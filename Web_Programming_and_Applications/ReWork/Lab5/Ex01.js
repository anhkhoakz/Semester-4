async function loadStudents() {
    const response = await fetch("http://localhost:3000/students");
    const students = await response.json();
    displayStudents(students);
}

function displayStudents(students) {
    let tbody = document.querySelector("tbody");
    tbody.innerHTML = "";

    students.forEach((student) => {
        let tr = document.createElement("tr");
        let state = student.state === "pending" ? "Pending" : "Completed";
        let stateColor = student.state === "pending" ? "warning" : "success";
        tr.innerHTML = `
            <td>${student.id}</td>
            <td>${student.name}</td>
            <td>${student.age}</td>
            <td><span class="badge badge-${stateColor}">${state}</span></td>
            <td>
                <button class="btn btn-sm btn-outline-primary" onclick="changeState(${student.id})">Change</button>
                <button class="btn btn-sm btn-outline-danger" onclick="deleteStudent(${student.id})">Delete</button>
            </td>
        `;
        tbody.appendChild(tr);
    });
}

loadStudents();

function validateInput() {
    let form = document.querySelector("form");
    let nameField = document.querySelector("#fullname");
    let ageField = document.querySelector("#age");
    let stateField = document.querySelector("#state");

    form.addEventListener("submit", (e) => {
        e.preventDefault();

        let name = nameField.value.trim();
        let age = ageField.value;
        let state = stateField.value;

        if (name === "") {
            nameField.focus();
            return alert("Please enter student name");
        }
        const data = {
            id: Math.round(Math.random() * 1000),
            name: name,
            age: parseInt(age),
            state: state.toLowerCase(),
        };
        addStudent(data);
    });
}

async function addStudent(student) {
    const response = await fetch("http://localhost:3000/students", {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(student),
    });
    if (response.ok) {
        loadStudents();
    }
}

async function changeState(studentID) {
    const response = await fetch(`http://localhost:3000/students/${studentID}`);
    const student = await response.json();
    student.state = student.state === "pending" ? "completed" : "pending";

    const updateResponse = await fetch(
        `http://localhost:3000/students/${studentID}`,
        {
            method: "PUT",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(student),
        }
    );
    if (updateResponse.ok) {
        loadStudents();
    }
}

async function deleteStudent(studentID) {
    const response = await fetch(
        `http://localhost:3000/students/${studentID}`,
        {
            method: "DELETE",
        }
    );
    if (response.ok) {
        loadStudents();
    }
}
