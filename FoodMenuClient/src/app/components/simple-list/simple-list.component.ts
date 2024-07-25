import { Component, Input } from "@angular/core";

interface Item {
    correlationId: string;
    displayName: string;
    description: string;
    price: number;
    imagePath: string;
}

@Component({
    selector: 'app-list',
    templateUrl: './simple-list.component.html',
    styleUrl: './simple-list.components.scss',
})
export class SimpleListComponent {
    @Input()
    public items: Item[] = [];
}