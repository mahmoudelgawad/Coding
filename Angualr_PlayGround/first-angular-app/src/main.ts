import { bootstrapApplication } from '@angular/platform-browser';

import { AppComponent } from './app/app.component';
import { HttpHandlerFn, HttpRequest, provideHttpClient, withInterceptors } from '@angular/common/http';

function LoggingInterCeptor(request:HttpRequest<unknown>, next:HttpHandlerFn){
    console.log('LoggingInterCeptor:OutgoingRequest');
    console.log(request);
    const reqClone = request.clone({
        headers: request.headers.set("F-DEBUG",'valueTestFofo')
    });
 return next(reqClone);
}

bootstrapApplication(AppComponent,{
    providers:[provideHttpClient(withInterceptors([LoggingInterCeptor]))]
}).catch((err) => console.error(err));
