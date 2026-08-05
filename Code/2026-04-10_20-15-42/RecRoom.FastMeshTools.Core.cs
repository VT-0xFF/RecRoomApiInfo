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
	public static class DGPSBKKVSES
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x99E7750", Offset = "0x99E6750", VA = "0x1899E7750")]
		public static float2 AEFWTXIDGOE(this RectAlignment a)
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
		[Cpp2IlInjected.Address(RVA = "0x312BB90", Offset = "0x312AB90", VA = "0x18312BB90")]
		public float2Rect(float2 position, float2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99E9FA0", Offset = "0x99E8FA0", VA = "0x1899E9FA0")]
		public void BXVWZDHELXS([Out] float2 a, [Out] float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99EA170", Offset = "0x99E9170", VA = "0x1899EA170")]
		public float2 HPBIDPXPAKW(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1AAF770", Offset = "0x1AAE770", VA = "0x181AAF770", Slot = "4")]
		public bool Equals(float2Rect other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99E9FC0", Offset = "0x99E8FC0", VA = "0x1899E9FC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99EA0C0", Offset = "0x99E90C0", VA = "0x1899EA0C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99EA1A0", Offset = "0x99E91A0", VA = "0x1899EA1A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99EA3C0", Offset = "0x99E93C0", VA = "0x1899EA3C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x99EA810", Offset = "0x99E9810", VA = "0x1899EA810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99EA780", Offset = "0x99E9780", VA = "0x1899EA780", Slot = "6")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99EA5E0", Offset = "0x99E95E0", VA = "0x1899EA5E0", Slot = "4")]
		public bool Equals(floatMinMax other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99EA6D0", Offset = "0x99E96D0", VA = "0x1899EA6D0", Slot = "5")]
		public bool Equals(float2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99EA620", Offset = "0x99E9620", VA = "0x1899EA620", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99EA700", Offset = "0x99E9700", VA = "0x1899EA700", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x99E8520", Offset = "0x99E7520", VA = "0x1899E8520")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99E8670", Offset = "0x99E7670", VA = "0x1899E8670")]
		public LayoutRect(LayoutRect parent, RectAlignment parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99E7FC0", Offset = "0x99E6FC0", VA = "0x1899E7FC0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99E7F20", Offset = "0x99E6F20", VA = "0x1899E7F20")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99E7F90", Offset = "0x99E6F90", VA = "0x1899E7F90")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99E7F30", Offset = "0x99E6F30", VA = "0x1899E7F30")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99E80D0", Offset = "0x99E70D0", VA = "0x1899E80D0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99E7850", Offset = "0x99E6850", VA = "0x1899E7850")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99E81E0", Offset = "0x99E71E0", VA = "0x1899E81E0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99E8190", Offset = "0x99E7190", VA = "0x1899E8190")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99E8140", Offset = "0x99E7140", VA = "0x1899E8140")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99E82A0", Offset = "0x99E72A0", VA = "0x1899E82A0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99E8250", Offset = "0x99E7250", VA = "0x1899E8250")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99E81F0", Offset = "0x99E71F0", VA = "0x1899E81F0")]
		public void SetParentAlignment(RectAlignment rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99E7FE0", Offset = "0x99E6FE0", VA = "0x1899E7FE0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99E8040", Offset = "0x99E7040", VA = "0x1899E8040")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99E7FD0", Offset = "0x99E6FD0", VA = "0x1899E7FD0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99E8350", Offset = "0x99E7350", VA = "0x1899E8350")]
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
	public static class HPVHLEUKONT
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly Vector3[] FTNHAMQMMNY;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99E7B90", Offset = "0x99E6B90", VA = "0x1899E7B90")]
		public static float2Rect IWOBYVEIXSK(Transform a, RectTransform b)
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99E7AD0", Offset = "0x99E6AD0", VA = "0x1899E7AD0")]
		public static void BSBLKAGJBCQ(Vector3[] a, [Out] float2 b, [Out] float2 c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class WCZSEVUMWUS
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int[] FPOGGFDOSLO;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99E9E50", Offset = "0x99E8E50", VA = "0x1899E9E50")]
		public static void CMJJCKJTOVR([In] int indexBufferIdx, [Out] ushort a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class RNCWOJTQZSX
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
		[Cpp2IlInjected.Address(RVA = "0x99E9370", Offset = "0x99E8370", VA = "0x1899E9370")]
		public static void JXSCVMSHSXB(float3[] a, [In] float2 rectPosition, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99E8AA0", Offset = "0x99E7AA0", VA = "0x1899E8AA0")]
		public static void BMTHLASQNVT(float2[] a, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99E9980", Offset = "0x99E8980", VA = "0x1899E9980")]
		public static void SPBJCEYOUPJ(float3[] a, [In] float shiftWidth)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99E9B70", Offset = "0x99E8B70", VA = "0x1899E9B70")]
		public static void WBBJMRGWFGK(QuadVertex[] a, [In] int vertexBufferIdx, [In] float3[] quadPositions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99E97E0", Offset = "0x99E87E0", VA = "0x1899E97E0")]
		public static void QVGYCOQZTEK(QuadVertex[] a, int b, [In] float3[] quadPositions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99E8F50", Offset = "0x99E7F50", VA = "0x1899E8F50")]
		public static void HBBHYONLRJG(QuadVertex[] a, [In] int vertexBufferIdx, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99E9560", Offset = "0x99E8560", VA = "0x1899E9560")]
		public static void NLULJOFSKTK(QuadVertex[] a, int b, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99E9C80", Offset = "0x99E8C80", VA = "0x1899E9C80")]
		public static void WFDIKKGBNPG(QuadVertex[] a, [In] int vertexBufferIdx, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99E8BB0", Offset = "0x99E7BB0", VA = "0x1899E8BB0")]
		public static void FAYWPZGIPSU(QuadVertex[] a, int b, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99E91F0", Offset = "0x99E81F0", VA = "0x1899E91F0")]
		public static void JMCNBTKVPJY(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99E8FD0", Offset = "0x99E7FD0", VA = "0x1899E8FD0")]
		public static void IZGLYRGLHQW(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99E99F0", Offset = "0x99E89F0", VA = "0x1899E99F0")]
		public static void TCXVBMACUTB(QuadVertex[] a, int b, [In] Color32 quadColor, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x99E8CC0", Offset = "0x99E7CC0", VA = "0x1899E8CC0")]
		public static void GBRCKYSBQDL(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] Color32 quadColor, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99E9430", Offset = "0x99E8430", VA = "0x1899E9430")]
		public static void LZGHSKAMZGT(ushort[] a, int b, [In] int indexBufferEndIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99E93F0", Offset = "0x99E83F0", VA = "0x1899E93F0")]
		public static void LJKMOKPWGCT(ushort[] a, int b, [In] int indexBufferEndIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99E98F0", Offset = "0x99E88F0", VA = "0x1899E98F0")]
		public static void RVAEGHTYLKU(ushort[] a, [In] int indexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99E9D90", Offset = "0x99E8D90", VA = "0x1899E9D90")]
		public static void YRLMHUZZTDA(ushort[] a, [In] int indexBufferIdx, [In] int vertexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99E95E0", Offset = "0x99E85E0", VA = "0x1899E95E0")]
		public static Bounds OSJBWEJBOFP([In] QuadVertex[] vertexBuffer, [In] ushort[] indexBuffer, [In] int indexBufferCount)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99E87B0", Offset = "0x99E77B0", VA = "0x1899E87B0")]
		public static Bounds BBMWMBTPHCO([In] QuadVertex[] vertexBuffer, [In] ushort[] indexBuffer, [In] int indexBufferCount)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x99E8B30", Offset = "0x99E7B30", VA = "0x1899E8B30")]
		[CompilerGenerated]
		internal static void EFLWEFMTGQB([In] float3 p, <>c__DisplayClass27_0 a)
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
