import { Injectable } from '@angular/core';
import { product } from './product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  inventory: product[] =[{name:"Birds are real", productId:"nasalies", price:999.99},
                         {name: "Cheese Quesadilla", productId:"queso123", price:7.00}, 
                         {name:"Uranium Sanwich", productId:"radioactive55", price:1000000}
                        ]
  constructor() { }

  getAllProducts(): product[]{
    return this.inventory;
  }
}
