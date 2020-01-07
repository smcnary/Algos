using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class BinaryTreeTraversals
	{
		public class TreeNode
		{
			public int val;
			public TreeNode Left;
			public TreeNode Right;

			public TreeNode(int x)
			{
				val = x;
				Left = Right = null;
			}
		}

		public class ListNode
		{
			public int Val;
			public ListNode Next;

			public ListNode(int x)
			{
				Val = x;
			}

		}


		public IList InorderTraversal(TreeNode root)
		{
			var res = new List<int>();
			while (root != null)
			{
				if (root.Left == null)
				{
					res.Add(root.val);
					root = root.Right;
				}
				else
				{
					var pre = root.Left;
					while (pre.Right != null && pre.Right != root)
					{
						pre = pre.Right;
					}

					if (pre.Right == null)
					{
						pre.Right = root;
						root = root.Left;
					}
					else
					{
						pre.Right = null;
						res.Add(root.val);
						root = root.Right;
					}
				}

			}

			return res;
		}

		public IList<int> PreOrderTraversal(TreeNode root)
		{
			var values = new List<int>();
			var mystack = new Stack<BinaryTreeTraversals.TreeNode>();
			if (root != null)
			{
				mystack.Push(root);
			}

			while (mystack.Count > 0)
			{
				var top = mystack.Pop();
				values.Add(top.val);

				if (top.Right != null)
				{
					mystack.Push(top.Right);
				}
				if (top.Left != null)
				{
					mystack.Push(top.Left);
				}
			}

			return values;
		}
	}
}
