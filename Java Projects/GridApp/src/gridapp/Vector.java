 /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gridapp;

public class Vector {
    //def variables
    private final String DIRECTION;
    private final int MAGNITUDE;
    // constructor
    Vector(String directon, int magnitude)
    {        
        this.DIRECTION = directon;
        this.MAGNITUDE = magnitude;
    }
    public String getDirection()
    {
        return DIRECTION;
    }
    public int getMagnitude()
    {
        return MAGNITUDE;
    }
}
      
