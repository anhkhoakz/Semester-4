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
                <form method="post" action="" onsubmit="return false" class="border rounded w-100 mb-5 mx-auto px-3 pt-3 bg-light">
                    <div class="form-group">
                        <label for="username">Username</label>
                        <input name="user" id="user" type="text" class="form-control" placeholder="Username">
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
                        // if (!empty($error)) {
                        //     echo "<div class='alert alert-danger'>$error</div>";
                        // }
                        ?>
                        <button class="btn btn-success px-5" onclick="validateLogin()">Login</button>
                    </div>
                    <div class="form-group">
                        <p>Don't have an account yet? <a href="register.php">Register now</a>.</p>
                        <p>Forgot your password? <a href="forgot.php">Reset your password</a>.</p>
                    </div>
                </form>

                <p class="text-danger">Login with: <strong>admin</strong> - <strong>123456</strong></p>
            </div>
        </div>
    </div>
    <script src="index.js"></script>
</body>

</html>