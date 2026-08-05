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
public static class LIMKPOKOHPH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE340", Offset = "0x7DACF40", VA = "0x187DAE340")]
	public static float2 FEIOKCPOOKM(this KHNEAFIHNDK ABBKIKJBINP)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KHNEAFIHNDK : byte
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
		[Cpp2IlInjected.Address(RVA = "0x30047A0", Offset = "0x30033A0", VA = "0x1830047A0")]
		public float2Rect(float2 IIBJECFMAJC, float2 DKFJGBGJGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0BC0", Offset = "0x7DAF7C0", VA = "0x187DB0BC0")]
		public void AMHBPBGIPFF([Out] float2 CIIMAEBCMHH, [Out] float2 BJLPHNOPDEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0E10", Offset = "0x7DAFA10", VA = "0x187DB0E10")]
		public float2 JCMHAEKIAPP(float2 HOGLGLBNLMN)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0BE0", Offset = "0x7DAF7E0", VA = "0x187DB0BE0", Slot = "4")]
		public bool Equals(float2Rect GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0C60", Offset = "0x7DAF860", VA = "0x187DB0C60", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0D60", Offset = "0x7DAF960", VA = "0x187DB0D60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0E40", Offset = "0x7DAFA40", VA = "0x187DB0E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1060", Offset = "0x7DAFC60", VA = "0x187DB1060", Slot = "5")]
		public string ToString(string GFCBDNDPEDI, IFormatProvider ELLKPMONHDB)
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
		[Cpp2IlInjected.Address(RVA = "0x7DB14A0", Offset = "0x7DB00A0", VA = "0x187DB14A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1410", Offset = "0x7DB0010", VA = "0x187DB1410", Slot = "6")]
		public string ToString(string GFCBDNDPEDI, IFormatProvider ELLKPMONHDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1270", Offset = "0x7DAFE70", VA = "0x187DB1270", Slot = "4")]
		public bool Equals(floatMinMax GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1360", Offset = "0x7DAFF60", VA = "0x187DB1360", Slot = "5")]
		public bool Equals(float2 GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB12B0", Offset = "0x7DAFEB0", VA = "0x187DB12B0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1390", Offset = "0x7DAFF90", VA = "0x187DB1390", Slot = "2")]
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
		private LIDPPAMAIHI cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DB04E0", Offset = "0x7DAF0E0", VA = "0x187DB04E0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0630", Offset = "0x7DAF230", VA = "0x187DB0630")]
		public LayoutRect(LayoutRect parent, KHNEAFIHNDK parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFFA0", Offset = "0x7DAEBA0", VA = "0x187DAFFA0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFF00", Offset = "0x7DAEB00", VA = "0x187DAFF00")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFF70", Offset = "0x7DAEB70", VA = "0x187DAFF70")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFF10", Offset = "0x7DAEB10", VA = "0x187DAFF10")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7DB00B0", Offset = "0x7DAECB0", VA = "0x187DB00B0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE440", Offset = "0x7DAD040", VA = "0x187DAE440")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7DB01B0", Offset = "0x7DAEDB0", VA = "0x187DB01B0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0160", Offset = "0x7DAED60", VA = "0x187DB0160")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0110", Offset = "0x7DAED10", VA = "0x187DB0110")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0260", Offset = "0x7DAEE60", VA = "0x187DB0260")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0210", Offset = "0x7DAEE10", VA = "0x187DB0210")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB01C0", Offset = "0x7DAEDC0", VA = "0x187DB01C0")]
		public void SetParentAlignment(KHNEAFIHNDK rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFFC0", Offset = "0x7DAEBC0", VA = "0x187DAFFC0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0020", Offset = "0x7DAEC20", VA = "0x187DB0020")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFFB0", Offset = "0x7DAEBB0", VA = "0x187DAFFB0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0310", Offset = "0x7DAEF10", VA = "0x187DB0310")]
		private LIDPPAMAIHI UpdateCache()
		{
			return default(LIDPPAMAIHI);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LIDPPAMAIHI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PPFJFBJKCCC
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] IGOEOFDDHIM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0840", Offset = "0x7DAF440", VA = "0x187DB0840")]
	public static float2Rect LLNMBNGBPOK(Transform IIFLEGNOOAO, RectTransform MDKAAPLMLKG)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0780", Offset = "0x7DAF380", VA = "0x187DB0780")]
	public static void GBKHGHLDGAC(Vector3[] IAKDDHHKPOJ, [Out] float2 PNMBBJAACMD, [Out] float2 LMOAHCJOHNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LNIKCMBCJMD
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] PDHPOKPDHDD;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DAFDC0", Offset = "0x7DAE9C0", VA = "0x187DAFDC0")]
	public static void EDGHGFPJNAA([In] int BFCEKPHAMNP, [Out] ushort FCCMJCPLOIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DFKOFIBFCMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PFJJHDNCCPF
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
	[Cpp2IlInjected.Address(RVA = "0x7DAEAF0", Offset = "0x7DAD6F0", VA = "0x187DAEAF0")]
	public static void FGPOPFIDKAG(float3[] NNLBKOKAHPO, [In] float2 OANAHOGHDLN, [In] float2 BJLPHNOPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DAFBB0", Offset = "0x7DAE7B0", VA = "0x187DAFBB0")]
	public static void PFMFPMCCHLE(float2[] JOFDIPMMPKO, [In] float2 AADDDHJHNKA, [In] float2 DFDHPILCMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE700", Offset = "0x7DAD300", VA = "0x187DAE700")]
	public static void AKLIFOLPGNP(float3[] NNLBKOKAHPO, [In] float CJEBDANLHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF990", Offset = "0x7DAE590", VA = "0x187DAF990")]
	public static void OIIAJAPDBJJ(QuadVertex[] MBBCPOLJNAB, [In] int FCCMJCPLOIA, [In] float3[] CFJHFAANALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7DAED70", Offset = "0x7DAD970", VA = "0x187DAED70")]
	public static void KGMDLINEOGO(QuadVertex[] MBBCPOLJNAB, int FCCMJCPLOIA, [In] float3[] CFJHFAANALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE960", Offset = "0x7DAD560", VA = "0x187DAE960")]
	public static void ECBJPCIGFAI(QuadVertex[] MBBCPOLJNAB, [In] int FCCMJCPLOIA, [In] Color32 HPADFEECFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF680", Offset = "0x7DAE280", VA = "0x187DAF680")]
	public static void MPJGKBCGLOL(QuadVertex[] MBBCPOLJNAB, int FCCMJCPLOIA, [In] Color32 HPADFEECFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE9E0", Offset = "0x7DAD5E0", VA = "0x187DAE9E0")]
	public static void EFOOFGCNPAN(QuadVertex[] MBBCPOLJNAB, [In] int FCCMJCPLOIA, [In] float2[] GNPCKIPNNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DAFAA0", Offset = "0x7DAE6A0", VA = "0x187DAFAA0")]
	public static void PDBPNOAKKFM(QuadVertex[] MBBCPOLJNAB, int FCCMJCPLOIA, [In] float2[] GNPCKIPNNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DAEBF0", Offset = "0x7DAD7F0", VA = "0x187DAEBF0")]
	public static void JKMKHAOCDCC(QuadVertex[] MBBCPOLJNAB, int FCCMJCPLOIA, [In] float3[] CFJHFAANALF, [In] Color32 HPADFEECFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF460", Offset = "0x7DAE060", VA = "0x187DAF460")]
	public static void MPHLKPFJGHF(QuadVertex[] MBBCPOLJNAB, int FCCMJCPLOIA, [In] float3[] CFJHFAANALF, [In] float2[] GNPCKIPNNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7DAFC40", Offset = "0x7DAE840", VA = "0x187DAFC40")]
	public static void PLOEODFFCDL(QuadVertex[] MBBCPOLJNAB, int FCCMJCPLOIA, [In] Color32 HPADFEECFAF, [In] float2[] GNPCKIPNNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF700", Offset = "0x7DAE300", VA = "0x187DAF700")]
	public static void ODGOEIBAGGB(QuadVertex[] MBBCPOLJNAB, int FCCMJCPLOIA, [In] float3[] CFJHFAANALF, [In] Color32 HPADFEECFAF, [In] float2[] GNPCKIPNNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE830", Offset = "0x7DAD430", VA = "0x187DAE830")]
	public static void CEMFBEMNANH(ushort[] FLIFHFICJGG, int BFCEKPHAMNP, [In] int JMLHEPMMFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE6C0", Offset = "0x7DAD2C0", VA = "0x187DAE6C0")]
	public static void AELEBHGMEEH(ushort[] FLIFHFICJGG, int BFCEKPHAMNP, [In] int JMLHEPMMFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF190", Offset = "0x7DADD90", VA = "0x187DAF190")]
	public static void MDPFOAFKHOD(ushort[] FLIFHFICJGG, [In] int BFCEKPHAMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE770", Offset = "0x7DAD370", VA = "0x187DAE770")]
	public static void BCGALAKAKGJ(ushort[] FLIFHFICJGG, [In] int BFCEKPHAMNP, [In] int FCCMJCPLOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF220", Offset = "0x7DADE20", VA = "0x187DAF220")]
	public static Bounds MKFPGNNCADH([In] QuadVertex[] MBBCPOLJNAB, [In] ushort[] FLIFHFICJGG, [In] int OPCDABPGOMN)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7DAEE80", Offset = "0x7DADA80", VA = "0x187DAEE80")]
	public static Bounds LMFIGCIAENK([In] QuadVertex[] MBBCPOLJNAB, [In] ushort[] FLIFHFICJGG, [In] int OPCDABPGOMN)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DAEB70", Offset = "0x7DAD770", VA = "0x187DAEB70")]
	[CompilerGenerated]
	internal static void FNIDMLEKAGO([In] float3 MBEDIGACNGC, PFJJHDNCCPF P_1)
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
