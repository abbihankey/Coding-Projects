/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hankeya;

// Abagail Hankey
    // Intro to Java: Project 6
    // This program saves and displays information of courses and registration
public abstract class Person implements Comparable<Person> {
    
    private String personId;
    private String lastName;
    private String firstName;

    public String getPersonId() {
        return personId;
    }

    public void setPersonId(String personId) {
        this.personId = personId;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    @Override
    public String toString() {
        return personId + '\t' + lastName + '\t' + firstName;
    }

    @Override
    public int compareTo(Person person) {

        if (lastName.equalsIgnoreCase(person.lastName)) {
            return firstName.compareTo(person.firstName);
        } else {
            return lastName.compareTo(person.lastName);
        }
    }
}
