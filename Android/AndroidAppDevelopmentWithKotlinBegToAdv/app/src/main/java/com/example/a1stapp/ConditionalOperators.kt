package com.example.a1stapp

fun main(){
    var numberA:Int = 5
    var numberB:Int = 8
    var numberC:Int = 12

    var result:Boolean = false

    //Conditional Operator &&
    result = (numberA > numberB) && (numberC > numberB)
    println("Result: " + result)

    //Conditional Operator ||
    result = (numberA > numberB) || (numberC > numberB)
    println("Result: " + result)
}