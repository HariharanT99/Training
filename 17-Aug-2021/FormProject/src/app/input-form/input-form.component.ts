import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl, Validators, NgForm } from '@angular/forms';
import { FormServiceService } from '../form-service.service';

@Component({
  selector: 'app-input-form',
  templateUrl: './input-form.component.html',
  styleUrls: ['./input-form.component.css']
})
export class InputFormComponent implements OnInit {

  // fN='';
  // lN='';
  // mbl='';
  // ml='';
  // hA='';
  // coN='';
  // cN='';

  

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
      'phoneNumber':new FormControl(null,Validators.compose([Validators.required,Validators.pattern('')])),

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
    { name: 'India', cities: ['Select State','Tamil Nadu','Kerala','Karnataka', 'Maharastra', 'Punjab', 'Uttar Pradesh'] },
  ];

  cities: any[]=[];

  changeCountry(count:any) 
  {
    this.cities = this.countryList.find(c => c.name == count.target.value).cities;
    //console.log(this.cities);
  
  }

  onSubmit(form:any)
  {
    // this.fN='';
    // this.lN='';
    // this.mbl='';
    // this.ml='';
    // this.hA='';
    // this.coN='';
    // this.cN='';
    this.Profile.emit(this.profileForm.value)
    console.log(this.profileForm.value)
  }

}
