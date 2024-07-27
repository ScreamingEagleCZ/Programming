package com.example.a1stapptesting

fun main(args: Array<String>) {
    println("***** Immutable Map *****")
    var cars = mapOf<String,Int>("BMW" to 1, "Ford" to 2, "Dodge" to 3)  // Key value pairs
    println("Ford car: " + cars["Ford"])
    println("Dodge car: " + cars["Dodge"])
    println("BMW car: " + cars["BMW"])
    println()

    println("***** Mutable Map *****")
    var cars2 = mutableMapOf<String,Int>("BMW" to 1, "Ford" to 2, "Dodge" to 3)  // see mutable fc
    cars2.put("Hyunday", 58)    // Adding element to map array
    println("Ford car: " + cars2["Ford"])
    println("Dodge car: " + cars2["Dodge"])
    println("BMW car: " + cars2["BMW"])
    println("Hyunday car: " + cars2["Hyunday"])
    println()
}