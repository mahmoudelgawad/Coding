/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 * When a function is called with new, the this inside it references the instance being created 
 * (an object whose internal prototype is the .prototype of the function),
 * rather than the globalThis / undefined in strict mode.
 * (There's nothing on the prototype here.)
 */
/**
 * @param {ListNode} list1
 * @param {ListNode} list2
 * @return {ListNode}
 */
function ListNode(val, next) {
    this.val = (val===undefined ? 0 : val)
    this.next = (next===undefined ? null : next)
}
var mergeTwoLists = function(list1, list2) {
  if(!list1) return list2;
  if(!list2) return list1;
  if(list1.val < list2.val){
        list1.next = mergeTwoLists(list1.next, list2)
        return list1;
    }
    else{
        list2.next = mergeTwoLists(list1,list2.next);
        return list2;
    }  
};

var printResult = (result=new ListNode())=>{
    let obj=[];
    if(!result) return obj;
    while(result)
        {
            obj.push(result.val);
            result = result.next;
        }
    return obj;    
};

console.time();
let list1=new ListNode(1,new ListNode(2,new ListNode(4)));
let list2=new ListNode(1,new ListNode(3,new ListNode(4)));
let testCase = {list1,list2};
 console.log({value:testCase, result:printResult(mergeTwoLists(list1,list2))});

list1=null;
list2=new ListNode(1,new ListNode(3,new ListNode(4)));
testCase = {list1,list2};
 console.log({value:testCase, result:printResult(mergeTwoLists(list1,list2))});

console.timeEnd();
