import { bootstrapApplication } from '@angular/platform-browser';

import { AppComponent } from './app/app.component';
import { HttpEventType, HttpHandlerFn, HttpRequest, provideHttpClient, withInterceptors } from '@angular/common/http';
import { tap } from 'rxjs';

function LoggingInterCeptor(request:HttpRequest<unknown>, next:HttpHandlerFn){
    console.log('LoggingInterCeptor:OutgoingRequest');
    console.log(request);
    const reqClone = request.clone({
        //will raise error
       // headers: request.headers.set("F-DEBUG",'valueTestFofo')
    });

    // next() return Observable with type 'HttpEvent'
 return next(reqClone).pipe(
    tap({
        next:(event) =>{
            if(event.type === HttpEventType.Response){
                console.log("[There Incomming Data] -->>");
                console.log(`Event Status:${event.status}`);
                console.log(`Event Response:`,event.body);
            }
        },
    }),
 );
}

bootstrapApplication(AppComponent,{
    providers:[provideHttpClient(withInterceptors([LoggingInterCeptor]))]
}).catch((err) => console.error(err));
