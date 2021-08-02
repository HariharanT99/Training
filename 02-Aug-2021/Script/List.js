
// Click cheked
var list = document.querySelector('ul');
list.addEventListener('dblclick', function(ev) {
  if (ev.target.tagName === 'LI') {
    ev.target.classList.toggle('checked');
  }
}, false);


// Add item
function newElement() 
{
  var li = document.createElement("li");
  var inputValue = document.getElementById("myInput").value;
  var t = document.createTextNode(inputValue);
  li.appendChild(t);
  if (inputValue === '') 
  {
    alert("You must write something!");
  } 
  else 
  {
    document.getElementById("myUl").appendChild(li);
  }
  document.getElementById("myInput").value = "";

}

// Clear

function clearChecked()
{

}