import { Component, OnInit } from '@angular/core';
import { NgFor } from '@angular/common';
import { ProjectService } from './project.service';

@Component({
  standalone: true,
  selector: 'projects',
  templateUrl: 'projects.component.html',
  imports: [NgFor]
})

export class ProjectsComponent implements OnInit {

  projects: any[] = [];

  constructor(private projectService: ProjectService) { }

  ngOnInit(): void {
    this.loadProjects();
  }

  loadProjects(): void {
    this.projectService.getProjects().subscribe(
      (data) => {
        this.projects = data;
      },
      (error) => {
        console.error('Error fetching designs:', error);
      }
    );
  }

}
