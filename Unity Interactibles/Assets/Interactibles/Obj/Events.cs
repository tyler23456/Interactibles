using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace GDA.Interactibles.UserObj
{
    public class Events 
    {
        public Action Start;
        public Action Stay;
        public Action Stop;

        public Events()
        {
            Start = Empty;
            Stay = Empty;
            Stop = Empty;
        }

        void Empty() { }
    }
}