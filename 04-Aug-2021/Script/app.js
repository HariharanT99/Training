const studentList = []

class Student
{
    constructor(firstName, lastName, regNumber, dateOfBirth, std)
    {
        this.firstName = firstName
        this.lastName = lastName
        this.regNumber = regNumber
        this.dateOfBirth = dateOfBirth
        this.std = std
    }
}

function StudentDetails() 
{
    let firstName = document.getElementById('fname').value
    let lastName = document.getElementById('lname').value
    let regNumber = document.getElementById('rnumber').value
    let dateOfBirth = document.getElementById('dob').value
    let std = document.getElementById('std').value

    var details = new Student(firstName, lastName, regNumber, dateOfBirth, std)

    studentList.push(details)

    localStorage.setItem('studentsInfo',JSON.stringify(studentList))

    document.getElementById('fname').value = ""
    document.getElementById('lname').value = ""
    document.getElementById('rnumber').value = ""
    document.getElementById('dob').value = ""
    document.getElementById('std').value = "Std"

}

function Display() 
{
    let displayTag = document.getElementById("dis")

    for (let stud of studentList) 
    {
        let detail = 
        `<div class="listStudent">
            <h3> Name:          ${stud.firstName} ${stud.lastName}<h3>
            <h4> Reg. Number:   ${stud.regNumber}<h4>
            <h5> Standard:      ${stud.std}<h5>
            <h5> Date of Birth: ${stud.dateOfBirth}<h5>
        </div>`
        displayTag.insertAdjacentHTML("afterbegin", detail)   
    }
}

/*

function Reload() 
{
    const tempList = localStorage.getItem('studentsInfo')
    let displayTag = document.getElementById("dis")

    if (!(tempList == null))
    {
        for (let stud of tempList) 
        {
            let detail = 
            `<div class="listStudent">
                <h3> Name:          ${stud.firstName} ${stud.lastName}<h3>
                <h4> Reg. Number:   ${stud.regNumber}<h4>
                <h5> Standard:      ${stud.std}<h5>
                <h5> Date of Birth: ${stud.dateOfBirth}<h5>
            </div>`
            displayTag.insertAdjacentHTML("afterbegin", detail)   
        }
    }   
}*/