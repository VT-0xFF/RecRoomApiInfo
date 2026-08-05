using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyTitle("Poly2Tri")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Poly2Tri Contributors")]
[assembly: AssemblyProduct("Poly2Tri")]
[assembly: AssemblyCopyright("Copyright © Poly2Tri Contributors 2009-2010")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("d1e24f2b-ea85-471a-af97-b431ca71b75c")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyVersion("1.0.0.0")]
namespace Poly2Tri;

public static class P2T
{
	private static TriangulationAlgorithm _defaultAlgorithm;

	public static void Triangulate(PolygonSet ps)
	{
		TriangulationContext triangulationContext = CreateContext(_defaultAlgorithm);
		foreach (Polygon polygon in ps.Polygons)
		{
			triangulationContext.PrepareTriangulation(polygon);
			Triangulate(triangulationContext);
			triangulationContext.Clear();
		}
	}

	public static void Triangulate(Polygon p)
	{
		Triangulate(_defaultAlgorithm, p);
	}

	public static void Triangulate(ConstrainedPointSet cps)
	{
		Triangulate(_defaultAlgorithm, cps);
	}

	public static void Triangulate(PointSet ps)
	{
		Triangulate(_defaultAlgorithm, ps);
	}

	public static TriangulationContext CreateContext(TriangulationAlgorithm algorithm)
	{
		return new DTSweepContext();
	}

	public static void Triangulate(TriangulationAlgorithm algorithm, Triangulatable t)
	{
		TriangulationContext triangulationContext = CreateContext(algorithm);
		triangulationContext.PrepareTriangulation(t);
		Triangulate(triangulationContext);
	}

	public static void Triangulate(TriangulationContext tcx)
	{
		TriangulationAlgorithm algorithm = tcx.Algorithm;
		DTSweep.Triangulate((DTSweepContext)tcx);
	}

	public static void Warmup()
	{
	}
}
public class Polygon : Triangulatable
{
	protected List<TriangulationPoint> _points = new List<TriangulationPoint>();

	protected List<TriangulationPoint> _steinerPoints;

	protected List<Polygon> _holes;

	protected List<DelaunayTriangle> _triangles;

	protected PolygonPoint _last;

	public TriangulationMode TriangulationMode => TriangulationMode.Polygon;

	public IList<TriangulationPoint> Points => _points;

	public IList<DelaunayTriangle> Triangles => _triangles;

	public IList<Polygon> Holes => _holes;

	public Polygon(IList<PolygonPoint> points)
	{
		if (points.Count < 3)
		{
			throw new ArgumentException("List has fewer than 3 points", "points");
		}
		if (points[0].Equals(points[points.Count - 1]))
		{
			points.RemoveAt(points.Count - 1);
		}
		_points.AddRange(points.Cast<TriangulationPoint>());
	}

	public Polygon(IEnumerable<PolygonPoint> points)
		: this((points as IList<PolygonPoint>) ?? points.ToArray())
	{
	}

	public Polygon(params PolygonPoint[] points)
		: this((IList<PolygonPoint>)points)
	{
	}

	public void AddSteinerPoint(TriangulationPoint point)
	{
		if (_steinerPoints == null)
		{
			_steinerPoints = new List<TriangulationPoint>();
		}
		_steinerPoints.Add(point);
	}

	public void AddSteinerPoints(List<TriangulationPoint> points)
	{
		if (_steinerPoints == null)
		{
			_steinerPoints = new List<TriangulationPoint>();
		}
		_steinerPoints.AddRange(points);
	}

	public void ClearSteinerPoints()
	{
		if (_steinerPoints != null)
		{
			_steinerPoints.Clear();
		}
	}

	public void AddHole(Polygon poly)
	{
		if (_holes == null)
		{
			_holes = new List<Polygon>();
		}
		_holes.Add(poly);
	}

	public void InsertPointAfter(PolygonPoint point, PolygonPoint newPoint)
	{
		int num = _points.IndexOf(point);
		if (num == -1)
		{
			throw new ArgumentException("Tried to insert a point into a Polygon after a point not belonging to the Polygon", "point");
		}
		newPoint.Next = point.Next;
		newPoint.Previous = point;
		point.Next.Previous = newPoint;
		point.Next = newPoint;
		_points.Insert(num + 1, newPoint);
	}

	public void AddPoints(IEnumerable<PolygonPoint> list)
	{
		foreach (PolygonPoint item in list)
		{
			item.Previous = _last;
			if (_last != null)
			{
				item.Next = _last.Next;
				_last.Next = item;
			}
			_last = item;
			_points.Add(item);
		}
		PolygonPoint polygonPoint = (PolygonPoint)_points[0];
		_last.Next = polygonPoint;
		polygonPoint.Previous = _last;
	}

	public void AddPoint(PolygonPoint p)
	{
		p.Previous = _last;
		p.Next = _last.Next;
		_last.Next = p;
		_points.Add(p);
	}

	public void RemovePoint(PolygonPoint p)
	{
		PolygonPoint next = p.Next;
		PolygonPoint previous = p.Previous;
		previous.Next = next;
		next.Previous = previous;
		_points.Remove(p);
	}

	public void AddTriangle(DelaunayTriangle t)
	{
		_triangles.Add(t);
	}

	public void AddTriangles(IEnumerable<DelaunayTriangle> list)
	{
		_triangles.AddRange(list);
	}

	public void ClearTriangles()
	{
		if (_triangles != null)
		{
			_triangles.Clear();
		}
	}

	public void Prepare(TriangulationContext tcx)
	{
		if (_triangles == null)
		{
			_triangles = new List<DelaunayTriangle>(_points.Count);
		}
		else
		{
			_triangles.Clear();
		}
		for (int i = 0; i < _points.Count - 1; i++)
		{
			tcx.NewConstraint(_points[i], _points[i + 1]);
		}
		tcx.NewConstraint(_points[0], _points[_points.Count - 1]);
		tcx.Points.AddRange(_points);
		if (_holes != null)
		{
			foreach (Polygon hole in _holes)
			{
				for (int j = 0; j < hole._points.Count - 1; j++)
				{
					tcx.NewConstraint(hole._points[j], hole._points[j + 1]);
				}
				tcx.NewConstraint(hole._points[0], hole._points[hole._points.Count - 1]);
				tcx.Points.AddRange(hole._points);
			}
		}
		if (_steinerPoints != null)
		{
			tcx.Points.AddRange(_steinerPoints);
		}
	}
}
public class PolygonPoint : TriangulationPoint
{
	public PolygonPoint Next { get; set; }

	public PolygonPoint Previous { get; set; }

	public PolygonPoint(double x, double y, int index = -1)
		: base(x, y, index)
	{
	}
}
public class PolygonSet
{
	protected List<Polygon> _polygons = new List<Polygon>();

	public IEnumerable<Polygon> Polygons => _polygons;

	public PolygonSet()
	{
	}

	public PolygonSet(Polygon poly)
	{
		_polygons.Add(poly);
	}

	public void Add(Polygon p)
	{
		_polygons.Add(p);
	}
}
public class DelaunayTriangle
{
	public FixedArray3<TriangulationPoint> Points;

	public FixedArray3<DelaunayTriangle> Neighbors;

	public FixedBitArray3 EdgeIsConstrained;

	public FixedBitArray3 EdgeIsDelaunay;

	public bool IsInterior { get; set; }

	public DelaunayTriangle(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3)
	{
		Points[0] = p1;
		Points[1] = p2;
		Points[2] = p3;
	}

	public int IndexOf(TriangulationPoint p)
	{
		int num = Points.IndexOf(p);
		if (num == -1)
		{
			throw new Exception("Calling index with a point that doesn't exist in triangle");
		}
		return num;
	}

	public int IndexCWFrom(TriangulationPoint p)
	{
		return (IndexOf(p) + 2) % 3;
	}

	public int IndexCCWFrom(TriangulationPoint p)
	{
		return (IndexOf(p) + 1) % 3;
	}

