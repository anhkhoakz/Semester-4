<?php
require_once "database.php";
$error = '';
$name = '';
$price = '';
$desc = '';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = $_POST['name'];
    $price = $_POST['price'];
    $desc = $_POST['desc'];

    if (empty($name)) {
        $error = 'Hãy nhập tên sản phẩm';
    } elseif (!is_numeric($price) || $price <= 0 || $price < 1000000 || $price % 10000 != 0) {
        $error = 'Giá của sản phẩm không hợp lệ';
    } elseif (empty($desc)) {
        $error = 'Hãy nhập mô tả của sản phẩm';
    } elseif ($_FILES['image']['error'] != UPLOAD_ERR_OK) {
        $error = 'Vui lòng upload ảnh của sản phẩm';
    } else {
        $upload_dir = 'images/';
        $tmp_name = $_FILES['image']['tmp_name'];
        $image_name = uniqid() . '_' . $_FILES['image']['name'];
        move_uploaded_file($tmp_name, $upload_dir . $image_name);

        $sql = "INSERT INTO product (name, price, description, image) VALUES (?, ?, ?, ?)";
        $stmt = mysqli_prepare($conn, $sql);
        mysqli_stmt_bind_param($stmt, "siss", $name, $price, $desc, $image_name);

        if (mysqli_stmt_execute($stmt)) {
            header("Location: index.php");
            exit();
        } else {
            $error = 'Error inserting record: ' . mysqli_error($conn);
        }
    }
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Thêm sản phẩm mới</title>
    <?php include_once "cdn.php" ?>
    <style>
        .bg {
            background: #eceb7b;
        }
    </style>
</head>

<body>
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-xl-5 col-lg-6 col-md-8 border rounded my-5 p-4  mx-3">
                <p class="mb-5"><a href="index.php">Quay lại</a></p>
                <h3 class="text-center text-secondary mt-2 mb-3 mb-3">Thêm sản phẩm mới</h3>
                <form method="post" action="" novalidate enctype="multipart/form-data">

                    <div class="form-group">
                        <label for="name">Tên sản phẩm</label>
                        <input value="<?= $name ?>" name="name" required class="form-control" type="text" placeholder="Tên sản phẩm" id="name">
                    </div>
                    <div class="form-group">
                        <label for="price">Giá bán</label>
                        <input value="<?= $price ?>" name="price" required class="form-control" type="number" placeholder="Giá bán" id="price">
                    </div>
                    <div class="form-group">
                        <label for="desc">Mô tả</label>
                        <textarea id="desc" name="desc" rows="4" class="form-control" placeholder="Mô tả"><?= $desc ?></textarea>
                    </div>
                    <div class="form-group">
                        <div class="custom-file">
                            <input name="image" type="file" class="custom-file-input" id="customFile" accept="image/gif, image/jpeg, image/png, image/bmp">
                            <label class="custom-file-label" for="customFile">Ảnh minh họa</label>
                        </div>
                    </div>
                    <div class="form-group">
                        <?php
                        if (!empty($error)) {
                            echo "<div class='alert alert-danger'>$error</div>";
                        }
                        ?>
                        <button type="submit" class="btn btn-primary px-5 mr-2 ">Thêm</button>
                    </div>
                </form>

            </div>
        </div>

    </div>
    <script>
        // Add the following code if you want the name of the file appear on select
        $(".custom-file-input").on("change", function() {
            var fileName = $(this).val().split("\\").pop();
            $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
        });
    </script>
</body>

</html>