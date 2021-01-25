/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package contactapp;
    import java.io.Serializable;
// Abagail Hankey
// Intro to Java
// Project 5
// 7/17/2020
// This program adds, updates, removes, and lists contacts stored
public class Contact implements Serializable{
    private String name;
    private String address;
    private String phone;
    private String email;
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public String getAddress() {
        return address;
    }
    public void setAddress(String address) {
        this.address = address;
    }
    public String getPhone() {
        return phone;
    }
    public void setPhone(String phone) {
        this.phone = phone;
    }
    public String getEmail() {
        return email;
    }
    public void setEmail(String email) {
        this.email = email;
    }
    public String toString() {
        return name + "\t" + address + "\t" + phone + "\t" + email;
    }
}
