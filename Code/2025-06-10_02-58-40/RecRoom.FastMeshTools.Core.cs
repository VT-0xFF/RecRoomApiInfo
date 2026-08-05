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
public static class IDBFLCJHEGD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BD80", Offset = "0x7C3AF80", VA = "0x187C3BD80")]
	public static float2 AHFNDKJCJLJ(this KLBMBDKIGOO BINICJBFMOC)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KLBMBDKIGOO : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2F71020", Offset = "0x2F70220", VA = "0x182F71020")]
		public float2Rect(float2 FICCENLPJEL, float2 GCFCAGDGDIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E860", Offset = "0x7C3DA60", VA = "0x187C3E860")]
		public void PCEFEHILDBC([Out] float2 IFCDIDCJFNG, [Out] float2 FFMLLFHIDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E830", Offset = "0x7C3DA30", VA = "0x187C3E830")]
		public float2 HJOJCBAHHNM(float2 MNADADOOCED)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E600", Offset = "0x7C3D800", VA = "0x187C3E600", Slot = "4")]
		public bool Equals(float2Rect CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E680", Offset = "0x7C3D880", VA = "0x187C3E680", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E780", Offset = "0x7C3D980", VA = "0x187C3E780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E880", Offset = "0x7C3DA80", VA = "0x187C3E880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EAA0", Offset = "0x7C3DCA0", VA = "0x187C3EAA0", Slot = "5")]
		public string ToString(string LHADPGCGDPB, IFormatProvider FBKDJMLIGDE)
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
		[Cpp2IlInjected.Address(RVA = "0x7C3EEF0", Offset = "0x7C3E0F0", VA = "0x187C3EEF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EE60", Offset = "0x7C3E060", VA = "0x187C3EE60", Slot = "6")]
		public string ToString(string LHADPGCGDPB, IFormatProvider FBKDJMLIGDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C3ECC0", Offset = "0x7C3DEC0", VA = "0x187C3ECC0", Slot = "4")]
		public bool Equals(floatMinMax CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EDB0", Offset = "0x7C3DFB0", VA = "0x187C3EDB0", Slot = "5")]
		public bool Equals(float2 CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C3ED00", Offset = "0x7C3DF00", VA = "0x187C3ED00", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EDE0", Offset = "0x7C3DFE0", VA = "0x187C3EDE0", Slot = "2")]
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
		private LGCNBHBIJML cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E220", Offset = "0x7C3D420", VA = "0x187C3E220")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E370", Offset = "0x7C3D570", VA = "0x187C3E370")]
		public LayoutRect(LayoutRect parent, KLBMBDKIGOO parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DCE0", Offset = "0x7C3CEE0", VA = "0x187C3DCE0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DC40", Offset = "0x7C3CE40", VA = "0x187C3DC40")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DCB0", Offset = "0x7C3CEB0", VA = "0x187C3DCB0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DC50", Offset = "0x7C3CE50", VA = "0x187C3DC50")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DDF0", Offset = "0x7C3CFF0", VA = "0x187C3DDF0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BE80", Offset = "0x7C3B080", VA = "0x187C3BE80")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DEF0", Offset = "0x7C3D0F0", VA = "0x187C3DEF0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DEA0", Offset = "0x7C3D0A0", VA = "0x187C3DEA0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DE50", Offset = "0x7C3D050", VA = "0x187C3DE50")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DFA0", Offset = "0x7C3D1A0", VA = "0x187C3DFA0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DF50", Offset = "0x7C3D150", VA = "0x187C3DF50")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DF00", Offset = "0x7C3D100", VA = "0x187C3DF00")]
		public void SetParentAlignment(KLBMBDKIGOO rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DD00", Offset = "0x7C3CF00", VA = "0x187C3DD00")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DD60", Offset = "0x7C3CF60", VA = "0x187C3DD60")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DCF0", Offset = "0x7C3CEF0", VA = "0x187C3DCF0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E050", Offset = "0x7C3D250", VA = "0x187C3E050")]
		private LGCNBHBIJML UpdateCache()
		{
			return default(LGCNBHBIJML);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LGCNBHBIJML : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class KIFOGLJLKIN
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] FGMBAEALFPA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D800", Offset = "0x7C3CA00", VA = "0x187C3D800")]
	public static float2Rect JKPHLAPCDPD(Transform IDPDNNMFPBD, RectTransform LBPEJPMBIKP)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DB10", Offset = "0x7C3CD10", VA = "0x187C3DB10")]
	public static void KAOJDFCHGAN(Vector3[] PPNPBDKONBP, [Out] float2 FHHDCGHGHIP, [Out] float2 AFOBMPBBEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MGCHHJLPMHL
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] GDIDIKCONGP;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E4C0", Offset = "0x7C3D6C0", VA = "0x187C3E4C0")]
	public static void EEBHFBNJMMI([In] int OFCIOFKOGEB, [Out] ushort EJAMJPFJFGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ILGPDPADDIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FIFPHPAICDA
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
	[Cpp2IlInjected.Address(RVA = "0x7C3C100", Offset = "0x7C3B300", VA = "0x187C3C100")]
	public static void AJGHJANENPB(float3[] ELODPGPGPGI, [In] float2 ACBPIFIEFOL, [In] float2 FFMLLFHIDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CA50", Offset = "0x7C3BC50", VA = "0x187C3CA50")]
	public static void GADAFNGKNGO(float2[] LGFDELHCDDN, [In] float2 AGFINEJHIPK, [In] float2 EKOOKMAMENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CFA0", Offset = "0x7C3C1A0", VA = "0x187C3CFA0")]
	public static void KLJBNAFBJPP(float3[] ELODPGPGPGI, [In] float JHLJLFKJAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C940", Offset = "0x7C3BB40", VA = "0x187C3C940")]
	public static void ENHMCFIAPHH(QuadVertex[] LDIEJBLHKPD, [In] int EJAMJPFJFGO, [In] float3[] LPLHCIAAKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C5A0", Offset = "0x7C3B7A0", VA = "0x187C3C5A0")]
	public static void CJKLKKDMGEB(QuadVertex[] LDIEJBLHKPD, int EJAMJPFJFGO, [In] float3[] LPLHCIAAKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D780", Offset = "0x7C3C980", VA = "0x187C3D780")]
	public static void PMGICLBNAOG(QuadVertex[] LDIEJBLHKPD, [In] int EJAMJPFJFGO, [In] Color32 DAMMNMIKBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D4C0", Offset = "0x7C3C6C0", VA = "0x187C3D4C0")]
	public static void MHFLFFIIKDO(QuadVertex[] LDIEJBLHKPD, int EJAMJPFJFGO, [In] Color32 DAMMNMIKBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CE50", Offset = "0x7C3C050", VA = "0x187C3CE50")]
	public static void JELHFLCENGG(QuadVertex[] LDIEJBLHKPD, [In] int EJAMJPFJFGO, [In] float2[] HIJKEMNADFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C830", Offset = "0x7C3BA30", VA = "0x187C3C830")]
	public static void DDCJIEJDBFF(QuadVertex[] LDIEJBLHKPD, int EJAMJPFJFGO, [In] float2[] HIJKEMNADFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C6B0", Offset = "0x7C3B8B0", VA = "0x187C3C6B0")]
	public static void DALCKDDCEJI(QuadVertex[] LDIEJBLHKPD, int EJAMJPFJFGO, [In] float3[] LPLHCIAAKEG, [In] Color32 DAMMNMIKBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D010", Offset = "0x7C3C210", VA = "0x187C3D010")]
	public static void MBFCIIFFBEF(QuadVertex[] LDIEJBLHKPD, int EJAMJPFJFGO, [In] float3[] LPLHCIAAKEG, [In] float2[] HIJKEMNADFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CCD0", Offset = "0x7C3BED0", VA = "0x187C3CCD0")]
	public static void HCGCMICLLFK(QuadVertex[] LDIEJBLHKPD, int EJAMJPFJFGO, [In] Color32 DAMMNMIKBIB, [In] float2[] HIJKEMNADFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D230", Offset = "0x7C3C430", VA = "0x187C3D230")]
	public static void MHCHKACIPFH(QuadVertex[] LDIEJBLHKPD, int EJAMJPFJFGO, [In] float3[] LPLHCIAAKEG, [In] Color32 DAMMNMIKBIB, [In] float2[] HIJKEMNADFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CAE0", Offset = "0x7C3BCE0", VA = "0x187C3CAE0")]
	public static void GKEFDLNKMNJ(ushort[] EDJJOJNLFAI, int OFCIOFKOGEB, [In] int HKFEHFFDNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CF60", Offset = "0x7C3C160", VA = "0x187C3CF60")]
	public static void KBEPOJOFCOK(ushort[] EDJJOJNLFAI, int OFCIOFKOGEB, [In] int HKFEHFFDNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C510", Offset = "0x7C3B710", VA = "0x187C3C510")]
	public static void BDCAJIKOJJO(ushort[] EDJJOJNLFAI, [In] int OFCIOFKOGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CC10", Offset = "0x7C3BE10", VA = "0x187C3CC10")]
	public static void GMLFOBKDBGH(ushort[] EDJJOJNLFAI, [In] int OFCIOFKOGEB, [In] int EJAMJPFJFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D540", Offset = "0x7C3C740", VA = "0x187C3D540")]
	public static Bounds OOKBAKFPLMG([In] QuadVertex[] LDIEJBLHKPD, [In] ushort[] EDJJOJNLFAI, [In] int OIGFODMFHFF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C180", Offset = "0x7C3B380", VA = "0x187C3C180")]
	public static Bounds AOGLBMPGHHA([In] QuadVertex[] LDIEJBLHKPD, [In] ushort[] EDJJOJNLFAI, [In] int OIGFODMFHFF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C490", Offset = "0x7C3B690", VA = "0x187C3C490")]
	[CompilerGenerated]
	internal static void BBBEJGNOOJI([In] float3 AGIIBANJIMH, FIFPHPAICDA P_1)
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
