function checkPassword() {
    let passwordField = document.getElementById("password");
    let password = passwordField.value;

    if (password.length < 8) {
        alert("Password must be at least 8 characters long.");
        passwordField.focus();
        return false;
    }
}
