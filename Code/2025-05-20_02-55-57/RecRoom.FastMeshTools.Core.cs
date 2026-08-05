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
public static class PNEOFEGHNGB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F2F0", Offset = "0x7C7E4F0", VA = "0x187C7F2F0")]
	public static float2 GHHEHAHLEMN(this MIJGIDMODHN HAJLMJABFBH)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MIJGIDMODHN : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2E42940", Offset = "0x2E41B40", VA = "0x182E42940")]
		public float2Rect(float2 BJHAAAPCKLC, float2 JAFKPMJIGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C81A30", Offset = "0x7C80C30", VA = "0x187C81A30")]
		public void EFFIMEDBJAK([Out] float2 PAJPNMHBCNF, [Out] float2 HIHPPKOIMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C81C80", Offset = "0x7C80E80", VA = "0x187C81C80")]
		public float2 JONNEAACFJO(float2 DDAGDCKIJFL)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C81A50", Offset = "0x7C80C50", VA = "0x187C81A50", Slot = "4")]
		public bool Equals(float2Rect FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C81AD0", Offset = "0x7C80CD0", VA = "0x187C81AD0", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C81BD0", Offset = "0x7C80DD0", VA = "0x187C81BD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C81CB0", Offset = "0x7C80EB0", VA = "0x187C81CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C81ED0", Offset = "0x7C810D0", VA = "0x187C81ED0", Slot = "5")]
		public string ToString(string HPCBECKKHGG, IFormatProvider MAMHBLJAPHN)
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
		[Cpp2IlInjected.Address(RVA = "0x7C82310", Offset = "0x7C81510", VA = "0x187C82310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C82280", Offset = "0x7C81480", VA = "0x187C82280", Slot = "6")]
		public string ToString(string HPCBECKKHGG, IFormatProvider MAMHBLJAPHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C820E0", Offset = "0x7C812E0", VA = "0x187C820E0", Slot = "4")]
		public bool Equals(floatMinMax FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C821D0", Offset = "0x7C813D0", VA = "0x187C821D0", Slot = "5")]
		public bool Equals(float2 FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C82120", Offset = "0x7C81320", VA = "0x187C82120", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C82200", Offset = "0x7C81400", VA = "0x187C82200", Slot = "2")]
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
		private MBGADIKKEPN cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FDA0", Offset = "0x7C7EFA0", VA = "0x187C7FDA0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FC50", Offset = "0x7C7EE50", VA = "0x187C7FC50")]
		public LayoutRect(LayoutRect parent, MIJGIDMODHN parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F710", Offset = "0x7C7E910", VA = "0x187C7F710")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F670", Offset = "0x7C7E870", VA = "0x187C7F670")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F6E0", Offset = "0x7C7E8E0", VA = "0x187C7F6E0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F680", Offset = "0x7C7E880", VA = "0x187C7F680")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F820", Offset = "0x7C7EA20", VA = "0x187C7F820")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C7EFD0", Offset = "0x7C7E1D0", VA = "0x187C7EFD0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F920", Offset = "0x7C7EB20", VA = "0x187C7F920")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F8D0", Offset = "0x7C7EAD0", VA = "0x187C7F8D0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F880", Offset = "0x7C7EA80", VA = "0x187C7F880")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F9D0", Offset = "0x7C7EBD0", VA = "0x187C7F9D0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F980", Offset = "0x7C7EB80", VA = "0x187C7F980")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F930", Offset = "0x7C7EB30", VA = "0x187C7F930")]
		public void SetParentAlignment(MIJGIDMODHN rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F730", Offset = "0x7C7E930", VA = "0x187C7F730")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F790", Offset = "0x7C7E990", VA = "0x187C7F790")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F720", Offset = "0x7C7E920", VA = "0x187C7F720")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FA80", Offset = "0x7C7EC80", VA = "0x187C7FA80")]
		private MBGADIKKEPN UpdateCache()
		{
			return default(MBGADIKKEPN);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MBGADIKKEPN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MBAPFOMJEEC
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] PNEGHELADIL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C7FFB0", Offset = "0x7C7F1B0", VA = "0x187C7FFB0")]
	public static float2Rect MFNNNALPPAF(Transform AJPEIIJDONE, RectTransform PJNHLGGHCLG)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C7FEF0", Offset = "0x7C7F0F0", VA = "0x187C7FEF0")]
	public static void CENEGGMLFGB(Vector3[] AMNOACAOPGF, [Out] float2 BCBBNNPFNAH, [Out] float2 IMCPMFMKKOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FIIDAMCFDFL
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] AOEGKKKONDL;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F530", Offset = "0x7C7E730", VA = "0x187C7F530")]
	public static void GBMAIHIHBCB([In] int LAOLPMDHHON, [Out] ushort EJCHHCNMIEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NPBKIMEIMGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CMMCPNBBKNM
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
	[Cpp2IlInjected.Address(RVA = "0x7C819B0", Offset = "0x7C80BB0", VA = "0x187C819B0")]
	public static void OHOLNFAKALL(float3[] JCLGLCKBFEO, [In] float2 LCLBMLKFLAP, [In] float2 HIHPPKOIMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C80D70", Offset = "0x7C7FF70", VA = "0x187C80D70")]
	public static void FAHMLGOFLCF(float2[] ELGLLJEOELG, [In] float2 HPLPBHKGFBF, [In] float2 KMOOCKHKDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C81410", Offset = "0x7C80610", VA = "0x187C81410")]
	public static void KNCENEMEDFG(float3[] JCLGLCKBFEO, [In] float OJIDNLKANON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C80AF0", Offset = "0x7C7FCF0", VA = "0x187C80AF0")]
	public static void CPAEOCIOFEG(QuadVertex[] JKCDEODAKEN, [In] int EJCHHCNMIEB, [In] float3[] CHKMBHILLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C81810", Offset = "0x7C80A10", VA = "0x187C81810")]
	public static void OAPIPNJMAJF(QuadVertex[] JKCDEODAKEN, int EJCHHCNMIEB, [In] float3[] CHKMBHILLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C81390", Offset = "0x7C80590", VA = "0x187C81390")]
	public static void KLCGNJPJNLM(QuadVertex[] JKCDEODAKEN, [In] int EJCHHCNMIEB, [In] Color32 NPMPONPGFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C81480", Offset = "0x7C80680", VA = "0x187C81480")]
	public static void LMFAFDGIFPB(QuadVertex[] JKCDEODAKEN, int EJCHHCNMIEB, [In] Color32 NPMPONPGFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C81280", Offset = "0x7C80480", VA = "0x187C81280")]
	public static void JLHEKCJEMHI(QuadVertex[] JKCDEODAKEN, [In] int EJCHHCNMIEB, [In] float2[] IMKNHCAPABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C804B0", Offset = "0x7C7F6B0", VA = "0x187C804B0")]
	public static void AINJPECGEGA(QuadVertex[] JKCDEODAKEN, int EJCHHCNMIEB, [In] float2[] IMKNHCAPABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C80330", Offset = "0x7C7F530", VA = "0x187C80330")]
	public static void ABOCKEJKFNP(QuadVertex[] JKCDEODAKEN, int EJCHHCNMIEB, [In] float3[] CHKMBHILLOA, [In] Color32 NPMPONPGFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C80850", Offset = "0x7C7FA50", VA = "0x187C80850")]
	public static void BNNHNIOCHHA(QuadVertex[] JKCDEODAKEN, int EJCHHCNMIEB, [In] float3[] CHKMBHILLOA, [In] float2[] IMKNHCAPABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C80E00", Offset = "0x7C80000", VA = "0x187C80E00")]
	public static void GCHJKMOHPCN(QuadVertex[] JKCDEODAKEN, int EJCHHCNMIEB, [In] Color32 NPMPONPGFKC, [In] float2[] IMKNHCAPABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C805C0", Offset = "0x7C7F7C0", VA = "0x187C805C0")]
	public static void BNMHLHAOINI(QuadVertex[] JKCDEODAKEN, int EJCHHCNMIEB, [In] float3[] CHKMBHILLOA, [In] Color32 NPMPONPGFKC, [In] float2[] IMKNHCAPABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C80C40", Offset = "0x7C7FE40", VA = "0x187C80C40")]
	public static void ECDMJOEDDCF(ushort[] GMFBAEIKGLI, int LAOLPMDHHON, [In] int JOODHLALGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C80C00", Offset = "0x7C7FE00", VA = "0x187C80C00")]
	public static void DHENGCIPJBC(ushort[] GMFBAEIKGLI, int LAOLPMDHHON, [In] int JOODHLALGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C81920", Offset = "0x7C80B20", VA = "0x187C81920")]
	public static void OHNIMPNFJIF(ushort[] GMFBAEIKGLI, [In] int LAOLPMDHHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C811C0", Offset = "0x7C803C0", VA = "0x187C811C0")]
	public static void JCPLLPJMOJF(ushort[] GMFBAEIKGLI, [In] int LAOLPMDHHON, [In] int EJCHHCNMIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C80F80", Offset = "0x7C80180", VA = "0x187C80F80")]
	public static Bounds GDAOPHCPGGO([In] QuadVertex[] JKCDEODAKEN, [In] ushort[] GMFBAEIKGLI, [In] int FPCIPNNBPNF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C81500", Offset = "0x7C80700", VA = "0x187C81500")]
	public static Bounds MFIFMEGEJMN([In] QuadVertex[] JKCDEODAKEN, [In] ushort[] GMFBAEIKGLI, [In] int FPCIPNNBPNF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C80A70", Offset = "0x7C7FC70", VA = "0x187C80A70")]
	[CompilerGenerated]
	internal static void CNLAKIBLMNI([In] float3 OJJILHCFMHP, CMMCPNBBKNM P_1)
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
