import { Component, inject, OnInit } from '@angular/core';
import { AuthService } from './auth/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  authService = inject(AuthService);
  
  loadedFeature = 'recipe';

  ngOnInit(): void {
    this.authService.autoLogin();
  }
  onNavigate(feature: string) {
    this.loadedFeature = feature;
  }


}
