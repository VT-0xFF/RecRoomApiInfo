using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyTitle("KdTreeLib")]
[assembly: AssemblyDescription("Generic multi-dimensional binary search tree")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("codeandcats@gmail.com")]
[assembly: AssemblyProduct("KdTreeLib")]
[assembly: AssemblyCopyright("Copyright © 2016")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("40b103e3-41e5-4a82-b9ba-384af1391862")]
[assembly: AssemblyFileVersion("1.3.0.0")]
[assembly: AssemblyVersion("1.3.0.0")]
internal struct ItemPriority<TItem, TPriority>
{
	public TItem Item;

	public TPriority Priority;
}
namespace KdTree
{
	public struct HyperRect<T>
	{
		private T[] minPoint;

		private T[] maxPoint;

		public T[] MinPoint
		{
			get
			{
				return minPoint;
			}
			set
			{
				minPoint = new T[value.Length];
				value.CopyTo(minPoint, 0);
			}
		}

		public T[] MaxPoint
		{
			get
			{
				return maxPoint;
			}
			set
			{
				maxPoint = new T[value.Length];
				value.CopyTo(maxPoint, 0);
			}
		}

		public static HyperRect<T> Infinite(int dimensions, ITypeMath<T> math)
		{
			HyperRect<T> result = new HyperRect<T>
			{
				MinPoint = new T[dimensions],
				MaxPoint = new T[dimensions]
			};
			for (int i = 0; i < dimensions; i++)
			{
				result.MinPoint[i] = math.NegativeInfinity;
				result.MaxPoint[i] = math.PositiveInfinity;
			}
			return result;
		}

		public T[] GetClosestPoint(T[] toPoint, ITypeMath<T> math)
		{
			T[] array = new T[toPoint.Length];
			for (int i = 0; i < toPoint.Length; i++)
			{
				if (math.Compare(minPoint[i], toPoint[i]) > 0)
				{
					array[i] = minPoint[i];
				}
				else if (math.Compare(maxPoint[i], toPoint[i]) < 0)
				{
					array[i] = maxPoint[i];
				}
				else
				{
					array[i] = toPoint[i];
				}
			}
			return array;
		}

		public HyperRect<T> Clone()
		{
			return new HyperRect<T>
			{
				MinPoint = MinPoint,
				MaxPoint = MaxPoint
			};
		}
	}
	public interface IPriorityQueue<TItem, TPriority>
	{
		int Count { get; }

		void Enqueue(TItem item, TPriority priority);

		TItem Dequeue();
	}
	public interface ITypeMath<T>
	{
		T MinValue { get; }

		T MaxValue { get; }

		T Zero { get; }

		T NegativeInfinity { get; }

		T PositiveInfinity { get; }

		int Compare(T a, T b);

		T Min(T a, T b);

		T Max(T a, T b);

		bool AreEqual(T a, T b);

		bool AreEqual(T[] a, T[] b);

		T Add(T a, T b);

		T Subtract(T a, T b);

		T Multiply(T a, T b);

		T DistanceSquaredBetweenPoints(T[] a, T[] b);
	}
	public interface IKdTree<TKey, TValue> : IEnumerable<KdTreeNode<TKey, TValue>>, IEnumerable
	{
		int Count { get; }

		bool Add(TKey[] point, TValue value);

		bool TryFindValueAt(TKey[] point, out TValue value);

		TValue FindValueAt(TKey[] point);

		bool TryFindValue(TValue value, out TKey[] point);

		TKey[] FindValue(TValue value);

		KdTreeNode<TKey, TValue>[] RadialSearch(TKey[] center, TKey radius, int count);

		void RemoveAt(TKey[] point);

		void Clear();

		KdTreeNode<TKey, TValue>[] GetNearestNeighbours(TKey[] point, int count = int.MaxValue);
	}
	public enum AddDuplicateBehavior
	{
		Skip,
		Error,
		Update,
		Collect
	}
	public class DuplicateNodeError : Exception
	{
		public DuplicateNodeError()
			: base("Cannot Add Node With Duplicate Coordinates")
		{
		}
	}
	[Serializable]
	public class KdTree<TKey, TValue> : IKdTree<TKey, TValue>, IEnumerable<KdTreeNode<TKey, TValue>>, IEnumerable
	{
		private int dimensions;

