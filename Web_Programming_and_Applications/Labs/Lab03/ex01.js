console.log("Hello world!");

function validateData() {
    let txtEmail = document.getElementById("email");
    let txtPassword = document.getElementById("pwd");

    let email = txtEmail.value.trim();
    let password = txtPassword.value.trim();
    // Use trim() to remove leading and trailing whitespaces for a clean input

    let errorMessage = "";

    if (!email) {
        errorMessage = "Please enter your email";
    } else if (!email.includes("@")) {
        errorMessage = "Your email is not correct";
    } else if (!password) {
        errorMessage = "Please enter your password";
    } else if (password.length < 6) {
        errorMessage = "Your password must contain at least 6 characters";
    }

    let labelErrorMessage = document.getElementsByClassName("errorMessage")[0];

    labelErrorMessage.innerText = errorMessage;

    if (errorMessage) {
        labelErrorMessage.classList.remove("d-none");
        return false;
    }

    labelErrorMessage.classList.add("d-none");

    return true;
}
