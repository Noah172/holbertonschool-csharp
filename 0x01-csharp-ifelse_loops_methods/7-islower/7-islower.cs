﻿using System;


class Character
{
    public static bool IsLower(char c)
    {
        bool ans = false;
        for (char cc = 'a'; cc <= 'z'; cc++)
        {
            if (cc == c)
                ans = true;
        }

        return (ans);
    }
}
