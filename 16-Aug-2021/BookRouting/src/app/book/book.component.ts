import { Component, OnInit } from '@angular/core';
import { BookServiceService } from '../book-service.service';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {

  id: number= 0;

  desc:any;
  img: any;

  bookList: {isbn: string,title: string,description: string, author: string, price: number,url: any}[] = [];

  constructor(private bookService: BookServiceService) { }

  ngOnInit(): void {
    this.bookList = this.bookService.onBookList();
    this.id = this.bookService.onId();
    this.desc = this.bookList[this.id].description;
  }

  onUpdateBook(url: any, description: string, price: any)
  {
    this.bookService.onBookUpdate(this.id, url, description, price);
  }


  url:any;
  msg='';

  onSelectFile(event: any) {
		if(!event.target.files[0] || event.target.files[0].length == 0) {
			this.msg = 'You must select an image';
			return;
		}
		
		var fileType = event.target.files[0].type;
		
		if (fileType.match(/image\/*/) == null) {
			this.msg = "Only images are supported";
			return;
		}
		
		var path = new FileReader();
		path.readAsDataURL(event.target.files[0]);
		
		path.onload = (_event) => {
			this.msg = "";
			this.url = path.result;
		}
	}
}
