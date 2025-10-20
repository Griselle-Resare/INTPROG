<?php

header('Content-Type: application/json');

$user = array(
    "id" => 1,
    "name" => "Resare",
    "email" => "Resare@example.com",
    "status" => "active"
);

echo json_encode($user);
?>
