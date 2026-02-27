import { getImageUrl } from "./utils";

export function Avatar({person,size}:any){
    return(
        <img
            src={getImageUrl(person)}
            alt={person.name}
            width={size}
            height={size} 
        />
    );
}

export default function ProfileProps(){
    return(
        <div>
            <Avatar 
            size={100} 
            person={{
                name:'Apple',
                imageId:'apple'
            }}/>
        
            <Avatar 
            size={80} 
            person={{
                name:'Orange',
                imageId:'orange'
            }}/>

            <Avatar 
            size={50} 
            person={{
                name:'Strawberry',
                imageId:'strawberry'
            }}/>
        </div>
    );
}