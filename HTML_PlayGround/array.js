const users=[
    {
      id:1,
      name:"jack",
      isActive:true,
      age:20
    },
    {
        id:2,
        name:"sami",
        isActive:true,
        age:18
    },
    {
        id:3,
        name:"waleed",
        isActive:false,
        age:30
    }
];

// users.sort((a,b) => b.age - a.age);
// let names= users.map(user => user.age);
// console.log("names = ", names);



// let searchResult = users.filter(u => u.id === 3);
// console.log({"searchResult":searchResult,"users":users});

// let names=["a","b","c","a"];
// let numbers=[10,1,6,35,15];

// const removeRepeat = (arr) => {
//     return [... new Set(arr)];
// }; 

//  const sorted =numbers.sort((a,b) => {
//     return a<b ? 1 : - 1;
//  });
// console.log(sorted);

function arrayMap(){
    //Map return new Array , not reference affect on orignal array
    let newUsers = users.map(u => u.id === 3 ? {...u,name:"GAZA! Live"} : u);
    console.log({old:users, new: newUsers});
}

function arrayFilter(){
    //Filer return new array , not affect on source array reference
    const words = ['spray', 'elite', 'exuberant', 'destruction', 'present'];
    const result = words.filter((word) => word.length > 6);
    result[0]="mahmoud";
    console.log("arrayFilter()",{word:words, resultFilter: result});
// Expected output: Array ["exuberant", "destruction", "present"]
}

function arraySlice(){
    //array of primitve string values
    const dogsNames =["max", "blue", "lio","trex", "dark", "spark"];
    //slice return 'Shallow Copy' new array ,
    //  affect on source array reference but not affected on source array if that array of primitives
            //(string, boolean , number, ...etc)
    //get from start 0 to end 2 index, 2 index value not included
    let sliceResult = dogsNames.slice(0,2);
    // output:['max','blue']
    sliceResult[0]="julia";
    console.log("arraySlice()",{source:dogsNames,result:sliceResult});
}

function arraySplice(){
    const dogsNames =["max", "blue", "lio","trex", "dark", "spark"];
    //splice return new array deleted from the source 
    //third argument to add or replace item depend on deleteCount(2th argument) '0:add' '>0:replace'
    //not affect on source array reference
    //start from 0 index and delete count number 3 items, start index value included
    let spliceResult = dogsNames.splice(0,3);
    console.log('spliceResult',spliceResult);
    // output:['max','blue','lio']

    spliceResult[0]="julia";
    // output:['julia','blue','lio']

    // add new item 'yellow' before  index 1 'blue'
    spliceResult.splice(1,0,'yellow');
    console.log(`spliceResult: add 'yellow'`,spliceResult);
    // output:['julia','yellow','blue','lio']

     // replace  index 1 value from 'blue' to 'yellow'
     spliceResult.splice(1,1,'green');
     console.log(`spliceResult: 'yellow' to 'green'`,spliceResult);
     // output:['julia','green','blue','lio']
    
    console.log("arraySplice()",{source:dogsNames,result:spliceResult});
}

function sortArrayUsers(){
    //sort affect on source object ' users Array', even if you donot open the object in brwoser console
    //will affect on the it's values, but open it first before sort run, to see original state values 
    console.log({fun:'sortArrayUsers',users:users});
    let order = 'desc';
    let result = [];
    setTimeout(()=>{
        if(order === 'asc')
            //    result = users.sort((a,b) => {return a.age > b.age ? 1 :-1;});
               users.sort((a,b) => a.age > b.age ? 1 : -1);
            else
               users.sort((a,b) => a.age > b.age ? -1 : 1);
        
             console.log({fun:'sortArrayUsers',users:users});
        console.log("delay...end")
    },5000);
    
}