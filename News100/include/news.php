<div class="inner-wrap clearfix">
    <div class="front-page-top-section clearfix">
        <div class="widget_slider_area"></div>
        <div class="widget_beside_slider"></div>
    </div>
    <div class="main-content-section clearfix">
        <?php
            if(!isset($_GET['category'])){
                $_GET['id_news'] = '1';
            }
            echo "<div id='primary'>";
            echo "<div id='content' class='clearfix'>";
                echo "<article class='post-239 post type-post status-publish format-standard has-post-thumbnail hentry category-science tag-beautiful-towns tag-south-africa'>";
                    echo "<div class='article-content clearfix'>";
                    $categoryName = strtolower($news['category_name']);
                    echo "<div class='above-entry-meta'><span class='cat-links'><a href='$url/category/$categoryName/' rel='category tag'>{$news['category_name']}</a>&nbsp;</span></div>";
                    echo "<header class='entry-header'>";
                        echo "<h1 class='entry-title'>{$news['title_news']}</h1>";
                    echo "</header>";
                    echo "<div class='entry-content clearfix'>";
                        echo "<div style=''>";
                            echo "<center>";
                            echo "<ins class='adsbygoogle' style='display:block' data-ad-client='ca-pub-2278542298831513' data-ad-slot='6807463966' data-ad-format='auto' data-full-width-responsive='true'></ins>";
                            echo "<script>(adsbygoogle = window.adsbygoogle || []).push({});</script>";
                            echo "</center>";
                        echo "</div>";
                        echo "<figure id='attachment_241' style='width: 630px' class='wp-caption aligncenter'>";
                            echo "<img class='size-full wp-image-241' src='{$news['url_img']}' alt='{$news['title_news']}' width='630' height='474'>";
                            echo "<figcaption class='wp-caption-text'>{$news['title_news']}</figcaption>";
                        echo "</figure>";
                        echo "<p>{$news['content']}</p>";
                        echo "</p>";
                    echo "</div>";
                    echo "</div>";
                echo "</article>";
            echo "</div>";
            echo "<ul class='default-wp-page clearfix'>";
                $query = mysql_query("SELECT MAX(A.id_news) AS id_news, A.title_news, B.category_name FROM tbl_news A INNER JOIN tbl_category B ON A.category_id = B.category_id WHERE A.id_news < {$idNews} AND A.category_id = {$category};");
                $news = mysql_fetch_array($query);
                $categoryName = strtolower($news['category_name']);
                $titleNews = generate_seo_link($news['title_news'], '-', true, $bad_words);
                if ($news['title_news'] != '') {
                    echo "<li class='previous'><a href='$url/category/$categoryName/$titleNews-{$news['id_news']}.html' rel='prev'><span class='meta-nav'><i class='fas fa-arrow-left'></i></span> {$news['title_news']}</a></li>";
                }

                $query = mysql_query("SELECT MIN(A.id_news) AS id_news, A.title_news, B.category_name FROM tbl_news A INNER JOIN tbl_category B ON A.category_id = B.category_id WHERE A.id_news > {$idNews} AND A.category_id = {$category};");
                $news = mysql_fetch_array($query);
                $titleNews = generate_seo_link($news['title_news'], '-', true, $bad_words);
                if ($news['title_news'] != '') {
                    echo "<li class='next'><a href='$url/category/$categoryName/$titleNews-{$news['id_news']}.html' rel='next'>{$news['title_news']} <span class='meta-nav'><i class='fas fa-arrow-right'></i></span></a></li>";
                }
            echo "</ul>";
        ?>
        <center>
            <!-- 728x90 -->
            <ins class="adsbygoogle"
                style="display:block"
                data-ad-client="ca-pub-2278542298831513"
                data-ad-slot="7356815223"
                data-ad-format="auto"
                data-full-width-responsive="true"></ins>
            <script>
                (adsbygoogle = window.adsbygoogle || []).push({});
            </script>
        </center>
        <div id="comments" class="comments-area">
            <div id="respond" class="comment-respond">
                <h3 id="reply-title" class="comment-reply-title">Leave a Reply <small><a rel="nofollow"
                            id="cancel-comment-reply-link"
                            href="/discover-5-most-beautiful-towns-in-south-africa/#respond"
                            style="display:none;">Cancel reply</a></small></h3>
                <form action="" method="post" id="commentform" class="comment-form" novalidate="">
                    <p class="comment-notes"><span id="email-notes">Your email address will not be published.</span>
                        Required fields are marked <span class="required">*</span></p>
                    <p class="comment-form-comment"><label for="comment">Comment</label> <textarea id="comment"
                            name="comment" cols="45" rows="8" maxlength="65525" aria-required="true"
                            required="required"></textarea></p>
                    <p class="comment-form-author"><label for="author">Name <span class="required">*</span></label>
                        <input id="author" name="author" type="text" value="" size="30" maxlength="245"
                            aria-required="true" required="required"></p>
                    <p class="comment-form-email"><label for="email">Email <span class="required">*</span></label>
                        <input id="email" name="email" type="email" value="" size="30" maxlength="100"
                            aria-describedby="email-notes" aria-required="true" required="required"></p>
                    <!-- <p class="comment-form-url"><label for="url">Website</label> <input id="url" name="url" type="url" value="" size="30" maxlength="200"></p> -->
                    <p class="form-submit"><input name="submit" type="submit" id="submit" class="submit"
                            value="Post Comment"> <input type="hidden" name="comment_post_ID" value="239"
                            id="comment_post_ID">
                        <input type="hidden" name="comment_parent" id="comment_parent" value="0">
                    </p>
                    <p style="display: none;"><input type="hidden" id="akismet_comment_nonce"
                            name="akismet_comment_nonce" value="132a15c21c"></p>
                    <p style="display: none;"></p>
                </form>
            </div>
            <!-- #respond -->
        </div>
        <!-- #comments -->
    </div>
    <?php
        include_once ('include/right_col.php');
    ?>
</div>