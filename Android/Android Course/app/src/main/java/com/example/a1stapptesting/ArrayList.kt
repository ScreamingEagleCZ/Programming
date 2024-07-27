package com.example.a1stapptesting

fun main(args: Array<String>) {
    var age = ArrayList<Int>()  // Defining Array list

    age.add(10) // Adding element to list
    age.add(1, 51)  // Diferent version to adding to list
    age.add(8)

    println("First element of age: " + age[0])
    println("Second element of age: " + age[1])
    println("Third element of age: " + age[2])
    println()

    age.add(1, 45)  // Adding into the middle of the list
    println("First element of age: " + age[0])
    println("Second element of age: " + age[1])
    println("Third element of age: " + age[2])
    println("Fourth element of age: " + age[3])
    println()

    age.remove(51)  // Removing element from list
    println("First element of age: " + age[0])
    println("Second element of age: " + age[1])
    println("Third element of age: " + age[2])
    println()

    var cars = arrayListOf<String>("BMW", "Chevrolet")  // Second type of Array List definition
    cars.add("DMC")
    println("First element of cars: " + cars[0])
    println("Second element of cars: " + cars[1])
    println("Third element of cars: " + cars[2])
    println()

    var myMixedArray = ArrayList<Any>() // Definition of Array with not defined type - ANy type
    myMixedArray.add("Ford")
    myMixedArray.add(5)
    myMixedArray.add(2.5)
    myMixedArray.add(true)
    myMixedArray.add('X')
    println("First element of myMixedArray: " + myMixedArray[0])
    println("Second element of myMixedArray: " + myMixedArray[1])
    println("Third element of myMixedArray: " + myMixedArray[2])
    println("Fourth element of myMixedArray: " + myMixedArray[3])
    println("Fifth element of myMixedArray: " + myMixedArray[4])
}