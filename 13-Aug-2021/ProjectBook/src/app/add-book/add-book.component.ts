import { Component, OnInit, EventEmitter, Output } from '@angular/core';


@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})

export class AddBookComponent{

  aut ='';
  prc = '';
  desc ='';
  ttl ='';
  isn='';  



  @Output() book: any = new EventEmitter<{isbn: string,title: string,describtion: string, author: string, price: number}>();


  constructor() { }


  onAddBook(isbn: any, title: string, description: string, author: string, price: any)
  {
    this.aut='';
    this.prc='';
    this.desc='';
    this.ttl='';
    this.isn='';

    this.book.emit({isbn,title,description,author,price});
  }

}
