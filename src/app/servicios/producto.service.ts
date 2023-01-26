import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable({providedIn: 'root'})
export class ProductoServicio {

    baseUrl: string;

    constructor(private http:HttpClient) { 
        this.baseUrl="/api/productos/";
    }

    getCategoria(){
        return this.http.get(this.baseUrl + 'GetListaCategorias').pipe(
            map(response=>{
                return response;
            })
        )
    }
    
}