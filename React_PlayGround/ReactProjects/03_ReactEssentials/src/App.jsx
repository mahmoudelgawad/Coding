import {useState} from 'react'
import Header from './components/Header/Header.jsx';
import CoreConcept from './components/CoreConcept.jsx';
import TabButton from './components/TabButton.jsx';

import imgConc1 from './assets/react-core-concepts.png'
import {CORE_CONCEPTS, EXAMPLES} from './data.js';


function App() {
  //#must use 'useState' with component function and in the top of it,it alwyas return array with2 values
  //const [stringValue,onSetStateActionNewStringValue] = useState('Initial Value - Please Select Press button');
  const [stringValue,onSetStateActionNewStringValue] = useState();
  //#deprectaed
  //let stringValue = 'Please Select Press button';
      function onHandleSelect(selectedValue){
        onSetStateActionNewStringValue(selectedValue);
        //#deprecated
        //stringValue = selectedValue;
        console.log(`You Select -> ${selectedValue}`);
    }

    let tabContent = <p>Please select content Example ...</p>
    if(stringValue)
      tabContent = (
        <div id="tab-content">
            <h3>{EXAMPLES[stringValue]?.title}</h3>
            <p>{EXAMPLES[stringValue]?.description}</p>
            <pre>
              <code>{EXAMPLES[stringValue]?.code}</code>
            </pre>
          </div>
      );

    console.log(`stringValue =  ${stringValue}`);
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
          <h2>Examples</h2>
          <menu>
            <TabButton isSelected={stringValue === 'components'} onSelect={()=>onHandleSelect('components')}>Components</TabButton>
            <TabButton isSelected={stringValue === 'jsx'} onSelect={()=>onHandleSelect('jsx')}>Jsx</TabButton>
            <TabButton isSelected={stringValue === 'props'} onSelect={()=>onHandleSelect('props')}>Props</TabButton>
            <TabButton isSelected={stringValue === 'state'} onSelect={()=>onHandleSelect('state')}>State</TabButton>
          </menu>
          {tabContent}
        </section>
      </main>
      {/* this will not changed automatically , you have to import and use react 'useState'  */}
      {stringValue}
    </div>
  );
}



export default App;
