import { Component, OnDestroy, OnInit } from '@angular/core';

import { DataStorageService } from '../shared/data-storage.service';
import { AuthService } from '../auth/auth.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html'
})
export class HeaderComponent implements OnInit,OnDestroy{
  isAuthenticated = false;
  private userSubscribtion = new Subscription();
 
  constructor(private dataStorageService: DataStorageService,
    private authServices :AuthService) {}

    ngOnInit(): void {
      this.userSubscribtion = this.authServices.userBeaviorSubject.subscribe( user => {
        // this.isAuthenticated = !user ? false : true;
        this.isAuthenticated = !!user;
      });
    }

  onSaveData() {
    this.dataStorageService.storeRecipes();
  }

  onFetchData() {
    this.dataStorageService.fetchRecipes().subscribe();
  }

  onLogout(){
    this.authServices.logout();
  }
  ngOnDestroy(): void {
    this.userSubscribtion.unsubscribe();
  }
}
