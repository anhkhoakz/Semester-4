/*
I split this file into multiple functions to make it easier to read and understand.
*/

function addStudent() {
    let firstName = document.getElementById("firstname").value;
    let lastName = document.getElementById("lastname").value;
    let email = document.getElementById("email").value;

    let errorMessage = validateInput(firstName, lastName, email);

    if (errorMessage !== "") {
        alert(errorMessage);
        return;
    }

    appendStudentToTable(firstName, lastName, email);
    resetForm();
}

function validateInput(firstName, lastName, email) {
    if (!firstName) {
        return "Please enter your first name";
    } else if (!lastName) {
        return "Please enter your last name";
    } else if (!email) {
        return "Please enter your email";
    } else if (!email.includes("@")) {
        return "Your email is not correct";
    }
    return "";
}

function appendStudentToTable(firstName, lastName, email) {
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
}

function resetForm() {
    document.querySelector("form").reset();
}

function removeStudent(aButton) {
    let td = aButton.parentElement;
    let tr = td.parentElement;
    tr.remove();
}
