import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InterviewerDashboardComponent } from './interviewer-dashboard/interviewer-dashboard.component';

const routes: Routes = [
  {path: 'interviewer-dashboard', component: InterviewerDashboardComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
