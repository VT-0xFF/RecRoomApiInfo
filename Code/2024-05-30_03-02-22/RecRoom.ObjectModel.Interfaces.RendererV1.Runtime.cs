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
public enum LOPNFEIOLHG
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
public enum IGEOLMBFFAJ
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
	FrozenHover
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JAJPAKDCEHB
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NIKPIFJFKAD
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GFBGGLPIGEH
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum AEMMBGBKIIN
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RRO_MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	RRO_COLORS_COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	RRO_MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	GENERATED_MIN_VALUE = 1000,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	GENERATED_COLORS_BITS_PER_CHANNEL = 8,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	GENERATED_COLORS_COUNT = 16777216,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	GENERATED_MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	LEGACY_GENERATED_COLORS_COUNT = 4096,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	GENERATED_TO_GPU_OFFSET = -939,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NPOBPEMJMNI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64DAEF0", Offset = "0x64DA0F0", VA = "0x1864DAEF0")]
	public static bool HMPABMEKBHF(this AEMMBGBKIIN OFJABNGOMJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64DAEE0", Offset = "0x64DA0E0", VA = "0x1864DAEE0")]
	public static bool EJALDKGCHDM(this AEMMBGBKIIN OFJABNGOMJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64DAF10", Offset = "0x64DA110", VA = "0x1864DAF10")]
	public static bool OMMDPBAJJPO(this AEMMBGBKIIN OFJABNGOMJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OFBMKGPINAP
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HKHDANCCDGC : OPLAPEEBMGF, IEquatable<HKHDANCCDGC>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int DMDPAHAMEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9CBB80", Offset = "0x9CAD80", VA = "0x1809CBB80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int BAGLMBHIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24131E0", Offset = "0x24123E0", VA = "0x1824131E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5819400", Offset = "0x5818600", VA = "0x185819400", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DOILPLLJOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64D6830", Offset = "0x64D5A30", VA = "0x1864D6830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9D20", Offset = "0x1DB8F20", VA = "0x181DB9D20", Slot = "8")]
	public bool Equals(HKHDANCCDGC JPLJHFMPDFD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x63BE6C0", Offset = "0x63BD8C0", VA = "0x1863BE6C0")]
	public static bool IICOCCMJGPI(HKHDANCCDGC BPOHBPAMNLC, HKHDANCCDGC NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64D6870", Offset = "0x64D5A70", VA = "0x1864D6870", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64D6910", Offset = "0x64D5B10", VA = "0x1864D6910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct COCKNJGLIBC : OPLAPEEBMGF, IEquatable<COCKNJGLIBC>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int DMDPAHAMEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9CBB80", Offset = "0x9CAD80", VA = "0x1809CBB80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int BAGLMBHIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x24131E0", Offset = "0x24123E0", VA = "0x1824131E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5819400", Offset = "0x5818600", VA = "0x185819400", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DOILPLLJOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x64D3170", Offset = "0x64D2370", VA = "0x1864D3170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9D20", Offset = "0x1DB8F20", VA = "0x181DB9D20", Slot = "8")]
	public bool Equals(COCKNJGLIBC JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64D31B0", Offset = "0x64D23B0", VA = "0x1864D31B0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64D3250", Offset = "0x64D2450", VA = "0x1864D3250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OKFEHJAHLJI : OPLAPEEBMGF, IEquatable<OKFEHJAHLJI>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int DMDPAHAMEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9CBB80", Offset = "0x9CAD80", VA = "0x1809CBB80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BAGLMBHIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x24131E0", Offset = "0x24123E0", VA = "0x1824131E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5819400", Offset = "0x5818600", VA = "0x185819400", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DOILPLLJOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x64DAF40", Offset = "0x64DA140", VA = "0x1864DAF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9D20", Offset = "0x1DB8F20", VA = "0x181DB9D20", Slot = "8")]
	public bool Equals(OKFEHJAHLJI JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x64DAF80", Offset = "0x64DA180", VA = "0x1864DAF80", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KKILDLONEMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFLHGKFNBJH(HKHDANCCDGC LNOFAKNEFAA, IGEOLMBFFAJ CLCCJLMKKCB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFLHGKFNBJH(COCKNJGLIBC FAMHFANMELI, IGEOLMBFFAJ CLCCJLMKKCB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KECLDBJBLJG(COCKNJGLIBC FAMHFANMELI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NNLHCGMEOGA(COCKNJGLIBC FAMHFANMELI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDNMNJAJHHB();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNMOLAGECOI(IGEOLMBFFAJ HHJOOHJDNNM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJBNFEENJCF(HKHDANCCDGC LNOFAKNEFAA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KJBNFEENJCF(COCKNJGLIBC FAMHFANMELI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HAEEEKLCBEE(COCKNJGLIBC FAMHFANMELI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BOILFKECFEB(COCKNJGLIBC FAMHFANMELI);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JOOOIPOMGNG();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CCIHOBEAIJM();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PAJCLLJJDAO(HKHDANCCDGC LNOFAKNEFAA, GFBGGLPIGEH HHJOOHJDNNM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CEECHDKDJOA(COCKNJGLIBC FAMHFANMELI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BINGJBDENLF(COCKNJGLIBC FAMHFANMELI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DEOEEJJMMDB();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MCCHGNCBKCH(GFBGGLPIGEH HHJOOHJDNNM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BNCMKMIIJOL(HKHDANCCDGC LNOFAKNEFAA, Vector3 GFFNHNCPOHD, Vector3 HIFGBFMLJGG, Vector3 BMKGMDCEGIL, float CCNFGLKPMLB, float HBNPGELFEGC, IReadOnlyList<Camera> HGDMFBOOIMD, LOPNFEIOLHG AOCCOCACGBB);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BNCMKMIIJOL(OKFEHJAHLJI BNHHMNNEDGA, Vector3 GFFNHNCPOHD, Vector3 HIFGBFMLJGG, Vector3 BMKGMDCEGIL, float CCNFGLKPMLB, float HBNPGELFEGC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PLKBHOHMKKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool ANHFGLKDFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HKHDANCCDGC LMBOOLGCBHM(BJKIPLDPHMN JLJKEBMIIPF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKHDANCCDGC LMBOOLGCBHM(BJKIPLDPHMN JLJKEBMIIPF, bool DAGFGCLEMKL);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMHKFAKMPDH(HKHDANCCDGC LNOFAKNEFAA);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PPKLPPKKNKE(HKHDANCCDGC LNOFAKNEFAA);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	COCKNJGLIBC CHFMGFLKOLL(HKHDANCCDGC LNOFAKNEFAA, NMNEADJHGGF JLJKEBMIIPF);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	COCKNJGLIBC JGAHDIPHDHC(HKHDANCCDGC LNOFAKNEFAA, LEFNELCIOHC JLJKEBMIIPF);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INMLFNIOGFM(COCKNJGLIBC FAMHFANMELI);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HDCEMEDCKDE(COCKNJGLIBC FAMHFANMELI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OKFEHJAHLJI AFKBAHABIGJ(CEEHCEFHKOG JLJKEBMIIPF);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CIOMKKIMNFP(OKFEHJAHLJI BNHHMNNEDGA);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LMMOOBGIDKM(OKFEHJAHLJI BNHHMNNEDGA);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task LKJCOOKAJKM();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task AFJHLJFKIOH();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task GGFPIHPJOLK();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JMIBMHBFHMO();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> MDAEFBDAKHL(HKHDANCCDGC LNOFAKNEFAA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EJDJDHNGDJK
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum MNHLMJHMGGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		PercentOfMax,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		PercentByDistance,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		ScreenPixels
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum ODAICFOJPEB
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum MNEPGPOLMPK
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum ICNOJDPGJKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		ErrorCalculated,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum FKCEKCFMKBE
	{
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Quest3
	}

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static int NGPJCIPEANI;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static int DKONCCKNAMH;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static int EGBFBKLLHDL;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int GDOCEBGDOAP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int[] FLIGNNJACGF;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int KHBLINKIEME;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int HGPGGNOFDFE;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static int BKHDKBDCKCE;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static long CGPCOEKJJHP;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static long FEKBIGCPEAH;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static long OMOMLGJNBJL;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static long LPJEDPIOFGJ;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long OMKKHOLNPNK;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long GANNIHCPEOF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static long FGNLDKEBKAP;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static long DEEPFBFCOBJ;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static long EPBKGEHDEPK;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static long CMIMLELBDCJ;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static long AKKCDDIINKD;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static long PPNHDFNBCBK;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static float DNBGCKGIOBA;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long ELHFGGHDDEI;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long DOJPFLIOLLI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool FAKAANAOHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x64D5C50", Offset = "0x64D4E50", VA = "0x1864D5C50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x64D4200", Offset = "0x64D3400", VA = "0x1864D4200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static FKCEKCFMKBE DLOIFDNHKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x64D3570", Offset = "0x64D2770", VA = "0x1864D3570")]
		[CompilerGenerated]
		get
		{
			return default(FKCEKCFMKBE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x64D5EC0", Offset = "0x64D50C0", VA = "0x1864D5EC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool LDIKLPDLPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x64D4260", Offset = "0x64D3460", VA = "0x1864D4260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x64D3460", Offset = "0x64D2660", VA = "0x1864D3460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static MNHLMJHMGGN APBFPEFNHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x64D5A00", Offset = "0x64D4C00", VA = "0x1864D5A00")]
		[CompilerGenerated]
		get
		{
			return default(MNHLMJHMGGN);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x64D5D00", Offset = "0x64D4F00", VA = "0x1864D5D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool CCKNPLDCGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x64D5AA0", Offset = "0x64D4CA0", VA = "0x1864D5AA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x64D44A0", Offset = "0x64D36A0", VA = "0x1864D44A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static ODAICFOJPEB PMBHJGLAHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x64D5D60", Offset = "0x64D4F60", VA = "0x1864D5D60")]
		[CompilerGenerated]
		get
		{
			return default(ODAICFOJPEB);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64D5680", Offset = "0x64D4880", VA = "0x1864D5680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool PAAJFEPKOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x64D4950", Offset = "0x64D3B50", VA = "0x1864D4950")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x64D3BE0", Offset = "0x64D2DE0", VA = "0x1864D3BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool OODKNACLIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x64D45B0", Offset = "0x64D37B0", VA = "0x1864D45B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x64D41A0", Offset = "0x64D33A0", VA = "0x1864D41A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool KDAJGOPMFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x64D3DA0", Offset = "0x64D2FA0", VA = "0x1864D3DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x64D59A0", Offset = "0x64D4BA0", VA = "0x1864D59A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float OAEKCICGKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x64D5800", Offset = "0x64D4A00", VA = "0x1864D5800")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x64D5CA0", Offset = "0x64D4EA0", VA = "0x1864D5CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int NOAPJDNFONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x64D55D0", Offset = "0x64D47D0", VA = "0x1864D55D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x64D4A50", Offset = "0x64D3C50", VA = "0x1864D4A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int DFAJOJKEGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x64D5850", Offset = "0x64D4A50", VA = "0x1864D5850")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x64D3C90", Offset = "0x64D2E90", VA = "0x1864D3C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int LBIEOIDJJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x64D3B90", Offset = "0x64D2D90", VA = "0x1864D3B90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x64D60F0", Offset = "0x64D52F0", VA = "0x1864D60F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int FBBFKJFKLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x64D42B0", Offset = "0x64D34B0", VA = "0x1864D42B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x64D4890", Offset = "0x64D3A90", VA = "0x1864D4890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int KOBEBEIIMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x64D6150", Offset = "0x64D5350", VA = "0x1864D6150")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x64D46A0", Offset = "0x64D38A0", VA = "0x1864D46A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int AOIIILNOAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64D34C0", Offset = "0x64D26C0", VA = "0x1864D34C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64D4360", Offset = "0x64D3560", VA = "0x1864D4360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int MOOFHHOMBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64D4600", Offset = "0x64D3800", VA = "0x1864D4600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64D61F0", Offset = "0x64D53F0", VA = "0x1864D61F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int NFBEODFKNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x64D5B50", Offset = "0x64D4D50", VA = "0x1864D5B50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x64D3F90", Offset = "0x64D3190", VA = "0x1864D3F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int OBKPGKBLBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64D3FF0", Offset = "0x64D31F0", VA = "0x1864D3FF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64D4090", Offset = "0x64D3290", VA = "0x1864D4090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int CFNOIFKKPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x64D5740", Offset = "0x64D4940", VA = "0x1864D5740")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x64D5F20", Offset = "0x64D5120", VA = "0x1864D5F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int BFPCODBIPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x64D3C40", Offset = "0x64D2E40", VA = "0x1864D3C40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x64D3E50", Offset = "0x64D3050", VA = "0x1864D3E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int KHAMPIOGHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x64D4560", Offset = "0x64D3760", VA = "0x1864D4560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x64D3340", Offset = "0x64D2540", VA = "0x1864D3340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static int IAPEEEIJJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x64D5DB0", Offset = "0x64D4FB0", VA = "0x1864D5DB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x64D4500", Offset = "0x64D3700", VA = "0x1864D4500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static int PKKENJOJCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x64D40F0", Offset = "0x64D32F0", VA = "0x1864D40F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x64D4700", Offset = "0x64D3900", VA = "0x1864D4700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static int NKCDIEMILAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x64D3CF0", Offset = "0x64D2EF0", VA = "0x1864D3CF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x64D5AF0", Offset = "0x64D4CF0", VA = "0x1864D5AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool PNDLKJNOHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x64D61A0", Offset = "0x64D53A0", VA = "0x1864D61A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x64D56E0", Offset = "0x64D48E0", VA = "0x1864D56E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool NKMOIABBMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x64D5A50", Offset = "0x64D4C50", VA = "0x1864D5A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x64D4830", Offset = "0x64D3A30", VA = "0x1864D4830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static MNEPGPOLMPK IAELEPMENEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x64D49A0", Offset = "0x64D3BA0", VA = "0x1864D49A0")]
		[CompilerGenerated]
		get
		{
			return default(MNEPGPOLMPK);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x64D5E00", Offset = "0x64D5000", VA = "0x1864D5E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static bool KOGICMEAPNP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x64D58A0", Offset = "0x64D4AA0", VA = "0x1864D58A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x64D4140", Offset = "0x64D3340", VA = "0x1864D4140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static float NPKDJNMEHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x64D5BA0", Offset = "0x64D4DA0", VA = "0x1864D5BA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x64D3DF0", Offset = "0x64D2FF0", VA = "0x1864D3DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static float ALIDKBDFCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x64D5FE0", Offset = "0x64D51E0", VA = "0x1864D5FE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x64D32E0", Offset = "0x64D24E0", VA = "0x1864D32E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float HINDFBFHMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x64D4040", Offset = "0x64D3240", VA = "0x1864D4040")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x64D49F0", Offset = "0x64D3BF0", VA = "0x1864D49F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static float EHOPOIHJFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x64D4650", Offset = "0x64D3850", VA = "0x1864D4650")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x64D5940", Offset = "0x64D4B40", VA = "0x1864D5940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static float COPFJHFLPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x64D58F0", Offset = "0x64D4AF0", VA = "0x1864D58F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x64D5620", Offset = "0x64D4820", VA = "0x1864D5620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static float CPKLPFPJHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x64D6030", Offset = "0x64D5230", VA = "0x1864D6030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x64D3EB0", Offset = "0x64D30B0", VA = "0x1864D3EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool BKMPBDIFPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x64D3D40", Offset = "0x64D2F40", VA = "0x1864D3D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x64D43C0", Offset = "0x64D35C0", VA = "0x1864D43C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float BKLCAHLPBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x64D5E60", Offset = "0x64D5060", VA = "0x1864D5E60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x64D33A0", Offset = "0x64D25A0", VA = "0x1864D33A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static int JGPKMJLFEGA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x64D5BF0", Offset = "0x64D4DF0", VA = "0x1864D5BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x64D47D0", Offset = "0x64D39D0", VA = "0x1864D47D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static int OILKIGGOLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x64D35C0", Offset = "0x64D27C0", VA = "0x1864D35C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x64D3400", Offset = "0x64D2600", VA = "0x1864D3400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool HAFAGMEIJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x64D5570", Offset = "0x64D4770", VA = "0x1864D5570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int PKBCIKFHLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x64D6090", Offset = "0x64D5290", VA = "0x1864D6090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x64D5F80", Offset = "0x64D5180", VA = "0x1864D5F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static float4x4 FFEONLCLFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x64D3F10", Offset = "0x64D3110", VA = "0x1864D3F10")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x64D4420", Offset = "0x64D3620", VA = "0x1864D4420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static float3 CEPLHGIEJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x64D5790", Offset = "0x64D4990", VA = "0x1864D5790")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x64D4760", Offset = "0x64D3960", VA = "0x1864D4760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static bool ACGKHOGOHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x64D48F0", Offset = "0x64D3AF0", VA = "0x1864D48F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x64D4300", Offset = "0x64D3500", VA = "0x1864D4300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static ICNOJDPGJKA CGGMKKFKMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x64D3510", Offset = "0x64D2710", VA = "0x1864D3510")]
		[CompilerGenerated]
		get
		{
			return default(ICNOJDPGJKA);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x64D6250", Offset = "0x64D5450", VA = "0x1864D6250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x64D4AB0", Offset = "0x64D3CB0", VA = "0x1864D4AB0")]
	public static void JCPAJKDNACO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x64D3620", Offset = "0x64D2820", VA = "0x1864D3620")]
	public static void APGCHADLELD(FKCEKCFMKBE LGMNIGEHBID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MKLNANNCHMI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct GLOGLGCEPEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Vector3 HFHFPGFAPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Quaternion HFLDDHFJBPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public float HBOLOFDHOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Quaternion FOJLEIKDJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public float MANDBKICCLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public float DAFGELFHOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public float DGLCCABFHHL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static List<GLOGLGCEPEC> ADFNJJOONIH;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x64D82B0", Offset = "0x64D74B0", VA = "0x1864D82B0")]
	public static NativeList<LIEHKAGFPDJ> IMMBPAOEIDB(ANKGCEKLPGL MBDIAFEJCBP)
	{
		return default(NativeList<LIEHKAGFPDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x64D9CE0", Offset = "0x64D8EE0", VA = "0x1864D9CE0")]
	private static bool LFPAAEDCHOG(int BJOOMLAOBEG, NativeList<LIEHKAGFPDJ> JBENFHJBMMN, List<GLOGLGCEPEC> PDEGHCDBAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x64DACC0", Offset = "0x64D9EC0", VA = "0x1864DACC0")]
	private static LIEHKAGFPDJ LPIIABHLBLI(int EBLANDPJDLF, List<GLOGLGCEPEC> PDEGHCDBAEK)
	{
		return default(LIEHKAGFPDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x64D7CC0", Offset = "0x64D6EC0", VA = "0x1864D7CC0")]
	private static LIEHKAGFPDJ ABOFLMLLECL(int EBLANDPJDLF, List<GLOGLGCEPEC> PDEGHCDBAEK)
	{
		return default(LIEHKAGFPDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x64D81D0", Offset = "0x64D73D0", VA = "0x1864D81D0")]
	private static LIEHKAGFPDJ DLPAEFPEHNE(Vector3 AMCKGDEABAD, Quaternion HKEEEIOLJKM, float HMEOAAPKBEC)
	{
		return default(LIEHKAGFPDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x64D8820", Offset = "0x64D7A20", VA = "0x1864D8820")]
	public static NativeList<LIEHKAGFPDJ> LDMKOOIEOHB(ANKGCEKLPGL MBDIAFEJCBP, float PHPCODGACOO)
	{
		return default(NativeList<LIEHKAGFPDJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JOJCAGMDJKL
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static Vector3 DIMDOLHNEFD;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static Vector3 KDOAEDAIOCI;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static readonly float KKELHNMDCAO;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x64D7950", Offset = "0x64D6B50", VA = "0x1864D7950")]
	public static Vector3 PDMFCOOMDEL(Vector3 DLEAGFMMAPM, Quaternion HKEEEIOLJKM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x64D7260", Offset = "0x64D6460", VA = "0x1864D7260")]
	public static Vector3 IHOLKJKNFFH(Quaternion JCCMNAMJFGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x64D71C0", Offset = "0x64D63C0", VA = "0x1864D71C0")]
	public static Vector3 GPLAOFKJABE(Quaternion JCCMNAMJFGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x64D7140", Offset = "0x64D6340", VA = "0x1864D7140")]
	public static Quaternion FAAANALFEKO(Vector3 GDLGHHBOJHM, Vector3 BGIIKDPIDDB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x64D7760", Offset = "0x64D6960", VA = "0x1864D7760")]
	public static Vector3 MNJHPMPNKMB(Vector3 LKGJNFCMOKM, Vector3 PPMMKODABEE, Vector3 BGIIKDPIDDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x64D69A0", Offset = "0x64D5BA0", VA = "0x1864D69A0")]
	public static Vector3 BGLDOLKLFAB(Vector3 DLEAGFMMAPM, Vector3 BGIIKDPIDDB, Quaternion JCCMNAMJFGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x64D6DD0", Offset = "0x64D5FD0", VA = "0x1864D6DD0")]
	public static Quaternion BNKIGCLACLF(Quaternion HKEEEIOLJKM, Vector3 GDLGHHBOJHM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x64D75F0", Offset = "0x64D67F0", VA = "0x1864D75F0")]
	public static bool KJBPMHHHMDH(Vector3 OPDACJGCJHB, Vector3 GOGJNDLEKJO, [Out] Vector3 MBNLKPDJGPN, bool PGJJCLOJDLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x64D7300", Offset = "0x64D6500", VA = "0x1864D7300")]
	public static Vector3 JODBFKLBEEK(bool LJHIBLCDMMH, [Optional] Quaternion IGJGMGHCGMP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LIEHKAGFPDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public float3 HFHFPGFAPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public float3x3 HFLDDHFJBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public float HBOLOFDHOOP;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ANKGCEKLPGL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	int GFEFKJIBLGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 JAHHNPNAEPA(int EBLANDPJDLF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion BEADEGFCLNA(int EBLANDPJDLF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float FCKIMELMMNK(int EBLANDPJDLF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LEFNELCIOHC : KLACODACEFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool AEJFDMLHLJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool PHJFDCGGHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float JENAFMLNNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	int IJJLOEJAMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool HBJEOPCNDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int NLDCMDGKFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<LIEHKAGFPDJ> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NMNEADJHGGF : KLACODACEFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JAJPAKDCEHB PHGHIAPGNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool BELGJCOEOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BJKIPLDPHMN
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KLLANJMFCIJ CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NIKPIFJFKAD IIHCDLAHLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface KLACODACEFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool BKCKLNBDMOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool FGJDBEMKJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	KLLANJMFCIJ CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float FGCOLKCDJFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Vector3 LGCLCIJLPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AEMMBGBKIIN KDFHCNNKFGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	OFBMKGPINAP CLNHGIJCHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CEEHCEFHKOG
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int BKCIMMKLICK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Transform PNEPJHOOFHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MLNPFMIPFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKHDANCCDGC GetBone(int EBLANDPJDLF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int EBLANDPJDLF);
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
