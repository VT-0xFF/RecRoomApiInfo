using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyConfiguration("")]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyProduct("KDTree")]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue | DebuggableAttribute.DebuggingModes.DisableOptimizations)]
[assembly: AssemblyTitle("KDTree")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyCopyright("Copyright ©  2013")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("b1f6e08e-691d-42c0-9eea-7e9de37deb76")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyVersion("1.0.0.0")]
namespace KDTree;

public interface DistanceFunctions
{
	double Distance(double[] p1, double[] p2);

	double DistanceToRectangle(double[] point, double[] min, double[] max);
}
public class SquareEuclideanDistanceFunction : DistanceFunctions
{
	public double Distance(double[] p1, double[] p2)
	{
		double num = 0.0;
		for (int i = 0; i < p1.Length; i++)
		{
			double num2 = p1[i] - p2[i];
			num += num2 * num2;
		}
		return num;
	}

	public double DistanceToRectangle(double[] point, double[] min, double[] max)
	{
		double num = 0.0;
		double num2 = 0.0;
		for (int i = 0; i < point.Length; i++)
		{
			num2 = 0.0;
			if (point[i] > max[i])
			{
				num2 = point[i] - max[i];
			}
			else if (point[i] < min[i])
			{
				num2 = point[i] - min[i];
			}
			num += num2 * num2;
		}
		return num;
	}
}
public class IntervalHeap<T>
{
	private const int DEFAULT_SIZE = 64;

	private T[] tData;

	private double[] tKeys;

	public int Size { get; private set; }

	public int Capacity { get; private set; }

	public T Min
	{
		get
		{
			if (Size == 0)
			{
				throw new Exception();
			}
			return tData[0];
		}
	}

	public T Max
	{
		get
		{
			if (Size == 0)
			{
				throw new Exception();
			}
			if (Size == 1)
			{
				return tData[0];
			}
			return tData[1];
		}
	}

	public double MinKey
	{
		get
		{
			if (Size == 0)
			{
				throw new Exception();
			}
			return tKeys[0];
		}
	}

	public double MaxKey
	{
		get
		{
			if (Size == 0)
			{
				throw new Exception();
			}
			if (Size == 1)
			{
				return tKeys[0];
			}
			return tKeys[1];
		}
	}

	public IntervalHeap()
		: this(64)
	{
	}

	public IntervalHeap(int capacity)
	{
		tData = new T[capacity];
		tKeys = new double[capacity];
		Capacity = capacity;
		Size = 0;
	}

	public void Insert(double key, T value)
	{
		if (Size >= Capacity)
		{
			Capacity *= 2;
			T[] destinationArray = new T[Capacity];
			Array.Copy(tData, destinationArray, tData.Length);
			tData = destinationArray;
			double[] destinationArray2 = new double[Capacity];
			Array.Copy(tKeys, destinationArray2, tKeys.Length);
			tKeys = destinationArray2;
		}
		Size++;
		tData[Size - 1] = value;
		tKeys[Size - 1] = key;
		SiftInsertedValueUp();
	}

	public void RemoveMin()
	{
		if (Size == 0)
		{
			throw new Exception();
		}
		Size--;
		tData[0] = tData[Size];
		tKeys[0] = tKeys[Size];
		tData[Size] = default(T);
		SiftDownMin(0);
	}

	public void ReplaceMin(double key, T value)
	{
		if (Size == 0)
		{
			throw new Exception();
		}
		tData[0] = value;
		tKeys[0] = key;
		if (Size > 1)
		{
			if (tKeys[1] < key)
			{
				Swap(0, 1);
			}
			SiftDownMin(0);
		}
	}

	public void RemoveMax()
	{
		if (Size == 0)
		{
			throw new Exception();
		}
		if (Size == 1)
		{
			RemoveMin();
			return;
		}
		Size--;
		tData[1] = tData[Size];
		tKeys[1] = tKeys[Size];
		tData[Size] = default(T);
		SiftDownMax(1);
	}

