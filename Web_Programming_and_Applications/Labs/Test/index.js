async function validateLogin() {
    let username = document.getElementById("user")
    username = username.value;
    let password = document.getElementById("password");
    password = password.value
    // console.log(username, password);
    let data = {
        "username": username,
        "password": password
    }
    let response = await fetch("http://localhost:8080/Test/loginFunction.php", {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(data)
    });

    let responseData = await response;
    if (responseData) {
        window.location.href = "index.php";
    }
}