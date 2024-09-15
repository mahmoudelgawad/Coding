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
    const dogsNames =["max", "blue", "lio","trex", "dark", "spark"];
    //slice return new array , not affect on source array reference
    //get from start 0 to end 2 index, 2 index value not included
    let sliceResult = dogsNames.slice(0,2);
    // output:['max','blue']
    sliceResult[0]="julia";
    console.log("arraySlice()",{source:dogsNames,result:sliceResult});
}

function arraySplice(){
    const dogsNames =["max", "blue", "lio","trex", "dark", "spark"];
    //splice return new array deleted from the source 
    //third argument to add or replace item depend on deleteCount '0:add' '>0:replace'
    //not affect on source array reference
    //start from 0 index and delete count number 3 items, start index value included
    let spliceResult = dogsNames.splice(0,3);
    console.log('spliceResult',spliceResult);
    // output:['max','blue','lio']

    spliceResult[0]="julia";
    // output:['julia','blue','lio']

    // add new item 'yellow' before  index 1 'blue'
    spliceResult.splice(1,0,'yellow')
    console.log(`spliceResult: add 'yellow'`,spliceResult);
    // output:['julia','yellow','blue','lio']

     // replace  index 1 value from 'blue' to 'yellow'
     spliceResult.splice(1,1,'green')
     console.log(`spliceResult: 'yellow' to 'green'`,spliceResult);
     // output:['julia','green','blue','lio']
    
    console.log("arraySplice()",{source:dogsNames,result:spliceResult});
}


//named function
function funTestOne(){
    console.log("funTestOne()");
    document.writeln("funTestOne()");
}


function spreadOperator(){
    const obj1 ={prop1:1};
    const obj2 = obj1; //point to same reference
    const obj3={...obj1};
    obj2.prop1=2; //change affect on obj1 reference value
    console.log({obj1:obj1, obj2:obj2, obj3:obj3});
}

function HoistingVar(){
    function fun(){
        console.log({'Top HoistingVar().fun() -> I value':i});
        var arr = [];
        for(var i = 0;i<10;i++){
            arr[i]=function(){return i;}
        }
        console.log({'HoistingVar().fun() -> I value':i});
        return arr;
    }
    // var i not defined here
    // console.log({'HoistingVar() -> I value':i});
    var arr2 = fun();
    console.log({arr2Elm5:arr2[5]()});  
}


function thisKeyWordWithObject(){

    let JSONObj = {
        name:'ebcell',
        func : function(){
            let self = this;
            console.log(this.name);
            console.log(self.name);
    
            /*()() this point to new object*/
            (function(){
                console.log(this.name === "");
                console.log(self.name);
            })();

            /*this point to new object*/
            // let fun = function(){
            //     console.log(this.name);
            //     console.log(self.name);
            // };
            // fun();
        

        /*this point to exist JSONObj object*/
        //    let fun = () =>{
        //          console.log(this.name);
        //         console.log(self.name);
        //     }
        //     fun();

        },
    };

    JSONObj.func();
}

function setTimeOutConsoleOrderCalls(){
    console.log(1);
    setTimeout(() =>{console.log(2)},1000);
    setTimeout(()=>{console.log(3)},0);
    console.log(4);
}

function generatorFunction(){

    function* geneFuncName(i){
        yield i;
        yield i+10;
        yield i+20
    }

    function* geneFuncNameWithReturn(i){
        yield i;
        return i+10;
        yield i+20; // unreachable Code
    }

    const gen = geneFuncName(5);
    console.log({yield1:gen.next().value,
                yield2:gen.next().value,
                yield3:gen.next().value});

    const genReturn = geneFuncNameWithReturn(5)
    console.log({yield1:genReturn.next(),
        return:genReturn.next(),
        yield2Unreachable:genReturn.next()});


}




////###############  Implementation   ##################
// call named function
//funTestOne();
//arrayMap();
//arrayFilter();
//arraySlice();
//arraySplice();
//spreadOperator();
//HoistingVar();
//thisKeyWordWithObject();
//setTimeOutConsoleOrderCalls();
generatorFunction();


