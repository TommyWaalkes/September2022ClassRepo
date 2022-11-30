import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CarlistComponent } from './carlist/carlist.component';
import { RouterModule, Routes } from '@angular/router';
import { CarDetailsComponent } from './car-details/car-details.component';

const routes: Routes = [
  { path: "carlist", component: CarlistComponent }, 
  //It tells car details that it will recieve an id, we'll then take that id and grab the matching car in car details
  {path: "cardetails/:id", component:CarDetailsComponent }
];

@NgModule({
  declarations: [
   
  ],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ], 
  exports:[RouterModule]
})
export class AppRoutingModule { }