	public void ReplaceMax(double key, T value)
	{
		if (Size == 0)
		{
			throw new Exception();
		}
		if (Size == 1)
		{
			ReplaceMin(key, value);
			return;
		}
		tData[1] = value;
		tKeys[1] = key;
		if (key < tKeys[0])
		{
			Swap(0, 1);
		}
		SiftDownMax(1);
	}

	private int Swap(int x, int y)
	{
		T val = tData[y];
		double num = tKeys[y];
		tData[y] = tData[x];
		tKeys[y] = tKeys[x];
		tData[x] = val;
		tKeys[x] = num;
		return y;
	}

	private void SiftInsertedValueUp()
	{
		int num = Size - 1;
		switch (num)
		{
		case 0:
			return;
		case 1:
			if (tKeys[num] < tKeys[num - 1])
			{
				Swap(num, num - 1);
			}
			return;
		}
		if (num % 2 == 1)
		{
			int num2 = (num / 2 - 1) | 1;
			if (tKeys[num] < tKeys[num - 1])
			{
				num = Swap(num, num - 1);
				if (tKeys[num] < tKeys[num2 - 1])
				{
					num = Swap(num, num2 - 1);
					SiftUpMin(num);
				}
			}
			else if (tKeys[num] > tKeys[num2])
			{
				num = Swap(num, num2);
				SiftUpMax(num);
			}
		}
		else
		{
			int num2 = (num / 2 - 1) | 1;
			if (tKeys[num] > tKeys[num2])
			{
				num = Swap(num, num2);
				SiftUpMax(num);
			}
			else if (tKeys[num] < tKeys[num2 - 1])
			{
				num = Swap(num, num2 - 1);
				SiftUpMin(num);
			}
		}
	}

	private void SiftUpMin(int iChild)
	{
		int num = (iChild / 2 - 1) & -2;
		while (num >= 0 && tKeys[iChild] < tKeys[num])
		{
			Swap(iChild, num);
			iChild = num;
			num = (iChild / 2 - 1) & -2;
		}
	}

	private void SiftUpMax(int iChild)
	{
		int num = (iChild / 2 - 1) | 1;
		while (num >= 0 && tKeys[iChild] > tKeys[num])
		{
			Swap(iChild, num);
			iChild = num;
			num = (iChild / 2 - 1) | 1;
		}
	}

	private void SiftDownMin(int iParent)
	{
		int num = iParent * 2 + 2;
		while (num < Size)
		{
			if (num + 2 < Size && tKeys[num + 2] < tKeys[num])
			{
				num += 2;
			}
			if (tKeys[num] < tKeys[iParent])
			{
				Swap(iParent, num);
				if (num + 1 < Size && tKeys[num + 1] < tKeys[num])
				{
					Swap(num, num + 1);
				}
				iParent = num;
				num = iParent * 2 + 2;
				continue;
			}
			break;
		}
	}

	private void SiftDownMax(int iParent)
	{
		int num = iParent * 2 + 1;
		while (num <= Size)
		{
			if (num == Size)
			{
				if (tKeys[num - 1] > tKeys[iParent])
				{
					Swap(iParent, num - 1);
				}
				break;
			}
			if (num + 2 == Size)
			{
				if (tKeys[num + 1] > tKeys[num])
				{
					if (tKeys[num + 1] > tKeys[iParent])
					{
						Swap(iParent, num + 1);
					}
					break;
				}
			}
			else if (num + 2 < Size && tKeys[num + 2] > tKeys[num])
			{
				num += 2;
			}
			if (tKeys[num] > tKeys[iParent])
			{
				Swap(iParent, num);
				if (tKeys[num - 1] > tKeys[num])
				{
					Swap(num, num - 1);
				}
				iParent = num;
				num = iParent * 2 + 1;
				continue;
			}
			break;
		}
	}
}
public class KDNode<T>
{
	protected internal int iDimensions;

	protected internal int iBucketCapacity;

	protected internal double[][] tPoints;

	protected internal T[] tData;

	protected internal KDNode<T> pLeft;

	protected internal KDNode<T> pRight;

	protected internal int iSplitDimension;

	protected internal double fSplitValue;

	protected internal double[] tMinBound;

	protected internal double[] tMaxBound;

	protected internal bool bSinglePoint;

