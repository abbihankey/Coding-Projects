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
    import java.util.Arrays;
    import java.util.Scanner;
    import java.io.IOException;
    import java.io.FileOutputStream;

public class ContactBook {
    ContactFileManager fileMan = new ContactFileManager(); 
    private Contact[] entries = null; 
    Scanner s = new Scanner(System.in);
    
    public void add(Contact c) {    
        if (entries == null) {
            entries = new Contact[1];
            entries[0] = c;
        } else {
            entries = Arrays.copyOf(entries, entries.length + 1);
            entries[entries.length - 1] = c;
        }
        System.out.println("Contact added!");
    }
    public void update(int pos, Contact c) {
        if (pos >= 0 && pos < entries.length) {
            entries[pos] = c;
            System.out.println("Contact updated!");
        } else {
            System.out.println("Invalid position");
        }
    }
    public void remove(int pos) {
        if (pos >= 0 && pos < entries.length) {
            for (int i = pos; i < entries.length - 1; i++) {
                 entries[pos] = entries[pos + 1];
            }
            entries = Arrays.copyOf(entries, entries.length - 1);
            System.out.println("Contact updated!");
        } else {
               System.out.println("Specified index doesn't exist!");
        }
    }
    public String toString() {
        String data = "";
        for (int i = 0; i < entries.length; i++) {
            data += i + ") " + entries[i].toString() + "\n";
        }
        return data;
    }
    public void save() { 
        String filename;
        System.out.print("Enter the filename to save to: "); 
        filename = s.nextLine(); 
        fileMan.writeContacts(filename, entries); 
    } 
    public void load() { 
        String filename;
        System.out.print("Enter the filename to save to: "); 
        filename = s.nextLine(); 
        entries = fileMan.readContacts(filename); 
    }
}   



