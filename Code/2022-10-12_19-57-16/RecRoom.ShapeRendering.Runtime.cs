using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.ClusterLODs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum EPNOHFDGCOL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	RRO_MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	RRO_COLORS_COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	RRO_MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	GENERATED_MIN_VALUE = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	GENERATED_COLORS_BITS_PER_CHANNEL = 8,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	GENERATED_COLORS_COUNT = 16777216,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	GENERATED_MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	LEGACY_GENERATED_COLORS_COUNT = 4096,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	GENERATED_TO_GPU_OFFSET = -939,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HLINLLGKIDD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8020", Offset = "0x5AA7020", VA = "0x185AA8020")]
	public static bool MENBAJAIJLE(this EPNOHFDGCOL OJFKKGMGOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5AA7FE0", Offset = "0x5AA6FE0", VA = "0x185AA7FE0")]
	public static bool BBPIBGJKEPF(this EPNOHFDGCOL OJFKKGMGOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5AA7FF0", Offset = "0x5AA6FF0", VA = "0x185AA7FF0")]
	public static bool EMKKCNEJBKF(this EPNOHFDGCOL OJFKKGMGOLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BLEOLAGNKMP
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PMJFIBNNDOA
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HGAOGFEBOPA
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	ScopeRoot,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	PivotHover,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DebugLocate
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FPMCIIECIFB
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JNFABEMDBKM : CJOIIAHMNEE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte GLJEDNALEGD = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte HGGNDFCIOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] EBMIJBNFLDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PIHNKLFJCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64A010", Offset = "0x649010", VA = "0x18064A010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x693CC0", Offset = "0x692CC0", VA = "0x180693CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JBDMDMAIABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66AD90", Offset = "0x669D90", VA = "0x18066AD90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x837950", Offset = "0x836950", VA = "0x180837950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float DOHKCICGDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1118820", Offset = "0x1117820", VA = "0x181118820", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1118810", Offset = "0x1117810", VA = "0x181118810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float BIENIJPBOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x13D6420", Offset = "0x13D5420", VA = "0x1813D6420", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1897D20", Offset = "0x1896D20", VA = "0x181897D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> KNCOMLCFOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9750", Offset = "0x5AA8750", VA = "0x185AA9750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> INKFOIILJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x56AFAA0", Offset = "0x56AEAA0", VA = "0x1856AFAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject MDILBPOCOND
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AE0", Offset = "0x6E1AE0", VA = "0x1806E2AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte OKNCMHMAPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9B80", Offset = "0x5AA8B80", VA = "0x185AA9B80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5AA9C70", Offset = "0x5AA8C70", VA = "0x185AA9C70")]
	public JNFABEMDBKM(List<BOFPBLEJOJE> JKJOOAPPNGF, List<BOFPBLEJOJE> MKGIEMCALKP, List<MIGBADIBIAF> GHHDJKNJEAG, Material JEFIMPHCKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5AA97B0", Offset = "0x5AA87B0", VA = "0x185AA97B0")]
	private int DOMLGLLFHGK(List<BOFPBLEJOJE> AJDLIKALKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5AA9A30", Offset = "0x5AA8A30", VA = "0x185AA9A30")]
	private void IEGOMNLAFCO(int BNCLGNANHBL, bool JHLBHCGIPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5AA9BD0", Offset = "0x5AA8BD0", VA = "0x185AA9BD0")]
	public void PBLDAHBCDEO(Vector3 HPDANHIBONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5AA98C0", Offset = "0x5AA88C0", VA = "0x185AA98C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5AA99F0", Offset = "0x5AA89F0", VA = "0x185AA99F0")]
	public void GGFHMFICPPB(Transform BGPJGKOIIBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LMCJDLDLPKC : MKFANOBNAGF, KBOMDIINLKJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JADJDIILLNP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LMCJDLDLPKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
		[DebuggerHidden]
		public JADJDIILLNP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9490", Offset = "0x5AA8490", VA = "0x185AA9490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5AA8F60", Offset = "0x5AA7F60", VA = "0x185AA8F60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9590", Offset = "0x5AA8590", VA = "0x185AA9590")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5AA95E0", Offset = "0x5AA85E0", VA = "0x185AA95E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9630", Offset = "0x5AA8630", VA = "0x185AA9630")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9450", Offset = "0x5AA8450", VA = "0x185AA9450", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5AA93B0", Offset = "0x5AA83B0", VA = "0x185AA93B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5AA93B0", Offset = "0x5AA83B0", VA = "0x185AA93B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CNDFGIMENOA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public LMCJDLDLPKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
		[DebuggerHidden]
		public CNDFGIMENOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5AA5910", Offset = "0x5AA4910", VA = "0x185AA5910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5AA5550", Offset = "0x5AA4550", VA = "0x185AA5550", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5AA59F0", Offset = "0x5AA49F0", VA = "0x185AA59F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5AA5A40", Offset = "0x5AA4A40", VA = "0x185AA5A40")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5AA58D0", Offset = "0x5AA48D0", VA = "0x185AA58D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5AA5830", Offset = "0x5AA4830", VA = "0x185AA5830", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5AA5830", Offset = "0x5AA4830", VA = "0x185AA5830", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CKLCCACIGLJ NCMKCMNFKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<HJPMBAKCFLC> NCDCHLBMMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> IGDIBHNMMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer IICPPDPFGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool KOELALJMCOA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<CAGDEPIFEPM> DOIMDFKOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LPDMFEGNNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE5F0", Offset = "0x5AAD5F0", VA = "0x185AAE5F0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MIGBADIBIAF HPCCHIHGIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE440", Offset = "0x5AAD440", VA = "0x185AAE440", Slot = "7")]
		get
		{
			return default(MIGBADIBIAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> NIMOIOPDMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x651590", Offset = "0x650590", VA = "0x180651590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5AAEC30", Offset = "0x5AADC30", VA = "0x185AAEC30")]
	public LMCJDLDLPKC(CKLCCACIGLJ PJDKPCLOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5AADB80", Offset = "0x5AACB80", VA = "0x185AADB80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5AADA70", Offset = "0x5AACA70", VA = "0x185AADA70")]
	public void CEMPCIEDPMO(HJPMBAKCFLC AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5AADA00", Offset = "0x5AACA00", VA = "0x185AADA00")]
	public void ADDEDGCCJIP(HJPMBAKCFLC AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE630", Offset = "0x5AAD630", VA = "0x185AAE630", Slot = "4")]
	public void OOEIEIMDGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE210", Offset = "0x5AAD210", VA = "0x185AAE210")]
	public void FMPDGFOLIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE2C0", Offset = "0x5AAD2C0", VA = "0x185AAE2C0")]
	private void JDPIBJDCBBD(List<HJPMBAKCFLC> NCDCHLBMMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE510", Offset = "0x5AAD510", VA = "0x185AAE510")]
	private static Material MLLDHODALFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE3F0", Offset = "0x5AAD3F0", VA = "0x185AAE3F0")]
	private void JDPIBJDCBBD(HJPMBAKCFLC AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5AADC20", Offset = "0x5AACC20", VA = "0x185AADC20")]
	private void EKDLAHMEMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5AADCF0", Offset = "0x5AACCF0", VA = "0x185AADCF0")]
	public void FKGNPOPEOJA(bool CLCEJCPPEDH, bool FOCKNBGPLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5AAEBA0", Offset = "0x5AADBA0", VA = "0x185AAEBA0")]
	protected void PNPHKNNJKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE580", Offset = "0x5AAD580", VA = "0x185AAE580")]
	[IteratorStateMachine(typeof(JADJDIILLNP))]
	public IEnumerable<Renderer> NCMFHJJEEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5AADBB0", Offset = "0x5AACBB0", VA = "0x185AADBB0")]
	[IteratorStateMachine(typeof(CNDFGIMENOA))]
	public IEnumerable<Renderer> EFAMKOHCPGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class HHJFODPOHKG : HJPMBAKCFLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly MGLCHLAIBHL PNKLFHJJPCN;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5AA7E90", Offset = "0x5AA6E90", VA = "0x185AA7E90")]
	public HHJFODPOHKG(LMCJDLDLPKC ODPHCGBINJN, MGLCHLAIBHL PJDKPCLOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5AA73E0", Offset = "0x5AA63E0", VA = "0x185AA73E0", Slot = "13")]
	public override int DOMLGLLFHGK(HGOHMCPPGIC NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5AA7CA0", Offset = "0x5AA6CA0", VA = "0x185AA7CA0", Slot = "14")]
	public override int PJNKAIPMEMD(HGOHMCPPGIC NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5AA75D0", Offset = "0x5AA65D0", VA = "0x185AA75D0", Slot = "15")]
	public override void ODFBJBIPPIB(HGOHMCPPGIC NIBPPJFAFOD, BDONICIEFBH IBKCDPMDABE, int FMGCEGANPOH = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BMMPNIEBPDA : global::KIMFBICNHMN<BMMPNIEBPDA>, EKJNBJHBEDB, IEquatable<BMMPNIEBPDA>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DCEMEBHPCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD90", Offset = "0x6FAD90", VA = "0x1806FBD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8A3600", Offset = "0x8A2600", VA = "0x1808A3600", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xE9D080", Offset = "0xE9C080", VA = "0x180E9D080", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5AA4120", Offset = "0x5AA3120", VA = "0x185AA4120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x27D30E0", Offset = "0x27D20E0", VA = "0x1827D30E0", Slot = "8")]
	public bool Equals(BMMPNIEBPDA IIKMMJKCGDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xDAA9E0", Offset = "0xDA99E0", VA = "0x180DAA9E0")]
	public static bool CGFEPDNGNBJ(BMMPNIEBPDA DOGOAAONBOH, BMMPNIEBPDA ENHIJCCJFBF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4780D40", Offset = "0x477FD40", VA = "0x184780D40")]
	public static bool NODBGCCFDAJ(BMMPNIEBPDA DOGOAAONBOH, BMMPNIEBPDA ENHIJCCJFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5AA4090", Offset = "0x5AA3090", VA = "0x185AA4090", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum PIDFEGHGOMO
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CKLCCACIGLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MIGBADIBIAF IFBDJBLKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PIDFEGHGOMO NKADBAMJMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CNAHBICJLLK : global::KIMFBICNHMN<CNAHBICJLLK>, EKJNBJHBEDB, IEquatable<CNAHBICJLLK>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int DCEMEBHPCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD90", Offset = "0x6FAD90", VA = "0x1806FBD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8A3600", Offset = "0x8A2600", VA = "0x1808A3600", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xE9D080", Offset = "0xE9C080", VA = "0x180E9D080", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5AA5510", Offset = "0x5AA4510", VA = "0x185AA5510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27D30E0", Offset = "0x27D20E0", VA = "0x1827D30E0", Slot = "8")]
	public bool Equals(CNAHBICJLLK IIKMMJKCGDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xDAA9E0", Offset = "0xDA99E0", VA = "0x180DAA9E0")]
	public static bool CGFEPDNGNBJ(CNAHBICJLLK DOGOAAONBOH, CNAHBICJLLK ENHIJCCJFBF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4780D40", Offset = "0x477FD40", VA = "0x184780D40")]
	public static bool NODBGCCFDAJ(CNAHBICJLLK DOGOAAONBOH, CNAHBICJLLK ENHIJCCJFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5AA5480", Offset = "0x5AA4480", VA = "0x185AA5480", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GIEGBDNGMOL
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	MIGBADIBIAF IFBDJBLKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float IBPAPDNHADJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 EMLHJCICDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	EPNOHFDGCOL PFGODCCILNO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	BLEOLAGNKMP FDNPBAENAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JCDOCGODEBF : GIEGBDNGMOL
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NNBFKGAONKD FOAPEOAEAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KMFJGNHHJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MGLCHLAIBHL : GIEGBDNGMOL
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool KHJFFGEGNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool HLPPOIIJHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float FDCOFEFDCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int LPJPPGDMHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool FPFDMIHCDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int GIBOBAABBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CINDOAHODGI> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OLFAGFAJFEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFIKNENDIBO(BMMPNIEBPDA ODPHCGBINJN, HGAOGFEBOPA ANEHEIPNCFA);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFIKNENDIBO(CNAHBICJLLK AJNFAJJPNHD, HGAOGFEBOPA ANEHEIPNCFA);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHNKDAOKFOE(CNAHBICJLLK AJNFAJJPNHD);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DADPFBFNKLH(CNAHBICJLLK AJNFAJJPNHD);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGOJOMJLOIN();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFFPOPCKNKN();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCMPGCCIDPI(HGAOGFEBOPA BCFKLEGAMEO);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PIAHDMEDAOJ(BMMPNIEBPDA ODPHCGBINJN);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PIAHDMEDAOJ(CNAHBICJLLK AJNFAJJPNHD);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EFKMIPKCLGF(BMMPNIEBPDA ODPHCGBINJN, FPMCIIECIFB BCFKLEGAMEO);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EFKMIPKCLGF(CNAHBICJLLK AJNFAJJPNHD, FPMCIIECIFB BCFKLEGAMEO);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MEPGDEDHNJO(CNAHBICJLLK AJNFAJJPNHD);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HKEHFHACMEB(CNAHBICJLLK AJNFAJJPNHD);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HDEGJOEPHAL();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NEFDEFJKCBE();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GEHMALDEAIL(FPMCIIECIFB BCFKLEGAMEO);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ADJBEOMBGJL(BMMPNIEBPDA ODPHCGBINJN, Vector3 AOCDHNKBEDD, Vector3 EOPLODOIDBP, Vector3 OHMHCFCFKKI, float BNFHNHLPMCA, float CPJNAJOJGLH, IReadOnlyList<Camera> LBAAPLBMJKJ, PMJFIBNNDOA DFGDBNLIMGG);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ADJBEOMBGJL(JLEKGEOPPIA KINOAOICMON, Vector3 AOCDHNKBEDD, Vector3 EOPLODOIDBP, Vector3 OHMHCFCFKKI, float BNFHNHLPMCA, float CPJNAJOJGLH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KHKMJGFHGJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMMPNIEBPDA FFFEHHGDBOP(CKLCCACIGLJ PJDKPCLOECB);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPLAACDOFAP(BMMPNIEBPDA ODPHCGBINJN);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBCHALMMBIG(BMMPNIEBPDA ODPHCGBINJN);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CNAHBICJLLK ADLMAENNKAF(BMMPNIEBPDA ODPHCGBINJN, JCDOCGODEBF PJDKPCLOECB);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CNAHBICJLLK OGBNLBOBJDM(BMMPNIEBPDA ODPHCGBINJN, MGLCHLAIBHL PJDKPCLOECB);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MENNLBPDMIE(CNAHBICJLLK AJNFAJJPNHD);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFHEIPJKFAP(CNAHBICJLLK AJNFAJJPNHD);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JLEKGEOPPIA FKBCLFLLAAH(DCGKFHIMCMJ PJDKPCLOECB);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KDNKELCDNJL(JLEKGEOPPIA KINOAOICMON);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FFMDGHLFJHE(JLEKGEOPPIA KINOAOICMON);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KNENKBEOOCP HNNHLEOAGGB(MIGBADIBIAF EDMDBIOONNN, IEnumerable<CNAHBICJLLK> NCDCHLBMMDM, int DJBDAHBOIBM);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> AAJJCDJAOHD(BMMPNIEBPDA ODPHCGBINJN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JLEKGEOPPIA : global::KIMFBICNHMN<JLEKGEOPPIA>, EKJNBJHBEDB, IEquatable<JLEKGEOPPIA>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int DCEMEBHPCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD90", Offset = "0x6FAD90", VA = "0x1806FBD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A3600", Offset = "0x8A2600", VA = "0x1808A3600", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xE9D080", Offset = "0xE9C080", VA = "0x180E9D080", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9710", Offset = "0x5AA8710", VA = "0x185AA9710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x27D30E0", Offset = "0x27D20E0", VA = "0x1827D30E0", Slot = "8")]
	public bool Equals(JLEKGEOPPIA IIKMMJKCGDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xDAA9E0", Offset = "0xDA99E0", VA = "0x180DAA9E0")]
	public static bool CGFEPDNGNBJ(JLEKGEOPPIA DOGOAAONBOH, JLEKGEOPPIA ENHIJCCJFBF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4780D40", Offset = "0x477FD40", VA = "0x184780D40")]
	public static bool NODBGCCFDAJ(JLEKGEOPPIA DOGOAAONBOH, JLEKGEOPPIA ENHIJCCJFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5AA9680", Offset = "0x5AA8680", VA = "0x185AA9680", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DCGKFHIMCMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int NJNDDGMCMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform JHBELHOLKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool GONLBGHNOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMMPNIEBPDA GetBone(int DEPOLIAIKKN);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int DEPOLIAIKKN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class PNEIMKJLCBO : HJPMBAKCFLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly JCDOCGODEBF JHINCDJPNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] EIAGLNJKBHD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override JKMLMPELMBA FCNNFGLCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0050", Offset = "0x5AAF050", VA = "0x185AB0050", Slot = "12")]
		get
		{
			return default(JKMLMPELMBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 PCOPLFKNOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5AAEF80", Offset = "0x5AADF80", VA = "0x185AAEF80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5AA7E90", Offset = "0x5AA6E90", VA = "0x185AA7E90")]
	public PNEIMKJLCBO(LMCJDLDLPKC ODPHCGBINJN, JCDOCGODEBF PJDKPCLOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF370", Offset = "0x5AAE370", VA = "0x185AAF370", Slot = "11")]
	public override bool MJHFFEDDGML(MIGBADIBIAF ODPHCGBINJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF2C0", Offset = "0x5AAE2C0", VA = "0x185AAF2C0", Slot = "13")]
	public override int DOMLGLLFHGK(HGOHMCPPGIC NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5AB0400", Offset = "0x5AAF400", VA = "0x185AB0400", Slot = "14")]
	public override int PJNKAIPMEMD(HGOHMCPPGIC NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5AAECD0", Offset = "0x5AADCD0", VA = "0x185AAECD0")]
	private int BBBOMEBBIIO(HGOHMCPPGIC NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF7E0", Offset = "0x5AAE7E0", VA = "0x185AAF7E0", Slot = "15")]
	public override void ODFBJBIPPIB(HGOHMCPPGIC NIBPPJFAFOD, BDONICIEFBH IBKCDPMDABE, int FMGCEGANPOH = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CCELDGOJHCI
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJCCBGAAHKI(FPMCIIECIFB BCFKLEGAMEO, Renderer NGCNIFIJPHL, int NKKDLKBMJOL);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEFDDJINECO(Renderer NGCNIFIJPHL, PMJFIBNNDOA DFGDBNLIMGG, Vector3 AOCDHNKBEDD, Vector3 EOPLODOIDBP, Vector3 OHMHCFCFKKI, float BNFHNHLPMCA, float CPJNAJOJGLH, float BNGOPHEGJBL = -1f, [Optional] Color? NNPLNBENDGM, [Optional] IReadOnlyList<Camera> ONEKIGIBGAD);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PADBLMMOLHF(Renderer NGCNIFIJPHL, int NKKDLKBMJOL);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FICCBLEIIMJ();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLCDPIPGDDH(int HJOCPJDENKK, HGAOGFEBOPA BCFKLEGAMEO, Renderer NGCNIFIJPHL, int NKKDLKBMJOL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KGHBEOOGEJE : OLFAGFAJFEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class KBJHHEKJDDE : global::KNIFPDNOBKD<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5AAA030", Offset = "0x5AA9030", VA = "0x185AAA030")]
		public KBJHHEKJDDE(string FOGNBJMCDMG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly CCELDGOJHCI LHOPEBCGPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly GGIDACDCDCA AGAPGEHFOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer KILGBDOGMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private KBJHHEKJDDE AJOBPCHCOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool OAMMBLEGBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer EEEOIOCILHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private KBJHHEKJDDE GDPDILGBNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool INCFBAIDPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer MPNLCCHJFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private KBJHHEKJDDE DFMIPCMGBEC;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x64A6E0", Offset = "0x6496E0", VA = "0x18064A6E0")]
	public KGHBEOOGEJE(CCELDGOJHCI INBNHLIGFGE, GGIDACDCDCA AGAPGEHFOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5AAAA70", Offset = "0x5AA9A70", VA = "0x185AAAA70", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB250", Offset = "0x5AAA250", VA = "0x185AAB250")]
	private void EJLHDFGEJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5AABA30", Offset = "0x5AAAA30", VA = "0x185AABA30", Slot = "4")]
	public void OFIKNENDIBO(BMMPNIEBPDA ODPHCGBINJN, HGAOGFEBOPA ANEHEIPNCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5AABC30", Offset = "0x5AAAC30", VA = "0x185AABC30", Slot = "5")]
	public void OFIKNENDIBO(CNAHBICJLLK AJNFAJJPNHD, HGAOGFEBOPA ANEHEIPNCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB620", Offset = "0x5AAA620", VA = "0x185AAB620", Slot = "6")]
	public void IHNKDAOKFOE(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA820", Offset = "0x5AA9820", VA = "0x185AAA820", Slot = "7")]
	public void DADPFBFNKLH(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB9F0", Offset = "0x5AAA9F0", VA = "0x185AAB9F0", Slot = "8")]
	public void MGOJOMJLOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x19011B0", Offset = "0x19001B0", VA = "0x1819011B0", Slot = "9")]
	public void LFFPOPCKNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA940", Offset = "0x5AA9940", VA = "0x185AAA940", Slot = "10")]
	public void DCMPGCCIDPI(HGAOGFEBOPA ANEHEIPNCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5AABE10", Offset = "0x5AAAE10", VA = "0x185AABE10", Slot = "11")]
	public void PIAHDMEDAOJ(BMMPNIEBPDA ODPHCGBINJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5AABFC0", Offset = "0x5AAAFC0", VA = "0x185AABFC0", Slot = "12")]
	public void PIAHDMEDAOJ(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5AAAC40", Offset = "0x5AA9C40", VA = "0x185AAAC40", Slot = "13")]
	public void EFKMIPKCLGF(BMMPNIEBPDA ODPHCGBINJN, FPMCIIECIFB BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5AAAFC0", Offset = "0x5AA9FC0", VA = "0x185AAAFC0", Slot = "14")]
	public void EFKMIPKCLGF(CNAHBICJLLK AJNFAJJPNHD, FPMCIIECIFB BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB550", Offset = "0x5AAA550", VA = "0x185AAB550", Slot = "17")]
	public void HDEGJOEPHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB950", Offset = "0x5AAA950", VA = "0x185AAB950", Slot = "15")]
	public void MEPGDEDHNJO(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB590", Offset = "0x5AAA590", VA = "0x185AAB590", Slot = "16")]
	public void HKEHFHACMEB(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1180120", Offset = "0x117F120", VA = "0x181180120", Slot = "18")]
	public void NEFDEFJKCBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB450", Offset = "0x5AAA450", VA = "0x185AAB450", Slot = "19")]
	public void GEHMALDEAIL(FPMCIIECIFB BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB750", Offset = "0x5AAA750", VA = "0x185AAB750")]
	private void LAMEEOEJDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5AAAE00", Offset = "0x5AA9E00", VA = "0x185AAAE00")]
	public void EFKMIPKCLGF(CNAHBICJLLK AJNFAJJPNHD, FPMCIIECIFB BCFKLEGAMEO, bool KLCPMMKPGNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB180", Offset = "0x5AAA180", VA = "0x185AAB180")]
	private void EJCCBGAAHKI(FPMCIIECIFB BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA080", Offset = "0x5AA9080", VA = "0x185AAA080", Slot = "20")]
	public void ADJBEOMBGJL(BMMPNIEBPDA ODPHCGBINJN, Vector3 AOCDHNKBEDD, Vector3 EOPLODOIDBP, Vector3 OHMHCFCFKKI, float BNFHNHLPMCA, float CPJNAJOJGLH, IReadOnlyList<Camera> LBAAPLBMJKJ, PMJFIBNNDOA DFGDBNLIMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA400", Offset = "0x5AA9400", VA = "0x185AAA400", Slot = "21")]
	public void ADJBEOMBGJL(JLEKGEOPPIA KINOAOICMON, Vector3 AOCDHNKBEDD, Vector3 EOPLODOIDBP, Vector3 OHMHCFCFKKI, float BNFHNHLPMCA, float CPJNAJOJGLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class HJPMBAKCFLC : OHPPPEKACDH, CAGDEPIFEPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly LMCJDLDLPKC MDILBPOCOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	protected Bounds HLABCHLIAJC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds ICBGGBJMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1192C20", Offset = "0x1191C20", VA = "0x181192C20", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual JKMLMPELMBA FCNNFGLCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5AA7F50", Offset = "0x5AA6F50", VA = "0x185AA7F50", Slot = "12")]
		get
		{
			return default(JKMLMPELMBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
	protected HJPMBAKCFLC(LMCJDLDLPKC ODPHCGBINJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5AA7EE0", Offset = "0x5AA6EE0", VA = "0x185AA7EE0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "11")]
	public virtual bool MJHFFEDDGML(MIGBADIBIAF ODPHCGBINJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int DOMLGLLFHGK(HGOHMCPPGIC NIBPPJFAFOD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int PJNKAIPMEMD(HGOHMCPPGIC NIBPPJFAFOD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void ODFBJBIPPIB(HGOHMCPPGIC NIBPPJFAFOD, BDONICIEFBH IBKCDPMDABE, int FMGCEGANPOH = -1);
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5AB04B0", Offset = "0x5AAF4B0", VA = "0x185AB04B0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NNBFKGAONKD
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class HOAKKLDFNFP
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HCFOGKHGNMI : IEnumerable<CFKIBOGOLPJ>, IEnumerable, IEnumerator<CFKIBOGOLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private CFKIBOGOLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private CFKIBOGOLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
		[DebuggerHidden]
		public HCFOGKHGNMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5AA7230", Offset = "0x5AA6230", VA = "0x185AA7230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5AA73A0", Offset = "0x5AA63A0", VA = "0x185AA73A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5AA7310", Offset = "0x5AA6310", VA = "0x185AA7310", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CFKIBOGOLPJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5AA7310", Offset = "0x5AA6310", VA = "0x185AA7310", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int MOGKEBDHEGN = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static CFKIBOGOLPJ[][] JGELNKMFMJH;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static APACEBGDDEO IPIGKHHKHJB;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static ShapeRendererConfig HIKDCJMBMEK;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader CPPMHKNELFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5AA8E50", Offset = "0x5AA7E50", VA = "0x185AA8E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer HAEOFCHMCOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5AA84E0", Offset = "0x5AA74E0", VA = "0x185AA84E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8040", Offset = "0x5AA7040", VA = "0x185AA8040")]
	public static Mesh AFGLILLCKGM(NNBFKGAONKD BOCLIGKIMNJ, int NIBPPJFAFOD = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8AE0", Offset = "0x5AA7AE0", VA = "0x185AA8AE0")]
	public static int NHDDIBCCCLK(NNBFKGAONKD BOCLIGKIMNJ, int NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5AA87D0", Offset = "0x5AA77D0", VA = "0x185AA87D0")]
	public static APACEBGDDEO GJKIJOABLIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7550", VA = "0x185AA8550")]
	[IteratorStateMachine(typeof(HCFOGKHGNMI))]
	private static IEnumerable<CFKIBOGOLPJ> FGFBOAMIOEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8AF0", Offset = "0x5AA7AF0", VA = "0x185AA8AF0")]
	public static CFKIBOGOLPJ OOODDCNNDIJ(NNBFKGAONKD BOCLIGKIMNJ, int NIBPPJFAFOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5AA84C0", Offset = "0x5AA74C0", VA = "0x185AA84C0")]
	public static bool DLEBFKPJKNI(this NNBFKGAONKD BOCLIGKIMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8930", Offset = "0x5AA7930", VA = "0x185AA8930")]
	public static void MOMIPGILBOF(NNBFKGAONKD BOCLIGKIMNJ, float3 MGMGKPEOKFB, out OBKLDODKGFO IDHKJKLPGOF, out float3 PFMHFPLNMLE, out float JNEBMCCOOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8100", Offset = "0x5AA7100", VA = "0x185AA8100")]
	public static void BFOFMGNKGLF(Vector3 MGMGKPEOKFB, NNBFKGAONKD BOCLIGKIMNJ, out Vector3 PFMHFPLNMLE, out float JNEBMCCOOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5AA84B0", Offset = "0x5AA74B0", VA = "0x185AA84B0")]
	[DDDKNIGBKHH(ODNNAFCJNAG.ExitingPlayMode, 0)]
	private static void DBAEKKKCLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5AA85B0", Offset = "0x5AA75B0", VA = "0x185AA85B0")]
	[DDDKNIGBKHH(ODNNAFCJNAG.ExitingPlayMode, 0)]
	private static void GFKCFADMKGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CKOHODFFJEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool HKDPBOOHHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material BBHMHPNIPFA();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MLLDHODALFB();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material GEHNNMCKDAK();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PPIMKGHOMOG(EPNOHFDGCOL OJFKKGMGOLE);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LMNPHJJKONG(BLEOLAGNKMP COPGKFGPGFI);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FNLFDODGOAP(GameObject ODMJCJPGHNI);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NBNMICHIBDC(GameObject ODMJCJPGHNI, bool HOJGCMGNPFC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface GGIDACDCDCA
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LMCJDLDLPKC ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HJPMBAKCFLC ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	DCLMIPOILPM ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class LBEDMLKMBAA : KHKMJGFHGJH, IDisposable, GGIDACDCDCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly global::PCNAFPCNLFL<BMMPNIEBPDA, LMCJDLDLPKC> ICJECGKDAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly global::PCNAFPCNLFL<CNAHBICJLLK, HJPMBAKCFLC> NCDCHLBMMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly global::PCNAFPCNLFL<JLEKGEOPPIA, DCLMIPOILPM> ICMGGKCFIKD;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static CKOHODFFJEJ IKDPCKPCIGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC840", Offset = "0x5AAB840", VA = "0x185AAC840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC880", Offset = "0x5AAB880", VA = "0x185AAC880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public LMCJDLDLPKC ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5AAD280", Offset = "0x5AAC280", VA = "0x185AAD280", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public HJPMBAKCFLC ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5AAD220", Offset = "0x5AAC220", VA = "0x185AAD220", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DCLMIPOILPM ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5AAD2E0", Offset = "0x5AAC2E0", VA = "0x185AAD2E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD4B0", Offset = "0x5AAC4B0", VA = "0x185AAD4B0")]
	public LBEDMLKMBAA(CKOHODFFJEJ INBNHLIGFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC8D0", Offset = "0x5AAB8D0", VA = "0x185AAC8D0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC960", Offset = "0x5AAB960", VA = "0x185AAC960", Slot = "4")]
	public BMMPNIEBPDA FFFEHHGDBOP(CKLCCACIGLJ PJDKPCLOECB)
	{
		return default(BMMPNIEBPDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD1C0", Offset = "0x5AAC1C0", VA = "0x185AAD1C0", Slot = "5")]
	public void KPLAACDOFAP(BMMPNIEBPDA ODPHCGBINJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD070", Offset = "0x5AAC070", VA = "0x185AAD070", Slot = "6")]
	public void KBCHALMMBIG(BMMPNIEBPDA ODPHCGBINJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC670", Offset = "0x5AAB670", VA = "0x185AAC670", Slot = "15")]
	public IEnumerable<Renderer> AAJJCDJAOHD(BMMPNIEBPDA ODPHCGBINJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC730", Offset = "0x5AAB730", VA = "0x185AAC730", Slot = "7")]
	public CNAHBICJLLK ADLMAENNKAF(BMMPNIEBPDA ODPHCGBINJN, JCDOCGODEBF PJDKPCLOECB)
	{
		return default(CNAHBICJLLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD3A0", Offset = "0x5AAC3A0", VA = "0x185AAD3A0", Slot = "8")]
	public CNAHBICJLLK OGBNLBOBJDM(BMMPNIEBPDA ODPHCGBINJN, MGLCHLAIBHL PJDKPCLOECB)
	{
		return default(CNAHBICJLLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD150", Offset = "0x5AAC150", VA = "0x185AAD150", Slot = "10")]
	public void KFHEIPJKFAP(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD340", Offset = "0x5AAC340", VA = "0x185AAD340", Slot = "9")]
	public void MENNLBPDMIE(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5AACAD0", Offset = "0x5AABAD0", VA = "0x185AACAD0", Slot = "11")]
	public JLEKGEOPPIA FKBCLFLLAAH(DCGKFHIMCMJ PJDKPCLOECB)
	{
		return default(JLEKGEOPPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5AACA60", Offset = "0x5AABA60", VA = "0x185AACA60", Slot = "13")]
	public void FFMDGHLFJHE(JLEKGEOPPIA KINOAOICMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD0F0", Offset = "0x5AAC0F0", VA = "0x185AAD0F0", Slot = "12")]
	public void KDNKELCDNJL(JLEKGEOPPIA KINOAOICMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5AACC70", Offset = "0x5AABC70", VA = "0x185AACC70", Slot = "14")]
	public KNENKBEOOCP HNNHLEOAGGB(MIGBADIBIAF EDMDBIOONNN, IEnumerable<CNAHBICJLLK> NCDCHLBMMDM, int DJBDAHBOIBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DCLMIPOILPM : MKFANOBNAGF
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KMBJNDPODPF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public DCLMIPOILPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
		[DebuggerHidden]
		public KMBJNDPODPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC5A0", Offset = "0x5AAB5A0", VA = "0x185AAC5A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC2C0", Offset = "0x5AAB2C0", VA = "0x185AAC2C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC620", Offset = "0x5AAB620", VA = "0x185AAC620")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC560", Offset = "0x5AAB560", VA = "0x185AAC560", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC4C0", Offset = "0x5AAB4C0", VA = "0x185AAC4C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC4C0", Offset = "0x5AAB4C0", VA = "0x185AAC4C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly DCGKFHIMCMJ IKNLCNGAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly GGIDACDCDCA AGAPGEHFOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private JNFABEMDBKM GGNKNNLHJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private List<BOFPBLEJOJE> HJBEGPHJDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private List<BOFPBLEJOJE> LJGFDAICGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private GameObject HDIENEEJHBN;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5AA5CD0", Offset = "0x5AA4CD0", VA = "0x185AA5CD0")]
	public static DCLMIPOILPM JCJIJDLCOKP(DCGKFHIMCMJ PJDKPCLOECB, GGIDACDCDCA AGAPGEHFOID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5AA6F50", Offset = "0x5AA5F50", VA = "0x185AA6F50")]
	private DCLMIPOILPM(DCGKFHIMCMJ PJDKPCLOECB, GGIDACDCDCA AGAPGEHFOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5AA6A70", Offset = "0x5AA5A70", VA = "0x185AA6A70")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5AA5EE0", Offset = "0x5AA4EE0", VA = "0x185AA5EE0")]
	[IteratorStateMachine(typeof(KMBJNDPODPF))]
	public IEnumerable<Renderer> NCMFHJJEEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5AA5F50", Offset = "0x5AA4F50", VA = "0x185AA5F50", Slot = "4")]
	public void OOEIEIMDGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5AA5E40", Offset = "0x5AA4E40", VA = "0x185AA5E40")]
	private void MJGNCBINOAP(Vector3 HPDANHIBONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5AA5A90", Offset = "0x5AA4A90", VA = "0x185AA5A90")]
	public void FMPDGFOLIAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BOFPBLEJOJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct IJHPEMCDNKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public BDONICIEFBH PEAIIEOLEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public MIGBADIBIAF GIHAIAEEPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int GJKHMACDDOK;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DHEBODIIGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public BOFPBLEJOJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public HGOHMCPPGIC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public List<IJHPEMCDNKP> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public KNENKBEOOCP combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public DHEBODIIGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5AA7050", Offset = "0x5AA6050", VA = "0x185AA7050")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5AA70B0", Offset = "0x5AA60B0", VA = "0x185AA70B0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5AA70E0", Offset = "0x5AA60E0", VA = "0x185AA70E0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private int[] CKNHFAMBOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private JONBCCFHAHM LLHEFODANKG;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static Matrix4x4 AADPOMIBHCL;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh GGKLCMKFFOF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x66A130", Offset = "0x669130", VA = "0x18066A130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int PGPEFLGJBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x64BBD0", Offset = "0x64ABD0", VA = "0x18064BBD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE410", Offset = "0x6ED410", VA = "0x1806EE410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5AA45D0", Offset = "0x5AA35D0", VA = "0x185AA45D0")]
	public void EECFCHEEHFB(List<MIGBADIBIAF> LKIMFBECIDI, Matrix4x4[] GKNCEIFDDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5AA4910", Offset = "0x5AA3910", VA = "0x185AA4910")]
	public static List<BOFPBLEJOJE> MFNJFAEBAIM(List<LMCJDLDLPKC> OJOBEEEOCEK, HGOHMCPPGIC NIBPPJFAFOD, Bounds ANAGHLFLMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5AA41F0", Offset = "0x5AA31F0", VA = "0x185AA41F0")]
	private JobHandle ECGCHBHOOPN(KNENKBEOOCP NOAJKDENLLH, int DJNKKLGGELH, int JHGCFEHDLOG, HGOHMCPPGIC NIBPPJFAFOD, List<IJHPEMCDNKP> KLDAKEGPCPN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5AA4800", Offset = "0x5AA3800", VA = "0x185AA4800")]
	private void KAFJBOJCPPN(List<IJHPEMCDNKP> KLDAKEGPCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5AA5070", Offset = "0x5AA4070", VA = "0x185AA5070")]
	private BOFPBLEJOJE(List<IJHPEMCDNKP> KLDAKEGPCPN, int DJNKKLGGELH, int JHGCFEHDLOG, HGOHMCPPGIC NIBPPJFAFOD, Bounds ANAGHLFLMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5AA4160", Offset = "0x5AA3160", VA = "0x185AA4160", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private MaterialPropertyBlock OIKPLKBCHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private BOFPBLEJOJE CNEBPEILFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private List<MIGBADIBIAF> GHHDJKNJEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private RenderTexture MHLPPOGJGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private ComputeBuffer CNICBCMJKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private ComputeShader KJOKBKAGICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private Matrix4x4[] CNPMHHMHPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int NHKJGPEIJNC;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer NDFCDPPDMMC
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x66A140", Offset = "0x669140", VA = "0x18066A140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int NJNDDGMCMKE
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x5AB1170", Offset = "0x5AB0170", VA = "0x185AB1170")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB04E0", Offset = "0x5AAF4E0", VA = "0x185AB04E0")]
		public static List<SkinnedShapeRenderer> Create(GameObject ODPHCGBINJN, List<BOFPBLEJOJE> AJDLIKALKDK, List<MIGBADIBIAF> GHHDJKNJEAG, Material JEFIMPHCKGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0B20", Offset = "0x5AAFB20", VA = "0x185AB0B20")]
		public void Init(BOFPBLEJOJE CNEBPEILFJE, List<MIGBADIBIAF> GHHDJKNJEAG, Material JEFIMPHCKGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB10C0", Offset = "0x5AB00C0", VA = "0x185AB10C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1010", Offset = "0x5AB0010", VA = "0x185AB1010")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0FD0", Offset = "0x5AAFFD0", VA = "0x185AB0FD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5AB08F0", Offset = "0x5AAF8F0", VA = "0x185AB08F0")]
		private void FIPNBFLLPHA(ScriptableRenderContext IGBOEABBEHO, Camera[] COMGFKKAPJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0730", Offset = "0x5AAF730", VA = "0x185AB0730")]
		private void EECFCHEEHFB(CommandBuffer BLIGGPEEFME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5AA3A60", Offset = "0x5AA2A60", VA = "0x185AA3A60")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5AA3B70", Offset = "0x5AA2B70", VA = "0x185AA3B70")]
	public static string NNIAAAJCFNJ(byte[] CDDAIIMDJCN, bool FNAKCEJPGOO)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
