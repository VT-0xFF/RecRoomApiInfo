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
public static class MIBGCHAPNBO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x720CC10", Offset = "0x720BE10", VA = "0x18720CC10")]
	public static float2 IEPKDCKGNEC(this DBCINOPHAGI EIIJCPDEHIB)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DBCINOPHAGI : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2B4C430", Offset = "0x2B4B630", VA = "0x182B4C430")]
		public float2Rect(float2 FCKJMOMOHAE, float2 AFLMMFDMNOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x720F590", Offset = "0x720E790", VA = "0x18720F590")]
		public void NLHBJIEEJHA([Out] float2 FBAHDAAAIMM, [Out] float2 EKEGBNBGIOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x720F330", Offset = "0x720E530", VA = "0x18720F330")]
		public float2 ENOPLLJBHPJ(float2 EGOOBOJEKGK)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x720F360", Offset = "0x720E560", VA = "0x18720F360", Slot = "4")]
		public bool Equals(float2Rect JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x720F3E0", Offset = "0x720E5E0", VA = "0x18720F3E0", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x720F4E0", Offset = "0x720E6E0", VA = "0x18720F4E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x720F5B0", Offset = "0x720E7B0", VA = "0x18720F5B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x720F7D0", Offset = "0x720E9D0", VA = "0x18720F7D0", Slot = "5")]
		public string ToString(string HNCNCHKHLCP, IFormatProvider FFJFDDAFNLG)
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
		[Cpp2IlInjected.Address(RVA = "0x720FC10", Offset = "0x720EE10", VA = "0x18720FC10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x720FB80", Offset = "0x720ED80", VA = "0x18720FB80", Slot = "6")]
		public string ToString(string HNCNCHKHLCP, IFormatProvider FFJFDDAFNLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x720F9E0", Offset = "0x720EBE0", VA = "0x18720F9E0", Slot = "4")]
		public bool Equals(floatMinMax JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x720FAD0", Offset = "0x720ECD0", VA = "0x18720FAD0", Slot = "5")]
		public bool Equals(float2 JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x720FA20", Offset = "0x720EC20", VA = "0x18720FA20", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x720FB00", Offset = "0x720ED00", VA = "0x18720FB00", Slot = "2")]
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
		private DDMAJGEMDNL cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x720D690", Offset = "0x720C890", VA = "0x18720D690")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x720D530", Offset = "0x720C730", VA = "0x18720D530")]
		public LayoutRect(LayoutRect parent, DBCINOPHAGI parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x720D040", Offset = "0x720C240", VA = "0x18720D040")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x720CFA0", Offset = "0x720C1A0", VA = "0x18720CFA0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x720D010", Offset = "0x720C210", VA = "0x18720D010")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x720CFB0", Offset = "0x720C1B0", VA = "0x18720CFB0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x720D150", Offset = "0x720C350", VA = "0x18720D150")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x720CAE0", Offset = "0x720BCE0", VA = "0x18720CAE0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x720D200", Offset = "0x720C400", VA = "0x18720D200")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x720D1C0", Offset = "0x720C3C0", VA = "0x18720D1C0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x720D180", Offset = "0x720C380", VA = "0x18720D180")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x720D2B0", Offset = "0x720C4B0", VA = "0x18720D2B0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x720D270", Offset = "0x720C470", VA = "0x18720D270")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x720D210", Offset = "0x720C410", VA = "0x18720D210")]
		public void SetParentAlignment(DBCINOPHAGI rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x720D060", Offset = "0x720C260", VA = "0x18720D060")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x720D0C0", Offset = "0x720C2C0", VA = "0x18720D0C0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x720D050", Offset = "0x720C250", VA = "0x18720D050")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x720D360", Offset = "0x720C560", VA = "0x18720D360")]
		private DDMAJGEMDNL UpdateCache()
		{
			return default(DDMAJGEMDNL);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DDMAJGEMDNL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PKDIPFOMDKE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] MAFNJNLKLLC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x720EFA0", Offset = "0x720E1A0", VA = "0x18720EFA0")]
	public static float2Rect MEMIFCCPDDJ(Transform OLMDFJEDLAI, RectTransform MKMPLOHPJDC)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x720EEE0", Offset = "0x720E0E0", VA = "0x18720EEE0")]
	public static void LHCNOMJAPBH(Vector3[] MDANOHFDFBA, [Out] float2 KKNLKEIKANG, [Out] float2 HEMGJLGOHMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IIMGMOMOLKA
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] FOKAFDCHBJP;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x720CE50", Offset = "0x720C050", VA = "0x18720CE50")]
	public static void FGPHOKADBOO([In] int AECIEBCOIME, [Out] ushort FCIDPNOGNGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OKJKAEBFCDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LMNFNCGDJAJ
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
	[Cpp2IlInjected.Address(RVA = "0x720EDD0", Offset = "0x720DFD0", VA = "0x18720EDD0")]
	public static void OJHEPAKLAFF(float3[] LMNPJNAHCIH, [In] float2 KJDDMKDKOCE, [In] float2 EKEGBNBGIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x720DC60", Offset = "0x720CE60", VA = "0x18720DC60")]
	public static void GBOEOGOOEBB(float2[] ONDGOMDEEFN, [In] float2 JNMPADPABOK, [In] float2 PIOADIKAKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x720D8F0", Offset = "0x720CAF0", VA = "0x18720D8F0")]
	public static void CEJLJPIHIBJ(float3[] LMNPJNAHCIH, [In] float AIBCICFJHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x720EAC0", Offset = "0x720DCC0", VA = "0x18720EAC0")]
	public static void LNPOHGCJAGD(QuadVertex[] JPHDLANAFAG, [In] int FCIDPNOGNGH, [In] float3[] GKGFPCCFOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x720DA90", Offset = "0x720CC90", VA = "0x18720DA90")]
	public static void FCIIFMKKPPL(QuadVertex[] JPHDLANAFAG, int FCIDPNOGNGH, [In] float3[] GKGFPCCFOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x720E0B0", Offset = "0x720D2B0", VA = "0x18720E0B0")]
	public static void HPKCMCDCIDE(QuadVertex[] JPHDLANAFAG, [In] int FCIDPNOGNGH, [In] Color32 KOEJFDOGCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x720EBD0", Offset = "0x720DDD0", VA = "0x18720EBD0")]
	public static void MKBOANFACKH(QuadVertex[] JPHDLANAFAG, int FCIDPNOGNGH, [In] Color32 KOEJFDOGCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x720E710", Offset = "0x720D910", VA = "0x18720E710")]
	public static void KLOICOGHDEL(QuadVertex[] JPHDLANAFAG, [In] int FCIDPNOGNGH, [In] float2[] JBMFLMAJIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x720D7E0", Offset = "0x720C9E0", VA = "0x18720D7E0")]
	public static void BIGHMMKMHBL(QuadVertex[] JPHDLANAFAG, int FCIDPNOGNGH, [In] float2[] JBMFLMAJIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x720DCF0", Offset = "0x720CEF0", VA = "0x18720DCF0")]
	public static void GMGFMLBNFNL(QuadVertex[] JPHDLANAFAG, int FCIDPNOGNGH, [In] float3[] GKGFPCCFOPN, [In] Color32 KOEJFDOGCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x720E8A0", Offset = "0x720DAA0", VA = "0x18720E8A0")]
	public static void LIKOJMCLHDM(QuadVertex[] JPHDLANAFAG, int FCIDPNOGNGH, [In] float3[] GKGFPCCFOPN, [In] float2[] JBMFLMAJIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x720EC50", Offset = "0x720DE50", VA = "0x18720EC50")]
	public static void OIJFDJOMJNJ(QuadVertex[] JPHDLANAFAG, int FCIDPNOGNGH, [In] Color32 KOEJFDOGCHO, [In] float2[] JBMFLMAJIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x720E480", Offset = "0x720D680", VA = "0x18720E480")]
	public static void KKPBEDIAGHJ(QuadVertex[] JPHDLANAFAG, int FCIDPNOGNGH, [In] float3[] GKGFPCCFOPN, [In] Color32 KOEJFDOGCHO, [In] float2[] JBMFLMAJIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x720D960", Offset = "0x720CB60", VA = "0x18720D960")]
	public static void EBKEFHCNHHD(ushort[] FMDJJNDHAGC, int AECIEBCOIME, [In] int KLGFGPGIOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x720E440", Offset = "0x720D640", VA = "0x18720E440")]
	public static void JGGNNCAFJML(ushort[] FMDJJNDHAGC, int AECIEBCOIME, [In] int KLGFGPGIOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x720EE50", Offset = "0x720E050", VA = "0x18720EE50")]
	public static void PMFGPOENGIF(ushort[] FMDJJNDHAGC, [In] int AECIEBCOIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x720DBA0", Offset = "0x720CDA0", VA = "0x18720DBA0")]
	public static void FKEFJHGHCGG(ushort[] FMDJJNDHAGC, [In] int AECIEBCOIME, [In] int FCIDPNOGNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x720DE70", Offset = "0x720D070", VA = "0x18720DE70")]
	public static Bounds HCFIKCOBJON([In] QuadVertex[] JPHDLANAFAG, [In] ushort[] FMDJJNDHAGC, [In] int JKODCPAIBBB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x720E130", Offset = "0x720D330", VA = "0x18720E130")]
	public static Bounds IAEEHEJHEIK([In] QuadVertex[] JPHDLANAFAG, [In] ushort[] FMDJJNDHAGC, [In] int JKODCPAIBBB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x720E820", Offset = "0x720DA20", VA = "0x18720E820")]
	[CompilerGenerated]
	internal static void LELBECEHGEJ([In] float3 GBPBPMJPBKO, LMNFNCGDJAJ P_1)
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
