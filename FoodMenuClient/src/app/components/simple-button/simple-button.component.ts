import { Component, Input } from "@angular/core";

@Component({
    selector: 'app-simple-button',
    templateUrl: './simple-button.component.html',
    styleUrl: './simple-button.component.scss'
})
export class SimpleButtonComponent {
    @Input()
    public buttonType: "basic" | "raised" | "flat" | "icon" = "basic";

    @Input()
    public icon: string = "";

    @Input()
    public label: string = "";
}