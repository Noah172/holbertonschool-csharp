﻿using System;


/// <summary>This is a base class for shapes.</summary>
class Shape
{
    /// <summary>Calculates the area of a shape.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Class rectangle that inherits from class shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>
    /// Property Width
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (width < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                this.width = value;
            }
        }
    }
    /// <summary>
    /// public property height
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (height < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                this.height = value;
        }
    }
}
