<?php
session_start();
if (!isset($_SESSION['user'])) {
    header('Location: login.php');
    exit();
}

require_once "database.php";
$sql = "SELECT * FROM product";
$result = mysqli_query($conn, $sql);

$totalProducts = mysqli_num_rows($result);
?>


<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Trang chủ - Danh sách sản phẩm</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <?php include_once "cdn.php" ?>
    <style>
        td {
            vertical-align: middle;
        }

        img {
            max-height: 100px;
        }
    </style>
</head>

<body>

    <div class="container">
        <div class="row justify-content-center">
            <div class="col col-md-10">
                <h3 class="my-4 text-center">Product List</h3>
                <div class="d-flex justify-content-between">
                    <a class="btn btn-sm btn-secondary mb-4" href="add_product.php">Add Product</a>
                    <a href="logout.php">Logout</a>
                </div>
                <table class="table-bordered table table-hover text-center">

                    <tr>
                        <th>Image</th>
                        <th>Name</th>
                        <th>Price</th>
                        <th>Description</th>
                        <th>Actions</th>
                    </tr>

                    <?php
                    while ($row = mysqli_fetch_assoc($result)) {
                    ?>
                        <tr>
                            <td class='align-middle'><img src='images/<?php echo $row['image']; ?>'></td>
                            <td class='align-middle'><?php echo $row['name']; ?></td>
                            <td class='align-middle'><?php echo $row['price']; ?> VND</td>
                            <td class='align-middle'><?php echo $row['description']; ?></td>
                            <td class='align-middle'>
                                <button class='btn btn-sm btn-primary mr-1 edit-btn' data-id="<?php echo $row['id']; ?>"><i class='fas fa-pen'></i></button>
                                <button class='btn btn-sm btn-danger delete-btn' data-id="<?php echo $row['id']; ?>"><i class='fas fa-trash-alt'></i></button>

                            </td>
                        </tr>
                    <?php
                    }
                    ?>
                </table>
                <p class="text-right">Total products: <strong><?php echo $totalProducts; ?></strong></p>
            </div>
        </div>
    </div>

    <?php include "modals.php" ?>


    <script>
        $(document).ready(function() {

            // show delete confirm
            $(".delete-btn").click(function() {
                $('#deleteModal').modal({
                    backdrop: 'static',
                    keyboard: false
                });
            });

            // show edit confirm
            $(".edit-btn").click(function() {
                $('#editModal').modal({
                    backdrop: 'static',
                    keyboard: false
                });
            });
        });
    </script>

    <script src="index.js"></script>

</body>

</html>