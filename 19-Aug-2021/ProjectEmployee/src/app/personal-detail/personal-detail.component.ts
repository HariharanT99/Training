import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, } from '@angular/forms';


@Component({
  selector: 'app-personal-detail',
  templateUrl: './personal-detail.component.html',
  styleUrls: ['./personal-detail.component.css']
})
export class PersonalDetailComponent implements OnInit {

  constructor() { }

  countryList: Array<any> = [
    { name: 'Germany', cities: ['Select State','Duesseldorf', 'Leinfelden-Echterdingen', 'Eschborn'] },
    { name: 'Spain', cities: ['Select State','Barcelona'] },
    { name: 'USA', cities: ['Select State','Downers Grove'] },
    { name: 'Mexico', cities: ['Select State','Puebla'] },
    { name: 'India', cities: ['Select State','Tamil Nadu','Kerala','Karnataka', 'Maharastra', 'Punjab', 'Uttar Pradesh'] },
  ];


  cities: Array<any>=[];

  changeCountry(count:any) 
  {
    this.cities = this.countryList.find(con => con.name == count.target.value).cities;
  
  }


  ngOnInit(): void {
    console.log(this.countryList)
  }



}
