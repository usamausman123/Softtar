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

$sql = "UPDATE webLedger SET year8='".$_POST['text2']."',year9='".$_POST['text3']."',year10='".$_POST['text4']."',year11='".$_POST['text5']."'
    WHERE account='".$_POST['text1']."';";

if ($conn->query($sql) === TRUE) {
    echo "Record updated successfully";
    header('location: http://localhost/internship/read.php');
} else {
    echo "Error updating record: " . $conn->error;
}

$conn->close();
?>