	public int Size { get; private set; }

	public bool IsLeaf => tPoints != null;

	protected KDNode(int iDimensions, int iBucketCapacity)
	{
		this.iDimensions = iDimensions;
		this.iBucketCapacity = iBucketCapacity;
		Size = 0;
		bSinglePoint = true;
		tPoints = new double[iBucketCapacity + 1][];
		tData = new T[iBucketCapacity + 1];
	}

	public void AddPoint(double[] tPoint, T kValue)
	{
		KDNode<T> kDNode = this;
		while (!kDNode.IsLeaf)
		{
			kDNode.ExtendBounds(tPoint);
			kDNode.Size++;
			kDNode = ((!(tPoint[kDNode.iSplitDimension] > kDNode.fSplitValue)) ? kDNode.pLeft : kDNode.pRight);
		}
		kDNode.AddLeafPoint(tPoint, kValue);
	}

	private void AddLeafPoint(double[] tPoint, T kValue)
	{
		tPoints[Size] = tPoint;
		tData[Size] = kValue;
		ExtendBounds(tPoint);
		Size++;
		if (Size == tPoints.Length - 1)
		{
			if (CalculateSplit())
			{
				SplitLeafNode();
			}
			else
			{
				IncreaseLeafCapacity();
			}
		}
	}

	private bool CheckBounds(double[] tPoint)
	{
		for (int i = 0; i < iDimensions; i++)
		{
			if (tPoint[i] > tMaxBound[i])
			{
				return false;
			}
			if (tPoint[i] < tMinBound[i])
			{
				return false;
			}
		}
		return true;
	}

	private void ExtendBounds(double[] tPoint)
	{
		if (tMinBound == null)
		{
			tMinBound = new double[iDimensions];
			tMaxBound = new double[iDimensions];
			Array.Copy(tPoint, tMinBound, iDimensions);
			Array.Copy(tPoint, tMaxBound, iDimensions);
			return;
		}
		for (int i = 0; i < iDimensions; i++)
		{
			if (double.IsNaN(tPoint[i]))
			{
				if (!double.IsNaN(tMinBound[i]) || !double.IsNaN(tMaxBound[i]))
				{
					bSinglePoint = false;
				}
				tMinBound[i] = double.NaN;
				tMaxBound[i] = double.NaN;
			}
			else if (tMinBound[i] > tPoint[i])
			{
				tMinBound[i] = tPoint[i];
				bSinglePoint = false;
			}
			else if (tMaxBound[i] < tPoint[i])
			{
				tMaxBound[i] = tPoint[i];
				bSinglePoint = false;
			}
		}
	}

	private void IncreaseLeafCapacity()
	{
		Array.Resize(ref tPoints, tPoints.Length * 2);
		Array.Resize(ref tData, tData.Length * 2);
	}

	private bool CalculateSplit()
	{
		if (bSinglePoint)
		{
			return false;
		}
		double num = 0.0;
		for (int i = 0; i < iDimensions; i++)
		{
			double num2 = tMaxBound[i] - tMinBound[i];
			if (double.IsNaN(num2))
			{
				num2 = 0.0;
			}
			if (num2 > num)
			{
				iSplitDimension = i;
				num = num2;
			}
		}
		if (num == 0.0)
		{
			return false;
		}
		fSplitValue = (tMinBound[iSplitDimension] + tMaxBound[iSplitDimension]) * 0.5;
		if (fSplitValue == double.PositiveInfinity)
		{
			fSplitValue = double.MaxValue;
		}
		else if (fSplitValue == double.NegativeInfinity)
		{
			fSplitValue = double.MinValue;
		}
		if (fSplitValue == tMaxBound[iSplitDimension])
		{
			fSplitValue = tMinBound[iSplitDimension];
		}
		return true;
	}

