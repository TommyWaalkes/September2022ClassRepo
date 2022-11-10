import { Component, Input, OnInit } from '@angular/core';
import { MenuItem } from '../MenuItem';


@Component({
  selector: 'app-add-item',
  templateUrl: './add-item.component.html',
  styleUrls: ['./add-item.component.css']
})
export class AddItemComponent implements OnInit {

  //the input decorator allows this component to take in and reference data like method parameters 
  @Input() existingItems: MenuItem[] = [];

  //This newItem variable should be editable directly in our HTML 
  newItem:MenuItem = {item:"", price:0, category:""};
  itemName: string = "";

  constructor() { }

  ngOnInit(): void {
  }

  addItem(){
    this.newItem.item = (<HTMLInputElement> document.getElementById("Item")).value;
    this.newItem.price = parseFloat((<HTMLInputElement> document.getElementById("Price")).value);
    this.newItem.category = (<HTMLInputElement> document.getElementById("Category")).value;

    console.log(this.newItem);
    
    this.existingItems.push(this.newItem);
  }

}
