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
public static class CGMAMNAFPEE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8156BE0", Offset = "0x8155BE0", VA = "0x188156BE0")]
	public static float2 PBFEBMEGNMM(this HDIJJHIJMFJ IGPKEEKAIIE)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HDIJJHIJMFJ : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2FD8200", Offset = "0x2FD7200", VA = "0x182FD8200")]
		public float2Rect(float2 EBGKGBGFPOC, float2 BKLOHAHJLKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8159890", Offset = "0x8158890", VA = "0x188159890")]
		public void HBLCGHBNJLA([Out] float2 HPHIGCGKBGC, [Out] float2 CJDGEJBIMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81598B0", Offset = "0x81588B0", VA = "0x1881598B0")]
		public float2 LGMLKLMANAH(float2 EABIJEJDHDH)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8159660", Offset = "0x8158660", VA = "0x188159660", Slot = "4")]
		public bool Equals(float2Rect EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81596E0", Offset = "0x81586E0", VA = "0x1881596E0", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81597E0", Offset = "0x81587E0", VA = "0x1881597E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81598E0", Offset = "0x81588E0", VA = "0x1881598E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8159B00", Offset = "0x8158B00", VA = "0x188159B00", Slot = "5")]
		public string ToString(string IEAPGIAMHDB, IFormatProvider MACLOGBKBBE)
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
		[Cpp2IlInjected.Address(RVA = "0x8159F50", Offset = "0x8158F50", VA = "0x188159F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8159EC0", Offset = "0x8158EC0", VA = "0x188159EC0", Slot = "6")]
		public string ToString(string IEAPGIAMHDB, IFormatProvider MACLOGBKBBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8159D20", Offset = "0x8158D20", VA = "0x188159D20", Slot = "4")]
		public bool Equals(floatMinMax EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8159E10", Offset = "0x8158E10", VA = "0x188159E10", Slot = "5")]
		public bool Equals(float2 EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8159D60", Offset = "0x8158D60", VA = "0x188159D60", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8159E40", Offset = "0x8158E40", VA = "0x188159E40", Slot = "2")]
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
		private OHIGBMKPACO cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81593C0", Offset = "0x81583C0", VA = "0x1881593C0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8159510", Offset = "0x8158510", VA = "0x188159510")]
		public LayoutRect(LayoutRect parent, HDIJJHIJMFJ parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8158E80", Offset = "0x8157E80", VA = "0x188158E80")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8158DE0", Offset = "0x8157DE0", VA = "0x188158DE0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8158E50", Offset = "0x8157E50", VA = "0x188158E50")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8158DF0", Offset = "0x8157DF0", VA = "0x188158DF0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8158F90", Offset = "0x8157F90", VA = "0x188158F90")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8156EC0", Offset = "0x8155EC0", VA = "0x188156EC0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8159090", Offset = "0x8158090", VA = "0x188159090")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8159040", Offset = "0x8158040", VA = "0x188159040")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8158FF0", Offset = "0x8157FF0", VA = "0x188158FF0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8159140", Offset = "0x8158140", VA = "0x188159140")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81590F0", Offset = "0x81580F0", VA = "0x1881590F0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81590A0", Offset = "0x81580A0", VA = "0x1881590A0")]
		public void SetParentAlignment(HDIJJHIJMFJ rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8158EA0", Offset = "0x8157EA0", VA = "0x188158EA0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8158F00", Offset = "0x8157F00", VA = "0x188158F00")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8158E90", Offset = "0x8157E90", VA = "0x188158E90")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81591F0", Offset = "0x81581F0", VA = "0x1881591F0")]
		private OHIGBMKPACO UpdateCache()
		{
			return default(OHIGBMKPACO);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OHIGBMKPACO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class ALCFIAOHJHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] LGDPEEJJACH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8157000", Offset = "0x8156000", VA = "0x188157000")]
	public static float2Rect LGBOLANOMJK(Transform MAEHHEPENNN, RectTransform AOJAHPGAGPO)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8157320", Offset = "0x8156320", VA = "0x188157320")]
	public static void PLOBPHPFGFA(Vector3[] OFHKICGNKLD, [Out] float2 IEGNAFDKBMI, [Out] float2 EOMGFLMBKFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GPPFEJPNOEK
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] IDAKCIGPHEF;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8157590", Offset = "0x8156590", VA = "0x188157590")]
	public static void ACPCOIALNMA([In] int NJMKPDIJFLG, [Out] ushort KHPPKPCECOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LCIKKELODAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JMEHLBMJKEB
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
	[Cpp2IlInjected.Address(RVA = "0x81576E0", Offset = "0x81566E0", VA = "0x1881576E0")]
	public static void AEPDLJIHHIO(float3[] FOLFEKOFHAM, [In] float2 MNHNGOGKIAE, [In] float2 CJDGEJBIMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8158190", Offset = "0x8157190", VA = "0x188158190")]
	public static void EIEEHLJOAKA(float2[] ADNLEEEIIMP, [In] float2 GKJAGFKAIKC, [In] float2 PCJBAEKGGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8158AA0", Offset = "0x8157AA0", VA = "0x188158AA0")]
	public static void MMHLBLJPKIM(float3[] FOLFEKOFHAM, [In] float FFKKEIDDPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8157760", Offset = "0x8156760", VA = "0x188157760")]
	public static void AKDACMLGKBF(QuadVertex[] DLHKGDMEECL, [In] int KHPPKPCECOP, [In] float3[] PLBBGPCGMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8158B10", Offset = "0x8157B10", VA = "0x188158B10")]
	public static void OGDAKBHGIEA(QuadVertex[] DLHKGDMEECL, int KHPPKPCECOP, [In] float3[] PLBBGPCGMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8158220", Offset = "0x8157220", VA = "0x188158220")]
	public static void EKNEEIJHGJA(QuadVertex[] DLHKGDMEECL, [In] int KHPPKPCECOP, [In] Color32 ENOHJPBNFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8158790", Offset = "0x8157790", VA = "0x188158790")]
	public static void KPILODFJJDH(QuadVertex[] DLHKGDMEECL, int KHPPKPCECOP, [In] Color32 ENOHJPBNFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8157B30", Offset = "0x8156B30", VA = "0x188157B30")]
	public static void CGMMDPIPPEP(QuadVertex[] DLHKGDMEECL, [In] int KHPPKPCECOP, [In] float2[] IBPBPKFPDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8157D70", Offset = "0x8156D70", VA = "0x188157D70")]
	public static void DIOBFJAAAAB(QuadVertex[] DLHKGDMEECL, int KHPPKPCECOP, [In] float2[] IBPBPKFPDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8158580", Offset = "0x8157580", VA = "0x188158580")]
	public static void IKODPJMIACO(QuadVertex[] DLHKGDMEECL, int KHPPKPCECOP, [In] float3[] PLBBGPCGMEH, [In] Color32 ENOHJPBNFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x81582A0", Offset = "0x81572A0", VA = "0x1881582A0")]
	public static void GCOIBKGOLDO(QuadVertex[] DLHKGDMEECL, int KHPPKPCECOP, [In] float3[] PLBBGPCGMEH, [In] float2[] IBPBPKFPDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8158C20", Offset = "0x8157C20", VA = "0x188158C20")]
	public static void OPGILHMBHFK(QuadVertex[] DLHKGDMEECL, int KHPPKPCECOP, [In] Color32 ENOHJPBNFGM, [In] float2[] IBPBPKFPDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8158810", Offset = "0x8157810", VA = "0x188158810")]
	public static void LDHCHGPCGNF(QuadVertex[] DLHKGDMEECL, int KHPPKPCECOP, [In] float3[] PLBBGPCGMEH, [In] Color32 ENOHJPBNFGM, [In] float2[] IBPBPKFPDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8157C40", Offset = "0x8156C40", VA = "0x188157C40")]
	public static void CNMJCEJHLNE(ushort[] NCJHPECNKNM, int NJMKPDIJFLG, [In] int OPPOLDGCIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8158DA0", Offset = "0x8157DA0", VA = "0x188158DA0")]
	public static void PIJDNOBOKAM(ushort[] NCJHPECNKNM, int NJMKPDIJFLG, [In] int OPPOLDGCIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8158700", Offset = "0x8157700", VA = "0x188158700")]
	public static void JLLMJGGJILJ(ushort[] NCJHPECNKNM, [In] int NJMKPDIJFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81584C0", Offset = "0x81574C0", VA = "0x1881584C0")]
	public static void GGGELCLILHA(ushort[] NCJHPECNKNM, [In] int NJMKPDIJFLG, [In] int KHPPKPCECOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8157870", Offset = "0x8156870", VA = "0x188157870")]
	public static Bounds BPEDJBMKGJM([In] QuadVertex[] DLHKGDMEECL, [In] ushort[] NCJHPECNKNM, [In] int DNGOHMLDKKM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8157E80", Offset = "0x8156E80", VA = "0x188157E80")]
	public static Bounds EIDJNMHOBEG([In] QuadVertex[] DLHKGDMEECL, [In] ushort[] NCJHPECNKNM, [In] int DNGOHMLDKKM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8157AB0", Offset = "0x8156AB0", VA = "0x188157AB0")]
	[CompilerGenerated]
	internal static void CBEPMPGLICP([In] float3 GDJJGAEMLNF, JMEHLBMJKEB P_1)
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
