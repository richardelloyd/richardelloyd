import { CommonModule } from '@angular/common';
import { Component, type OnInit } from '@angular/core';

@Component({
  selector: 'header',
  standalone: true,
  imports: [
    CommonModule,
  ],
  templateUrl: './header.component.html',
})
export class HeaderComponent implements OnInit {

  ngOnInit(): void { }

}
