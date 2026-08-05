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
	[Cpp2IlInjected.Address(RVA = "0x786D540", Offset = "0x786C940", VA = "0x18786D540")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CDD680", Offset = "0x2CDCA80", VA = "0x182CDD680")]
		public float2Rect(float2 INHMOEHIHAJ, float2 MNDMOIHIBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7870220", Offset = "0x786F620", VA = "0x187870220")]
		public void LKJBGMAPBIG([Out] float2 KBHOOBIANKJ, [Out] float2 MPOIBIENOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x786FFC0", Offset = "0x786F3C0", VA = "0x18786FFC0")]
		public float2 DNIMEPDAFKK(float2 IGKMOOCLPGG)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x786FFF0", Offset = "0x786F3F0", VA = "0x18786FFF0", Slot = "4")]
		public bool Equals(float2Rect KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7870070", Offset = "0x786F470", VA = "0x187870070", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7870170", Offset = "0x786F570", VA = "0x187870170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7870240", Offset = "0x786F640", VA = "0x187870240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7870460", Offset = "0x786F860", VA = "0x187870460", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x78708A0", Offset = "0x786FCA0", VA = "0x1878708A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7870810", Offset = "0x786FC10", VA = "0x187870810", Slot = "6")]
		public string ToString(string HJPPOILPOFH, IFormatProvider KIABGCJLOID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7870670", Offset = "0x786FA70", VA = "0x187870670", Slot = "4")]
		public bool Equals(floatMinMax KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7870760", Offset = "0x786FB60", VA = "0x187870760", Slot = "5")]
		public bool Equals(float2 KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78706B0", Offset = "0x786FAB0", VA = "0x1878706B0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7870790", Offset = "0x786FB90", VA = "0x187870790", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x786FD20", Offset = "0x786F120", VA = "0x18786FD20")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x786FBD0", Offset = "0x786EFD0", VA = "0x18786FBD0")]
		public LayoutRect(LayoutRect parent, OEEIIIJHEPF parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x786F690", Offset = "0x786EA90", VA = "0x18786F690")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x786F5F0", Offset = "0x786E9F0", VA = "0x18786F5F0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x786F660", Offset = "0x786EA60", VA = "0x18786F660")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x786F600", Offset = "0x786EA00", VA = "0x18786F600")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x786F7A0", Offset = "0x786EBA0", VA = "0x18786F7A0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x786D820", Offset = "0x786CC20", VA = "0x18786D820")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x786F8A0", Offset = "0x786ECA0", VA = "0x18786F8A0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x786F850", Offset = "0x786EC50", VA = "0x18786F850")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x786F800", Offset = "0x786EC00", VA = "0x18786F800")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x786F950", Offset = "0x786ED50", VA = "0x18786F950")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x786F900", Offset = "0x786ED00", VA = "0x18786F900")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x786F8B0", Offset = "0x786ECB0", VA = "0x18786F8B0")]
		public void SetParentAlignment(OEEIIIJHEPF rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x786F6B0", Offset = "0x786EAB0", VA = "0x18786F6B0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x786F710", Offset = "0x786EB10", VA = "0x18786F710")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x786F6A0", Offset = "0x786EAA0", VA = "0x18786F6A0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x786FA00", Offset = "0x786EE00", VA = "0x18786FA00")]
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
	[Cpp2IlInjected.Address(RVA = "0x786D960", Offset = "0x786CD60", VA = "0x18786D960")]
	public static float2Rect AEGHJHIOCOL(Transform NKFGIOFCPCC, RectTransform IGICHEAKAKH)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x786DC80", Offset = "0x786D080", VA = "0x18786DC80")]
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
	[Cpp2IlInjected.Address(RVA = "0x786FE70", Offset = "0x786F270", VA = "0x18786FE70")]
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
	[Cpp2IlInjected.Address(RVA = "0x786F2A0", Offset = "0x786E6A0", VA = "0x18786F2A0")]
	public static void LLMLFDMJGPB(float3[] FHPGENAFOLA, [In] float2 HPINJNBPIDE, [In] float2 MPOIBIENOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x786E100", Offset = "0x786D500", VA = "0x18786E100")]
	public static void DGBIOIECEOC(float2[] IAIIPNHLMPM, [In] float2 DGJHBOFIEAE, [In] float2 KEKHHMEFBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x786DDF0", Offset = "0x786D1F0", VA = "0x18786DDF0")]
	public static void CDNKEPPIMBG(float3[] FHPGENAFOLA, [In] float GEHHPFPIGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x786EDD0", Offset = "0x786E1D0", VA = "0x18786EDD0")]
	public static void KBILIOBJAIN(QuadVertex[] FOMFBIDEHFE, [In] int AGBILMLPMMA, [In] float3[] CBLHPCMDFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x786E460", Offset = "0x786D860", VA = "0x18786E460")]
	public static void EDPJFKIHOHI(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] float3[] CBLHPCMDFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x786ED50", Offset = "0x786E150", VA = "0x18786ED50")]
	public static void JMJCLIAGKHN(QuadVertex[] FOMFBIDEHFE, [In] int AGBILMLPMMA, [In] Color32 GJLDGODDDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x786F320", Offset = "0x786E720", VA = "0x18786F320")]
	public static void OJNEMCMDEPL(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] Color32 GJLDGODDDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x786F3A0", Offset = "0x786E7A0", VA = "0x18786F3A0")]
	public static void PGOHGJLLLEE(QuadVertex[] FOMFBIDEHFE, [In] int AGBILMLPMMA, [In] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x786E350", Offset = "0x786D750", VA = "0x18786E350")]
	public static void DLDEINKPLHP(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x786E8C0", Offset = "0x786DCC0", VA = "0x18786E8C0")]
	public static void HOBPPHNIALE(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] float3[] CBLHPCMDFGF, [In] Color32 GJLDGODDDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x786DEE0", Offset = "0x786D2E0", VA = "0x18786DEE0")]
	public static void CKKILHPKNME(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] float3[] CBLHPCMDFGF, [In] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x786EEE0", Offset = "0x786E2E0", VA = "0x18786EEE0")]
	public static void KMHNHMFLKMP(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] Color32 GJLDGODDDLD, [In] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x786E570", Offset = "0x786D970", VA = "0x18786E570")]
	public static void ELKKHPGEGMD(QuadVertex[] FOMFBIDEHFE, int AGBILMLPMMA, [In] float3[] CBLHPCMDFGF, [In] Color32 GJLDGODDDLD, [In] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x786E220", Offset = "0x786D620", VA = "0x18786E220")]
	public static void DKIDCCOOMAN(ushort[] JOADPFBHFNF, int IDCFCHLNIFD, [In] int MKKIKGIPBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x786DDB0", Offset = "0x786D1B0", VA = "0x18786DDB0")]
	public static void BIPILJOGKEA(ushort[] JOADPFBHFNF, int IDCFCHLNIFD, [In] int MKKIKGIPBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x786E190", Offset = "0x786D590", VA = "0x18786E190")]
	public static void DIKGNNJLECD(ushort[] JOADPFBHFNF, [In] int IDCFCHLNIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x786E800", Offset = "0x786DC00", VA = "0x18786E800")]
	public static void GFDCPCMIODN(ushort[] JOADPFBHFNF, [In] int IDCFCHLNIFD, [In] int AGBILMLPMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x786F060", Offset = "0x786E460", VA = "0x18786F060")]
	public static Bounds KPONDKLIFCK([In] QuadVertex[] FOMFBIDEHFE, [In] ushort[] JOADPFBHFNF, [In] int IFPLNDDMJMO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x786EA40", Offset = "0x786DE40", VA = "0x18786EA40")]
	public static Bounds IDENDBJGKBH([In] QuadVertex[] FOMFBIDEHFE, [In] ushort[] JOADPFBHFNF, [In] int IFPLNDDMJMO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x786DE60", Offset = "0x786D260", VA = "0x18786DE60")]
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
