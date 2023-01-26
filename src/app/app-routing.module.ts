import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { InicioComponent } from "./componentes/inicio/inicio.componente";

const appRoutes: Routes = [
    { path: '', component: InicioComponent , pathMatch: 'full' },
];

@NgModule({
    declarations: [
    ],
    imports: [
        CommonModule,
        RouterModule.forRoot(appRoutes),
    ],

    exports: [
        RouterModule
    ]
})

export class AppRoutingModule {

}
