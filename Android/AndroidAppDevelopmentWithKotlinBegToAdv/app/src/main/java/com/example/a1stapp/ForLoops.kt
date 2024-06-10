package com.example.a1stapp

fun main(){
    for (number in 1..10){
        println("Actual loop iteration: $number")
    }

    var sum:Int = 0
    for (x in 0..10){
        if (x % 2 == 0){
            println(x)
            sum += x
            println("Current summary of even numbers is: $sum")
        }
    }
    println("Final sum is: $sum")

    var myNumberArray = arrayListOf<Int>(1,2,3,4,5,6,7,8,9,10)
    for (y in 0..(myNumberArray.size)-1){
        println("myNumberArray[$y] = ${myNumberArray[y]}")  //printing index of array + content
    }

    for (y in myNumberArray.indices){
        println("myNumberArray[$y] = ${myNumberArray[y]}")  // exactly same output as above
    }

}