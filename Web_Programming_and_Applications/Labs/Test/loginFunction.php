<?php

require_once "database.php";

header("Content-Type: application/json; charset=utf-8");


if ($_SERVER['REQUEST_METHOD'] != 'POST') {
    http_response_code(405);
    die(json_encode(array("code" => 2, "message" => "This method is not supported " . $_SERVER["REQUEST_METHOD"])));
}

$data = json_decode(file_get_contents('php://input'));

if (is_null($data)) {
    die(json_encode(array("code" => 3, "message" => "This method is just support JSON")));
}

if (
    !property_exists($data, 'username') ||
    !property_exists($data, 'password')
) {
    http_response_code(400);
    die(json_encode(array("code" => 4, "message" => "Insufficient data")));
}

if (
    empty($data->username) ||
    empty($data->password)
) {
    die(json_encode(array("code" => 5, "message" => "Invalid data")));
}

$username = $data->username;
$password = $data->password;

$stmt = $conn->prepare("SELECT * FROM account WHERE username = ?");
$stmt->bind_param("s", $username);
$stmt->execute();
$result = $stmt->get_result();

if ($result->num_rows == 0) {
    die(json_encode(array("code" => 4, 'message' => 'Invalid username or password')));
} else {
    $row = $result->fetch_assoc();
    $triedTime = $row['triedTime'];
    $isBlocked = $row['isBlocked'];
    if (password_verify($password, $row['password'])) {
        if ($row['activated'] == 0) {
            die(json_encode(array("code" => 5, 'message' => 'Your account is not activated yet')));
        }

        if ($isBlocked) {
            die(json_encode(array("code" => 7, 'message' => 'Your account is blocked')));
        }
        $stmt = $conn->prepare("UPDATE account SET triedTime = 0 WHERE username = ?");
        $stmt->bind_param('s', $username);
        $stmt->execute();

        session_start();
        $_SESSION['user'] = $row['username'];

        header('Location: index.php');
    } else {
        $triedTime++;
        $stmt = $conn->prepare("UPDATE account SET triedTime = ? WHERE username = ?");
        $stmt->bind_param('is', $triedTime, $username);
        $stmt->execute();

        if ($triedTime >= 3) {
            $stmt = $conn->prepare("UPDATE account SET isBlocked = 1 WHERE username = ?");
            $stmt->bind_param('s', $username);
            $stmt->execute();
            die(json_encode(array("code" => 7, 'message' => 'Your account is blocked')));
        }
        die(json_encode(array("code" => 6, 'message' => 'Invalid username or password')));
    }
}
