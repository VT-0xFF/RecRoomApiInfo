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
public static class BJJLBOPBHEF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FE16F0", Offset = "0x6FE0AF0", VA = "0x186FE16F0")]
	public static float2 GLNHHOAIBIE(this MHDJMNCLACI DLPKKMJMFBI)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MHDJMNCLACI : byte
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
		[Cpp2IlInjected.Address(RVA = "0x295B110", Offset = "0x295A510", VA = "0x18295B110")]
		public float2Rect(float2 CPGMOBFHDAC, float2 BGDDCGNLDBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4160", Offset = "0x6FE3560", VA = "0x186FE4160")]
		public void MIAIEJBCOBI([Out] float2 LHAIBEKBKDN, [Out] float2 CCCBCIKEAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4130", Offset = "0x6FE3530", VA = "0x186FE4130")]
		public float2 IAPONIIMFNI(float2 ANOEMEHKDNP)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3F00", Offset = "0x6FE3300", VA = "0x186FE3F00", Slot = "4")]
		public bool Equals(float2Rect BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3F80", Offset = "0x6FE3380", VA = "0x186FE3F80", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4080", Offset = "0x6FE3480", VA = "0x186FE4080", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4180", Offset = "0x6FE3580", VA = "0x186FE4180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FE43A0", Offset = "0x6FE37A0", VA = "0x186FE43A0", Slot = "5")]
		public string ToString(string LAKAMCGCHJB, IFormatProvider IENKDCKGHDF)
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
		[Cpp2IlInjected.Address(RVA = "0x6FE47E0", Offset = "0x6FE3BE0", VA = "0x186FE47E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4750", Offset = "0x6FE3B50", VA = "0x186FE4750", Slot = "6")]
		public string ToString(string LAKAMCGCHJB, IFormatProvider IENKDCKGHDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE45B0", Offset = "0x6FE39B0", VA = "0x186FE45B0", Slot = "4")]
		public bool Equals(floatMinMax BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE46A0", Offset = "0x6FE3AA0", VA = "0x186FE46A0", Slot = "5")]
		public bool Equals(float2 BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE45F0", Offset = "0x6FE39F0", VA = "0x186FE45F0", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FE46D0", Offset = "0x6FE3AD0", VA = "0x186FE46D0", Slot = "2")]
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
		private GGLADJJNIJJ cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3C80", Offset = "0x6FE3080", VA = "0x186FE3C80")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3B30", Offset = "0x6FE2F30", VA = "0x186FE3B30")]
		public LayoutRect(LayoutRect parent, MHDJMNCLACI parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3640", Offset = "0x6FE2A40", VA = "0x186FE3640")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FE35A0", Offset = "0x6FE29A0", VA = "0x186FE35A0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3610", Offset = "0x6FE2A10", VA = "0x186FE3610")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FE35B0", Offset = "0x6FE29B0", VA = "0x186FE35B0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3750", Offset = "0x6FE2B50", VA = "0x186FE3750")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FE17F0", Offset = "0x6FE0BF0", VA = "0x186FE17F0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3800", Offset = "0x6FE2C00", VA = "0x186FE3800")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE37C0", Offset = "0x6FE2BC0", VA = "0x186FE37C0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3780", Offset = "0x6FE2B80", VA = "0x186FE3780")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE38B0", Offset = "0x6FE2CB0", VA = "0x186FE38B0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3870", Offset = "0x6FE2C70", VA = "0x186FE3870")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3810", Offset = "0x6FE2C10", VA = "0x186FE3810")]
		public void SetParentAlignment(MHDJMNCLACI rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3660", Offset = "0x6FE2A60", VA = "0x186FE3660")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FE36C0", Offset = "0x6FE2AC0", VA = "0x186FE36C0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3650", Offset = "0x6FE2A50", VA = "0x186FE3650")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3960", Offset = "0x6FE2D60", VA = "0x186FE3960")]
		private GGLADJJNIJJ UpdateCache()
		{
			return default(GGLADJJNIJJ);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum GGLADJJNIJJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BOBBIHEMJGC
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] GBAKMMKFIHL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6FE30E0", Offset = "0x6FE24E0", VA = "0x186FE30E0")]
	public static float2Rect EFKKPKNHHGI(Transform LKGMNBOIBJA, RectTransform MGPMAFDHMLC)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3020", Offset = "0x6FE2420", VA = "0x186FE3020")]
	public static void AJOOJNJJMNI(Vector3[] FHFDCNJJKPA, [Out] float2 OHMCJFFPFMB, [Out] float2 CDDAELCNAGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NHGOINNILHB
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] DFJKIGFOMLI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3DC0", Offset = "0x6FE31C0", VA = "0x186FE3DC0")]
	public static void OEGCCNBNMEO([In] int MEFGKNMJBDJ, [Out] ushort CPNDGLONMAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BEAFEGIMNIK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IGAAHMJJCJF
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
	[Cpp2IlInjected.Address(RVA = "0x6FE1920", Offset = "0x6FE0D20", VA = "0x186FE1920")]
	public static void BBJENADBDCH(float3[] IOGNMGAMFCB, [In] float2 EHBIBKPPJAA, [In] float2 CCCBCIKEAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2F90", Offset = "0x6FE2390", VA = "0x186FE2F90")]
	public static void PPHCMBLLFLI(float2[] BFOPHFPMPFB, [In] float2 AJFGJLGLHIL, [In] float2 NIJNHGMJMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2600", Offset = "0x6FE1A00", VA = "0x186FE2600")]
	public static void KGJBAOBPEEO(float3[] IOGNMGAMFCB, [In] float NAENNCFACAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2670", Offset = "0x6FE1A70", VA = "0x186FE2670")]
	public static void KHBBGPHEKAO(QuadVertex[] MMIMMJHIFEO, [In] int CPNDGLONMAN, [In] float3[] FNLDJGJHHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1C30", Offset = "0x6FE1030", VA = "0x186FE1C30")]
	public static void CMDIKLLBEMH(QuadVertex[] MMIMMJHIFEO, int CPNDGLONMAN, [In] float3[] FNLDJGJHHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2D90", Offset = "0x6FE2190", VA = "0x186FE2D90")]
	public static void NPGCGIHHIHL(QuadVertex[] MMIMMJHIFEO, [In] int CPNDGLONMAN, [In] Color32 BLAOJGFDJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2E10", Offset = "0x6FE2210", VA = "0x186FE2E10")]
	public static void OFFCLIJOALN(QuadVertex[] MMIMMJHIFEO, int CPNDGLONMAN, [In] Color32 BLAOJGFDJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE22B0", Offset = "0x6FE16B0", VA = "0x186FE22B0")]
	public static void JDOLEGCGDPJ(QuadVertex[] MMIMMJHIFEO, [In] int CPNDGLONMAN, [In] float2[] POHDKHENFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2070", Offset = "0x6FE1470", VA = "0x186FE2070")]
	public static void IAEGNNFPHDB(QuadVertex[] MMIMMJHIFEO, int CPNDGLONMAN, [In] float2[] POHDKHENFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2A90", Offset = "0x6FE1E90", VA = "0x186FE2A90")]
	public static void LECIODHHALF(QuadVertex[] MMIMMJHIFEO, int CPNDGLONMAN, [In] float3[] FNLDJGJHHFF, [In] Color32 BLAOJGFDJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1D40", Offset = "0x6FE1140", VA = "0x186FE1D40")]
	public static void CPNMMJANCEC(QuadVertex[] MMIMMJHIFEO, int CPNDGLONMAN, [In] float3[] FNLDJGJHHFF, [In] float2[] POHDKHENFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2C10", Offset = "0x6FE2010", VA = "0x186FE2C10")]
	public static void LKACGHOMCEO(QuadVertex[] MMIMMJHIFEO, int CPNDGLONMAN, [In] Color32 BLAOJGFDJMH, [In] float2[] POHDKHENFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6FE19A0", Offset = "0x6FE0DA0", VA = "0x186FE19A0")]
	public static void BNOPNFNKILJ(QuadVertex[] MMIMMJHIFEO, int CPNDGLONMAN, [In] float3[] FNLDJGJHHFF, [In] Color32 BLAOJGFDJMH, [In] float2[] POHDKHENFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2180", Offset = "0x6FE1580", VA = "0x186FE2180")]
	public static void JBGDNKDBKHD(ushort[] NCFBNPHIBJE, int MEFGKNMJBDJ, [In] int JENJICNNHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2F50", Offset = "0x6FE2350", VA = "0x186FE2F50")]
	public static void OOMCADPAEDO(ushort[] NCFBNPHIBJE, int MEFGKNMJBDJ, [In] int JENJICNNHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1FE0", Offset = "0x6FE13E0", VA = "0x186FE1FE0")]
	public static void FCDFPMNGBLE(ushort[] NCFBNPHIBJE, [In] int MEFGKNMJBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2E90", Offset = "0x6FE2290", VA = "0x186FE2E90")]
	public static void OLNIFFMMKHD(ushort[] NCFBNPHIBJE, [In] int MEFGKNMJBDJ, [In] int CPNDGLONMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6FE23C0", Offset = "0x6FE17C0", VA = "0x186FE23C0")]
	public static Bounds JPPMKDINDCB([In] QuadVertex[] MMIMMJHIFEO, [In] ushort[] NCFBNPHIBJE, [In] int PHMBNNDCGGC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2780", Offset = "0x6FE1B80", VA = "0x186FE2780")]
	public static Bounds LCPAPDDMIHD([In] QuadVertex[] MMIMMJHIFEO, [In] ushort[] NCFBNPHIBJE, [In] int PHMBNNDCGGC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1F60", Offset = "0x6FE1360", VA = "0x186FE1F60")]
	[CompilerGenerated]
	internal static void DGFMCNBFBIF([In] float3 AHHPGJOEACI, IGAAHMJJCJF P_1)
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
