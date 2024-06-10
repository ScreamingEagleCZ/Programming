package com.example.a1stapp

fun main(){
    print("Please enter a number: ")
    var number:Int = readLine()!!.toInt()

    if (number % 2 == 0) {
        println("$number is even")
    } else {
        println("$number is odd")
    }

}