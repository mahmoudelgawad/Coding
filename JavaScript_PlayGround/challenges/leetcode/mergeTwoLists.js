import { ListNode,printListNode } from "./ListNode";

/**
 * @param {ListNode} list1 
 * @param {ListNode} list2 
 * @returns {ListNode}
 */
const mergeTwoLists = function(list1, list2) {
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



console.time();
let list1=new ListNode(1,new ListNode(2,new ListNode(4)));
let list2=new ListNode(1,new ListNode(3,new ListNode(4)));
let testCase = {list1,list2};
 console.log({value:testCase, result:printListNode(mergeTwoLists(list1,list2))});

list1=null;
list2=new ListNode(1,new ListNode(3,new ListNode(4)));
testCase = {list1,list2};
 console.log({value:testCase, result:printListNode(mergeTwoLists(list1,list2))});

console.timeEnd();
