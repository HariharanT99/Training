import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-todo-display',
  templateUrl: './todo-display.component.html',
  styleUrls: ['./todo-display.component.css']
})
export class TodoDisplayComponent implements OnInit {

  taskList: string[] = [];
  constructor() { }

  ngOnInit(): void {
  }

  onDone(index: number){
    this.taskList.forEach(task => {
      if (this.taskList[index] == task)
      {
        this.taskList[index]= `✔ ${task}`
      }
    });
  }
    onRemove(index: number){
      this.taskList.splice(index, 1)
      sessionStorage.setItem('taskList',JSON.stringify(this.taskList))
    };

    onUpdate(task: any)
    {
      this.taskList.push(task)
    }
  

}
