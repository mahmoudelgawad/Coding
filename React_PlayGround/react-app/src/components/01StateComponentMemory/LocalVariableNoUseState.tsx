export default function LocalVariableNoUseState(){
    return(
        <>
            <h2>Local Variable instead UseState:</h2>
            <h3>Section:</h3>
            <p>some times no need for 'useState', special in case with 'prompt()' </p>
            <p>it look like fire then not sync with return the intersted value from the user,
                so we use normal local variable 'let name = prompt()' instead 'useState' in this case
            </p>
            <a href="https://codesandbox.io/p/sandbox/react-dev-letnameinsteadusestate-xkjrvw">Source Code</a>
        </>
    ); 
}