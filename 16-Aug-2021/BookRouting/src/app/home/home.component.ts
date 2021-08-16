import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { BookServiceService } from '../book-service.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  aut ='';
  prc = '';
  desc ='';
  ttl ='';
  isn='';  

  constructor (private bookService: BookServiceService) { }

  ngOnInit(): void {
  }

  onAddBook(isbn: any, title: string, description: string, author: string, price: any)
  {
    this.bookService.onBookAdded(isbn, title, description, author, price);
    this.aut ='';
    this.prc = '';
    this.desc ='';
    this.ttl ='';
    this.isn=''; 
  }
}
