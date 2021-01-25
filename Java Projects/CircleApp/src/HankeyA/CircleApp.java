/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package HankeyA;
/**
 *
 * @author abbih
 */
import java.util.Scanner;
public class CircleApp {

    // Abagail Hankey
    // 6/26/2020
    // Intro to Java
    // This program calculates circle area from user input
    
    public static void main(String[] args) {
        
        double radius;
        // get user input and try for exeption 
        try (Scanner stdln = new Scanner(System.in)) {
            
            System.out.print("Please enter the radius of a circle: ");
            radius = stdln.nextDouble();
        }
        
        //create object, why isn't contructor working?
        Circle circle = circle.new Circle(radius);

        // output
        System.out.println("Area: " + circle.getArea());
        System.out.println("Diameter: " + circle.getDiameter());
        System.out.println("Circumference: " + circle.getCircumference());
    }  
}
