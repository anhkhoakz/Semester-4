<?php
require_once("../database/product_db.php");

header("Content-Type: application/json; charset=utf-8");

if ($_SERVER['REQUEST_METHOD'] !== 'GET') {
    http_response_code(405);
    die(json_encode(array("code" => 2, "message" => "This method is not supported " . $_SERVER["REQUEST_METHOD"])));
}

if (empty($_GET['id'])) {
    http_response_code(400);
    die(json_encode(array("code" => 3, 'message' => 'Please provide a product id')));
}

$id = $_GET['id'];
if (!is_numeric($id)) {
    http_response_code(400);
    die(json_encode(array("code" => 4, 'message' => 'Please provide a valid product id')));
}

$id = intval($id);
if ($id < 1 || $id > 1000) {
    http_response_code(400);
    die(json_encode(array("code" => 5, 'message' => 'Product id is out of range')));
}

die(get_product($id));