		private ITypeMath<TKey> typeMath;

		private KdTreeNode<TKey, TValue> root;

		public AddDuplicateBehavior AddDuplicateBehavior { get; private set; }

		public int Count { get; private set; }

		public KdTree(int dimensions, ITypeMath<TKey> typeMath)
		{
			this.dimensions = dimensions;
			this.typeMath = typeMath;
			Count = 0;
		}

		public KdTree(int dimensions, ITypeMath<TKey> typeMath, AddDuplicateBehavior addDuplicateBehavior)
			: this(dimensions, typeMath)
		{
			AddDuplicateBehavior = addDuplicateBehavior;
		}

		public bool Add(TKey[] point, TValue value)
		{
			KdTreeNode<TKey, TValue> value2 = new KdTreeNode<TKey, TValue>(point, value);
			if (root == null)
			{
				root = new KdTreeNode<TKey, TValue>(point, value);
			}
			else
			{
				int num = -1;
				KdTreeNode<TKey, TValue> kdTreeNode = root;
				int compare;
				while (true)
				{
					num = (num + 1) % dimensions;
					if (typeMath.AreEqual(point, kdTreeNode.Point))
					{
						switch (AddDuplicateBehavior)
						{
						case AddDuplicateBehavior.Skip:
							return false;
						case AddDuplicateBehavior.Error:
							throw new DuplicateNodeError();
						case AddDuplicateBehavior.Update:
							break;
						case AddDuplicateBehavior.Collect:
							kdTreeNode.AddDuplicate(value);
							return false;
						default:
							throw new Exception("Unexpected AddDuplicateBehavior");
						}
						kdTreeNode.Value = value;
					}
					compare = typeMath.Compare(point[num], kdTreeNode.Point[num]);
					if (kdTreeNode[compare] == null)
					{
						break;
					}
					kdTreeNode = kdTreeNode[compare];
				}
				kdTreeNode[compare] = value2;
			}
			Count++;
			return true;
		}

		private void ReadChildNodes(KdTreeNode<TKey, TValue> removedNode)
		{
			if (removedNode.IsLeaf)
			{
				return;
			}
			Queue<KdTreeNode<TKey, TValue>> queue = new Queue<KdTreeNode<TKey, TValue>>();
			Queue<KdTreeNode<TKey, TValue>> queue2 = new Queue<KdTreeNode<TKey, TValue>>();
			if (removedNode.LeftChild != null)
			{
				queue2.Enqueue(removedNode.LeftChild);
			}
			if (removedNode.RightChild != null)
			{
				queue2.Enqueue(removedNode.RightChild);
			}
			while (queue2.Count > 0)
			{
				KdTreeNode<TKey, TValue> kdTreeNode = queue2.Dequeue();
				queue.Enqueue(kdTreeNode);
				for (int i = -1; i <= 1; i += 2)
				{
					if (kdTreeNode[i] != null)
					{
						queue2.Enqueue(kdTreeNode[i]);
						kdTreeNode[i] = null;
					}
				}
			}
			while (queue.Count > 0)
			{
				KdTreeNode<TKey, TValue> kdTreeNode2 = queue.Dequeue();
				Count--;
				Add(kdTreeNode2.Point, kdTreeNode2.Value);
			}
		}

		public void RemoveAt(TKey[] point)
		{
			if (root == null)
			{
				return;
			}
			KdTreeNode<TKey, TValue> removedNode;
			if (typeMath.AreEqual(point, root.Point))
			{
				removedNode = root;
				root = null;
				Count--;
				ReadChildNodes(removedNode);
				return;
			}
			removedNode = root;
			int num = -1;
			do
			{
				num = (num + 1) % dimensions;
				int compare = typeMath.Compare(point[num], removedNode.Point[num]);
				if (removedNode[compare] == null)
				{
					break;
				}
				if (typeMath.AreEqual(point, removedNode[compare].Point))
				{
					KdTreeNode<TKey, TValue> removedNode2 = removedNode[compare];
					removedNode[compare] = null;
					Count--;
					ReadChildNodes(removedNode2);
				}
				else
				{
					removedNode = removedNode[compare];
				}
			}
			while (removedNode != null);
		}

