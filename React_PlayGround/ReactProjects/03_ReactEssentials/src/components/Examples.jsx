import { useState } from 'react';
import TabButton from './TabButton.jsx';
import { EXAMPLES } from '../data.js';
export default function Examples()
{
    //#must use 'useState' with component function and in the top of it,it alwyas return array with2 values
    //const [stringValue,onSetStateActionNewStringValue] = useState('Initial Value - Please Select Press button');
    const [stringValue, onSetStateActionNewStringValue] = useState();
    //#deprectaed
    //let stringValue = 'Please Select Press button';
    function onHandleSelect(selectedValue) {
        onSetStateActionNewStringValue(selectedValue);
        //#deprecated
        //stringValue = selectedValue;
        console.log(`You Select -> ${selectedValue}`);
    }

    let tabContent = <p>Please select content Example ...</p>
    if (stringValue)
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
    console.log('Examples component will return');
    return (
        <>
          <h2>Examples</h2>
          <menu>
            <TabButton isSelected={stringValue === 'components'} onSelect={()=>onHandleSelect('components')}>Components</TabButton>
            <TabButton isSelected={stringValue === 'jsx'} onSelect={()=>onHandleSelect('jsx')}>Jsx</TabButton>
            <TabButton isSelected={stringValue === 'props'} onSelect={()=>onHandleSelect('props')}>Props</TabButton>
            <TabButton isSelected={stringValue === 'state'} onSelect={()=>onHandleSelect('state')}>State</TabButton>
          </menu>
            {tabContent}

            {/* this will not changed automatically , you have to import and use react 'useState'  */}
            {stringValue}
        </>
    );
}