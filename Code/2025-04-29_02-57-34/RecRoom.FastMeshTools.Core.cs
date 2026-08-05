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
public static class NAGEILMPDFC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5AE0", Offset = "0x7AE4EE0", VA = "0x187AE5AE0")]
	public static float2 MEBHGNGPMMF(this ELAAILPNPAI OMJAKKKMFKD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ELAAILPNPAI : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2D791B0", Offset = "0x2D785B0", VA = "0x182D791B0")]
		public float2Rect(float2 KBPOHLLNAIG, float2 LLBNOFGPNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8650", Offset = "0x7AE7A50", VA = "0x187AE8650")]
		public void JGKNJHGPNLN([Out] float2 NNLICODKFDC, [Out] float2 OKOPJGMGHID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8670", Offset = "0x7AE7A70", VA = "0x187AE8670")]
		public float2 KEGBOCIDCFI(float2 LJKOGJNOBFE)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8420", Offset = "0x7AE7820", VA = "0x187AE8420", Slot = "4")]
		public bool Equals(float2Rect DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7AE84A0", Offset = "0x7AE78A0", VA = "0x187AE84A0", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7AE85A0", Offset = "0x7AE79A0", VA = "0x187AE85A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7AE86A0", Offset = "0x7AE7AA0", VA = "0x187AE86A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7AE88C0", Offset = "0x7AE7CC0", VA = "0x187AE88C0", Slot = "5")]
		public string ToString(string EIDACCNCFOG, IFormatProvider OEFNOANBGID)
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
		[Cpp2IlInjected.Address(RVA = "0x7AE8D10", Offset = "0x7AE8110", VA = "0x187AE8D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8C80", Offset = "0x7AE8080", VA = "0x187AE8C80", Slot = "6")]
		public string ToString(string EIDACCNCFOG, IFormatProvider OEFNOANBGID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8AE0", Offset = "0x7AE7EE0", VA = "0x187AE8AE0", Slot = "4")]
		public bool Equals(floatMinMax DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8BD0", Offset = "0x7AE7FD0", VA = "0x187AE8BD0", Slot = "5")]
		public bool Equals(float2 DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8B20", Offset = "0x7AE7F20", VA = "0x187AE8B20", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8C00", Offset = "0x7AE8000", VA = "0x187AE8C00", Slot = "2")]
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
		private DJLCMLGKJCJ cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7E80", Offset = "0x7AE7280", VA = "0x187AE7E80")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7D30", Offset = "0x7AE7130", VA = "0x187AE7D30")]
		public LayoutRect(LayoutRect parent, ELAAILPNPAI parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AE77F0", Offset = "0x7AE6BF0", VA = "0x187AE77F0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7750", Offset = "0x7AE6B50", VA = "0x187AE7750")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7AE77C0", Offset = "0x7AE6BC0", VA = "0x187AE77C0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7760", Offset = "0x7AE6B60", VA = "0x187AE7760")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7900", Offset = "0x7AE6D00", VA = "0x187AE7900")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AE59A0", Offset = "0x7AE4DA0", VA = "0x187AE59A0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7A00", Offset = "0x7AE6E00", VA = "0x187AE7A00")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE79B0", Offset = "0x7AE6DB0", VA = "0x187AE79B0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7960", Offset = "0x7AE6D60", VA = "0x187AE7960")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7AB0", Offset = "0x7AE6EB0", VA = "0x187AE7AB0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7A60", Offset = "0x7AE6E60", VA = "0x187AE7A60")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7A10", Offset = "0x7AE6E10", VA = "0x187AE7A10")]
		public void SetParentAlignment(ELAAILPNPAI rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7810", Offset = "0x7AE6C10", VA = "0x187AE7810")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7870", Offset = "0x7AE6C70", VA = "0x187AE7870")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7800", Offset = "0x7AE6C00", VA = "0x187AE7800")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7B60", Offset = "0x7AE6F60", VA = "0x187AE7B60")]
		private DJLCMLGKJCJ UpdateCache()
		{
			return default(DJLCMLGKJCJ);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DJLCMLGKJCJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MJFFLMLFPLE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] LBEECJBLFGL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7FD0", Offset = "0x7AE73D0", VA = "0x187AE7FD0")]
	public static float2Rect NDBAKPHNMFF(Transform PNEKOKHGLKD, RectTransform EJCNBBIIFBE)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7AE82F0", Offset = "0x7AE76F0", VA = "0x187AE82F0")]
	public static void OIIFCLCKEIN(Vector3[] ILKPLGLEGLF, [Out] float2 JLCBKIPFKML, [Out] float2 CBHAMKJGEOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class ELBONPMGFNF
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] ELGAHKBCHCM;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5F00", Offset = "0x7AE5300", VA = "0x187AE5F00")]
	public static void MBDCKECDAPM([In] int OHEBMBLKFCN, [Out] ushort LALGAFIBAHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HCGDDNPJCPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DCHOPLKOEBN
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
	[Cpp2IlInjected.Address(RVA = "0x7AE7150", Offset = "0x7AE6550", VA = "0x187AE7150")]
	public static void LBLOOFIEGLA(float3[] MOGHAJAHNKH, [In] float2 ODHDBNHAHFA, [In] float2 OKOPJGMGHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7AE71D0", Offset = "0x7AE65D0", VA = "0x187AE71D0")]
	public static void LOEPNAIDAIJ(float2[] JGHAMNAEAMP, [In] float2 BCEEKEAEAHF, [In] float2 GPKLCIADMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE70E0", Offset = "0x7AE64E0", VA = "0x187AE70E0")]
	public static void KGEAALICEAB(float3[] MOGHAJAHNKH, [In] float DMDNKJDBABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE66A0", Offset = "0x7AE5AA0", VA = "0x187AE66A0")]
	public static void ENDFKFEGABL(QuadVertex[] KHJOOAKPGCG, [In] int LALGAFIBAHO, [In] float3[] FPJDNLHBECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7640", Offset = "0x7AE6A40", VA = "0x187AE7640")]
	public static void PNCDDJONDNE(QuadVertex[] KHJOOAKPGCG, int LALGAFIBAHO, [In] float3[] FPJDNLHBECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7AE67B0", Offset = "0x7AE5BB0", VA = "0x187AE67B0")]
	public static void GCLKHGODFNH(QuadVertex[] KHJOOAKPGCG, [In] int LALGAFIBAHO, [In] Color32 EMIIAJCDKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6320", Offset = "0x7AE5720", VA = "0x187AE6320")]
	public static void COJNLKPFEAA(QuadVertex[] KHJOOAKPGCG, int LALGAFIBAHO, [In] Color32 EMIIAJCDKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6460", Offset = "0x7AE5860", VA = "0x187AE6460")]
	public static void DHLLEIMICJH(QuadVertex[] KHJOOAKPGCG, [In] int LALGAFIBAHO, [In] float2[] DGKKKOEKKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7AE72A0", Offset = "0x7AE66A0", VA = "0x187AE72A0")]
	public static void MKFOLBNMHON(QuadVertex[] KHJOOAKPGCG, int LALGAFIBAHO, [In] float2[] DGKKKOEKKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6B40", Offset = "0x7AE5F40", VA = "0x187AE6B40")]
	public static void GOGBCMMALMO(QuadVertex[] KHJOOAKPGCG, int LALGAFIBAHO, [In] float3[] FPJDNLHBECD, [In] Color32 EMIIAJCDKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6D40", Offset = "0x7AE6140", VA = "0x187AE6D40")]
	public static void IDNKNMIMMLO(QuadVertex[] KHJOOAKPGCG, int LALGAFIBAHO, [In] float3[] FPJDNLHBECD, [In] float2[] DGKKKOEKKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6F60", Offset = "0x7AE6360", VA = "0x187AE6F60")]
	public static void JBPAIIDNOBH(QuadVertex[] KHJOOAKPGCG, int LALGAFIBAHO, [In] Color32 EMIIAJCDKDF, [In] float2[] DGKKKOEKKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7AE73B0", Offset = "0x7AE67B0", VA = "0x187AE73B0")]
	public static void NJIAOGMNFFG(QuadVertex[] KHJOOAKPGCG, int LALGAFIBAHO, [In] float3[] FPJDNLHBECD, [In] Color32 EMIIAJCDKDF, [In] float2[] DGKKKOEKKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6570", Offset = "0x7AE5970", VA = "0x187AE6570")]
	public static void EBBJNHEONBF(ushort[] NBFOEFEABNC, int OHEBMBLKFCN, [In] int BBFDOANMKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7260", Offset = "0x7AE6660", VA = "0x187AE7260")]
	public static void LOMECCGEPLA(ushort[] NBFOEFEABNC, int OHEBMBLKFCN, [In] int BBFDOANMKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6050", Offset = "0x7AE5450", VA = "0x187AE6050")]
	public static void BFGBKGLIFAE(ushort[] NBFOEFEABNC, [In] int OHEBMBLKFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7AE63A0", Offset = "0x7AE57A0", VA = "0x187AE63A0")]
	public static void COLIEAMMPIM(ushort[] NBFOEFEABNC, [In] int OHEBMBLKFCN, [In] int LALGAFIBAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7AE60E0", Offset = "0x7AE54E0", VA = "0x187AE60E0")]
	public static Bounds CMHCACGGKAO([In] QuadVertex[] KHJOOAKPGCG, [In] ushort[] NBFOEFEABNC, [In] int FIAFCEMGPGI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6830", Offset = "0x7AE5C30", VA = "0x187AE6830")]
	public static Bounds GIIBICIAOML([In] QuadVertex[] KHJOOAKPGCG, [In] ushort[] NBFOEFEABNC, [In] int FIAFCEMGPGI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6CC0", Offset = "0x7AE60C0", VA = "0x187AE6CC0")]
	[CompilerGenerated]
	internal static void HBNOLAAKNEG([In] float3 OHELNHAJILJ, DCHOPLKOEBN P_1)
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
