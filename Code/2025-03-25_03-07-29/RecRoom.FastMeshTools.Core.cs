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
public static class HPFAPPKGLBF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x77FD030", Offset = "0x77FC430", VA = "0x1877FD030")]
	public static float2 DCNGCNBGIAH(this FDINCONJAAP ELGGFJBNPLB)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FDINCONJAAP : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2CABFB0", Offset = "0x2CAB3B0", VA = "0x182CABFB0")]
		public float2Rect(float2 JPKKPDPLAGA, float2 EOKAMHLPIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77FFCF0", Offset = "0x77FF0F0", VA = "0x1877FFCF0")]
		public void KGKDCLGKMAN([Out] float2 LGPNGNCLOBL, [Out] float2 JHKPAJHJHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x77FFA90", Offset = "0x77FEE90", VA = "0x1877FFA90")]
		public float2 EGPEBHDDJIC(float2 OBODFKIOOEE)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x77FFAC0", Offset = "0x77FEEC0", VA = "0x1877FFAC0", Slot = "4")]
		public bool Equals(float2Rect JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77FFB40", Offset = "0x77FEF40", VA = "0x1877FFB40", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77FFC40", Offset = "0x77FF040", VA = "0x1877FFC40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77FFD10", Offset = "0x77FF110", VA = "0x1877FFD10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77FFF30", Offset = "0x77FF330", VA = "0x1877FFF30", Slot = "5")]
		public string ToString(string LMHNLPFPEOI, IFormatProvider JLCNNKJMBCG)
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
		[Cpp2IlInjected.Address(RVA = "0x7800380", Offset = "0x77FF780", VA = "0x187800380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x78002F0", Offset = "0x77FF6F0", VA = "0x1878002F0", Slot = "6")]
		public string ToString(string LMHNLPFPEOI, IFormatProvider JLCNNKJMBCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7800150", Offset = "0x77FF550", VA = "0x187800150", Slot = "4")]
		public bool Equals(floatMinMax JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7800240", Offset = "0x77FF640", VA = "0x187800240", Slot = "5")]
		public bool Equals(float2 JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7800190", Offset = "0x77FF590", VA = "0x187800190", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7800270", Offset = "0x77FF670", VA = "0x187800270", Slot = "2")]
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
		private LDLDDCEJDAC cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77FF3B0", Offset = "0x77FE7B0", VA = "0x1877FF3B0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77FF500", Offset = "0x77FE900", VA = "0x1877FF500")]
		public LayoutRect(LayoutRect parent, FDINCONJAAP parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x77FEE70", Offset = "0x77FE270", VA = "0x1877FEE70")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77FEDD0", Offset = "0x77FE1D0", VA = "0x1877FEDD0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x77FEE40", Offset = "0x77FE240", VA = "0x1877FEE40")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x77FEDE0", Offset = "0x77FE1E0", VA = "0x1877FEDE0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x77FEF80", Offset = "0x77FE380", VA = "0x1877FEF80")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77FD130", Offset = "0x77FC530", VA = "0x1877FD130")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77FF080", Offset = "0x77FE480", VA = "0x1877FF080")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x77FF030", Offset = "0x77FE430", VA = "0x1877FF030")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x77FEFE0", Offset = "0x77FE3E0", VA = "0x1877FEFE0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x77FF130", Offset = "0x77FE530", VA = "0x1877FF130")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x77FF0E0", Offset = "0x77FE4E0", VA = "0x1877FF0E0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x77FF090", Offset = "0x77FE490", VA = "0x1877FF090")]
		public void SetParentAlignment(FDINCONJAAP rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77FEE90", Offset = "0x77FE290", VA = "0x1877FEE90")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77FEEF0", Offset = "0x77FE2F0", VA = "0x1877FEEF0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x77FEE80", Offset = "0x77FE280", VA = "0x1877FEE80")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x77FF1E0", Offset = "0x77FE5E0", VA = "0x1877FF1E0")]
		private LDLDDCEJDAC UpdateCache()
		{
			return default(LDLDDCEJDAC);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LDLDDCEJDAC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NHMDHKJHIAA
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] JKBFPBHBOKG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77FF710", Offset = "0x77FEB10", VA = "0x1877FF710")]
	public static float2Rect NICODKKFADI(Transform BDICADMHCHB, RectTransform JMBMDICGCNK)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77FF650", Offset = "0x77FEA50", VA = "0x1877FF650")]
	public static void FBEAAKKKAPP(Vector3[] MPPHDOOPLDD, [Out] float2 IPECBHNLFPB, [Out] float2 HJCBHKAGEBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DHMFJCIKMCH
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] DKABHLEFPGO;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x77FD590", Offset = "0x77FC990", VA = "0x1877FD590")]
	public static void KHKBKOLJMPA([In] int DODBAOMEKEO, [Out] ushort CPCIKCGFHPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KMLFIOAFFNI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CAEJHOIOLEC
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
	[Cpp2IlInjected.Address(RVA = "0x77FDC60", Offset = "0x77FD060", VA = "0x1877FDC60")]
	public static void FCBINPABJOK(float3[] JFANBPIKJAM, [In] float2 CPBGNJDECNI, [In] float2 JHKPAJHJHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x77FDCE0", Offset = "0x77FD0E0", VA = "0x1877FDCE0")]
	public static void FKNDGDCMJPM(float2[] MMBECHBOFMG, [In] float2 CFLFEIJHBPC, [In] float2 DBNKFMHMFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x77FEB60", Offset = "0x77FDF60", VA = "0x1877FEB60")]
	public static void OFKBIJCLHND(float3[] JFANBPIKJAM, [In] float MOOKCAPPDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x77FDD70", Offset = "0x77FD170", VA = "0x1877FDD70")]
	public static void JLGNOKIIJOH(QuadVertex[] BBDHEFBCMAB, [In] int CPCIKCGFHPI, [In] float3[] MAMMCAKMKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x77FE3B0", Offset = "0x77FD7B0", VA = "0x1877FE3B0")]
	public static void LCFAANMOAOJ(QuadVertex[] BBDHEFBCMAB, int CPCIKCGFHPI, [In] float3[] MAMMCAKMKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x77FDBE0", Offset = "0x77FCFE0", VA = "0x1877FDBE0")]
	public static void DJICBNDOMNF(QuadVertex[] BBDHEFBCMAB, [In] int CPCIKCGFHPI, [In] Color32 OJOAAHKGNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x77FED50", Offset = "0x77FE150", VA = "0x1877FED50")]
	public static void PKFGBOJDPMM(QuadVertex[] BBDHEFBCMAB, int CPCIKCGFHPI, [In] Color32 OJOAAHKGNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x77FDAD0", Offset = "0x77FCED0", VA = "0x1877FDAD0")]
	public static void CNDHFOOJGHE(QuadVertex[] BBDHEFBCMAB, [In] int CPCIKCGFHPI, [In] float2[] IENNICHJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x77FE4C0", Offset = "0x77FD8C0", VA = "0x1877FE4C0")]
	public static void NKJPMBDOIBH(QuadVertex[] BBDHEFBCMAB, int CPCIKCGFHPI, [In] float2[] IENNICHJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x77FEBD0", Offset = "0x77FDFD0", VA = "0x1877FEBD0")]
	public static void OFMJDLKPBCO(QuadVertex[] BBDHEFBCMAB, int CPCIKCGFHPI, [In] float3[] MAMMCAKMKHK, [In] Color32 OJOAAHKGNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x77FDE80", Offset = "0x77FD280", VA = "0x1877FDE80")]
	public static void KENMMMCBJNI(QuadVertex[] BBDHEFBCMAB, int CPCIKCGFHPI, [In] float3[] MAMMCAKMKHK, [In] float2[] IENNICHJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x77FD7A0", Offset = "0x77FCBA0", VA = "0x1877FD7A0")]
	public static void BLOHEEJDPKA(QuadVertex[] BBDHEFBCMAB, int CPCIKCGFHPI, [In] Color32 OJOAAHKGNIH, [In] float2[] IENNICHJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x77FE690", Offset = "0x77FDA90", VA = "0x1877FE690")]
	public static void NOPBALCDHMB(QuadVertex[] BBDHEFBCMAB, int CPCIKCGFHPI, [In] float3[] MAMMCAKMKHK, [In] Color32 OJOAAHKGNIH, [In] float2[] IENNICHJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x77FD9A0", Offset = "0x77FCDA0", VA = "0x1877FD9A0")]
	public static void CLPLPNEDKJL(ushort[] MJGAOOLDKHJ, int DODBAOMEKEO, [In] int OLDAPNIHGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77FD6D0", Offset = "0x77FCAD0", VA = "0x1877FD6D0")]
	public static void BBMDGALCCKN(ushort[] MJGAOOLDKHJ, int DODBAOMEKEO, [In] int OLDAPNIHGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77FD710", Offset = "0x77FCB10", VA = "0x1877FD710")]
	public static void BEJLFFDMCAN(ushort[] MJGAOOLDKHJ, [In] int DODBAOMEKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x77FE5D0", Offset = "0x77FD9D0", VA = "0x1877FE5D0")]
	public static void NLBGPLHMGLB(ushort[] MJGAOOLDKHJ, [In] int DODBAOMEKEO, [In] int CPCIKCGFHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x77FE920", Offset = "0x77FDD20", VA = "0x1877FE920")]
	public static Bounds ODPKCHEFNJL([In] QuadVertex[] BBDHEFBCMAB, [In] ushort[] MJGAOOLDKHJ, [In] int KFHAFKCADFN)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x77FE0A0", Offset = "0x77FD4A0", VA = "0x1877FE0A0")]
	public static Bounds KMMABFBDFMA([In] QuadVertex[] BBDHEFBCMAB, [In] ushort[] MJGAOOLDKHJ, [In] int KFHAFKCADFN)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x77FD920", Offset = "0x77FCD20", VA = "0x1877FD920")]
	[CompilerGenerated]
	internal static void BMAJBEMLPDE([In] float3 GGAJNINGNDF, CAEJHOIOLEC P_1)
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
