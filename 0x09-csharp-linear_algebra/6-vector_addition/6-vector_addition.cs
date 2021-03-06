﻿using System;

    /// <summary>This is the class object.</summary>
    class VectorMath
    {
        /// <summary>This method sums two vectors, according to the mathematical procedure,
        ///it returns a vector of -1 if the vectors cannot be sum or if they're not 2D or 3D.</summary>
        public static double[] Add(double[] vector1, double[] vector2)
        {
            double[] bad = new double[2];
            if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3
            || vector2.Length < 2 || vector2.Length > 3)
            {
                for (int i = 0; i < 2; i++)
                bad[i] = -1;
            return bad;
            }

            int len;
        if  (vector1.Length == 2)
            len = 2;
        else
            len = 3;
            
        double[] good = new double[len];
        for (int i = 0; i < vector1.Length; i++)
            good[i] = (vector1[i] + vector2[i]);

        return good;
        }
    }
