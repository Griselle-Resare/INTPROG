<?php

$jsonData = file_get_contents("php://input");


$data = json_decode($jsonData, true);


$response = ["status" => "error", "message" => "Invalid input."];

if (isset($data["username"]) && isset($data["password"])) {
    $username = htmlspecialchars($data["username"]);
    $password = htmlspecialchars($data["password"]);

    
    if (!empty($username) && !empty($password)) {
        $response = [
            "status" => "success",
            "message" => "Welcome, $username!"
        ];
    } else {
        $response = [
            "status" => "error",
            "message" => "Missing username or password."
        ];
    }
}

header("Content-Type: application/json");
echo json_encode($response);
?>
