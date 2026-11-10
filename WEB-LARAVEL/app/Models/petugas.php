<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Foundation\Auth\User;

class petugas extends Model
{
    protected $fillable = [
        'id_petugas',
        'username',
        'password',
        'nama_tugas',
        'level',
        'create_at',
        'update_at'
    ];
}
