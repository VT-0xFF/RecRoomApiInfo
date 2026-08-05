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
			[Cpp2IlInjected.Address(RVA = "0x81CE1E0", Offset = "0x81CD5E0", VA = "0x1881CE1E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB81730", Offset = "0xB80B30", VA = "0x180B81730")]
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
		[Cpp2IlInjected.Address(RVA = "0x81CAB00", Offset = "0x81C9F00", VA = "0x1881CAB00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x81CD0C0", Offset = "0x81CC4C0", VA = "0x1881CD0C0")]
		public bool SNHNRSORUJE([In] NativeArray<float3> points, NativeList<float3> a, NativeList<int> b, Allocator c, CancellationToken d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x81CB060", Offset = "0x81CA460", VA = "0x1881CB060")]
		private void Initialize([In] NativeArray<float3> points, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81CB360", Offset = "0x81CA760", VA = "0x1881CB360")]
		private void PPBAHCSWFTC([In] NativeArray<float3> points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81CC740", Offset = "0x81CBB40", VA = "0x1881CC740")]
		private void RPLILPSTADL([In] NativeArray<float3> points, [Out] int a, [Out] int b, [Out] int c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81CA7D0", Offset = "0x81C9BD0", VA = "0x1881CA7D0")]
		private void CCLTEFSJSXY([In] NativeArray<float3> points, Allocator a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81CD570", Offset = "0x81CC970", VA = "0x1881CD570")]
		private void VBGDJEPTZGA([In] NativeArray<float3> points, float3 a, int b, Face c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81CC350", Offset = "0x81CB750", VA = "0x1881CC350")]
		private void QPLPSPOKPIB([In] NativeArray<float3> points, float3 a, int b, int c, Face d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81CDA80", Offset = "0x81CCE80", VA = "0x1881CDA80")]
		private void YXTZIQFXPVG([In] NativeArray<float3> points, int a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81CAC20", Offset = "0x81CA020", VA = "0x1881CAC20")]
		private void EOVWFAKDMCF([In] NativeArray<float3> points, Allocator a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81CCBF0", Offset = "0x81CBFF0", VA = "0x1881CCBF0")]
		private void SAXFYJJROSD([In] NativeArray<float3> points, NativeList<float3> a, NativeList<int> b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81CD510", Offset = "0x81CC910", VA = "0x1881CD510")]
		private float UKBOZBGQOJQ(float3 a, float3 b, Face c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81C8D20", Offset = "0x81C8120", VA = "0x1881C8D20")]
		private float3 Normal(float3 v0, float3 v1, float3 v2)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81CDA50", Offset = "0x81CCE50", VA = "0x1881CDA50")]
		private static float XRIWLLNFRGB(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81CE180", Offset = "0x81CD580", VA = "0x1881CE180")]
		private static float3 ZZSPEVLKZXY(float3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81CB300", Offset = "0x81CA700", VA = "0x1881CB300")]
		private bool MIULERTEADS(float3 a, float3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81CB230", Offset = "0x81CA630", VA = "0x1881CB230")]
		private bool JKHOYVSZJFJ(float3 a, float3 b, float3 c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81CD200", Offset = "0x81CC600", VA = "0x1881CD200")]
		private bool SRAVKQNAIXM(float3 a, float3 b, float3 c, float3 d)
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
		public int KZBIIPNWBUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x81C96B0", Offset = "0x81C8AB0", VA = "0x1881C96B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int JQKVERPISIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x81C9A00", Offset = "0x81C8E00", VA = "0x1881C9A00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool OPQIQKQJKTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x81C97A0", Offset = "0x81C8BA0", VA = "0x1881C97A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public CollisionMeshMetrics GXPUVUXXVOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x81C9700", Offset = "0x81C8B00", VA = "0x1881C9700")]
			get
			{
				return default(CollisionMeshMetrics);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81CA460", Offset = "0x81C9860", VA = "0x1881CA460")]
		public CollisionMeshData(int vertexCount, int indexCount, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81CA430", Offset = "0x81C9830", VA = "0x1881CA430")]
		public CollisionMeshData(CollisionMeshMetrics metrics, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81CA520", Offset = "0x81C9920", VA = "0x1881CA520")]
		public CollisionMeshData(Mesh mesh, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81CA140", Offset = "0x81C9540", VA = "0x1881CA140")]
		public CollisionMeshData(CollisionMeshData data, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81C9630", Offset = "0x81C8A30", VA = "0x1881C9630", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81C9140", Offset = "0x81C8540", VA = "0x1881C9140")]
		public void Add([In] CollisionMeshData source, float4x4 localToWorld, Transform rootTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81C97E0", Offset = "0x81C8BE0", VA = "0x1881C97E0")]
		public void KRYTNPKFGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81C9A50", Offset = "0x81C8E50", VA = "0x1881C9A50")]
		public void QRRMBWGDFPT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81C9F50", Offset = "0x81C9350", VA = "0x1881C9F50")]
		public CollisionMeshData VQBFSKEXWOW(Allocator a, CancellationToken b)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81C9520", Offset = "0x81C8920", VA = "0x1881C9520")]
		public Mesh BBUDOFOUPPY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81C9930", Offset = "0x81C8D30", VA = "0x1881C9930")]
		private unsafe static float3* OMNIJJVVBYM(NativeArray<float3> a)
		{
			//IL_0002: Expected I, but got O
			return (float3*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x81C9980", Offset = "0x81C8D80", VA = "0x1881C9980")]
		private unsafe static int* OMNIJJVVBYM(NativeArray<int> a)
		{
			//IL_0002: Expected I, but got O
			return (int*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x81C99D0", Offset = "0x81C8DD0", VA = "0x1881C99D0")]
		[CompilerGenerated]
		internal static void OWWQQEKIKFB(int a, int b, <>c__DisplayClass21_0 c)
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
		public int IPFSPCMAEJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x81CA710", Offset = "0x81C9B10", VA = "0x1881CA710")]
			get
			{
				return default(int);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x275AB00", Offset = "0x2759F00", VA = "0x18275AB00")]
		public static CollisionMeshMetrics SYVIVGFMWIG(CollisionMeshMetrics a, CollisionMeshMetrics b)
		{
			return default(CollisionMeshMetrics);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81CA720", Offset = "0x81C9B20", VA = "0x1881CA720")]
		public static CollisionMeshMetrics TUZUHTLBCAG(CollisionMeshMetrics a, int b)
		{
			return default(CollisionMeshMetrics);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x81CA690", Offset = "0x81C9A90", VA = "0x1881CA690", Slot = "0")]
		public override bool Equals(object that)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81CA6D0", Offset = "0x81C9AD0", VA = "0x1881CA6D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81CA740", Offset = "0x81C9B40", VA = "0x1881CA740", Slot = "3")]
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
