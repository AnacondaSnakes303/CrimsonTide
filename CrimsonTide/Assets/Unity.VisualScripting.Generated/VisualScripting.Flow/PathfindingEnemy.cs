using System.Collections.Generic;
using UnityEngine;



public class Node : MonoBehaviour 
{
    public Vector2Int Position;
    public float GCost;
    public float HCost;
    public Node Parent;

    public float FCost => GCost + HCost;

    public Node(Vector2Int position)
    {
        Position = position;
    }
}

public class AStarPathfinding : MonoBehaviour
{
    public Vector2Int start;
    public Vector2Int target;
    public int gridWidth = 10;
    public int gridHeight = 10;

    private List<Node> openList = new List<Node>();
    private List<Node> closedList = new List<Node>();
    private Node[,] grid;

    private void Start()
    {
        InitializeGrid();
        FindPath(start, target);
    }

    private void InitializeGrid()
    {
        grid = new Node[gridWidth, gridHeight];
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                grid[x, y] = new Node(new Vector2Int(x, y));
            }
        }
    }

    public List<Vector2Int> FindPath(Vector2Int startPos, Vector2Int targetPos)
    {
        Node startNode = grid[startPos.x, startPos.y];
        Node targetNode = grid[targetPos.x, targetPos.y];

        openList.Clear();
        closedList.Clear();
        openList.Add(startNode);

        while (openList.Count > 0)
        {
            Node currentNode = GetNodeWithLowestFCost();
            openList.Remove(currentNode);
            closedList.Add(currentNode);

            if (currentNode.Position == targetNode.Position)
            {
                return RetracePath(startNode, currentNode);
            }

            foreach (Node neighbor in GetNeighbors(currentNode))
            {
                if (closedList.Contains(neighbor)) continue;

                float newGCost = currentNode.GCost + Vector2Int.Distance(currentNode.Position, neighbor.Position);
                if (newGCost < neighbor.GCost || !openList.Contains(neighbor))
                {
                    neighbor.GCost = newGCost;
                    neighbor.HCost = Vector2Int.Distance(neighbor.Position, targetNode.Position);
                    neighbor.Parent = currentNode;

                    if (!openList.Contains(neighbor))
                    {
                        openList.Add(neighbor);
                    }
                }
            }
        }

        return null; // No path found
    }

    private List<Vector2Int> RetracePath(Node startNode, Node endNode)
    {
        List<Vector2Int> path = new List<Vector2Int>();
        Node currentNode = endNode;
        while (currentNode != startNode)
        {
            path.Add(currentNode.Position);
            currentNode = currentNode.Parent;
        }
        path.Reverse();
        return path;
    }

    private List<Node> GetNeighbors(Node node)
    {
        List<Node> neighbors = new List<Node>();
        Vector2Int[] directions = {
            new Vector2Int(1, 0), // Right
            new Vector2Int(-1, 0), // Left
            new Vector2Int(0, 1), // Up
            new Vector2Int(0, -1) // Down
        };

        foreach (Vector2Int dir in directions)
        {
            Vector2Int neighborPos = node.Position + dir;
            if (IsInBounds(neighborPos))
            {
                neighbors.Add(grid[neighborPos.x, neighborPos.y]);
            }
        }

        return neighbors;
    }

    private bool IsInBounds(Vector2Int position)
    {
        return position.x >= 0 && position.x < gridWidth && position.y >= 0 && position.y < gridHeight;
    }

    private Node GetNodeWithLowestFCost()
    {
        Node lowestFCostNode = openList[0];
        foreach (Node node in openList)
        {
            if (node.FCost < lowestFCostNode.FCost || (node.FCost == lowestFCostNode.FCost && node.HCost < lowestFCostNode.HCost))
            {
                lowestFCostNode = node;
            }
        }
        return lowestFCostNode;
    }
}
