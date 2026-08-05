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
public enum EABGJBJDCKI
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
public static class FECDBDEFHGK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7291510", Offset = "0x7290510", VA = "0x187291510")]
	public static bool GJGCFHGGLJO(this EABGJBJDCKI HHJIAEJDIHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7291560", Offset = "0x7290560", VA = "0x187291560")]
	public static bool ONIMEIOEPIM(this EABGJBJDCKI HHJIAEJDIHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7291530", Offset = "0x7290530", VA = "0x187291530")]
	public static bool JICPJGCAIDC(this EABGJBJDCKI HHJIAEJDIHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FDEEDPFGKHB : CEKEPAAIMKF<FDEEDPFGKHB>, CKPCDNGLPGP, IEquatable<FDEEDPFGKHB>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int EHPNNEFNFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA79570", Offset = "0xA78570", VA = "0x180A79570", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int AHEIGHJAOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C3F0", Offset = "0x1E2B3F0", VA = "0x181E2C3F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x11BC270", Offset = "0x11BB270", VA = "0x1811BC270", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FHMCEOPEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7291440", Offset = "0x7290440", VA = "0x187291440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2D70", Offset = "0x2BA1D70", VA = "0x182BA2D70", Slot = "8")]
	public bool Equals(FDEEDPFGKHB JONIFABKCAI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A17130", Offset = "0x4A16130", VA = "0x184A17130")]
	public static bool NLNNLODOBLO(FDEEDPFGKHB CDICEDNOPPN, FDEEDPFGKHB ANCILJKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72913A0", Offset = "0x72903A0", VA = "0x1872913A0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7291480", Offset = "0x7290480", VA = "0x187291480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EDOGAFJMIEH
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
public struct APDDHIFAEFF : CEKEPAAIMKF<APDDHIFAEFF>, CKPCDNGLPGP, IEquatable<APDDHIFAEFF>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int EHPNNEFNFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA79570", Offset = "0xA78570", VA = "0x180A79570", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int AHEIGHJAOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C3F0", Offset = "0x1E2B3F0", VA = "0x181E2C3F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x11BC270", Offset = "0x11BB270", VA = "0x1811BC270", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FHMCEOPEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72912D0", Offset = "0x72902D0", VA = "0x1872912D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2D70", Offset = "0x2BA1D70", VA = "0x182BA2D70", Slot = "8")]
	public bool Equals(APDDHIFAEFF JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7291230", Offset = "0x7290230", VA = "0x187291230", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7291310", Offset = "0x7290310", VA = "0x187291310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum PBFKAKAGAIJ
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
public enum KKAMNNCNEEM
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
public interface HPJDNKFIOEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPDGJCDKIAL(FDEEDPFGKHB FMNCHFNIOHH, KKAMNNCNEEM AOGHJNLEEHB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPDGJCDKIAL(APDDHIFAEFF MMMIJMMKPFM, KKAMNNCNEEM AOGHJNLEEHB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOOKIFOEAOM(APDDHIFAEFF MMMIJMMKPFM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DBPLDKAPLHE(APDDHIFAEFF MMMIJMMKPFM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLEMHBOCPHH();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DOMFKMMFHPM(KKAMNNCNEEM FLAJIGGIBOB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMFGAJMOFFB(FDEEDPFGKHB FMNCHFNIOHH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JMFGAJMOFFB(APDDHIFAEFF MMMIJMMKPFM);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LNHLEHHMFNF(FDEEDPFGKHB FMNCHFNIOHH, JOJGLDNKBNG FLAJIGGIBOB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LNHLEHHMFNF(APDDHIFAEFF MMMIJMMKPFM, JOJGLDNKBNG FLAJIGGIBOB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NMGAKDHOGGI(APDDHIFAEFF MMMIJMMKPFM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LNGPIBOFLHG(APDDHIFAEFF MMMIJMMKPFM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NJFGGMDMAJN();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CDODGEEMBLP(JOJGLDNKBNG FLAJIGGIBOB);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EALNBAPFJNO(FDEEDPFGKHB FMNCHFNIOHH, Vector3 MHJCHFLOAOF, Vector3 NLGDGJDHHCN, Vector3 KMFPMFMFFIG, float FDBODHIJCLK, float FILFGJPBLNL, IReadOnlyList<Camera> EOAEMGOFOCC, PBFKAKAGAIJ MILEKKHNKLI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EALNBAPFJNO(ALDEJIMEPDN AECGKOMJOLE, Vector3 MHJCHFLOAOF, Vector3 NLGDGJDHHCN, Vector3 KMFPMFMFFIG, float FDBODHIJCLK, float FILFGJPBLNL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct ALDEJIMEPDN : CEKEPAAIMKF<ALDEJIMEPDN>, CKPCDNGLPGP, IEquatable<ALDEJIMEPDN>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int EHPNNEFNFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA79570", Offset = "0xA78570", VA = "0x180A79570", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int AHEIGHJAOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C3F0", Offset = "0x1E2B3F0", VA = "0x181E2C3F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x11BC270", Offset = "0x11BB270", VA = "0x1811BC270", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FHMCEOPEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72911F0", Offset = "0x72901F0", VA = "0x1872911F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2D70", Offset = "0x2BA1D70", VA = "0x182BA2D70", Slot = "8")]
	public bool Equals(ALDEJIMEPDN JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7291150", Offset = "0x7290150", VA = "0x187291150", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FCOGJPCHMEG : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GAHNJLMAFHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LMHCKLDBPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FDEEDPFGKHB GJFBOJJFIHH(DJBBCAMOLKN HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FDEEDPFGKHB GJFBOJJFIHH(DJBBCAMOLKN HCKNMLENIIG, bool MEKPEOBHAEG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIIKFOJFIOO(FDEEDPFGKHB FMNCHFNIOHH);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANACLDHAPLB(FDEEDPFGKHB FMNCHFNIOHH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "4")]
	APDDHIFAEFF LABKGHGFGHF(FDEEDPFGKHB FMNCHFNIOHH, ALDHKGMJCAI HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	APDDHIFAEFF GKGBEEBIABN(FDEEDPFGKHB FMNCHFNIOHH, GHBLIDIILJF HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NAHMLDCGCAC(APDDHIFAEFF MMMIJMMKPFM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KGOCLKEPOOI(APDDHIFAEFF MMMIJMMKPFM);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ALDEJIMEPDN KAGINFLEEOH(MHCCGAJOFBH HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BELJMOKABMA(ALDEJIMEPDN AECGKOMJOLE);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PLCMDCBCJOH(ALDEJIMEPDN AECGKOMJOLE);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task JLFFDBFGPOC();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task HDOPEFLAOAP();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task GKPOLINNKPD();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CINKPDHFMMJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> FPMAOPAACCH(FDEEDPFGKHB FMNCHFNIOHH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum JOJGLDNKBNG
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
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MBAFEGIAFAG
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static Vector3 MHLCJJFCBKN;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static Vector3 CBANGOJEKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly float OPMAMFJBGNL;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7294EB0", Offset = "0x7293EB0", VA = "0x187294EB0")]
	public static Vector3 PJJDLMICDNB(Vector3 ELDNGMDBKPP, Quaternion FIMLLHIBIOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7294C00", Offset = "0x7293C00", VA = "0x187294C00")]
	public static Vector3 OFHKCIHBBEH(Quaternion DEANJFCCEBG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7294B50", Offset = "0x7293B50", VA = "0x187294B50")]
	public static Vector3 NCGNMIFELNF(Quaternion DEANJFCCEBG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7294720", Offset = "0x7293720", VA = "0x187294720")]
	public static Quaternion FCPEABGKIAL(Vector3 HAMNFFBEFHD, Vector3 MJKKHJFHAJH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72947C0", Offset = "0x72937C0", VA = "0x1872947C0")]
	public static Vector3 GGJFACJGIEC(Vector3 LPFGMAFAIIJ, Vector3 BENMFBPFAGA, Vector3 MJKKHJFHAJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7294CB0", Offset = "0x7293CB0", VA = "0x187294CB0")]
	public static Vector3 OGBAFPOFAJE(Vector3 ELDNGMDBKPP, Vector3 MJKKHJFHAJH, Quaternion DEANJFCCEBG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7294360", Offset = "0x7293360", VA = "0x187294360")]
	public static Quaternion EGDKFLMMDFE(Quaternion FIMLLHIBIOI, Vector3 HAMNFFBEFHD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72945A0", Offset = "0x72935A0", VA = "0x1872945A0")]
	public static bool EPNOJKGMPJN(Vector3 BCGHMLGNPJI, Vector3 GEIDFLHKLBK, out Vector3 FADBJOLDPEL, bool LKMOKIGPFLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7294970", Offset = "0x7293970", VA = "0x187294970")]
	public static Vector3 KMGPFAEMIJN(bool LLOBFOLEIMA, [Optional] Quaternion MFCEPMCCOFP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum IBAFDJCDMKA
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
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GJBBCJAKLOK
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private struct LFIJPCBEPBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Vector3 HCILKJHLOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Quaternion MFMJNPLDFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float BIJAANICNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Quaternion NDALKPBFANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float BFDCCBGHIFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public float IHIHHOKCPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public float BLCAOHBDDCJ;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static List<LFIJPCBEPBN> IDCOPBBIEMK;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72928D0", Offset = "0x72918D0", VA = "0x1872928D0")]
	public static NativeList<FBFEKICOADI> FHHJFIOJANM(GOJBJFEKLPM NMBCFCBEFNO)
	{
		return default(NativeList<FBFEKICOADI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7291AB0", Offset = "0x7290AB0", VA = "0x187291AB0")]
	private static bool EJMPBGDHHJE(int MBMAEEFDADD, NativeList<FBFEKICOADI> MLAOHBBKEKK, List<LFIJPCBEPBN> IBHIPLMPOFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72940F0", Offset = "0x72930F0", VA = "0x1872940F0")]
	private static FBFEKICOADI NMODEDBIBMN(int CMOLHAEMMAE, List<LFIJPCBEPBN> IBHIPLMPOFD)
	{
		return default(FBFEKICOADI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7291570", Offset = "0x7290570", VA = "0x187291570")]
	private static FBFEKICOADI BGEEIONBDHJ(int CMOLHAEMMAE, List<LFIJPCBEPBN> IBHIPLMPOFD)
	{
		return default(FBFEKICOADI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72919B0", Offset = "0x72909B0", VA = "0x1872919B0")]
	private static FBFEKICOADI EJMHHOOGEBA(Vector3 HONHANLIPPH, Quaternion FIMLLHIBIOI, float CADELOLNNHN)
	{
		return default(FBFEKICOADI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7292E00", Offset = "0x7291E00", VA = "0x187292E00")]
	public static NativeList<FBFEKICOADI> KCDKFNPIIGF(GOJBJFEKLPM NMBCFCBEFNO, float JIOHEIAJEIB)
	{
		return default(NativeList<FBFEKICOADI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum ENNMJJOLNDD
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
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ALDHKGMJCAI : BPDJFIAOJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IBAFDJCDMKA GIAGOPFJACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool GAIPFIJBGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DJBBCAMOLKN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	ILAKCHBHFNG NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	ENNMJJOLNDD JJBHEBPAMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GHBLIDIILJF : BPDJFIAOJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BBIOLCHANPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool JBDEEMMGKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float KBEMBNEGADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int FHPDKJBAJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool LHKKPPIPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int MNAIHOFKGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<FBFEKICOADI> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MHCCGAJOFBH
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int PBCFAOEFBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform BILDJDKBFID
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DECCJLDIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FDEEDPFGKHB GetBone(int CMOLHAEMMAE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int CMOLHAEMMAE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BPDJFIAOJAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PBHBNGBJOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LDNJONNIDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	ILAKCHBHFNG NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float IHNCICMGECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Vector3 NDGNIMKFPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	EABGJBJDCKI DDBJGJJDKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EDOGAFJMIEH DABLPOAIINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FBFEKICOADI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 HCILKJHLOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float3x3 MFMJNPLDFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float BIJAANICNLP;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GOJBJFEKLPM
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int MPICCAFALNC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FMIBMLFLGOI(int CMOLHAEMMAE);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion PPDABIMJJGF(int CMOLHAEMMAE);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float FEMABOOOFMH(int CMOLHAEMMAE);
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
