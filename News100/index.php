<?php
    require_once ('include/config.php');



    if(!isset($_GET['page'])){
        $_GET['page'] = 'home';
    }
    $page = $_GET['page'];
    if(!isset($_GET['category'])){
        $_GET['category'] = 'home';
    }
    $category = $_GET['category'];
    switch($category){
        case 'home':
            $title = 'Car news today - Car news today';
            $pagetitle = '';
            break;
        case '1':
            $title = 'Car News';
            $pagetitle = 'Car News';
            break;
        case '2':
            $title = 'Shopping';
            $pagetitle = 'Shopping';
            break;
        case '3':
            $title = 'Skin';
            $pagetitle = 'Skin';
            break;
        case '4':
            $title = 'Insurance';
            $pagetitle = 'Insurance';
            break;
    };

    if(isset($_GET['id_news'])){
        $idNews = $_GET['id_news'];
        $query = mysql_query("SELECT category_name, id_news, title_news, description_news, url_img, content FROM tbl_news A INNER JOIN tbl_category B ON A.category_id = B.category_id WHERE A.id_news = {$idNews};");
        $news = mysql_fetch_array($query);
        $title = $news['title_news']." - Car news today";
    }
?>
<!DOCTYPE html>
<html lang="en-US">

<head>
    <title><?php echo $title; ?></title>
    <link rel="shortcut icon" href="<?php echo $url; ?>/images/favicon.ico" type="image/x-icon">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1">

    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta http-equiv="cache-control" content="max-age=0" />
    <meta http-equiv="cache-control" content="no-cache" />
    <meta name="robots" content="index, follow" />
    <meta name="language" content="English" />
    <meta name="description" content="Provide the latest information car news" />
    <meta name="keywords"
        content="car news msn, car news today, car news india, car news websites, car news uk, car news 2020, car news canada, car news usa, car news malaysia, car news app, car news autocar, car news api, car news australia 2020, car news auto express" />

    <?php include_once 'include/css_js.php'; ?>
</head>

<body class="home blog wide">
    <center>
        <ins class="adsbygoogle" style="display: block; height: 90px;" data-ad-client="ca-pub-2278542298831513"
            data-ad-format="link">
        </ins>

        <script>
        (adsbygoogle = window.adsbygoogle || []).push({});
        </script>
    </center>
    <div id="page" class="hfeed site">
        <?php include_once ('include/header.php'); ?>
        <div id="main" class="clearfix">
            <?php include_once ('include/'.$page.'.php'); ?>
        </div>
        <?php include_once ('include/footer.php'); ?>
    </div>
</body>
</html>