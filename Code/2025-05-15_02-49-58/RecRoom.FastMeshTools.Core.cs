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
public static class KCCDNCBHLBL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C177E0", Offset = "0x7C15DE0", VA = "0x187C177E0")]
	public static float2 CDFECAELIHE(this FMDEEKEGJAL GMHMGPPAECM)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FMDEEKEGJAL : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2E17000", Offset = "0x2E15600", VA = "0x182E17000")]
		public float2Rect(float2 EPCLGOKLIPO, float2 CFNMLMNHCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A240", Offset = "0x7C18840", VA = "0x187C1A240")]
		public void BGDNOIMKKGE([Out] float2 BJAIKIJFJAB, [Out] float2 IAGMCHJPEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A260", Offset = "0x7C18860", VA = "0x187C1A260")]
		public float2 EMELLBPIHBJ(float2 INDJGMGIGJH)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A290", Offset = "0x7C18890", VA = "0x187C1A290", Slot = "4")]
		public bool Equals(float2Rect MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A310", Offset = "0x7C18910", VA = "0x187C1A310", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A410", Offset = "0x7C18A10", VA = "0x187C1A410", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A4C0", Offset = "0x7C18AC0", VA = "0x187C1A4C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A6E0", Offset = "0x7C18CE0", VA = "0x187C1A6E0", Slot = "5")]
		public string ToString(string CKHLMMECGLE, IFormatProvider AMMODFLNLEK)
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
		[Cpp2IlInjected.Address(RVA = "0x7C1AB20", Offset = "0x7C19120", VA = "0x187C1AB20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AA90", Offset = "0x7C19090", VA = "0x187C1AA90", Slot = "6")]
		public string ToString(string CKHLMMECGLE, IFormatProvider AMMODFLNLEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A8F0", Offset = "0x7C18EF0", VA = "0x187C1A8F0", Slot = "4")]
		public bool Equals(floatMinMax MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A9E0", Offset = "0x7C18FE0", VA = "0x187C1A9E0", Slot = "5")]
		public bool Equals(float2 MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A930", Offset = "0x7C18F30", VA = "0x187C1A930", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AA10", Offset = "0x7C19010", VA = "0x187C1AA10", Slot = "2")]
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
		private GKEIPMPHIEH cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C19B60", Offset = "0x7C18160", VA = "0x187C19B60")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C19CB0", Offset = "0x7C182B0", VA = "0x187C19CB0")]
		public LayoutRect(LayoutRect parent, FMDEEKEGJAL parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C19620", Offset = "0x7C17C20", VA = "0x187C19620")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C19580", Offset = "0x7C17B80", VA = "0x187C19580")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C195F0", Offset = "0x7C17BF0", VA = "0x187C195F0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C19590", Offset = "0x7C17B90", VA = "0x187C19590")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C19730", Offset = "0x7C17D30", VA = "0x187C19730")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C178E0", Offset = "0x7C15EE0", VA = "0x187C178E0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C19830", Offset = "0x7C17E30", VA = "0x187C19830")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C197E0", Offset = "0x7C17DE0", VA = "0x187C197E0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C19790", Offset = "0x7C17D90", VA = "0x187C19790")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C198E0", Offset = "0x7C17EE0", VA = "0x187C198E0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C19890", Offset = "0x7C17E90", VA = "0x187C19890")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C19840", Offset = "0x7C17E40", VA = "0x187C19840")]
		public void SetParentAlignment(FMDEEKEGJAL rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C19640", Offset = "0x7C17C40", VA = "0x187C19640")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C196A0", Offset = "0x7C17CA0", VA = "0x187C196A0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C19630", Offset = "0x7C17C30", VA = "0x187C19630")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C19990", Offset = "0x7C17F90", VA = "0x187C19990")]
		private GKEIPMPHIEH UpdateCache()
		{
			return default(GKEIPMPHIEH);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum GKEIPMPHIEH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NNPBNGLJLOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] HHEHMOOIKPI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C19E00", Offset = "0x7C18400", VA = "0x187C19E00")]
	public static float2Rect FPAPLENCBEE(Transform CFOEPNMHGBO, RectTransform FCPOJLOEIEO)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A110", Offset = "0x7C18710", VA = "0x187C1A110")]
	public static void ODDDDNNEONH(Vector3[] FGAABGHBNMC, [Out] float2 COJGDIKBGKB, [Out] float2 JNIBMOMFMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BKCDICGPFKC
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] MIKFDHDKEOE;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C17C00", Offset = "0x7C16200", VA = "0x187C17C00")]
	public static void IBCOEJBKNDO([In] int AHEILNPGLGH, [Out] ushort JFJBAMJCKOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DIFKACCMNAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DOBOKNMNBEO
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
	[Cpp2IlInjected.Address(RVA = "0x7C17E80", Offset = "0x7C16480", VA = "0x187C17E80")]
	public static void AHHHDICLEGA(float3[] PEKMPNMHBPN, [In] float2 ONEKKBKCIBD, [In] float2 IAGMCHJPEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C18FB0", Offset = "0x7C175B0", VA = "0x187C18FB0")]
	public static void HNMDAHJBJLP(float2[] DMCDJAANJJG, [In] float2 JGNECBNGPKK, [In] float2 MNPDAOJHMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C19200", Offset = "0x7C17800", VA = "0x187C19200")]
	public static void MOHJAAHIOID(float3[] PEKMPNMHBPN, [In] float GNNMPJMEIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C18C20", Offset = "0x7C17220", VA = "0x187C18C20")]
	public static void FKEKHLPGDLL(QuadVertex[] GFKJOIMNDHO, [In] int JFJBAMJCKOC, [In] float3[] NGDPFMJOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C17F90", Offset = "0x7C16590", VA = "0x187C17F90")]
	public static void BMBIKBGDPIK(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] float3[] NGDPFMJOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C19100", Offset = "0x7C17700", VA = "0x187C19100")]
	public static void KDOHGGJFGMK(QuadVertex[] GFKJOIMNDHO, [In] int JFJBAMJCKOC, [In] Color32 IIOJDIEANID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C19270", Offset = "0x7C17870", VA = "0x187C19270")]
	public static void NCKEJBHFOPO(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] Color32 IIOJDIEANID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C19470", Offset = "0x7C17A70", VA = "0x187C19470")]
	public static void OAHHGFFOFBC(QuadVertex[] GFKJOIMNDHO, [In] int JFJBAMJCKOC, [In] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C18860", Offset = "0x7C16E60", VA = "0x187C18860")]
	public static void ECABCLJBFOP(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C18AA0", Offset = "0x7C170A0", VA = "0x187C18AA0")]
	public static void FHALMDCBEJL(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] float3[] NGDPFMJOGNA, [In] Color32 IIOJDIEANID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C180A0", Offset = "0x7C166A0", VA = "0x187C180A0")]
	public static void CHKDNCCMEGL(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] float3[] NGDPFMJOGNA, [In] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C192F0", Offset = "0x7C178F0", VA = "0x187C192F0")]
	public static void NGLBBOMKPFE(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] Color32 IIOJDIEANID, [In] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C185D0", Offset = "0x7C16BD0", VA = "0x187C185D0")]
	public static void DINOBEIOAPK(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] float3[] NGDPFMJOGNA, [In] Color32 IIOJDIEANID, [In] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C18970", Offset = "0x7C16F70", VA = "0x187C18970")]
	public static void ENDMODIFNNC(ushort[] BMPFHBCCNDN, int AHEILNPGLGH, [In] int MFMOEFCIMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C18D30", Offset = "0x7C17330", VA = "0x187C18D30")]
	public static void HJMOAEJEOGD(ushort[] BMPFHBCCNDN, int AHEILNPGLGH, [In] int MFMOEFCIMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C17F00", Offset = "0x7C16500", VA = "0x187C17F00")]
	public static void AJJPBDJJEMM(ushort[] BMPFHBCCNDN, [In] int AHEILNPGLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C19040", Offset = "0x7C17640", VA = "0x187C19040")]
	public static void JHLLLKEMCAA(ushort[] BMPFHBCCNDN, [In] int AHEILNPGLGH, [In] int JFJBAMJCKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C18D70", Offset = "0x7C17370", VA = "0x187C18D70")]
	public static Bounds HLJBLFNONLG([In] QuadVertex[] GFKJOIMNDHO, [In] ushort[] BMPFHBCCNDN, [In] int IDKFBJPHMKC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C182C0", Offset = "0x7C168C0", VA = "0x187C182C0")]
	public static Bounds CPCELCNHDFF([In] QuadVertex[] GFKJOIMNDHO, [In] ushort[] BMPFHBCCNDN, [In] int IDKFBJPHMKC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C19180", Offset = "0x7C17780", VA = "0x187C19180")]
	[CompilerGenerated]
	internal static void MANGJIGMOMH([In] float3 NOOBIPOJNNG, DOBOKNMNBEO P_1)
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
