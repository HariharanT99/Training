import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Applicant } from '../model/applicant';

@Injectable({
  providedIn: 'root'
})
export class ApplicantService {

  constructor(private http: HttpClient) { }

  formData: Applicant = new Applicant();
  readonly baseURL = 'https://localhost:44339/Applicant';

  applicantList: Applicant[]=[];

  bllist: number[]= [1,34,44,2];

  refreshList(): void
  {
    this.http.get(this.baseURL)
    .subscribe(Response => {
      this.applicantList = Object.values(Response);
      console.log(Response);
      });
  }
}
