/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gridapp;
import java.util.Scanner;
// Abagail Hankey
// Intro to Java Project 4
// 7/4/2020
public class GridApp {
    public static void main(String[] args) {
        // def variables
        String choice;
        String sentence;
        int magnitude;
        boolean done = false;
        Scanner stdln = new Scanner(System.in);
        Grid grid = new Grid(10, 10);
        Box box;
        while(!done)
        {
            //create grid
            grid.draw();
            System.out.print("Enter (U)p, (D)own, (L)eft, (R)ight, or (E)xit (capital letters only): ");
            //get input
            choice = stdln.nextLine();
            if (!choice.equals("E"))
            {
                System.out.print("Enter a magnitude(integer): ");
                magnitude = stdln.nextInt();
                sentence = stdln.nextLine();
                Vector vector = new Vector(choice, magnitude);
                box = grid.getBox();
                box.push(vector);
            }
            else if (choice.equals("E"))
            {
                done = true;
            }
        }        
    }    
}