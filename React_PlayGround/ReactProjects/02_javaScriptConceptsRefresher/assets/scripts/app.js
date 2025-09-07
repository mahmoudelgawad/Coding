//#you have import with '.js' extension file
import { apiKey,abc as abcAlias } from "./util.js";
import * as util from './util.js';
import defaultKey from './util.js';
import * as helper from './helper.js';
import * as arrays from './array.js';
import * as destructing from './destructing.js';
import * as spreadOperator from './spread_operator.js';
import * as controlStructures from './conditionsAndLoop.js';
import * as manipulatingDOM from './manipulatingTheDOM.js';
import * as functionsAsValues from './functionsAsValues.js'

console.log({key:apiKey});
//#error now abc has alias name
// console.log({abc:abc});
console.log({abcalias:abcAlias});
console.log({util_abc:util.abc});
console.log({defaultKey:defaultKey});

helper.createUserJSON();
helper.createUserClass();

arrays.arrayFunctions();

destructing.createDestructing();

spreadOperator.implementSpreadOperator();

controlStructures.implement();

manipulatingDOM.implement();

functionsAsValues.implement();