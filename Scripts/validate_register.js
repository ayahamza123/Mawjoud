var first_name = document.forms['vform']['first-name'];
var last_name = document.forms['vform']['last-name'];
var email = document.forms['vform']['email'];
var password = document.forms['vform']['password'];
var password_confirm = document.forms['vform']['password_confirm'];
// SELECTING ALL ERROR DISPLAY ELEMENTS
var first_name_error = document.getElementById('first-name_error');
var last_name_error = document.getElementById('last-name_error');
var email_error = document.getElementById('email_error');
var password_error = document.getElementById('password_error');
// SETTING ALL EVENT LISTENERS
first_name.addEventListener('blur', firstVerify, true);
last_name.addEventListener('blur', lastVerify, true);
email.addEventListener('blur', emailVerify, true);
password.addEventListener('blur', passwordVerify, true);
// validation function
function Validate() {
  // validate firstname
  var regName = /^[a-zA-Z\s]+$/;
  if (first_name.value == ""||first_name.value.length<3) {
    first_name.style.border = "1px solid red";
    document.getElementById('first-name_div').style.color = "red";
    first_name_error.textContent = "First must contain more than 3 caracter";
    first_name.focus();
    return false;
  }else if(!regName.test(first_name.value)){
  first_name.style.border = "1px solid red";
  document.getElementById('first-name_div').style.color = "red";
  first_name_error.textContent = "First name must contain only alphabetic";
  first_name.focus();
  return false;}

    // validate lastname
    if (last_name.value == "") {
        last_name.style.border = "1px solid red";
        document.getElementById('last-name_div').style.color = "red";
        last_name_error.textContent = "last name is required";
        last_name.focus();
        return false;
      }else if(!regName.test(last_name.value)){
        last_name.style.border = "1px solid red";
        document.getElementById('first-name_div').style.color = "red";
        last_name_error.textContent = "Last name must contain only alphabetic";
        last_name.focus();
        return false;}

  // validate email
  if (email.value == "") {
    email.style.border = "1px solid red";
    document.getElementById('email_div').style.color = "red";
    email_error.textContent = "Email is required";
    email.focus();
    return false;
  }
  // validate password
  if (password.value == "" || password.value.length<6) {
    password.style.border = "1px solid red";
    document.getElementById('password_div').style.color = "red";
    password_confirm.style.border = "1px solid red";
    password_error.textContent = "Password must contain more then 6 caractere";
    password.focus();
    return false;
  }
  // check if the two passwords match
  if (password.value != password_confirm.value) {
    password.style.border = "1px solid red";
    document.getElementById('pass_confirm_div').style.color = "red";
    password_confirm.style.border = "1px solid red";
    password_error.innerHTML = "The two passwords do not match";
    return false;
  }
}
// event handler functions
function firstVerify() {
  if (first_name.value != "") {
   first_name.style.border = "1px solid #5e6e66";
   document.getElementById('first-name_div').style.color = "#5e6e66";
   first_name_error.innerHTML = "";
   return true;
  }
}function lastVerify() {
    if (last_name.value != "") {
     last_name.style.border = "1px solid #5e6e66";
     document.getElementById('last-name_div').style.color = "#5e6e66";
     last_name_error.innerHTML = "";
     return true;
    }
  }
function emailVerify() {
  if (email.value != "") {
  	email.style.border = "1px solid #5e6e66";
  	document.getElementById('email_div').style.color = "#5e6e66";
  	email_error.innerHTML = "";
  	return true;
  }
}
function passwordVerify() {
  if (password.value != "") {
  	password.style.border = "1px solid #5e6e66";
  	document.getElementById('pass_confirm_div').style.color = "#5e6e66";
  	document.getElementById('password_div').style.color = "#5e6e66";
  	password_error.innerHTML = "";
  	return true;
  }
  if (password.value === password_confirm.value) {
  	password.style.border = "1px solid #5e6e66";
  	document.getElementById('pass_confirm_div').style.color = "#5e6e66";
  	password_error.innerHTML = "";
  	return true;
  }
}