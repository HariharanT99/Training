import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit {

  taskList: string[] = [];
  
  constructor() { }

  ngOnInit(): void {
  }

  onLoadDisplay(){
    this.taskList = JSON.parse(sessionStorage.getItem('taskList') || '{}');
    console.log(2)
    console.log(this.taskList)
  }

  onAdd(addTask: any){ 
    this.taskList.push(addTask.value)
    addTask.value = null
    sessionStorage.setItem('taskList',JSON.stringify(this.taskList))
  }

  onDone(index: number){
    this.taskList.forEach(task => {
      if (this.taskList[index] == task)  ///foreach(var task in list)
      {
        this.taskList[index]= `✔ ${task}`
      }
    });
  }

  onRemove(index: number){
    this.taskList.splice(index, 1)
    sessionStorage.setItem('taskList',JSON.stringify(this.taskList))
  }

}
