<?php
//first connect to the database
require_once('includes/connect.php');
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    
    <link rel="stylesheet" href="Css/style.css" type="text/css" charset="utf-8">
    <title>Document</title>
</head>
<div>
    <div class="head">
        <nav>
            <ul>
                <li class="sub">
                    <a href="index.php">Home</a>
                    <ul>
                        <li><a href="presentation.html">Details</a></li>
                        <li class="sub">
                            <a href="contact.html">contact</a>
                            <ul>
                                <li><a href="one.html">One</a></li>
                                <li><a href="two.html">Two</a></li>
                                <li class="sub">
                                    <a href="three.html">Three</a>
                                    <ul>
                                        <li><a href="one.html">One</a></li>
                                        <li><a href="two.html">Two</a></li>
                                        <li><a href="three.html">Three</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li class="sub">
                    <a href="sumbit.html">Sumbit Your Results</a>
                    <ul>
                        <p> Put Search Bar Hear</p>
                    </ul>
                </li>
                <li class="sub">
                    <a href="shop.html">Games</a>
                    <ul>
                        <li class="sub">
                            <a href=".html">Sandbox</a>
                            <ul>
                                <li><a href="one.html">Minecraft</a></li>
                                <li><a href="two.html">Factorio</a></li>
                                <li><a href="three.html">Satisfactoy</a></li>
                                <li><a href="three.html">More</a></li>      
                                </li>
                            </ul>
                        </li>
                        <li class="sub">
                            <a href=".html">Questing</a>
                            <ul>
                                <li><a href="one.html">Withcher</a></li>
                                <li><a href="two.html">Astroneer</a></li>
                                <li><a href="three.html">Celeste</a></li>
                                <li><a href="three.html">More</a></li>      
                                </li>
                            </ul>
                        </li>
                        <li class="sub">
                            <a href=".html">First Person Shooter</a>
                            <ul>
                                <li><a href="one.html">Rainbow Six Siege</a></li>
                                <li><a href="two.html">Doom</a></li>
                                <li><a href="three.html">CSGO</a></li>
                                <li><a href="three.html">More</a></li>      
                                </li>
                            </ul>
                        </li>
                        
                    </ul>
                </li>
                <li><a href="news.html">Submit Your Results</a></li>
            </ul>
        </nav>
            </div>
            <div class="bodybox">
            <br>
            <br>
            <div class="formbox">
            <br>
            <form method="post" action="submit.php">
            <span class="submit">Game:</span> <input type="text" name="Game" require="/^[a-zA-Z ]*$/"><br>
            <br>
            <span class="submit">Genre:</span> <select name ="Genre" id="">
            <option value="Sandbox">Sandbox</option>
            <option value="FPV">First Person Shooter</option>
            <option value="Quest">Quest</option>
            <option value="Survival">Survival</option>
            </select>
            <br>
            <br>
            <span class="submit">Type Of Game:</span> <select name ="Type" id="">
            <option value="PC">Action Games</option>
            <option value="PlayStaion">Action-Adventure Games</option>
            <option value="Xbox">Adventure Games</option>
            <option value="Nintendo">Role-Playing</option>
            <option value="Android">Simulation</option>
            <option value="Android">Stratergy</option>
            <option value="Android">Puzzle Games</option>
            </select>
            <br>
            <br>
            <span class="submit">Time: Hours:</span> <input type="number" name="Hours" min="0" step="1" max="999"> <span class="submit">Hrs</span> <input type="number" name="Minutes" min="0" step="1" max="60" ><span class="submit">Mins</span> <input type="number" name="Seconds" min="0" step="1" max="60"><span class="submit">Secs</span><br>
            <br>
            <span class="submit">Platform:</span><select name ="Platform" id="">
            <option value="PC">PC (Computer)</option>
            <option value="PlayStaion">PlayStaion</option>
            <option value="Xbox">XBOX</option>
            <option value="Nintendo">Nintendo</option>
            <option value="Android">Android</option>
            </select>
            <br>
            <br>
            <span class="submit">Date:</span> <input type="date" name="Date"><br>
            <br>
            <span class="submit">Evidence (Please provide web links to all evidence and proof):</span> <input type="text" name="evidence"><br>
            <br>
            <span class="submit">Username:</span> <input type="text" name="UserName"><br>
            <?php
//check to see if form has been submitted, if not the blank entries will be displayed
if ($_SERVER["REQUEST_METHOD"] == "POST") {
	// form was submitted, place data into appropriate variables
  $game = $_POST["Game"];
  $genre = $_POST["Genre"];
  $type = $_POST["Type"];
  $hours = $_POST["Hours"];
  $minutes = $_POST["Minutes"];
  $seconds = $_POST["Seconds"];
  $platform = $_POST["Platform"];
  $date = $_POST["Date"];
  $evidence = $_POST["evidence"];
  $username = $_POST["UserName"];
  //$timesubmitted = date('Y-m-d H:i:s');


	try {
		// set the PDO error mode to exception
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

		//insert data into activity table
    $sth = $pdo->prepare("INSERT INTO GameSpeedRunning (Game,Genre,Type,Hours,Minutes,Seconds,Platform,Date,UserName,evidence) VALUES (:game,:genre,:type,:hours,:minutes,:seconds,:platform,:date,:username,:evidence)");
    $sth->bindValue(':game', $game, PDO::PARAM_STR);
    $sth->bindValue(':genre', $genre, PDO::PARAM_STR);
    $sth->bindValue(':type', $type, PDO::PARAM_STR);
    $sth->bindValue(':platform', $platform, PDO::PARAM_STR);
    $sth->bindValue(':date', $date, PDO::PARAM_STR);
    $sth->bindValue(':username', $username, PDO::PARAM_STR);
    //$sth->bindValue(':timesubmited', $timesubmitted, PDO::PARAM_STR);
    $sth->bindValue(':evidence', $evidence, PDO::PARAM_STR);
    $sth->bindValue(':hours', $hours, PDO::PARAM_STR);
    $sth->bindValue(':minutes', $minutes, PDO::PARAM_STR);
    $sth->bindValue(':seconds', $seconds, PDO::PARAM_STR);
    $count = $sth->execute();

       // echo the number of affected rows, if count =1 the record (row) was successfully inserted
    if($count == 1){
    	echo "record added to database";
    	}

    // close the database connection 
    $pdo = null;
	}
   	catch(PDOException $e)
    {
    echo $e->getMessage();
    }
 }
?>


<input type="submit" value ="submit">
</form>
                <br>
                <br>
                <br>
                </div>
                </div>
            </div>          
</body>
</html>