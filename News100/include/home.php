<div class="inner-wrap clearfix">
    <div class="front-page-top-section clearfix">
        <div class="widget_slider_area"></div>
        <div class="widget_beside_slider"></div>
    </div>
    <div class="main-content-section clearfix">
        <div id="primary">
            <div id="content" class="clearfix">
                <?php
                    if ($pagetitle != '') {
                        echo "<header class='page-header'><h1 class='page-title'><span>$pagetitle</span></h1></header>";
                    }
                ?>
                <div class="article-container">
                    <?php
                               $pages_per_segment = 3;
                               $rows_per_page = 20;
                               $query = "SELECT category_name, id_news, title_news, SUBSTRING_INDEX(description_news,' ',20) AS description_news, url_img FROM tbl_news A INNER JOIN tbl_category B ON A.category_id = B.category_id ";
                               if ($category != 'home') {
                                   $query .= "WHERE A.category_id = $category ";
                               }
                               $results       = mysql_query($query) or die ('Không lấy được cơ sở dữ liệu');
                               $records       = mysql_num_rows($results);
                               // Tổng số trang = tổng số dòng / số dòng trên 1 trang
                               $totalpages    = ceil($records / $rows_per_page);
                               // tổng số phân đoạn = tổng số trang / số trang trên 1 phân đoạn
                               $totalsegments = ceil($totalpages / $pages_per_segment);
                               // trang hiện tại
                               if (isset($_GET['p'])) {
                                   $current_page = intval($_GET['p']);
                               } else { // Người dùng không chọn thì mặc định là trang 1
                                   $current_page = 1;
                               }
                               // phân đoạn hiện tại: trang hiện tại / số trang 1 phân đoạn
                               $current_segment = ceil($current_page / $pages_per_segment);
                               
                               // trang bắt đầu
                               $start_page = ($current_page - 1) * $rows_per_page;
                               
                               // nối chuỗi -> query LIMIT
                               $query .= "ORDER BY A.date_news DESC LIMIT {$start_page}, {$rows_per_page};";
    
                               $results = mysql_query($query);
                               // xuất CSDL
                               $count = 0;
                               if($results && mysql_num_rows($results) > 0){
                                 while($rows = mysql_fetch_array($results)){
                                     $categoryName = str_replace(' ', '-', strtolower($rows['category_name']));
                                     $titleNews = generate_seo_link($rows['title_news'], '-', true, $bad_words);
                                     echo "<article class='post-239 post type-post status-publish format-standard has-post-thumbnail hentry category-science tag-beautiful-towns tag-south-africa'>";
                                         echo "<div class='featured-image'>";
                                             echo "<a href='$url/category/$categoryName/$titleNews-{$rows['id_news']}.html' title='{$rows['title_news']}'>";
                                             if ($count == 0) {
                                                 echo "<a href='$url/category/$categoryName/$titleNews-{$rows['id_news']}.html' title='{$rows['title_news']}'><img width='800' height='445' src='{$rows['url_img']}' class='attachment-colormag-featured-image size-colormag-featured-image wp-post-image' alt='{$rows['title_news']}'></a>";
                                             } else {
                                                 echo "<img width='630' height='445' src='{$rows['url_img']}' class='attachment-colormag-featured-image size-colormag-featured-image wp-post-image' alt='{$rows['title_news']}'>";
                                             }
                                             echo "</a>";
                                         echo "</div>";
                                         echo "<div class='article-content clearfix'>";
                                             echo "<div class='above-entry-meta'><span class='cat-links'><a href='$url/category/$categoryName/' rel='category tag'>{$rows['category_name']}</a>&nbsp;</span></div>";
                                             echo "<header class='entry-header'>";
                                                 echo "<h2 class='entry-title'>";
                                                     echo "<a href='$url/category/$categoryName/$titleNews-{$rows['id_news']}.html' title='{$rows['title_news']}'>{$rows['title_news']}</a>";
                                                 echo "</h2>";
                                             echo "</header>";
                                             echo "<div class='entry-content clearfix'>";
                                                 echo "<p>{$rows['description_news']}</p>";
                                                 echo "<a class='more-link' title='{$rows['title_news']}' href='$url/category/$categoryName/$titleNews-{$rows['id_news']}.html'><span>Read more</span></a>";
                                             echo "</div>";
                                         echo "</div>";
                                     echo "</article>";
                                     $count++;
                                 }
                               }
                               echo "<div class='mh-loop-pagination clearfix' style='clear: both;'>";
                               //Xuất số trang bên dưới để người dùng chọn ==> thực hiện hành động truyền tham số cho p
                               // Lấy địa chỉ hiện tại
                               $sPage = "";

                               // nếu không phải là phân đoạn đầu tiên
                               if($current_segment - 1 != 0){
                                   $sPage .= "<a class='page-numbers' href='$url/page/1'> &laquo; </a>&nbsp;";
                                   $sPage .= "<a class='page-numbers' href='$url/page/" . (($current_segment -1) * $pages_per_segment) ." '> &lsaquo; </a>&nbsp;";
                               }

                               $count = ($totalpages <= $current_segment * $pages_per_segment) ? ($totalpages - ($current_segment - 1) * $pages_per_segment) : $pages_per_segment;
                               for($i = 1; $i <= $count; $i++){
                                   $page = ($current_segment - 1) * $pages_per_segment + $i;
                                   $sPage .= "<a href ='$url/page/" . $page . "' " . (($page == $current_page) ? "class='page-numbers current'" : "class='page-numbers'") . " >" . ($page) . "</a>&nbsp;";
                               }
                               if($current_segment < $totalsegments){
                                   $sPage .= "<a class='page-numbers' href='$url/page/" . (($current_segment) * $pages_per_segment + 1) . "'> &rsaquo; </a>&nbsp;";
                               $sPage .= "<a class='page-numbers' href = '$url/page/" . ($totalpages) . "'> &raquo; </a>&nbsp;";
                               }
                               echo $sPage;
                               echo "</div>";
                           ?>
                            <script async src='https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js'></script>
                            <!-- 728x90 -->
                            <ins class='adsbygoogle'
                                style='display:block'
                                data-ad-client='ca-pub-2278542298831513'
                                data-ad-slot='7356815223'
                                data-ad-format='auto'
                                data-full-width-responsive='true'></ins>
                            <script>
                                (adsbygoogle = window.adsbygoogle || []).push({});
                            </script>
                </div>
            </div>
        </div>
        <?php
                      include_once ('include/right_col.php');
                  ?>
    </div>
</div>