		public KdTreeNode<TKey, TValue>[] GetNearestNeighbours(TKey[] point, int count)
		{
			if (count > Count)
			{
				count = Count;
			}
			if (count < 0)
			{
				throw new ArgumentException("Number of neighbors cannot be negative");
			}
			if (count == 0)
			{
				return new KdTreeNode<TKey, TValue>[0];
			}
			_ = new KdTreeNode<TKey, TValue>[count];
			NearestNeighbourList<KdTreeNode<TKey, TValue>, TKey> nearestNeighbourList = new NearestNeighbourList<KdTreeNode<TKey, TValue>, TKey>(count, typeMath);
			HyperRect<TKey> rect = HyperRect<TKey>.Infinite(dimensions, typeMath);
			AddNearestNeighbours(root, point, rect, 0, nearestNeighbourList, typeMath.MaxValue);
			count = nearestNeighbourList.Count;
			KdTreeNode<TKey, TValue>[] array = new KdTreeNode<TKey, TValue>[count];
			for (int i = 0; i < count; i++)
			{
				array[count - i - 1] = nearestNeighbourList.RemoveFurtherest();
			}
			return array;
		}

		private void AddNearestNeighbours(KdTreeNode<TKey, TValue> node, TKey[] target, HyperRect<TKey> rect, int depth, NearestNeighbourList<KdTreeNode<TKey, TValue>, TKey> nearestNeighbours, TKey maxSearchRadiusSquared)
		{
			if (node == null)
			{
				return;
			}
			int num = depth % dimensions;
			HyperRect<TKey> hyperRect = rect.Clone();
			hyperRect.MaxPoint[num] = node.Point[num];
			HyperRect<TKey> hyperRect2 = rect.Clone();
			hyperRect2.MinPoint[num] = node.Point[num];
			int num2 = typeMath.Compare(target[num], node.Point[num]);
			HyperRect<TKey> rect2 = ((num2 <= 0) ? hyperRect : hyperRect2);
			HyperRect<TKey> rect3 = ((num2 <= 0) ? hyperRect2 : hyperRect);
			KdTreeNode<TKey, TValue> kdTreeNode = ((num2 <= 0) ? node.LeftChild : node.RightChild);
			KdTreeNode<TKey, TValue> node2 = ((num2 <= 0) ? node.RightChild : node.LeftChild);
			if (kdTreeNode != null)
			{
				AddNearestNeighbours(kdTreeNode, target, rect2, depth + 1, nearestNeighbours, maxSearchRadiusSquared);
			}
			TKey[] closestPoint = rect3.GetClosestPoint(target, typeMath);
			TKey a = typeMath.DistanceSquaredBetweenPoints(closestPoint, target);
			if (typeMath.Compare(a, maxSearchRadiusSquared) <= 0)
			{
				if (nearestNeighbours.IsCapacityReached)
				{
					if (typeMath.Compare(a, nearestNeighbours.GetFurtherestDistance()) < 0)
					{
						AddNearestNeighbours(node2, target, rect3, depth + 1, nearestNeighbours, maxSearchRadiusSquared);
					}
				}
				else
				{
					AddNearestNeighbours(node2, target, rect3, depth + 1, nearestNeighbours, maxSearchRadiusSquared);
				}
			}
			a = typeMath.DistanceSquaredBetweenPoints(node.Point, target);
			if (typeMath.Compare(a, maxSearchRadiusSquared) <= 0)
			{
				nearestNeighbours.Add(node, a);
			}
		}

		public KdTreeNode<TKey, TValue>[] RadialSearch(TKey[] center, TKey radius, int count)
		{
			NearestNeighbourList<KdTreeNode<TKey, TValue>, TKey> nearestNeighbourList = new NearestNeighbourList<KdTreeNode<TKey, TValue>, TKey>(count, typeMath);
			AddNearestNeighbours(root, center, HyperRect<TKey>.Infinite(dimensions, typeMath), 0, nearestNeighbourList, typeMath.Multiply(radius, radius));
			count = nearestNeighbourList.Count;
			KdTreeNode<TKey, TValue>[] array = new KdTreeNode<TKey, TValue>[count];
			for (int i = 0; i < count; i++)
			{
				array[count - i - 1] = nearestNeighbourList.RemoveFurtherest();
			}
			return array;
		}

