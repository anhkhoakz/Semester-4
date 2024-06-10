<?php
require_once "database.php";
$error = '';

if (isset($_GET['email'], $_GET['activate_token'])) {
  $email = $_GET['email'];
  $token = $_GET['activate_token'];

  $sql = "SELECT * FROM account WHERE email = ? AND activate_token = ?";
  $stmt = mysqli_prepare($conn, $sql);
  mysqli_stmt_bind_param($stmt, "ss", $email, $token);
  mysqli_stmt_execute($stmt);
  $result = mysqli_stmt_get_result($stmt);

  if (mysqli_num_rows($result) > 0) {
    $update_sql = "UPDATE account SET activated = 1 WHERE email = ? AND activate_token = ?";
    $update_stmt = mysqli_prepare($conn, $update_sql);
    mysqli_stmt_bind_param($update_stmt, "ss", $email, $token);
    if (!mysqli_stmt_execute($update_stmt)) {
      $error = 'Error updating record: ' . mysqli_error($conn);
    }
  } else {
    $error = 'Invalid activation link';
  }
} else {
  $error = 'Invalid activation link';
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
  <title>Account Activation</title>
  <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
  <?php include_once "cdn.php" ?>
</head>

<body>
  <div class="container">
    <div class="row">
      <div class="col-md-6 mt-5 mx-auto p-3 border rounded">
        <h4>Account Activation</h4>
        <?php if (empty($error)) { ?>
          <p class="text-success">Congratulations! Your account has been activated.</p>
          <p>Click <a href="login.php">here</a> to login and manage your account information.</p>
        <?php } else { ?>
          <p class="text-danger">This is not a valid URL or it has expired.</p>
        <?php } ?>
        <p>Click <a href="login.php">here</a> to login.</p>
        <a class="btn btn-success px-5" href="login.php">Login</a>
      </div>
    </div>
  </div>
</body>

</html>