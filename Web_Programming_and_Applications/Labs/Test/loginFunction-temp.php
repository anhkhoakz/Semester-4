<?php
session_start();

if (isset($_SESSION['user'])) {
    header('Location: index.php');
    exit();
}

$error = '';
$user = '';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $user = $_POST['user'];
    $pass = $_POST['pass'];
    $triedTime = 0;

    if (empty($user)) {
        $error = 'Please enter your username';
    } elseif (empty($pass)) {
        $error = 'Please enter your password';
    } else {
        require_once "database.php";

        $stmt = $conn->prepare("SELECT * FROM account WHERE username = ?");
        $stmt->bind_param("s", $user);
        $stmt->execute();
        $result = $stmt->get_result();

        if ($result->num_rows == 0) {
            $error = 'Invalid username or password';
        } else {
            $row = $result->fetch_assoc();
            if (password_verify($pass, $row['password']) || $triedTime >= 3) {
                if ($row['activated'] == 0) {
                    $error = 'Your account is not activated yet';
                    $conn->close();
                    exit();
                }
                $_SESSION['user'] = $row['username'];
                header('Location: index.php');
                exit();
            } else {
                $triedTime ++;
                $error = 'Invalid username or password';
            }
        }
    }
}