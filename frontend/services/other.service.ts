// other.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OtherService {
  private apiUrl = 'https://api.example.com/others'; // API endpoint for other data

  constructor(private http: HttpClient) { }

  getOtherData(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl); // Fetch other data from the API
  }

  // Additional methods for other-related operations can be added here
}
