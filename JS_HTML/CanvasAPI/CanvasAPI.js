// const divElm = document.getElementById("imageCanvasContainer");
const canvas = document.getElementById("canvas");
const ctx = canvas.getContext("2d");

const imgElm = document.getElementById('imgCar');
if(imgElm){
 imgElm.addEventListener("load",(event) =>{
    ctx.drawImage(imgElm, 50, 50);
 });
}
var pointerCounter = 0;
var points = [];
// canvas.style.position = "absolute";
// canvas.style.top = divElm.offsetTop;
// canvas.style.left = divElm.offsetLeft;
//canvas.style.backgroundImage = "url('CanvasAPI/CarDiagaram.png')";
canvas.width = 708;
canvas.height = 461;

if(canvas){
    canvas.addEventListener("click",divImagePointsCanvasAPI,true);
}

function divImagePointsCanvasAPI(event){
    console.log({divImagePointsCanvasAPI:{event:event}});
    const x = event.offsetX;
    const y = event.offsetY;
    drawPoint(x,y);
}



function drawPoint(x,y){
const ctx = canvas.getContext("2d");

ctx.beginPath();
ctx.arc(x, y, 15, 0, 2 * Math.PI);
ctx.fillStyle="black";
ctx.fill();
++pointerCounter;


ctx.fillStyle="white";
ctx.font="17px arial bold ";
ctx.textAlign="center";
ctx.fillText(`${pointerCounter.toString()}`,x , y+3);


points.push({x:x,y:y,id:pointerCounter,comment:""});
console.log(points)
drawNewDamageDetailsRow({id:pointerCounter})
}

function onCommentChange(e){
    console.log(e);
   let id =e.currentTarget.id;
   id =id.substring(id.indexOf("-")+1,id.length);
   let comment = $(this).val();
   console.log({id:id,comment:comment}); 
   points = points.map(p => p.id === Number(id) ? {...p,comment:comment} : p);
   console.log({points:points}); 
}

$(() =>{
    $('.damage-comment').on("change",onCommentChange);
});


function drawNewDamageDetailsRow(data){
    $("#InspectionsDamageGrid").append(`<div class="row border border-dark">
                <div class="col border border-dark">
                    <label id="dmgid-${data.id}">${data.id}</label>
                </div>
                <div class="col border border-dark">
                    <input id="dmgtype-${data.id}" type="text" value="" name="DamageType" readonly/>
                </div>
                <div class="col border border-dark">
                    <input id="dmgcom-${data.id}" class="damage-comment" type="text" value="" name="Comment" />
                </div>
            </div>`);
    $('.damage-comment').on("change",onCommentChange);
}

document.addEventListener('DOMContentLoaded',(elm,e)=>{
 
});