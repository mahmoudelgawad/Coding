import {useState} from 'react'
import Header from './components/Header/Header.jsx';
import CoreConcept from './components/CoreConcept.jsx';
import TabButton from './components/TabButton.jsx';

import imgConc1 from './assets/react-core-concepts.png'
import {CORE_CONCEPTS} from './data.js';


function App() {
  //#must use 'useState' with component function and in the top of it,it alwyas return array with2 values
  const [stringValue,onUpdateStringValueState] = useState('Initial Value - Please Select Press button');
  //#deprectaed
  //let stringValue = 'Please Select Press button';
      function onHandleSelect(selectedValue){
        onUpdateStringValueState(`You Select -> ${selectedValue}`);
        //#deprecated
        //stringValue = selectedValue;
        console.log(`You Select -> ${selectedValue}`);
    }
    console.log('App Component Will Render');
  return (
    <div>
      <Header/>
      <main>
        <section id="core-concepts">
          <h2>Core Concepts</h2>
          <ul>
            {/* <CoreConcept img={imgConc1} title="test title" desc="test description"/> */}
            <CoreConcept {...CORE_CONCEPTS[0]}/>
            <CoreConcept {...CORE_CONCEPTS[1]}/>
            <CoreConcept {...CORE_CONCEPTS[2]}/>
            <CoreConcept {...CORE_CONCEPTS[3]}/>
          </ul>
        </section>
        <section id="examples">
          <h2>Examples</h2>
          <menu>
            <TabButton onSelect={()=>onHandleSelect('Components')}>Components</TabButton>
            <TabButton onSelect={()=>onHandleSelect('Jsx')}>Jsx</TabButton>
            <TabButton onSelect={()=>onHandleSelect('Props')}>Props</TabButton>
            <TabButton onSelect={()=>onHandleSelect('State')}>State</TabButton>
          </menu>
        </section>
      </main>
      {/* this will not changed automatically , you have to import and use react 'useState'  */}
      {stringValue}
    </div>
  );
}



export default App;
