var firstname = document.forms["Contact Form"]["firstname"]; 
var surname = document.forms["Contact Form"]["surname"];
var email = document.forms["Contact Form"]["email address"];
var msg = document.forms["Contact Form"]["msg"];
//declaration of variables based on Contact.cshtml

if (firstname.value = "") //Checking for an empty value, if nothing is provided show error message
{
    window.alert("Please Enter your first name");
    firstname.focus();
    return false;
}

if (surname.value = "") //Checking for an empty value, if nothing is provided show error message
{
    window.alert("Please Enter your surname");
    surname.focus();
    return false;
}

if (email.value = "") //Checking for an empty value, if nothing is provided show error message
{
    window.alert("Please Enter your email address");
    email.focus();
    return false;
}

if (email.value.indexOf("@", 0) < 0) //Checking for an email address value without @ sign, if it is not provided show error message
{
    window.alert("Please enter a valid email address");
    email.focus;
    return false;
}

if (msg.value = "") //Checking for an empty value, if nothing is provided show error message
{
    window.alert("Please enter your message, so that we can process your request");
    message.focus();
    return false;
}

return true; //Checking to see if all fields are filled in 

