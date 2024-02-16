package com.example.a1stapptesting

fun main(args: Array<String>) {
    var age = arrayOf(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 9)
    println("First element of array age at index [0]: " + age[0])   // Showing element at index
    println("Fifth element of array age at index [4]: " + age[4])
    println("Tenth element of array age at index [9]: " + age[9])

    var cars = arrayOf("BMW", "Dodge", "Ford")
    println("First element of array cars is: " + cars[0])
    println("Second element of array cars is: " + cars[1])
    println("Third element of array cars is: " + cars[2])

    cars.set(0, "Bawo") // Replaces element in array
    println("Element 0 at cars replaced...")
    println("New car at element 0: " + cars[0])

    println("Size of array age is: " + age.size + " elements")  // Returns size of array

    var carAndPower = arrayOf("BMW", 300, "Skoda", 105, "Audi", 23) // Array of multi types
    println("Car " + carAndPower[0] + " has " + carAndPower[1] + " kw.")
    println("Car " + carAndPower[2] + " has " + carAndPower[3] + " kw.")
    println("Car " + carAndPower[4] + " has " + carAndPower[5] + " kw.")
}