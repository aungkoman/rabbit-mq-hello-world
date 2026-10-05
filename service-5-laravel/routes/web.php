<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\TestController;

Route::get('/', [TestController::class, 'index'])->name('home');

Route::get('/up', function () {
    return response()->noContent();
});
Route::get('/404', function () {
    return response("404");
});
