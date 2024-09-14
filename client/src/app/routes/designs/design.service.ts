import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import{ Constants } from '../../core/config/constants';

@Injectable({
  providedIn: 'root'
})
export class DesignService {
  // Replace with your actual API URL

  constructor(private http: HttpClient) { }

  getDesigns(): Observable<any> {
    return this.http.get(`${Constants.API_ENDPOINT}/designs`);
  }

  // getDesignById(id: number): Observable<any> {
  //   return this.http.get(`${Constants.API_ENDPOINT}/designs/${id}`);
  // }

  // createDesign(design: any): Observable<any> {
  //   return this.http.post(`${Constants.API_ENDPOINT}/designs`, design);
  // }

  // updateDesign(id: number, design: any): Observable<any> {
  //   return this.http.put(`${Constants.API_ENDPOINT}/designs/${id}`, design);
  // }

  // deleteDesign(id: number): Observable<any> {
  //   return this.http.delete(`${Constants.API_ENDPOINT}/designs/${id}`);
  // }
}