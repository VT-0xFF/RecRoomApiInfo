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
public static class HEHMFKADKNM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80E3810", Offset = "0x80E2410", VA = "0x1880E3810")]
	public static float2 FFBMFICFEBD(this PBNFKBEPDIE DGFEGDEBGDP)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PBNFKBEPDIE : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2FAD810", Offset = "0x2FAC410", VA = "0x182FAD810")]
		public float2Rect(float2 FEMJLOIOGIK, float2 PFHGPMHBODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80E60B0", Offset = "0x80E4CB0", VA = "0x1880E60B0")]
		public void AEDAIPFNKDM([Out] float2 EHIHAEJJDAJ, [Out] float2 KGJPOLDJGJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80E6300", Offset = "0x80E4F00", VA = "0x1880E6300")]
		public float2 NIBGMGCFJLG(float2 AMFKKPKELCC)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80E60D0", Offset = "0x80E4CD0", VA = "0x1880E60D0", Slot = "4")]
		public bool Equals(float2Rect IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80E6150", Offset = "0x80E4D50", VA = "0x1880E6150", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80E6250", Offset = "0x80E4E50", VA = "0x1880E6250", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80E6330", Offset = "0x80E4F30", VA = "0x1880E6330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80E6550", Offset = "0x80E5150", VA = "0x1880E6550", Slot = "5")]
		public string ToString(string DNHJAJKHKHI, IFormatProvider DELLHMMJLCI)
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
		[Cpp2IlInjected.Address(RVA = "0x80E69A0", Offset = "0x80E55A0", VA = "0x1880E69A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80E6910", Offset = "0x80E5510", VA = "0x1880E6910", Slot = "6")]
		public string ToString(string DNHJAJKHKHI, IFormatProvider DELLHMMJLCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80E6770", Offset = "0x80E5370", VA = "0x1880E6770", Slot = "4")]
		public bool Equals(floatMinMax IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80E6860", Offset = "0x80E5460", VA = "0x1880E6860", Slot = "5")]
		public bool Equals(float2 IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80E67B0", Offset = "0x80E53B0", VA = "0x1880E67B0", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80E6890", Offset = "0x80E5490", VA = "0x1880E6890", Slot = "2")]
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
		private ACILBMHJJDD cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80E5F60", Offset = "0x80E4B60", VA = "0x1880E5F60")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80E5E10", Offset = "0x80E4A10", VA = "0x1880E5E10")]
		public LayoutRect(LayoutRect parent, PBNFKBEPDIE parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80E58D0", Offset = "0x80E44D0", VA = "0x1880E58D0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80E5830", Offset = "0x80E4430", VA = "0x1880E5830")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80E58A0", Offset = "0x80E44A0", VA = "0x1880E58A0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80E5840", Offset = "0x80E4440", VA = "0x1880E5840")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80E59E0", Offset = "0x80E45E0", VA = "0x1880E59E0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80E3910", Offset = "0x80E2510", VA = "0x1880E3910")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80E5AE0", Offset = "0x80E46E0", VA = "0x1880E5AE0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x80E5A90", Offset = "0x80E4690", VA = "0x1880E5A90")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80E5A40", Offset = "0x80E4640", VA = "0x1880E5A40")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80E5B90", Offset = "0x80E4790", VA = "0x1880E5B90")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80E5B40", Offset = "0x80E4740", VA = "0x1880E5B40")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80E5AF0", Offset = "0x80E46F0", VA = "0x1880E5AF0")]
		public void SetParentAlignment(PBNFKBEPDIE rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80E58F0", Offset = "0x80E44F0", VA = "0x1880E58F0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80E5950", Offset = "0x80E4550", VA = "0x1880E5950")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80E58E0", Offset = "0x80E44E0", VA = "0x1880E58E0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80E5C40", Offset = "0x80E4840", VA = "0x1880E5C40")]
		private ACILBMHJJDD UpdateCache()
		{
			return default(ACILBMHJJDD);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum ACILBMHJJDD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JJKOHAHADOM
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] FELBFMNFDOJ;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80E54A0", Offset = "0x80E40A0", VA = "0x1880E54A0")]
	public static float2Rect KBLNOPOOGGK(Transform DIILFLPMPJB, RectTransform ADGCHNLKFKK)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80E53E0", Offset = "0x80E3FE0", VA = "0x1880E53E0")]
	public static void ADDJBLHDIPC(Vector3[] AOOKPHPGLLG, [Out] float2 MPPPNIHIBJF, [Out] float2 ENBPGBPHHMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BKPBLPDKAAI
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] DAPKJLGHNDG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80E3A50", Offset = "0x80E2650", VA = "0x1880E3A50")]
	public static void ONJAFILAMOL([In] int ILMKAPMDEND, [Out] ushort KGKCDGMLIGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FNCOPHGGFLL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FEEFNIOLGAO
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
	[Cpp2IlInjected.Address(RVA = "0x80E5360", Offset = "0x80E3F60", VA = "0x1880E5360")]
	public static void OEFKLDIJHKF(float3[] HIDJBENBABI, [In] float2 GLBCFLPNMHI, [In] float2 KGJPOLDJGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x80E4430", Offset = "0x80E3030", VA = "0x1880E4430")]
	public static void EKGIHJMHEAA(float2[] OFDGIJPEADD, [In] float2 MFNFLKKHDKO, [In] float2 BCPFGLLJKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80E52F0", Offset = "0x80E3EF0", VA = "0x1880E52F0")]
	public static void OADPIPMPNMC(float3[] HIDJBENBABI, [In] float KJOPPCDJGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80E4320", Offset = "0x80E2F20", VA = "0x1880E4320")]
	public static void DHOGIAFCMMB(QuadVertex[] FAHKAMDEBIK, [In] int KGKCDGMLIGM, [In] float3[] BMPBBIIELLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80E3CE0", Offset = "0x80E28E0", VA = "0x1880E3CE0")]
	public static void ALOMGEHKJOG(QuadVertex[] FAHKAMDEBIK, int KGKCDGMLIGM, [In] float3[] BMPBBIIELLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80E4EE0", Offset = "0x80E3AE0", VA = "0x1880E4EE0")]
	public static void LALDFIGADEE(QuadVertex[] FAHKAMDEBIK, [In] int KGKCDGMLIGM, [In] Color32 FMEGCLPHKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80E4C00", Offset = "0x80E3800", VA = "0x1880E4C00")]
	public static void HDFEPEKEPKD(QuadVertex[] FAHKAMDEBIK, int KGKCDGMLIGM, [In] Color32 FMEGCLPHKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80E4DD0", Offset = "0x80E39D0", VA = "0x1880E4DD0")]
	public static void KBCNJODPCBC(QuadVertex[] FAHKAMDEBIK, [In] int KGKCDGMLIGM, [In] float2[] GCKHLANONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80E4CC0", Offset = "0x80E38C0", VA = "0x1880E4CC0")]
	public static void JDPPCHPHAHO(QuadVertex[] FAHKAMDEBIK, int KGKCDGMLIGM, [In] float2[] GCKHLANONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80E47D0", Offset = "0x80E33D0", VA = "0x1880E47D0")]
	public static void GBMJLAPGHCL(QuadVertex[] FAHKAMDEBIK, int KGKCDGMLIGM, [In] float3[] BMPBBIIELLB, [In] Color32 FMEGCLPHKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80E4080", Offset = "0x80E2C80", VA = "0x1880E4080")]
	public static void BMACBPBGECC(QuadVertex[] FAHKAMDEBIK, int KGKCDGMLIGM, [In] float3[] BMPBBIIELLB, [In] float2[] GCKHLANONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80E4A80", Offset = "0x80E3680", VA = "0x1880E4A80")]
	public static void HBNKKDGHLGC(QuadVertex[] FAHKAMDEBIK, int KGKCDGMLIGM, [In] Color32 FMEGCLPHKCI, [In] float2[] GCKHLANONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x80E3DF0", Offset = "0x80E29F0", VA = "0x1880E3DF0")]
	public static void BDGIHGGILEH(QuadVertex[] FAHKAMDEBIK, int KGKCDGMLIGM, [In] float3[] BMPBBIIELLB, [In] Color32 FMEGCLPHKCI, [In] float2[] GCKHLANONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x80E4950", Offset = "0x80E3550", VA = "0x1880E4950")]
	public static void HBNDBHBIIHK(ushort[] BLFIHGFFINF, int ILMKAPMDEND, [In] int BEHCBLDALJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x80E4C80", Offset = "0x80E3880", VA = "0x1880E4C80")]
	public static void HENJECKBJLF(ushort[] BLFIHGFFINF, int ILMKAPMDEND, [In] int BEHCBLDALJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x80E51A0", Offset = "0x80E3DA0", VA = "0x1880E51A0")]
	public static void LJJBKHMAMNB(ushort[] BLFIHGFFINF, [In] int ILMKAPMDEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80E5230", Offset = "0x80E3E30", VA = "0x1880E5230")]
	public static void MCGKNFMJMHH(ushort[] BLFIHGFFINF, [In] int ILMKAPMDEND, [In] int KGKCDGMLIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80E4F60", Offset = "0x80E3B60", VA = "0x1880E4F60")]
	public static Bounds LFMNGGDBCMN([In] QuadVertex[] FAHKAMDEBIK, [In] ushort[] BLFIHGFFINF, [In] int IANGEOMGABH)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80E44C0", Offset = "0x80E30C0", VA = "0x1880E44C0")]
	public static Bounds FNLPBDOEIFA([In] QuadVertex[] FAHKAMDEBIK, [In] ushort[] BLFIHGFFINF, [In] int IANGEOMGABH)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80E42A0", Offset = "0x80E2EA0", VA = "0x1880E42A0")]
	[CompilerGenerated]
	internal static void BNJBOCJBBGJ([In] float3 BOOEFKPMNJO, FEEFNIOLGAO P_1)
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
