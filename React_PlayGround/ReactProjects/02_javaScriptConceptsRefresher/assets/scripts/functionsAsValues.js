export const implement = () =>{
    function greeter(greetFn){
        greetFn();
    }
    greeter(() => console.log('Hi!'));

    function handleTimeOut(){
        console.log('Timed out!');
    }
    const handleTimeOut2 = ()=>{
        console.log('Timed out ... again!');
    };
    setTimeout(handleTimeOut,2000);
    setTimeout(handleTimeOut2,3000);
    setTimeout(() =>{
        console.log('More Timing out...');
    },4000);
}

//Error:Uncaught ReferenceError: handleTimeout is not defined
//#it's accessible/defined or scoped inside 'implement' function not out side it
//handleTimeout();
