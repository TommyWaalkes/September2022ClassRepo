import { Component, Input, OnInit } from '@angular/core';
import { MenuItem } from '../MenuItem';

@Component({
  selector: 'app-delete-item',
  templateUrl: './delete-item.component.html',
  styleUrls: ['./delete-item.component.css']
})
export class DeleteItemComponent implements OnInit {
@Input() existingItems: MenuItem[] = [];
@Input() indexToDelete : number =  -1;
  constructor() { }

  ngOnInit(): void {
  }

  deleteItem(index:number){
    this.existingItems.splice(index, 1);
  }

}
