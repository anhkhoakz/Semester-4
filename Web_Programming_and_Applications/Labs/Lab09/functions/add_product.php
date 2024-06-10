<?php

require_once("../database/product_db.php");

header("Content-Type: application/json; charset=utf-8");


if ($_SERVER['REQUEST_METHOD'] !== 'POST') {
    http_response_code(405);
    die(json_encode(array("code" => 2, "message" => "This method is not supported " . $_SERVER["REQUEST_METHOD"])));
}

$data = json_decode(file_get_contents('php://input'));

if (is_null($data)) {
    http_response_code(400);
    die(json_encode(array("code" => 3, "message" => "This method is just support JSON")));
}

$required_properties = ['name', 'price', 'description'];
foreach ($required_properties as $property) {
    if (
        !property_exists($data, $property) ||
        empty($data->$property)
    ) {
        http_response_code(400);
        die(json_encode(array("code" => 4, "message" => "Missing or empty '$property' field")));
    }
}

$result = add_product($data->name, $data->price, $data->description);

if ($result) {
    http_response_code(200);
    die(json_encode(array("code" => 0, "message" => "Data Successfully Added")));
} else {
    http_response_code(500);
    die(json_encode(array("code" => 1, "message" => "Failed to add data")));
}
