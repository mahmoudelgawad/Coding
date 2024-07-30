
// users.sort((a,b) => b.age - a.age);
// let names= users.map(user => user.age);
// console.log("names = ", names);

// let names=["a","b","c","a"];
// let numbers=[10,1,6,35,15];

// const removeRepeat = (arr) => {
//     return [... new Set(arr)];
// }; 

//  const sorted =numbers.sort((a,b) => {
//     return a<b ? 1 : - 1;
//  });
// console.log(sorted);



////###############  filter   ##################
const words = ['spray', 'elite', 'exuberant', 'destruction', 'present'];

const result = words.filter((word) => word.length > 6);
result[0]="mahmoud";
console.log(result);
console.log(words);
// Expected output: Array ["exuberant", "destruction", "present"]

//named function
function funTestOne(){
    console.log("funTestOne()");
    document.writeln("funTestOne()");
}
// call named function
funTestOne();

