using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PCJLEJOLJBG
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
public static class DPAOOBCAOJB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F711B0", Offset = "0x6F705B0", VA = "0x186F711B0")]
	public static bool CDMNDGNNNCA(this PCJLEJOLJBG GEMDAKCADJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F711D0", Offset = "0x6F705D0", VA = "0x186F711D0")]
	public static bool IJDJGEDKONJ(this PCJLEJOLJBG GEMDAKCADJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F711E0", Offset = "0x6F705E0", VA = "0x186F711E0")]
	public static bool IKMPCAKICAB(this PCJLEJOLJBG GEMDAKCADJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OKLEKLIDLMN : AJHCFBOLAKM, IEquatable<OKLEKLIDLMN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int BJNMAHEDMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int EGCDHDOFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC90", Offset = "0x16CF090", VA = "0x1816CFC90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2513720", Offset = "0x2512B20", VA = "0x182513720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MFCBPLJLPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F722B0", Offset = "0x6F716B0", VA = "0x186F722B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x25129B0", Offset = "0x2511DB0", VA = "0x1825129B0", Slot = "8")]
	public bool Equals(OKLEKLIDLMN LNOOAJJNCAE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x47178A0", Offset = "0x4716CA0", VA = "0x1847178A0")]
	public static bool JJOPDHABKNF(OKLEKLIDLMN EJOFMGLMADH, OKLEKLIDLMN CMACFBOCONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F722F0", Offset = "0x6F716F0", VA = "0x186F722F0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F72390", Offset = "0x6F71790", VA = "0x186F72390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KFDDOGLDHLG
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GEDODKLBGBN : AJHCFBOLAKM, IEquatable<GEDODKLBGBN>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int BJNMAHEDMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int EGCDHDOFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC90", Offset = "0x16CF090", VA = "0x1816CFC90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2513720", Offset = "0x2512B20", VA = "0x182513720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MFCBPLJLPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F71210", Offset = "0x6F70610", VA = "0x186F71210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x25129B0", Offset = "0x2511DB0", VA = "0x1825129B0", Slot = "8")]
	public bool Equals(GEDODKLBGBN LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F71250", Offset = "0x6F70650", VA = "0x186F71250", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F712F0", Offset = "0x6F706F0", VA = "0x186F712F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LJALOLHLMDP
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum ACHEKCMGEOE
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	PivotHover,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DebugLocate,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	FrozenHover
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MDEKHLOEFLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KENPBPJLLKE(OKLEKLIDLMN COMCNEGAGFF, ACHEKCMGEOE DILPMIKBIBB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KENPBPJLLKE(GEDODKLBGBN HELMOINPHOO, ACHEKCMGEOE DILPMIKBIBB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLKPAFDKBHF(GEDODKLBGBN HELMOINPHOO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENKJFOHEFJM(GEDODKLBGBN HELMOINPHOO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPFCDIFKIDI();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AJNFKCJDIOP(ACHEKCMGEOE JLNNFEOBAMK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IAEEOAOLJEH(OKLEKLIDLMN COMCNEGAGFF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IAEEOAOLJEH(GEDODKLBGBN HELMOINPHOO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AFHKPLFAIGC(OKLEKLIDLMN COMCNEGAGFF, GEICHFJJNEH JLNNFEOBAMK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AFHKPLFAIGC(GEDODKLBGBN HELMOINPHOO, GEICHFJJNEH JLNNFEOBAMK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PLALEMKDHHP(GEDODKLBGBN HELMOINPHOO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CLJFMCCKDEK(GEDODKLBGBN HELMOINPHOO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EGNKPHCMMAC();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MGGPLCJHKFM(GEICHFJJNEH JLNNFEOBAMK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KJFIPFMCDAM(OKLEKLIDLMN COMCNEGAGFF, Vector3 PHKNAAELEFN, Vector3 APLMJONIBPJ, Vector3 PIOMJMJFAEF, float KCEGFBDDAPP, float KNLBJOHODJG, IReadOnlyList<Camera> FOMEGEBHNBN, LJALOLHLMDP OCIOIKDKNOC);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KJFIPFMCDAM(OBNMJKICJAH LJNLFDAMGFF, Vector3 PHKNAAELEFN, Vector3 APLMJONIBPJ, Vector3 PIOMJMJFAEF, float KCEGFBDDAPP, float KNLBJOHODJG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OBNMJKICJAH : AJHCFBOLAKM, IEquatable<OBNMJKICJAH>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BJNMAHEDMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EGCDHDOFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC90", Offset = "0x16CF090", VA = "0x1816CFC90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2513720", Offset = "0x2512B20", VA = "0x182513720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MFCBPLJLPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F721D0", Offset = "0x6F715D0", VA = "0x186F721D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x25129B0", Offset = "0x2511DB0", VA = "0x1825129B0", Slot = "8")]
	public bool Equals(OBNMJKICJAH LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F72210", Offset = "0x6F71610", VA = "0x186F72210", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CLBOFGEACDM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LGMOPIKEIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKLEKLIDLMN ELHDPCJHHPL(HCNNDKBMFHP KJFNAECAHBA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKLEKLIDLMN ELHDPCJHHPL(HCNNDKBMFHP KJFNAECAHBA, bool OOMMBPJCKFE);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNFIBLMFODF(OKLEKLIDLMN COMCNEGAGFF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKFOCEPJGDA(OKLEKLIDLMN COMCNEGAGFF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GEDODKLBGBN PLAOPHKIPFP(OKLEKLIDLMN COMCNEGAGFF, PDNKFDPIEAN KJFNAECAHBA);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GEDODKLBGBN JIDOIALBPCJ(OKLEKLIDLMN COMCNEGAGFF, ECBBFBMBEDB KJFNAECAHBA);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LBGKNNBEBPI(GEDODKLBGBN HELMOINPHOO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ILKAHIDBLHE(GEDODKLBGBN HELMOINPHOO);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OBNMJKICJAH JPHMOIMANGJ(KPLDONNJBIM KJFNAECAHBA);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IKGMPLDFBPH(OBNMJKICJAH LJNLFDAMGFF);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PLMFJNGPEIJ(OBNMJKICJAH LJNLFDAMGFF);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DLLEICKEFDP();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task LOPMDMEMBAB();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task PMKIEDKCMKP();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BELBMMDAMMC();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> NLPMPLMFMMJ(OKLEKLIDLMN COMCNEGAGFF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GEICHFJJNEH
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HDKAFBMFBNN
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static Vector3 JMBCFOMNEJI;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static Vector3 MICOKLPBHJK;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly float GECCKCANCEO;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F71CD0", Offset = "0x6F710D0", VA = "0x186F71CD0")]
	public static Vector3 NBFKKLBEHCB(Vector3 LMDHDKCKGHC, Quaternion IFDCCCEDOFF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F71430", Offset = "0x6F70830", VA = "0x186F71430")]
	public static Vector3 GNOIGGFDAAK(Quaternion PFHPGOOLCFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F71380", Offset = "0x6F70780", VA = "0x186F71380")]
	public static Vector3 GAGFBKGOCHC(Quaternion PFHPGOOLCFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F71840", Offset = "0x6F70C40", VA = "0x186F71840")]
	public static Quaternion IGHOAPCAKOE(Vector3 KDLMOBCGODE, Vector3 LHLKLIEJLPJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F71B20", Offset = "0x6F70F20", VA = "0x186F71B20")]
	public static Vector3 MJHFJOOKCCM(Vector3 BJCDJLEEDGJ, Vector3 CHECAFCKJPB, Vector3 LHLKLIEJLPJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F71F30", Offset = "0x6F71330", VA = "0x186F71F30")]
	public static Vector3 OCHBPPLCKDH(Vector3 LMDHDKCKGHC, Vector3 LHLKLIEJLPJ, Quaternion PFHPGOOLCFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F718E0", Offset = "0x6F70CE0", VA = "0x186F718E0")]
	public static Quaternion MFLHONEENJL(Quaternion IFDCCCEDOFF, Vector3 KDLMOBCGODE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F716C0", Offset = "0x6F70AC0", VA = "0x186F716C0")]
	public static bool HOJKLPBGOOI(Vector3 JELNLDAPEAA, Vector3 OJBJEMJGOMA, out Vector3 EODDGEKBHAD, bool MNPJAAHIBBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F714E0", Offset = "0x6F708E0", VA = "0x186F714E0")]
	public static Vector3 HEGJCJBALMJ(bool ELLBOECFBAM, [Optional] Quaternion HEAEJCMLFGC)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum LDCBIJHGALF
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CMCNBHMFLDN
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct AJLKIPKKKEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Vector3 COBAGHJPFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Quaternion DLMCOOJLNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float FFBACCHEAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Quaternion JHODCKBPFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float PELMJHINOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public float GNBJFPGJBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public float FBCMACNEGHL;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static List<AJLKIPKKKEK> CNONODKJAIO;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F1E0", Offset = "0x6F6E5E0", VA = "0x186F6F1E0")]
	public static NativeList<IFKOAODPPHD> GEOFFACPMFH(IHOGNCCIEFE PJBHFLBCCAN)
	{
		return default(NativeList<IFKOAODPPHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E3C0", Offset = "0x6F6D7C0", VA = "0x186F6E3C0")]
	private static bool EAMLINOPKND(int GNPGECNAJNK, NativeList<IFKOAODPPHD> OHCLGKAJOMN, List<AJLKIPKKKEK> JKBOOFJEDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F710", Offset = "0x6F6EB10", VA = "0x186F6F710")]
	private static IFKOAODPPHD KEEFHFMMCCG(int PEFIKPEDCLN, List<AJLKIPKKKEK> JKBOOFJEDPD)
	{
		return default(IFKOAODPPHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F900", Offset = "0x6F6ED00", VA = "0x186F6F900")]
	private static IFKOAODPPHD KGHOFBIBJFP(int PEFIKPEDCLN, List<AJLKIPKKKEK> JKBOOFJEDPD)
	{
		return default(IFKOAODPPHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FD40", Offset = "0x6F6F140", VA = "0x186F6FD40")]
	private static IFKOAODPPHD LKEMMJDHCDF(Vector3 LPIMIOFOIOA, Quaternion IFDCCCEDOFF, float IPHDKMMKPIL)
	{
		return default(IFKOAODPPHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FE40", Offset = "0x6F6F240", VA = "0x186F6FE40")]
	public static NativeList<IFKOAODPPHD> NPEAFCNNEGL(IHOGNCCIEFE PJBHFLBCCAN, float BFIFKBKIGBI)
	{
		return default(NativeList<IFKOAODPPHD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum IGECCDJBDBL
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PDNKFDPIEAN : AIJFLIHGNNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LDCBIJHGALF MGMOJPCHBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool FNOILKFCLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HCNNDKBMFHP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	BCHJJGNIBBC GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IGECCDJBDBL IOHKPEHEIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ECBBFBMBEDB : AIJFLIHGNNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool CIDAJEFHNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool KAMKBEGCFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float ACLGFLMPCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int LACAOKOKBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool JEBPKEFIANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int NPPIBEPDLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<IFKOAODPPHD> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KPLDONNJBIM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int AOENHPFIJFB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform BLDDLFJJDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool BFCPPGOLMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKLEKLIDLMN GetBone(int PEFIKPEDCLN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int PEFIKPEDCLN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AIJFLIHGNNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool AFIJJAHIKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IONNGPDNONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	BCHJJGNIBBC GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float NEGLOIKOOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Vector3 AIJAMJKCFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PCJLEJOLJBG ABHHCCAHOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	KFDDOGLDHLG ILPCCFEGLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IFKOAODPPHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 COBAGHJPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float3x3 DLMCOOJLNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float FFBACCHEAGA;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IHOGNCCIEFE
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int NOCKJBANIIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NPDIMKINEFJ(int PEFIKPEDCLN);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion NPIGNCLKIMF(int PEFIKPEDCLN);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float DMDAMAABPPE(int PEFIKPEDCLN);
}
namespace Cpp2IlInjected;

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
