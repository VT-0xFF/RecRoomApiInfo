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
public static class FOLAPNEGCGC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F90900", Offset = "0x7F8EF00", VA = "0x187F90900")]
	public static float2 PKNNOEKOOHF(this MJIOCKCHAMP EJFJEBNJCMH)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MJIOCKCHAMP : byte
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
		[Cpp2IlInjected.Address(RVA = "0x30811E0", Offset = "0x307F7E0", VA = "0x1830811E0")]
		public float2Rect(float2 NHLFNDFGAHK, float2 GPNBMIDFKMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F93350", Offset = "0x7F91950", VA = "0x187F93350")]
		public void GMJJAGOJIKC([Out] float2 PHMHLEDPALE, [Out] float2 BLGIAOLKDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F93320", Offset = "0x7F91920", VA = "0x187F93320")]
		public float2 GBKFLDFLBBH(float2 GHHMMIKHDFL)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F931A0", Offset = "0x7F917A0", VA = "0x187F931A0", Slot = "4")]
		public bool Equals(float2Rect HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F93220", Offset = "0x7F91820", VA = "0x187F93220", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F93370", Offset = "0x7F91970", VA = "0x187F93370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F93420", Offset = "0x7F91A20", VA = "0x187F93420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F93640", Offset = "0x7F91C40", VA = "0x187F93640", Slot = "5")]
		public string ToString(string MCLEKLAABMK, IFormatProvider OMMCDLFFHEA)
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
		[Cpp2IlInjected.Address(RVA = "0x7F93A80", Offset = "0x7F92080", VA = "0x187F93A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F939F0", Offset = "0x7F91FF0", VA = "0x187F939F0", Slot = "6")]
		public string ToString(string MCLEKLAABMK, IFormatProvider OMMCDLFFHEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F93850", Offset = "0x7F91E50", VA = "0x187F93850", Slot = "4")]
		public bool Equals(floatMinMax HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F93940", Offset = "0x7F91F40", VA = "0x187F93940", Slot = "5")]
		public bool Equals(float2 HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F93890", Offset = "0x7F91E90", VA = "0x187F93890", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F93970", Offset = "0x7F91F70", VA = "0x187F93970", Slot = "2")]
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
		private CLDGFPCNIHL cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F92960", Offset = "0x7F90F60", VA = "0x187F92960")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F92AB0", Offset = "0x7F910B0", VA = "0x187F92AB0")]
		public LayoutRect(LayoutRect parent, MJIOCKCHAMP parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F92420", Offset = "0x7F90A20", VA = "0x187F92420")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F92380", Offset = "0x7F90980", VA = "0x187F92380")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7F923F0", Offset = "0x7F909F0", VA = "0x187F923F0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F92390", Offset = "0x7F90990", VA = "0x187F92390")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F92530", Offset = "0x7F90B30", VA = "0x187F92530")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F90A00", Offset = "0x7F8F000", VA = "0x187F90A00")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F92630", Offset = "0x7F90C30", VA = "0x187F92630")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F925E0", Offset = "0x7F90BE0", VA = "0x187F925E0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F92590", Offset = "0x7F90B90", VA = "0x187F92590")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F926E0", Offset = "0x7F90CE0", VA = "0x187F926E0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F92690", Offset = "0x7F90C90", VA = "0x187F92690")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F92640", Offset = "0x7F90C40", VA = "0x187F92640")]
		public void SetParentAlignment(MJIOCKCHAMP rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F92440", Offset = "0x7F90A40", VA = "0x187F92440")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F924A0", Offset = "0x7F90AA0", VA = "0x187F924A0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F92430", Offset = "0x7F90A30", VA = "0x187F92430")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F92790", Offset = "0x7F90D90", VA = "0x187F92790")]
		private CLDGFPCNIHL UpdateCache()
		{
			return default(CLDGFPCNIHL);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CLDGFPCNIHL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PHNJIGELFBD
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] DHMODEJFDOI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F92E10", Offset = "0x7F91410", VA = "0x187F92E10")]
	public static float2Rect PFLCAELDEJN(Transform HJMEACPNJDF, RectTransform OKOGHNMMGGB)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D50", Offset = "0x7F91350", VA = "0x187F92D50")]
	public static void OJKMLEMMMPD(Vector3[] MAABDMEABJE, [Out] float2 LPAMMAPPJAO, [Out] float2 CMGDLKAFPEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OBKBDNLMEGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] BGFJLIPHOPG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F92C00", Offset = "0x7F91200", VA = "0x187F92C00")]
	public static void EABEBAEGBME([In] int KDHMBLHPIPA, [Out] ushort GGJHFIDFLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GDBAAAHJMNA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AAONEIGHDMN
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
	[Cpp2IlInjected.Address(RVA = "0x7F91F20", Offset = "0x7F90520", VA = "0x187F91F20")]
	public static void MPIDKBMIADA(float3[] IGOIDHPNIBA, [In] float2 PCMAGPLNBKG, [In] float2 BLGIAOLKDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F920D0", Offset = "0x7F906D0", VA = "0x187F920D0")]
	public static void NONJPNOENCE(float2[] PFOJLLELOFF, [In] float2 AEOKEGOPDOL, [In] float2 CPDEMLAHGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F91A80", Offset = "0x7F90080", VA = "0x187F91A80")]
	public static void KJNJKKMBBFL(float3[] IGOIDHPNIBA, [In] float DKNIGPLOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F92160", Offset = "0x7F90760", VA = "0x187F92160")]
	public static void NPMFIIPCMAK(QuadVertex[] ECODDHEEFOM, [In] int GGJHFIDFLMH, [In] float3[] PJLPCPGFCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F91B70", Offset = "0x7F90170", VA = "0x187F91B70")]
	public static void LGNNFLGGJBH(QuadVertex[] ECODDHEEFOM, int GGJHFIDFLMH, [In] float3[] PJLPCPGFCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F91050", Offset = "0x7F8F650", VA = "0x187F91050")]
	public static void GLMJLGDALPK(QuadVertex[] ECODDHEEFOM, [In] int GGJHFIDFLMH, [In] Color32 AGCKBAFIGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F91AF0", Offset = "0x7F900F0", VA = "0x187F91AF0")]
	public static void LABLPCBMMAF(QuadVertex[] ECODDHEEFOM, int GGJHFIDFLMH, [In] Color32 AGCKBAFIGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F91970", Offset = "0x7F8FF70", VA = "0x187F91970")]
	public static void KCAJJGNEIOB(QuadVertex[] ECODDHEEFOM, [In] int GGJHFIDFLMH, [In] float2[] KBAIMLEGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F92270", Offset = "0x7F90870", VA = "0x187F92270")]
	public static void ODBJFPOGKDB(QuadVertex[] ECODDHEEFOM, int GGJHFIDFLMH, [In] float2[] KBAIMLEGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F91250", Offset = "0x7F8F850", VA = "0x187F91250")]
	public static void IAJGCNBNEAD(QuadVertex[] ECODDHEEFOM, int GGJHFIDFLMH, [In] float3[] PJLPCPGFCPF, [In] Color32 AGCKBAFIGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F91D00", Offset = "0x7F90300", VA = "0x187F91D00")]
	public static void MLMMDJIBGPI(QuadVertex[] ECODDHEEFOM, int GGJHFIDFLMH, [In] float3[] PJLPCPGFCPF, [In] float2[] KBAIMLEGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F910D0", Offset = "0x7F8F6D0", VA = "0x187F910D0")]
	public static void HAHOGPNPIFM(QuadVertex[] ECODDHEEFOM, int GGJHFIDFLMH, [In] Color32 AGCKBAFIGEB, [In] float2[] KBAIMLEGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F916E0", Offset = "0x7F8FCE0", VA = "0x187F916E0")]
	public static void JKJIMCFEEBP(QuadVertex[] ECODDHEEFOM, int GGJHFIDFLMH, [In] float3[] PJLPCPGFCPF, [In] Color32 AGCKBAFIGEB, [In] float2[] KBAIMLEGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F91FA0", Offset = "0x7F905A0", VA = "0x187F91FA0")]
	public static void NKFJMBFAKHC(ushort[] FJICBKCLHKB, int KDHMBLHPIPA, [In] int PEFCBKFFKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F90F80", Offset = "0x7F8F580", VA = "0x187F90F80")]
	public static void FEKONMAOCIJ(ushort[] FJICBKCLHKB, int KDHMBLHPIPA, [In] int PEFCBKFFKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F90FC0", Offset = "0x7F8F5C0", VA = "0x187F90FC0")]
	public static void GBAJIFBNCGC(ushort[] FJICBKCLHKB, [In] int KDHMBLHPIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F90C80", Offset = "0x7F8F280", VA = "0x187F90C80")]
	public static void ALJIHKIOEHM(ushort[] FJICBKCLHKB, [In] int KDHMBLHPIPA, [In] int GGJHFIDFLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7F90D40", Offset = "0x7F8F340", VA = "0x187F90D40")]
	public static Bounds BEOELIGLOHK([In] QuadVertex[] ECODDHEEFOM, [In] ushort[] FJICBKCLHKB, [In] int DJMFJMKKGHO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F913D0", Offset = "0x7F8F9D0", VA = "0x187F913D0")]
	public static Bounds IBEDKHLNDMH([In] QuadVertex[] ECODDHEEFOM, [In] ushort[] FJICBKCLHKB, [In] int DJMFJMKKGHO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F91C80", Offset = "0x7F90280", VA = "0x187F91C80")]
	[CompilerGenerated]
	internal static void MDILOJJAINJ([In] float3 CMGKLEEINPK, AAONEIGHDMN P_1)
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
