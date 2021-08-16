import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BookServiceService {


  constructor() { }

  bookList: {isbn: string,title: string,description: string, author: string, price: number,url: any}[] = 
  [
    {
      isbn: '1-86092-049-7', 
      title: 'The Grass is Always Greener', 
      description: 'This ingenious tale examines the ambitions and petty jealousies of the staff at Critchley\'s Bank. From the doorman to the personnel manager, to Sir William, the bank\'s sorrowful chairman.',
      author: 'Jeffrey Archer',
      price: 60,
      url: ''
    },
    {
      isbn: '1-86092-012-8', 
      title: 'Murder!', 
      description: 'Two men meet in a seaside resort. What follows is murder. What\'s discovered isn\'t all it seems to be... Arnold Bennett was born in 1867.',
      author: 'Arnold Bennett ',
      price: 40,
      url: ''

    },
    {
      isbn: '1-86092-006-3', 
      title: '	An Occurrence at Owl Creek Bridge One of the Missing', 
      description: 'Ambrose Bierce was an American journalist, newspaper editor, misanthrope, writer and wit. His two short story masterpieces, An Occurrence at Owl Creek Bridge and One of the Missing, are both brilliant examples of American short fiction at its sharpest. Each is a gripping action tale set in the American Civil War during which Bierce himself saw action at Shiloh and Chickamauga.',
      author: '	Ambrose Bierce',
      price: 30,
      url: ''
    },
    {
      isbn: '1-86092-022-5', 
      title: 'A Boy at Seven', 
      description: 'John Bidwell\'s two satirical short story journals are loosely based on real incidents in the author\'s life.',
      author: 'John Bidwell',
      price: 80,
      url: ''
    }
  ];

  id: number = 0;

  onBookAdded(isbn: string,title: string,description: string, author: string, price: number)
  {
    this.bookList.push({isbn:isbn, title:title, description:description, author:author, price:price,url:''});
    localStorage.setItem('books',JSON.stringify(this.bookList));
  }

  onBookList(){
    return this.bookList;
  }

  onBookUpdate(id: number,url: any, description: string, price: number)
  {
    this.bookList[id].description = description;
    this.bookList[id].price = price;
    this.bookList[id].url = url;
    localStorage.setItem('books',JSON.stringify(this.bookList));
  }

  onUpdateId(id: number)
  {
    this.id=id;
  }

  onId()
  {
    return this.id
  }
}
