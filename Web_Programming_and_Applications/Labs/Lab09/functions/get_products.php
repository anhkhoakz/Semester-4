<?php
require_once("../database/product_db.php");

header("Content-Type: application/json; charset=utf-8");


if ($_SERVER['REQUEST_METHOD'] !== 'GET') {
    http_response_code(405);
    die(json_encode(array("code" => 2, "message" => "This method is not supported " . $_SERVER["REQUEST_METHOD"])));
}

die(get_products());
