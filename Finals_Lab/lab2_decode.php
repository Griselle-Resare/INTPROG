<?php

$json_string = '{"name":"Resare","age":21,"email":"resare@example.com"}';

$obj = json_decode($json_string);

$arr = json_decode($json_string, true);

echo "Object: " . $obj->name . "<br>";
echo "Array: " . $arr["email"];
?>
