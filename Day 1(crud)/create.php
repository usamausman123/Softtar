<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "myDB";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$sql = "INSERT INTO webLedger (account, year8, year9, year10, year11)
VALUES ('".$_POST['text1']."','".$_POST['text2']."','".$_POST['text3']."' ,'".$_POST['text4']."','".$_POST['text5']."');";
echo $sql;
if ($conn->query($sql) === TRUE) {
    echo "New record created successfully";
    header('location: http://localhost/internship/read.php');
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>