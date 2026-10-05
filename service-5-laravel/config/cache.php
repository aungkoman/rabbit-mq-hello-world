<?php

return [

    'default' => env('CACHE_STORE', 'array'),

    'stores' => [

        'redis' => [
            'driver' => 'redis',
            'connection' => 'cache',
            'lock_connection' => 'default',
        ],

    ],

    'prefix' => env('CACHE_PREFIX', str_replace('.', '_', env('APP_NAME', 'laravel').'_cache')),

];
