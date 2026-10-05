<?php

use Illuminate\Support\Facades\Artisan;

test('application homepage loads', function () {
    $response = $this->get('/');

    $response->assertStatus(200);
});

test('database connection works', function () {
    try {
        Artisan::call('db:show');
        $this->assertTrue(true);
    } catch (\Exception $e) {
        $this->fail('Database connection failed: ' . $e->getMessage());
    }
});
