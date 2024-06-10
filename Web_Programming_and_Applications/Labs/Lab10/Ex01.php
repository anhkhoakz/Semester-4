<?php
if ($_SERVER['REQUEST_METHOD'] !== 'POST') {
    http_response_code(405);
    exit;
}

$targetDir = './uploads/';
$errorMessage = '';

if (!file_exists($targetDir)) {
    mkdir($targetDir, 0777, true);
}

$oringinFileName = $_FILES['document']['name'];

$fileType = strtolower(pathinfo($oringinFileName, PATHINFO_EXTENSION));

if (isset($_POST['fileName']) && $_POST['fileName'] !== '') {
    $fileName = basename($_POST['fileName']) . '.' . $fileType;
} else {
    $fileName = basename($oringinFileName);
}

$targetFile = $targetDir . $fileName;

if (file_exists($targetFile)) {
    $errorMessage = "File already exists.";
}

$maxFileSize = 500 * 1024 * 1024;
if ($_FILES['document']['size'] > $maxFileSize) {
    $errorMessage = "File size exceeds the limit.";
}

$allowedExtensions = array('txt', 'doc', 'docx', 'xls', 'xlsx', 'jpg', 'png', 'mp3', 'mp4', 'pdf', 'rar', 'zip');
if (!in_array($fileType, $allowedExtensions)) {
    $errorMessage = "This file type is not allowed.";
}

if ($errorMessage !== '') {
    echo $errorMessage;
} elseif (move_uploaded_file($_FILES['document']['tmp_name'], $targetFile)) {
    echo "File uploaded successfully.";
} else {
    echo "File upload failed.";
}
