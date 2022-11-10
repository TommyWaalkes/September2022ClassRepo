import { Component, Input, OnInit } from '@angular/core';
import { MenuItem } from '../MenuItem';

@Component({
  selector: 'app-update-form',
  templateUrl: './update-form.component.html',
  styleUrls: ['./update-form.component.css']
})
export class UpdateFormComponent implements OnInit {

  constructor() { }
  @Input() existingItems: MenuItem[] = [];
  itemToUpdate: MenuItem = {item:"", price:0, category:""};
  index:number = -1;
  ngOnInit(): void {
  }

  SelectItemToUpdate(){
    this.index = parseInt((<HTMLInputElement> document.getElementById("index")).value);
    this.itemToUpdate = this.existingItems[this.index];
    console.log(this.itemToUpdate);
  }

  UpdateItem(){
   
    this.itemToUpdate.item = (<HTMLInputElement> document.getElementById("ItemU")).value;
    this.itemToUpdate.price = parseFloat((<HTMLInputElement> document.getElementById("PriceU")).value);
    this.itemToUpdate.category = (<HTMLInputElement> document.getElementById("CategoryU")).value;
    console.log(this.itemToUpdate);
    this.existingItems[this.index] = this.itemToUpdate;
  }

}
