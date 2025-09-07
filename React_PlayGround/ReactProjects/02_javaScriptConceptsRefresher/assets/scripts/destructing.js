export const createDestructing = () =>{
    //#array
    //#destructing is shortcut for accessing/pull out array elements by index
    /*
    const arr = ["Mahmoud","41"];
    const username = arr[0];
    const age = arr[1];
    */
    const [username, age] = ["Mahmoud","41"];
    console.log({username:username,age:age});

    //#Object
    //#you have to use same keys in object, or give alias name as {person:personAliasName,amount}
    const {person:personName,amount} = {
        person:"Kader",
        amount:20
    }
    console.log({personName:personName,amount:amount});
    
    //#function destructing
    const storeOrder = (order)=>{
        localStorage.setItem('id',order.id);
        localStorage.setItem('currency',order.currency);
    }
    const setOrder_Desctructing = ({id,currency}) =>{
        localStorage.setItem('id',id);
        localStorage.setItem('currency',currency);
    }
}