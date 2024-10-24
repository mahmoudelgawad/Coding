import {useState} from 'react';

//https://www.freecodecamp.org/news/how-to-build-forms-in-react/
export  function UserInfoForm(){
    const [formData, setFormData] = useState({name:'',age:0,address:''});

    function handleChange(event){
        const {name, value} = event.target;
        setFormData((prevData) => ({...prevData,[name]:value}));
    }

    function handleSubmit(event){
        event.preventDefault();
        console.log(formData);
    }

   

    return(
        <form onSubmit={handleSubmit}>

        <p>
        <label>Name</label>
        <input type="text" name="name" value={formData.name} onChange={handleChange}/>
        </p>

        <p>
        <label>Age</label>
        <input type="number" name="age" onChange={handleChange}/>
        </p>

        <p>
        <label>Address</label>
        <input type="text" name="address" onChange={handleChange}/>
        </p>
        
        <p>
           {/* <button type="submit">Show</button> */}
           <input type="submit" value="Submit"/>
        </p>

        </form>
    );
}