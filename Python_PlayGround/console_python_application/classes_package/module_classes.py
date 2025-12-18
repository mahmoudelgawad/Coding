class PersonClass:
    isEmployee = False
    def __init__(self,name, age):
        #internaly using "__new__" def fun for new instance
        #'self' mean current instance similar to 'this' in js
        self.name = name
        self.age = age

    def talk(self):
        # 'f' or 'F' formatted string literals
        print(f"{self.name} say Hi !")

    

    