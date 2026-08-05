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
public enum IKKGENNIEIK
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
public enum CKJLKPAHMFI
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
public enum LBBOFCAGNFJ
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
public enum MDHGKJAOALO
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
public enum HMDPDMKPOCJ
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
public enum AOKFBPFAEAA
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
public static class IAOAEGDLBLD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x827FF90", Offset = "0x827ED90", VA = "0x18827FF90")]
	public static bool INMLHJDGNDG(this AOKFBPFAEAA MJHKIJLGCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x827FF80", Offset = "0x827ED80", VA = "0x18827FF80")]
	public static bool AMMPHGLDCPJ(this AOKFBPFAEAA MJHKIJLGCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x827FFB0", Offset = "0x827EDB0", VA = "0x18827FFB0")]
	public static bool NFPGPGEHKEM(this AOKFBPFAEAA MJHKIJLGCOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PLHKBDHNDHI
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
public struct IFKLBEEHLLN : FOLAMDMFEJK, IEquatable<IFKLBEEHLLN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int GBFKBOHPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int CALPLMDODGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x30BACB0", Offset = "0x30B9AB0", VA = "0x1830BACB0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E47E60", Offset = "0x6E46C60", VA = "0x186E47E60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IHBLCGMONJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8283160", Offset = "0x8281F60", VA = "0x188283160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1341670", Offset = "0x1340470", VA = "0x181341670", Slot = "8")]
	public bool Equals(IFKLBEEHLLN LOKLFHKEJPC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C450E0", Offset = "0x3C43EE0", VA = "0x183C450E0")]
	public static bool HAHIHKOBLPE(IFKLBEEHLLN LKPLCEODICL, IFKLBEEHLLN MANCHAKPLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82830C0", Offset = "0x8281EC0", VA = "0x1882830C0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82831A0", Offset = "0x8281FA0", VA = "0x1882831A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DDJIEOGAMGL : FOLAMDMFEJK, IEquatable<DDJIEOGAMGL>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int GBFKBOHPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int CALPLMDODGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x30BACB0", Offset = "0x30B9AB0", VA = "0x1830BACB0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E47E60", Offset = "0x6E46C60", VA = "0x186E47E60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IHBLCGMONJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x827FEB0", Offset = "0x827ECB0", VA = "0x18827FEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1341670", Offset = "0x1340470", VA = "0x181341670", Slot = "8")]
	public bool Equals(DDJIEOGAMGL LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x827FE10", Offset = "0x827EC10", VA = "0x18827FE10", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x827FEF0", Offset = "0x827ECF0", VA = "0x18827FEF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PLMBKMDHFEK : FOLAMDMFEJK, IEquatable<PLMBKMDHFEK>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GBFKBOHPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CALPLMDODGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x30BACB0", Offset = "0x30B9AB0", VA = "0x1830BACB0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E47E60", Offset = "0x6E46C60", VA = "0x186E47E60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IHBLCGMONJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8286AE0", Offset = "0x82858E0", VA = "0x188286AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1341670", Offset = "0x1340470", VA = "0x181341670", Slot = "8")]
	public bool Equals(PLMBKMDHFEK LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8286A40", Offset = "0x8285840", VA = "0x188286A40", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CHEKCMOLHDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONCLCDAHIIA(IFKLBEEHLLN EGPDFGOHLFM, CKJLKPAHMFI KMKJPPGBBCA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONCLCDAHIIA(DDJIEOGAMGL KDLDDCCMAJC, CKJLKPAHMFI KMKJPPGBBCA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LJFIKDKBGPK(DDJIEOGAMGL KDLDDCCMAJC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDBCIOCFBBG(DDJIEOGAMGL KDLDDCCMAJC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGKOHFDFEKI();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLJMAEPEJNB(CKJLKPAHMFI DGPNPBEKOOD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DIOCCIDHHBM(IFKLBEEHLLN EGPDFGOHLFM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DIOCCIDHHBM(DDJIEOGAMGL KDLDDCCMAJC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LEKJDPOBBFD(DDJIEOGAMGL KDLDDCCMAJC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FDDOPICLLAG(DDJIEOGAMGL KDLDDCCMAJC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MDAEKAHGOAO();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PCLFALFNMDG();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DJNOCPAIADL(IFKLBEEHLLN EGPDFGOHLFM, HMDPDMKPOCJ DGPNPBEKOOD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KOMIMFMKMAP(DDJIEOGAMGL KDLDDCCMAJC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FDLDIFOGGDP(DDJIEOGAMGL KDLDDCCMAJC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KCGHPKPECDM();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ALKHDBDPABN(HMDPDMKPOCJ DGPNPBEKOOD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JINFDJEFPDC(IFKLBEEHLLN EGPDFGOHLFM, Vector3 PBBIMOLCJHL, Vector3 LDCEFMAJMOB, Vector3 LMPIOOGBHJE, float LELKNDGNJHD, float EMEKMNBIBCM, IReadOnlyList<Camera> CFGPGBNFLMI, IKKGENNIEIK OPMILLGOOOM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JINFDJEFPDC(PLMBKMDHFEK BKFEEEDBEMD, Vector3 PBBIMOLCJHL, Vector3 LDCEFMAJMOB, Vector3 LMPIOOGBHJE, float LELKNDGNJHD, float EMEKMNBIBCM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JLDCHECNAIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NFJLGBBJHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IFKLBEEHLLN KPNDHBBFOEN(LCOLNOMHDFM BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IFKLBEEHLLN KPNDHBBFOEN(LCOLNOMHDFM BOIPFNOKGBJ, bool ELMOIKFNJDE);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDEMKELICHA(IFKLBEEHLLN EGPDFGOHLFM);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFEPLEMBKCE(IFKLBEEHLLN EGPDFGOHLFM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DDJIEOGAMGL HCPNIHGNADO(IFKLBEEHLLN EGPDFGOHLFM, KCFGAJKDIOC BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DDJIEOGAMGL BLNICLLKDFE(IFKLBEEHLLN EGPDFGOHLFM, HDAFBNCPEAH BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ECGHONJNKFF(DDJIEOGAMGL KDLDDCCMAJC);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MLIPPHGPOJM(DDJIEOGAMGL KDLDDCCMAJC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PLMBKMDHFEK IBBIKOGMEAI(JKPIFGALOOA BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EPIGPEOMJDE(PLMBKMDHFEK BKFEEEDBEMD);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KIPNCNCMONH(PLMBKMDHFEK BKFEEEDBEMD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task KCMKNIMGKEC();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task DJDHPHGMGOB();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task ICFDIPJMBML();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BCHENKEKDPL();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> HEKFIJHIJMJ(IFKLBEEHLLN EGPDFGOHLFM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ILKDGLCEENL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum CIBOIKKLHBA
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum GJKBPIIOGLD
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum HLPNPDOKEKM
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		BatchColour,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		RefreshShapesBatchColour,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		RefreshBatchedMeshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum PGNJEPAIEFN
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum IMHKAPLOLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum JEJGFBEFHLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum IBNHCHBJMFC
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum GCGNFDINDPA
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		LowQualityHighSpeed = 102
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool FEAKPGGLHCJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long HBOPICJFDCO;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool LKAJHMGDNHO;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool HMIHEMOOFAA;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool IILHAOPDCMP;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float JMCJJEMICMK;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float JGJCNOBPALG;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int GGMEFNKMMHJ;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static JEJGFBEFHLA FNLFIBMDEAM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long NADMGPMDOPD;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float KOFAHICEMPL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int EIPIKFJIPNO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int DKAKGFHNIGL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int BBHHGAFGPCD;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int NBIMNKKJODJ;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int GIFGACMFAGC;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int ABIPCAJPMOL;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int MCCMDLBBDLG;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int EAKKEBDKJBM;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool ECOAHGCHJGD;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int IGGKFKBCIOJ;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int BELNDKNFIBD;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int MCGOEDHNNCO;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool KGDOEEOKHFB;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float EEFBLCGGLDO;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool AELAHLKPPJB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float MOGNAMGCCPA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long CBGIIIJHFBO;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool EKNAPBHIDJK;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long DDPBDLBAOIE;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int EINAOBAJAOF;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool MBBFFPGNCLG;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static CIBOIKKLHBA BJCKHABFBFE;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool AMDNHGDCANA;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool IFNPMIPMOIP;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int IKHFDHAENHL;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int LKHHCNAFHOL;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int IJFFONGDKDP;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int CAFMJEINBJL;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int EGOKGAJEJNL;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int HHKEHCFMLIC;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int IAKFCOIKDHC;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int GPIDAPABDEF;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float GHPDGMNDGCE;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float IDKLNFEPFHD;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float GAAAJDDKCLL;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float IBNCPCMKJAD;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int NKKDNNIDFKM;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int OBBIIFIGAOB;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int ALPGNCMBBGF;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int CGGPGELANAM;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool DJGABICOALN;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static HLPNPDOKEKM APKKDACDEGA;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static PGNJEPAIEFN NAKOJFEBOJJ;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool MBLDJKLFFBJ;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static GJKBPIIOGLD CKEKJAECABF;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float CAGBLCJKKCA;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float KJKLCDHGMOG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float NDPFAMFPKEE;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float BCNKKGMLBDL;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float PMMHBFGFEMF;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float ACDFPKGADFC;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float OBKMOPABHEI;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float GBLMLKBFNCP;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool BGAICMOKHLM;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static IBNHCHBJMFC ELHEEHBPNEO;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool NAECDMPFBLF;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float DBGICEOOMCN;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float BKAHCGKDHFK;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float FNPIMCFDGMJ;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float HKLOJEHPFEP;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float EACPFDLGBAM;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool OBIKGHNEAHA;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long EHKIIOODKKB;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float PJIGNHPLLDC;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float DOOCGOLLIAL;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float EMKABFCFCCN;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int JLIHGFILEHK;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float PODLHFLHAGK;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool FMFDOACBDJG;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long AIDEBKLMPIN;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int HLFFBIBLCDM;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int KEJKHKOHFPK;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float DDKBGCBLDMH;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float GLEDGFLFNKI;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool EOCCOAADEGB;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool JAOAEKCCNKK;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float HAOFNGIDIJP;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long KAEICHIFOCM;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long MMDHELOFKBL;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int LPIMKKPDDGF;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 GOHAODLNFGP;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 ABMEAIBLNHM;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool FJBDJCHEJOJ;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static IMHKAPLOLNJ KNGOAMKNGAG;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long LNHHJPHMAKB;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int IKMDCBKNIEM;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int KELKDIPEMON;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int INOLOLPKFPP;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int BFNFEGMIAPB;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int OLAFDGEKEEF;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int GKFMEOPLPEP;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int IANGIAJMPJP;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static long FPIADAHECCN;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int AFAPKNEDKAF;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int AJNALFGEFBK;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int FGMILJGFHGC;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long FPNPHDOEKME;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long KABCCCCDGJA;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long GBAPNDNMHKB;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static long IBIBGEMPDMG;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int JLPDCGMFNGD;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int IAPOLKKDMMF;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int NBNNOCCJFPC;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int FHIFCKFJAKD;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static int MHGDPBFOCPE;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static int[] DNDJFIAGIFC;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int[] PKELABKFADF;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int EOBABPIAEEI;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long GOHGGJOJMAC;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long HJPBLNDJJCC;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static int KPDEACAAMFL;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static int NBMFAININAK;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long EEPGCCHIPKF;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long LLANHMBFEHE;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long AEHIDBHLBGE;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long DJDABODFBOP;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long JECPLDIIIHH;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static long HLIOOOJAGIL;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long DDPDMAHJMAJ;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long JOIMJAHGDAI;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long CLKPCKNKEHI;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static float MAHOMNCNFOP;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static float AABKLEICKEH;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long KJCDCICNGNO;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static int JFHFBNJFLIP;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long BIFBGBCFDDA;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long JDJGDGNLCFG;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static float LJFINPKKIPL;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long EDDNEMKJMFI;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long OHONNLGNDAH;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long EDIHNPCBOHP;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long HEPDDDIDMOF;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long ENIKPKOFOJA;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long GIHMIJANOBA;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long EJNIFGOMCLO;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long PBLAFGCMIAJ;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static long PKLMOGJGCMO;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static long JBCGLHDKBFI;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static long GHFBOEABBHM;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static long OHGJCDEHEAA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static GCGNFDINDPA MGMBABKKGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8283230", Offset = "0x8282030", VA = "0x188283230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long DIJIAOJFINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8284A00", Offset = "0x8283800", VA = "0x188284A00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8284350", Offset = "0x8283150", VA = "0x188284350")]
	public static void KKGOANFKNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8283290", Offset = "0x8282090", VA = "0x188283290")]
	public static void HCNHDHNJGCN(GCGNFDINDPA LCKNEADGMJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ICCDLEPALHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct MBDELJFCDFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public Vector3 BKNMJONCLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Quaternion DPJLAFKHMOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float EPJCPHOJPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public Quaternion CFOCPJEPNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float HIHAENHMDCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float NFOCDKHGMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float HHBEHOCJKDH;
	}

	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private static List<MBDELJFCDFP> JNBCKDPNPBD;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8281010", Offset = "0x827FE10", VA = "0x188281010")]
	public static NativeList<FLPAONONIEF> DOMDHEBBJON(DEAKCBKIHCK MDHOEKKPKHF)
	{
		return default(NativeList<FLPAONONIEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x827FFE0", Offset = "0x827EDE0", VA = "0x18827FFE0")]
	private static bool BHAGKBOCLAI(int BOECAAOIBHO, NativeList<FLPAONONIEF> OHLBIIOAJDL, List<MBDELJFCDFP> GGCENMEEMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8280E90", Offset = "0x827FC90", VA = "0x188280E90")]
	private static FLPAONONIEF CGFGCKCFPLP(int BLFNDPNNLJD, List<MBDELJFCDFP> GGCENMEEMKN)
	{
		return default(FLPAONONIEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8281680", Offset = "0x8280480", VA = "0x188281680")]
	private static FLPAONONIEF FMGIBDNPEKE(int BLFNDPNNLJD, List<MBDELJFCDFP> GGCENMEEMKN)
	{
		return default(FLPAONONIEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82815A0", Offset = "0x82803A0", VA = "0x1882815A0")]
	private static FLPAONONIEF EMILLAMHLLE(Vector3 MLCPBGGGOAK, Quaternion EOMHGOPNFOC, float LNLGAMEGNNM)
	{
		return default(FLPAONONIEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8281B70", Offset = "0x8280970", VA = "0x188281B70")]
	public static NativeList<FLPAONONIEF> MPCCOADBIEC(DEAKCBKIHCK MDHOEKKPKHF, float EADMNEOBMNA)
	{
		return default(NativeList<FLPAONONIEF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LCEPNPDEIBG
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public static Vector3 EBFFHCJIGJE;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public static Vector3 DGFNMEHHPNJ;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly float GNOIAKKODCO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8286630", Offset = "0x8285430", VA = "0x188286630")]
	public static Vector3 PLKJFGPMJGO(Vector3 ENLDPHFFCHA, Quaternion EOMHGOPNFOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82868C0", Offset = "0x82856C0", VA = "0x1882868C0")]
	public static Vector3 PPFBFNNIDDC(Quaternion NOLDGDLLBBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8285A90", Offset = "0x8284890", VA = "0x188285A90")]
	public static Vector3 EBFMJAGGPBK(Quaternion NOLDGDLLBBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8285720", Offset = "0x8284520", VA = "0x188285720")]
	public static Quaternion AEFHGMHHKHK(Vector3 NCJMIJBPLIB, Vector3 LCJFLGICHDD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8285B30", Offset = "0x8284930", VA = "0x188285B30")]
	public static Vector3 HJEBCHNEHIJ(Vector3 NPALPMMOKIM, Vector3 HLJMCAGNHHI, Vector3 LCJFLGICHDD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8285D20", Offset = "0x8284B20", VA = "0x188285D20")]
	public static Vector3 KDPECHCHMON(Vector3 ENLDPHFFCHA, Vector3 LCJFLGICHDD, Quaternion NOLDGDLLBBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8286150", Offset = "0x8284F50", VA = "0x188286150")]
	public static Quaternion KECJDJAPOGC(Quaternion EOMHGOPNFOC, Vector3 NCJMIJBPLIB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82864B0", Offset = "0x82852B0", VA = "0x1882864B0")]
	public static bool KFAFNCLBFON(Vector3 ECPONKBKGIM, Vector3 ADBCOKCLEPL, [Out] Vector3 EGEHAJPAGFC, bool KLOGALIGMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82857A0", Offset = "0x82845A0", VA = "0x1882857A0")]
	public static Vector3 COGJAPKIKNE(bool NLLGEMNHOJD, [Optional] Quaternion HEAFJPKNPGE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FLPAONONIEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float3 BKNMJONCLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public float3x3 DPJLAFKHMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public float EPJCPHOJPNJ;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DEAKCBKIHCK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int KMCEJHPDDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 PLMAJLDGGPC(int BLFNDPNNLJD);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion GPAKHJFMOCE(int BLFNDPNNLJD);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float CEIECHIHGHB(int BLFNDPNNLJD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HDAFBNCPEAH : IOKBKKINBCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GDBCHBAMBED
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool FGPEGJHCFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float DPNNBLMCMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int KJMOFKDALPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OAFBPIDLCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int FGKFCKBPHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<FLPAONONIEF> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KCFGAJKDIOC : IOKBKKINBCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LBBOFCAGNFJ OENJGGOHGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IGMKNKJDGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 LCBCICMILDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LCOLNOMHDFM
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GKKGCGDMMHN HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MDHGKJAOALO OKFOCLEADEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IOKBKKINBCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CBAECABMNNH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LCBFDCDIPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	GKKGCGDMMHN HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS HPOOFGHAGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float DBMGMMPBOML
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 LAGAFFABKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	AOKFBPFAEAA OMLLKOFLOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	PLHKBDHNDHI EILMFJBLPLE
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
public interface JKPIFGALOOA
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int ICGPOMBEAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform CCEMMIOHPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool MKCEIGCIOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IFKLBEEHLLN GetBone(int BLFNDPNNLJD);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int BLFNDPNNLJD);
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