	public bool Contains(TriangulationPoint p)
	{
		return Points.Contains(p);
	}

	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t)
	{
		int num = EdgeIndex(p1, p2);
		if (num == -1)
		{
			throw new Exception("Error marking neighbors -- t doesn't contain edge p1-p2!");
		}
		Neighbors[num] = t;
	}

	public void MarkNeighbor(DelaunayTriangle t)
	{
		bool flag = t.Contains(Points[0]);
		bool flag2 = t.Contains(Points[1]);
		bool flag3 = t.Contains(Points[2]);
		if (flag2 && flag3)
		{
			Neighbors[0] = t;
			t.MarkNeighbor(Points[1], Points[2], this);
			return;
		}
		if (flag && flag3)
		{
			Neighbors[1] = t;
			t.MarkNeighbor(Points[0], Points[2], this);
			return;
		}
		if (flag && flag2)
		{
			Neighbors[2] = t;
			t.MarkNeighbor(Points[0], Points[1], this);
			return;
		}
		throw new Exception("Failed to mark neighbor, doesn't share an edge!");
	}

	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p)
	{
		return PointCWFrom(t.PointCWFrom(p));
	}

	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point)
	{
		return Neighbors[(Points.IndexOf(point) + 1) % 3];
	}

	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point)
	{
		return Neighbors[(Points.IndexOf(point) + 2) % 3];
	}

	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point)
	{
		return Neighbors[Points.IndexOf(point)];
	}

	public TriangulationPoint PointCCWFrom(TriangulationPoint point)
	{
		return Points[(IndexOf(point) + 1) % 3];
	}

	public TriangulationPoint PointCWFrom(TriangulationPoint point)
	{
		return Points[(IndexOf(point) + 2) % 3];
	}

	private void RotateCW()
	{
		TriangulationPoint value = Points[2];
		Points[2] = Points[1];
		Points[1] = Points[0];
		Points[0] = value;
	}

	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint)
	{
		RotateCW();
		Points[IndexCCWFrom(oPoint)] = nPoint;
	}

	public override string ToString()
	{
		return string.Concat(Points[0], ",", Points[1], ",", Points[2]);
	}

	public void MarkNeighborEdges()
	{
		for (int i = 0; i < 3; i++)
		{
			if (EdgeIsConstrained[i] && Neighbors[i] != null)
			{
				Neighbors[i].MarkConstrainedEdge(Points[(i + 1) % 3], Points[(i + 2) % 3]);
			}
		}
	}

	public void MarkEdge(DelaunayTriangle triangle)
	{
		for (int i = 0; i < 3; i++)
		{
			if (EdgeIsConstrained[i])
			{
				triangle.MarkConstrainedEdge(Points[(i + 1) % 3], Points[(i + 2) % 3]);
			}
		}
	}

	public void MarkEdge(List<DelaunayTriangle> tList)
	{
		foreach (DelaunayTriangle t in tList)
		{
			for (int i = 0; i < 3; i++)
			{
				if (t.EdgeIsConstrained[i])
				{
					MarkConstrainedEdge(t.Points[(i + 1) % 3], t.Points[(i + 2) % 3]);
				}
			}
		}
	}

	public void MarkConstrainedEdge(int index)
	{
		EdgeIsConstrained[index] = true;
	}

	public void MarkConstrainedEdge(DTSweepConstraint edge)
	{
		MarkConstrainedEdge(edge.P, edge.Q);
	}

	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q)
	{
		int num = EdgeIndex(p, q);
		if (num != -1)
		{
			EdgeIsConstrained[num] = true;
		}
	}

	public double Area()
	{
		double num = Points[0].X - Points[1].X;
		double num2 = Points[2].Y - Points[1].Y;
		return Math.Abs(num * num2 * 0.5);
	}

	public TriangulationPoint Centroid()
	{
		double x = (Points[0].X + Points[1].X + Points[2].X) / 3.0;
		double y = (Points[0].Y + Points[1].Y + Points[2].Y) / 3.0;
		return new TriangulationPoint(x, y);
	}

	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2)
	{
		int num = Points.IndexOf(p1);
		int num2 = Points.IndexOf(p2);
		bool flag = num == 0 || num2 == 0;
		bool flag2 = num == 1 || num2 == 1;
		bool flag3 = num == 2 || num2 == 2;
		if (flag2 && flag3)
		{
			return 0;
		}
		if (flag && flag3)
		{
			return 1;
		}
		if (flag && flag2)
		{
			return 2;
		}
		return -1;
	}

	public bool GetConstrainedEdgeCCW(TriangulationPoint p)
	{
		return EdgeIsConstrained[(IndexOf(p) + 2) % 3];
	}

	public bool GetConstrainedEdgeCW(TriangulationPoint p)
	{
		return EdgeIsConstrained[(IndexOf(p) + 1) % 3];
	}

	public bool GetConstrainedEdgeAcross(TriangulationPoint p)
	{
		return EdgeIsConstrained[IndexOf(p)];
	}

	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce)
	{
		EdgeIsConstrained[(IndexOf(p) + 2) % 3] = ce;
	}

	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce)
	{
		EdgeIsConstrained[(IndexOf(p) + 1) % 3] = ce;
	}

	public void SetConstrainedEdgeAcross(TriangulationPoint p, bool ce)
	{
		EdgeIsConstrained[IndexOf(p)] = ce;
	}

	public bool GetDelaunayEdgeCCW(TriangulationPoint p)
	{
		return EdgeIsDelaunay[(IndexOf(p) + 2) % 3];
	}

	public bool GetDelaunayEdgeCW(TriangulationPoint p)
	{
		return EdgeIsDelaunay[(IndexOf(p) + 1) % 3];
	}

	public bool GetDelaunayEdgeAcross(TriangulationPoint p)
	{
		return EdgeIsDelaunay[IndexOf(p)];
	}

	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce)
	{
		EdgeIsDelaunay[(IndexOf(p) + 2) % 3] = ce;
	}

	public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce)
	{
		EdgeIsDelaunay[(IndexOf(p) + 1) % 3] = ce;
	}

	public void SetDelaunayEdgeAcross(TriangulationPoint p, bool ce)
	{
		EdgeIsDelaunay[IndexOf(p)] = ce;
	}
}
public class AdvancingFront
{
	public AdvancingFrontNode Head;

	public AdvancingFrontNode Tail;

	protected AdvancingFrontNode Search;

	public AdvancingFront(AdvancingFrontNode head, AdvancingFrontNode tail)
	{
		Head = head;
		Tail = tail;
		Search = head;
		AddNode(head);
		AddNode(tail);
	}

	public void AddNode(AdvancingFrontNode node)
	{
	}

	public void RemoveNode(AdvancingFrontNode node)
	{
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (AdvancingFrontNode advancingFrontNode = Head; advancingFrontNode != Tail; advancingFrontNode = advancingFrontNode.Next)
		{
			stringBuilder.Append(advancingFrontNode.Point.X).Append("->");
		}
		stringBuilder.Append(Tail.Point.X);
		return stringBuilder.ToString();
	}

	private AdvancingFrontNode FindSearchNode(double x)
	{
		return Search;
	}

	public AdvancingFrontNode LocateNode(TriangulationPoint point)
	{
		return LocateNode(point.X);
	}

	private AdvancingFrontNode LocateNode(double x)
	{
		AdvancingFrontNode advancingFrontNode = FindSearchNode(x);
		if (x < advancingFrontNode.Value)
		{
			while ((advancingFrontNode = advancingFrontNode.Prev) != null)
			{
				if (x >= advancingFrontNode.Value)
				{
					Search = advancingFrontNode;
					return advancingFrontNode;
				}
			}
		}
		else
		{
			while ((advancingFrontNode = advancingFrontNode.Next) != null)
			{
				if (x < advancingFrontNode.Value)
				{
					Search = advancingFrontNode.Prev;
					return advancingFrontNode.Prev;
				}
			}
		}
		return null;
	}

