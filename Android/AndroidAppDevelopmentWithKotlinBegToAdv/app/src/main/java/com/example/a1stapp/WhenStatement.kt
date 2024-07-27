package com.example.a1stapp

fun main(){
    print("Enter number for day in week (1 to 7): ")
    var dayNr:Int = readLine()!!.toInt()
    var day:String

    when(dayNr){
        1 -> day = "Monday" // -> lambda expression
        2 -> day = "Tuesday"
        3 -> day = "Wednesday"
        4 -> day = "Thursday"
        5 -> day = "Friday"
        6 -> day = "Saturday"
        7 -> day = "Sunday"
        else -> day = "You are an Idiot day!"
    }
    println("Day is: $day")
}
