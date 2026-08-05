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
	[Cpp2IlInjected.Address(RVA = "0x5B82A10", Offset = "0x5B81210", VA = "0x185B82A10")]
	public static bool MENBAJAIJLE(this EPNOHFDGCOL OJFKKGMGOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B829D0", Offset = "0x5B811D0", VA = "0x185B829D0")]
	public static bool BBPIBGJKEPF(this EPNOHFDGCOL OJFKKGMGOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5B829E0", Offset = "0x5B811E0", VA = "0x185B829E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F4C80", Offset = "0x6F3480", VA = "0x1806F4C80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F50B0", Offset = "0x6F38B0", VA = "0x1806F50B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JBDMDMAIABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F9700", Offset = "0x6F7F00", VA = "0x1806F9700", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B90", Offset = "0x6F8390", VA = "0x1806F9B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float DOHKCICGDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F7070", Offset = "0x6F5870", VA = "0x1806F7070", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F7080", Offset = "0x6F5880", VA = "0x1806F7080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float BIENIJPBOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAF2DE0", Offset = "0xAF15E0", VA = "0x180AF2DE0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAF2E00", Offset = "0xAF1600", VA = "0x180AF2E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> KNCOMLCFOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B84140", Offset = "0x5B82940", VA = "0x185B84140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> INKFOIILJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A900", Offset = "0x1C29100", VA = "0x181C2A900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject MDILBPOCOND
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B40", Offset = "0x6F4340", VA = "0x1806F5B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A70", Offset = "0x6F4270", VA = "0x1806F5A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte OKNCMHMAPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5B84570", Offset = "0x5B82D70", VA = "0x185B84570", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5B84660", Offset = "0x5B82E60", VA = "0x185B84660")]
	public JNFABEMDBKM(List<BOFPBLEJOJE> JKJOOAPPNGF, List<BOFPBLEJOJE> MKGIEMCALKP, List<MIGBADIBIAF> GHHDJKNJEAG, Material JEFIMPHCKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B841A0", Offset = "0x5B829A0", VA = "0x185B841A0")]
	private int DOMLGLLFHGK(List<BOFPBLEJOJE> AJDLIKALKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B84420", Offset = "0x5B82C20", VA = "0x185B84420")]
	private void IEGOMNLAFCO(int BNCLGNANHBL, bool JHLBHCGIPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B845C0", Offset = "0x5B82DC0", VA = "0x185B845C0")]
	public void PBLDAHBCDEO(Vector3 HPDANHIBONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B842B0", Offset = "0x5B82AB0", VA = "0x185B842B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B843E0", Offset = "0x5B82BE0", VA = "0x185B843E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F54B0", Offset = "0x7F3CB0", VA = "0x1807F54B0")]
		[DebuggerHidden]
		public JADJDIILLNP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5B83E80", Offset = "0x5B82680", VA = "0x185B83E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5B83950", Offset = "0x5B82150", VA = "0x185B83950", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B83F80", Offset = "0x5B82780", VA = "0x185B83F80")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5B83FD0", Offset = "0x5B827D0", VA = "0x185B83FD0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B84020", Offset = "0x5B82820", VA = "0x185B84020")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B83E40", Offset = "0x5B82640", VA = "0x185B83E40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5B83DA0", Offset = "0x5B825A0", VA = "0x185B83DA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B83DA0", Offset = "0x5B825A0", VA = "0x185B83DA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F54B0", Offset = "0x7F3CB0", VA = "0x1807F54B0")]
		[DebuggerHidden]
		public CNDFGIMENOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5B80300", Offset = "0x5B7EB00", VA = "0x185B80300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5B7FF40", Offset = "0x5B7E740", VA = "0x185B7FF40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5B803E0", Offset = "0x5B7EBE0", VA = "0x185B803E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5B80430", Offset = "0x5B7EC30", VA = "0x185B80430")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5B802C0", Offset = "0x5B7EAC0", VA = "0x185B802C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B80220", Offset = "0x5B7EA20", VA = "0x185B80220", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5B80220", Offset = "0x5B7EA20", VA = "0x185B80220", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LPDMFEGNNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5B88FE0", Offset = "0x5B877E0", VA = "0x185B88FE0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MIGBADIBIAF HPCCHIHGIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B88E30", Offset = "0x5B87630", VA = "0x185B88E30", Slot = "7")]
		get
		{
			return default(MIGBADIBIAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> NIMOIOPDMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x726A30", Offset = "0x725230", VA = "0x180726A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x726A50", Offset = "0x725250", VA = "0x180726A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B89620", Offset = "0x5B87E20", VA = "0x185B89620")]
	public LMCJDLDLPKC(CKLCCACIGLJ PJDKPCLOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B88570", Offset = "0x5B86D70", VA = "0x185B88570", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B88460", Offset = "0x5B86C60", VA = "0x185B88460")]
	public void CEMPCIEDPMO(HJPMBAKCFLC AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B883F0", Offset = "0x5B86BF0", VA = "0x185B883F0")]
	public void ADDEDGCCJIP(HJPMBAKCFLC AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5B89020", Offset = "0x5B87820", VA = "0x185B89020", Slot = "4")]
	public void OOEIEIMDGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5B88C00", Offset = "0x5B87400", VA = "0x185B88C00")]
	public void FMPDGFOLIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5B88CB0", Offset = "0x5B874B0", VA = "0x185B88CB0")]
	private void JDPIBJDCBBD(List<HJPMBAKCFLC> NCDCHLBMMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5B88F00", Offset = "0x5B87700", VA = "0x185B88F00")]
	private static Material MLLDHODALFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5B88DE0", Offset = "0x5B875E0", VA = "0x185B88DE0")]
	private void JDPIBJDCBBD(HJPMBAKCFLC AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B88610", Offset = "0x5B86E10", VA = "0x185B88610")]
	private void EKDLAHMEMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B886E0", Offset = "0x5B86EE0", VA = "0x185B886E0")]
	public void FKGNPOPEOJA(bool CLCEJCPPEDH, bool FOCKNBGPLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B89590", Offset = "0x5B87D90", VA = "0x185B89590")]
	protected void PNPHKNNJKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B88F70", Offset = "0x5B87770", VA = "0x185B88F70")]
	[IteratorStateMachine(typeof(JADJDIILLNP))]
	public IEnumerable<Renderer> NCMFHJJEEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B885A0", Offset = "0x5B86DA0", VA = "0x185B885A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B82880", Offset = "0x5B81080", VA = "0x185B82880")]
	public HHJFODPOHKG(LMCJDLDLPKC ODPHCGBINJN, MGLCHLAIBHL PJDKPCLOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5B81DD0", Offset = "0x5B805D0", VA = "0x185B81DD0", Slot = "13")]
	public override int DOMLGLLFHGK(HGOHMCPPGIC NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5B82690", Offset = "0x5B80E90", VA = "0x185B82690", Slot = "14")]
	public override int PJNKAIPMEMD(HGOHMCPPGIC NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5B81FC0", Offset = "0x5B807C0", VA = "0x185B81FC0", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x79CEA0", Offset = "0x79B6A0", VA = "0x18079CEA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F76F0", Offset = "0x7F5EF0", VA = "0x1807F76F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F7700", Offset = "0x7F5F00", VA = "0x1807F7700", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5B7EB10", Offset = "0x5B7D310", VA = "0x185B7EB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6DF960", Offset = "0x6DE160", VA = "0x1806DF960", Slot = "8")]
	public bool Equals(BMMPNIEBPDA IIKMMJKCGDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1AC2650", Offset = "0x1AC0E50", VA = "0x181AC2650")]
	public static bool CGFEPDNGNBJ(BMMPNIEBPDA DOGOAAONBOH, BMMPNIEBPDA ENHIJCCJFBF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1AC2670", Offset = "0x1AC0E70", VA = "0x181AC2670")]
	public static bool NODBGCCFDAJ(BMMPNIEBPDA DOGOAAONBOH, BMMPNIEBPDA ENHIJCCJFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EA80", Offset = "0x5B7D280", VA = "0x185B7EA80", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x79CEA0", Offset = "0x79B6A0", VA = "0x18079CEA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F76F0", Offset = "0x7F5EF0", VA = "0x1807F76F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F7700", Offset = "0x7F5F00", VA = "0x1807F7700", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5B7FF00", Offset = "0x5B7E700", VA = "0x185B7FF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DF960", Offset = "0x6DE160", VA = "0x1806DF960", Slot = "8")]
	public bool Equals(CNAHBICJLLK IIKMMJKCGDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1AC2650", Offset = "0x1AC0E50", VA = "0x181AC2650")]
	public static bool CGFEPDNGNBJ(CNAHBICJLLK DOGOAAONBOH, CNAHBICJLLK ENHIJCCJFBF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1AC2670", Offset = "0x1AC0E70", VA = "0x181AC2670")]
	public static bool NODBGCCFDAJ(CNAHBICJLLK DOGOAAONBOH, CNAHBICJLLK ENHIJCCJFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5B7FE70", Offset = "0x5B7E670", VA = "0x185B7FE70", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x79CEA0", Offset = "0x79B6A0", VA = "0x18079CEA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7F76F0", Offset = "0x7F5EF0", VA = "0x1807F76F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7F7700", Offset = "0x7F5F00", VA = "0x1807F7700", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5B84100", Offset = "0x5B82900", VA = "0x185B84100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF960", Offset = "0x6DE160", VA = "0x1806DF960", Slot = "8")]
	public bool Equals(JLEKGEOPPIA IIKMMJKCGDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1AC2650", Offset = "0x1AC0E50", VA = "0x181AC2650")]
	public static bool CGFEPDNGNBJ(JLEKGEOPPIA DOGOAAONBOH, JLEKGEOPPIA ENHIJCCJFBF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1AC2670", Offset = "0x1AC0E70", VA = "0x181AC2670")]
	public static bool NODBGCCFDAJ(JLEKGEOPPIA DOGOAAONBOH, JLEKGEOPPIA ENHIJCCJFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5B84070", Offset = "0x5B82870", VA = "0x185B84070", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B8AA40", Offset = "0x5B89240", VA = "0x185B8AA40", Slot = "12")]
		get
		{
			return default(JKMLMPELMBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 PCOPLFKNOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5B89970", Offset = "0x5B88170", VA = "0x185B89970")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5B82880", Offset = "0x5B81080", VA = "0x185B82880")]
	public PNEIMKJLCBO(LMCJDLDLPKC ODPHCGBINJN, JCDOCGODEBF PJDKPCLOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5B89D60", Offset = "0x5B88560", VA = "0x185B89D60", Slot = "11")]
	public override bool MJHFFEDDGML(MIGBADIBIAF ODPHCGBINJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5B89CB0", Offset = "0x5B884B0", VA = "0x185B89CB0", Slot = "13")]
	public override int DOMLGLLFHGK(HGOHMCPPGIC NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5B8ADF0", Offset = "0x5B895F0", VA = "0x185B8ADF0", Slot = "14")]
	public override int PJNKAIPMEMD(HGOHMCPPGIC NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5B896C0", Offset = "0x5B87EC0", VA = "0x185B896C0")]
	private int BBBOMEBBIIO(HGOHMCPPGIC NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5B8A1D0", Offset = "0x5B889D0", VA = "0x185B8A1D0", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B84A20", Offset = "0x5B83220", VA = "0x185B84A20")]
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
	[Cpp2IlInjected.Address(RVA = "0x72D3D0", Offset = "0x72BBD0", VA = "0x18072D3D0")]
	public KGHBEOOGEJE(CCELDGOJHCI INBNHLIGFGE, GGIDACDCDCA AGAPGEHFOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5B85460", Offset = "0x5B83C60", VA = "0x185B85460", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B85C40", Offset = "0x5B84440", VA = "0x185B85C40")]
	private void EJLHDFGEJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5B86420", Offset = "0x5B84C20", VA = "0x185B86420", Slot = "4")]
	public void OFIKNENDIBO(BMMPNIEBPDA ODPHCGBINJN, HGAOGFEBOPA ANEHEIPNCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5B86620", Offset = "0x5B84E20", VA = "0x185B86620", Slot = "5")]
	public void OFIKNENDIBO(CNAHBICJLLK AJNFAJJPNHD, HGAOGFEBOPA ANEHEIPNCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5B86010", Offset = "0x5B84810", VA = "0x185B86010", Slot = "6")]
	public void IHNKDAOKFOE(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5B85210", Offset = "0x5B83A10", VA = "0x185B85210", Slot = "7")]
	public void DADPFBFNKLH(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5B863E0", Offset = "0x5B84BE0", VA = "0x185B863E0", Slot = "8")]
	public void MGOJOMJLOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2875E10", Offset = "0x2874610", VA = "0x182875E10", Slot = "9")]
	public void LFFPOPCKNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B85330", Offset = "0x5B83B30", VA = "0x185B85330", Slot = "10")]
	public void DCMPGCCIDPI(HGAOGFEBOPA ANEHEIPNCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B86800", Offset = "0x5B85000", VA = "0x185B86800", Slot = "11")]
	public void PIAHDMEDAOJ(BMMPNIEBPDA ODPHCGBINJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5B869B0", Offset = "0x5B851B0", VA = "0x185B869B0", Slot = "12")]
	public void PIAHDMEDAOJ(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5B85630", Offset = "0x5B83E30", VA = "0x185B85630", Slot = "13")]
	public void EFKMIPKCLGF(BMMPNIEBPDA ODPHCGBINJN, FPMCIIECIFB BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5B859B0", Offset = "0x5B841B0", VA = "0x185B859B0", Slot = "14")]
	public void EFKMIPKCLGF(CNAHBICJLLK AJNFAJJPNHD, FPMCIIECIFB BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5B85F40", Offset = "0x5B84740", VA = "0x185B85F40", Slot = "17")]
	public void HDEGJOEPHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5B86340", Offset = "0x5B84B40", VA = "0x185B86340", Slot = "15")]
	public void MEPGDEDHNJO(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5B85F80", Offset = "0x5B84780", VA = "0x185B85F80", Slot = "16")]
	public void HKEHFHACMEB(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x20F8400", Offset = "0x20F6C00", VA = "0x1820F8400", Slot = "18")]
	public void NEFDEFJKCBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5B85E40", Offset = "0x5B84640", VA = "0x185B85E40", Slot = "19")]
	public void GEHMALDEAIL(FPMCIIECIFB BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B86140", Offset = "0x5B84940", VA = "0x185B86140")]
	private void LAMEEOEJDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B857F0", Offset = "0x5B83FF0", VA = "0x185B857F0")]
	public void EFKMIPKCLGF(CNAHBICJLLK AJNFAJJPNHD, FPMCIIECIFB BCFKLEGAMEO, bool KLCPMMKPGNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B85B70", Offset = "0x5B84370", VA = "0x185B85B70")]
	private void EJCCBGAAHKI(FPMCIIECIFB BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B84A70", Offset = "0x5B83270", VA = "0x185B84A70", Slot = "20")]
	public void ADJBEOMBGJL(BMMPNIEBPDA ODPHCGBINJN, Vector3 AOCDHNKBEDD, Vector3 EOPLODOIDBP, Vector3 OHMHCFCFKKI, float BNFHNHLPMCA, float CPJNAJOJGLH, IReadOnlyList<Camera> LBAAPLBMJKJ, PMJFIBNNDOA DFGDBNLIMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B84DF0", Offset = "0x5B835F0", VA = "0x185B84DF0", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x210AE90", Offset = "0x2109690", VA = "0x18210AE90", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual JKMLMPELMBA FCNNFGLCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5B82940", Offset = "0x5B81140", VA = "0x185B82940", Slot = "12")]
		get
		{
			return default(JKMLMPELMBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x70E220", Offset = "0x70CA20", VA = "0x18070E220")]
	protected HJPMBAKCFLC(LMCJDLDLPKC ODPHCGBINJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5B828D0", Offset = "0x5B810D0", VA = "0x185B828D0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x65E740", Offset = "0x65CF40", VA = "0x18065E740", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B8AEA0", Offset = "0x5B896A0", VA = "0x185B8AEA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F54B0", Offset = "0x7F3CB0", VA = "0x1807F54B0")]
		[DebuggerHidden]
		public HCFOGKHGNMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5B81C20", Offset = "0x5B80420", VA = "0x185B81C20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5B81D90", Offset = "0x5B80590", VA = "0x185B81D90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5B81D00", Offset = "0x5B80500", VA = "0x185B81D00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CFKIBOGOLPJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5B81D00", Offset = "0x5B80500", VA = "0x185B81D00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B83840", Offset = "0x5B82040", VA = "0x185B83840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer HAEOFCHMCOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5B82ED0", Offset = "0x5B816D0", VA = "0x185B82ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5B82A30", Offset = "0x5B81230", VA = "0x185B82A30")]
	public static Mesh AFGLILLCKGM(NNBFKGAONKD BOCLIGKIMNJ, int NIBPPJFAFOD = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5B834D0", Offset = "0x5B81CD0", VA = "0x185B834D0")]
	public static int NHDDIBCCCLK(NNBFKGAONKD BOCLIGKIMNJ, int NIBPPJFAFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B831C0", Offset = "0x5B819C0", VA = "0x185B831C0")]
	public static APACEBGDDEO GJKIJOABLIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5B82F40", Offset = "0x5B81740", VA = "0x185B82F40")]
	[IteratorStateMachine(typeof(HCFOGKHGNMI))]
	private static IEnumerable<CFKIBOGOLPJ> FGFBOAMIOEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B834E0", Offset = "0x5B81CE0", VA = "0x185B834E0")]
	public static CFKIBOGOLPJ OOODDCNNDIJ(NNBFKGAONKD BOCLIGKIMNJ, int NIBPPJFAFOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B82EB0", Offset = "0x5B816B0", VA = "0x185B82EB0")]
	public static bool DLEBFKPJKNI(this NNBFKGAONKD BOCLIGKIMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B83320", Offset = "0x5B81B20", VA = "0x185B83320")]
	public static void MOMIPGILBOF(NNBFKGAONKD BOCLIGKIMNJ, float3 MGMGKPEOKFB, out OBKLDODKGFO IDHKJKLPGOF, out float3 PFMHFPLNMLE, out float JNEBMCCOOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5B82AF0", Offset = "0x5B812F0", VA = "0x185B82AF0")]
	public static void BFOFMGNKGLF(Vector3 MGMGKPEOKFB, NNBFKGAONKD BOCLIGKIMNJ, out Vector3 PFMHFPLNMLE, out float JNEBMCCOOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5B82EA0", Offset = "0x5B816A0", VA = "0x185B82EA0")]
	[DDDKNIGBKHH(ODNNAFCJNAG.ExitingPlayMode, 0)]
	private static void DBAEKKKCLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5B82FA0", Offset = "0x5B817A0", VA = "0x185B82FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B87230", Offset = "0x5B85A30", VA = "0x185B87230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5B87270", Offset = "0x5B85A70", VA = "0x185B87270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public LMCJDLDLPKC ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5B87C70", Offset = "0x5B86470", VA = "0x185B87C70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public HJPMBAKCFLC ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5B87C10", Offset = "0x5B86410", VA = "0x185B87C10", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DCLMIPOILPM ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5B87CD0", Offset = "0x5B864D0", VA = "0x185B87CD0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B87EA0", Offset = "0x5B866A0", VA = "0x185B87EA0")]
	public LBEDMLKMBAA(CKOHODFFJEJ INBNHLIGFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B872C0", Offset = "0x5B85AC0", VA = "0x185B872C0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B87350", Offset = "0x5B85B50", VA = "0x185B87350", Slot = "4")]
	public BMMPNIEBPDA FFFEHHGDBOP(CKLCCACIGLJ PJDKPCLOECB)
	{
		return default(BMMPNIEBPDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5B87BB0", Offset = "0x5B863B0", VA = "0x185B87BB0", Slot = "5")]
	public void KPLAACDOFAP(BMMPNIEBPDA ODPHCGBINJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5B87A60", Offset = "0x5B86260", VA = "0x185B87A60", Slot = "6")]
	public void KBCHALMMBIG(BMMPNIEBPDA ODPHCGBINJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5B87060", Offset = "0x5B85860", VA = "0x185B87060", Slot = "15")]
	public IEnumerable<Renderer> AAJJCDJAOHD(BMMPNIEBPDA ODPHCGBINJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5B87120", Offset = "0x5B85920", VA = "0x185B87120", Slot = "7")]
	public CNAHBICJLLK ADLMAENNKAF(BMMPNIEBPDA ODPHCGBINJN, JCDOCGODEBF PJDKPCLOECB)
	{
		return default(CNAHBICJLLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5B87D90", Offset = "0x5B86590", VA = "0x185B87D90", Slot = "8")]
	public CNAHBICJLLK OGBNLBOBJDM(BMMPNIEBPDA ODPHCGBINJN, MGLCHLAIBHL PJDKPCLOECB)
	{
		return default(CNAHBICJLLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B87B40", Offset = "0x5B86340", VA = "0x185B87B40", Slot = "10")]
	public void KFHEIPJKFAP(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5B87D30", Offset = "0x5B86530", VA = "0x185B87D30", Slot = "9")]
	public void MENNLBPDMIE(CNAHBICJLLK AJNFAJJPNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5B874C0", Offset = "0x5B85CC0", VA = "0x185B874C0", Slot = "11")]
	public JLEKGEOPPIA FKBCLFLLAAH(DCGKFHIMCMJ PJDKPCLOECB)
	{
		return default(JLEKGEOPPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5B87450", Offset = "0x5B85C50", VA = "0x185B87450", Slot = "13")]
	public void FFMDGHLFJHE(JLEKGEOPPIA KINOAOICMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5B87AE0", Offset = "0x5B862E0", VA = "0x185B87AE0", Slot = "12")]
	public void KDNKELCDNJL(JLEKGEOPPIA KINOAOICMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5B87660", Offset = "0x5B85E60", VA = "0x185B87660", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7F54B0", Offset = "0x7F3CB0", VA = "0x1807F54B0")]
		[DebuggerHidden]
		public KMBJNDPODPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5B86F90", Offset = "0x5B85790", VA = "0x185B86F90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5B86CB0", Offset = "0x5B854B0", VA = "0x185B86CB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5B87010", Offset = "0x5B85810", VA = "0x185B87010")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5B86F50", Offset = "0x5B85750", VA = "0x185B86F50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5B86EB0", Offset = "0x5B856B0", VA = "0x185B86EB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B86EB0", Offset = "0x5B856B0", VA = "0x185B86EB0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B806C0", Offset = "0x5B7EEC0", VA = "0x185B806C0")]
	public static DCLMIPOILPM JCJIJDLCOKP(DCGKFHIMCMJ PJDKPCLOECB, GGIDACDCDCA AGAPGEHFOID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5B81940", Offset = "0x5B80140", VA = "0x185B81940")]
	private DCLMIPOILPM(DCGKFHIMCMJ PJDKPCLOECB, GGIDACDCDCA AGAPGEHFOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B81460", Offset = "0x5B7FC60", VA = "0x185B81460")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B808D0", Offset = "0x5B7F0D0", VA = "0x185B808D0")]
	[IteratorStateMachine(typeof(KMBJNDPODPF))]
	public IEnumerable<Renderer> NCMFHJJEEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B80940", Offset = "0x5B7F140", VA = "0x185B80940", Slot = "4")]
	public void OOEIEIMDGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5B80830", Offset = "0x5B7F030", VA = "0x185B80830")]
	private void MJGNCBINOAP(Vector3 HPDANHIBONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5B80480", Offset = "0x5B7EC80", VA = "0x185B80480")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public DHEBODIIGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5B81A40", Offset = "0x5B80240", VA = "0x185B81A40")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5B81AA0", Offset = "0x5B802A0", VA = "0x185B81AA0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5B81AD0", Offset = "0x5B802D0", VA = "0x185B81AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8060", Offset = "0x6F6860", VA = "0x1806F8060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int PGPEFLGJBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x671690", Offset = "0x66FE90", VA = "0x180671690")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x671680", Offset = "0x66FE80", VA = "0x180671680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EFC0", Offset = "0x5B7D7C0", VA = "0x185B7EFC0")]
	public void EECFCHEEHFB(List<MIGBADIBIAF> LKIMFBECIDI, Matrix4x4[] GKNCEIFDDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F300", Offset = "0x5B7DB00", VA = "0x185B7F300")]
	public static List<BOFPBLEJOJE> MFNJFAEBAIM(List<LMCJDLDLPKC> OJOBEEEOCEK, HGOHMCPPGIC NIBPPJFAFOD, Bounds ANAGHLFLMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EBE0", Offset = "0x5B7D3E0", VA = "0x185B7EBE0")]
	private JobHandle ECGCHBHOOPN(KNENKBEOOCP NOAJKDENLLH, int DJNKKLGGELH, int JHGCFEHDLOG, HGOHMCPPGIC NIBPPJFAFOD, List<IJHPEMCDNKP> KLDAKEGPCPN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F1F0", Offset = "0x5B7D9F0", VA = "0x185B7F1F0")]
	private void KAFJBOJCPPN(List<IJHPEMCDNKP> KLDAKEGPCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5B7FA60", Offset = "0x5B7E260", VA = "0x185B7FA60")]
	private BOFPBLEJOJE(List<IJHPEMCDNKP> KLDAKEGPCPN, int DJNKKLGGELH, int JHGCFEHDLOG, HGOHMCPPGIC NIBPPJFAFOD, Bounds ANAGHLFLMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EB50", Offset = "0x5B7D350", VA = "0x185B7EB50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x6F5010", Offset = "0x6F3810", VA = "0x1806F5010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int NJNDDGMCMKE
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x5B8BB60", Offset = "0x5B8A360", VA = "0x185B8BB60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5B8AED0", Offset = "0x5B896D0", VA = "0x185B8AED0")]
		public static List<SkinnedShapeRenderer> Create(GameObject ODPHCGBINJN, List<BOFPBLEJOJE> AJDLIKALKDK, List<MIGBADIBIAF> GHHDJKNJEAG, Material JEFIMPHCKGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5B8B510", Offset = "0x5B89D10", VA = "0x185B8B510")]
		public void Init(BOFPBLEJOJE CNEBPEILFJE, List<MIGBADIBIAF> GHHDJKNJEAG, Material JEFIMPHCKGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5B8BAB0", Offset = "0x5B8A2B0", VA = "0x185B8BAB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5B8BA00", Offset = "0x5B8A200", VA = "0x185B8BA00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5B8B9C0", Offset = "0x5B8A1C0", VA = "0x185B8B9C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5B8B2E0", Offset = "0x5B89AE0", VA = "0x185B8B2E0")]
		private void FIPNBFLLPHA(ScriptableRenderContext IGBOEABBEHO, Camera[] COMGFKKAPJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5B8B120", Offset = "0x5B89920", VA = "0x185B8B120")]
		private void EECFCHEEHFB(CommandBuffer BLIGGPEEFME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F30", Offset = "0x6E6730", VA = "0x1806E7F30")]
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
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E450", Offset = "0x5B7CC50", VA = "0x185B7E450")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E560", Offset = "0x5B7CD60", VA = "0x185B7E560")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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
