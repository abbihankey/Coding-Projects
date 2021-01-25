/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hankeya;

// Abagail Hankey
    // Intro to Java: Project 6
    // This program saves and displays information of courses and registration
public class Instructor extends Person {
    private String title;
    private String department;

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDepartment() {
        return department;
    }

    public void setDepartment(String department) {
        this.department = department;
    }

    @Override
    public String toString() {
        return super.toString() + "\t" + title + "\t" + department;
    }
}
