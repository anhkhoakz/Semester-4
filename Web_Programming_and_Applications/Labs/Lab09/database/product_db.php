<?php
require_once('database.php');

function add_product($name, $price, $desc)
{
    $id = generateRandomID();
    $sql = "INSERT INTO product(id, name, price, description) values(?, ?, ?, ?)";
    $conn = get_connection();
    $stmt = $conn->prepare($sql);
    $stmt->bind_param('isis', $id, $name, $price, $desc);
    $stmt->execute();
    return $stmt->affected_rows === 1;
}

function get_products()
{
    $sql = 'SELECT * FROM  product';
    $conn = get_connection();
    $result = $conn->query($sql);
    if (!$result) {
        return json_encode(array('error' => 'Select product fail'));
    }

    return json_encode($result->fetch_all(MYSQLI_ASSOC));
}

function get_product($id)
{
    $sql = 'SELECT * FROM product WHERE id = ?';
    $conn = get_connection();
    $stmt = $conn->prepare($sql);
    $stmt->bind_param('i', $id);
    $stmt->execute();
    $result = $stmt->get_result();
    if (!$result) {
        return json_encode(array('error' => 'select product fail'));
    }
    return json_encode($result->fetch_assoc());
}

function update_product($id, $name, $price, $desc)
{
    $sql = 'UPDATE product SET name = ?, price = ?, description = ? WHERE id = ?';
    $conn = get_connection();
    $stmt = $conn->prepare($sql);
    $stmt->bind_param('sisi', $name, $price, $desc, $id);
    $stmt->execute();
    return $stmt->affected_rows === 1;
}

function delete_product($id)
{
    $sql = 'DELETE FROM product WHERE id = ?';
    $conn = get_connection();
    $stmt = $conn->prepare($sql);
    $stmt->bind_param('i', $id);
    $stmt->execute();
    return $stmt->affected_rows === 1;
}

function generateRandomID()
{
    $randomID = rand(1, 1000);

    $sql = 'SELECT id FROM product WHERE id = ?';
    $conn = get_connection();
    $stmt = $conn->prepare($sql);
    $stmt->bind_param('i', $randomID);

    while (true) {
        $stmt->execute();
        $result = $stmt->get_result();
        if ($result->num_rows === 0) {
            break;
        }
        $randomID = rand(1, 1000);
        $stmt->bind_param('i', $randomID);
    }

    return $randomID;
}
