import './Header.css'
import headerImage from '../../assets/react-core-concepts.png'
const descriptions = ["Fundamental","Crucial","Core"]

function getRandomNum(max){
  return Math.floor(Math.random() * (max + 1));
}


export default function Header() {
  const desc = descriptions[getRandomNum(2)];
  return (
    <header>
      {/* <img src="src/assets/react-core-concepts.png" alt="Stylized atom" /> */}
      <img src={headerImage} alt="stylized atom"/>
      <h1>React Essentials</h1>
      <p>
        {desc} React concepts you will need for almost any app you are
        going to build!
      </p>
    </header>
  );
}