import logo from './logo.svg';
import './App.css';
import { ListNames } from './list-names/ListNames';

function App() {
  const names=["mahmoud","Sonwar","Sami","jacop"];
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
      <p>my new code</p>
      {ListNames(names)}
    </div>
  );
}

export default App;
