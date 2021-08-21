import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators, FormBuilder, FormArray } from '@angular/forms';
import { EmployeeService } from '../employee.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-professional-detail',
  templateUrl: './professional-detail.component.html',
  styleUrls: ['./professional-detail.component.css']
})
export class ProfessionalDetailComponent implements OnInit {

  constructor(private fb: FormBuilder, private empObj: EmployeeService,  private _router: Router) { }


  professionalForm: FormGroup;

  ngOnInit(): void {
    this.professionalForm = this.fb.group({
      professionalList: this.fb.array([
        this.onAddCompanyGroup()
      ])
  })
  console.log(this.professionalForm)
}

onAddCompanyGroup(): FormGroup
{
  return this.fb.group({
  companyName:['', Validators.required],
  designation: ['', Validators.required],
  startDate: ['', Validators.required],
  endDate: ['', Validators.required],
  skill: ['', Validators.required]
  });
}

  CompanyList: {companyName:string, designation:string, startDate:Date, endDate:Date, skill:string}[] = [];

  cName: string;
  designation:string;
  startDate:Date;
  endDate:Date;
  skill:string;

  onPushCompanyList()
  {
    this.cName=this.professionalForm.get('professionalList').value[0].companyName
    this.designation=this.professionalForm.get('professionalList').value[0].designation
    this.startDate=this.professionalForm.get('professionalList').value[0].startDate
    this.endDate=this.professionalForm.get('professionalList').value[0].endDate
    this.skill=this.professionalForm.get('professionalList').value[0].skill
    
    this.CompanyList.push({companyName:this.cName,designation:this.designation,startDate:this.startDate,endDate:this.endDate,skill:this.skill})
  }

  onAddCompany():void
  {
    this.onPushCompanyList()

    console.log(this.CompanyList);


    (<FormArray>this.professionalForm.get('professionalList')).push(this.onAddCompanyGroup())
  }


  onNext()
  {
    this.onPushCompanyList();
    this.empObj.onCompanyDetailTemp(this.CompanyList);

    this._router.navigate(['/attachment']);
  }
}
