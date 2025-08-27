export class Person {
    constructor(name) {
      this.name = name;
    }
  
    walk() {
      console.log(`person.walk() = ${this.name}`);
    }
  }