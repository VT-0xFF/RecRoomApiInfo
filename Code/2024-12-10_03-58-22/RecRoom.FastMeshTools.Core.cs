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
public static class OMJPAMCIKFB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C33840", Offset = "0x6C32440", VA = "0x186C33840")]
	public static float2 HBPMALLPGKI(this MNNFLCHAPEL MFBDPDEGDMG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MNNFLCHAPEL : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2766BB0", Offset = "0x27657B0", VA = "0x182766BB0")]
		public float2Rect(float2 GKJAMFFKDLE, float2 OLKJNOHMJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C36180", Offset = "0x6C34D80", VA = "0x186C36180")]
		public void KHJFAIMOGKG([Out] float2 EIJHIDOMGMP, [Out] float2 CBKMEBCGCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C35F20", Offset = "0x6C34B20", VA = "0x186C35F20")]
		public float2 DOOEANNMMNA(float2 KAMDJBFNMAD)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C35F50", Offset = "0x6C34B50", VA = "0x186C35F50", Slot = "4")]
		public bool Equals(float2Rect FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6C35FD0", Offset = "0x6C34BD0", VA = "0x186C35FD0", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C360D0", Offset = "0x6C34CD0", VA = "0x186C360D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C361A0", Offset = "0x6C34DA0", VA = "0x186C361A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C363C0", Offset = "0x6C34FC0", VA = "0x186C363C0", Slot = "5")]
		public string ToString(string DNBEJMJLODH, IFormatProvider HDLIIBOCAJJ)
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
		[Cpp2IlInjected.Address(RVA = "0x6C36800", Offset = "0x6C35400", VA = "0x186C36800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C36770", Offset = "0x6C35370", VA = "0x186C36770", Slot = "6")]
		public string ToString(string DNBEJMJLODH, IFormatProvider HDLIIBOCAJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C365D0", Offset = "0x6C351D0", VA = "0x186C365D0", Slot = "4")]
		public bool Equals(floatMinMax FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C366C0", Offset = "0x6C352C0", VA = "0x186C366C0", Slot = "5")]
		public bool Equals(float2 FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C36610", Offset = "0x6C35210", VA = "0x186C36610", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C366F0", Offset = "0x6C352F0", VA = "0x186C366F0", Slot = "2")]
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
		private NHNFMGPJJAF cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C35C90", Offset = "0x6C34890", VA = "0x186C35C90")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C35DD0", Offset = "0x6C349D0", VA = "0x186C35DD0")]
		public LayoutRect(LayoutRect parent, MNNFLCHAPEL parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C357A0", Offset = "0x6C343A0", VA = "0x186C357A0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C35700", Offset = "0x6C34300", VA = "0x186C35700")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C35770", Offset = "0x6C34370", VA = "0x186C35770")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C35710", Offset = "0x6C34310", VA = "0x186C35710")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C358B0", Offset = "0x6C344B0", VA = "0x186C358B0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C33710", Offset = "0x6C32310", VA = "0x186C33710")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C35960", Offset = "0x6C34560", VA = "0x186C35960")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C35920", Offset = "0x6C34520", VA = "0x186C35920")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C358E0", Offset = "0x6C344E0", VA = "0x186C358E0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C35A10", Offset = "0x6C34610", VA = "0x186C35A10")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C359D0", Offset = "0x6C345D0", VA = "0x186C359D0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C35970", Offset = "0x6C34570", VA = "0x186C35970")]
		public void SetParentAlignment(MNNFLCHAPEL rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C357C0", Offset = "0x6C343C0", VA = "0x186C357C0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C35820", Offset = "0x6C34420", VA = "0x186C35820")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C357B0", Offset = "0x6C343B0", VA = "0x186C357B0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C35AC0", Offset = "0x6C346C0", VA = "0x186C35AC0")]
		private NHNFMGPJJAF UpdateCache()
		{
			return default(NHNFMGPJJAF);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NHNFMGPJJAF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EBJLNIKLDEG
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] FKJBEBEJNFP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C35180", Offset = "0x6C33D80", VA = "0x186C35180")]
	public static float2Rect CJBIBMEKDFK(Transform MPPJKDEKJAA, RectTransform CGJNNJHBPPG)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C35490", Offset = "0x6C34090", VA = "0x186C35490")]
	public static void ODFDHGIDFGK(Vector3[] IBMBCKLAPIE, [Out] float2 FDBDHJDBKGA, [Out] float2 CAIIHNDCIIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EEDGGNLPDPE
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] COCOOFDIIID;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C355C0", Offset = "0x6C341C0", VA = "0x186C355C0")]
	public static void KPFJBGIOGHG([In] int ICPPPNGPILH, [Out] ushort KDAIHBAAFBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ACCLADKLLKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FDHBICGEBKH
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
	[Cpp2IlInjected.Address(RVA = "0x6C34840", Offset = "0x6C33440", VA = "0x186C34840")]
	public static void FHMMCEHIGBL(float3[] DJIMCLKIICJ, [In] float2 HLEIEHPNFMB, [In] float2 CBKMEBCGCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C33940", Offset = "0x6C32540", VA = "0x186C33940")]
	public static void AJPHLKCFDKB(float2[] LONJNCPJPOG, [In] float2 JCBIAOOBMOK, [In] float2 AECNFHLIJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C34FD0", Offset = "0x6C33BD0", VA = "0x186C34FD0")]
	public static void NDFEPNJMDMB(float3[] DJIMCLKIICJ, [In] float CEOBFHNEBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C349D0", Offset = "0x6C335D0", VA = "0x186C349D0")]
	public static void GOFKMOLOELB(QuadVertex[] GMEKHLIPNOG, [In] int KDAIHBAAFBP, [In] float3[] PHCOCAHDJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C348C0", Offset = "0x6C334C0", VA = "0x186C348C0")]
	public static void FKHFENEHOFK(QuadVertex[] GMEKHLIPNOG, int KDAIHBAAFBP, [In] float3[] PHCOCAHDJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C34ED0", Offset = "0x6C33AD0", VA = "0x186C34ED0")]
	public static void MHEHEALCPFJ(QuadVertex[] GMEKHLIPNOG, [In] int KDAIHBAAFBP, [In] Color32 BPPNDMCGBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C34AE0", Offset = "0x6C336E0", VA = "0x186C34AE0")]
	public static void IBINDHIFELP(QuadVertex[] GMEKHLIPNOG, int KDAIHBAAFBP, [In] Color32 BPPNDMCGBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C34070", Offset = "0x6C32C70", VA = "0x186C34070")]
	public static void CKGEHOGMGFL(QuadVertex[] GMEKHLIPNOG, [In] int KDAIHBAAFBP, [In] float2[] KAEGLEBCHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C33C10", Offset = "0x6C32810", VA = "0x186C33C10")]
	public static void BIBJDAGBIEG(QuadVertex[] GMEKHLIPNOG, int KDAIHBAAFBP, [In] float2[] KAEGLEBCHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C33A90", Offset = "0x6C32690", VA = "0x186C33A90")]
	public static void BEGADGCCOCC(QuadVertex[] GMEKHLIPNOG, int KDAIHBAAFBP, [In] float3[] PHCOCAHDJKE, [In] Color32 BPPNDMCGBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C34620", Offset = "0x6C33220", VA = "0x186C34620")]
	public static void FHGCIFIMJMA(QuadVertex[] GMEKHLIPNOG, int KDAIHBAAFBP, [In] float3[] PHCOCAHDJKE, [In] float2[] KAEGLEBCHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C34180", Offset = "0x6C32D80", VA = "0x186C34180")]
	public static void EMAHFBHPNAB(QuadVertex[] GMEKHLIPNOG, int KDAIHBAAFBP, [In] Color32 BPPNDMCGBLJ, [In] float2[] KAEGLEBCHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C34390", Offset = "0x6C32F90", VA = "0x186C34390")]
	public static void EPLHPGPMEJG(QuadVertex[] GMEKHLIPNOG, int KDAIHBAAFBP, [In] float3[] PHCOCAHDJKE, [In] Color32 BPPNDMCGBLJ, [In] float2[] KAEGLEBCHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C34B60", Offset = "0x6C33760", VA = "0x186C34B60")]
	public static void IHOFIPNPHFC(ushort[] OCNBKFMGOEB, int ICPPPNGPILH, [In] int AFDAJMBCHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C33D20", Offset = "0x6C32920", VA = "0x186C33D20")]
	public static void CCCIDLDNKLB(ushort[] OCNBKFMGOEB, int ICPPPNGPILH, [In] int AFDAJMBCHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C34300", Offset = "0x6C32F00", VA = "0x186C34300")]
	public static void EMNBOFJEPHP(ushort[] OCNBKFMGOEB, [In] int ICPPPNGPILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C339D0", Offset = "0x6C325D0", VA = "0x186C339D0")]
	public static void AKBIPCBGLKG(ushort[] OCNBKFMGOEB, [In] int ICPPPNGPILH, [In] int KDAIHBAAFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C34C90", Offset = "0x6C33890", VA = "0x186C34C90")]
	public static Bounds LDLPEGOMNBO([In] QuadVertex[] GMEKHLIPNOG, [In] ushort[] OCNBKFMGOEB, [In] int JMIMHGGCKGF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C33D60", Offset = "0x6C32960", VA = "0x186C33D60")]
	public static Bounds CKFLJPNCNOA([In] QuadVertex[] GMEKHLIPNOG, [In] ushort[] OCNBKFMGOEB, [In] int JMIMHGGCKGF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C34F50", Offset = "0x6C33B50", VA = "0x186C34F50")]
	[CompilerGenerated]
	internal static void MOMKNKPDGOG([In] float3 GAECIBGPFJF, FDHBICGEBKH P_1)
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
