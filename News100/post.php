<?php
    require_once ('include/config.php');

    $title = 'Car news today - Car news today';
    $message = "";
    if(isset($_POST['add_product'])){
        // Chèn vào CSDL
        $title_news = str_replace("\"", "'", $_POST['title_news']);
        $description_news = str_replace("\"", "'", $_POST['description_news']);
        $category_id = str_replace("\"", "'", $_POST['category_id']);
        $url_img = str_replace("\"", "'", $_POST['url_img']);

        mysql_query("SET NAMES UTF8");
        $query = sprintf('INSERT INTO tbl_news (title_news, description_news, content, date_news, category_id, url_img) VALUES ("%s", "%s", "%s", NOW(), "%s", "%s");'
            , $title_news
            , strip_tags($description_news)
            , $description_news
            , $category_id
            , $url_img
        );

        $result = mysql_query($query) or die ('Register Error' . mysql_error());
        if($result){
            $message = "Register success.";
        }else{
            $message = "Register error.";
        }
    }

    if(isset($_POST['delete_video'])){
        // Chèn vào CSDL
        $id_video = $_POST['id_video'];

        mysql_query("SET NAMES UTF8");
        $query = "DELETE FROM tbl_video WHERE id_video = {$id_video}";
        $result = mysql_query($query) or die ('Register Error' . mysql_error());
        if($result){
            $message = "Delete success.";
            
        }else{
            $message = "Delete error.";
        }
    }
?>
<!DOCTYPE html>
<html>

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
    <meta name="keywords" content="car news msn, car news today, car news india, car news websites, car news uk, car news 2020, car news canada, car news usa, car news malaysia, car news app, car news autocar, car news api, car news australia 2020, car news auto express" />

    <?php include_once 'include/css_js.php'; ?>

    <style>
    body {
        font-family: Arial;
    }

    /* Style the tab */
    .tab {
        overflow: hidden;
        border: 1px solid #ccc;
        background-color: #f1f1f1;
    }

    /* Style the buttons inside the tab */
    .tab button {
        background-color: inherit;
        float: left;
        border: none;
        outline: none;
        cursor: pointer;
        padding: 14px 16px;
        transition: 0.3s;
        font-size: 17px;
    }

    /* Change background color of buttons on hover */
    .tab button:hover {
        background-color: #ddd;
    }

    /* Create an active/current tablink class */
    .tab button.active {
        background-color: #ccc;
    }

    /* Style the tab content */
    .tabcontent {
        display: none;
        padding: 6px 12px;
        border: 1px solid #ccc;
        border-top: none;
    }
    </style>
</head>

<body class="home blog wide">
    <div id="page" class="hfeed site">
        <?php include_once ('include/header.php'); ?>
        <div class="inner-wrap clearfix">
            <div class="main-content-section clearfix">
                <button class="tablink" onclick="openPage('Home', this, 'red')" id="defaultOpen">Thêm mới tin tức</button>
                <button class="tablink" onclick="openPage('News', this, 'green')">Thêm mới thể loại</button>
                <div id="Home" class="tabcontent">
                    <span color="red" style="font-size: 30px;margin-left: 100px;"><?php echo $message ?></span>
                    <form id="add-product-form" action="post.php" method="POST"
                        enctype="multipart/form-data">
                        <table>
                            <tr>
                                <th>Thể loại</th>
                                <td>
                                    <select style="height:40px;font-size: 18px;width: 300px;" name="category_id">
                                    <?php
                                        $menu_query = 'SELECT * FROM tbl_category;';
                                        $menu_result = mysql_query($menu_query) or die ('Không lấy được menu từ cơ sở dữ liệu');
                                        while($menu_items = mysql_fetch_array($menu_result)) {
                                            echo "<option value='{$menu_items['category_id']}'>{$menu_items['category_name']}</option>";
                                        }
                                    ?>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <th style="width: 100px;">Tiêu đề</th>
                                <td><input type="text" name="title_news" /></td>
                            </tr>
                            <tr>
                                <th style="width: 100px;">Ảnh đại diện</th>
                                <td><input type="text" name="url_img" /></td>
                            </tr>
                            <tr>
                                <th style="vertical-align: middle;">Mô tả</th>
                                <td><textarea id="description" cols="40" rows="10" name="description_news"></textarea></td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <input type="submit" value="Add" name="add_product" />
                                    <input type="reset" class="button_big" value="Reset" />
                                </td>
                            </tr>
                        </table>
                    </form>
                </div>

                <div id="News" class="tabcontent">
                    <h3>News</h3>
                    <p>Some news this fine day!</p>
                </div>

                <!-- <form id="add-product-form" action="dfjwroejskfjdsfhweuriwrdsjf.php" method="POST"
                    enctype="multipart/form-data">
                    <table border='1' style="margin-left: 100px;margin-top: 20px;">
                        <tr>
                            <th style="width: 100px;">Id Video Delete</th>
                            <td><input type="text" name="id_video" /></td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">
                                <input type="submit" value="Delete" name="delete_video" />
                                <input type="reset" class="button_big" value="Reset" />
                            </td>
                        </tr>
                    </table>
                </form> -->
                <script type="text/javascript">
                    $(function() {
                        $('#description').wysiwyg();
                    });
                    function openPage(pageName, elmnt, color) {
                        var i, tabcontent, tablinks;
                        tabcontent = document.getElementsByClassName("tabcontent");
                        for (i = 0; i < tabcontent.length; i++) {
                            tabcontent[i].style.display = "none";
                        }
                        tablinks = document.getElementsByClassName("tablink");
                        for (i = 0; i < tablinks.length; i++) {
                            tablinks[i].style.backgroundColor = "";
                        }
                        document.getElementById(pageName).style.display = "block";
                        elmnt.style.backgroundColor = color;
                    }
                    document.getElementById("defaultOpen").click();
                </script>
            </div>
        </div>
        <?php include_once ('include/footer.php'); ?>
    </div>
</body>

</html>