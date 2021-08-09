
var $registrationForm = $('#registration');
if($registrationForm.length){
  $registrationForm.validate({
      rules:{
          username: {
              required: true,
          },
          email: {
              required: true,
          },
          password: {
              required: true,
              minlength: 6
          },
          confirm: {
              required: true,
              equalTo: '#password'
          },
          fname: {
              required: true,
          },
          lname: {
              required: true,
          },
          gender: {
              required: true
          },
          address: {
              required: true
          }
      },
      messages:{
          username: {
              required: 'Please enter username!'
          },
          email: {
              required: 'Please enter email!',
              email: 'Please enter valid email!'
          },
          password: {
              required: 'Please enter password!',
              minlength: "Password must have atleast 6 characters"
          },
          confirm: {
              required: 'Please enter confirm password!',
              equalTo: 'Please enter same password!'
          },
          fname: {
              required: 'Please enter first name!'
          },
          lname: {
              required: 'Please enter last name!'
          },
          country: {
              required: 'Please select country!'
          },
          address: {
              required: 'Please enter address!'
          }
      },
      errorPlacement: function(error, element) 
      {
        if (element.is(":radio")) 
        {
            error.appendTo(element.parents('.gender'));
        }
        else 
        { 
            error.insertAfter( element );
        }
        
       }
  });
}