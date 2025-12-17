//https://github.com/google/closure-compiler/wiki/Annotating-JavaScript-for-the-Closure-Compiler
//#Annotation for javascript google clouser compiler
//#apply only on variable function

import { ListNode, printListNode } from "./ListNode.js";

/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
const addTwoNumbers = function(l1, l2) {
    return addTwoNumbersRec(l1,l2);
};

/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @param {number} carry
 * @return {ListNode}
 */
const addTwoNumbersRec = function(l1, l2, carry = 0) {
    if(!l1 && !l2 && carry === 0) return null;
    let total = (!l1 ? 0 : l1.val) + (!l2 ? 0 : l2.val) + carry;
    carry = Math.trunc(total / 10);
    return new ListNode(total%10, addTwoNumbersRec(l1?.next,l2?.next,carry));
};


let l1 = new ListNode(2,new ListNode(4,new ListNode(3,null)));
let l2 = new ListNode(5,new ListNode(6,new ListNode(4,null)));

let testCase = {l1,l2};
console.time();
console.log({value:testCase, result:addTwoNumbers(l1,l2)});
console.timeEnd();
//testCase="()";
