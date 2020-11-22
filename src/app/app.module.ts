import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CompareproductsComponent } from './compareproducts/compareproducts.component';
import { ProductlistComponent } from './productlist/productlist.component';
import { ProductService } from 'src/Service/productService';
import {HttpClientModule} from  '@angular/common/http';
import {enableProdMode} from '@angular/core';

enableProdMode();

@NgModule({
  declarations: [
    AppComponent,
    CompareproductsComponent,
    ProductlistComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
    
  ],
  providers: [ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
