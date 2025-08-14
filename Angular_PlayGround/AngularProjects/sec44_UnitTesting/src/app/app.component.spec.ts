/* tslint:disable:no-unused-variable */

import { TestBed } from '@angular/core/testing';
import { AppComponent } from './app.component';

describe('App: CompleteGuideFinalWebpack', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      //#using 'imports' instead 'declarations' because it is standalone  component 
      imports: [
        AppComponent
      ],
    });
  });

  it('should create the app', () => {
    let fixture = TestBed.createComponent(AppComponent);
    let app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have as title 'app works!'`, () => {
    let fixture = TestBed.createComponent(AppComponent);
    let app = fixture.debugElement.componentInstance;
    expect(app.title).toEqual('app works!');
  });

  it('should render title in a h1 tag', () => {
    let fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    let compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('h1').textContent).toContain('app works!');
  });
});
