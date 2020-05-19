<header id="masthead" class="site-header clearfix">
    <div id="header-text-nav-container" class="clearfix">
        <div class="inner-wrap">
            <div id="header-text-nav-wrap" class="clearfix">
                <div id="header-left-section">
                    <div id="header-text" class="">
                        <h1 id="site-title">
                            <a href="<?php echo $url; ?>/" title="Car News" rel="home">Car News</a>
                        </h1>
                        <!-- #site-description -->
                    </div>
                    <!-- #header-text -->
                </div>
                <!-- #header-left-section -->
                <div id="header-right-section">
                </div>
                <!-- #header-right-section -->
            </div>
            <!-- #header-text-nav-wrap -->
        </div>
        <!-- .inner-wrap -->
        <nav id="site-navigation" class="main-navigation clearfix" role="navigation">
            <div class="inner-wrap clearfix">
                <!-- <div class="<?php if ($category == 'home'){ echo 'front_page_on'; } ?> home-icon">
                        <a href="<?php echo $url; ?>/" title="Taglifes"><i class="fa fa-home"></i></a>
                     </div> -->
                <h4 class="menu-toggle"></h4>
                <div class="menu-primary-container">
                    <ul id="menu-menu-1" class="menunav-menu">
                        <li id="menu-item-6"
                            class="menu-item menu-item-type-custom menu-item-object-custom <?php if ($category == 'home'){ echo 'current-menu-item '; } ?> menu-item-home menu-item-6">
                            <a href="<?php echo $url; ?>/">Home</a></li>
                        <li id="menu-item-9"
                            class="menu-item menu-item-type-taxonomy menu-item-object-category <?php if ($category == '1'){ echo 'current-menu-item '; } ?> menu-item-9">
                            <a href="<?php echo $url; ?>/category/car-news">Car News</a></li>
                        <li id="menu-item-12"
                            class="menu-item menu-item-type-taxonomy menu-item-object-category <?php if ($category == '2'){ echo 'current-menu-item '; } ?> menu-item-12">
                            <a href="<?php echo $url; ?>/category/shopping">Shopping</a></li>
                        <li id="menu-item-10"
                            class="menu-item menu-item-type-taxonomy menu-item-object-category <?php if ($category == '3'){ echo 'current-menu-item '; } ?> menu-item-10">
                            <a href="<?php echo $url; ?>/category/skin">Skin</a></li>
                        <li id="menu-item-10"
                            class="menu-item menu-item-type-taxonomy menu-item-object-category <?php if ($category == '4'){ echo 'current-menu-item '; } ?> menu-item-10">
                            <a href="<?php echo $url; ?>/category/insurance">Insurance</a></li>
                    </ul>
                </div>
                <!-- <div class="search-form-top">
                        <form action="" class="search-form searchform clearfix" method="get">
                           <div class="search-wrap">
                              <input type="text" placeholder="Search" class="s field" name="s">
                              <button class="search-icon" type="submit"></button>
                           </div>
                        </form>
                     </div> -->
            </div>
        </nav>
    </div>
    <!-- #header-text-nav-container -->
    <?php
         /* takes the input, scrubs bad characters */
         function generate_seo_link($input, $replace = '-', $remove_words = true, $words_array = array()) {
            //make it lowercase, remove punctuation, remove multiple/leading/ending spaces
            $return = trim(ereg_replace(' +', ' ', preg_replace('/[^a-zA-Z0-9\s]/', '', strtolower($input))));

            //remove words, if not helpful to seo
            //i like my defaults list in remove_words(), so I wont pass that array
            if($remove_words) { $return = remove_words($return, $replace, $words_array); }

            //convert the spaces to whatever the user wants
            //usually a dash or underscore..
            //...then return the value.
            return str_replace(' ', $replace, $return);
         }

         /* takes an input, scrubs unnecessary words */
         function remove_words($input,$replace,$words_array = array(),$unique_words = true)
         {
            //separate all words based on spaces
            $input_array = explode(' ',$input);

            //create the return array
            $return = array();

            //loops through words, remove bad words, keep good ones
            foreach($input_array as $word)
            {
               //if it's a word we should add...
               if(!in_array($word,$words_array) && ($unique_words ? !in_array($word,$return) : true))
               {
                     $return[] = $word;
               }
            }

            //return good words separated by dashes
            return implode($replace,$return);
         }
         $bad_words = array('a','and','the','an','it','is','with','can','of','why','not');
   ?>
</header>