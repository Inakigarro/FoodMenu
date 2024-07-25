import { ChangeDetectorRef, Component, OnDestroy } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MediaMatcher } from '@angular/cdk/layout';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnDestroy {
  public tabs: string[] = ["Hamburguesas", "Papas", "Gaseosas"]
  public itemList = [
    {
      correlationId: '1',
      displayName: 'Hamburguesa Simple',
      description: 'Pan de papa, 140gr de carne, 2x cheddar',
      price: 100,
      imagePath: '../assets/hamburgers/smaple-hamburger-150.png',
    },
    {
      correlationId: '1',
      displayName: 'Hamburguesa Simple',
      description: 'Pan de papa, 140gr de carne, 2x cheddar',
      price: 100,
      imagePath: '../assets/hamburgers/smaple-hamburger-150.png',
    },
    {
      correlationId: '1',
      displayName: 'Hamburguesa Simple',
      description: 'Pan de papa, 140gr de carne, 2x cheddar',
      price: 100,
      imagePath: '../assets/hamburgers/smaple-hamburger-150.png',
    }
  ];

  mobileQuery: MediaQueryList;

  private _mobileQueryListener: () => void;

  constructor(
    changeDetectorRef: ChangeDetectorRef,
    media: MediaMatcher) {
      this.mobileQuery = media.matchMedia('(max-width: 768px)');
      this._mobileQueryListener = () => changeDetectorRef.detectChanges();
      this.mobileQuery.addListener(this._mobileQueryListener);
    }

  public ngOnDestroy(): void {
      this.mobileQuery.removeListener(this._mobileQueryListener)
  }
}
