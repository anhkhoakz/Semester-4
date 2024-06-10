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
            if (password_verify($pass, $row['password'])) {
                if ($row['activated'] == 0) {
                    $error = 'Your account is not activated yet';
                    $conn->close();
                    exit();
                }
                $_SESSION['user'] = $row['username'];
                header('Location: index.php');
                exit();
            } else {
                $error = 'Invalid username or password';
            }
        }
    }
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <title>User Login</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <?php include_once "cdn.php" ?>
</head>

<body>
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-6 col-lg-5">
                <h3 class="text-center text-secondary mt-5 mb-3">User Login</h3>
                <form method="post" action="" class="border rounded w-100 mb-5 mx-auto px-3 pt-3 bg-light">
                    <div class="form-group">
                        <label for="username">Username</label>
                        <input value="<?= $user ?>" name="user" id="user" type="text" class="form-control" placeholder="Username">
                    </div>
                    <div class="form-group">
                        <label for="password">Password</label>
                        <input name="pass" id="password" type="password" class="form-control" placeholder="Password">
                    </div>
                    <div class="form-group custom-control custom-checkbox">
                        <input <?= isset($_POST['remember']) ? 'checked' : '' ?> name="remember" type="checkbox" class="custom-control-input" id="remember">
                        <label class="custom-control-label" for="remember">Remember login</label>
                    </div>
                    <div class="form-group">
                        <?php
                        if (!empty($error)) {
                            echo "<div class='alert alert-danger'>$error</div>";
                        }
                        ?>
                        <button class="btn btn-success px-5">Login</button>
                    </div>
                    <div class="form-group">
                        <p>Don't have an account yet? <a href="register.php">Register now</a>.</p>
                        <p>Forgot your password? <a href="forgot.php">Reset your password</a>.</p>
                    </div>
                </form>

                <p class="text-danger">Login with: <strong>admin</strong> - <strong>admin123</strong></p>
            </div>
        </div>
    </div>
</body>

</html>