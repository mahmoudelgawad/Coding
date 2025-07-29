import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-post',
  standalone:true,
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css'],
})
export class PostComponent {
  //# TypeScript properties strictness and optionality as 'difinite assignment assertion'
  //# '!' meaning for typescript is don't worry will assigned from the parent
  @Input() title!: string;
  //# '?' meaning for typescript it is 'string' or 'undefined' 
  @Input() content?: string;
}
