
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  message = 'Hello';
  users = [
    { id: 24, name: 'Sergio', username: 'stepserg' },
    { id: 12, name: 'Trom', username: 'trom' },
    { id: 31, name: 'Holly', username: 'hollybout' }
  ];
}
