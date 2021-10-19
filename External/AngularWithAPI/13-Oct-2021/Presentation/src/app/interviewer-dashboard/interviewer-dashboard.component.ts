import { Component, OnInit } from '@angular/core';
import { ApplicantServiceService } from '../service/applicant-service.service';

@Component({
  selector: 'app-interviewer-dashboard',
  templateUrl: './interviewer-dashboard.component.html',
  styleUrls: ['./interviewer-dashboard.component.css']
})
export class InterviewerDashboardComponent implements OnInit {

  constructor(public service: ApplicantServiceService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

}
