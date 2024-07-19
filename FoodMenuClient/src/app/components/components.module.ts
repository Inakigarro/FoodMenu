import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
// Material modules.
import { MatToolbarModule } from "@angular/material/toolbar"
import { MatButtonModule } from "@angular/material/button"; 
import { MatIconModule } from "@angular/material/icon";

// Custom components.
import { SimpleToolbarComponent } from "./simple-toolbar/simple-toolbar.component";
import { SimpleButtonComponent } from "./simple-button/simple-button.component";

const MaterialModules = [
    MatToolbarModule,
    MatButtonModule,
    MatIconModule
];

@NgModule({
    declarations: [
        SimpleButtonComponent,
        SimpleToolbarComponent],
    imports: [CommonModule, MaterialModules],
    exports: [SimpleButtonComponent, SimpleToolbarComponent]
})
export class ComponentsModule {}