<?php

$countries = json_decode(file_get_contents('./countries.json'), true);
$query = isset($_POST['query']) ? $_POST['query'] : '';

$matchedCountries = array_filter($countries, function ($country) use ($query) {
    return strpos(strtolower($country['country']), strtolower($query)) !== false;
});

echo json_encode(array_values($matchedCountries));
