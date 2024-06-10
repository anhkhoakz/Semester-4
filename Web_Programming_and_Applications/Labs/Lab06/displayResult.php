<?php

if (isset($_POST['name']) && isset($_POST['email']) && isset($_POST['browser']) && isset($_POST['gender']) && isset($_POST['OS'])) {
    $name = $_POST['name'];
    $email = $_POST['email'];
    $fwbs = $_POST['browser'];
    $gender = $_POST['gender'];
    $os = $_POST['OS'];
}
?>

<!doctype html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <title>Result</title>
</head>

<body>
    <div class="container">
        <div class="row">
            <div class="col-md-8 col-lg-5 my-5 mx-2 mx-sm-auto border rounded px-3 py-3">
                <h5 class="text-center mb-3 text-success fw-bolder">Confirm Infomation</h5>
                <form>
                    <div class="form-group">
                        <label>Your name</label>
                        <div class="text-success fw-bolder"><?= $name ?></div>
                    </div>
                    <div class="form-group">
                        <label for="email">Your email</label>
                        <div class="text-success fw-bolder"><?= $email ?></div>
                    </div>

                    <div class="form-group">
                        <legend class="col-form-label">Gender</legend>
                        <div class="text-success fw-bolder"><?= $gender ?></div>
                    </div>

                    <div class="form-group">
                        <legend class="col-form-label">Favorite web browsers</legend>
                        <?php
                        echo "<ul>";
                        foreach ($fwbs as $fwb) {
                            echo "<li class='text-success fw-bolder'>$fwb</li>";
                        }
                        echo "</ul>";
                        ?>
                    </div>

                    <div class="form-group">
                        <legend class="col-form-label">Prefered Operating System</legend>
                        <div class="text-success fw-bolder"><?= $os ?></div>
                    </div>
                    <button class="btn btn-success px-5 mr-2">Save</button>
                    <a href="Ex04.html" class="btn btn-outline-success px-5">Back</a>
                </form>
            </div>
        </div>
    </div>
</body>

</html>