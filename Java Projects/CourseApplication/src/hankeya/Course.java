/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hankeya;
// Abagail Hankey
    // Intro to Java: Project 6
    // This program saves and displays information of courses and registration

import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;
import java.util.List;

public class Course {
  private String courseId;
    private String courseName;
    private String courseCode;
    private Instructor instructor;
    // Creating a ArrayList to store Students
    private final List<Student> roster = new ArrayList<>();

    public String getCourseId() {
        return courseId;
    }

    public void setCourseId(String courseId) {
        this.courseId = courseId;
    }

    public String getCourseName() {
        return courseName;
    }

    public void setCourseName(String courseName) {
        this.courseName = courseName;
    }

    public String getCourseCode() {
        return courseCode;
    }

    public void setCourseCode(String courseCode) {
        this.courseCode = courseCode;
    }

    public Instructor getInstructor() {
        return instructor;
    }

    public void setInstructor(Instructor instructor) {
        this.instructor = instructor;
    }

    /**
     * Adds a Student to the roster
     * @param student
     */
    public void addStudent(Student student) {
        roster.add(student);
    }

    /**
     * Removes a Student from the roster
     * @param personId
     */
    public void removeStudent(String personId) {
        // To delete a Student looping through the roster and comparing the students by personId
        Iterator<Student> studentIterator = roster.iterator();
        while (studentIterator.hasNext()) {
            Student student = studentIterator.next();
            // When match is found, deleting the student
            if (student.getPersonId().equalsIgnoreCase(personId)) {
                studentIterator.remove();
            }
        }
    }

    @Override
    public String toString() {

        Collections.sort(roster);
        StringBuilder stringBuilder = new StringBuilder();
        for (Student student : roster) {
            stringBuilder.append(student.toString());
            stringBuilder.append("\n");
        }
        String roster = stringBuilder.toString();

        return courseId + '\n' +
                courseName + '\n' +
                courseCode + '\n' +
                "\n" +
                "Instructor\n" +
                "------------------------------------------------------------\n" +
                instructor.toString() + "\n" +
                "\n" +
                "Student Roster\n" +
                "-------------------------------------------------------------\n" +
                roster;
    }
}
