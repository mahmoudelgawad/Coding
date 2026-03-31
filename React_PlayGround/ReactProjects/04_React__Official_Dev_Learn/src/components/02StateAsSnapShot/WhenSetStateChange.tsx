export default function WhenSetStateChange(){
    return(
        <>
            <h2>When SetState Change the state variable:</h2>
            <h3>Section:</h3>
            <p>when we call the setter function to change specific state variable </p>
            <p>it's not change immediately but changed the state value for next snapshot render, 
                not current state snapshot 
            </p>
            <a href="https://codesandbox.io/p/sandbox/react-dev-whensetstatechange-hqy5x5">Source Code</a>
        </>
    ); 
}