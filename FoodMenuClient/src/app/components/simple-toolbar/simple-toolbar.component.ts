import { Component, Input } from "@angular/core";

@Component({
    selector: "app-simple-toolbar",
    templateUrl: "./simple-toolbar.component.html",
    styleUrl: "./simple-toolbar.component.scss"
})
export class SimpleToolbarComponent {
    @Input()
    public iconButton: string = "";

    @Input()
    public title: string = "";
}