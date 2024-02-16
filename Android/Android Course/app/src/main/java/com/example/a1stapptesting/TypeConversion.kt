package com.example.a1stapptesting

/*
toByte()
toShort()
toInt()
toLong()
toFloat()
toDouble()
 */
fun main(args: Array<String>) {
    // Conversion from smaller data type to larger data type - no data loss
    var x:Byte = 127
    var y:Int = x.toInt()   //Converts x to int and pass it to y
    var z:Double = y.toDouble()
    println(x)
    println(y)
    println(z)

    // Conversion from bigger to smaller - data loss possible
    var a:Double = 132.32
    var b:Int = a.toInt()
    var c:Byte = b.toByte()
    println(a)  // 132.32
    println(b)  // 132
    println(c)  // -124
}