import LocalVariableNoUseState from "./LocalVariableNoUseState";
import UseStateForIndex from "./UseStateForIndex";

export default function StateComponentMemory(){
    return(
        <>
         <h1>State A component's memory:</h1>
         <a href="https://react.dev/learn/state-a-components-memory">Official React Dev Link</a>
         <hr/>
         <UseStateForIndex/>
         <hr/>
         <LocalVariableNoUseState/>
        </>
    );
}