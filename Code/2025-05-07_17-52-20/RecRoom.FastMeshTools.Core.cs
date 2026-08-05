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
	[Cpp2IlInjected.Address(RVA = "0x7C4C530", Offset = "0x7C4B530", VA = "0x187C4C530")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E16F50", Offset = "0x2E15F50", VA = "0x182E16F50")]
		public float2Rect(float2 EPCLGOKLIPO, float2 CFNMLMNHCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EFB0", Offset = "0x7C4DFB0", VA = "0x187C4EFB0")]
		public void BGDNOIMKKGE([Out] float2 BJAIKIJFJAB, [Out] float2 IAGMCHJPEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EFD0", Offset = "0x7C4DFD0", VA = "0x187C4EFD0")]
		public float2 EMELLBPIHBJ(float2 INDJGMGIGJH)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F000", Offset = "0x7C4E000", VA = "0x187C4F000", Slot = "4")]
		public bool Equals(float2Rect MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F080", Offset = "0x7C4E080", VA = "0x187C4F080", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F180", Offset = "0x7C4E180", VA = "0x187C4F180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F230", Offset = "0x7C4E230", VA = "0x187C4F230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F450", Offset = "0x7C4E450", VA = "0x187C4F450", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C4F8A0", Offset = "0x7C4E8A0", VA = "0x187C4F8A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F810", Offset = "0x7C4E810", VA = "0x187C4F810", Slot = "6")]
		public string ToString(string CKHLMMECGLE, IFormatProvider AMMODFLNLEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F670", Offset = "0x7C4E670", VA = "0x187C4F670", Slot = "4")]
		public bool Equals(floatMinMax MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F760", Offset = "0x7C4E760", VA = "0x187C4F760", Slot = "5")]
		public bool Equals(float2 MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F6B0", Offset = "0x7C4E6B0", VA = "0x187C4F6B0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F790", Offset = "0x7C4E790", VA = "0x187C4F790", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C4E8C0", Offset = "0x7C4D8C0", VA = "0x187C4E8C0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EA10", Offset = "0x7C4DA10", VA = "0x187C4EA10")]
		public LayoutRect(LayoutRect parent, FMDEEKEGJAL parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E380", Offset = "0x7C4D380", VA = "0x187C4E380")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E2E0", Offset = "0x7C4D2E0", VA = "0x187C4E2E0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E350", Offset = "0x7C4D350", VA = "0x187C4E350")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E2F0", Offset = "0x7C4D2F0", VA = "0x187C4E2F0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E490", Offset = "0x7C4D490", VA = "0x187C4E490")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C630", Offset = "0x7C4B630", VA = "0x187C4C630")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E590", Offset = "0x7C4D590", VA = "0x187C4E590")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E540", Offset = "0x7C4D540", VA = "0x187C4E540")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E4F0", Offset = "0x7C4D4F0", VA = "0x187C4E4F0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E640", Offset = "0x7C4D640", VA = "0x187C4E640")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E5F0", Offset = "0x7C4D5F0", VA = "0x187C4E5F0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E5A0", Offset = "0x7C4D5A0", VA = "0x187C4E5A0")]
		public void SetParentAlignment(FMDEEKEGJAL rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E3A0", Offset = "0x7C4D3A0", VA = "0x187C4E3A0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E400", Offset = "0x7C4D400", VA = "0x187C4E400")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E390", Offset = "0x7C4D390", VA = "0x187C4E390")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E6F0", Offset = "0x7C4D6F0", VA = "0x187C4E6F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C4EB60", Offset = "0x7C4DB60", VA = "0x187C4EB60")]
	public static float2Rect FPAPLENCBEE(Transform CFOEPNMHGBO, RectTransform FCPOJLOEIEO)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C4EE80", Offset = "0x7C4DE80", VA = "0x187C4EE80")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C4C950", Offset = "0x7C4B950", VA = "0x187C4C950")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C4CBE0", Offset = "0x7C4BBE0", VA = "0x187C4CBE0")]
	public static void AHHHDICLEGA(float3[] PEKMPNMHBPN, [In] float2 ONEKKBKCIBD, [In] float2 IAGMCHJPEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DD10", Offset = "0x7C4CD10", VA = "0x187C4DD10")]
	public static void HNMDAHJBJLP(float2[] DMCDJAANJJG, [In] float2 JGNECBNGPKK, [In] float2 MNPDAOJHMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DF60", Offset = "0x7C4CF60", VA = "0x187C4DF60")]
	public static void MOHJAAHIOID(float3[] PEKMPNMHBPN, [In] float GNNMPJMEIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D980", Offset = "0x7C4C980", VA = "0x187C4D980")]
	public static void FKEKHLPGDLL(QuadVertex[] GFKJOIMNDHO, [In] int JFJBAMJCKOC, [In] float3[] NGDPFMJOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CCF0", Offset = "0x7C4BCF0", VA = "0x187C4CCF0")]
	public static void BMBIKBGDPIK(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] float3[] NGDPFMJOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DE60", Offset = "0x7C4CE60", VA = "0x187C4DE60")]
	public static void KDOHGGJFGMK(QuadVertex[] GFKJOIMNDHO, [In] int JFJBAMJCKOC, [In] Color32 IIOJDIEANID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DFD0", Offset = "0x7C4CFD0", VA = "0x187C4DFD0")]
	public static void NCKEJBHFOPO(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] Color32 IIOJDIEANID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E1D0", Offset = "0x7C4D1D0", VA = "0x187C4E1D0")]
	public static void OAHHGFFOFBC(QuadVertex[] GFKJOIMNDHO, [In] int JFJBAMJCKOC, [In] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D5C0", Offset = "0x7C4C5C0", VA = "0x187C4D5C0")]
	public static void ECABCLJBFOP(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D800", Offset = "0x7C4C800", VA = "0x187C4D800")]
	public static void FHALMDCBEJL(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] float3[] NGDPFMJOGNA, [In] Color32 IIOJDIEANID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CE00", Offset = "0x7C4BE00", VA = "0x187C4CE00")]
	public static void CHKDNCCMEGL(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] float3[] NGDPFMJOGNA, [In] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E050", Offset = "0x7C4D050", VA = "0x187C4E050")]
	public static void NGLBBOMKPFE(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] Color32 IIOJDIEANID, [In] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D330", Offset = "0x7C4C330", VA = "0x187C4D330")]
	public static void DINOBEIOAPK(QuadVertex[] GFKJOIMNDHO, int JFJBAMJCKOC, [In] float3[] NGDPFMJOGNA, [In] Color32 IIOJDIEANID, [In] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D6D0", Offset = "0x7C4C6D0", VA = "0x187C4D6D0")]
	public static void ENDMODIFNNC(ushort[] BMPFHBCCNDN, int AHEILNPGLGH, [In] int MFMOEFCIMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DA90", Offset = "0x7C4CA90", VA = "0x187C4DA90")]
	public static void HJMOAEJEOGD(ushort[] BMPFHBCCNDN, int AHEILNPGLGH, [In] int MFMOEFCIMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CC60", Offset = "0x7C4BC60", VA = "0x187C4CC60")]
	public static void AJJPBDJJEMM(ushort[] BMPFHBCCNDN, [In] int AHEILNPGLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DDA0", Offset = "0x7C4CDA0", VA = "0x187C4DDA0")]
	public static void JHLLLKEMCAA(ushort[] BMPFHBCCNDN, [In] int AHEILNPGLGH, [In] int JFJBAMJCKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DAD0", Offset = "0x7C4CAD0", VA = "0x187C4DAD0")]
	public static Bounds HLJBLFNONLG([In] QuadVertex[] GFKJOIMNDHO, [In] ushort[] BMPFHBCCNDN, [In] int IDKFBJPHMKC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D020", Offset = "0x7C4C020", VA = "0x187C4D020")]
	public static Bounds CPCELCNHDFF([In] QuadVertex[] GFKJOIMNDHO, [In] ushort[] BMPFHBCCNDN, [In] int IDKFBJPHMKC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DEE0", Offset = "0x7C4CEE0", VA = "0x187C4DEE0")]
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
