<?php
require_once('includes/connect.php');
?>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css" type="text/css" charset="utf-8">
    
    <title>Study Time</title>
</head>
<body>
   <header>
       <br>
       <a href = "index.php" class = "header-text">Study Time!</a> 
    </header>
<br>
<table>
  <tr>
    <th>Date</th>
    <th>Time</th>    
    <th>Subject</th>
    <th>Details</th>
  </tr>
  <br>
<?php   
foreach ($pdo -> query("SELECT StudyDate,StudySubject,StudyTime,StudyInformation
FROM StudyCount ") as $row)  { ?>
   <tr>
	 <td> <?php echo htmlspecialchars($row['StudyDate']); ?></td>
	 <td> <?php echo htmlspecialchars($row['StudyTime']); ?></td>
     <td> <?php echo htmlspecialchars($row['StudySubject']); ?></td>
     <td> <?php echo htmlspecialchars($row['StudyInformation']); ?></td>
	</tr>
<?php } ?>
</table>
<a href = "study.php">Go Back </a>
</body>
</html>