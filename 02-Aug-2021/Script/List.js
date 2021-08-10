const task = []


var close = document.getElementsByClassName("close");

document.querySelector('#btnAdd').addEventListener('click', function(){
  if ((document.getElementById('input').value !== ''))
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
        // <li>String</li>
     li.appendChild(listItem)  
     list.append(li)

     var span = document.createElement("SPAN"); // <span>x</span>
     var txt = document.createTextNode("\u00D7");
     span.className = "close"
     span.appendChild(txt)
     li.appendChild(span)

     for (var i = 0; i < close.length; i++) 
     {
      close[i].onclick = function() 
      {
        var dv = this.parrentElement
        dv.style.display = "none"
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
list.addEventListener('dblclick', function(item) {
  if (item.target.tagName === 'LI') {
    item.target.classList.toggle('checked');
  }
});

function Store(){
  localStorage.setItem('task', JSON.stringify(task))
}
