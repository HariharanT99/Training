const task = []


var close = document.getElementsByClassName("close");

document.querySelector('#btnAdd').addEventListener('click', function(){
  if (!(document.getElementById('input').value === ''))
  {
    var list = document.getElementById('myUl')
    list.innerHTML = ''; 

    var todoInput = document.getElementById('input').value
    task.push(todoInput)
    document.getElementById('input').value = ""
   
    for (var i = 0; i < task.length; i++) 
    {
        var listItem = document.createTextNode(task[i]);
        var li = document.createElement("li");
     li.appendChild(listItem)
     list.append(li)

     var span = document.createElement("SPAN");
     var txt = document.createTextNode("\u00D7");
     span.className = "close"
     span.appendChild(txt)
     li.appendChild(span)

     for (var i = 0; i < close.length; i++) 
     {
      close[i].onclick = function() 
      {
        var div = this.parentElement
        div.style.display = "none"
      }
     }
    }

    Store()
  }
  else
  {
    alert("Enter the Task")
  }
})

var list = document.querySelector('ul');
list.addEventListener('dblclick', function(ev) {
  if (ev.target.tagName === 'LI') {
    ev.target.classList.toggle('checked');
  }
}, false);

function Store(){
  localStorage.setItem('task', JSON.stringify(task))
}
