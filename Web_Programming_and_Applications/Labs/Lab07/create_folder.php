<?php
session_start();

if (!isset($_SESSION['user'])) {
    die("Unauthorized access");
}

if (!isset($_POST['folderName'])) {
    die("Full path is not provided");
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $data = json_decode(file_get_contents("php://input"), true);
    $foldername = $data['foldername'];
    $dir = "uploads/";
    mkdir($dir . $foldername);
}
