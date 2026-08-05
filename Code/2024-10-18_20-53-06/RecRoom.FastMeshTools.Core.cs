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
public static class CHGINIABDPO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0C80", Offset = "0x6DC0080", VA = "0x186DC0C80")]
	public static float2 HPPHGAFCPJE(this BFHMHKBPKFE ABCCCLJJMPG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BFHMHKBPKFE : byte
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
		[Cpp2IlInjected.Address(RVA = "0x27FB790", Offset = "0x27FAB90", VA = "0x1827FB790")]
		public float2Rect(float2 CLHMEGFDOKF, float2 IKJKAFPPDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DC36C0", Offset = "0x6DC2AC0", VA = "0x186DC36C0")]
		public void KGNAIFFBBCO([Out] float2 LJGFGLKMGKD, [Out] float2 MCCDJLFDNDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6DC36E0", Offset = "0x6DC2AE0", VA = "0x186DC36E0")]
		public float2 MLPIIKANAMK(float2 FIJFFIGEHDE)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3490", Offset = "0x6DC2890", VA = "0x186DC3490", Slot = "4")]
		public bool Equals(float2Rect KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3510", Offset = "0x6DC2910", VA = "0x186DC3510", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3610", Offset = "0x6DC2A10", VA = "0x186DC3610", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3710", Offset = "0x6DC2B10", VA = "0x186DC3710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3930", Offset = "0x6DC2D30", VA = "0x186DC3930", Slot = "5")]
		public string ToString(string BIFHNMDIJFJ, IFormatProvider JHFBMPJEGKI)
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
		[Cpp2IlInjected.Address(RVA = "0x6DC3D80", Offset = "0x6DC3180", VA = "0x186DC3D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3CF0", Offset = "0x6DC30F0", VA = "0x186DC3CF0", Slot = "6")]
		public string ToString(string BIFHNMDIJFJ, IFormatProvider JHFBMPJEGKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3B50", Offset = "0x6DC2F50", VA = "0x186DC3B50", Slot = "4")]
		public bool Equals(floatMinMax KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3C40", Offset = "0x6DC3040", VA = "0x186DC3C40", Slot = "5")]
		public bool Equals(float2 KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3B90", Offset = "0x6DC2F90", VA = "0x186DC3B90", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3C70", Offset = "0x6DC3070", VA = "0x186DC3C70", Slot = "2")]
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
		private LKBKLKPCIJA cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3200", Offset = "0x6DC2600", VA = "0x186DC3200")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3340", Offset = "0x6DC2740", VA = "0x186DC3340")]
		public LayoutRect(LayoutRect parent, BFHMHKBPKFE parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2D10", Offset = "0x6DC2110", VA = "0x186DC2D10")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2C70", Offset = "0x6DC2070", VA = "0x186DC2C70")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2CE0", Offset = "0x6DC20E0", VA = "0x186DC2CE0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2C80", Offset = "0x6DC2080", VA = "0x186DC2C80")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2E20", Offset = "0x6DC2220", VA = "0x186DC2E20")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DC0D80", Offset = "0x6DC0180", VA = "0x186DC0D80")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2ED0", Offset = "0x6DC22D0", VA = "0x186DC2ED0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2E90", Offset = "0x6DC2290", VA = "0x186DC2E90")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2E50", Offset = "0x6DC2250", VA = "0x186DC2E50")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2F80", Offset = "0x6DC2380", VA = "0x186DC2F80")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2F40", Offset = "0x6DC2340", VA = "0x186DC2F40")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2EE0", Offset = "0x6DC22E0", VA = "0x186DC2EE0")]
		public void SetParentAlignment(BFHMHKBPKFE rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2D30", Offset = "0x6DC2130", VA = "0x186DC2D30")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2D90", Offset = "0x6DC2190", VA = "0x186DC2D90")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2D20", Offset = "0x6DC2120", VA = "0x186DC2D20")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3030", Offset = "0x6DC2430", VA = "0x186DC3030")]
		private LKBKLKPCIJA UpdateCache()
		{
			return default(LKBKLKPCIJA);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LKBKLKPCIJA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EFHENONNOFA
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] KAKCCEPHJBG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0FF0", Offset = "0x6DC03F0", VA = "0x186DC0FF0")]
	public static float2Rect JLCEILGDBCP(Transform PIFGCDNJDDM, RectTransform KDGMCPCFIID)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1300", Offset = "0x6DC0700", VA = "0x186DC1300")]
	public static void LJFGEFIMGKN(Vector3[] AHOOEMKDDFJ, [Out] float2 DBFICLBOEFG, [Out] float2 EGCLLCBPEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FFEIJPMCMCI
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] EBOOANJLAHB;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1430", Offset = "0x6DC0830", VA = "0x186DC1430")]
	public static void BKPLHOIJBDG([In] int DKGDOFNGODA, [Out] ushort KHNNEEJAMBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KNKADNOIFNA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AANEILPMDIG
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
	[Cpp2IlInjected.Address(RVA = "0x6DC1FB0", Offset = "0x6DC13B0", VA = "0x186DC1FB0")]
	public static void GLFKPMMJBDF(float3[] MJBNODBDMBC, [In] float2 JJBAAGJFFOH, [In] float2 MCCDJLFDNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1680", Offset = "0x6DC0A80", VA = "0x186DC1680")]
	public static void CEDPBPDGJAM(float2[] OBLFMLKJCHG, [In] float2 DJNLBCCKENN, [In] float2 KINNBGFGOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2180", Offset = "0x6DC1580", VA = "0x186DC2180")]
	public static void JAMLHOCJHGF(float3[] MJBNODBDMBC, [In] float MBMHNIIJEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1570", Offset = "0x6DC0970", VA = "0x186DC1570")]
	public static void ABOPJLPAGBM(QuadVertex[] BKDODPIHOMD, [In] int KHNNEEJAMBB, [In] float3[] OABNCECCCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2370", Offset = "0x6DC1770", VA = "0x186DC2370")]
	public static void JJGHHGKKENM(QuadVertex[] BKDODPIHOMD, int KHNNEEJAMBB, [In] float3[] OABNCECCCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2510", Offset = "0x6DC1910", VA = "0x186DC2510")]
	public static void NKACAEIINIH(QuadVertex[] BKDODPIHOMD, [In] int KHNNEEJAMBB, [In] Color32 JMIPOKJMMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2BF0", Offset = "0x6DC1FF0", VA = "0x186DC2BF0")]
	public static void PPIPMKAOCDB(QuadVertex[] BKDODPIHOMD, int KHNNEEJAMBB, [In] Color32 JMIPOKJMMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2030", Offset = "0x6DC1430", VA = "0x186DC2030")]
	public static void HJLFOLAOFIL(QuadVertex[] BKDODPIHOMD, [In] int KHNNEEJAMBB, [In] float2[] ONOENHDDMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1C60", Offset = "0x6DC1060", VA = "0x186DC1C60")]
	public static void EJIJOIHMGLD(QuadVertex[] BKDODPIHOMD, int KHNNEEJAMBB, [In] float2[] ONOENHDDMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DC17D0", Offset = "0x6DC0BD0", VA = "0x186DC17D0")]
	public static void CJDEONKIPHO(QuadVertex[] BKDODPIHOMD, int KHNNEEJAMBB, [In] float3[] OABNCECCCBN, [In] Color32 JMIPOKJMMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2590", Offset = "0x6DC1990", VA = "0x186DC2590")]
	public static void OFOAHKOJCFB(QuadVertex[] BKDODPIHOMD, int KHNNEEJAMBB, [In] float3[] OABNCECCCBN, [In] float2[] ONOENHDDMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DC21F0", Offset = "0x6DC15F0", VA = "0x186DC21F0")]
	public static void JDOMBKIFKMK(QuadVertex[] BKDODPIHOMD, int KHNNEEJAMBB, [In] Color32 JMIPOKJMMNM, [In] float2[] ONOENHDDMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1950", Offset = "0x6DC0D50", VA = "0x186DC1950")]
	public static void CKOFNJMBMDH(QuadVertex[] BKDODPIHOMD, int KHNNEEJAMBB, [In] float3[] OABNCECCCBN, [In] Color32 JMIPOKJMMNM, [In] float2[] ONOENHDDMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2AC0", Offset = "0x6DC1EC0", VA = "0x186DC2AC0")]
	public static void PLLAEEMNEJL(ushort[] HNBDGNELJGI, int DKGDOFNGODA, [In] int NFIHFBMJODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2140", Offset = "0x6DC1540", VA = "0x186DC2140")]
	public static void HMLHNAHGCGB(ushort[] HNBDGNELJGI, int DKGDOFNGODA, [In] int NFIHFBMJODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2480", Offset = "0x6DC1880", VA = "0x186DC2480")]
	public static void MPCCLDLMBOI(ushort[] HNBDGNELJGI, [In] int DKGDOFNGODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1710", Offset = "0x6DC0B10", VA = "0x186DC1710")]
	public static void CHBPMLPDIFG(ushort[] HNBDGNELJGI, [In] int DKGDOFNGODA, [In] int KHNNEEJAMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1D70", Offset = "0x6DC1170", VA = "0x186DC1D70")]
	public static Bounds GAKNAELEMJI([In] QuadVertex[] BKDODPIHOMD, [In] ushort[] HNBDGNELJGI, [In] int MOMGGCMOPCO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC27B0", Offset = "0x6DC1BB0", VA = "0x186DC27B0")]
	public static Bounds PAAKNBGHLJN([In] QuadVertex[] BKDODPIHOMD, [In] ushort[] HNBDGNELJGI, [In] int MOMGGCMOPCO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1BE0", Offset = "0x6DC0FE0", VA = "0x186DC1BE0")]
	[CompilerGenerated]
	internal static void EFHJECAFBBN([In] float3 KKPMNJCHLDM, AANEILPMDIG P_1)
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
