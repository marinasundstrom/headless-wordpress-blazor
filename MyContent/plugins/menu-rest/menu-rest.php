<?php
/**
 * @package Menu REST
 * @version 1.0.0
 */
/*
Plugin Name: Menu REST
Plugin URI: http://wordpress.org/
Description: Adds an endpoint for menus to the Wordpress REST API.
Author: Robert Sundström
Version: 1.0.0
Author URI: https://www.robetsundstrom.com/
*/

function get_my_menu( $data ) {
    // Replace your menu name, slug or ID carefully
    return wp_get_nav_menu_items($data['id']);
}

add_action( 'rest_api_init', function () {
    register_rest_route( 'wp/v2', '/menus/(?P<id>\S+)', array(
        'methods' => 'GET',
        'callback' => 'get_my_menu',
    ) );
} );