<html>
    <head>
        <title>Read</title>
        <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        
        .left{
            float: left;
            background-color: black;
            color: aliceblue;
            
        }
        .mid{
            float: left;
            padding-top: 27px;
            padding-left: 25px;
            background-color: black;
            height:63px;
            
        }
        .p1{
            display: inline;
            color: aliceblue;
            border-color: black;
        }
        .o1{
            background-color: black;
            color: aliceblue;
        }
        .right{
            float: left;
            padding-top: 17px;
            width:70.5%;
            padding-right: 10px;
            background-color: black;
            height:63px;
        }
        .btn-primary{
            background-color: white;
            color: black;
        }
        .btn-xs{
            background-color: gray;
            color: white;
        }
        .nav{
            margin-top: 110px;
            font-size: 50px;
            margin-left: 25px;
        }
    </style>
</head>
    <body>
        <div class="container">
        <div class="header">
            <div class="left">
                <h2>&nbsp;&nbsp;&nbsp;&nbsp;Ledger Web</h2>
            </div>
            <div class="mid">
                <form>
                    <select   class="o1">
                        <option>Reports</option>
                    </select>&nbsp;&nbsp; <p class="p1">Help</p>
                </form>
            </div>
            <div class="right">
                &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                <button type="button" class="btn btn-primary btn-xs">2011-01-01</button>
                <button type="button" class="btn btn-primary btn-xs">2012-01-01</button>
                <a href="create.html" type="submit" class="btn btn-primary">Create</a>
                <form style="display: inline" action="read.php" method="post"><input type="submit" class="btn btn-primary" value="Read"></form>&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
        </div>
            <b><p class="nav">Leaky Ship</p></b>
            <hr>
        <table class="table table-bordered table-striped ">
        <thead>
            <tr>
                <th>Account</th>
                <th>2008-01-01</th>
                <th>2009-01-01</th>
                <th>2010-01-01</th>
                <th>2011-01-01</th>
                <th>Update</th>
                <th>Delete</th>
            </tr>
        </thead>
        <tbody>

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

        $sql = "SELECT account, year8, year9, year10, year11 FROM webLedger";
        $result = $conn->query($sql);

        if ($result->num_rows > 0) 
        {
        // output data of each row
            while($row = $result->fetch_assoc()) {
            echo "<tr>";
            echo    "<td>" .$row["account"]. "</td>"; 
            echo    "<td>" .$row["year8"]. "</td>"; 
            echo    "<td>" .$row["year9"]. "</td>"; 
            echo    "<td>" .$row["year10"]. "</td>"; 
            echo    "<td>" .$row["year8"]. "</td>" ;
            echo "<td><form action='update.html' method='post'>
        		<input type='submit' name='update' value='Update'></form></td>";
            echo "<td><form action='delete.html' method='post'>
        		<input type='submit' name='delete' value='Delete'></form></td>";
                echo    "</tr>";
            }
        } 
            else  {
            echo "0 results";
        }
        $conn->close();
        ?>
            </tbody>
        </table>
        </div>
        
    </body>
</html>