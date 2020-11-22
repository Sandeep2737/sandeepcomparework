import {HttpClient} from '@angular/common/http';
import{Injectable} from '@angular/core'

@Injectable({providedIn:"root"})
export class ProductService
{

    constructor(private http:HttpClient)
    {

    }
    GetProducts()
    {
        return this.http.get("https://localhost:44388/api/Products");

    }
    compareproducts()
    {
        return this.http.get("https://localhost:44388/api/CompareProducts");
    }
    addcompareproducts(id)
    {
        return this.http.get("https://localhost:44388/api/addCompareProduct"+id);
    }

   
  
}
