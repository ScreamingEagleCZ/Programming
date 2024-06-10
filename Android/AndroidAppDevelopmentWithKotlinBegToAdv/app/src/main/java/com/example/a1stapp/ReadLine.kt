package com.example.a1stapp

fun main(){
    print("Gimme your name! ")  // without ln the cursor stays on same line
    var name:String? = readLine()   // version with ?
    print("Gimme your age! ")
    var age:Int = readLine()!!.toInt()  // version with !! + conversion

    println("Hello " + name + "! " + age + " is pretty lot...have you considered " +
            "buying a motorbike yet?")
}