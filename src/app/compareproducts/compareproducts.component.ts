import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/Service/productService';


@Component({
  selector: 'app-compareproducts',
  templateUrl: './compareproducts.component.html',
  styleUrls: ['./compareproducts.component.css']
})
export class CompareproductsComponent implements OnInit {
  

  constructor(private prodservice:ProductService) {

   }

  ngOnInit() {
     this.Getprod;
  }
  products;
    Getprod()
    {
      this.prodservice.GetProducts().subscribe((data)=>{
        this.products = data;
        console.log(data);
      })
    }

  }

  


