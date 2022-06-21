import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ApplicantTableComponent } from './dashboard/applicant-table/applicant-table.component';
import { InterviewComponent } from './interview/interview.component';
import { ApplicantsComponent } from './applicants/applicants.component';



@NgModule({
  declarations: [
    DashboardComponent,
    ApplicantTableComponent,
    InterviewComponent,
    ApplicantsComponent
  ],
  imports: [
    CommonModule
  ]
})
export class HrModule { }
