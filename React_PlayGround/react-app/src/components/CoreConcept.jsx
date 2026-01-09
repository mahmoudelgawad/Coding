/*
function CoreConcept(props){
  return(
    <li>
      <img src={props.img}/>
      <h3>{props.title}</h3>
      <p>{props.desc}</p>
    </li>
  );
}
*/
export default function CoreConcept({image,title,description}){
  return(
    <li>
      <img src={image}/>
      <h3>{title}</h3>
      <p>{description}</p>
    </li>
  );
}