	public AdvancingFrontNode LocatePoint(TriangulationPoint point)
	{
		double x = point.X;
		AdvancingFrontNode advancingFrontNode = FindSearchNode(x);
		double x2 = advancingFrontNode.Point.X;
		if (x == x2)
		{
			if (point != advancingFrontNode.Point)
			{
				if (point == advancingFrontNode.Prev.Point)
				{
					advancingFrontNode = advancingFrontNode.Prev;
				}
				else
				{
					if (point != advancingFrontNode.Next.Point)
					{
						throw new Exception("Failed to find Node for given afront point");
					}
					advancingFrontNode = advancingFrontNode.Next;
				}
			}
		}
		else if (x < x2)
		{
			while ((advancingFrontNode = advancingFrontNode.Prev) != null && point != advancingFrontNode.Point)
			{
			}
		}
		else
		{
			while ((advancingFrontNode = advancingFrontNode.Next) != null && point != advancingFrontNode.Point)
			{
			}
		}
		Search = advancingFrontNode;
		return advancingFrontNode;
	}
}
public class AdvancingFrontNode
{
	public AdvancingFrontNode Next;

	public AdvancingFrontNode Prev;

	public double Value;

	public TriangulationPoint Point;

	public DelaunayTriangle Triangle;

	public bool HasNext => Next != null;

	public bool HasPrev => Prev != null;

	public AdvancingFrontNode(TriangulationPoint point)
	{
		Point = point;
		Value = point.X;
	}
}
public static class DTSweep
{
	private const double PI_div2 = Math.PI / 2.0;

	private const double PI_3div4 = Math.PI * 3.0 / 4.0;

	public static void Triangulate(DTSweepContext tcx)
	{
		tcx.CreateAdvancingFront();
		Sweep(tcx);
		if (tcx.TriangulationMode == TriangulationMode.Polygon)
		{
			FinalizationPolygon(tcx);
		}
		else
		{
			FinalizationConvexHull(tcx);
		}
		tcx.Done();
	}

	private static void Sweep(DTSweepContext tcx)
	{
		List<TriangulationPoint> points = tcx.Points;
		for (int i = 1; i < points.Count; i++)
		{
			TriangulationPoint triangulationPoint = points[i];
			AdvancingFrontNode node = PointEvent(tcx, triangulationPoint);
			if (triangulationPoint.HasEdges)
			{
				foreach (DTSweepConstraint edge in triangulationPoint.Edges)
				{
					if (tcx.IsDebugEnabled)
					{
						tcx.DTDebugContext.ActiveConstraint = edge;
					}
					EdgeEvent(tcx, edge, node);
				}
			}
			tcx.Update(null);
		}
	}

