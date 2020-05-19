<div id="secondary">
                     <aside id="text-2" class="widget widget_text clearfix">
                        <h3 class="widget-title"><span>Search By Google</span></h3>
                        <div class="textwidget">
                           <style type="text/css">
                              @import url(//www.google.com/cse/api/branding.css);
                           </style>
                           <div class="cse-branding-bottom" style="background-color:#FFFFFF;color:#000000">
                              <div class="cse-branding-form">
                                 <form action="http://www.google.com/" id="cse-search-box">
                                    <div>
                                       <input type="hidden" name="cx" value="006236088925092053547:whft8zbmm2l">
                                       <input type="hidden" name="ie" value="UTF-8">
                                       <input type="text" name="q" size="55">
                                       <input type="submit" name="sa" value="Search">
                                    </div>
                                 </form>
                              </div>
                              <div class="cse-branding-logo">
                                 
                              </div>
                              <div class="cse-branding-text">
                                 Custom Search
                              </div>
                           </div>
                        </div>
                     </aside>
                     <aside id="text-3" class="widget widget_text clearfix">
                        <div class="textwidget">
                            <!-- Hinh Vuong -->
                           <!-- 336x280 -->
                           <ins class="adsbygoogle"
                              style="display:block"
                              data-ad-client="ca-pub-2278542298831513"
                              data-ad-slot="6807463966"
                              data-ad-format="auto"
                              data-full-width-responsive="true"></ins>
                           <script>
                              (adsbygoogle = window.adsbygoogle || []).push({});
                           </script>
                        </div>
                     </aside>
                     <aside id="recent-posts-2" class="widget widget_recent_entries clearfix">
                         <h3 class="widget-title"><span>Recent Posts</span></h3>
                         <ul>
                             <?php
                             $query = "SELECT id_news, title_news, B.category_url FROM tbl_news A INNER JOIN tbl_category B ON A.category_id = B.category_id ORDER BY date_news DESC LIMIT 5;";
                             $results = mysql_query($query) or die ('Không lấy được cơ sở dữ liệu');
                             // xuất CSDL
                             if($results && mysql_num_rows($results) > 0){
                                while($rows = mysql_fetch_array($results)){
                                    $titleNews = generate_seo_link($rows['title_news'], '-', true, $bad_words);
                                    echo "<li><a href='$url/category/{$rows['category_url']}/$titleNews-{$rows['id_news']}.html'>{$rows['title_news']}</a></li>";
                                }
                             }
                            ?>
                        </ul>
                     </aside>
                  </div>