using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace binarySearch
{
    public class Node
    {
        public int data { get; set;}
        public Node leftNode { get; set;}
        public Node rightNode { get; set; }

        public Node(int new_data)
        {
            this.data = new_data;
            this.leftNode = null;
            this.rightNode = null;
        }

        public int searchNode(int value, int actualLoop)
        {
            int nbrOfStep = 0;
            Console.Write(this.data + "-->");

            if (value < this.data)
            {
                if (this.rightNode != null)
                {
                    if (this.rightNode.data == value)
                    {
                        nbrOfStep = actualLoop + 1;
                    }

                    else
                    {
                        nbrOfStep = rightNode.searchNode(value, actualLoop + 1);
                    }
                }
            }

            if(value > this.data)
            {
                if (this.leftNode != null)
                {
                    if (this.leftNode.data == value)
                    {
                        nbrOfStep = actualLoop + 1;
                    }

                    else
                    {
                        nbrOfStep = leftNode.searchNode(value, actualLoop + 1);
                    }
                }
            }

            /*

            if(this.leftNode.data == value || this.rightNode.data == value)
            {
                nbrOfStep = actualLoop + 1;
            }
            
            else
            {
                if(value > this.data)
                {
                    nbrOfStep = leftNode.searchNode(value, actualLoop + 1);
                }
                if (value < this.data)
                {
                    nbrOfStep = rightNode.searchNode(value, actualLoop + 1);
                }
            }*/
            return nbrOfStep;
        }

        public void insertNode(Node newNode)
        {
            if(newNode.data > this.data)
            {
                if(leftNode != null)
                {
                    this.leftNode.insertNode(newNode);
                }
                else
                {
                    this.leftNode = newNode;
                }
            }

            if(newNode.data < this.data)
            {
                if (rightNode != null)
                {
                    this.rightNode.insertNode(newNode);
                }
                else
                {
                    this.rightNode = newNode;
                }
            }
        }

        public int count()
        {
            int cnt = 1;
            if(this.leftNode != null)
            {
                cnt += leftNode.count();
            }
            if(this.rightNode != null)
            {
                cnt += rightNode.count();
            }

            return cnt;
        }

        public int getDepth()
        {
            int actualLeftDepth = 1;
            int actualRightDepth = 1;

            if (this.leftNode != null)
            {
                actualLeftDepth += leftNode.getDepth();
            }
            if (this.rightNode != null)
            {
                actualRightDepth += rightNode.getDepth();
            }

            if(actualRightDepth <= actualLeftDepth)
            {
                return actualLeftDepth;
            }

            else
            {
                return actualRightDepth;
            }
        }

        public bool isBalanced(Node n)
        {

            return true;
        }
    }

    public class RootNode
    {
        public RootNode()
        {

        }
        public Node populateTree(int[] numbers)
        {
            Node n = new Node(numbers[0]);

            for (int i = 1; i < numbers.Count(); i++)
            {
                Node x = new Node(numbers[i]);
                n.insertNode(x);
            }
            return n;
        }

    }
}
