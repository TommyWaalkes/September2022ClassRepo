import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DisplayComponent } from './display/display.component';
import { TestComponent } from './test/test.component';

//This is the main field you will edit in this file, everything else you want to leave alone
const routes: Routes = [
  { path: 'display', component: DisplayComponent },
  { path: 'test', component: TestComponent}, 
  { path: '', redirectTo: '/test', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
