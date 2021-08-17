import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FormServiceService {

  countries: {id: number, name:string}[] = [{id:1,name:'India'},{id:2,name:'America'},{id:3,name:'Australia'},{id:4,name:'China'},{id:5,name:'Japan'}];
  statesIndia: string[] = ['Andhra Pradesh', 'Assam', 'Arunachal Pradesh', 'Bihar', 'Goa', 'Gujarat', 'Jammu and Kashmir', 'Jharkhand', 'West Bengal', 'Karnataka', 'Kerala', 'Madhya Pradesh', 'Maharashtra']
  statesAmerica: string[] = ['Alabama', 'Alaska', 'California', 'Delaware','Georgia','Idaho', 'Indiana','Louisiana', 'Maryland']
  statesAustralia: string[] = ['New South Wales', 'Queensland', 'Northern Territory', 'Western Australia', 'South Australia', 'Victoria', 'Tasmania']
  statesChina: string[] = ['Anhui', 'Chongqing', 'Gansu', 'Hainan', 'Heilongjiang', 'Jiangsu', 'Liaoning', 'Shaanxi', 'Shanxi']
  statesJapan: string[] = ['Hokkaido', 'Tohoku', 'Kanto', 'Chubu', 'Kinki', 'Chugoku', 'Shikoku','Kyushu-Okinawa']


  constructor() { }

  onGetStates(country: any)
  {
    if (country === 'India')
    {
      return this.statesIndia;
    }
    else if (country === "America")
    {
      return this.statesAmerica;
    }

    else if (country === 'Australia')
    {
      return this.statesAustralia;
    }

    else if (country === 'China')
    {
      return this.statesChina;
    }
    else
    {
      return this.statesJapan;
    }
  }

  onGetCountries()
  {
    return this.countries
  }

}
