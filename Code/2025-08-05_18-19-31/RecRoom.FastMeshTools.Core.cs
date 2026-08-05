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
public static class PODIGBBDEAF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8291BC0", Offset = "0x8290FC0", VA = "0x188291BC0")]
	public static float2 BIDFBHJELBM(this PLGODKNEODI OFELPJPIBJK)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PLGODKNEODI : byte
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
		[Cpp2IlInjected.Address(RVA = "0x302F400", Offset = "0x302E800", VA = "0x18302F400")]
		public float2Rect(float2 LBCFHLNAPLC, float2 MPDDFCCPIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8294320", Offset = "0x8293720", VA = "0x188294320")]
		public void BBBPACNHLNO([Out] float2 AACCHEHAOIO, [Out] float2 FNBDFFPLGIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8294340", Offset = "0x8293740", VA = "0x188294340")]
		public float2 CAKADLMHKFB(float2 JLKEEHDBJOG)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8294370", Offset = "0x8293770", VA = "0x188294370", Slot = "4")]
		public bool Equals(float2Rect LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82943F0", Offset = "0x82937F0", VA = "0x1882943F0", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82944F0", Offset = "0x82938F0", VA = "0x1882944F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82945A0", Offset = "0x82939A0", VA = "0x1882945A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82947C0", Offset = "0x8293BC0", VA = "0x1882947C0", Slot = "5")]
		public string ToString(string LKPDHLBCOHA, IFormatProvider PEDOFKBGLGM)
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
		[Cpp2IlInjected.Address(RVA = "0x8294C10", Offset = "0x8294010", VA = "0x188294C10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8294B80", Offset = "0x8293F80", VA = "0x188294B80", Slot = "6")]
		public string ToString(string LKPDHLBCOHA, IFormatProvider PEDOFKBGLGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82949E0", Offset = "0x8293DE0", VA = "0x1882949E0", Slot = "4")]
		public bool Equals(floatMinMax LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8294AD0", Offset = "0x8293ED0", VA = "0x188294AD0", Slot = "5")]
		public bool Equals(float2 LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8294A20", Offset = "0x8293E20", VA = "0x188294A20", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8294B00", Offset = "0x8293F00", VA = "0x188294B00", Slot = "2")]
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
		private MDPCBOOKADO cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8293C30", Offset = "0x8293030", VA = "0x188293C30")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8293D80", Offset = "0x8293180", VA = "0x188293D80")]
		public LayoutRect(LayoutRect parent, PLGODKNEODI parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82936F0", Offset = "0x8292AF0", VA = "0x1882936F0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8293650", Offset = "0x8292A50", VA = "0x188293650")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82936C0", Offset = "0x8292AC0", VA = "0x1882936C0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8293660", Offset = "0x8292A60", VA = "0x188293660")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8293800", Offset = "0x8292C00", VA = "0x188293800")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8291A80", Offset = "0x8290E80", VA = "0x188291A80")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8293900", Offset = "0x8292D00", VA = "0x188293900")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82938B0", Offset = "0x8292CB0", VA = "0x1882938B0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8293860", Offset = "0x8292C60", VA = "0x188293860")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82939B0", Offset = "0x8292DB0", VA = "0x1882939B0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8293960", Offset = "0x8292D60", VA = "0x188293960")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8293910", Offset = "0x8292D10", VA = "0x188293910")]
		public void SetParentAlignment(PLGODKNEODI rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8293710", Offset = "0x8292B10", VA = "0x188293710")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8293770", Offset = "0x8292B70", VA = "0x188293770")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8293700", Offset = "0x8292B00", VA = "0x188293700")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8293A60", Offset = "0x8292E60", VA = "0x188293A60")]
		private MDPCBOOKADO UpdateCache()
		{
			return default(MDPCBOOKADO);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MDPCBOOKADO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OFFLGAKCEKM
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] NILMCNGAKNL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8293F90", Offset = "0x8293390", VA = "0x188293F90")]
	public static float2Rect PGGFLCCOBGG(Transform DDEMOKFPDJB, RectTransform NJJNDJLGDNH)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8293ED0", Offset = "0x82932D0", VA = "0x188293ED0")]
	public static void LHAPGMNHKDJ(Vector3[] FKLCBPAEKOL, [Out] float2 FELPICHHHLC, [Out] float2 IDCCLFDFCEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IMOENGAMFOL
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] GINNEKBBHHD;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8293500", Offset = "0x8292900", VA = "0x188293500")]
	public static void GKMDLAHJOCI([In] int DGOIANCLDEJ, [Out] ushort COOFPDBLPLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GPNFGGNFNEO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AHIGJLKKMHP
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
	[Cpp2IlInjected.Address(RVA = "0x8291F10", Offset = "0x8291310", VA = "0x188291F10")]
	public static void AOKKLHEGGON(float3[] BLBFHDPMCNL, [In] float2 AACPJONNAHK, [In] float2 FNBDFFPLGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8292050", Offset = "0x8291450", VA = "0x188292050")]
	public static void DFALGKMAKOL(float2[] LKKOJLJBACB, [In] float2 CPCCEFEBEGG, [In] float2 FMPGDINDGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8293140", Offset = "0x8292540", VA = "0x188293140")]
	public static void MCJLLBLNBLC(float3[] BLBFHDPMCNL, [In] float BBONFLIAOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8293330", Offset = "0x8292730", VA = "0x188293330")]
	public static void MKJBJDPNOKF(QuadVertex[] JHLBEFNIFND, [In] int COOFPDBLPLN, [In] float3[] AMFAFDOBOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82921F0", Offset = "0x82915F0", VA = "0x1882921F0")]
	public static void DPHONGMLCIO(QuadVertex[] JHLBEFNIFND, int COOFPDBLPLN, [In] float3[] AMFAFDOBOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8292300", Offset = "0x8291700", VA = "0x188292300")]
	public static void GJEKFDGHLMD(QuadVertex[] JHLBEFNIFND, [In] int COOFPDBLPLN, [In] Color32 OMLHCPEEEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8293480", Offset = "0x8292880", VA = "0x188293480")]
	public static void NPOLMDIFJMO(QuadVertex[] JHLBEFNIFND, int COOFPDBLPLN, [In] Color32 OMLHCPEEEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8291E00", Offset = "0x8291200", VA = "0x188291E00")]
	public static void AJPNKECELIK(QuadVertex[] JHLBEFNIFND, [In] int COOFPDBLPLN, [In] float2[] MEOGFPCLBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82920E0", Offset = "0x82914E0", VA = "0x1882920E0")]
	public static void DNANEIDCCGD(QuadVertex[] JHLBEFNIFND, int COOFPDBLPLN, [In] float2[] MEOGFPCLBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82931B0", Offset = "0x82925B0", VA = "0x1882931B0")]
	public static void MINECNIMFKE(QuadVertex[] JHLBEFNIFND, int COOFPDBLPLN, [In] float3[] AMFAFDOBOBF, [In] Color32 OMLHCPEEEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8292C00", Offset = "0x8292000", VA = "0x188292C00")]
	public static void KPPCMJKPCCO(QuadVertex[] JHLBEFNIFND, int COOFPDBLPLN, [In] float3[] AMFAFDOBOBF, [In] float2[] MEOGFPCLBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8292A80", Offset = "0x8291E80", VA = "0x188292A80")]
	public static void KGOBJNFAHAP(QuadVertex[] JHLBEFNIFND, int COOFPDBLPLN, [In] Color32 OMLHCPEEEDJ, [In] float2[] MEOGFPCLBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8292EB0", Offset = "0x82922B0", VA = "0x188292EB0")]
	public static void LOOKLLHNNEJ(QuadVertex[] JHLBEFNIFND, int COOFPDBLPLN, [In] float3[] AMFAFDOBOBF, [In] Color32 OMLHCPEEEDJ, [In] float2[] MEOGFPCLBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8292380", Offset = "0x8291780", VA = "0x188292380")]
	public static void JBJKAAEPOLP(ushort[] NKEIMBHPNJH, int DGOIANCLDEJ, [In] int PEBDCKNOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8293440", Offset = "0x8292840", VA = "0x188293440")]
	public static void MMHOEMDJAFG(ushort[] NKEIMBHPNJH, int DGOIANCLDEJ, [In] int PEBDCKNOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8292E20", Offset = "0x8292220", VA = "0x188292E20")]
	public static void LFBDFJPAOOD(ushort[] NKEIMBHPNJH, [In] int DGOIANCLDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8291F90", Offset = "0x8291390", VA = "0x188291F90")]
	public static void DEIMJAEOFOC(ushort[] NKEIMBHPNJH, [In] int DGOIANCLDEJ, [In] int COOFPDBLPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x82924B0", Offset = "0x82918B0", VA = "0x1882924B0")]
	public static Bounds JFEDOGGGCDN([In] QuadVertex[] JHLBEFNIFND, [In] ushort[] NKEIMBHPNJH, [In] int NPLFGEAMKOD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x82926F0", Offset = "0x8291AF0", VA = "0x1882926F0")]
	public static Bounds JNJPILEPBJE([In] QuadVertex[] JHLBEFNIFND, [In] ushort[] NKEIMBHPNJH, [In] int NPLFGEAMKOD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8292A00", Offset = "0x8291E00", VA = "0x188292A00")]
	[CompilerGenerated]
	internal static void KEKINPBHAMC([In] float3 AOECCAAAEOB, AHIGJLKKMHP P_1)
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