	private static void FinalizationConvexHull(DTSweepContext tcx)
	{
		AdvancingFrontNode next = tcx.Front.Head.Next;
		AdvancingFrontNode next2 = next.Next;
		_ = next2.Next;
		TriangulationPoint point = next.Point;
		TurnAdvancingFrontConvex(tcx, next, next2);
		next = tcx.Front.Tail.Prev;
		DelaunayTriangle delaunayTriangle;
		if (next.Triangle.Contains(next.Next.Point) && next.Triangle.Contains(next.Prev.Point))
		{
			delaunayTriangle = next.Triangle.NeighborAcrossFrom(next.Point);
			RotateTrianglePair(next.Triangle, next.Point, delaunayTriangle, delaunayTriangle.OppositePoint(next.Triangle, next.Point));
			tcx.MapTriangleToNodes(next.Triangle);
			tcx.MapTriangleToNodes(delaunayTriangle);
		}
		next = tcx.Front.Head.Next;
		if (next.Triangle.Contains(next.Prev.Point) && next.Triangle.Contains(next.Next.Point))
		{
			delaunayTriangle = next.Triangle.NeighborAcrossFrom(next.Point);
			RotateTrianglePair(next.Triangle, next.Point, delaunayTriangle, delaunayTriangle.OppositePoint(next.Triangle, next.Point));
			tcx.MapTriangleToNodes(next.Triangle);
			tcx.MapTriangleToNodes(delaunayTriangle);
		}
		point = tcx.Front.Head.Point;
		next2 = tcx.Front.Tail.Prev;
		delaunayTriangle = next2.Triangle;
		TriangulationPoint triangulationPoint = next2.Point;
		while (true)
		{
			tcx.RemoveFromList(delaunayTriangle);
			triangulationPoint = delaunayTriangle.PointCCWFrom(triangulationPoint);
			if (triangulationPoint == point)
			{
				break;
			}
			delaunayTriangle = delaunayTriangle.NeighborCCWFrom(triangulationPoint);
		}
		point = tcx.Front.Head.Next.Point;
		triangulationPoint = delaunayTriangle.PointCWFrom(tcx.Front.Head.Point);
		delaunayTriangle = delaunayTriangle.NeighborCWFrom(tcx.Front.Head.Point);
		do
		{
			tcx.RemoveFromList(delaunayTriangle);
			triangulationPoint = delaunayTriangle.PointCCWFrom(triangulationPoint);
			delaunayTriangle = delaunayTriangle.NeighborCCWFrom(triangulationPoint);
		}
		while (triangulationPoint != point);
		tcx.FinalizeTriangulation();
	}

	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c)
	{
		AdvancingFrontNode advancingFrontNode = b;
		while (c != tcx.Front.Tail)
		{
			if (tcx.IsDebugEnabled)
			{
				tcx.DTDebugContext.ActiveNode = c;
			}
			if (TriangulationUtil.Orient2d(b.Point, c.Point, c.Next.Point) == Orientation.CCW)
			{
				Fill(tcx, c);
				c = c.Next;
			}
			else if (b != advancingFrontNode && TriangulationUtil.Orient2d(b.Prev.Point, b.Point, c.Point) == Orientation.CCW)
			{
				Fill(tcx, b);
				b = b.Prev;
			}
			else
			{
				b = c;
				c = c.Next;
			}
		}
	}

	private static void FinalizationPolygon(DTSweepContext tcx)
	{
		DelaunayTriangle delaunayTriangle = tcx.Front.Head.Next.Triangle;
		TriangulationPoint point = tcx.Front.Head.Next.Point;
		while (!delaunayTriangle.GetConstrainedEdgeCW(point))
		{
			delaunayTriangle = delaunayTriangle.NeighborCCWFrom(point);
		}
		tcx.MeshClean(delaunayTriangle);
	}

	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point)
	{
		AdvancingFrontNode advancingFrontNode = tcx.LocateNode(point);
		if (tcx.IsDebugEnabled)
		{
			tcx.DTDebugContext.ActiveNode = advancingFrontNode;
		}
		AdvancingFrontNode advancingFrontNode2 = NewFrontTriangle(tcx, point, advancingFrontNode);
		if (point.X <= advancingFrontNode.Point.X + TriangulationUtil.EPSILON)
		{
			Fill(tcx, advancingFrontNode);
		}
		tcx.AddNode(advancingFrontNode2);
		FillAdvancingFront(tcx, advancingFrontNode2);
		return advancingFrontNode2;
	}

	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node)
	{
		DelaunayTriangle delaunayTriangle = new DelaunayTriangle(point, node.Point, node.Next.Point);
		delaunayTriangle.MarkNeighbor(node.Triangle);
		tcx.Triangles.Add(delaunayTriangle);
		AdvancingFrontNode advancingFrontNode = new AdvancingFrontNode(point);
		advancingFrontNode.Next = node.Next;
		advancingFrontNode.Prev = node;
		node.Next.Prev = advancingFrontNode;
		node.Next = advancingFrontNode;
		tcx.AddNode(advancingFrontNode);
		if (tcx.IsDebugEnabled)
		{
			tcx.DTDebugContext.ActiveNode = advancingFrontNode;
		}
		if (!Legalize(tcx, delaunayTriangle))
		{
			tcx.MapTriangleToNodes(delaunayTriangle);
		}
		return advancingFrontNode;
	}

	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
		try
		{
			tcx.EdgeEvent.ConstrainedEdge = edge;
			tcx.EdgeEvent.Right = edge.P.X > edge.Q.X;
			if (tcx.IsDebugEnabled)
			{
				tcx.DTDebugContext.PrimaryTriangle = node.Triangle;
			}
			if (!IsEdgeSideOfTriangle(node.Triangle, edge.P, edge.Q))
			{
				FillEdgeEvent(tcx, edge, node);
				EdgeEvent(tcx, edge.P, edge.Q, node.Triangle, edge.Q);
			}
		}
		catch (PointOnEdgeException)
		{
			throw;
		}
	}

	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
		if (tcx.EdgeEvent.Right)
		{
			FillRightAboveEdgeEvent(tcx, edge, node);
		}
		else
		{
			FillLeftAboveEdgeEvent(tcx, edge, node);
		}
	}

	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
		Fill(tcx, node.Next);
		if (node.Next.Point != edge.P && TriangulationUtil.Orient2d(edge.Q, node.Next.Point, edge.P) == Orientation.CCW && TriangulationUtil.Orient2d(node.Point, node.Next.Point, node.Next.Next.Point) == Orientation.CCW)
		{
			FillRightConcaveEdgeEvent(tcx, edge, node);
		}
	}

	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
		if (TriangulationUtil.Orient2d(node.Next.Point, node.Next.Next.Point, node.Next.Next.Next.Point) == Orientation.CCW)
		{
			FillRightConcaveEdgeEvent(tcx, edge, node.Next);
		}
		else if (TriangulationUtil.Orient2d(edge.Q, node.Next.Next.Point, edge.P) == Orientation.CCW)
		{
			FillRightConvexEdgeEvent(tcx, edge, node.Next);
		}
	}

	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
		if (tcx.IsDebugEnabled)
		{
			tcx.DTDebugContext.ActiveNode = node;
		}
		if (node.Point.X < edge.P.X)
		{
			if (TriangulationUtil.Orient2d(node.Point, node.Next.Point, node.Next.Next.Point) == Orientation.CCW)
			{
				FillRightConcaveEdgeEvent(tcx, edge, node);
				return;
			}
			FillRightConvexEdgeEvent(tcx, edge, node);
			FillRightBelowEdgeEvent(tcx, edge, node);
		}
	}

	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
		while (node.Next.Point.X < edge.P.X)
		{
			if (tcx.IsDebugEnabled)
			{
				tcx.DTDebugContext.ActiveNode = node;
			}
			if (TriangulationUtil.Orient2d(edge.Q, node.Next.Point, edge.P) == Orientation.CCW)
			{
				FillRightBelowEdgeEvent(tcx, edge, node);
			}
			else
			{
				node = node.Next;
			}
		}
	}

	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
		if (TriangulationUtil.Orient2d(node.Prev.Point, node.Prev.Prev.Point, node.Prev.Prev.Prev.Point) == Orientation.CW)
		{
			FillLeftConcaveEdgeEvent(tcx, edge, node.Prev);
		}
		else if (TriangulationUtil.Orient2d(edge.Q, node.Prev.Prev.Point, edge.P) == Orientation.CW)
		{
			FillLeftConvexEdgeEvent(tcx, edge, node.Prev);
		}
	}

	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
		Fill(tcx, node.Prev);
		if (node.Prev.Point != edge.P && TriangulationUtil.Orient2d(edge.Q, node.Prev.Point, edge.P) == Orientation.CW && TriangulationUtil.Orient2d(node.Point, node.Prev.Point, node.Prev.Prev.Point) == Orientation.CW)
		{
			FillLeftConcaveEdgeEvent(tcx, edge, node);
		}
	}

	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
		if (tcx.IsDebugEnabled)
		{
			tcx.DTDebugContext.ActiveNode = node;
		}
		if (node.Point.X > edge.P.X)
		{
			if (TriangulationUtil.Orient2d(node.Point, node.Prev.Point, node.Prev.Prev.Point) == Orientation.CW)
			{
				FillLeftConcaveEdgeEvent(tcx, edge, node);
				return;
			}
			FillLeftConvexEdgeEvent(tcx, edge, node);
			FillLeftBelowEdgeEvent(tcx, edge, node);
		}
	}

	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
		while (node.Prev.Point.X > edge.P.X)
		{
			if (tcx.IsDebugEnabled)
			{
				tcx.DTDebugContext.ActiveNode = node;
			}
			if (TriangulationUtil.Orient2d(edge.Q, node.Prev.Point, edge.P) == Orientation.CW)
			{
				FillLeftBelowEdgeEvent(tcx, edge, node);
			}
			else
			{
				node = node.Prev;
			}
		}
	}

	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq)
	{
		int num = triangle.EdgeIndex(ep, eq);
		if (num == -1)
		{
			return false;
		}
		triangle.MarkConstrainedEdge(num);
		triangle = triangle.Neighbors[num];
		triangle?.MarkConstrainedEdge(ep, eq);
		return true;
	}

	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point)
	{
		if (tcx.IsDebugEnabled)
		{
			tcx.DTDebugContext.PrimaryTriangle = triangle;
		}
		if (!IsEdgeSideOfTriangle(triangle, ep, eq))
		{
			TriangulationPoint triangulationPoint = triangle.PointCCWFrom(point);
			Orientation orientation = TriangulationUtil.Orient2d(eq, triangulationPoint, ep);
			if (orientation == Orientation.Collinear)
			{
				throw new PointOnEdgeException("EdgeEvent - Point on constrained edge not supported yet", eq, triangulationPoint, ep);
			}
			TriangulationPoint triangulationPoint2 = triangle.PointCWFrom(point);
			Orientation orientation2 = TriangulationUtil.Orient2d(eq, triangulationPoint2, ep);
			if (orientation2 == Orientation.Collinear)
			{
				throw new PointOnEdgeException("EdgeEvent - Point on constrained edge not supported yet", eq, triangulationPoint2, ep);
			}
			if (orientation == orientation2)
			{
				triangle = ((orientation != Orientation.CW) ? triangle.NeighborCWFrom(point) : triangle.NeighborCCWFrom(point));
				EdgeEvent(tcx, ep, eq, triangle, point);
			}
			else
			{
				FlipEdgeEvent(tcx, ep, eq, triangle, point);
			}
		}
	}

	private static void SplitEdge(TriangulationPoint ep, TriangulationPoint eq, TriangulationPoint p)
	{
		eq.Edges.First((DTSweepConstraint e) => e.Q == ep || e.P == ep).P = p;
		new DTSweepConstraint(ep, p);
	}

	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p)
	{
		DelaunayTriangle delaunayTriangle = t.NeighborAcrossFrom(p);
		TriangulationPoint triangulationPoint = delaunayTriangle.OppositePoint(t, p);
		if (delaunayTriangle == null)
		{
			throw new InvalidOperationException("[BUG:FIXME] FLIP failed due to missing triangle");
		}
		if (tcx.IsDebugEnabled)
		{
			tcx.DTDebugContext.PrimaryTriangle = t;
			tcx.DTDebugContext.SecondaryTriangle = delaunayTriangle;
		}
		if (TriangulationUtil.InScanArea(p, t.PointCCWFrom(p), t.PointCWFrom(p), triangulationPoint))
		{
			RotateTrianglePair(t, p, delaunayTriangle, triangulationPoint);
			tcx.MapTriangleToNodes(t);
			tcx.MapTriangleToNodes(delaunayTriangle);
			if (p == eq && triangulationPoint == ep)
			{
				if (eq == tcx.EdgeEvent.ConstrainedEdge.Q && ep == tcx.EdgeEvent.ConstrainedEdge.P)
				{
					if (tcx.IsDebugEnabled)
					{
						Console.WriteLine("[FLIP] - constrained edge done");
					}
					t.MarkConstrainedEdge(ep, eq);
					delaunayTriangle.MarkConstrainedEdge(ep, eq);
					Legalize(tcx, t);
					Legalize(tcx, delaunayTriangle);
				}
				else if (tcx.IsDebugEnabled)
				{
					Console.WriteLine("[FLIP] - subedge done");
				}
			}
			else
			{
				if (tcx.IsDebugEnabled)
				{
					Console.WriteLine("[FLIP] - flipping and continuing with triangle still crossing edge");
				}
				Orientation o = TriangulationUtil.Orient2d(eq, triangulationPoint, ep);
				t = NextFlipTriangle(tcx, o, t, delaunayTriangle, p, triangulationPoint);
				FlipEdgeEvent(tcx, ep, eq, t, p);
			}
		}
		else
		{
			TriangulationPoint p2 = NextFlipPoint(ep, eq, delaunayTriangle, triangulationPoint);
			FlipScanEdgeEvent(tcx, ep, eq, t, delaunayTriangle, p2);
			EdgeEvent(tcx, ep, eq, t, p);
		}
	}

	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op)
	{
		return TriangulationUtil.Orient2d(eq, op, ep) switch
		{
			Orientation.CW => ot.PointCCWFrom(op), 
			Orientation.CCW => ot.PointCWFrom(op), 
			Orientation.Collinear => throw new PointOnEdgeException("Point on constrained edge not supported yet", eq, op, ep), 
			_ => throw new NotImplementedException("Orientation not handled"), 
		};
	}

	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op)
	{
		int index;
		if (o == Orientation.CCW)
		{
			index = ot.EdgeIndex(p, op);
			ot.EdgeIsDelaunay[index] = true;
			Legalize(tcx, ot);
			ot.EdgeIsDelaunay.Clear();
			return t;
		}
		index = t.EdgeIndex(p, op);
		t.EdgeIsDelaunay[index] = true;
		Legalize(tcx, t);
		t.EdgeIsDelaunay.Clear();
		return ot;
	}

	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p)
	{
		DelaunayTriangle delaunayTriangle = t.NeighborAcrossFrom(p);
		TriangulationPoint triangulationPoint = delaunayTriangle.OppositePoint(t, p);
		if (delaunayTriangle == null)
		{
			throw new Exception("[BUG:FIXME] FLIP failed due to missing triangle");
		}
		if (tcx.IsDebugEnabled)
		{
			Console.WriteLine("[FLIP:SCAN] - scan next point");
			tcx.DTDebugContext.PrimaryTriangle = t;
			tcx.DTDebugContext.SecondaryTriangle = delaunayTriangle;
		}
		if (TriangulationUtil.InScanArea(eq, flipTriangle.PointCCWFrom(eq), flipTriangle.PointCWFrom(eq), triangulationPoint))
		{
			FlipEdgeEvent(tcx, eq, triangulationPoint, delaunayTriangle, triangulationPoint);
			return;
		}
		TriangulationPoint p2 = NextFlipPoint(ep, eq, delaunayTriangle, triangulationPoint);
		FlipScanEdgeEvent(tcx, ep, eq, flipTriangle, delaunayTriangle, p2);
	}

	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n)
	{
		AdvancingFrontNode next = n.Next;
		while (next.HasNext)
		{
			double num = HoleAngle(next);
			if (num > Math.PI / 2.0 || num < -Math.PI / 2.0)
			{
				break;
			}
			Fill(tcx, next);
			next = next.Next;
		}
		next = n.Prev;
		while (next.HasPrev)
		{
			double num = HoleAngle(next);
			if (num > Math.PI / 2.0 || num < -Math.PI / 2.0)
			{
				break;
			}
			Fill(tcx, next);
			next = next.Prev;
		}
		if (n.HasNext && n.Next.HasNext)
		{
			double num = BasinAngle(n);
			if (num < Math.PI * 3.0 / 4.0)
			{
				FillBasin(tcx, n);
			}
		}
	}

	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node)
	{
		if (TriangulationUtil.Orient2d(node.Point, node.Next.Point, node.Next.Next.Point) == Orientation.CCW)
		{
			tcx.Basin.leftNode = node;
		}
		else
		{
			tcx.Basin.leftNode = node.Next;
		}
		tcx.Basin.bottomNode = tcx.Basin.leftNode;
		while (tcx.Basin.bottomNode.HasNext && tcx.Basin.bottomNode.Point.Y >= tcx.Basin.bottomNode.Next.Point.Y)
		{
			tcx.Basin.bottomNode = tcx.Basin.bottomNode.Next;
		}
		if (tcx.Basin.bottomNode != tcx.Basin.leftNode)
		{
			tcx.Basin.rightNode = tcx.Basin.bottomNode;
			while (tcx.Basin.rightNode.HasNext && tcx.Basin.rightNode.Point.Y < tcx.Basin.rightNode.Next.Point.Y)
			{
				tcx.Basin.rightNode = tcx.Basin.rightNode.Next;
			}
			if (tcx.Basin.rightNode != tcx.Basin.bottomNode)
			{
				tcx.Basin.width = tcx.Basin.rightNode.Point.X - tcx.Basin.leftNode.Point.X;
				tcx.Basin.leftHighest = tcx.Basin.leftNode.Point.Y > tcx.Basin.rightNode.Point.Y;
				FillBasinReq(tcx, tcx.Basin.bottomNode);
			}
		}
	}

	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node)
	{
		if (IsShallow(tcx, node))
		{
			return;
		}
		Fill(tcx, node);
		if (node.Prev == tcx.Basin.leftNode && node.Next == tcx.Basin.rightNode)
		{
			return;
		}
		if (node.Prev == tcx.Basin.leftNode)
		{
			if (TriangulationUtil.Orient2d(node.Point, node.Next.Point, node.Next.Next.Point) == Orientation.CW)
			{
				return;
			}
			node = node.Next;
		}
		else if (node.Next != tcx.Basin.rightNode)
		{
			node = ((!(node.Prev.Point.Y < node.Next.Point.Y)) ? node.Next : node.Prev);
		}
		else
		{
			if (TriangulationUtil.Orient2d(node.Point, node.Prev.Point, node.Prev.Prev.Point) == Orientation.CCW)
			{
				return;
			}
			node = node.Prev;
		}
		FillBasinReq(tcx, node);
	}

	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node)
	{
		double num = ((!tcx.Basin.leftHighest) ? (tcx.Basin.rightNode.Point.Y - node.Point.Y) : (tcx.Basin.leftNode.Point.Y - node.Point.Y));
		if (tcx.Basin.width > num)
		{
			return true;
		}
		return false;
	}

	private static double HoleAngle(AdvancingFrontNode node)
	{
		double x = node.Point.X;
		double y = node.Point.Y;
		double num = node.Next.Point.X - x;
		double num2 = node.Next.Point.Y - y;
		double num3 = node.Prev.Point.X - x;
		double num4 = node.Prev.Point.Y - y;
		return Math.Atan2(num * num4 - num2 * num3, num * num3 + num2 * num4);
	}

	private static double BasinAngle(AdvancingFrontNode node)
	{
		double x = node.Point.X - node.Next.Next.Point.X;
		return Math.Atan2(node.Point.Y - node.Next.Next.Point.Y, x);
	}

	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node)
	{
		DelaunayTriangle delaunayTriangle = new DelaunayTriangle(node.Prev.Point, node.Point, node.Next.Point);
		delaunayTriangle.MarkNeighbor(node.Prev.Triangle);
		delaunayTriangle.MarkNeighbor(node.Triangle);
		tcx.Triangles.Add(delaunayTriangle);
		node.Prev.Next = node.Next;
		node.Next.Prev = node.Prev;
		tcx.RemoveNode(node);
		if (!Legalize(tcx, delaunayTriangle))
		{
			tcx.MapTriangleToNodes(delaunayTriangle);
		}
	}

	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t)
	{
		for (int i = 0; i < 3; i++)
		{
			if (t.EdgeIsDelaunay[i])
			{
				continue;
			}
			DelaunayTriangle delaunayTriangle = t.Neighbors[i];
			if (delaunayTriangle == null)
			{
				continue;
			}
			TriangulationPoint triangulationPoint = t.Points[i];
			TriangulationPoint triangulationPoint2 = delaunayTriangle.OppositePoint(t, triangulationPoint);
			int index = delaunayTriangle.IndexOf(triangulationPoint2);
			if (delaunayTriangle.EdgeIsConstrained[index] || delaunayTriangle.EdgeIsDelaunay[index])
			{
				t.EdgeIsConstrained[i] = delaunayTriangle.EdgeIsConstrained[index];
			}
			else if (TriangulationUtil.SmartIncircle(triangulationPoint, t.PointCCWFrom(triangulationPoint), t.PointCWFrom(triangulationPoint), triangulationPoint2))
			{
				t.EdgeIsDelaunay[i] = true;
				delaunayTriangle.EdgeIsDelaunay[index] = true;
				RotateTrianglePair(t, triangulationPoint, delaunayTriangle, triangulationPoint2);
				if (!Legalize(tcx, t))
				{
					tcx.MapTriangleToNodes(t);
				}
				if (!Legalize(tcx, delaunayTriangle))
				{
					tcx.MapTriangleToNodes(delaunayTriangle);
				}
				t.EdgeIsDelaunay[i] = false;
				delaunayTriangle.EdgeIsDelaunay[index] = false;
				return true;
			}
		}
		return false;
	}

	private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op)
	{
		DelaunayTriangle delaunayTriangle = t.NeighborCCWFrom(p);
		DelaunayTriangle delaunayTriangle2 = t.NeighborCWFrom(p);
		DelaunayTriangle delaunayTriangle3 = ot.NeighborCCWFrom(op);
		DelaunayTriangle delaunayTriangle4 = ot.NeighborCWFrom(op);
		bool constrainedEdgeCCW = t.GetConstrainedEdgeCCW(p);
		bool constrainedEdgeCW = t.GetConstrainedEdgeCW(p);
		bool constrainedEdgeCCW2 = ot.GetConstrainedEdgeCCW(op);
		bool constrainedEdgeCW2 = ot.GetConstrainedEdgeCW(op);
		bool delaunayEdgeCCW = t.GetDelaunayEdgeCCW(p);
		bool delaunayEdgeCW = t.GetDelaunayEdgeCW(p);
		bool delaunayEdgeCCW2 = ot.GetDelaunayEdgeCCW(op);
		bool delaunayEdgeCW2 = ot.GetDelaunayEdgeCW(op);
		t.Legalize(p, op);
		ot.Legalize(op, p);
		ot.SetDelaunayEdgeCCW(p, delaunayEdgeCCW);
		t.SetDelaunayEdgeCW(p, delaunayEdgeCW);
		t.SetDelaunayEdgeCCW(op, delaunayEdgeCCW2);
		ot.SetDelaunayEdgeCW(op, delaunayEdgeCW2);
		ot.SetConstrainedEdgeCCW(p, constrainedEdgeCCW);
		t.SetConstrainedEdgeCW(p, constrainedEdgeCW);
		t.SetConstrainedEdgeCCW(op, constrainedEdgeCCW2);
		ot.SetConstrainedEdgeCW(op, constrainedEdgeCW2);
		t.Neighbors.Clear();
		ot.Neighbors.Clear();
		if (delaunayTriangle != null)
		{
			ot.MarkNeighbor(delaunayTriangle);
		}
		if (delaunayTriangle2 != null)
		{
			t.MarkNeighbor(delaunayTriangle2);
		}
		if (delaunayTriangle3 != null)
		{
			t.MarkNeighbor(delaunayTriangle3);
		}
		if (delaunayTriangle4 != null)
		{
			ot.MarkNeighbor(delaunayTriangle4);
		}
		t.MarkNeighbor(ot);
	}
}
public class DTSweepBasin
{
	public AdvancingFrontNode leftNode;

