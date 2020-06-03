var email = document.forms['vform']['email'];
var password = document.forms['vform']['password'];

var email_error = document.getElementById('email_error');
var password_error = document.getElementById('password_error');

email.addEventListener('blur', emailVerify, true);
password.addEventListener('blur', passwordVerify, true);
function Validate() {
 // validate email
 if (email.value == "") {
    email.style.border = "1px solid red";
    document.getElementById('email_div').style.color = "red";
    email_error.textContent = "Invalid Email";
    email.focus();
    return false;
  }
  // validate password
  if (password.value == "") {
    password.style.border = "1px solid red";
    document.getElementById('password_div').style.color = "red";
    password_error.textContent = "Incorrect password!";
    password.focus();
    return false;
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
        document.getElementById('password_div').style.color = "#5e6e66";
        password_error.innerHTML = "";
        return true;
    }}}