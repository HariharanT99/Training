import { Component, OnInit } from '@angular/core';
import { ApplicantService } from 'src/app/service/applicant.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
  
})
export class DashboardComponent implements OnInit {

  constructor(public service: ApplicantService) { }

  ngOnInit(): void {
  }

  columns = [{ prop: 'name' }, { name: 'Company' }, { name: 'Gender' }];
  rows = [    { name: 'Austin', gender: 'Male', company: 'Swimlane' },    { name: 'Dany', gender: 'Male', company: 'KFC' },    { name: 'Molly', gender: 'Female', company: 'Burger King' }  ];

}
