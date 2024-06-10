<?php
$targetDir = "uploads/";
if (!file_exists($targetDir)) {
    mkdir($targetDir, 0777, true);
}

$targetFile = $targetDir . basename($_FILES["fileToUpload"]["name"]);
$uploadOk = 1;
$fileType = strtolower(pathinfo($targetFile, PATHINFO_EXTENSION));

if (file_exists($targetFile)) {
    echo json_encode(array('message' => 'File already exists'));
    exit;
}

if ($_FILES["fileToUpload"]["size"] > 20000000) {
    echo json_encode(array('message' => 'File is too large'));
    exit;
}

$allowedExtensions = array("jpg", "png", "txt");
if (!in_array($fileType, $allowedExtensions)) {
    echo json_encode(array('message' => 'File type is not allowed'));
    exit;
}

if (move_uploaded_file($_FILES["fileToUpload"]["tmp_name"], $targetFile)) {
    echo json_encode(array('message' => 'File uploaded successfully'));
} else {
    echo json_encode(array('message' => 'Error uploading file'));
}
