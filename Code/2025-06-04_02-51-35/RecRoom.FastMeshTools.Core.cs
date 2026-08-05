using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh.Core;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FFHMFONHBBN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F878F0", Offset = "0x7F860F0", VA = "0x187F878F0")]
	public static float2 EHMKCMPAJHB(this CACLAAHGJAC EKJJMBEOJHC)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CACLAAHGJAC : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2F3D7E0", Offset = "0x2F3BFE0", VA = "0x182F3D7E0")]
		public float2Rect(float2 KKEEFCOJJFM, float2 GGIJOHIPOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A380", Offset = "0x7F88B80", VA = "0x187F8A380")]
		public void EBKFCGEKMKA([Out] float2 EEEMJJHCBGN, [Out] float2 EPHANANEPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A350", Offset = "0x7F88B50", VA = "0x187F8A350")]
		public float2 EAKKDKOFKGH(float2 IHAKBNFAIEN)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A3A0", Offset = "0x7F88BA0", VA = "0x187F8A3A0", Slot = "4")]
		public bool Equals(float2Rect KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A420", Offset = "0x7F88C20", VA = "0x187F8A420", Slot = "0")]
		public override bool Equals(object HPLLAPMNIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A520", Offset = "0x7F88D20", VA = "0x187F8A520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A5D0", Offset = "0x7F88DD0", VA = "0x187F8A5D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A7F0", Offset = "0x7F88FF0", VA = "0x187F8A7F0", Slot = "5")]
		public string ToString(string HKOGDKBPFKC, IFormatProvider LLKCOGOHBNI)
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
		[Cpp2IlInjected.Address(RVA = "0x7F8AC30", Offset = "0x7F89430", VA = "0x187F8AC30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8ABA0", Offset = "0x7F893A0", VA = "0x187F8ABA0", Slot = "6")]
		public string ToString(string HKOGDKBPFKC, IFormatProvider LLKCOGOHBNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8AA00", Offset = "0x7F89200", VA = "0x187F8AA00", Slot = "4")]
		public bool Equals(floatMinMax KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F8AAF0", Offset = "0x7F892F0", VA = "0x187F8AAF0", Slot = "5")]
		public bool Equals(float2 KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8AA40", Offset = "0x7F89240", VA = "0x187F8AA40", Slot = "0")]
		public override bool Equals(object HPLLAPMNIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F8AB20", Offset = "0x7F89320", VA = "0x187F8AB20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct QuadVertex
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
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
		private NHGEGHGHOCI cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A0C0", Offset = "0x7F888C0", VA = "0x187F8A0C0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F89F70", Offset = "0x7F88770", VA = "0x187F89F70")]
		public LayoutRect(LayoutRect parent, CACLAAHGJAC parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F89A30", Offset = "0x7F88230", VA = "0x187F89A30")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F89990", Offset = "0x7F88190", VA = "0x187F89990")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7F89A00", Offset = "0x7F88200", VA = "0x187F89A00")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F899A0", Offset = "0x7F881A0", VA = "0x187F899A0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F89B40", Offset = "0x7F88340", VA = "0x187F89B40")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F879F0", Offset = "0x7F861F0", VA = "0x187F879F0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F89C40", Offset = "0x7F88440", VA = "0x187F89C40")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F89BF0", Offset = "0x7F883F0", VA = "0x187F89BF0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F89BA0", Offset = "0x7F883A0", VA = "0x187F89BA0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F89CF0", Offset = "0x7F884F0", VA = "0x187F89CF0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F89CA0", Offset = "0x7F884A0", VA = "0x187F89CA0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F89C50", Offset = "0x7F88450", VA = "0x187F89C50")]
		public void SetParentAlignment(CACLAAHGJAC rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F89A50", Offset = "0x7F88250", VA = "0x187F89A50")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F89AB0", Offset = "0x7F882B0", VA = "0x187F89AB0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F89A40", Offset = "0x7F88240", VA = "0x187F89A40")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F89DA0", Offset = "0x7F885A0", VA = "0x187F89DA0")]
		private NHGEGHGHOCI UpdateCache()
		{
			return default(NHGEGHGHOCI);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NHGEGHGHOCI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LNCDANDMJGI
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] JAPCKOPEOFK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F89610", Offset = "0x7F87E10", VA = "0x187F89610")]
	public static float2Rect GCGFNCGIADF(Transform ABIPFINEENN, RectTransform OLBBKGLINIK)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F89550", Offset = "0x7F87D50", VA = "0x187F89550")]
	public static void BIIGELIODDH(Vector3[] PHAKKJAKNKI, [Out] float2 EDBIKCGPICF, [Out] float2 PIMEBNLNKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OMPKMAHGOEG
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] PCJKMHAPPLE;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A210", Offset = "0x7F88A10", VA = "0x187F8A210")]
	public static void LCAOPDFLOIM([In] int GEFFFMMONGK, [Out] ushort BJCIJCDLLDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FLJLLFLHFEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ELNMPAHNLEN
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
	[Cpp2IlInjected.Address(RVA = "0x7F89050", Offset = "0x7F87850", VA = "0x187F89050")]
	public static void FIJKGNMKEKH(float3[] GOIMAGAGFDJ, [In] float2 POELDPDCBEA, [In] float2 EPHANANEPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F89190", Offset = "0x7F87990", VA = "0x187F89190")]
	public static void IMMBPHAMKHF(float2[] GGHKANKFKDG, [In] float2 NJEBDKAGEPC, [In] float2 JGBCDNPAANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F88320", Offset = "0x7F86B20", VA = "0x187F88320")]
	public static void BJKEFEPNPDE(float3[] GOIMAGAGFDJ, [In] float LHCJCKEBJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F88920", Offset = "0x7F87120", VA = "0x187F88920")]
	public static void EBPPEKELNJC(QuadVertex[] NNGLNBDMOEH, [In] int BJCIJCDLLDO, [In] float3[] JNEMKMABEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F89220", Offset = "0x7F87A20", VA = "0x187F89220")]
	public static void INGCOEMKLBG(QuadVertex[] NNGLNBDMOEH, int BJCIJCDLLDO, [In] float3[] JNEMKMABEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F88420", Offset = "0x7F86C20", VA = "0x187F88420")]
	public static void CPCDKGPPEEK(QuadVertex[] NNGLNBDMOEH, [In] int BJCIJCDLLDO, [In] Color32 MJMCFDINFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F89110", Offset = "0x7F87910", VA = "0x187F89110")]
	public static void IMJOBEMGPGL(QuadVertex[] NNGLNBDMOEH, int BJCIJCDLLDO, [In] Color32 MJMCFDINFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F88F40", Offset = "0x7F87740", VA = "0x187F88F40")]
	public static void FCPMMBNNPJO(QuadVertex[] NNGLNBDMOEH, [In] int BJCIJCDLLDO, [In] float2[] HEKNKNMGNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F88210", Offset = "0x7F86A10", VA = "0x187F88210")]
	public static void AKJCIPOJJED(QuadVertex[] NNGLNBDMOEH, int BJCIJCDLLDO, [In] float2[] HEKNKNMGNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F88D40", Offset = "0x7F87540", VA = "0x187F88D40")]
	public static void FBDPHFJBOIH(QuadVertex[] NNGLNBDMOEH, int BJCIJCDLLDO, [In] float3[] JNEMKMABEHE, [In] Color32 MJMCFDINFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F89330", Offset = "0x7F87B30", VA = "0x187F89330")]
	public static void OKAKCLJCLON(QuadVertex[] NNGLNBDMOEH, int BJCIJCDLLDO, [In] float3[] JNEMKMABEHE, [In] float2[] HEKNKNMGNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F88560", Offset = "0x7F86D60", VA = "0x187F88560")]
	public static void DDLBELNPBFJ(QuadVertex[] NNGLNBDMOEH, int BJCIJCDLLDO, [In] Color32 MJMCFDINFHE, [In] float2[] HEKNKNMGNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F87E50", Offset = "0x7F86650", VA = "0x187F87E50")]
	public static void AFJEOCLGIBF(QuadVertex[] NNGLNBDMOEH, int BJCIJCDLLDO, [In] float3[] JNEMKMABEHE, [In] Color32 MJMCFDINFHE, [In] float2[] HEKNKNMGNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F880E0", Offset = "0x7F868E0", VA = "0x187F880E0")]
	public static void AILNGNPFPFC(ushort[] OHHIFKBJOGG, int GEFFFMMONGK, [In] int NCOKKHFHHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F890D0", Offset = "0x7F878D0", VA = "0x187F890D0")]
	public static void FLFEBJCEAOL(ushort[] OHHIFKBJOGG, int GEFFFMMONGK, [In] int NCOKKHFHHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F88390", Offset = "0x7F86B90", VA = "0x187F88390")]
	public static void CMOKMNEGCLF(ushort[] OHHIFKBJOGG, [In] int GEFFFMMONGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F884A0", Offset = "0x7F86CA0", VA = "0x187F884A0")]
	public static void DAHJOJEABGI(ushort[] OHHIFKBJOGG, [In] int GEFFFMMONGK, [In] int BJCIJCDLLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7F886E0", Offset = "0x7F86EE0", VA = "0x187F886E0")]
	public static Bounds DJBDKMLHOGL([In] QuadVertex[] NNGLNBDMOEH, [In] ushort[] OHHIFKBJOGG, [In] int KMAONMAMNJB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F88A30", Offset = "0x7F87230", VA = "0x187F88A30")]
	public static Bounds ECDFDGHGPDM([In] QuadVertex[] NNGLNBDMOEH, [In] ushort[] OHHIFKBJOGG, [In] int KMAONMAMNJB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F88EC0", Offset = "0x7F876C0", VA = "0x187F88EC0")]
	[CompilerGenerated]
	internal static void FCDKALKPHJP([In] float3 LNKCJPMONLM, ELNMPAHNLEN P_1)
	{
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
