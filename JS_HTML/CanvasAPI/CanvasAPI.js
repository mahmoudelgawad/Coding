// const divElm = document.getElementById("imageCanvasContainer");
const canvas = document.getElementById("canvas");
const ctx = canvas.getContext("2d");

const imgElm = document.getElementById('imgCar');
if(imgElm){

 imgElm.addEventListener("load",(event) =>{
    ctx.drawImage(imgElm, 50, 50);
 });
}
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

    console.log({x:x,y:y});

    drawPoint(x,y);

}



function drawPoint(x,y){
const ctx = canvas.getContext("2d");


ctx.beginPath();
ctx.arc(x, y, 10, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();

}