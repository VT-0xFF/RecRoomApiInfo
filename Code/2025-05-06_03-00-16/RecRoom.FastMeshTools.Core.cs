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
public static class EIIJFDMDCNN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B10240", Offset = "0x7B0EA40", VA = "0x187B10240")]
	public static float2 JODGDKBCOJA(this GFHGBNLPLPF JIBKMPCNJBE)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GFHGBNLPLPF : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2DC3380", Offset = "0x2DC1B80", VA = "0x182DC3380")]
		public float2Rect(float2 NCGKJMOKFAF, float2 LBLAFDELPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B12E20", Offset = "0x7B11620", VA = "0x187B12E20")]
		public void GBLJIMIKPOB([Out] float2 ADPKADHEKGH, [Out] float2 NGHGHOJNKFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B12EF0", Offset = "0x7B116F0", VA = "0x187B12EF0")]
		public float2 OHMGDJOJKKE(float2 OMOKHEODFDD)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B12CA0", Offset = "0x7B114A0", VA = "0x187B12CA0", Slot = "4")]
		public bool Equals(float2Rect PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B12D20", Offset = "0x7B11520", VA = "0x187B12D20", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B12E40", Offset = "0x7B11640", VA = "0x187B12E40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B12F20", Offset = "0x7B11720", VA = "0x187B12F20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B13140", Offset = "0x7B11940", VA = "0x187B13140", Slot = "5")]
		public string ToString(string CGJBGKAIMNA, IFormatProvider AFAOOFNPIHH)
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
		[Cpp2IlInjected.Address(RVA = "0x7B13580", Offset = "0x7B11D80", VA = "0x187B13580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B134F0", Offset = "0x7B11CF0", VA = "0x187B134F0", Slot = "6")]
		public string ToString(string CGJBGKAIMNA, IFormatProvider AFAOOFNPIHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B13350", Offset = "0x7B11B50", VA = "0x187B13350", Slot = "4")]
		public bool Equals(floatMinMax PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B13440", Offset = "0x7B11C40", VA = "0x187B13440", Slot = "5")]
		public bool Equals(float2 PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B13390", Offset = "0x7B11B90", VA = "0x187B13390", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B13470", Offset = "0x7B11C70", VA = "0x187B13470", Slot = "2")]
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
		private LGCENPBLKCF cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B10EC0", Offset = "0x7B0F6C0", VA = "0x187B10EC0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B11010", Offset = "0x7B0F810", VA = "0x187B11010")]
		public LayoutRect(LayoutRect parent, GFHGBNLPLPF parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7B10980", Offset = "0x7B0F180", VA = "0x187B10980")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B108E0", Offset = "0x7B0F0E0", VA = "0x187B108E0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B10950", Offset = "0x7B0F150", VA = "0x187B10950")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B108F0", Offset = "0x7B0F0F0", VA = "0x187B108F0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B10A90", Offset = "0x7B0F290", VA = "0x187B10A90")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B10340", Offset = "0x7B0EB40", VA = "0x187B10340")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B10B90", Offset = "0x7B0F390", VA = "0x187B10B90")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B10B40", Offset = "0x7B0F340", VA = "0x187B10B40")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B10AF0", Offset = "0x7B0F2F0", VA = "0x187B10AF0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B10C40", Offset = "0x7B0F440", VA = "0x187B10C40")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B10BF0", Offset = "0x7B0F3F0", VA = "0x187B10BF0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B10BA0", Offset = "0x7B0F3A0", VA = "0x187B10BA0")]
		public void SetParentAlignment(GFHGBNLPLPF rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B109A0", Offset = "0x7B0F1A0", VA = "0x187B109A0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7B10A00", Offset = "0x7B0F200", VA = "0x187B10A00")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B10990", Offset = "0x7B0F190", VA = "0x187B10990")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B10CF0", Offset = "0x7B0F4F0", VA = "0x187B10CF0")]
		private LGCENPBLKCF UpdateCache()
		{
			return default(LGCENPBLKCF);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LGCENPBLKCF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NNBIBDFEHDF
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] KIFNMCJFCHP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B11220", Offset = "0x7B0FA20", VA = "0x187B11220")]
	public static float2Rect OMJKDPPJAPN(Transform LEHIIFAEICB, RectTransform ALLFIKNKLHM)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B11160", Offset = "0x7B0F960", VA = "0x187B11160")]
	public static void ENOBDIMJBIB(Vector3[] LLEIJPOEKFM, [Out] float2 EDGENFDJJHO, [Out] float2 FGNFJAMALCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JPNJJHAEPGB
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] OPJJILCLBOL;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B107A0", Offset = "0x7B0EFA0", VA = "0x187B107A0")]
	public static void AHNFHPLNJAM([In] int KIEDCDNGGDK, [Out] ushort MCLONLMPEAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PPLODDEJBID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KFKIHKAJLJO
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
	[Cpp2IlInjected.Address(RVA = "0x7B12BE0", Offset = "0x7B113E0", VA = "0x187B12BE0")]
	public static void PAJMNBKMPOL(float3[] IPFEFJFMIIO, [In] float2 DFPCJBPJBMI, [In] float2 NGHGHOJNKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B12220", Offset = "0x7B10A20", VA = "0x187B12220")]
	public static void HDFDADMJMJP(float2[] JGHAOHEBMDK, [In] float2 DPMJCCLLCLN, [In] float2 CFKPCJDHLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B118D0", Offset = "0x7B100D0", VA = "0x187B118D0")]
	public static void DCFIDEAICAB(float3[] IPFEFJFMIIO, [In] float LHJMCOBAOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B117C0", Offset = "0x7B0FFC0", VA = "0x187B117C0")]
	public static void CIFKJAJJGHP(QuadVertex[] LIHIDAINJML, [In] int MCLONLMPEAD, [In] float3[] OHNOHNOLEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B12000", Offset = "0x7B10800", VA = "0x187B12000")]
	public static void GHMKANMJIMA(QuadVertex[] LIHIDAINJML, int MCLONLMPEAD, [In] float3[] OHNOHNOLEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B12B60", Offset = "0x7B11360", VA = "0x187B12B60")]
	public static void NLMGBIKJAOA(QuadVertex[] LIHIDAINJML, [In] int MCLONLMPEAD, [In] Color32 FCEDFGDABOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B12700", Offset = "0x7B10F00", VA = "0x187B12700")]
	public static void LDCGDCJNGCN(QuadVertex[] LIHIDAINJML, int MCLONLMPEAD, [In] Color32 FCEDFGDABOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B12110", Offset = "0x7B10910", VA = "0x187B12110")]
	public static void HCKBIJKEKEA(QuadVertex[] LIHIDAINJML, [In] int MCLONLMPEAD, [In] float2[] MGJIDPJJPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B12810", Offset = "0x7B11010", VA = "0x187B12810")]
	public static void NEEEAJAJMBN(QuadVertex[] LIHIDAINJML, int MCLONLMPEAD, [In] float2[] MGJIDPJJPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B11BF0", Offset = "0x7B103F0", VA = "0x187B11BF0")]
	public static void FAOMEAHOJAK(QuadVertex[] LIHIDAINJML, int MCLONLMPEAD, [In] float3[] OHNOHNOLEOD, [In] Color32 FCEDFGDABOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B115A0", Offset = "0x7B0FDA0", VA = "0x187B115A0")]
	public static void BKGFLFDMEEH(QuadVertex[] LIHIDAINJML, int MCLONLMPEAD, [In] float3[] OHNOHNOLEOD, [In] float2[] MGJIDPJJPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B11A70", Offset = "0x7B10270", VA = "0x187B11A70")]
	public static void EFKPCLABLNL(QuadVertex[] LIHIDAINJML, int MCLONLMPEAD, [In] Color32 FCEDFGDABOI, [In] float2[] MGJIDPJJPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B11D70", Offset = "0x7B10570", VA = "0x187B11D70")]
	public static void GHLLEBBOKNG(QuadVertex[] LIHIDAINJML, int MCLONLMPEAD, [In] float3[] OHNOHNOLEOD, [In] Color32 FCEDFGDABOI, [In] float2[] MGJIDPJJPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B11940", Offset = "0x7B10140", VA = "0x187B11940")]
	public static void DDIAMNAECEJ(ushort[] MAKHNJGJMCI, int KIEDCDNGGDK, [In] int CNGPDKONKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B12C60", Offset = "0x7B11460", VA = "0x187B12C60")]
	public static void PCFEGHFLAGD(ushort[] MAKHNJGJMCI, int KIEDCDNGGDK, [In] int CNGPDKONKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B12780", Offset = "0x7B10F80", VA = "0x187B12780")]
	public static void LPIGKAPDFDA(ushort[] MAKHNJGJMCI, [In] int KIEDCDNGGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B125C0", Offset = "0x7B10DC0", VA = "0x187B125C0")]
	public static void JEBFIMCPDCL(ushort[] MAKHNJGJMCI, [In] int KIEDCDNGGDK, [In] int MCLONLMPEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B12920", Offset = "0x7B11120", VA = "0x187B12920")]
	public static Bounds NLBONCMNECG([In] QuadVertex[] LIHIDAINJML, [In] ushort[] MAKHNJGJMCI, [In] int LLCEPGLCJOJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7B122B0", Offset = "0x7B10AB0", VA = "0x187B122B0")]
	public static Bounds JAMJBKPJPGD([In] QuadVertex[] LIHIDAINJML, [In] ushort[] MAKHNJGJMCI, [In] int LLCEPGLCJOJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B12680", Offset = "0x7B10E80", VA = "0x187B12680")]
	[CompilerGenerated]
	internal static void JLOLEDLHDGC([In] float3 GOHMPMCJCDD, KFKIHKAJLJO P_1)
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