	public AdvancingFrontNode bottomNode;

	public AdvancingFrontNode rightNode;

	public double width;

	public bool leftHighest;
}
public class DTSweepConstraint : TriangulationConstraint
{
	public DTSweepConstraint(TriangulationPoint p1, TriangulationPoint p2)
	{
		P = p1;
		Q = p2;
		if (p1.Y > p2.Y)
		{
			Q = p1;
			P = p2;
		}
		else if (p1.Y == p2.Y)
		{
			if (p1.X > p2.X)
			{
				Q = p1;
				P = p2;
			}
			else
			{
				_ = p1.X;
				_ = p2.X;
			}
		}
		Q.AddEdge(this);
	}
}
public class DTSweepContext : TriangulationContext
{
	private readonly float ALPHA = 0.3f;

	public AdvancingFront Front;

	public DTSweepBasin Basin = new DTSweepBasin();

	public DTSweepEdgeEvent EdgeEvent = new DTSweepEdgeEvent();

	private DTSweepPointComparator _comparator = new DTSweepPointComparator();

	public TriangulationPoint Head { get; set; }

	public TriangulationPoint Tail { get; set; }

	public override bool IsDebugEnabled
	{
		get
		{
			return base.IsDebugEnabled;
		}
		protected set
		{
			if (value && base.DebugContext == null)
			{
				base.DebugContext = new DTSweepDebugContext(this);
			}
			base.IsDebugEnabled = value;
		}
	}

