package com.example.a1stapp

fun main(){
    var myCharRange = 'a'.rangeTo(other = 'j')  // a and j are included in range
    var myChar = 'k' in myCharRange
    println("myCharRange has k: " + myChar)

    var myCharRange2 = 'A'..'F' // Second style of definition
    var myChar2 = 'E' in myCharRange2
    println("myCharRange2 has E: " + myChar2)
}