package com.example.a1stapp

fun main(){
    var result:Int = 5 + 2 * 4  // Multiplication has priority
    println("result: " + result)

    result = (5 + 2) * 4    // Parenthesis have priority
    println("result: " + result)

    var x:Int = 8
    var y:Int = 4
    var z:Int = 2
    var sum:Int = 0

    sum = x + --y + --z // --has priority
    println("Sum: " + sum)
}