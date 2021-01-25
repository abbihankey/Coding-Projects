/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hankeya;

// Abagail Hankey
    // Intro to Java: Project 6
    // This program saves and displays information of courses and registration
public class Student extends Person {
    private String major;
    private double gpa;

    public String getMajor() {
        return major;
    }

    public void setMajor(String major) {
        this.major = major;
    }

    public double getGpa() {
        return gpa;
    }

    public void setGpa(double gpa) {
        this.gpa = gpa;
    }

    @Override
    public String toString() {
        return super.toString() + "\t" + major + "\t" + gpa;
    }
}
