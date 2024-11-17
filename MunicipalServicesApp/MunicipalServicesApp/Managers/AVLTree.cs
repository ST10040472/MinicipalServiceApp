// AVL Tree Node
using MunicipalServicesApp.Models;
using System.Collections.Generic;
using System;

public class AVLTreeNode
{
    public ServiceRequest Data { get; set; }
    public AVLTreeNode Left { get; set; }
    public AVLTreeNode Right { get; set; }
    public int Height { get; set; }

    public AVLTreeNode(ServiceRequest data)
    {
        Data = data;
        Left = Right = null;
        Height = 1;
    }
}

// AVL Tree for managing service requests
public class AVLTree
{
    private AVLTreeNode root;

    public AVLTree()
    {
        root = null;
    }

    // Insert a new service request
    public void Insert(ServiceRequest serviceRequest)
    {
        root = InsertNode(root, serviceRequest);
    }

    private AVLTreeNode InsertNode(AVLTreeNode node, ServiceRequest serviceRequest)
    {
        // 1. Perform the normal BST insert
        if (node == null)
            return new AVLTreeNode(serviceRequest);

        if (serviceRequest.RequestID < node.Data.RequestID)
            node.Left = InsertNode(node.Left, serviceRequest);
        else if (serviceRequest.RequestID > node.Data.RequestID)
            node.Right = InsertNode(node.Right, serviceRequest);
        else
            return node; // Duplicates are not allowed

        // 2. Update height of this ancestor node
        node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;

        // 3. Get the balance factor
        int balance = GetBalance(node);

        // 4. Balance the node
        if (balance > 1 && serviceRequest.RequestID < node.Left.Data.RequestID)
            return RightRotate(node);

        if (balance < -1 && serviceRequest.RequestID > node.Right.Data.RequestID)
            return LeftRotate(node);

        if (balance > 1 && serviceRequest.RequestID > node.Left.Data.RequestID)
        {
            node.Left = LeftRotate(node.Left);
            return RightRotate(node);
        }

        if (balance < -1 && serviceRequest.RequestID < node.Right.Data.RequestID)
        {
            node.Right = RightRotate(node.Right);
            return LeftRotate(node);
        }

        return node;
    }

    private int GetHeight(AVLTreeNode node)
    {
        return node == null ? 0 : node.Height;
    }

    private int GetBalance(AVLTreeNode node)
    {
        return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
    }

    private AVLTreeNode LeftRotate(AVLTreeNode x)
    {
        AVLTreeNode y = x.Right;
        AVLTreeNode T2 = y.Left;

        y.Left = x;
        x.Right = T2;

        x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
        y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

        return y;
    }

    private AVLTreeNode RightRotate(AVLTreeNode y)
    {
        AVLTreeNode x = y.Left;
        AVLTreeNode T2 = x.Right;

        x.Right = y;
        y.Left = T2;

        y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
        x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

        return x;
    }

    // Inorder traversal to get the sorted list of service requests
    public List<ServiceRequest> InOrderTraversal()
    {
        List<ServiceRequest> result = new List<ServiceRequest>();
        InOrderTraversalHelper(root, result);
        return result;
    }

    private void InOrderTraversalHelper(AVLTreeNode node, List<ServiceRequest> result)
    {
        if (node != null)
        {
            InOrderTraversalHelper(node.Left, result);
            result.Add(node.Data);
            InOrderTraversalHelper(node.Right, result);
        }
    }
}
