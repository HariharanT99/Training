import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-book-display',
  templateUrl: './book-display.component.html',
  styleUrls: ['./book-display.component.css']
})
export class BookDisplayComponent implements OnInit {

  desc:any;
  img:any;

  url:any;
  msg='';

  id: number = 0;

  @Input() bookList: any;

  @Output() book: any = new EventEmitter<{id:number, url: any,describtion: string, price: number}>();

  constructor() { }

  ngOnInit(): void {
  }

  onUpdateId(id: number)
  {
    this.desc=this.bookList[id].description;
    this.id=id;
  }

  onUpdateBook(id: number,url: any, description: string, price: any)
  {
    this.img=''; 
    this.book.emit({id,url,description,price});
  }

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
