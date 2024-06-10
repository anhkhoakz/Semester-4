<?php

function saveComment($name, $type, $comment)
{
    $timestamp = date("H:i - d/m/Y");

    $commentData = [
        "name" => $name,
        "type" => $type,
        "comment" => $comment,
        "timestamp" => $timestamp
    ];

    $serializedComment = json_encode($commentData) . PHP_EOL;

    file_put_contents("comments.txt", $serializedComment, FILE_APPEND);
}

function deleteComment($index)
{
    $comments = file("comments.txt", FILE_IGNORE_NEW_LINES);

    unset($comments[$index]);

    file_put_contents("comments.txt", implode(PHP_EOL, $comments));
}

if ($_SERVER["REQUEST_METHOD"] == "GET" && isset($_GET["action"]) && $_GET["action"] == "delete") {
    if (isset($_GET["index"])) {
        deleteComment($_GET["index"]);
    }
}

function displayComments()
{
    $comments = file("comments.txt", FILE_IGNORE_NEW_LINES);

    $comments = array_reverse($comments);

    foreach ($comments as $index => $comment) {
        $commentData = json_decode($comment, true);

        if ($commentData !== null) {
            echo '<div class="alert ' . $commentData["type"] . ' alert-dismissible" data-index="' . $index . '">';
            echo '<button type="button" class="close" onclick="deleteComment(this)">&times;</button>';
            echo '<strong>' . $commentData["name"] . ':</strong> ' . $commentData["comment"];
            echo '<div class="text-right small">' . $commentData["timestamp"] . '</div>';
            echo '</div>';
        }
    }
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = $_POST["name"];
    $type = $_POST["type"];
    $comment = $_POST["comment"];

    saveComment($name, $type, $comment);

    header("Location: " . $_SERVER['PHP_SELF']);
    exit;
}

?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>PHP Exercises</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
</head>

<body>
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-sm-8 my-3 mx-auto p-3">
                <div class="border rounded p-3">
                    <h4 class="text-center mb-3">Nhập bình luận của bạn</h4>
                    <form method="post">
                        <div class=" form-row">
                            <div class="form-group col-md-6">
                                <label for="name">Họ và tên</label>
                                <input id="name" name="name" type="text" class="form-control" required />
                            </div>
                            <div class="form-group col-md-6">
                                <label for="type">Chọn màu nền</label>
                                <select id="type" name="type" class="custom-select">
                                    <option value="alert-secondary" selected>Gray</option>
                                    <option value="alert-success">Green</option>
                                    <option value="alert-primary">Blue</option>
                                    <option value="alert-danger">Red</option>
                                    <option value="alert-warning">Yellow</option>
                                </select>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="comment">Bình luận</label>
                            <textarea id="comment" name="comment" class="form-control" placeholder="Nhập nội dung" style="height: 80px" required></textarea>
                        </div>
                        <button class="btn btn-primary" type="submit " onclick="checkForm()">Gửi bình luận</button>
                    </form>
                </div>
                <div class=" mt-3" style="max-height: 300px; overflow: scroll">
                    <?php displayComments(); ?>
                </div>
            </div>
        </div>
    </div>

    <script>
        function deleteComment(button) {
            var index = button.parentElement.getAttribute("data-index");
            window.location.href = "<?php echo $_SERVER['PHP_SELF']; ?>?action=delete&index=" + index;
        }
    </script>
</body>

</html>