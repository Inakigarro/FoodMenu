import { Component, Input } from "@angular/core";

@Component({
    selector: 'app-item-card',
    templateUrl: './item-card.component.html',
    styleUrl: './item-card.component.scss'
})
export class ItemCardComponent {
    @Input()
    public imagePath: string = "";

    @Input()
    public itemName: string = "";

    @Input()
    public itemDescription: string = "";
}