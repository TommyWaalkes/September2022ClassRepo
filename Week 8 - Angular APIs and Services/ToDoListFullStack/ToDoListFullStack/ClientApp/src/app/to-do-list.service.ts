import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ToDo } from './to-do';

@Injectable({
  providedIn: 'root'
})
export class ToDoListService {
  baseURL:string;
  constructor(private http:HttpClient, @Inject("BASE_URL") private url:string) { 
    this.baseURL = url;
  }

  GetToDos():Observable<ToDo[]>{
    return this.http.get<ToDo[]>(this.baseURL +"api/ToDos");
  }
}
