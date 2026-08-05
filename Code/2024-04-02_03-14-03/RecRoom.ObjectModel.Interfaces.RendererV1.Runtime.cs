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
public enum LFMHGJAEOHE
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
public enum HMGGEEBIJCM
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
public enum HGGBAPPCPHG
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
public enum PIIDANLABNO
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
public enum JCCMDILNKCC
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
public enum NGIEHFKGLDJ
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
public static class DNJGOJCHOLB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61E9CD0", Offset = "0x61E88D0", VA = "0x1861E9CD0")]
	public static bool DJDNGENMODB(this NGIEHFKGLDJ KIMBDFBIAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61E9CF0", Offset = "0x61E88F0", VA = "0x1861E9CF0")]
	public static bool IFDAMEJGIPE(this NGIEHFKGLDJ KIMBDFBIAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61E9D00", Offset = "0x61E8900", VA = "0x1861E9D00")]
	public static bool JNLAIICAIKD(this NGIEHFKGLDJ KIMBDFBIAPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HJOGNBOCCHO
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
public struct GDGJGEMFAOL : ONPNDKJAMEL, IEquatable<GDGJGEMFAOL>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int KGAKPAMIIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8F7FF0", Offset = "0x8F6BF0", VA = "0x1808F7FF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int MONJDGNGJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22BBEE0", Offset = "0x22BAAE0", VA = "0x1822BBEE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x556DF40", Offset = "0x556CB40", VA = "0x18556DF40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CBDMCJHEAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61E9DC0", Offset = "0x61E89C0", VA = "0x1861E9DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D08520", Offset = "0x1D07120", VA = "0x181D08520", Slot = "8")]
	public bool Equals(GDGJGEMFAOL NAFFCAIMPLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61290A0", Offset = "0x6127CA0", VA = "0x1861290A0")]
	public static bool MGCOHCIMIFH(GDGJGEMFAOL PKCAMDKHNLN, GDGJGEMFAOL ECIMPLOCMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x61E9D30", Offset = "0x61E8930", VA = "0x1861E9D30", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61E9E00", Offset = "0x61E8A00", VA = "0x1861E9E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BEJCAKPHPBK : ONPNDKJAMEL, IEquatable<BEJCAKPHPBK>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int KGAKPAMIIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F7FF0", Offset = "0x8F6BF0", VA = "0x1808F7FF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int MONJDGNGJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x22BBEE0", Offset = "0x22BAAE0", VA = "0x1822BBEE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x556DF40", Offset = "0x556CB40", VA = "0x18556DF40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CBDMCJHEAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61E88E0", Offset = "0x61E74E0", VA = "0x1861E88E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D08520", Offset = "0x1D07120", VA = "0x181D08520", Slot = "8")]
	public bool Equals(BEJCAKPHPBK NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61E8850", Offset = "0x61E7450", VA = "0x1861E8850", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x61E8920", Offset = "0x61E7520", VA = "0x1861E8920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ANFCEGGLFPJ : ONPNDKJAMEL, IEquatable<ANFCEGGLFPJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int KGAKPAMIIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8F7FF0", Offset = "0x8F6BF0", VA = "0x1808F7FF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int MONJDGNGJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x22BBEE0", Offset = "0x22BAAE0", VA = "0x1822BBEE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x556DF40", Offset = "0x556CB40", VA = "0x18556DF40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CBDMCJHEAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x61E8810", Offset = "0x61E7410", VA = "0x1861E8810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D08520", Offset = "0x1D07120", VA = "0x181D08520", Slot = "8")]
	public bool Equals(ANFCEGGLFPJ NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61E8780", Offset = "0x61E7380", VA = "0x1861E8780", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OCBJEKIAPBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFIFNOMKFPK(GDGJGEMFAOL EBCHPMPLBLG, HMGGEEBIJCM PGMGJAILCNF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFIFNOMKFPK(BEJCAKPHPBK GHGFIHJAPCA, HMGGEEBIJCM PGMGJAILCNF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OGOANHDCKIK(BEJCAKPHPBK GHGFIHJAPCA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHIODCJCJMF(BEJCAKPHPBK GHGFIHJAPCA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNFGMFFIAGL();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DHADEEIJAMO(HMGGEEBIJCM CJEAJMFMNNJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DBFCPBLCKJH(GDGJGEMFAOL EBCHPMPLBLG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DBFCPBLCKJH(BEJCAKPHPBK GHGFIHJAPCA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HCHMHFPHFBF(BEJCAKPHPBK GHGFIHJAPCA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JOOEKPMNHGE(BEJCAKPHPBK GHGFIHJAPCA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KABFJPMMKPG();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OCKBGDLEIHN();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PJPHPPBHLKJ(GDGJGEMFAOL EBCHPMPLBLG, JCCMDILNKCC CJEAJMFMNNJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FFNGAHJOEHJ(BEJCAKPHPBK GHGFIHJAPCA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KOFLDEOMNAM(BEJCAKPHPBK GHGFIHJAPCA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CPOJBJOOANG();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EIHAGGGHMDE(JCCMDILNKCC CJEAJMFMNNJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PMLONMOOBNN(GDGJGEMFAOL EBCHPMPLBLG, Vector3 LOGLFFPDJCF, Vector3 INDJPNEIEFC, Vector3 PNIIKGJPKAN, float LNJNBNBOBMH, float JKPOAOJGEDN, IReadOnlyList<Camera> JKLOKCPCPMG, LFMHGJAEOHE CGHANBJGMFG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PMLONMOOBNN(ANFCEGGLFPJ PAIDENBGKAD, Vector3 LOGLFFPDJCF, Vector3 INDJPNEIEFC, Vector3 PNIIKGJPKAN, float LNJNBNBOBMH, float JKPOAOJGEDN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LBCGJIALOHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FDPPGOJDGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GDGJGEMFAOL BGGBPFJJGIC(NOFCJBHOLNF KOMCCCIEHEA);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GDGJGEMFAOL BGGBPFJJGIC(NOFCJBHOLNF KOMCCCIEHEA, bool JGKHBENDGHI);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMHDMHALJPH(GDGJGEMFAOL EBCHPMPLBLG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ACLBDBEAGAP(GDGJGEMFAOL EBCHPMPLBLG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BEJCAKPHPBK ICKINJMHIPJ(GDGJGEMFAOL EBCHPMPLBLG, EPLALJMPDDH KOMCCCIEHEA);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BEJCAKPHPBK ENMGNMHDBPL(GDGJGEMFAOL EBCHPMPLBLG, BHPPBMOHNGF KOMCCCIEHEA);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOCAGBNJBLN(BEJCAKPHPBK GHGFIHJAPCA);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FDIGHNALLKL(BEJCAKPHPBK GHGFIHJAPCA);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ANFCEGGLFPJ HKOCBEEPEFA(OCMKIDMEEDJ KOMCCCIEHEA);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HINLOFBMEIE(ANFCEGGLFPJ PAIDENBGKAD);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HGMFKCMJNIO(ANFCEGGLFPJ PAIDENBGKAD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task IOJKAGINOKK();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task FPJPOOPOEOH();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FMAIKLFDJMC();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KGKNDCLGIPE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> FAFGILOFOKP(GDGJGEMFAOL EBCHPMPLBLG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NCAPBOHNMJP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum BKFFNNCCIHD
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		PercentOfMax,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		PercentByDistance,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		ScreenPixels
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum JKLJBFEDOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum EGPHAKDPEPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum FOIPNNCMLMF
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		Slight,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		AveragePC,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		Mobile,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		OldMobile,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		OutOfMemory
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static bool PCCAFGNEDPM;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int HMENJDBIIMJ;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int LNMDPJAGINH;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int LFJCKOIMPEN;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int DEGADFMCCGP;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int FAMDKFNPBFE;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int APFKEOOCBFO;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int ODPOCGPFOGP;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static int NODIJDNDDHG;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static long HCJKFNOGCJM;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static long EIEIDKKNHLJ;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static long DJIADGIPHKD;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static long MOGPDMAAMOM;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static long OJAGLHJLFJO;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static long JIMKGIFOLMJ;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static long JHMHIPMHCCH;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static long EDEEIJIFFEL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static FOIPNNCMLMF JEJKAFLFKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x61EB110", Offset = "0x61E9D10", VA = "0x1861EB110")]
		[CompilerGenerated]
		get
		{
			return default(FOIPNNCMLMF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x61EA4C0", Offset = "0x61E90C0", VA = "0x1861EA4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static BKFFNNCCIHD CDJALHMMBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x61E9EE0", Offset = "0x61E8AE0", VA = "0x1861E9EE0")]
		[CompilerGenerated]
		get
		{
			return default(BKFFNNCCIHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x61EA5D0", Offset = "0x61E91D0", VA = "0x1861EA5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool OJJGPJBHBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x61E9F30", Offset = "0x61E8B30", VA = "0x1861E9F30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x61EC2E0", Offset = "0x61EAEE0", VA = "0x1861EC2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static JKLJBFEDOMJ JLINJKMBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61EBDB0", Offset = "0x61EA9B0", VA = "0x1861EBDB0")]
		[CompilerGenerated]
		get
		{
			return default(JKLJBFEDOMJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x61EA150", Offset = "0x61E8D50", VA = "0x1861EA150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool FHGJFPJLGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x61EAC30", Offset = "0x61E9830", VA = "0x1861EAC30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x61EA300", Offset = "0x61E8F00", VA = "0x1861EA300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool ADFDEHKFNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x61EACD0", Offset = "0x61E98D0", VA = "0x1861EACD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x61EAF40", Offset = "0x61E9B40", VA = "0x1861EAF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static float POCILJCNDDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x61EA8E0", Offset = "0x61E94E0", VA = "0x1861EA8E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x61EA630", Offset = "0x61E9230", VA = "0x1861EA630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static int HHAHEFCJCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x61EAFA0", Offset = "0x61E9BA0", VA = "0x1861EAFA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static int ADCAAPMHKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61EA210", Offset = "0x61E8E10", VA = "0x1861EA210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x61EAD20", Offset = "0x61E9920", VA = "0x1861EAD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static int FHKPELHFBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x61EA890", Offset = "0x61E9490", VA = "0x1861EA890")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x61EA460", Offset = "0x61E9060", VA = "0x1861EA460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int LIBDNGKGAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x61EA410", Offset = "0x61E9010", VA = "0x1861EA410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x61EAB00", Offset = "0x61E9700", VA = "0x1861EAB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int CAEFGCJEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x61EAE30", Offset = "0x61E9A30", VA = "0x1861EAE30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x61EB0B0", Offset = "0x61E9CB0", VA = "0x1861EB0B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int OLMCOEEAIDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x61EB280", Offset = "0x61E9E80", VA = "0x1861EB280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x61EB000", Offset = "0x61E9C00", VA = "0x1861EB000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int DHLNJMCNLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x61EBCB0", Offset = "0x61EA8B0", VA = "0x1861EBCB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x61EC340", Offset = "0x61EAF40", VA = "0x1861EC340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int PIAAOFNGABP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x61EBD00", Offset = "0x61EA900", VA = "0x1861EBD00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x61EBD50", Offset = "0x61EA950", VA = "0x1861EBD50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int MAACDNNCBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x61EA0A0", Offset = "0x61E8CA0", VA = "0x1861EA0A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x61EAD80", Offset = "0x61E9980", VA = "0x1861EAD80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int LBMKNPDBBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x61EA260", Offset = "0x61E8E60", VA = "0x1861EA260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61EA520", Offset = "0x61E9120", VA = "0x1861EA520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int EBMPBMCFOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x61EB060", Offset = "0x61E9C60", VA = "0x1861EB060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x61EA9F0", Offset = "0x61E95F0", VA = "0x1861EA9F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static bool EDHMCOLIMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x61EC290", Offset = "0x61EAE90", VA = "0x1861EC290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x61EC230", Offset = "0x61EAE30", VA = "0x1861EC230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static bool ODLNIPOEOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x61EA7E0", Offset = "0x61E93E0", VA = "0x1861EA7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x61EBBF0", Offset = "0x61EA7F0", VA = "0x1861EBBF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static EGPHAKDPEPA LHMCACFIPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x61EA6E0", Offset = "0x61E92E0", VA = "0x1861EA6E0")]
		[CompilerGenerated]
		get
		{
			return default(EGPHAKDPEPA);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x61EBEA0", Offset = "0x61EAAA0", VA = "0x1861EBEA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool HBHJNJMPIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x61EADE0", Offset = "0x61E99E0", VA = "0x1861EADE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x61E9F80", Offset = "0x61E8B80", VA = "0x1861E9F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float CPHCDIMCGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x61EA730", Offset = "0x61E9330", VA = "0x1861EA730")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x61EA3B0", Offset = "0x61E8FB0", VA = "0x1861EA3B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float CGLGGPLOGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x61EA360", Offset = "0x61E8F60", VA = "0x1861EA360")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x61EAAA0", Offset = "0x61E96A0", VA = "0x1861EAAA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static float NBAFMCADNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x61EAC80", Offset = "0x61E9880", VA = "0x1861EAC80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x61EA830", Offset = "0x61E9430", VA = "0x1861EA830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static float PKKBJGINKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61EA690", Offset = "0x61E9290", VA = "0x1861EA690")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61EA780", Offset = "0x61E9380", VA = "0x1861EA780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static float IEKCONAJLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x61EAA50", Offset = "0x61E9650", VA = "0x1861EAA50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x61EBC50", Offset = "0x61EA850", VA = "0x1861EBC50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool LBLBEFHJHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x61E9E90", Offset = "0x61E8A90", VA = "0x1861E9E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x61EAE80", Offset = "0x61E9A80", VA = "0x1861EAE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static float EDCAMNJEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61EABE0", Offset = "0x61E97E0", VA = "0x1861EABE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x61EA930", Offset = "0x61E9530", VA = "0x1861EA930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int LMENILHFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x61EA580", Offset = "0x61E9180", VA = "0x1861EA580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61E9FE0", Offset = "0x61E8BE0", VA = "0x1861E9FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int DIGNIKIEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x61EBE00", Offset = "0x61EAA00", VA = "0x1861EBE00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61EB2D0", Offset = "0x61E9ED0", VA = "0x1861EB2D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int FCBMCLHCBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61EBE50", Offset = "0x61EAA50", VA = "0x1861EBE50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61EAEE0", Offset = "0x61E9AE0", VA = "0x1861EAEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool LLKIJOMNMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61EA0F0", Offset = "0x61E8CF0", VA = "0x1861EA0F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61EA990", Offset = "0x61E9590", VA = "0x1861EA990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static Transform HCJHEKKEGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61EB220", Offset = "0x61E9E20", VA = "0x1861EB220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x61EAB60", Offset = "0x61E9760", VA = "0x1861EAB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool PLEJEGGOBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x61EA1B0", Offset = "0x61E8DB0", VA = "0x1861EA1B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x61EB1C0", Offset = "0x61E9DC0", VA = "0x1861EB1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool HLJFFKBADOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61EB160", Offset = "0x61E9D60", VA = "0x1861EB160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x61EC3A0", Offset = "0x61EAFA0", VA = "0x1861EC3A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static bool AKLFBPBNPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61EA2B0", Offset = "0x61E8EB0", VA = "0x1861EA2B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x61EA040", Offset = "0x61E8C40", VA = "0x1861EA040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x61EB330", Offset = "0x61E9F30", VA = "0x1861EB330")]
	public static void MBMEFOEFABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x61EBF00", Offset = "0x61EAB00", VA = "0x1861EBF00")]
	public static void PHHGAOHHNOA(FOIPNNCMLMF NGLBNAJOPKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PGCDDODFGEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct HBJMBKNAOGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Vector3 KMIPHHDCLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Quaternion BKMOBCFEIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public float FFBKJCAKPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Quaternion POBJMDIICAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float CDKKGGHDABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public float DJNEFDKLKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public float ADPINLKBLJL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static List<HBJMBKNAOGF> AJMPJAGBFLJ;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x61ECD30", Offset = "0x61EB930", VA = "0x1861ECD30")]
	public static NativeList<JKGAAGKIBDH> EFLDCLHPBNH(FBECDJBHDPK KIGGBMJEDEA)
	{
		return default(NativeList<JKGAAGKIBDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61ED2B0", Offset = "0x61EBEB0", VA = "0x1861ED2B0")]
	private static bool FHCDJPFMCEF(int CFPNJHJGBGM, NativeList<JKGAAGKIBDH> MGHLKGJFBCD, List<HBJMBKNAOGF> FKCJGBMKIAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61EF760", Offset = "0x61EE360", VA = "0x1861EF760")]
	private static JKGAAGKIBDH JNEHCACNLBE(int NOBCGKJBAOK, List<HBJMBKNAOGF> FKCJGBMKIAO)
	{
		return default(JKGAAGKIBDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61EC820", Offset = "0x61EB420", VA = "0x1861EC820")]
	private static JKGAAGKIBDH CLKEEGHAFOH(int NOBCGKJBAOK, List<HBJMBKNAOGF> FKCJGBMKIAO)
	{
		return default(JKGAAGKIBDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x61EF8F0", Offset = "0x61EE4F0", VA = "0x1861EF8F0")]
	private static JKGAAGKIBDH MMAJKLJFNII(Vector3 IMBPOLOMLBB, Quaternion NLOMNLFGFKB, float HAPMMMMDGHH)
	{
		return default(JKGAAGKIBDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x61EE290", Offset = "0x61ECE90", VA = "0x1861EE290")]
	public static NativeList<JKGAAGKIBDH> GLKJHDGFAAO(FBECDJBHDPK KIGGBMJEDEA, float JKOJNPDLMLJ)
	{
		return default(NativeList<JKGAAGKIBDH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DGEAPIFBOCK
{
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static Vector3 FHJKKPFMGMC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static Vector3 GDDDHACOAPD;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static readonly float BMEPMEFHEEP;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61E89B0", Offset = "0x61E75B0", VA = "0x1861E89B0")]
	public static Vector3 BKIHGKAPJLH(Vector3 LLKPDAJNMCL, Quaternion NLOMNLFGFKB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x61E9B50", Offset = "0x61E8750", VA = "0x1861E9B50")]
	public static Vector3 OJKDGKJCKEB(Quaternion MJCNDCDLGEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61E9AB0", Offset = "0x61E86B0", VA = "0x1861E9AB0")]
	public static Vector3 MLHEAIBOJBK(Quaternion MJCNDCDLGEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x61E8FB0", Offset = "0x61E7BB0", VA = "0x1861E8FB0")]
	public static Quaternion CMKFNHNGDME(Vector3 MPBHICGGLEH, Vector3 JJMOIFJMOBF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x61E9030", Offset = "0x61E7C30", VA = "0x1861E9030")]
	public static Vector3 FMJPHEFHJPG(Vector3 HINAKANKMEC, Vector3 HDIPFAOLDMJ, Vector3 JJMOIFJMOBF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x61E9390", Offset = "0x61E7F90", VA = "0x1861E9390")]
	public static Vector3 LAAALPOAELH(Vector3 LLKPDAJNMCL, Vector3 JJMOIFJMOBF, Quaternion MJCNDCDLGEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x61E8C40", Offset = "0x61E7840", VA = "0x1861E8C40")]
	public static Quaternion CEHMHEGJIOA(Quaternion NLOMNLFGFKB, Vector3 MPBHICGGLEH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x61E9220", Offset = "0x61E7E20", VA = "0x1861E9220")]
	public static bool HHFHLJKBEDH(Vector3 DHGOCHNKJDG, Vector3 IOONJNMMENL, [Out] Vector3 IPIBPFLONCL, bool NOMBNAKLCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x61E97C0", Offset = "0x61E83C0", VA = "0x1861E97C0")]
	public static Vector3 MADEALDJMMM(bool KHFLLMFFGPE, [Optional] Quaternion JHOLCCJAGJH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JKGAAGKIBDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public float3 KMIPHHDCLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public float3x3 BKMOBCFEIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float FFBKJCAKPNG;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FBECDJBHDPK
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int NPMLHNAENOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 KJPGFLAALDG(int NOBCGKJBAOK);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion DPNJJJAIBLG(int NOBCGKJBAOK);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float PPNPFIAHGIP(int NOBCGKJBAOK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BHPPBMOHNGF : KGPGMLMPCID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool FNOIONBAJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool DFDCOCJMJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float EEKLOJJHFDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	int DHPFFLLFLMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool FEOAAPLHAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int NMBCBBEKPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<JKGAAGKIBDH> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EPLALJMPDDH : KGPGMLMPCID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	HGGBAPPCPHG BDILLPMEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool OHLBDBALDCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NOFCJBHOLNF
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CMLIHGNKANO OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PIIDANLABNO GJPHNKDIDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KGPGMLMPCID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool MOHILDPGENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool OAGPIPNOBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	CMLIHGNKANO OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	float MHJLDMGGADN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 FCFBNGCIDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	NGIEHFKGLDJ KIGMLEOEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HJOGNBOCCHO JDEOEBMONJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OCMKIDMEEDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	int PLLPAJLBLMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Transform GEJIMPOMMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool PBCDGGHJDPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GDGJGEMFAOL GetBone(int NOBCGKJBAOK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int NOBCGKJBAOK);
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