	public override TriangulationAlgorithm Algorithm => TriangulationAlgorithm.DTSweep;

	public DTSweepContext()
	{
		Clear();
	}

	public void RemoveFromList(DelaunayTriangle triangle)
	{
		Triangles.Remove(triangle);
	}

	public void MeshClean(DelaunayTriangle triangle)
	{
		MeshCleanReq(triangle);
	}

	private void MeshCleanReq(DelaunayTriangle triangle)
	{
		if (triangle == null || triangle.IsInterior)
		{
			return;
		}
		triangle.IsInterior = true;
		base.Triangulatable.AddTriangle(triangle);
		for (int i = 0; i < 3; i++)
		{
			if (!triangle.EdgeIsConstrained[i])
			{
				MeshCleanReq(triangle.Neighbors[i]);
			}
		}
	}

	public override void Clear()
	{
		base.Clear();
		Triangles.Clear();
	}

	public void AddNode(AdvancingFrontNode node)
	{
		Front.AddNode(node);
	}

	public void RemoveNode(AdvancingFrontNode node)
	{
		Front.RemoveNode(node);
	}

	public AdvancingFrontNode LocateNode(TriangulationPoint point)
	{
		return Front.LocateNode(point);
	}

	public void CreateAdvancingFront()
	{
		DelaunayTriangle delaunayTriangle = new DelaunayTriangle(Points[0], Tail, Head);
		Triangles.Add(delaunayTriangle);
		AdvancingFrontNode advancingFrontNode = new AdvancingFrontNode(delaunayTriangle.Points[1]);
		advancingFrontNode.Triangle = delaunayTriangle;
		AdvancingFrontNode advancingFrontNode2 = new AdvancingFrontNode(delaunayTriangle.Points[0]);
		advancingFrontNode2.Triangle = delaunayTriangle;
		AdvancingFrontNode tail = new AdvancingFrontNode(delaunayTriangle.Points[2]);
		Front = new AdvancingFront(advancingFrontNode, tail);
		Front.AddNode(advancingFrontNode2);
		Front.Head.Next = advancingFrontNode2;
		advancingFrontNode2.Next = Front.Tail;
		advancingFrontNode2.Prev = Front.Head;
		Front.Tail.Prev = advancingFrontNode2;
	}

	public void MapTriangleToNodes(DelaunayTriangle t)
	{
		for (int i = 0; i < 3; i++)
		{
			if (t.Neighbors[i] == null)
			{
				AdvancingFrontNode advancingFrontNode = Front.LocatePoint(t.PointCWFrom(t.Points[i]));
				if (advancingFrontNode != null)
				{
					advancingFrontNode.Triangle = t;
				}
			}
		}
	}

