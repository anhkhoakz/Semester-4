<?php
require_once("../database/product_db.php");

header("Content-Type: application/json; charset=utf-8");

if ($_SERVER['REQUEST_METHOD'] !== 'DELETE') {
    http_response_code(405);
    die(json_encode(array("code" => 2, "message" => "This method is not supported " . $_SERVER["REQUEST_METHOD"])));
}

$data =  json_decode(file_get_contents("php://input"));

if (is_null($data)) {
    http_response_code(400);
    die(json_encode(array("code" => 3, 'message' => 'JSON is null')));
}

if (
    !property_exists($data, 'id') ||
    empty($data->id)
) {
    http_response_code(400);
    die(json_encode(array('code' => 4, 'message' => 'Please provide a valid product ID')));
}

$id = intval($data->id);
if ($id < 1 || $id > 10000000000) {
    http_response_code(400);
    die(json_encode(array("code" => 5, 'message' => 'Product ID is out of range')));
}

$result = delete_product($id);

if ($result) {
    die(json_encode(array("code" => 200, "message" => "Product deleted successfully")));
} else {
    http_response_code(500);
    die(json_encode(array("code" => 500, 'message' => 'Failed to delete product')));
}
