console.log("Hello world!");

function validateData() {
    let txtEmail = document.getElementById("email");
    let txtPassword = document.getElementById("pwd");

    let email = txtEmail.value;
    let password = txtPassword.value;

    let errorMessage = "";

    if (email == null || email == "") {
        errorMessage = "Please enter your email";
    } else if (!email.includes("@")) {
        errorMessage = "Your email is not correct";
    } else if (password == null || password == "") {
        errorMessage = "Please enter your password";
    } else if (password.length < 6) {
        errorMessage = "Your password must contain at least 6 characters";
    }

    let labelErrorMessage = document.getElementsByClassName("errorMessage")[0]; // what is [0]?

    labelErrorMessage.innerText = errorMessage;

    if (errorMessage != "") {
        labelErrorMessage.classList.remove("d-none");
        return false;
    }

    labelErrorMessage.classList.add("d-none");

    return true;
}
