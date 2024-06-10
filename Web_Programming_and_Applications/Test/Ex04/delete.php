    <?php

    require_once('db.php');

    if ($_SERVER['REQUEST_METHOD'] === "POST"  && isset($_POST['id'])) {
        $id = $_POST['id'];

        $conn = get_connection();
        $sql = "DELETE FROM product WHERE id = ?";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("i", $id);
        $stmt->execute();

        if ($stmt->affected_rows > 0) {
            echo "Record deleted successfully";
        } else {
            echo "Error deleting record: " . $conn->error;
        }
        $stmt->close();
        $conn->close();
    }
