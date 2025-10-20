<?php

$jsonData = file_get_contents("php://input");

$data = json_decode($jsonData, true);

if ($data && isset($data["username"]) && isset($data["password"])) {
    $username = htmlspecialchars($data["username"]);
    $password = htmlspecialchars($data["password"]);

    echo "Username: $username<br>";
    echo "Password: $password";
} else {
    echo "No valid JSON data received.";
}
?>
