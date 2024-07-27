package com.example.a1stapp

fun main() {
    var x:Int = 20
    var y:Int = 15
    var z:Int = 0

    println("x = 20, y = 15")
    z = x + y
    println("x + y is: " + z)

    z += x
    println("z += x is: " + z)

    z -= y
    println("z -= y is: " + z)

    z *= x
    println("z *= x is: " + z)

    z /= y
    println("z /= y is: " + z)

    z %= x
    println("z %= x is:" + z)
}