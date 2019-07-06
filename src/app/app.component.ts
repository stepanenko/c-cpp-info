
import { Component, Injector } from '@angular/core';
import { createCustomElement } from '@angular/elements';
import { DomSanitizer } from '@angular/platform-browser';

import { AlertComponent } from './alert.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  content = null;

  constructor(private injector: Injector, private domSanitizer: DomSanitizer) {
    const AlertEl = createCustomElement(AlertComponent, { injector: this.injector });
    customElements.define('my-alert', AlertEl);
    setTimeout(() => {
      this.content = this.domSanitizer.bypassSecurityTrustHtml('<app-alert message="Rendered dynamically"</app-alert>');
    }, 1000);
  }

  message = 'Hello';
  users = [
    { id: 24, name: 'Sergio', username: 'stepserg' },
    { id: 12, name: 'Trom', username: 'trom' },
    { id: 31, name: 'Holly', username: 'hollybout' }
  ];
}
