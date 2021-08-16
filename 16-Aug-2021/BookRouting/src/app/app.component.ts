import { Component } from '@angular/core';
import { BookServiceService } from './book-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'BookRouting';

  constructor (private bookservise: BookServiceService) {}
}
