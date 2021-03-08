package com.sonicscholar;

public class Main {

    public static void main(String[] args) {
        //assignment
        int a = 8;
        int b = 5;

        // arithmetic
        System.out.println("arithmetic");
        System.out.println(a + b); //13
        System.out.println(a - b); //3
        System.out.println(a * b); //40
        System.out.println(a / b); //1.6 ?
        System.out.println((double)a / 5); //cast to double
        System.out.println(a % b); //1 remainder 3
        System.out.println();

        // concatenation
        String s1 = "hello";
        String s2 = "world";

        System.out.println("concatenation");
        System.out.println(s1 + " " + s2);
        System.out.println();

        // comparison
        System.out.println("comparison");
        System.out.println(1 < 2);
        System.out.println(2 <= 2);
        System.out.println(1.5 > 0);
        System.out.println(a == b);
        System.out.println(a != b);
        System.out.println(!(a == b));
        System.out.println('z' > 'm');
        System.out.println();

        // Logic
        System.out.println("logical");
        System.out.println(true && false); //false
        System.out.println(true || false); //true
        System.out.println(true == false); //false
        System.out.println();

        // bitwise logic - use the Calculator App in Programmer Mode!
        System.out.println("bitwise");
        System.out.println(0xFF & 0x7); //0x7
        System.out.println(0x7 | 0xB); //0xF
        System.out.println(0b111 | 0b1011); //15 decimal
        System.out.println(~0xFFFFFF00); //0x000000FF
        System.out.println(~0b11111111111111111111111100000000); //0b11111111 //0xFF //255

        //array access
        int[] numbers = new int[] { 1, 2, 3, 4 };
        System.out.println("array access");
        System.out.println(numbers[0]);
        System.out.println(numbers[numbers.length -1]);
    }
}
