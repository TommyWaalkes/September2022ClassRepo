//This imports any extension meant to be used site wide. 
//When we create a new component the command line places a reference to that component in this file
//We're registering the component so it can be used in our app
//Tread carefully with this file, breaking this file can break your whole app
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HelloWorldComponent } from './hello-world/hello-world.component';
import { AddItemComponent } from './add-item/add-item.component';
import { DeleteItemComponent } from './delete-item/delete-item.component';
import { UpdateFormComponent } from './update-form/update-form.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HelloWorldComponent,
    AddItemComponent,
    DeleteItemComponent,
    UpdateFormComponent
  ],
  //pull in extension to Angular, most often one built into Angular
  imports: [
    BrowserModule, 
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