		public bool TryFindValueAt(TKey[] point, out TValue value)
		{
			KdTreeNode<TKey, TValue> kdTreeNode = root;
			int num = -1;
			while (true)
			{
				if (kdTreeNode == null)
				{
					value = default(TValue);
					return false;
				}
				if (typeMath.AreEqual(point, kdTreeNode.Point))
				{
					break;
				}
				num = (num + 1) % dimensions;
				int compare = typeMath.Compare(point[num], kdTreeNode.Point[num]);
				kdTreeNode = kdTreeNode[compare];
			}
			value = kdTreeNode.Value;
			return true;
		}

		public TValue FindValueAt(TKey[] point)
		{
			if (TryFindValueAt(point, out var value))
			{
				return value;
			}
			return default(TValue);
		}

		public bool TryFindValue(TValue value, out TKey[] point)
		{
			if (root == null)
			{
				point = null;
				return false;
			}
			Queue<KdTreeNode<TKey, TValue>> queue = new Queue<KdTreeNode<TKey, TValue>>();
			queue.Enqueue(root);
			while (queue.Count > 0)
			{
				KdTreeNode<TKey, TValue> kdTreeNode = queue.Dequeue();
				ref TValue value2 = ref kdTreeNode.Value;
				object obj = value;
				if (value2.Equals(obj))
				{
					point = kdTreeNode.Point;
					return true;
				}
				for (int i = -1; i <= 1; i += 2)
				{
					KdTreeNode<TKey, TValue> kdTreeNode2 = kdTreeNode[i];
					if (kdTreeNode2 != null)
					{
						queue.Enqueue(kdTreeNode2);
					}
				}
			}
			point = null;
			return false;
		}

		public TKey[] FindValue(TValue value)
		{
			if (TryFindValue(value, out var point))
			{
				return point;
			}
			return null;
		}

		private void AddNodeToStringBuilder(KdTreeNode<TKey, TValue> node, StringBuilder sb, int depth)
		{
			sb.AppendLine(node.ToString());
			for (int i = -1; i <= 1; i += 2)
			{
				for (int j = 0; j <= depth; j++)
				{
					sb.Append("\t");
				}
				sb.Append((i == -1) ? "L " : "R ");
				if (node[i] == null)
				{
					sb.AppendLine("");
				}
				else
				{
					AddNodeToStringBuilder(node[i], sb, depth + 1);
				}
			}
		}

		public override string ToString()
		{
			if (root == null)
			{
				return "";
			}
			StringBuilder stringBuilder = new StringBuilder();
			AddNodeToStringBuilder(root, stringBuilder, 0);
			return stringBuilder.ToString();
		}

		private void AddNodesToList(KdTreeNode<TKey, TValue> node, List<KdTreeNode<TKey, TValue>> nodes)
		{
			if (node == null)
			{
				return;
			}
			nodes.Add(node);
			for (int i = -1; i <= 1; i += 2)
			{
				if (node[i] != null)
				{
					AddNodesToList(node[i], nodes);
					node[i] = null;
				}
			}
		}

		private void SortNodesArray(KdTreeNode<TKey, TValue>[] nodes, int byDimension, int fromIndex, int toIndex)
		{
			for (int i = fromIndex + 1; i <= toIndex; i++)
			{
				int num = i;
				while (true)
				{
					KdTreeNode<TKey, TValue> kdTreeNode = nodes[num - 1];
					KdTreeNode<TKey, TValue> kdTreeNode2 = nodes[num];
					if (typeMath.Compare(kdTreeNode2.Point[byDimension], kdTreeNode.Point[byDimension]) >= 0)
					{
						break;
					}
					nodes[num - 1] = kdTreeNode2;
					nodes[num] = kdTreeNode;
				}
			}
		}