	private void SplitLeafNode()
	{
		pRight = new KDNode<T>(iDimensions, iBucketCapacity);
		pLeft = new KDNode<T>(iDimensions, iBucketCapacity);
		for (int i = 0; i < Size; i++)
		{
			double[] array = tPoints[i];
			T kValue = tData[i];
			if (array[iSplitDimension] > fSplitValue)
			{
				pRight.AddLeafPoint(array, kValue);
			}
			else
			{
				pLeft.AddLeafPoint(array, kValue);
			}
		}
		tPoints = null;
		tData = null;
	}
}
public class KDTree<T> : KDNode<T>
{
	public KDTree(int iDimensions)
		: base(iDimensions, 24)
	{
	}

	public KDTree(int iDimensions, int iBucketCapacity)
		: base(iDimensions, iBucketCapacity)
	{
	}

	public NearestNeighbour<T> NearestNeighbors(double[] tSearchPoint, int iMaxReturned, double fDistance = -1.0)
	{
		DistanceFunctions kDistanceFunction = new SquareEuclideanDistanceFunction();
		return NearestNeighbors(tSearchPoint, kDistanceFunction, iMaxReturned, fDistance);
	}

	public NearestNeighbour<T> NearestNeighbors(double[] tSearchPoint, DistanceFunctions kDistanceFunction, int iMaxReturned, double fDistance)
	{
		return new NearestNeighbour<T>(this, tSearchPoint, kDistanceFunction, iMaxReturned, fDistance);
	}
}
public class MinHeap<T>
{
	private static int DEFAULT_SIZE = 64;

	private T[] tData;

	private double[] tKeys;

	public int Size { get; private set; }

	public int Capacity { get; private set; }

	public T Min
	{
		get
		{
			if (Size == 0)
			{
				throw new Exception();
			}
			return tData[0];
		}
	}

	public double MinKey
	{
		get
		{
			if (Size == 0)
			{
				throw new Exception();
			}
			return tKeys[0];
		}
	}

	public MinHeap()
		: this(DEFAULT_SIZE)
	{
	}

	public MinHeap(int iCapacity)
	{
		tData = new T[iCapacity];
		tKeys = new double[iCapacity];
		Capacity = iCapacity;
		Size = 0;
	}

	public void Insert(double key, T value)
	{
		if (Size >= Capacity)
		{
			Capacity *= 2;
			T[] destinationArray = new T[Capacity];
			Array.Copy(tData, destinationArray, tData.Length);
			tData = destinationArray;
			double[] destinationArray2 = new double[Capacity];
			Array.Copy(tKeys, destinationArray2, tKeys.Length);
			tKeys = destinationArray2;
		}
		tData[Size] = value;
		tKeys[Size] = key;
		SiftUp(Size);
		Size++;
	}

	public void RemoveMin()
	{
		if (Size == 0)
		{
			throw new Exception();
		}
		Size--;
		tData[0] = tData[Size];
		tKeys[0] = tKeys[Size];
		tData[Size] = default(T);
		SiftDown(0);
	}

	private void SiftUp(int iChild)
	{
		int num = (iChild - 1) / 2;
		while (iChild != 0 && tKeys[iChild] < tKeys[num])
		{
			T val = tData[num];
			double num2 = tKeys[num];
			tData[num] = tData[iChild];
			tKeys[num] = tKeys[iChild];
			tData[iChild] = val;
			tKeys[iChild] = num2;
			iChild = num;
			num = (iChild - 1) / 2;
		}
	}

	private void SiftDown(int iParent)
	{
		int num = iParent * 2 + 1;
		while (num < Size)
		{
			if (num + 1 < Size && tKeys[num] > tKeys[num + 1])
			{
				num++;
			}
			if (tKeys[iParent] > tKeys[num])
			{
				T val = tData[iParent];
				double num2 = tKeys[iParent];
				tData[iParent] = tData[num];
				tKeys[iParent] = tKeys[num];
				tData[num] = val;
				tKeys[num] = num2;
				iParent = num;
				num = iParent * 2 + 1;
				continue;
			}
			break;
		}
	}
}
public class NearestNeighbour<T> : IEnumerator
{
	private double[] tSearchPoint;

	private DistanceFunctions kDistanceFunction;

	private MinHeap<KDNode<T>> pPending;

	private IntervalHeap<T> pEvaluated;

	private KDNode<T> pRoot = null;

	private int iMaxPointsReturned = 0;

	private int iPointsRemaining;

