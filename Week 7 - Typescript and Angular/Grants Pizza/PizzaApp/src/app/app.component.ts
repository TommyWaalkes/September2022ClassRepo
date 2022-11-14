import { Component } from '@angular/core';
import { AddService } from './add.service';
import { MenuItem } from './MenuItem';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  items: MenuItem[] = 
  [{item: "Chicken Tendies", price: 5.00, category:"dinner"},
    {item:"Mixed Green Salad", price: 6.00, category:"side"},
    {item:"Beef n Veggie Stew", price: 7.99, category:"dinner"}
  ];

  heading:string = "Menu Items";
  title = 'PizzaApp';

  constructor(private add: AddService){

  }

  UseService(){
    this.add.HelloWorld();
  }

  getByCategory( ) : MenuItem[]{
    //To refer to something in the same class in a JS object 
    //You MUST use the this keyword
    //This rule applieds to both properties and methods defined as part of the class
    //local vars are still okay
    this.heading = (<HTMLInputElement> document.getElementById("cat")).value;
    let output: MenuItem[] = [];
    for(let i: number = 0; i<this.items.length; i++){
      let m: MenuItem = this.items[i];

      if(m.category.includes(this.heading)){
        output.push(m);
      }
    }

    this.items = output;

    return output;
  }

  reset() : void{
    this.heading = "Menu Items";
    this.items =  [{item: "Chicken Tendies", price: 5.00, category:"dinner"},
    {item:"Mixed Green Salad", price: 6.00, category:"side"},
    {item:"Beef n Veggie Stew", price: 7.99, category:"dinner"}
  ];
  }
}
