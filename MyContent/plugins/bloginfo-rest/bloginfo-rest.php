<?php
/**
 * @package Blog Info REST
 * @version 1.0.0
 */
/*
Plugin Name: Blog Info REST
Plugin URI: http://wordpress.org/
Description: Adds an endpoint for blog info to the Wordpress REST API.
Author: Robert Sundström
Version: 1.0.0
Author URI: https://www.robetsundstrom.com/
*/

function get_my_bloginfo() {
    return array(
        "name" => get_bloginfo('name'),
        "description" => get_bloginfo('description'),
        "url" => get_bloginfo('url'));
}

add_action( 'rest_api_init', function () {
    register_rest_route( 'wp/v2', '/bloginfo', array(
        'methods' => 'GET',
        'callback' => 'get_my_bloginfo',
    ) );
} );