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
public static class EKJDACLPLBE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x78F2AD0", Offset = "0x78F14D0", VA = "0x1878F2AD0")]
	public static float2 DGGHNICCOHD(this AGFONAPIFCC GEMOLHKDPDO)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AGFONAPIFCC : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2CF4BE0", Offset = "0x2CF35E0", VA = "0x182CF4BE0")]
		public float2Rect(float2 KKIJMCHODGC, float2 PICLDLMFMMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78F5530", Offset = "0x78F3F30", VA = "0x1878F5530")]
		public void EHJACGLEOBL([Out] float2 OMLGMNNDLLG, [Out] float2 LANGJCDDLOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78F5780", Offset = "0x78F4180", VA = "0x1878F5780")]
		public float2 KICBPJGLBKO(float2 NMNGCHABEDG)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x78F5550", Offset = "0x78F3F50", VA = "0x1878F5550", Slot = "4")]
		public bool Equals(float2Rect OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x78F55D0", Offset = "0x78F3FD0", VA = "0x1878F55D0", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x78F56D0", Offset = "0x78F40D0", VA = "0x1878F56D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78F57B0", Offset = "0x78F41B0", VA = "0x1878F57B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78F59D0", Offset = "0x78F43D0", VA = "0x1878F59D0", Slot = "5")]
		public string ToString(string GKPIBGBGJLP, IFormatProvider LGNOAONHIHN)
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
		[Cpp2IlInjected.Address(RVA = "0x78F5E10", Offset = "0x78F4810", VA = "0x1878F5E10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x78F5D80", Offset = "0x78F4780", VA = "0x1878F5D80", Slot = "6")]
		public string ToString(string GKPIBGBGJLP, IFormatProvider LGNOAONHIHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78F5BE0", Offset = "0x78F45E0", VA = "0x1878F5BE0", Slot = "4")]
		public bool Equals(floatMinMax OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x78F5CD0", Offset = "0x78F46D0", VA = "0x1878F5CD0", Slot = "5")]
		public bool Equals(float2 OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78F5C20", Offset = "0x78F4620", VA = "0x1878F5C20", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78F5D00", Offset = "0x78F4700", VA = "0x1878F5D00", Slot = "2")]
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
		private IFKMIAJHEJI cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78F4E50", Offset = "0x78F3850", VA = "0x1878F4E50")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78F4FA0", Offset = "0x78F39A0", VA = "0x1878F4FA0")]
		public LayoutRect(LayoutRect parent, AGFONAPIFCC parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78F4910", Offset = "0x78F3310", VA = "0x1878F4910")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78F4870", Offset = "0x78F3270", VA = "0x1878F4870")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78F48E0", Offset = "0x78F32E0", VA = "0x1878F48E0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78F4880", Offset = "0x78F3280", VA = "0x1878F4880")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78F4A20", Offset = "0x78F3420", VA = "0x1878F4A20")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78F2DB0", Offset = "0x78F17B0", VA = "0x1878F2DB0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x78F4B20", Offset = "0x78F3520", VA = "0x1878F4B20")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78F4AD0", Offset = "0x78F34D0", VA = "0x1878F4AD0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x78F4A80", Offset = "0x78F3480", VA = "0x1878F4A80")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78F4BD0", Offset = "0x78F35D0", VA = "0x1878F4BD0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78F4B80", Offset = "0x78F3580", VA = "0x1878F4B80")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78F4B30", Offset = "0x78F3530", VA = "0x1878F4B30")]
		public void SetParentAlignment(AGFONAPIFCC rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78F4930", Offset = "0x78F3330", VA = "0x1878F4930")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78F4990", Offset = "0x78F3390", VA = "0x1878F4990")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78F4920", Offset = "0x78F3320", VA = "0x1878F4920")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x78F4C80", Offset = "0x78F3680", VA = "0x1878F4C80")]
		private IFKMIAJHEJI UpdateCache()
		{
			return default(IFKMIAJHEJI);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IFKMIAJHEJI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PEJNNPMCFDE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] CNNGFFPMHFL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x78F50F0", Offset = "0x78F3AF0", VA = "0x1878F50F0")]
	public static float2Rect AKJINNBOIBD(Transform CFJHEIBDLDK, RectTransform HIKBDNMPFJK)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x78F5400", Offset = "0x78F3E00", VA = "0x1878F5400")]
	public static void EKKOOAGFBNG(Vector3[] FEIAHEDKGDF, [Out] float2 ODPANEHCOAE, [Out] float2 AIHFEHEPHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HHECMJKPEFF
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] LGHMGCGACCK;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x78F4730", Offset = "0x78F3130", VA = "0x1878F4730")]
	public static void PBBGFKELHDA([In] int LBPDBNMFCOH, [Out] ushort OGHJKCBBNOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ABECONPKEOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NOBIKLIFOJA
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
	[Cpp2IlInjected.Address(RVA = "0x78F3930", Offset = "0x78F2330", VA = "0x1878F3930")]
	public static void HJPPNIAJGAK(float3[] FPCPGADAFAL, [In] float2 DCNHFPAIADB, [In] float2 LANGJCDDLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x78F2F70", Offset = "0x78F1970", VA = "0x1878F2F70")]
	public static void AOHEPMEBJPN(float2[] PMMLDILIGAE, [In] float2 JFNNFLDGFGM, [In] float2 MEBCDPIMLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x78F39B0", Offset = "0x78F23B0", VA = "0x1878F39B0")]
	public static void INIFIPMDNIH(float3[] FPCPGADAFAL, [In] float PGOEOCNAEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x78F3350", Offset = "0x78F1D50", VA = "0x1878F3350")]
	public static void ELJBHDFPGGA(QuadVertex[] LKNOPNABOND, [In] int OGHJKCBBNOA, [In] float3[] PJLAGFJIFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x78F4460", Offset = "0x78F2E60", VA = "0x1878F4460")]
	public static void PMPHCOHHNNJ(QuadVertex[] LKNOPNABOND, int OGHJKCBBNOA, [In] float3[] PJLAGFJIFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x78F3670", Offset = "0x78F2070", VA = "0x1878F3670")]
	public static void HFJLCOEDFCC(QuadVertex[] LKNOPNABOND, [In] int OGHJKCBBNOA, [In] Color32 PJEPMHNPGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x78F2EF0", Offset = "0x78F18F0", VA = "0x1878F2EF0")]
	public static void AAGGELDHOAJ(QuadVertex[] LKNOPNABOND, int OGHJKCBBNOA, [In] Color32 PJEPMHNPGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x78F3520", Offset = "0x78F1F20", VA = "0x1878F3520")]
	public static void FNCDEMOBBJP(QuadVertex[] LKNOPNABOND, [In] int OGHJKCBBNOA, [In] float2[] JEFLIFCDNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x78F41D0", Offset = "0x78F2BD0", VA = "0x1878F41D0")]
	public static void ODPOFJMNOFE(QuadVertex[] LKNOPNABOND, int OGHJKCBBNOA, [In] float2[] JEFLIFCDNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x78F42E0", Offset = "0x78F2CE0", VA = "0x1878F42E0")]
	public static void ONDGDIDCNML(QuadVertex[] LKNOPNABOND, int OGHJKCBBNOA, [In] float3[] PJLAGFJIFJC, [In] Color32 PJEPMHNPGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x78F3000", Offset = "0x78F1A00", VA = "0x1878F3000")]
	public static void CGLILNGEFMH(QuadVertex[] LKNOPNABOND, int OGHJKCBBNOA, [In] float3[] PJLAGFJIFJC, [In] float2[] JEFLIFCDNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x78F4050", Offset = "0x78F2A50", VA = "0x1878F4050")]
	public static void KDABGAFPOPD(QuadVertex[] LKNOPNABOND, int OGHJKCBBNOA, [In] Color32 PJEPMHNPGDC, [In] float2[] JEFLIFCDNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x78F3A20", Offset = "0x78F2420", VA = "0x1878F3A20")]
	public static void JCCAPACHJJJ(QuadVertex[] LKNOPNABOND, int OGHJKCBBNOA, [In] float3[] PJLAGFJIFJC, [In] Color32 PJEPMHNPGDC, [In] float2[] JEFLIFCDNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x78F3220", Offset = "0x78F1C20", VA = "0x1878F3220")]
	public static void DIABHJKMMBB(ushort[] IDPGMLJGHJE, int LBPDBNMFCOH, [In] int DIHILOECEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x78F3630", Offset = "0x78F2030", VA = "0x1878F3630")]
	public static void FOOHGGGKLOP(ushort[] IDPGMLJGHJE, int LBPDBNMFCOH, [In] int DIHILOECEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x78F3FC0", Offset = "0x78F29C0", VA = "0x1878F3FC0")]
	public static void KALKPONIBHJ(ushort[] IDPGMLJGHJE, [In] int LBPDBNMFCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x78F3460", Offset = "0x78F1E60", VA = "0x1878F3460")]
	public static void FAJAIFPFNBP(ushort[] IDPGMLJGHJE, [In] int LBPDBNMFCOH, [In] int OGHJKCBBNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x78F36F0", Offset = "0x78F20F0", VA = "0x1878F36F0")]
	public static Bounds HHLFNILLIOM([In] QuadVertex[] LKNOPNABOND, [In] ushort[] IDPGMLJGHJE, [In] int NAFGKOIPBHM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x78F3CB0", Offset = "0x78F26B0", VA = "0x1878F3CB0")]
	public static Bounds KAJLCKBICLF([In] QuadVertex[] LKNOPNABOND, [In] ushort[] IDPGMLJGHJE, [In] int NAFGKOIPBHM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x78F4570", Offset = "0x78F2F70", VA = "0x1878F4570")]
	[CompilerGenerated]
	internal static void PNOGPJKKOIL([In] float3 GJPBKNDCAIE, NOBIKLIFOJA P_1)
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
