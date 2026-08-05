using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Foundation.Mathematics;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NBOEAIAAPLF
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CHMGPECIKJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	PivotHover,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	DebugLocate,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	FrozenHover,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ManipulateCollision
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CALBLPNDMED
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OGAOHBCKIEK
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum MFEDJIKCLFM
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum IPAPAOLOGOE
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	RRO_MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	RRO_COLORS_COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	RRO_MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	GENERATED_MIN_VALUE = 1000,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	GENERATED_COLORS_BITS_PER_CHANNEL = 8,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	GENERATED_COLORS_COUNT = 16777216,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	GENERATED_MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	LEGACY_GENERATED_COLORS_COUNT = 4096,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	GENERATED_TO_GPU_OFFSET = -939,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ELDDNDNPPIE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7E10A60", Offset = "0x7E0FC60", VA = "0x187E10A60")]
	public static bool CHKBCCHOFDB(this IPAPAOLOGOE MBFCBBCCMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7E10A50", Offset = "0x7E0FC50", VA = "0x187E10A50")]
	public static bool BGMAPPNNFKB(this IPAPAOLOGOE MBFCBBCCMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E10A80", Offset = "0x7E0FC80", VA = "0x187E10A80")]
	public static bool HMJMFEKPAAJ(this IPAPAOLOGOE MBFCBBCCMKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JMKIOIDBFKN
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GPGLHFGDHFI : JHEBGNDPGNA, IEquatable<GPGLHFGDHFI>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int IJCKDBACFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int HNJNJKKAINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2F5C110", Offset = "0x2F5B310", VA = "0x182F5C110", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E42C20", Offset = "0x6E41E20", VA = "0x186E42C20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool APFGOMCKPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E13B50", Offset = "0x7E12D50", VA = "0x187E13B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1262400", Offset = "0x1261600", VA = "0x181262400", Slot = "8")]
	public bool Equals(GPGLHFGDHFI CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8700", Offset = "0x3AE7900", VA = "0x183AE8700")]
	public static bool EEDHALGLIEL(GPGLHFGDHFI BGPKBCGBDMP, GPGLHFGDHFI NIJBGCGEGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E13B90", Offset = "0x7E12D90", VA = "0x187E13B90", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E13C30", Offset = "0x7E12E30", VA = "0x187E13C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BGBEOAFDOPH : JHEBGNDPGNA, IEquatable<BGBEOAFDOPH>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int IJCKDBACFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int HNJNJKKAINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2F5C110", Offset = "0x2F5B310", VA = "0x182F5C110", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E42C20", Offset = "0x6E41E20", VA = "0x186E42C20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool APFGOMCKPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E108E0", Offset = "0x7E0FAE0", VA = "0x187E108E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1262400", Offset = "0x1261600", VA = "0x181262400", Slot = "8")]
	public bool Equals(BGBEOAFDOPH CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E10920", Offset = "0x7E0FB20", VA = "0x187E10920", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E109C0", Offset = "0x7E0FBC0", VA = "0x187E109C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KLOAHGNEGEC : JHEBGNDPGNA, IEquatable<KLOAHGNEGEC>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int IJCKDBACFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HNJNJKKAINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2F5C110", Offset = "0x2F5B310", VA = "0x182F5C110", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E42C20", Offset = "0x6E41E20", VA = "0x186E42C20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool APFGOMCKPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E17050", Offset = "0x7E16250", VA = "0x187E17050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1262400", Offset = "0x1261600", VA = "0x181262400", Slot = "8")]
	public bool Equals(KLOAHGNEGEC CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E17090", Offset = "0x7E16290", VA = "0x187E17090", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BJOOKMNONND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMPABNEGPNP(GPGLHFGDHFI OLEJNEHCCLF, CHMGPECIKJJ LANBPNACLHP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMPABNEGPNP(BGBEOAFDOPH GEPHAPCMEAA, CHMGPECIKJJ LANBPNACLHP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNHAOMJCEPD(BGBEOAFDOPH GEPHAPCMEAA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EGBPMPEGGGG(BGBEOAFDOPH GEPHAPCMEAA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDCILGFLIFK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEILHJKOGKE(CHMGPECIKJJ GDHKDBJPDLG);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BJOFINNNIDL(GPGLHFGDHFI OLEJNEHCCLF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BJOFINNNIDL(BGBEOAFDOPH GEPHAPCMEAA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HNEDAJEDEPA(BGBEOAFDOPH GEPHAPCMEAA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HKLLAFOKFDM(BGBEOAFDOPH GEPHAPCMEAA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HKLONCLDPME();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EDPBACDFANJ();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FBJGGOEPNMH(GPGLHFGDHFI OLEJNEHCCLF, MFEDJIKCLFM GDHKDBJPDLG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OKLNLMGMPCG(BGBEOAFDOPH GEPHAPCMEAA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IICKABDAKGM(BGBEOAFDOPH GEPHAPCMEAA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BPPLGIMMIFE();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GHJFJKAANEA(MFEDJIKCLFM GDHKDBJPDLG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KNILFOFLEJI(GPGLHFGDHFI OLEJNEHCCLF, Vector3 FKFLJICHCAL, Vector3 JBKMANIFODD, Vector3 EJAHENKHIMI, float JBKJMEDDIGO, float CKMCMMNCBCC, IReadOnlyList<Camera> NLPIHPFJJMF, NBOEAIAAPLF CBCPLGKAOIC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KNILFOFLEJI(KLOAHGNEGEC KJPGEMOEAPM, Vector3 FKFLJICHCAL, Vector3 JBKMANIFODD, Vector3 EJAHENKHIMI, float JBKJMEDDIGO, float CKMCMMNCBCC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NBLECBFEIMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CJGHPAFALAH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPGLHFGDHFI HEAIGKKBKEH(JOPFHDFGJHL CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GPGLHFGDHFI HEAIGKKBKEH(JOPFHDFGJHL CAIGHLKIDBF, bool EEOABHMMOFE);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLGLAOJHHDH(GPGLHFGDHFI OLEJNEHCCLF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DJIGJBBHLPC(GPGLHFGDHFI OLEJNEHCCLF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BGBEOAFDOPH PFHGFNIBAKG(GPGLHFGDHFI OLEJNEHCCLF, FBCEMHOLLKI CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BGBEOAFDOPH OPLCOGOINLJ(GPGLHFGDHFI OLEJNEHCCLF, EABGNPNGALB CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IAHIPDIKFKB(BGBEOAFDOPH GEPHAPCMEAA);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FGACNJJFDFN(BGBEOAFDOPH GEPHAPCMEAA);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KLOAHGNEGEC AFPDDIDKPBO(MFHLEMCNGOL CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AMAGGGEHMJE(KLOAHGNEGEC KJPGEMOEAPM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PLEHBIJBNGH(KLOAHGNEGEC KJPGEMOEAPM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task JLIGKJHKJEB();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task HIFMMODDNKM();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task BFNOJOEBBDO();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NAIJEIJMPIM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> OBGMBKIHBEN(GPGLHFGDHFI OLEJNEHCCLF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HCKDLLLJBGM
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum IIACBFJNEHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum CENLAHPILAE
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum ODBANBIJIEN
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		RefreshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum KGCEONPDFEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum JDODDNJMNDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum CMEEGFLKEDK
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum PJOPONMMPPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum JAIBANNHBMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		LowQualityHighSpeed = 102
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool JCKOMEJNHKH;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long MKEDICIBOIH;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool CEGGLGGPHJN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool DCLBMBDPHAH;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool CEFGBDNEBDH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float FMFDKMCPEKI;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float KGLNJBLADED;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int KBCIDDHEGBP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static CMEEGFLKEDK DEOHPCJOJCD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long FKGMEFPNFNO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float BGDODDGBIFJ;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int IPEOBDBIDFA;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int DDIMAIFLEMC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int BKNPAIKMNMI;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int GGCMMHNAIFK;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int IOMMOEMBODP;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int IPPLIDKOEIP;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int PBDECOAJLDF;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int MJBLMENDFDG;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool BJDPADMGELL;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int LMNCOPBAGPL;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int HFNGINDPFHM;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int EFGEMIFJOHJ;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool ELHLJPLINLI;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float NMGKFEKPKMD;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool HHNMDMDAIGP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float EGGNBBFENGN;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long OKHAIFIJJNC;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool LFAAJKGAIAC;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long BBMOBDELKOC;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int FFGDAOPLILD;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool IFCGBHCLGAD;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static IIACBFJNEHP ICMLDGHIOKK;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool LJBCLMPNGOL;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool EALDHDGEAHG;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int ONCAOFBILAN;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int BIHKJLBNKEH;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int OFGMFFMNFFA;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int JLCAFOMECMC;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int EKODPLLEJDJ;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int FIHMLKIAKNL;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int CIKNBIJBACF;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int LELAPHDIBAN;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float LJKDKIHBKHE;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float FOJDJJDOPHD;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float AONIJJIFGPE;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float MKOCAIHNGEJ;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int HEGBFHBKFNK;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int PFAAIICLEFL;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int EOGDCFAKNAN;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int EDLICOHKLAN;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool GHKAPEJJHAC;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static ODBANBIJIEN FGELHNFPIEO;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static KGCEONPDFEN NEJLDBGCFBK;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool NMMLBCLCDPM;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static CENLAHPILAE HBFGJCCHDIH;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float FLAHPNONNGA;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float OMAECEEAPDI;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float AHFFMDIHGNA;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float MKAGBNCMBKL;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float PNHMDGANOLJ;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float HKBDBPJFFCG;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float PJBOJMIJOFA;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float CPCCCKAMGGD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool EAONDIFGEEN;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static PJOPONMMPPL EJOMCAFICIH;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool NBKOPPEINCN;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float CGFFKPJEDME;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float EJPGIBINKEN;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float HFPAIEJGNGD;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float HHELOGOFKPM;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float PKMPHCCJAAF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool EDGKFOGJEMK;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long PPDCEFGFFPB;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float EGMBLPMNHEO;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float CKAAGLJHJCD;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float KAJGKDJMGEG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int AKMEJEIIMFC;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float JJOMMAGNIKE;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool CHNEIIJCODC;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long LLONJLHBDMF;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int MANLOMAOEKA;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int ACKBMHBICEN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float CKKAFDGAPLB;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float OJKGGHMAINE;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool OJHOENCCGNL;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool BNJLANKHGDI;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float IBOBKHLEGCL;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long KGIEDJMBKPK;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long MFEBDELEEGM;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int AJKDMJOMMOF;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 PDJKEFFBNIN;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 EPFJPIMCOHM;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool MDHDPHOKIEL;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static JDODDNJMNDH HOGFHILKGJB;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long GDFDAIBBBGH;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int GNGDDJOBPDE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int HLKAJOEELDG;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int GKDCGIFNODE;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int GCFIBKPLFPJ;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int KKHBNOBDCHP;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long ECIIBJDDFFN;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int GEIIKLOOHIJ;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int NBPJMKGKHLM;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int ILHBGMCHLDD;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long BJDMBCGBMBO;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long ENOEIHACPGF;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long EJHLCIKDCFE;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long EAIHHBNGFKJ;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int GFBFOEOEILE;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int PKHFFMFEMHN;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int BNBNGLNAICK;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int JCAHEKPHHKF;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] BJDBNKNMJOD;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int CMDCLPCHJJH;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long DBGPPPLOCCN;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long GFDJKGBFIGH;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int OBLFOEIGPKK;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int EHNKAFFPDLD;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long DIILHCHKBMD;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long EJCBNBAFING;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long NJBFAOCOGOC;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long ICMMJJMBKDK;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long PAANCEKPLOK;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long PNHGMFHMDGI;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long COBPOIFGMMF;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long PEMNKBEPKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long DPLPHCLKDFK;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float HGFJDNAHMLB;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float LMEDHLFDKHM;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long GJILJCLACHB;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int CAGNDGKKMGI;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long CDBAEMEBCHM;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long KMOCACAOBGK;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float AHILMJEIMGP;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long PMPJHAADJCF;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long OGHEJJONHDG;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long MKKBHLGIKAN;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long KBAAKLKIACA;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long CENHOFGLPKJ;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long OFMCMALKEIH;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long CAGMJCIBHLL;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long HNPAHDMKMKE;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long HKBEOBKJLBN;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long KOIIHLMMAHP;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long PPCCKIDPBJF;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long HOGAJCKBEOI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static JAIBANNHBMG AOLMBBDPEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E13CC0", Offset = "0x7E12EC0", VA = "0x187E13CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long FPLEKBKLLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7E14C90", Offset = "0x7E13E90", VA = "0x187E14C90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E14CF0", Offset = "0x7E13EF0", VA = "0x187E14CF0")]
	public static void LIIMPHOCJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E13D10", Offset = "0x7E12F10", VA = "0x187E13D10")]
	public static void CEGKPCDLEOJ(JAIBANNHBMG PKAGJECOJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GDBLNNIJBNA
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct NELPDDDAANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 MILMNOPOIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Quaternion DDKKAJIGLLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float NLABEFHONMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Quaternion FKEMLPJMKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float NMCCDDEFKBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float EEKJMDADOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public float IFPCJKMANFB;
	}

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static List<NELPDDDAANL> PMCACHKOHFD;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E126A0", Offset = "0x7E118A0", VA = "0x187E126A0")]
	public static NativeList<FOAHBAFICDA> IPEEPGJCHEG(POJLDBNILMM ALLIBLOLGHD)
	{
		return default(NativeList<FOAHBAFICDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E12C30", Offset = "0x7E11E30", VA = "0x187E12C30")]
	private static bool MNEECHLEACG(int HPPAPFGKKNG, NativeList<FOAHBAFICDA> ACALKMLJJOL, List<NELPDDDAANL> JMHAJFOJCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E10AB0", Offset = "0x7E0FCB0", VA = "0x187E10AB0")]
	private static FOAHBAFICDA AFFEBEMCFIP(int CIAPLOIMNOJ, List<NELPDDDAANL> JMHAJFOJCBL)
	{
		return default(FOAHBAFICDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E121B0", Offset = "0x7E113B0", VA = "0x187E121B0")]
	private static FOAHBAFICDA HHCJGPGKEMK(int CIAPLOIMNOJ, List<NELPDDDAANL> JMHAJFOJCBL)
	{
		return default(FOAHBAFICDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E120D0", Offset = "0x7E112D0", VA = "0x187E120D0")]
	private static FOAHBAFICDA GAPJKGJCFEF(Vector3 ICPEADDPOJA, Quaternion DIFHEMCKFDL, float DKGEGBLOEHH)
	{
		return default(FOAHBAFICDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E10C30", Offset = "0x7E0FE30", VA = "0x187E10C30")]
	public static NativeList<FOAHBAFICDA> ELNNOLOFGPM(POJLDBNILMM ALLIBLOLGHD, float NDMFCLKMKKL)
	{
		return default(NativeList<FOAHBAFICDA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JDMKLPAABOK
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 FODGCDHIFAO;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static Vector3 PPAEBKOMBKN;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly float PCOOAOOKHGG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E15DD0", Offset = "0x7E14FD0", VA = "0x187E15DD0")]
	public static Vector3 FFANOCGFMEK(Vector3 PGEAPLACEND, Quaternion DIFHEMCKFDL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E16BF0", Offset = "0x7E15DF0", VA = "0x187E16BF0")]
	public static Vector3 NAJJPMPEHOC(Quaternion NDOBKEDDJAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E16050", Offset = "0x7E15250", VA = "0x187E16050")]
	public static Vector3 FLFAAJCPPBK(Quaternion NDOBKEDDJAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E15D50", Offset = "0x7E14F50", VA = "0x187E15D50")]
	public static Quaternion CEBCNINMMPF(Vector3 JBACNGDELHL, Vector3 BNGNHOGLPHP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E16A00", Offset = "0x7E15C00", VA = "0x187E16A00")]
	public static Vector3 MGAHKEJGFOI(Vector3 MGACMOJMLCB, Vector3 AMIOAAEDIOF, Vector3 BNGNHOGLPHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E16450", Offset = "0x7E15650", VA = "0x187E16450")]
	public static Vector3 KEFPLGNLNGN(Vector3 PGEAPLACEND, Vector3 BNGNHOGLPHP, Quaternion NDOBKEDDJAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7E160F0", Offset = "0x7E152F0", VA = "0x187E160F0")]
	public static Quaternion KAFKJEENOMC(Quaternion DIFHEMCKFDL, Vector3 JBACNGDELHL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E16880", Offset = "0x7E15A80", VA = "0x187E16880")]
	public static bool MFPALBIEMHG(Vector3 DIBLDNIEIOM, Vector3 ILLDLPKNHBL, [Out] Vector3 HGJENMIPHNG, bool INCAMAHHFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E16C90", Offset = "0x7E15E90", VA = "0x187E16C90")]
	public static Vector3 PHEKNCHCNDP(bool LOPBMEFACOM, [Optional] Quaternion AKNIBADBPBG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FOAHBAFICDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3 MILMNOPOIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float3x3 DDKKAJIGLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float NLABEFHONMO;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface POJLDBNILMM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int DAIEFNGNGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 MGEIKIPABMM(int CIAPLOIMNOJ);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion LGNNOJCHMEG(int CIAPLOIMNOJ);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float LHMJLOEGPPO(int CIAPLOIMNOJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EABGNPNGALB : MOBKHCNBNPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool FGNNFPEONOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool ADDNJIJFNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float FHGBEKFLKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int DHGLNINDJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool IAFBBNJPGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int PHIICBAEOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<FOAHBAFICDA> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FBCEMHOLLKI : MOBKHCNBNPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CALBLPNDMED OAHCAKNONAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KGILOAPKIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 ICEOJFKEGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JOPFHDFGJHL
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DONKIJIPKJK DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	OGAOHBCKIEK EEDOPDOLPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MOBKHCNBNPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CFLIEIANFIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MHEGCBOLCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DONKIJIPKJK DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS ONJOOEENMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float ICLFNBIPKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 JGNNJPINBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	IPAPAOLOGOE LLHGCBGBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	JMKIOIDBFKN OAKAJGINBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MFHLEMCNGOL
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int DHPHIMBIFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform GGBLJGCLIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool JIDFLIJAFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GPGLHFGDHFI GetBone(int CIAPLOIMNOJ);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int CIAPLOIMNOJ);
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
