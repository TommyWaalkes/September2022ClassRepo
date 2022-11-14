import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AddService {

  constructor() { }

  HelloWorld(){
    console.log("Hello World");
  }
}
