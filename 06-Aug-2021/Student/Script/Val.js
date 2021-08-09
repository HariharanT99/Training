$(function(){
    var $registrationForm = $("registration");
        $registrationForm.validate({
            rules:{
                firstname:{
                    required: true
                }
            },
            messages:{
                firstname:{
                    required: "Enter the first name"
                }
            }
        })
    
})