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
public static class DMNLGFDPBBE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x744CF30", Offset = "0x744C330", VA = "0x18744CF30")]
	public static float2 JODIPIFKIAJ(this NBKGMFGBKHL MBFGAPMKIIG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NBKGMFGBKHL : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2B98770", Offset = "0x2B97B70", VA = "0x182B98770")]
		public float2Rect(float2 NDADPNJPMFO, float2 IBMHAIHIDJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x744FC10", Offset = "0x744F010", VA = "0x18744FC10")]
		public void JNMBAPLKJHM([Out] float2 DMKHJOBNCJC, [Out] float2 JMDLDEHAFMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x744FBE0", Offset = "0x744EFE0", VA = "0x18744FBE0")]
		public float2 JFHDPAGDEKG(float2 FJFCMMJFMHH)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x744F9B0", Offset = "0x744EDB0", VA = "0x18744F9B0", Slot = "4")]
		public bool Equals(float2Rect OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x744FA30", Offset = "0x744EE30", VA = "0x18744FA30", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x744FB30", Offset = "0x744EF30", VA = "0x18744FB30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x744FC30", Offset = "0x744F030", VA = "0x18744FC30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x744FE50", Offset = "0x744F250", VA = "0x18744FE50", Slot = "5")]
		public string ToString(string HGFLLJFOAAE, IFormatProvider FFBJJPHCNIA)
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
		[Cpp2IlInjected.Address(RVA = "0x74502A0", Offset = "0x744F6A0", VA = "0x1874502A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7450210", Offset = "0x744F610", VA = "0x187450210", Slot = "6")]
		public string ToString(string HGFLLJFOAAE, IFormatProvider FFBJJPHCNIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7450070", Offset = "0x744F470", VA = "0x187450070", Slot = "4")]
		public bool Equals(floatMinMax OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7450160", Offset = "0x744F560", VA = "0x187450160", Slot = "5")]
		public bool Equals(float2 OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74500B0", Offset = "0x744F4B0", VA = "0x1874500B0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7450190", Offset = "0x744F590", VA = "0x187450190", Slot = "2")]
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
		private MBGOGKNJMGL cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x744F410", Offset = "0x744E810", VA = "0x18744F410")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x744F2C0", Offset = "0x744E6C0", VA = "0x18744F2C0")]
		public LayoutRect(LayoutRect parent, NBKGMFGBKHL parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x744ED80", Offset = "0x744E180", VA = "0x18744ED80")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x744ECE0", Offset = "0x744E0E0", VA = "0x18744ECE0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x744ED50", Offset = "0x744E150", VA = "0x18744ED50")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x744ECF0", Offset = "0x744E0F0", VA = "0x18744ECF0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x744EE90", Offset = "0x744E290", VA = "0x18744EE90")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x744D210", Offset = "0x744C610", VA = "0x18744D210")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x744EF90", Offset = "0x744E390", VA = "0x18744EF90")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x744EF40", Offset = "0x744E340", VA = "0x18744EF40")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x744EEF0", Offset = "0x744E2F0", VA = "0x18744EEF0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x744F040", Offset = "0x744E440", VA = "0x18744F040")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x744EFF0", Offset = "0x744E3F0", VA = "0x18744EFF0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x744EFA0", Offset = "0x744E3A0", VA = "0x18744EFA0")]
		public void SetParentAlignment(NBKGMFGBKHL rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x744EDA0", Offset = "0x744E1A0", VA = "0x18744EDA0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x744EE00", Offset = "0x744E200", VA = "0x18744EE00")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x744ED90", Offset = "0x744E190", VA = "0x18744ED90")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x744F0F0", Offset = "0x744E4F0", VA = "0x18744F0F0")]
		private MBGOGKNJMGL UpdateCache()
		{
			return default(MBGOGKNJMGL);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MBGOGKNJMGL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OAKEBGOOAFM
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] LEJAPPJNHDC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x744F560", Offset = "0x744E960", VA = "0x18744F560")]
	public static float2Rect FAKNMCGBNHN(Transform CMEACAFNGIE, RectTransform MOCLCNOAHKF)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x744F880", Offset = "0x744EC80", VA = "0x18744F880")]
	public static void ONINPEHFAAO(Vector3[] KFLAKNIFHGM, [Out] float2 CDIPILBCKFB, [Out] float2 HCEBABCAMLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JIHEDCHBDCP
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] HHLOHDCEHBI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x744D490", Offset = "0x744C890", VA = "0x18744D490")]
	public static void JPBHPNMOEPE([In] int LLPGLADCDJP, [Out] ushort LMEHBDIKNMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KGJDLNOIHOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HAFPOLFCJHO
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
	[Cpp2IlInjected.Address(RVA = "0x744EC60", Offset = "0x744E060", VA = "0x18744EC60")]
	public static void NFPHNMNGELD(float3[] GLNKKPCLHKJ, [In] float2 HEFEPHBKPLP, [In] float2 JMDLDEHAFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x744DD40", Offset = "0x744D140", VA = "0x18744DD40")]
	public static void DBIEMDMGFJJ(float2[] HBOAOKMGCAB, [In] float2 EJGMPPPNFFA, [In] float2 FKDJPOFHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x744EB30", Offset = "0x744DF30", VA = "0x18744EB30")]
	public static void MGJNNLPACJI(float3[] GLNKKPCLHKJ, [In] float OAPLHGGBBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x744DDD0", Offset = "0x744D1D0", VA = "0x18744DDD0")]
	public static void DEKPJMEGAHG(QuadVertex[] PHDCDBDEDFM, [In] int LMEHBDIKNMD, [In] float3[] NFDLHDNPMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x744DF60", Offset = "0x744D360", VA = "0x18744DF60")]
	public static void GNNFOKGAIMC(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] float3[] NFDLHDNPMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x744E9A0", Offset = "0x744DDA0", VA = "0x18744E9A0")]
	public static void KKHMHHPHEAK(QuadVertex[] PHDCDBDEDFM, [In] int LMEHBDIKNMD, [In] Color32 JONBAOFIJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x744E360", Offset = "0x744D760", VA = "0x18744E360")]
	public static void IHPBCMHLHBO(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] Color32 JONBAOFIJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x744EA20", Offset = "0x744DE20", VA = "0x18744EA20")]
	public static void LCBANIBJFBH(QuadVertex[] PHDCDBDEDFM, [In] int LMEHBDIKNMD, [In] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x744E3E0", Offset = "0x744D7E0", VA = "0x18744E3E0")]
	public static void IONPAPIIJNI(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x744E1E0", Offset = "0x744D5E0", VA = "0x18744E1E0")]
	public static void IBKMIONBNBC(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] float3[] NFDLHDNPMJN, [In] Color32 JONBAOFIJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x744E4F0", Offset = "0x744D8F0", VA = "0x18744E4F0")]
	public static void JPBMCLOFJPH(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] float3[] NFDLHDNPMJN, [In] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x744D980", Offset = "0x744CD80", VA = "0x18744D980")]
	public static void BIACMDPMPAA(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] Color32 JONBAOFIJIC, [In] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x744E710", Offset = "0x744DB10", VA = "0x18744E710")]
	public static void KBLNKDFAJOF(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] float3[] NFDLHDNPMJN, [In] Color32 JONBAOFIJIC, [In] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x744E070", Offset = "0x744D470", VA = "0x18744E070")]
	public static void HEKMJGBMMHE(ushort[] EEPKNOKHHND, int LLPGLADCDJP, [In] int HCGIJEHJHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x744E1A0", Offset = "0x744D5A0", VA = "0x18744E1A0")]
	public static void HPALPECAPCE(ushort[] EEPKNOKHHND, int LLPGLADCDJP, [In] int HCGIJEHJHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x744D8F0", Offset = "0x744CCF0", VA = "0x18744D8F0")]
	public static void APCOOKEGMOP(ushort[] EEPKNOKHHND, [In] int LLPGLADCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x744EBA0", Offset = "0x744DFA0", VA = "0x18744EBA0")]
	public static void MJFKEKELBGH(ushort[] EEPKNOKHHND, [In] int LLPGLADCDJP, [In] int LMEHBDIKNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x744DB00", Offset = "0x744CF00", VA = "0x18744DB00")]
	public static Bounds CPFOCDODKLA([In] QuadVertex[] PHDCDBDEDFM, [In] ushort[] EEPKNOKHHND, [In] int JMPFMJBCKFB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x744D5E0", Offset = "0x744C9E0", VA = "0x18744D5E0")]
	public static Bounds AJLHHGFHEMF([In] QuadVertex[] PHDCDBDEDFM, [In] ushort[] EEPKNOKHHND, [In] int JMPFMJBCKFB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x744DEE0", Offset = "0x744D2E0", VA = "0x18744DEE0")]
	[CompilerGenerated]
	internal static void DMEHIAEBHNO([In] float3 FCEAHINHNGO, HAFPOLFCJHO P_1)
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
