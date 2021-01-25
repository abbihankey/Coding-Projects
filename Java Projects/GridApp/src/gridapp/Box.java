/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gridapp;

/**
 *
 * @author abbih
 */
public class Box {
    private static final int MIN_X = 0;
    private static final int MIN_Y = 0;
    private final int maxX;
    private final int maxY;
    private int x = 0;
    private int y = 0;
     
    // Constructor
    Box(int limitX, int limitY)
    {        
        this.maxX = limitX;
        this.maxY = limitY;
    }
    public int getX()
    {
        return x;
    }
    public int getY()
    {
        return y;
    }
    public void push( Vector vector)
    {
        switch(vector.getDirection())
        {
            case "R":
                x += vector.getMagnitude();
                break;
            case "U":
                y += vector.getMagnitude();
                break;
            case "L":
                x += vector.getMagnitude();
                break;
            case "D":
                y += vector.getMagnitude();
                break;                    
        }
        if (x > maxX)
        {
            x = maxX;
        }
        else if (x < MIN_X)
        {
            x = MIN_X;
        }
        if (y > maxY)
        {
            y = maxY;
        }
        else if (y < MIN_Y)
        {
            y = MIN_Y;
        }        
    }
}

