import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    loadComponent: () => import('./routes/home/home.component').then(m => m.HomeComponent),
    title: 'Home'
  },
  {
    path: 'designs',
    loadComponent: () => import('./routes/designs/designs.component').then(m => m.DesignsComponent),
    title: 'Designs'
  },
  {
    path: 'projects',
    loadComponent: () => import('./routes/projects/projects.component').then(m => m.ProjectsComponent),
    title: 'Projects'
  },
  {
    path: '**',
    redirectTo: '',
  },

];
