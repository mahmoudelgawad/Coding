import { Component, computed, inject } from '@angular/core';
import { NgIf } from '@angular/common'; // or use CommonModule for all directives

import { AuthComponent } from './auth/auth.component';
import { LearningResourcesComponent } from './learning-resources/learning-resources.component';
import { AuthService } from './auth/auth.service';
import { AuthDirective } from './auth/auth.directive';
import { LogDirective } from './log.directive';


@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [AuthComponent, LearningResourcesComponent, NgIf, AuthDirective, LogDirective],
  //use host directive on app component, mean add directive on current host component 'app'
  //and will log any click with that component
  // hostDirectives:[LogDirective]
})
export class AppComponent {
private authService = inject(AuthService)

isAdmin = computed( () => this.authService.activePermission() === 'admin' );

}
