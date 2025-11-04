import { Component } from '@angular/core';
import {Recipe} from '../recipe.model';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrl: './recipe-list.component.css'
})
export class RecipeListComponent {
recipes:Recipe[] = [
    new Recipe("Beef Shawerma","beef pieces with tahena vinigar bakdones onion","https://www.cookingclassy.com/wp-content/uploads/2023/06/beef-shawarma-2.jpg"),
    new Recipe("Kofta Basmati Rice","beef kofta with basmati rice and salad","https://cdn.britannica.com/34/236834-050-B6161830/chicken-and-vegetable-shish-kabobs-on-a-skewer-with-rice.jpg"),
  ];
}
