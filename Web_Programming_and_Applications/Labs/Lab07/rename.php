<?php
session_start();

if (!isset($_SESSION['user'])) {
    die("Unauthorized access");
}

if (!isset($_POST['folderPath']) || !isset($_POST['folderNewName'])) {
    die("Full path or new name is not provided");
}

$oldPath = $_POST['folderPath'];
$newName = $_POST['folderNewName'];

$dirPath = dirname($oldPath);
$newPath = $dirPath . '/' . $newName;

if (rename($oldPath, $newPath)) {
    echo "File renamed successfully";
} else {
    echo "Error renaming file";
}
