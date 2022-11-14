import { Component } from '@angular/core';
import { Todo } from './todo';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angTodo';

  myTodos:Todo[] = [
    { task:'Wash hands' , completed:true},
    { task:'Take out trash' , completed:true},
    { task:'Joined zoom' , completed:false},
    { task:'Eat breakfast' , completed:false},
  ];

  CompleteTodo(i:number) {

    this.myTodos[i].completed = true;
  }
}
