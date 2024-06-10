<?php
session_start();

// Check if the user is authenticated
if (!isset($_SESSION['user'])) {
    die("Unauthorized access");
}

// Check if the full path is provided via POST request
if (!isset($_POST['folderPath'])) {
    die("Full path is not provided");
}

$fullPath = $_POST['folderPath'];

// Attempt to delete the file/folder
if (is_dir($fullPath)) {
    // If it's a directory, use rmdir() to remove it
    if (rmdir($fullPath)) {
        echo "Folder deleted successfully";
    } else {
        echo "Error deleting folder";
    }
} else {
    // If it's a file, use unlink() to remove it
    if (unlink($fullPath)) {
        echo "File deleted successfully";
    } else {
        echo "Error deleting file";
    }
}
