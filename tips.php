<?php
require_once('includes/connect.php');
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css" type="text/css" charset="utf-8" <?php echo time(); ?>>
    
    <title>Study Time</title>
</head>
<body>
   <header>
       <br>
       <a href = "index.php" class = "header-text">Study Time!</a> 
    </header>
    <br>
    <div class = "inputbox">
   <h1> My Top 5 Studying Tips: </h1>
   <br>
   <ol>
    <li>15 minutes/day is better than none during the week and 8hrs on the weekend.</li>
    <li>Ask for help if you need it - ask teachers, parents etc.</li>
    <li>Don't be hard on yourself!</li>
    <li>Notes are important. Take notes, rewrite notes, share notes with others.</li>
    <li>If what you need to study is not what you want to study, reward yourself for doing it!</li>
    </ol>
    <br>
    <br>
    <a href = "study.php">Go Back </a>
    </div>
</body>
</html>