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
			[Cpp2IlInjected.Address(RVA = "0x9748010", Offset = "0x9747410", VA = "0x189748010")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4FAE0", Offset = "0xE4EEE0", VA = "0x180E4FAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9744E50", Offset = "0x9744250", VA = "0x189744E50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9746980", Offset = "0x9745D80", VA = "0x189746980")]
		public bool NACPCLWCYOG([In] NativeArray<float3> points, NativeList<float3> a, NativeList<int> b, Allocator c, CancellationToken d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9745760", Offset = "0x9744B60", VA = "0x189745760")]
		private void Initialize([In] NativeArray<float3> points, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9745930", Offset = "0x9744D30", VA = "0x189745930")]
		private void KVKPSCXAWMA([In] NativeArray<float3> points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9747690", Offset = "0x9746A90", VA = "0x189747690")]
		private void USFVRIPJHOF([In] NativeArray<float3> points, [Out] int a, [Out] int b, [Out] int c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9744B20", Offset = "0x9743F20", VA = "0x189744B20")]
		private void DSPLBQHMIQS([In] NativeArray<float3> points, Allocator a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9745280", Offset = "0x9744680", VA = "0x189745280")]
		private void IWXZNISMTHC([In] NativeArray<float3> points, float3 a, int b, Face c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9744730", Offset = "0x9743B30", VA = "0x189744730")]
		private void DECLMXAZRSZ([In] NativeArray<float3> points, float3 a, int b, int c, Face d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9746AC0", Offset = "0x9745EC0", VA = "0x189746AC0")]
		private void PEGEJXQMJZK([In] NativeArray<float3> points, int a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9747B40", Offset = "0x9746F40", VA = "0x189747B40")]
		private void UYLFXYKVXBX([In] NativeArray<float3> points, Allocator a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x97471C0", Offset = "0x97465C0", VA = "0x1897471C0")]
		private void SOIAZJJKFQX([In] NativeArray<float3> points, NativeList<float3> a, NativeList<int> b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9747F80", Offset = "0x9747380", VA = "0x189747F80")]
		private float YBFXSEOMKTQ(float3 a, float3 b, Face c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9742E60", Offset = "0x9742260", VA = "0x189742E60")]
		private float3 Normal(float3 v0, float3 v1, float3 v2)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9747FE0", Offset = "0x97473E0", VA = "0x189747FE0")]
		private static float ZKPGJMUDKMF(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9746920", Offset = "0x9745D20", VA = "0x189746920")]
		private static float3 MOQOWROXZMS(float3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9744600", Offset = "0x9743A00", VA = "0x189744600")]
		private bool BGZWYYNDQKY(float3 a, float3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9744660", Offset = "0x9743A60", VA = "0x189744660")]
		private bool CJTTMFKORWL(float3 a, float3 b, float3 c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9744F70", Offset = "0x9744370", VA = "0x189744F70")]
		private bool FXYUMBGVNOW(float3 a, float3 b, float3 c, float3 d)
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
		public int YZQCGXALXTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9743C40", Offset = "0x9743040", VA = "0x189743C40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int FDHYRWYTHHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9743E40", Offset = "0x9743240", VA = "0x189743E40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool LRUHMFXBSGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9743E90", Offset = "0x9743290", VA = "0x189743E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public CollisionMeshMetrics SFFUGCIPTBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9743ED0", Offset = "0x97432D0", VA = "0x189743ED0")]
			get
			{
				return default(CollisionMeshMetrics);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9744290", Offset = "0x9743690", VA = "0x189744290")]
		public CollisionMeshData(int vertexCount, int indexCount, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9744260", Offset = "0x9743660", VA = "0x189744260")]
		public CollisionMeshData(CollisionMeshMetrics metrics, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9744350", Offset = "0x9743750", VA = "0x189744350")]
		public CollisionMeshData(Mesh mesh, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9743F70", Offset = "0x9743370", VA = "0x189743F70")]
		public CollisionMeshData(CollisionMeshData data, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9743350", Offset = "0x9742750", VA = "0x189743350", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9742F70", Offset = "0x9742370", VA = "0x189742F70")]
		public void Add([In] CollisionMeshData source, float4x4 localToWorld, Transform rootTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9743AF0", Offset = "0x9742EF0", VA = "0x189743AF0")]
		public void LSPBWADSGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x97433D0", Offset = "0x97427D0", VA = "0x1897433D0")]
		public void EGCAFLFCBDH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x97438D0", Offset = "0x9742CD0", VA = "0x1897438D0")]
		public CollisionMeshData JRERJXVKWJM(Allocator a, CancellationToken b)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9743C90", Offset = "0x9743090", VA = "0x189743C90")]
		public Mesh RJVQIWNRCWS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9743DF0", Offset = "0x97431F0", VA = "0x189743DF0")]
		private unsafe static float3* SQDKFUKCKQU(NativeArray<float3> a)
		{
			//IL_0002: Expected I, but got O
			return (float3*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9743DA0", Offset = "0x97431A0", VA = "0x189743DA0")]
		private unsafe static int* SQDKFUKCKQU(NativeArray<int> a)
		{
			//IL_0002: Expected I, but got O
			return (int*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9743AC0", Offset = "0x9742EC0", VA = "0x189743AC0")]
		[CompilerGenerated]
		internal static void KORLRHFSYJV(int a, int b, <>c__DisplayClass21_0 c)
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
		public int YLXWNHGTFNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9744560", Offset = "0x9743960", VA = "0x189744560")]
			get
			{
				return default(int);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2A1C640", Offset = "0x2A1BA40", VA = "0x182A1C640")]
		public static CollisionMeshMetrics ULQKOYUIQVA(CollisionMeshMetrics a, CollisionMeshMetrics b)
		{
			return default(CollisionMeshMetrics);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x97444C0", Offset = "0x97438C0", VA = "0x1897444C0")]
		public static CollisionMeshMetrics EGFDVQQHWZQ(CollisionMeshMetrics a, int b)
		{
			return default(CollisionMeshMetrics);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x97444E0", Offset = "0x97438E0", VA = "0x1897444E0", Slot = "0")]
		public override bool Equals(object that)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9744520", Offset = "0x9743920", VA = "0x189744520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9744570", Offset = "0x9743970", VA = "0x189744570", Slot = "3")]
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
