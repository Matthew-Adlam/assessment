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
    <h1> Input your study log here! </h1>
    <img src = "images/download-1.jpg" class = "floatright">
    <form method = "post" action="study.php">
    <span class="submit">Study Subject:</span><select id="" name="StudySubject" required>
    <option value = "Maths">Maths</option>
    <option value = "English">English</option>
    <option value = "Science">Science</option>
    </select> 
    <br>
    <span class="submit">Study Time :</span><input type="time" name="StudyTime" required>
    <br>
    <span class="submit">Study Details:</span><input type="text" name="StudyInformation" class="textarea" maxlength="20" placeholder="Homework" size="20" required>
    <br>
    <span class = "submit">Study Date:</span><input type = "date" name  = "StudyDate" required>
    <br>
<?php
    if($_SERVER["REQUEST_METHOD"] =="POST") {
        $StudySubject= $_POST["StudySubject"];
        $StudyTime = $_POST["StudyTime"];
        $StudyInformation = $_POST["StudyInformation"];
        $StudyDate = $_POST["StudyDate"];
       /* $DateSubmitted = */
    try {
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        $sth  = $pdo->prepare("INSERT INTO StudyCount (StudySubject,StudyTime,StudyInformation,StudyDate) VALUES (:StudySubject,:StudyTime,:StudyInformation,:StudyDate)");
        $sth->bindValue(':StudySubject', $StudySubject, PDO::PARAM_STR);
        $sth->bindValue(':StudyTime', $StudyTime, PDO::PARAM_STR);
        $sth->bindValue(':StudyInformation', $StudyInformation, PDO::PARAM_STR);
        $sth->bindValue(':StudyDate', $StudyDate, PDO::PARAM_STR);
        $count = $sth->execute();

        if($count == 1) {
            echo "Record added to the database! Go to the link below to view your study log!";
        }
        $pdo = null;
    }
    catch(PDOException $e) {
        echo $e->getMessage();
    }
}
    ?>
    <br>
    <p><i>Note: Keep your details short: 1-2 words eg. Homework.</i> </p>
    <input type ="submit" value="Submit">
    <br>
    <br>
     <a href = "display.php" class = "stylethismatthew"><u>View your study log!</u> </a>
    </form>
  <a href="tips.php">  <h3 class = "abcd"> My Top 5 Studying Tips </h3></a>
    </div>
</body>
</html>