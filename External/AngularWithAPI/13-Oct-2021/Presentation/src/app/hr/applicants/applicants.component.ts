import { Component, OnInit } from '@angular/core';
import { ApplicantService } from 'src/app/service/applicant.service';

@Component({
  selector: 'app-applicants',
  templateUrl: './applicants.component.html',
  styleUrls: ['./applicants.component.css']
})
export class ApplicantsComponent implements OnInit {

  constructor(private service: ApplicantService) { }

  ngOnInit(): void {
  }


}
