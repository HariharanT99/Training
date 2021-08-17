import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-display-form',
  templateUrl: './display-form.component.html',
  styleUrls: ['./display-form.component.css']
})
export class DisplayFormComponent implements OnInit {

  
  @Input() ProfileList:any;

  constructor() { }

  ngOnInit(): void {
  }

}
