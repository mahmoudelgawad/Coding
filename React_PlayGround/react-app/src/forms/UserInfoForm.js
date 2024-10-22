export  function UserInfoForm(){

    function displayName(formData){
        console.log('test manually');
        alert(formData.get('name'));
    }

    return(
        <form action={displayName}>

        <p>
        <label>Name</label>
        <input type="text" name="name"/>
        </p>

        <p>
        <label>Age</label>
        <input type="number" name="age"/>
        </p>

        <p>
        <label>Address</label>
        <input type="text" name="address"/>
        </p>

        <p>
           <button type="submit">Show</button>
        </p>

        </form>
    );
}