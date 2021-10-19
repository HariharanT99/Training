import { Injectable } from '@angular/core';
import { Applicant } from '../model/applicant';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ApplicantServiceService {

  constructor(private http: HttpClient) { }

  formData: Applicant = new Applicant();
  readonly baseURL = 'https://localhost:44339/Applicant';

  list: Applicant[]=[];

  refreshList(): void
  {
    this.http.get(this.baseURL)
    .subscribe(Response => {
      this.list = Object.values(Response);
      console.log(Response);
      });
  }
}
