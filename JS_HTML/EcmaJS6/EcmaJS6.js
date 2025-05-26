//JavaScript ECAM script 6 need server not called as file://

import {Person} from './person';
import Teacher,{promote} from './teacher';

function objectWithThis() {
  const person = {
    name: "mahmoud",
    walk() {
      //this will reference for current object
      console.log("this", this);
    },
  };

  person.walk();

  //passing walk function reference as object
  const walk = person.walk;
  // this reference point to  'window' obj not original person obj
  walk();

  // to fix 'this' reference to original 'person' obj use 'bind'
  const walk_bind = person.walk.bind(person);
  walk_bind();
}

function arrowFuncWithThis() {
  const person = {
    name: "Mahmoud",
    walk() {
      let self = this;
      setTimeout(function () {
        console.log("self", self);
      }, 1000);
    },
    talk() {
      //let self = this;
      //arrow function inherit 'this' keyword from current context, no nead to rebind
      setTimeout(() => console.log("this", this), 1000);
    },
  };

  //person.walk();
  person.talk();
}

function arrayMapFunc() {
  const colors = ["red", "green", "blue"];
  const items = colors.map((color) => `<li>${color}</li>`);
  console.log({ items: items });
}

function destructingObject() {
  const address = {
    street: "bluto",
    building: "30",
    floor: 3,
  };
  const { street: st, building, floor } = address;
  console.log(st, building, floor);
}

function definePersonClass() {
  const person = new Person("Alexandria");
  person.walk();
}

function defineTeacherCalss(){
  //calling base class 'Person' constructor by inheritance
  const teacher = new Teacher("MahmoudInstructor","BaschelorCS");
  teacher.teach();
  console.log({teacherName:teacher.name,teacherDegree:teacher.degree});
}


/////////////////////Implementation///////////////////////////////

function Implementation() {
  console.log("EcmaJS6::START");
  //ObjectWithThis();
  //ArrowFuncWithThis();
  //ArrayMapFunc();
  //DestructingObject();
  //DefinePersonClass();
  defineTeacherCalss();
  console.log("EcmaJS6::END");
}

Implementation();
