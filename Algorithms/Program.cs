﻿using Algorithms.Sorting;
using Algorithms.Dynamic;
using System;
using System.Collections.Generic;
using Algorithms.RecursionAndBacktracking;
using Algorithms.Graph;
using Algorithms.DataStrauctures;
using Algorithms.DataStrauctures.Arrays; 
using Algorithms.Interface;
using Algorithms.DataStrauctures.HashMapAndDictionary;
using Algorithms.StringManipulation;
using Algorithms.Trees;
using Algorithms.WarmUp;
using Algorithms.DataStuctures.LinkedList;

namespace Algorithms
{
    class Program
    {
        public static IAlgorithm algorithm = new CommonLinkedListProblems();
        // Driver Code
        public static void Main(String[] args)
        {
            algorithm.Execute();
        }
    }

}
