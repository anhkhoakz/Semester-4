<?php
require_once("../database/product_db.php");

header("Content-Type: application/json; charset=utf-8");

if ($_SERVER['REQUEST_METHOD'] !== 'PUT') {
    http_response_code(405);
    die(json_encode(array("code" => 2, "message" => "This method is not supported " . $_SERVER["REQUEST_METHOD"])));
}

$data =  json_decode(file_get_contents("php://input"));

if (is_null($data)) {
    http_response_code(400);
    die(json_encode(array("code" => 3, 'message' => 'JSON is null')));
}

$required_properties = ['id', 'name', 'price', 'description'];
foreach ($required_properties as $property) {
    if (!property_exists($data, $property) || empty($data->$property)) {
        http_response_code(400);
        die(json_encode(array('code' => 4, 'message' => 'Please provide a non-empty value for ' . $property)));
    }
}

$id = intval($data->id);

if (empty($id)) {
    http_response_code(400);
    die(json_encode(array("code" => 6, 'message' => 'Please provide a product id')));
}

if (!is_numeric($id)) {
    http_response_code(400);
    die(json_encode(array("code" => 7, 'message' => 'Please provide a valid product id')));
}

if ($id < 1 || $id > 1000) {
    http_response_code(400);
    die(json_encode(array("code" => 8, 'message' => 'Product id is out of range')));
}

update_product($id, $data->name, $data->price, $data->description);
die(json_encode(['code' => 0, 'message' => 'Update product success']));
