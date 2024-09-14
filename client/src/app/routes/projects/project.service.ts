import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import{ Constants } from '../../core/config/constants';

@Injectable({
  providedIn: 'root'
})
export class ProjectService { // Replace with your actual API URL

  constructor(private http: HttpClient) { }

  public getProjects(): Observable<any> {
    return this.http.get(`${Constants.API_ENDPOINT}/projects`);
  }

  // getProjectById(id: number): Observable<any> {
  //   return this.http.get(`${this.apiUrl}/projects/${id}`);
  // }

  // createProject(project: any): Observable<any> {
  //   return this.http.post(`${this.apiUrl}/projects`, project);
  // }

  // updateProject(id: number, project: any): Observable<any> {
  //   return this.http.put(`${this.apiUrl}/projects/${id}`, project);
  // }

  // deleteProject(id: number): Observable<any> {
  //   return this.http.delete(`${this.apiUrl}/projects/${id}`);
  // }
}