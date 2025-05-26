import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';

import { WelcomeComponent } from './welcome/welcome.component';

//# by default routes not load components lazely, will including in bundle
//# you have to use different syntax "loadComponent"
const routes: Route[] = [
  {
    path: '',
    component: WelcomeComponent,
  },
  {
    path: 'about',
    //component: AboutComponent,
    //#load the component lazly instead
    loadComponent: () => import('./about/about.component')
        .then( imported => imported.AboutComponent),
  },
  {
    path: 'dashboard',
    //#load the dashboard routes lazly
    loadChildren: () => import('./dashboard/routes')
        .then((imported) => imported.DASHBOARD_ROUTES),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
