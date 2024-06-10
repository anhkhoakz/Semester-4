function addStudent() {
    let firstNameField = document.getElementById("firstname");
    let lastNameField = document.getElementById("lastname");
    let emailField = document.getElementById("email");

    let firstname = firstNameField.value;
    let lastname = lastNameField.value;
    let email = emailField.value;

    // TODO: Validate Input

    let tr = document.createElement("tr");
    let td1 = document.createElement("td");
    let td2 = document.createElement("td");
    let td3 = document.createElement("td");
    let td4 = document.createElement("td");

    td1.textContent = firstname;
    td2.textContent = lastname;
    td3.textContent = email;
    td4.innerHTML =
        '<button class="btn btn-danger btn-sm" onclick="removeStudent(this)">Delete</button>';

    tr.append(td1, td2, td3, td4);

    let tbody = document.querySelector("tbody");

    tbody.appendChild(tr);

    firstNameField.value = "";
    lastNameField.value = "";
    emailField.value = "";
    firstNameField.focus();
}

function removeStudent(element) {
    td = element.parentElement;
    tr = td.parentElement;
    tr.remove();
}
