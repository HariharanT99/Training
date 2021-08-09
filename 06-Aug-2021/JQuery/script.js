const studentList = []

class Student
{
    constructor(userName, email, password, firstName, lastName, gender, address)
    {
        this.userName = userName
        this.email = email
        this.password = password
        this.firstName = firstName
        this.lastName = lastName
        this.gender = gender
        this.address = address
    }
}

function StudentDetails() 
{
    console.log("tHis")
    let userName = document.getElementById('userName').value
    let firstName = document.getElementById('fname').value
    let lastName = document.getElementById('lname').value
    let password = document.getElementById('password').value
    let email = document.getElementById('email').value
    let address = document.getElementById('address').value
    let gender = document.getElementById('gender')

    var details = new Student(userName, email, password, firstName, lastName, gender, address)

    studentList.push(details)

    localStorage.setItem('studentsInfo',JSON.stringify(studentList))
}

function Display() 
{
    let displayTag = document.getElementById("dis")

    for (let stud of studentList) 
    {
        let detail = 
        `<div class="listStudent">
            <h2> UserName: ${stud.userName}</h2>
            <h3> Name:          ${stud.firstName} ${stud.lastName}<h3>
            <h4> Email:   ${stud.email}<h4>
            <h5> Address:      ${stud.address}<h5>
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