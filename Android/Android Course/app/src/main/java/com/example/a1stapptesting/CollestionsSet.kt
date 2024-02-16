package com.example.a1stapptesting

fun main(args: Array<String>) {
    // Normal Array can have dulicate elements
    var mySetArray = arrayListOf<Any>("Kotlin", 2, 2.5, 'K', true, "Kotlin")
    println(mySetArray.size)    // 6 printed
    println(mySetArray.last())  // Kotlin printed
    println()

    // Set array cannot of multiple same elements - duplicates,
    // even defined it will not be inside of array
    var mySetArray2 = setOf<Any>("Kotlin", 2, 2.5, 'K', true, "Kotlin")
    println(mySetArray2.size)   // 5 printed
    println(mySetArray2.last()) // true printed
}