import { Component, OnInit,EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-todo-input',
  templateUrl: './todo-input.component.html',
  styleUrls: ['./todo-input.component.css']
})
export class TodoInputComponent implements OnInit {

  task = '';

  @Output() onTaskAdded = new EventEmitter<string>();

  // taskList: string[] = [];
  constructor() { }

  ngOnInit(): void {
  }

  onAdd(){ 
    this.onTaskAdded.emit(this.task)
  }
}
