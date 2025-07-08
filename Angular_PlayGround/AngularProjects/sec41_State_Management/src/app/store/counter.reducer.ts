import { createReducer, on } from "@ngrx/store";
import { incrementAction,decrementAction, setAction } from "./counter.actions";

const initialState = 0;

//# Reducer contain changing manipulation/process of the data store 
//# linked with action via 'on' func

//#another way using manual function reducer
// export function counterReducer(state = initialState, action:any){
//  if(action.type === '[Counter] Increment'){
//          return state + action.value
//  }
//     return state;
// } 

//# ngrx 'createReducer' create function under the hood 
export const counterReducer = createReducer(
  initialState,
  //# 'state' latest/current store data, 
  //# 'action' for passed parameter or props
  on(incrementAction,(state,action) => state + action.valueRate), 
  on(decrementAction,(state,action) => {
   console.log({reducer:'counterReducerOndecrementAction'});
   return  state - action.valueRate;
  }),
  on(setAction,(state, action) => action.setValue)
);