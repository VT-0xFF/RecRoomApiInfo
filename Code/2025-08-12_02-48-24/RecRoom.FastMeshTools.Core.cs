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
public static class HCCMKHCDHEI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8447B20", Offset = "0x8446120", VA = "0x188447B20")]
	public static float2 LHOHNENDCPB(this LEPECGJMIGJ PAONAEEGLOH)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LEPECGJMIGJ : byte
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
		[Cpp2IlInjected.Address(RVA = "0x309D6B0", Offset = "0x309BCB0", VA = "0x18309D6B0")]
		public float2Rect(float2 AANGPKCDGHO, float2 MLMBLBFOLPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x844A3C0", Offset = "0x84489C0", VA = "0x18844A3C0")]
		public void BHACFNDCJGJ([Out] float2 FGDCJODLPDN, [Out] float2 AJCPBOIAMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x844A610", Offset = "0x8448C10", VA = "0x18844A610")]
		public float2 KBMLHCLFLFP(float2 JAECPBKCLAP)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x844A3E0", Offset = "0x84489E0", VA = "0x18844A3E0", Slot = "4")]
		public bool Equals(float2Rect IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x844A460", Offset = "0x8448A60", VA = "0x18844A460", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x844A560", Offset = "0x8448B60", VA = "0x18844A560", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x844A640", Offset = "0x8448C40", VA = "0x18844A640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x844A860", Offset = "0x8448E60", VA = "0x18844A860", Slot = "5")]
		public string ToString(string IENFMLICFPK, IFormatProvider KONCNBNKGKA)
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
		[Cpp2IlInjected.Address(RVA = "0x844ACB0", Offset = "0x84492B0", VA = "0x18844ACB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x844AC20", Offset = "0x8449220", VA = "0x18844AC20", Slot = "6")]
		public string ToString(string IENFMLICFPK, IFormatProvider KONCNBNKGKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x844AA80", Offset = "0x8449080", VA = "0x18844AA80", Slot = "4")]
		public bool Equals(floatMinMax IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x844AB70", Offset = "0x8449170", VA = "0x18844AB70", Slot = "5")]
		public bool Equals(float2 IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x844AAC0", Offset = "0x84490C0", VA = "0x18844AAC0", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x844ABA0", Offset = "0x84491A0", VA = "0x18844ABA0", Slot = "2")]
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
		private EIFKODILOFH cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8449B80", Offset = "0x8448180", VA = "0x188449B80")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8449CD0", Offset = "0x84482D0", VA = "0x188449CD0")]
		public LayoutRect(LayoutRect parent, LEPECGJMIGJ parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8449640", Offset = "0x8447C40", VA = "0x188449640")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84495A0", Offset = "0x8447BA0", VA = "0x1884495A0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8449610", Offset = "0x8447C10", VA = "0x188449610")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84495B0", Offset = "0x8447BB0", VA = "0x1884495B0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8449750", Offset = "0x8447D50", VA = "0x188449750")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8447C20", Offset = "0x8446220", VA = "0x188447C20")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8449850", Offset = "0x8447E50", VA = "0x188449850")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8449800", Offset = "0x8447E00", VA = "0x188449800")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84497B0", Offset = "0x8447DB0", VA = "0x1884497B0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8449900", Offset = "0x8447F00", VA = "0x188449900")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84498B0", Offset = "0x8447EB0", VA = "0x1884498B0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8449860", Offset = "0x8447E60", VA = "0x188449860")]
		public void SetParentAlignment(LEPECGJMIGJ rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8449660", Offset = "0x8447C60", VA = "0x188449660")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84496C0", Offset = "0x8447CC0", VA = "0x1884496C0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8449650", Offset = "0x8447C50", VA = "0x188449650")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84499B0", Offset = "0x8447FB0", VA = "0x1884499B0")]
		private EIFKODILOFH UpdateCache()
		{
			return default(EIFKODILOFH);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum EIFKODILOFH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MKMFPKAIHAD
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] FNOEOOADCID;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8449EE0", Offset = "0x84484E0", VA = "0x188449EE0")]
	public static float2Rect OKGKLOKEGCC(Transform OAEJNGPCKCP, RectTransform LKEAKCADNOO)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8449E20", Offset = "0x8448420", VA = "0x188449E20")]
	public static void JGDNAOBENDL(Vector3[] CLAFDPLIANC, [Out] float2 AJNNFOKDGKA, [Out] float2 BHCLOJJFNGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OAOJNAMHOMG
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] NHKADFIEIBH;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x844A270", Offset = "0x8448870", VA = "0x18844A270")]
	public static void BOLALNBKHIB([In] int EBOAMLPNMKM, [Out] ushort PCPMLFIGIEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HLDMIHBFLCD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HFDNFJONDPI
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
	[Cpp2IlInjected.Address(RVA = "0x84486C0", Offset = "0x8446CC0", VA = "0x1884486C0")]
	public static void GDIPOHKBKBI(float3[] MHOBCEENJCN, [In] float2 MBODJPMLBLH, [In] float2 AJCPBOIAMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8448EE0", Offset = "0x84474E0", VA = "0x188448EE0")]
	public static void IOKBBPFOLKL(float2[] MKENFGMPINK, [In] float2 OGHIFLOKKEP, [In] float2 LJLLPINFJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8448650", Offset = "0x8446C50", VA = "0x188448650")]
	public static void FGEKLFOHEAM(float3[] MHOBCEENJCN, [In] float IKDMOCKOIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84480E0", Offset = "0x84466E0", VA = "0x1884480E0")]
	public static void DFHHJCBKAOC(QuadVertex[] AFAAEBBPFPC, [In] int PCPMLFIGIEA, [In] float3[] BDFIPBINODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8448940", Offset = "0x8446F40", VA = "0x188448940")]
	public static void HCFDCEMJBLN(QuadVertex[] AFAAEBBPFPC, int PCPMLFIGIEA, [In] float3[] BDFIPBINODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84488C0", Offset = "0x8446EC0", VA = "0x1884488C0")]
	public static void HACDFDJCEJN(QuadVertex[] AFAAEBBPFPC, [In] int PCPMLFIGIEA, [In] Color32 IELNLNBBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84485D0", Offset = "0x8446BD0", VA = "0x1884485D0")]
	public static void FAEEIGBDKBF(QuadVertex[] AFAAEBBPFPC, int PCPMLFIGIEA, [In] Color32 IELNLNBBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8448430", Offset = "0x8446A30", VA = "0x188448430")]
	public static void EBLKNCOKMOH(QuadVertex[] AFAAEBBPFPC, [In] int PCPMLFIGIEA, [In] float2[] IEJFKHMNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8447FD0", Offset = "0x84465D0", VA = "0x188447FD0")]
	public static void COHDMIEMAJC(QuadVertex[] AFAAEBBPFPC, int PCPMLFIGIEA, [In] float2[] IEJFKHMNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8448D60", Offset = "0x8447360", VA = "0x188448D60")]
	public static void IJAGALPKFKJ(QuadVertex[] AFAAEBBPFPC, int PCPMLFIGIEA, [In] float3[] BDFIPBINODN, [In] Color32 IELNLNBBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84492C0", Offset = "0x84478C0", VA = "0x1884492C0")]
	public static void OMEFGIKFHOB(QuadVertex[] AFAAEBBPFPC, int PCPMLFIGIEA, [In] float3[] BDFIPBINODN, [In] float2[] IEJFKHMNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8448740", Offset = "0x8446D40", VA = "0x188448740")]
	public static void GMJHGALBGAO(QuadVertex[] AFAAEBBPFPC, int PCPMLFIGIEA, [In] Color32 IELNLNBBGCO, [In] float2[] IEJFKHMNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8448AD0", Offset = "0x84470D0", VA = "0x188448AD0")]
	public static void IDLEMOKGPDK(QuadVertex[] AFAAEBBPFPC, int PCPMLFIGIEA, [In] float3[] BDFIPBINODN, [In] Color32 IELNLNBBGCO, [In] float2[] IEJFKHMNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8447EA0", Offset = "0x84464A0", VA = "0x188447EA0")]
	public static void COBALCBPGEK(ushort[] MIEKPHIDELH, int EBOAMLPNMKM, [In] int FJPBDFEHNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8449280", Offset = "0x8447880", VA = "0x188449280")]
	public static void NDEKBCFDKGM(ushort[] MIEKPHIDELH, int EBOAMLPNMKM, [In] int FJPBDFEHNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8448540", Offset = "0x8446B40", VA = "0x188448540")]
	public static void ECPHKCNDPOM(ushort[] MIEKPHIDELH, [In] int EBOAMLPNMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84494E0", Offset = "0x8447AE0", VA = "0x1884494E0")]
	public static void PEFFJBPDGDI(ushort[] MIEKPHIDELH, [In] int EBOAMLPNMKM, [In] int PCPMLFIGIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84481F0", Offset = "0x84467F0", VA = "0x1884481F0")]
	public static Bounds DNHFMEEAPPE([In] QuadVertex[] AFAAEBBPFPC, [In] ushort[] MIEKPHIDELH, [In] int FBMDGKHBLNE)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8448F70", Offset = "0x8447570", VA = "0x188448F70")]
	public static Bounds LHGPHIGMIFE([In] QuadVertex[] AFAAEBBPFPC, [In] ushort[] MIEKPHIDELH, [In] int FBMDGKHBLNE)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8448A50", Offset = "0x8447050", VA = "0x188448A50")]
	[CompilerGenerated]
	internal static void HFMPKJENGNF([In] float3 JHCGOEHIHDC, HFDNFJONDPI P_1)
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
