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
public static class FBODNPAAFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75D1240", Offset = "0x75D0640", VA = "0x1875D1240")]
	public static float2 MHCFOBINAFI(this BJDAPBOKJGP HMFBCAHCDBI)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BJDAPBOKJGP : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2C08CF0", Offset = "0x2C080F0", VA = "0x182C08CF0")]
		public float2Rect(float2 HJBDDDIFEBJ, float2 NBPEDBIONNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75D3CA0", Offset = "0x75D30A0", VA = "0x1875D3CA0")]
		public void COICBMCKFLC([Out] float2 FMFMHDNAFLD, [Out] float2 CKNNMDJBJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75D3EF0", Offset = "0x75D32F0", VA = "0x1875D3EF0")]
		public float2 LDFBLHIHKAO(float2 OEKJFGNJDJD)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x75D3CC0", Offset = "0x75D30C0", VA = "0x1875D3CC0", Slot = "4")]
		public bool Equals(float2Rect MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75D3D40", Offset = "0x75D3140", VA = "0x1875D3D40", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75D3E40", Offset = "0x75D3240", VA = "0x1875D3E40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75D3F20", Offset = "0x75D3320", VA = "0x1875D3F20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75D4140", Offset = "0x75D3540", VA = "0x1875D4140", Slot = "5")]
		public string ToString(string MCIFFFCOFIA, IFormatProvider OBBHKJCKPJP)
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
		[Cpp2IlInjected.Address(RVA = "0x75D4580", Offset = "0x75D3980", VA = "0x1875D4580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75D44F0", Offset = "0x75D38F0", VA = "0x1875D44F0", Slot = "6")]
		public string ToString(string MCIFFFCOFIA, IFormatProvider OBBHKJCKPJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75D4350", Offset = "0x75D3750", VA = "0x1875D4350", Slot = "4")]
		public bool Equals(floatMinMax MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75D4440", Offset = "0x75D3840", VA = "0x1875D4440", Slot = "5")]
		public bool Equals(float2 MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75D4390", Offset = "0x75D3790", VA = "0x1875D4390", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75D4470", Offset = "0x75D3870", VA = "0x1875D4470", Slot = "2")]
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
		private MCPLIMJLPDH cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75D3B50", Offset = "0x75D2F50", VA = "0x1875D3B50")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75D3A00", Offset = "0x75D2E00", VA = "0x1875D3A00")]
		public LayoutRect(LayoutRect parent, BJDAPBOKJGP parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75D34C0", Offset = "0x75D28C0", VA = "0x1875D34C0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75D3420", Offset = "0x75D2820", VA = "0x1875D3420")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x75D3490", Offset = "0x75D2890", VA = "0x1875D3490")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75D3430", Offset = "0x75D2830", VA = "0x1875D3430")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75D35D0", Offset = "0x75D29D0", VA = "0x1875D35D0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75D1520", Offset = "0x75D0920", VA = "0x1875D1520")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75D36D0", Offset = "0x75D2AD0", VA = "0x1875D36D0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x75D3680", Offset = "0x75D2A80", VA = "0x1875D3680")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x75D3630", Offset = "0x75D2A30", VA = "0x1875D3630")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x75D3780", Offset = "0x75D2B80", VA = "0x1875D3780")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x75D3730", Offset = "0x75D2B30", VA = "0x1875D3730")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x75D36E0", Offset = "0x75D2AE0", VA = "0x1875D36E0")]
		public void SetParentAlignment(BJDAPBOKJGP rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x75D34E0", Offset = "0x75D28E0", VA = "0x1875D34E0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x75D3540", Offset = "0x75D2940", VA = "0x1875D3540")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x75D34D0", Offset = "0x75D28D0", VA = "0x1875D34D0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x75D3830", Offset = "0x75D2C30", VA = "0x1875D3830")]
		private MCPLIMJLPDH UpdateCache()
		{
			return default(MCPLIMJLPDH);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MCPLIMJLPDH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class KFNKKOCLKJL
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] MIIGBHDEEJO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75D2FE0", Offset = "0x75D23E0", VA = "0x1875D2FE0")]
	public static float2Rect AECNKALOAPP(Transform FHANHAIKACC, RectTransform GACPILKGIFM)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75D32F0", Offset = "0x75D26F0", VA = "0x1875D32F0")]
	public static void CNMPGLCNDHD(Vector3[] FADMCFGNIJH, [Out] float2 IKENCPHIKGM, [Out] float2 MNJHKANCBHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JEFBPNBANFF
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] PKJIDPBIGBO;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75D2EA0", Offset = "0x75D22A0", VA = "0x1875D2EA0")]
	public static void LHPBHMKJKCF([In] int DODBJJKLCOL, [Out] ushort MMLMIPPLNNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AJCBDENFECI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JFHCHAFAJFJ
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
	[Cpp2IlInjected.Address(RVA = "0x75D1F40", Offset = "0x75D1340", VA = "0x1875D1F40")]
	public static void DDABDCFNIDK(float3[] MNGPJBNIKLB, [In] float2 IMKONPMOAGD, [In] float2 CKNNMDJBJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x75D1FC0", Offset = "0x75D13C0", VA = "0x1875D1FC0")]
	public static void GAMHIPGMMMM(float2[] EJBHJEMDGBE, [In] float2 DFMLFIKFHHI, [In] float2 FHFDDEKOJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75D1660", Offset = "0x75D0A60", VA = "0x1875D1660")]
	public static void AENINKIKOGC(float3[] MNGPJBNIKLB, [In] float EHACKGCDGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75D1D70", Offset = "0x75D1170", VA = "0x1875D1D70")]
	public static void CKHOPNFLACF(QuadVertex[] LACIFHEKNOJ, [In] int MMLMIPPLNNP, [In] float3[] CGCLPMIBAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x75D1950", Offset = "0x75D0D50", VA = "0x1875D1950")]
	public static void CIKIMJBAJHN(QuadVertex[] LACIFHEKNOJ, int MMLMIPPLNNP, [In] float3[] CGCLPMIBAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75D18D0", Offset = "0x75D0CD0", VA = "0x1875D18D0")]
	public static void CECJNMPMBJC(QuadVertex[] LACIFHEKNOJ, [In] int MMLMIPPLNNP, [In] Color32 EHECHIIBEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75D16D0", Offset = "0x75D0AD0", VA = "0x1875D16D0")]
	public static void AOMHAGGKAAA(QuadVertex[] LACIFHEKNOJ, int MMLMIPPLNNP, [In] Color32 EHECHIIBEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x75D2050", Offset = "0x75D1450", VA = "0x1875D2050")]
	public static void GBDIBNGBKGB(QuadVertex[] LACIFHEKNOJ, [In] int MMLMIPPLNNP, [In] float2[] MEKJPCEGDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x75D2C50", Offset = "0x75D2050", VA = "0x1875D2C50")]
	public static void PBMBCJJCDCM(QuadVertex[] LACIFHEKNOJ, int MMLMIPPLNNP, [In] float2[] MEKJPCEGDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75D1750", Offset = "0x75D0B50", VA = "0x1875D1750")]
	public static void BLLIHFILLMN(QuadVertex[] LACIFHEKNOJ, int MMLMIPPLNNP, [In] float3[] CGCLPMIBAKE, [In] Color32 EHECHIIBEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x75D29A0", Offset = "0x75D1DA0", VA = "0x1875D29A0")]
	public static void LNOMOLLBACG(QuadVertex[] LACIFHEKNOJ, int MMLMIPPLNNP, [In] float3[] CGCLPMIBAKE, [In] float2[] MEKJPCEGDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x75D2820", Offset = "0x75D1C20", VA = "0x1875D2820")]
	public static void LKGEGLOIDHN(QuadVertex[] LACIFHEKNOJ, int MMLMIPPLNNP, [In] Color32 EHECHIIBEPK, [In] float2[] MEKJPCEGDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x75D2290", Offset = "0x75D1690", VA = "0x1875D2290")]
	public static void GGGAGFMNBPB(QuadVertex[] LACIFHEKNOJ, int MMLMIPPLNNP, [In] float3[] CGCLPMIBAKE, [In] Color32 EHECHIIBEPK, [In] float2[] MEKJPCEGDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x75D2160", Offset = "0x75D1560", VA = "0x1875D2160")]
	public static void GDLNIKBFNFM(ushort[] GNEIKOKNAPM, int DODBJJKLCOL, [In] int GBHEKMAILOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x75D2520", Offset = "0x75D1920", VA = "0x1875D2520")]
	public static void HDGLHHJPNEL(ushort[] GNEIKOKNAPM, int DODBJJKLCOL, [In] int GBHEKMAILOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x75D2BC0", Offset = "0x75D1FC0", VA = "0x1875D2BC0")]
	public static void ONBCNEGHIGA(ushort[] GNEIKOKNAPM, [In] int DODBJJKLCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x75D1E80", Offset = "0x75D1280", VA = "0x1875D1E80")]
	public static void CMPJANBOMID(ushort[] GNEIKOKNAPM, [In] int DODBJJKLCOL, [In] int MMLMIPPLNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x75D2560", Offset = "0x75D1960", VA = "0x1875D2560")]
	public static Bounds IOFEBENMCJD([In] QuadVertex[] LACIFHEKNOJ, [In] ushort[] GNEIKOKNAPM, [In] int LNHBDPPLFCK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x75D1A60", Offset = "0x75D0E60", VA = "0x1875D1A60")]
	public static Bounds CJOAHNGDFEH([In] QuadVertex[] LACIFHEKNOJ, [In] ushort[] GNEIKOKNAPM, [In] int LNHBDPPLFCK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x75D27A0", Offset = "0x75D1BA0", VA = "0x1875D27A0")]
	[CompilerGenerated]
	internal static void KFLCCOPENMJ([In] float3 FEPAKEBFLMO, JFHCHAFAJFJ P_1)
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
