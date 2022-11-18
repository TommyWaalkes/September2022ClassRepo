import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DonutResults } from './DonutResults';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DonutsService {
  url:string = "https://grandcircusco.github.io/demo-apis/donuts.json";

  constructor(private http:HttpClient) { }

  GetAllDonuts(): Observable<DonutResults>{
      return this.get<DonutResults>(this.url);
  }
}
