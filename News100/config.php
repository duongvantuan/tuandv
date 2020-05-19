<?php
    // $conn = mysql_connect("3.12.6.166", "root","Abcd@1234");
    $conn = mysql_connect("database-2.cmxzvve96gy6.ap-northeast-1.rds.amazonaws.com", "admin","Tuan1234");
    mysql_query("SET character_set_results=utf8");
    mb_language('uni');
    mb_internal_encoding('UTF-8');
    mysql_select_db("tophotnewstoday");

    // $url = 'http://localhost/News100';
    // $url = 'https://carnews.live';
    // $url = 'https://heathlaundrydiet.pw';
	$url = 'http://34.227.17.236';
?>