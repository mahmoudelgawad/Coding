import { ApplicationConfig } from "@angular/core";
import { provideRouter, withComponentInputBinding, withRouterConfig } from "@angular/router";
import { appRoutes } from "./app.routes";

export const appConfig : ApplicationConfig = {
    providers:[
        provideRouter(
            appRoutes,
            //applicable for main/parent component/route, not child/nested routes
            withComponentInputBinding(),
            withRouterConfig({paramsInheritanceStrategy:"always"})),
    ]
}