// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//function onAddSkill()
//{
//    let displayTag = document.getElementById("skillinput");

//    let detail = '<select asp-for="SkillName" asp-items="@ViewBag.skillDropdown" class="form-control mb-3">< option selected = "" >Select</option ></select >'


//    displayTag.insertAdjacentHTML("beforebegin", detail)

//    //var cls = document.createElement("input")

//    //var atr = document.createAttribute('asp-for="Skills"')

//    //cls.appendChild(atr)

//    //input.append(cls)

//}

function updatemark(arg) {
    var skill = ""
    //Iterating the collection of checkboxes which checked marked  
    $('input[type=checkbox]').each(function () {
        if (this.checked) {
            skill = skill + $(this).val() + " "
            //assign set value to hidden field   
            $('#SkillName').val(skill);
        }
    });
}