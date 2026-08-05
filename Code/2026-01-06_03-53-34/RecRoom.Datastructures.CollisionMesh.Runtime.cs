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
			[Cpp2IlInjected.Address(RVA = "0x83018C0", Offset = "0x83002C0", VA = "0x1883018C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB942A0", Offset = "0xB92CA0", VA = "0x180B942A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82FF5A0", Offset = "0x82FDFA0", VA = "0x1882FF5A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8301450", Offset = "0x82FFE50", VA = "0x188301450")]
		public bool XEHFHIVGAWP([In] NativeArray<float3> points, NativeList<float3> a, NativeList<int> b, Allocator c, CancellationToken d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82FFE20", Offset = "0x82FE820", VA = "0x1882FFE20")]
		private void Initialize([In] NativeArray<float3> points, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82FE5B0", Offset = "0x82FCFB0", VA = "0x1882FE5B0")]
		private void CSJXPWFCQVV([In] NativeArray<float3> points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82FFFF0", Offset = "0x82FE9F0", VA = "0x1882FFFF0")]
		private void JBQBIXPLEHS([In] NativeArray<float3> points, [Out] int a, [Out] int b, [Out] int c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8301590", Offset = "0x82FFF90", VA = "0x188301590")]
		private void YDWKDHFYHFR([In] NativeArray<float3> points, Allocator a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8300600", Offset = "0x82FF000", VA = "0x188300600")]
		private void POCKMKPOIBJ([In] NativeArray<float3> points, float3 a, int b, Face c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82FF6C0", Offset = "0x82FE0C0", VA = "0x1882FF6C0")]
		private void HNLXJUOJEIG([In] NativeArray<float3> points, float3 a, int b, int c, Face d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82FDEB0", Offset = "0x82FC8B0", VA = "0x1882FDEB0")]
		private void AVEEHYZZJKH([In] NativeArray<float3> points, int a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8300B40", Offset = "0x82FF540", VA = "0x188300B40")]
		private void VFDPLDFQTVC([In] NativeArray<float3> points, Allocator a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8300F80", Offset = "0x82FF980", VA = "0x188300F80")]
		private void VURMNSNWVUG([In] NativeArray<float3> points, NativeList<float3> a, NativeList<int> b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82FFAB0", Offset = "0x82FE4B0", VA = "0x1882FFAB0")]
		private float HYTYXFAGIGN(float3 a, float3 b, Face c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82FC710", Offset = "0x82FB110", VA = "0x1882FC710")]
		private float3 Normal(float3 v0, float3 v1, float3 v2)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8300500", Offset = "0x82FEF00", VA = "0x188300500")]
		private static float NMUILQMMYZE(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8300AE0", Offset = "0x82FF4E0", VA = "0x188300AE0")]
		private static float3 TGJUGLLMLLH(float3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83004A0", Offset = "0x82FEEA0", VA = "0x1883004A0")]
		private bool MZFKMWGFAFN(float3 a, float3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8300530", Offset = "0x82FEF30", VA = "0x188300530")]
		private bool NPGEKPQOGYO(float3 a, float3 b, float3 c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82FFB10", Offset = "0x82FE510", VA = "0x1882FFB10")]
		private bool ILOCOTPRVDX(float3 a, float3 b, float3 c, float3 d)
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
		public int THGMVPMUQFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x82FCF00", Offset = "0x82FB900", VA = "0x1882FCF00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ZLBIUKVEGRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x82FCD90", Offset = "0x82FB790", VA = "0x1882FCD90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool AZQANBKHVRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x82FCD50", Offset = "0x82FB750", VA = "0x1882FCD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public CollisionMeshMetrics GFIEFJCXNII
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x82FCF80", Offset = "0x82FB980", VA = "0x1882FCF80")]
			get
			{
				return default(CollisionMeshMetrics);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82FDB40", Offset = "0x82FC540", VA = "0x1882FDB40")]
		public CollisionMeshData(int vertexCount, int indexCount, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82FDB10", Offset = "0x82FC510", VA = "0x1882FDB10")]
		public CollisionMeshData(CollisionMeshMetrics metrics, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82FDC00", Offset = "0x82FC600", VA = "0x1882FDC00")]
		public CollisionMeshData(Mesh mesh, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82FD820", Offset = "0x82FC220", VA = "0x1882FD820")]
		public CollisionMeshData(CollisionMeshData data, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82FCDE0", Offset = "0x82FB7E0", VA = "0x1882FCDE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82FC970", Offset = "0x82FB370", VA = "0x1882FC970")]
		public void Add([In] CollisionMeshData source, float4x4 localToWorld, Transform rootTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82FC820", Offset = "0x82FB220", VA = "0x1882FC820")]
		public void ABLAVJVZMSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82FD210", Offset = "0x82FBC10", VA = "0x1882FD210")]
		public void SHDOUXATEPO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82FD020", Offset = "0x82FBA20", VA = "0x1882FD020")]
		public CollisionMeshData SCXPKZJKLTX(Allocator a, CancellationToken b)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82FD710", Offset = "0x82FC110", VA = "0x1882FD710")]
		public Mesh TCQTLQJVNYL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82FCEB0", Offset = "0x82FB8B0", VA = "0x1882FCEB0")]
		private unsafe static float3* INHJJPYOHHP(NativeArray<float3> a)
		{
			//IL_0002: Expected I, but got O
			return (float3*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82FCE60", Offset = "0x82FB860", VA = "0x1882FCE60")]
		private unsafe static int* INHJJPYOHHP(NativeArray<int> a)
		{
			//IL_0002: Expected I, but got O
			return (int*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82FCF50", Offset = "0x82FB950", VA = "0x1882FCF50")]
		[CompilerGenerated]
		internal static void NRLKTTBLTPI(int a, int b, <>c__DisplayClass21_0 c)
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
		public int RARDOMBWKGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x82FDE80", Offset = "0x82FC880", VA = "0x1882FDE80")]
			get
			{
				return default(int);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2767D00", Offset = "0x2766700", VA = "0x182767D00")]
		public static CollisionMeshMetrics VUDHLVIBKUN(CollisionMeshMetrics a, CollisionMeshMetrics b)
		{
			return default(CollisionMeshMetrics);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82FDE90", Offset = "0x82FC890", VA = "0x1882FDE90")]
		public static CollisionMeshMetrics YMAGKTYDTKZ(CollisionMeshMetrics a, int b)
		{
			return default(CollisionMeshMetrics);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82FDD70", Offset = "0x82FC770", VA = "0x1882FDD70", Slot = "0")]
		public override bool Equals(object that)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82FDDB0", Offset = "0x82FC7B0", VA = "0x1882FDDB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82FDDF0", Offset = "0x82FC7F0", VA = "0x1882FDDF0", Slot = "3")]
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
