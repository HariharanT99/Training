$(document).ready(function() {
    $("#basic-form").validate({
      errorClass: "error fail-alert",
      validClass: "valid success-alert",
      rules: {
        fname : {
          required: true,
          minlength: 3
        },
        email: {
          required: true,
          email: true
        },
      },
      messages : {
        name: {
          minlength: "Name should be at least 3 characters"
        },
        email: {
          email: "The email should be in the format: abc@domain.tld"
        },
      }
    });
  });