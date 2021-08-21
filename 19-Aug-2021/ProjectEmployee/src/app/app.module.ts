import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PersonalDetailComponent } from './personal-detail/personal-detail.component';
import { ProfessionalDetailComponent } from './professional-detail/professional-detail.component';
import { AttachmentComponent } from './attachment/attachment.component';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';





@NgModule({
  declarations: [
    AppComponent,
    PersonalDetailComponent,
    ProfessionalDetailComponent,
    AttachmentComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule
    
  ],

  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
