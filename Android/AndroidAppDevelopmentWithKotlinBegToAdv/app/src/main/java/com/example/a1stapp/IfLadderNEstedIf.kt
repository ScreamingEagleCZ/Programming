package com.example.a1stapp

fun main() {
    println("Please enter your age: ")
    var age:Int = readLine()!!.toInt()

    if (age < 13) {
        println("Go pull your rubber ducky!")
    } else if (age < 15) {
        println("Go ride a bicycle!")
    } else if (age < 21 ) {
        println("You can ride a kiddie bike...enjoy ;)")
    } else {
        if (age < 65) {
            println("Finally u can ride a Man-o-taur motorbike! Go get em tiger!!!")
        } else {
            println("Hope you enjoyed your life so far...now rule the rest!!!")
        }
    }

    println("Please enter 3 numbers: ")
    var number1:Int = readLine()!!.toInt()
    var number2:Int = readLine()!!.toInt()
    var number3:Int = readLine()!!.toInt()
    var largestNumber:Int

    if (number1 >= number2){
        if (number1 >= number3){
            largestNumber = number1
        } else {
            largestNumber = number3
        }
    } else {
        if (number2 >= number3){
            largestNumber = number2
        } else {
            largestNumber = number3
        }
    }
    println("Largest number is $largestNumber...")
}


