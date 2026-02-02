import './App.css'
const imgStyle = {
  width:"250px",
  hight:"250px"
};

function Profile(){
 return(
  <img
    src="https://axrzaord1cno.compat.objectstorage.me-jeddah-1.oraclecloud.com/new_assets/Areas/2512202333122211.webp"
    alt="First Mosque In Islam"
    style={imgStyle}
  />
 );
}

function App() {

  return (
    <section>
      <h1>First Mosque</h1>
      <Profile />
      <Profile />
      <Profile />
    </section>
  );
}

export default App
