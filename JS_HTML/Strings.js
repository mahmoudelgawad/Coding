function checkStringIncludes(mark){
    let str = "Mahmoud Ahmed";
    console.log({isContainMark:str.includes(mark)})
}

function substringGetNumberPart()
{
  let str = "md-15";
  //# 'string.length' not include '0', start with '1'
  let result =str.substring(str.indexOf("-")+1,str.length);
  console.log({function :'substringGetNumberPart',result:result});
}

//checkStringIncludes('?');
substringGetNumberPart();