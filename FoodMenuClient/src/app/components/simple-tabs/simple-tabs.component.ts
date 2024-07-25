import { Component, Input } from "@angular/core";

@Component({
    selector: 'app-tabs',
    templateUrl: './simple-tabs.component.html',
    styleUrl: 'simple-tabs.component.scss'
})
export class SimpleTabsComponent {
    @Input()
    public tabs: string[] = []
}