		private void AddNodesBalanced(KdTreeNode<TKey, TValue>[] nodes, int byDimension, int fromIndex, int toIndex)
		{
			if (fromIndex == toIndex)
			{
				Add(nodes[fromIndex].Point, nodes[fromIndex].Value);
				nodes[fromIndex] = null;
				return;
			}
			SortNodesArray(nodes, byDimension, fromIndex, toIndex);
			int num = fromIndex + (int)System.Math.Round((float)(toIndex + 1 - fromIndex) / 2f) - 1;
			Add(nodes[num].Point, nodes[num].Value);
			nodes[num] = null;
			int byDimension2 = (byDimension + 1) % dimensions;
			if (fromIndex < num)
			{
				AddNodesBalanced(nodes, byDimension2, fromIndex, num - 1);
			}
			if (toIndex > num)
			{
				AddNodesBalanced(nodes, byDimension2, num + 1, toIndex);
			}
		}

		public void Balance()
		{
			List<KdTreeNode<TKey, TValue>> list = new List<KdTreeNode<TKey, TValue>>();
			AddNodesToList(root, list);
			Clear();
			AddNodesBalanced(list.ToArray(), 0, 0, list.Count - 1);
		}

		private void RemoveChildNodes(KdTreeNode<TKey, TValue> node)
		{
			for (int i = -1; i <= 1; i += 2)
			{
				if (node[i] != null)
				{
					RemoveChildNodes(node[i]);
					node[i] = null;
				}
			}
		}

		public void Clear()
		{
			if (root != null)
			{
				RemoveChildNodes(root);
			}
		}

		public void SaveToFile(string filename)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			using FileStream fileStream = File.Create(filename);
			binaryFormatter.Serialize(fileStream, this);
			fileStream.Flush();
		}

