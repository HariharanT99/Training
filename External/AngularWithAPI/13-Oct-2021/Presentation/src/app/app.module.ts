import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HrComponent } from './hr/hr.component';
import { DashboardComponent } from './hr/dashboard/dashboard.component';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { ApplicantTableComponent } from './hr/dashboard/applicant-table/applicant-table.component';
import { InterviewComponent } from './hr/interview/interview.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HrComponent
    ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgxDatatableModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
