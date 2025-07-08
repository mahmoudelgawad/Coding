import { createAction, props,Action } from "@ngrx/store";

//# 'createAtion' accept object {type,props<T>}
//# will links with reducers with 'on' function
//# for attaching/passing data to action as parameter use 'props<T>()' method
export const incrementAction = createAction(
    '[Counter] Increment',
    props<{valueRate:number}>()
);
export const decrementAction = createAction(
    '[Counter] Decrement',
    props<{valueRate:number}>()
);

export const initAction = createAction(
    '[Counter] Init'
);

export const setAction = createAction(
    '[Counter] Set',
     props<{setValue:number}>()
);


//# alternative to make action
/*
export const INCREMENT = '[Counter] Increment';
export class IncrementAction implements Action{
    readonly type = INCREMENT;
    constructor(public value:number) {} 
}
export type CounterActions = IncrementAction;
*/