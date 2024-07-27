package com.example.a1stapptesting

fun main(args: Array<String>) {
    var a:String = "Hello!"
    var b:String = "Beaver!"
    println(a)
    println(b)
    print(a + " " + b)

    var age:Int = 36
    println("Your age is: " + age)

    var x:String = "Kotlin"
    var i:Int = x.length
    println("Length of string " + x + " is " + i + " characters.")
    var c:Boolean = x.equals("Beaver")
    println("Does Kotlin equals to Beaver? - " + c)
    println("Is the string empty? - " + x.isEmpty())
    println(x.uppercase())
    println(x.lowercase())


}