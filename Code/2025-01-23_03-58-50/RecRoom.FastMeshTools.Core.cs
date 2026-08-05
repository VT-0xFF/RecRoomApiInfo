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
public static class PFEOLEIEGIE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F39070", Offset = "0x6F37870", VA = "0x186F39070")]
	public static float2 AHEDIGAAIJM(this JHAAAKFPINM DBGGLIGNNJK)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JHAAAKFPINM : byte
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
		[Cpp2IlInjected.Address(RVA = "0x294EB10", Offset = "0x294D310", VA = "0x18294EB10")]
		public float2Rect(float2 BALIIBCILHH, float2 BOOADEANLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B790", Offset = "0x6F39F90", VA = "0x186F3B790")]
		public void CCFBGGDGJEK([Out] float2 PIECBDGJIBC, [Out] float2 FIFDAHJIFCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B7B0", Offset = "0x6F39FB0", VA = "0x186F3B7B0")]
		public float2 EOHGPAGBBHI(float2 DGFKAHFBNIH)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B7E0", Offset = "0x6F39FE0", VA = "0x186F3B7E0", Slot = "4")]
		public bool Equals(float2Rect LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B860", Offset = "0x6F3A060", VA = "0x186F3B860", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B960", Offset = "0x6F3A160", VA = "0x186F3B960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BA10", Offset = "0x6F3A210", VA = "0x186F3BA10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BC30", Offset = "0x6F3A430", VA = "0x186F3BC30", Slot = "5")]
		public string ToString(string AENEDEDOEJK, IFormatProvider AGPJBLDNDHI)
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
		[Cpp2IlInjected.Address(RVA = "0x6F3C070", Offset = "0x6F3A870", VA = "0x186F3C070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BFE0", Offset = "0x6F3A7E0", VA = "0x186F3BFE0", Slot = "6")]
		public string ToString(string AENEDEDOEJK, IFormatProvider AGPJBLDNDHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BE40", Offset = "0x6F3A640", VA = "0x186F3BE40", Slot = "4")]
		public bool Equals(floatMinMax LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BF30", Offset = "0x6F3A730", VA = "0x186F3BF30", Slot = "5")]
		public bool Equals(float2 LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BE80", Offset = "0x6F3A680", VA = "0x186F3BE80", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BF60", Offset = "0x6F3A760", VA = "0x186F3BF60", Slot = "2")]
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
		private GCMHPFMKHKC cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F39F40", Offset = "0x6F38740", VA = "0x186F39F40")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F39DE0", Offset = "0x6F385E0", VA = "0x186F39DE0")]
		public LayoutRect(LayoutRect parent, JHAAAKFPINM parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F398F0", Offset = "0x6F380F0", VA = "0x186F398F0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F39850", Offset = "0x6F38050", VA = "0x186F39850")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F398C0", Offset = "0x6F380C0", VA = "0x186F398C0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F39860", Offset = "0x6F38060", VA = "0x186F39860")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F39A00", Offset = "0x6F38200", VA = "0x186F39A00")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F38F40", Offset = "0x6F37740", VA = "0x186F38F40")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F39AB0", Offset = "0x6F382B0", VA = "0x186F39AB0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F39A70", Offset = "0x6F38270", VA = "0x186F39A70")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F39A30", Offset = "0x6F38230", VA = "0x186F39A30")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F39B60", Offset = "0x6F38360", VA = "0x186F39B60")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F39B20", Offset = "0x6F38320", VA = "0x186F39B20")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F39AC0", Offset = "0x6F382C0", VA = "0x186F39AC0")]
		public void SetParentAlignment(JHAAAKFPINM rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F39910", Offset = "0x6F38110", VA = "0x186F39910")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F39970", Offset = "0x6F38170", VA = "0x186F39970")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F39900", Offset = "0x6F38100", VA = "0x186F39900")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F39C10", Offset = "0x6F38410", VA = "0x186F39C10")]
		private GCMHPFMKHKC UpdateCache()
		{
			return default(GCMHPFMKHKC);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum GCMHPFMKHKC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class KCFOMIOMCCN
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] BHGGGAOOECB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F39400", Offset = "0x6F37C00", VA = "0x186F39400")]
	public static float2Rect NHLMOBHPKCD(Transform AHIDDBPIGJL, RectTransform BIINCLMPDMO)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F39720", Offset = "0x6F37F20", VA = "0x186F39720")]
	public static void OKMIDJBPIJB(Vector3[] ECFENBFFAFC, [Out] float2 GMIGPGIEBMN, [Out] float2 KMLOFEFLFLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FIAGABBMIDG
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] INGMNBIBKKA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F392B0", Offset = "0x6F37AB0", VA = "0x186F392B0")]
	public static void JIANPBMKHLL([In] int KPDABBMCONK, [Out] ushort NCGIPKEAKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MOKIMCNMPDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HHGAJNDCLII
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
	[Cpp2IlInjected.Address(RVA = "0x6F3B4E0", Offset = "0x6F39CE0", VA = "0x186F3B4E0")]
	public static void MLDCKMEAFND(float3[] JCDEPJOEGMJ, [In] float2 CKOOCAABKNG, [In] float2 FIFDAHJIFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B250", Offset = "0x6F39A50", VA = "0x186F3B250")]
	public static void LNINKDDEPGO(float2[] LKFIMKOMCJE, [In] float2 DIGGHKEIMIA, [In] float2 DNMCFMIKOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F3ABA0", Offset = "0x6F393A0", VA = "0x186F3ABA0")]
	public static void HMCLLEIOMDP(float3[] JCDEPJOEGMJ, [In] float HNDNEGNHPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B140", Offset = "0x6F39940", VA = "0x186F3B140")]
	public static void LMHOPBLKEBC(QuadVertex[] FDHPEMKCOHP, [In] int NCGIPKEAKCE, [In] float3[] EMMICPEOIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A3A0", Offset = "0x6F38BA0", VA = "0x186F3A3A0")]
	public static void BANPJCMMGJE(QuadVertex[] FDHPEMKCOHP, int NCGIPKEAKCE, [In] float3[] EMMICPEOIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AC10", Offset = "0x6F39410", VA = "0x186F3AC10")]
	public static void JBBMMCFKDJI(QuadVertex[] FDHPEMKCOHP, [In] int NCGIPKEAKCE, [In] Color32 MKFFHGBEBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B2E0", Offset = "0x6F39AE0", VA = "0x186F3B2E0")]
	public static void MCAEHJLCHFE(QuadVertex[] FDHPEMKCOHP, int NCGIPKEAKCE, [In] Color32 MKFFHGBEBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A540", Offset = "0x6F38D40", VA = "0x186F3A540")]
	public static void FAODBOPFPEK(QuadVertex[] FDHPEMKCOHP, [In] int NCGIPKEAKCE, [In] float2[] NDJEPEMMDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AE10", Offset = "0x6F39610", VA = "0x186F3AE10")]
	public static void JILACOJOGAO(QuadVertex[] FDHPEMKCOHP, int NCGIPKEAKCE, [In] float2[] NDJEPEMMDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B360", Offset = "0x6F39B60", VA = "0x186F3B360")]
	public static void MEMFPDKFEPP(QuadVertex[] FDHPEMKCOHP, int NCGIPKEAKCE, [In] float3[] EMMICPEOIOJ, [In] Color32 MKFFHGBEBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AF20", Offset = "0x6F39720", VA = "0x186F3AF20")]
	public static void KBOCBPDDHPF(QuadVertex[] FDHPEMKCOHP, int NCGIPKEAKCE, [In] float3[] EMMICPEOIOJ, [In] float2[] NDJEPEMMDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AC90", Offset = "0x6F39490", VA = "0x186F3AC90")]
	public static void JENIDNKEKMJ(QuadVertex[] FDHPEMKCOHP, int NCGIPKEAKCE, [In] Color32 MKFFHGBEBEI, [In] float2[] NDJEPEMMDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A910", Offset = "0x6F39110", VA = "0x186F3A910")]
	public static void HJFAMLFFMKF(QuadVertex[] FDHPEMKCOHP, int NCGIPKEAKCE, [In] float3[] EMMICPEOIOJ, [In] Color32 MKFFHGBEBEI, [In] float2[] NDJEPEMMDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B560", Offset = "0x6F39D60", VA = "0x186F3B560")]
	public static void OPEBDKPOEEE(ushort[] PEKFDICHDPA, int KPDABBMCONK, [In] int NJBHFOKLKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B690", Offset = "0x6F39E90", VA = "0x186F3B690")]
	public static void PNALOCBOFMK(ushort[] PEKFDICHDPA, int KPDABBMCONK, [In] int NJBHFOKLKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A4B0", Offset = "0x6F38CB0", VA = "0x186F3A4B0")]
	public static void BDKIEJPPPHP(ushort[] PEKFDICHDPA, [In] int KPDABBMCONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B6D0", Offset = "0x6F39ED0", VA = "0x186F3B6D0")]
	public static void PPEDJBHECMO(ushort[] PEKFDICHDPA, [In] int KPDABBMCONK, [In] int NCGIPKEAKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A6D0", Offset = "0x6F38ED0", VA = "0x186F3A6D0")]
	public static Bounds GAEIFJDKGIJ([In] QuadVertex[] FDHPEMKCOHP, [In] ushort[] PEKFDICHDPA, [In] int BFEOIIMNOCA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A090", Offset = "0x6F38890", VA = "0x186F3A090")]
	public static Bounds AJCHBNFMPKO([In] QuadVertex[] FDHPEMKCOHP, [In] ushort[] PEKFDICHDPA, [In] int BFEOIIMNOCA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A650", Offset = "0x6F38E50", VA = "0x186F3A650")]
	[CompilerGenerated]
	internal static void FELLNJBHLFP([In] float3 DOCBAALINAN, HHGAJNDCLII P_1)
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
