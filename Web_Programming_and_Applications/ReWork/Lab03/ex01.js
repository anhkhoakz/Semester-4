function showErrorMessage(message) {
    let error = document.getElementsByClassName("errorMessage")[0];
    if (
        (message == null || message == undefined) &&
        !error.classList.contains("d-none")
    ) {
        error.classList.add("d-none");
    } else {
        error.classList.remove("d-none");
        error.innerHTML = message;
    }
}

function validateInput() {
    let emailField = document.getElementById("email");
    let passwordField = document.getElementById("pwd");
    let email = emailField.value;
    let password = passwordField.value;

    if (email == null || email == "") {
        showErrorMessage("Please enter your email address");
        return false;
    }
    if (!email.includes("@")) {
        showErrorMessage("Please enter a valid email address");
        return false;
    }
    if (password == null || password == "") {
        showErrorMessage("Please enter your password");
        return false;
    }

    if (password.length < 6) {
        showErrorMessage("Your password must contain at least 6 characters");
        return false;
    }

    showErrorMessage(null);
    return true;
}
