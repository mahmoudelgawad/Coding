import math
from .module_list_node import ListNode

class AddTwoNumbersClass:
    
    def addTwoNumbers(self, l1: ListNode | None, l2: ListNode | None) -> ListNode | None:
        return self.addTwoNumbersRec(l1,l2)
    
    def addTwoNumbersRec(self,l1:ListNode,l2:ListNode,carry = 0) -> ListNode | None:
        if(l1 == None and l2 == None and carry == 0): return None
        total = (l1.val if l1 != None else 0) + (l2.val if l2 != None else 0) + carry
        #//or math.trunc(total/10)
        carry = int(total / 10)
        return ListNode(total%10, self.addTwoNumbersRec((l1.next if l1 != None else None),(l2.next if l2 != None else None), carry))

    @classmethod
    def implement(cls):
        l1 = ListNode(2,ListNode(4,ListNode(3)))
        l2 = ListNode(5,ListNode(6,ListNode(4)))    
        
        obj = AddTwoNumbersClass()
        result  = obj.addTwoNumbers(l1,l2)
        while(result != None):
            print(result.val,end='')
            result = result.next
        print()

        

    

        