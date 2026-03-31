import './App.css'
import Gallery,{Profile} from './components/Gallery'
import Avatar from './components/Avatar';
import ProfileProps from './components/ProfileProps';


function App() {
  return (
    <>
      <Gallery/>
      <Profile/>
      <hr/>
      <Avatar/>
      <hr/>
      <ProfileProps/>
      <hr/>
      
    </>
  );
}



export default App
