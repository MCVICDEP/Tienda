import { Component, Input, OnInit } from '@angular/core';
import { ProductoServicio } from 'src/app/servicios/producto.service';

@Component({
    selector: 'app-filtro-profucto',
    templateUrl: './filtro-producto.component.html',
    styleUrls: ['./filtro-producto.component.scss']
})

export class FiltroProductoComponent implements OnInit {

    @Input('categoria')
    categoria;

    ListadeCategoria:[]

    constructor(private ProductoServicio: ProductoServicio) { }

    ngOnInit() {
        this.ProductoServicio.getCategoria().subscribe((categoriaData:[])=>{
            this.ListadeCategoria = categoriaData;
        }, error =>{
            console.log("error en tiempo de ejecución",error);            
        }
        );
     }
}