		public static KdTree<TKey, TValue> LoadFromFile(string filename)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			using FileStream serializationStream = File.Open(filename, FileMode.Open);
			return (KdTree<TKey, TValue>)binaryFormatter.Deserialize(serializationStream);
		}

		public IEnumerator<KdTreeNode<TKey, TValue>> GetEnumerator()
		{
			Stack<KdTreeNode<TKey, TValue>> left = new Stack<KdTreeNode<TKey, TValue>>();
			Stack<KdTreeNode<TKey, TValue>> right = new Stack<KdTreeNode<TKey, TValue>>();
			Action<KdTreeNode<TKey, TValue>> addLeft = delegate(KdTreeNode<TKey, TValue> node)
			{
				if (node.LeftChild != null)
				{
					left.Push(node.LeftChild);
				}
			};
			Action<KdTreeNode<TKey, TValue>> addRight = delegate(KdTreeNode<TKey, TValue> node)
			{
				if (node.RightChild != null)
				{
					right.Push(node.RightChild);
				}
			};
			if (root == null)
			{
				yield break;
			}
			yield return root;
			addLeft(root);
			addRight(root);
			while (true)
			{
				if (left.Any())
				{
					KdTreeNode<TKey, TValue> kdTreeNode = left.Pop();
					addLeft(kdTreeNode);
					addRight(kdTreeNode);
					yield return kdTreeNode;
					continue;
				}
				if (right.Any())
				{
					KdTreeNode<TKey, TValue> kdTreeNode2 = right.Pop();
					addLeft(kdTreeNode2);
					addRight(kdTreeNode2);
					yield return kdTreeNode2;
					continue;
				}
				break;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	[Serializable]
	public class KdTreeNode<TKey, TValue>
	{
		public TKey[] Point;

		public TValue Value;

		public List<TValue> Duplicates;

		internal KdTreeNode<TKey, TValue> LeftChild;

		internal KdTreeNode<TKey, TValue> RightChild;

		internal KdTreeNode<TKey, TValue> this[int compare]
		{
			get
			{
				if (compare <= 0)
				{
					return LeftChild;
				}
				return RightChild;
			}
			set
			{
				if (compare <= 0)
				{
					LeftChild = value;
				}
				else
				{
					RightChild = value;
				}
			}
		}

		public bool IsLeaf
		{
			get
			{
				if (LeftChild == null)
				{
					return RightChild == null;
				}
				return false;
			}
		}

		public KdTreeNode()
		{
		}

		public KdTreeNode(TKey[] point, TValue value)
		{
			Point = point;
			Value = value;
		}

		public void AddDuplicate(TValue value)
		{
			if (Duplicates == null)
			{
				Duplicates = new List<TValue> { value };
			}
			else
			{
				Duplicates.Add(value);
			}
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < Point.Length; i++)
			{
				stringBuilder.Append(Point[i].ToString());
			}
			if (Value == null)
			{
				stringBuilder.Append("null");
			}
			else
			{
				stringBuilder.Append(Value.ToString());
			}
			return stringBuilder.ToString();
		}
	}
	public interface INearestNeighbourList<TItem, TDistance>
	{
		int MaxCapacity { get; }

		int Count { get; }

		bool Add(TItem item, TDistance distance);

		TItem GetFurtherest();

		TItem RemoveFurtherest();
	}
	public class NearestNeighbourList<TItem, TDistance> : INearestNeighbourList<TItem, TDistance>
	{
		private PriorityQueue<TItem, TDistance> queue;

		private ITypeMath<TDistance> distanceMath;

		private int maxCapacity;

		public int MaxCapacity => maxCapacity;

		public int Count => queue.Count;

		public bool IsCapacityReached => Count == MaxCapacity;

		public NearestNeighbourList(int maxCapacity, ITypeMath<TDistance> distanceMath)
		{
			this.maxCapacity = maxCapacity;
			this.distanceMath = distanceMath;
			queue = new PriorityQueue<TItem, TDistance>(maxCapacity, distanceMath);
		}

		public bool Add(TItem item, TDistance distance)
		{
			if (queue.Count >= maxCapacity)
			{
				if (distanceMath.Compare(distance, queue.GetHighestPriority()) < 0)
				{
					queue.Dequeue();
					queue.Enqueue(item, distance);
					return true;
				}
				return false;
			}
			queue.Enqueue(item, distance);
			return true;
		}

		public TItem GetFurtherest()
		{
			if (Count == 0)
			{
				throw new Exception("List is empty");
			}
			return queue.GetHighest();
		}

		public TDistance GetFurtherestDistance()
		{
			if (Count == 0)
			{
				throw new Exception("List is empty");
			}
			return queue.GetHighestPriority();
		}

		public TItem RemoveFurtherest()
		{
			return queue.Dequeue();
		}
	}
	public class PriorityQueue<TItem, TPriority> : IPriorityQueue<TItem, TPriority>
	{
		private ITypeMath<TPriority> priorityMath;

		private ItemPriority<TItem, TPriority>[] queue;

		private int capacity;

		private int count;

		public int Count => count;

		public PriorityQueue(int capacity, ITypeMath<TPriority> priorityMath)
		{
			if (capacity <= 0)
			{
				throw new ArgumentException("Capacity must be greater than zero");
			}
			this.capacity = capacity;
			queue = new ItemPriority<TItem, TPriority>[capacity];
			this.priorityMath = priorityMath;
		}

		private void ExpandCapacity()
		{
			capacity *= 2;
			ItemPriority<TItem, TPriority>[] destinationArray = new ItemPriority<TItem, TPriority>[capacity];
			Array.Copy(queue, destinationArray, queue.Length);
			queue = destinationArray;
		}

		public void Enqueue(TItem item, TPriority priority)
		{
			if (++count > capacity)
			{
				ExpandCapacity();
			}
			int num = count - 1;
			queue[num] = new ItemPriority<TItem, TPriority>
			{
				Item = item,
				Priority = priority
			};
			ReorderItem(num, -1);
		}

		public TItem Dequeue()
		{
			TItem item = queue[0].Item;
			queue[0].Item = default(TItem);
			queue[0].Priority = priorityMath.MinValue;
			ReorderItem(0, 1);
			count--;
			return item;
		}

		private void ReorderItem(int index, int direction)
		{
			if (direction != -1 && direction != 1)
			{
				throw new ArgumentException("Invalid Direction");
			}
			ItemPriority<TItem, TPriority> itemPriority = queue[index];
			for (int i = index + direction; i >= 0 && i < count; i += direction)
			{
				ItemPriority<TItem, TPriority> itemPriority2 = queue[i];
				int num = priorityMath.Compare(itemPriority.Priority, itemPriority2.Priority);
				if ((direction == -1 && num > 0) || (direction == 1 && num < 0))
				{
					queue[index] = itemPriority2;
					queue[i] = itemPriority;
					index += direction;
					continue;
				}
				break;
			}
		}

		public TItem GetHighest()
		{
			if (count == 0)
			{
				throw new Exception("Queue is empty");
			}
			return queue[0].Item;
		}

		public TPriority GetHighestPriority()
		{
			if (count == 0)
			{
				throw new Exception("Queue is empty");
			}
			return queue[0].Priority;
		}
	}
}
namespace KdTree.Math
{
	[Serializable]
	public class DoubleMath : TypeMath<double>
	{
		public override double MinValue => double.MinValue;

