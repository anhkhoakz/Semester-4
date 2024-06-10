<?php
// Function to establish database connection
function get_connection()
{
    $servername = "localhost";
    $username = "root";
    $password = "";
    $dbname = "WebProgramming";

    // Create connection
    $conn = new mysqli($servername, $username, $password, $dbname);

    // Check connection
    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    }

    return $conn;
}


function get_products()
{

    $conn = get_connection();
    $sql = "SELECT * FROM product";
    $result = $conn->query($sql);

    $products = array();

    if ($result->num_rows > 0) {

        while ($row = $result->fetch_assoc()) {
            $products[] = $row;
        }
        $conn->close();

        return $products;
    } else {
        $conn->close();

        return $products;
    }
}