	public override void PrepareTriangulation(Triangulatable t)
	{
		base.PrepareTriangulation(t);
		double x;
		double num = (x = Points[0].X);
		double y;
		double num2 = (y = Points[0].Y);
		foreach (TriangulationPoint point in Points)
		{
			if (point.X > num)
			{
				num = point.X;
			}
			if (point.X < x)
			{
				x = point.X;
			}
			if (point.Y > num2)
			{
				num2 = point.Y;
			}
			if (point.Y < y)
			{
				y = point.Y;
			}
		}
		double num3 = (double)ALPHA * (num - x);
		double num4 = (double)ALPHA * (num2 - y);
		TriangulationPoint head = new TriangulationPoint(num + num3, y - num4);
		TriangulationPoint tail = new TriangulationPoint(x - num3, y - num4);
		Head = head;
		Tail = tail;
		Points.Sort(_comparator);
	}

	public void FinalizeTriangulation()
	{
		base.Triangulatable.AddTriangles(Triangles);
		Triangles.Clear();
	}

	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b)
	{
		return new DTSweepConstraint(a, b);
	}
}
public class DTSweepDebugContext : TriangulationDebugContext
{
	private DelaunayTriangle _primaryTriangle;

	private DelaunayTriangle _secondaryTriangle;

	private TriangulationPoint _activePoint;

	private AdvancingFrontNode _activeNode;

	private DTSweepConstraint _activeConstraint;

	public DelaunayTriangle PrimaryTriangle
	{
		get
		{
			return _primaryTriangle;
		}
		set
		{
			_primaryTriangle = value;
			_tcx.Update("set PrimaryTriangle");
		}
	}

	public DelaunayTriangle SecondaryTriangle
	{
		get
		{
			return _secondaryTriangle;
		}
		set
		{
			_secondaryTriangle = value;
			_tcx.Update("set SecondaryTriangle");
		}
	}

	public TriangulationPoint ActivePoint
	{
		get
		{
			return _activePoint;
		}
		set
		{
			_activePoint = value;
			_tcx.Update("set ActivePoint");
		}
	}

	public AdvancingFrontNode ActiveNode
	{
		get
		{
			return _activeNode;
		}
		set
		{
			_activeNode = value;
			_tcx.Update("set ActiveNode");
		}
	}

	public DTSweepConstraint ActiveConstraint
	{
		get
		{
			return _activeConstraint;
		}
		set
		{
			_activeConstraint = value;
			_tcx.Update("set ActiveConstraint");
		}
	}

	public bool IsDebugContext => true;

	public DTSweepDebugContext(DTSweepContext tcx)
		: base(tcx)
	{
	}

	public override void Clear()
	{
		PrimaryTriangle = null;
		SecondaryTriangle = null;
		ActivePoint = null;
		ActiveNode = null;
		ActiveConstraint = null;
	}
}
public class DTSweepEdgeEvent
{
	public DTSweepConstraint ConstrainedEdge;

	public bool Right;
}
public class DTSweepPointComparator : IComparer<TriangulationPoint>
{
	public int Compare(TriangulationPoint p1, TriangulationPoint p2)
	{
		if (p1.Y < p2.Y)
		{
			return -1;
		}
		if (p1.Y > p2.Y)
		{
			return 1;
		}
		if (p1.X < p2.X)
		{
			return -1;
		}
		if (p1.X > p2.X)
		{
			return 1;
		}
		return 0;
	}
}
public class PointOnEdgeException : NotImplementedException
{
	public readonly TriangulationPoint A;

	public readonly TriangulationPoint B;

	public readonly TriangulationPoint C;

	public PointOnEdgeException(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c)
		: base(message)
	{
		A = a;
		B = b;
		C = c;
	}
}
public enum Orientation
{
	CW,
	CCW,
	Collinear
}
public class ConstrainedPointSet : PointSet
{
	public int[] EdgeIndex { get; private set; }

	public override TriangulationMode TriangulationMode => TriangulationMode.Constrained;

	public ConstrainedPointSet(List<TriangulationPoint> points, int[] index)
		: base(points)
	{
		EdgeIndex = index;
	}

	public override void Prepare(TriangulationContext tcx)
	{
		base.Prepare(tcx);
		for (int i = 0; i < EdgeIndex.Length; i += 2)
		{
			tcx.NewConstraint(base.Points[EdgeIndex[i]], base.Points[EdgeIndex[i + 1]]);
		}
	}
}
public class PointSet : Triangulatable
{
	public IList<TriangulationPoint> Points { get; private set; }

	public IList<DelaunayTriangle> Triangles { get; private set; }

	public virtual TriangulationMode TriangulationMode => TriangulationMode.Unconstrained;

	public PointSet(List<TriangulationPoint> points)
	{
		Points = new List<TriangulationPoint>(points);
	}

	public void AddTriangle(DelaunayTriangle t)
	{
		Triangles.Add(t);
	}

	public void AddTriangles(IEnumerable<DelaunayTriangle> list)
	{
		foreach (DelaunayTriangle item in list)
		{
			Triangles.Add(item);
		}
	}

	public void ClearTriangles()
	{
		Triangles.Clear();
	}

	public virtual void Prepare(TriangulationContext tcx)
	{
		if (Triangles == null)
		{
			Triangles = new List<DelaunayTriangle>(Points.Count);
		}
		else
		{
			Triangles.Clear();
		}
		tcx.Points.AddRange(Points);
	}
}
public interface Triangulatable
{
	IList<TriangulationPoint> Points { get; }

	IList<DelaunayTriangle> Triangles { get; }

	TriangulationMode TriangulationMode { get; }

	void Prepare(TriangulationContext tcx);

	void AddTriangle(DelaunayTriangle t);

	void AddTriangles(IEnumerable<DelaunayTriangle> list);

	void ClearTriangles();
}
public enum TriangulationAlgorithm
{
	DTSweep
}
public class TriangulationConstraint
{
	public TriangulationPoint P;

	public TriangulationPoint Q;
}
public abstract class TriangulationContext
{
	public readonly List<DelaunayTriangle> Triangles = new List<DelaunayTriangle>();

	public readonly List<TriangulationPoint> Points = new List<TriangulationPoint>(200);

	public TriangulationDebugContext DebugContext { get; protected set; }

	public TriangulationMode TriangulationMode { get; protected set; }

	public Triangulatable Triangulatable { get; private set; }

	public int StepCount { get; private set; }

	public abstract TriangulationAlgorithm Algorithm { get; }

	public virtual bool IsDebugEnabled { get; protected set; }

	public DTSweepDebugContext DTDebugContext => DebugContext as DTSweepDebugContext;

	public void Done()
	{
		StepCount++;
	}

	public virtual void PrepareTriangulation(Triangulatable t)
	{
		Triangulatable = t;
		TriangulationMode = t.TriangulationMode;
		t.Prepare(this);
	}

	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b);

	public void Update(string message)
	{
	}

	public virtual void Clear()
	{
		Points.Clear();
		if (DebugContext != null)
		{
			DebugContext.Clear();
		}
		StepCount = 0;
	}
}
public abstract class TriangulationDebugContext
{
	protected TriangulationContext _tcx;

	public TriangulationDebugContext(TriangulationContext tcx)
	{
		_tcx = tcx;
	}

	public abstract void Clear();
}
public enum TriangulationMode
{
	Unconstrained,
	Constrained,
	Polygon
}
public class TriangulationPoint
{
	public const int INSERTED_INDEX = -1;

	public const int INVALID_INDEX = -2;

	public double X;

	public double Y;

	public int Index;

	public List<DTSweepConstraint> Edges { get; private set; }

	public float Xf
	{
		get
		{
			return (float)X;
		}
		set
		{
			X = value;
		}
	}

	public float Yf
	{
		get
		{
			return (float)Y;
		}
		set
		{
			Y = value;
		}
	}

	public bool HasEdges => Edges != null;

	public TriangulationPoint(double x, double y, int index = -1)
	{
		X = x;
		Y = y;
		Index = index;
	}

	public override string ToString()
	{
		return "[" + X + "," + Y + "]";
	}

