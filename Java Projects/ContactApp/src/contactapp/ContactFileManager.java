/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package contactapp;
    import java.io.FileInputStream; 
    import java.io.FileOutputStream; 
    import java.io.ObjectInputStream; 
    import java.io.ObjectOutputStream;
    import java.io.IOException;
public class ContactFileManager {
    public void writeContacts(String filename, Contact[] contacts) { 
        try { 
        FileOutputStream fos = new FileOutputStream(filename); 
        ObjectOutputStream oos = new ObjectOutputStream(fos); 
        oos.writeObject(contacts); 
        oos.close(); 
        fos.close(); 
        } catch ( Exception ex) { 
        
        } 
    } 
    
    public Contact[] readContacts(String filename) { 
        Contact[] contacts = null; 
        try { 
            FileInputStream fis = new FileInputStream(filename); 
            ObjectInputStream ois = new ObjectInputStream(fis); 
            contacts = (Contact[]) ois.readObject(); 
            ois.close(); 
            fis.close(); 
        } catch (Exception ex) { 
            System.out.println("Some exception occured: " + ex.toString()); 
        } 
        return contacts; 
    } 
}
       
 