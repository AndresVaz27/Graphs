using System;
using System.Collections.Generic;

class Graph
{
    private Dictionary<string, List<string>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<string, List<string>>();
    }

    public void AddVertex(string vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new List<string>();
        }
    }

    public void AddEdge(string vertex1, string vertex2)
    {
        if (adjacencyList.ContainsKey(vertex1) && adjacencyList.ContainsKey(vertex2))
        {
            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1); // For an undirected graph
        }
    }

    public void PrintGraph()
    {
        foreach (var vertex in adjacencyList.Keys)
        {
            Console.Write($"{vertex}: ");
            foreach (var neighbor in adjacencyList[vertex])
            {
                Console.Write($"{neighbor} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Graph socialNetwork = new Graph();

        // Adding vertices (people) to the graph
        socialNetwork.AddVertex("Alice");
        socialNetwork.AddVertex("Bob");
        socialNetwork.AddVertex("Charlie");
        socialNetwork.AddVertex("David");

        // Adding edges (relationships) to the graph
        socialNetwork.AddEdge("Alice", "Bob");
        socialNetwork.AddEdge("Bob", "Charlie");
        socialNetwork.AddEdge("Charlie", "David");

        // Printing the graph
        socialNetwork.PrintGraph();
    }
}