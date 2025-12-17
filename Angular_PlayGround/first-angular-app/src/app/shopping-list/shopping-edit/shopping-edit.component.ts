import { Component, OnInit,ViewChild,ElementRef, Output, EventEmitter } from '@angular/core';
import { Ingredient } from '../../shared/ingredient.model';

@Component({
  selector: 'app-shopping-edit',
  templateUrl: './shopping-edit.component.html',
  styleUrls: ['./shopping-edit.component.css']
})
export class ShoppingEditComponent implements OnInit {
@ViewChild('nameInput') nameInputElem : ElementRef;
@ViewChild('amountInput') amountInputElem : ElementRef;
@Output() addIngredientEventEmitter = new EventEmitter<Ingredient>();
  constructor() { }

  ngOnInit() {
  }

  onAdd(){
    this.addIngredientEventEmitter.emit(
      new Ingredient(this.nameInputElem.nativeElement.value,
                     this.amountInputElem.nativeElement.value));
  }
}
