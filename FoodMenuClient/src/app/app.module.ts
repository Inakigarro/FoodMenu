import { NgModule } from "@angular/core";
import { AppComponent } from "./app.component";
import { AppRoutingModule } from "./app-routing.module";
import { BrowserModule } from "@angular/platform-browser";
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { ComponentsModule } from "./components/components.module";
import { MatSidenavModule } from "@angular/material/sidenav";
import { MatToolbarModule } from "@angular/material/toolbar";
import { MatButtonModule } from "@angular/material/button";
import { MatIconModule } from "@angular/material/icon";
import { ItemCardComponent } from "./item-card/item-card.component";
import { MatCardModule } from '@angular/material/card'

@NgModule({
    declarations: [
      AppComponent,
      ItemCardComponent],
    imports: [
      BrowserModule,
      AppRoutingModule,
      ComponentsModule,
      MatButtonModule,
      MatCardModule,
      MatIconModule,
      MatSidenavModule,
      MatToolbarModule,
      ],
    exports: [],
    providers: [
      provideAnimationsAsync()
  ],
    bootstrap: [AppComponent]
})
export class AppModule {}