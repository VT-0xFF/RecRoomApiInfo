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
	public static class WREZQANGYOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x850F170", Offset = "0x850DF70", VA = "0x18850F170")]
		public static float2 LRMOOOAGEKE(this RectAlignment a)
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
		[Cpp2IlInjected.Address(RVA = "0x2ECFAB0", Offset = "0x2ECE8B0", VA = "0x182ECFAB0")]
		public float2Rect(float2 position, float2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8511A60", Offset = "0x8510860", VA = "0x188511A60")]
		public void RBUETEQJKHW([Out] float2 a, [Out] float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8511A30", Offset = "0x8510830", VA = "0x188511A30")]
		public float2 KVBMOHHBIYS(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x186C7D0", Offset = "0x186B5D0", VA = "0x18186C7D0", Slot = "4")]
		public bool Equals(float2Rect other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8511880", Offset = "0x8510680", VA = "0x188511880", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8511980", Offset = "0x8510780", VA = "0x188511980", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8511A80", Offset = "0x8510880", VA = "0x188511A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8511C90", Offset = "0x8510A90", VA = "0x188511C90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x85120D0", Offset = "0x8510ED0", VA = "0x1885120D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8512040", Offset = "0x8510E40", VA = "0x188512040", Slot = "6")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8511EA0", Offset = "0x8510CA0", VA = "0x188511EA0", Slot = "4")]
		public bool Equals(floatMinMax other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8511F90", Offset = "0x8510D90", VA = "0x188511F90", Slot = "5")]
		public bool Equals(float2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8511EE0", Offset = "0x8510CE0", VA = "0x188511EE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8511FC0", Offset = "0x8510DC0", VA = "0x188511FC0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x850FF50", Offset = "0x850ED50", VA = "0x18850FF50")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85100A0", Offset = "0x850EEA0", VA = "0x1885100A0")]
		public LayoutRect(LayoutRect parent, RectAlignment parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x850F9F0", Offset = "0x850E7F0", VA = "0x18850F9F0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x850F950", Offset = "0x850E750", VA = "0x18850F950")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x850F9C0", Offset = "0x850E7C0", VA = "0x18850F9C0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x850F960", Offset = "0x850E760", VA = "0x18850F960")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x850FB00", Offset = "0x850E900", VA = "0x18850FB00")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x850EEF0", Offset = "0x850DCF0", VA = "0x18850EEF0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x850FC10", Offset = "0x850EA10", VA = "0x18850FC10")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x850FBC0", Offset = "0x850E9C0", VA = "0x18850FBC0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x850FB70", Offset = "0x850E970", VA = "0x18850FB70")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x850FCD0", Offset = "0x850EAD0", VA = "0x18850FCD0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x850FC80", Offset = "0x850EA80", VA = "0x18850FC80")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x850FC20", Offset = "0x850EA20", VA = "0x18850FC20")]
		public void SetParentAlignment(RectAlignment rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x850FA10", Offset = "0x850E810", VA = "0x18850FA10")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x850FA70", Offset = "0x850E870", VA = "0x18850FA70")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x850FA00", Offset = "0x850E800", VA = "0x18850FA00")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x850FD80", Offset = "0x850EB80", VA = "0x18850FD80")]
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
	public static class LQFDFLBPRKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly Vector3[] RFFVIRQQVJU;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x850F500", Offset = "0x850E300", VA = "0x18850F500")]
		public static float2Rect TENZJJJEUQS(Transform a, RectTransform b)
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x850F820", Offset = "0x850E620", VA = "0x18850F820")]
		public static void ZDWVSLNINJK(Vector3[] a, [Out] float2 b, [Out] float2 c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class EVHCQJGZZFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int[] OWHEJSBIPBG;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x850F3B0", Offset = "0x850E1B0", VA = "0x18850F3B0")]
		public static void CBOMHDSKNKT([In] int indexBufferIdx, [Out] ushort a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ROWEWCSPFRB
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
		[Cpp2IlInjected.Address(RVA = "0x85114F0", Offset = "0x85102F0", VA = "0x1885114F0")]
		public static void UQAQZVERIAH(float3[] a, [In] float2 rectPosition, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85104D0", Offset = "0x850F2D0", VA = "0x1885104D0")]
		public static void BGSVMMCHZLX(float2[] a, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8511050", Offset = "0x850FE50", VA = "0x188511050")]
		public static void KDTXPMIAXPF(float3[] a, [In] float shiftWidth)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8511360", Offset = "0x8510160", VA = "0x188511360")]
		public static void TPBXEJXUXFE(QuadVertex[] a, [In] int vertexBufferIdx, [In] float3[] quadPositions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85108E0", Offset = "0x850F6E0", VA = "0x1885108E0")]
		public static void DTTRTTYFWHI(QuadVertex[] a, int b, [In] float3[] quadPositions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85110C0", Offset = "0x850FEC0", VA = "0x1885110C0")]
		public static void LVCWYMKWTAY(QuadVertex[] a, [In] int vertexBufferIdx, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8510C10", Offset = "0x850FA10", VA = "0x188510C10")]
		public static void GRVEZHDGZSQ(QuadVertex[] a, int b, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85109F0", Offset = "0x850F7F0", VA = "0x1885109F0")]
		public static void ETCQFSBDKFO(QuadVertex[] a, [In] int vertexBufferIdx, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8510B00", Offset = "0x850F900", VA = "0x188510B00")]
		public static void FUAJOJUSCAU(QuadVertex[] a, int b, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8511700", Offset = "0x8510500", VA = "0x188511700")]
		public static void ZASOCQKNGEG(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8511140", Offset = "0x850FF40", VA = "0x188511140")]
		public static void PLFXZRHASVY(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8510560", Offset = "0x850F360", VA = "0x188510560")]
		public static void BRPEODYJWDJ(QuadVertex[] a, int b, [In] Color32 quadColor, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8510DC0", Offset = "0x850FBC0", VA = "0x188510DC0")]
		public static void JCHVUOPHHOZ(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] Color32 quadColor, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8510C90", Offset = "0x850FA90", VA = "0x188510C90")]
		public static void IINOWPECCNR(ushort[] a, int b, [In] int indexBufferEndIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85116C0", Offset = "0x85104C0", VA = "0x1885116C0")]
		public static void XXLNFYALSQX(ushort[] a, int b, [In] int indexBufferEndIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8511630", Offset = "0x8510430", VA = "0x188511630")]
		public static void XRSWBZWVDUQ(ushort[] a, [In] int indexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8511570", Offset = "0x8510370", VA = "0x188511570")]
		public static void XEAOYEOLXIW(ushort[] a, [In] int indexBufferIdx, [In] int vertexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85106E0", Offset = "0x850F4E0", VA = "0x1885106E0")]
		public static Bounds CAOGSWCFPQV([In] QuadVertex[] vertexBuffer, [In] ushort[] indexBuffer, [In] int indexBufferCount)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85101E0", Offset = "0x850EFE0", VA = "0x1885101E0")]
		public static Bounds ASKDZXUMHRI([In] QuadVertex[] vertexBuffer, [In] ushort[] indexBuffer, [In] int indexBufferCount)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8511470", Offset = "0x8510270", VA = "0x188511470")]
		[CompilerGenerated]
		internal static void UFAHBJKXXFD([In] float3 p, <>c__DisplayClass27_0 a)
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
