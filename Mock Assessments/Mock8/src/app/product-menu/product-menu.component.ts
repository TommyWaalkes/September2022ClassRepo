import { Component } from '@angular/core';
import { product } from '../product';
import { ProductService } from '../product-service.service';

@Component({
  selector: 'app-product-menu',
  templateUrl: './product-menu.component.html',
  styleUrls: ['./product-menu.component.css']
})
export class ProductMenuComponent {

  products:product[] =[];
  constructor(private productService: ProductService){
      this.products = productService.inventory;
      console.log(this.products);
  }
}
