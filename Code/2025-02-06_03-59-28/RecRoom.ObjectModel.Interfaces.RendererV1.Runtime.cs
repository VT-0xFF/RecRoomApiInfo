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
public enum HKPFFIEJALG
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
public enum IIDEEAJADIF
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
public enum GMFMCBMNOIN
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
public enum MPNDAIDMIFL
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
public enum IJIMINIKDMH
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
public enum BDCLPCNFFNI
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
public static class HCBLFIHGKGK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x73D9760", Offset = "0x73D8560", VA = "0x1873D9760")]
	public static bool DOEJAHJBEIO(this BDCLPCNFFNI AIIAALEAOJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x73D9750", Offset = "0x73D8550", VA = "0x1873D9750")]
	public static bool BHDEELGANCO(this BDCLPCNFFNI AIIAALEAOJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x73D9780", Offset = "0x73D8580", VA = "0x1873D9780")]
	public static bool PBNMIOHODIG(this BDCLPCNFFNI AIIAALEAOJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OPLNEGJOKGG
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
public struct KLDPLFJBOPH : PLHKHJEHJBK, IEquatable<KLDPLFJBOPH>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int OFCLDJHOLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int CKCKCAOJJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B506C0", Offset = "0x2B4F4C0", VA = "0x182B506C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x65B1030", Offset = "0x65AFE30", VA = "0x1865B1030", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JJCPGCBCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x73DF790", Offset = "0x73DE590", VA = "0x1873DF790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x167FFC0", Offset = "0x167EDC0", VA = "0x18167FFC0", Slot = "8")]
	public bool Equals(KLDPLFJBOPH LHMPMCLNOPG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x32B5C20", Offset = "0x32B4A20", VA = "0x1832B5C20")]
	public static bool BHDCHHANDIG(KLDPLFJBOPH HJGGLHBFMKO, KLDPLFJBOPH AGAPPIBJJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x73DF6F0", Offset = "0x73DE4F0", VA = "0x1873DF6F0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x73DF7D0", Offset = "0x73DE5D0", VA = "0x1873DF7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OKIHHGKOEFK : PLHKHJEHJBK, IEquatable<OKIHHGKOEFK>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int OFCLDJHOLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int CKCKCAOJJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B506C0", Offset = "0x2B4F4C0", VA = "0x182B506C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x65B1030", Offset = "0x65AFE30", VA = "0x1865B1030", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JJCPGCBCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x73DF9E0", Offset = "0x73DE7E0", VA = "0x1873DF9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x167FFC0", Offset = "0x167EDC0", VA = "0x18167FFC0", Slot = "8")]
	public bool Equals(OKIHHGKOEFK LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x73DF940", Offset = "0x73DE740", VA = "0x1873DF940", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x73DFA20", Offset = "0x73DE820", VA = "0x1873DFA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LNAOICLPAFJ : PLHKHJEHJBK, IEquatable<LNAOICLPAFJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int OFCLDJHOLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CKCKCAOJJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B506C0", Offset = "0x2B4F4C0", VA = "0x182B506C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65B1030", Offset = "0x65AFE30", VA = "0x1865B1030", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JJCPGCBCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x73DF900", Offset = "0x73DE700", VA = "0x1873DF900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x167FFC0", Offset = "0x167EDC0", VA = "0x18167FFC0", Slot = "8")]
	public bool Equals(LNAOICLPAFJ LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x73DF860", Offset = "0x73DE660", VA = "0x1873DF860", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CKINBMACMLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPKKKEEKDED(KLDPLFJBOPH DOJENPPADJD, IIDEEAJADIF NCIPABHIJLA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPKKKEEKDED(OKIHHGKOEFK CKJIDNLNDHF, IIDEEAJADIF NCIPABHIJLA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNGJGGELGPO(OKIHHGKOEFK CKJIDNLNDHF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOFIBBDGECE(OKIHHGKOEFK CKJIDNLNDHF);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGJOAAEJHAF();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDMGPECAHHK(IIDEEAJADIF OBDHBADPJNM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMLHJGBNPLA(KLDPLFJBOPH DOJENPPADJD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JMLHJGBNPLA(OKIHHGKOEFK CKJIDNLNDHF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LEKBBBMCALB(OKIHHGKOEFK CKJIDNLNDHF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DKINCCFGFAL(OKIHHGKOEFK CKJIDNLNDHF);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DDOOHAJBEOM();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OJPCMDGIDEH();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HILBOFLDBAB(KLDPLFJBOPH DOJENPPADJD, IJIMINIKDMH OBDHBADPJNM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EBHBAIFJDKO(OKIHHGKOEFK CKJIDNLNDHF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GNHFFPFBLEH(OKIHHGKOEFK CKJIDNLNDHF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KOINBCBCMIC();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DPAPHFEGEKJ(IJIMINIKDMH OBDHBADPJNM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HMAAAGPCFFC(KLDPLFJBOPH DOJENPPADJD, Vector3 IHNAJKLAENA, Vector3 NBABABJONCA, Vector3 DCGDGGNJFJO, float HDCAALNNBKL, float CIDFJCGBHAA, IReadOnlyList<Camera> PGMIBGALBJN, HKPFFIEJALG ICGIPJGENJM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HMAAAGPCFFC(LNAOICLPAFJ GJLJFFJALNO, Vector3 IHNAJKLAENA, Vector3 NBABABJONCA, Vector3 DCGDGGNJFJO, float HDCAALNNBKL, float CIDFJCGBHAA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EHONGHPLPEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IGMDKHCJOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLDPLFJBOPH IFGKEBOHBHC(LPPLGFGBCLD JOAPLPPIFPC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KLDPLFJBOPH IFGKEBOHBHC(LPPLGFGBCLD JOAPLPPIFPC, bool EKMKMKMHMPJ);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFNGKNPGHDO(KLDPLFJBOPH DOJENPPADJD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BNCAMMDKGOF(KLDPLFJBOPH DOJENPPADJD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OKIHHGKOEFK DBPDJHAGCKD(KLDPLFJBOPH DOJENPPADJD, MPBNEJBMNDN JOAPLPPIFPC);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OKIHHGKOEFK BOPCIBCGDBI(KLDPLFJBOPH DOJENPPADJD, ELAPOOPPBIK JOAPLPPIFPC);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FJKHJKACPHB(OKIHHGKOEFK CKJIDNLNDHF);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DDJELDBFAEN(OKIHHGKOEFK CKJIDNLNDHF);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LNAOICLPAFJ DMFKNLLJJNE(NLGHHFCMPEI JOAPLPPIFPC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ENBOMGDCKIO(LNAOICLPAFJ GJLJFFJALNO);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JIDCNGKHEJG(LNAOICLPAFJ GJLJFFJALNO);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task POHHEGDLFAI();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task NAALLEAMKDB();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task AOGPMJNIJAE();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PJJOFOLNOLM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> HNKHPBJAMAO(KLDPLFJBOPH DOJENPPADJD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JLLLAALLMGP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum HEBIDMNIKFM
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum HNDDCKEKNLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum KJALDKOOHNK
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		RefreshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum DMGKDIJOEIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum MNHFKBMDDDB
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum HKBHNCEBBND
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum HBPMAEHEKMG
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum CIFJCFEKIBF
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		LAST = 101
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool MKFPKLGPCNB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static long FCDCAAIPIFJ;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float COMFNMFKLPD;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static bool AOPMHLCBDCH;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static long IHEIACKEMDO;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static int IEBJIIHIHMO;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool EOENPEBAFEE;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static HNDDCKEKNLI IPGBCNCHBLO;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float MPBAOFAAKKB;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float NGPCJPBPBOI;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static HBPMAEHEKMG KGBKGHLFMLM;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool KIMFPEOKKNE;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static float JIANHLDEFIK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static float MNNOGLEINHJ;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float MGAIOBKILFK;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float PGFKLFBECGJ;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float FLIOAHABMCE;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long AHMJJJCOIKB;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static long BGIGLPLAOHL;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static int EPPMOHOENNN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static bool JPJGBIAJABA;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static long DANCFHGFBKB;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static int LDLDEKGPINP;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static int BLPAJIHNEOK;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static int HDGHCFBNGPB;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static long FHKNBMEIFLA;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long AMOHDLBDBBD;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int FOBKHGMNGDE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int EHBKOOKGNCO;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int HLMMMGMEAKL;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static long GMIBIDKAIMO;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static long NCMNKBFKNCI;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long EOAGJMKPPLO;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static long JNKNECBDPBI;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int FGLNDNOLAJA;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int HEPCNBIKLHF;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int IJAKJJJNDMC;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int GGLCMLELPBB;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int[] ONJEKBBHLFE;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int MEOOCIFCBMB;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long KDBDMLDPHAO;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static long FFHHPMAELNA;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int FBGOJBNEIFF;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static long LOBHCBCDJKH;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long EGIAKEJJKEO;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long PFEAOFBPJNM;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long PHPKGOGNKDP;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long NKKBNOFOGAN;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static long INMHIIPIGFP;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static long LOOKJNGIGIP;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long KEIMIDJCHNH;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long EPJPPCDJOLN;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static float DKCPKDIOICJ;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long GLCDJJCLEID;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static int BIFEDDOLKGG;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long HAEBHLJCHLJ;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long LOAAPHHEJDF;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static float EMAOEJCNLFC;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long OJKPPBAKJOD;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static long GKCAEOKLEBP;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long EMLOPHODNFC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long FAPLKDADOOL;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long CMEBBKKGNIB;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long NIHNAJANOCH;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long MHBNOAJGCJP;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long MNLPALOGCNG;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long JLLFOFDNFKC;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long CBAJEOPKKAA;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long CGOMCFBOEKL;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long HNAFFBCAIOP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool CDOEAGBPBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x73DE940", Offset = "0x73DD740", VA = "0x1873DE940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x73DC780", Offset = "0x73DB580", VA = "0x1873DC780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static CIFJCFEKIBF BLGMFOFGJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x73DAB60", Offset = "0x73D9960", VA = "0x1873DAB60")]
		[CompilerGenerated]
		get
		{
			return default(CIFJCFEKIBF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x73DCB10", Offset = "0x73DB910", VA = "0x1873DCB10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool AMBELEIEKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x73DB200", Offset = "0x73DA000", VA = "0x1873DB200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x73D9FD0", Offset = "0x73D8DD0", VA = "0x1873D9FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool MKFEDKPJKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x73DB3B0", Offset = "0x73DA1B0", VA = "0x1873DB3B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73DD150", Offset = "0x73DBF50", VA = "0x1873DD150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static float GGCLBHEMOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x73DAC10", Offset = "0x73D9A10", VA = "0x1873DAC10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x73DD680", Offset = "0x73DC480", VA = "0x1873DD680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static float JEHLCMFCFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x73DAD20", Offset = "0x73D9B20", VA = "0x1873DAD20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x73DE700", Offset = "0x73DD500", VA = "0x1873DE700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static int PKNLLEGPCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x73DA460", Offset = "0x73D9260", VA = "0x1873DA460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x73D9DF0", Offset = "0x73D8BF0", VA = "0x1873D9DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static HKBHNCEBBND FLOKOPLBNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x73DA510", Offset = "0x73D9310", VA = "0x1873DA510")]
		[CompilerGenerated]
		get
		{
			return default(HKBHNCEBBND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x73DA740", Offset = "0x73D9540", VA = "0x1873DA740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long OCBGJAKMNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x73DD5E0", Offset = "0x73DC3E0", VA = "0x1873DD5E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x73DE7C0", Offset = "0x73DD5C0", VA = "0x1873DE7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float FFPONMHDKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x73DD1B0", Offset = "0x73DBFB0", VA = "0x1873DD1B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x73DCD30", Offset = "0x73DBB30", VA = "0x1873DCD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int HDGIGDCAHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x73DCAC0", Offset = "0x73DB8C0", VA = "0x1873DCAC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x73DA290", Offset = "0x73D9090", VA = "0x1873DA290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int DANKHPPKBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x73DC9C0", Offset = "0x73DB7C0", VA = "0x1873DC9C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x73D9CE0", Offset = "0x73D8AE0", VA = "0x1873D9CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int HPLECDPAACH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x73DD100", Offset = "0x73DBF00", VA = "0x1873DD100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x73DCF10", Offset = "0x73DBD10", VA = "0x1873DCF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int DLHBHLLNNNG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x73DCA70", Offset = "0x73DB870", VA = "0x1873DCA70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x73DA5C0", Offset = "0x73D93C0", VA = "0x1873DA5C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int OPOJGIBGLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x73D9DA0", Offset = "0x73D8BA0", VA = "0x1873D9DA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x73D9D40", Offset = "0x73D8B40", VA = "0x1873D9D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int GBAHHNDHOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x73DA3B0", Offset = "0x73D91B0", VA = "0x1873DA3B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x73DAFB0", Offset = "0x73D9DB0", VA = "0x1873DAFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int LNFGDJKAAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x73DE990", Offset = "0x73DD790", VA = "0x1873DE990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x73DD200", Offset = "0x73DC000", VA = "0x1873DD200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool DKNOKKBBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x73DCCE0", Offset = "0x73DBAE0", VA = "0x1873DCCE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int CILIIPHEGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x73DCB70", Offset = "0x73DB970", VA = "0x1873DCB70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x73DCD90", Offset = "0x73DBB90", VA = "0x1873DCD90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int NAPKJALHOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x73DE650", Offset = "0x73DD450", VA = "0x1873DE650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x73DAF50", Offset = "0x73D9D50", VA = "0x1873DAF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int HNBNPKEPPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x73DB2B0", Offset = "0x73DA0B0", VA = "0x1873DB2B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x73DE760", Offset = "0x73DD560", VA = "0x1873DE760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool CDOAEGDPEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x73D9930", Offset = "0x73D8730", VA = "0x1873D9930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x73DEB00", Offset = "0x73DD900", VA = "0x1873DEB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float PKAMINIEHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x73DB300", Offset = "0x73DA100", VA = "0x1873DB300")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x73DA560", Offset = "0x73D9360", VA = "0x1873DA560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static bool CIOPPEOCJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x73DD630", Offset = "0x73DC430", VA = "0x1873DD630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x73DA090", Offset = "0x73D8E90", VA = "0x1873DA090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool FNMCBEIPCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x73DD380", Offset = "0x73DC180", VA = "0x1873DD380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x73DC960", Offset = "0x73DB760", VA = "0x1873DC960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static HEBIDMNIKFM NCIAMGIBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x73DA800", Offset = "0x73D9600", VA = "0x1873DA800")]
		[CompilerGenerated]
		get
		{
			return default(HEBIDMNIKFM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x73DB350", Offset = "0x73DA150", VA = "0x1873DB350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool LJCPOBDHKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x73DEA40", Offset = "0x73DD840", VA = "0x1873DEA40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x73DB250", Offset = "0x73DA050", VA = "0x1873DB250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool BIIAOGEGMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x73DD580", Offset = "0x73DC380", VA = "0x1873DD580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x73DA680", Offset = "0x73D9480", VA = "0x1873DA680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int IOKFHNMNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x73DAEF0", Offset = "0x73D9CF0", VA = "0x1873DAEF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x73DCF70", Offset = "0x73DBD70", VA = "0x1873DCF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int KDNMONPMHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x73DCFD0", Offset = "0x73DBDD0", VA = "0x1873DCFD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x73DA6E0", Offset = "0x73D94E0", VA = "0x1873DA6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int LPOGKEGKDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x73D9C20", Offset = "0x73D8A20", VA = "0x1873D9C20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x73D98D0", Offset = "0x73D86D0", VA = "0x1873D98D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int ECFMPMINOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x73DA980", Offset = "0x73D9780", VA = "0x1873DA980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x73D9C80", Offset = "0x73D8A80", VA = "0x1873D9C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static int LONAOEHAFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x73D9F70", Offset = "0x73D8D70", VA = "0x1873D9F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x73DA920", Offset = "0x73D9720", VA = "0x1873DA920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static int MJMGKOEDLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x73D9980", Offset = "0x73D8780", VA = "0x1873D9980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x73DC720", Offset = "0x73DB520", VA = "0x1873DC720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static int DFOGNGMJCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x73D9A40", Offset = "0x73D8840", VA = "0x1873D9A40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x73DE820", Offset = "0x73DD620", VA = "0x1873DE820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static int JEKDLLHPNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x73DADD0", Offset = "0x73D9BD0", VA = "0x1873DADD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x73DCE50", Offset = "0x73DBC50", VA = "0x1873DCE50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float KMOLCGEEFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x73DC900", Offset = "0x73DB700", VA = "0x1873DC900")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x73D9E50", Offset = "0x73D8C50", VA = "0x1873D9E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float JDPKADEEHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x73DA9E0", Offset = "0x73D97E0", VA = "0x1873DA9E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x73DA1D0", Offset = "0x73D8FD0", VA = "0x1873DA1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float APJNBMOMJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x73DC6C0", Offset = "0x73DB4C0", VA = "0x1873DC6C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x73DB0E0", Offset = "0x73D9EE0", VA = "0x1873DB0E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int JAKMGKJHNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x73DD260", Offset = "0x73DC060", VA = "0x1873DD260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x73DC7E0", Offset = "0x73DB5E0", VA = "0x1873DC7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int ADHHOPLKILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x73DE6A0", Offset = "0x73DD4A0", VA = "0x1873DE6A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x73DAB00", Offset = "0x73D9900", VA = "0x1873DAB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static int IBOLLOLNGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x73DA170", Offset = "0x73D8F70", VA = "0x1873DA170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x73DABB0", Offset = "0x73D99B0", VA = "0x1873DABB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int JBOPLGFBJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x73DC8A0", Offset = "0x73DB6A0", VA = "0x1873DC8A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x73DD0A0", Offset = "0x73DBEA0", VA = "0x1873DD0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static bool IGDBFJNJHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x73D9B00", Offset = "0x73D8900", VA = "0x1873D9B00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x73DA860", Offset = "0x73D9660", VA = "0x1873DA860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static KJALDKOOHNK PLKJONCFJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x73DC840", Offset = "0x73DB640", VA = "0x1873DC840")]
		[CompilerGenerated]
		get
		{
			return default(KJALDKOOHNK);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x73D9BC0", Offset = "0x73D89C0", VA = "0x1873D9BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static DMGKDIJOEIH LOHKLLOCALB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x73DA400", Offset = "0x73D9200", VA = "0x1873DA400")]
		[CompilerGenerated]
		get
		{
			return default(DMGKDIJOEIH);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x73D9EB0", Offset = "0x73D8CB0", VA = "0x1873D9EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool PAMPMDPJAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x73DB1A0", Offset = "0x73D9FA0", VA = "0x1873DB1A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x73DA8C0", Offset = "0x73D96C0", VA = "0x1873DA8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static float MEBMDNAKEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x73D9870", Offset = "0x73D8670", VA = "0x1873D9870")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x73D99E0", Offset = "0x73D87E0", VA = "0x1873D99E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static float PPKBLFMIOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x73DD3E0", Offset = "0x73DC1E0", VA = "0x1873DD3E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x73DD440", Offset = "0x73DC240", VA = "0x1873DD440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float IFGAGIMIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x73DB140", Offset = "0x73D9F40", VA = "0x1873DB140")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x73D9B60", Offset = "0x73D8960", VA = "0x1873D9B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float CAFADACBFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x73DCBC0", Offset = "0x73DB9C0", VA = "0x1873DCBC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x73DA4B0", Offset = "0x73D92B0", VA = "0x1873DA4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float CMEDFMMFEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x73D9F10", Offset = "0x73D8D10", VA = "0x1873D9F10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x73DA620", Offset = "0x73D9420", VA = "0x1873DA620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static float JDHEPLLFHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x73DCDF0", Offset = "0x73DBBF0", VA = "0x1873DCDF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x73DE880", Offset = "0x73DD680", VA = "0x1873DE880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static bool NFABIGNDFPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x73DA7A0", Offset = "0x73D95A0", VA = "0x1873DA7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x73DCA10", Offset = "0x73DB810", VA = "0x1873DCA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float MFMGNLCPNKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x73DAA40", Offset = "0x73D9840", VA = "0x1873DAA40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x73DB010", Offset = "0x73D9E10", VA = "0x1873DB010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static float JJOIBEFCKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x73DD2C0", Offset = "0x73DC0C0", VA = "0x1873DD2C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x73DE8E0", Offset = "0x73DD6E0", VA = "0x1873DE8E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static float KDPMJEBCJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x73DA230", Offset = "0x73D9030", VA = "0x1873DA230")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x73D9AA0", Offset = "0x73D88A0", VA = "0x1873D9AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static int JFCIJEIMEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x73DAE90", Offset = "0x73D9C90", VA = "0x1873DAE90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x73DAC60", Offset = "0x73D9A60", VA = "0x1873DAC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static float BBNFBDFPMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x73DCC80", Offset = "0x73DBA80", VA = "0x1873DCC80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static bool IGKPOKIGHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x73D97B0", Offset = "0x73D85B0", VA = "0x1873D97B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x73DEAA0", Offset = "0x73DD8A0", VA = "0x1873DEAA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static int MDGGEIOLLBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x73DD4A0", Offset = "0x73DC2A0", VA = "0x1873DD4A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x73DA350", Offset = "0x73D9150", VA = "0x1873DA350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static float OLKNOIPFGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x73DAAA0", Offset = "0x73D98A0", VA = "0x1873DAAA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x73DA2F0", Offset = "0x73D90F0", VA = "0x1873DA2F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static float FEJBBMHGMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x73DB400", Offset = "0x73DA200", VA = "0x1873DB400")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x73DD320", Offset = "0x73DC120", VA = "0x1873DD320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static bool NJCPDDFLMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x73DAD70", Offset = "0x73D9B70", VA = "0x1873DAD70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x73DAE30", Offset = "0x73D9C30", VA = "0x1873DAE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public static float PEBFHECHCCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x73D9810", Offset = "0x73D8610", VA = "0x1873D9810")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x73DE9E0", Offset = "0x73DD7E0", VA = "0x1873DE9E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public static float4x4 EHGMGBHMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x73DA0F0", Offset = "0x73D8EF0", VA = "0x1873DA0F0")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x73DD500", Offset = "0x73DC300", VA = "0x1873DD500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static float3 EHGFGLEHBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x73DD030", Offset = "0x73DBE30", VA = "0x1873DD030")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x73DB070", Offset = "0x73D9E70", VA = "0x1873DB070")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static bool CGEKOEOLAED
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x73DCC20", Offset = "0x73DBA20", VA = "0x1873DCC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x73DACC0", Offset = "0x73D9AC0", VA = "0x1873DACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static MNHFKBMDDDB ABCOCLEBHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x73DCEB0", Offset = "0x73DBCB0", VA = "0x1873DCEB0")]
		[CompilerGenerated]
		get
		{
			return default(MNHFKBMDDDB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x73DA030", Offset = "0x73D8E30", VA = "0x1873DA030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x73DB460", Offset = "0x73DA260", VA = "0x1873DB460")]
	public static void IDBOIMJNHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x73DD6E0", Offset = "0x73DC4E0", VA = "0x1873DD6E0")]
	public static void OGGKLOIILJJ(CIFJCFEKIBF JGKBLADLDMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DDOEOIGGCHP
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct FPLCKFJPNJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Vector3 FJDJKDCINHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Quaternion FJBLNCDHDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public float LGDFBOABPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public Quaternion DIMOKLAMAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public float BOMEMDDANAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public float NOPAHNBIAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public float DNJHNFGIIFP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static List<FPLCKFJPNJK> DNFKKIIIGHF;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x73D68E0", Offset = "0x73D56E0", VA = "0x1873D68E0")]
	public static NativeList<HNPJEHHNIMF> HEDHPBFGGJC(PGOLGEJEGCP AMHAHGPNKPL)
	{
		return default(NativeList<HNPJEHHNIMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x73D7370", Offset = "0x73D6170", VA = "0x1873D7370")]
	private static bool MBOKDNBDCED(int JELBMBFLBOP, NativeList<HNPJEHHNIMF> LDEANEOLAOA, List<FPLCKFJPNJK> OOGMCEJHKKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x73D8220", Offset = "0x73D7020", VA = "0x1873D8220")]
	private static HNPJEHHNIMF OEKJOEAKKIL(int NBNGIGCCLIC, List<FPLCKFJPNJK> OOGMCEJHKKC)
	{
		return default(HNPJEHHNIMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x73D6E80", Offset = "0x73D5C80", VA = "0x1873D6E80")]
	private static HNPJEHHNIMF JMOLOCACLKA(int NBNGIGCCLIC, List<FPLCKFJPNJK> OOGMCEJHKKC)
	{
		return default(HNPJEHHNIMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x73D5340", Offset = "0x73D4140", VA = "0x1873D5340")]
	private static HNPJEHHNIMF DCALAHININE(Vector3 COKJJHJKDKB, Quaternion DIGMAMODBCJ, float HCPBBIGLAFG)
	{
		return default(HNPJEHHNIMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x73D5420", Offset = "0x73D4220", VA = "0x1873D5420")]
	public static NativeList<HNPJEHHNIMF> HABCLJLBIOD(PGOLGEJEGCP AMHAHGPNKPL, float MLCCMJKOCPE)
	{
		return default(NativeList<HNPJEHHNIMF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class EBKNHGOBDNG
{
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public static Vector3 LCDMHJCLCGK;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public static Vector3 LEFKMJCNBBN;

	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public static readonly float CIHEABJHJNF;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x73D8E30", Offset = "0x73D7C30", VA = "0x1873D8E30")]
	public static Vector3 JNJELDHGCOF(Vector3 MFFKIHONLPJ, Quaternion DIGMAMODBCJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x73D8D90", Offset = "0x73D7B90", VA = "0x1873D8D90")]
	public static Vector3 IFIJCGINBAC(Quaternion CKABIAOPKPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x73D84B0", Offset = "0x73D72B0", VA = "0x1873D84B0")]
	public static Vector3 DKDBHKDDAHK(Quaternion CKABIAOPKPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x73D8430", Offset = "0x73D7230", VA = "0x1873D8430")]
	public static Quaternion CJHOCOGPJCN(Vector3 GGAAGAFEPHJ, Vector3 FOPIBLDPFFK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x73D8840", Offset = "0x73D7640", VA = "0x1873D8840")]
	public static Vector3 GLGMFPOGIGF(Vector3 LFPFEOJKDMB, Vector3 MHEHIGMFPBA, Vector3 FOPIBLDPFFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x73D90C0", Offset = "0x73D7EC0", VA = "0x1873D90C0")]
	public static Vector3 LOFFBBFIOHN(Vector3 MFFKIHONLPJ, Vector3 FOPIBLDPFFK, Quaternion CKABIAOPKPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x73D8A30", Offset = "0x73D7830", VA = "0x1873D8A30")]
	public static Quaternion GOEMOHHGAOM(Quaternion DIGMAMODBCJ, Vector3 GGAAGAFEPHJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x73D94F0", Offset = "0x73D82F0", VA = "0x1873D94F0")]
	public static bool OJDLNNPDJOJ(Vector3 IHOFAKBAJCD, Vector3 FDKHNGLDBNI, [Out] Vector3 JNNHIJLBOAM, bool NPHIMNPPKML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x73D8550", Offset = "0x73D7350", VA = "0x1873D8550")]
	public static Vector3 GDIJNFCBMLP(bool JDLMAKBCKMA, [Optional] Quaternion CCFGPNLMACN)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HNPJEHHNIMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public float3 FJDJKDCINHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public float3x3 FJBLNCDHDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public float LGDFBOABPBI;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PGOLGEJEGCP
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	int CKIFJGLDFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 LNKEMEINJKF(int NBNGIGCCLIC);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion LPDPKNEFEKF(int NBNGIGCCLIC);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float FODBJAHEPEE(int NBNGIGCCLIC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface ELAPOOPPBIK : PJDOFLMGJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool FPBDAGOKOFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool BEDNAGIDLBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float MGPEOPDMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	int LECAHJFFKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OPPCEGHPOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int CBBLDBCKHME
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<HNPJEHHNIMF> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MPBNEJBMNDN : PJDOFLMGJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	GMFMCBMNOIN NLDIOBKAKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool DPEGJFFOJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float3 FJJPNKGFBDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LPPLGFGBCLD
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	IDOAIIMFGBF HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	MPNDAIDMIFL OHNCPBDNLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PJDOFLMGJLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool ILEFMALIOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool NBKNLNNCCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IDOAIIMFGBF HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	UniformTRS CDLNBCPGOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float AHNHFKIEELE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	Vector3 PINLPOOADFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	BDCLPCNFFNI NBJJHEIJHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	OPLNEGJOKGG ILMECLJILMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NLGHHFCMPEI
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int GFLFDJJDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Transform HCKAPHIJFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool AKOLPGIGBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KLDPLFJBOPH GetBone(int NBNGIGCCLIC);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int NBNGIGCCLIC);
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
