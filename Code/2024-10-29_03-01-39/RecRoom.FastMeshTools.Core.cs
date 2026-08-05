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
public static class FGKMAKALGNO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E98770", Offset = "0x6E97770", VA = "0x186E98770")]
	public static float2 PNINJIFJOAE(this OEHMOBLIGDG FEBHBDHIBOI)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OEHMOBLIGDG : byte
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
		[Cpp2IlInjected.Address(RVA = "0x28D0630", Offset = "0x28CF630", VA = "0x1828D0630")]
		public float2Rect(float2 PAMMLHPIJIB, float2 MLDINGBBEHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B100", Offset = "0x6E9A100", VA = "0x186E9B100")]
		public void GIFBHPBPLDG([Out] float2 NJCCOCLKEGE, [Out] float2 AENOGAGJCOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B1D0", Offset = "0x6E9A1D0", VA = "0x186E9B1D0")]
		public float2 MDFOCOAGJGO(float2 ANIPLJMMOBI)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AF80", Offset = "0x6E99F80", VA = "0x186E9AF80", Slot = "4")]
		public bool Equals(float2Rect DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B000", Offset = "0x6E9A000", VA = "0x186E9B000", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B120", Offset = "0x6E9A120", VA = "0x186E9B120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B200", Offset = "0x6E9A200", VA = "0x186E9B200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B420", Offset = "0x6E9A420", VA = "0x186E9B420", Slot = "5")]
		public string ToString(string PKNNBLNOLJP, IFormatProvider ELFKHJELBDO)
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
		[Cpp2IlInjected.Address(RVA = "0x6E9B860", Offset = "0x6E9A860", VA = "0x186E9B860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B7D0", Offset = "0x6E9A7D0", VA = "0x186E9B7D0", Slot = "6")]
		public string ToString(string PKNNBLNOLJP, IFormatProvider ELFKHJELBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B630", Offset = "0x6E9A630", VA = "0x186E9B630", Slot = "4")]
		public bool Equals(floatMinMax DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B720", Offset = "0x6E9A720", VA = "0x186E9B720", Slot = "5")]
		public bool Equals(float2 DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B670", Offset = "0x6E9A670", VA = "0x186E9B670", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B750", Offset = "0x6E9A750", VA = "0x186E9B750", Slot = "2")]
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
		private NKDLMGAPGHI cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A8B0", Offset = "0x6E998B0", VA = "0x186E9A8B0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A9F0", Offset = "0x6E999F0", VA = "0x186E9A9F0")]
		public LayoutRect(LayoutRect parent, OEHMOBLIGDG parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A3C0", Offset = "0x6E993C0", VA = "0x186E9A3C0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A320", Offset = "0x6E99320", VA = "0x186E9A320")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A390", Offset = "0x6E99390", VA = "0x186E9A390")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A330", Offset = "0x6E99330", VA = "0x186E9A330")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A4D0", Offset = "0x6E994D0", VA = "0x186E9A4D0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E98870", Offset = "0x6E97870", VA = "0x186E98870")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A580", Offset = "0x6E99580", VA = "0x186E9A580")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A540", Offset = "0x6E99540", VA = "0x186E9A540")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A500", Offset = "0x6E99500", VA = "0x186E9A500")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A630", Offset = "0x6E99630", VA = "0x186E9A630")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A5F0", Offset = "0x6E995F0", VA = "0x186E9A5F0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A590", Offset = "0x6E99590", VA = "0x186E9A590")]
		public void SetParentAlignment(OEHMOBLIGDG rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A3E0", Offset = "0x6E993E0", VA = "0x186E9A3E0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A440", Offset = "0x6E99440", VA = "0x186E9A440")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A3D0", Offset = "0x6E993D0", VA = "0x186E9A3D0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A6E0", Offset = "0x6E996E0", VA = "0x186E9A6E0")]
		private NKDLMGAPGHI UpdateCache()
		{
			return default(NKDLMGAPGHI);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NKDLMGAPGHI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PPCENGLCFGA
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] HDDHHHPPNFD;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E9AC00", Offset = "0x6E99C00", VA = "0x186E9AC00")]
	public static float2Rect OAHPGNDLJJH(Transform DOONLFNDJPO, RectTransform CECLKDDLGFE)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E9AB40", Offset = "0x6E99B40", VA = "0x186E9AB40")]
	public static void HENDLOKOFNL(Vector3[] NFABEFEEGCA, [Out] float2 JCGGLMFLBCP, [Out] float2 PLFLOPDIPGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GGOOIIEICGL
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] FBBAJKDAEHH;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E98AE0", Offset = "0x6E97AE0", VA = "0x186E98AE0")]
	public static void KAKJPBAINLK([In] int PHLNNECMGOD, [Out] ushort HGNDIGNCONL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LLFBEIHIHNO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MNFHJGMNNMF
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
	[Cpp2IlInjected.Address(RVA = "0x6E992D0", Offset = "0x6E982D0", VA = "0x186E992D0")]
	public static void FCMJINLLKMP(float3[] IAPBJEHMJJE, [In] float2 BEAMEAGHFME, [In] float2 AENOGAGJCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E991C0", Offset = "0x6E981C0", VA = "0x186E991C0")]
	public static void DFBHIIAOMDN(float2[] AOIPODJKKEK, [In] float2 COCJBGNOENF, [In] float2 FJIHHPODBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E99C00", Offset = "0x6E98C00", VA = "0x186E99C00")]
	public static void KLKNAKLMCHO(float3[] IAPBJEHMJJE, [In] float EKNGPIHAJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E99AF0", Offset = "0x6E98AF0", VA = "0x186E99AF0")]
	public static void KDMNHEDMHIE(QuadVertex[] DOOAAKKIMAO, [In] int HGNDIGNCONL, [In] float3[] FJCONLBNKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E999E0", Offset = "0x6E989E0", VA = "0x186E999E0")]
	public static void IIEFLBBLGEO(QuadVertex[] DOOAAKKIMAO, int HGNDIGNCONL, [In] float3[] FJCONLBNKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E99250", Offset = "0x6E98250", VA = "0x186E99250")]
	public static void DMJKFHLHBPO(QuadVertex[] DOOAAKKIMAO, [In] int HGNDIGNCONL, [In] Color32 GLMABFLAELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A2A0", Offset = "0x6E992A0", VA = "0x186E9A2A0")]
	public static void POMHCMMCFNP(QuadVertex[] DOOAAKKIMAO, int HGNDIGNCONL, [In] Color32 GLMABFLAELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E99600", Offset = "0x6E98600", VA = "0x186E99600")]
	public static void HGJCFADGLCM(QuadVertex[] DOOAAKKIMAO, [In] int HGNDIGNCONL, [In] float2[] KPKFAJLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E98F30", Offset = "0x6E97F30", VA = "0x186E98F30")]
	public static void DBFOENAJJEH(QuadVertex[] DOOAAKKIMAO, int HGNDIGNCONL, [In] float2[] KPKFAJLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E99040", Offset = "0x6E98040", VA = "0x186E99040")]
	public static void DDJMDMLMGJK(QuadVertex[] DOOAAKKIMAO, int HGNDIGNCONL, [In] float3[] FJCONLBNKBM, [In] Color32 GLMABFLAELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E99C70", Offset = "0x6E98C70", VA = "0x186E99C70")]
	public static void MAKMEDAMCGG(QuadVertex[] DOOAAKKIMAO, int HGNDIGNCONL, [In] float3[] FJCONLBNKBM, [In] float2[] KPKFAJLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E99480", Offset = "0x6E98480", VA = "0x186E99480")]
	public static void GPNNNAFIOBF(QuadVertex[] DOOAAKKIMAO, int HGNDIGNCONL, [In] Color32 GLMABFLAELB, [In] float2[] KPKFAJLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E99750", Offset = "0x6E98750", VA = "0x186E99750")]
	public static void IHKGKJKMMLK(QuadVertex[] DOOAAKKIMAO, int HGNDIGNCONL, [In] float3[] FJCONLBNKBM, [In] Color32 GLMABFLAELB, [In] float2[] KPKFAJLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E99350", Offset = "0x6E98350", VA = "0x186E99350")]
	public static void FENKNEFEFLO(ushort[] OBHKGPFIIMD, int PHLNNECMGOD, [In] int JOBKMOPBFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E99710", Offset = "0x6E98710", VA = "0x186E99710")]
	public static void IBKAIGEKKIG(ushort[] OBHKGPFIIMD, int PHLNNECMGOD, [In] int JOBKMOPBFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E99F50", Offset = "0x6E98F50", VA = "0x186E99F50")]
	public static void NNFHPBEHIDD(ushort[] OBHKGPFIIMD, [In] int PHLNNECMGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E99E90", Offset = "0x6E98E90", VA = "0x186E99E90")]
	public static void MMJLEJCCHHE(ushort[] OBHKGPFIIMD, [In] int PHLNNECMGOD, [In] int HGNDIGNCONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E99FE0", Offset = "0x6E98FE0", VA = "0x186E99FE0")]
	public static Bounds ODDHPHJOHPD([In] QuadVertex[] DOOAAKKIMAO, [In] ushort[] OBHKGPFIIMD, [In] int KNKDMLNKGDJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E98C20", Offset = "0x6E97C20", VA = "0x186E98C20")]
	public static Bounds BHCDJIJNOHD([In] QuadVertex[] DOOAAKKIMAO, [In] ushort[] OBHKGPFIIMD, [In] int KNKDMLNKGDJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A220", Offset = "0x6E99220", VA = "0x186E9A220")]
	[CompilerGenerated]
	internal static void ONBKJOJDADC([In] float3 NLBDJHPCOPN, MNFHJGMNNMF P_1)
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
