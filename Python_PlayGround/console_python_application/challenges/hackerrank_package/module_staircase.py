class Staircase:
    #def __init__()
    #internaly using "__new__" def fun for new instance
    
    def staircase(self,n:int):
        for i in range(n):
            spaces = n -i -1
            chars = i+1
            print(" " * spaces + "#" * chars)
    
    def implement(self):
        n = 6
        self.staircase(n)

    