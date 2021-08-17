import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl, Validators, NgForm } from '@angular/forms';
import { FormServiceService } from '../form-service.service';

@Component({
  selector: 'app-input-form',
  templateUrl: './input-form.component.html',
  styleUrls: ['./input-form.component.css']
})
export class InputFormComponent implements OnInit {

  fName='';
  lName='';
  mobile=0;
  mail='';
  homeAdd='';
  countryName='';
  cityName='';

  

  @Output() Profile:any=new EventEmitter<{firstName:string,lastName:string,phoneNumber:number,emailId:string,address:string,country:string,city:string}>();

  onAddProfile()
  {
    // this.Profile.emit({firstName:this.firstName,lastName:this.lastName,phoneNumber:this.phoneNumber,emailId:this.emailId,address:this.})
  }


  profileForm:FormGroup;

  ngOnInit(): void 
  {
    this.profileForm=new FormGroup({
      // 'profileData':new FormGroup({
      'firstName':new FormControl(null,Validators.required),
      'lastName':new FormControl(null,Validators.required),
      'phoneNumber':new FormControl(null,Validators.compose([Validators.required,Validators.pattern('[- +()0-9]+')])),

      'emailId':new FormControl(null, Validators.compose([
        Validators.required,
        Validators.pattern('^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$')
      ])),
      'Address':new FormControl(null,Validators.required),
      'Country':new FormControl(null,Validators.required),
      'City':new FormControl(null,Validators.required),


    // })
    });
  }

  constructor() { }

  countryList: Array<any> = [
    { name: 'Germany', cities: ['Select State','Duesseldorf', 'Leinfelden-Echterdingen', 'Eschborn'] },
    { name: 'Spain', cities: ['Select State','Barcelona'] },
    { name: 'USA', cities: ['Select State','Downers Grove'] },
    { name: 'Mexico', cities: ['Select State','Puebla'] },
    { name: 'India', cities: ['Select State','Tamil Nadu','Kerala','Karnataka'] },
  ];

  cities: Array<any>=[];

  changeCountry(count:any) 
  {
    this.cities = this.countryList.find(con => con.name == count.target.value).cities;
    //console.log(this.cities);
  
  }

  onSubmit(form:any)
  {
    this.lName='';
    this.mobile=0;
    this.mail='';
    this.homeAdd='';
    this.countryName='';
    this.cityName='';
    this.fName='';
    this.Profile.emit(this.profileForm.value)
    console.log(this.profileForm.value)
  }

}