	private double fThreshold;

	private double _CurrentDistance = -1.0;

	private T _Current = default(T);

	object IEnumerator.Current => _Current;

	public double CurrentDistance => _CurrentDistance;

	public T Current => _Current;

	public NearestNeighbour(KDNode<T> pRoot, double[] tSearchPoint, DistanceFunctions kDistance, int iMaxPoints, double fThreshold)
	{
		if (tSearchPoint.Length != pRoot.iDimensions)
		{
			throw new Exception("Dimensionality of search point and kd-tree are not the same.");
		}
		this.tSearchPoint = new double[tSearchPoint.Length];
		Array.Copy(tSearchPoint, this.tSearchPoint, tSearchPoint.Length);
		iPointsRemaining = Math.Min(iMaxPoints, pRoot.Size);
		this.fThreshold = fThreshold;
		kDistanceFunction = kDistance;
		this.pRoot = pRoot;
		iMaxPointsReturned = iMaxPoints;
		_CurrentDistance = -1.0;
		pEvaluated = new IntervalHeap<T>();
		pPending = new MinHeap<KDNode<T>>();
		pPending.Insert(0.0, pRoot);
	}

	public bool MoveNext()
	{
		if (iPointsRemaining == 0)
		{
			_Current = default(T);
			return false;
		}
		while (pPending.Size > 0 && (pEvaluated.Size == 0 || pPending.MinKey < pEvaluated.MinKey))
		{
			KDNode<T> kDNode = pPending.Min;
			pPending.RemoveMin();
			while (!kDNode.IsLeaf)
			{
				KDNode<T> kDNode2;
				if (tSearchPoint[kDNode.iSplitDimension] > kDNode.fSplitValue)
				{
					kDNode2 = kDNode.pLeft;
					kDNode = kDNode.pRight;
				}
				else
				{
					kDNode2 = kDNode.pRight;
					kDNode = kDNode.pLeft;
				}
				double num = kDistanceFunction.DistanceToRectangle(tSearchPoint, kDNode2.tMinBound, kDNode2.tMaxBound);
				if ((!(fThreshold >= 0.0) || !(num > fThreshold)) && (pEvaluated.Size < iPointsRemaining || num <= pEvaluated.MaxKey))
				{
					pPending.Insert(num, kDNode2);
				}
			}
			if (kDNode.bSinglePoint)
			{
				double num = kDistanceFunction.Distance(kDNode.tPoints[0], tSearchPoint);
				if ((fThreshold >= 0.0 && num >= fThreshold) || (pEvaluated.Size >= iPointsRemaining && !(num <= pEvaluated.MaxKey)))
				{
					continue;
				}
				for (int i = 0; i < kDNode.Size; i++)
				{
					if (pEvaluated.Size == iPointsRemaining)
					{
						pEvaluated.ReplaceMax(num, kDNode.tData[i]);
					}
					else
					{
						pEvaluated.Insert(num, kDNode.tData[i]);
					}
				}
				continue;
			}
			for (int i = 0; i < kDNode.Size; i++)
			{
				double num = kDistanceFunction.Distance(kDNode.tPoints[i], tSearchPoint);
				if (!(fThreshold >= 0.0) || !(num >= fThreshold))
				{
					if (pEvaluated.Size < iPointsRemaining)
					{
						pEvaluated.Insert(num, kDNode.tData[i]);
					}
					else if (num < pEvaluated.MaxKey)
					{
						pEvaluated.ReplaceMax(num, kDNode.tData[i]);
					}
				}
			}
		}
		if (pEvaluated.Size == 0)
		{
			return false;
		}
		iPointsRemaining--;
		_CurrentDistance = pEvaluated.MinKey;
		_Current = pEvaluated.Min;
		pEvaluated.RemoveMin();
		return true;
	}

	public void Reset()
	{
		iPointsRemaining = Math.Min(iMaxPointsReturned, pRoot.Size);
		_CurrentDistance = -1.0;
		pEvaluated = new IntervalHeap<T>();
		pPending = new MinHeap<KDNode<T>>();
		pPending.Insert(0.0, pRoot);
	}
}
