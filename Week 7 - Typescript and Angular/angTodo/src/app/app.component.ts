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
    { task:'Wash hands' , completed:true, isEditing:false},
    { task:'Take out trash' , completed:true, isEditing:false},
    { task:'Joined zoom' , completed:false, isEditing:false},
    { task:'Eat breakfast' , completed:false, isEditing:false}
  ];

  CompleteTodo(i:number) {

    this.myTodos[i].completed = true;
  }

  AddToDo(){
    let taskName: string = (<HTMLInputElement> document.getElementById("AddInput")).value;

    let t : Todo = {task:taskName, completed:false, isEditing:false};

    this.myTodos.push(t);
  }

  DeleteToDo(i:number){
    this.myTodos.splice(i, 1);
  }

  EditToDo(i: number){
    let t: Todo = this.myTodos[i];
    //This is what's a called toggle in front end 
    t.isEditing = !t.isEditing;
  }

}
