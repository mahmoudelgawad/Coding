using MagicVillaAPI.Data;
using MagicVillaAPI.Models;
using MagicVillaAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace MagicVillaAPI.Controllers
{
    //#for binding first part name of controller 'VillaAPI' 
    //[Route("api/[controller]")]
    [Route("api/villaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
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
            return Ok(VillaStore.villas);
        }

        [HttpGet("{id:int}",Name ="GetVilla")]
        //# attribute for swagger documentation
        //[ProducesResponseType(200,Type = typeof(VillaDTO))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            //#validation
            if (id == 0) return BadRequest();

            var villa =  VillaStore.villas.FirstOrDefault(v => v.ID == id);

            if (villa == null) return NotFound();

            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDTO> CreateVilla([FromBody]VillaDTO villaDTO) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (villaDTO == null) return BadRequest(villaDTO);
            if (villaDTO.ID > 0) return StatusCode(StatusCodes.Status500InternalServerError);
            villaDTO.ID = VillaStore.villas.OrderByDescending(v => v.ID).FirstOrDefault().ID + 1;
            VillaStore.villas.Add(villaDTO);

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
            return CreatedAtRoute("GetVilla",new{ id = villaDTO.ID},villaDTO);

        }
    }
}