		public override double MaxValue => double.MaxValue;

		public override double Zero => 0.0;

		public override double NegativeInfinity => double.NegativeInfinity;

		public override double PositiveInfinity => double.PositiveInfinity;

		public override int Compare(double a, double b)
		{
			return a.CompareTo(b);
		}

		public override bool AreEqual(double a, double b)
		{
			return a == b;
		}

		public override double Add(double a, double b)
		{
			return a + b;
		}

		public override double Subtract(double a, double b)
		{
			return a - b;
		}

		public override double Multiply(double a, double b)
		{
			return a * b;
		}

		public override double DistanceSquaredBetweenPoints(double[] a, double[] b)
		{
			double num = Zero;
			int num2 = a.Length;
			for (int i = 0; i < num2; i++)
			{
				double num3 = Subtract(a[i], b[i]);
				double b2 = Multiply(num3, num3);
				num = Add(num, b2);
			}
			return num;
		}
	}
	[Serializable]
	public class FloatMath : TypeMath<float>
	{
		public override float MinValue => float.MinValue;

		public override float MaxValue => float.MaxValue;

		public override float Zero => 0f;

		public override float NegativeInfinity => float.NegativeInfinity;

		public override float PositiveInfinity => float.PositiveInfinity;

		public override int Compare(float a, float b)
		{
			return a.CompareTo(b);
		}

		public override bool AreEqual(float a, float b)
		{
			return a == b;
		}

		public override float Add(float a, float b)
		{
			return a + b;
		}

		public override float Subtract(float a, float b)
		{
			return a - b;
		}

		public override float Multiply(float a, float b)
		{
			return a * b;
		}

		public override float DistanceSquaredBetweenPoints(float[] a, float[] b)
		{
			float num = Zero;
			int num2 = a.Length;
			for (int i = 0; i < num2; i++)
			{
				float num3 = Subtract(a[i], b[i]);
				float b2 = Multiply(num3, num3);
				num = Add(num, b2);
			}
			return num;
		}
	}
	[Serializable]
	public abstract class TypeMath<T> : ITypeMath<T>
	{
		public abstract T MinValue { get; }

		public abstract T MaxValue { get; }

		public abstract T Zero { get; }

		public abstract T NegativeInfinity { get; }

		public abstract T PositiveInfinity { get; }

		public abstract int Compare(T a, T b);

		public abstract bool AreEqual(T a, T b);

		public virtual bool AreEqual(T[] a, T[] b)
		{
			if (a.Length != b.Length)
			{
				return false;
			}
			for (int i = 0; i < a.Length; i++)
			{
				if (!AreEqual(a[i], b[i]))
				{
					return false;
				}
			}
			return true;
		}

		public T Min(T a, T b)
		{
			if (Compare(a, b) < 0)
			{
				return a;
			}
			return b;
		}

		public T Max(T a, T b)
		{
			if (Compare(a, b) > 0)
			{
				return a;
			}
			return b;
		}

		public abstract T Add(T a, T b);

		public abstract T Subtract(T a, T b);

		public abstract T Multiply(T a, T b);

		public abstract T DistanceSquaredBetweenPoints(T[] a, T[] b);
	}
}
