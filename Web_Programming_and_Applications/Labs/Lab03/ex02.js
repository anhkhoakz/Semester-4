function addStudent() {
    let txtFirstName = document.getElementById("firstname");
    let txtLastName = document.getElementById("lastname");
    let txtEmail = document.getElementById("email");

    let firstName = txtFirstName.value;
    let lastName = txtLastName.value;
    let email = txtEmail.value;

    let errorMessage = "";

    if (firstName == null || firstName === "") {
        errorMessage = "Please enter your first name";
    } else if (lastName == null || lastName === "") {
        errorMessage = "Please enter your last name";
    } else if (email == null || email === "") {
        errorMessage = "Please enter your email";
    } else if (!email.includes("@")) {
        errorMessage = "Your email is not correct";
    }

    let tbody = document.getElementsByTagName("tbody")[0];

    let tr = document.createElement("tr");

    let td1 = document.createElement("td");
    td1.innerText = firstName;
    tr.appendChild(td1);

    let td2 = document.createElement("td");
    td2.innerText = lastName;
    tr.appendChild(td2);

    let td3 = document.createElement("td");
    td3.innerText = email;
    tr.appendChild(td3);

    let td4 = document.createElement("td");
    td4.innerHTML = `<button onclick="removeStudent(this)" class="btn btn-danger btn-sm">Delete</button>`;
    tr.appendChild(td4);

    tbody.appendChild(tr);

    resetForm();
}

function removeStudent(aButton) {
    let td = aButton.parentElement;
    let tr = td.parentElement;
    tr.remove();
}

function resetForm() {
    document.querySelector("form").reset();
}
