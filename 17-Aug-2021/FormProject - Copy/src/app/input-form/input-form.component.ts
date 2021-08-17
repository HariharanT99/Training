import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, NgForm } from '@angular/forms';
import { FormServiceService } from '../form-service.service';

@Component({
  selector: 'app-input-form',
  templateUrl: './input-form.component.html',
  styleUrls: ['./input-form.component.css']
})
export class InputFormComponent implements OnInit {

  countries: {id: number, name:string}[] =[];
  states: string[]=[];

  i: number=0;
   
  profileForm: FormGroup;


  get detail()
  {
    return this.profileForm.controls;
  }

  constructor(private formservice: FormServiceService) { }

  ngOnInit(): void {
    this.countries = this.formservice.onGetCountries();

    this.profileForm = new FormGroup({
      'fname': new FormControl(null),
      'lname': new FormControl(null),
      'pnumber': new FormControl(null),
      'email': new FormControl(null),
      'address': new FormControl (null),
      'country': new FormControl (null),
      'state': new FormControl (null)
    })
  }

  onSelect(country: any)
  {
    let con = country.target.value; 
    this.states = this.formservice.onGetStates(con);
  }

  onAdded()
  {
    console.log('Done')
  }
}
