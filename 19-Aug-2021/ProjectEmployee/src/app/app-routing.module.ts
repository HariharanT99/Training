import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PersonalDetailComponent } from './personal-detail/personal-detail.component';
import { ProfessionalDetailComponent } from './professional-detail/professional-detail.component';
import { HomeComponent } from './home/home.component';
import { AttachmentComponent } from './attachment/attachment.component';


const employeeRoute: Routes =
[
  {path: 'home', component: HomeComponent},
  {path: 'personal-detail', component: PersonalDetailComponent},
  {path: 'professional-detail', component: ProfessionalDetailComponent},
  {path: 'attachment', component: AttachmentComponent}
]
@NgModule({
  imports: [RouterModule.forRoot(employeeRoute)],
  exports: [RouterModule]
})


export class AppRoutingModule { }
