$(".custom-file-input").on("change", function () {
    let fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});

$("form").submit(function (event) {
    event.preventDefault();
    $("#error-message").addClass("d-none").empty();

    let fileInput = $(".custom-file-input")[0];
    let file = fileInput.files[0];

    let numFiles = fileInput.files.length;

    if (numFiles === 0) {
        $("#error-message").text("Please select a file").removeClass("d-none");
        return;
    }
    if (numFiles > 1) {
        $("#error-message")
            .text("Please select only one file")
            .removeClass("d-none");
        return;
    }

    let reader = new FileReader();
    reader.onloadend = function () {
        let fileSize = reader.result.byteLength;
        console.log("File size: " + fileSize + " bytes");

        if (fileSize > 500 * 1028 * 1028) {
            $("#error-message")
                .text("File size exceeds the limit")
                .removeClass("d-none");
            return;
        }
    };

    let fileType = file.name.split(".");
    fileType = fileType[fileType.length - 1];

    if (
        ![
            "txt",
            "plain",
            "doc",
            "docx",
            "xls",
            "xlsx",
            "jpg",
            "png",
            "mp3",
            "mp4",
            "pdf",
            "rar",
            "zip",
        ].includes(fileType)
    ) {
        $("#error-message").text("Invalid file type").removeClass("d-none");
        return;
    }

    let xhr = new XMLHttpRequest();
    xhr.open("POST", "http://localhost/Lab10/Ex01.php", true);

    xhr.upload.addEventListener("progress", function (event) {
        if (event.lengthComputable) {
            let percentComplete = (event.loaded / event.total) * 100;
            $(".progress-bar").css("width", percentComplete + "%");
            $(".progress-bar").attr("aria-valuenow", percentComplete);
        }
    });

    xhr.onreadystatechange = function () {
        if (xhr.readyState === XMLHttpRequest.DONE) {
            if (xhr.status === 200) {
                if (xhr.responseText.includes("successfully")) {
                    alert(xhr.responseText);
                } else {
                    $("#error-message")
                        .text(xhr.responseText)
                        .removeClass("d-none");
                }
            } else {
                $("#error-message")
                    .text("An error occurred: " + xhr.statusText)
                    .removeClass("d-none");
            }
        }
    };

    let formData = new FormData(this);
    formData.append("file", file);

    xhr.send(formData);
});
