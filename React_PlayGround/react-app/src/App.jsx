import {useState} from 'react'
import Header from './components/Header/Header.jsx';
import CoreConcept from './components/CoreConcept.jsx';
import imgConc1 from './assets/react-core-concepts.png';
import Examples from './components/Examples.jsx'
import {CORE_CONCEPTS} from './data.js';


function App() {  
    console.log('App Component Will Render');
  return (
    <div>
      <Header/>
      <main>
        <section id="core-concepts">
          <h2>Core Concepts</h2>
          {/* <ul>
            <CoreConcept img={imgConc1} title="test title" desc="test description"/>
          </ul> */}

          {/* <ul>
            <CoreConcept {...CORE_CONCEPTS[0]}/>
            <CoreConcept {...CORE_CONCEPTS[1]}/>
            <CoreConcept {...CORE_CONCEPTS[2]}/>
            <CoreConcept {...CORE_CONCEPTS[3]}/>
          </ul> */}

          {CORE_CONCEPTS.map(c => {
            <CoreConcept {...c}/>
          })}
        </section>
        <section id="examples">
          <Examples/>
        </section>
      </main>
    </div>
  );
}



export default App;
