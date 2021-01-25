/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package contactapp;
// Abagail Hankey
// Intro to Java
// Project 5
// 7/17/2020
// This program adds, updates, removes, and lists contacts stored
import java.util.Scanner;
public class ContactApp {
     static ContactBook contactBook;
     static Scanner scanner;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        contactBook = new ContactBook();
        scanner = new Scanner(System.in);
        int choice = 0;
        while (choice != 5) {
            choice = displayMenuAndReturnChoice();
            switch (choice) {
            case 1: //Adding a contact//
                Contact c = getContactInput();
                contactBook.add(c);
                break;
            case 2://updating//
                c = getContactInput();
                System.out.println("Enter the position to be updated: ");
                int pos = Integer.parseInt(scanner.nextLine());
                contactBook.update(pos, c);
                break;
            case 3://removing//
                System.out.println("Enter the position of contact to be removed: ");
                pos = Integer.parseInt(scanner.nextLine());
                contactBook.remove(pos);
                break;            
            case 4://displaying//
                System.out.println(contactBook);
                break;
            case 5://Save a contactbook
                contactBook.save();
                break;
            case 6://Load a contactbook
                contactBook.load();
                break;
            case 7:
                System.out.println("Exiting...");
                break;
            }
        }
    }
    static int displayMenuAndReturnChoice() {
        System.out.println("1. Add a contact");
        System.out.println("2. Update a contact");
        System.out.println("3. Remove a contact");
        System.out.println("4. List all contacts");
        System.out.println("5. Save");
        System.out.println("6. Load");
        System.out.println("7. Exit");
        System.out.println("Please enter your choice: ");
        try {
            int choice = Integer.parseInt(scanner.nextLine());
            if (choice >= 1 && choice <= 5) {
                return choice;
             
            } else {
                System.out.println("Invalid choice, try again");
                return displayMenuAndReturnChoice();
            }
        } catch(Exception e){
            System.out.println("Invalid input, try again...");
            return displayMenuAndReturnChoice();
        }
    }
    private static Contact getContactInput() {
        Contact c = new Contact();
        System.out.println("Enter name: ");
        String name = scanner.nextLine();
        System.out.println("Enter address: ");
        String address = scanner.nextLine();
        System.out.println("Enter phone: ");
        String phone = scanner.nextLine();
        System.out.println("Enter email: ");
        String email = scanner.nextLine();
        c.setName(name);
        c.setPhone(phone);
        c.setAddress(address);
        c.setEmail(email);
        return c;
    }
}