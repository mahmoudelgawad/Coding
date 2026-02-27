export default function Avatar(){
    const srcURL = "/abdelwahed-elwakil-architect.PNG"
    const name="Abdelwahed Elwakil"
    const today = new Date();

    //#alternative use single object
    const person={
        name:"Abdelwahed Elwakil",
        theme: {backgroundColor:'black',color:'pink'}
    };

    return(
    <>
    <h1>Avatar Component</h1>
        <img
          className="avatar"
          src="/abdelwahed-elwakil-architect.PNG"
          alt="Abdwahed Elwakil"  
        />

        <img
        className="avatar" 
        src={srcURL}
        alt={name}
        />
        <h2>{person.name} , Architect </h2>
        <h6>{formatDate(today)}</h6>
        <h3 style={{backgroundColor:'darkgray',color:'pink'}}>He is re-alive the islamic buildings</h3>
        <h3 style={person.theme}>Professional in Islamic Legacy build with blocks  </h3>
    </>
    )

    function formatDate(date:Date){
       return Intl.DateTimeFormat(
            'en-US',
            {weekday:'long'}
        ).format(date);
    }
}