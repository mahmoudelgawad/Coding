export default function StateWithAwaitPromise(){
    return(
        <>
            <h2>When press 'Buy' button multiple times :</h2>
            <h3>Problem Challeng 1:</h3>
            <p>it call updater function to increment the pending state and create Promise object,
                with 'await' for delay 'setTimeout(3000)' (3 seconds), then increment pending state, then increment completed state 
            </p>

            <a href="https://codesandbox.io/p/sandbox/react-dev-statewithawaitpromise-mcnfg2">Source Code</a>
        </>
    ); 
}