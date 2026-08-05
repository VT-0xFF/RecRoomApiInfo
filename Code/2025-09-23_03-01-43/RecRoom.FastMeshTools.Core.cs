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
public static class IMKKPMPLALI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84E43D0", Offset = "0x84E29D0", VA = "0x1884E43D0")]
	public static float2 GKLLBDMLOOJ(this ICLPPMPMANB KLHCLCMMAIL)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ICLPPMPMANB : byte
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
		[Cpp2IlInjected.Address(RVA = "0x3106D70", Offset = "0x3105370", VA = "0x183106D70")]
		public float2Rect(float2 APHHGJIDDCM, float2 KCJLCGFEBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84E6ED0", Offset = "0x84E54D0", VA = "0x1884E6ED0")]
		public void HEAGIBMIAPN([Out] float2 AFEKAGKNEHN, [Out] float2 MMNIOOIGPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84E6DF0", Offset = "0x84E53F0", VA = "0x1884E6DF0")]
		public float2 FHJBIBNGBML(float2 FPMOOHIJOME)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84E6C70", Offset = "0x84E5270", VA = "0x1884E6C70", Slot = "4")]
		public bool Equals(float2Rect AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84E6CF0", Offset = "0x84E52F0", VA = "0x1884E6CF0", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84E6E20", Offset = "0x84E5420", VA = "0x1884E6E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84E6EF0", Offset = "0x84E54F0", VA = "0x1884E6EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84E7110", Offset = "0x84E5710", VA = "0x1884E7110", Slot = "5")]
		public string ToString(string OFCLANOKPBA, IFormatProvider FLBMAMDHHCN)
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
		[Cpp2IlInjected.Address(RVA = "0x84E7550", Offset = "0x84E5B50", VA = "0x1884E7550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84E74C0", Offset = "0x84E5AC0", VA = "0x1884E74C0", Slot = "6")]
		public string ToString(string OFCLANOKPBA, IFormatProvider FLBMAMDHHCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84E7320", Offset = "0x84E5920", VA = "0x1884E7320", Slot = "4")]
		public bool Equals(floatMinMax AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84E7410", Offset = "0x84E5A10", VA = "0x1884E7410", Slot = "5")]
		public bool Equals(float2 AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84E7360", Offset = "0x84E5960", VA = "0x1884E7360", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84E7440", Offset = "0x84E5A40", VA = "0x1884E7440", Slot = "2")]
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
		private LOECBMPLBHD cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84E6580", Offset = "0x84E4B80", VA = "0x1884E6580")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84E66D0", Offset = "0x84E4CD0", VA = "0x1884E66D0")]
		public LayoutRect(LayoutRect parent, ICLPPMPMANB parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84E6040", Offset = "0x84E4640", VA = "0x1884E6040")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84E5FA0", Offset = "0x84E45A0", VA = "0x1884E5FA0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84E6010", Offset = "0x84E4610", VA = "0x1884E6010")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84E5FB0", Offset = "0x84E45B0", VA = "0x1884E5FB0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84E6150", Offset = "0x84E4750", VA = "0x1884E6150")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84E44D0", Offset = "0x84E2AD0", VA = "0x1884E44D0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84E6250", Offset = "0x84E4850", VA = "0x1884E6250")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84E6200", Offset = "0x84E4800", VA = "0x1884E6200")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84E61B0", Offset = "0x84E47B0", VA = "0x1884E61B0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84E6300", Offset = "0x84E4900", VA = "0x1884E6300")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84E62B0", Offset = "0x84E48B0", VA = "0x1884E62B0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84E6260", Offset = "0x84E4860", VA = "0x1884E6260")]
		public void SetParentAlignment(ICLPPMPMANB rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84E6060", Offset = "0x84E4660", VA = "0x1884E6060")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84E60C0", Offset = "0x84E46C0", VA = "0x1884E60C0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84E6050", Offset = "0x84E4650", VA = "0x1884E6050")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84E63B0", Offset = "0x84E49B0", VA = "0x1884E63B0")]
		private LOECBMPLBHD UpdateCache()
		{
			return default(LOECBMPLBHD);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LOECBMPLBHD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OGKNOPFFOMM
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] PENFGMHADLA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84E68E0", Offset = "0x84E4EE0", VA = "0x1884E68E0")]
	public static float2Rect KMMBLKEFADO(Transform PPJBFCIMDLN, RectTransform AMMKGILEHBG)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84E6820", Offset = "0x84E4E20", VA = "0x1884E6820")]
	public static void FBHPGDEOJEG(Vector3[] HGKHMCCGOHP, [Out] float2 KECGAHAPFAB, [Out] float2 GAEHKCHAJDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CABLOEFKJEN
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] BGEHOBAMCAK;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84E5D10", Offset = "0x84E4310", VA = "0x1884E5D10")]
	public static void BKEAKCLOCDD([In] int KCMCEJENIHL, [Out] ushort AAHIIBKPBFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ADCFJANPACH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IPLDHOFPPHN
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
	[Cpp2IlInjected.Address(RVA = "0x84E5C10", Offset = "0x84E4210", VA = "0x1884E5C10")]
	public static void PDCMAMOEHOE(float3[] ILDGOEEJDBG, [In] float2 EHLIBPDLKLK, [In] float2 MMNIOOIGPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84E5410", Offset = "0x84E3A10", VA = "0x1884E5410")]
	public static void KOBLFKANEJM(float2[] LFAANGNKKEP, [In] float2 HDHBEICEDJJ, [In] float2 ILIOFHPJOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84E4E80", Offset = "0x84E3480", VA = "0x1884E4E80")]
	public static void FAKAAAPEOIL(float3[] ILDGOEEJDBG, [In] float EEBEEIINOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84E54A0", Offset = "0x84E3AA0", VA = "0x1884E54A0")]
	public static void LKGDHDJAEOP(QuadVertex[] HJPGEMIKMGI, [In] int AAHIIBKPBFI, [In] float3[] LMKMBLMLOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84E5070", Offset = "0x84E3670", VA = "0x1884E5070")]
	public static void FNKMADACFDO(QuadVertex[] HJPGEMIKMGI, int AAHIIBKPBFI, [In] float3[] LMKMBLMLOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84E5290", Offset = "0x84E3890", VA = "0x1884E5290")]
	public static void IHIKADIKONA(QuadVertex[] HJPGEMIKMGI, [In] int AAHIIBKPBFI, [In] Color32 BNCBMMNIEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84E5880", Offset = "0x84E3E80", VA = "0x1884E5880")]
	public static void ONFIJIKJGPA(QuadVertex[] HJPGEMIKMGI, int AAHIIBKPBFI, [In] Color32 BNCBMMNIEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84E4610", Offset = "0x84E2C10", VA = "0x1884E4610")]
	public static void CCLCEAAJPHG(QuadVertex[] HJPGEMIKMGI, [In] int AAHIIBKPBFI, [In] float2[] NBBBLCBJIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84E5180", Offset = "0x84E3780", VA = "0x1884E5180")]
	public static void GGAOAEOCBOG(QuadVertex[] HJPGEMIKMGI, int AAHIIBKPBFI, [In] float2[] NBBBLCBJIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84E4EF0", Offset = "0x84E34F0", VA = "0x1884E4EF0")]
	public static void FCEBLCIEMAB(QuadVertex[] HJPGEMIKMGI, int AAHIIBKPBFI, [In] float3[] LMKMBLMLOEO, [In] Color32 BNCBMMNIEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84E4C60", Offset = "0x84E3260", VA = "0x1884E4C60")]
	public static void EAPHLBAGCHF(QuadVertex[] HJPGEMIKMGI, int AAHIIBKPBFI, [In] float3[] LMKMBLMLOEO, [In] float2[] NBBBLCBJIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84E4AE0", Offset = "0x84E30E0", VA = "0x1884E4AE0")]
	public static void DEJCIOGNCNM(QuadVertex[] HJPGEMIKMGI, int AAHIIBKPBFI, [In] Color32 BNCBMMNIEIB, [In] float2[] NBBBLCBJIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84E4850", Offset = "0x84E2E50", VA = "0x1884E4850")]
	public static void CPMOHLAFDJL(QuadVertex[] HJPGEMIKMGI, int AAHIIBKPBFI, [In] float3[] LMKMBLMLOEO, [In] Color32 BNCBMMNIEIB, [In] float2[] NBBBLCBJIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84E4720", Offset = "0x84E2D20", VA = "0x1884E4720")]
	public static void CINIPGOACMM(ushort[] ELBEIJOAGAP, int KCMCEJENIHL, [In] int AGKEBMCDADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84E53D0", Offset = "0x84E39D0", VA = "0x1884E53D0")]
	public static void KKKLACOBOGM(ushort[] ELBEIJOAGAP, int KCMCEJENIHL, [In] int AGKEBMCDADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84E57F0", Offset = "0x84E3DF0", VA = "0x1884E57F0")]
	public static void NCEAIOCKCHM(ushort[] ELBEIJOAGAP, [In] int KCMCEJENIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84E5310", Offset = "0x84E3910", VA = "0x1884E5310")]
	public static void JINMJPNJLEI(ushort[] ELBEIJOAGAP, [In] int KCMCEJENIHL, [In] int AAHIIBKPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84E55B0", Offset = "0x84E3BB0", VA = "0x1884E55B0")]
	public static Bounds MMCBNEFJPAC([In] QuadVertex[] HJPGEMIKMGI, [In] ushort[] ELBEIJOAGAP, [In] int LLGMBOFNLOC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84E5900", Offset = "0x84E3F00", VA = "0x1884E5900")]
	public static Bounds PCEBOMDELBD([In] QuadVertex[] HJPGEMIKMGI, [In] ushort[] ELBEIJOAGAP, [In] int LLGMBOFNLOC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84E5C90", Offset = "0x84E4290", VA = "0x1884E5C90")]
	[CompilerGenerated]
	internal static void PELMPOJNNKN([In] float3 OKHLJECLMJG, IPLDHOFPPHN P_1)
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
