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
			[Cpp2IlInjected.Address(RVA = "0x8240620", Offset = "0x823FA20", VA = "0x188240620")]
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
			[Cpp2IlInjected.Address(RVA = "0xB3CC00", Offset = "0xB3C000", VA = "0x180B3CC00")]
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
		[Cpp2IlInjected.Address(RVA = "0x823D620", Offset = "0x823CA20", VA = "0x18823D620", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8240030", Offset = "0x823F430", VA = "0x188240030")]
		public bool VMQLKZRBMMK([In] NativeArray<float3> points, NativeList<float3> a, NativeList<int> b, Allocator c, CancellationToken d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x823DB20", Offset = "0x823CF20", VA = "0x18823DB20")]
		private void Initialize([In] NativeArray<float3> points, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x823F040", Offset = "0x823E440", VA = "0x18823F040")]
		private void VHLTPNWGWIQ([In] NativeArray<float3> points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x823E160", Offset = "0x823D560", VA = "0x18823E160")]
		private void MLWCRYXKTLT([In] NativeArray<float3> points, [Out] int a, [Out] int b, [Out] int c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x823ED10", Offset = "0x823E110", VA = "0x18823ED10")]
		private void UBFHGEMXVUW([In] NativeArray<float3> points, Allocator a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x823D140", Offset = "0x823C540", VA = "0x18823D140")]
		private void CUNVESOQNEA([In] NativeArray<float3> points, float3 a, int b, Face c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8240230", Offset = "0x823F630", VA = "0x188240230")]
		private void YHXEEQVBBMN([In] NativeArray<float3> points, float3 a, int b, int c, Face d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x823E610", Offset = "0x823DA10", VA = "0x18823E610")]
		private void PLHMODPFKVO([In] NativeArray<float3> points, int a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x823DCF0", Offset = "0x823D0F0", VA = "0x18823DCF0")]
		private void JOMRKXWBJXL([In] NativeArray<float3> points, Allocator a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x823CC10", Offset = "0x823C010", VA = "0x18823CC10")]
		private void AFYANISWZLR([In] NativeArray<float3> points, NativeList<float3> a, NativeList<int> b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82401D0", Offset = "0x823F5D0", VA = "0x1882401D0")]
		private float XOFJNOGUBKG(float3 a, float3 b, Face c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x823B470", Offset = "0x823A870", VA = "0x18823B470")]
		private float3 Normal(float3 v0, float3 v1, float3 v2)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x823E130", Offset = "0x823D530", VA = "0x18823E130")]
		private static float LMWYCSMGGJT(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x823D0E0", Offset = "0x823C4E0", VA = "0x18823D0E0")]
		private static float3 ARYINTUFQHQ(float3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8240170", Offset = "0x823F570", VA = "0x188240170")]
		private bool WJFVEVGQTXK(float3 a, float3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x823DA50", Offset = "0x823CE50", VA = "0x18823DA50")]
		private bool GQDWRVONFTJ(float3 a, float3 b, float3 c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x823D740", Offset = "0x823CB40", VA = "0x18823D740")]
		private bool FVABRVIWKLQ(float3 a, float3 b, float3 c, float3 d)
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
		public int RGACUWQPXAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x823BC70", Offset = "0x823B070", VA = "0x18823BC70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int QKGLHRTPCMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x823C530", Offset = "0x823B930", VA = "0x18823C530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool SBDFDLHCDRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x823BCF0", Offset = "0x823B0F0", VA = "0x18823BCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public CollisionMeshMetrics AJKQSNUGPDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x823BD30", Offset = "0x823B130", VA = "0x18823BD30")]
			get
			{
				return default(CollisionMeshMetrics);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x823C8A0", Offset = "0x823BCA0", VA = "0x18823C8A0")]
		public CollisionMeshData(int vertexCount, int indexCount, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x823C870", Offset = "0x823BC70", VA = "0x18823C870")]
		public CollisionMeshData(CollisionMeshMetrics metrics, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x823C960", Offset = "0x823BD60", VA = "0x18823C960")]
		public CollisionMeshData(Mesh mesh, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x823C580", Offset = "0x823B980", VA = "0x18823C580")]
		public CollisionMeshData(CollisionMeshData data, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x823BB50", Offset = "0x823AF50", VA = "0x18823BB50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x823B580", Offset = "0x823A980", VA = "0x18823B580")]
		public void Add([In] CollisionMeshData source, float4x4 localToWorld, Transform rootTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x823C3E0", Offset = "0x823B7E0", VA = "0x18823C3E0")]
		public void VKLHVATYOQU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x823BEE0", Offset = "0x823B2E0", VA = "0x18823BEE0")]
		public void TZRVIEXYVZT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x823B960", Offset = "0x823AD60", VA = "0x18823B960")]
		public CollisionMeshData CLAPPVQJRSG(Allocator a, CancellationToken b)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x823BDD0", Offset = "0x823B1D0", VA = "0x18823BDD0")]
		public Mesh TGEOJZJOJHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x823BC20", Offset = "0x823B020", VA = "0x18823BC20")]
		private unsafe static float3* EXCMUIBNLAQ(NativeArray<float3> a)
		{
			//IL_0002: Expected I, but got O
			return (float3*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x823BBD0", Offset = "0x823AFD0", VA = "0x18823BBD0")]
		private unsafe static int* EXCMUIBNLAQ(NativeArray<int> a)
		{
			//IL_0002: Expected I, but got O
			return (int*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x823BCC0", Offset = "0x823B0C0", VA = "0x18823BCC0")]
		[CompilerGenerated]
		internal static void KBLMPKHQXYL(int a, int b, <>c__DisplayClass21_0 c)
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
		public int NBPPWDUHUAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x823CAD0", Offset = "0x823BED0", VA = "0x18823CAD0")]
			get
			{
				return default(int);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2711F80", Offset = "0x2711380", VA = "0x182711F80")]
		public static CollisionMeshMetrics BWNDTZPGZAW(CollisionMeshMetrics a, CollisionMeshMetrics b)
		{
			return default(CollisionMeshMetrics);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x823CB60", Offset = "0x823BF60", VA = "0x18823CB60")]
		public static CollisionMeshMetrics IHFXLNCYKKG(CollisionMeshMetrics a, int b)
		{
			return default(CollisionMeshMetrics);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x823CAE0", Offset = "0x823BEE0", VA = "0x18823CAE0", Slot = "0")]
		public override bool Equals(object that)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x823CB20", Offset = "0x823BF20", VA = "0x18823CB20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x823CB80", Offset = "0x823BF80", VA = "0x18823CB80", Slot = "3")]
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
