import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  //You can label your paths however you wish, but generally its best to name them after the component
  //Any time you add in a new component and you wish your user to be able to click to access it 
  //you need to come here and put that new component into the array
  {path:"home", component: HomeComponent},
  {path:"about", component: AboutComponent},
  {path:"contact", component: ContactComponent},
  {path:"", redirectTo:"/home", pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
