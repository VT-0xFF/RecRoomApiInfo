using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.FastMesh
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class RXEAJVUUUSR
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89E4CA0", Offset = "0x89E38A0", VA = "0x1889E4CA0")]
		public static float2 FPYBUXXVVTZ(this RectAlignment a)
		{
			return default(float2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum RectAlignment : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		BottomLeft,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		BottomCenter,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		BottomRight,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		CenterLeft,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Center,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		CenterRight,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		TopLeft,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		TopCenter,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		TopRight
	}
}
namespace RecRoom.FastMesh.Core
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct float2Rect : IEquatable<float2Rect>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const int BYTE_SIZE = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float width;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public float height;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float2 position;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float2 size;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x336F0D0", Offset = "0x336DCD0", VA = "0x18336F0D0")]
		public float2Rect(float2 position, float2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89E75F0", Offset = "0x89E61F0", VA = "0x1889E75F0")]
		public void SGLQLYIOUSX([Out] float2 a, [Out] float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89E75C0", Offset = "0x89E61C0", VA = "0x1889E75C0")]
		public float2 PQXXLXXHVHL(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D68E80", Offset = "0x1D67A80", VA = "0x181D68E80", Slot = "4")]
		public bool Equals(float2Rect other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89E7410", Offset = "0x89E6010", VA = "0x1889E7410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89E7510", Offset = "0x89E6110", VA = "0x1889E7510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89E7610", Offset = "0x89E6210", VA = "0x1889E7610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89E7830", Offset = "0x89E6430", VA = "0x1889E7830", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct floatMinMax : IEquatable<floatMinMax>, IEquatable<float2>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const int BYTE_SIZE = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float max;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float2 value;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89E7C80", Offset = "0x89E6880", VA = "0x1889E7C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89E7BF0", Offset = "0x89E67F0", VA = "0x1889E7BF0", Slot = "6")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89E7A50", Offset = "0x89E6650", VA = "0x1889E7A50", Slot = "4")]
		public bool Equals(floatMinMax other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89E7B40", Offset = "0x89E6740", VA = "0x1889E7B40", Slot = "5")]
		public bool Equals(float2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89E7A90", Offset = "0x89E6690", VA = "0x1889E7A90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x89E7B70", Offset = "0x89E6770", VA = "0x1889E7B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Obfuscation(Exclude = true)]
	public struct QuadVertex
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[Obfuscation(Exclude = true)]
		public static class Constants
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly VertexAttributeDescriptor[] layout;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Color32 color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float2 uv;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Obfuscation(Exclude = true)]
	public class LayoutRect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private float2Rect localRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private float2 parentAlignmentNormalized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private LayoutRect parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<LayoutRect> children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private LayoutRectDirtyStates cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x89E6D30", Offset = "0x89E5930", VA = "0x1889E6D30")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89E6E80", Offset = "0x89E5A80", VA = "0x1889E6E80")]
		public LayoutRect(LayoutRect parent, RectAlignment parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89E6770", Offset = "0x89E5370", VA = "0x1889E6770")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x89E66D0", Offset = "0x89E52D0", VA = "0x1889E66D0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89E6740", Offset = "0x89E5340", VA = "0x1889E6740")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x89E66E0", Offset = "0x89E52E0", VA = "0x1889E66E0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x89E6880", Offset = "0x89E5480", VA = "0x1889E6880")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x89E4B00", Offset = "0x89E3700", VA = "0x1889E4B00")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x89E6990", Offset = "0x89E5590", VA = "0x1889E6990")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x89E6940", Offset = "0x89E5540", VA = "0x1889E6940")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x89E68F0", Offset = "0x89E54F0", VA = "0x1889E68F0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x89E6A50", Offset = "0x89E5650", VA = "0x1889E6A50")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x89E6A00", Offset = "0x89E5600", VA = "0x1889E6A00")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x89E69A0", Offset = "0x89E55A0", VA = "0x1889E69A0")]
		public void SetParentAlignment(RectAlignment rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89E6790", Offset = "0x89E5390", VA = "0x1889E6790")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x89E67F0", Offset = "0x89E53F0", VA = "0x1889E67F0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89E6780", Offset = "0x89E5380", VA = "0x1889E6780")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x89E6B60", Offset = "0x89E5760", VA = "0x1889E6B60")]
		private LayoutRectDirtyStates UpdateCache()
		{
			return default(LayoutRectDirtyStates);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum LayoutRectDirtyStates : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Clean,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Dirty
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class WGVLTVOURQY
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly Vector3[] BOWYTEYEWTZ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x89E7080", Offset = "0x89E5C80", VA = "0x1889E7080")]
		public static float2Rect SCSPRCJRIMJ(Transform a, RectTransform b)
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89E6FC0", Offset = "0x89E5BC0", VA = "0x1889E6FC0")]
		public static void MESHSWRCCDH(Vector3[] a, [Out] float2 b, [Out] float2 c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ATRHDXGRKZH
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int[] ZAMODZQBKNB;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x89E4DA0", Offset = "0x89E39A0", VA = "0x1889E4DA0")]
		public static void TMCPZIYXQEE([In] int indexBufferIdx, [Out] ushort a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class EYBNVSISJRO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <>c__DisplayClass27_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float minX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public float minY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float minZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public float maxX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public float maxY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public float maxZ;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x89E5BE0", Offset = "0x89E47E0", VA = "0x1889E5BE0")]
		public static void MXKULPRVWQM(float3[] a, [In] float2 rectPosition, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89E5A20", Offset = "0x89E4620", VA = "0x1889E5A20")]
		public static void LOEBOCCNAHQ(float2[] a, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89E59B0", Offset = "0x89E45B0", VA = "0x1889E59B0")]
		public static void KWGQKUVSJRY(float3[] a, [In] float shiftWidth)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x89E53B0", Offset = "0x89E3FB0", VA = "0x1889E53B0")]
		public static void EJADPLKZANZ(QuadVertex[] a, [In] int vertexBufferIdx, [In] float3[] quadPositions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x89E6480", Offset = "0x89E5080", VA = "0x1889E6480")]
		public static void QCLNGAHNVZT(QuadVertex[] a, int b, [In] float3[] quadPositions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x89E5030", Offset = "0x89E3C30", VA = "0x1889E5030")]
		public static void AJTIBPMVHUX(QuadVertex[] a, [In] int vertexBufferIdx, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x89E6650", Offset = "0x89E5250", VA = "0x1889E6650")]
		public static void TGJPLSPKJFT(QuadVertex[] a, int b, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89E5CF0", Offset = "0x89E48F0", VA = "0x1889E5CF0")]
		public static void NFYVWQPYEIN(QuadVertex[] a, [In] int vertexBufferIdx, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x89E62F0", Offset = "0x89E4EF0", VA = "0x1889E62F0")]
		public static void POCCOSUUFLZ(QuadVertex[] a, int b, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89E5230", Offset = "0x89E3E30", VA = "0x1889E5230")]
		public static void CHDRNJTCTEV(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89E54C0", Offset = "0x89E40C0", VA = "0x1889E54C0")]
		public static void EQXLHKQSXBV(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x89E50B0", Offset = "0x89E3CB0", VA = "0x1889E50B0")]
		public static void AZBFZOKSTSS(QuadVertex[] a, int b, [In] Color32 quadColor, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x89E56E0", Offset = "0x89E42E0", VA = "0x1889E56E0")]
		public static void EUITWZCNGRY(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] Color32 quadColor, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89E5AB0", Offset = "0x89E46B0", VA = "0x1889E5AB0")]
		public static void MAWAZAOWOQI(ushort[] a, int b, [In] int indexBufferEndIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x89E5970", Offset = "0x89E4570", VA = "0x1889E5970")]
		public static void JZGGLEDOMAG(ushort[] a, int b, [In] int indexBufferEndIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89E5C60", Offset = "0x89E4860", VA = "0x1889E5C60")]
		public static void NCWRKYAMWXV(ushort[] a, [In] int indexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89E6590", Offset = "0x89E5190", VA = "0x1889E6590")]
		public static void RDCYUQQWZQT(ushort[] a, [In] int indexBufferIdx, [In] int vertexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89E60F0", Offset = "0x89E4CF0", VA = "0x1889E60F0")]
		public static Bounds OVIJZELUBFY([In] QuadVertex[] vertexBuffer, [In] ushort[] indexBuffer, [In] int indexBufferCount)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89E5E00", Offset = "0x89E4A00", VA = "0x1889E5E00")]
		public static Bounds NHSLLOGBPGR([In] QuadVertex[] vertexBuffer, [In] ushort[] indexBuffer, [In] int indexBufferCount)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89E6400", Offset = "0x89E5000", VA = "0x1889E6400")]
		[CompilerGenerated]
		internal static void PTQJSLNBQHM([In] float3 p, <>c__DisplayClass27_0 a)
		{
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
