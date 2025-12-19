import math
from module_list_node import ListNode

class AddTwoNumbersClass:

    def addTwoNumbers(self, l1: ListNode | None, l2: ListNode | None) -> ListNode | None:
        return self.addTwoNumbersRec(l1,l2)

    def addTwoNumbersRec(self,l1:ListNode,l2:ListNode,carry = 0) -> ListNode | None:
        if(l1 == None and l2 == None and carry == 0): return
        total = (l1.val if l1 != None else 0) + (l2.val if l2 != None else 0) + carry
        #//or math.trunc(total/10)
        carry = int(total / 10)
        return self.addTwoNumbersRec(l1.val or 0,l2.val or 0, carry)
        


    @staticmethod
    def implement():
        print("static mehtod")
    

        