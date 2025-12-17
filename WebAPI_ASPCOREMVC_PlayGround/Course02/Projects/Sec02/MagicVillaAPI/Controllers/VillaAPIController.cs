using MagicVillaAPI.CustomLogging;
using MagicVillaAPI.Data;
using MagicVillaAPI.Models;
using MagicVillaAPI.Models.DTO;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace MagicVillaAPI.Controllers
{
    //#for binding first part name of controller 'VillaAPI' 
    //[Route("api/[controller]")]
    [Route("api/villaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        //#default MS Logger
        readonly private ILogger<VillaAPIController> _logger;

        //#SegriLog Logger
        // readonly private ILogger _logger;

        //#custom logging
        //readonly private ILogging _logger;

        //#default MS Logger
        //public VillaAPIController(ILogger<VillaAPIController> logger)
        
        //for SeriLog or Custom Loggin
        //public VillaAPIController(ILogger logger)

        readonly private ApplicationDBContext _db;
        public VillaAPIController(ILogger<VillaAPIController> logger, ApplicationDBContext dbcontext) 
        {
            _logger = logger;
            _db = dbcontext;
        }

        /*
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas() 
        {
            return VillaStore.villas;
        }
  
        [HttpGet("{id:int}")]
        public VillaDTO? GetVilla(int id) 
        {
            return VillaStore.villas.FirstOrDefault(v => v.ID == id);
        }
        */

        //#using ActionResult:IActionResult
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            _logger.LogInformation("Return All Villas");
            //return Ok(VillaStore.villas);
            return Ok(_db.Villas.ToList());
        }

        [HttpGet("{id:int}", Name = "GetVilla")]
        //# attribute for swagger documentation
        //[ProducesResponseType(200,Type = typeof(VillaDTO))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            //#validation
            if (id == 0) 
            {
                _logger.LogError($"Wrong Villa ID = {id}");
                return BadRequest();
            }

            var villa = _db.Villas.FirstOrDefault(v => v.ID == id);

            if (villa == null) return NotFound();

            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villaDTO)
        {
            //#validations
            //#apply data annotation validation
            if (!ModelState.IsValid) return BadRequest(ModelState); //400 code
            if (villaDTO == null) return BadRequest(villaDTO);
            if (villaDTO.ID > 0) return StatusCode(StatusCodes.Status500InternalServerError);
            //#cusomt validation allready exist villa name
            if (_db.Villas.FirstOrDefault(v => v.Name.ToLower() == villaDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomValidation", "Villa Name Already Exist");
                return BadRequest(ModelState);
            }

            villaDTO.ID = _db.Villas.OrderByDescending(v => v.ID).FirstOrDefault().ID + 1;
            var newVilla = Map(villaDTO);
            newVilla.CreatedDate = DateTime.Now;
            _db.Villas.Add(newVilla);
            _db.SaveChanges();

            //#return 200 : OK
            //return Ok(villaDTO);

            //#return 201: created
            //#return genrate link of 'GetVilla' API end point with id parameter, and body with villaDTO
            /* RESPONSE
             content-type: application/json; charset=utf-8
             location: https://localhost:44326/api/villaAPI/3
             server: Microsoft-IIS/10.0
             x-powered-by: ASP.NET
             date: Fri, 31 Oct 2025 17:31:47 GMT
            */
            return CreatedAtRoute("GetVilla", new { id = newVilla.ID }, villaDTO);

        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public ActionResult DeleteVilla(int id)
        {
            if (id == 0) return BadRequest();
            var villa = _db.Villas.FirstOrDefault(v => v.ID == id);
            if (villa == null) return NotFound();
            _db.Villas.Remove(villa);
            _db.SaveChanges();
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id:int}",Name ="UpdateVilla")]
        public ActionResult UpdateVilla(int id, [FromBody] VillaDTO villaDto) 
        {
            if (villaDto == null || id != villaDto.ID) return BadRequest();
            //var villa = _db.Villas.FirstOrDefault(v => v.ID == id);
            //if (villa == null) return NotFound();
            var updatedVilla = Map(villaDto);

            //#automatic update
            _db.Villas.Update(updatedVilla);
            _db.SaveChanges();
            return NoContent();
        }


        [ProducesResponseType(StatusCodes.Status204NoContent)] 
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        public ActionResult UpdatePartialVilla(int id,[FromBody]JsonPatchDocument<VillaDTO> patchVillaDto)
        {
            if (patchVillaDto == null || id == 0) return BadRequest();
            //var villa = _db.Villas.FirstOrDefault(v => v.ID == id);
            //# to fix 2 tracked error update in savechanges
            var villa = _db.Villas.AsNoTracking().FirstOrDefault(v => v.ID == id);
            if (villa == null) return BadRequest();
            var newVillaDTO = Map(villa);
            patchVillaDto.ApplyTo(newVillaDTO,ModelState);
            //#will fail because 2 villa instance with same id tracked
            //#because 'new' keyword so use 'AsNoTracking()'
            var updatedVilla = Map(newVillaDTO);
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _db.Villas.Update(updatedVilla);
            _db.SaveChanges();
            return NoContent();
        }

        private Villa Map(VillaDTO villaDto) 
        {
            return new Villa
            {
                ID = villaDto.ID,
                Name = villaDto.Name,
                Details = villaDto.Details,
                AreaSqft = villaDto.AreaSqft,
                ImageUrl = villaDto.ImageUrl,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                Amenity = villaDto.Amenity,
            };
        }

        private VillaDTO Map(Villa villa)
        {
            return new VillaDTO
            {
                ID = villa.ID,
                Name = villa.Name,
                Details = villa.Details,
                AreaSqft = villa.AreaSqft,
                ImageUrl = villa.ImageUrl,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                Amenity = villa.Amenity
            };
        }
    }
}
