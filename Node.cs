﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_assignment
{
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node(object data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.Write(Data);
        }
    }
}
