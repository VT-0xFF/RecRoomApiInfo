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
public static class EHHKMKCIEJL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x836E720", Offset = "0x836D520", VA = "0x18836E720")]
	public static float2 HILDLGPGFDM(this JCMJNIGLLBO AEMGAAJOLNB)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JCMJNIGLLBO : byte
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
		[Cpp2IlInjected.Address(RVA = "0x308A720", Offset = "0x3089520", VA = "0x18308A720")]
		public float2Rect(float2 FLAPAOJCDCM, float2 BCMFMCHGEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83713E0", Offset = "0x83701E0", VA = "0x1883713E0")]
		public void MLOAOPFMIPK([Out] float2 LKEFOMHPBFD, [Out] float2 BPAHHHHBBPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8371180", Offset = "0x836FF80", VA = "0x188371180")]
		public float2 ENKJIABKCFJ(float2 DFLPHBJNDNC)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83711B0", Offset = "0x836FFB0", VA = "0x1883711B0", Slot = "4")]
		public bool Equals(float2Rect FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8371230", Offset = "0x8370030", VA = "0x188371230", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8371330", Offset = "0x8370130", VA = "0x188371330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8371400", Offset = "0x8370200", VA = "0x188371400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8371620", Offset = "0x8370420", VA = "0x188371620", Slot = "5")]
		public string ToString(string DILPKDIDKCM, IFormatProvider AGBEIDMJODJ)
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
		[Cpp2IlInjected.Address(RVA = "0x8371A60", Offset = "0x8370860", VA = "0x188371A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83719D0", Offset = "0x83707D0", VA = "0x1883719D0", Slot = "6")]
		public string ToString(string DILPKDIDKCM, IFormatProvider AGBEIDMJODJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8371830", Offset = "0x8370630", VA = "0x188371830", Slot = "4")]
		public bool Equals(floatMinMax FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8371920", Offset = "0x8370720", VA = "0x188371920", Slot = "5")]
		public bool Equals(float2 FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8371870", Offset = "0x8370670", VA = "0x188371870", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8371950", Offset = "0x8370750", VA = "0x188371950", Slot = "2")]
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
		private EIGEGBOAIFN cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x836F930", Offset = "0x836E730", VA = "0x18836F930")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x836F7E0", Offset = "0x836E5E0", VA = "0x18836F7E0")]
		public LayoutRect(LayoutRect parent, JCMJNIGLLBO parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x836F2A0", Offset = "0x836E0A0", VA = "0x18836F2A0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x836F200", Offset = "0x836E000", VA = "0x18836F200")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x836F270", Offset = "0x836E070", VA = "0x18836F270")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x836F210", Offset = "0x836E010", VA = "0x18836F210")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x836F3B0", Offset = "0x836E1B0", VA = "0x18836F3B0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x836E820", Offset = "0x836D620", VA = "0x18836E820")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x836F4B0", Offset = "0x836E2B0", VA = "0x18836F4B0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x836F460", Offset = "0x836E260", VA = "0x18836F460")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x836F410", Offset = "0x836E210", VA = "0x18836F410")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x836F560", Offset = "0x836E360", VA = "0x18836F560")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x836F510", Offset = "0x836E310", VA = "0x18836F510")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x836F4C0", Offset = "0x836E2C0", VA = "0x18836F4C0")]
		public void SetParentAlignment(JCMJNIGLLBO rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x836F2C0", Offset = "0x836E0C0", VA = "0x18836F2C0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x836F320", Offset = "0x836E120", VA = "0x18836F320")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x836F2B0", Offset = "0x836E0B0", VA = "0x18836F2B0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x836F610", Offset = "0x836E410", VA = "0x18836F610")]
		private EIGEGBOAIFN UpdateCache()
		{
			return default(EIGEGBOAIFN);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum EIGEGBOAIFN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FBNLLDMJLBI
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] GCDONDMNLCA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x836EE80", Offset = "0x836DC80", VA = "0x18836EE80")]
	public static float2Rect OOIFJMKCABB(Transform MOKGONMNKEA, RectTransform BNIHAACOHPG)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x836EDC0", Offset = "0x836DBC0", VA = "0x18836EDC0")]
	public static void DOGKGGJMOJP(Vector3[] EKPDBPHKEEC, [Out] float2 OLBFNPPONEB, [Out] float2 ANDCPDPHMGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DEKMNBJPAON
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] IDOIBPDOJKP;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x836EC80", Offset = "0x836DA80", VA = "0x18836EC80")]
	public static void IPGBADGOLGA([In] int ABEDFPDDFOF, [Out] ushort FFBLOOFNNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MPDECCOIJOH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CHEDMMGHLHG
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
	[Cpp2IlInjected.Address(RVA = "0x836FCC0", Offset = "0x836EAC0", VA = "0x18836FCC0")]
	public static void BALIKLLCMBM(float3[] LPDKBHNBHFL, [In] float2 PNMCGNGBNJO, [In] float2 BPAHHHHBBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8370AD0", Offset = "0x836F8D0", VA = "0x188370AD0")]
	public static void IJLCBJJHJKD(float2[] LIFPLKHKGIN, [In] float2 PMANPEJBMPH, [In] float2 AKOJHMOKPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8370B60", Offset = "0x836F960", VA = "0x188370B60")]
	public static void JFKBFJPFCIF(float3[] LPDKBHNBHFL, [In] float IKKELAAJANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x836FED0", Offset = "0x836ECD0", VA = "0x18836FED0")]
	public static void EEPKCDCJIAL(QuadVertex[] MBKKFAHCLMA, [In] int FFBLOOFNNGK, [In] float3[] CLHIGJHJDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x83706B0", Offset = "0x836F4B0", VA = "0x1883706B0")]
	public static void HDCNLNBOHOJ(QuadVertex[] MBKKFAHCLMA, int FFBLOOFNNGK, [In] float3[] CLHIGJHJDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8371100", Offset = "0x836FF00", VA = "0x188371100")]
	public static void PAJJFPCAPHL(QuadVertex[] MBKKFAHCLMA, [In] int FFBLOOFNNGK, [In] Color32 COEBDNBJMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x836FD40", Offset = "0x836EB40", VA = "0x18836FD40")]
	public static void COPCFIHHBAB(QuadVertex[] MBKKFAHCLMA, int FFBLOOFNNGK, [In] Color32 COEBDNBJMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8370490", Offset = "0x836F290", VA = "0x188370490")]
	public static void FKMEOCEIKFA(QuadVertex[] MBKKFAHCLMA, [In] int FFBLOOFNNGK, [In] float2[] HDDMABCEGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83705A0", Offset = "0x836F3A0", VA = "0x1883705A0")]
	public static void GFLGEKHBJAO(QuadVertex[] MBKKFAHCLMA, int FFBLOOFNNGK, [In] float2[] HDDMABCEGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8370E00", Offset = "0x836FC00", VA = "0x188370E00")]
	public static void MGPFNIODKFD(QuadVertex[] MBKKFAHCLMA, int FFBLOOFNNGK, [In] float3[] CLHIGJHJDAL, [In] Color32 COEBDNBJMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8370270", Offset = "0x836F070", VA = "0x188370270")]
	public static void FJJLJELPHCM(QuadVertex[] MBKKFAHCLMA, int FFBLOOFNNGK, [In] float3[] CLHIGJHJDAL, [In] float2[] HDDMABCEGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8370F80", Offset = "0x836FD80", VA = "0x188370F80")]
	public static void OIALBAOEJOC(QuadVertex[] MBKKFAHCLMA, int FFBLOOFNNGK, [In] Color32 COEBDNBJMNA, [In] float2[] HDDMABCEGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x836FFE0", Offset = "0x836EDE0", VA = "0x18836FFE0")]
	public static void EJGKPBEJKBN(QuadVertex[] MBKKFAHCLMA, int FFBLOOFNNGK, [In] float3[] CLHIGJHJDAL, [In] Color32 COEBDNBJMNA, [In] float2[] HDDMABCEGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8370CD0", Offset = "0x836FAD0", VA = "0x188370CD0")]
	public static void MDDGHHNDKAB(ushort[] MOJAMPNJJGB, int ABEDFPDDFOF, [In] int OOHOBFBBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8370C90", Offset = "0x836FA90", VA = "0x188370C90")]
	public static void JIFGBOGLHFP(ushort[] MOJAMPNJJGB, int ABEDFPDDFOF, [In] int OOHOBFBBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x836FDC0", Offset = "0x836EBC0", VA = "0x18836FDC0")]
	public static void DMFMIEFALPM(ushort[] MOJAMPNJJGB, [In] int ABEDFPDDFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8370BD0", Offset = "0x836F9D0", VA = "0x188370BD0")]
	public static void JFNBDLIFJLB(ushort[] MOJAMPNJJGB, [In] int ABEDFPDDFOF, [In] int FFBLOOFNNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x836FA80", Offset = "0x836E880", VA = "0x18836FA80")]
	public static Bounds AIPFKBGLANJ([In] QuadVertex[] MBKKFAHCLMA, [In] ushort[] MOJAMPNJJGB, [In] int HHPMLAEKIJG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83707C0", Offset = "0x836F5C0", VA = "0x1883707C0")]
	public static Bounds HIALCHMCDNC([In] QuadVertex[] MBKKFAHCLMA, [In] ushort[] MOJAMPNJJGB, [In] int HHPMLAEKIJG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x836FE50", Offset = "0x836EC50", VA = "0x18836FE50")]
	[CompilerGenerated]
	internal static void DOLGEEAKBLG([In] float3 EFDFIDCNFKB, CHEDMMGHLHG P_1)
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
