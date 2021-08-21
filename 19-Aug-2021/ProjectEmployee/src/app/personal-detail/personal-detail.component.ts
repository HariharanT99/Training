import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { EmployeeService } from '../employee.service';


@Component({
  selector: 'app-personal-detail',
  templateUrl: './personal-detail.component.html',
  styleUrls: ['./personal-detail.component.css']
})
export class PersonalDetailComponent implements OnInit {

  constructor(private empObj: EmployeeService) { }

  countryList: Array<any> = [
    { name: 'Germany', states: ['Duesseldorf', 'Leinfelden-Echterdingen', 'Eschborn'] },
    { name: 'Spain', states: ['Barcelona'] },
    { name: 'USA', states: ['Downers Grove'] },
    { name: 'Mexico', states: ['Puebla'] },
    { name: 'India', states: ['Tamil Nadu','Kerala','Karnataka', 'Maharastra', 'Punjab', 'Uttar Pradesh'] }
  ];

  inputForm: FormGroup;

  states: Array<any>=[];

  changeCountry(count:any) 
  {
    this.states = this.countryList.find(con => con.name == count.target.value).states;
  
  }


  ngOnInit(): void {
    this.inputForm = new FormGroup({
      firstName: new FormControl('', Validators.required),
      lastName: new FormControl('', Validators.required),
      phoneNumber: new FormControl('', Validators.required),
      address: new FormControl('', Validators.required),
      country: new FormControl('', Validators.required),
      state: new FormControl('', Validators.required)
    })
  }

  onNext()
  {
    let fName=this.inputForm.controls.firstName.value;
    let lName=this.inputForm.controls.lastName.value;
    let pNumber=this.inputForm.controls.phoneNumber.value;
    let add=this.inputForm.controls.address.value;
    let con=this.inputForm.controls.country.value;
    let state=this.inputForm.controls.state.value;

    this.empObj.onPersonalDetailTemp(fName,lName,pNumber,add,con,state)
  }
}
