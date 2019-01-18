<?php

if(isset($_POST['name']) && isset($_POST['question'])) {
	//Compiles the name of the user, static text to wake Alexa and the user's question.
    $data = $_POST['name'] . ' asks, Hey Alexa ' . $_POST['question'] . "\r\n";
	//Writes the compiled text into the text file named 'alexaquestions.txt'.
    $ret = file_put_contents('alexaquestions.txt', $data, FILE_APPEND | LOCK_EX);
    if($ret === false) {
        die('There was an error writing this file');
    }
    else {
		//Instructs the web browser to load the url below when data has successfully been written to the server text file.
		header('Location: https://richardmotion.com/askalexa/askalexasuccess.html');
    }
}
else {
   die('no post data to process');
}
?>