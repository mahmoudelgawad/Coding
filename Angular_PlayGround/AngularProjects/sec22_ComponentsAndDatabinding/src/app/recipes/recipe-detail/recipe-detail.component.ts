import { Component, DoCheck, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Recipe } from '../recipe.model';

@Component({
  selector: 'app-recipe-detail',
  templateUrl: './recipe-detail.component.html',
  styleUrls: ['./recipe-detail.component.css']
})
export class RecipeDetailComponent implements OnInit, OnChanges, DoCheck {
  @Input() selectedRecipe:Recipe;
  constructor() { }

  ngOnChanges(changes: SimpleChanges): void {
    
  }

  ngOnInit() {
  }

  ngDoCheck(): void {
    console.log(this.selectedRecipe);
  }



}
