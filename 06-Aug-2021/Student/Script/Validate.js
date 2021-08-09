// Document is ready
$(document).ready(function () {
	
    // Validate Firstname
        $('#fnameCheck').hide();
        let firstnameError = true;
        $('#fname').keyup(function () {
            validatefirstname();
        });
        
        function validatefirstname() {
        let fnameValue = $('#fname').val();
        if (fnameValue.length == '') {
        $('#fnameCheck').show();
            firstnameError = false;
            return false;
        }
        else if (fnameValue.length < 3)
        {
            $('#fnameCheck').show();
            $('#fnameCheck').html("**length of Firstname must be greater than 3 characters");
            firstnameError = false;
            return false;
        }
        else {
            $('#fnameCheck').hide();
        }
        }

        $('#lnameCheck').hide();
        let lastnameError = true;

        function validatelastname() {
            let lnameValue = $('#lname').val();
            if (lnameValue.length == '') {
                $('#lnameCheck').show();
                lastnameError = false;
                return false;
            }
            else {
                $('#lnameCheck').hide();
            }
            }
    
    // Validate Email
        const email =document.getElementById('email');

        email.addEventListener('blur', ()=>{
        let regex = /^([_\-\.0-9a-zA-Z]+)@([_\-\.0-9a-zA-Z]+)\.([a-zA-Z]){2,7}$/;

        let em = email.value;

        if(regex.test(em)){
            email.classList.remove('is-invalid');
            emailError = true;
        }
        else{
                email.classList.add('is-invalid');
                emailError = false;
        }
        })

        
    // Submitt button
        $('#submit').click(function () {
            validatefirstname();
            validateEmail();
            validatelastname();
            if ((firstnameError == true) &&
                ( lastnameError == true) &&
                (emailError == true)) {
                return true;
            } else {
                return false;
            }
        });
    });
    