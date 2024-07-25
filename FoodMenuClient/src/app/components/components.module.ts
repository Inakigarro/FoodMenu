import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
// Material modules.
import { MatToolbarModule } from "@angular/material/toolbar"
import { MatButtonModule } from "@angular/material/button"; 
import { MatIconModule } from "@angular/material/icon";
import { MatListModule } from '@angular/material/list';
import { MatTabsModule } from '@angular/material/tabs';
import { MatCardModule } from "@angular/material/card";
// Custom components.
import { SimpleToolbarComponent } from "./simple-toolbar/simple-toolbar.component";
import { SimpleButtonComponent } from "./simple-button/simple-button.component";
import { SimpleListComponent } from "./simple-list/simple-list.component";
import { ItemCardComponent } from "../item-card/item-card.component";
import { SimpleTabsComponent } from "./simple-tabs/simple-tabs.component";


const MaterialModules = [
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    MatListModule,
    MatCardModule,
    MatTabsModule
];

@NgModule({
    declarations: [
        SimpleButtonComponent,
        SimpleListComponent,
        SimpleTabsComponent,
        SimpleToolbarComponent,
        ItemCardComponent],
    imports: [CommonModule, MaterialModules],
    exports: [
        SimpleButtonComponent,
        SimpleTabsComponent,
        SimpleToolbarComponent,
        SimpleListComponent,
        ItemCardComponent]
})
export class ComponentsModule {}