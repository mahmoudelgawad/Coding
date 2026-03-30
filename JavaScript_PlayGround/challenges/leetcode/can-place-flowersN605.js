//https://github.com/google/closure-compiler/wiki/Annotating-JavaScript-for-the-Closure-Compiler
//#Annotation for javascript google clouser compiler
//#apply only on variable function
/**
 * @param {number[]} flowerbed
 * @param {number} n
 * @return {boolean}
 */
const canPlaceFlowers = function(flowerbed, n) {
	if(n < 0 || flowerbed.length === 0) return false;
	let av = 0;
	for(let i = 0; i<flowerbed.length ;i++)
		if(flowerbed[i]===0 &&
		   (
		    (i === 0 && i === flowerbed.length - 1) ||
			(i === 0 && flowerbed[i+1] === 0) ||
			(i === flowerbed.length-1 && flowerbed[i-1] === 0) ||
			(i!== 0 && i !== flowerbed.length -1 && flowerbed[i+1] === 0 && flowerbed[i-1] === 0) 	
		   ) 	
		  )
		{
		 ++av;
		 flowerbed[i] = 1;	
		}
	return av >= n;
};


let flowerbed=[1,0,0,0,0,1];
console.time();
console.log({result:canPlaceFlowers(flowerbed,2) === false ? 'OK' : 'NO!'});
console.timeEnd();

flowerbed=[0];
console.time();
console.log({result:canPlaceFlowers(flowerbed,1) === true ? 'OK' : 'NO!'});
console.timeEnd();

flowerbed=[0,1,0];
console.time();
console.log({result:canPlaceFlowers(flowerbed,1) === false ? 'OK' : 'NO!'});
console.timeEnd();
