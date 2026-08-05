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
public static class HKFMLIHODBC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7496ED0", Offset = "0x7495AD0", VA = "0x187496ED0")]
	public static float2 CCIHDLPOJID(this GPCFPIODJNB EOJHGICHEJJ)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GPCFPIODJNB : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2B71B40", Offset = "0x2B70740", VA = "0x182B71B40")]
		public float2Rect(float2 FCININPMBGJ, float2 FJJGAGKDECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74996E0", Offset = "0x74982E0", VA = "0x1874996E0")]
		public void EALEPKLOIDH([Out] float2 EMNAMLGBLKK, [Out] float2 BNJBKCNPHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7499930", Offset = "0x7498530", VA = "0x187499930")]
		public float2 MKBLDLOHCJL(float2 IBBGJPBKBIG)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7499700", Offset = "0x7498300", VA = "0x187499700", Slot = "4")]
		public bool Equals(float2Rect PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7499780", Offset = "0x7498380", VA = "0x187499780", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7499880", Offset = "0x7498480", VA = "0x187499880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7499960", Offset = "0x7498560", VA = "0x187499960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7499B80", Offset = "0x7498780", VA = "0x187499B80", Slot = "5")]
		public string ToString(string MPDMBPEKKLJ, IFormatProvider PHGPPKPBHGN)
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
		[Cpp2IlInjected.Address(RVA = "0x7499FD0", Offset = "0x7498BD0", VA = "0x187499FD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7499F40", Offset = "0x7498B40", VA = "0x187499F40", Slot = "6")]
		public string ToString(string MPDMBPEKKLJ, IFormatProvider PHGPPKPBHGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7499DA0", Offset = "0x74989A0", VA = "0x187499DA0", Slot = "4")]
		public bool Equals(floatMinMax PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7499E90", Offset = "0x7498A90", VA = "0x187499E90", Slot = "5")]
		public bool Equals(float2 PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7499DE0", Offset = "0x74989E0", VA = "0x187499DE0", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7499EC0", Offset = "0x7498AC0", VA = "0x187499EC0", Slot = "2")]
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
		private CIBNOCMAAAJ cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7499010", Offset = "0x7497C10", VA = "0x187499010")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7499150", Offset = "0x7497D50", VA = "0x187499150")]
		public LayoutRect(LayoutRect parent, GPCFPIODJNB parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7498B20", Offset = "0x7497720", VA = "0x187498B20")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7498A80", Offset = "0x7497680", VA = "0x187498A80")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7498AF0", Offset = "0x74976F0", VA = "0x187498AF0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7498A90", Offset = "0x7497690", VA = "0x187498A90")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7498C30", Offset = "0x7497830", VA = "0x187498C30")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7496FD0", Offset = "0x7495BD0", VA = "0x187496FD0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7498CE0", Offset = "0x74978E0", VA = "0x187498CE0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7498CA0", Offset = "0x74978A0", VA = "0x187498CA0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7498C60", Offset = "0x7497860", VA = "0x187498C60")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7498D90", Offset = "0x7497990", VA = "0x187498D90")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7498D50", Offset = "0x7497950", VA = "0x187498D50")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7498CF0", Offset = "0x74978F0", VA = "0x187498CF0")]
		public void SetParentAlignment(GPCFPIODJNB rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7498B40", Offset = "0x7497740", VA = "0x187498B40")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7498BA0", Offset = "0x74977A0", VA = "0x187498BA0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7498B30", Offset = "0x7497730", VA = "0x187498B30")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7498E40", Offset = "0x7497A40", VA = "0x187498E40")]
		private CIBNOCMAAAJ UpdateCache()
		{
			return default(CIBNOCMAAAJ);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CIBNOCMAAAJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MHLGNMDOKAP
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] EEBDPPLFHDA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7499360", Offset = "0x7497F60", VA = "0x187499360")]
	public static float2Rect OLNDBCBNFBD(Transform CCKJCBBHMAD, RectTransform EJGAMJDEIEL)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x74992A0", Offset = "0x7497EA0", VA = "0x1874992A0")]
	public static void FKINEAJMCGK(Vector3[] EKLKDPFFEAC, [Out] float2 DMOKGKPBDAL, [Out] float2 IBGGHDAOBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LPJKBEIIOJO
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] APDNFEOPAIG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7498940", Offset = "0x7497540", VA = "0x187498940")]
	public static void MMIOPKECNFG([In] int LKMKMDBEGGG, [Out] ushort NFEDHLCCDBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DFMFHLBCOKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NIBJBIGFNNM
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
	[Cpp2IlInjected.Address(RVA = "0x7497A20", Offset = "0x7496620", VA = "0x187497A20")]
	public static void GMDMMONALNO(float3[] GOBILMMKDEO, [In] float2 EOHPFAILPHF, [In] float2 BNJBKCNPHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7497680", Offset = "0x7496280", VA = "0x187497680")]
	public static void DJBKNOAFHDO(float2[] JJDPOMMJMKE, [In] float2 BMPANAHCPON, [In] float2 MHBOEHMPHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7497440", Offset = "0x7496040", VA = "0x187497440")]
	public static void BNGECPDKCFJ(float3[] GOBILMMKDEO, [In] float DOEKIEMNDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74983B0", Offset = "0x7496FB0", VA = "0x1874983B0")]
	public static void PBMONAFKKNF(QuadVertex[] HGCDDOPJELK, [In] int NFEDHLCCDBA, [In] float3[] EINOIINPFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x74984C0", Offset = "0x74970C0", VA = "0x1874984C0")]
	public static void PGKNIHPAMPC(QuadVertex[] HGCDDOPJELK, int NFEDHLCCDBA, [In] float3[] EINOIINPFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x74973C0", Offset = "0x7495FC0", VA = "0x1874973C0")]
	public static void ALIOKMBFPLN(QuadVertex[] HGCDDOPJELK, [In] int NFEDHLCCDBA, [In] Color32 ICAIJOFBIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7497AA0", Offset = "0x74966A0", VA = "0x187497AA0")]
	public static void KAIEJCPDBHJ(QuadVertex[] HGCDDOPJELK, int NFEDHLCCDBA, [In] Color32 ICAIJOFBIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7497570", Offset = "0x7496170", VA = "0x187497570")]
	public static void DGDMCGPLILO(QuadVertex[] HGCDDOPJELK, [In] int NFEDHLCCDBA, [In] float2[] LPJBAKIJALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7497710", Offset = "0x7496310", VA = "0x187497710")]
	public static void ECHEMDPNKHC(QuadVertex[] HGCDDOPJELK, int NFEDHLCCDBA, [In] float2[] LPJBAKIJALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7497240", Offset = "0x7495E40", VA = "0x187497240")]
	public static void AIOMOCBEBHD(QuadVertex[] HGCDDOPJELK, int NFEDHLCCDBA, [In] float3[] EINOIINPFJM, [In] Color32 ICAIJOFBIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7497E80", Offset = "0x7496A80", VA = "0x187497E80")]
	public static void NNFCHMLBCDP(QuadVertex[] HGCDDOPJELK, int NFEDHLCCDBA, [In] float3[] EINOIINPFJM, [In] float2[] LPJBAKIJALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x74978A0", Offset = "0x74964A0", VA = "0x1874978A0")]
	public static void FDNJEHALMHA(QuadVertex[] HGCDDOPJELK, int NFEDHLCCDBA, [In] Color32 ICAIJOFBIBG, [In] float2[] LPJBAKIJALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7497BF0", Offset = "0x74967F0", VA = "0x187497BF0")]
	public static void KMGOCMHGPFJ(QuadVertex[] HGCDDOPJELK, int NFEDHLCCDBA, [In] float3[] EINOIINPFJM, [In] Color32 ICAIJOFBIBG, [In] float2[] LPJBAKIJALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7498810", Offset = "0x7497410", VA = "0x187498810")]
	public static void PPDHDIPLLMD(ushort[] OEACGOFFDOK, int LKMKMDBEGGG, [In] int IJBIGPLEEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7497B20", Offset = "0x7496720", VA = "0x187497B20")]
	public static void KDJCNBHKNFB(ushort[] OEACGOFFDOK, int LKMKMDBEGGG, [In] int IJBIGPLEEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7497B60", Offset = "0x7496760", VA = "0x187497B60")]
	public static void KICCFJDDCNK(ushort[] OEACGOFFDOK, [In] int LKMKMDBEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x74974B0", Offset = "0x74960B0", VA = "0x1874974B0")]
	public static void CLCCJHDBGCJ(ushort[] OEACGOFFDOK, [In] int LKMKMDBEGGG, [In] int NFEDHLCCDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x74985D0", Offset = "0x74971D0", VA = "0x1874985D0")]
	public static Bounds PMNCHCMJEOL([In] QuadVertex[] HGCDDOPJELK, [In] ushort[] OEACGOFFDOK, [In] int OFPPEGIGEAE)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x74980A0", Offset = "0x7496CA0", VA = "0x1874980A0")]
	public static Bounds NNGDLMIDBDF([In] QuadVertex[] HGCDDOPJELK, [In] ushort[] OEACGOFFDOK, [In] int OFPPEGIGEAE)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7497820", Offset = "0x7496420", VA = "0x187497820")]
	[CompilerGenerated]
	internal static void EGOOGMJMPOA([In] float3 NKBNDBLIKOB, NIBJBIGFNNM P_1)
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
