import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { BooksComponent } from './books/books.component';
import { BookComponent } from './book/book.component';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';

const bookRoute: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'books', component: BooksComponent},
  {path: 'book', component: BookComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    BooksComponent,
    BookComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot(bookRoute)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
