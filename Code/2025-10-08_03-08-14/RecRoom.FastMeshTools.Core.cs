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
	public static class RLOIYSFYEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85782D0", Offset = "0x85770D0", VA = "0x1885782D0")]
		public static float2 THUHTKUDYRL(this RectAlignment a)
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
		[Cpp2IlInjected.Address(RVA = "0x3071990", Offset = "0x3070790", VA = "0x183071990")]
		public float2Rect(float2 position, float2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x857ACC0", Offset = "0x8579AC0", VA = "0x18857ACC0")]
		public void KAKPPNOMYGN([Out] float2 a, [Out] float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x857AC90", Offset = "0x8579A90", VA = "0x18857AC90")]
		public float2 IJCDEWZIMKL(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1A74B10", Offset = "0x1A73910", VA = "0x181A74B10", Slot = "4")]
		public bool Equals(float2Rect other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x857AAE0", Offset = "0x85798E0", VA = "0x18857AAE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x857ABE0", Offset = "0x85799E0", VA = "0x18857ABE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x857ACE0", Offset = "0x8579AE0", VA = "0x18857ACE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x857AF00", Offset = "0x8579D00", VA = "0x18857AF00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x857B350", Offset = "0x857A150", VA = "0x18857B350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x857B2C0", Offset = "0x857A0C0", VA = "0x18857B2C0", Slot = "6")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x857B120", Offset = "0x8579F20", VA = "0x18857B120", Slot = "4")]
		public bool Equals(floatMinMax other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x857B210", Offset = "0x857A010", VA = "0x18857B210", Slot = "5")]
		public bool Equals(float2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x857B160", Offset = "0x8579F60", VA = "0x18857B160", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x857B240", Offset = "0x857A040", VA = "0x18857B240", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x8578D90", Offset = "0x8577B90", VA = "0x188578D90")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8578ED0", Offset = "0x8577CD0", VA = "0x188578ED0")]
		public LayoutRect(LayoutRect parent, RectAlignment parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8578830", Offset = "0x8577630", VA = "0x188578830")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8578790", Offset = "0x8577590", VA = "0x188578790")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8578800", Offset = "0x8577600", VA = "0x188578800")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85787A0", Offset = "0x85775A0", VA = "0x1885787A0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8578940", Offset = "0x8577740", VA = "0x188578940")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8578190", Offset = "0x8576F90", VA = "0x188578190")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8578A50", Offset = "0x8577850", VA = "0x188578A50")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8578A00", Offset = "0x8577800", VA = "0x188578A00")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85789B0", Offset = "0x85777B0", VA = "0x1885789B0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8578B10", Offset = "0x8577910", VA = "0x188578B10")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8578AC0", Offset = "0x85778C0", VA = "0x188578AC0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8578A60", Offset = "0x8577860", VA = "0x188578A60")]
		public void SetParentAlignment(RectAlignment rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8578850", Offset = "0x8577650", VA = "0x188578850")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85788B0", Offset = "0x85776B0", VA = "0x1885788B0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8578840", Offset = "0x8577640", VA = "0x188578840")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8578BC0", Offset = "0x85779C0", VA = "0x188578BC0")]
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
	public static class XRULLNLLKOS
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly Vector3[] XWMCRRBPMEN;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x857A760", Offset = "0x8579560", VA = "0x18857A760")]
		public static float2Rect RUDQNVVRTNN(Transform a, RectTransform b)
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x857A6A0", Offset = "0x85794A0", VA = "0x18857A6A0")]
		public static void JPKVBLKMBQL(Vector3[] a, [Out] float2 b, [Out] float2 c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class AWIWXKBWFTJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int[] TSYMOSWZXLL;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8578510", Offset = "0x8577310", VA = "0x188578510")]
		public static void OAFSRVUIGCC([In] int indexBufferIdx, [Out] ushort a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class XNZUJSNEVHU
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
		[Cpp2IlInjected.Address(RVA = "0x85799B0", Offset = "0x85787B0", VA = "0x1885799B0")]
		public static void DWGEHXQPCDY(float3[] a, [In] float2 rectPosition, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x857A140", Offset = "0x8578F40", VA = "0x18857A140")]
		public static void JUBXZBEXHBG(float2[] a, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x857A380", Offset = "0x8579180", VA = "0x18857A380")]
		public static void MUGMEITDXVC(float3[] a, [In] float shiftWidth)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x857A590", Offset = "0x8579390", VA = "0x18857A590")]
		public static void ZQNIBXGDHUB(QuadVertex[] a, [In] int vertexBufferIdx, [In] float3[] quadPositions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85798A0", Offset = "0x85786A0", VA = "0x1885798A0")]
		public static void DEVFIMAJHPB(QuadVertex[] a, int b, [In] float3[] quadPositions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x857A1D0", Offset = "0x8578FD0", VA = "0x18857A1D0")]
		public static void KPLIVMMPDIZ(QuadVertex[] a, [In] int vertexBufferIdx, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x857A0C0", Offset = "0x8578EC0", VA = "0x18857A0C0")]
		public static void JJOETRXFQZZ(QuadVertex[] a, int b, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8579200", Offset = "0x8578000", VA = "0x188579200")]
		public static void AXHDJUDZOPZ(QuadVertex[] a, [In] int vertexBufferIdx, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x857A3F0", Offset = "0x85791F0", VA = "0x18857A3F0")]
		public static void OLUERTCUEUF(QuadVertex[] a, int b, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8579490", Offset = "0x8578290", VA = "0x188579490")]
		public static void DBIYRIULVVR(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8579A30", Offset = "0x8578830", VA = "0x188579A30")]
		public static void EEQCIMJUIVP(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8579310", Offset = "0x8578110", VA = "0x188579310")]
		public static void CCELYBWZIIY(QuadVertex[] a, int b, [In] Color32 quadColor, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8579610", Offset = "0x8578410", VA = "0x188579610")]
		public static void DBMJEVMFBQY(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] Color32 quadColor, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x857A250", Offset = "0x8579050", VA = "0x18857A250")]
		public static void MJWTGFKHDVU(ushort[] a, int b, [In] int indexBufferEndIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x857A080", Offset = "0x8578E80", VA = "0x18857A080")]
		public static void IKYITULBZGU(ushort[] a, int b, [In] int indexBufferEndIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x857A500", Offset = "0x8579300", VA = "0x18857A500")]
		public static void SYAXKDTTEFT(ushort[] a, [In] int indexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8579F40", Offset = "0x8578D40", VA = "0x188579F40")]
		public static void GBEGCWKTJSF(ushort[] a, [In] int indexBufferIdx, [In] int vertexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8579000", Offset = "0x8577E00", VA = "0x188579000")]
		public static Bounds AQDATWRCHPW([In] QuadVertex[] vertexBuffer, [In] ushort[] indexBuffer, [In] int indexBufferCount)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8579C50", Offset = "0x8578A50", VA = "0x188579C50")]
		public static Bounds FIBUKEHGQBR([In] QuadVertex[] vertexBuffer, [In] ushort[] indexBuffer, [In] int indexBufferCount)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x857A000", Offset = "0x8578E00", VA = "0x18857A000")]
		[CompilerGenerated]
		internal static void HCYXUATFUVS([In] float3 p, <>c__DisplayClass27_0 a)
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
