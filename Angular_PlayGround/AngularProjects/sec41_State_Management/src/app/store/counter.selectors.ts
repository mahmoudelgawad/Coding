import { createSelector } from "@ngrx/store";

//#create selector using 'arrow function' or 'createSelector' function 
export const counterSelector = (state:{counter:number}) => state.counter;
export const counterDoubleSelector = createSelector(
    counterSelector,
    (counter:number) => counter * 2);
export const counterTripleSelector = (state:{counter:number}) => state.counter * 3; 