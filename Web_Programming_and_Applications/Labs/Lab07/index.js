function loadFiles() {
    fetch("load_files.php")
        .then((response) => {
            if (!response.ok) {
                throw new Error("Error loading files");
            }
            return response.json();
        })
        .then((data) => {
            const tableBody = document.querySelector("tbody");
            tableBody.innerHTML = "";
            data.forEach((file) => {
                const row = document.createElement("tr");
                row.innerHTML = `
                    <td>${chooseTypeIcon(file.type)} ${file.name}</td>
                    <td>${file.type}</td>
                    <td>${file.size}</td>
                    <td>${file.last_modified}</td>
                    <td>
                    <i class="fa fa-download action" onclick="downloadFile('${
                        file.name
                    }')"></i>
                    <i class="fa fa-edit action" onclick="renameFile('${
                        file.name
                    }')"></i>
                    <i class="fa fa-trash action" onclick="deleteFile('${
                        file.name
                    }')"></i>
                    onclick="deleteFile('${file.name}')"></i>
                    </td>
                `;
                tableBody.appendChild(row);
            });
        })
        .catch((error) => console.error("Error:", error));
}

loadFiles();

function chooseTypeIcon(fileType) {
    switch (fileType) {
        case "Folder":
            return '<i class="fa fa-folder"></i>';
        default:
            return '<i class="fas fa-file"></i>';
    }
}

function showNewFolderModal() {
    $("#new-folder-dialog").modal("show");
}

document
    .getElementById("createFolderBtn")
    .addEventListener("click", function () {
        var folderName = document.getElementById("folderName").value;
        createFolder(folderName);
        $("#new-folder-dialog").modal("hide");
    });

function createFolder(foldername) {
    fetch("create_folder.php", {
        method: "POST",
        body: JSON.stringify({ foldername: foldername }),
        headers: {
            "Content-Type": "application/json",
        },
    })
        .then((response) => {
            if (!response.ok) {
                throw new Error("Error creating folder");
            }
            loadFiles();
        })
        .catch((error) => console.error("Error:", error));
}

function showNewFileModal() {
    $("#new-file-dialog").modal("show");
}

function createTextFile(filename, content) {
    fetch("create_text_file.php", {
        method: "POST",
        body: JSON.stringify({ filename: filename, content: content }),
        headers: {
            "Content-Type": "application/json",
        },
    })
        .then((response) => {
            if (!response.ok) {
                throw new Error("Error creating text file");
            }
            loadFiles();
        })
        .catch((error) => console.error("Error:", error));
}

document.addEventListener("DOMContentLoaded", function () {
    document
        .getElementById("createTextFileBtn")
        .addEventListener("click", function () {
            $("#new-text-file-dialog").modal("show");
        });

    document
        .getElementById("createFileBtn")
        .addEventListener("click", function () {
            var fileName = document.getElementById("file-name").value;
            var fileContent = document.getElementById("file-content").value;

            createTextFile(fileName, fileContent);

            $("#new-text-file-dialog").modal("hide");
        });
});

$("#uploadForm").submit(function (e) {
    e.preventDefault();
    var formData = new FormData(this);
    $.ajax({
        url: "upload_file.php",
        type: "POST",
        data: formData,
        success: function (response) {
            alert(response);
            $("#uploadForm")[0].reset();
            loadFiles();
        },
        error: function (error) {
            console.error("Error:", error);
        },
        cache: false,
        contentType: false,
        processData: false,
    });
});

function downloadFile(fileName) {
    fetch("download.php", {
        method: "POST",
        body: JSON.stringify({ folderPath: fileName }),
        headers: {
            "Content-Type": "application/json",
        },
    })
        .then((response) => {
            if (!response.ok) {
                throw new Error("Error downloading file");
            }
        })
        .catch((error) => console.error("Error:", error));
}

function renameFile(oldName) {
    var newName = prompt("Enter the new name for the file:", oldName);
    if (newName === null) {
        return;
    }

    fetch("rename.php", {
        method: "POST",
        body: JSON.stringify({ folderPath: oldName, folderNewName: newName }),
        headers: {
            "Content-Type": "application/json",
        },
    })
        .then((response) => {
            if (!response.ok) {
                throw new Error("Error renaming file");
            }
            loadFiles();
        })
        .catch((error) => console.error("Error:", error));
}

function deleteFile(filePath) {
    var confirmDelete = confirm(
        "Are you sure you want to delete this file/folder?"
    );
    if (!confirmDelete) {
        return;
    }

    fetch("delete_folder.php", {
        method: "POST",
        body: JSON.stringify({ folderPath: filePath }),
        headers: {
            "Content-Type": "application/json",
        },
    })
        .then((response) => {
            if (!response.ok) {
                throw new Error("Error deleting file/folder");
            }
            loadFiles();
        })
        .catch((error) => console.error("Error:", error));
}

$("#uploadForm").submit(function (e) {
    e.preventDefault();
    var formData = new FormData(this);
    $.ajax({
        url: "upload_file.php",
        type: "POST",
        data: formData,
        success: function (response) {
            alert(response.message);
            $("#uploadForm")[0].reset();
            loadFiles();
        },
        error: function (error) {
            console.error("Error:", error);
        },
        cache: false,
        contentType: false,
        processData: false,
    });
});
