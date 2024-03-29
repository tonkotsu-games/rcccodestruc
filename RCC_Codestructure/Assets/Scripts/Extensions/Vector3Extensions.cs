﻿using UnityEngine;

public static class Vector3Extensions
{
    // With
    public static Vector3 With(this Vector3 original, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? original.x, y ?? original.y, z ?? original.z);
    }

    //Flat (sets y to 0)
    public static Vector3 Flat(this Vector3 original)
    {
        return new Vector3(original.x, 0, original.z);
    }

    //Direction To
    public static Vector3 DirectionTo(this Vector3 source, Vector3 destination)
    {
        return Vector3.Normalize(destination - source);
    }
}