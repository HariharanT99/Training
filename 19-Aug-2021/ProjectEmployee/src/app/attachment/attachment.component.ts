import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-attachment',
  templateUrl: './attachment.component.html',
  styleUrls: ['./attachment.component.css']
})
export class AttachmentComponent implements OnInit {

  constructor() { }

  attachmentForm: FormControl;

  ngOnInit(): void {
    this.attachmentForm = new FormControl(Object)
  }


  msg='';
  file:object;
  onSelectFile(event: any) {
		if(!event.target.files[0] || event.target.files[0].length == 0) {
			this.msg = 'You must select an image';
			return;
		}
		
		var fileType = event.target.files[0].type;
		
		if (fileType.match(/pdf\/*/) == null) {
			this.msg = "Only pdf are supported";
			return;
		}
    this.file= event.target.files
		console.log(this.file)
	}

  onSubmit()
  {
    
  }
}