	public void AddEdge(DTSweepConstraint e)
	{
		if (Edges == null)
		{
			Edges = new List<DTSweepConstraint>();
		}
		Edges.Add(e);
	}
}
public class TriangulationUtil
{
	public static double EPSILON = 1E-12;

	public static bool SmartIncircle(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd)
	{
		double x = pd.X;
		double y = pd.Y;
		double num = pa.X - x;
		double num2 = pa.Y - y;
		double num3 = pb.X - x;
		double num4 = pb.Y - y;
		double num5 = num * num4;
		double num6 = num3 * num2;
		double num7 = num5 - num6;
		if (num7 <= 0.0)
		{
			return false;
		}
		double num8 = pc.X - x;
		double num9 = pc.Y - y;
		double num10 = num8 * num2;
		double num11 = num * num9;
		double num12 = num10 - num11;
		if (num12 <= 0.0)
		{
			return false;
		}
		double num13 = num3 * num9;
		double num14 = num8 * num4;
		double num15 = num * num + num2 * num2;
		double num16 = num3 * num3 + num4 * num4;
		double num17 = num8 * num8 + num9 * num9;
		return num15 * (num13 - num14) + num16 * num12 + num17 * num7 > 0.0;
	}

	public static bool InScanArea(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd)
	{
		double x = pd.X;
		double y = pd.Y;
		double num = pa.X - x;
		double num2 = pa.Y - y;
		double num3 = pb.X - x;
		double num4 = pb.Y - y;
		double num5 = num * num4;
		double num6 = num3 * num2;
		if (num5 - num6 <= 0.0)
		{
			return false;
		}
		double num7 = pc.X - x;
		double num8 = pc.Y - y;
		double num9 = num7 * num2;
		double num10 = num * num8;
		if (num9 - num10 <= 0.0)
		{
			return false;
		}
		return true;
	}

	public static Orientation Orient2d(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc)
	{
		double num = (pa.X - pc.X) * (pb.Y - pc.Y);
		double num2 = (pa.Y - pc.Y) * (pb.X - pc.X);
		double num3 = num - num2;
		if (num3 > 0.0 - EPSILON && num3 < EPSILON)
		{
			return Orientation.Collinear;
		}
		if (num3 > 0.0)
		{
			return Orientation.CCW;
		}
		return Orientation.CW;
	}
}
public class PointGenerator
{
	private static readonly Random RNG = new Random();

	public static List<TriangulationPoint> UniformDistribution(int n, double scale)
	{
		List<TriangulationPoint> list = new List<TriangulationPoint>();
		for (int i = 0; i < n; i++)
		{
			list.Add(new TriangulationPoint(scale * (0.5 - RNG.NextDouble()), scale * (0.5 - RNG.NextDouble()), i));
		}
		return list;
	}

	public static List<TriangulationPoint> UniformGrid(int n, double scale)
	{
		double num = 0.0;
		double num2 = scale / (double)n;
		double num3 = 0.5 * scale;
		List<TriangulationPoint> list = new List<TriangulationPoint>();
		for (int i = 0; i < n + 1; i++)
		{
			num = num3 - (double)i * num2;
			for (int j = 0; j < n + 1; j++)
			{
				list.Add(new TriangulationPoint(num, num3 - (double)j * num2, i));
			}
		}
		return list;
	}
}
public class PolygonGenerator
{
	private static readonly Random RNG = new Random();

	private static double PI_2 = Math.PI * 2.0;

	public static Polygon RandomCircleSweep(double scale, int vertexCount)
	{
		double num = scale / 4.0;
		PolygonPoint[] array = new PolygonPoint[vertexCount];
		for (int i = 0; i < vertexCount; i++)
		{
			do
			{
				num = ((i % 250 == 0) ? (num + scale / 2.0 * (0.5 - RNG.NextDouble())) : ((i % 50 != 0) ? (num + 25.0 * scale / (double)vertexCount * (0.5 - RNG.NextDouble())) : (num + scale / 5.0 * (0.5 - RNG.NextDouble()))));
				num = ((num > scale / 2.0) ? (scale / 2.0) : num);
				num = ((num < scale / 10.0) ? (scale / 10.0) : num);
			}
			while (num < scale / 10.0 || num > scale / 2.0);
			PolygonPoint polygonPoint = new PolygonPoint(num * Math.Cos(PI_2 * (double)i / (double)vertexCount), num * Math.Sin(PI_2 * (double)i / (double)vertexCount), i);
			array[i] = polygonPoint;
		}
		return new Polygon(array);
	}

	public static Polygon RandomCircleSweep2(double scale, int vertexCount)
	{
		double num = scale / 4.0;
		PolygonPoint[] array = new PolygonPoint[vertexCount];
		for (int i = 0; i < vertexCount; i++)
		{
			do
			{
				num += scale / 5.0 * (0.5 - RNG.NextDouble());
				num = ((num > scale / 2.0) ? (scale / 2.0) : num);
				num = ((num < scale / 10.0) ? (scale / 10.0) : num);
			}
			while (num < scale / 10.0 || num > scale / 2.0);
			PolygonPoint polygonPoint = new PolygonPoint(num * Math.Cos(PI_2 * (double)i / (double)vertexCount), num * Math.Sin(PI_2 * (double)i / (double)vertexCount), i);
			array[i] = polygonPoint;
		}
		return new Polygon(array);
	}
}
public struct FixedArray3<T> : IEnumerable<T>, IEnumerable where T : class
{
	public T _0;

	public T _1;

	public T _2;

	public T this[int index]
	{
		get
		{
			return index switch
			{
				0 => _0, 
				1 => _1, 
				2 => _2, 
				_ => throw new IndexOutOfRangeException(), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				_0 = value;
				break;
			case 1:
				_1 = value;
				break;
			case 2:
				_2 = value;
				break;
			default:
				throw new IndexOutOfRangeException();
			}
		}
	}

	public bool Contains(T value)
	{
		for (int i = 0; i < 3; i++)
		{
			if (this[i] == value)
			{
				return true;
			}
		}
		return false;
	}

	public int IndexOf(T value)
	{
		for (int i = 0; i < 3; i++)
		{
			if (this[i] == value)
			{
				return i;
			}
		}
		return -1;
	}

	public void Clear()
	{
		_0 = (_1 = (_2 = null));
	}

	public void Clear(T value)
	{
		for (int i = 0; i < 3; i++)
		{
			if (this[i] == value)
			{
				this[i] = null;
			}
		}
	}

	private IEnumerable<T> Enumerate()
	{
		int i = 0;
		while (i < 3)
		{
			yield return this[i];
			int num = i + 1;
			i = num;
		}
	}

	public IEnumerator<T> GetEnumerator()
	{
		return Enumerate().GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
public struct FixedBitArray3 : IEnumerable<bool>, IEnumerable
{
	public bool _0;

	public bool _1;

	public bool _2;

	public bool this[int index]
	{
		get
		{
			return index switch
			{
				0 => _0, 
				1 => _1, 
				2 => _2, 
				_ => throw new IndexOutOfRangeException(), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				_0 = value;
				break;
			case 1:
				_1 = value;
				break;
			case 2:
				_2 = value;
				break;
			default:
				throw new IndexOutOfRangeException();
			}
		}
	}

	public bool Contains(bool value)
	{
		for (int i = 0; i < 3; i++)
		{
			if (this[i] == value)
			{
				return true;
			}
		}
		return false;
	}

	public int IndexOf(bool value)
	{
		for (int i = 0; i < 3; i++)
		{
			if (this[i] == value)
			{
				return i;
			}
		}
		return -1;
	}

	public void Clear()
	{
		_0 = (_1 = (_2 = false));
	}

	public void Clear(bool value)
	{
		for (int i = 0; i < 3; i++)
		{
			if (this[i] == value)
			{
				this[i] = false;
			}
		}
	}

	private IEnumerable<bool> Enumerate()
	{
		int i = 0;
		while (i < 3)
		{
			yield return this[i];
			int num = i + 1;
			i = num;
		}
	}

	public IEnumerator<bool> GetEnumerator()
	{
		return Enumerate().GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
