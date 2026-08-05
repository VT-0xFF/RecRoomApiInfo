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
public enum DLBMCHLGFNN
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
public enum LBAACCFPEFG
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
public enum CMGHNAKJDFM
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
public enum EABNKPDDGGB
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
public enum EJEKANEOHGI
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
public enum AOFPBDKJHJG
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
public static class MDKFKPLLJID
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F0F880", Offset = "0x7F0E280", VA = "0x187F0F880")]
	public static bool FLDJAPCBKHA(this AOFPBDKJHJG PMELCIJHALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F0F840", Offset = "0x7F0E240", VA = "0x187F0F840")]
	public static bool CPBLEBKGAGK(this AOFPBDKJHJG PMELCIJHALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F0F850", Offset = "0x7F0E250", VA = "0x187F0F850")]
	public static bool FGIFPDGFKFE(this AOFPBDKJHJG PMELCIJHALK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OCLKLGODOEL
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
public struct LFLLENECNAF : MCDNNIEBNOJ, IEquatable<LFLLENECNAF>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int FOIACCDFCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int EHHACNLGFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2F60", Offset = "0x2FA1960", VA = "0x182FA2F60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F27F80", Offset = "0x6F26980", VA = "0x186F27F80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HBILGBNKLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F770", Offset = "0x7F0E170", VA = "0x187F0F770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x129E210", Offset = "0x129CC10", VA = "0x18129E210", Slot = "8")]
	public bool Equals(LFLLENECNAF NDNHELJMDCG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3B33350", Offset = "0x3B31D50", VA = "0x183B33350")]
	public static bool IDFALDDOLDN(LFLLENECNAF MJGADEGDMOP, LFLLENECNAF LJDEEJKPAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F0F6D0", Offset = "0x7F0E0D0", VA = "0x187F0F6D0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0F7B0", Offset = "0x7F0E1B0", VA = "0x187F0F7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OOCANPCELJK : MCDNNIEBNOJ, IEquatable<OOCANPCELJK>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int FOIACCDFCND
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int EHHACNLGFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2F60", Offset = "0x2FA1960", VA = "0x182FA2F60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F27F80", Offset = "0x6F26980", VA = "0x186F27F80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HBILGBNKLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F10C40", Offset = "0x7F0F640", VA = "0x187F10C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x129E210", Offset = "0x129CC10", VA = "0x18129E210", Slot = "8")]
	public bool Equals(OOCANPCELJK NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F10BA0", Offset = "0x7F0F5A0", VA = "0x187F10BA0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F10C80", Offset = "0x7F0F680", VA = "0x187F10C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DNKOMFHFFCL : MCDNNIEBNOJ, IEquatable<DNKOMFHFFCL>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FOIACCDFCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EHHACNLGFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2F60", Offset = "0x2FA1960", VA = "0x182FA2F60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F27F80", Offset = "0x6F26980", VA = "0x186F27F80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HBILGBNKLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F690", Offset = "0x7F0E090", VA = "0x187F0F690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x129E210", Offset = "0x129CC10", VA = "0x18129E210", Slot = "8")]
	public bool Equals(DNKOMFHFFCL NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0F5F0", Offset = "0x7F0DFF0", VA = "0x187F0F5F0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KCOGCHBFLDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAAOMHGJHAK(LFLLENECNAF ALPBGLGCPNB, LBAACCFPEFG LKIOAPBFPML);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAAOMHGJHAK(OOCANPCELJK EBHEGJDIFIE, LBAACCFPEFG LKIOAPBFPML);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOKHANKGKKP(OOCANPCELJK EBHEGJDIFIE);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PFEDKGPLKLO(OOCANPCELJK EBHEGJDIFIE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKMBNCLNBFA();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EPODPJADIIN(LBAACCFPEFG HHCAOFMCNLG);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DGIOOHAPIIE(LFLLENECNAF ALPBGLGCPNB);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DGIOOHAPIIE(OOCANPCELJK EBHEGJDIFIE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FAOAOJCMAPL(OOCANPCELJK EBHEGJDIFIE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PPLNABCOFEK(OOCANPCELJK EBHEGJDIFIE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AJHCOGGJGCG();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NIHAPIKLNBK();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PHPJBPPLLDD(LFLLENECNAF ALPBGLGCPNB, EJEKANEOHGI HHCAOFMCNLG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HMNCFDAGMCH(OOCANPCELJK EBHEGJDIFIE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HBHECLAAPNC(OOCANPCELJK EBHEGJDIFIE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ELKMGPGENIK();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EBFHKNPAFCE(EJEKANEOHGI HHCAOFMCNLG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NFDIBADABAM(LFLLENECNAF ALPBGLGCPNB, Vector3 KBMNGNLKIGM, Vector3 MFLAHHCNGLE, Vector3 JFKFLLJIFEB, float BCDGHNGOJIJ, float AGKCFKEOFLP, IReadOnlyList<Camera> JENGAHABIPB, DLBMCHLGFNN HPJMJFCDFBG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NFDIBADABAM(DNKOMFHFFCL NEKJLPNDJKJ, Vector3 KBMNGNLKIGM, Vector3 MFLAHHCNGLE, Vector3 JFKFLLJIFEB, float BCDGHNGOJIJ, float AGKCFKEOFLP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JHOAFMOCPOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CAAOAGNEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LFLLENECNAF EJPILKBGIJI(FMGFLKNPHAK HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LFLLENECNAF EJPILKBGIJI(FMGFLKNPHAK HPGIDELCODH, bool JNDDPIHMCCH);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMMDOGNECGG(LFLLENECNAF ALPBGLGCPNB);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PFHEDFBHNGC(LFLLENECNAF ALPBGLGCPNB);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OOCANPCELJK CFAMFCAMGPE(LFLLENECNAF ALPBGLGCPNB, AELOEGAHNAG HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OOCANPCELJK GILHDFEMJMM(LFLLENECNAF ALPBGLGCPNB, AJFNDLNEHCE HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FECDEOJHEFM(OOCANPCELJK EBHEGJDIFIE);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BOAHMPJCLCE(OOCANPCELJK EBHEGJDIFIE);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DNKOMFHFFCL KIMGJIPFGJL(IBJOONGDNBK HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GOCCGOFPGHI(DNKOMFHFFCL NEKJLPNDJKJ);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JEMICJCLABE(DNKOMFHFFCL NEKJLPNDJKJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task OGJFPLEDIBB();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task DBDFJFPMIMN();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task KCPNFEJFKLC();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ELNPLNNDPEI();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> DPPHMFGBOHN(LFLLENECNAF ALPBGLGCPNB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CPGMAIDJIBE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum GEEBKNGHDAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum HJEALCKPFBE
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum NMCINHKGHIO
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
	public enum AHMBBJPOEML
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
	public enum GFFIENNOIJC
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
	public enum OMCNDODLHPK
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
	public enum BGPHBKCMAFP
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum DLJKBLDGEKO
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
	public static bool JEAAPPEJGBP;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long HHHKEHCJHPL;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool PEJINDDFPJB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool NECOOJHPPMF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool GNOMFHBMJNE;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float HBMNOGAHNBG;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float FLOHKBJNCAD;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int BPEHFNHDCCI;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static OMCNDODLHPK KCPBNBIPCNJ;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long GNMMCENDMIA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float NHPGJPNALMA;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int MDPAINOEFJK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int LKMHOGPDJEO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int NAPPNJLFFKC;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int BBKJMGMNKAC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int PNILBOFGMLL;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int EGCFBPCLDAC;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int OGGDFDMNJAH;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int NEAODNJGOKL;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool NBLENDPDPGO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int CPDEMIHJCCM;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int HIEMOJCNBMB;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int ODNDKIOADHK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool FJEMANNOIFD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float AMPNMLFHLME;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool PICINANBKMA;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float NFMAIGLIDPB;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long OOIAKFGBDAB;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool GFAPNHMLPGA;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long HLPAOKIOLIO;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int EGDMHOBCBNH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool NALGPMPBAKK;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static GEEBKNGHDAI AAIBMIMKGFG;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool FPEGFBJBANJ;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool FLMEIDAMJJD;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int IKNPLEDDBEJ;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int ECBOKIKAJII;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int NFCHEPJFIEJ;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int PFAOBGCKOIB;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int OILIOMAJAOG;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int AMGIGOGAHCM;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int HDGDAHEKBDB;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int PKHOKBHMPCP;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float CDJHDJMJPJO;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float OPOKBGFEODE;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float CKJKAOFBJKO;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float GDIHLHIGECJ;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int HKPKPIEHIEP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int OGMJIFGDJOG;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int LJKPAHDJMPK;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int AGGMLIFOPNA;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool CMNLIKNPDGM;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static NMCINHKGHIO LIPOHMDMEKM;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static AHMBBJPOEML JMKHKGHBCHJ;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool APIKFPJKNNF;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static HJEALCKPFBE JNHKNEAIILJ;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float HMIGMMBENAA;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float BINIADHBKHL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float LKJINEEMGMB;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float GMLKPHLLPIF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float FDMLDHGMBMP;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float EOMGHOKKJGN;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float HHAEHMGHNFG;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float JAADIJOGILK;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool OCFBAKMGNJA;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static BGPHBKCMAFP PBLELHDNHIK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool OMAPABPCHGI;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float PCPCFKHCBPN;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float GHCMBOCCDIA;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float HNCKHKELFJM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float JPENIGNCMFA;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float EPABGCIEGBM;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool MGBOCAEGODI;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long GPAHKAPKIJG;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float BPOJDHCFKPC;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float EPDGPILIJKC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float DDDLAJDHLEG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int BPANFNCEOOF;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float MHFHKCHBEHA;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool AGMECLANIJJ;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long DFHMCAADODB;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int PJODHABJHJE;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int GIGOCLECAIK;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float HJEEDIHGHHD;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float GHPBLMEEOBL;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool DLAPIHKFHOA;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool MIGIMOKFOOM;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float JGIBEOCKPDE;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long PPONEHLDCNO;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long IBFMEDNKAFP;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int CNDDCHENBLD;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 IDKEKKIIAAI;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 PHAMJIKBEBG;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool BJJAGKCIFOO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static GFFIENNOIJC HDNKDCPBMJD;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long BGDENLGNKDO;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int CHLFGBJFCEI;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int DENFLBHOGEL;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int HJBBOBHBDPO;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int BLNMNBBMNFJ;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int JEPIJGLJONM;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long FPDJMIKFLFK;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int FJOPBANIHHE;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int ANHHPMKMAMC;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int MGACIMODLAK;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long EHFHMFAPIDA;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long NEOLAFMOIGO;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long EDAFNCDBPEC;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long EKPKPAIOGDO;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int DJMAFKDIBDE;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int JDHIDHAAJKK;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int FDJGMEDJNHN;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int AOLPEGMPJBE;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] JLKGMOADHAI;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int PIMEDAJIEJK;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long DPPADCGAPNM;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long POGNAPGFOCD;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int LKOKNHJIIGO;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int AMOGMFDMKNK;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long IKEGNPKELNG;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long CJINHIKPOHF;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long GADAOGEHMDA;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long KGLMNOBBJFN;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long MKBFGBDKKIC;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long MCCDMIONAFI;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long EOGEMGANLOD;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long NAMDOEDCLGD;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long IPMOGAOBMHB;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float POHIODJOPMK;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float AIHBJAGONOG;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long IFLGMCMEIKK;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int AHKGGFJCOEK;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long FBEBFAIIGJM;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long HHCEFIFPHCP;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float ACNPNADPLEH;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long OHHCKLLNMPD;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long GCFDEEEBBPG;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long JENAPMPINOI;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long ONHOBFMDFHE;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long AKFPKHPLONK;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long LIBCAJCCBAI;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long DBKHCEBJLLO;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long ELBIOODIJOK;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long KLACPOPGNMO;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long GFCEHGHGNHL;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long BLCJBFJOMFD;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long BJMKPKLGDKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static DLJKBLDGEKO IGOEFICKFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BA70", Offset = "0x7F0A470", VA = "0x187F0BA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long IEDFIBPOFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A4C0", Offset = "0x7F08EC0", VA = "0x187F0A4C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A520", Offset = "0x7F08F20", VA = "0x187F0A520")]
	public static void JKKIAGKKELE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F0AAF0", Offset = "0x7F094F0", VA = "0x187F0AAF0")]
	public static void PAOMMONCGPH(DLJKBLDGEKO PDLMOLIHGBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DJNENLOAHND
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct AAJIECOADOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 ICJIGFAHILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Quaternion ACEAKNBEHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float NGEMMPELKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Quaternion ECJAMIJHHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float LCBLGOHIEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float DOACIBEMCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public float CAFEHHJIGDO;
	}

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static List<AAJIECOADOK> MIOKOLDOCPN;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F0D560", Offset = "0x7F0BF60", VA = "0x187F0D560")]
	public static NativeList<PLLACCJJPHF> DOFCEHLLNOB(GFBHNCCBMLF HPNFFCPPBFG)
	{
		return default(NativeList<PLLACCJJPHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C550", Offset = "0x7F0AF50", VA = "0x187F0C550")]
	private static bool BIDEDDPBEII(int LFGCGKOHNIA, NativeList<PLLACCJJPHF> MGJNMKLFKCJ, List<AAJIECOADOK> BIFADIMOBMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F0D3E0", Offset = "0x7F0BDE0", VA = "0x187F0D3E0")]
	private static PLLACCJJPHF CKEBANAOMHB(int IDANDMAPNBN, List<AAJIECOADOK> BIFADIMOBMA)
	{
		return default(PLLACCJJPHF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F0EF90", Offset = "0x7F0D990", VA = "0x187F0EF90")]
	private static PLLACCJJPHF PDFHLHAILMH(int IDANDMAPNBN, List<AAJIECOADOK> BIFADIMOBMA)
	{
		return default(PLLACCJJPHF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F0F480", Offset = "0x7F0DE80", VA = "0x187F0F480")]
	private static PLLACCJJPHF PNHIGIAMFHE(Vector3 NHKLJJMEOLP, Quaternion NOEMAMNIFJJ, float BGJJMJPDNJC)
	{
		return default(PLLACCJJPHF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0DAF0", Offset = "0x7F0C4F0", VA = "0x187F0DAF0")]
	public static NativeList<PLLACCJJPHF> KCAAFPAPEJE(GFBHNCCBMLF HPNFFCPPBFG, float JMHEKPOCECE)
	{
		return default(NativeList<PLLACCJJPHF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class MFFDEIEFGHA
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 JOHNDCBINPE;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static Vector3 JHAGGCLFDCL;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly float MAINJIDCJLO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0FD20", Offset = "0x7F0E720", VA = "0x187F0FD20")]
	public static Vector3 KACEEKEOHEJ(Vector3 MEIJJJENHAL, Quaternion NOEMAMNIFJJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F10A30", Offset = "0x7F0F430", VA = "0x187F10A30")]
	public static Vector3 PHOAFCCCJPL(Quaternion NGPACIMGGNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F0FC80", Offset = "0x7F0E680", VA = "0x187F0FC80")]
	public static Vector3 HLOIPIHBLPF(Quaternion NGPACIMGGNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F0FC00", Offset = "0x7F0E600", VA = "0x187F0FC00")]
	public static Quaternion DEJKJINNLFA(Vector3 HPCBBMBEKNN, Vector3 ODJALHAEEDH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F0FFA0", Offset = "0x7F0E9A0", VA = "0x187F0FFA0")]
	public static Vector3 MLIHOCIHNON(Vector3 IFBLLAJHENM, Vector3 MGANAHGEAFI, Vector3 ODJALHAEEDH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F10600", Offset = "0x7F0F000", VA = "0x187F10600")]
	public static Vector3 OEGEMNODKOK(Vector3 MEIJJJENHAL, Vector3 ODJALHAEEDH, Quaternion NGPACIMGGNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F0F8A0", Offset = "0x7F0E2A0", VA = "0x187F0F8A0")]
	public static Quaternion BCLGGKFJDAN(Quaternion NOEMAMNIFJJ, Vector3 HPCBBMBEKNN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F10190", Offset = "0x7F0EB90", VA = "0x187F10190")]
	public static bool NGOMEKCGBBD(Vector3 NGJANGMCJGE, Vector3 LKLHJIOINHE, [Out] Vector3 EEAGDBFPFCE, bool KGALMIPLHNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F10310", Offset = "0x7F0ED10", VA = "0x187F10310")]
	public static Vector3 OCHCPOJPJJJ(bool EFDALMHLELK, [Optional] Quaternion CCEGOBKFANB)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PLLACCJJPHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3 ICJIGFAHILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float3x3 ACEAKNBEHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float NGEMMPELKAO;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GFBHNCCBMLF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int HBCOAOLAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 MEJMBKGOOEC(int IDANDMAPNBN);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion LDJEALGHHMF(int IDANDMAPNBN);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float HNJKLPNBKBF(int IDANDMAPNBN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface AJFNDLNEHCE : HHCMFCBLDPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool ONJONHGJOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GNAMPCONKOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float FGPJFIIOKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int BKBEKHCFABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool CNMKBLECDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int JLKLKDMDGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<PLLACCJJPHF> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface AELOEGAHNAG : HHCMFCBLDPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CMGHNAKJDFM OLGMGEHPEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FLBPKEFKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 PNKKOOCLMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FMGFLKNPHAK
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	KAOEODPJKHN OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	EABNKPDDGGB CBLNHJFHAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HHCMFCBLDPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LFAEOEKJBDI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool IAEJEDDMJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	KAOEODPJKHN OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS IEPFCGOGPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float OABPIGFMENH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 JMGHBHLNEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	AOFPBDKJHJG IPAGFHMFIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	OCLKLGODOEL EHEJOPGAOPC
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
public interface IBJOONGDNBK
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int OLBIAEIDBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform JDNCJLNMKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool OFEMLHGBKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LFLLENECNAF GetBone(int IDANDMAPNBN);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int IDANDMAPNBN);
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
