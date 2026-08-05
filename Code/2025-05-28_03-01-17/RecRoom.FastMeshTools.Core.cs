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
public static class FJJGCCGBECD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D847B0", Offset = "0x7D835B0", VA = "0x187D847B0")]
	public static float2 KECFMNJHKIG(this LJLLJPPMEBP NNBKBEKPNDK)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LJLLJPPMEBP : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2ED1A90", Offset = "0x2ED0890", VA = "0x182ED1A90")]
		public float2Rect(float2 NPJPCFKLMHD, float2 ACINDEOBNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D871D0", Offset = "0x7D85FD0", VA = "0x187D871D0")]
		public void GOKNENBJBKI([Out] float2 KBCPCBPBIFH, [Out] float2 DHHPIKEAIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D872A0", Offset = "0x7D860A0", VA = "0x187D872A0")]
		public float2 IBIONENHENF(float2 IPMGNCCHKCM)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D87050", Offset = "0x7D85E50", VA = "0x187D87050", Slot = "4")]
		public bool Equals(float2Rect HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D870D0", Offset = "0x7D85ED0", VA = "0x187D870D0", Slot = "0")]
		public override bool Equals(object GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D871F0", Offset = "0x7D85FF0", VA = "0x187D871F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D872D0", Offset = "0x7D860D0", VA = "0x187D872D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D874F0", Offset = "0x7D862F0", VA = "0x187D874F0", Slot = "5")]
		public string ToString(string HONGJHADKJH, IFormatProvider NMMLIKIJEEF)
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
		[Cpp2IlInjected.Address(RVA = "0x7D87930", Offset = "0x7D86730", VA = "0x187D87930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D878A0", Offset = "0x7D866A0", VA = "0x187D878A0", Slot = "6")]
		public string ToString(string HONGJHADKJH, IFormatProvider NMMLIKIJEEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D87700", Offset = "0x7D86500", VA = "0x187D87700", Slot = "4")]
		public bool Equals(floatMinMax HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D877F0", Offset = "0x7D865F0", VA = "0x187D877F0", Slot = "5")]
		public bool Equals(float2 HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D87740", Offset = "0x7D86540", VA = "0x187D87740", Slot = "0")]
		public override bool Equals(object GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D87820", Offset = "0x7D86620", VA = "0x187D87820", Slot = "2")]
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
		private LEKPMJKLLHN cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D86AB0", Offset = "0x7D858B0", VA = "0x187D86AB0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D86960", Offset = "0x7D85760", VA = "0x187D86960")]
		public LayoutRect(LayoutRect parent, LJLLJPPMEBP parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D86420", Offset = "0x7D85220", VA = "0x187D86420")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7D86380", Offset = "0x7D85180", VA = "0x187D86380")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D863F0", Offset = "0x7D851F0", VA = "0x187D863F0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D86390", Offset = "0x7D85190", VA = "0x187D86390")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D86530", Offset = "0x7D85330", VA = "0x187D86530")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D848B0", Offset = "0x7D836B0", VA = "0x187D848B0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D86630", Offset = "0x7D85430", VA = "0x187D86630")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7D865E0", Offset = "0x7D853E0", VA = "0x187D865E0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7D86590", Offset = "0x7D85390", VA = "0x187D86590")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7D866E0", Offset = "0x7D854E0", VA = "0x187D866E0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7D86690", Offset = "0x7D85490", VA = "0x187D86690")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7D86640", Offset = "0x7D85440", VA = "0x187D86640")]
		public void SetParentAlignment(LJLLJPPMEBP rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7D86440", Offset = "0x7D85240", VA = "0x187D86440")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D864A0", Offset = "0x7D852A0", VA = "0x187D864A0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7D86430", Offset = "0x7D85230", VA = "0x187D86430")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7D86790", Offset = "0x7D85590", VA = "0x187D86790")]
		private LEKPMJKLLHN UpdateCache()
		{
			return default(LEKPMJKLLHN);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LEKPMJKLLHN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MECKMMPGMKE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] DMOOHPBAOAG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D86C00", Offset = "0x7D85A00", VA = "0x187D86C00")]
	public static float2Rect BFKCADKKHCH(Transform HECNMDEPAGD, RectTransform GDCDKMJLKDH)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D86F20", Offset = "0x7D85D20", VA = "0x187D86F20")]
	public static void FOFFGBEIOKL(Vector3[] CMAOECNJPGG, [Out] float2 JJLOIPCKCEC, [Out] float2 CEDDBAAAIGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EFMKAEDICAD
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] ECIMFKNACNF;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D84B30", Offset = "0x7D83930", VA = "0x187D84B30")]
	public static void BNJBIBKKFFG([In] int JNPAPKOIHHM, [Out] ushort CBGCIGJJLGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FNCAHBIFOMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KEPAEJNAMHM
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
	[Cpp2IlInjected.Address(RVA = "0x7D86010", Offset = "0x7D84E10", VA = "0x187D86010")]
	public static void NHPHCMHDFAJ(float3[] EPCKEPGIKMJ, [In] float2 BMLHPLEABAJ, [In] float2 DHHPIKEAIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D851D0", Offset = "0x7D83FD0", VA = "0x187D851D0")]
	public static void DGCJNECLHBK(float2[] JKPABIAPHCM, [In] float2 AKMHEDLJBMA, [In] float2 APNCJCBONBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D85160", Offset = "0x7D83F60", VA = "0x187D85160")]
	public static void CGLGFPJOILM(float3[] EPCKEPGIKMJ, [In] float JEABFKNECGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D86160", Offset = "0x7D84F60", VA = "0x187D86160")]
	public static void PBFCGBCJIDO(QuadVertex[] NPKGPEMIEKO, [In] int CBGCIGJJLGE, [In] float3[] FPMCLKAKPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D85840", Offset = "0x7D84640", VA = "0x187D85840")]
	public static void FCBKIPPNPGE(QuadVertex[] NPKGPEMIEKO, int CBGCIGJJLGE, [In] float3[] FPMCLKAKPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D850E0", Offset = "0x7D83EE0", VA = "0x187D850E0")]
	public static void BKIKIKOBGMC(QuadVertex[] NPKGPEMIEKO, [In] int CBGCIGJJLGE, [In] Color32 IEHIJEJPBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D85F10", Offset = "0x7D84D10", VA = "0x187D85F10")]
	public static void IINHBJGBCKI(QuadVertex[] NPKGPEMIEKO, int CBGCIGJJLGE, [In] Color32 IEHIJEJPBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D84C80", Offset = "0x7D83A80", VA = "0x187D84C80")]
	public static void AEBIFIEACJC(QuadVertex[] NPKGPEMIEKO, [In] int CBGCIGJJLGE, [In] float2[] KJOMPOHFIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D86270", Offset = "0x7D85070", VA = "0x187D86270")]
	public static void PEGIEGJHHEC(QuadVertex[] NPKGPEMIEKO, int CBGCIGJJLGE, [In] float2[] KJOMPOHFIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D85260", Offset = "0x7D84060", VA = "0x187D85260")]
	public static void DMMJKLMPKIO(QuadVertex[] NPKGPEMIEKO, int CBGCIGJJLGE, [In] float3[] FPMCLKAKPBN, [In] Color32 IEHIJEJPBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D85620", Offset = "0x7D84420", VA = "0x187D85620")]
	public static void EAPFOCKLLEO(QuadVertex[] NPKGPEMIEKO, int CBGCIGJJLGE, [In] float3[] FPMCLKAKPBN, [In] float2[] KJOMPOHFIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D85D90", Offset = "0x7D84B90", VA = "0x187D85D90")]
	public static void IFEEAIAGIBA(QuadVertex[] NPKGPEMIEKO, int CBGCIGJJLGE, [In] Color32 IEHIJEJPBBK, [In] float2[] KJOMPOHFIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D84D90", Offset = "0x7D83B90", VA = "0x187D84D90")]
	public static void AFBOJIJOHFJ(QuadVertex[] NPKGPEMIEKO, int CBGCIGJJLGE, [In] float3[] FPMCLKAKPBN, [In] Color32 IEHIJEJPBBK, [In] float2[] KJOMPOHFIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C60", Offset = "0x7D84A60", VA = "0x187D85C60")]
	public static void GILELEFCAHJ(ushort[] CAIEFFKNDIL, int JNPAPKOIHHM, [In] int OOCFDLICHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D86090", Offset = "0x7D84E90", VA = "0x187D86090")]
	public static void NIOBODFGIPM(ushort[] CAIEFFKNDIL, int JNPAPKOIHHM, [In] int OOCFDLICHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D860D0", Offset = "0x7D84ED0", VA = "0x187D860D0")]
	public static void OMEBCAFBALF(ushort[] CAIEFFKNDIL, [In] int JNPAPKOIHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D85020", Offset = "0x7D83E20", VA = "0x187D85020")]
	public static void ANBOBFHJAJP(ushort[] CAIEFFKNDIL, [In] int JNPAPKOIHHM, [In] int CBGCIGJJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D853E0", Offset = "0x7D841E0", VA = "0x187D853E0")]
	public static Bounds EACOCKGDEAF([In] QuadVertex[] NPKGPEMIEKO, [In] ushort[] CAIEFFKNDIL, [In] int OBAIPCAHPMJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D85950", Offset = "0x7D84750", VA = "0x187D85950")]
	public static Bounds GHBBPBGHJBE([In] QuadVertex[] NPKGPEMIEKO, [In] ushort[] CAIEFFKNDIL, [In] int OBAIPCAHPMJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D85F90", Offset = "0x7D84D90", VA = "0x187D85F90")]
	[CompilerGenerated]
	internal static void INAEGMLCONN([In] float3 PJEGPPLKFBI, KEPAEJNAMHM P_1)
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
