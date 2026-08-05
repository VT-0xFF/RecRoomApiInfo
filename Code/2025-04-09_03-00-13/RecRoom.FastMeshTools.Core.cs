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
public static class DAAGACKMFEN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x78BA500", Offset = "0x78B9900", VA = "0x1878BA500")]
	public static float2 NAJGBCFKOMH(this OEEIIIJHEPF DCGHHJDPIEN)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OEEIIIJHEPF : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2CD8010", Offset = "0x2CD7410", VA = "0x182CD8010")]
		public float2Rect(float2 INHMOEHIHAJ, float2 MNDMOIHIBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78BD1C0", Offset = "0x78BC5C0", VA = "0x1878BD1C0")]
		public void LKJBGMAPBIG([Out] float2 KBHOOBIANKJ, [Out] float2 MPOIBIENOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78BCF60", Offset = "0x78BC360", VA = "0x1878BCF60")]
		public float2 DNIMEPDAFKK(float2 IGKMOOCLPGG)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x78BCF90", Offset = "0x78BC390", VA = "0x1878BCF90", Slot = "4")]
		public bool Equals(float2Rect KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x78BD010", Offset = "0x78BC410", VA = "0x1878BD010", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x78BD110", Offset = "0x78BC510", VA = "0x1878BD110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78BD1E0", Offset = "0x78BC5E0", VA = "0x1878BD1E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78BD400", Offset = "0x78BC800", VA = "0x1878BD400", Slot = "5")]
		public string ToString(string HJPPOILPOFH, IFormatProvider KIABGCJLOID)
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
		[Cpp2IlInjected.Address(RVA = "0x78BD840", Offset = "0x78BCC40", VA = "0x1878BD840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x78BD7B0", Offset = "0x78BCBB0", VA = "0x1878BD7B0", Slot = "6")]
		public string ToString(string HJPPOILPOFH, IFormatProvider KIABGCJLOID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78BD610", Offset = "0x78BCA10", VA = "0x1878BD610", Slot = "4")]
		public bool Equals(floatMinMax KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x78BD700", Offset = "0x78BCB00", VA = "0x1878BD700", Slot = "5")]
		public bool Equals(float2 KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78BD650", Offset = "0x78BCA50", VA = "0x1878BD650", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78BD730", Offset = "0x78BCB30", VA = "0x1878BD730", Slot = "2")]
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
		private LLELBAIBGHE cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78BCCD0", Offset = "0x78BC0D0", VA = "0x1878BCCD0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78BCB80", Offset = "0x78BBF80", VA = "0x1878BCB80")]
		public LayoutRect(LayoutRect parent, OEEIIIJHEPF parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78BC640", Offset = "0x78BBA40", VA = "0x1878BC640")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78BC5A0", Offset = "0x78BB9A0", VA = "0x1878BC5A0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78BC610", Offset = "0x78BBA10", VA = "0x1878BC610")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78BC5B0", Offset = "0x78BB9B0", VA = "0x1878BC5B0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78BC750", Offset = "0x78BBB50", VA = "0x1878BC750")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78BA7E0", Offset = "0x78B9BE0", VA = "0x1878BA7E0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x78BC850", Offset = "0x78BBC50", VA = "0x1878BC850")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78BC800", Offset = "0x78BBC00", VA = "0x1878BC800")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x78BC7B0", Offset = "0x78BBBB0", VA = "0x1878BC7B0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78BC900", Offset = "0x78BBD00", VA = "0x1878BC900")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78BC8B0", Offset = "0x78BBCB0", VA = "0x1878BC8B0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78BC860", Offset = "0x78BBC60", VA = "0x1878BC860")]
		public void SetParentAlignment(OEEIIIJHEPF rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78BC660", Offset = "0x78BBA60", VA = "0x1878BC660")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78BC6C0", Offset = "0x78BBAC0", VA = "0x1878BC6C0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78BC650", Offset = "0x78BBA50", VA = "0x1878BC650")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x78BC9B0", Offset = "0x78BBDB0", VA = "0x1878BC9B0")]
		private LLELBAIBGHE UpdateCache()
		{
			return default(LLELBAIBGHE);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LLELBAIBGHE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CCHKPCIDMKL
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] OHMFFJDENHH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x78BA920", Offset = "0x78B9D20", VA = "0x1878BA920")]
	public static float2Rect AEGHJHIOCOL(Transform NKFGIOFCPCC, RectTransform IGICHEAKAKH)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x78BAC30", Offset = "0x78BA030", VA = "0x1878BAC30")]
	public static void IPNMOIDIBKH(Vector3[] DNFPCNKCEDH, [Out] float2 GCDIMBKCOPF, [Out] float2 IPOFNNMKDAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OJABDACDNPP
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] BDKHPMIEJGE;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x78BCE20", Offset = "0x78BC220", VA = "0x1878BCE20")]
	public static void AOPBGCICJKF([In] int IDCFCHLNIFD, [Out] ushort AGBILMLPMMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CFBCFHBEDPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct INJAFLPBGHG
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
	[Cpp2IlInjected.Address(RVA = "0x78BC250", Offset = "0x78BB650", VA = "0x1878BC250")]
	public static void LLMLFDMJGPB(float3[] FHPGENAFOLA, [In] float2 HPINJNBPIDE, [In] float2 MPOIBIENOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x78BB0B0", Offset = "0x78BA4B0", VA = "0x1878BB0B0")]
	public static void DGBIOIECEOC(float2[] IAIIPNHLMPM, [In] float2 DGJHBOFIEAE, [In] float2 KEKHHMEFBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x78BADA0", Offset = "0x78BA1A0", VA = "0x1878BADA0")]
	public static void CDNKEPPIMBG(float3[] FHPGENAFOLA, [In] float GEHHPFPIGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x78BBD80", Offset = "0x78BB180", VA = "0x1878BBD80")]
	public static void KBILIOBJAIN(QuadVertex[] FOMFBIDEHFE, [In] int AGBILMLPMMA, [In] float3[] CBLHPCMDFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x78BB410", Offset = "0x78BA810", VA = "0x1878BB410")]
	public static void EDPJFKIHOHI(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] float3[] CBLHPCMDFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x78BBD00", Offset = "0x78BB100", VA = "0x1878BBD00")]
	public static void JMJCLIAGKHN(QuadVertex[] FOMFBIDEHFE, [In] int AGBILMLPMMA, [In] Color32 GJLDGODDDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x78BC2D0", Offset = "0x78BB6D0", VA = "0x1878BC2D0")]
	public static void OJNEMCMDEPL(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] Color32 GJLDGODDDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x78BC350", Offset = "0x78BB750", VA = "0x1878BC350")]
	public static void PGOHGJLLLEE(QuadVertex[] FOMFBIDEHFE, [In] int AGBILMLPMMA, [In] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x78BB300", Offset = "0x78BA700", VA = "0x1878BB300")]
	public static void DLDEINKPLHP(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x78BB870", Offset = "0x78BAC70", VA = "0x1878BB870")]
	public static void HOBPPHNIALE(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] float3[] CBLHPCMDFGF, [In] Color32 GJLDGODDDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x78BAE90", Offset = "0x78BA290", VA = "0x1878BAE90")]
	public static void CKKILHPKNME(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] float3[] CBLHPCMDFGF, [In] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x78BBE90", Offset = "0x78BB290", VA = "0x1878BBE90")]
	public static void KMHNHMFLKMP(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] Color32 GJLDGODDDLD, [In] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x78BB520", Offset = "0x78BA920", VA = "0x1878BB520")]
	public static void ELKKHPGEGMD(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] float3[] CBLHPCMDFGF, [In] Color32 GJLDGODDDLD, [In] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x78BB1D0", Offset = "0x78BA5D0", VA = "0x1878BB1D0")]
	public static void DKIDCCOOMAN(ushort[] JOADPFBHFNF, int IDCFCHLNIFD, [In] int MKKIKGIPBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x78BAD60", Offset = "0x78BA160", VA = "0x1878BAD60")]
	public static void BIPILJOGKEA(ushort[] JOADPFBHFNF, int IDCFCHLNIFD, [In] int MKKIKGIPBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x78BB140", Offset = "0x78BA540", VA = "0x1878BB140")]
	public static void DIKGNNJLECD(ushort[] JOADPFBHFNF, [In] int IDCFCHLNIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x78BB7B0", Offset = "0x78BABB0", VA = "0x1878BB7B0")]
	public static void GFDCPCMIODN(ushort[] JOADPFBHFNF, [In] int IDCFCHLNIFD, [In] int AGBILMLPMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x78BC010", Offset = "0x78BB410", VA = "0x1878BC010")]
	public static Bounds KPONDKLIFCK([In] QuadVertex[] FOMFBIDEHFE, [In] ushort[] JOADPFBHFNF, [In] int IFPLNDDMJMO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x78BB9F0", Offset = "0x78BADF0", VA = "0x1878BB9F0")]
	public static Bounds IDENDBJGKBH([In] QuadVertex[] FOMFBIDEHFE, [In] ushort[] JOADPFBHFNF, [In] int IFPLNDDMJMO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x78BAE10", Offset = "0x78BA210", VA = "0x1878BAE10")]
	[CompilerGenerated]
	internal static void CKAJMKDNMDP([In] float3 ICNDIBLBLJD, INJAFLPBGHG P_1)
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
