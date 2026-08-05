using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using TriangleNet.Algorithm;
using TriangleNet.Data;
using TriangleNet.Geometry;
using TriangleNet.IO;
using TriangleNet.Log;
using TriangleNet.Smoothing;
using TriangleNet.Tools;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyTitle("Triangle")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Triangle")]
[assembly: AssemblyCopyright("Copyright ©  2012")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("96a540d0-1772-4bed-8d25-ef5fa23cd1bc")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyVersion("1.0.0.0")]
namespace TriangleNet
{
	internal class BadTriQueue
	{
		private static readonly double SQRT2 = 1.4142135623730951;

		private BadTriangle[] queuefront;

		private BadTriangle[] queuetail;

		private int[] nextnonemptyq;

		private int firstnonemptyq;

		private int count;

		public int Count => count;

		public BadTriQueue()
		{
			queuefront = new BadTriangle[4096];
			queuetail = new BadTriangle[4096];
			nextnonemptyq = new int[4096];
			firstnonemptyq = -1;
			count = 0;
		}

		public void Enqueue(BadTriangle badtri)
		{
			count++;
			double num;
			int num2;
			if (badtri.key >= 1.0)
			{
				num = badtri.key;
				num2 = 1;
			}
			else
			{
				num = 1.0 / badtri.key;
				num2 = 0;
			}
			int num3 = 0;
			while (num > 2.0)
			{
				int num4 = 1;
				double num5 = 0.5;
				while (num * num5 * num5 > 1.0)
				{
					num4 *= 2;
					num5 *= num5;
				}
				num3 += num4;
				num *= num5;
			}
			num3 = 2 * num3 + ((num > SQRT2) ? 1 : 0);
			int num6 = ((num2 <= 0) ? (2048 + num3) : (2047 - num3));
			if (queuefront[num6] == null)
			{
				if (num6 > firstnonemptyq)
				{
					nextnonemptyq[num6] = firstnonemptyq;
					firstnonemptyq = num6;
				}
				else
				{
					int i;
					for (i = num6 + 1; queuefront[i] == null; i++)
					{
					}
					nextnonemptyq[num6] = nextnonemptyq[i];
					nextnonemptyq[i] = num6;
				}
				queuefront[num6] = badtri;
			}
			else
			{
				queuetail[num6].nexttriang = badtri;
			}
			queuetail[num6] = badtri;
			badtri.nexttriang = null;
		}

		public void Enqueue(ref Otri enqtri, double minedge, Vertex enqapex, Vertex enqorg, Vertex enqdest)
		{
			BadTriangle badTriangle = new BadTriangle();
			badTriangle.poortri = enqtri;
			badTriangle.key = minedge;
			badTriangle.triangapex = enqapex;
			badTriangle.triangorg = enqorg;
			badTriangle.triangdest = enqdest;
			Enqueue(badTriangle);
		}

		public BadTriangle Dequeue()
		{
			if (firstnonemptyq < 0)
			{
				return null;
			}
			count--;
			BadTriangle badTriangle = queuefront[firstnonemptyq];
			queuefront[firstnonemptyq] = badTriangle.nexttriang;
			if (badTriangle == queuetail[firstnonemptyq])
			{
				firstnonemptyq = nextnonemptyq[firstnonemptyq];
			}
			return badTriangle;
		}
	}
	public class Behavior
	{
		private bool poly;

		private bool quality;

		private bool varArea;

		private bool convex;

		private bool jettison;

		private bool boundaryMarkers = true;

		private bool noHoles;

		private bool conformDel;

		private TriangulationAlgorithm algorithm;

		private Func<ITriangle, double, bool> usertest;

		private int noBisect;

		private int steiner = -1;

		private double minAngle;

		private double maxAngle;

		private double maxArea = -1.0;

		internal bool fixedArea;

		internal bool useSegments = true;

		internal bool useRegions;

		internal double goodAngle;

		internal double maxGoodAngle;

		internal double offconstant;

		public static bool NoExact { get; set; }

		public static bool Verbose { get; set; }

		public bool Quality
		{
			get
			{
				return quality;
			}
			set
			{
				quality = value;
				if (quality)
				{
					Update();
				}
			}
		}

		public double MinAngle
		{
			get
			{
				return minAngle;
			}
			set
			{
				minAngle = value;
				Update();
			}
		}

		public double MaxAngle
		{
			get
			{
				return maxAngle;
			}
			set
			{
				maxAngle = value;
				Update();
			}
		}

		public double MaxArea
		{
			get
			{
				return maxArea;
			}
			set
			{
				maxArea = value;
				fixedArea = value > 0.0;
			}
		}

		public bool VarArea
		{
			get
			{
				return varArea;
			}
			set
			{
				varArea = value;
			}
		}

		public bool Poly
		{
			get
			{
				return poly;
			}
			set
			{
				poly = value;
			}
		}

		public Func<ITriangle, double, bool> UserTest
		{
			get
			{
				return usertest;
			}
			set
			{
				usertest = value;
			}
		}

		public bool Convex
		{
			get
			{
				return convex;
			}
			set
			{
				convex = value;
			}
		}

		public bool ConformingDelaunay
		{
			get
			{
				return conformDel;
			}
			set
			{
				conformDel = value;
			}
		}

		public TriangulationAlgorithm Algorithm
		{
			get
			{
				return algorithm;
			}
			set
			{
				algorithm = value;
			}
		}

		public int NoBisect
		{
			get
			{
				return noBisect;
			}
			set
			{
				noBisect = value;
				if (noBisect < 0 || noBisect > 2)
				{
					noBisect = 0;
				}
			}
		}

		public int SteinerPoints
		{
			get
			{
				return steiner;
			}
			set
			{
				steiner = value;
			}
		}

		public bool UseBoundaryMarkers
		{
			get
			{
				return boundaryMarkers;
			}
			set
			{
				boundaryMarkers = value;
			}
		}

		public bool NoHoles
		{
			get
			{
				return noHoles;
			}
			set
			{
				noHoles = value;
			}
		}

		public bool Jettison
		{
			get
			{
				return jettison;
			}
			set
			{
				jettison = value;
			}
		}

		public Behavior(bool quality, double minAngle)
		{
			if (quality)
			{
				this.quality = true;
				this.minAngle = minAngle;
				Update();
			}
		}

		public Behavior()
			: this(quality: false, 20.0)
		{
		}

		private void Update()
		{
			quality = true;
			if (minAngle < 0.0 || minAngle > 60.0)
			{
				minAngle = 0.0;
				quality = false;
				SimpleLog.Instance.Warning("Invalid quality option (minimum angle).", "Mesh.Behavior");
			}
			if ((maxAngle != 0.0 && maxAngle < 90.0) || maxAngle > 180.0)
			{
				maxAngle = 0.0;
				quality = false;
				SimpleLog.Instance.Warning("Invalid quality option (maximum angle).", "Mesh.Behavior");
			}
			useSegments = Poly || Quality || Convex;
			goodAngle = Math.Cos(MinAngle * Math.PI / 180.0);
			maxGoodAngle = Math.Cos(MaxAngle * Math.PI / 180.0);
			if (goodAngle == 1.0)
			{
				offconstant = 0.0;
			}
			else
			{
				offconstant = 0.475 * Math.Sqrt((1.0 + goodAngle) / (1.0 - goodAngle));
			}
			goodAngle *= goodAngle;
		}
	}
	internal class ConstraintMesher
	{
		private Mesh mesh;

		private Behavior behavior;

		private TriangleLocator locator;

		private List<Triangle> viri;

		private ILog<SimpleLogItem> logger;

		public ConstraintMesher(Mesh mesh)
		{
			this.mesh = mesh;
			behavior = mesh.behavior;
			locator = mesh.locator;
			viri = new List<Triangle>();
			logger = SimpleLog.Instance;
		}

		public void CarveHoles()
		{
			Otri searchtri = default(Otri);
			Triangle[] array = null;
			if (!mesh.behavior.Convex)
			{
				InfectHull();
			}
			if (!mesh.behavior.NoHoles)
			{
				foreach (Point hole in mesh.holes)
				{
					if (mesh.bounds.Contains(hole))
					{
						searchtri.triangle = Mesh.dummytri;
						searchtri.orient = 0;
						searchtri.SymSelf();
						Vertex pa = searchtri.Org();
						Vertex pb = searchtri.Dest();
						if (Primitives.CounterClockwise(pa, pb, hole) > 0.0 && mesh.locator.Locate(hole, ref searchtri) != LocateResult.Outside && !searchtri.IsInfected())
						{
							searchtri.Infect();
							viri.Add(searchtri.triangle);
						}
					}
				}
			}
			if (mesh.regions.Count > 0)
			{
				int num = 0;
				array = new Triangle[mesh.regions.Count];
				foreach (RegionPointer region in mesh.regions)
				{
					array[num] = Mesh.dummytri;
					if (mesh.bounds.Contains(region.point))
					{
						searchtri.triangle = Mesh.dummytri;
						searchtri.orient = 0;
						searchtri.SymSelf();
						Vertex pa2 = searchtri.Org();
						Vertex pb = searchtri.Dest();
						if (Primitives.CounterClockwise(pa2, pb, region.point) > 0.0 && mesh.locator.Locate(region.point, ref searchtri) != LocateResult.Outside && !searchtri.IsInfected())
						{
							array[num] = searchtri.triangle;
							array[num].region = region.id;
						}
					}
					num++;
				}
			}
			if (viri.Count > 0)
			{
				Plague();
			}
			if (array != null)
			{
				RegionIterator regionIterator = new RegionIterator(mesh);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != Mesh.dummytri && !Otri.IsDead(array[i]))
					{
						regionIterator.Process(array[i]);
					}
				}
			}
			viri.Clear();
		}

		public void FormSkeleton(InputGeometry input)
		{
			mesh.insegments = 0;
			if (behavior.Poly)
			{
				if (mesh.triangles.Count == 0)
				{
					return;
				}
				if (input.HasSegments)
				{
					mesh.MakeVertexMap();
				}
				int num = 0;
				foreach (Edge segment in input.segments)
				{
					mesh.insegments++;
					int p = segment.P0;
					int p2 = segment.P1;
					num = segment.Boundary;
					if (p < 0 || p >= mesh.invertices)
					{
						if (Behavior.Verbose)
						{
							logger.Warning("Invalid first endpoint of segment.", "Mesh.FormSkeleton().1");
						}
						continue;
					}
					if (p2 < 0 || p2 >= mesh.invertices)
					{
						if (Behavior.Verbose)
						{
							logger.Warning("Invalid second endpoint of segment.", "Mesh.FormSkeleton().2");
						}
						continue;
					}
					Vertex vertex = mesh.vertices[p];
					Vertex vertex2 = mesh.vertices[p2];
					if (vertex.x == vertex2.x && vertex.y == vertex2.y)
					{
						if (Behavior.Verbose)
						{
							logger.Warning("Endpoints of segment (IDs " + p + "/" + p2 + ") are coincident.", "Mesh.FormSkeleton()");
						}
					}
					else
					{
						InsertSegment(vertex, vertex2, num);
					}
				}
			}
			if (behavior.Convex || !behavior.Poly)
			{
				MarkHull();
			}
		}

		private void InfectHull()
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Osub os = default(Osub);
			o.triangle = Mesh.dummytri;
			o.orient = 0;
			o.SymSelf();
			o.Copy(ref o3);
			do
			{
				if (!o.IsInfected())
				{
					o.SegPivot(ref os);
					if (os.seg == Mesh.dummysub)
					{
						if (!o.IsInfected())
						{
							o.Infect();
							viri.Add(o.triangle);
						}
					}
					else if (os.seg.boundary == 0)
					{
						os.seg.boundary = 1;
						Vertex vertex = o.Org();
						Vertex vertex2 = o.Dest();
						if (vertex.mark == 0)
						{
							vertex.mark = 1;
						}
						if (vertex2.mark == 0)
						{
							vertex2.mark = 1;
						}
					}
				}
				o.LnextSelf();
				o.Oprev(ref o2);
				while (o2.triangle != Mesh.dummytri)
				{
					o2.Copy(ref o);
					o.Oprev(ref o2);
				}
			}
			while (!o.Equal(o3));
		}

		private void Plague()
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Osub os = default(Osub);
			for (int i = 0; i < viri.Count; i++)
			{
				o.triangle = viri[i];
				o.Uninfect();
				o.orient = 0;
				while (o.orient < 3)
				{
					o.Sym(ref o2);
					o.SegPivot(ref os);
					if (o2.triangle == Mesh.dummytri || o2.IsInfected())
					{
						if (os.seg != Mesh.dummysub)
						{
							mesh.SubsegDealloc(os.seg);
							if (o2.triangle != Mesh.dummytri)
							{
								o2.Uninfect();
								o2.SegDissolve();
								o2.Infect();
							}
						}
					}
					else if (os.seg == Mesh.dummysub)
					{
						o2.Infect();
						viri.Add(o2.triangle);
					}
					else
					{
						os.TriDissolve();
						if (os.seg.boundary == 0)
						{
							os.seg.boundary = 1;
						}
						Vertex vertex = o2.Org();
						Vertex vertex2 = o2.Dest();
						if (vertex.mark == 0)
						{
							vertex.mark = 1;
						}
						if (vertex2.mark == 0)
						{
							vertex2.mark = 1;
						}
					}
					o.orient++;
				}
				o.Infect();
			}
			foreach (Triangle virus in viri)
			{
				o.triangle = virus;
				o.orient = 0;
				while (o.orient < 3)
				{
					Vertex vertex3 = o.Org();
					if (vertex3 != null)
					{
						bool flag = true;
						o.SetOrg(null);
						o.Onext(ref o2);
						while (o2.triangle != Mesh.dummytri && !o2.Equal(o))
						{
							if (o2.IsInfected())
							{
								o2.SetOrg(null);
							}
							else
							{
								flag = false;
							}
							o2.OnextSelf();
						}
						if (o2.triangle == Mesh.dummytri)
						{
							o.Oprev(ref o2);
							while (o2.triangle != Mesh.dummytri)
							{
								if (o2.IsInfected())
								{
									o2.SetOrg(null);
								}
								else
								{
									flag = false;
								}
								o2.OprevSelf();
							}
						}
						if (flag)
						{
							vertex3.type = VertexType.UndeadVertex;
							mesh.undeads++;
						}
					}
					o.orient++;
				}
				o.orient = 0;
				while (o.orient < 3)
				{
					o.Sym(ref o2);
					if (o2.triangle == Mesh.dummytri)
					{
						mesh.hullsize--;
					}
					else
					{
						o2.Dissolve();
						mesh.hullsize++;
					}
					o.orient++;
				}
				mesh.TriangleDealloc(o.triangle);
			}
			viri.Clear();
		}

		private FindDirectionResult FindDirection(ref Otri searchtri, Vertex searchpoint)
		{
			Otri o = default(Otri);
			Vertex vertex = searchtri.Org();
			Vertex pc = searchtri.Dest();
			Vertex pc2 = searchtri.Apex();
			double num = Primitives.CounterClockwise(searchpoint, vertex, pc2);
			bool flag = num > 0.0;
			double num2 = Primitives.CounterClockwise(vertex, searchpoint, pc);
			bool flag2 = num2 > 0.0;
			if (flag && flag2)
			{
				searchtri.Onext(ref o);
				if (o.triangle == Mesh.dummytri)
				{
					flag = false;
				}
				else
				{
					flag2 = false;
				}
			}
			while (flag)
			{
				searchtri.OnextSelf();
				if (searchtri.triangle == Mesh.dummytri)
				{
					logger.Error("Unable to find a triangle on path.", "Mesh.FindDirection().1");
					throw new Exception("Unable to find a triangle on path.");
				}
				pc2 = searchtri.Apex();
				num2 = num;
				num = Primitives.CounterClockwise(searchpoint, vertex, pc2);
				flag = num > 0.0;
			}
			while (flag2)
			{
				searchtri.OprevSelf();
				if (searchtri.triangle == Mesh.dummytri)
				{
					logger.Error("Unable to find a triangle on path.", "Mesh.FindDirection().2");
					throw new Exception("Unable to find a triangle on path.");
				}
				pc = searchtri.Dest();
				num = num2;
				num2 = Primitives.CounterClockwise(vertex, searchpoint, pc);
				flag2 = num2 > 0.0;
			}
			if (num == 0.0)
			{
				return FindDirectionResult.Leftcollinear;
			}
			if (num2 == 0.0)
			{
				return FindDirectionResult.Rightcollinear;
			}
			return FindDirectionResult.Within;
		}

		private void SegmentIntersection(ref Otri splittri, ref Osub splitsubseg, Vertex endpoint2)
		{
			Osub o = default(Osub);
			Vertex vertex = splittri.Apex();
			Vertex vertex2 = splittri.Org();
			Vertex vertex3 = splittri.Dest();
			double num = vertex3.x - vertex2.x;
			double num2 = vertex3.y - vertex2.y;
			double num3 = endpoint2.x - vertex.x;
			double num4 = endpoint2.y - vertex.y;
			double num5 = vertex2.x - endpoint2.x;
			double num6 = vertex2.y - endpoint2.y;
			double num7 = num2 * num3 - num * num4;
			if (num7 == 0.0)
			{
				logger.Error("Attempt to find intersection of parallel segments.", "Mesh.SegmentIntersection()");
				throw new Exception("Attempt to find intersection of parallel segments.");
			}
			double num8 = (num4 * num5 - num3 * num6) / num7;
			Vertex vertex4 = new Vertex(vertex2.x + num8 * (vertex3.x - vertex2.x), vertex2.y + num8 * (vertex3.y - vertex2.y), splitsubseg.seg.boundary, mesh.nextras);
			vertex4.hash = mesh.hash_vtx++;
			vertex4.id = vertex4.hash;
			for (int i = 0; i < mesh.nextras; i++)
			{
				vertex4.attributes[i] = vertex2.attributes[i] + num8 * (vertex3.attributes[i] - vertex2.attributes[i]);
			}
			mesh.vertices.Add(vertex4.hash, vertex4);
			if (mesh.InsertVertex(vertex4, ref splittri, ref splitsubseg, segmentflaws: false, triflaws: false) != InsertVertexResult.Successful)
			{
				logger.Error("Failure to split a segment.", "Mesh.SegmentIntersection()");
				throw new Exception("Failure to split a segment.");
			}
			vertex4.tri = splittri;
			if (mesh.steinerleft > 0)
			{
				mesh.steinerleft--;
			}
			splitsubseg.SymSelf();
			splitsubseg.Pivot(ref o);
			splitsubseg.Dissolve();
			o.Dissolve();
			do
			{
				splitsubseg.SetSegOrg(vertex4);
				splitsubseg.NextSelf();
			}
			while (splitsubseg.seg != Mesh.dummysub);
			do
			{
				o.SetSegOrg(vertex4);
				o.NextSelf();
			}
			while (o.seg != Mesh.dummysub);
			FindDirection(ref splittri, vertex);
			Vertex vertex5 = splittri.Dest();
			Vertex vertex6 = splittri.Apex();
			if (vertex6.x == vertex.x && vertex6.y == vertex.y)
			{
				splittri.OnextSelf();
			}
			else if (vertex5.x != vertex.x || vertex5.y != vertex.y)
			{
				logger.Error("Topological inconsistency after splitting a segment.", "Mesh.SegmentIntersection()");
				throw new Exception("Topological inconsistency after splitting a segment.");
			}
		}

		private bool ScoutSegment(ref Otri searchtri, Vertex endpoint2, int newmark)
		{
			Otri o = default(Otri);
			Osub os = default(Osub);
			FindDirectionResult findDirectionResult = FindDirection(ref searchtri, endpoint2);
			Vertex vertex = searchtri.Dest();
			Vertex vertex2 = searchtri.Apex();
			if ((vertex2.x == endpoint2.x && vertex2.y == endpoint2.y) || (vertex.x == endpoint2.x && vertex.y == endpoint2.y))
			{
				if (vertex2.x == endpoint2.x && vertex2.y == endpoint2.y)
				{
					searchtri.LprevSelf();
				}
				mesh.InsertSubseg(ref searchtri, newmark);
				return true;
			}
			switch (findDirectionResult)
			{
			case FindDirectionResult.Leftcollinear:
				searchtri.LprevSelf();
				mesh.InsertSubseg(ref searchtri, newmark);
				return ScoutSegment(ref searchtri, endpoint2, newmark);
			case FindDirectionResult.Rightcollinear:
				mesh.InsertSubseg(ref searchtri, newmark);
				searchtri.LnextSelf();
				return ScoutSegment(ref searchtri, endpoint2, newmark);
			default:
				searchtri.Lnext(ref o);
				o.SegPivot(ref os);
				if (os.seg == Mesh.dummysub)
				{
					return false;
				}
				SegmentIntersection(ref o, ref os, endpoint2);
				o.Copy(ref searchtri);
				mesh.InsertSubseg(ref searchtri, newmark);
				return ScoutSegment(ref searchtri, endpoint2, newmark);
			}
		}

		private void DelaunayFixup(ref Otri fixuptri, bool leftside)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Osub os = default(Osub);
			fixuptri.Lnext(ref o);
			o.Sym(ref o2);
			if (o2.triangle == Mesh.dummytri)
			{
				return;
			}
			o.SegPivot(ref os);
			if (os.seg != Mesh.dummysub)
			{
				return;
			}
			Vertex vertex = o.Apex();
			Vertex vertex2 = o.Org();
			Vertex vertex3 = o.Dest();
			Vertex vertex4 = o2.Apex();
			if (leftside)
			{
				if (Primitives.CounterClockwise(vertex, vertex2, vertex4) <= 0.0)
				{
					return;
				}
			}
			else if (Primitives.CounterClockwise(vertex4, vertex3, vertex) <= 0.0)
			{
				return;
			}
			if (!(Primitives.CounterClockwise(vertex3, vertex2, vertex4) > 0.0) || !(Primitives.InCircle(vertex2, vertex4, vertex3, vertex) <= 0.0))
			{
				mesh.Flip(ref o);
				fixuptri.LprevSelf();
				DelaunayFixup(ref fixuptri, leftside);
				DelaunayFixup(ref o2, leftside);
			}
		}

		private void ConstrainedEdge(ref Otri starttri, Vertex endpoint2, int newmark)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Osub os = default(Osub);
			Vertex pa = starttri.Org();
			starttri.Lnext(ref o);
			mesh.Flip(ref o);
			bool flag = false;
			bool flag2 = false;
			do
			{
				Vertex vertex = o.Org();
				if (vertex.x == endpoint2.x && vertex.y == endpoint2.y)
				{
					o.Oprev(ref o2);
					DelaunayFixup(ref o, leftside: false);
					DelaunayFixup(ref o2, leftside: true);
					flag2 = true;
					continue;
				}
				double num = Primitives.CounterClockwise(pa, endpoint2, vertex);
				if (num == 0.0)
				{
					flag = true;
					o.Oprev(ref o2);
					DelaunayFixup(ref o, leftside: false);
					DelaunayFixup(ref o2, leftside: true);
					flag2 = true;
					continue;
				}
				if (num > 0.0)
				{
					o.Oprev(ref o2);
					DelaunayFixup(ref o2, leftside: true);
					o.LprevSelf();
				}
				else
				{
					DelaunayFixup(ref o, leftside: false);
					o.OprevSelf();
				}
				o.SegPivot(ref os);
				if (os.seg == Mesh.dummysub)
				{
					mesh.Flip(ref o);
					continue;
				}
				flag = true;
				SegmentIntersection(ref o, ref os, endpoint2);
				flag2 = true;
			}
			while (!flag2);
			mesh.InsertSubseg(ref o, newmark);
			if (flag && !ScoutSegment(ref o, endpoint2, newmark))
			{
				ConstrainedEdge(ref o, endpoint2, newmark);
			}
		}

		private void InsertSegment(Vertex endpoint1, Vertex endpoint2, int newmark)
		{
			Otri otri = default(Otri);
			Otri otri2 = default(Otri);
			Vertex vertex = null;
			otri = endpoint1.tri;
			if (otri.triangle != null)
			{
				vertex = otri.Org();
			}
			if (vertex != endpoint1)
			{
				otri.triangle = Mesh.dummytri;
				otri.orient = 0;
				otri.SymSelf();
				if (locator.Locate(endpoint1, ref otri) != LocateResult.OnVertex)
				{
					logger.Error("Unable to locate PSLG vertex in triangulation.", "Mesh.InsertSegment().1");
					throw new Exception("Unable to locate PSLG vertex in triangulation.");
				}
			}
			locator.Update(ref otri);
			if (ScoutSegment(ref otri, endpoint2, newmark))
			{
				return;
			}
			endpoint1 = otri.Org();
			vertex = null;
			otri2 = endpoint2.tri;
			if (otri2.triangle != null)
			{
				vertex = otri2.Org();
			}
			if (vertex != endpoint2)
			{
				otri2.triangle = Mesh.dummytri;
				otri2.orient = 0;
				otri2.SymSelf();
				if (locator.Locate(endpoint2, ref otri2) != LocateResult.OnVertex)
				{
					logger.Error("Unable to locate PSLG vertex in triangulation.", "Mesh.InsertSegment().2");
					throw new Exception("Unable to locate PSLG vertex in triangulation.");
				}
			}
			locator.Update(ref otri2);
			if (!ScoutSegment(ref otri2, endpoint1, newmark))
			{
				endpoint2 = otri2.Org();
				ConstrainedEdge(ref otri, endpoint2, newmark);
			}
		}

		private void MarkHull()
		{
			Otri tri = default(Otri);
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			tri.triangle = Mesh.dummytri;
			tri.orient = 0;
			tri.SymSelf();
			tri.Copy(ref o2);
			do
			{
				mesh.InsertSubseg(ref tri, 1);
				tri.LnextSelf();
				tri.Oprev(ref o);
				while (o.triangle != Mesh.dummytri)
				{
					o.Copy(ref tri);
					tri.Oprev(ref o);
				}
			}
			while (!tri.Equal(o2));
		}
	}
	public static class MeshValidator
	{
		public static bool IsConsistent(Mesh mesh)
		{
			Otri otri = default(Otri);
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			ILog<SimpleLogItem> instance = SimpleLog.Instance;
			bool noExact = Behavior.NoExact;
			Behavior.NoExact = false;
			int num = 0;
			foreach (Triangle value in mesh.triangles.Values)
			{
				otri.triangle = value;
				otri.orient = 0;
				while (otri.orient < 3)
				{
					Vertex vertex = otri.Org();
					Vertex vertex2 = otri.Dest();
					if (otri.orient == 0)
					{
						Vertex pc = otri.Apex();
						if (Primitives.CounterClockwise(vertex, vertex2, pc) <= 0.0)
						{
							if (Behavior.Verbose)
							{
								instance.Warning("Triangle is flat or inverted.", "Quality.CheckMesh()");
							}
							num++;
						}
					}
					otri.Sym(ref o);
					if (o.triangle != Mesh.dummytri)
					{
						o.Sym(ref o2);
						if (otri.triangle != o2.triangle || otri.orient != o2.orient)
						{
							if (otri.triangle == o2.triangle && Behavior.Verbose)
							{
								instance.Warning("Asymmetric triangle-triangle bond: (Right triangle, wrong orientation)", "Quality.CheckMesh()");
							}
							num++;
						}
						Vertex vertex3 = o.Org();
						Vertex vertex4 = o.Dest();
						if (vertex != vertex4 || vertex2 != vertex3)
						{
							if (Behavior.Verbose)
							{
								instance.Warning("Mismatched edge coordinates between two triangles.", "Quality.CheckMesh()");
							}
							num++;
						}
					}
					otri.orient++;
				}
			}
			mesh.MakeVertexMap();
			foreach (Vertex value2 in mesh.vertices.Values)
			{
				if (value2.tri.triangle == null && Behavior.Verbose)
				{
					instance.Warning("Vertex (ID " + value2.id + ") not connected to mesh (duplicate input vertex?)", "Quality.CheckMesh()");
				}
			}
			Behavior.NoExact = noExact;
			return num == 0;
		}

		public static bool IsDelaunay(Mesh mesh)
		{
			return IsDelaunay(mesh, constrained: false);
		}

		public static bool IsConstrainedDelaunay(Mesh mesh)
		{
			return IsDelaunay(mesh, constrained: true);
		}

		private static bool IsDelaunay(Mesh mesh, bool constrained)
		{
			Otri otri = default(Otri);
			Otri o = default(Otri);
			Osub os = default(Osub);
			ILog<SimpleLogItem> instance = SimpleLog.Instance;
			bool noExact = Behavior.NoExact;
			Behavior.NoExact = false;
			int num = 0;
			Vertex infvertex = mesh.infvertex1;
			Vertex infvertex2 = mesh.infvertex2;
			Vertex infvertex3 = mesh.infvertex3;
			foreach (Triangle value in mesh.triangles.Values)
			{
				otri.triangle = value;
				otri.orient = 0;
				while (otri.orient < 3)
				{
					Vertex vertex = otri.Org();
					Vertex vertex2 = otri.Dest();
					Vertex vertex3 = otri.Apex();
					otri.Sym(ref o);
					Vertex vertex4 = o.Apex();
					bool flag = otri.triangle.id < o.triangle.id && !Otri.IsDead(o.triangle) && o.triangle != Mesh.dummytri && vertex != infvertex && vertex != infvertex2 && vertex != infvertex3 && vertex2 != infvertex && vertex2 != infvertex2 && vertex2 != infvertex3 && vertex3 != infvertex && vertex3 != infvertex2 && vertex3 != infvertex3 && vertex4 != infvertex && vertex4 != infvertex2 && vertex4 != infvertex3;
					if (constrained && mesh.checksegments && flag)
					{
						otri.SegPivot(ref os);
						if (os.seg != Mesh.dummysub)
						{
							flag = false;
						}
					}
					if (flag && Primitives.NonRegular(vertex, vertex2, vertex3, vertex4) > 0.0)
					{
						if (Behavior.Verbose)
						{
							instance.Warning($"Non-regular pair of triangles found (IDs {otri.triangle.id}/{o.triangle.id}).", "Quality.CheckDelaunay()");
						}
						num++;
					}
					otri.orient++;
				}
			}
			Behavior.NoExact = noExact;
			return num == 0;
		}
	}
	internal class NewLocation
	{
		private const double EPS = 1E-50;

		private Mesh mesh;

		private Behavior behavior;

		private double[] petalx = new double[20];

		private double[] petaly = new double[20];

		private double[] petalr = new double[20];

		private double[] wedges = new double[500];

		private double[] initialConvexPoly = new double[500];

		private double[] points_p = new double[500];

		private double[] points_q = new double[500];

		private double[] points_r = new double[500];

		private double[] poly1 = new double[100];

		private double[] poly2 = new double[100];

		private double[][] polys = new double[3][];

		public NewLocation(Mesh mesh)
		{
			this.mesh = mesh;
			behavior = mesh.behavior;
		}

		public Point FindLocation(Vertex torg, Vertex tdest, Vertex tapex, ref double xi, ref double eta, bool offcenter, Otri badotri)
		{
			if (behavior.MaxAngle == 0.0)
			{
				return FindNewLocationWithoutMaxAngle(torg, tdest, tapex, ref xi, ref eta, offcenter: true, badotri);
			}
			return FindNewLocation(torg, tdest, tapex, ref xi, ref eta, offcenter: true, badotri);
		}

		private Point FindNewLocationWithoutMaxAngle(Vertex torg, Vertex tdest, Vertex tapex, ref double xi, ref double eta, bool offcenter, Otri badotri)
		{
			double offconstant = behavior.offconstant;
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double num5 = 0.0;
			int num6 = 0;
			int num7 = 0;
			Otri neighotri = default(Otri);
			double[] thirdpoint = new double[2];
			double xi2 = 0.0;
			double eta2 = 0.0;
			double[] p = new double[5];
			double[] p2 = new double[4];
			double num8 = 0.06;
			double num9 = 1.0;
			double num10 = 1.0;
			int num11 = 0;
			double[] newloc = new double[2];
			double num12 = 0.0;
			double num13 = 0.0;
			Statistic.CircumcenterCount++;
			double num14 = tdest.x - torg.x;
			double num15 = tdest.y - torg.y;
			double num16 = tapex.x - torg.x;
			double num17 = tapex.y - torg.y;
			double num18 = tapex.x - tdest.x;
			double num19 = tapex.y - tdest.y;
			double num20 = num14 * num14 + num15 * num15;
			double num21 = num16 * num16 + num17 * num17;
			double num22 = (tdest.x - tapex.x) * (tdest.x - tapex.x) + (tdest.y - tapex.y) * (tdest.y - tapex.y);
			double num23;
			if (Behavior.NoExact)
			{
				num23 = 0.5 / (num14 * num17 - num16 * num15);
			}
			else
			{
				num23 = 0.5 / Primitives.CounterClockwise(tdest, tapex, torg);
				Statistic.CounterClockwiseCount--;
			}
			double num24 = (num17 * num20 - num15 * num21) * num23;
			double num25 = (num14 * num21 - num16 * num20) * num23;
			Point point = new Point(torg.x + num24, torg.y + num25);
			Otri deltri = badotri;
			num6 = LongestShortestEdge(num21, num22, num20);
			Point point2;
			Point point3;
			Point point4;
			switch (num6)
			{
			case 123:
				num = num16;
				num2 = num17;
				num3 = num21;
				num4 = num22;
				num5 = num20;
				point2 = tdest;
				point3 = torg;
				point4 = tapex;
				break;
			case 132:
				num = num16;
				num2 = num17;
				num3 = num21;
				num4 = num20;
				num5 = num22;
				point2 = tdest;
				point3 = tapex;
				point4 = torg;
				break;
			case 213:
				num = num18;
				num2 = num19;
				num3 = num22;
				num4 = num21;
				num5 = num20;
				point2 = torg;
				point3 = tdest;
				point4 = tapex;
				break;
			case 231:
				num = num18;
				num2 = num19;
				num3 = num22;
				num4 = num20;
				num5 = num21;
				point2 = torg;
				point3 = tapex;
				point4 = tdest;
				break;
			case 312:
				num = num14;
				num2 = num15;
				num3 = num20;
				num4 = num21;
				num5 = num22;
				point2 = tapex;
				point3 = tdest;
				point4 = torg;
				break;
			default:
				num = num14;
				num2 = num15;
				num3 = num20;
				num4 = num22;
				num5 = num21;
				point2 = tapex;
				point3 = torg;
				point4 = tdest;
				break;
			}
			if (offcenter && offconstant > 0.0)
			{
				switch (num6)
				{
				case 213:
				case 231:
				{
					double num26 = 0.5 * num - offconstant * num2;
					double num27 = 0.5 * num2 + offconstant * num;
					if (num26 * num26 + num27 * num27 < (num24 - num14) * (num24 - num14) + (num25 - num15) * (num25 - num15))
					{
						num24 = num14 + num26;
						num25 = num15 + num27;
					}
					else
					{
						num7 = 1;
					}
					break;
				}
				case 123:
				case 132:
				{
					double num26 = 0.5 * num + offconstant * num2;
					double num27 = 0.5 * num2 - offconstant * num;
					if (num26 * num26 + num27 * num27 < num24 * num24 + num25 * num25)
					{
						num24 = num26;
						num25 = num27;
					}
					else
					{
						num7 = 1;
					}
					break;
				}
				default:
				{
					double num26 = 0.5 * num - offconstant * num2;
					double num27 = 0.5 * num2 + offconstant * num;
					if (num26 * num26 + num27 * num27 < num24 * num24 + num25 * num25)
					{
						num24 = num26;
						num25 = num27;
					}
					else
					{
						num7 = 1;
					}
					break;
				}
				}
			}
			if (num7 == 1)
			{
				double num28 = (num4 + num3 - num5) / (2.0 * Math.Sqrt(num4) * Math.Sqrt(num3));
				bool flag = num28 < 0.0 || Math.Abs(num28 - 0.0) <= 1E-50;
				num11 = DoSmoothing(deltri, torg, tdest, tapex, ref newloc);
				if (num11 > 0)
				{
					Statistic.RelocationCount++;
					num24 = newloc[0] - torg.x;
					num25 = newloc[1] - torg.y;
					num12 = torg.x;
					num13 = torg.y;
					switch (num11)
					{
					case 1:
						mesh.DeleteVertex(ref deltri);
						break;
					case 2:
						deltri.LnextSelf();
						mesh.DeleteVertex(ref deltri);
						break;
					case 3:
						deltri.LprevSelf();
						mesh.DeleteVertex(ref deltri);
						break;
					}
				}
				else
				{
					double num29 = Math.Sqrt(num3) / (2.0 * Math.Sin(behavior.MinAngle * Math.PI / 180.0));
					double num30 = (point3.x + point4.x) / 2.0;
					double num31 = (point3.y + point4.y) / 2.0;
					double num32 = num30 + Math.Sqrt(num29 * num29 - num3 / 4.0) * (point3.y - point4.y) / Math.Sqrt(num3);
					double num33 = num31 + Math.Sqrt(num29 * num29 - num3 / 4.0) * (point4.x - point3.x) / Math.Sqrt(num3);
					double num34 = num30 - Math.Sqrt(num29 * num29 - num3 / 4.0) * (point3.y - point4.y) / Math.Sqrt(num3);
					double num35 = num31 - Math.Sqrt(num29 * num29 - num3 / 4.0) * (point4.x - point3.x) / Math.Sqrt(num3);
					double num36 = (num32 - point2.x) * (num32 - point2.x);
					double num37 = (num33 - point2.y) * (num33 - point2.y);
					double num38 = (num34 - point2.x) * (num34 - point2.x);
					double num39 = (num35 - point2.y) * (num35 - point2.y);
					double x;
					double y;
					if (num36 + num37 <= num38 + num39)
					{
						x = num32;
						y = num33;
					}
					else
					{
						x = num34;
						y = num35;
					}
					bool neighborsVertex = GetNeighborsVertex(badotri, point3.x, point3.y, point2.x, point2.y, ref thirdpoint, ref neighotri);
					double num40 = num24;
					double num41 = num25;
					if (!neighborsVertex)
					{
						Vertex torg2 = neighotri.Org();
						Vertex tdest2 = neighotri.Dest();
						Vertex tapex2 = neighotri.Apex();
						Point point5 = Primitives.FindCircumcenter(torg2, tdest2, tapex2, ref xi2, ref eta2);
						double num42 = point3.y - point2.y;
						double num43 = point2.x - point3.x;
						num42 = point.x + num42;
						num43 = point.y + num43;
						CircleLineIntersection(point.x, point.y, num42, num43, x, y, num29, ref p);
						double x2 = (point3.x + point2.x) / 2.0;
						double y2 = (point3.y + point2.y) / 2.0;
						double num44;
						double num45;
						if (ChooseCorrectPoint(x2, y2, p[3], p[4], point.x, point.y, flag))
						{
							num44 = p[3];
							num45 = p[4];
						}
						else
						{
							num44 = p[1];
							num45 = p[2];
						}
						PointBetweenPoints(num44, num45, point.x, point.y, point5.x, point5.y, ref p2);
						if (p[0] > 0.0)
						{
							if (Math.Abs(p2[0] - 1.0) <= 1E-50)
							{
								if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, point5.x, point5.y))
								{
									num40 = num24;
									num41 = num25;
								}
								else
								{
									num40 = p2[2] - torg.x;
									num41 = p2[3] - torg.y;
								}
							}
							else if (IsBadTriangleAngle(point4.x, point4.y, point3.x, point3.y, num44, num45))
							{
								double num46 = Math.Sqrt((num44 - point.x) * (num44 - point.x) + (num45 - point.y) * (num45 - point.y));
								double num47 = point.x - num44;
								double num48 = point.y - num45;
								num47 /= num46;
								num48 /= num46;
								num44 += num47 * num8 * Math.Sqrt(num3);
								num45 += num48 * num8 * Math.Sqrt(num3);
								if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num44, num45))
								{
									num40 = num24;
									num41 = num25;
								}
								else
								{
									num40 = num44 - torg.x;
									num41 = num45 - torg.y;
								}
							}
							else
							{
								num40 = num44 - torg.x;
								num41 = num45 - torg.y;
							}
							if ((point2.x - point.x) * (point2.x - point.x) + (point2.y - point.y) * (point2.y - point.y) > num9 * ((point2.x - (num40 + torg.x)) * (point2.x - (num40 + torg.x)) + (point2.y - (num41 + torg.y)) * (point2.y - (num41 + torg.y))))
							{
								num40 = num24;
								num41 = num25;
							}
						}
					}
					bool neighborsVertex2 = GetNeighborsVertex(badotri, point4.x, point4.y, point2.x, point2.y, ref thirdpoint, ref neighotri);
					double num49 = num24;
					double num50 = num25;
					if (!neighborsVertex2)
					{
						Vertex torg3 = neighotri.Org();
						Vertex tdest2 = neighotri.Dest();
						Vertex tapex2 = neighotri.Apex();
						Point point5 = Primitives.FindCircumcenter(torg3, tdest2, tapex2, ref xi2, ref eta2);
						double num42 = point4.y - point2.y;
						double num43 = point2.x - point4.x;
						num42 = point.x + num42;
						num43 = point.y + num43;
						CircleLineIntersection(point.x, point.y, num42, num43, x, y, num29, ref p);
						double x3 = (point4.x + point2.x) / 2.0;
						double y3 = (point4.y + point2.y) / 2.0;
						double num44;
						double num45;
						if (ChooseCorrectPoint(x3, y3, p[3], p[4], point.x, point.y, isObtuse: false))
						{
							num44 = p[3];
							num45 = p[4];
						}
						else
						{
							num44 = p[1];
							num45 = p[2];
						}
						PointBetweenPoints(num44, num45, point.x, point.y, point5.x, point5.y, ref p2);
						if (p[0] > 0.0)
						{
							if (Math.Abs(p2[0] - 1.0) <= 1E-50)
							{
								if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, point5.x, point5.y))
								{
									num49 = num24;
									num50 = num25;
								}
								else
								{
									num49 = p2[2] - torg.x;
									num50 = p2[3] - torg.y;
								}
							}
							else if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num44, num45))
							{
								double num46 = Math.Sqrt((num44 - point.x) * (num44 - point.x) + (num45 - point.y) * (num45 - point.y));
								double num47 = point.x - num44;
								double num48 = point.y - num45;
								num47 /= num46;
								num48 /= num46;
								num44 += num47 * num8 * Math.Sqrt(num3);
								num45 += num48 * num8 * Math.Sqrt(num3);
								if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num44, num45))
								{
									num49 = num24;
									num50 = num25;
								}
								else
								{
									num49 = num44 - torg.x;
									num50 = num45 - torg.y;
								}
							}
							else
							{
								num49 = num44 - torg.x;
								num50 = num45 - torg.y;
							}
							if ((point2.x - point.x) * (point2.x - point.x) + (point2.y - point.y) * (point2.y - point.y) > num9 * ((point2.x - (num49 + torg.x)) * (point2.x - (num49 + torg.x)) + (point2.y - (num50 + torg.y)) * (point2.y - (num50 + torg.y))))
							{
								num49 = num24;
								num50 = num25;
							}
						}
					}
					if (flag)
					{
						num24 = num40;
						num25 = num41;
					}
					else if (num10 * ((point2.x - (num49 + torg.x)) * (point2.x - (num49 + torg.x)) + (point2.y - (num50 + torg.y)) * (point2.y - (num50 + torg.y))) > (point2.x - (num40 + torg.x)) * (point2.x - (num40 + torg.x)) + (point2.y - (num41 + torg.y)) * (point2.y - (num41 + torg.y)))
					{
						num24 = num49;
						num25 = num50;
					}
					else
					{
						num24 = num40;
						num25 = num41;
					}
				}
			}
			Point point6 = new Point();
			if (num11 <= 0)
			{
				point6.x = torg.x + num24;
				point6.y = torg.y + num25;
			}
			else
			{
				point6.x = num12 + num24;
				point6.y = num13 + num25;
			}
			xi = (num17 * num24 - num16 * num25) * (2.0 * num23);
			eta = (num14 * num25 - num15 * num24) * (2.0 * num23);
			return point6;
		}

		private Point FindNewLocation(Vertex torg, Vertex tdest, Vertex tapex, ref double xi, ref double eta, bool offcenter, Otri badotri)
		{
			double offconstant = behavior.offconstant;
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double num5 = 0.0;
			int num6 = 0;
			int num7 = 0;
			Otri neighotri = default(Otri);
			double[] thirdpoint = new double[2];
			double xi2 = 0.0;
			double eta2 = 0.0;
			double[] p = new double[5];
			double[] p2 = new double[4];
			double num8 = 0.06;
			double num9 = 1.0;
			double num10 = 1.0;
			int num11 = 0;
			double[] newloc = new double[2];
			double num12 = 0.0;
			double num13 = 0.0;
			double num14 = 0.0;
			double num15 = 0.0;
			double[] p3 = new double[3];
			double[] p4 = new double[4];
			Statistic.CircumcenterCount++;
			double num16 = tdest.x - torg.x;
			double num17 = tdest.y - torg.y;
			double num18 = tapex.x - torg.x;
			double num19 = tapex.y - torg.y;
			double num20 = tapex.x - tdest.x;
			double num21 = tapex.y - tdest.y;
			double num22 = num16 * num16 + num17 * num17;
			double num23 = num18 * num18 + num19 * num19;
			double num24 = (tdest.x - tapex.x) * (tdest.x - tapex.x) + (tdest.y - tapex.y) * (tdest.y - tapex.y);
			double num25;
			if (Behavior.NoExact)
			{
				num25 = 0.5 / (num16 * num19 - num18 * num17);
			}
			else
			{
				num25 = 0.5 / Primitives.CounterClockwise(tdest, tapex, torg);
				Statistic.CounterClockwiseCount--;
			}
			double num26 = (num19 * num22 - num17 * num23) * num25;
			double num27 = (num16 * num23 - num18 * num22) * num25;
			Point point = new Point(torg.x + num26, torg.y + num27);
			Otri deltri = badotri;
			num6 = LongestShortestEdge(num23, num24, num22);
			Point point2;
			Point point3;
			Point point4;
			switch (num6)
			{
			case 123:
				num = num18;
				num2 = num19;
				num3 = num23;
				num4 = num24;
				num5 = num22;
				point2 = tdest;
				point3 = torg;
				point4 = tapex;
				break;
			case 132:
				num = num18;
				num2 = num19;
				num3 = num23;
				num4 = num22;
				num5 = num24;
				point2 = tdest;
				point3 = tapex;
				point4 = torg;
				break;
			case 213:
				num = num20;
				num2 = num21;
				num3 = num24;
				num4 = num23;
				num5 = num22;
				point2 = torg;
				point3 = tdest;
				point4 = tapex;
				break;
			case 231:
				num = num20;
				num2 = num21;
				num3 = num24;
				num4 = num22;
				num5 = num23;
				point2 = torg;
				point3 = tapex;
				point4 = tdest;
				break;
			case 312:
				num = num16;
				num2 = num17;
				num3 = num22;
				num4 = num23;
				num5 = num24;
				point2 = tapex;
				point3 = tdest;
				point4 = torg;
				break;
			default:
				num = num16;
				num2 = num17;
				num3 = num22;
				num4 = num24;
				num5 = num23;
				point2 = tapex;
				point3 = torg;
				point4 = tdest;
				break;
			}
			if (offcenter && offconstant > 0.0)
			{
				switch (num6)
				{
				case 213:
				case 231:
				{
					double num28 = 0.5 * num - offconstant * num2;
					double num29 = 0.5 * num2 + offconstant * num;
					if (num28 * num28 + num29 * num29 < (num26 - num16) * (num26 - num16) + (num27 - num17) * (num27 - num17))
					{
						num26 = num16 + num28;
						num27 = num17 + num29;
					}
					else
					{
						num7 = 1;
					}
					break;
				}
				case 123:
				case 132:
				{
					double num28 = 0.5 * num + offconstant * num2;
					double num29 = 0.5 * num2 - offconstant * num;
					if (num28 * num28 + num29 * num29 < num26 * num26 + num27 * num27)
					{
						num26 = num28;
						num27 = num29;
					}
					else
					{
						num7 = 1;
					}
					break;
				}
				default:
				{
					double num28 = 0.5 * num - offconstant * num2;
					double num29 = 0.5 * num2 + offconstant * num;
					if (num28 * num28 + num29 * num29 < num26 * num26 + num27 * num27)
					{
						num26 = num28;
						num27 = num29;
					}
					else
					{
						num7 = 1;
					}
					break;
				}
				}
			}
			if (num7 == 1)
			{
				double num30 = (num4 + num3 - num5) / (2.0 * Math.Sqrt(num4) * Math.Sqrt(num3));
				bool flag = num30 < 0.0 || Math.Abs(num30 - 0.0) <= 1E-50;
				num11 = DoSmoothing(deltri, torg, tdest, tapex, ref newloc);
				if (num11 > 0)
				{
					Statistic.RelocationCount++;
					num26 = newloc[0] - torg.x;
					num27 = newloc[1] - torg.y;
					num12 = torg.x;
					num13 = torg.y;
					switch (num11)
					{
					case 1:
						mesh.DeleteVertex(ref deltri);
						break;
					case 2:
						deltri.LnextSelf();
						mesh.DeleteVertex(ref deltri);
						break;
					case 3:
						deltri.LprevSelf();
						mesh.DeleteVertex(ref deltri);
						break;
					}
				}
				else
				{
					double num31 = Math.Acos((num4 + num5 - num3) / (2.0 * Math.Sqrt(num4) * Math.Sqrt(num5))) * 180.0 / Math.PI;
					num31 = ((!(behavior.MinAngle > num31)) ? (num31 + 0.5) : behavior.MinAngle);
					double num32 = Math.Sqrt(num3) / (2.0 * Math.Sin(num31 * Math.PI / 180.0));
					double num33 = (point3.x + point4.x) / 2.0;
					double num34 = (point3.y + point4.y) / 2.0;
					double num35 = num33 + Math.Sqrt(num32 * num32 - num3 / 4.0) * (point3.y - point4.y) / Math.Sqrt(num3);
					double num36 = num34 + Math.Sqrt(num32 * num32 - num3 / 4.0) * (point4.x - point3.x) / Math.Sqrt(num3);
					double num37 = num33 - Math.Sqrt(num32 * num32 - num3 / 4.0) * (point3.y - point4.y) / Math.Sqrt(num3);
					double num38 = num34 - Math.Sqrt(num32 * num32 - num3 / 4.0) * (point4.x - point3.x) / Math.Sqrt(num3);
					double num39 = (num35 - point2.x) * (num35 - point2.x);
					double num40 = (num36 - point2.y) * (num36 - point2.y);
					double num41 = (num37 - point2.x) * (num37 - point2.x);
					double num42 = (num38 - point2.y) * (num38 - point2.y);
					double num43;
					double num44;
					if (num39 + num40 <= num41 + num42)
					{
						num43 = num35;
						num44 = num36;
					}
					else
					{
						num43 = num37;
						num44 = num38;
					}
					bool neighborsVertex = GetNeighborsVertex(badotri, point3.x, point3.y, point2.x, point2.y, ref thirdpoint, ref neighotri);
					double num45 = num26;
					double num46 = num27;
					double num47 = Math.Sqrt((num43 - num33) * (num43 - num33) + (num44 - num34) * (num44 - num34));
					double num48 = (num43 - num33) / num47;
					double num49 = (num44 - num34) / num47;
					double num50 = num43 + num48 * num32;
					double num51 = num44 + num49 * num32;
					double num52 = (2.0 * behavior.MaxAngle + num31 - 180.0) * Math.PI / 180.0;
					double num53 = num50 * Math.Cos(num52) + num51 * Math.Sin(num52) + num43 - num43 * Math.Cos(num52) - num44 * Math.Sin(num52);
					double num54 = (0.0 - num50) * Math.Sin(num52) + num51 * Math.Cos(num52) + num44 + num43 * Math.Sin(num52) - num44 * Math.Cos(num52);
					double num55 = num50 * Math.Cos(num52) - num51 * Math.Sin(num52) + num43 - num43 * Math.Cos(num52) + num44 * Math.Sin(num52);
					double num56 = num50 * Math.Sin(num52) + num51 * Math.Cos(num52) + num44 - num43 * Math.Sin(num52) - num44 * Math.Cos(num52);
					double num57;
					double num58;
					double num59;
					double num60;
					if (ChooseCorrectPoint(num55, num56, point3.x, point3.y, num53, num54, isObtuse: true))
					{
						num57 = num53;
						num58 = num54;
						num59 = num55;
						num60 = num56;
					}
					else
					{
						num57 = num55;
						num58 = num56;
						num59 = num53;
						num60 = num54;
					}
					double num61 = (point3.x + point2.x) / 2.0;
					double num62 = (point3.y + point2.y) / 2.0;
					if (!neighborsVertex)
					{
						Vertex torg2 = neighotri.Org();
						Vertex tdest2 = neighotri.Dest();
						Vertex tapex2 = neighotri.Apex();
						Point point5 = Primitives.FindCircumcenter(torg2, tdest2, tapex2, ref xi2, ref eta2);
						double num63 = point3.y - point2.y;
						double num64 = point2.x - point3.x;
						num63 = point.x + num63;
						num64 = point.y + num64;
						CircleLineIntersection(point.x, point.y, num63, num64, num43, num44, num32, ref p);
						double num65;
						double num66;
						if (ChooseCorrectPoint(num61, num62, p[3], p[4], point.x, point.y, flag))
						{
							num65 = p[3];
							num66 = p[4];
						}
						else
						{
							num65 = p[1];
							num66 = p[2];
						}
						double x = point3.x;
						double y = point3.y;
						num48 = point4.x - point3.x;
						num49 = point4.y - point3.y;
						double x2 = num57;
						double y2 = num58;
						LineLineIntersection(point.x, point.y, num63, num64, x, y, x2, y2, ref p3);
						if (p3[0] > 0.0)
						{
							num14 = p3[1];
							num15 = p3[2];
						}
						PointBetweenPoints(num65, num66, point.x, point.y, point5.x, point5.y, ref p2);
						if (p[0] > 0.0)
						{
							if (Math.Abs(p2[0] - 1.0) <= 1E-50)
							{
								PointBetweenPoints(p2[2], p2[3], point.x, point.y, num14, num15, ref p4);
								if (Math.Abs(p4[0] - 1.0) <= 1E-50 && p3[0] > 0.0)
								{
									if ((point2.x - num57) * (point2.x - num57) + (point2.y - num58) * (point2.y - num58) > num9 * ((point2.x - num14) * (point2.x - num14) + (point2.y - num15) * (point2.y - num15)) && IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num57, num58) && MinDistanceToNeighbor(num57, num58, ref neighotri) > MinDistanceToNeighbor(num14, num15, ref neighotri))
									{
										num45 = num57 - torg.x;
										num46 = num58 - torg.y;
									}
									else if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num14, num15))
									{
										double num67 = Math.Sqrt((num14 - point.x) * (num14 - point.x) + (num15 - point.y) * (num15 - point.y));
										double num68 = point.x - num14;
										double num69 = point.y - num15;
										num68 /= num67;
										num69 /= num67;
										num14 += num68 * num8 * Math.Sqrt(num3);
										num15 += num69 * num8 * Math.Sqrt(num3);
										if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num14, num15))
										{
											num45 = num26;
											num46 = num27;
										}
										else
										{
											num45 = num14 - torg.x;
											num46 = num15 - torg.y;
										}
									}
									else
									{
										num45 = p4[2] - torg.x;
										num46 = p4[3] - torg.y;
									}
								}
								else if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, point5.x, point5.y))
								{
									num45 = num26;
									num46 = num27;
								}
								else
								{
									num45 = p2[2] - torg.x;
									num46 = p2[3] - torg.y;
								}
							}
							else
							{
								PointBetweenPoints(num65, num66, point.x, point.y, num14, num15, ref p4);
								if (Math.Abs(p4[0] - 1.0) <= 1E-50 && p3[0] > 0.0)
								{
									if ((point2.x - num57) * (point2.x - num57) + (point2.y - num58) * (point2.y - num58) > num9 * ((point2.x - num14) * (point2.x - num14) + (point2.y - num15) * (point2.y - num15)) && IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num57, num58) && MinDistanceToNeighbor(num57, num58, ref neighotri) > MinDistanceToNeighbor(num14, num15, ref neighotri))
									{
										num45 = num57 - torg.x;
										num46 = num58 - torg.y;
									}
									else if (IsBadTriangleAngle(point4.x, point4.y, point3.x, point3.y, num14, num15))
									{
										double num67 = Math.Sqrt((num14 - point.x) * (num14 - point.x) + (num15 - point.y) * (num15 - point.y));
										double num68 = point.x - num14;
										double num69 = point.y - num15;
										num68 /= num67;
										num69 /= num67;
										num14 += num68 * num8 * Math.Sqrt(num3);
										num15 += num69 * num8 * Math.Sqrt(num3);
										if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num14, num15))
										{
											num45 = num26;
											num46 = num27;
										}
										else
										{
											num45 = num14 - torg.x;
											num46 = num15 - torg.y;
										}
									}
									else
									{
										num45 = p4[2] - torg.x;
										num46 = p4[3] - torg.y;
									}
								}
								else if (IsBadTriangleAngle(point4.x, point4.y, point3.x, point3.y, num65, num66))
								{
									double num67 = Math.Sqrt((num65 - point.x) * (num65 - point.x) + (num66 - point.y) * (num66 - point.y));
									double num68 = point.x - num65;
									double num69 = point.y - num66;
									num68 /= num67;
									num69 /= num67;
									num65 += num68 * num8 * Math.Sqrt(num3);
									num66 += num69 * num8 * Math.Sqrt(num3);
									if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num65, num66))
									{
										num45 = num26;
										num46 = num27;
									}
									else
									{
										num45 = num65 - torg.x;
										num46 = num66 - torg.y;
									}
								}
								else
								{
									num45 = num65 - torg.x;
									num46 = num66 - torg.y;
								}
							}
							if ((point2.x - point.x) * (point2.x - point.x) + (point2.y - point.y) * (point2.y - point.y) > num9 * ((point2.x - (num45 + torg.x)) * (point2.x - (num45 + torg.x)) + (point2.y - (num46 + torg.y)) * (point2.y - (num46 + torg.y))))
							{
								num45 = num26;
								num46 = num27;
							}
						}
					}
					bool neighborsVertex2 = GetNeighborsVertex(badotri, point4.x, point4.y, point2.x, point2.y, ref thirdpoint, ref neighotri);
					double num70 = num26;
					double num71 = num27;
					double num72 = (point4.x + point2.x) / 2.0;
					double num73 = (point4.y + point2.y) / 2.0;
					if (!neighborsVertex2)
					{
						Vertex torg3 = neighotri.Org();
						Vertex tdest2 = neighotri.Dest();
						Vertex tapex2 = neighotri.Apex();
						Point point5 = Primitives.FindCircumcenter(torg3, tdest2, tapex2, ref xi2, ref eta2);
						double num63 = point4.y - point2.y;
						double num64 = point2.x - point4.x;
						num63 = point.x + num63;
						num64 = point.y + num64;
						CircleLineIntersection(point.x, point.y, num63, num64, num43, num44, num32, ref p);
						double num65;
						double num66;
						if (ChooseCorrectPoint(num72, num73, p[3], p[4], point.x, point.y, isObtuse: false))
						{
							num65 = p[3];
							num66 = p[4];
						}
						else
						{
							num65 = p[1];
							num66 = p[2];
						}
						double x = point4.x;
						double y = point4.y;
						num48 = point3.x - point4.x;
						num49 = point3.y - point4.y;
						double x2 = num59;
						double y2 = num60;
						LineLineIntersection(point.x, point.y, num63, num64, x, y, x2, y2, ref p3);
						if (p3[0] > 0.0)
						{
							num14 = p3[1];
							num15 = p3[2];
						}
						PointBetweenPoints(num65, num66, point.x, point.y, point5.x, point5.y, ref p2);
						if (p[0] > 0.0)
						{
							if (Math.Abs(p2[0] - 1.0) <= 1E-50)
							{
								PointBetweenPoints(p2[2], p2[3], point.x, point.y, num14, num15, ref p4);
								if (Math.Abs(p4[0] - 1.0) <= 1E-50 && p3[0] > 0.0)
								{
									if ((point2.x - num59) * (point2.x - num59) + (point2.y - num60) * (point2.y - num60) > num9 * ((point2.x - num14) * (point2.x - num14) + (point2.y - num15) * (point2.y - num15)) && IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num59, num60) && MinDistanceToNeighbor(num59, num60, ref neighotri) > MinDistanceToNeighbor(num14, num15, ref neighotri))
									{
										num70 = num59 - torg.x;
										num71 = num60 - torg.y;
									}
									else if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num14, num15))
									{
										double num67 = Math.Sqrt((num14 - point.x) * (num14 - point.x) + (num15 - point.y) * (num15 - point.y));
										double num68 = point.x - num14;
										double num69 = point.y - num15;
										num68 /= num67;
										num69 /= num67;
										num14 += num68 * num8 * Math.Sqrt(num3);
										num15 += num69 * num8 * Math.Sqrt(num3);
										if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num14, num15))
										{
											num70 = num26;
											num71 = num27;
										}
										else
										{
											num70 = num14 - torg.x;
											num71 = num15 - torg.y;
										}
									}
									else
									{
										num70 = p4[2] - torg.x;
										num71 = p4[3] - torg.y;
									}
								}
								else if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, point5.x, point5.y))
								{
									num70 = num26;
									num71 = num27;
								}
								else
								{
									num70 = p2[2] - torg.x;
									num71 = p2[3] - torg.y;
								}
							}
							else
							{
								PointBetweenPoints(num65, num66, point.x, point.y, num14, num15, ref p4);
								if (Math.Abs(p4[0] - 1.0) <= 1E-50 && p3[0] > 0.0)
								{
									if ((point2.x - num59) * (point2.x - num59) + (point2.y - num60) * (point2.y - num60) > num9 * ((point2.x - num14) * (point2.x - num14) + (point2.y - num15) * (point2.y - num15)) && IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num59, num60) && MinDistanceToNeighbor(num59, num60, ref neighotri) > MinDistanceToNeighbor(num14, num15, ref neighotri))
									{
										num70 = num59 - torg.x;
										num71 = num60 - torg.y;
									}
									else if (IsBadTriangleAngle(point4.x, point4.y, point3.x, point3.y, num14, num15))
									{
										double num67 = Math.Sqrt((num14 - point.x) * (num14 - point.x) + (num15 - point.y) * (num15 - point.y));
										double num68 = point.x - num14;
										double num69 = point.y - num15;
										num68 /= num67;
										num69 /= num67;
										num14 += num68 * num8 * Math.Sqrt(num3);
										num15 += num69 * num8 * Math.Sqrt(num3);
										if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num14, num15))
										{
											num70 = num26;
											num71 = num27;
										}
										else
										{
											num70 = num14 - torg.x;
											num71 = num15 - torg.y;
										}
									}
									else
									{
										num70 = p4[2] - torg.x;
										num71 = p4[3] - torg.y;
									}
								}
								else if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num65, num66))
								{
									double num67 = Math.Sqrt((num65 - point.x) * (num65 - point.x) + (num66 - point.y) * (num66 - point.y));
									double num68 = point.x - num65;
									double num69 = point.y - num66;
									num68 /= num67;
									num69 /= num67;
									num65 += num68 * num8 * Math.Sqrt(num3);
									num66 += num69 * num8 * Math.Sqrt(num3);
									if (IsBadTriangleAngle(point3.x, point3.y, point4.x, point4.y, num65, num66))
									{
										num70 = num26;
										num71 = num27;
									}
									else
									{
										num70 = num65 - torg.x;
										num71 = num66 - torg.y;
									}
								}
								else
								{
									num70 = num65 - torg.x;
									num71 = num66 - torg.y;
								}
							}
							if ((point2.x - point.x) * (point2.x - point.x) + (point2.y - point.y) * (point2.y - point.y) > num9 * ((point2.x - (num70 + torg.x)) * (point2.x - (num70 + torg.x)) + (point2.y - (num71 + torg.y)) * (point2.y - (num71 + torg.y))))
							{
								num70 = num26;
								num71 = num27;
							}
						}
					}
					if (flag)
					{
						if (neighborsVertex && neighborsVertex2)
						{
							if (num10 * ((point2.x - num72) * (point2.x - num72) + (point2.y - num73) * (point2.y - num73)) > (point2.x - num61) * (point2.x - num61) + (point2.y - num62) * (point2.y - num62))
							{
								num26 = num70;
								num27 = num71;
							}
							else
							{
								num26 = num45;
								num27 = num46;
							}
						}
						else if (neighborsVertex)
						{
							if (num10 * ((point2.x - (num70 + torg.x)) * (point2.x - (num70 + torg.x)) + (point2.y - (num71 + torg.y)) * (point2.y - (num71 + torg.y))) > (point2.x - num61) * (point2.x - num61) + (point2.y - num62) * (point2.y - num62))
							{
								num26 = num70;
								num27 = num71;
							}
							else
							{
								num26 = num45;
								num27 = num46;
							}
						}
						else if (neighborsVertex2)
						{
							if (num10 * ((point2.x - num72) * (point2.x - num72) + (point2.y - num73) * (point2.y - num73)) > (point2.x - (num45 + torg.x)) * (point2.x - (num45 + torg.x)) + (point2.y - (num46 + torg.y)) * (point2.y - (num46 + torg.y)))
							{
								num26 = num70;
								num27 = num71;
							}
							else
							{
								num26 = num45;
								num27 = num46;
							}
						}
						else if (num10 * ((point2.x - (num70 + torg.x)) * (point2.x - (num70 + torg.x)) + (point2.y - (num71 + torg.y)) * (point2.y - (num71 + torg.y))) > (point2.x - (num45 + torg.x)) * (point2.x - (num45 + torg.x)) + (point2.y - (num46 + torg.y)) * (point2.y - (num46 + torg.y)))
						{
							num26 = num70;
							num27 = num71;
						}
						else
						{
							num26 = num45;
							num27 = num46;
						}
					}
					else if (neighborsVertex && neighborsVertex2)
					{
						if (num10 * ((point2.x - num72) * (point2.x - num72) + (point2.y - num73) * (point2.y - num73)) > (point2.x - num61) * (point2.x - num61) + (point2.y - num62) * (point2.y - num62))
						{
							num26 = num70;
							num27 = num71;
						}
						else
						{
							num26 = num45;
							num27 = num46;
						}
					}
					else if (neighborsVertex)
					{
						if (num10 * ((point2.x - (num70 + torg.x)) * (point2.x - (num70 + torg.x)) + (point2.y - (num71 + torg.y)) * (point2.y - (num71 + torg.y))) > (point2.x - num61) * (point2.x - num61) + (point2.y - num62) * (point2.y - num62))
						{
							num26 = num70;
							num27 = num71;
						}
						else
						{
							num26 = num45;
							num27 = num46;
						}
					}
					else if (neighborsVertex2)
					{
						if (num10 * ((point2.x - num72) * (point2.x - num72) + (point2.y - num73) * (point2.y - num73)) > (point2.x - (num45 + torg.x)) * (point2.x - (num45 + torg.x)) + (point2.y - (num46 + torg.y)) * (point2.y - (num46 + torg.y)))
						{
							num26 = num70;
							num27 = num71;
						}
						else
						{
							num26 = num45;
							num27 = num46;
						}
					}
					else if (num10 * ((point2.x - (num70 + torg.x)) * (point2.x - (num70 + torg.x)) + (point2.y - (num71 + torg.y)) * (point2.y - (num71 + torg.y))) > (point2.x - (num45 + torg.x)) * (point2.x - (num45 + torg.x)) + (point2.y - (num46 + torg.y)) * (point2.y - (num46 + torg.y)))
					{
						num26 = num70;
						num27 = num71;
					}
					else
					{
						num26 = num45;
						num27 = num46;
					}
				}
			}
			Point point6 = new Point();
			if (num11 <= 0)
			{
				point6.x = torg.x + num26;
				point6.y = torg.y + num27;
			}
			else
			{
				point6.x = num12 + num26;
				point6.y = num13 + num27;
			}
			xi = (num19 * num26 - num18 * num27) * (2.0 * num25);
			eta = (num16 * num27 - num17 * num26) * (2.0 * num25);
			return point6;
		}

		private int LongestShortestEdge(double aodist, double dadist, double dodist)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (dodist < aodist && dodist < dadist)
			{
				num2 = 3;
				if (aodist < dadist)
				{
					num = 2;
					num3 = 1;
				}
				else
				{
					num = 1;
					num3 = 2;
				}
			}
			else if (aodist < dadist)
			{
				num2 = 1;
				if (dodist < dadist)
				{
					num = 2;
					num3 = 3;
				}
				else
				{
					num = 3;
					num3 = 2;
				}
			}
			else
			{
				num2 = 2;
				if (aodist < dodist)
				{
					num = 3;
					num3 = 1;
				}
				else
				{
					num = 1;
					num3 = 3;
				}
			}
			return num2 * 100 + num3 * 10 + num;
		}

		private int DoSmoothing(Otri badotri, Vertex torg, Vertex tdest, Vertex tapex, ref double[] newloc)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			double[] array = new double[6];
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			bool flag = false;
			num = GetStarPoints(badotri, torg, tdest, tapex, 1, ref points_p);
			if (torg.type == VertexType.FreeVertex && num != 0 && ValidPolygonAngles(num, points_p) && ((behavior.MaxAngle != 0.0) ? GetWedgeIntersection(num, points_p, ref newloc) : GetWedgeIntersectionWithoutMaxAngle(num, points_p, ref newloc)))
			{
				array[0] = newloc[0];
				array[1] = newloc[1];
				num4++;
				num5 = 1;
			}
			num2 = GetStarPoints(badotri, torg, tdest, tapex, 2, ref points_q);
			if (tdest.type == VertexType.FreeVertex && num2 != 0 && ValidPolygonAngles(num2, points_q) && ((behavior.MaxAngle != 0.0) ? GetWedgeIntersection(num2, points_q, ref newloc) : GetWedgeIntersectionWithoutMaxAngle(num2, points_q, ref newloc)))
			{
				array[2] = newloc[0];
				array[3] = newloc[1];
				num4++;
				num6 = 2;
			}
			num3 = GetStarPoints(badotri, torg, tdest, tapex, 3, ref points_r);
			if (tapex.type == VertexType.FreeVertex && num3 != 0 && ValidPolygonAngles(num3, points_r) && ((behavior.MaxAngle != 0.0) ? GetWedgeIntersection(num3, points_r, ref newloc) : GetWedgeIntersectionWithoutMaxAngle(num3, points_r, ref newloc)))
			{
				array[4] = newloc[0];
				array[5] = newloc[1];
				num4++;
				num7 = 3;
			}
			if (num4 > 0)
			{
				if (num5 > 0)
				{
					newloc[0] = array[0];
					newloc[1] = array[1];
					return num5;
				}
				if (num6 > 0)
				{
					newloc[0] = array[2];
					newloc[1] = array[3];
					return num6;
				}
				if (num7 > 0)
				{
					newloc[0] = array[4];
					newloc[1] = array[5];
					return num7;
				}
			}
			return 0;
		}

		private int GetStarPoints(Otri badotri, Vertex p, Vertex q, Vertex r, int whichPoint, ref double[] points)
		{
			Otri neighotri = default(Otri);
			double first_x = 0.0;
			double first_y = 0.0;
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double[] thirdpoint = new double[2];
			int num5 = 0;
			switch (whichPoint)
			{
			case 1:
				first_x = p.x;
				first_y = p.y;
				num = r.x;
				num2 = r.y;
				num3 = q.x;
				num4 = q.y;
				break;
			case 2:
				first_x = q.x;
				first_y = q.y;
				num = p.x;
				num2 = p.y;
				num3 = r.x;
				num4 = r.y;
				break;
			case 3:
				first_x = r.x;
				first_y = r.y;
				num = q.x;
				num2 = q.y;
				num3 = p.x;
				num4 = p.y;
				break;
			}
			Otri badotri2 = badotri;
			points[num5] = num;
			num5++;
			points[num5] = num2;
			num5++;
			thirdpoint[0] = num;
			thirdpoint[1] = num2;
			do
			{
				if (!GetNeighborsVertex(badotri2, first_x, first_y, num, num2, ref thirdpoint, ref neighotri))
				{
					badotri2 = neighotri;
					num = thirdpoint[0];
					num2 = thirdpoint[1];
					points[num5] = thirdpoint[0];
					num5++;
					points[num5] = thirdpoint[1];
					num5++;
					continue;
				}
				num5 = 0;
				break;
			}
			while (!(Math.Abs(thirdpoint[0] - num3) <= 1E-50) || !(Math.Abs(thirdpoint[1] - num4) <= 1E-50));
			return num5 / 2;
		}

		private bool GetNeighborsVertex(Otri badotri, double first_x, double first_y, double second_x, double second_y, ref double[] thirdpoint, ref Otri neighotri)
		{
			Otri o = default(Otri);
			bool result = false;
			Vertex vertex = null;
			Vertex vertex2 = null;
			Vertex vertex3 = null;
			int num = 0;
			int num2 = 0;
			badotri.orient = 0;
			while (badotri.orient < 3)
			{
				badotri.Sym(ref o);
				if (o.triangle != Mesh.dummytri)
				{
					vertex = o.Org();
					vertex2 = o.Dest();
					vertex3 = o.Apex();
					if ((vertex.x != vertex2.x || vertex.y != vertex2.y) && (vertex2.x != vertex3.x || vertex2.y != vertex3.y) && (vertex.x != vertex3.x || vertex.y != vertex3.y))
					{
						num = 0;
						if (Math.Abs(first_x - vertex.x) < 1E-50 && Math.Abs(first_y - vertex.y) < 1E-50)
						{
							num = 11;
						}
						else if (Math.Abs(first_x - vertex2.x) < 1E-50 && Math.Abs(first_y - vertex2.y) < 1E-50)
						{
							num = 12;
						}
						else if (Math.Abs(first_x - vertex3.x) < 1E-50 && Math.Abs(first_y - vertex3.y) < 1E-50)
						{
							num = 13;
						}
						num2 = 0;
						if (Math.Abs(second_x - vertex.x) < 1E-50 && Math.Abs(second_y - vertex.y) < 1E-50)
						{
							num2 = 21;
						}
						else if (Math.Abs(second_x - vertex2.x) < 1E-50 && Math.Abs(second_y - vertex2.y) < 1E-50)
						{
							num2 = 22;
						}
						else if (Math.Abs(second_x - vertex3.x) < 1E-50 && Math.Abs(second_y - vertex3.y) < 1E-50)
						{
							num2 = 23;
						}
					}
				}
				if ((num == 11 && (num2 == 22 || num2 == 23)) || (num == 12 && (num2 == 21 || num2 == 23)) || (num == 13 && (num2 == 21 || num2 == 22)))
				{
					break;
				}
				badotri.orient++;
			}
			switch (num)
			{
			case 0:
				result = true;
				break;
			case 11:
				switch (num2)
				{
				case 22:
					thirdpoint[0] = vertex3.x;
					thirdpoint[1] = vertex3.y;
					break;
				case 23:
					thirdpoint[0] = vertex2.x;
					thirdpoint[1] = vertex2.y;
					break;
				default:
					result = true;
					break;
				}
				break;
			case 12:
				switch (num2)
				{
				case 21:
					thirdpoint[0] = vertex3.x;
					thirdpoint[1] = vertex3.y;
					break;
				case 23:
					thirdpoint[0] = vertex.x;
					thirdpoint[1] = vertex.y;
					break;
				default:
					result = true;
					break;
				}
				break;
			case 13:
				switch (num2)
				{
				case 21:
					thirdpoint[0] = vertex2.x;
					thirdpoint[1] = vertex2.y;
					break;
				case 22:
					thirdpoint[0] = vertex.x;
					thirdpoint[1] = vertex.y;
					break;
				default:
					result = true;
					break;
				}
				break;
			default:
				if (num2 == 0)
				{
					result = true;
				}
				break;
			}
			neighotri = o;
			return result;
		}

		private bool GetWedgeIntersectionWithoutMaxAngle(int numpoints, double[] points, ref double[] newloc)
		{
			if (2 * numpoints > petalx.Length)
			{
				petalx = new double[2 * numpoints];
				petaly = new double[2 * numpoints];
				petalr = new double[2 * numpoints];
				wedges = new double[2 * numpoints * 16 + 36];
				if (Behavior.Verbose)
				{
					SimpleLog.Instance.Info("NewLocation: resized work arrays (" + 2 * numpoints + ")");
				}
			}
			double[] p = new double[3];
			int num = 0;
			double num2 = points[2 * numpoints - 4];
			double num3 = points[2 * numpoints - 3];
			double num4 = points[2 * numpoints - 2];
			double num5 = points[2 * numpoints - 1];
			double num6 = behavior.MinAngle * Math.PI / 180.0;
			double num7;
			double num8;
			if (behavior.goodAngle == 1.0)
			{
				num7 = 0.0;
				num8 = 0.0;
			}
			else
			{
				num7 = 0.5 / Math.Tan(num6);
				num8 = 0.5 / Math.Sin(num6);
			}
			for (int i = 0; i < numpoints * 2; i += 2)
			{
				double num9 = points[i];
				double num10 = points[i + 1];
				double num11 = num4 - num2;
				double num12 = num5 - num3;
				double num13 = Math.Sqrt(num11 * num11 + num12 * num12);
				petalx[i / 2] = num2 + 0.5 * num11 - num7 * num12;
				petaly[i / 2] = num3 + 0.5 * num12 + num7 * num11;
				petalr[i / 2] = num8 * num13;
				petalx[numpoints + i / 2] = petalx[i / 2];
				petaly[numpoints + i / 2] = petaly[i / 2];
				petalr[numpoints + i / 2] = petalr[i / 2];
				double num14 = (num2 + num4) / 2.0;
				double num15 = (num3 + num5) / 2.0;
				double num16 = Math.Sqrt((petalx[i / 2] - num14) * (petalx[i / 2] - num14) + (petaly[i / 2] - num15) * (petaly[i / 2] - num15));
				double num17 = (petalx[i / 2] - num14) / num16;
				double num18 = (petaly[i / 2] - num15) / num16;
				double num19 = petalx[i / 2] + num17 * petalr[i / 2];
				double num20 = petaly[i / 2] + num18 * petalr[i / 2];
				num17 = num4 - num2;
				num18 = num5 - num3;
				double num21 = num4 * Math.Cos(num6) - num5 * Math.Sin(num6) + num2 - num2 * Math.Cos(num6) + num3 * Math.Sin(num6);
				double num22 = num4 * Math.Sin(num6) + num5 * Math.Cos(num6) + num3 - num2 * Math.Sin(num6) - num3 * Math.Cos(num6);
				wedges[i * 16] = num2;
				wedges[i * 16 + 1] = num3;
				wedges[i * 16 + 2] = num21;
				wedges[i * 16 + 3] = num22;
				num17 = num2 - num4;
				num18 = num3 - num5;
				double num23 = num2 * Math.Cos(num6) + num3 * Math.Sin(num6) + num4 - num4 * Math.Cos(num6) - num5 * Math.Sin(num6);
				double num24 = (0.0 - num2) * Math.Sin(num6) + num3 * Math.Cos(num6) + num5 + num4 * Math.Sin(num6) - num5 * Math.Cos(num6);
				wedges[i * 16 + 4] = num23;
				wedges[i * 16 + 5] = num24;
				wedges[i * 16 + 6] = num4;
				wedges[i * 16 + 7] = num5;
				num17 = num19 - petalx[i / 2];
				num18 = num20 - petaly[i / 2];
				double num25 = num19;
				double num26 = num20;
				for (int j = 1; j < 4; j++)
				{
					double num27 = num19 * Math.Cos((Math.PI / 3.0 - num6) * (double)j) + num20 * Math.Sin((Math.PI / 3.0 - num6) * (double)j) + petalx[i / 2] - petalx[i / 2] * Math.Cos((Math.PI / 3.0 - num6) * (double)j) - petaly[i / 2] * Math.Sin((Math.PI / 3.0 - num6) * (double)j);
					double num28 = (0.0 - num19) * Math.Sin((Math.PI / 3.0 - num6) * (double)j) + num20 * Math.Cos((Math.PI / 3.0 - num6) * (double)j) + petaly[i / 2] + petalx[i / 2] * Math.Sin((Math.PI / 3.0 - num6) * (double)j) - petaly[i / 2] * Math.Cos((Math.PI / 3.0 - num6) * (double)j);
					wedges[i * 16 + 8 + 4 * (j - 1)] = num27;
					wedges[i * 16 + 9 + 4 * (j - 1)] = num28;
					wedges[i * 16 + 10 + 4 * (j - 1)] = num25;
					wedges[i * 16 + 11 + 4 * (j - 1)] = num26;
					num25 = num27;
					num26 = num28;
				}
				num25 = num19;
				num26 = num20;
				for (int j = 1; j < 4; j++)
				{
					double num29 = num19 * Math.Cos((Math.PI / 3.0 - num6) * (double)j) - num20 * Math.Sin((Math.PI / 3.0 - num6) * (double)j) + petalx[i / 2] - petalx[i / 2] * Math.Cos((Math.PI / 3.0 - num6) * (double)j) + petaly[i / 2] * Math.Sin((Math.PI / 3.0 - num6) * (double)j);
					double num30 = num19 * Math.Sin((Math.PI / 3.0 - num6) * (double)j) + num20 * Math.Cos((Math.PI / 3.0 - num6) * (double)j) + petaly[i / 2] - petalx[i / 2] * Math.Sin((Math.PI / 3.0 - num6) * (double)j) - petaly[i / 2] * Math.Cos((Math.PI / 3.0 - num6) * (double)j);
					wedges[i * 16 + 20 + 4 * (j - 1)] = num25;
					wedges[i * 16 + 21 + 4 * (j - 1)] = num26;
					wedges[i * 16 + 22 + 4 * (j - 1)] = num29;
					wedges[i * 16 + 23 + 4 * (j - 1)] = num30;
					num25 = num29;
					num26 = num30;
				}
				if (i == 0)
				{
					LineLineIntersection(num2, num3, num21, num22, num4, num5, num23, num24, ref p);
					if (p[0] == 1.0)
					{
						initialConvexPoly[0] = p[1];
						initialConvexPoly[1] = p[2];
						initialConvexPoly[2] = wedges[i * 16 + 16];
						initialConvexPoly[3] = wedges[i * 16 + 17];
						initialConvexPoly[4] = wedges[i * 16 + 12];
						initialConvexPoly[5] = wedges[i * 16 + 13];
						initialConvexPoly[6] = wedges[i * 16 + 8];
						initialConvexPoly[7] = wedges[i * 16 + 9];
						initialConvexPoly[8] = num19;
						initialConvexPoly[9] = num20;
						initialConvexPoly[10] = wedges[i * 16 + 22];
						initialConvexPoly[11] = wedges[i * 16 + 23];
						initialConvexPoly[12] = wedges[i * 16 + 26];
						initialConvexPoly[13] = wedges[i * 16 + 27];
						initialConvexPoly[14] = wedges[i * 16 + 30];
						initialConvexPoly[15] = wedges[i * 16 + 31];
					}
				}
				num2 = num4;
				num3 = num5;
				num4 = num9;
				num5 = num10;
			}
			if (numpoints != 0)
			{
				int num31 = (numpoints - 1) / 2 + 1;
				int num32 = 0;
				int num33 = 0;
				int i = 1;
				int numvertices = 8;
				for (int j = 0; j < 32; j += 4)
				{
					num = HalfPlaneIntersection(numvertices, ref initialConvexPoly, wedges[32 * num31 + j], wedges[32 * num31 + 1 + j], wedges[32 * num31 + 2 + j], wedges[32 * num31 + 3 + j]);
					if (num == 0)
					{
						return false;
					}
					numvertices = num;
				}
				for (num33++; num33 < numpoints - 1; num33++)
				{
					for (int j = 0; j < 32; j += 4)
					{
						num = HalfPlaneIntersection(numvertices, ref initialConvexPoly, wedges[32 * (i + num31 * num32) + j], wedges[32 * (i + num31 * num32) + 1 + j], wedges[32 * (i + num31 * num32) + 2 + j], wedges[32 * (i + num31 * num32) + 3 + j]);
						if (num == 0)
						{
							return false;
						}
						numvertices = num;
					}
					i += num32;
					num32 = (num32 + 1) % 2;
				}
				FindPolyCentroid(num, initialConvexPoly, ref newloc);
				if (!behavior.fixedArea)
				{
					return true;
				}
			}
			return false;
		}

		private bool GetWedgeIntersection(int numpoints, double[] points, ref double[] newloc)
		{
			if (2 * numpoints > petalx.Length)
			{
				petalx = new double[2 * numpoints];
				petaly = new double[2 * numpoints];
				petalr = new double[2 * numpoints];
				wedges = new double[2 * numpoints * 20 + 40];
				if (Behavior.Verbose)
				{
					SimpleLog.Instance.Info("NewLocation: resized work arrays (" + 2 * numpoints + ")");
				}
			}
			double[] p = new double[3];
			double[] p2 = new double[3];
			double[] p3 = new double[3];
			double[] p4 = new double[3];
			int num = 0;
			int num2 = 0;
			double num3 = 4.0;
			double num4 = 4.0;
			double num5 = points[2 * numpoints - 4];
			double num6 = points[2 * numpoints - 3];
			double num7 = points[2 * numpoints - 2];
			double num8 = points[2 * numpoints - 1];
			double num9 = behavior.MinAngle * Math.PI / 180.0;
			double num10 = Math.Sin(num9);
			double num11 = Math.Cos(num9);
			double num12 = behavior.MaxAngle * Math.PI / 180.0;
			double num13 = Math.Sin(num12);
			double num14 = Math.Cos(num12);
			double num15;
			double num16;
			if (behavior.goodAngle == 1.0)
			{
				num15 = 0.0;
				num16 = 0.0;
			}
			else
			{
				num15 = 0.5 / Math.Tan(num9);
				num16 = 0.5 / Math.Sin(num9);
			}
			for (int i = 0; i < numpoints * 2; i += 2)
			{
				double num17 = points[i];
				double num18 = points[i + 1];
				double num19 = num7 - num5;
				double num20 = num8 - num6;
				double num21 = Math.Sqrt(num19 * num19 + num20 * num20);
				petalx[i / 2] = num5 + 0.5 * num19 - num15 * num20;
				petaly[i / 2] = num6 + 0.5 * num20 + num15 * num19;
				petalr[i / 2] = num16 * num21;
				petalx[numpoints + i / 2] = petalx[i / 2];
				petaly[numpoints + i / 2] = petaly[i / 2];
				petalr[numpoints + i / 2] = petalr[i / 2];
				double num22 = (num5 + num7) / 2.0;
				double num23 = (num6 + num8) / 2.0;
				double num24 = Math.Sqrt((petalx[i / 2] - num22) * (petalx[i / 2] - num22) + (petaly[i / 2] - num23) * (petaly[i / 2] - num23));
				double num25 = (petalx[i / 2] - num22) / num24;
				double num26 = (petaly[i / 2] - num23) / num24;
				double num27 = petalx[i / 2] + num25 * petalr[i / 2];
				double num28 = petaly[i / 2] + num26 * petalr[i / 2];
				num25 = num7 - num5;
				num26 = num8 - num6;
				double num29 = num7 * num11 - num8 * num10 + num5 - num5 * num11 + num6 * num10;
				double num30 = num7 * num10 + num8 * num11 + num6 - num5 * num10 - num6 * num11;
				wedges[i * 20] = num5;
				wedges[i * 20 + 1] = num6;
				wedges[i * 20 + 2] = num29;
				wedges[i * 20 + 3] = num30;
				num25 = num5 - num7;
				num26 = num6 - num8;
				double num31 = num5 * num11 + num6 * num10 + num7 - num7 * num11 - num8 * num10;
				double num32 = (0.0 - num5) * num10 + num6 * num11 + num8 + num7 * num10 - num8 * num11;
				wedges[i * 20 + 4] = num31;
				wedges[i * 20 + 5] = num32;
				wedges[i * 20 + 6] = num7;
				wedges[i * 20 + 7] = num8;
				num25 = num27 - petalx[i / 2];
				num26 = num28 - petaly[i / 2];
				double num33 = num27;
				double num34 = num28;
				num9 = 2.0 * behavior.MaxAngle + behavior.MinAngle - 180.0;
				if (num9 <= 0.0)
				{
					num2 = 4;
					num3 = 1.0;
					num4 = 1.0;
				}
				else if (num9 <= 5.0)
				{
					num2 = 6;
					num3 = 2.0;
					num4 = 2.0;
				}
				else if (num9 <= 10.0)
				{
					num2 = 8;
					num3 = 3.0;
					num4 = 3.0;
				}
				else
				{
					num2 = 10;
					num3 = 4.0;
					num4 = 4.0;
				}
				num9 = num9 * Math.PI / 180.0;
				for (int j = 1; (double)j < num3; j++)
				{
					if (num3 != 1.0)
					{
						double num35 = num27 * Math.Cos(num9 / (num3 - 1.0) * (double)j) + num28 * Math.Sin(num9 / (num3 - 1.0) * (double)j) + petalx[i / 2] - petalx[i / 2] * Math.Cos(num9 / (num3 - 1.0) * (double)j) - petaly[i / 2] * Math.Sin(num9 / (num3 - 1.0) * (double)j);
						double num36 = (0.0 - num27) * Math.Sin(num9 / (num3 - 1.0) * (double)j) + num28 * Math.Cos(num9 / (num3 - 1.0) * (double)j) + petaly[i / 2] + petalx[i / 2] * Math.Sin(num9 / (num3 - 1.0) * (double)j) - petaly[i / 2] * Math.Cos(num9 / (num3 - 1.0) * (double)j);
						wedges[i * 20 + 8 + 4 * (j - 1)] = num35;
						wedges[i * 20 + 9 + 4 * (j - 1)] = num36;
						wedges[i * 20 + 10 + 4 * (j - 1)] = num33;
						wedges[i * 20 + 11 + 4 * (j - 1)] = num34;
						num33 = num35;
						num34 = num36;
					}
				}
				num25 = num5 - num7;
				num26 = num6 - num8;
				double num37 = num5 * num14 + num6 * num13 + num7 - num7 * num14 - num8 * num13;
				double num38 = (0.0 - num5) * num13 + num6 * num14 + num8 + num7 * num13 - num8 * num14;
				wedges[i * 20 + 20] = num7;
				wedges[i * 20 + 21] = num8;
				wedges[i * 20 + 22] = num37;
				wedges[i * 20 + 23] = num38;
				num33 = num27;
				num34 = num28;
				for (int j = 1; (double)j < num4; j++)
				{
					if (num4 != 1.0)
					{
						double num39 = num27 * Math.Cos(num9 / (num4 - 1.0) * (double)j) - num28 * Math.Sin(num9 / (num4 - 1.0) * (double)j) + petalx[i / 2] - petalx[i / 2] * Math.Cos(num9 / (num4 - 1.0) * (double)j) + petaly[i / 2] * Math.Sin(num9 / (num4 - 1.0) * (double)j);
						double num40 = num27 * Math.Sin(num9 / (num4 - 1.0) * (double)j) + num28 * Math.Cos(num9 / (num4 - 1.0) * (double)j) + petaly[i / 2] - petalx[i / 2] * Math.Sin(num9 / (num4 - 1.0) * (double)j) - petaly[i / 2] * Math.Cos(num9 / (num4 - 1.0) * (double)j);
						wedges[i * 20 + 24 + 4 * (j - 1)] = num33;
						wedges[i * 20 + 25 + 4 * (j - 1)] = num34;
						wedges[i * 20 + 26 + 4 * (j - 1)] = num39;
						wedges[i * 20 + 27 + 4 * (j - 1)] = num40;
						num33 = num39;
						num34 = num40;
					}
				}
				num25 = num7 - num5;
				num26 = num8 - num6;
				double num41 = num7 * num14 - num8 * num13 + num5 - num5 * num14 + num6 * num13;
				double num42 = num7 * num13 + num8 * num14 + num6 - num5 * num13 - num6 * num14;
				wedges[i * 20 + 36] = num41;
				wedges[i * 20 + 37] = num42;
				wedges[i * 20 + 38] = num5;
				wedges[i * 20 + 39] = num6;
				if (i == 0)
				{
					switch (num2)
					{
					case 4:
						LineLineIntersection(num5, num6, num29, num30, num7, num8, num31, num32, ref p);
						LineLineIntersection(num5, num6, num29, num30, num7, num8, num37, num38, ref p2);
						LineLineIntersection(num5, num6, num41, num42, num7, num8, num37, num38, ref p3);
						LineLineIntersection(num5, num6, num41, num42, num7, num8, num31, num32, ref p4);
						if (p[0] == 1.0 && p2[0] == 1.0 && p3[0] == 1.0 && p4[0] == 1.0)
						{
							initialConvexPoly[0] = p[1];
							initialConvexPoly[1] = p[2];
							initialConvexPoly[2] = p2[1];
							initialConvexPoly[3] = p2[2];
							initialConvexPoly[4] = p3[1];
							initialConvexPoly[5] = p3[2];
							initialConvexPoly[6] = p4[1];
							initialConvexPoly[7] = p4[2];
						}
						break;
					case 6:
						LineLineIntersection(num5, num6, num29, num30, num7, num8, num31, num32, ref p);
						LineLineIntersection(num5, num6, num29, num30, num7, num8, num37, num38, ref p2);
						LineLineIntersection(num5, num6, num41, num42, num7, num8, num31, num32, ref p3);
						if (p[0] == 1.0 && p2[0] == 1.0 && p3[0] == 1.0)
						{
							initialConvexPoly[0] = p[1];
							initialConvexPoly[1] = p[2];
							initialConvexPoly[2] = p2[1];
							initialConvexPoly[3] = p2[2];
							initialConvexPoly[4] = wedges[i * 20 + 8];
							initialConvexPoly[5] = wedges[i * 20 + 9];
							initialConvexPoly[6] = num27;
							initialConvexPoly[7] = num28;
							initialConvexPoly[8] = wedges[i * 20 + 26];
							initialConvexPoly[9] = wedges[i * 20 + 27];
							initialConvexPoly[10] = p3[1];
							initialConvexPoly[11] = p3[2];
						}
						break;
					case 8:
						LineLineIntersection(num5, num6, num29, num30, num7, num8, num31, num32, ref p);
						LineLineIntersection(num5, num6, num29, num30, num7, num8, num37, num38, ref p2);
						LineLineIntersection(num5, num6, num41, num42, num7, num8, num31, num32, ref p3);
						if (p[0] == 1.0 && p2[0] == 1.0 && p3[0] == 1.0)
						{
							initialConvexPoly[0] = p[1];
							initialConvexPoly[1] = p[2];
							initialConvexPoly[2] = p2[1];
							initialConvexPoly[3] = p2[2];
							initialConvexPoly[4] = wedges[i * 20 + 12];
							initialConvexPoly[5] = wedges[i * 20 + 13];
							initialConvexPoly[6] = wedges[i * 20 + 8];
							initialConvexPoly[7] = wedges[i * 20 + 9];
							initialConvexPoly[8] = num27;
							initialConvexPoly[9] = num28;
							initialConvexPoly[10] = wedges[i * 20 + 26];
							initialConvexPoly[11] = wedges[i * 20 + 27];
							initialConvexPoly[12] = wedges[i * 20 + 30];
							initialConvexPoly[13] = wedges[i * 20 + 31];
							initialConvexPoly[14] = p3[1];
							initialConvexPoly[15] = p3[2];
						}
						break;
					case 10:
						LineLineIntersection(num5, num6, num29, num30, num7, num8, num31, num32, ref p);
						LineLineIntersection(num5, num6, num29, num30, num7, num8, num37, num38, ref p2);
						LineLineIntersection(num5, num6, num41, num42, num7, num8, num31, num32, ref p3);
						if (p[0] == 1.0 && p2[0] == 1.0 && p3[0] == 1.0)
						{
							initialConvexPoly[0] = p[1];
							initialConvexPoly[1] = p[2];
							initialConvexPoly[2] = p2[1];
							initialConvexPoly[3] = p2[2];
							initialConvexPoly[4] = wedges[i * 20 + 16];
							initialConvexPoly[5] = wedges[i * 20 + 17];
							initialConvexPoly[6] = wedges[i * 20 + 12];
							initialConvexPoly[7] = wedges[i * 20 + 13];
							initialConvexPoly[8] = wedges[i * 20 + 8];
							initialConvexPoly[9] = wedges[i * 20 + 9];
							initialConvexPoly[10] = num27;
							initialConvexPoly[11] = num28;
							initialConvexPoly[12] = wedges[i * 20 + 28];
							initialConvexPoly[13] = wedges[i * 20 + 29];
							initialConvexPoly[14] = wedges[i * 20 + 32];
							initialConvexPoly[15] = wedges[i * 20 + 33];
							initialConvexPoly[16] = wedges[i * 20 + 34];
							initialConvexPoly[17] = wedges[i * 20 + 35];
							initialConvexPoly[18] = p3[1];
							initialConvexPoly[19] = p3[2];
						}
						break;
					}
				}
				num5 = num7;
				num6 = num8;
				num7 = num17;
				num8 = num18;
			}
			if (numpoints != 0)
			{
				int num43 = (numpoints - 1) / 2 + 1;
				int num44 = 0;
				int num45 = 0;
				int i = 1;
				int numvertices = num2;
				for (int j = 0; j < 40; j += 4)
				{
					if ((num2 != 4 || (j != 8 && j != 12 && j != 16 && j != 24 && j != 28 && j != 32)) && (num2 != 6 || (j != 12 && j != 16 && j != 28 && j != 32)) && (num2 != 8 || (j != 16 && j != 32)))
					{
						num = HalfPlaneIntersection(numvertices, ref initialConvexPoly, wedges[40 * num43 + j], wedges[40 * num43 + 1 + j], wedges[40 * num43 + 2 + j], wedges[40 * num43 + 3 + j]);
						if (num == 0)
						{
							return false;
						}
						numvertices = num;
					}
				}
				for (num45++; num45 < numpoints - 1; num45++)
				{
					for (int j = 0; j < 40; j += 4)
					{
						if ((num2 != 4 || (j != 8 && j != 12 && j != 16 && j != 24 && j != 28 && j != 32)) && (num2 != 6 || (j != 12 && j != 16 && j != 28 && j != 32)) && (num2 != 8 || (j != 16 && j != 32)))
						{
							num = HalfPlaneIntersection(numvertices, ref initialConvexPoly, wedges[40 * (i + num43 * num44) + j], wedges[40 * (i + num43 * num44) + 1 + j], wedges[40 * (i + num43 * num44) + 2 + j], wedges[40 * (i + num43 * num44) + 3 + j]);
							if (num == 0)
							{
								return false;
							}
							numvertices = num;
						}
					}
					i += num44;
					num44 = (num44 + 1) % 2;
				}
				FindPolyCentroid(num, initialConvexPoly, ref newloc);
				if (behavior.MaxAngle == 0.0)
				{
					return true;
				}
				int num46 = 0;
				for (int j = 0; j < numpoints * 2 - 2; j += 2)
				{
					if (IsBadTriangleAngle(newloc[0], newloc[1], points[j], points[j + 1], points[j + 2], points[j + 3]))
					{
						num46++;
					}
				}
				if (IsBadTriangleAngle(newloc[0], newloc[1], points[0], points[1], points[numpoints * 2 - 2], points[numpoints * 2 - 1]))
				{
					num46++;
				}
				if (num46 == 0)
				{
					return true;
				}
				int num47 = ((numpoints <= 2) ? 20 : 30);
				for (int k = 0; k < 2 * numpoints; k += 2)
				{
					for (int l = 1; l < num47; l++)
					{
						newloc[0] = 0.0;
						newloc[1] = 0.0;
						for (i = 0; i < 2 * numpoints; i += 2)
						{
							double num48 = 1.0 / (double)numpoints;
							if (i == k)
							{
								newloc[0] = newloc[0] + 0.1 * (double)l * num48 * points[i];
								newloc[1] = newloc[1] + 0.1 * (double)l * num48 * points[i + 1];
							}
							else
							{
								num48 = (1.0 - 0.1 * (double)l * num48) / ((double)numpoints - 1.0);
								newloc[0] = newloc[0] + num48 * points[i];
								newloc[1] = newloc[1] + num48 * points[i + 1];
							}
						}
						num46 = 0;
						for (int j = 0; j < numpoints * 2 - 2; j += 2)
						{
							if (IsBadTriangleAngle(newloc[0], newloc[1], points[j], points[j + 1], points[j + 2], points[j + 3]))
							{
								num46++;
							}
						}
						if (IsBadTriangleAngle(newloc[0], newloc[1], points[0], points[1], points[numpoints * 2 - 2], points[numpoints * 2 - 1]))
						{
							num46++;
						}
						if (num46 == 0)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		private bool ValidPolygonAngles(int numpoints, double[] points)
		{
			for (int i = 0; i < numpoints; i++)
			{
				if (i == numpoints - 1)
				{
					if (IsBadPolygonAngle(points[i * 2], points[i * 2 + 1], points[0], points[1], points[2], points[3]))
					{
						return false;
					}
				}
				else if (i == numpoints - 2)
				{
					if (IsBadPolygonAngle(points[i * 2], points[i * 2 + 1], points[(i + 1) * 2], points[(i + 1) * 2 + 1], points[0], points[1]))
					{
						return false;
					}
				}
				else if (IsBadPolygonAngle(points[i * 2], points[i * 2 + 1], points[(i + 1) * 2], points[(i + 1) * 2 + 1], points[(i + 2) * 2], points[(i + 2) * 2 + 1]))
				{
					return false;
				}
			}
			return true;
		}

		private bool IsBadPolygonAngle(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			double num = x1 - x2;
			double num2 = y1 - y2;
			double num3 = x2 - x3;
			double num4 = y2 - y3;
			double num5 = x3 - x1;
			double num6 = y3 - y1;
			double num7 = num * num + num2 * num2;
			double num8 = num3 * num3 + num4 * num4;
			double num9 = num5 * num5 + num6 * num6;
			if (Math.Acos((num7 + num8 - num9) / (2.0 * Math.Sqrt(num7) * Math.Sqrt(num8))) < 2.0 * Math.Acos(Math.Sqrt(behavior.goodAngle)))
			{
				return true;
			}
			return false;
		}

		private void LineLineIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, ref double[] p)
		{
			double num = (y4 - y3) * (x2 - x1) - (x4 - x3) * (y2 - y1);
			double num2 = (x4 - x3) * (y1 - y3) - (y4 - y3) * (x1 - x3);
			double num3 = (x2 - x1) * (y1 - y3) - (y2 - y1) * (x1 - x3);
			if (Math.Abs(num - 0.0) < 1E-50 && Math.Abs(num3 - 0.0) < 1E-50 && Math.Abs(num2 - 0.0) < 1E-50)
			{
				p[0] = 0.0;
				return;
			}
			if (Math.Abs(num - 0.0) < 1E-50)
			{
				p[0] = 0.0;
				return;
			}
			p[0] = 1.0;
			num2 /= num;
			num3 /= num;
			p[1] = x1 + num2 * (x2 - x1);
			p[2] = y1 + num2 * (y2 - y1);
		}

		private int HalfPlaneIntersection(int numvertices, ref double[] convexPoly, double x1, double y1, double x2, double y2)
		{
			double[] array = null;
			int i = 0;
			int num = 0;
			double num2 = x2 - x1;
			double num3 = y2 - y1;
			int num4 = SplitConvexPolygon(numvertices, convexPoly, x1, y1, x2, y2, ref polys);
			if (num4 == 3)
			{
				i = numvertices;
			}
			else
			{
				for (int j = 0; j < num4; j++)
				{
					double num5 = 1E+17;
					double num6 = -1E+17;
					double num7;
					for (int k = 1; (double)k <= 2.0 * polys[j][0] - 1.0; k += 2)
					{
						num7 = num2 * (polys[j][k + 1] - y1) - num3 * (polys[j][k] - x1);
						num5 = ((num7 < num5) ? num7 : num5);
						num6 = ((num7 > num6) ? num7 : num6);
					}
					num7 = ((Math.Abs(num5) > Math.Abs(num6)) ? num5 : num6);
					if (num7 > 0.0)
					{
						array = polys[j];
						num = 1;
						break;
					}
				}
				if (num == 1)
				{
					for (; (double)i < array[0]; i++)
					{
						convexPoly[2 * i] = array[2 * i + 1];
						convexPoly[2 * i + 1] = array[2 * i + 2];
					}
				}
			}
			return i;
		}

		private int SplitConvexPolygon(int numvertices, double[] convexPoly, double x1, double y1, double x2, double y2, ref double[][] polys)
		{
			int num = 0;
			double[] p = new double[3];
			int num2 = 0;
			int num3 = 0;
			double num4 = 1E-12;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			for (int i = 0; i < 2 * numvertices; i += 2)
			{
				int num13 = ((i + 2 < 2 * numvertices) ? (i + 2) : 0);
				LineLineSegmentIntersection(x1, y1, x2, y2, convexPoly[i], convexPoly[i + 1], convexPoly[num13], convexPoly[num13 + 1], ref p);
				if (Math.Abs(p[0] - 0.0) <= num4)
				{
					if (num == 1)
					{
						num3++;
						poly2[2 * num3 - 1] = convexPoly[num13];
						poly2[2 * num3] = convexPoly[num13 + 1];
					}
					else
					{
						num2++;
						poly1[2 * num2 - 1] = convexPoly[num13];
						poly1[2 * num2] = convexPoly[num13 + 1];
					}
					num5++;
					continue;
				}
				if (Math.Abs(p[0] - 2.0) <= num4)
				{
					num2++;
					poly1[2 * num2 - 1] = convexPoly[num13];
					poly1[2 * num2] = convexPoly[num13 + 1];
					num6++;
					continue;
				}
				num7++;
				if (Math.Abs(p[1] - convexPoly[num13]) <= num4 && Math.Abs(p[2] - convexPoly[num13 + 1]) <= num4)
				{
					num8++;
					switch (num)
					{
					case 1:
						num3++;
						poly2[2 * num3 - 1] = convexPoly[num13];
						poly2[2 * num3] = convexPoly[num13 + 1];
						num2++;
						poly1[2 * num2 - 1] = convexPoly[num13];
						poly1[2 * num2] = convexPoly[num13 + 1];
						num++;
						break;
					case 0:
						num11++;
						num2++;
						poly1[2 * num2 - 1] = convexPoly[num13];
						poly1[2 * num2] = convexPoly[num13 + 1];
						if (i + 4 < 2 * numvertices)
						{
							int num14 = LinePointLocation(x1, y1, x2, y2, convexPoly[i], convexPoly[i + 1]);
							int num15 = LinePointLocation(x1, y1, x2, y2, convexPoly[i + 4], convexPoly[i + 5]);
							if (num14 != num15 && num14 != 0 && num15 != 0)
							{
								num12++;
								num3++;
								poly2[2 * num3 - 1] = convexPoly[num13];
								poly2[2 * num3] = convexPoly[num13 + 1];
								num++;
							}
						}
						break;
					}
				}
				else if (!(Math.Abs(p[1] - convexPoly[i]) <= num4) || !(Math.Abs(p[2] - convexPoly[i + 1]) <= num4))
				{
					num9++;
					num2++;
					poly1[2 * num2 - 1] = p[1];
					poly1[2 * num2] = p[2];
					num3++;
					poly2[2 * num3 - 1] = p[1];
					poly2[2 * num3] = p[2];
					switch (num)
					{
					case 1:
						num2++;
						poly1[2 * num2 - 1] = convexPoly[num13];
						poly1[2 * num2] = convexPoly[num13 + 1];
						break;
					case 0:
						num3++;
						poly2[2 * num3 - 1] = convexPoly[num13];
						poly2[2 * num3] = convexPoly[num13 + 1];
						break;
					}
					num++;
				}
				else
				{
					num10++;
					if (num == 1)
					{
						num3++;
						poly2[2 * num3 - 1] = convexPoly[num13];
						poly2[2 * num3] = convexPoly[num13 + 1];
					}
					else
					{
						num2++;
						poly1[2 * num2 - 1] = convexPoly[num13];
						poly1[2 * num2] = convexPoly[num13 + 1];
					}
				}
			}
			int result;
			if (num != 0 && num != 2)
			{
				result = 3;
			}
			else
			{
				result = ((num == 0) ? 1 : 2);
				poly1[0] = num2;
				poly2[0] = num3;
				polys[0] = poly1;
				if (num == 2)
				{
					polys[1] = poly2;
				}
			}
			return result;
		}

		private int LinePointLocation(double x1, double y1, double x2, double y2, double x, double y)
		{
			if (Math.Atan((y2 - y1) / (x2 - x1)) * 180.0 / Math.PI == 90.0)
			{
				if (Math.Abs(x1 - x) <= 1E-11)
				{
					return 0;
				}
			}
			else if (Math.Abs(y1 + (y2 - y1) * (x - x1) / (x2 - x1) - y) <= 1E-50)
			{
				return 0;
			}
			double num = (x2 - x1) * (y - y1) - (y2 - y1) * (x - x1);
			if (Math.Abs(num - 0.0) <= 1E-11)
			{
				return 0;
			}
			if (num > 0.0)
			{
				return 1;
			}
			return 2;
		}

		private void LineLineSegmentIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, ref double[] p)
		{
			double num = 1E-13;
			double num2 = (y4 - y3) * (x2 - x1) - (x4 - x3) * (y2 - y1);
			double num3 = (x4 - x3) * (y1 - y3) - (y4 - y3) * (x1 - x3);
			double num4 = (x2 - x1) * (y1 - y3) - (y2 - y1) * (x1 - x3);
			if (Math.Abs(num2 - 0.0) < num)
			{
				if (Math.Abs(num4 - 0.0) < num && Math.Abs(num3 - 0.0) < num)
				{
					p[0] = 2.0;
				}
				else
				{
					p[0] = 0.0;
				}
				return;
			}
			num4 /= num2;
			num3 /= num2;
			if (num4 < 0.0 - num || num4 > 1.0 + num)
			{
				p[0] = 0.0;
				return;
			}
			p[0] = 1.0;
			p[1] = x1 + num3 * (x2 - x1);
			p[2] = y1 + num3 * (y2 - y1);
		}

		private void FindPolyCentroid(int numpoints, double[] points, ref double[] centroid)
		{
			centroid[0] = 0.0;
			centroid[1] = 0.0;
			for (int i = 0; i < 2 * numpoints; i += 2)
			{
				centroid[0] = centroid[0] + points[i];
				centroid[1] = centroid[1] + points[i + 1];
			}
			centroid[0] = centroid[0] / (double)numpoints;
			centroid[1] = centroid[1] / (double)numpoints;
		}

		private void CircleLineIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double r, ref double[] p)
		{
			double num = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
			double num2 = 2.0 * ((x2 - x1) * (x1 - x3) + (y2 - y1) * (y1 - y3));
			double num3 = x3 * x3 + y3 * y3 + x1 * x1 + y1 * y1 - 2.0 * (x3 * x1 + y3 * y1) - r * r;
			double num4 = num2 * num2 - 4.0 * num * num3;
			if (num4 < 0.0)
			{
				p[0] = 0.0;
			}
			else if (Math.Abs(num4 - 0.0) < 1E-50)
			{
				p[0] = 1.0;
				double num5 = (0.0 - num2) / (2.0 * num);
				p[1] = x1 + num5 * (x2 - x1);
				p[2] = y1 + num5 * (y2 - y1);
			}
			else if (num4 > 0.0 && !(Math.Abs(num - 0.0) < 1E-50))
			{
				p[0] = 2.0;
				double num5 = (0.0 - num2 + Math.Sqrt(num4)) / (2.0 * num);
				p[1] = x1 + num5 * (x2 - x1);
				p[2] = y1 + num5 * (y2 - y1);
				num5 = (0.0 - num2 - Math.Sqrt(num4)) / (2.0 * num);
				p[3] = x1 + num5 * (x2 - x1);
				p[4] = y1 + num5 * (y2 - y1);
			}
			else
			{
				p[0] = 0.0;
			}
		}

		private bool ChooseCorrectPoint(double x1, double y1, double x2, double y2, double x3, double y3, bool isObtuse)
		{
			double num = (x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3);
			double num2 = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
			if (isObtuse)
			{
				if (num2 >= num)
				{
					return true;
				}
				return false;
			}
			if (num2 < num)
			{
				return true;
			}
			return false;
		}

		private void PointBetweenPoints(double x1, double y1, double x2, double y2, double x, double y, ref double[] p)
		{
			if ((x2 - x) * (x2 - x) + (y2 - y) * (y2 - y) < (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1))
			{
				p[0] = 1.0;
				p[1] = (x - x2) * (x - x2) + (y - y2) * (y - y2);
				p[2] = x;
				p[3] = y;
			}
			else
			{
				p[0] = 0.0;
				p[1] = 0.0;
				p[2] = 0.0;
				p[3] = 0.0;
			}
		}

		private bool IsBadTriangleAngle(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			double num = x1 - x2;
			double num2 = y1 - y2;
			double num3 = x2 - x3;
			double num4 = y2 - y3;
			double num5 = x3 - x1;
			double num6 = y3 - y1;
			double num7 = num * num;
			double num8 = num2 * num2;
			double num9 = num3 * num3;
			double num10 = num4 * num4;
			double num11 = num5 * num5;
			double num12 = num6 * num6;
			double num13 = num7 + num8;
			double num14 = num9 + num10;
			double num15 = num11 + num12;
			double num16;
			if (num13 < num14 && num13 < num15)
			{
				num16 = num3 * num5 + num4 * num6;
				num16 = num16 * num16 / (num14 * num15);
			}
			else if (num14 < num15)
			{
				num16 = num * num5 + num2 * num6;
				num16 = num16 * num16 / (num13 * num15);
			}
			else
			{
				num16 = num * num3 + num2 * num4;
				num16 = num16 * num16 / (num13 * num14);
			}
			double num17 = ((num13 > num14 && num13 > num15) ? ((num14 + num15 - num13) / (2.0 * Math.Sqrt(num14 * num15))) : ((!(num14 > num15)) ? ((num13 + num14 - num15) / (2.0 * Math.Sqrt(num13 * num14))) : ((num13 + num15 - num14) / (2.0 * Math.Sqrt(num13 * num15)))));
			if (num16 > behavior.goodAngle || (behavior.MaxAngle != 0.0 && num17 < behavior.maxGoodAngle))
			{
				return true;
			}
			return false;
		}

		private double MinDistanceToNeighbor(double newlocX, double newlocY, ref Otri searchtri)
		{
			Otri o = default(Otri);
			LocateResult locateResult = LocateResult.Outside;
			Point point = new Point(newlocX, newlocY);
			Vertex vertex = searchtri.Org();
			Vertex vertex2 = searchtri.Dest();
			if (vertex.x == point.x && vertex.y == point.y)
			{
				locateResult = LocateResult.OnVertex;
				searchtri.Copy(ref o);
			}
			else if (vertex2.x == point.x && vertex2.y == point.y)
			{
				searchtri.LnextSelf();
				locateResult = LocateResult.OnVertex;
				searchtri.Copy(ref o);
			}
			else
			{
				double num = Primitives.CounterClockwise(vertex, vertex2, point);
				if (num < 0.0)
				{
					searchtri.SymSelf();
					searchtri.Copy(ref o);
					locateResult = mesh.locator.PreciseLocate(point, ref o, stopatsubsegment: false);
				}
				else if (num == 0.0)
				{
					if (vertex.x < point.x == point.x < vertex2.x && vertex.y < point.y == point.y < vertex2.y)
					{
						locateResult = LocateResult.OnEdge;
						searchtri.Copy(ref o);
					}
				}
				else
				{
					searchtri.Copy(ref o);
					locateResult = mesh.locator.PreciseLocate(point, ref o, stopatsubsegment: false);
				}
			}
			if (locateResult == LocateResult.OnVertex || locateResult == LocateResult.Outside)
			{
				return 0.0;
			}
			Vertex vertex3 = o.Org();
			Vertex vertex4 = o.Dest();
			Vertex vertex5 = o.Apex();
			double num2 = (vertex3.x - point.x) * (vertex3.x - point.x) + (vertex3.y - point.y) * (vertex3.y - point.y);
			double num3 = (vertex4.x - point.x) * (vertex4.x - point.x) + (vertex4.y - point.y) * (vertex4.y - point.y);
			double num4 = (vertex5.x - point.x) * (vertex5.x - point.x) + (vertex5.y - point.y) * (vertex5.y - point.y);
			if (num2 <= num3 && num2 <= num4)
			{
				return num2;
			}
			if (num3 <= num4)
			{
				return num3;
			}
			return num4;
		}
	}
	internal class QualityMesher
	{
		private Queue<BadSubseg> badsubsegs;

		private BadTriQueue queue;

		private Mesh mesh;

		private Behavior behavior;

		private NewLocation newLocation;

		private ILog<SimpleLogItem> logger;

		public QualityMesher(Mesh mesh)
		{
			logger = SimpleLog.Instance;
			badsubsegs = new Queue<BadSubseg>();
			queue = new BadTriQueue();
			this.mesh = mesh;
			behavior = mesh.behavior;
			newLocation = new NewLocation(mesh);
		}

		public void AddBadSubseg(BadSubseg badseg)
		{
			badsubsegs.Enqueue(badseg);
		}

		public int CheckSeg4Encroach(ref Osub testsubseg)
		{
			Otri ot = default(Otri);
			Osub o = default(Osub);
			int num = 0;
			int num2 = 0;
			Vertex vertex = testsubseg.Org();
			Vertex vertex2 = testsubseg.Dest();
			testsubseg.TriPivot(ref ot);
			if (ot.triangle != Mesh.dummytri)
			{
				num2++;
				Vertex vertex3 = ot.Apex();
				double num3 = (vertex.x - vertex3.x) * (vertex2.x - vertex3.x) + (vertex.y - vertex3.y) * (vertex2.y - vertex3.y);
				if (num3 < 0.0 && (behavior.ConformingDelaunay || num3 * num3 >= (2.0 * behavior.goodAngle - 1.0) * (2.0 * behavior.goodAngle - 1.0) * ((vertex.x - vertex3.x) * (vertex.x - vertex3.x) + (vertex.y - vertex3.y) * (vertex.y - vertex3.y)) * ((vertex2.x - vertex3.x) * (vertex2.x - vertex3.x) + (vertex2.y - vertex3.y) * (vertex2.y - vertex3.y))))
				{
					num = 1;
				}
			}
			testsubseg.Sym(ref o);
			o.TriPivot(ref ot);
			if (ot.triangle != Mesh.dummytri)
			{
				num2++;
				Vertex vertex3 = ot.Apex();
				double num3 = (vertex.x - vertex3.x) * (vertex2.x - vertex3.x) + (vertex.y - vertex3.y) * (vertex2.y - vertex3.y);
				if (num3 < 0.0 && (behavior.ConformingDelaunay || num3 * num3 >= (2.0 * behavior.goodAngle - 1.0) * (2.0 * behavior.goodAngle - 1.0) * ((vertex.x - vertex3.x) * (vertex.x - vertex3.x) + (vertex.y - vertex3.y) * (vertex.y - vertex3.y)) * ((vertex2.x - vertex3.x) * (vertex2.x - vertex3.x) + (vertex2.y - vertex3.y) * (vertex2.y - vertex3.y))))
				{
					num += 2;
				}
			}
			if (num > 0 && (behavior.NoBisect == 0 || (behavior.NoBisect == 1 && num2 == 2)))
			{
				BadSubseg badSubseg = new BadSubseg();
				if (num == 1)
				{
					badSubseg.encsubseg = testsubseg;
					badSubseg.subsegorg = vertex;
					badSubseg.subsegdest = vertex2;
				}
				else
				{
					badSubseg.encsubseg = o;
					badSubseg.subsegorg = vertex2;
					badSubseg.subsegdest = vertex;
				}
				badsubsegs.Enqueue(badSubseg);
			}
			return num;
		}

		public void TestTriangle(ref Otri testtri)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Osub os = default(Osub);
			Vertex vertex = testtri.Org();
			Vertex vertex2 = testtri.Dest();
			Vertex vertex3 = testtri.Apex();
			double num = vertex.x - vertex2.x;
			double num2 = vertex.y - vertex2.y;
			double num3 = vertex2.x - vertex3.x;
			double num4 = vertex2.y - vertex3.y;
			double num5 = vertex3.x - vertex.x;
			double num6 = vertex3.y - vertex.y;
			double num7 = num * num;
			double num8 = num2 * num2;
			double num9 = num3 * num3;
			double num10 = num4 * num4;
			double num11 = num5 * num5;
			double num12 = num6 * num6;
			double num13 = num7 + num8;
			double num14 = num9 + num10;
			double num15 = num11 + num12;
			double minedge;
			Vertex vertex4;
			Vertex vertex5;
			double num16;
			if (num13 < num14 && num13 < num15)
			{
				minedge = num13;
				num16 = num3 * num5 + num4 * num6;
				num16 = num16 * num16 / (num14 * num15);
				vertex4 = vertex;
				vertex5 = vertex2;
				testtri.Copy(ref o);
			}
			else if (num14 < num15)
			{
				minedge = num14;
				num16 = num * num5 + num2 * num6;
				num16 = num16 * num16 / (num13 * num15);
				vertex4 = vertex2;
				vertex5 = vertex3;
				testtri.Lnext(ref o);
			}
			else
			{
				minedge = num15;
				num16 = num * num3 + num2 * num4;
				num16 = num16 * num16 / (num13 * num14);
				vertex4 = vertex3;
				vertex5 = vertex;
				testtri.Lprev(ref o);
			}
			if (behavior.VarArea || behavior.fixedArea || behavior.UserTest != null)
			{
				double num17 = 0.5 * (num * num4 - num2 * num3);
				if (behavior.fixedArea && num17 > behavior.MaxArea)
				{
					queue.Enqueue(ref testtri, minedge, vertex3, vertex, vertex2);
					return;
				}
				if (behavior.VarArea && num17 > testtri.triangle.area && testtri.triangle.area > 0.0)
				{
					queue.Enqueue(ref testtri, minedge, vertex3, vertex, vertex2);
					return;
				}
				if (behavior.UserTest != null && behavior.UserTest(testtri.triangle, num17))
				{
					queue.Enqueue(ref testtri, minedge, vertex3, vertex, vertex2);
					return;
				}
			}
			double num18 = ((num13 > num14 && num13 > num15) ? ((num14 + num15 - num13) / (2.0 * Math.Sqrt(num14 * num15))) : ((!(num14 > num15)) ? ((num13 + num14 - num15) / (2.0 * Math.Sqrt(num13 * num14))) : ((num13 + num15 - num14) / (2.0 * Math.Sqrt(num13 * num15)))));
			if (!(num16 > behavior.goodAngle) && (!(num18 < behavior.maxGoodAngle) || behavior.MaxAngle == 0.0))
			{
				return;
			}
			if (vertex4.type == VertexType.SegmentVertex && vertex5.type == VertexType.SegmentVertex)
			{
				o.SegPivot(ref os);
				if (os.seg == Mesh.dummysub)
				{
					o.Copy(ref o2);
					do
					{
						o.OprevSelf();
						o.SegPivot(ref os);
					}
					while (os.seg == Mesh.dummysub);
					Vertex vertex6 = os.SegOrg();
					Vertex vertex7 = os.SegDest();
					do
					{
						o2.DnextSelf();
						o2.SegPivot(ref os);
					}
					while (os.seg == Mesh.dummysub);
					Vertex vertex8 = os.SegOrg();
					Vertex vertex9 = os.SegDest();
					Vertex vertex10 = null;
					if (vertex7.x == vertex8.x && vertex7.y == vertex8.y)
					{
						vertex10 = vertex7;
					}
					else if (vertex6.x == vertex9.x && vertex6.y == vertex9.y)
					{
						vertex10 = vertex6;
					}
					if (vertex10 != null)
					{
						double num19 = (vertex4.x - vertex10.x) * (vertex4.x - vertex10.x) + (vertex4.y - vertex10.y) * (vertex4.y - vertex10.y);
						double num20 = (vertex5.x - vertex10.x) * (vertex5.x - vertex10.x) + (vertex5.y - vertex10.y) * (vertex5.y - vertex10.y);
						if (num19 < 1.001 * num20 && num19 > 0.999 * num20)
						{
							return;
						}
					}
				}
			}
			queue.Enqueue(ref testtri, minedge, vertex3, vertex, vertex2);
		}

		private void TallyEncs()
		{
			Osub testsubseg = new Osub
			{
				orient = 0
			};
			foreach (Segment value in mesh.subsegs.Values)
			{
				testsubseg.seg = value;
				CheckSeg4Encroach(ref testsubseg);
			}
		}

		private void SplitEncSegs(bool triflaws)
		{
			Otri ot = default(Otri);
			Otri o = default(Otri);
			Osub os = default(Osub);
			Osub osub = default(Osub);
			while (badsubsegs.Count > 0 && mesh.steinerleft != 0)
			{
				BadSubseg badSubseg = badsubsegs.Dequeue();
				osub = badSubseg.encsubseg;
				Vertex vertex = osub.Org();
				Vertex vertex2 = osub.Dest();
				if (!Osub.IsDead(osub.seg) && vertex == badSubseg.subsegorg && vertex2 == badSubseg.subsegdest)
				{
					osub.TriPivot(ref ot);
					ot.Lnext(ref o);
					o.SegPivot(ref os);
					bool flag = os.seg != Mesh.dummysub;
					o.LnextSelf();
					o.SegPivot(ref os);
					bool flag2 = os.seg != Mesh.dummysub;
					if (!behavior.ConformingDelaunay && !flag && !flag2)
					{
						Vertex vertex3 = ot.Apex();
						while (vertex3.type == VertexType.FreeVertex && (vertex.x - vertex3.x) * (vertex2.x - vertex3.x) + (vertex.y - vertex3.y) * (vertex2.y - vertex3.y) < 0.0)
						{
							mesh.DeleteVertex(ref o);
							osub.TriPivot(ref ot);
							vertex3 = ot.Apex();
							ot.Lprev(ref o);
						}
					}
					ot.Sym(ref o);
					if (o.triangle != Mesh.dummytri)
					{
						o.LnextSelf();
						o.SegPivot(ref os);
						bool flag3 = os.seg != Mesh.dummysub;
						flag2 = flag2 || flag3;
						o.LnextSelf();
						o.SegPivot(ref os);
						bool flag4 = os.seg != Mesh.dummysub;
						flag = flag || flag4;
						if (!behavior.ConformingDelaunay && !flag4 && !flag3)
						{
							Vertex vertex3 = o.Org();
							while (vertex3.type == VertexType.FreeVertex && (vertex.x - vertex3.x) * (vertex2.x - vertex3.x) + (vertex.y - vertex3.y) * (vertex2.y - vertex3.y) < 0.0)
							{
								mesh.DeleteVertex(ref o);
								ot.Sym(ref o);
								vertex3 = o.Apex();
								o.LprevSelf();
							}
						}
					}
					double num3;
					if (flag || flag2)
					{
						double num = Math.Sqrt((vertex2.x - vertex.x) * (vertex2.x - vertex.x) + (vertex2.y - vertex.y) * (vertex2.y - vertex.y));
						double num2 = 1.0;
						while (num > 3.0 * num2)
						{
							num2 *= 2.0;
						}
						while (num < 1.5 * num2)
						{
							num2 *= 0.5;
						}
						num3 = num2 / num;
						if (flag2)
						{
							num3 = 1.0 - num3;
						}
					}
					else
					{
						num3 = 0.5;
					}
					Vertex vertex4 = new Vertex(vertex.x + num3 * (vertex2.x - vertex.x), vertex.y + num3 * (vertex2.y - vertex.y), osub.Mark(), mesh.nextras);
					vertex4.type = VertexType.SegmentVertex;
					vertex4.hash = mesh.hash_vtx++;
					vertex4.id = vertex4.hash;
					mesh.vertices.Add(vertex4.hash, vertex4);
					for (int i = 0; i < mesh.nextras; i++)
					{
						vertex4.attributes[i] = vertex.attributes[i] + num3 * (vertex2.attributes[i] - vertex.attributes[i]);
					}
					if (!Behavior.NoExact)
					{
						double num4 = Primitives.CounterClockwise(vertex, vertex2, vertex4);
						double num5 = (vertex.x - vertex2.x) * (vertex.x - vertex2.x) + (vertex.y - vertex2.y) * (vertex.y - vertex2.y);
						if (num4 != 0.0 && num5 != 0.0)
						{
							num4 /= num5;
							if (!double.IsNaN(num4))
							{
								vertex4.x += num4 * (vertex2.y - vertex.y);
								vertex4.y += num4 * (vertex.x - vertex2.x);
							}
						}
					}
					if ((vertex4.x == vertex.x && vertex4.y == vertex.y) || (vertex4.x == vertex2.x && vertex4.y == vertex2.y))
					{
						logger.Error("Ran out of precision: I attempted to split a segment to a smaller size than can be accommodated by the finite precision of floating point arithmetic.", "Quality.SplitEncSegs()");
						throw new Exception("Ran out of precision");
					}
					InsertVertexResult insertVertexResult = mesh.InsertVertex(vertex4, ref ot, ref osub, segmentflaws: true, triflaws);
					if (insertVertexResult != InsertVertexResult.Successful && insertVertexResult != InsertVertexResult.Encroaching)
					{
						logger.Error("Failure to split a segment.", "Quality.SplitEncSegs()");
						throw new Exception("Failure to split a segment.");
					}
					if (mesh.steinerleft > 0)
					{
						mesh.steinerleft--;
					}
					CheckSeg4Encroach(ref osub);
					osub.NextSelf();
					CheckSeg4Encroach(ref osub);
				}
				badSubseg.subsegorg = null;
			}
		}

		private void TallyFaces()
		{
			Otri testtri = new Otri
			{
				orient = 0
			};
			foreach (Triangle value in mesh.triangles.Values)
			{
				testtri.triangle = value;
				TestTriangle(ref testtri);
			}
		}

		private void SplitTriangle(BadTriangle badtri)
		{
			Otri otri = default(Otri);
			double xi = 0.0;
			double eta = 0.0;
			otri = badtri.poortri;
			Vertex vertex = otri.Org();
			Vertex vertex2 = otri.Dest();
			Vertex vertex3 = otri.Apex();
			if (Otri.IsDead(otri.triangle) || !(vertex == badtri.triangorg) || !(vertex2 == badtri.triangdest) || !(vertex3 == badtri.triangapex))
			{
				return;
			}
			bool flag = false;
			Point point = ((!behavior.fixedArea && !behavior.VarArea) ? newLocation.FindLocation(vertex, vertex2, vertex3, ref xi, ref eta, offcenter: true, otri) : Primitives.FindCircumcenter(vertex, vertex2, vertex3, ref xi, ref eta, behavior.offconstant));
			if ((point.x == vertex.x && point.y == vertex.y) || (point.x == vertex2.x && point.y == vertex2.y) || (point.x == vertex3.x && point.y == vertex3.y))
			{
				if (Behavior.Verbose)
				{
					logger.Warning("New vertex falls on existing vertex.", "Quality.SplitTriangle()");
					flag = true;
				}
			}
			else
			{
				Vertex vertex4 = new Vertex(point.x, point.y, 0, mesh.nextras);
				vertex4.type = VertexType.FreeVertex;
				for (int i = 0; i < mesh.nextras; i++)
				{
					vertex4.attributes[i] = vertex.attributes[i] + xi * (vertex2.attributes[i] - vertex.attributes[i]) + eta * (vertex3.attributes[i] - vertex.attributes[i]);
				}
				if (eta < xi)
				{
					otri.LprevSelf();
				}
				Osub splitseg = default(Osub);
				switch (mesh.InsertVertex(vertex4, ref otri, ref splitseg, segmentflaws: true, triflaws: true))
				{
				case InsertVertexResult.Successful:
					vertex4.hash = mesh.hash_vtx++;
					vertex4.id = vertex4.hash;
					mesh.vertices.Add(vertex4.hash, vertex4);
					if (mesh.steinerleft > 0)
					{
						mesh.steinerleft--;
					}
					break;
				case InsertVertexResult.Encroaching:
					mesh.UndoVertex();
					break;
				default:
					if (Behavior.Verbose)
					{
						logger.Warning("New vertex falls on existing vertex.", "Quality.SplitTriangle()");
						flag = true;
					}
					break;
				case InsertVertexResult.Violating:
					break;
				}
			}
			if (flag)
			{
				logger.Error("The new vertex is at the circumcenter of triangle: This probably means that I am trying to refine triangles to a smaller size than can be accommodated by the finite precision of floating point arithmetic.", "Quality.SplitTriangle()");
				throw new Exception("The new vertex is at the circumcenter of triangle.");
			}
		}

		public void EnforceQuality()
		{
			TallyEncs();
			SplitEncSegs(triflaws: false);
			if (behavior.MinAngle > 0.0 || behavior.VarArea || behavior.fixedArea || behavior.UserTest != null)
			{
				TallyFaces();
				mesh.checkquality = true;
				while (queue.Count > 0 && mesh.steinerleft != 0)
				{
					BadTriangle badtri = queue.Dequeue();
					SplitTriangle(badtri);
					if (badsubsegs.Count > 0)
					{
						queue.Enqueue(badtri);
						SplitEncSegs(triflaws: true);
					}
				}
			}
			if (Behavior.Verbose && behavior.ConformingDelaunay && badsubsegs.Count > 0 && mesh.steinerleft == 0)
			{
				logger.Warning("I ran out of Steiner points, but the mesh has encroached subsegments, and therefore might not be truly Delaunay. If the Delaunay property is important to you, try increasing the number of Steiner points.", "Quality.EnforceQuality()");
			}
		}
	}
	public enum TriangulationAlgorithm
	{
		Dwyer,
		Incremental,
		SweepLine
	}
	internal enum LocateResult
	{
		InTriangle,
		OnEdge,
		OnVertex,
		Outside
	}
	internal enum InsertVertexResult
	{
		Successful,
		Encroaching,
		Violating,
		Duplicate
	}
	internal enum FindDirectionResult
	{
		Within,
		Leftcollinear,
		Rightcollinear
	}
	public enum VertexType
	{
		InputVertex,
		SegmentVertex,
		FreeVertex,
		DeadVertex,
		UndeadVertex
	}
	public enum NodeNumbering
	{
		None,
		Linear,
		CuthillMcKee
	}
	public class Mesh
	{
		private ILog<SimpleLogItem> logger;

		private QualityMesher quality;

		private Stack<Otri> flipstack;

		internal Dictionary<int, Triangle> triangles;

		internal Dictionary<int, Segment> subsegs;

		internal Dictionary<int, Vertex> vertices;

		internal int hash_vtx;

		internal int hash_seg;

		internal int hash_tri;

		internal List<Point> holes;

		internal List<RegionPointer> regions;

		internal BoundingBox bounds;

		internal int invertices;

		internal int inelements;

		internal int insegments;

		internal int undeads;

		internal int edges;

		internal int mesh_dim;

		internal int nextras;

		internal int hullsize;

		internal int steinerleft;

		internal bool checksegments;

		internal bool checkquality;

		internal Vertex infvertex1;

		internal Vertex infvertex2;

		internal Vertex infvertex3;

		internal static Triangle dummytri;

		internal static Segment dummysub;

		internal TriangleLocator locator;

		internal Behavior behavior;

		internal NodeNumbering numbering;

		public Behavior Behavior => behavior;

		public BoundingBox Bounds => bounds;

		public ICollection<Vertex> Vertices => vertices.Values;

		public IList<Point> Holes => holes;

		public ICollection<Triangle> Triangles => triangles.Values;

		public ICollection<Segment> Segments => subsegs.Values;

		public IEnumerable<Edge> Edges
		{
			get
			{
				EdgeEnumerator e = new EdgeEnumerator(this);
				while (e.MoveNext())
				{
					yield return e.Current;
				}
			}
		}

		public int NumberOfInputPoints => invertices;

		public int NumberOfEdges => edges;

		public bool IsPolygon => insegments > 0;

		public NodeNumbering CurrentNumbering => numbering;

		public Mesh()
			: this(new Behavior())
		{
		}

		public Mesh(Behavior behavior)
		{
			this.behavior = behavior;
			logger = SimpleLog.Instance;
			vertices = new Dictionary<int, Vertex>();
			triangles = new Dictionary<int, Triangle>();
			subsegs = new Dictionary<int, Segment>();
			flipstack = new Stack<Otri>();
			holes = new List<Point>();
			regions = new List<RegionPointer>();
			quality = new QualityMesher(this);
			locator = new TriangleLocator(this);
			Primitives.ExactInit();
			if (dummytri == null)
			{
				DummyInit();
			}
		}

		public void Load(string filename)
		{
			FileReader.Read(filename, out var geometry, out var list);
			if (geometry != null && list != null)
			{
				Load(geometry, list);
			}
		}

		public void Load(InputGeometry input, List<ITriangle> triangles)
		{
			if (input == null || triangles == null)
			{
				throw new ArgumentException("Invalid input (argument is null).");
			}
			ResetData();
			if (input.HasSegments)
			{
				behavior.Poly = true;
				holes.AddRange(input.Holes);
			}
			if (!behavior.Poly)
			{
				behavior.VarArea = false;
				behavior.useRegions = false;
			}
			behavior.useRegions = input.Regions.Count > 0;
			TransferNodes(input);
			hullsize = DataReader.Reconstruct(this, input, triangles.ToArray());
			edges = (3 * triangles.Count + hullsize) / 2;
		}

		public void Triangulate(string inputFile)
		{
			InputGeometry input = FileReader.Read(inputFile);
			Triangulate(input);
		}

		public void Triangulate(InputGeometry input)
		{
			ResetData();
			behavior.Poly = input.HasSegments;
			if (!behavior.Poly)
			{
				behavior.VarArea = false;
				behavior.useRegions = false;
			}
			behavior.useRegions = input.Regions.Count > 0;
			steinerleft = behavior.SteinerPoints;
			TransferNodes(input);
			hullsize = Delaunay();
			infvertex1 = null;
			infvertex2 = null;
			infvertex3 = null;
			ConstraintMesher constraintMesher = new ConstraintMesher(this);
			if (behavior.useSegments)
			{
				checksegments = true;
				constraintMesher.FormSkeleton(input);
			}
			if (behavior.Poly && triangles.Count > 0)
			{
				foreach (Point hole in input.holes)
				{
					holes.Add(hole);
				}
				foreach (RegionPointer region in input.regions)
				{
					regions.Add(region);
				}
				constraintMesher.CarveHoles();
			}
			else
			{
				holes.Clear();
				regions.Clear();
			}
			if ((behavior.Quality || behavior.ConformingDelaunay) && triangles.Count > 0)
			{
				quality.EnforceQuality();
			}
			edges = (3 * triangles.Count + hullsize) / 2;
		}

		public void Refine(bool halfArea)
		{
			if (halfArea)
			{
				double num = 0.0;
				foreach (Triangle value2 in triangles.Values)
				{
					double value = (value2.vertices[2].x - value2.vertices[0].x) * (value2.vertices[1].y - value2.vertices[0].y) - (value2.vertices[1].x - value2.vertices[0].x) * (value2.vertices[2].y - value2.vertices[0].y);
					value = Math.Abs(value) / 2.0;
					if (value > num)
					{
						num = value;
					}
				}
				Refine(num / 2.0);
			}
			else
			{
				Refine();
			}
		}

		public void Refine(double areaConstraint)
		{
			behavior.fixedArea = true;
			behavior.MaxArea = areaConstraint;
			Refine();
			behavior.fixedArea = false;
			behavior.MaxArea = -1.0;
		}

		public void Refine()
		{
			inelements = triangles.Count;
			invertices = vertices.Count;
			if (behavior.Poly)
			{
				if (behavior.useSegments)
				{
					insegments = subsegs.Count;
				}
				else
				{
					insegments = hullsize;
				}
			}
			Reset();
			steinerleft = behavior.SteinerPoints;
			infvertex1 = null;
			infvertex2 = null;
			infvertex3 = null;
			if (behavior.useSegments)
			{
				checksegments = true;
			}
			if (triangles.Count > 0)
			{
				quality.EnforceQuality();
			}
			edges = (3 * triangles.Count + hullsize) / 2;
		}

		public void Smooth()
		{
			numbering = NodeNumbering.None;
			((ISmoother)new SimpleSmoother(this)).Smooth();
		}

		public void Renumber()
		{
			Renumber(NodeNumbering.Linear);
		}

		public void Renumber(NodeNumbering num)
		{
			if (num == numbering)
			{
				return;
			}
			int num2;
			switch (num)
			{
			case NodeNumbering.Linear:
				num2 = 0;
				foreach (Vertex value in vertices.Values)
				{
					value.id = num2++;
				}
				break;
			case NodeNumbering.CuthillMcKee:
			{
				int[] array = new CuthillMcKee().Renumber(this);
				foreach (Vertex value2 in vertices.Values)
				{
					value2.id = array[value2.id];
				}
				break;
			}
			}
			numbering = num;
			num2 = 0;
			foreach (Triangle value3 in triangles.Values)
			{
				value3.id = num2++;
			}
		}

		private int Delaunay()
		{
			int num = 0;
			num = ((behavior.Algorithm == TriangulationAlgorithm.Dwyer) ? new Dwyer().Triangulate(this) : ((behavior.Algorithm != TriangulationAlgorithm.SweepLine) ? new Incremental().Triangulate(this) : new SweepLine().Triangulate(this)));
			if (triangles.Count != 0)
			{
				return num;
			}
			return 0;
		}

		private void ResetData()
		{
			vertices.Clear();
			triangles.Clear();
			subsegs.Clear();
			holes.Clear();
			regions.Clear();
			hash_vtx = 0;
			hash_seg = 0;
			hash_tri = 0;
			flipstack.Clear();
			hullsize = 0;
			edges = 0;
			Reset();
			locator.Reset();
		}

		private void Reset()
		{
			numbering = NodeNumbering.None;
			undeads = 0;
			checksegments = false;
			checkquality = false;
			Statistic.InCircleCount = 0L;
			Statistic.CounterClockwiseCount = 0L;
			Statistic.InCircleAdaptCount = 0L;
			Statistic.CounterClockwiseAdaptCount = 0L;
			Statistic.Orient3dCount = 0L;
			Statistic.HyperbolaCount = 0L;
			Statistic.CircleTopCount = 0L;
			Statistic.CircumcenterCount = 0L;
		}

		private void DummyInit()
		{
			dummytri = new Triangle();
			dummytri.hash = -1;
			dummytri.id = -1;
			dummytri.neighbors[0].triangle = dummytri;
			dummytri.neighbors[1].triangle = dummytri;
			dummytri.neighbors[2].triangle = dummytri;
			if (behavior.useSegments)
			{
				dummysub = new Segment();
				dummysub.hash = -1;
				dummysub.subsegs[0].seg = dummysub;
				dummysub.subsegs[1].seg = dummysub;
				dummytri.subsegs[0].seg = dummysub;
				dummytri.subsegs[1].seg = dummysub;
				dummytri.subsegs[2].seg = dummysub;
			}
		}

		private void TransferNodes(InputGeometry data)
		{
			List<Vertex> points = data.points;
			invertices = points.Count;
			mesh_dim = 2;
			if (invertices < 3)
			{
				logger.Error("Input must have at least three input vertices.", "MeshReader.TransferNodes()");
				throw new Exception("Input must have at least three input vertices.");
			}
			nextras = ((points[0].attributes != null) ? points[0].attributes.Length : 0);
			foreach (Vertex item in points)
			{
				item.hash = hash_vtx++;
				item.id = item.hash;
				vertices.Add(item.hash, item);
			}
			bounds = data.Bounds;
		}

		internal void MakeVertexMap()
		{
			Otri tri = default(Otri);
			foreach (Triangle value in triangles.Values)
			{
				tri.triangle = value;
				tri.orient = 0;
				while (tri.orient < 3)
				{
					tri.Org().tri = tri;
					tri.orient++;
				}
			}
		}

		internal void MakeTriangle(ref Otri newotri)
		{
			Triangle triangle = new Triangle();
			triangle.hash = hash_tri++;
			triangle.id = triangle.hash;
			newotri.triangle = triangle;
			newotri.orient = 0;
			triangles.Add(triangle.hash, triangle);
		}

		internal void MakeSegment(ref Osub newsubseg)
		{
			Segment segment = new Segment();
			segment.hash = hash_seg++;
			newsubseg.seg = segment;
			newsubseg.orient = 0;
			subsegs.Add(segment.hash, segment);
		}

		internal InsertVertexResult InsertVertex(Vertex newvertex, ref Otri searchtri, ref Osub splitseg, bool segmentflaws, bool triflaws)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Otri o4 = default(Otri);
			Otri o5 = default(Otri);
			Otri o6 = default(Otri);
			Otri newotri = default(Otri);
			Otri newotri2 = default(Otri);
			Otri newotri3 = default(Otri);
			Otri o7 = default(Otri);
			Otri o8 = default(Otri);
			Otri o9 = default(Otri);
			Otri o10 = default(Otri);
			Otri o11 = default(Otri);
			Osub os = default(Osub);
			Osub os2 = default(Osub);
			Osub os3 = default(Osub);
			Osub os4 = default(Osub);
			Osub os5 = default(Osub);
			Osub os6 = default(Osub);
			Osub o12 = default(Osub);
			Osub os7 = default(Osub);
			LocateResult locateResult;
			if (splitseg.seg == null)
			{
				if (searchtri.triangle == dummytri)
				{
					o.triangle = dummytri;
					o.orient = 0;
					o.SymSelf();
					locateResult = locator.Locate(newvertex, ref o);
				}
				else
				{
					searchtri.Copy(ref o);
					locateResult = locator.PreciseLocate(newvertex, ref o, stopatsubsegment: true);
				}
			}
			else
			{
				searchtri.Copy(ref o);
				locateResult = LocateResult.OnEdge;
			}
			Vertex dest;
			Vertex org;
			switch (locateResult)
			{
			case LocateResult.OnVertex:
				o.Copy(ref searchtri);
				locator.Update(ref o);
				return InsertVertexResult.Duplicate;
			case LocateResult.OnEdge:
			case LocateResult.Outside:
			{
				if (checksegments && splitseg.seg == null)
				{
					o.SegPivot(ref os5);
					if (os5.seg != dummysub)
					{
						if (segmentflaws)
						{
							bool flag = behavior.NoBisect != 2;
							if (flag && behavior.NoBisect == 1)
							{
								o.Sym(ref o11);
								flag = o11.triangle != dummytri;
							}
							if (flag)
							{
								BadSubseg badSubseg = new BadSubseg();
								badSubseg.encsubseg = os5;
								badSubseg.subsegorg = os5.Org();
								badSubseg.subsegdest = os5.Dest();
								quality.AddBadSubseg(badSubseg);
							}
						}
						o.Copy(ref searchtri);
						locator.Update(ref o);
						return InsertVertexResult.Violating;
					}
				}
				o.Lprev(ref o4);
				o4.Sym(ref o8);
				o.Sym(ref o6);
				bool flag2 = o6.triangle != dummytri;
				if (flag2)
				{
					o6.LnextSelf();
					o6.Sym(ref o10);
					MakeTriangle(ref newotri3);
				}
				else
				{
					hullsize++;
				}
				MakeTriangle(ref newotri2);
				dest = o.Org();
				org = o.Dest();
				Vertex vertex = o.Apex();
				newotri2.SetOrg(vertex);
				newotri2.SetDest(dest);
				newotri2.SetApex(newvertex);
				o.SetOrg(newvertex);
				newotri2.triangle.region = o4.triangle.region;
				if (behavior.VarArea)
				{
					newotri2.triangle.area = o4.triangle.area;
				}
				if (flag2)
				{
					Vertex dest2 = o6.Dest();
					newotri3.SetOrg(dest);
					newotri3.SetDest(dest2);
					newotri3.SetApex(newvertex);
					o6.SetOrg(newvertex);
					newotri3.triangle.region = o6.triangle.region;
					if (behavior.VarArea)
					{
						newotri3.triangle.area = o6.triangle.area;
					}
				}
				if (checksegments)
				{
					o4.SegPivot(ref os2);
					if (os2.seg != dummysub)
					{
						o4.SegDissolve();
						newotri2.SegBond(ref os2);
					}
					if (flag2)
					{
						o6.SegPivot(ref os4);
						if (os4.seg != dummysub)
						{
							o6.SegDissolve();
							newotri3.SegBond(ref os4);
						}
					}
				}
				newotri2.Bond(ref o8);
				newotri2.LprevSelf();
				newotri2.Bond(ref o4);
				newotri2.LprevSelf();
				if (flag2)
				{
					newotri3.Bond(ref o10);
					newotri3.LnextSelf();
					newotri3.Bond(ref o6);
					newotri3.LnextSelf();
					newotri3.Bond(ref newotri2);
				}
				if (splitseg.seg != null)
				{
					splitseg.SetDest(newvertex);
					Vertex segOrg = splitseg.SegOrg();
					Vertex segDest = splitseg.SegDest();
					splitseg.SymSelf();
					splitseg.Pivot(ref o12);
					InsertSubseg(ref newotri2, splitseg.seg.boundary);
					newotri2.SegPivot(ref os7);
					os7.SetSegOrg(segOrg);
					os7.SetSegDest(segDest);
					splitseg.Bond(ref os7);
					os7.SymSelf();
					os7.Bond(ref o12);
					splitseg.SymSelf();
					if (newvertex.mark == 0)
					{
						newvertex.mark = splitseg.seg.boundary;
					}
				}
				if (checkquality)
				{
					flipstack.Clear();
					flipstack.Push(default(Otri));
					flipstack.Push(o);
				}
				o.LnextSelf();
				break;
			}
			default:
			{
				o.Lnext(ref o3);
				o.Lprev(ref o4);
				o3.Sym(ref o7);
				o4.Sym(ref o8);
				MakeTriangle(ref newotri);
				MakeTriangle(ref newotri2);
				dest = o.Org();
				org = o.Dest();
				Vertex vertex = o.Apex();
				newotri.SetOrg(org);
				newotri.SetDest(vertex);
				newotri.SetApex(newvertex);
				newotri2.SetOrg(vertex);
				newotri2.SetDest(dest);
				newotri2.SetApex(newvertex);
				o.SetApex(newvertex);
				newotri.triangle.region = o.triangle.region;
				newotri2.triangle.region = o.triangle.region;
				if (behavior.VarArea)
				{
					double area = o.triangle.area;
					newotri.triangle.area = area;
					newotri2.triangle.area = area;
				}
				if (checksegments)
				{
					o3.SegPivot(ref os);
					if (os.seg != dummysub)
					{
						o3.SegDissolve();
						newotri.SegBond(ref os);
					}
					o4.SegPivot(ref os2);
					if (os2.seg != dummysub)
					{
						o4.SegDissolve();
						newotri2.SegBond(ref os2);
					}
				}
				newotri.Bond(ref o7);
				newotri2.Bond(ref o8);
				newotri.LnextSelf();
				newotri2.LprevSelf();
				newotri.Bond(ref newotri2);
				newotri.LnextSelf();
				o3.Bond(ref newotri);
				newotri2.LprevSelf();
				o4.Bond(ref newotri2);
				if (checkquality)
				{
					flipstack.Clear();
					flipstack.Push(o);
				}
				break;
			}
			}
			InsertVertexResult result = InsertVertexResult.Successful;
			Vertex vertex2 = o.Org();
			dest = vertex2;
			org = o.Dest();
			while (true)
			{
				bool flag3 = true;
				if (checksegments)
				{
					o.SegPivot(ref os6);
					if (os6.seg != dummysub)
					{
						flag3 = false;
						if (segmentflaws && quality.CheckSeg4Encroach(ref os6) > 0)
						{
							result = InsertVertexResult.Encroaching;
						}
					}
				}
				if (flag3)
				{
					o.Sym(ref o2);
					if (o2.triangle == dummytri)
					{
						flag3 = false;
					}
					else
					{
						Vertex vertex3 = o2.Apex();
						flag3 = ((!(org == infvertex1) && !(org == infvertex2) && !(org == infvertex3)) ? ((!(dest == infvertex1) && !(dest == infvertex2) && !(dest == infvertex3)) ? (!(vertex3 == infvertex1) && !(vertex3 == infvertex2) && !(vertex3 == infvertex3) && Primitives.InCircle(org, newvertex, dest, vertex3) > 0.0) : (Primitives.CounterClockwise(vertex3, org, newvertex) > 0.0)) : (Primitives.CounterClockwise(newvertex, dest, vertex3) > 0.0));
						if (flag3)
						{
							o2.Lprev(ref o5);
							o5.Sym(ref o9);
							o2.Lnext(ref o6);
							o6.Sym(ref o10);
							o.Lnext(ref o3);
							o3.Sym(ref o7);
							o.Lprev(ref o4);
							o4.Sym(ref o8);
							o5.Bond(ref o7);
							o3.Bond(ref o8);
							o4.Bond(ref o10);
							o6.Bond(ref o9);
							if (checksegments)
							{
								o5.SegPivot(ref os3);
								o3.SegPivot(ref os);
								o4.SegPivot(ref os2);
								o6.SegPivot(ref os4);
								if (os3.seg == dummysub)
								{
									o6.SegDissolve();
								}
								else
								{
									o6.SegBond(ref os3);
								}
								if (os.seg == dummysub)
								{
									o5.SegDissolve();
								}
								else
								{
									o5.SegBond(ref os);
								}
								if (os2.seg == dummysub)
								{
									o3.SegDissolve();
								}
								else
								{
									o3.SegBond(ref os2);
								}
								if (os4.seg == dummysub)
								{
									o4.SegDissolve();
								}
								else
								{
									o4.SegBond(ref os4);
								}
							}
							o.SetOrg(vertex3);
							o.SetDest(newvertex);
							o.SetApex(dest);
							o2.SetOrg(newvertex);
							o2.SetDest(vertex3);
							o2.SetApex(org);
							int region = Math.Min(o2.triangle.region, o.triangle.region);
							o2.triangle.region = region;
							o.triangle.region = region;
							if (behavior.VarArea)
							{
								double area = ((!(o2.triangle.area <= 0.0) && !(o.triangle.area <= 0.0)) ? (0.5 * (o2.triangle.area + o.triangle.area)) : (-1.0));
								o2.triangle.area = area;
								o.triangle.area = area;
							}
							if (checkquality)
							{
								flipstack.Push(o);
							}
							o.LprevSelf();
							org = vertex3;
						}
					}
				}
				if (!flag3)
				{
					if (triflaws)
					{
						quality.TestTriangle(ref o);
					}
					o.LnextSelf();
					o.Sym(ref o11);
					if (org == vertex2 || o11.triangle == dummytri)
					{
						break;
					}
					o11.Lnext(ref o);
					dest = org;
					org = o.Dest();
				}
			}
			o.Lnext(ref searchtri);
			Otri o13 = default(Otri);
			o.Lnext(ref o13);
			locator.Update(ref o13);
			return result;
		}

		internal void InsertSubseg(ref Otri tri, int subsegmark)
		{
			Otri o = default(Otri);
			Osub os = default(Osub);
			Vertex vertex = tri.Org();
			Vertex vertex2 = tri.Dest();
			if (vertex.mark == 0)
			{
				vertex.mark = subsegmark;
			}
			if (vertex2.mark == 0)
			{
				vertex2.mark = subsegmark;
			}
			tri.SegPivot(ref os);
			if (os.seg == dummysub)
			{
				MakeSegment(ref os);
				os.SetOrg(vertex2);
				os.SetDest(vertex);
				os.SetSegOrg(vertex2);
				os.SetSegDest(vertex);
				tri.SegBond(ref os);
				tri.Sym(ref o);
				os.SymSelf();
				o.SegBond(ref os);
				os.seg.boundary = subsegmark;
			}
			else if (os.seg.boundary == 0)
			{
				os.seg.boundary = subsegmark;
			}
		}

		internal void Flip(ref Otri flipedge)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Otri o4 = default(Otri);
			Otri o5 = default(Otri);
			Otri o6 = default(Otri);
			Otri o7 = default(Otri);
			Otri o8 = default(Otri);
			Otri o9 = default(Otri);
			Osub os = default(Osub);
			Osub os2 = default(Osub);
			Osub os3 = default(Osub);
			Osub os4 = default(Osub);
			Vertex apex = flipedge.Org();
			Vertex apex2 = flipedge.Dest();
			Vertex vertex = flipedge.Apex();
			flipedge.Sym(ref o5);
			Vertex vertex2 = o5.Apex();
			o5.Lprev(ref o3);
			o3.Sym(ref o8);
			o5.Lnext(ref o4);
			o4.Sym(ref o9);
			flipedge.Lnext(ref o);
			o.Sym(ref o6);
			flipedge.Lprev(ref o2);
			o2.Sym(ref o7);
			o3.Bond(ref o6);
			o.Bond(ref o7);
			o2.Bond(ref o9);
			o4.Bond(ref o8);
			if (checksegments)
			{
				o3.SegPivot(ref os3);
				o.SegPivot(ref os);
				o2.SegPivot(ref os2);
				o4.SegPivot(ref os4);
				if (os3.seg == dummysub)
				{
					o4.SegDissolve();
				}
				else
				{
					o4.SegBond(ref os3);
				}
				if (os.seg == dummysub)
				{
					o3.SegDissolve();
				}
				else
				{
					o3.SegBond(ref os);
				}
				if (os2.seg == dummysub)
				{
					o.SegDissolve();
				}
				else
				{
					o.SegBond(ref os2);
				}
				if (os4.seg == dummysub)
				{
					o2.SegDissolve();
				}
				else
				{
					o2.SegBond(ref os4);
				}
			}
			flipedge.SetOrg(vertex2);
			flipedge.SetDest(vertex);
			flipedge.SetApex(apex);
			o5.SetOrg(vertex);
			o5.SetDest(vertex2);
			o5.SetApex(apex2);
		}

		internal void Unflip(ref Otri flipedge)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Otri o4 = default(Otri);
			Otri o5 = default(Otri);
			Otri o6 = default(Otri);
			Otri o7 = default(Otri);
			Otri o8 = default(Otri);
			Otri o9 = default(Otri);
			Osub os = default(Osub);
			Osub os2 = default(Osub);
			Osub os3 = default(Osub);
			Osub os4 = default(Osub);
			Vertex apex = flipedge.Org();
			Vertex apex2 = flipedge.Dest();
			Vertex vertex = flipedge.Apex();
			flipedge.Sym(ref o5);
			Vertex vertex2 = o5.Apex();
			o5.Lprev(ref o3);
			o3.Sym(ref o8);
			o5.Lnext(ref o4);
			o4.Sym(ref o9);
			flipedge.Lnext(ref o);
			o.Sym(ref o6);
			flipedge.Lprev(ref o2);
			o2.Sym(ref o7);
			o3.Bond(ref o9);
			o.Bond(ref o8);
			o2.Bond(ref o6);
			o4.Bond(ref o7);
			if (checksegments)
			{
				o3.SegPivot(ref os3);
				o.SegPivot(ref os);
				o2.SegPivot(ref os2);
				o4.SegPivot(ref os4);
				if (os3.seg == dummysub)
				{
					o.SegDissolve();
				}
				else
				{
					o.SegBond(ref os3);
				}
				if (os.seg == dummysub)
				{
					o2.SegDissolve();
				}
				else
				{
					o2.SegBond(ref os);
				}
				if (os2.seg == dummysub)
				{
					o4.SegDissolve();
				}
				else
				{
					o4.SegBond(ref os2);
				}
				if (os4.seg == dummysub)
				{
					o3.SegDissolve();
				}
				else
				{
					o3.SegBond(ref os4);
				}
			}
			flipedge.SetOrg(vertex);
			flipedge.SetDest(vertex2);
			flipedge.SetApex(apex2);
			o5.SetOrg(vertex2);
			o5.SetDest(vertex);
			o5.SetApex(apex);
		}

		private void TriangulatePolygon(Otri firstedge, Otri lastedge, int edgecount, bool doflip, bool triflaws)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			int num = 1;
			Vertex pa = lastedge.Apex();
			Vertex pb = firstedge.Dest();
			firstedge.Onext(ref o2);
			Vertex pc = o2.Dest();
			o2.Copy(ref o);
			for (int i = 2; i <= edgecount - 2; i++)
			{
				o.OnextSelf();
				Vertex vertex = o.Dest();
				if (Primitives.InCircle(pa, pb, pc, vertex) > 0.0)
				{
					o.Copy(ref o2);
					pc = vertex;
					num = i;
				}
			}
			if (num > 1)
			{
				o2.Oprev(ref o3);
				TriangulatePolygon(firstedge, o3, num + 1, doflip: true, triflaws);
			}
			if (num < edgecount - 2)
			{
				o2.Sym(ref o3);
				TriangulatePolygon(o2, lastedge, edgecount - num, doflip: true, triflaws);
				o3.Sym(ref o2);
			}
			if (doflip)
			{
				Flip(ref o2);
				if (triflaws)
				{
					o2.Sym(ref o);
					quality.TestTriangle(ref o);
				}
			}
			o2.Copy(ref lastedge);
		}

		internal void DeleteVertex(ref Otri deltri)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Otri o4 = default(Otri);
			Otri o5 = default(Otri);
			Otri o6 = default(Otri);
			Otri o7 = default(Otri);
			Otri o8 = default(Otri);
			Osub os = default(Osub);
			Osub os2 = default(Osub);
			Vertex dyingvertex = deltri.Org();
			VertexDealloc(dyingvertex);
			deltri.Onext(ref o);
			int num = 1;
			while (!deltri.Equal(o))
			{
				num++;
				o.OnextSelf();
			}
			if (num > 3)
			{
				deltri.Onext(ref o2);
				deltri.Oprev(ref o3);
				TriangulatePolygon(o2, o3, num, doflip: false, behavior.NoBisect == 0);
			}
			deltri.Lprev(ref o4);
			deltri.Dnext(ref o5);
			o5.Sym(ref o7);
			o4.Oprev(ref o6);
			o6.Sym(ref o8);
			deltri.Bond(ref o7);
			o4.Bond(ref o8);
			o5.SegPivot(ref os);
			if (os.seg != dummysub)
			{
				deltri.SegBond(ref os);
			}
			o6.SegPivot(ref os2);
			if (os2.seg != dummysub)
			{
				o4.SegBond(ref os2);
			}
			Vertex org = o5.Org();
			deltri.SetOrg(org);
			if (behavior.NoBisect == 0)
			{
				quality.TestTriangle(ref deltri);
			}
			TriangleDealloc(o5.triangle);
			TriangleDealloc(o6.triangle);
		}

		internal void UndoVertex()
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Otri o4 = default(Otri);
			Otri o5 = default(Otri);
			Otri o6 = default(Otri);
			Otri o7 = default(Otri);
			Osub os = default(Osub);
			Osub os2 = default(Osub);
			Osub os3 = default(Osub);
			while (flipstack.Count > 0)
			{
				Otri flipedge = flipstack.Pop();
				if (flipstack.Count == 0)
				{
					flipedge.Dprev(ref o);
					o.LnextSelf();
					flipedge.Onext(ref o2);
					o2.LprevSelf();
					o.Sym(ref o4);
					o2.Sym(ref o5);
					Vertex apex = o.Dest();
					flipedge.SetApex(apex);
					flipedge.LnextSelf();
					flipedge.Bond(ref o4);
					o.SegPivot(ref os);
					flipedge.SegBond(ref os);
					flipedge.LnextSelf();
					flipedge.Bond(ref o5);
					o2.SegPivot(ref os2);
					flipedge.SegBond(ref os2);
					TriangleDealloc(o.triangle);
					TriangleDealloc(o2.triangle);
				}
				else if (flipstack.Peek().triangle == null)
				{
					flipedge.Lprev(ref o7);
					o7.Sym(ref o2);
					o2.LnextSelf();
					o2.Sym(ref o5);
					Vertex org = o2.Dest();
					flipedge.SetOrg(org);
					o7.Bond(ref o5);
					o2.SegPivot(ref os2);
					o7.SegBond(ref os2);
					TriangleDealloc(o2.triangle);
					flipedge.Sym(ref o7);
					if (o7.triangle != dummytri)
					{
						o7.LnextSelf();
						o7.Dnext(ref o3);
						o3.Sym(ref o6);
						o7.SetOrg(org);
						o7.Bond(ref o6);
						o3.SegPivot(ref os3);
						o7.SegBond(ref os3);
						TriangleDealloc(o3.triangle);
					}
					flipstack.Clear();
				}
				else
				{
					Unflip(ref flipedge);
				}
			}
		}

		internal void TriangleDealloc(Triangle dyingtriangle)
		{
			Otri.Kill(dyingtriangle);
			triangles.Remove(dyingtriangle.hash);
		}

		internal void VertexDealloc(Vertex dyingvertex)
		{
			dyingvertex.type = VertexType.DeadVertex;
			vertices.Remove(dyingvertex.hash);
		}

		internal void SubsegDealloc(Segment dyingsubseg)
		{
			Osub.Kill(dyingsubseg);
			subsegs.Remove(dyingsubseg.hash);
		}
	}
	public static class Primitives
	{
		private static double epsilon;

		private static double splitter;

		private static double resulterrbound;

		private static double ccwerrboundA;

		private static double ccwerrboundB;

		private static double ccwerrboundC;

		private static double iccerrboundA;

		private static double iccerrboundB;

		private static double iccerrboundC;

		private static double o3derrboundA;

		private static double o3derrboundB;

		private static double o3derrboundC;

		public static void ExactInit()
		{
			bool flag = true;
			double num = 0.5;
			epsilon = 1.0;
			splitter = 1.0;
			double num2 = 1.0;
			double num3;
			do
			{
				num3 = num2;
				epsilon *= num;
				if (flag)
				{
					splitter *= 2.0;
				}
				flag = !flag;
				num2 = 1.0 + epsilon;
			}
			while (num2 != 1.0 && num2 != num3);
			splitter += 1.0;
			resulterrbound = (3.0 + 8.0 * epsilon) * epsilon;
			ccwerrboundA = (3.0 + 16.0 * epsilon) * epsilon;
			ccwerrboundB = (2.0 + 12.0 * epsilon) * epsilon;
			ccwerrboundC = (9.0 + 64.0 * epsilon) * epsilon * epsilon;
			iccerrboundA = (10.0 + 96.0 * epsilon) * epsilon;
			iccerrboundB = (4.0 + 48.0 * epsilon) * epsilon;
			iccerrboundC = (44.0 + 576.0 * epsilon) * epsilon * epsilon;
			o3derrboundA = (7.0 + 56.0 * epsilon) * epsilon;
			o3derrboundB = (3.0 + 28.0 * epsilon) * epsilon;
			o3derrboundC = (26.0 + 288.0 * epsilon) * epsilon * epsilon;
		}

		public static double CounterClockwise(Point pa, Point pb, Point pc)
		{
			Statistic.CounterClockwiseCount++;
			double num = (pa.x - pc.x) * (pb.y - pc.y);
			double num2 = (pa.y - pc.y) * (pb.x - pc.x);
			double num3 = num - num2;
			if (Behavior.NoExact)
			{
				return num3;
			}
			double num4;
			if (num > 0.0)
			{
				if (num2 <= 0.0)
				{
					return num3;
				}
				num4 = num + num2;
			}
			else
			{
				if (!(num < 0.0))
				{
					return num3;
				}
				if (num2 >= 0.0)
				{
					return num3;
				}
				num4 = 0.0 - num - num2;
			}
			double num5 = ccwerrboundA * num4;
			if (num3 >= num5 || 0.0 - num3 >= num5)
			{
				return num3;
			}
			Statistic.CounterClockwiseAdaptCount++;
			return CounterClockwiseAdapt(pa, pb, pc, num4);
		}

		public static double InCircle(Point pa, Point pb, Point pc, Point pd)
		{
			Statistic.InCircleCount++;
			double num = pa.x - pd.x;
			double num2 = pb.x - pd.x;
			double num3 = pc.x - pd.x;
			double num4 = pa.y - pd.y;
			double num5 = pb.y - pd.y;
			double num6 = pc.y - pd.y;
			double num7 = num2 * num6;
			double num8 = num3 * num5;
			double num9 = num * num + num4 * num4;
			double num10 = num3 * num4;
			double num11 = num * num6;
			double num12 = num2 * num2 + num5 * num5;
			double num13 = num * num5;
			double num14 = num2 * num4;
			double num15 = num3 * num3 + num6 * num6;
			double num16 = num9 * (num7 - num8) + num12 * (num10 - num11) + num15 * (num13 - num14);
			if (Behavior.NoExact)
			{
				return num16;
			}
			double num17 = (Math.Abs(num7) + Math.Abs(num8)) * num9 + (Math.Abs(num10) + Math.Abs(num11)) * num12 + (Math.Abs(num13) + Math.Abs(num14)) * num15;
			double num18 = iccerrboundA * num17;
			if (num16 > num18 || 0.0 - num16 > num18)
			{
				return num16;
			}
			Statistic.InCircleAdaptCount++;
			return InCircleAdapt(pa, pb, pc, pd, num17);
		}

		public static double NonRegular(Point pa, Point pb, Point pc, Point pd)
		{
			return InCircle(pa, pb, pc, pd);
		}

		public static Point FindCircumcenter(Point torg, Point tdest, Point tapex, ref double xi, ref double eta, double offconstant)
		{
			Statistic.CircumcenterCount++;
			double num = tdest.x - torg.x;
			double num2 = tdest.y - torg.y;
			double num3 = tapex.x - torg.x;
			double num4 = tapex.y - torg.y;
			double num5 = num * num + num2 * num2;
			double num6 = num3 * num3 + num4 * num4;
			double num7 = (tdest.x - tapex.x) * (tdest.x - tapex.x) + (tdest.y - tapex.y) * (tdest.y - tapex.y);
			double num8;
			if (Behavior.NoExact)
			{
				num8 = 0.5 / (num * num4 - num3 * num2);
			}
			else
			{
				num8 = 0.5 / CounterClockwise(tdest, tapex, torg);
				Statistic.CounterClockwiseCount--;
			}
			double num9 = (num4 * num5 - num2 * num6) * num8;
			double num10 = (num * num6 - num3 * num5) * num8;
			if (num5 < num6 && num5 < num7)
			{
				if (offconstant > 0.0)
				{
					double num11 = 0.5 * num - offconstant * num2;
					double num12 = 0.5 * num2 + offconstant * num;
					if (num11 * num11 + num12 * num12 < num9 * num9 + num10 * num10)
					{
						num9 = num11;
						num10 = num12;
					}
				}
			}
			else if (num6 < num7)
			{
				if (offconstant > 0.0)
				{
					double num11 = 0.5 * num3 + offconstant * num4;
					double num12 = 0.5 * num4 - offconstant * num3;
					if (num11 * num11 + num12 * num12 < num9 * num9 + num10 * num10)
					{
						num9 = num11;
						num10 = num12;
					}
				}
			}
			else if (offconstant > 0.0)
			{
				double num11 = 0.5 * (tapex.x - tdest.x) - offconstant * (tapex.y - tdest.y);
				double num12 = 0.5 * (tapex.y - tdest.y) + offconstant * (tapex.x - tdest.x);
				if (num11 * num11 + num12 * num12 < (num9 - num) * (num9 - num) + (num10 - num2) * (num10 - num2))
				{
					num9 = num + num11;
					num10 = num2 + num12;
				}
			}
			xi = (num4 * num9 - num3 * num10) * (2.0 * num8);
			eta = (num * num10 - num2 * num9) * (2.0 * num8);
			return new Point(torg.x + num9, torg.y + num10);
		}

		public static Point FindCircumcenter(Point torg, Point tdest, Point tapex, ref double xi, ref double eta)
		{
			Statistic.CircumcenterCount++;
			double num = tdest.x - torg.x;
			double num2 = tdest.y - torg.y;
			double num3 = tapex.x - torg.x;
			double num4 = tapex.y - torg.y;
			double num5 = num * num + num2 * num2;
			double num6 = num3 * num3 + num4 * num4;
			double num7;
			if (Behavior.NoExact)
			{
				num7 = 0.5 / (num * num4 - num3 * num2);
			}
			else
			{
				num7 = 0.5 / CounterClockwise(tdest, tapex, torg);
				Statistic.CounterClockwiseCount--;
			}
			double num8 = (num4 * num5 - num2 * num6) * num7;
			double num9 = (num * num6 - num3 * num5) * num7;
			xi = (num4 * num8 - num3 * num9) * (2.0 * num7);
			eta = (num * num9 - num2 * num8) * (2.0 * num7);
			return new Point(torg.x + num8, torg.y + num9);
		}

		private static int FastExpansionSumZeroElim(int elen, double[] e, int flen, double[] f, double[] h)
		{
			double num = e[0];
			double num2 = f[0];
			int num4;
			int num3 = (num4 = 0);
			double num5;
			if (num2 > num == num2 > 0.0 - num)
			{
				num5 = num;
				num = e[++num3];
			}
			else
			{
				num5 = num2;
				num2 = f[++num4];
			}
			int num6 = 0;
			if (num3 < elen && num4 < flen)
			{
				double num7;
				double num9;
				if (num2 > num == num2 > 0.0 - num)
				{
					num7 = num + num5;
					double num8 = num7 - num;
					num9 = num5 - num8;
					num = e[++num3];
				}
				else
				{
					num7 = num2 + num5;
					double num8 = num7 - num2;
					num9 = num5 - num8;
					num2 = f[++num4];
				}
				num5 = num7;
				if (num9 != 0.0)
				{
					h[num6++] = num9;
				}
				while (num3 < elen && num4 < flen)
				{
					if (num2 > num == num2 > 0.0 - num)
					{
						num7 = num5 + num;
						double num8 = num7 - num5;
						double num10 = num7 - num8;
						double num11 = num - num8;
						num9 = num5 - num10 + num11;
						num = e[++num3];
					}
					else
					{
						num7 = num5 + num2;
						double num8 = num7 - num5;
						double num10 = num7 - num8;
						double num11 = num2 - num8;
						num9 = num5 - num10 + num11;
						num2 = f[++num4];
					}
					num5 = num7;
					if (num9 != 0.0)
					{
						h[num6++] = num9;
					}
				}
			}
			while (num3 < elen)
			{
				double num7 = num5 + num;
				double num8 = num7 - num5;
				double num10 = num7 - num8;
				double num11 = num - num8;
				double num9 = num5 - num10 + num11;
				num = e[++num3];
				num5 = num7;
				if (num9 != 0.0)
				{
					h[num6++] = num9;
				}
			}
			while (num4 < flen)
			{
				double num7 = num5 + num2;
				double num8 = num7 - num5;
				double num10 = num7 - num8;
				double num11 = num2 - num8;
				double num9 = num5 - num10 + num11;
				num2 = f[++num4];
				num5 = num7;
				if (num9 != 0.0)
				{
					h[num6++] = num9;
				}
			}
			if (num5 != 0.0 || num6 == 0)
			{
				h[num6++] = num5;
			}
			return num6;
		}

		private static int ScaleExpansionZeroElim(int elen, double[] e, double b, double[] h)
		{
			double num = splitter * b;
			double num2 = num - b;
			double num3 = num - num2;
			double num4 = b - num3;
			double num5 = e[0] * b;
			double num6 = splitter * e[0];
			num2 = num6 - e[0];
			double num7 = num6 - num2;
			double num8 = e[0] - num7;
			double num9 = num5 - num7 * num3 - num8 * num3 - num7 * num4;
			double num10 = num8 * num4 - num9;
			int num11 = 0;
			if (num10 != 0.0)
			{
				h[num11++] = num10;
			}
			for (int i = 1; i < elen; i++)
			{
				double num12 = e[i];
				double num13 = num12 * b;
				double num14 = splitter * num12;
				num2 = num14 - num12;
				num7 = num14 - num2;
				num8 = num12 - num7;
				num9 = num13 - num7 * num3 - num8 * num3 - num7 * num4;
				double num15 = num8 * num4 - num9;
				double num16 = num5 + num15;
				double num17 = num16 - num5;
				double num18 = num16 - num17;
				double num19 = num15 - num17;
				num10 = num5 - num18 + num19;
				if (num10 != 0.0)
				{
					h[num11++] = num10;
				}
				num5 = num13 + num16;
				num17 = num5 - num13;
				num10 = num16 - num17;
				if (num10 != 0.0)
				{
					h[num11++] = num10;
				}
			}
			if (num5 != 0.0 || num11 == 0)
			{
				h[num11++] = num5;
			}
			return num11;
		}

		private static double Estimate(int elen, double[] e)
		{
			double num = e[0];
			for (int i = 1; i < elen; i++)
			{
				num += e[i];
			}
			return num;
		}

		private static double CounterClockwiseAdapt(Point pa, Point pb, Point pc, double detsum)
		{
			double[] array = new double[5];
			double[] array2 = new double[5];
			double[] array3 = new double[8];
			double[] array4 = new double[12];
			double[] array5 = new double[16];
			double num = pa.X - pc.X;
			double num2 = pb.X - pc.X;
			double num3 = pa.Y - pc.Y;
			double num4 = pb.Y - pc.Y;
			double num5 = num * num4;
			double num6 = splitter * num;
			double num7 = num6 - num;
			double num8 = num6 - num7;
			double num9 = num - num8;
			double num10 = splitter * num4;
			num7 = num10 - num4;
			double num11 = num10 - num7;
			double num12 = num4 - num11;
			double num13 = num5 - num8 * num11 - num9 * num11 - num8 * num12;
			double num14 = num9 * num12 - num13;
			double num15 = num3 * num2;
			double num16 = splitter * num3;
			num7 = num16 - num3;
			num8 = num16 - num7;
			num9 = num3 - num8;
			double num17 = splitter * num2;
			num7 = num17 - num2;
			num11 = num17 - num7;
			num12 = num2 - num11;
			num13 = num15 - num8 * num11 - num9 * num11 - num8 * num12;
			double num18 = num9 * num12 - num13;
			double num19 = num14 - num18;
			double num20 = num14 - num19;
			double num21 = num19 + num20;
			double num22 = num20 - num18;
			double num23 = num14 - num21;
			array[0] = num23 + num22;
			double num24 = num5 + num19;
			num20 = num24 - num5;
			num21 = num24 - num20;
			num22 = num19 - num20;
			num23 = num5 - num21;
			double num25 = num23 + num22;
			num19 = num25 - num15;
			num20 = num25 - num19;
			num21 = num19 + num20;
			num22 = num20 - num15;
			num23 = num25 - num21;
			array[1] = num23 + num22;
			double num26 = num24 + num19;
			num20 = num26 - num24;
			num21 = num26 - num20;
			num22 = num19 - num20;
			num23 = num24 - num21;
			array[2] = num23 + num22;
			array[3] = num26;
			double num27 = Estimate(4, array);
			double num28 = ccwerrboundB * detsum;
			if (num27 >= num28 || 0.0 - num27 >= num28)
			{
				return num27;
			}
			num20 = pa.X - num;
			num21 = num + num20;
			num22 = num20 - pc.X;
			num23 = pa.X - num21;
			double num29 = num23 + num22;
			num20 = pb.X - num2;
			num21 = num2 + num20;
			num22 = num20 - pc.X;
			num23 = pb.X - num21;
			double num30 = num23 + num22;
			num20 = pa.Y - num3;
			num21 = num3 + num20;
			num22 = num20 - pc.Y;
			num23 = pa.Y - num21;
			double num31 = num23 + num22;
			num20 = pb.Y - num4;
			num21 = num4 + num20;
			num22 = num20 - pc.Y;
			num23 = pb.Y - num21;
			double num32 = num23 + num22;
			if (num29 == 0.0 && num31 == 0.0 && num30 == 0.0 && num32 == 0.0)
			{
				return num27;
			}
			num28 = ccwerrboundC * detsum + resulterrbound * ((num27 >= 0.0) ? num27 : (0.0 - num27));
			num27 += num * num32 + num4 * num29 - (num3 * num30 + num2 * num31);
			if (num27 >= num28 || 0.0 - num27 >= num28)
			{
				return num27;
			}
			double num33 = num29 * num4;
			double num34 = splitter * num29;
			num7 = num34 - num29;
			num8 = num34 - num7;
			num9 = num29 - num8;
			double num35 = splitter * num4;
			num7 = num35 - num4;
			num11 = num35 - num7;
			num12 = num4 - num11;
			num13 = num33 - num8 * num11 - num9 * num11 - num8 * num12;
			double num36 = num9 * num12 - num13;
			double num37 = num31 * num2;
			double num38 = splitter * num31;
			num7 = num38 - num31;
			num8 = num38 - num7;
			num9 = num31 - num8;
			double num39 = splitter * num2;
			num7 = num39 - num2;
			num11 = num39 - num7;
			num12 = num2 - num11;
			num13 = num37 - num8 * num11 - num9 * num11 - num8 * num12;
			double num40 = num9 * num12 - num13;
			num19 = num36 - num40;
			num20 = num36 - num19;
			num21 = num19 + num20;
			num22 = num20 - num40;
			num23 = num36 - num21;
			array2[0] = num23 + num22;
			num24 = num33 + num19;
			num20 = num24 - num33;
			num21 = num24 - num20;
			num22 = num19 - num20;
			num23 = num33 - num21;
			double num41 = num23 + num22;
			num19 = num41 - num37;
			num20 = num41 - num19;
			num21 = num19 + num20;
			num22 = num20 - num37;
			num23 = num41 - num21;
			array2[1] = num23 + num22;
			double num42 = num24 + num19;
			num20 = num42 - num24;
			num21 = num42 - num20;
			num22 = num19 - num20;
			num23 = num24 - num21;
			array2[2] = num23 + num22;
			array2[3] = num42;
			int elen = FastExpansionSumZeroElim(4, array, 4, array2, array3);
			num33 = num * num32;
			double num43 = splitter * num;
			num7 = num43 - num;
			num8 = num43 - num7;
			num9 = num - num8;
			double num44 = splitter * num32;
			num7 = num44 - num32;
			num11 = num44 - num7;
			num12 = num32 - num11;
			num13 = num33 - num8 * num11 - num9 * num11 - num8 * num12;
			double num45 = num9 * num12 - num13;
			num37 = num3 * num30;
			double num46 = splitter * num3;
			num7 = num46 - num3;
			num8 = num46 - num7;
			num9 = num3 - num8;
			double num47 = splitter * num30;
			num7 = num47 - num30;
			num11 = num47 - num7;
			num12 = num30 - num11;
			num13 = num37 - num8 * num11 - num9 * num11 - num8 * num12;
			num40 = num9 * num12 - num13;
			num19 = num45 - num40;
			num20 = num45 - num19;
			num21 = num19 + num20;
			num22 = num20 - num40;
			num23 = num45 - num21;
			array2[0] = num23 + num22;
			num24 = num33 + num19;
			num20 = num24 - num33;
			num21 = num24 - num20;
			num22 = num19 - num20;
			num23 = num33 - num21;
			double num48 = num23 + num22;
			num19 = num48 - num37;
			num20 = num48 - num19;
			num21 = num19 + num20;
			num22 = num20 - num37;
			num23 = num48 - num21;
			array2[1] = num23 + num22;
			num42 = num24 + num19;
			num20 = num42 - num24;
			num21 = num42 - num20;
			num22 = num19 - num20;
			num23 = num24 - num21;
			array2[2] = num23 + num22;
			array2[3] = num42;
			int elen2 = FastExpansionSumZeroElim(elen, array3, 4, array2, array4);
			num33 = num29 * num32;
			double num49 = splitter * num29;
			num7 = num49 - num29;
			num8 = num49 - num7;
			num9 = num29 - num8;
			double num50 = splitter * num32;
			num7 = num50 - num32;
			num11 = num50 - num7;
			num12 = num32 - num11;
			num13 = num33 - num8 * num11 - num9 * num11 - num8 * num12;
			double num51 = num9 * num12 - num13;
			num37 = num31 * num30;
			double num52 = splitter * num31;
			num7 = num52 - num31;
			num8 = num52 - num7;
			num9 = num31 - num8;
			double num53 = splitter * num30;
			num7 = num53 - num30;
			num11 = num53 - num7;
			num12 = num30 - num11;
			num13 = num37 - num8 * num11 - num9 * num11 - num8 * num12;
			num40 = num9 * num12 - num13;
			num19 = num51 - num40;
			num20 = num51 - num19;
			num21 = num19 + num20;
			num22 = num20 - num40;
			num23 = num51 - num21;
			array2[0] = num23 + num22;
			num24 = num33 + num19;
			num20 = num24 - num33;
			num21 = num24 - num20;
			num22 = num19 - num20;
			num23 = num33 - num21;
			double num54 = num23 + num22;
			num19 = num54 - num37;
			num20 = num54 - num19;
			num21 = num19 + num20;
			num22 = num20 - num37;
			num23 = num54 - num21;
			array2[1] = num23 + num22;
			num42 = num24 + num19;
			num20 = num42 - num24;
			num21 = num42 - num20;
			num22 = num19 - num20;
			num23 = num24 - num21;
			array2[2] = num23 + num22;
			array2[3] = num42;
			int num55 = FastExpansionSumZeroElim(elen2, array4, 4, array2, array5);
			return array5[num55 - 1];
		}

		private static double InCircleAdapt(Point pa, Point pb, Point pc, Point pd, double permanent)
		{
			double[] array = new double[4];
			double[] array2 = new double[4];
			double[] array3 = new double[4];
			double[] array4 = new double[8];
			double[] array5 = new double[16];
			double[] array6 = new double[8];
			double[] array7 = new double[16];
			double[] array8 = new double[32];
			double[] array9 = new double[8];
			double[] array10 = new double[16];
			double[] array11 = new double[8];
			double[] array12 = new double[16];
			double[] array13 = new double[32];
			double[] array14 = new double[8];
			double[] array15 = new double[16];
			double[] array16 = new double[8];
			double[] array17 = new double[16];
			double[] array18 = new double[32];
			double[] array19 = new double[64];
			double[] array20 = new double[1152];
			double[] array21 = new double[1152];
			double[] array22 = new double[4];
			double[] array23 = new double[4];
			double[] array24 = new double[4];
			double[] array25 = new double[5];
			double[] array26 = new double[5];
			double[] array27 = new double[8];
			double[] array28 = new double[16];
			double[] array29 = new double[16];
			double[] array30 = new double[16];
			double[] array31 = new double[32];
			double[] array32 = new double[32];
			double[] array33 = new double[48];
			double[] array34 = new double[64];
			double[] array35 = new double[8];
			double[] array36 = new double[8];
			double[] array37 = new double[8];
			double[] array38 = new double[8];
			double[] array39 = new double[8];
			double[] array40 = new double[8];
			double[] array41 = new double[8];
			double[] array42 = new double[8];
			double[] array43 = new double[8];
			double[] array44 = new double[8];
			double[] array45 = new double[8];
			double[] array46 = new double[8];
			double[] array47 = new double[8];
			double[] array48 = new double[8];
			double[] array49 = new double[8];
			double[] array50 = new double[8];
			double[] array51 = new double[8];
			double[] array52 = new double[8];
			int elen = 0;
			int elen2 = 0;
			int elen3 = 0;
			int elen4 = 0;
			int elen5 = 0;
			int elen6 = 0;
			double[] array53 = new double[16];
			double[] array54 = new double[16];
			double[] array55 = new double[16];
			double[] array56 = new double[16];
			double[] array57 = new double[16];
			double[] array58 = new double[16];
			double[] array59 = new double[8];
			double[] array60 = new double[8];
			double[] array61 = new double[8];
			double[] array62 = new double[8];
			double[] array63 = new double[8];
			double[] array64 = new double[8];
			double[] array65 = new double[8];
			double[] array66 = new double[8];
			double[] array67 = new double[8];
			double[] array68 = new double[4];
			double[] array69 = new double[4];
			double[] array70 = new double[4];
			double num = pa.X - pd.X;
			double num2 = pb.X - pd.X;
			double num3 = pc.X - pd.X;
			double num4 = pa.Y - pd.Y;
			double num5 = pb.Y - pd.Y;
			double num6 = pc.Y - pd.Y;
			num = pa.X - pd.X;
			num2 = pb.X - pd.X;
			num3 = pc.X - pd.X;
			num4 = pa.Y - pd.Y;
			num5 = pb.Y - pd.Y;
			num6 = pc.Y - pd.Y;
			double num7 = num2 * num6;
			double num8 = splitter * num2;
			double num9 = num8 - num2;
			double num10 = num8 - num9;
			double num11 = num2 - num10;
			double num12 = splitter * num6;
			num9 = num12 - num6;
			double num13 = num12 - num9;
			double num14 = num6 - num13;
			double num15 = num7 - num10 * num13 - num11 * num13 - num10 * num14;
			double num16 = num11 * num14 - num15;
			double num17 = num3 * num5;
			double num18 = splitter * num3;
			num9 = num18 - num3;
			num10 = num18 - num9;
			num11 = num3 - num10;
			double num19 = splitter * num5;
			num9 = num19 - num5;
			num13 = num19 - num9;
			num14 = num5 - num13;
			num15 = num17 - num10 * num13 - num11 * num13 - num10 * num14;
			double num20 = num11 * num14 - num15;
			double num21 = num16 - num20;
			double num22 = num16 - num21;
			double num23 = num21 + num22;
			double num24 = num22 - num20;
			double num25 = num16 - num23;
			array[0] = num25 + num24;
			double num26 = num7 + num21;
			num22 = num26 - num7;
			num23 = num26 - num22;
			num24 = num21 - num22;
			num25 = num7 - num23;
			double num27 = num25 + num24;
			num21 = num27 - num17;
			num22 = num27 - num21;
			num23 = num21 + num22;
			num24 = num22 - num17;
			num25 = num27 - num23;
			array[1] = num25 + num24;
			double num28 = num26 + num21;
			num22 = num28 - num26;
			num23 = num28 - num22;
			num24 = num21 - num22;
			num25 = num26 - num23;
			array[2] = num25 + num24;
			array[3] = num28;
			int elen7 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array, num, array4), array4, num, array5);
			int flen = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array, num4, array6), array6, num4, array7);
			int elen8 = FastExpansionSumZeroElim(elen7, array5, flen, array7, array8);
			double num29 = num3 * num4;
			double num30 = splitter * num3;
			num9 = num30 - num3;
			num10 = num30 - num9;
			num11 = num3 - num10;
			double num31 = splitter * num4;
			num9 = num31 - num4;
			num13 = num31 - num9;
			num14 = num4 - num13;
			num15 = num29 - num10 * num13 - num11 * num13 - num10 * num14;
			double num32 = num11 * num14 - num15;
			double num33 = num * num6;
			double num34 = splitter * num;
			num9 = num34 - num;
			num10 = num34 - num9;
			num11 = num - num10;
			double num35 = splitter * num6;
			num9 = num35 - num6;
			num13 = num35 - num9;
			num14 = num6 - num13;
			num15 = num33 - num10 * num13 - num11 * num13 - num10 * num14;
			double num36 = num11 * num14 - num15;
			num21 = num32 - num36;
			num22 = num32 - num21;
			num23 = num21 + num22;
			num24 = num22 - num36;
			num25 = num32 - num23;
			array2[0] = num25 + num24;
			num26 = num29 + num21;
			num22 = num26 - num29;
			num23 = num26 - num22;
			num24 = num21 - num22;
			num25 = num29 - num23;
			num27 = num25 + num24;
			num21 = num27 - num33;
			num22 = num27 - num21;
			num23 = num21 + num22;
			num24 = num22 - num33;
			num25 = num27 - num23;
			array2[1] = num25 + num24;
			double num37 = num26 + num21;
			num22 = num37 - num26;
			num23 = num37 - num22;
			num24 = num21 - num22;
			num25 = num26 - num23;
			array2[2] = num25 + num24;
			array2[3] = num37;
			int elen9 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array2, num2, array9), array9, num2, array10);
			int flen2 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array2, num5, array11), array11, num5, array12);
			int flen3 = FastExpansionSumZeroElim(elen9, array10, flen2, array12, array13);
			double num38 = num * num5;
			double num39 = splitter * num;
			num9 = num39 - num;
			num10 = num39 - num9;
			num11 = num - num10;
			double num40 = splitter * num5;
			num9 = num40 - num5;
			num13 = num40 - num9;
			num14 = num5 - num13;
			num15 = num38 - num10 * num13 - num11 * num13 - num10 * num14;
			double num41 = num11 * num14 - num15;
			double num42 = num2 * num4;
			double num43 = splitter * num2;
			num9 = num43 - num2;
			num10 = num43 - num9;
			num11 = num2 - num10;
			double num44 = splitter * num4;
			num9 = num44 - num4;
			num13 = num44 - num9;
			num14 = num4 - num13;
			num15 = num42 - num10 * num13 - num11 * num13 - num10 * num14;
			double num45 = num11 * num14 - num15;
			num21 = num41 - num45;
			num22 = num41 - num21;
			num23 = num21 + num22;
			num24 = num22 - num45;
			num25 = num41 - num23;
			array3[0] = num25 + num24;
			num26 = num38 + num21;
			num22 = num26 - num38;
			num23 = num26 - num22;
			num24 = num21 - num22;
			num25 = num38 - num23;
			num27 = num25 + num24;
			num21 = num27 - num42;
			num22 = num27 - num21;
			num23 = num21 + num22;
			num24 = num22 - num42;
			num25 = num27 - num23;
			array3[1] = num25 + num24;
			double num46 = num26 + num21;
			num22 = num46 - num26;
			num23 = num46 - num22;
			num24 = num21 - num22;
			num25 = num26 - num23;
			array3[2] = num25 + num24;
			array3[3] = num46;
			int elen10 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array3, num3, array14), array14, num3, array15);
			int flen4 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array3, num6, array16), array16, num6, array17);
			int num47 = FastExpansionSumZeroElim(flen: FastExpansionSumZeroElim(elen10, array15, flen4, array17, array18), elen: FastExpansionSumZeroElim(elen8, array8, flen3, array13, array19), e: array19, f: array18, h: array20);
			double num48 = Estimate(num47, array20);
			double num49 = iccerrboundB * permanent;
			if (num48 >= num49 || 0.0 - num48 >= num49)
			{
				return num48;
			}
			num22 = pa.X - num;
			num23 = num + num22;
			num24 = num22 - pd.X;
			num25 = pa.X - num23;
			double num50 = num25 + num24;
			num22 = pa.Y - num4;
			num23 = num4 + num22;
			num24 = num22 - pd.Y;
			num25 = pa.Y - num23;
			double num51 = num25 + num24;
			num22 = pb.X - num2;
			num23 = num2 + num22;
			num24 = num22 - pd.X;
			num25 = pb.X - num23;
			double num52 = num25 + num24;
			num22 = pb.Y - num5;
			num23 = num5 + num22;
			num24 = num22 - pd.Y;
			num25 = pb.Y - num23;
			double num53 = num25 + num24;
			num22 = pc.X - num3;
			num23 = num3 + num22;
			num24 = num22 - pd.X;
			num25 = pc.X - num23;
			double num54 = num25 + num24;
			num22 = pc.Y - num6;
			num23 = num6 + num22;
			num24 = num22 - pd.Y;
			num25 = pc.Y - num23;
			double num55 = num25 + num24;
			if (num50 == 0.0 && num52 == 0.0 && num54 == 0.0 && num51 == 0.0 && num53 == 0.0 && num55 == 0.0)
			{
				return num48;
			}
			num49 = iccerrboundC * permanent + resulterrbound * ((num48 >= 0.0) ? num48 : (0.0 - num48));
			num48 += (num * num + num4 * num4) * (num2 * num55 + num6 * num52 - (num5 * num54 + num3 * num53)) + 2.0 * (num * num50 + num4 * num51) * (num2 * num6 - num5 * num3) + ((num2 * num2 + num5 * num5) * (num3 * num51 + num4 * num54 - (num6 * num50 + num * num55)) + 2.0 * (num2 * num52 + num5 * num53) * (num3 * num4 - num6 * num)) + ((num3 * num3 + num6 * num6) * (num * num53 + num5 * num50 - (num4 * num52 + num2 * num51)) + 2.0 * (num3 * num54 + num6 * num55) * (num * num5 - num4 * num2));
			if (num48 >= num49 || 0.0 - num48 >= num49)
			{
				return num48;
			}
			double[] array71 = array20;
			double[] array72 = array21;
			if (num52 != 0.0 || num53 != 0.0 || num54 != 0.0 || num55 != 0.0)
			{
				double num56 = num * num;
				double num57 = splitter * num;
				num9 = num57 - num;
				num10 = num57 - num9;
				num11 = num - num10;
				num15 = num56 - num10 * num10 - (num10 + num10) * num11;
				double num58 = num11 * num11 - num15;
				double num59 = num4 * num4;
				double num60 = splitter * num4;
				num9 = num60 - num4;
				num10 = num60 - num9;
				num11 = num4 - num10;
				num15 = num59 - num10 * num10 - (num10 + num10) * num11;
				double num61 = num11 * num11 - num15;
				num21 = num58 + num61;
				num22 = num21 - num58;
				num23 = num21 - num22;
				num24 = num61 - num22;
				num25 = num58 - num23;
				array22[0] = num25 + num24;
				num26 = num56 + num21;
				num22 = num26 - num56;
				num23 = num26 - num22;
				num24 = num21 - num22;
				num25 = num56 - num23;
				num27 = num25 + num24;
				num21 = num27 + num59;
				num22 = num21 - num27;
				num23 = num21 - num22;
				num24 = num59 - num22;
				num25 = num27 - num23;
				array22[1] = num25 + num24;
				double num62 = num26 + num21;
				num22 = num62 - num26;
				num23 = num62 - num22;
				num24 = num21 - num22;
				num25 = num26 - num23;
				array22[2] = num25 + num24;
				array22[3] = num62;
			}
			if (num54 != 0.0 || num55 != 0.0 || num50 != 0.0 || num51 != 0.0)
			{
				double num63 = num2 * num2;
				double num64 = splitter * num2;
				num9 = num64 - num2;
				num10 = num64 - num9;
				num11 = num2 - num10;
				num15 = num63 - num10 * num10 - (num10 + num10) * num11;
				double num65 = num11 * num11 - num15;
				double num66 = num5 * num5;
				double num67 = splitter * num5;
				num9 = num67 - num5;
				num10 = num67 - num9;
				num11 = num5 - num10;
				num15 = num66 - num10 * num10 - (num10 + num10) * num11;
				double num68 = num11 * num11 - num15;
				num21 = num65 + num68;
				num22 = num21 - num65;
				num23 = num21 - num22;
				num24 = num68 - num22;
				num25 = num65 - num23;
				array23[0] = num25 + num24;
				num26 = num63 + num21;
				num22 = num26 - num63;
				num23 = num26 - num22;
				num24 = num21 - num22;
				num25 = num63 - num23;
				num27 = num25 + num24;
				num21 = num27 + num66;
				num22 = num21 - num27;
				num23 = num21 - num22;
				num24 = num66 - num22;
				num25 = num27 - num23;
				array23[1] = num25 + num24;
				double num69 = num26 + num21;
				num22 = num69 - num26;
				num23 = num69 - num22;
				num24 = num21 - num22;
				num25 = num26 - num23;
				array23[2] = num25 + num24;
				array23[3] = num69;
			}
			if (num50 != 0.0 || num51 != 0.0 || num52 != 0.0 || num53 != 0.0)
			{
				double num70 = num3 * num3;
				double num71 = splitter * num3;
				num9 = num71 - num3;
				num10 = num71 - num9;
				num11 = num3 - num10;
				num15 = num70 - num10 * num10 - (num10 + num10) * num11;
				double num72 = num11 * num11 - num15;
				double num73 = num6 * num6;
				double num74 = splitter * num6;
				num9 = num74 - num6;
				num10 = num74 - num9;
				num11 = num6 - num10;
				num15 = num73 - num10 * num10 - (num10 + num10) * num11;
				double num75 = num11 * num11 - num15;
				num21 = num72 + num75;
				num22 = num21 - num72;
				num23 = num21 - num22;
				num24 = num75 - num22;
				num25 = num72 - num23;
				array24[0] = num25 + num24;
				num26 = num70 + num21;
				num22 = num26 - num70;
				num23 = num26 - num22;
				num24 = num21 - num22;
				num25 = num70 - num23;
				num27 = num25 + num24;
				num21 = num27 + num73;
				num22 = num21 - num27;
				num23 = num21 - num22;
				num24 = num73 - num22;
				num25 = num27 - num23;
				array24[1] = num25 + num24;
				double num76 = num26 + num21;
				num22 = num76 - num26;
				num23 = num76 - num22;
				num24 = num21 - num22;
				num25 = num26 - num23;
				array24[2] = num25 + num24;
				array24[3] = num76;
			}
			if (num50 != 0.0)
			{
				elen = ScaleExpansionZeroElim(4, array, num50, array47);
				int elen11 = ScaleExpansionZeroElim(elen, array47, 2.0 * num, array28);
				int flen5 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array24, num50, array36), array36, num5, array29);
				int elen12 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array23, num50, array35), array35, 0.0 - num6, array30);
				int flen6 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array31);
				int flen7 = FastExpansionSumZeroElim(elen12, array30, flen6, array31, array33);
				num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
				double[] array73 = array71;
				array71 = array72;
				array72 = array73;
			}
			if (num51 != 0.0)
			{
				elen2 = ScaleExpansionZeroElim(4, array, num51, array48);
				int elen11 = ScaleExpansionZeroElim(elen2, array48, 2.0 * num4, array28);
				int flen5 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array23, num51, array37), array37, num3, array29);
				int elen13 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array24, num51, array38), array38, 0.0 - num2, array30);
				int flen6 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array31);
				int flen7 = FastExpansionSumZeroElim(elen13, array30, flen6, array31, array33);
				num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
				double[] array74 = array71;
				array71 = array72;
				array72 = array74;
			}
			if (num52 != 0.0)
			{
				elen3 = ScaleExpansionZeroElim(4, array2, num52, array49);
				int elen11 = ScaleExpansionZeroElim(elen3, array49, 2.0 * num2, array28);
				int flen5 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array22, num52, array39), array39, num6, array29);
				int elen14 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array24, num52, array40), array40, 0.0 - num4, array30);
				int flen6 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array31);
				int flen7 = FastExpansionSumZeroElim(elen14, array30, flen6, array31, array33);
				num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
				double[] array75 = array71;
				array71 = array72;
				array72 = array75;
			}
			if (num53 != 0.0)
			{
				elen4 = ScaleExpansionZeroElim(4, array2, num53, array50);
				int elen11 = ScaleExpansionZeroElim(elen4, array50, 2.0 * num5, array28);
				int flen5 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array24, num53, array42), array42, num, array29);
				int elen15 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array22, num53, array41), array41, 0.0 - num3, array30);
				int flen6 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array31);
				int flen7 = FastExpansionSumZeroElim(elen15, array30, flen6, array31, array33);
				num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
				double[] array76 = array71;
				array71 = array72;
				array72 = array76;
			}
			if (num54 != 0.0)
			{
				elen5 = ScaleExpansionZeroElim(4, array3, num54, array51);
				int elen11 = ScaleExpansionZeroElim(elen5, array51, 2.0 * num3, array28);
				int flen5 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array23, num54, array44), array44, num4, array29);
				int elen16 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array22, num54, array43), array43, 0.0 - num5, array30);
				int flen6 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array31);
				int flen7 = FastExpansionSumZeroElim(elen16, array30, flen6, array31, array33);
				num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
				double[] array77 = array71;
				array71 = array72;
				array72 = array77;
			}
			if (num55 != 0.0)
			{
				elen6 = ScaleExpansionZeroElim(4, array3, num55, array52);
				int elen11 = ScaleExpansionZeroElim(elen6, array52, 2.0 * num6, array28);
				int flen5 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array22, num55, array45), array45, num2, array29);
				int elen17 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array23, num55, array46), array46, 0.0 - num, array30);
				int flen6 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array31);
				int flen7 = FastExpansionSumZeroElim(elen17, array30, flen6, array31, array33);
				num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
				double[] array78 = array71;
				array71 = array72;
				array72 = array78;
			}
			if (num50 != 0.0 || num51 != 0.0)
			{
				int elen18;
				int elen19;
				if (num52 != 0.0 || num53 != 0.0 || num54 != 0.0 || num55 != 0.0)
				{
					double num77 = num52 * num6;
					double num78 = splitter * num52;
					num9 = num78 - num52;
					num10 = num78 - num9;
					num11 = num52 - num10;
					double num79 = splitter * num6;
					num9 = num79 - num6;
					num13 = num79 - num9;
					num14 = num6 - num13;
					num15 = num77 - num10 * num13 - num11 * num13 - num10 * num14;
					double num80 = num11 * num14 - num15;
					double num81 = num2 * num55;
					double num82 = splitter * num2;
					num9 = num82 - num2;
					num10 = num82 - num9;
					num11 = num2 - num10;
					double num83 = splitter * num55;
					num9 = num83 - num55;
					num13 = num83 - num9;
					num14 = num55 - num13;
					num15 = num81 - num10 * num13 - num11 * num13 - num10 * num14;
					double num84 = num11 * num14 - num15;
					num21 = num80 + num84;
					num22 = num21 - num80;
					num23 = num21 - num22;
					num24 = num84 - num22;
					num25 = num80 - num23;
					array25[0] = num25 + num24;
					num26 = num77 + num21;
					num22 = num26 - num77;
					num23 = num26 - num22;
					num24 = num21 - num22;
					num25 = num77 - num23;
					num27 = num25 + num24;
					num21 = num27 + num81;
					num22 = num21 - num27;
					num23 = num21 - num22;
					num24 = num81 - num22;
					num25 = num27 - num23;
					array25[1] = num25 + num24;
					double num85 = num26 + num21;
					num22 = num85 - num26;
					num23 = num85 - num22;
					num24 = num21 - num22;
					num25 = num26 - num23;
					array25[2] = num25 + num24;
					array25[3] = num85;
					double num86 = 0.0 - num5;
					num77 = num54 * num86;
					double num87 = splitter * num54;
					num9 = num87 - num54;
					num10 = num87 - num9;
					num11 = num54 - num10;
					double num88 = splitter * num86;
					num9 = num88 - num86;
					num13 = num88 - num9;
					num14 = num86 - num13;
					num15 = num77 - num10 * num13 - num11 * num13 - num10 * num14;
					num80 = num11 * num14 - num15;
					num86 = 0.0 - num53;
					num81 = num3 * num86;
					double num89 = splitter * num3;
					num9 = num89 - num3;
					num10 = num89 - num9;
					num11 = num3 - num10;
					double num90 = splitter * num86;
					num9 = num90 - num86;
					num13 = num90 - num9;
					num14 = num86 - num13;
					num15 = num81 - num10 * num13 - num11 * num13 - num10 * num14;
					num84 = num11 * num14 - num15;
					num21 = num80 + num84;
					num22 = num21 - num80;
					num23 = num21 - num22;
					num24 = num84 - num22;
					num25 = num80 - num23;
					array26[0] = num25 + num24;
					num26 = num77 + num21;
					num22 = num26 - num77;
					num23 = num26 - num22;
					num24 = num21 - num22;
					num25 = num77 - num23;
					num27 = num25 + num24;
					num21 = num27 + num81;
					num22 = num21 - num27;
					num23 = num21 - num22;
					num24 = num81 - num22;
					num25 = num27 - num23;
					array26[1] = num25 + num24;
					double num91 = num26 + num21;
					num22 = num91 - num26;
					num23 = num91 - num22;
					num24 = num21 - num22;
					num25 = num26 - num23;
					array26[2] = num25 + num24;
					array26[3] = num91;
					elen18 = FastExpansionSumZeroElim(4, array25, 4, array26, array66);
					num77 = num52 * num55;
					double num92 = splitter * num52;
					num9 = num92 - num52;
					num10 = num92 - num9;
					num11 = num52 - num10;
					double num93 = splitter * num55;
					num9 = num93 - num55;
					num13 = num93 - num9;
					num14 = num55 - num13;
					num15 = num77 - num10 * num13 - num11 * num13 - num10 * num14;
					num80 = num11 * num14 - num15;
					num81 = num54 * num53;
					double num94 = splitter * num54;
					num9 = num94 - num54;
					num10 = num94 - num9;
					num11 = num54 - num10;
					double num95 = splitter * num53;
					num9 = num95 - num53;
					num13 = num95 - num9;
					num14 = num53 - num13;
					num15 = num81 - num10 * num13 - num11 * num13 - num10 * num14;
					num84 = num11 * num14 - num15;
					num21 = num80 - num84;
					num22 = num80 - num21;
					num23 = num21 + num22;
					num24 = num22 - num84;
					num25 = num80 - num23;
					array69[0] = num25 + num24;
					num26 = num77 + num21;
					num22 = num26 - num77;
					num23 = num26 - num22;
					num24 = num21 - num22;
					num25 = num77 - num23;
					num27 = num25 + num24;
					num21 = num27 - num81;
					num22 = num27 - num21;
					num23 = num21 + num22;
					num24 = num22 - num81;
					num25 = num27 - num23;
					array69[1] = num25 + num24;
					double num96 = num26 + num21;
					num22 = num96 - num26;
					num23 = num96 - num22;
					num24 = num21 - num22;
					num25 = num26 - num23;
					array69[2] = num25 + num24;
					array69[3] = num96;
					elen19 = 4;
				}
				else
				{
					array66[0] = 0.0;
					elen18 = 1;
					array69[0] = 0.0;
					elen19 = 1;
				}
				if (num50 != 0.0)
				{
					int elen11 = ScaleExpansionZeroElim(elen, array47, num50, array28);
					int elen20 = ScaleExpansionZeroElim(elen18, array66, num50, array53);
					int flen6 = ScaleExpansionZeroElim(elen20, array53, 2.0 * num, array31);
					int flen7 = FastExpansionSumZeroElim(elen11, array28, flen6, array31, array33);
					num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
					double[] array79 = array71;
					array71 = array72;
					array72 = array79;
					if (num53 != 0.0)
					{
						elen11 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array24, num50, array27), array27, num53, array28);
						num47 = FastExpansionSumZeroElim(num47, array71, elen11, array28, array72);
						double[] array80 = array71;
						array71 = array72;
						array72 = array80;
					}
					if (num55 != 0.0)
					{
						elen11 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array23, 0.0 - num50, array27), array27, num55, array28);
						num47 = FastExpansionSumZeroElim(num47, array71, elen11, array28, array72);
						double[] array81 = array71;
						array71 = array72;
						array72 = array81;
					}
					flen6 = ScaleExpansionZeroElim(elen20, array53, num50, array31);
					int elen21 = ScaleExpansionZeroElim(elen19, array69, num50, array59);
					elen11 = ScaleExpansionZeroElim(elen21, array59, 2.0 * num, array28);
					int flen5 = ScaleExpansionZeroElim(elen21, array59, num50, array29);
					int flen8 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array32);
					int flen9 = FastExpansionSumZeroElim(flen6, array31, flen8, array32, array34);
					num47 = FastExpansionSumZeroElim(num47, array71, flen9, array34, array72);
					double[] array82 = array71;
					array71 = array72;
					array72 = array82;
				}
				if (num51 != 0.0)
				{
					int elen11 = ScaleExpansionZeroElim(elen2, array48, num51, array28);
					int elen22 = ScaleExpansionZeroElim(elen18, array66, num51, array54);
					int flen6 = ScaleExpansionZeroElim(elen22, array54, 2.0 * num4, array31);
					int flen7 = FastExpansionSumZeroElim(elen11, array28, flen6, array31, array33);
					num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
					double[] array83 = array71;
					array71 = array72;
					array72 = array83;
					flen6 = ScaleExpansionZeroElim(elen22, array54, num51, array31);
					int elen23 = ScaleExpansionZeroElim(elen19, array69, num51, array60);
					elen11 = ScaleExpansionZeroElim(elen23, array60, 2.0 * num4, array28);
					int flen5 = ScaleExpansionZeroElim(elen23, array60, num51, array29);
					int flen8 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array32);
					int flen9 = FastExpansionSumZeroElim(flen6, array31, flen8, array32, array34);
					num47 = FastExpansionSumZeroElim(num47, array71, flen9, array34, array72);
					double[] array84 = array71;
					array71 = array72;
					array72 = array84;
				}
			}
			if (num52 != 0.0 || num53 != 0.0)
			{
				int elen24;
				int elen25;
				if (num54 != 0.0 || num55 != 0.0 || num50 != 0.0 || num51 != 0.0)
				{
					double num77 = num54 * num4;
					double num97 = splitter * num54;
					num9 = num97 - num54;
					num10 = num97 - num9;
					num11 = num54 - num10;
					double num98 = splitter * num4;
					num9 = num98 - num4;
					num13 = num98 - num9;
					num14 = num4 - num13;
					num15 = num77 - num10 * num13 - num11 * num13 - num10 * num14;
					double num80 = num11 * num14 - num15;
					double num81 = num3 * num51;
					double num99 = splitter * num3;
					num9 = num99 - num3;
					num10 = num99 - num9;
					num11 = num3 - num10;
					double num100 = splitter * num51;
					num9 = num100 - num51;
					num13 = num100 - num9;
					num14 = num51 - num13;
					num15 = num81 - num10 * num13 - num11 * num13 - num10 * num14;
					double num84 = num11 * num14 - num15;
					num21 = num80 + num84;
					num22 = num21 - num80;
					num23 = num21 - num22;
					num24 = num84 - num22;
					num25 = num80 - num23;
					array25[0] = num25 + num24;
					num26 = num77 + num21;
					num22 = num26 - num77;
					num23 = num26 - num22;
					num24 = num21 - num22;
					num25 = num77 - num23;
					num27 = num25 + num24;
					num21 = num27 + num81;
					num22 = num21 - num27;
					num23 = num21 - num22;
					num24 = num81 - num22;
					num25 = num27 - num23;
					array25[1] = num25 + num24;
					double num85 = num26 + num21;
					num22 = num85 - num26;
					num23 = num85 - num22;
					num24 = num21 - num22;
					num25 = num26 - num23;
					array25[2] = num25 + num24;
					array25[3] = num85;
					double num86 = 0.0 - num6;
					num77 = num50 * num86;
					double num101 = splitter * num50;
					num9 = num101 - num50;
					num10 = num101 - num9;
					num11 = num50 - num10;
					double num102 = splitter * num86;
					num9 = num102 - num86;
					num13 = num102 - num9;
					num14 = num86 - num13;
					num15 = num77 - num10 * num13 - num11 * num13 - num10 * num14;
					num80 = num11 * num14 - num15;
					num86 = 0.0 - num55;
					num81 = num * num86;
					double num103 = splitter * num;
					num9 = num103 - num;
					num10 = num103 - num9;
					num11 = num - num10;
					double num104 = splitter * num86;
					num9 = num104 - num86;
					num13 = num104 - num9;
					num14 = num86 - num13;
					num15 = num81 - num10 * num13 - num11 * num13 - num10 * num14;
					num84 = num11 * num14 - num15;
					num21 = num80 + num84;
					num22 = num21 - num80;
					num23 = num21 - num22;
					num24 = num84 - num22;
					num25 = num80 - num23;
					array26[0] = num25 + num24;
					num26 = num77 + num21;
					num22 = num26 - num77;
					num23 = num26 - num22;
					num24 = num21 - num22;
					num25 = num77 - num23;
					num27 = num25 + num24;
					num21 = num27 + num81;
					num22 = num21 - num27;
					num23 = num21 - num22;
					num24 = num81 - num22;
					num25 = num27 - num23;
					array26[1] = num25 + num24;
					double num91 = num26 + num21;
					num22 = num91 - num26;
					num23 = num91 - num22;
					num24 = num21 - num22;
					num25 = num26 - num23;
					array26[2] = num25 + num24;
					array26[3] = num91;
					elen24 = FastExpansionSumZeroElim(4, array25, 4, array26, array67);
					num77 = num54 * num51;
					double num105 = splitter * num54;
					num9 = num105 - num54;
					num10 = num105 - num9;
					num11 = num54 - num10;
					double num106 = splitter * num51;
					num9 = num106 - num51;
					num13 = num106 - num9;
					num14 = num51 - num13;
					num15 = num77 - num10 * num13 - num11 * num13 - num10 * num14;
					num80 = num11 * num14 - num15;
					num81 = num50 * num55;
					double num107 = splitter * num50;
					num9 = num107 - num50;
					num10 = num107 - num9;
					num11 = num50 - num10;
					double num108 = splitter * num55;
					num9 = num108 - num55;
					num13 = num108 - num9;
					num14 = num55 - num13;
					num15 = num81 - num10 * num13 - num11 * num13 - num10 * num14;
					num84 = num11 * num14 - num15;
					num21 = num80 - num84;
					num22 = num80 - num21;
					num23 = num21 + num22;
					num24 = num22 - num84;
					num25 = num80 - num23;
					array70[0] = num25 + num24;
					num26 = num77 + num21;
					num22 = num26 - num77;
					num23 = num26 - num22;
					num24 = num21 - num22;
					num25 = num77 - num23;
					num27 = num25 + num24;
					num21 = num27 - num81;
					num22 = num27 - num21;
					num23 = num21 + num22;
					num24 = num22 - num81;
					num25 = num27 - num23;
					array70[1] = num25 + num24;
					double num109 = num26 + num21;
					num22 = num109 - num26;
					num23 = num109 - num22;
					num24 = num21 - num22;
					num25 = num26 - num23;
					array70[2] = num25 + num24;
					array70[3] = num109;
					elen25 = 4;
				}
				else
				{
					array67[0] = 0.0;
					elen24 = 1;
					array70[0] = 0.0;
					elen25 = 1;
				}
				if (num52 != 0.0)
				{
					int elen11 = ScaleExpansionZeroElim(elen3, array49, num52, array28);
					int elen26 = ScaleExpansionZeroElim(elen24, array67, num52, array55);
					int flen6 = ScaleExpansionZeroElim(elen26, array55, 2.0 * num2, array31);
					int flen7 = FastExpansionSumZeroElim(elen11, array28, flen6, array31, array33);
					num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
					double[] array85 = array71;
					array71 = array72;
					array72 = array85;
					if (num55 != 0.0)
					{
						elen11 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array22, num52, array27), array27, num55, array28);
						num47 = FastExpansionSumZeroElim(num47, array71, elen11, array28, array72);
						double[] array86 = array71;
						array71 = array72;
						array72 = array86;
					}
					if (num51 != 0.0)
					{
						elen11 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array24, 0.0 - num52, array27), array27, num51, array28);
						num47 = FastExpansionSumZeroElim(num47, array71, elen11, array28, array72);
						double[] array87 = array71;
						array71 = array72;
						array72 = array87;
					}
					flen6 = ScaleExpansionZeroElim(elen26, array55, num52, array31);
					int elen27 = ScaleExpansionZeroElim(elen25, array70, num52, array61);
					elen11 = ScaleExpansionZeroElim(elen27, array61, 2.0 * num2, array28);
					int flen5 = ScaleExpansionZeroElim(elen27, array61, num52, array29);
					int flen8 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array32);
					int flen9 = FastExpansionSumZeroElim(flen6, array31, flen8, array32, array34);
					num47 = FastExpansionSumZeroElim(num47, array71, flen9, array34, array72);
					double[] array88 = array71;
					array71 = array72;
					array72 = array88;
				}
				if (num53 != 0.0)
				{
					int elen11 = ScaleExpansionZeroElim(elen4, array50, num53, array28);
					int elen28 = ScaleExpansionZeroElim(elen24, array67, num53, array56);
					int flen6 = ScaleExpansionZeroElim(elen28, array56, 2.0 * num5, array31);
					int flen7 = FastExpansionSumZeroElim(elen11, array28, flen6, array31, array33);
					num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
					double[] array89 = array71;
					array71 = array72;
					array72 = array89;
					flen6 = ScaleExpansionZeroElim(elen28, array56, num53, array31);
					int elen29 = ScaleExpansionZeroElim(elen25, array70, num53, array62);
					elen11 = ScaleExpansionZeroElim(elen29, array62, 2.0 * num5, array28);
					int flen5 = ScaleExpansionZeroElim(elen29, array62, num53, array29);
					int flen8 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array32);
					int flen9 = FastExpansionSumZeroElim(flen6, array31, flen8, array32, array34);
					num47 = FastExpansionSumZeroElim(num47, array71, flen9, array34, array72);
					double[] array90 = array71;
					array71 = array72;
					array72 = array90;
				}
			}
			if (num54 != 0.0 || num55 != 0.0)
			{
				int elen30;
				int elen31;
				if (num50 != 0.0 || num51 != 0.0 || num52 != 0.0 || num53 != 0.0)
				{
					double num77 = num50 * num5;
					double num110 = splitter * num50;
					num9 = num110 - num50;
					num10 = num110 - num9;
					num11 = num50 - num10;
					double num111 = splitter * num5;
					num9 = num111 - num5;
					num13 = num111 - num9;
					num14 = num5 - num13;
					num15 = num77 - num10 * num13 - num11 * num13 - num10 * num14;
					double num80 = num11 * num14 - num15;
					double num81 = num * num53;
					double num112 = splitter * num;
					num9 = num112 - num;
					num10 = num112 - num9;
					num11 = num - num10;
					double num113 = splitter * num53;
					num9 = num113 - num53;
					num13 = num113 - num9;
					num14 = num53 - num13;
					num15 = num81 - num10 * num13 - num11 * num13 - num10 * num14;
					double num84 = num11 * num14 - num15;
					num21 = num80 + num84;
					num22 = num21 - num80;
					num23 = num21 - num22;
					num24 = num84 - num22;
					num25 = num80 - num23;
					array25[0] = num25 + num24;
					num26 = num77 + num21;
					num22 = num26 - num77;
					num23 = num26 - num22;
					num24 = num21 - num22;
					num25 = num77 - num23;
					num27 = num25 + num24;
					num21 = num27 + num81;
					num22 = num21 - num27;
					num23 = num21 - num22;
					num24 = num81 - num22;
					num25 = num27 - num23;
					array25[1] = num25 + num24;
					double num85 = num26 + num21;
					num22 = num85 - num26;
					num23 = num85 - num22;
					num24 = num21 - num22;
					num25 = num26 - num23;
					array25[2] = num25 + num24;
					array25[3] = num85;
					double num86 = 0.0 - num4;
					num77 = num52 * num86;
					double num114 = splitter * num52;
					num9 = num114 - num52;
					num10 = num114 - num9;
					num11 = num52 - num10;
					double num115 = splitter * num86;
					num9 = num115 - num86;
					num13 = num115 - num9;
					num14 = num86 - num13;
					num15 = num77 - num10 * num13 - num11 * num13 - num10 * num14;
					num80 = num11 * num14 - num15;
					num86 = 0.0 - num51;
					num81 = num2 * num86;
					double num116 = splitter * num2;
					num9 = num116 - num2;
					num10 = num116 - num9;
					num11 = num2 - num10;
					double num117 = splitter * num86;
					num9 = num117 - num86;
					num13 = num117 - num9;
					num14 = num86 - num13;
					num15 = num81 - num10 * num13 - num11 * num13 - num10 * num14;
					num84 = num11 * num14 - num15;
					num21 = num80 + num84;
					num22 = num21 - num80;
					num23 = num21 - num22;
					num24 = num84 - num22;
					num25 = num80 - num23;
					array26[0] = num25 + num24;
					num26 = num77 + num21;
					num22 = num26 - num77;
					num23 = num26 - num22;
					num24 = num21 - num22;
					num25 = num77 - num23;
					num27 = num25 + num24;
					num21 = num27 + num81;
					num22 = num21 - num27;
					num23 = num21 - num22;
					num24 = num81 - num22;
					num25 = num27 - num23;
					array26[1] = num25 + num24;
					double num91 = num26 + num21;
					num22 = num91 - num26;
					num23 = num91 - num22;
					num24 = num21 - num22;
					num25 = num26 - num23;
					array26[2] = num25 + num24;
					array26[3] = num91;
					elen30 = FastExpansionSumZeroElim(4, array25, 4, array26, array65);
					num77 = num50 * num53;
					double num118 = splitter * num50;
					num9 = num118 - num50;
					num10 = num118 - num9;
					num11 = num50 - num10;
					double num119 = splitter * num53;
					num9 = num119 - num53;
					num13 = num119 - num9;
					num14 = num53 - num13;
					num15 = num77 - num10 * num13 - num11 * num13 - num10 * num14;
					num80 = num11 * num14 - num15;
					num81 = num52 * num51;
					double num120 = splitter * num52;
					num9 = num120 - num52;
					num10 = num120 - num9;
					num11 = num52 - num10;
					double num121 = splitter * num51;
					num9 = num121 - num51;
					num13 = num121 - num9;
					num14 = num51 - num13;
					num15 = num81 - num10 * num13 - num11 * num13 - num10 * num14;
					num84 = num11 * num14 - num15;
					num21 = num80 - num84;
					num22 = num80 - num21;
					num23 = num21 + num22;
					num24 = num22 - num84;
					num25 = num80 - num23;
					array68[0] = num25 + num24;
					num26 = num77 + num21;
					num22 = num26 - num77;
					num23 = num26 - num22;
					num24 = num21 - num22;
					num25 = num77 - num23;
					num27 = num25 + num24;
					num21 = num27 - num81;
					num22 = num27 - num21;
					num23 = num21 + num22;
					num24 = num22 - num81;
					num25 = num27 - num23;
					array68[1] = num25 + num24;
					double num122 = num26 + num21;
					num22 = num122 - num26;
					num23 = num122 - num22;
					num24 = num21 - num22;
					num25 = num26 - num23;
					array68[2] = num25 + num24;
					array68[3] = num122;
					elen31 = 4;
				}
				else
				{
					array65[0] = 0.0;
					elen30 = 1;
					array68[0] = 0.0;
					elen31 = 1;
				}
				if (num54 != 0.0)
				{
					int elen11 = ScaleExpansionZeroElim(elen5, array51, num54, array28);
					int elen32 = ScaleExpansionZeroElim(elen30, array65, num54, array57);
					int flen6 = ScaleExpansionZeroElim(elen32, array57, 2.0 * num3, array31);
					int flen7 = FastExpansionSumZeroElim(elen11, array28, flen6, array31, array33);
					num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
					double[] array91 = array71;
					array71 = array72;
					array72 = array91;
					if (num51 != 0.0)
					{
						elen11 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array23, num54, array27), array27, num51, array28);
						num47 = FastExpansionSumZeroElim(num47, array71, elen11, array28, array72);
						double[] array92 = array71;
						array71 = array72;
						array72 = array92;
					}
					if (num53 != 0.0)
					{
						elen11 = ScaleExpansionZeroElim(ScaleExpansionZeroElim(4, array22, 0.0 - num54, array27), array27, num53, array28);
						num47 = FastExpansionSumZeroElim(num47, array71, elen11, array28, array72);
						double[] array93 = array71;
						array71 = array72;
						array72 = array93;
					}
					flen6 = ScaleExpansionZeroElim(elen32, array57, num54, array31);
					int elen33 = ScaleExpansionZeroElim(elen31, array68, num54, array63);
					elen11 = ScaleExpansionZeroElim(elen33, array63, 2.0 * num3, array28);
					int flen5 = ScaleExpansionZeroElim(elen33, array63, num54, array29);
					int flen8 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array32);
					int flen9 = FastExpansionSumZeroElim(flen6, array31, flen8, array32, array34);
					num47 = FastExpansionSumZeroElim(num47, array71, flen9, array34, array72);
					double[] array94 = array71;
					array71 = array72;
					array72 = array94;
				}
				if (num55 != 0.0)
				{
					int elen11 = ScaleExpansionZeroElim(elen6, array52, num55, array28);
					int elen34 = ScaleExpansionZeroElim(elen30, array65, num55, array58);
					int flen6 = ScaleExpansionZeroElim(elen34, array58, 2.0 * num6, array31);
					int flen7 = FastExpansionSumZeroElim(elen11, array28, flen6, array31, array33);
					num47 = FastExpansionSumZeroElim(num47, array71, flen7, array33, array72);
					double[] array95 = array71;
					array71 = array72;
					array72 = array95;
					flen6 = ScaleExpansionZeroElim(elen34, array58, num55, array31);
					int elen35 = ScaleExpansionZeroElim(elen31, array68, num55, array64);
					elen11 = ScaleExpansionZeroElim(elen35, array64, 2.0 * num6, array28);
					int flen5 = ScaleExpansionZeroElim(elen35, array64, num55, array29);
					int flen8 = FastExpansionSumZeroElim(elen11, array28, flen5, array29, array32);
					int flen9 = FastExpansionSumZeroElim(flen6, array31, flen8, array32, array34);
					num47 = FastExpansionSumZeroElim(num47, array71, flen9, array34, array72);
					double[] array96 = array71;
					array71 = array72;
					array72 = array96;
				}
			}
			return array71[num47 - 1];
		}
	}
	internal class Sampler
	{
		private static Random rand = new Random(DateTime.Now.Millisecond);

		private int samples = 1;

		private int triangleCount;

		private static int samplefactor = 11;

		private int[] keys;

		public void Reset()
		{
			samples = 1;
			triangleCount = 0;
		}

		public void Update(Mesh mesh)
		{
			Update(mesh, forceUpdate: false);
		}

		public void Update(Mesh mesh, bool forceUpdate)
		{
			int count = mesh.triangles.Count;
			if (triangleCount != count || forceUpdate)
			{
				triangleCount = count;
				while (samplefactor * samples * samples * samples < count)
				{
					samples++;
				}
				keys = mesh.triangles.Keys.ToArray();
			}
		}

		public int[] GetSamples(Mesh mesh)
		{
			List<int> list = new List<int>(samples);
			int num = triangleCount / samples;
			for (int i = 0; i < samples; i++)
			{
				int num2 = rand.Next(i * num, (i + 1) * num - 1);
				if (!mesh.triangles.Keys.Contains(keys[num2]))
				{
					Update(mesh, forceUpdate: true);
					i--;
				}
				else
				{
					list.Add(keys[num2]);
				}
			}
			return list.ToArray();
		}
	}
	internal class TriangleLocator
	{
		private Sampler sampler;

		private Mesh mesh;

		internal Otri recenttri;

		public TriangleLocator(Mesh mesh)
		{
			this.mesh = mesh;
			sampler = new Sampler();
		}

		public void Update(ref Otri otri)
		{
			otri.Copy(ref recenttri);
		}

		public void Reset()
		{
			recenttri.triangle = null;
		}

		public LocateResult PreciseLocate(Point searchpoint, ref Otri searchtri, bool stopatsubsegment)
		{
			Otri o = default(Otri);
			Osub os = default(Osub);
			Vertex vertex = searchtri.Org();
			Vertex vertex2 = searchtri.Dest();
			Vertex vertex3 = searchtri.Apex();
			while (true)
			{
				if (vertex3.x == searchpoint.X && vertex3.y == searchpoint.Y)
				{
					searchtri.LprevSelf();
					return LocateResult.OnVertex;
				}
				double num = Primitives.CounterClockwise(vertex, vertex3, searchpoint);
				double num2 = Primitives.CounterClockwise(vertex3, vertex2, searchpoint);
				bool flag;
				if (num > 0.0)
				{
					flag = !(num2 > 0.0) || (vertex3.x - searchpoint.X) * (vertex2.x - vertex.x) + (vertex3.y - searchpoint.Y) * (vertex2.y - vertex.y) > 0.0;
				}
				else
				{
					if (!(num2 > 0.0))
					{
						if (num == 0.0)
						{
							searchtri.LprevSelf();
							return LocateResult.OnEdge;
						}
						if (num2 == 0.0)
						{
							searchtri.LnextSelf();
							return LocateResult.OnEdge;
						}
						return LocateResult.InTriangle;
					}
					flag = false;
				}
				if (flag)
				{
					searchtri.Lprev(ref o);
					vertex2 = vertex3;
				}
				else
				{
					searchtri.Lnext(ref o);
					vertex = vertex3;
				}
				o.Sym(ref searchtri);
				if (mesh.checksegments && stopatsubsegment)
				{
					o.SegPivot(ref os);
					if (os.seg != Mesh.dummysub)
					{
						o.Copy(ref searchtri);
						return LocateResult.Outside;
					}
				}
				if (searchtri.triangle == Mesh.dummytri)
				{
					break;
				}
				vertex3 = searchtri.Apex();
			}
			o.Copy(ref searchtri);
			return LocateResult.Outside;
		}

		public LocateResult Locate(Point searchpoint, ref Otri searchtri)
		{
			Otri otri = default(Otri);
			Vertex vertex = searchtri.Org();
			double num = (searchpoint.X - vertex.x) * (searchpoint.X - vertex.x) + (searchpoint.Y - vertex.y) * (searchpoint.Y - vertex.y);
			if (recenttri.triangle != null && !Otri.IsDead(recenttri.triangle))
			{
				vertex = recenttri.Org();
				if (vertex.x == searchpoint.X && vertex.y == searchpoint.Y)
				{
					recenttri.Copy(ref searchtri);
					return LocateResult.OnVertex;
				}
				double num2 = (searchpoint.X - vertex.x) * (searchpoint.X - vertex.x) + (searchpoint.Y - vertex.y) * (searchpoint.Y - vertex.y);
				if (num2 < num)
				{
					recenttri.Copy(ref searchtri);
					num = num2;
				}
			}
			sampler.Update(mesh);
			int[] samples = sampler.GetSamples(mesh);
			foreach (int key in samples)
			{
				otri.triangle = mesh.triangles[key];
				if (!Otri.IsDead(otri.triangle))
				{
					vertex = otri.Org();
					double num2 = (searchpoint.X - vertex.x) * (searchpoint.X - vertex.x) + (searchpoint.Y - vertex.y) * (searchpoint.Y - vertex.y);
					if (num2 < num)
					{
						otri.Copy(ref searchtri);
						num = num2;
					}
				}
			}
			vertex = searchtri.Org();
			Vertex vertex2 = searchtri.Dest();
			if (vertex.x == searchpoint.X && vertex.y == searchpoint.Y)
			{
				return LocateResult.OnVertex;
			}
			if (vertex2.x == searchpoint.X && vertex2.y == searchpoint.Y)
			{
				searchtri.LnextSelf();
				return LocateResult.OnVertex;
			}
			double num3 = Primitives.CounterClockwise(vertex, vertex2, searchpoint);
			if (num3 < 0.0)
			{
				searchtri.SymSelf();
			}
			else if (num3 == 0.0 && vertex.x < searchpoint.X == searchpoint.X < vertex2.x && vertex.y < searchpoint.Y == searchpoint.Y < vertex2.y)
			{
				return LocateResult.OnEdge;
			}
			return PreciseLocate(searchpoint, ref searchtri, stopatsubsegment: false);
		}
	}
}
namespace TriangleNet.Tools
{
	public class AdjacencyMatrix
	{
		private int node_num;

		private int adj_num;

		private int[] adj_row;

		private int[] adj;

		public int[] AdjacencyRow => adj_row;

		public int[] Adjacency => adj;

		public AdjacencyMatrix(Mesh mesh)
		{
			node_num = mesh.vertices.Count;
			adj_row = AdjacencyCount(mesh);
			adj_num = adj_row[node_num] - 1;
			adj = AdjacencySet(mesh, adj_row);
		}

		public int Bandwidth()
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < node_num; i++)
			{
				for (int j = adj_row[i]; j <= adj_row[i + 1] - 1; j++)
				{
					int num3 = adj[j - 1];
					num = Math.Max(num, i - num3);
					num2 = Math.Max(num2, num3 - i);
				}
			}
			return num + 1 + num2;
		}

		private int[] AdjacencyCount(Mesh mesh)
		{
			int[] array = new int[node_num + 1];
			int i;
			for (i = 0; i < node_num; i++)
			{
				array[i] = 1;
			}
			foreach (Triangle value in mesh.triangles.Values)
			{
				int id = value.id;
				int id2 = value.vertices[0].id;
				int id3 = value.vertices[1].id;
				int id4 = value.vertices[2].id;
				int id5 = value.neighbors[2].triangle.id;
				if (id5 < 0 || id < id5)
				{
					array[id2]++;
					array[id3]++;
				}
				id5 = value.neighbors[0].triangle.id;
				if (id5 < 0 || id < id5)
				{
					array[id3]++;
					array[id4]++;
				}
				id5 = value.neighbors[1].triangle.id;
				if (id5 < 0 || id < id5)
				{
					array[id4]++;
					array[id2]++;
				}
			}
			i = node_num;
			while (1 <= i)
			{
				array[i] = array[i - 1];
				i--;
			}
			array[0] = 1;
			for (int j = 1; j <= node_num; j++)
			{
				array[j] = array[j - 1] + array[j];
			}
			return array;
		}

		private int[] AdjacencySet(Mesh mesh, int[] rows)
		{
			int[] array = new int[node_num];
			Array.Copy(rows, array, node_num);
			int num = rows[node_num] - 1;
			int[] array2 = new int[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = -1;
			}
			for (int i = 0; i < node_num; i++)
			{
				array2[array[i] - 1] = i;
				array[i]++;
			}
			foreach (Triangle value in mesh.triangles.Values)
			{
				int id = value.id;
				int id2 = value.vertices[0].id;
				int id3 = value.vertices[1].id;
				int id4 = value.vertices[2].id;
				int id5 = value.neighbors[2].triangle.id;
				if (id5 < 0 || id < id5)
				{
					array2[array[id2] - 1] = id3;
					array[id2]++;
					array2[array[id3] - 1] = id2;
					array[id3]++;
				}
				id5 = value.neighbors[0].triangle.id;
				if (id5 < 0 || id < id5)
				{
					array2[array[id3] - 1] = id4;
					array[id3]++;
					array2[array[id4] - 1] = id3;
					array[id4]++;
				}
				id5 = value.neighbors[1].triangle.id;
				if (id5 < 0 || id < id5)
				{
					array2[array[id2] - 1] = id4;
					array[id2]++;
					array2[array[id4] - 1] = id2;
					array[id4]++;
				}
			}
			for (int i = 0; i < node_num; i++)
			{
				int num2 = rows[i];
				int num3 = rows[i + 1] - 1;
				HeapSort(array2, num2 - 1, num3 + 1 - num2);
			}
			return array2;
		}

		private void CreateHeap(int[] a, int offset, int size)
		{
			int num = size / 2 - 1;
			while (0 <= num)
			{
				int num2 = a[offset + num];
				int num3 = num;
				while (true)
				{
					int num4 = 2 * num3 + 1;
					if (size <= num4)
					{
						break;
					}
					if (num4 + 1 < size && a[offset + num4] < a[offset + num4 + 1])
					{
						num4++;
					}
					if (num2 >= a[offset + num4])
					{
						break;
					}
					a[offset + num3] = a[offset + num4];
					num3 = num4;
				}
				a[offset + num3] = num2;
				num--;
			}
		}

		private void HeapSort(int[] a, int offset, int size)
		{
			if (size > 1)
			{
				CreateHeap(a, offset, size);
				int num = a[offset];
				a[offset] = a[offset + size - 1];
				a[offset + size - 1] = num;
				int num2 = size - 1;
				while (2 <= num2)
				{
					CreateHeap(a, offset, num2);
					num = a[offset];
					a[offset] = a[offset + num2 - 1];
					a[offset + num2 - 1] = num;
					num2--;
				}
			}
		}
	}
	public class BoundedVoronoi : IVoronoi
	{
		private Mesh mesh;

		private Point[] points;

		private List<VoronoiRegion> regions;

		private List<Point> segPoints;

		private int segIndex;

		private Dictionary<int, Segment> subsegMap;

		private bool includeBoundary = true;

		public Point[] Points => points;

		public ICollection<VoronoiRegion> Regions => regions;

		public BoundedVoronoi(Mesh mesh)
			: this(mesh, includeBoundary: true)
		{
		}

		public BoundedVoronoi(Mesh mesh, bool includeBoundary)
		{
			this.mesh = mesh;
			this.includeBoundary = includeBoundary;
			Generate();
		}

		private void Generate()
		{
			mesh.Renumber();
			mesh.MakeVertexMap();
			regions = new List<VoronoiRegion>(mesh.vertices.Count);
			points = new Point[mesh.triangles.Count];
			segPoints = new List<Point>(mesh.subsegs.Count * 4);
			ComputeCircumCenters();
			TagBlindTriangles();
			foreach (Vertex value in mesh.vertices.Values)
			{
				if (value.type == VertexType.FreeVertex || value.Boundary == 0)
				{
					ConstructCell(value);
				}
				else if (includeBoundary)
				{
					ConstructBoundaryCell(value);
				}
			}
			int num = points.Length;
			Array.Resize(ref points, num + segPoints.Count);
			for (int i = 0; i < segPoints.Count; i++)
			{
				points[num + i] = segPoints[i];
			}
			segPoints.Clear();
			segPoints = null;
		}

		private void ComputeCircumCenters()
		{
			Otri otri = default(Otri);
			double xi = 0.0;
			double eta = 0.0;
			foreach (Triangle value in mesh.triangles.Values)
			{
				Triangle triangle = (otri.triangle = value);
				Point point = Primitives.FindCircumcenter(otri.Org(), otri.Dest(), otri.Apex(), ref xi, ref eta);
				point.id = triangle.id;
				points[triangle.id] = point;
			}
		}

		private void TagBlindTriangles()
		{
			int num = 0;
			subsegMap = new Dictionary<int, Segment>();
			Otri ot = default(Otri);
			Otri o = default(Otri);
			Osub seg = default(Osub);
			Osub os = default(Osub);
			foreach (Triangle value in mesh.triangles.Values)
			{
				value.infected = false;
			}
			foreach (Segment value2 in mesh.subsegs.Values)
			{
				Stack<Triangle> stack = new Stack<Triangle>();
				seg.seg = value2;
				seg.orient = 0;
				seg.TriPivot(ref ot);
				if (ot.triangle != Mesh.dummytri && !ot.triangle.infected)
				{
					stack.Push(ot.triangle);
				}
				seg.SymSelf();
				seg.TriPivot(ref ot);
				if (ot.triangle != Mesh.dummytri && !ot.triangle.infected)
				{
					stack.Push(ot.triangle);
				}
				while (stack.Count > 0)
				{
					ot.triangle = stack.Pop();
					ot.orient = 0;
					if (!TriangleIsBlinded(ref ot, ref seg))
					{
						continue;
					}
					ot.triangle.infected = true;
					num++;
					subsegMap.Add(ot.triangle.hash, seg.seg);
					ot.orient = 0;
					while (ot.orient < 3)
					{
						ot.Sym(ref o);
						o.SegPivot(ref os);
						if (o.triangle != Mesh.dummytri && !o.triangle.infected && os.seg == Mesh.dummysub)
						{
							stack.Push(o.triangle);
						}
						ot.orient++;
					}
				}
			}
			num = 0;
		}

		private bool TriangleIsBlinded(ref Otri tri, ref Osub seg)
		{
			Vertex p = tri.Org();
			Vertex p2 = tri.Dest();
			Vertex p3 = tri.Apex();
			Vertex p4 = seg.Org();
			Vertex p5 = seg.Dest();
			Point p6 = points[tri.triangle.id];
			if (SegmentsIntersect(p4, p5, p6, p, out var p7, strictIntersect: true))
			{
				return true;
			}
			if (SegmentsIntersect(p4, p5, p6, p2, out p7, strictIntersect: true))
			{
				return true;
			}
			if (SegmentsIntersect(p4, p5, p6, p3, out p7, strictIntersect: true))
			{
				return true;
			}
			return false;
		}

		private void ConstructCell(Vertex vertex)
		{
			VoronoiRegion voronoiRegion = new VoronoiRegion(vertex);
			regions.Add(voronoiRegion);
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Osub osub = default(Osub);
			Osub o4 = default(Osub);
			int count = mesh.triangles.Count;
			List<Point> list = new List<Point>();
			vertex.tri.Copy(ref o2);
			if (o2.Org() != vertex)
			{
				throw new Exception("ConstructBvdCell: inconsistent topology.");
			}
			o2.Copy(ref o);
			o2.Onext(ref o3);
			do
			{
				Point point = points[o.triangle.id];
				Point p = points[o3.triangle.id];
				Point p2;
				if (!o.triangle.infected)
				{
					list.Add(point);
					if (o3.triangle.infected)
					{
						o4.seg = subsegMap[o3.triangle.hash];
						if (SegmentsIntersect(o4.SegOrg(), o4.SegDest(), point, p, out p2, strictIntersect: true))
						{
							p2.id = count + segIndex++;
							segPoints.Add(p2);
							list.Add(p2);
						}
					}
				}
				else
				{
					osub.seg = subsegMap[o.triangle.hash];
					if (!o3.triangle.infected)
					{
						if (SegmentsIntersect(osub.SegOrg(), osub.SegDest(), point, p, out p2, strictIntersect: true))
						{
							p2.id = count + segIndex++;
							segPoints.Add(p2);
							list.Add(p2);
						}
					}
					else
					{
						o4.seg = subsegMap[o3.triangle.hash];
						if (!osub.Equal(o4))
						{
							if (SegmentsIntersect(osub.SegOrg(), osub.SegDest(), point, p, out p2, strictIntersect: true))
							{
								p2.id = count + segIndex++;
								segPoints.Add(p2);
								list.Add(p2);
							}
							if (SegmentsIntersect(o4.SegOrg(), o4.SegDest(), point, p, out p2, strictIntersect: true))
							{
								p2.id = count + segIndex++;
								segPoints.Add(p2);
								list.Add(p2);
							}
						}
					}
				}
				o3.Copy(ref o);
				o3.OnextSelf();
			}
			while (!o.Equal(o2));
			voronoiRegion.Add(list);
		}

		private void ConstructBoundaryCell(Vertex vertex)
		{
			VoronoiRegion voronoiRegion = new VoronoiRegion(vertex);
			regions.Add(voronoiRegion);
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Otri o4 = default(Otri);
			Osub osub = default(Osub);
			Osub o5 = default(Osub);
			int count = mesh.triangles.Count;
			List<Point> list = new List<Point>();
			vertex.tri.Copy(ref o2);
			if (o2.Org() != vertex)
			{
				throw new Exception("ConstructBoundaryBvdCell: inconsistent topology.");
			}
			o2.Copy(ref o);
			o2.Onext(ref o3);
			o2.Oprev(ref o4);
			if (o4.triangle != Mesh.dummytri)
			{
				while (o4.triangle != Mesh.dummytri && !o4.Equal(o2))
				{
					o4.Copy(ref o);
					o4.OprevSelf();
				}
				o.Copy(ref o2);
				o.Onext(ref o3);
			}
			Point point;
			if (o4.triangle == Mesh.dummytri)
			{
				point = new Point(vertex.x, vertex.y);
				point.id = count + segIndex++;
				segPoints.Add(point);
				list.Add(point);
			}
			Vertex vertex2 = o.Org();
			Vertex vertex3 = o.Dest();
			point = new Point((vertex2.X + vertex3.X) / 2.0, (vertex2.Y + vertex3.Y) / 2.0);
			point.id = count + segIndex++;
			segPoints.Add(point);
			list.Add(point);
			do
			{
				Point point2 = points[o.triangle.id];
				if (o3.triangle == Mesh.dummytri)
				{
					if (!o.triangle.infected)
					{
						list.Add(point2);
					}
					vertex2 = o.Org();
					Vertex vertex4 = o.Apex();
					point = new Point((vertex2.X + vertex4.X) / 2.0, (vertex2.Y + vertex4.Y) / 2.0);
					point.id = count + segIndex++;
					segPoints.Add(point);
					list.Add(point);
					break;
				}
				Point p = points[o3.triangle.id];
				if (!o.triangle.infected)
				{
					list.Add(point2);
					if (o3.triangle.infected)
					{
						o5.seg = subsegMap[o3.triangle.hash];
						if (SegmentsIntersect(o5.SegOrg(), o5.SegDest(), point2, p, out point, strictIntersect: true))
						{
							point.id = count + segIndex++;
							segPoints.Add(point);
							list.Add(point);
						}
					}
				}
				else
				{
					osub.seg = subsegMap[o.triangle.hash];
					Vertex p2 = osub.SegOrg();
					Vertex p3 = osub.SegDest();
					if (!o3.triangle.infected)
					{
						vertex3 = o.Dest();
						Vertex vertex4 = o.Apex();
						Point p4 = new Point((vertex3.X + vertex4.X) / 2.0, (vertex3.Y + vertex4.Y) / 2.0);
						if (SegmentsIntersect(p2, p3, p4, point2, out point, strictIntersect: false))
						{
							point.id = count + segIndex++;
							segPoints.Add(point);
							list.Add(point);
						}
						if (SegmentsIntersect(p2, p3, point2, p, out point, strictIntersect: true))
						{
							point.id = count + segIndex++;
							segPoints.Add(point);
							list.Add(point);
						}
					}
					else
					{
						o5.seg = subsegMap[o3.triangle.hash];
						if (!osub.Equal(o5))
						{
							if (SegmentsIntersect(p2, p3, point2, p, out point, strictIntersect: true))
							{
								point.id = count + segIndex++;
								segPoints.Add(point);
								list.Add(point);
							}
							if (SegmentsIntersect(o5.SegOrg(), o5.SegDest(), point2, p, out point, strictIntersect: true))
							{
								point.id = count + segIndex++;
								segPoints.Add(point);
								list.Add(point);
							}
						}
						else
						{
							Point p5 = new Point((vertex2.X + vertex3.X) / 2.0, (vertex2.Y + vertex3.Y) / 2.0);
							if (SegmentsIntersect(p2, p3, p5, p, out point, strictIntersect: false))
							{
								point.id = count + segIndex++;
								segPoints.Add(point);
								list.Add(point);
							}
						}
					}
				}
				o3.Copy(ref o);
				o3.OnextSelf();
			}
			while (!o.Equal(o2));
			voronoiRegion.Add(list);
		}

		private bool SegmentsIntersect(Point p1, Point p2, Point p3, Point p4, out Point p, bool strictIntersect)
		{
			p = null;
			double x = p1.X;
			double y = p1.Y;
			double x2 = p2.X;
			double y2 = p2.Y;
			double x3 = p3.X;
			double y3 = p3.Y;
			double x4 = p4.X;
			double y4 = p4.Y;
			if ((x == x2 && y == y2) || (x3 == x4 && y3 == y4))
			{
				return false;
			}
			if ((x == x3 && y == y3) || (x2 == x3 && y2 == y3) || (x == x4 && y == y4) || (x2 == x4 && y2 == y4))
			{
				return false;
			}
			x2 -= x;
			y2 -= y;
			x3 -= x;
			y3 -= y;
			x4 -= x;
			y4 -= y;
			double num = Math.Sqrt(x2 * x2 + y2 * y2);
			double num2 = x2 / num;
			double num3 = y2 / num;
			double num4 = x3 * num2 + y3 * num3;
			y3 = y3 * num2 - x3 * num3;
			x3 = num4;
			double num5 = x4 * num2 + y4 * num3;
			y4 = y4 * num2 - x4 * num3;
			x4 = num5;
			if ((y3 < 0.0 && y4 < 0.0) || (y3 >= 0.0 && y4 >= 0.0 && strictIntersect))
			{
				return false;
			}
			double num6 = x4 + (x3 - x4) * y4 / (y4 - y3);
			if (num6 < 0.0 || (num6 > num && strictIntersect))
			{
				return false;
			}
			p = new Point(x + num6 * num2, y + num6 * num3);
			return true;
		}
	}
	public class CuthillMcKee
	{
		private int node_num;

		private AdjacencyMatrix matrix;

		public int[] Renumber(Mesh mesh)
		{
			node_num = mesh.vertices.Count;
			mesh.Renumber(NodeNumbering.Linear);
			matrix = new AdjacencyMatrix(mesh);
			int num = matrix.Bandwidth();
			int[] perm = GenerateRcm();
			int[] array = PermInverse(node_num, perm);
			int num2 = PermBandwidth(perm, array);
			if (Behavior.Verbose)
			{
				SimpleLog.Instance.Info($"Reverse Cuthill-McKee (Bandwidth: {num} > {num2})");
			}
			return array;
		}

		private int PermBandwidth(int[] perm, int[] perm_inv)
		{
			int[] adjacencyRow = matrix.AdjacencyRow;
			int[] adjacency = matrix.Adjacency;
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < node_num; i++)
			{
				for (int j = adjacencyRow[perm[i]]; j <= adjacencyRow[perm[i] + 1] - 1; j++)
				{
					int num3 = perm_inv[adjacency[j - 1]];
					num = Math.Max(num, i - num3);
					num2 = Math.Max(num2, num3 - i);
				}
			}
			return num + 1 + num2;
		}

		private int[] GenerateRcm()
		{
			int[] array = new int[node_num];
			int iccsze = 0;
			int level_num = 0;
			int[] level_row = new int[node_num + 1];
			int[] array2 = new int[node_num];
			for (int i = 0; i < node_num; i++)
			{
				array2[i] = 1;
			}
			int num = 1;
			for (int i = 0; i < node_num; i++)
			{
				if (array2[i] != 0)
				{
					int root = i;
					FindRoot(ref root, array2, ref level_num, level_row, array, num - 1);
					Rcm(root, array2, array, num - 1, ref iccsze);
					num += iccsze;
					if (node_num < num)
					{
						return array;
					}
				}
			}
			return array;
		}

		private void Rcm(int root, int[] mask, int[] perm, int offset, ref int iccsze)
		{
			int[] adjacencyRow = matrix.AdjacencyRow;
			int[] adjacency = matrix.Adjacency;
			int[] array = new int[node_num];
			Degree(root, mask, array, ref iccsze, perm, offset);
			mask[root] = 0;
			if (iccsze <= 1)
			{
				return;
			}
			int num = 0;
			int num2 = 1;
			while (num < num2)
			{
				int num3 = num + 1;
				num = num2;
				for (int i = num3; i <= num; i++)
				{
					int num4 = perm[offset + i - 1];
					int num5 = adjacencyRow[num4];
					int num6 = adjacencyRow[num4 + 1] - 1;
					int num7 = num2 + 1;
					for (int j = num5; j <= num6; j++)
					{
						int num8 = adjacency[j - 1];
						if (mask[num8] != 0)
						{
							num2++;
							mask[num8] = 0;
							perm[offset + num2 - 1] = num8;
						}
					}
					if (num2 <= num7)
					{
						continue;
					}
					int num9 = num7;
					while (num9 < num2)
					{
						int num10 = num9;
						num9++;
						int num8 = perm[offset + num9 - 1];
						while (num7 < num10)
						{
							int num11 = perm[offset + num10 - 1];
							if (array[num11 - 1] <= array[num8 - 1])
							{
								break;
							}
							perm[offset + num10] = num11;
							num10--;
						}
						perm[offset + num10] = num8;
					}
				}
			}
			ReverseVector(perm, offset, iccsze);
		}

		private void FindRoot(ref int root, int[] mask, ref int level_num, int[] level_row, int[] level, int offset)
		{
			int[] adjacencyRow = matrix.AdjacencyRow;
			int[] adjacency = matrix.Adjacency;
			int level_num2 = 0;
			GetLevelSet(ref root, mask, ref level_num, level_row, level, offset);
			int num = level_row[level_num] - 1;
			if (level_num == 1 || level_num == num)
			{
				return;
			}
			do
			{
				int num2 = num;
				int num3 = level_row[level_num - 1];
				root = level[offset + num3 - 1];
				if (num3 < num)
				{
					for (int i = num3; i <= num; i++)
					{
						int num4 = level[offset + i - 1];
						int num5 = 0;
						int num6 = adjacencyRow[num4 - 1];
						int num7 = adjacencyRow[num4] - 1;
						for (int j = num6; j <= num7; j++)
						{
							int num8 = adjacency[j - 1];
							if (mask[num8] > 0)
							{
								num5++;
							}
						}
						if (num5 < num2)
						{
							root = num4;
							num2 = num5;
						}
					}
				}
				GetLevelSet(ref root, mask, ref level_num2, level_row, level, offset);
				if (level_num2 > level_num)
				{
					level_num = level_num2;
					continue;
				}
				break;
			}
			while (num > level_num);
		}

		private void GetLevelSet(ref int root, int[] mask, ref int level_num, int[] level_row, int[] level, int offset)
		{
			int[] adjacencyRow = matrix.AdjacencyRow;
			int[] adjacency = matrix.Adjacency;
			mask[root] = 0;
			level[offset] = root;
			level_num = 0;
			int num = 0;
			int num2 = 1;
			do
			{
				int num3 = num + 1;
				num = num2;
				level_num++;
				level_row[level_num - 1] = num3;
				for (int i = num3; i <= num; i++)
				{
					int num4 = level[offset + i - 1];
					int num5 = adjacencyRow[num4];
					int num6 = adjacencyRow[num4 + 1] - 1;
					for (int j = num5; j <= num6; j++)
					{
						int num7 = adjacency[j - 1];
						if (mask[num7] != 0)
						{
							num2++;
							level[offset + num2 - 1] = num7;
							mask[num7] = 0;
						}
					}
				}
			}
			while (num2 - num > 0);
			level_row[level_num] = num + 1;
			for (int i = 0; i < num2; i++)
			{
				mask[level[offset + i]] = 1;
			}
		}

		private void Degree(int root, int[] mask, int[] deg, ref int iccsze, int[] ls, int offset)
		{
			int[] adjacencyRow = matrix.AdjacencyRow;
			int[] adjacency = matrix.Adjacency;
			int num = 1;
			ls[offset] = root;
			adjacencyRow[root] = -adjacencyRow[root];
			int num2 = 0;
			iccsze = 1;
			while (num > 0)
			{
				int num3 = num2 + 1;
				num2 = iccsze;
				for (int i = num3; i <= num2; i++)
				{
					int num4 = ls[offset + i - 1];
					int num5 = -adjacencyRow[num4];
					int num6 = Math.Abs(adjacencyRow[num4 + 1]) - 1;
					int num7 = 0;
					for (int j = num5; j <= num6; j++)
					{
						int num8 = adjacency[j - 1];
						if (mask[num8] != 0)
						{
							num7++;
							if (0 <= adjacencyRow[num8])
							{
								adjacencyRow[num8] = -adjacencyRow[num8];
								iccsze++;
								ls[offset + iccsze - 1] = num8;
							}
						}
					}
					deg[num4] = num7;
				}
				num = iccsze - num2;
			}
			for (int i = 0; i < iccsze; i++)
			{
				int num4 = ls[offset + i];
				adjacencyRow[num4] = -adjacencyRow[num4];
			}
		}

		private int[] PermInverse(int n, int[] perm)
		{
			int[] array = new int[node_num];
			for (int i = 0; i < n; i++)
			{
				array[perm[i]] = i;
			}
			return array;
		}

		private void ReverseVector(int[] a, int offset, int size)
		{
			for (int i = 0; i < size / 2; i++)
			{
				int num = a[offset + i];
				a[offset + i] = a[offset + size - 1 - i];
				a[offset + size - 1 - i] = num;
			}
		}
	}
	public interface IVoronoi
	{
		Point[] Points { get; }

		ICollection<VoronoiRegion> Regions { get; }
	}
	public class QuadTree
	{
		private QuadNode root;

		internal ITriangle[] triangles;

		internal int sizeBound;

		internal int maxDepth;

		public QuadTree(Mesh mesh, int maxDepth, int sizeBound)
		{
			this.maxDepth = maxDepth;
			this.sizeBound = sizeBound;
			triangles = mesh.Triangles.ToArray();
			int num = 0;
			root = new QuadNode(mesh.Bounds, this, init: true);
			root.CreateSubRegion(++num);
		}

		public QuadTree(Mesh mesh)
			: this(mesh, 10, 10)
		{
		}

		public ITriangle Query(double x, double y)
		{
			Point point = new Point(x, y);
			List<int> list = root.FindTriangles(point);
			List<ITriangle> list2 = new List<ITriangle>();
			foreach (int item in list)
			{
				ITriangle triangle = triangles[item];
				if (IsPointInTriangle(point, triangle.GetVertex(0), triangle.GetVertex(1), triangle.GetVertex(2)))
				{
					list2.Add(triangle);
					break;
				}
			}
			return list2.FirstOrDefault();
		}

		internal static bool IsPointInTriangle(Point p, Point t0, Point t1, Point t2)
		{
			Point point = new Point(t1.X - t0.X, t1.Y - t0.Y);
			Point point2 = new Point(t2.X - t0.X, t2.Y - t0.Y);
			Point p2 = new Point(p.X - t0.X, p.Y - t0.Y);
			Point q = new Point(0.0 - point.Y, point.X);
			Point q2 = new Point(0.0 - point2.Y, point2.X);
			double num = DotProduct(p2, q2) / DotProduct(point, q2);
			double num2 = DotProduct(p2, q) / DotProduct(point2, q);
			if (num >= 0.0 && num2 >= 0.0 && num + num2 <= 1.0)
			{
				return true;
			}
			return false;
		}

		internal static double DotProduct(Point p, Point q)
		{
			return p.X * q.X + p.Y * q.Y;
		}
	}
	internal class QuadNode
	{
		private const int SW = 0;

		private const int SE = 1;

		private const int NW = 2;

		private const int NE = 3;

		private const double EPS = 1E-06;

		private static readonly byte[] BITVECTOR = new byte[4] { 1, 2, 4, 8 };

		private BoundingBox bounds;

		private Point pivot;

		private QuadTree tree;

		private QuadNode[] regions;

		private List<int> triangles;

		private byte bitRegions;

		public QuadNode(BoundingBox box, QuadTree tree)
			: this(box, tree, init: false)
		{
		}

		public QuadNode(BoundingBox box, QuadTree tree, bool init)
		{
			this.tree = tree;
			bounds = new BoundingBox(box.MinX, box.MinY, box.MaxX, box.MaxY);
			pivot = new Point((box.MinX + box.MaxX) / 2.0, (box.MinY + box.MaxY) / 2.0);
			bitRegions = 0;
			regions = new QuadNode[4];
			triangles = new List<int>();
			if (init)
			{
				int num = tree.triangles.Length;
				triangles.Capacity = num;
				for (int i = 0; i < num; i++)
				{
					triangles.Add(i);
				}
			}
		}

		public List<int> FindTriangles(Point searchPoint)
		{
			int num = FindRegion(searchPoint);
			if (regions[num] == null)
			{
				return triangles;
			}
			return regions[num].FindTriangles(searchPoint);
		}

		public void CreateSubRegion(int currentDepth)
		{
			BoundingBox box = new BoundingBox(bounds.MinX, bounds.MinY, pivot.X, pivot.Y);
			regions[0] = new QuadNode(box, tree);
			box = new BoundingBox(pivot.X, bounds.MinY, bounds.MaxX, pivot.Y);
			regions[1] = new QuadNode(box, tree);
			box = new BoundingBox(bounds.MinX, pivot.Y, pivot.X, bounds.MaxY);
			regions[2] = new QuadNode(box, tree);
			box = new BoundingBox(pivot.X, pivot.Y, bounds.MaxX, bounds.MaxY);
			regions[3] = new QuadNode(box, tree);
			Point[] array = new Point[3];
			foreach (int triangle2 in triangles)
			{
				ITriangle triangle = tree.triangles[triangle2];
				array[0] = triangle.GetVertex(0);
				array[1] = triangle.GetVertex(1);
				array[2] = triangle.GetVertex(2);
				AddTriangleToRegion(array, triangle2);
			}
			for (int i = 0; i < 4; i++)
			{
				if (regions[i].triangles.Count > tree.sizeBound && currentDepth < tree.maxDepth)
				{
					regions[i].CreateSubRegion(currentDepth + 1);
				}
			}
		}

		private void AddTriangleToRegion(Point[] triangle, int index)
		{
			bitRegions = 0;
			if (QuadTree.IsPointInTriangle(pivot, triangle[0], triangle[1], triangle[2]))
			{
				AddToRegion(index, 0);
				AddToRegion(index, 1);
				AddToRegion(index, 2);
				AddToRegion(index, 3);
				return;
			}
			FindTriangleIntersections(triangle, index);
			if (bitRegions == 0)
			{
				int num = FindRegion(triangle[0]);
				regions[num].triangles.Add(index);
			}
		}

		private void FindTriangleIntersections(Point[] triangle, int index)
		{
			int num = 2;
			int num2 = 0;
			while (num2 < 3)
			{
				double num3 = triangle[num2].X - triangle[num].X;
				double num4 = triangle[num2].Y - triangle[num].Y;
				if (num3 != 0.0)
				{
					FindIntersectionsWithX(num3, num4, triangle, index, num);
				}
				if (num4 != 0.0)
				{
					FindIntersectionsWithY(num3, num4, triangle, index, num);
				}
				num = num2++;
			}
		}

		private void FindIntersectionsWithX(double dx, double dy, Point[] triangle, int index, int k)
		{
			double num = (pivot.X - triangle[k].X) / dx;
			if (num < 1.000001 && num > -1E-06)
			{
				double num2 = triangle[k].Y + num * dy;
				if (num2 < pivot.Y && num2 >= bounds.MinY)
				{
					AddToRegion(index, 0);
					AddToRegion(index, 1);
				}
				else if (num2 <= bounds.MaxY)
				{
					AddToRegion(index, 2);
					AddToRegion(index, 3);
				}
			}
			num = (bounds.MinX - triangle[k].X) / dx;
			if (num < 1.000001 && num > -1E-06)
			{
				double num3 = triangle[k].Y + num * dy;
				if (num3 < pivot.Y && num3 >= bounds.MinY)
				{
					AddToRegion(index, 0);
				}
				else if (num3 <= bounds.MaxY)
				{
					AddToRegion(index, 2);
				}
			}
			num = (bounds.MaxX - triangle[k].X) / dx;
			if (num < 1.000001 && num > -1E-06)
			{
				double num4 = triangle[k].Y + num * dy;
				if (num4 < pivot.Y && num4 >= bounds.MinY)
				{
					AddToRegion(index, 1);
				}
				else if (num4 <= bounds.MaxY)
				{
					AddToRegion(index, 3);
				}
			}
		}

		private void FindIntersectionsWithY(double dx, double dy, Point[] triangle, int index, int k)
		{
			double num = (pivot.Y - triangle[k].Y) / dy;
			if (num < 1.000001 && num > -1E-06)
			{
				double num2 = triangle[k].X + num * dx;
				if (num2 > pivot.X && num2 <= bounds.MaxX)
				{
					AddToRegion(index, 1);
					AddToRegion(index, 3);
				}
				else if (num2 >= bounds.MinX)
				{
					AddToRegion(index, 0);
					AddToRegion(index, 2);
				}
			}
			num = (bounds.MinY - triangle[k].Y) / dy;
			if (num < 1.000001 && num > -1E-06)
			{
				double num2 = triangle[k].X + num * dx;
				if (num2 > pivot.X && num2 <= bounds.MaxX)
				{
					AddToRegion(index, 1);
				}
				else if (num2 >= bounds.MinX)
				{
					AddToRegion(index, 0);
				}
			}
			num = (bounds.MaxY - triangle[k].Y) / dy;
			if (num < 1.000001 && num > -1E-06)
			{
				double num2 = triangle[k].X + num * dx;
				if (num2 > pivot.X && num2 <= bounds.MaxX)
				{
					AddToRegion(index, 3);
				}
				else if (num2 >= bounds.MinX)
				{
					AddToRegion(index, 2);
				}
			}
		}

		private int FindRegion(Point point)
		{
			int num = 2;
			if (point.Y < pivot.Y)
			{
				num = 0;
			}
			if (point.X > pivot.X)
			{
				num++;
			}
			return num;
		}

		private void AddToRegion(int index, int region)
		{
			if ((bitRegions & BITVECTOR[region]) == 0)
			{
				regions[region].triangles.Add(index);
				bitRegions |= BITVECTOR[region];
			}
		}
	}
	public class QualityMeasure
	{
		private class AreaMeasure
		{
			public double area_min = double.MaxValue;

			public double area_max = double.MinValue;

			public double area_total;

			public int area_zero;

			public void Reset()
			{
				area_min = double.MaxValue;
				area_max = double.MinValue;
				area_total = 0.0;
				area_zero = 0;
			}

			public double Measure(Point a, Point b, Point c)
			{
				double num = 0.5 * Math.Abs(a.x * (b.y - c.y) + b.x * (c.y - a.y) + c.x * (a.y - b.y));
				area_min = Math.Min(area_min, num);
				area_max = Math.Max(area_max, num);
				area_total += num;
				if (num == 0.0)
				{
					area_zero++;
				}
				return num;
			}
		}

		private class AlphaMeasure
		{
			public double alpha_min;

			public double alpha_max;

			public double alpha_ave;

			public double alpha_area;

			public void Reset()
			{
				alpha_min = double.MaxValue;
				alpha_max = double.MinValue;
				alpha_ave = 0.0;
				alpha_area = 0.0;
			}

			private double acos(double c)
			{
				if (c <= -1.0)
				{
					return Math.PI;
				}
				if (1.0 <= c)
				{
					return 0.0;
				}
				return Math.Acos(c);
			}

			public double Measure(double ab, double bc, double ca, double area)
			{
				double val = double.MaxValue;
				double num = ab * ab;
				double num2 = bc * bc;
				double num3 = ca * ca;
				double val2;
				double val3;
				double val4;
				if (ab != 0.0 || bc != 0.0 || ca != 0.0)
				{
					val2 = ((ca != 0.0 && ab != 0.0) ? acos((num3 + num - num2) / (2.0 * ca * ab)) : Math.PI);
					val3 = ((ab != 0.0 && bc != 0.0) ? acos((num + num2 - num3) / (2.0 * ab * bc)) : Math.PI);
					val4 = ((bc != 0.0 && ca != 0.0) ? acos((num2 + num3 - num) / (2.0 * bc * ca)) : Math.PI);
				}
				else
				{
					val2 = Math.PI * 2.0 / 3.0;
					val3 = Math.PI * 2.0 / 3.0;
					val4 = Math.PI * 2.0 / 3.0;
				}
				val = Math.Min(val, val2);
				val = Math.Min(val, val3);
				val = Math.Min(val, val4);
				val = val * 3.0 / Math.PI;
				alpha_ave += val;
				alpha_area += area * val;
				alpha_min = Math.Min(val, alpha_min);
				alpha_max = Math.Max(val, alpha_max);
				return val;
			}

			public void Normalize(int n, double area_total)
			{
				if (n > 0)
				{
					alpha_ave /= n;
				}
				else
				{
					alpha_ave = 0.0;
				}
				if (0.0 < area_total)
				{
					alpha_area /= area_total;
				}
				else
				{
					alpha_area = 0.0;
				}
			}
		}

		private class Q_Measure
		{
			public double q_min;

			public double q_max;

			public double q_ave;

			public double q_area;

			public void Reset()
			{
				q_min = double.MaxValue;
				q_max = double.MinValue;
				q_ave = 0.0;
				q_area = 0.0;
			}

			public double Measure(double ab, double bc, double ca, double area)
			{
				double num = (bc + ca - ab) * (ca + ab - bc) * (ab + bc - ca) / (ab * bc * ca);
				q_min = Math.Min(q_min, num);
				q_max = Math.Max(q_max, num);
				q_ave += num;
				q_area += num * area;
				return num;
			}

			public void Normalize(int n, double area_total)
			{
				if (n > 0)
				{
					q_ave /= n;
				}
				else
				{
					q_ave = 0.0;
				}
				if (area_total > 0.0)
				{
					q_area /= area_total;
				}
				else
				{
					q_area = 0.0;
				}
			}
		}

		private AreaMeasure areaMeasure;

		private AlphaMeasure alphaMeasure;

		private Q_Measure qMeasure;

		private Mesh mesh;

		public double AreaMinimum => areaMeasure.area_min;

		public double AreaMaximum => areaMeasure.area_max;

		public double AreaRatio => areaMeasure.area_max / areaMeasure.area_min;

		public double AlphaMinimum => alphaMeasure.alpha_min;

		public double AlphaMaximum => alphaMeasure.alpha_max;

		public double AlphaAverage => alphaMeasure.alpha_ave;

		public double AlphaArea => alphaMeasure.alpha_area;

		public double Q_Minimum => qMeasure.q_min;

		public double Q_Maximum => qMeasure.q_max;

		public double Q_Average => qMeasure.q_ave;

		public double Q_Area => qMeasure.q_area;

		public QualityMeasure()
		{
			areaMeasure = new AreaMeasure();
			alphaMeasure = new AlphaMeasure();
			qMeasure = new Q_Measure();
		}

		public void Update(Mesh mesh)
		{
			this.mesh = mesh;
			areaMeasure.Reset();
			alphaMeasure.Reset();
			qMeasure.Reset();
			Compute();
		}

		private void Compute()
		{
			int num = 0;
			foreach (Triangle value in mesh.triangles.Values)
			{
				num++;
				Point point = value.vertices[0];
				Point point2 = value.vertices[1];
				Point point3 = value.vertices[2];
				double num2 = point.x - point2.x;
				double num3 = point.y - point2.y;
				double ab = Math.Sqrt(num2 * num2 + num3 * num3);
				double num4 = point2.x - point3.x;
				num3 = point2.y - point3.y;
				double bc = Math.Sqrt(num4 * num4 + num3 * num3);
				double num5 = point3.x - point.x;
				num3 = point3.y - point.y;
				double ca = Math.Sqrt(num5 * num5 + num3 * num3);
				double area = areaMeasure.Measure(point, point2, point3);
				alphaMeasure.Measure(ab, bc, ca, area);
				qMeasure.Measure(ab, bc, ca, area);
			}
			alphaMeasure.Normalize(num, areaMeasure.area_total);
			qMeasure.Normalize(num, areaMeasure.area_total);
		}

		public int Bandwidth()
		{
			if (mesh == null)
			{
				return 0;
			}
			int num = 0;
			int num2 = 0;
			foreach (Triangle value in mesh.triangles.Values)
			{
				for (int i = 0; i < 3; i++)
				{
					int id = value.GetVertex(i).id;
					for (int j = 0; j < 3; j++)
					{
						int id2 = value.GetVertex(j).id;
						num2 = Math.Max(num2, id2 - id);
						num = Math.Max(num, id - id2);
					}
				}
			}
			return num + 1 + num2;
		}
	}
	public class RegionIterator
	{
		private Mesh mesh;

		private List<Triangle> viri;

		public RegionIterator(Mesh mesh)
		{
			this.mesh = mesh;
			viri = new List<Triangle>();
		}

		private void ProcessRegion(Action<Triangle> func)
		{
			Otri otri = default(Otri);
			Otri o = default(Otri);
			Osub os = default(Osub);
			_ = mesh.behavior;
			for (int i = 0; i < viri.Count; i++)
			{
				otri.triangle = viri[i];
				otri.Uninfect();
				func(otri.triangle);
				otri.orient = 0;
				while (otri.orient < 3)
				{
					otri.Sym(ref o);
					otri.SegPivot(ref os);
					if (o.triangle != Mesh.dummytri && !o.IsInfected() && os.seg == Mesh.dummysub)
					{
						o.Infect();
						viri.Add(o.triangle);
					}
					otri.orient++;
				}
				otri.Infect();
			}
			foreach (Triangle virus in viri)
			{
				virus.infected = false;
			}
			viri.Clear();
		}

		public void Process(Triangle triangle)
		{
			Process(triangle, delegate(Triangle tri)
			{
				tri.region = triangle.region;
			});
		}

		public void Process(Triangle triangle, Action<Triangle> func)
		{
			if (triangle != Mesh.dummytri && !Otri.IsDead(triangle))
			{
				triangle.infected = true;
				viri.Add(triangle);
				ProcessRegion(func);
			}
			viri.Clear();
		}
	}
	public class Statistic
	{
		public static long InCircleCount = 0L;

		public static long InCircleAdaptCount = 0L;

		public static long CounterClockwiseCount = 0L;

		public static long CounterClockwiseAdaptCount = 0L;

		public static long Orient3dCount = 0L;

		public static long HyperbolaCount = 0L;

		public static long CircumcenterCount = 0L;

		public static long CircleTopCount = 0L;

		public static long RelocationCount = 0L;

		private double minEdge;

		private double maxEdge;

		private double minAspect;

		private double maxAspect;

		private double minArea;

		private double maxArea;

		private double minAngle;

		private double maxAngle;

		private int inVetrices;

		private int inTriangles;

		private int inSegments;

		private int inHoles;

		private int outVertices;

		private int outTriangles;

		private int outEdges;

		private int boundaryEdges;

		private int intBoundaryEdges;

		private int constrainedEdges;

		private int[] angleTable;

		private int[] minAngles;

		private int[] maxAngles;

		private static readonly int[] plus1Mod3 = new int[3] { 1, 2, 0 };

		private static readonly int[] minus1Mod3 = new int[3] { 2, 0, 1 };

		public double ShortestEdge => minEdge;

		public double LongestEdge => maxEdge;

		public double ShortestAltitude => minAspect;

		public double LargestAspectRatio => maxAspect;

		public double SmallestArea => minArea;

		public double LargestArea => maxArea;

		public double SmallestAngle => minAngle;

		public double LargestAngle => maxAngle;

		public int InputVertices => inVetrices;

		public int InputTriangles => inTriangles;

		public int InputSegments => inSegments;

		public int InputHoles => inHoles;

		public int Vertices => outVertices;

		public int Triangles => outTriangles;

		public int Edges => outEdges;

		public int BoundaryEdges => boundaryEdges;

		public int InteriorBoundaryEdges => intBoundaryEdges;

		public int ConstrainedEdges => constrainedEdges;

		public int[] AngleHistogram => angleTable;

		public int[] MinAngleHistogram => minAngles;

		public int[] MaxAngleHistogram => maxAngles;

		private void GetAspectHistogram(Mesh mesh)
		{
			int[] array = new int[16];
			double[] array2 = new double[16]
			{
				1.5, 2.0, 2.5, 3.0, 4.0, 6.0, 10.0, 15.0, 25.0, 50.0,
				100.0, 300.0, 1000.0, 10000.0, 100000.0, 0.0
			};
			Otri otri = default(Otri);
			Vertex[] array3 = new Vertex[3];
			double[] array4 = new double[3];
			double[] array5 = new double[3];
			double[] array6 = new double[3];
			otri.orient = 0;
			foreach (Triangle value in mesh.triangles.Values)
			{
				otri.triangle = value;
				array3[0] = otri.Org();
				array3[1] = otri.Dest();
				array3[2] = otri.Apex();
				double num = 0.0;
				for (int i = 0; i < 3; i++)
				{
					int num2 = plus1Mod3[i];
					int num3 = minus1Mod3[i];
					array4[i] = array3[num2].x - array3[num3].x;
					array5[i] = array3[num2].y - array3[num3].y;
					array6[i] = array4[i] * array4[i] + array5[i] * array5[i];
					if (array6[i] > num)
					{
						num = array6[i];
					}
				}
				double num4 = Math.Abs((array3[2].x - array3[0].x) * (array3[1].y - array3[0].y) - (array3[1].x - array3[0].x) * (array3[2].y - array3[0].y)) / 2.0;
				double num5 = num4 * num4 / num;
				double num6 = num / num5;
				int j;
				for (j = 0; num6 > array2[j] * array2[j] && j < 15; j++)
				{
				}
				array[j]++;
			}
		}

		public void Update(Mesh mesh, int sampleDegrees)
		{
			inVetrices = mesh.invertices;
			inTriangles = mesh.inelements;
			inSegments = mesh.insegments;
			inHoles = mesh.holes.Count;
			outVertices = mesh.vertices.Count - mesh.undeads;
			outTriangles = mesh.triangles.Count;
			outEdges = mesh.edges;
			boundaryEdges = mesh.hullsize;
			intBoundaryEdges = mesh.subsegs.Count - mesh.hullsize;
			constrainedEdges = mesh.subsegs.Count;
			Point[] array = new Point[3];
			sampleDegrees = 60;
			double[] array2 = new double[sampleDegrees / 2 - 1];
			double[] array3 = new double[3];
			double[] array4 = new double[3];
			double[] array5 = new double[3];
			double num = Math.PI / (double)sampleDegrees;
			double num2 = 180.0 / Math.PI;
			angleTable = new int[sampleDegrees];
			minAngles = new int[sampleDegrees];
			maxAngles = new int[sampleDegrees];
			for (int i = 0; i < sampleDegrees / 2 - 1; i++)
			{
				array2[i] = Math.Cos(num * (double)(i + 1));
				array2[i] *= array2[i];
			}
			for (int j = 0; j < sampleDegrees; j++)
			{
				angleTable[j] = 0;
			}
			minAspect = mesh.bounds.Width + mesh.bounds.Height;
			minAspect *= minAspect;
			maxAspect = 0.0;
			minEdge = minAspect;
			maxEdge = 0.0;
			minArea = minAspect;
			maxArea = 0.0;
			minAngle = 0.0;
			maxAngle = 2.0;
			bool flag = true;
			bool flag2 = true;
			double num3 = 1.0;
			foreach (Triangle value in mesh.triangles.Values)
			{
				double num4 = 0.0;
				num3 = 1.0;
				array[0] = value.vertices[0];
				array[1] = value.vertices[1];
				array[2] = value.vertices[2];
				double num5 = 0.0;
				for (int k = 0; k < 3; k++)
				{
					int num6 = plus1Mod3[k];
					int num7 = minus1Mod3[k];
					array3[k] = array[num6].X - array[num7].X;
					array4[k] = array[num6].Y - array[num7].Y;
					array5[k] = array3[k] * array3[k] + array4[k] * array4[k];
					if (array5[k] > num5)
					{
						num5 = array5[k];
					}
					if (array5[k] > maxEdge)
					{
						maxEdge = array5[k];
					}
					if (array5[k] < minEdge)
					{
						minEdge = array5[k];
					}
				}
				double num8 = Math.Abs((array[2].X - array[0].X) * (array[1].Y - array[0].Y) - (array[1].X - array[0].X) * (array[2].Y - array[0].Y));
				if (num8 < minArea)
				{
					minArea = num8;
				}
				if (num8 > maxArea)
				{
					maxArea = num8;
				}
				double num9 = num8 * num8 / num5;
				if (num9 < minAspect)
				{
					minAspect = num9;
				}
				double num10 = num5 / num9;
				if (num10 > maxAspect)
				{
					maxAspect = num10;
				}
				int num13;
				for (int l = 0; l < 3; l++)
				{
					int num6 = plus1Mod3[l];
					int num7 = minus1Mod3[l];
					double num11 = array3[num6] * array3[num7] + array4[num6] * array4[num7];
					double num12 = num11 * num11 / (array5[num6] * array5[num7]);
					num13 = sampleDegrees / 2 - 1;
					for (int num14 = num13 - 1; num14 >= 0; num14--)
					{
						if (num12 > array2[num14])
						{
							num13 = num14;
						}
					}
					if (num11 <= 0.0)
					{
						angleTable[num13]++;
						if (num12 > minAngle)
						{
							minAngle = num12;
						}
						if (flag && num12 < maxAngle)
						{
							maxAngle = num12;
						}
						if (num12 > num4)
						{
							num4 = num12;
						}
						if (flag2 && num12 < num3)
						{
							num3 = num12;
						}
					}
					else
					{
						angleTable[sampleDegrees - num13 - 1]++;
						if (flag || num12 > maxAngle)
						{
							maxAngle = num12;
							flag = false;
						}
						if (flag2 || num12 > num3)
						{
							num3 = num12;
							flag2 = false;
						}
					}
				}
				num13 = sampleDegrees / 2 - 1;
				for (int num15 = num13 - 1; num15 >= 0; num15--)
				{
					if (num4 > array2[num15])
					{
						num13 = num15;
					}
				}
				minAngles[num13]++;
				num13 = sampleDegrees / 2 - 1;
				for (int num16 = num13 - 1; num16 >= 0; num16--)
				{
					if (num3 > array2[num16])
					{
						num13 = num16;
					}
				}
				if (flag2)
				{
					maxAngles[num13]++;
				}
				else
				{
					maxAngles[sampleDegrees - num13 - 1]++;
				}
				flag2 = true;
			}
			minEdge = Math.Sqrt(minEdge);
			maxEdge = Math.Sqrt(maxEdge);
			minAspect = Math.Sqrt(minAspect);
			maxAspect = Math.Sqrt(maxAspect);
			minArea *= 0.5;
			maxArea *= 0.5;
			if (minAngle >= 1.0)
			{
				minAngle = 0.0;
			}
			else
			{
				minAngle = num2 * Math.Acos(Math.Sqrt(minAngle));
			}
			if (maxAngle >= 1.0)
			{
				maxAngle = 180.0;
			}
			else if (flag)
			{
				maxAngle = num2 * Math.Acos(Math.Sqrt(maxAngle));
			}
			else
			{
				maxAngle = 180.0 - num2 * Math.Acos(Math.Sqrt(maxAngle));
			}
		}
	}
	public class Voronoi : IVoronoi
	{
		private Mesh mesh;

		private Point[] points;

		private Dictionary<int, VoronoiRegion> regions;

		private Dictionary<int, Point> rayPoints;

		private int rayIndex;

		private BoundingBox bounds;

		public Point[] Points => points;

		public ICollection<VoronoiRegion> Regions => regions.Values;

		public Voronoi(Mesh mesh)
		{
			this.mesh = mesh;
			Generate();
		}

		private void Generate()
		{
			mesh.Renumber();
			mesh.MakeVertexMap();
			points = new Point[mesh.triangles.Count + mesh.hullsize];
			regions = new Dictionary<int, VoronoiRegion>(mesh.vertices.Count);
			rayPoints = new Dictionary<int, Point>();
			rayIndex = 0;
			bounds = new BoundingBox();
			ComputeCircumCenters();
			foreach (Vertex value in mesh.vertices.Values)
			{
				regions.Add(value.id, new VoronoiRegion(value));
			}
			foreach (VoronoiRegion value2 in regions.Values)
			{
				ConstructVoronoiRegion(value2);
			}
		}

		private void ComputeCircumCenters()
		{
			Otri otri = default(Otri);
			double xi = 0.0;
			double eta = 0.0;
			foreach (Triangle value in mesh.triangles.Values)
			{
				Triangle triangle = (otri.triangle = value);
				Point point = Primitives.FindCircumcenter(otri.Org(), otri.Dest(), otri.Apex(), ref xi, ref eta);
				point.id = triangle.id;
				points[triangle.id] = point;
				bounds.Expand(point.x, point.y);
			}
			double num = Math.Max(bounds.Width, bounds.Height);
			bounds.Resize(num, num);
		}

		private void ConstructVoronoiRegion(VoronoiRegion region)
		{
			Vertex obj = region.Generator as Vertex;
			List<Point> list = new List<Point>();
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Otri o4 = default(Otri);
			Osub os = default(Osub);
			obj.tri.Copy(ref o2);
			o2.Copy(ref o);
			o2.Onext(ref o3);
			if (o3.triangle == Mesh.dummytri)
			{
				o2.Oprev(ref o4);
				if (o4.triangle != Mesh.dummytri)
				{
					o2.Copy(ref o3);
					o2.OprevSelf();
					o2.Copy(ref o);
				}
			}
			while (o3.triangle != Mesh.dummytri)
			{
				list.Add(points[o.triangle.id]);
				region.AddNeighbor(o.triangle.id, regions[o.Apex().id]);
				if (o3.Equal(o2))
				{
					region.Add(list);
					return;
				}
				o3.Copy(ref o);
				o3.OnextSelf();
			}
			region.Bounded = false;
			int count = mesh.triangles.Count;
			o.Lprev(ref o3);
			o3.SegPivot(ref os);
			int hash = os.seg.hash;
			list.Add(points[o.triangle.id]);
			region.AddNeighbor(o.triangle.id, regions[o.Apex().id]);
			if (!rayPoints.TryGetValue(hash, out var value))
			{
				Vertex vertex = o.Org();
				Vertex vertex2 = o.Apex();
				BoxRayIntersection(points[o.triangle.id], vertex.y - vertex2.y, vertex2.x - vertex.x, out value);
				value.id = count + rayIndex;
				points[count + rayIndex] = value;
				rayIndex++;
				rayPoints.Add(hash, value);
			}
			list.Add(value);
			list.Reverse();
			o2.Copy(ref o);
			o.Oprev(ref o4);
			while (o4.triangle != Mesh.dummytri)
			{
				list.Add(points[o4.triangle.id]);
				region.AddNeighbor(o4.triangle.id, regions[o4.Apex().id]);
				o4.Copy(ref o);
				o4.OprevSelf();
			}
			o.SegPivot(ref os);
			hash = os.seg.hash;
			if (!rayPoints.TryGetValue(hash, out value))
			{
				Vertex vertex = o.Org();
				Vertex vertex3 = o.Dest();
				BoxRayIntersection(points[o.triangle.id], vertex3.y - vertex.y, vertex.x - vertex3.x, out value);
				value.id = count + rayIndex;
				rayPoints.Add(hash, value);
				points[count + rayIndex] = value;
				rayIndex++;
			}
			list.Add(value);
			region.AddNeighbor(value.id, regions[o.Dest().id]);
			list.Reverse();
			region.Add(list);
		}

		private bool BoxRayIntersection(Point pt, double dx, double dy, out Point intersect)
		{
			double x = pt.X;
			double y = pt.Y;
			double minX = bounds.MinX;
			double maxX = bounds.MaxX;
			double minY = bounds.MinY;
			double maxY = bounds.MaxY;
			if (x < minX || x > maxX || y < minY || y > maxY)
			{
				intersect = null;
				return false;
			}
			double num;
			double x2;
			double y2;
			if (dx < 0.0)
			{
				num = (minX - x) / dx;
				x2 = minX;
				y2 = y + num * dy;
			}
			else if (dx > 0.0)
			{
				num = (maxX - x) / dx;
				x2 = maxX;
				y2 = y + num * dy;
			}
			else
			{
				num = double.MaxValue;
				x2 = (y2 = 0.0);
			}
			double num2;
			double x3;
			double y3;
			if (dy < 0.0)
			{
				num2 = (minY - y) / dy;
				x3 = x + num2 * dx;
				y3 = minY;
			}
			else if (dy > 0.0)
			{
				num2 = (maxY - y) / dy;
				x3 = x + num2 * dx;
				y3 = maxY;
			}
			else
			{
				num2 = double.MaxValue;
				x3 = (y3 = 0.0);
			}
			if (num < num2)
			{
				intersect = new Point(x2, y2);
			}
			else
			{
				intersect = new Point(x3, y3);
			}
			return true;
		}
	}
	public class VoronoiRegion
	{
		private int id;

		private Point generator;

		private List<Point> vertices;

		private bool bounded;

		private Dictionary<int, VoronoiRegion> neighbors;

		public int ID => id;

		public Point Generator => generator;

		public ICollection<Point> Vertices => vertices;

		public bool Bounded
		{
			get
			{
				return bounded;
			}
			set
			{
				bounded = value;
			}
		}

		public VoronoiRegion(Vertex generator)
		{
			id = generator.id;
			this.generator = generator;
			vertices = new List<Point>();
			bounded = true;
			neighbors = new Dictionary<int, VoronoiRegion>();
		}

		public void Add(Point point)
		{
			vertices.Add(point);
		}

		public void Add(List<Point> points)
		{
			vertices.AddRange(points);
		}

		public VoronoiRegion GetNeighbor(Point p)
		{
			if (neighbors.TryGetValue(p.id, out var value))
			{
				return value;
			}
			return null;
		}

		internal void AddNeighbor(int id, VoronoiRegion neighbor)
		{
			neighbors.Add(id, neighbor);
		}

		public override string ToString()
		{
			return $"R-ID {id}";
		}
	}
}
namespace TriangleNet.Smoothing
{
	public interface ISmoother
	{
		void Smooth();
	}
	public class SimpleSmoother : ISmoother
	{
		private Mesh mesh;

		public SimpleSmoother(Mesh mesh)
		{
			this.mesh = mesh;
		}

		public void Smooth()
		{
			mesh.behavior.Quality = false;
			for (int i = 0; i < 5; i++)
			{
				Step();
				mesh.Triangulate(Rebuild());
			}
		}

		private void Step()
		{
			foreach (VoronoiRegion region in new BoundedVoronoi(mesh, includeBoundary: false).Regions)
			{
				int num = 0;
				double num3;
				double num2 = (num3 = 0.0);
				foreach (Point vertex in region.Vertices)
				{
					num++;
					num2 += vertex.x;
					num3 += vertex.y;
				}
				region.Generator.x = num2 / (double)num;
				region.Generator.y = num3 / (double)num;
			}
		}

		private InputGeometry Rebuild()
		{
			InputGeometry inputGeometry = new InputGeometry(mesh.vertices.Count);
			foreach (Vertex value in mesh.vertices.Values)
			{
				inputGeometry.AddPoint(value.x, value.y, value.mark);
			}
			foreach (Segment value2 in mesh.subsegs.Values)
			{
				inputGeometry.AddSegment(value2.P0, value2.P1, value2.Boundary);
			}
			foreach (Point hole in mesh.holes)
			{
				inputGeometry.AddHole(hole.x, hole.y);
			}
			foreach (RegionPointer region in mesh.regions)
			{
				inputGeometry.AddRegion(region.point.x, region.point.y, region.id);
			}
			return inputGeometry;
		}
	}
}
namespace TriangleNet.Log
{
	public enum LogLevel
	{
		Info,
		Warning,
		Error
	}
	public interface ILog<T> where T : ILogItem
	{
		IList<T> Data { get; }

		LogLevel Level { get; }

		void Add(T item);

		void Clear();

		void Info(string message);

		void Error(string message, string info);

		void Warning(string message, string info);
	}
	public interface ILogItem
	{
		DateTime Time { get; }

		LogLevel Level { get; }

		string Message { get; }

		string Info { get; }
	}
	public sealed class SimpleLog : ILog<SimpleLogItem>
	{
		private List<SimpleLogItem> log = new List<SimpleLogItem>();

		private LogLevel level;

		private static readonly SimpleLog instance;

		public static ILog<SimpleLogItem> Instance => instance;

		public IList<SimpleLogItem> Data => log;

		public LogLevel Level => level;

		static SimpleLog()
		{
			instance = new SimpleLog();
		}

		private SimpleLog()
		{
		}

		public void Add(SimpleLogItem item)
		{
			log.Add(item);
		}

		public void Clear()
		{
			log.Clear();
		}

		public void Info(string message)
		{
			log.Add(new SimpleLogItem(LogLevel.Info, message));
		}

		public void Warning(string message, string location)
		{
			log.Add(new SimpleLogItem(LogLevel.Warning, message, location));
		}

		public void Error(string message, string location)
		{
			log.Add(new SimpleLogItem(LogLevel.Error, message, location));
		}
	}
	public class SimpleLogItem : ILogItem
	{
		private DateTime time;

		private LogLevel level;

		private string message;

		private string info;

		public DateTime Time => time;

		public LogLevel Level => level;

		public string Message => message;

		public string Info => info;

		public SimpleLogItem(LogLevel level, string message)
			: this(level, message, "")
		{
		}

		public SimpleLogItem(LogLevel level, string message, string info)
		{
			time = DateTime.Now;
			this.level = level;
			this.message = message;
			this.info = info;
		}
	}
}
namespace TriangleNet.IO
{
	internal static class DataReader
	{
		public static int Reconstruct(Mesh mesh, InputGeometry input, ITriangle[] triangles)
		{
			int num = 0;
			Otri newotri = default(Otri);
			Otri o = default(Otri);
			Otri otri = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Osub newsubseg = default(Osub);
			int[] array = new int[3];
			int[] array2 = new int[2];
			int num2 = 0;
			int inelements = ((triangles != null) ? triangles.Length : 0);
			int count = input.segments.Count;
			mesh.inelements = inelements;
			mesh.regions.AddRange(input.regions);
			for (num2 = 0; num2 < mesh.inelements; num2++)
			{
				mesh.MakeTriangle(ref newotri);
			}
			if (mesh.behavior.Poly)
			{
				mesh.insegments = count;
				for (num2 = 0; num2 < mesh.insegments; num2++)
				{
					mesh.MakeSegment(ref newsubseg);
				}
			}
			List<Otri>[] array3 = new List<Otri>[mesh.vertices.Count];
			for (num2 = 0; num2 < mesh.vertices.Count; num2++)
			{
				Otri item = new Otri
				{
					triangle = Mesh.dummytri
				};
				array3[num2] = new List<Otri>(3);
				array3[num2].Add(item);
			}
			num2 = 0;
			foreach (Triangle value in mesh.triangles.Values)
			{
				newotri.triangle = value;
				array[0] = triangles[num2].P0;
				array[1] = triangles[num2].P1;
				array[2] = triangles[num2].P2;
				for (int i = 0; i < 3; i++)
				{
					if (array[i] < 0 || array[i] >= mesh.invertices)
					{
						SimpleLog.Instance.Error("Triangle has an invalid vertex index.", "MeshReader.Reconstruct()");
						throw new Exception("Triangle has an invalid vertex index.");
					}
				}
				newotri.triangle.region = triangles[num2].Region;
				if (mesh.behavior.VarArea)
				{
					newotri.triangle.area = triangles[num2].Area;
				}
				newotri.orient = 0;
				newotri.SetOrg(mesh.vertices[array[0]]);
				newotri.SetDest(mesh.vertices[array[1]]);
				newotri.SetApex(mesh.vertices[array[2]]);
				newotri.orient = 0;
				while (newotri.orient < 3)
				{
					int num3 = array[newotri.orient];
					int num4 = array3[num3].Count - 1;
					Otri otri2 = array3[num3][num4];
					array3[num3].Add(newotri);
					otri = otri2;
					if (otri.triangle != Mesh.dummytri)
					{
						Vertex vertex = newotri.Dest();
						Vertex vertex2 = newotri.Apex();
						do
						{
							Vertex vertex3 = otri.Dest();
							Vertex vertex4 = otri.Apex();
							if (vertex2 == vertex3)
							{
								newotri.Lprev(ref o);
								o.Bond(ref otri);
							}
							if (vertex == vertex4)
							{
								otri.Lprev(ref o2);
								newotri.Bond(ref o2);
							}
							num4--;
							otri2 = array3[num3][num4];
							otri = otri2;
						}
						while (otri.triangle != Mesh.dummytri);
					}
					newotri.orient++;
				}
				num2++;
			}
			num = 0;
			if (mesh.behavior.Poly)
			{
				int num5 = 0;
				num2 = 0;
				foreach (Segment value2 in mesh.subsegs.Values)
				{
					newsubseg.seg = value2;
					array2[0] = input.segments[num2].P0;
					array2[1] = input.segments[num2].P1;
					num5 = input.segments[num2].Boundary;
					for (int j = 0; j < 2; j++)
					{
						if (array2[j] < 0 || array2[j] >= mesh.invertices)
						{
							SimpleLog.Instance.Error("Segment has an invalid vertex index.", "MeshReader.Reconstruct()");
							throw new Exception("Segment has an invalid vertex index.");
						}
					}
					newsubseg.orient = 0;
					Vertex vertex5 = mesh.vertices[array2[0]];
					Vertex vertex6 = mesh.vertices[array2[1]];
					newsubseg.SetOrg(vertex5);
					newsubseg.SetDest(vertex6);
					newsubseg.SetSegOrg(vertex5);
					newsubseg.SetSegDest(vertex6);
					newsubseg.seg.boundary = num5;
					newsubseg.orient = 0;
					while (newsubseg.orient < 2)
					{
						int num3 = array2[1 - newsubseg.orient];
						int num6 = array3[num3].Count - 1;
						Otri item2 = array3[num3][num6];
						Otri otri2 = array3[num3][num6];
						otri = otri2;
						Vertex vertex7 = newsubseg.Org();
						bool flag = true;
						while (flag && otri.triangle != Mesh.dummytri)
						{
							Vertex vertex3 = otri.Dest();
							if (vertex7 == vertex3)
							{
								array3[num3].Remove(item2);
								otri.SegBond(ref newsubseg);
								otri.Sym(ref o3);
								if (o3.triangle == Mesh.dummytri)
								{
									mesh.InsertSubseg(ref otri, 1);
									num++;
								}
								flag = false;
							}
							num6--;
							item2 = array3[num3][num6];
							otri2 = array3[num3][num6];
							otri = otri2;
						}
						newsubseg.orient++;
					}
					num2++;
				}
			}
			for (num2 = 0; num2 < mesh.vertices.Count; num2++)
			{
				int num7 = array3[num2].Count - 1;
				Otri otri2 = array3[num2][num7];
				otri = otri2;
				while (otri.triangle != Mesh.dummytri)
				{
					num7--;
					otri2 = array3[num2][num7];
					otri.SegDissolve();
					otri.Sym(ref o3);
					if (o3.triangle == Mesh.dummytri)
					{
						mesh.InsertSubseg(ref otri, 1);
						num++;
					}
					otri = otri2;
				}
			}
			return num;
		}
	}
	internal class DebugWriter
	{
		private static NumberFormatInfo nfi;

		private int iteration;

		private string session;

		private StreamWriter stream;

		private string tmpFile;

		private int[] vertices;

		private int triangles;

		private static readonly DebugWriter instance;

		public static DebugWriter Session => instance;

		static DebugWriter()
		{
			nfi = CultureInfo.InvariantCulture.NumberFormat;
			instance = new DebugWriter();
		}

		private DebugWriter()
		{
		}

		public void Start(string session)
		{
			iteration = 0;
			this.session = session;
			if (stream != null)
			{
				throw new Exception("A session is active. Finish before starting a new.");
			}
			tmpFile = Path.GetTempFileName();
			stream = new StreamWriter(tmpFile);
		}

		public void Write(Mesh mesh, bool skip)
		{
			WriteMesh(mesh, skip);
			triangles = mesh.Triangles.Count;
		}

		public void Write(Mesh mesh)
		{
			Write(mesh, skip: false);
		}

		public void Finish()
		{
			Finish(session + ".mshx");
		}

		private void Finish(string path)
		{
			if (stream == null)
			{
				return;
			}
			stream.Flush();
			stream.Dispose();
			stream = null;
			string s = "#!N" + iteration + Environment.NewLine;
			using (FileStream compressedStream = new FileStream(path, FileMode.Create))
			{
				using GZipStream gZipStream = new GZipStream(compressedStream, CompressionMode.Compress, leaveOpen: false);
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				gZipStream.Write(bytes, 0, bytes.Length);
				bytes = File.ReadAllBytes(tmpFile);
				gZipStream.Write(bytes, 0, bytes.Length);
			}
			File.Delete(tmpFile);
		}

		private void WriteGeometry(InputGeometry geometry)
		{
			stream.WriteLine("#!G{0}", iteration++);
		}

		private void WriteMesh(Mesh mesh, bool skip)
		{
			if (triangles == mesh.triangles.Count && skip)
			{
				return;
			}
			stream.WriteLine("#!M{0}", iteration++);
			if (VerticesChanged(mesh))
			{
				HashVertices(mesh);
				stream.WriteLine("{0}", mesh.vertices.Count);
				foreach (Vertex value in mesh.vertices.Values)
				{
					stream.WriteLine("{0} {1} {2} {3}", value.hash, value.x.ToString(nfi), value.y.ToString(nfi), value.mark);
				}
			}
			else
			{
				stream.WriteLine("0");
			}
			stream.WriteLine("{0}", mesh.subsegs.Count);
			Osub osub = new Osub
			{
				orient = 0
			};
			foreach (Segment value2 in mesh.subsegs.Values)
			{
				if (value2.hash > 0)
				{
					osub.seg = value2;
					Vertex vertex = osub.Org();
					Vertex vertex2 = osub.Dest();
					stream.WriteLine("{0} {1} {2} {3}", osub.seg.hash, vertex.hash, vertex2.hash, osub.seg.boundary);
				}
			}
			Otri otri = default(Otri);
			Otri o = default(Otri);
			otri.orient = 0;
			stream.WriteLine("{0}", mesh.triangles.Count);
			foreach (Triangle value3 in mesh.triangles.Values)
			{
				otri.triangle = value3;
				Vertex vertex = otri.Org();
				Vertex vertex2 = otri.Dest();
				Vertex vertex3 = otri.Apex();
				int num = ((vertex == null) ? (-1) : vertex.hash);
				int num2 = ((vertex2 == null) ? (-1) : vertex2.hash);
				int num3 = ((vertex3 == null) ? (-1) : vertex3.hash);
				stream.Write("{0} {1} {2} {3}", otri.triangle.hash, num, num2, num3);
				otri.orient = 1;
				otri.Sym(ref o);
				int hash = o.triangle.hash;
				otri.orient = 2;
				otri.Sym(ref o);
				int hash2 = o.triangle.hash;
				otri.orient = 0;
				otri.Sym(ref o);
				int hash3 = o.triangle.hash;
				stream.WriteLine(" {0} {1} {2}", hash, hash2, hash3);
			}
		}

		private bool VerticesChanged(Mesh mesh)
		{
			if (vertices == null || mesh.Vertices.Count != vertices.Length)
			{
				return true;
			}
			int num = 0;
			foreach (Vertex vertex in mesh.Vertices)
			{
				if (vertex.id != vertices[num++])
				{
					return true;
				}
			}
			return false;
		}

		private void HashVertices(Mesh mesh)
		{
			if (vertices == null || mesh.Vertices.Count != vertices.Length)
			{
				vertices = new int[mesh.Vertices.Count];
			}
			int num = 0;
			foreach (Vertex vertex in mesh.Vertices)
			{
				vertices[num++] = vertex.id;
			}
		}
	}
	public static class FileWriter
	{
		private static NumberFormatInfo nfi = CultureInfo.InvariantCulture.NumberFormat;

		public static void Write(Mesh mesh, string filename)
		{
			WritePoly(mesh, Path.ChangeExtension(filename, ".poly"));
			WriteElements(mesh, Path.ChangeExtension(filename, ".ele"));
		}

		public static void WriteNodes(Mesh mesh, string filename)
		{
			using StreamWriter writer = new StreamWriter(filename);
			WriteNodes(writer, mesh);
		}

		private static void WriteNodes(StreamWriter writer, Mesh mesh)
		{
			int num = mesh.vertices.Count;
			Behavior behavior = mesh.behavior;
			if (behavior.Jettison)
			{
				num = mesh.vertices.Count - mesh.undeads;
			}
			if (writer == null)
			{
				return;
			}
			writer.WriteLine("{0} {1} {2} {3}", num, mesh.mesh_dim, mesh.nextras, behavior.UseBoundaryMarkers ? "1" : "0");
			if (mesh.numbering == NodeNumbering.None)
			{
				mesh.Renumber();
			}
			if (mesh.numbering == NodeNumbering.Linear)
			{
				WriteNodes(writer, mesh.vertices.Values, behavior.UseBoundaryMarkers, mesh.nextras, behavior.Jettison);
				return;
			}
			Vertex[] array = new Vertex[mesh.vertices.Count];
			foreach (Vertex value in mesh.vertices.Values)
			{
				array[value.id] = value;
			}
			WriteNodes(writer, array, behavior.UseBoundaryMarkers, mesh.nextras, behavior.Jettison);
		}

		private static void WriteNodes(StreamWriter writer, IEnumerable<Vertex> nodes, bool markers, int attribs, bool jettison)
		{
			int num = 0;
			foreach (Vertex node in nodes)
			{
				if (!jettison || node.type != VertexType.UndeadVertex)
				{
					writer.Write("{0} {1} {2}", num, node.x.ToString(nfi), node.y.ToString(nfi));
					for (int i = 0; i < attribs; i++)
					{
						writer.Write(" {0}", node.attributes[i].ToString(nfi));
					}
					if (markers)
					{
						writer.Write(" {0}", node.mark);
					}
					writer.WriteLine();
					num++;
				}
			}
		}

		public static void WriteElements(Mesh mesh, string filename)
		{
			Otri otri = default(Otri);
			bool useRegions = mesh.behavior.useRegions;
			int num = 0;
			otri.orient = 0;
			using StreamWriter streamWriter = new StreamWriter(filename);
			streamWriter.WriteLine("{0} 3 {1}", mesh.triangles.Count, useRegions ? 1 : 0);
			foreach (Triangle value in mesh.triangles.Values)
			{
				Triangle triangle = (otri.triangle = value);
				Vertex vertex = otri.Org();
				Vertex vertex2 = otri.Dest();
				Vertex vertex3 = otri.Apex();
				streamWriter.Write("{0} {1} {2} {3}", num, vertex.id, vertex2.id, vertex3.id);
				if (useRegions)
				{
					streamWriter.Write(" {0}", otri.triangle.region);
				}
				streamWriter.WriteLine();
				triangle.id = num++;
			}
		}

		public static void WritePoly(Mesh mesh, string filename)
		{
			WritePoly(mesh, filename, writeNodes: true);
		}

		public static void WritePoly(Mesh mesh, string filename, bool writeNodes)
		{
			Osub osub = default(Osub);
			bool useBoundaryMarkers = mesh.behavior.UseBoundaryMarkers;
			using StreamWriter streamWriter = new StreamWriter(filename);
			if (writeNodes)
			{
				WriteNodes(streamWriter, mesh);
			}
			else
			{
				streamWriter.WriteLine("0 {0} {1} {2}", mesh.mesh_dim, mesh.nextras, useBoundaryMarkers ? "1" : "0");
			}
			streamWriter.WriteLine("{0} {1}", mesh.subsegs.Count, useBoundaryMarkers ? "1" : "0");
			osub.orient = 0;
			int num = 0;
			foreach (Segment value in mesh.subsegs.Values)
			{
				osub.seg = value;
				Vertex vertex = osub.Org();
				Vertex vertex2 = osub.Dest();
				if (useBoundaryMarkers)
				{
					streamWriter.WriteLine("{0} {1} {2} {3}", num, vertex.id, vertex2.id, osub.seg.boundary);
				}
				else
				{
					streamWriter.WriteLine("{0} {1} {2}", num, vertex.id, vertex2.id);
				}
				num++;
			}
			num = 0;
			streamWriter.WriteLine("{0}", mesh.holes.Count);
			foreach (Point hole in mesh.holes)
			{
				streamWriter.WriteLine("{0} {1} {2}", num++, hole.X.ToString(nfi), hole.Y.ToString(nfi));
			}
			if (mesh.regions.Count <= 0)
			{
				return;
			}
			num = 0;
			streamWriter.WriteLine("{0}", mesh.regions.Count);
			foreach (RegionPointer region in mesh.regions)
			{
				streamWriter.WriteLine("{0} {1} {2} {3}", num, region.point.X.ToString(nfi), region.point.Y.ToString(nfi), region.id);
				num++;
			}
		}

		public static void WriteEdges(Mesh mesh, string filename)
		{
			Otri otri = default(Otri);
			Otri o = default(Otri);
			Osub os = default(Osub);
			Behavior behavior = mesh.behavior;
			using StreamWriter streamWriter = new StreamWriter(filename);
			streamWriter.WriteLine("{0} {1}", mesh.edges, behavior.UseBoundaryMarkers ? "1" : "0");
			long num = 0L;
			foreach (Triangle value in mesh.triangles.Values)
			{
				otri.triangle = value;
				otri.orient = 0;
				while (otri.orient < 3)
				{
					otri.Sym(ref o);
					if (otri.triangle.id < o.triangle.id || o.triangle == Mesh.dummytri)
					{
						Vertex vertex = otri.Org();
						Vertex vertex2 = otri.Dest();
						if (behavior.UseBoundaryMarkers)
						{
							if (behavior.useSegments)
							{
								otri.SegPivot(ref os);
								if (os.seg == Mesh.dummysub)
								{
									streamWriter.WriteLine("{0} {1} {2} {3}", num, vertex.id, vertex2.id, 0);
								}
								else
								{
									streamWriter.WriteLine("{0} {1} {2} {3}", num, vertex.id, vertex2.id, os.seg.boundary);
								}
							}
							else
							{
								streamWriter.WriteLine("{0} {1} {2} {3}", num, vertex.id, vertex2.id, (o.triangle == Mesh.dummytri) ? "1" : "0");
							}
						}
						else
						{
							streamWriter.WriteLine("{0} {1} {2}", num, vertex.id, vertex2.id);
						}
						num++;
					}
					otri.orient++;
				}
			}
		}

		public static void WriteNeighbors(Mesh mesh, string filename)
		{
			Otri otri = default(Otri);
			Otri o = default(Otri);
			int num = 0;
			using StreamWriter streamWriter = new StreamWriter(filename);
			streamWriter.WriteLine("{0} 3", mesh.triangles.Count);
			Mesh.dummytri.id = -1;
			foreach (Triangle value in mesh.triangles.Values)
			{
				otri.triangle = value;
				otri.orient = 1;
				otri.Sym(ref o);
				int id = o.triangle.id;
				otri.orient = 2;
				otri.Sym(ref o);
				int id2 = o.triangle.id;
				otri.orient = 0;
				otri.Sym(ref o);
				int id3 = o.triangle.id;
				streamWriter.WriteLine("{0} {1} {2} {3}", num++, id, id2, id3);
			}
		}

		public static void WriteVoronoi(Mesh mesh, string filename)
		{
			Otri otri = default(Otri);
			Otri o = default(Otri);
			double xi = 0.0;
			double eta = 0.0;
			int num = 0;
			otri.orient = 0;
			using StreamWriter streamWriter = new StreamWriter(filename);
			streamWriter.WriteLine("{0} 2 {1} 0", mesh.triangles.Count, mesh.nextras);
			foreach (Triangle value in mesh.triangles.Values)
			{
				otri.triangle = value;
				Vertex torg = otri.Org();
				Vertex tdest = otri.Dest();
				Vertex tapex = otri.Apex();
				Point point = Primitives.FindCircumcenter(torg, tdest, tapex, ref xi, ref eta);
				streamWriter.Write("{0} {1} {2}", num, point.X.ToString(nfi), point.Y.ToString(nfi));
				for (int i = 0; i < mesh.nextras; i++)
				{
					streamWriter.Write(" 0");
				}
				streamWriter.WriteLine();
				otri.triangle.id = num++;
			}
			streamWriter.WriteLine("{0} 0", mesh.edges);
			num = 0;
			foreach (Triangle value2 in mesh.triangles.Values)
			{
				otri.triangle = value2;
				otri.orient = 0;
				while (otri.orient < 3)
				{
					otri.Sym(ref o);
					if (otri.triangle.id < o.triangle.id || o.triangle == Mesh.dummytri)
					{
						int id = otri.triangle.id;
						if (o.triangle == Mesh.dummytri)
						{
							Vertex torg = otri.Org();
							Vertex tdest = otri.Dest();
							streamWriter.WriteLine("{0} {1} -1 {2} {3}", num, id, (tdest[1] - torg[1]).ToString(nfi), (torg[0] - tdest[0]).ToString(nfi));
						}
						else
						{
							int id2 = o.triangle.id;
							streamWriter.WriteLine("{0} {1} {2}", num, id, id2);
						}
						num++;
					}
					otri.orient++;
				}
			}
		}

		public static void WriteOffFile(Mesh mesh, string filename)
		{
			long num = mesh.vertices.Count;
			if (mesh.behavior.Jettison)
			{
				num = mesh.vertices.Count - mesh.undeads;
			}
			int num2 = 0;
			using StreamWriter streamWriter = new StreamWriter(filename);
			streamWriter.WriteLine("OFF");
			streamWriter.WriteLine("{0}  {1}  {2}", num, mesh.triangles.Count, mesh.edges);
			foreach (Vertex value in mesh.vertices.Values)
			{
				if (!mesh.behavior.Jettison || value.type != VertexType.UndeadVertex)
				{
					streamWriter.WriteLine(" {0}  {1}  0.0", value[0].ToString(nfi), value[1].ToString(nfi));
					value.id = num2++;
				}
			}
			Otri otri = default(Otri);
			otri.orient = 0;
			foreach (Triangle value2 in mesh.triangles.Values)
			{
				otri.triangle = value2;
				Vertex current = otri.Org();
				Vertex vertex = otri.Dest();
				Vertex vertex2 = otri.Apex();
				streamWriter.WriteLine(" 3   {0}  {1}  {2}", current.id, vertex.id, vertex2.id);
			}
		}
	}
	public interface IGeometryFormat
	{
		InputGeometry Read(string filename);
	}
	public interface IMeshFormat
	{
		Mesh Import(string filename);

		void Write(Mesh mesh, string filename);
	}
	public class InputTriangle : ITriangle
	{
		internal int[] vertices;

		internal int region;

		internal double area;

		public int ID => 0;

		public int P0 => vertices[0];

		public int P1 => vertices[1];

		public int P2 => vertices[2];

		public bool SupportsNeighbors => false;

		public int N0 => -1;

		public int N1 => -1;

		public int N2 => -1;

		public double Area
		{
			get
			{
				return area;
			}
			set
			{
				area = value;
			}
		}

		public int Region
		{
			get
			{
				return region;
			}
			set
			{
				region = value;
			}
		}

		public InputTriangle(int p0, int p1, int p2)
		{
			vertices = new int[3] { p0, p1, p2 };
		}

		public Vertex GetVertex(int index)
		{
			return null;
		}

		public ITriangle GetNeighbor(int index)
		{
			return null;
		}

		public ISegment GetSegment(int index)
		{
			return null;
		}
	}
	public static class FileReader
	{
		private static NumberFormatInfo nfi = CultureInfo.InvariantCulture.NumberFormat;

		private static int startIndex = 0;

		private static bool TryReadLine(StreamReader reader, out string[] token)
		{
			token = null;
			if (reader.EndOfStream)
			{
				return false;
			}
			string text = reader.ReadLine().Trim();
			while (string.IsNullOrEmpty(text.Trim()) || text.StartsWith("#"))
			{
				if (reader.EndOfStream)
				{
					return false;
				}
				text = reader.ReadLine().Trim();
			}
			token = text.Split(new char[2] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
			return true;
		}

		private static void ReadVertex(InputGeometry data, int index, string[] line, int attributes, int marks)
		{
			double x = double.Parse(line[1], nfi);
			double y = double.Parse(line[2], nfi);
			int boundary = 0;
			double[] array = ((attributes == 0) ? null : new double[attributes]);
			for (int i = 0; i < attributes; i++)
			{
				if (line.Length > 3 + i)
				{
					array[i] = double.Parse(line[3 + i], nfi);
				}
			}
			if (marks > 0 && line.Length > 3 + attributes)
			{
				boundary = int.Parse(line[3 + attributes]);
			}
			data.AddPoint(x, y, boundary, array);
		}

		public static void Read(string filename, out InputGeometry geometry)
		{
			geometry = null;
			string text = Path.ChangeExtension(filename, ".poly");
			if (File.Exists(text))
			{
				geometry = ReadPolyFile(text);
				return;
			}
			text = Path.ChangeExtension(filename, ".node");
			geometry = ReadNodeFile(text);
		}

		public static void Read(string filename, out InputGeometry geometry, out List<ITriangle> triangles)
		{
			triangles = null;
			Read(filename, out geometry);
			string text = Path.ChangeExtension(filename, ".ele");
			if (File.Exists(text) && geometry != null)
			{
				triangles = ReadEleFile(text);
			}
		}

		public static InputGeometry Read(string filename)
		{
			InputGeometry geometry = null;
			Read(filename, out geometry);
			return geometry;
		}

		public static InputGeometry ReadNodeFile(string nodefilename)
		{
			return ReadNodeFile(nodefilename, readElements: false);
		}

		public static InputGeometry ReadNodeFile(string nodefilename, bool readElements)
		{
			startIndex = 0;
			int num = 0;
			int attributes = 0;
			int marks = 0;
			InputGeometry inputGeometry;
			using (StreamReader reader = new StreamReader(nodefilename))
			{
				if (!TryReadLine(reader, out var token))
				{
					throw new Exception("Can't read input file.");
				}
				num = int.Parse(token[0]);
				if (num < 3)
				{
					throw new Exception("Input must have at least three input vertices.");
				}
				if (token.Length > 1 && int.Parse(token[1]) != 2)
				{
					throw new Exception("Triangle only works with two-dimensional meshes.");
				}
				if (token.Length > 2)
				{
					attributes = int.Parse(token[2]);
				}
				if (token.Length > 3)
				{
					marks = int.Parse(token[3]);
				}
				inputGeometry = new InputGeometry(num);
				if (num > 0)
				{
					for (int i = 0; i < num; i++)
					{
						if (!TryReadLine(reader, out token))
						{
							throw new Exception("Can't read input file (vertices).");
						}
						if (token.Length < 3)
						{
							throw new Exception("Invalid vertex.");
						}
						if (i == 0)
						{
							startIndex = int.Parse(token[0], nfi);
						}
						ReadVertex(inputGeometry, i, token, attributes, marks);
					}
				}
			}
			if (readElements)
			{
				string text = Path.ChangeExtension(nodefilename, ".ele");
				if (File.Exists(text))
				{
					ReadEleFile(text, readArea: true);
				}
			}
			return inputGeometry;
		}

		public static InputGeometry ReadPolyFile(string polyfilename)
		{
			return ReadPolyFile(polyfilename, readElements: false, readArea: false);
		}

		public static InputGeometry ReadPolyFile(string polyfilename, bool readElements)
		{
			return ReadPolyFile(polyfilename, readElements, readArea: false);
		}

		public static InputGeometry ReadPolyFile(string polyfilename, bool readElements, bool readArea)
		{
			startIndex = 0;
			int num = 0;
			int attributes = 0;
			int marks = 0;
			InputGeometry inputGeometry;
			using (StreamReader reader = new StreamReader(polyfilename))
			{
				if (!TryReadLine(reader, out var token))
				{
					throw new Exception("Can't read input file.");
				}
				num = int.Parse(token[0]);
				if (token.Length > 1 && int.Parse(token[1]) != 2)
				{
					throw new Exception("Triangle only works with two-dimensional meshes.");
				}
				if (token.Length > 2)
				{
					attributes = int.Parse(token[2]);
				}
				if (token.Length > 3)
				{
					marks = int.Parse(token[3]);
				}
				if (num > 0)
				{
					inputGeometry = new InputGeometry(num);
					for (int i = 0; i < num; i++)
					{
						if (!TryReadLine(reader, out token))
						{
							throw new Exception("Can't read input file (vertices).");
						}
						if (token.Length < 3)
						{
							throw new Exception("Invalid vertex.");
						}
						if (i == 0)
						{
							startIndex = int.Parse(token[0], nfi);
						}
						ReadVertex(inputGeometry, i, token, attributes, marks);
					}
				}
				else
				{
					inputGeometry = ReadNodeFile(Path.ChangeExtension(polyfilename, ".node"));
					num = inputGeometry.Count;
				}
				if (inputGeometry.Points == null)
				{
					throw new Exception("No nodes available.");
				}
				if (!TryReadLine(reader, out token))
				{
					throw new Exception("Can't read input file (segments).");
				}
				int num2 = int.Parse(token[0]);
				int num3 = 0;
				if (token.Length > 1)
				{
					num3 = int.Parse(token[1]);
				}
				for (int j = 0; j < num2; j++)
				{
					if (!TryReadLine(reader, out token))
					{
						throw new Exception("Can't read input file (segments).");
					}
					if (token.Length < 3)
					{
						throw new Exception("Segment has no endpoints.");
					}
					int num4 = int.Parse(token[1]) - startIndex;
					int num5 = int.Parse(token[2]) - startIndex;
					int boundary = 0;
					if (num3 > 0 && token.Length > 3)
					{
						boundary = int.Parse(token[3]);
					}
					if (num4 < 0 || num4 >= num)
					{
						if (Behavior.Verbose)
						{
							SimpleLog.Instance.Warning("Invalid first endpoint of segment.", "MeshReader.ReadPolyfile()");
						}
					}
					else if (num5 < 0 || num5 >= num)
					{
						if (Behavior.Verbose)
						{
							SimpleLog.Instance.Warning("Invalid second endpoint of segment.", "MeshReader.ReadPolyfile()");
						}
					}
					else
					{
						inputGeometry.AddSegment(num4, num5, boundary);
					}
				}
				if (!TryReadLine(reader, out token))
				{
					throw new Exception("Can't read input file (holes).");
				}
				int num6 = int.Parse(token[0]);
				if (num6 > 0)
				{
					for (int k = 0; k < num6; k++)
					{
						if (!TryReadLine(reader, out token))
						{
							throw new Exception("Can't read input file (holes).");
						}
						if (token.Length < 3)
						{
							throw new Exception("Invalid hole.");
						}
						inputGeometry.AddHole(double.Parse(token[1], nfi), double.Parse(token[2], nfi));
					}
				}
				if (TryReadLine(reader, out token))
				{
					int num7 = int.Parse(token[0]);
					if (num7 > 0)
					{
						for (int l = 0; l < num7; l++)
						{
							if (!TryReadLine(reader, out token))
							{
								throw new Exception("Can't read input file (region).");
							}
							if (token.Length < 4)
							{
								throw new Exception("Invalid region attributes.");
							}
							inputGeometry.AddRegion(double.Parse(token[1], nfi), double.Parse(token[2], nfi), int.Parse(token[3]));
						}
					}
				}
			}
			if (readElements)
			{
				string text = Path.ChangeExtension(polyfilename, ".ele");
				if (File.Exists(text))
				{
					ReadEleFile(text, readArea);
				}
			}
			return inputGeometry;
		}

		public static List<ITriangle> ReadEleFile(string elefilename)
		{
			return ReadEleFile(elefilename, readArea: false);
		}

		private static List<ITriangle> ReadEleFile(string elefilename, bool readArea)
		{
			int num = 0;
			int num2 = 0;
			List<ITriangle> list;
			using (StreamReader reader = new StreamReader(elefilename))
			{
				bool flag = false;
				if (!TryReadLine(reader, out var token))
				{
					throw new Exception("Can't read input file (elements).");
				}
				num = int.Parse(token[0]);
				num2 = 0;
				if (token.Length > 2)
				{
					num2 = int.Parse(token[2]);
					flag = true;
				}
				if (num2 > 1)
				{
					SimpleLog.Instance.Warning("Triangle attributes not supported.", "FileReader.Read");
				}
				list = new List<ITriangle>(num);
				for (int i = 0; i < num; i++)
				{
					if (!TryReadLine(reader, out token))
					{
						throw new Exception("Can't read input file (elements).");
					}
					if (token.Length < 4)
					{
						throw new Exception("Triangle has no nodes.");
					}
					InputTriangle inputTriangle = new InputTriangle(int.Parse(token[1]) - startIndex, int.Parse(token[2]) - startIndex, int.Parse(token[3]) - startIndex);
					if (num2 > 0 && flag)
					{
						int result = 0;
						flag = int.TryParse(token[4], out result);
						inputTriangle.region = result;
					}
					list.Add(inputTriangle);
				}
			}
			if (readArea)
			{
				string text = Path.ChangeExtension(elefilename, ".area");
				if (File.Exists(text))
				{
					ReadAreaFile(text, num);
				}
			}
			return list;
		}

		private static double[] ReadAreaFile(string areafilename, int intriangles)
		{
			double[] array = null;
			using StreamReader reader = new StreamReader(areafilename);
			if (!TryReadLine(reader, out var token))
			{
				throw new Exception("Can't read input file (area).");
			}
			if (int.Parse(token[0]) != intriangles)
			{
				SimpleLog.Instance.Warning("Number of area constraints doesn't match number of triangles.", "ReadAreaFile()");
				return null;
			}
			array = new double[intriangles];
			for (int i = 0; i < intriangles; i++)
			{
				if (!TryReadLine(reader, out token))
				{
					throw new Exception("Can't read input file (area).");
				}
				if (token.Length != 2)
				{
					throw new Exception("Triangle has no nodes.");
				}
				array[i] = double.Parse(token[1], nfi);
			}
			return array;
		}

		public static List<Edge> ReadEdgeFile(string edgeFile, int invertices)
		{
			List<Edge> list = null;
			startIndex = 0;
			using StreamReader reader = new StreamReader(edgeFile);
			if (!TryReadLine(reader, out var token))
			{
				throw new Exception("Can't read input file (segments).");
			}
			int num = int.Parse(token[0]);
			int num2 = 0;
			if (token.Length > 1)
			{
				num2 = int.Parse(token[1]);
			}
			if (num > 0)
			{
				list = new List<Edge>(num);
			}
			for (int i = 0; i < num; i++)
			{
				if (!TryReadLine(reader, out token))
				{
					throw new Exception("Can't read input file (segments).");
				}
				if (token.Length < 3)
				{
					throw new Exception("Segment has no endpoints.");
				}
				int num3 = int.Parse(token[1]) - startIndex;
				int num4 = int.Parse(token[2]) - startIndex;
				int boundary = 0;
				if (num2 > 0 && token.Length > 3)
				{
					boundary = int.Parse(token[3]);
				}
				if (num3 < 0 || num3 >= invertices)
				{
					if (Behavior.Verbose)
					{
						SimpleLog.Instance.Warning("Invalid first endpoint of segment.", "MeshReader.ReadPolyfile()");
					}
				}
				else if (num4 < 0 || num4 >= invertices)
				{
					if (Behavior.Verbose)
					{
						SimpleLog.Instance.Warning("Invalid second endpoint of segment.", "MeshReader.ReadPolyfile()");
					}
				}
				else
				{
					list.Add(new Edge(num3, num4, boundary));
				}
			}
			return list;
		}
	}
	public class TriangleFormat : IGeometryFormat, IMeshFormat
	{
		public Mesh Import(string filename)
		{
			switch (Path.GetExtension(filename))
			{
			case ".node":
			case ".poly":
			case ".ele":
			{
				FileReader.Read(filename, out var geometry, out var triangles);
				if (geometry != null && triangles != null)
				{
					Mesh mesh = new Mesh();
					mesh.Load(geometry, triangles);
					return mesh;
				}
				break;
			}
			}
			throw new NotSupportedException("Could not load '" + filename + "' file.");
		}

		public void Write(Mesh mesh, string filename)
		{
			FileWriter.WritePoly(mesh, Path.ChangeExtension(filename, ".poly"));
			FileWriter.WriteElements(mesh, Path.ChangeExtension(filename, ".ele"));
		}

		public InputGeometry Read(string filename)
		{
			string extension = Path.GetExtension(filename);
			if (extension == ".node")
			{
				return FileReader.ReadNodeFile(filename);
			}
			if (extension == ".poly")
			{
				return FileReader.ReadPolyFile(filename);
			}
			throw new NotSupportedException("File format '" + extension + "' not supported.");
		}
	}
}
namespace TriangleNet.Geometry
{
	public class BoundingBox
	{
		private double xmin;

		private double ymin;

		private double xmax;

		private double ymax;

		public double MinX => xmin;

		public double MaxX => xmax;

		public double MinY => ymin;

		public double MaxY => ymax;

		public double Width => xmax - xmin;

		public double Height => ymax - ymin;

		public BoundingBox()
			: this(double.MaxValue, double.MaxValue, double.MinValue, double.MinValue)
		{
		}

		public BoundingBox(BoundingBox other)
			: this(other.MinX, other.MinY, other.MaxX, other.MaxY)
		{
		}

		public BoundingBox(double xmin, double ymin, double xmax, double ymax)
		{
			this.xmin = xmin;
			this.xmax = xmax;
			this.ymin = ymin;
			this.ymax = ymax;
		}

		public void Resize(double dx, double dy)
		{
			xmin -= dx;
			xmax += dx;
			ymin -= dy;
			ymax += dy;
		}

		public void Expand(double x, double y)
		{
			xmin = Math.Min(xmin, x);
			ymin = Math.Min(ymin, y);
			xmax = Math.Max(xmax, x);
			ymax = Math.Max(ymax, y);
		}

		public void Expand(BoundingBox other)
		{
			xmin = Math.Min(xmin, other.xmin);
			ymin = Math.Min(ymin, other.ymin);
			xmax = Math.Max(xmax, other.xmax);
			ymax = Math.Max(ymax, other.ymax);
		}

		public bool Contains(Point pt)
		{
			if (pt.x >= xmin && pt.x <= xmax && pt.y >= ymin)
			{
				return pt.y <= ymax;
			}
			return false;
		}

		public bool Contains(BoundingBox other)
		{
			if (xmin <= other.MinX && other.MaxX <= xmax && ymin <= other.MinY)
			{
				return other.MaxY <= ymax;
			}
			return false;
		}

		public bool Intersects(BoundingBox other)
		{
			if (other.MinX < xmax && xmin < other.MaxX && other.MinY < ymax)
			{
				return ymin < other.MaxY;
			}
			return false;
		}
	}
	public class Edge
	{
		public int P0 { get; private set; }

		public int P1 { get; private set; }

		public int Boundary { get; private set; }

		public Edge(int p0, int p1)
			: this(p0, p1, 0)
		{
		}

		public Edge(int p0, int p1, int boundary)
		{
			P0 = p0;
			P1 = p1;
			Boundary = boundary;
		}
	}
	public class EdgeEnumerator : IEnumerator<Edge>, IDisposable, IEnumerator
	{
		private IEnumerator<Triangle> triangles;

		private Otri tri;

		private Otri neighbor;

		private Osub sub;

		private Edge current;

		private Vertex p1;

		private Vertex p2;

		public Edge Current => current;

		object IEnumerator.Current => current;

		public EdgeEnumerator(Mesh mesh)
		{
			triangles = mesh.triangles.Values.GetEnumerator();
			triangles.MoveNext();
			tri.triangle = triangles.Current;
			tri.orient = 0;
		}

		public void Dispose()
		{
			triangles.Dispose();
		}

		public bool MoveNext()
		{
			if (tri.triangle == null)
			{
				return false;
			}
			current = null;
			while (current == null)
			{
				if (tri.orient == 3)
				{
					if (!triangles.MoveNext())
					{
						return false;
					}
					tri.triangle = triangles.Current;
					tri.orient = 0;
				}
				tri.Sym(ref neighbor);
				if (tri.triangle.id < neighbor.triangle.id || neighbor.triangle == Mesh.dummytri)
				{
					p1 = tri.Org();
					p2 = tri.Dest();
					tri.SegPivot(ref sub);
					current = new Edge(p1.id, p2.id, sub.seg.boundary);
				}
				tri.orient++;
			}
			return true;
		}

		public void Reset()
		{
			triangles.Reset();
		}
	}
	public class InputGeometry
	{
		internal List<Vertex> points;

		internal List<Edge> segments;

		internal List<Point> holes;

		internal List<RegionPointer> regions;

		private BoundingBox bounds;

		private int pointAttributes = -1;

		public BoundingBox Bounds => bounds;

		public bool HasSegments => segments.Count > 0;

		public int Count => points.Count;

		public IEnumerable<Point> Points => ((IEnumerable<Vertex>)points).Select((Func<Vertex, Point>)((Vertex v) => v));

		public ICollection<Edge> Segments => segments;

		public ICollection<Point> Holes => holes;

		public ICollection<RegionPointer> Regions => regions;

		public InputGeometry()
			: this(3)
		{
		}

		public InputGeometry(int capacity)
		{
			points = new List<Vertex>(capacity);
			segments = new List<Edge>();
			holes = new List<Point>();
			regions = new List<RegionPointer>();
			bounds = new BoundingBox();
			pointAttributes = -1;
		}

		public void Clear()
		{
			points.Clear();
			segments.Clear();
			holes.Clear();
			regions.Clear();
			pointAttributes = -1;
		}

		public void AddPoint(double x, double y)
		{
			AddPoint(x, y, 0);
		}

		public void AddPoint(double x, double y, int boundary)
		{
			points.Add(new Vertex(x, y, boundary));
			bounds.Expand(x, y);
		}

		public void AddPoint(double x, double y, int boundary, double attribute)
		{
			AddPoint(x, y, 0, new double[1] { attribute });
		}

		public void AddPoint(double x, double y, int boundary, double[] attribs)
		{
			if (pointAttributes < 0)
			{
				pointAttributes = ((attribs != null) ? attribs.Length : 0);
			}
			else
			{
				if (attribs == null && pointAttributes > 0)
				{
					throw new ArgumentException("Inconsitent use of point attributes.");
				}
				if (attribs != null && pointAttributes != attribs.Length)
				{
					throw new ArgumentException("Inconsitent use of point attributes.");
				}
			}
			points.Add(new Vertex(x, y, boundary)
			{
				attributes = attribs
			});
			bounds.Expand(x, y);
		}

		public void AddPoint(Vertex v)
		{
			double[] attributes = v.attributes;
			if (pointAttributes < 0)
			{
				pointAttributes = ((attributes != null) ? attributes.Length : 0);
			}
			else
			{
				if (attributes == null && pointAttributes > 0)
				{
					throw new ArgumentException("Inconsitent use of point attributes.");
				}
				if (attributes != null && pointAttributes != attributes.Length)
				{
					throw new ArgumentException("Inconsitent use of point attributes.");
				}
			}
			points.Add(v);
			bounds.Expand(v.x, v.y);
		}

		public void AddHole(double x, double y)
		{
			holes.Add(new Point(x, y));
		}

		public void AddRegion(double x, double y, int id)
		{
			regions.Add(new RegionPointer(x, y, id));
		}

		public void AddSegment(int p0, int p1)
		{
			AddSegment(p0, p1, 0);
		}

		public void AddSegment(int p0, int p1, int boundary)
		{
			if (p0 == p1 || p0 < 0 || p1 < 0)
			{
				throw new NotSupportedException("Invalid endpoints.");
			}
			segments.Add(new Edge(p0, p1, boundary));
		}
	}
	public interface ITriangle
	{
		int ID { get; }

		int P0 { get; }

		int P1 { get; }

		int P2 { get; }

		bool SupportsNeighbors { get; }

		int N0 { get; }

		int N1 { get; }

		int N2 { get; }

		double Area { get; set; }

		int Region { get; }

		Vertex GetVertex(int index);

		ITriangle GetNeighbor(int index);

		ISegment GetSegment(int index);
	}
	public class Point : IComparable<Point>, IEquatable<Point>
	{
		internal int id;

		internal double x;

		internal double y;

		internal int mark;

		internal double[] attributes;

		public int ID => id;

		public double X => x;

		public double Y => y;

		public int Boundary => mark;

		public double[] Attributes => attributes;

		public Point()
			: this(0.0, 0.0, 0)
		{
		}

		public Point(double x, double y)
			: this(x, y, 0)
		{
		}

		public Point(double x, double y, int mark)
		{
			this.x = x;
			this.y = y;
			this.mark = mark;
		}

		public static bool operator ==(Point a, Point b)
		{
			if ((object)a == b)
			{
				return true;
			}
			if ((object)a == null || (object)b == null)
			{
				return false;
			}
			return a.Equals(b);
		}

		public static bool operator !=(Point a, Point b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is Point point))
			{
				return false;
			}
			if (x == point.x)
			{
				return y == point.y;
			}
			return false;
		}

		public bool Equals(Point p)
		{
			if ((object)p == null)
			{
				return false;
			}
			if (x == p.x)
			{
				return y == p.y;
			}
			return false;
		}

		public int CompareTo(Point other)
		{
			if (x == other.x && y == other.y)
			{
				return 0;
			}
			if (!(x < other.x) && (x != other.x || !(y < other.y)))
			{
				return 1;
			}
			return -1;
		}

		public override int GetHashCode()
		{
			return x.GetHashCode() ^ y.GetHashCode();
		}

		public override string ToString()
		{
			return $"[{x},{y}]";
		}
	}
	public class RegionPointer
	{
		internal Point point;

		internal int id;

		public RegionPointer(double x, double y, int id)
		{
			point = new Point(x, y);
			this.id = id;
		}
	}
	public interface ISegment
	{
		int P0 { get; }

		int P1 { get; }

		int Boundary { get; }

		Vertex GetVertex(int index);

		ITriangle GetTriangle(int index);
	}
}
namespace TriangleNet.Data
{
	internal class BadSubseg
	{
		private static int hashSeed;

		internal int Hash;

		public Osub encsubseg;

		public Vertex subsegorg;

		public Vertex subsegdest;

		public BadSubseg()
		{
			Hash = hashSeed++;
		}

		public override int GetHashCode()
		{
			return Hash;
		}

		public override string ToString()
		{
			return $"B-SID {encsubseg.seg.hash}";
		}
	}
	internal class BadTriangle
	{
		public static int OTID;

		public int ID;

		public Otri poortri;

		public double key;

		public Vertex triangorg;

		public Vertex triangdest;

		public Vertex triangapex;

		public BadTriangle nexttriang;

		public BadTriangle()
		{
			ID = OTID++;
		}

		public override string ToString()
		{
			return $"B-TID {poortri.triangle.hash}";
		}
	}
	internal struct Osub
	{
		public Segment seg;

		public int orient;

		public override string ToString()
		{
			if (seg == null)
			{
				return "O-TID [null]";
			}
			return $"O-SID {seg.hash}";
		}

		public void Sym(ref Osub o2)
		{
			o2.seg = seg;
			o2.orient = 1 - orient;
		}

		public void SymSelf()
		{
			orient = 1 - orient;
		}

		public void Pivot(ref Osub o2)
		{
			o2 = seg.subsegs[orient];
		}

		public void PivotSelf()
		{
			this = seg.subsegs[orient];
		}

		public void Next(ref Osub o2)
		{
			o2 = seg.subsegs[1 - orient];
		}

		public void NextSelf()
		{
			this = seg.subsegs[1 - orient];
		}

		public Vertex Org()
		{
			return seg.vertices[orient];
		}

		public Vertex Dest()
		{
			return seg.vertices[1 - orient];
		}

		public void SetOrg(Vertex ptr)
		{
			seg.vertices[orient] = ptr;
		}

		public void SetDest(Vertex ptr)
		{
			seg.vertices[1 - orient] = ptr;
		}

		public Vertex SegOrg()
		{
			return seg.vertices[2 + orient];
		}

		public Vertex SegDest()
		{
			return seg.vertices[3 - orient];
		}

		public void SetSegOrg(Vertex ptr)
		{
			seg.vertices[2 + orient] = ptr;
		}

		public void SetSegDest(Vertex ptr)
		{
			seg.vertices[3 - orient] = ptr;
		}

		public int Mark()
		{
			return seg.boundary;
		}

		public void SetMark(int value)
		{
			seg.boundary = value;
		}

		public void Bond(ref Osub o2)
		{
			seg.subsegs[orient] = o2;
			o2.seg.subsegs[o2.orient] = this;
		}

		public void Dissolve()
		{
			seg.subsegs[orient].seg = Mesh.dummysub;
		}

		public void Copy(ref Osub o2)
		{
			o2.seg = seg;
			o2.orient = orient;
		}

		public bool Equal(Osub o2)
		{
			if (seg == o2.seg)
			{
				return orient == o2.orient;
			}
			return false;
		}

		public static bool IsDead(Segment sub)
		{
			return sub.subsegs[0].seg == null;
		}

		public static void Kill(Segment sub)
		{
			sub.subsegs[0].seg = null;
			sub.subsegs[1].seg = null;
		}

		public void TriPivot(ref Otri ot)
		{
			ot = seg.triangles[orient];
		}

		public void TriDissolve()
		{
			seg.triangles[orient].triangle = Mesh.dummytri;
		}
	}
	internal struct Otri
	{
		public Triangle triangle;

		public int orient;

		private static readonly int[] plus1Mod3 = new int[3] { 1, 2, 0 };

		private static readonly int[] minus1Mod3 = new int[3] { 2, 0, 1 };

		public override string ToString()
		{
			if (triangle == null)
			{
				return "O-TID [null]";
			}
			return $"O-TID {triangle.hash}";
		}

		public void Sym(ref Otri o2)
		{
			o2.triangle = triangle.neighbors[orient].triangle;
			o2.orient = triangle.neighbors[orient].orient;
		}

		public void SymSelf()
		{
			int num = orient;
			orient = triangle.neighbors[num].orient;
			triangle = triangle.neighbors[num].triangle;
		}

		public void Lnext(ref Otri o2)
		{
			o2.triangle = triangle;
			o2.orient = plus1Mod3[orient];
		}

		public void LnextSelf()
		{
			orient = plus1Mod3[orient];
		}

		public void Lprev(ref Otri o2)
		{
			o2.triangle = triangle;
			o2.orient = minus1Mod3[orient];
		}

		public void LprevSelf()
		{
			orient = minus1Mod3[orient];
		}

		public void Onext(ref Otri o2)
		{
			o2.triangle = triangle;
			o2.orient = minus1Mod3[orient];
			int num = o2.orient;
			o2.orient = o2.triangle.neighbors[num].orient;
			o2.triangle = o2.triangle.neighbors[num].triangle;
		}

		public void OnextSelf()
		{
			orient = minus1Mod3[orient];
			int num = orient;
			orient = triangle.neighbors[num].orient;
			triangle = triangle.neighbors[num].triangle;
		}

		public void Oprev(ref Otri o2)
		{
			o2.triangle = triangle.neighbors[orient].triangle;
			o2.orient = triangle.neighbors[orient].orient;
			o2.orient = plus1Mod3[o2.orient];
		}

		public void OprevSelf()
		{
			int num = orient;
			orient = triangle.neighbors[num].orient;
			triangle = triangle.neighbors[num].triangle;
			orient = plus1Mod3[orient];
		}

		public void Dnext(ref Otri o2)
		{
			o2.triangle = triangle.neighbors[orient].triangle;
			o2.orient = triangle.neighbors[orient].orient;
			o2.orient = minus1Mod3[o2.orient];
		}

		public void DnextSelf()
		{
			int num = orient;
			orient = triangle.neighbors[num].orient;
			triangle = triangle.neighbors[num].triangle;
			orient = minus1Mod3[orient];
		}

		public void Dprev(ref Otri o2)
		{
			o2.triangle = triangle;
			o2.orient = plus1Mod3[orient];
			int num = o2.orient;
			o2.orient = o2.triangle.neighbors[num].orient;
			o2.triangle = o2.triangle.neighbors[num].triangle;
		}

		public void DprevSelf()
		{
			orient = plus1Mod3[orient];
			int num = orient;
			orient = triangle.neighbors[num].orient;
			triangle = triangle.neighbors[num].triangle;
		}

		public void Rnext(ref Otri o2)
		{
			o2.triangle = triangle.neighbors[orient].triangle;
			o2.orient = triangle.neighbors[orient].orient;
			o2.orient = plus1Mod3[o2.orient];
			int num = o2.orient;
			o2.orient = o2.triangle.neighbors[num].orient;
			o2.triangle = o2.triangle.neighbors[num].triangle;
		}

		public void RnextSelf()
		{
			int num = orient;
			orient = triangle.neighbors[num].orient;
			triangle = triangle.neighbors[num].triangle;
			orient = plus1Mod3[orient];
			num = orient;
			orient = triangle.neighbors[num].orient;
			triangle = triangle.neighbors[num].triangle;
		}

		public void Rprev(ref Otri o2)
		{
			o2.triangle = triangle.neighbors[orient].triangle;
			o2.orient = triangle.neighbors[orient].orient;
			o2.orient = minus1Mod3[o2.orient];
			int num = o2.orient;
			o2.orient = o2.triangle.neighbors[num].orient;
			o2.triangle = o2.triangle.neighbors[num].triangle;
		}

		public void RprevSelf()
		{
			int num = orient;
			orient = triangle.neighbors[num].orient;
			triangle = triangle.neighbors[num].triangle;
			orient = minus1Mod3[orient];
			num = orient;
			orient = triangle.neighbors[num].orient;
			triangle = triangle.neighbors[num].triangle;
		}

		public Vertex Org()
		{
			return triangle.vertices[plus1Mod3[orient]];
		}

		public Vertex Dest()
		{
			return triangle.vertices[minus1Mod3[orient]];
		}

		public Vertex Apex()
		{
			return triangle.vertices[orient];
		}

		public void SetOrg(Vertex ptr)
		{
			triangle.vertices[plus1Mod3[orient]] = ptr;
		}

		public void SetDest(Vertex ptr)
		{
			triangle.vertices[minus1Mod3[orient]] = ptr;
		}

		public void SetApex(Vertex ptr)
		{
			triangle.vertices[orient] = ptr;
		}

		public void Bond(ref Otri o2)
		{
			triangle.neighbors[orient].triangle = o2.triangle;
			triangle.neighbors[orient].orient = o2.orient;
			o2.triangle.neighbors[o2.orient].triangle = triangle;
			o2.triangle.neighbors[o2.orient].orient = orient;
		}

		public void Dissolve()
		{
			triangle.neighbors[orient].triangle = Mesh.dummytri;
			triangle.neighbors[orient].orient = 0;
		}

		public void Copy(ref Otri o2)
		{
			o2.triangle = triangle;
			o2.orient = orient;
		}

		public bool Equal(Otri o2)
		{
			if (triangle == o2.triangle)
			{
				return orient == o2.orient;
			}
			return false;
		}

		public void Infect()
		{
			triangle.infected = true;
		}

		public void Uninfect()
		{
			triangle.infected = false;
		}

		public bool IsInfected()
		{
			return triangle.infected;
		}

		public static bool IsDead(Triangle tria)
		{
			return tria.neighbors[0].triangle == null;
		}

		public static void Kill(Triangle tria)
		{
			tria.neighbors[0].triangle = null;
			tria.neighbors[2].triangle = null;
		}

		public void SegPivot(ref Osub os)
		{
			os = triangle.subsegs[orient];
		}

		public void SegBond(ref Osub os)
		{
			triangle.subsegs[orient] = os;
			os.seg.triangles[os.orient] = this;
		}

		public void SegDissolve()
		{
			triangle.subsegs[orient].seg = Mesh.dummysub;
		}
	}
	public class Segment : ISegment
	{
		internal int hash;

		internal Osub[] subsegs;

		internal Vertex[] vertices;

		internal Otri[] triangles;

		internal int boundary;

		public int P0 => vertices[0].id;

		public int P1 => vertices[1].id;

		public int Boundary => boundary;

		public Segment()
		{
			subsegs = new Osub[2];
			subsegs[0].seg = Mesh.dummysub;
			subsegs[1].seg = Mesh.dummysub;
			vertices = new Vertex[4];
			triangles = new Otri[2];
			triangles[0].triangle = Mesh.dummytri;
			triangles[1].triangle = Mesh.dummytri;
			boundary = 0;
		}

		public Vertex GetVertex(int index)
		{
			return vertices[index];
		}

		public ITriangle GetTriangle(int index)
		{
			if (triangles[index].triangle != Mesh.dummytri)
			{
				return triangles[index].triangle;
			}
			return null;
		}

		public override int GetHashCode()
		{
			return hash;
		}

		public override string ToString()
		{
			return $"SID {hash}";
		}
	}
	public class Triangle : ITriangle
	{
		internal int hash;

		internal int id;

		internal Otri[] neighbors;

		internal Vertex[] vertices;

		internal Osub[] subsegs;

		internal int region;

		internal double area;

		internal bool infected;

		public int ID => id;

		public int P0
		{
			get
			{
				if (!(vertices[0] == null))
				{
					return vertices[0].id;
				}
				return -1;
			}
		}

		public int P1
		{
			get
			{
				if (!(vertices[1] == null))
				{
					return vertices[1].id;
				}
				return -1;
			}
		}

		public int P2
		{
			get
			{
				if (!(vertices[2] == null))
				{
					return vertices[2].id;
				}
				return -1;
			}
		}

		public bool SupportsNeighbors => true;

		public int N0 => neighbors[0].triangle.id;

		public int N1 => neighbors[1].triangle.id;

		public int N2 => neighbors[2].triangle.id;

		public double Area
		{
			get
			{
				return area;
			}
			set
			{
				area = value;
			}
		}

		public int Region => region;

		public Triangle()
		{
			neighbors = new Otri[3];
			neighbors[0].triangle = Mesh.dummytri;
			neighbors[1].triangle = Mesh.dummytri;
			neighbors[2].triangle = Mesh.dummytri;
			vertices = new Vertex[3];
			subsegs = new Osub[3];
			subsegs[0].seg = Mesh.dummysub;
			subsegs[1].seg = Mesh.dummysub;
			subsegs[2].seg = Mesh.dummysub;
		}

		public Vertex GetVertex(int index)
		{
			return vertices[index];
		}

		public ITriangle GetNeighbor(int index)
		{
			if (neighbors[index].triangle != Mesh.dummytri)
			{
				return neighbors[index].triangle;
			}
			return null;
		}

		public ISegment GetSegment(int index)
		{
			if (subsegs[index].seg != Mesh.dummysub)
			{
				return subsegs[index].seg;
			}
			return null;
		}

		public override int GetHashCode()
		{
			return hash;
		}

		public override string ToString()
		{
			return $"TID {hash}";
		}
	}
	public class Vertex : Point
	{
		internal int hash;

		internal VertexType type;

		internal Otri tri;

		public VertexType Type => type;

		public double this[int i] => i switch
		{
			0 => x, 
			1 => y, 
			_ => throw new ArgumentOutOfRangeException("Index must be 0 or 1."), 
		};

		public Vertex()
			: this(0.0, 0.0, 0, 0)
		{
		}

		public Vertex(double x, double y)
			: this(x, y, 0, 0)
		{
		}

		public Vertex(double x, double y, int mark)
			: this(x, y, mark, 0)
		{
		}

		public Vertex(double x, double y, int mark, int attribs)
			: base(x, y, mark)
		{
			type = VertexType.InputVertex;
			if (attribs > 0)
			{
				attributes = new double[attribs];
			}
		}

		public override int GetHashCode()
		{
			return hash;
		}
	}
}
namespace TriangleNet.Algorithm
{
	public interface ITriangulator
	{
		int Triangulate(Mesh mesh);
	}
	internal class Dwyer
	{
		private static Random rand = new Random(DateTime.Now.Millisecond);

		private bool useDwyer = true;

		private Vertex[] sortarray;

		private Mesh mesh;

		private void VertexSort(int left, int right)
		{
			int num = left;
			int num2 = right;
			if (right - left + 1 < 32)
			{
				for (int i = left + 1; i <= right; i++)
				{
					Vertex vertex = sortarray[i];
					int num3 = i - 1;
					while (num3 >= left && (sortarray[num3].x > vertex.x || (sortarray[num3].x == vertex.x && sortarray[num3].y > vertex.y)))
					{
						sortarray[num3 + 1] = sortarray[num3];
						num3--;
					}
					sortarray[num3 + 1] = vertex;
				}
				return;
			}
			int num4 = rand.Next(left, right);
			double x = sortarray[num4].x;
			double y = sortarray[num4].y;
			left--;
			right++;
			while (left < right)
			{
				do
				{
					left++;
				}
				while (left <= right && (sortarray[left].x < x || (sortarray[left].x == x && sortarray[left].y < y)));
				do
				{
					right--;
				}
				while (left <= right && (sortarray[right].x > x || (sortarray[right].x == x && sortarray[right].y > y)));
				if (left < right)
				{
					Vertex vertex2 = sortarray[left];
					sortarray[left] = sortarray[right];
					sortarray[right] = vertex2;
				}
			}
			if (left > num)
			{
				VertexSort(num, left);
			}
			if (num2 > right + 1)
			{
				VertexSort(right + 1, num2);
			}
		}

		private void VertexMedian(int left, int right, int median, int axis)
		{
			int num = right - left + 1;
			int left2 = left;
			int right2 = right;
			if (num == 2)
			{
				if (sortarray[left][axis] > sortarray[right][axis] || (sortarray[left][axis] == sortarray[right][axis] && sortarray[left][1 - axis] > sortarray[right][1 - axis]))
				{
					Vertex vertex = sortarray[right];
					sortarray[right] = sortarray[left];
					sortarray[left] = vertex;
				}
				return;
			}
			int num2 = rand.Next(left, right);
			double num3 = sortarray[num2][axis];
			double num4 = sortarray[num2][1 - axis];
			left--;
			right++;
			while (left < right)
			{
				do
				{
					left++;
				}
				while (left <= right && (sortarray[left][axis] < num3 || (sortarray[left][axis] == num3 && sortarray[left][1 - axis] < num4)));
				do
				{
					right--;
				}
				while (left <= right && (sortarray[right][axis] > num3 || (sortarray[right][axis] == num3 && sortarray[right][1 - axis] > num4)));
				if (left < right)
				{
					Vertex vertex = sortarray[left];
					sortarray[left] = sortarray[right];
					sortarray[right] = vertex;
				}
			}
			if (left > median)
			{
				VertexMedian(left2, left - 1, median, axis);
			}
			if (right < median - 1)
			{
				VertexMedian(right + 1, right2, median, axis);
			}
		}

		private void AlternateAxes(int left, int right, int axis)
		{
			int num = right - left + 1;
			int num2 = num >> 1;
			if (num <= 3)
			{
				axis = 0;
			}
			VertexMedian(left, right, left + num2, axis);
			if (num - num2 >= 2)
			{
				if (num2 >= 2)
				{
					AlternateAxes(left, left + num2 - 1, 1 - axis);
				}
				AlternateAxes(left + num2, right, 1 - axis);
			}
		}

		private void MergeHulls(ref Otri farleft, ref Otri innerleft, ref Otri innerright, ref Otri farright, int axis)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Otri o4 = default(Otri);
			Otri o5 = default(Otri);
			Otri o6 = default(Otri);
			Otri o7 = default(Otri);
			Otri newotri = default(Otri);
			Vertex vertex = innerleft.Dest();
			Vertex vertex2 = innerleft.Apex();
			Vertex vertex3 = innerright.Org();
			Vertex vertex4 = innerright.Apex();
			Vertex vertex5;
			Vertex vertex7;
			if (useDwyer && axis == 1)
			{
				vertex5 = farleft.Org();
				Vertex vertex6 = farleft.Apex();
				vertex7 = farright.Dest();
				Vertex vertex8 = farright.Apex();
				while (vertex6.y < vertex5.y)
				{
					farleft.LnextSelf();
					farleft.SymSelf();
					vertex5 = vertex6;
					vertex6 = farleft.Apex();
				}
				innerleft.Sym(ref o7);
				Vertex vertex9 = o7.Apex();
				while (vertex9.y > vertex.y)
				{
					o7.Lnext(ref innerleft);
					vertex2 = vertex;
					vertex = vertex9;
					innerleft.Sym(ref o7);
					vertex9 = o7.Apex();
				}
				while (vertex4.y < vertex3.y)
				{
					innerright.LnextSelf();
					innerright.SymSelf();
					vertex3 = vertex4;
					vertex4 = innerright.Apex();
				}
				farright.Sym(ref o7);
				vertex9 = o7.Apex();
				while (vertex9.y > vertex7.y)
				{
					o7.Lnext(ref farright);
					vertex8 = vertex7;
					vertex7 = vertex9;
					farright.Sym(ref o7);
					vertex9 = o7.Apex();
				}
			}
			bool flag;
			do
			{
				flag = false;
				if (Primitives.CounterClockwise(vertex, vertex2, vertex3) > 0.0)
				{
					innerleft.LprevSelf();
					innerleft.SymSelf();
					vertex = vertex2;
					vertex2 = innerleft.Apex();
					flag = true;
				}
				if (Primitives.CounterClockwise(vertex4, vertex3, vertex) > 0.0)
				{
					innerright.LnextSelf();
					innerright.SymSelf();
					vertex3 = vertex4;
					vertex4 = innerright.Apex();
					flag = true;
				}
			}
			while (flag);
			innerleft.Sym(ref o);
			innerright.Sym(ref o2);
			mesh.MakeTriangle(ref newotri);
			newotri.Bond(ref innerleft);
			newotri.LnextSelf();
			newotri.Bond(ref innerright);
			newotri.LnextSelf();
			newotri.SetOrg(vertex3);
			newotri.SetDest(vertex);
			vertex5 = farleft.Org();
			if (vertex == vertex5)
			{
				newotri.Lnext(ref farleft);
			}
			vertex7 = farright.Dest();
			if (vertex3 == vertex7)
			{
				newotri.Lprev(ref farright);
			}
			Vertex vertex10 = vertex;
			Vertex vertex11 = vertex3;
			Vertex vertex12 = o.Apex();
			Vertex vertex13 = o2.Apex();
			while (true)
			{
				bool flag2 = Primitives.CounterClockwise(vertex12, vertex10, vertex11) <= 0.0;
				bool flag3 = Primitives.CounterClockwise(vertex13, vertex10, vertex11) <= 0.0;
				if (flag2 && flag3)
				{
					break;
				}
				if (!flag2)
				{
					o.Lprev(ref o3);
					o3.SymSelf();
					Vertex vertex14 = o3.Apex();
					if (vertex14 != null)
					{
						bool flag4 = Primitives.InCircle(vertex10, vertex11, vertex12, vertex14) > 0.0;
						while (flag4)
						{
							o3.LnextSelf();
							o3.Sym(ref o5);
							o3.LnextSelf();
							o3.Sym(ref o4);
							o3.Bond(ref o5);
							o.Bond(ref o4);
							o.LnextSelf();
							o.Sym(ref o6);
							o3.LprevSelf();
							o3.Bond(ref o6);
							o.SetOrg(vertex10);
							o.SetDest(null);
							o.SetApex(vertex14);
							o3.SetOrg(null);
							o3.SetDest(vertex12);
							o3.SetApex(vertex14);
							vertex12 = vertex14;
							o4.Copy(ref o3);
							vertex14 = o3.Apex();
							flag4 = vertex14 != null && Primitives.InCircle(vertex10, vertex11, vertex12, vertex14) > 0.0;
						}
					}
				}
				if (!flag3)
				{
					o2.Lnext(ref o3);
					o3.SymSelf();
					Vertex vertex14 = o3.Apex();
					if (vertex14 != null)
					{
						bool flag4 = Primitives.InCircle(vertex10, vertex11, vertex13, vertex14) > 0.0;
						while (flag4)
						{
							o3.LprevSelf();
							o3.Sym(ref o5);
							o3.LprevSelf();
							o3.Sym(ref o4);
							o3.Bond(ref o5);
							o2.Bond(ref o4);
							o2.LprevSelf();
							o2.Sym(ref o6);
							o3.LnextSelf();
							o3.Bond(ref o6);
							o2.SetOrg(null);
							o2.SetDest(vertex11);
							o2.SetApex(vertex14);
							o3.SetOrg(vertex13);
							o3.SetDest(null);
							o3.SetApex(vertex14);
							vertex13 = vertex14;
							o4.Copy(ref o3);
							vertex14 = o3.Apex();
							flag4 = vertex14 != null && Primitives.InCircle(vertex10, vertex11, vertex13, vertex14) > 0.0;
						}
					}
				}
				if (flag2 || (!flag3 && Primitives.InCircle(vertex12, vertex10, vertex11, vertex13) > 0.0))
				{
					newotri.Bond(ref o2);
					o2.Lprev(ref newotri);
					newotri.SetDest(vertex10);
					vertex11 = vertex13;
					newotri.Sym(ref o2);
					vertex13 = o2.Apex();
				}
				else
				{
					newotri.Bond(ref o);
					o.Lnext(ref newotri);
					newotri.SetOrg(vertex11);
					vertex10 = vertex12;
					newotri.Sym(ref o);
					vertex12 = o.Apex();
				}
			}
			mesh.MakeTriangle(ref o3);
			o3.SetOrg(vertex10);
			o3.SetDest(vertex11);
			o3.Bond(ref newotri);
			o3.LnextSelf();
			o3.Bond(ref o2);
			o3.LnextSelf();
			o3.Bond(ref o);
			if (useDwyer && axis == 1)
			{
				vertex5 = farleft.Org();
				Vertex vertex6 = farleft.Apex();
				vertex7 = farright.Dest();
				Vertex vertex8 = farright.Apex();
				farleft.Sym(ref o7);
				Vertex vertex9 = o7.Apex();
				while (vertex9.x < vertex5.x)
				{
					o7.Lprev(ref farleft);
					vertex6 = vertex5;
					vertex5 = vertex9;
					farleft.Sym(ref o7);
					vertex9 = o7.Apex();
				}
				while (vertex8.x > vertex7.x)
				{
					farright.LprevSelf();
					farright.SymSelf();
					vertex7 = vertex8;
					vertex8 = farright.Apex();
				}
			}
		}

		private void DivconqRecurse(int left, int right, int axis, ref Otri farleft, ref Otri farright)
		{
			Otri newotri = default(Otri);
			Otri newotri2 = default(Otri);
			Otri newotri3 = default(Otri);
			Otri newotri4 = default(Otri);
			Otri farright2 = default(Otri);
			Otri farleft2 = default(Otri);
			int num = right - left + 1;
			switch (num)
			{
			case 2:
				mesh.MakeTriangle(ref farleft);
				farleft.SetOrg(sortarray[left]);
				farleft.SetDest(sortarray[left + 1]);
				mesh.MakeTriangle(ref farright);
				farright.SetOrg(sortarray[left + 1]);
				farright.SetDest(sortarray[left]);
				farleft.Bond(ref farright);
				farleft.LprevSelf();
				farright.LnextSelf();
				farleft.Bond(ref farright);
				farleft.LprevSelf();
				farright.LnextSelf();
				farleft.Bond(ref farright);
				farright.Lprev(ref farleft);
				break;
			case 3:
			{
				mesh.MakeTriangle(ref newotri);
				mesh.MakeTriangle(ref newotri2);
				mesh.MakeTriangle(ref newotri3);
				mesh.MakeTriangle(ref newotri4);
				double num3 = Primitives.CounterClockwise(sortarray[left], sortarray[left + 1], sortarray[left + 2]);
				if (num3 == 0.0)
				{
					newotri.SetOrg(sortarray[left]);
					newotri.SetDest(sortarray[left + 1]);
					newotri2.SetOrg(sortarray[left + 1]);
					newotri2.SetDest(sortarray[left]);
					newotri3.SetOrg(sortarray[left + 2]);
					newotri3.SetDest(sortarray[left + 1]);
					newotri4.SetOrg(sortarray[left + 1]);
					newotri4.SetDest(sortarray[left + 2]);
					newotri.Bond(ref newotri2);
					newotri3.Bond(ref newotri4);
					newotri.LnextSelf();
					newotri2.LprevSelf();
					newotri3.LnextSelf();
					newotri4.LprevSelf();
					newotri.Bond(ref newotri4);
					newotri2.Bond(ref newotri3);
					newotri.LnextSelf();
					newotri2.LprevSelf();
					newotri3.LnextSelf();
					newotri4.LprevSelf();
					newotri.Bond(ref newotri2);
					newotri3.Bond(ref newotri4);
					newotri2.Copy(ref farleft);
					newotri3.Copy(ref farright);
					break;
				}
				newotri.SetOrg(sortarray[left]);
				newotri2.SetDest(sortarray[left]);
				newotri4.SetOrg(sortarray[left]);
				if (num3 > 0.0)
				{
					newotri.SetDest(sortarray[left + 1]);
					newotri2.SetOrg(sortarray[left + 1]);
					newotri3.SetDest(sortarray[left + 1]);
					newotri.SetApex(sortarray[left + 2]);
					newotri3.SetOrg(sortarray[left + 2]);
					newotri4.SetDest(sortarray[left + 2]);
				}
				else
				{
					newotri.SetDest(sortarray[left + 2]);
					newotri2.SetOrg(sortarray[left + 2]);
					newotri3.SetDest(sortarray[left + 2]);
					newotri.SetApex(sortarray[left + 1]);
					newotri3.SetOrg(sortarray[left + 1]);
					newotri4.SetDest(sortarray[left + 1]);
				}
				newotri.Bond(ref newotri2);
				newotri.LnextSelf();
				newotri.Bond(ref newotri3);
				newotri.LnextSelf();
				newotri.Bond(ref newotri4);
				newotri2.LprevSelf();
				newotri3.LnextSelf();
				newotri2.Bond(ref newotri3);
				newotri2.LprevSelf();
				newotri4.LprevSelf();
				newotri2.Bond(ref newotri4);
				newotri3.LnextSelf();
				newotri4.LprevSelf();
				newotri3.Bond(ref newotri4);
				newotri2.Copy(ref farleft);
				if (num3 > 0.0)
				{
					newotri3.Copy(ref farright);
				}
				else
				{
					farleft.Lnext(ref farright);
				}
				break;
			}
			default:
			{
				int num2 = num >> 1;
				DivconqRecurse(left, left + num2 - 1, 1 - axis, ref farleft, ref farright2);
				DivconqRecurse(left + num2, right, 1 - axis, ref farleft2, ref farright);
				MergeHulls(ref farleft, ref farright2, ref farleft2, ref farright, axis);
				break;
			}
			}
		}

		private int RemoveGhosts(ref Otri startghost)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			bool flag = !mesh.behavior.Poly;
			startghost.Lprev(ref o);
			o.SymSelf();
			Mesh.dummytri.neighbors[0] = o;
			startghost.Copy(ref o2);
			int num = 0;
			do
			{
				num++;
				o2.Lnext(ref o3);
				o2.LprevSelf();
				o2.SymSelf();
				if (flag && o2.triangle != Mesh.dummytri)
				{
					Vertex vertex = o2.Org();
					if (vertex.mark == 0)
					{
						vertex.mark = 1;
					}
				}
				o2.Dissolve();
				o3.Sym(ref o2);
				mesh.TriangleDealloc(o3.triangle);
			}
			while (!o2.Equal(startghost));
			return num;
		}

		public int Triangulate(Mesh m)
		{
			Otri farleft = default(Otri);
			Otri farright = default(Otri);
			mesh = m;
			sortarray = new Vertex[m.invertices];
			int num = 0;
			foreach (Vertex value in m.vertices.Values)
			{
				sortarray[num++] = value;
			}
			VertexSort(0, m.invertices - 1);
			num = 0;
			for (int i = 1; i < m.invertices; i++)
			{
				if (sortarray[num].x == sortarray[i].x && sortarray[num].y == sortarray[i].y)
				{
					if (Behavior.Verbose)
					{
						SimpleLog.Instance.Warning($"A duplicate vertex appeared and was ignored (ID {sortarray[i].hash}).", "DivConquer.DivconqDelaunay()");
					}
					sortarray[i].type = VertexType.UndeadVertex;
					m.undeads++;
				}
				else
				{
					num++;
					sortarray[num] = sortarray[i];
				}
			}
			num++;
			if (useDwyer)
			{
				int num2 = num >> 1;
				if (num - num2 >= 2)
				{
					if (num2 >= 2)
					{
						AlternateAxes(0, num2 - 1, 1);
					}
					AlternateAxes(num2, num - 1, 1);
				}
			}
			DivconqRecurse(0, num - 1, 0, ref farleft, ref farright);
			return RemoveGhosts(ref farleft);
		}
	}
	internal class Incremental
	{
		private Mesh mesh;

		private void GetBoundingBox()
		{
			Otri newotri = default(Otri);
			BoundingBox bounds = mesh.bounds;
			double num = bounds.Width;
			if (bounds.Height > num)
			{
				num = bounds.Height;
			}
			if (num == 0.0)
			{
				num = 1.0;
			}
			mesh.infvertex1 = new Vertex(bounds.MinX - 50.0 * num, bounds.MinY - 40.0 * num);
			mesh.infvertex2 = new Vertex(bounds.MaxX + 50.0 * num, bounds.MinY - 40.0 * num);
			mesh.infvertex3 = new Vertex(0.5 * (bounds.MinX + bounds.MaxX), bounds.MaxY + 60.0 * num);
			mesh.MakeTriangle(ref newotri);
			newotri.SetOrg(mesh.infvertex1);
			newotri.SetDest(mesh.infvertex2);
			newotri.SetApex(mesh.infvertex3);
			Mesh.dummytri.neighbors[0] = newotri;
		}

		private int RemoveBox()
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Otri o4 = default(Otri);
			Otri o5 = default(Otri);
			Otri o6 = default(Otri);
			bool flag = !mesh.behavior.Poly;
			o4.triangle = Mesh.dummytri;
			o4.orient = 0;
			o4.SymSelf();
			o4.Lprev(ref o5);
			o4.LnextSelf();
			o4.SymSelf();
			o4.Lprev(ref o2);
			o2.SymSelf();
			o4.Lnext(ref o3);
			o3.SymSelf();
			if (o3.triangle == Mesh.dummytri)
			{
				o2.LprevSelf();
				o2.SymSelf();
			}
			Mesh.dummytri.neighbors[0] = o2;
			int num = -2;
			while (!o4.Equal(o5))
			{
				num++;
				o4.Lprev(ref o6);
				o6.SymSelf();
				if (flag && o6.triangle != Mesh.dummytri)
				{
					Vertex vertex = o6.Org();
					if (vertex.mark == 0)
					{
						vertex.mark = 1;
					}
				}
				o6.Dissolve();
				o4.Lnext(ref o);
				o.Sym(ref o4);
				mesh.TriangleDealloc(o.triangle);
				if (o4.triangle == Mesh.dummytri)
				{
					o6.Copy(ref o4);
				}
			}
			mesh.TriangleDealloc(o5.triangle);
			return num;
		}

		public int Triangulate(Mesh mesh)
		{
			this.mesh = mesh;
			Otri searchtri = default(Otri);
			GetBoundingBox();
			foreach (Vertex value in mesh.vertices.Values)
			{
				searchtri.triangle = Mesh.dummytri;
				Osub splitseg = default(Osub);
				if (mesh.InsertVertex(value, ref searchtri, ref splitseg, segmentflaws: false, triflaws: false) == InsertVertexResult.Duplicate)
				{
					if (Behavior.Verbose)
					{
						SimpleLog.Instance.Warning("A duplicate vertex appeared and was ignored.", "Incremental.IncrementalDelaunay()");
					}
					value.type = VertexType.UndeadVertex;
					mesh.undeads++;
				}
			}
			return RemoveBox();
		}
	}
	internal class SweepLine
	{
		private class SweepEvent
		{
			public double xkey;

			public double ykey;

			public Vertex vertexEvent;

			public Otri otriEvent;

			public int heapposition;
		}

		private class SweepEventVertex : Vertex
		{
			public SweepEvent evt;

			public SweepEventVertex(SweepEvent e)
			{
				evt = e;
			}
		}

		private class SplayNode
		{
			public Otri keyedge;

			public Vertex keydest;

			public SplayNode lchild;

			public SplayNode rchild;
		}

		private static int randomseed = 1;

		private static int SAMPLERATE = 10;

		private Mesh mesh;

		private double xminextreme;

		private List<SplayNode> splaynodes;

		private int randomnation(int choices)
		{
			randomseed = (randomseed * 1366 + 150889) % 714025;
			return randomseed / (714025 / choices + 1);
		}

		private void HeapInsert(SweepEvent[] heap, int heapsize, SweepEvent newevent)
		{
			double xkey = newevent.xkey;
			double ykey = newevent.ykey;
			int num = heapsize;
			bool flag = num > 0;
			while (flag)
			{
				int num2 = num - 1 >> 1;
				if (heap[num2].ykey < ykey || (heap[num2].ykey == ykey && heap[num2].xkey <= xkey))
				{
					flag = false;
					continue;
				}
				heap[num] = heap[num2];
				heap[num].heapposition = num;
				num = num2;
				flag = num > 0;
			}
			heap[num] = newevent;
			newevent.heapposition = num;
		}

		private void Heapify(SweepEvent[] heap, int heapsize, int eventnum)
		{
			SweepEvent sweepEvent = heap[eventnum];
			double xkey = sweepEvent.xkey;
			double ykey = sweepEvent.ykey;
			int num = 2 * eventnum + 1;
			bool flag = num < heapsize;
			while (flag)
			{
				int num2 = ((!(heap[num].ykey < ykey) && (heap[num].ykey != ykey || !(heap[num].xkey < xkey))) ? eventnum : num);
				int num3 = num + 1;
				if (num3 < heapsize && (heap[num3].ykey < heap[num2].ykey || (heap[num3].ykey == heap[num2].ykey && heap[num3].xkey < heap[num2].xkey)))
				{
					num2 = num3;
				}
				if (num2 == eventnum)
				{
					flag = false;
					continue;
				}
				heap[eventnum] = heap[num2];
				heap[eventnum].heapposition = eventnum;
				heap[num2] = sweepEvent;
				sweepEvent.heapposition = num2;
				eventnum = num2;
				num = 2 * eventnum + 1;
				flag = num < heapsize;
			}
		}

		private void HeapDelete(SweepEvent[] heap, int heapsize, int eventnum)
		{
			SweepEvent sweepEvent = heap[heapsize - 1];
			if (eventnum > 0)
			{
				double xkey = sweepEvent.xkey;
				double ykey = sweepEvent.ykey;
				bool flag;
				do
				{
					int num = eventnum - 1 >> 1;
					if (heap[num].ykey < ykey || (heap[num].ykey == ykey && heap[num].xkey <= xkey))
					{
						flag = false;
						continue;
					}
					heap[eventnum] = heap[num];
					heap[eventnum].heapposition = eventnum;
					eventnum = num;
					flag = eventnum > 0;
				}
				while (flag);
			}
			heap[eventnum] = sweepEvent;
			sweepEvent.heapposition = eventnum;
			Heapify(heap, heapsize - 1, eventnum);
		}

		private void CreateHeap(out SweepEvent[] eventheap)
		{
			int num = 3 * mesh.invertices / 2;
			eventheap = new SweepEvent[num];
			int num2 = 0;
			foreach (Vertex value in mesh.vertices.Values)
			{
				SweepEvent sweepEvent = new SweepEvent();
				sweepEvent.vertexEvent = value;
				sweepEvent.xkey = value.x;
				sweepEvent.ykey = value.y;
				HeapInsert(eventheap, num2++, sweepEvent);
			}
		}

		private SplayNode Splay(SplayNode splaytree, Point searchpoint, ref Otri searchtri)
		{
			if (splaytree == null)
			{
				return null;
			}
			if (splaytree.keyedge.Dest() == splaytree.keydest)
			{
				bool flag = RightOfHyperbola(ref splaytree.keyedge, searchpoint);
				SplayNode splayNode;
				if (flag)
				{
					splaytree.keyedge.Copy(ref searchtri);
					splayNode = splaytree.rchild;
				}
				else
				{
					splayNode = splaytree.lchild;
				}
				if (splayNode == null)
				{
					return splaytree;
				}
				if (splayNode.keyedge.Dest() != splayNode.keydest)
				{
					splayNode = Splay(splayNode, searchpoint, ref searchtri);
					if (splayNode == null)
					{
						if (flag)
						{
							splaytree.rchild = null;
						}
						else
						{
							splaytree.lchild = null;
						}
						return splaytree;
					}
				}
				bool flag2 = RightOfHyperbola(ref splayNode.keyedge, searchpoint);
				SplayNode splayNode2;
				if (!flag2)
				{
					splayNode2 = (splayNode.lchild = Splay(splayNode.lchild, searchpoint, ref searchtri));
				}
				else
				{
					splayNode.keyedge.Copy(ref searchtri);
					splayNode2 = (splayNode.rchild = Splay(splayNode.rchild, searchpoint, ref searchtri));
				}
				if (splayNode2 == null)
				{
					if (flag)
					{
						splaytree.rchild = splayNode.lchild;
						splayNode.lchild = splaytree;
					}
					else
					{
						splaytree.lchild = splayNode.rchild;
						splayNode.rchild = splaytree;
					}
					return splayNode;
				}
				if (flag2)
				{
					if (flag)
					{
						splaytree.rchild = splayNode.lchild;
						splayNode.lchild = splaytree;
					}
					else
					{
						splaytree.lchild = splayNode2.rchild;
						splayNode2.rchild = splaytree;
					}
					splayNode.rchild = splayNode2.lchild;
					splayNode2.lchild = splayNode;
				}
				else
				{
					if (flag)
					{
						splaytree.rchild = splayNode2.lchild;
						splayNode2.lchild = splaytree;
					}
					else
					{
						splaytree.lchild = splayNode.rchild;
						splayNode.rchild = splaytree;
					}
					splayNode.lchild = splayNode2.rchild;
					splayNode2.rchild = splayNode;
				}
				return splayNode2;
			}
			SplayNode splayNode3 = Splay(splaytree.lchild, searchpoint, ref searchtri);
			SplayNode splayNode4 = Splay(splaytree.rchild, searchpoint, ref searchtri);
			splaynodes.Remove(splaytree);
			if (splayNode3 == null)
			{
				return splayNode4;
			}
			if (splayNode4 == null)
			{
				return splayNode3;
			}
			if (splayNode3.rchild == null)
			{
				splayNode3.rchild = splayNode4.lchild;
				splayNode4.lchild = splayNode3;
				return splayNode4;
			}
			if (splayNode4.lchild == null)
			{
				splayNode4.lchild = splayNode3.rchild;
				splayNode3.rchild = splayNode4;
				return splayNode3;
			}
			SplayNode rchild = splayNode3.rchild;
			while (rchild.rchild != null)
			{
				rchild = rchild.rchild;
			}
			rchild.rchild = splayNode4;
			return splayNode3;
		}

		private SplayNode SplayInsert(SplayNode splayroot, Otri newkey, Point searchpoint)
		{
			SplayNode splayNode = new SplayNode();
			splaynodes.Add(splayNode);
			newkey.Copy(ref splayNode.keyedge);
			splayNode.keydest = newkey.Dest();
			if (splayroot == null)
			{
				splayNode.lchild = null;
				splayNode.rchild = null;
			}
			else if (RightOfHyperbola(ref splayroot.keyedge, searchpoint))
			{
				splayNode.lchild = splayroot;
				splayNode.rchild = splayroot.rchild;
				splayroot.rchild = null;
			}
			else
			{
				splayNode.lchild = splayroot.lchild;
				splayNode.rchild = splayroot;
				splayroot.lchild = null;
			}
			return splayNode;
		}

		private SplayNode FrontLocate(SplayNode splayroot, Otri bottommost, Vertex searchvertex, ref Otri searchtri, ref bool farright)
		{
			bottommost.Copy(ref searchtri);
			splayroot = Splay(splayroot, searchvertex, ref searchtri);
			bool flag = false;
			while (!flag && RightOfHyperbola(ref searchtri, searchvertex))
			{
				searchtri.OnextSelf();
				flag = searchtri.Equal(bottommost);
			}
			farright = flag;
			return splayroot;
		}

		private SplayNode CircleTopInsert(SplayNode splayroot, Otri newkey, Vertex pa, Vertex pb, Vertex pc, double topy)
		{
			Point point = new Point();
			Otri searchtri = default(Otri);
			double num = Primitives.CounterClockwise(pa, pb, pc);
			double num2 = pa.x - pc.x;
			double num3 = pa.y - pc.y;
			double num4 = pb.x - pc.x;
			double num5 = pb.y - pc.y;
			double num6 = num2 * num2 + num3 * num3;
			double num7 = num4 * num4 + num5 * num5;
			point.x = pc.x - (num3 * num7 - num5 * num6) / (2.0 * num);
			point.y = topy;
			return SplayInsert(Splay(splayroot, point, ref searchtri), newkey, point);
		}

		private bool RightOfHyperbola(ref Otri fronttri, Point newsite)
		{
			Statistic.HyperbolaCount++;
			Vertex vertex = fronttri.Dest();
			Vertex vertex2 = fronttri.Apex();
			if (vertex.y < vertex2.y || (vertex.y == vertex2.y && vertex.x < vertex2.x))
			{
				if (newsite.x >= vertex2.x)
				{
					return true;
				}
			}
			else if (newsite.x <= vertex.x)
			{
				return false;
			}
			double num = vertex.x - newsite.x;
			double num2 = vertex.y - newsite.y;
			double num3 = vertex2.x - newsite.x;
			double num4 = vertex2.y - newsite.y;
			return num2 * (num3 * num3 + num4 * num4) > num4 * (num * num + num2 * num2);
		}

		private double CircleTop(Vertex pa, Vertex pb, Vertex pc, double ccwabc)
		{
			Statistic.CircleTopCount++;
			double num = pa.x - pc.x;
			double num2 = pa.y - pc.y;
			double num3 = pb.x - pc.x;
			double num4 = pb.y - pc.y;
			double num5 = pa.x - pb.x;
			double num6 = pa.y - pb.y;
			double num7 = num * num + num2 * num2;
			double num8 = num3 * num3 + num4 * num4;
			double num9 = num5 * num5 + num6 * num6;
			return pc.y + (num * num8 - num3 * num7 + Math.Sqrt(num7 * num8 * num9)) / (2.0 * ccwabc);
		}

		private void Check4DeadEvent(ref Otri checktri, SweepEvent[] eventheap, ref int heapsize)
		{
			int num = -1;
			SweepEventVertex sweepEventVertex = checktri.Org() as SweepEventVertex;
			if (sweepEventVertex != null)
			{
				num = sweepEventVertex.evt.heapposition;
				HeapDelete(eventheap, heapsize, num);
				heapsize--;
				checktri.SetOrg(null);
			}
		}

		private int RemoveGhosts(ref Otri startghost)
		{
			Otri o = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			bool flag = !mesh.behavior.Poly;
			startghost.Lprev(ref o);
			o.SymSelf();
			Mesh.dummytri.neighbors[0] = o;
			startghost.Copy(ref o2);
			int num = 0;
			do
			{
				num++;
				o2.Lnext(ref o3);
				o2.LprevSelf();
				o2.SymSelf();
				if (flag && o2.triangle != Mesh.dummytri)
				{
					Vertex vertex = o2.Org();
					if (vertex.mark == 0)
					{
						vertex.mark = 1;
					}
				}
				o2.Dissolve();
				o3.Sym(ref o2);
				mesh.TriangleDealloc(o3.triangle);
			}
			while (!o2.Equal(startghost));
			return num;
		}

		public int Triangulate(Mesh mesh)
		{
			this.mesh = mesh;
			xminextreme = 10.0 * mesh.bounds.MinX - 9.0 * mesh.bounds.MaxX;
			Otri o = default(Otri);
			Otri searchtri = default(Otri);
			Otri newotri = default(Otri);
			Otri newotri2 = default(Otri);
			Otri o2 = default(Otri);
			Otri o3 = default(Otri);
			Otri o4 = default(Otri);
			bool farright = false;
			splaynodes = new List<SplayNode>();
			SplayNode splayroot = null;
			CreateHeap(out var eventheap);
			int invertices = mesh.invertices;
			mesh.MakeTriangle(ref newotri);
			mesh.MakeTriangle(ref newotri2);
			newotri.Bond(ref newotri2);
			newotri.LnextSelf();
			newotri2.LprevSelf();
			newotri.Bond(ref newotri2);
			newotri.LnextSelf();
			newotri2.LprevSelf();
			newotri.Bond(ref newotri2);
			Vertex vertexEvent = eventheap[0].vertexEvent;
			HeapDelete(eventheap, invertices, 0);
			invertices--;
			Vertex vertexEvent2;
			do
			{
				if (invertices == 0)
				{
					SimpleLog.Instance.Error("Input vertices are all identical.", "SweepLine.Triangulate()");
					throw new Exception("Input vertices are all identical.");
				}
				vertexEvent2 = eventheap[0].vertexEvent;
				HeapDelete(eventheap, invertices, 0);
				invertices--;
				if (vertexEvent.x == vertexEvent2.x && vertexEvent.y == vertexEvent2.y)
				{
					if (Behavior.Verbose)
					{
						SimpleLog.Instance.Warning("A duplicate vertex appeared and was ignored (ID " + vertexEvent2.id + ").", "SweepLine.Triangulate().1");
					}
					vertexEvent2.type = VertexType.UndeadVertex;
					mesh.undeads++;
				}
			}
			while (vertexEvent.x == vertexEvent2.x && vertexEvent.y == vertexEvent2.y);
			newotri.SetOrg(vertexEvent);
			newotri.SetDest(vertexEvent2);
			newotri2.SetOrg(vertexEvent2);
			newotri2.SetDest(vertexEvent);
			newotri.Lprev(ref o);
			Vertex vertex = vertexEvent2;
			while (invertices > 0)
			{
				SweepEvent sweepEvent = eventheap[0];
				HeapDelete(eventheap, invertices, 0);
				invertices--;
				bool flag = true;
				if (sweepEvent.xkey < mesh.bounds.MinX)
				{
					Otri flipedge = sweepEvent.otriEvent;
					flipedge.Oprev(ref o2);
					Check4DeadEvent(ref o2, eventheap, ref invertices);
					flipedge.Onext(ref o3);
					Check4DeadEvent(ref o3, eventheap, ref invertices);
					if (o2.Equal(o))
					{
						flipedge.Lprev(ref o);
					}
					mesh.Flip(ref flipedge);
					flipedge.SetApex(null);
					flipedge.Lprev(ref newotri);
					flipedge.Lnext(ref newotri2);
					newotri.Sym(ref o2);
					if (randomnation(SAMPLERATE) == 0)
					{
						flipedge.SymSelf();
						Vertex pa = flipedge.Dest();
						Vertex pb = flipedge.Apex();
						Vertex pc = flipedge.Org();
						splayroot = CircleTopInsert(splayroot, newotri, pa, pb, pc, sweepEvent.ykey);
					}
				}
				else
				{
					Vertex vertexEvent3 = sweepEvent.vertexEvent;
					if (vertexEvent3.x == vertex.x && vertexEvent3.y == vertex.y)
					{
						if (Behavior.Verbose)
						{
							SimpleLog.Instance.Warning("A duplicate vertex appeared and was ignored (ID " + vertexEvent3.id + ").", "SweepLine.Triangulate().2");
						}
						vertexEvent3.type = VertexType.UndeadVertex;
						mesh.undeads++;
						flag = false;
					}
					else
					{
						vertex = vertexEvent3;
						splayroot = FrontLocate(splayroot, o, vertexEvent3, ref searchtri, ref farright);
						Check4DeadEvent(ref searchtri, eventheap, ref invertices);
						searchtri.Copy(ref o3);
						searchtri.Sym(ref o2);
						mesh.MakeTriangle(ref newotri);
						mesh.MakeTriangle(ref newotri2);
						Vertex vertex2 = o3.Dest();
						newotri.SetOrg(vertex2);
						newotri.SetDest(vertexEvent3);
						newotri2.SetOrg(vertexEvent3);
						newotri2.SetDest(vertex2);
						newotri.Bond(ref newotri2);
						newotri.LnextSelf();
						newotri2.LprevSelf();
						newotri.Bond(ref newotri2);
						newotri.LnextSelf();
						newotri2.LprevSelf();
						newotri.Bond(ref o2);
						newotri2.Bond(ref o3);
						if (!farright && o3.Equal(o))
						{
							newotri.Copy(ref o);
						}
						if (randomnation(SAMPLERATE) == 0)
						{
							splayroot = SplayInsert(splayroot, newotri, vertexEvent3);
						}
						else if (randomnation(SAMPLERATE) == 0)
						{
							newotri2.Lnext(ref o4);
							splayroot = SplayInsert(splayroot, o4, vertexEvent3);
						}
					}
				}
				if (flag)
				{
					Vertex pa = o2.Apex();
					Vertex pb = newotri.Dest();
					Vertex pc = newotri.Apex();
					double num = Primitives.CounterClockwise(pa, pb, pc);
					if (num > 0.0)
					{
						SweepEvent sweepEvent2 = new SweepEvent();
						sweepEvent2.xkey = xminextreme;
						sweepEvent2.ykey = CircleTop(pa, pb, pc, num);
						sweepEvent2.otriEvent = newotri;
						HeapInsert(eventheap, invertices, sweepEvent2);
						invertices++;
						newotri.SetOrg(new SweepEventVertex(sweepEvent2));
					}
					pa = newotri2.Apex();
					pb = newotri2.Org();
					pc = o3.Apex();
					double num2 = Primitives.CounterClockwise(pa, pb, pc);
					if (num2 > 0.0)
					{
						SweepEvent sweepEvent2 = new SweepEvent();
						sweepEvent2.xkey = xminextreme;
						sweepEvent2.ykey = CircleTop(pa, pb, pc, num2);
						sweepEvent2.otriEvent = o3;
						HeapInsert(eventheap, invertices, sweepEvent2);
						invertices++;
						o3.SetOrg(new SweepEventVertex(sweepEvent2));
					}
				}
			}
			splaynodes.Clear();
			o.LprevSelf();
			return RemoveGhosts(ref o);
		}
	}
}
