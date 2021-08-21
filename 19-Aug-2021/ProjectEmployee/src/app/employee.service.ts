import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {


  aplicationDetails: 
  {
    firstName:string, 
    lastName:string, 
    phoneNumber:number, 
    address:string, 
    country:string,
    state:string,
    experienceDetails: {companyName:string, designation:string, startDate:Date, endDate:Date, skill:string}[],
    resume: object
  }[] = [];
  constructor() { }


  fName: string;
  lName: string;
  pNumber: number;
  add: string;
  con: string;
  sta: string;

  onPersonalDetailTemp(fName: string,lName: string,pNumber: number, add: string, con:string,state:string)
  {
    this.fName=fName;
    this.lName=lName;
    this.pNumber=pNumber;
    this.add=add;
    this.con=con;
    this.sta=state;

    console.log(this.fName)
    console.log(this.lName)
    console.log(this.con)
    console.log(this.sta)

  }

  companyDetails: {companyName:string, designation:string, startDate:Date, endDate:Date, skill:string}[];

  onCompanyDetailTemp(comp: {companyName:string, designation:string, startDate:Date, endDate:Date, skill:string}[])
  {
    this.companyDetails=comp;
    console.log(this.companyDetails);
  }

  file: object;

  onfileTemp(fl: object)
  {
    
    this.file=fl;
    this.wholeUpload();
  }

  wholeUpload()
  {
    this.aplicationDetails.push({firstName:this.fName,lastName:this.lName,phoneNumber:this.pNumber,address:this.add,
    country:this.con,state:this.sta,experienceDetails:this.companyDetails,resume:this.file})
    console.log(this.aplicationDetails)
  }

}
