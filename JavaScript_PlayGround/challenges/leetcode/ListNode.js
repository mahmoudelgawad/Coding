/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 *
 * 
 * 
 * When a function is called with the new keyword in JavaScript, the this inside that function (which is acting as a constructor) references a newly created instance object [1, 2]. 
   Here is what happens during this process:
    1- A new object is created: An empty, plain JavaScript object is created in memory.
    2- this is bound: The this keyword within the constructor function is automatically bound to this brand-new object.
    3- Prototype linking occurs: The new object is linked to the constructor function's prototype property, enabling inheritance of methods [2].
    4- The constructor executes: The code within the constructor function runs, typically adding properties and methods to the this object.
    5- The new object is returned: If the constructor function does not explicitly return its own object, the newly created this object is implicitly returned [1, 2]. 
 */
/**
 * @param {ListNode} list1
 * @param {ListNode} list2
 * @return {ListNode}
 */
export function ListNode(val, next) {
    this.val = (val===undefined ? 0 : val)
    this.next = (next===undefined ? null : next)
}

export const printListNode = (result=new ListNode())=>{
    let obj=[];
    if(!result) return obj;
    while(result)
        {
            obj.push(result.val);
            result = result.next;
        }
    return obj;    
};