import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { BookServiceService } from '../book-service.service';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {

  bookList: {isbn: string,title: string,description: string, author: string, price: number,url: any}[] = [];

  constructor(private bookService: BookServiceService) { }

  ngOnInit(): void 
  {
    this.bookList= this.bookService.onBookList();
  }

  onUpdateId(id: number)
  {
    this.bookService.onUpdateId(id);
  }


}
