import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ApplicantsComponent } from './hr/applicants/applicants.component';
import { DashboardComponent } from './hr/dashboard/dashboard.component';
import { HrComponent } from './hr/hr.component';

const routes: Routes = [
  {path:'hr', component: HrComponent},
  {path:'dashboard', component: DashboardComponent},
  {path:'applicants', component: ApplicantsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
