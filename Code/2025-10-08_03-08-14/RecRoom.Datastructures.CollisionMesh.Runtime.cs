using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace GK
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public struct ConvexHullCalculator : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct Face
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int Vertex0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int Vertex1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public int Vertex2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public int Opposite0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int Opposite1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int Opposite2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public float3 Normal;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8549520", Offset = "0x8548320", VA = "0x188549520")]
			public Face(int v0, int v1, int v2, int o0, int o1, int o2, float3 normal)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct PointFace
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int Point;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int Face;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float Distance;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xE5FD00", Offset = "0xE5EB00", VA = "0x180E5FD00")]
			public PointFace(int p, int f, float d)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct HorizonEdge
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public int Face;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int Edge0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public int Edge1;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private NativeParallelHashMap<int, Face> faces;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeList<PointFace> openSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private NativeParallelHashMap<int, int> litFaces;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeList<HorizonEdge> horizon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeParallelHashMap<int, int> hullVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int openSetTail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int faceCount;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8545B10", Offset = "0x8544910", VA = "0x188545B10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8547B50", Offset = "0x8546950", VA = "0x188547B50")]
		public bool PPDHLZHHTZJ([In] NativeArray<float3> points, NativeList<float3> a, NativeList<int> b, Allocator c, CancellationToken d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8546A40", Offset = "0x8545840", VA = "0x188546A40")]
		private void Initialize([In] NativeArray<float3> points, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85480F0", Offset = "0x8546EF0", VA = "0x1885480F0")]
		private void SHZDUNPDJVV([In] NativeArray<float3> points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85461A0", Offset = "0x8544FA0", VA = "0x1885461A0")]
		private void IOJBVUYDGHO([In] NativeArray<float3> points, [Out] int a, [Out] int b, [Out] int c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8547C90", Offset = "0x8546A90", VA = "0x188547C90")]
		private void QPSUCNSLFBN([In] NativeArray<float3> points, Allocator a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8545C30", Offset = "0x8544A30", VA = "0x188545C30")]
		private void FQFRCZCKRVJ([In] NativeArray<float3> points, float3 a, int b, Face c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8546650", Offset = "0x8545450", VA = "0x188546650")]
		private void IYXHKMNNUNQ([In] NativeArray<float3> points, float3 a, int b, int c, Face d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8546C70", Offset = "0x8545A70", VA = "0x188546C70")]
		private void NYQQGROCKJR([In] NativeArray<float3> points, int a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85490E0", Offset = "0x8547EE0", VA = "0x1885490E0")]
		private void XFHTUSWNRCU([In] NativeArray<float3> points, Allocator a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8547680", Offset = "0x8546480", VA = "0x188547680")]
		private void OZOIBJEZQXY([In] NativeArray<float3> points, NativeList<float3> a, NativeList<int> b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8547FC0", Offset = "0x8546DC0", VA = "0x188547FC0")]
		private float RRWRXFFGXJH(float3 a, float3 b, Face c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8544060", Offset = "0x8542E60", VA = "0x188544060")]
		private float3 Normal(float3 v0, float3 v1, float3 v2)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8546110", Offset = "0x8544F10", VA = "0x188546110")]
		private static float GIAKRYPYLYG(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8546140", Offset = "0x8544F40", VA = "0x188546140")]
		private static float3 IFGRFOOGYXP(float3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8546C10", Offset = "0x8545A10", VA = "0x188546C10")]
		private bool NKVLHLRZQYT(float3 a, float3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8548020", Offset = "0x8546E20", VA = "0x188548020")]
		private bool RTIAUYZFRXY(float3 a, float3 b, float3 c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8547370", Offset = "0x8546170", VA = "0x188547370")]
		private bool OBHDDJKWHOV(float3 a, float3 b, float3 c, float3 d)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct CollisionMeshData : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <>c__DisplayClass21_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public unsafe int* indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int indexCount;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NativeList<float3> Vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NativeList<int> Indices;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int IQNKBHRENQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8545390", Offset = "0x8544190", VA = "0x188545390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int SUEXAPIXEIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8544860", Offset = "0x8543660", VA = "0x188544860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DGRJVBSKFAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8544BC0", Offset = "0x85439C0", VA = "0x188544BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public CollisionMeshMetrics PIUTLRNWCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x85452F0", Offset = "0x85440F0", VA = "0x1885452F0")]
			get
			{
				return default(CollisionMeshMetrics);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85457A0", Offset = "0x85445A0", VA = "0x1885457A0")]
		public CollisionMeshData(int vertexCount, int indexCount, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8545770", Offset = "0x8544570", VA = "0x188545770")]
		public CollisionMeshData(CollisionMeshMetrics metrics, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8545860", Offset = "0x8544660", VA = "0x188545860")]
		public CollisionMeshData(Mesh mesh, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8545480", Offset = "0x8544280", VA = "0x188545480")]
		public CollisionMeshData(CollisionMeshData data, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85448B0", Offset = "0x85436B0", VA = "0x1885448B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8544480", Offset = "0x8543280", VA = "0x188544480")]
		public void Add([In] CollisionMeshData source, float4x4 localToWorld, Transform rootTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8544A70", Offset = "0x8543870", VA = "0x188544A70")]
		public void NQLQGWDAAKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8544C00", Offset = "0x8543A00", VA = "0x188544C00")]
		public void RVXPKVPGDXO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8545100", Offset = "0x8543F00", VA = "0x188545100")]
		public CollisionMeshData TUOKKXDHGIN(Allocator a, CancellationToken b)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8544960", Offset = "0x8543760", VA = "0x188544960")]
		public Mesh KTQXJUQMSZZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8545430", Offset = "0x8544230", VA = "0x188545430")]
		private unsafe static float3* ZLKIZNMXFNH(NativeArray<float3> a)
		{
			//IL_0002: Expected I, but got O
			return (float3*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85453E0", Offset = "0x85441E0", VA = "0x1885453E0")]
		private unsafe static int* ZLKIZNMXFNH(NativeArray<int> a)
		{
			//IL_0002: Expected I, but got O
			return (int*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8544930", Offset = "0x8543730", VA = "0x188544930")]
		[CompilerGenerated]
		internal static void FKVBQXBWQTI(int a, int b, <>c__DisplayClass21_0 c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct CollisionMeshMetrics
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int VertexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int IndexCount;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int PGVHDCTRICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8545A70", Offset = "0x8544870", VA = "0x188545A70")]
			get
			{
				return default(int);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2983650", Offset = "0x2982450", VA = "0x182983650")]
		public static CollisionMeshMetrics IEBXCIUBRCZ(CollisionMeshMetrics a, CollisionMeshMetrics b)
		{
			return default(CollisionMeshMetrics);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8545A50", Offset = "0x8544850", VA = "0x188545A50")]
		public static CollisionMeshMetrics ITYRJVXTIEF(CollisionMeshMetrics a, int b)
		{
			return default(CollisionMeshMetrics);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85459D0", Offset = "0x85447D0", VA = "0x1885459D0", Slot = "0")]
		public override bool Equals(object that)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8545A10", Offset = "0x8544810", VA = "0x188545A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8545A80", Offset = "0x8544880", VA = "0x188545A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
