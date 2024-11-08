import { Component, DestroyRef, inject } from '@angular/core';
import { AbstractControl, EmailValidator, FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { debounceTime, of } from 'rxjs';

//custome validator
function mustContainQuestionMark(control: AbstractControl){
  if(control.value.includes('?')){
    return null; //ok Passed
  }
  return {notContainQuestionMark:true}; //error
}

//async custome validator, as sending http request to backend, for check alredy exist
function EmailMustUnique(control:AbstractControl)
{
  if(control.value !== "test@example.com")
    return of(null); //return observable for async validator

  return of({emailNotUnique:true});
}

//different way we can load the saved email from Browser local storage outside the component and also the ngOninit
/*let InitialEmailValue = "";
let savedFormData = window.localStorage.getItem("saved-login-reactive-form");
if(savedFormData)
{
 let parsedFormData = JSON.parse(savedFormData);
 InitialEmailValue = parsedFormData.email; // then but that in FormControl as initial value
}
*/

@Component({
  selector: 'app-login-reactive',
  standalone: true,
  imports:[ReactiveFormsModule],
  templateUrl: './login.reactive.component.html',
  styleUrl: './login.reactive.component.css',
})
export class LoginReactiveComponent {

  destRef = inject(DestroyRef);

  form = new FormGroup({
    email: new FormControl('',{
      validators:[Validators.email,Validators.required],
      asyncValidators:[EmailMustUnique]}),
    password: new FormControl('',{
      validators:[Validators.required,Validators.minLength(6), mustContainQuestionMark]
    })
  });

  ngOnInit()
  {
    //retrieve local storage
    const savedFormValue = window.localStorage.getItem("saved-login-reactive-form");
    if(savedFormValue){
      const parsedValue = JSON.parse(savedFormValue);
      //this.form.setValue();
      //this.form.controls.email.setValue(parsedValue.email);
      this.form.patchValue({email:parsedValue.email});
    }

    //saving form changes in localstorage
    var formValueChangesSubs = this.form.valueChanges
    .pipe(
      debounceTime(500) //for delay emit everey single observer/event or value
    )
    .subscribe({
      next:(value) =>{
        window.localStorage.setItem("saved-login-reactive-form",JSON.stringify({email:value.email}));
      },
      complete:undefined,
      error:undefined
    }
    );
    this.destRef.onDestroy(() => {
      formValueChangesSubs.unsubscribe();
    });

  }

  get isInValidEmail(){
    return (this.form.controls.email.touched &&
      this.form.controls.email.dirty &&
      this.form.controls.email.invalid);
  }

  get isInValidPassword(){
    return (this.form.controls.password.touched &&
      this.form.controls.password.dirty &&
      this.form.controls.password.invalid);
  }

  onSubmit(){
    console.log(this.form.value);
  }


}
