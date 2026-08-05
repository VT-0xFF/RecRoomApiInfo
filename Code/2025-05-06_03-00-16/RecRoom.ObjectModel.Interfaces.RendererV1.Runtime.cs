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
public enum GBCBAFBJFMP
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
public enum HFLHFCIMFNP
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
public enum PFDGIOAKAOJ
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
public enum DHLGPNHKFGA
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
public enum KKHCPEKNJIC
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
public enum CGKMKJEAANA
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
public static class EEMPMNKPGMK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3190", Offset = "0x7CA1990", VA = "0x187CA3190")]
	public static bool ONBDDNHIAHA(this CGKMKJEAANA CBCOGLOFHMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3150", Offset = "0x7CA1950", VA = "0x187CA3150")]
	public static bool MIOKMBMKAHF(this CGKMKJEAANA CBCOGLOFHMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3160", Offset = "0x7CA1960", VA = "0x187CA3160")]
	public static bool NNGKECIBELO(this CGKMKJEAANA CBCOGLOFHMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KLEDGCGHKKL
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
public struct NKPCNGHCBDP : KAICMPMFPHE, IEquatable<NKPCNGHCBDP>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int NHCKMLOFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int ILGJIFNMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0CE0", Offset = "0x2DAF4E0", VA = "0x182DB0CE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D588B0", Offset = "0x6D570B0", VA = "0x186D588B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FFFKLPKJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9680", Offset = "0x7CA7E80", VA = "0x187CA9680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xEC9860", Offset = "0xEC8060", VA = "0x180EC9860", Slot = "8")]
	public bool Equals(NKPCNGHCBDP PGPJMFPAKOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x39615E0", Offset = "0x395FDE0", VA = "0x1839615E0")]
	public static bool NIDGPKKMDPO(NKPCNGHCBDP BINANFFLHIK, NKPCNGHCBDP NOAPPAEGHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA95F0", Offset = "0x7CA7DF0", VA = "0x187CA95F0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA96C0", Offset = "0x7CA7EC0", VA = "0x187CA96C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DLGAKKGEPKP : KAICMPMFPHE, IEquatable<DLGAKKGEPKP>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int NHCKMLOFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int ILGJIFNMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0CE0", Offset = "0x2DAF4E0", VA = "0x182DB0CE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D588B0", Offset = "0x6D570B0", VA = "0x186D588B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FFFKLPKJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3080", Offset = "0x7CA1880", VA = "0x187CA3080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xEC9860", Offset = "0xEC8060", VA = "0x180EC9860", Slot = "8")]
	public bool Equals(DLGAKKGEPKP PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2FF0", Offset = "0x7CA17F0", VA = "0x187CA2FF0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CA30C0", Offset = "0x7CA18C0", VA = "0x187CA30C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OPEKOKNPEII : KAICMPMFPHE, IEquatable<OPEKOKNPEII>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NHCKMLOFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ILGJIFNMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0CE0", Offset = "0x2DAF4E0", VA = "0x182DB0CE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D588B0", Offset = "0x6D570B0", VA = "0x186D588B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FFFKLPKJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7CA97E0", Offset = "0x7CA7FE0", VA = "0x187CA97E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xEC9860", Offset = "0xEC8060", VA = "0x180EC9860", Slot = "8")]
	public bool Equals(OPEKOKNPEII PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9750", Offset = "0x7CA7F50", VA = "0x187CA9750", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OJMGMPCIMIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNDKBEJMECG(NKPCNGHCBDP PNDCHGJLEGG, HFLHFCIMFNP POCCMBPNGEN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNDKBEJMECG(DLGAKKGEPKP AAMAJMKCBNJ, HFLHFCIMFNP POCCMBPNGEN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOCMKCIEPFE(DLGAKKGEPKP AAMAJMKCBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJHAAMOJNIN(DLGAKKGEPKP AAMAJMKCBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJCDONKPCBP();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NPCPIHNPPAH(HFLHFCIMFNP PIJHKCJDAHO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OALPPKEDEIN(NKPCNGHCBDP PNDCHGJLEGG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OALPPKEDEIN(DLGAKKGEPKP AAMAJMKCBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HNAIKFEKJCG(DLGAKKGEPKP AAMAJMKCBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KGHKBABFLEO(DLGAKKGEPKP AAMAJMKCBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PIIPMMMIKOA();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DKGIKPCJCHA();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DCIDHDCNDGG(NKPCNGHCBDP PNDCHGJLEGG, KKHCPEKNJIC PIJHKCJDAHO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FAIFNMFDLBC(DLGAKKGEPKP AAMAJMKCBNJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GPIOODEMIEL(DLGAKKGEPKP AAMAJMKCBNJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OLHJAEAPBIJ();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KPGLHJCLEHN(KKHCPEKNJIC PIJHKCJDAHO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BLFHBMAMAMM(NKPCNGHCBDP PNDCHGJLEGG, Vector3 HOPGOBDNJKN, Vector3 FPIEKCNILGJ, Vector3 DIGACAJBFJH, float MLBOJHFBHPC, float CCABDFEMEFP, IReadOnlyList<Camera> GEAMDJLLILA, GBCBAFBJFMP NOGCCJNOPLG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BLFHBMAMAMM(OPEKOKNPEII IAONCFHKNEM, Vector3 HOPGOBDNJKN, Vector3 FPIEKCNILGJ, Vector3 DIGACAJBFJH, float MLBOJHFBHPC, float CCABDFEMEFP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OBHDPEBCHIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IOGELKMDLDE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKPCNGHCBDP DBHINNIFLOM(OFIGCCKINJH NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NKPCNGHCBDP DBHINNIFLOM(OFIGCCKINJH NFNBKNAJBPN, bool NGLJCCMLJOA);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCMAEMPGBHB(NKPCNGHCBDP PNDCHGJLEGG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCJLNEGODED(NKPCNGHCBDP PNDCHGJLEGG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DLGAKKGEPKP FKDABEFHEFH(NKPCNGHCBDP PNDCHGJLEGG, FMOLHEJODCJ NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DLGAKKGEPKP GPBMEECDPHG(NKPCNGHCBDP PNDCHGJLEGG, CILFHMBDFBH NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ANDFNFFLMBA(DLGAKKGEPKP AAMAJMKCBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HEBBDCKEFCL(DLGAKKGEPKP AAMAJMKCBNJ);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OPEKOKNPEII EADLLAIDPBL(DDGPKKHCANB NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MFJDKIKFGHI(OPEKOKNPEII IAONCFHKNEM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DAHADFMMGIE(OPEKOKNPEII IAONCFHKNEM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task PKGHJCAGLGG();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task CIPLINGPNAO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task MANBKHJLJDD();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HAGGOPNBHKJ();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> KNKDOBDIOJL(NKPCNGHCBDP PNDCHGJLEGG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LDJCMFGIOBD
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum MFEKICOIPOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum HIHFOPDOCGM
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum KMEDEBHJFAP
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
	public enum GDKBECHPFGI
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
	public enum DFKDIKJBFEM
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
	public enum KAOJNPNHAMG
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
	public enum NGBFHHNGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum DACBNGCFCFG
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
	public static bool AMFPEOCPJLG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long EJGCLPHMIGI;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool KJCLFPAPLBG;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool DPMEKGFFNJG;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool MADOIIFHFLB;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float AKLBFBKOAJO;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float KDMPPJBFNIJ;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int MPMLLFCOFIC;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static KAOJNPNHAMG HHGHIAPMDFG;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long EDIBNBJJEDG;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float BCCAMPJNLPJ;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int AADLJKCMOND;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int CECJLNMAAAP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int OHDBAOBODKK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int GHIMODAMHMO;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int CFNJAFBOPKH;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int MOHNEGICNBL;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int LKGODJHMNHL;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int FJEADEAGFHD;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool NFADIGKAOFO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int FGJDMADPLKB;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int HGGBGNLOBME;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int PHEHGIHDDFF;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool GKLDENEHBFE;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float CKAINPNJGLN;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool BBECLMBGKFM;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float CLCFPCMNOEP;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long DBLEGGHBPGF;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool AACNLANAKMF;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long BNALADBGEMI;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int MHKAEJPCPOL;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool CNPLHFHILFJ;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static MFEKICOIPOP OMNOCLMNNNJ;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool HPDBIOODGIH;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool CEDHDCMLALP;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int JLGFLHKPPFF;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int DFAMOMKHIBG;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int HIKBNGDAHJA;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int DLKOJNGPIOO;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int EMMDBAGJAPC;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int CKBCEHKIEKM;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int EAIFOAMFIHF;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int EFGIJJJGDJN;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float MLGILOCDIPE;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float EGEAFPAFMOJ;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float EJCEGIENPMA;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float LKBNNLFHJHM;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int GBJPLINMPHG;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int EODCDLKNENA;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int JBOIFCJPIIE;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int JHHHODBEEMN;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool NBPJKBGDLAA;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static KMEDEBHJFAP GOGHMNHOOBH;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static GDKBECHPFGI PMKNDGEBMHE;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool HKDDIFAGDKK;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static HIHFOPDOCGM BNHAPFFBEOA;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float KFKEEGHNODN;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float AFFNIHPILEK;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float MPOBJMHNGOH;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float GDONADDKCIE;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float NDDEKKJAKKI;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float FIKGIBHPKMD;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float FJHONEAJGMJ;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float OKHCIPLEAPL;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool BCGMCHAKFKL;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static NGBFHHNGGGF GPMGCAGCONE;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool IAHIDJDJPHE;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float KPOIJAEMFDO;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float EHJINKGEJED;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float NFADDEIGODF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float CANDDLEFGLD;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float IIPBLLFCKBI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool FHFOJHBKBJJ;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long LFHAPBOONCH;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float IPEAALBOBKO;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float LKJJBMFBKAM;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float KLFEOFFKKJC;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int LFMEHPDJHGN;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float EMDBMCNJNGB;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool FNGNNDJBBIJ;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long DCGEOGHFJCB;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int DOLBBHNMJKN;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int JAECFHOFDII;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float PLEDMJCHOCP;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float ABJJDFCLLDH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool LEJIJIMFFMP;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool KEHHHJHJKPB;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float GFNDILKPPFD;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long JHAOAPABOED;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long HFGMNDCMGML;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int MGLNCBCFEHA;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 JMKHNBPCCBP;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 HONMOCPBKLO;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool BPBLHGDAPAF;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static DFKDIKJBFEM NCJIGKJNAIB;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long NCJPKHIEHBD;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int HLFKMGICNBE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int KPMDNLLKJCO;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int GPGEJOKJJDL;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int AONBEBEOBPJ;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int IFPNOBKAGPE;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long ELDNMLKGLNL;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int LJMKPNNKNMF;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int JPAMOFFKMDN;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int DMILNHAFADB;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long EOEAJOKEKFO;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long JEINANDLBMO;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long CNJHLCIPHBI;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long LIHHFOGGAKD;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int LHGKIOMPBOE;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int ONPLIBIKCIC;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int CJPIHCHLHLH;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int MKIJOBHIJBK;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] NDMNDPMAFFF;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int FEDFKFEACMA;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long NFIPMBAGIMJ;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long MGPKGAHDCIM;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int FIBGHHMJIIC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int GFGDNIBADGM;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long ACAPPOBPOGK;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long PMMBJJIFFKO;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long PEGBFEEELAG;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long IODPPHCDMGA;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long MLIIAKDEGDC;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long FFAELADKDHA;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long JKIJDFEHGDK;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long JIJHGMFIODG;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long JJDBLNABKJF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float DONKAOFBDNH;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float ENDIGEEDEAL;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long NNPGIJOJCAP;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int CFDAMLEHDHF;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long JAIPBIFDJOK;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long LFACOMKDBBL;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float INMGGKOLHOO;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long GGHCGAGBKLC;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long GFNDIFJAPEE;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long FEGCBDOLOKO;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long JDEGFGPIIFC;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long JFKJJLKGHBL;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long ELCFMBJEBGG;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long ODNGDLJDPLB;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long NAOFCCIBMCJ;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long CPJCDILOMIG;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long GMMPLKNFHHD;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long EAPLEIOBFDE;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long BNPMNOKHOBC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static DACBNGCFCFG GABMEFDPBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7CA7810", Offset = "0x7CA6010", VA = "0x187CA7810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long JFFHPEKCMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6830", Offset = "0x7CA5030", VA = "0x187CA6830")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6260", Offset = "0x7CA4A60", VA = "0x187CA6260")]
	public static void BIFEJIMDJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6890", Offset = "0x7CA5090", VA = "0x187CA6890")]
	public static void NPMBEKBHANJ(DACBNGCFCFG CLBPHCMKEOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class INMAJKLKLFA
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct HFMNMFDPPKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 COFBFGOOFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Quaternion PHMBAJJGPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float FFLBHMOOMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Quaternion GCPHGEAPLHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float IKFONFIFMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float ICPILACBFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public float IHNBIGPMNOP;
	}

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static List<HFMNMFDPPKG> FONAANGDMBA;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4790", Offset = "0x7CA2F90", VA = "0x187CA4790")]
	public static NativeList<OFEAEHKGGHH> JHKFDBDBOPJ(DFJCBJNFNEI DMLFPKLKPFK)
	{
		return default(NativeList<OFEAEHKGGHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3410", Offset = "0x7CA1C10", VA = "0x187CA3410")]
	private static bool FCAEBGIHABF(int JEGIFICJAGL, NativeList<OFEAEHKGGHH> HLPIAOANGMD, List<HFMNMFDPPKG> BIAKPLJDFKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA31B0", Offset = "0x7CA19B0", VA = "0x187CA31B0")]
	private static OFEAEHKGGHH AONOHDFDPOP(int IGNBGDBAAAC, List<HFMNMFDPPKG> BIAKPLJDFKD)
	{
		return default(OFEAEHKGGHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA42A0", Offset = "0x7CA2AA0", VA = "0x187CA42A0")]
	private static OFEAEHKGGHH JCNNLCPKFIO(int IGNBGDBAAAC, List<HFMNMFDPPKG> BIAKPLJDFKD)
	{
		return default(OFEAEHKGGHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3330", Offset = "0x7CA1B30", VA = "0x187CA3330")]
	private static OFEAEHKGGHH CJPCBMBDPKG(Vector3 NANJGAHEDND, Quaternion MODLABAKDKE, float BCDEDKPOOJB)
	{
		return default(OFEAEHKGGHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4D30", Offset = "0x7CA3530", VA = "0x187CA4D30")]
	public static NativeList<OFEAEHKGGHH> NINLBFKALNN(DFJCBJNFNEI DMLFPKLKPFK, float BDMNEPGOMEF)
	{
		return default(NativeList<OFEAEHKGGHH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LMNPGEJLMIN
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 DJKGMJFAJAF;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static Vector3 DAFAICJIEHO;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly float BBFDNDBLCFJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9080", Offset = "0x7CA7880", VA = "0x187CA9080")]
	public static Vector3 JNKMEOODDBP(Vector3 FPOFDOPGIFJ, Quaternion MODLABAKDKE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8C80", Offset = "0x7CA7480", VA = "0x187CA8C80")]
	public static Vector3 GCDGHFFCJJM(Quaternion PMHMEKBKJJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9300", Offset = "0x7CA7B00", VA = "0x187CA9300")]
	public static Vector3 MGDLMJOIMFM(Quaternion PMHMEKBKJJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CA82F0", Offset = "0x7CA6AF0", VA = "0x187CA82F0")]
	public static Quaternion AMCEPBPMHLD(Vector3 ELEEIMOLKDP, Vector3 GLANACDLEOF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8A90", Offset = "0x7CA7290", VA = "0x187CA8A90")]
	public static Vector3 GBPEGCNGGKD(Vector3 OLDBIKDJBPK, Vector3 GOEOABHCAOI, Vector3 GLANACDLEOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8370", Offset = "0x7CA6B70", VA = "0x187CA8370")]
	public static Vector3 CKALOCCGEGK(Vector3 FPOFDOPGIFJ, Vector3 GLANACDLEOF, Quaternion PMHMEKBKJJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8D20", Offset = "0x7CA7520", VA = "0x187CA8D20")]
	public static Quaternion IKNCFEAMFOP(Quaternion MODLABAKDKE, Vector3 ELEEIMOLKDP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CA93A0", Offset = "0x7CA7BA0", VA = "0x187CA93A0")]
	public static bool NHMAIICCNCP(Vector3 AEIKILCJEEJ, Vector3 OMPAAKFMJFI, [Out] Vector3 EFPHCCMNKBP, bool PPGOLMBNPCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7CA87A0", Offset = "0x7CA6FA0", VA = "0x187CA87A0")]
	public static Vector3 EJDPHGKGGGA(bool CGPPPHFNLBL, [Optional] Quaternion NKCGJHEKAEI)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OFEAEHKGGHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3 COFBFGOOFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float3x3 PHMBAJJGPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float FFLBHMOOMNL;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DFJCBJNFNEI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int KJPOFDKAHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 DBGPAOMJPPG(int IGNBGDBAAAC);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion FFGCOGALGGE(int IGNBGDBAAAC);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float ELOFCKFFIED(int IGNBGDBAAAC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CILFHMBDFBH : PBDOHGFKHAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool BPOLINDOIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool NNBCPAEDGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float HEALHAGNOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int DMLIMHEEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool CCBOMDCEPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int JKGDKNOICOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<OFEAEHKGGHH> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FMOLHEJODCJ : PBDOHGFKHAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PFDGIOAKAOJ OCKFKHHPDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MILDILAPJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 MICMADINKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OFIGCCKINJH
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AIFAFFNBDPH FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	DHLGPNHKFGA PKBBGPAIKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PBDOHGFKHAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IFJKMMEMEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool IFEKLNDJDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AIFAFFNBDPH FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS FEFNONNIKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float FKJMKHIOOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 GNKAJCNAHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	CGKMKJEAANA PJBEGDBBOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	KLEDGCGHKKL POFPNGHBLED
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
public interface DDGPKKHCANB
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int AMJMEGJOAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform ECPACNIKLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool EIFBLAFPOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NKPCNGHCBDP GetBone(int IGNBGDBAAAC);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int IGNBGDBAAAC);
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
