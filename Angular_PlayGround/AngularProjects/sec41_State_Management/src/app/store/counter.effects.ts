import { inject } from "@angular/core"
import { Actions, createEffect, ofType } from "@ngrx/effects"
import { of, switchMap, tap, withLatestFrom } from "rxjs";
import { decrementAction, incrementAction, initAction, setAction } from "./counter.actions";
import { Store } from "@ngrx/store";
import { counterSelector } from "./counter.selectors";

const COUNTER_LOCAL_STORAGE_NAME = 'counter';

//#there was another old way using decorator
//#but new one is the following  
export class counterEffects{
    store = inject(Store<{counter:number}>)
    actions$ = inject(Actions);

    loadCountEffect = createEffect(()=>
        this.actions$.pipe(
            //#work on init EFFECT instead of doing reducer logic
            ofType(initAction),
            //#for return/switch new other observable and ngrx action
            switchMap(()=>{
                const storedCounter = localStorage.getItem(COUNTER_LOCAL_STORAGE_NAME);
                if(storedCounter){
                    //# '+' to convert string to number
                    return of(setAction({setValue:+storedCounter}));
                }
                return of(setAction({setValue: 0}));
            }),
        ),
        //#if needed not call another effect use {dispatch:false}
    );

    saveCountEffect = createEffect(() => 
        this.actions$.pipe(
            ofType(incrementAction, decrementAction),
            //#will return '[action,counter]' ,but if not using 'withlatestform' 'tap' will recieve 'action' only
            withLatestFrom(this.store.select(counterSelector)),
            tap(([action,counter]) =>{
                console.log({effect:'saveCountEffect',action:action});
                localStorage.setItem(COUNTER_LOCAL_STORAGE_NAME, counter.toString());
            })
        ),
        //# for not call another effect
        {dispatch:false});


}