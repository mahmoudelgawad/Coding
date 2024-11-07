import { afterNextRender, Component, DestroyRef, inject, viewChild } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { debounceTime } from 'rxjs';

const FORM_EMAIL_KEY = "125from-email";
@Component({
  selector: 'app-login',
  standalone: true,
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
  imports:[FormsModule]
})
export class LoginComponent {
  
  private form = viewChild.required<NgForm>('form');
  private destroyRef = inject(DestroyRef);

  constructor(){
    //First time constructor run, register form logic callback with this function 
    //After the form completely init/rendered in the template 
    afterNextRender(() =>{
      const savedData = window.localStorage.getItem(FORM_EMAIL_KEY);
      if(savedData){
        const loadedFormData = JSON.parse(savedData);
        const emailValue = loadedFormData.email;
        setTimeout(() =>{
          this.form().controls['email'].setValue(emailValue);
        },1);      
      }
  
      //as observable changes data stream
      //'?' mean incase not initialized yet 
      const changesSubs = this.form().valueChanges?.pipe(
        debounceTime(500) //delay emit stream data for specific time
      ).subscribe({
        next:(value) =>{
          window.localStorage.setItem(
            FORM_EMAIL_KEY,
            JSON.stringify({email:value.email}));
          console.log(value);
        },
        complete:undefined,
        error:undefined
      });
      this.destroyRef.onDestroy(() =>{changesSubs?.unsubscribe()});
    });

  }

  onSubmit(formData:NgForm){

    if(formData.form.invalid)
      return;
    
    const email = formData.form.value.email;
    const password = formData.form.value.password;

    console.log(email);
    console.log(password);
  }
}
