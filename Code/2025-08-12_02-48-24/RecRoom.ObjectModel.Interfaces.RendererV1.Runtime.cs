using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation.Mathematics;
using RecRoom.RendererV1.Terrain;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GKHANICHKNM
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
public enum HPNEHHPMAMF
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
public enum DAKFOMKEJOH
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
public enum PBMIECBIOFI
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
public enum BFKHDCBEHIE
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
public enum JHJALLMJIFB
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
public static class HMBKMAIBEAE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x862F390", Offset = "0x862D990", VA = "0x18862F390")]
	public static bool NGALAMLLAJL(this JHJALLMJIFB FCGLIALLIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x862F350", Offset = "0x862D950", VA = "0x18862F350")]
	public static bool LLJCDDJKCLI(this JHJALLMJIFB FCGLIALLIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x862F360", Offset = "0x862D960", VA = "0x18862F360")]
	public static bool NECJGJJGMPJ(this JHJALLMJIFB FCGLIALLIEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CKIILNPNIGK
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
public struct MOELEHFPCPE : ILGHCGIBOJL, IEquatable<MOELEHFPCPE>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int CIDOMJAOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x302EA20", Offset = "0x302D020", VA = "0x18302EA20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x302EA30", Offset = "0x302D030", VA = "0x18302EA30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EJBELALFPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86326A0", Offset = "0x8630CA0", VA = "0x1886326A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x13F29A0", Offset = "0x13F0FA0", VA = "0x1813F29A0", Slot = "8")]
	public bool Equals(MOELEHFPCPE IBCMCOKAJEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F600", Offset = "0x3F3DC00", VA = "0x183F3F600")]
	public static bool LMIMJGGKHMP(MOELEHFPCPE IAFDMJDNHDH, MOELEHFPCPE DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8632600", Offset = "0x8630C00", VA = "0x188632600", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x86326E0", Offset = "0x8630CE0", VA = "0x1886326E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IFOKEJDEOGF : ILGHCGIBOJL, IEquatable<IFOKEJDEOGF>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int CIDOMJAOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x302EA20", Offset = "0x302D020", VA = "0x18302EA20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x302EA30", Offset = "0x302D030", VA = "0x18302EA30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EJBELALFPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x862F450", Offset = "0x862DA50", VA = "0x18862F450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x13F29A0", Offset = "0x13F0FA0", VA = "0x1813F29A0", Slot = "8")]
	public bool Equals(IFOKEJDEOGF IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x862F3B0", Offset = "0x862D9B0", VA = "0x18862F3B0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x862F490", Offset = "0x862DA90", VA = "0x18862F490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AMGLFNOLFKB : ILGHCGIBOJL, IEquatable<AMGLFNOLFKB>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CIDOMJAOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x302EA20", Offset = "0x302D020", VA = "0x18302EA20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x302EA30", Offset = "0x302D030", VA = "0x18302EA30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EJBELALFPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x862B990", Offset = "0x8629F90", VA = "0x18862B990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x13F29A0", Offset = "0x13F0FA0", VA = "0x1813F29A0", Slot = "8")]
	public bool Equals(AMGLFNOLFKB IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x862B8F0", Offset = "0x8629EF0", VA = "0x18862B8F0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KPOKAGBLPPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOFNGBLGAKP(MOELEHFPCPE PPOKNBNEDHM, HPNEHHPMAMF OOEPNBCGDBB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOFNGBLGAKP(IFOKEJDEOGF NDLHPLKACFL, HPNEHHPMAMF OOEPNBCGDBB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCMBNEGKMKG(IFOKEJDEOGF NDLHPLKACFL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENJDKJGFBBO(IFOKEJDEOGF NDLHPLKACFL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BKKGGEKCFJK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDBNHDIKLDG(HPNEHHPMAMF EHLAHNIAPLD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PBBKBFLAFJG(MOELEHFPCPE PPOKNBNEDHM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PBBKBFLAFJG(IFOKEJDEOGF NDLHPLKACFL);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JPHGIJCJLNH(IFOKEJDEOGF NDLHPLKACFL);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FBHOHOBMPFA(IFOKEJDEOGF NDLHPLKACFL);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AAOGGAPGAMF();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HIMKJKBMKAH();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FFGDMFIGIHN(MOELEHFPCPE PPOKNBNEDHM, BFKHDCBEHIE EHLAHNIAPLD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FDDFMHGLBKO(IFOKEJDEOGF NDLHPLKACFL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BIEAPFGADJJ(IFOKEJDEOGF NDLHPLKACFL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KPCOLBPPHMO();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IKBNLFKPABL(BFKHDCBEHIE EHLAHNIAPLD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MECPHOOMCEM(MOELEHFPCPE PPOKNBNEDHM, Vector3 HMAEOJELIFN, Vector3 LCHHDDILKNF, Vector3 OHFMCOFKEEH, float APELLKBPHOD, float OMLMLHNGAPG, IReadOnlyList<Camera> FBHOBMBNCDL, GKHANICHKNM KCBMGJBFEDC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MECPHOOMCEM(AMGLFNOLFKB HDJAEIGPJHD, Vector3 HMAEOJELIFN, Vector3 LCHHDDILKNF, Vector3 OHFMCOFKEEH, float APELLKBPHOD, float OMLMLHNGAPG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IPGDEIOBDCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IHJNEAHJLCN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MOELEHFPCPE JAPOBCDIJPN(BGNDGMGKLOG DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MOELEHFPCPE JAPOBCDIJPN(BGNDGMGKLOG DAJAOHIJHHL, bool DIBFFCNMPLC);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFICJPMALCG(MOELEHFPCPE PPOKNBNEDHM);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDCMCGKHKIJ(MOELEHFPCPE PPOKNBNEDHM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IFOKEJDEOGF LDFKKLCMFAF(MOELEHFPCPE PPOKNBNEDHM, KINPHOMJCLM DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IFOKEJDEOGF ELIGFFJCPJP(MOELEHFPCPE PPOKNBNEDHM, FOCDFGPPKDG DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KMABDPIPIJB(IFOKEJDEOGF NDLHPLKACFL);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OGHMMCDDPLB(IFOKEJDEOGF NDLHPLKACFL);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AMGLFNOLFKB HLAGGKFHIGL(MDPFJBPFLFJ DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KKNJMOJANLF(AMGLFNOLFKB HDJAEIGPJHD);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CHMOEIADNAC(AMGLFNOLFKB HDJAEIGPJHD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task MGOOPPEMAMI();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task LAJCOBFKHFL();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task EBDDJIEOMCC();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IAPMGJPPHIH();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> DDIOPHDLELO(MOELEHFPCPE PPOKNBNEDHM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HLLPFHAANOG
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum CPAGPJNKKGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum ONIEBIOCCGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum LPJDHBJANOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		BatchColour,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		RefreshShapesBatchColour,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		RefreshBatchedMeshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum AHACOGCEOBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum GMCEAOFAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum HBOBDIDIHIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		CheckPassive,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum ADPEMKOKFJO
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum OBLPIPPNIPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		LowQualityHighSpeed = 102,
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		SpreadsheetSettings = 103
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool GIDCIEJMFOF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long KDJKOLKONMN;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool ECCLKNDJCPC;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool HJKHGKJKHCP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool DDBLMOMACPJ;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float GCAJEEBLELA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float JNEOBFMJBBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int LCAOIHOAKOE;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static HBOBDIDIHIF AAHNGLLPODJ;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long NAPOMPCODLC;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float FHCPFHKLLKD;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int OCFGGLOEPFG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int ADDAFCJALOK;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int JHBEDFFMNIO;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int NEPGHHJAJNI;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int KIIOHDFGCAL;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int EAFGPDGNMAK;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int OHADCIFAOIL;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int GBJOPDAHEIG;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool PAOJHAEFOLD;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int HCMECHOEGMG;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int DFOJCCJLDDH;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int CDJPDCGPBJA;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool DEOBDMGFJAF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float BKIBCADPPPE;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool MEBAMCGLMOL;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float FBHHAFHMJBG;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long ODKHNLKFAHM;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool MEGDCKAHOAD;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long ACFJOGPCEGK;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int LPEJAFHLIFH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool IGLOJOBPCJC;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static CPAGPJNKKGH PMOKPHGIPMF;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool BHDLOACFPOM;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool GCPKFGCGCKB;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int MNGBIEINPOJ;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int PNBNCIPPNGJ;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int MJJEMNHDNAP;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int MFCLIDPLCEE;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int BJIKCKFMAEA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int ADHIJFIOKDM;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int BBILCCIEOHP;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int MGIGGHEEDJA;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float CMGOODDDOHO;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float MNCCPMCCIEA;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float MAPNDBIMIOG;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float GHJFIAOKCEL;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int PBNFNMKFBMD;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int MIGHGPDHHEP;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int CPMLKHLKEFI;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int DFBCMDEBPBE;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool MGAAGDKKAEG;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static LPJDHBJANOC CLEKDCIINDM;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static AHACOGCEOBI AGEHAKODHAN;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool BDMFFEDJJIA;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static ONIEBIOCCGF HJNGOJIMAIA;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float MJOCKIFOHLB;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float PJLLIBACLJE;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float JNOOPPLNGIH;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float CFKMLLNOINF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float KLJOEGCDLDB;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float NIGDPADNFJP;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float FMCFPINFGDA;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float JBJMANEMAAN;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool NOBDPHKNBAK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static ADPEMKOKFJO HKFEKIOIOPD;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool LHHDMHHFJCO;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float CNHHOHHHICD;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float HFDDJBPEODC;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float DGEDHJOLLPI;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float FCMGDGANFEG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float LIBEEDAKBGJ;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool OMGNOJAIAPM;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long PMDBGLKLFAB;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float PJBFCCLFNPF;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float PMKMOLFDGIG;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float LNFOOLOBDGB;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int CIJIBIMLFAM;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float DEENIDNBECO;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool CHFHFFOOPKA;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long DKGPMMAEJGE;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int JGFIHKCPAIO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int OLMDBEAEMME;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float FFPKANFIKMK;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float EMHBJJIGGGD;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool PJAFDKKLFPH;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool GJCOOFPPOGJ;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float CCMNJPAGKLK;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long FEPJIHDHIEG;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long OGAJFMLKJHJ;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int BBAMDHELCFL;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static bool NEMPODKABND;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float MKBPBBNOGMI;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static float EPBFCAEKOIL;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static bool AKPKLMFHNFM;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long KPMEHHNOCJL;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int OILAJGDGHAA;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static float4x4 JACFBDDLGLM;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static float3 HHMADCCGBDK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static bool MENFNEDALLM;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static GMCEAOFAFMK MIDHELOLKIO;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long EHCDAECKHBD;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int JMIJHIGLNKB;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int NIHDJFMNIPN;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int IEIPHKMBCBA;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int MMHNADEHBOI;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int ABFLKECPJKA;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int GLEIGMKLABE;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int DAFLHFDPKMI;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long HGFJPCLFBPE;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int OGCBILOHKCL;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int MNJHIGEKCNM;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int MDAABDEOMNN;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long EIHIFDBCJNF;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long DKCJPMFIIJK;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long IHAMKHBJKHE;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long BLCIPKCEPHP;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int KJKMJBIMKMN;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int LNAKGNCPNGK;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static int OIPHPELLHEC;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static int OGOLCDKLMHM;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static int NLLMOIFFMFA;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static int[] DDDANKKHDBM;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static int[] PLCBGPEIMBO;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static int OMPEBHONMKI;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long PFNOMPJLFFD;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long PDAELMKKOEL;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static int CNJPAKMBPAF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static int EHLHGPFABJJ;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long LHMFKHHNNNE;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long NHGJHIJKGEI;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long MKCOLBNKHEM;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long AEDAEIGIBEL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long DGDBKAFCHPK;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long LMFOMLFGHLG;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long DOPIHBDAJNC;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long LDGLMONEDGN;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long JFHHFKONAGO;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static float AGPPKHDGKDA;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static float JBIAPPINBBC;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long GDGILNCJJJH;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static int GHKHDGMHEJL;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long FKPACBBFNMM;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long HHPIEIFKOHO;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static float BFPOHALLCNK;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long EKMMHHIGMFE;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long JNKMAEMBPIP;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static long PJECMIKCJKI;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static long IPJLEAKJONL;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static long OLDMFMALJJI;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static long LNKLNJGGBDI;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static long BLAJOCENOPD;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static long NNGOGOFFEAO;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static long INECHKPPMNK;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static long GANBBEAPBNP;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static long DKPLLOOKAAG;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static long HDACAGCEOLG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static OBLPIPPNIPE CGBOLLDAANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x862E5B0", Offset = "0x862CBB0", VA = "0x18862E5B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long HDHEENBHJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x862DEA0", Offset = "0x862C4A0", VA = "0x18862DEA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x862DF00", Offset = "0x862C500", VA = "0x18862DF00")]
	public static void MBLCJGPACFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x862CCF0", Offset = "0x862B2F0", VA = "0x18862CCF0")]
	public static void GAJDOJDEHMN(OBLPIPPNIPE JCPDLNNDAMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class JBMPIJNPFNN
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct IAPOCLHPONB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Vector3 IIKJNDDFMGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Quaternion NEMGOCEHIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public float ELLGGJLJFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Quaternion JLJJDIAFLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public float GCBLEBFBCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public float NGNIMMMFPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public float IOHEJJJPMOK;
	}

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static List<IAPOCLHPONB> NIMPGEKBMEE;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8630B20", Offset = "0x862F120", VA = "0x188630B20")]
	public static NativeList<ONPFMKLHPJO> KJBGBOJLAJJ(PPGDCNAHADK AFDLHEFMFJN)
	{
		return default(NativeList<ONPFMKLHPJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x862FB90", Offset = "0x862E190", VA = "0x18862FB90")]
	private static bool IBCBHKAMODH(int JFOIDEBHAAF, NativeList<ONPFMKLHPJO> CENCPMGPALN, List<IAPOCLHPONB> ODLDCBBJIMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x862F520", Offset = "0x862DB20", VA = "0x18862F520")]
	private static ONPFMKLHPJO CFLKMPCOGJJ(int IEODBGLFEOD, List<IAPOCLHPONB> ODLDCBBJIMN)
	{
		return default(ONPFMKLHPJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x862F6A0", Offset = "0x862DCA0", VA = "0x18862F6A0")]
	private static ONPFMKLHPJO EGKDLLKFEKJ(int IEODBGLFEOD, List<IAPOCLHPONB> ODLDCBBJIMN)
	{
		return default(ONPFMKLHPJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8630A40", Offset = "0x862F040", VA = "0x188630A40")]
	private static ONPFMKLHPJO JBKOJIHBMEC(Vector3 DPLNHDFCMOI, Quaternion LNFJGJBDGFN, float OFHHJJPMNHK)
	{
		return default(ONPFMKLHPJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86310B0", Offset = "0x862F6B0", VA = "0x1886310B0")]
	public static NativeList<ONPFMKLHPJO> NPPKKKAPNOG(PPGDCNAHADK AFDLHEFMFJN, float GCKDOKKMKKC)
	{
		return default(NativeList<ONPFMKLHPJO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HHHFJJJAKBD
{
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static Vector3 DCNPCABHFPE;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static Vector3 JAKPOEDDIPK;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly float EKJOIEDAHGA;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x862C2B0", Offset = "0x862A8B0", VA = "0x18862C2B0")]
	public static Vector3 GAHLPODOPOG(Vector3 FBFAIDDNOGA, Quaternion LNFJGJBDGFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x862C210", Offset = "0x862A810", VA = "0x18862C210")]
	public static Vector3 FMHAGNINCFE(Quaternion NEOIPHFFLHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x862C0F0", Offset = "0x862A6F0", VA = "0x18862C0F0")]
	public static Vector3 DMOOFOMNNBE(Quaternion NEOIPHFFLHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x862C190", Offset = "0x862A790", VA = "0x18862C190")]
	public static Quaternion FAOMANNMICL(Vector3 FANJPCNJGDA, Vector3 NNMAALGIDJM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x862C6C0", Offset = "0x862ACC0", VA = "0x18862C6C0")]
	public static Vector3 MLBNMGBNALN(Vector3 DLEODCLDJIO, Vector3 IHBFPFJALDL, Vector3 NNMAALGIDJM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x862B9D0", Offset = "0x8629FD0", VA = "0x18862B9D0")]
	public static Vector3 BGHFAIPPFJF(Vector3 FBFAIDDNOGA, Vector3 NNMAALGIDJM, Quaternion NEOIPHFFLHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x862C8B0", Offset = "0x862AEB0", VA = "0x18862C8B0")]
	public static Quaternion NDNGIDODHDO(Quaternion LNFJGJBDGFN, Vector3 FANJPCNJGDA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x862C540", Offset = "0x862AB40", VA = "0x18862C540")]
	public static bool KJOEECOPMLE(Vector3 KJNLAHHGFPP, Vector3 BNMIDGJMFBO, [Out] Vector3 KDCHPNLBIGB, bool EMMBIHLOBAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x862BE00", Offset = "0x862A400", VA = "0x18862BE00")]
	public static Vector3 CNGJENPJPIC(bool ONFNLFEPALF, [Optional] Quaternion IIJGDHKPEAD)
	{
		return default(Vector3);
	}
}
namespace RecRoom.RendererV1.Terrain
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct TerrainMaterialLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float heightCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public float slopeCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Color topColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public CKIILNPNIGK topMaterialInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public Color slopeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public CKIILNPNIGK slopeMaterialInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct TerrainWaterProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public bool WaterEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public float WaterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public Color WaterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Color DeepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public float EmissiveStrength;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class TerrainGenerationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public LMJANGHOCHE baseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public float baseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public float baseTerrainScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public TerrainGenerationLayer[] additionalLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public TerrainMaterialLayer[] materialLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public bool normalizeLayerHeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public IDAMNGPLNCK playArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public float playAreaOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public TerrainWaterProperties globalWaterProperties;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8632770", Offset = "0x8630D70", VA = "0x188632770")]
		public TerrainGenerationInfo()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct TerrainInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public float GroundHeight;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AJKGBDBIABJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	TerrainData PDPHCAJCBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GameObject KLKHHMEMBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 KIHJHDEPAIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float3 NGFPMEALOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float3 NAFINNBDMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	TerrainGenerationInfo GJEEAOEJHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	TerrainInfo PONBIAIINLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> JHDAKFPLOLF(uint NIOMGJANNON, bool ODCIBPHFNOE = true, bool CENICICFICP = true, bool BIEGFBCMOKJ = true, [Optional] TerrainGenerationInfo AFDLHEFMFJN, HIBCLHNAINH LGDICPKEJCD = HIBCLHNAINH.Default, [Optional] float3? GAEMKFJLCNG, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LOMEBHIDOPA(bool CEPPFMGDODG);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IAFMNMIAAOC(Action<Material> CPPMGJEJBPB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct ONPFMKLHPJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public float3 IIKJNDDFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public float3x3 NEMGOCEHIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public float ELLGGJLJFAI;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PPGDCNAHADK
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int EMNJLKJLEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 EKPAOGNKNHD(int IEODBGLFEOD);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion EFMBPFAPJAK(int IEODBGLFEOD);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float EBCCAMPBHJE(int IEODBGLFEOD);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FOCDFGPPKDG : GIIFJHIFIIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IJLHGOCOMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KBLBFPOEDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float FMHEGOGCEON
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int AOIAILACBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KDGEOLNDMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int AGLBEGDADAF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<ONPFMKLHPJO> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KINPHOMJCLM : GIIFJHIFIIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DAKFOMKEJOH LFEMELPPIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool DKBOGHJDABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float3 LILJOILJLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface BGNDGMGKLOG
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	HGOECGDMDII ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	PBMIECBIOFI ILAFKJJHADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GIIFJHIFIIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool KGINCHNHDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DGOFIAMECID
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	HGOECGDMDII ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	UniformTRS PEAHHINEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float BALIPDKKMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 FHCKALKBBOO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	JHJALLMJIFB KOCDJLPKCPB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CKIILNPNIGK CIFBJANMCKL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MDPFJBPFLFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int PANJMICONFN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Transform KHMNPKHMMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool AMECIDDPHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MOELEHFPCPE GetBone(int IEODBGLFEOD);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int IEODBGLFEOD);
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
