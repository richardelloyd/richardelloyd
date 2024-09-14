import { Component, OnInit } from '@angular/core';
import { NgFor } from '@angular/common';
import { DesignService } from './design.service';

@Component({
  standalone: true,
  selector: 'designs',
  templateUrl: 'designs.component.html',
  imports: [NgFor]
})
export class DesignsComponent implements OnInit {
  designs: any[] = [];

  constructor(private designsService: DesignService) { }

  ngOnInit(): void {
    this.loadDesigns();
  }

  loadDesigns(): void {
    this.designsService.getDesigns().subscribe(
      (data) => {
        this.designs = data;
      },
      (error) => {
        console.error('Error fetching designs:', error);
      }
    );
  }
}
