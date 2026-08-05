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
public enum GJHINECCNGL
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
public enum BLEKIMGBKEH
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
public enum GPFOAHFBENB
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
public enum HEMKNAONLNN
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
public enum PHLFHEADMAE
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
public enum FLEIDECPCLB
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
public static class PCNNJPIFKNE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71430A0", Offset = "0x71424A0", VA = "0x1871430A0")]
	public static bool BHDEKENJDCJ(this FLEIDECPCLB ALAHFOHFNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71430C0", Offset = "0x71424C0", VA = "0x1871430C0")]
	public static bool DHJBFPIALBP(this FLEIDECPCLB ALAHFOHFNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7143070", Offset = "0x7142470", VA = "0x187143070")]
	public static bool AFMLCMNAIPB(this FLEIDECPCLB ALAHFOHFNNO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HDEGMGMJOHI
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
public struct MKEMEHIOFOB : BCFJABJPHMG, IEquatable<MKEMEHIOFOB>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int MCCLHKLCIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD2A260", Offset = "0xD29660", VA = "0x180D2A260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int FALKEIDFDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x293B520", Offset = "0x293A920", VA = "0x18293B520", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x634DE50", Offset = "0x634D250", VA = "0x18634DE50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BDPCGJLEFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x713EBF0", Offset = "0x713DFF0", VA = "0x18713EBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2220A80", Offset = "0x221FE80", VA = "0x182220A80", Slot = "8")]
	public bool Equals(MKEMEHIOFOB BMKPAKCEMFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x30D7810", Offset = "0x30D6C10", VA = "0x1830D7810")]
	public static bool FANHDJJNLED(MKEMEHIOFOB DDIIBBHFODJ, MKEMEHIOFOB BCCGANGEINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x713EB60", Offset = "0x713DF60", VA = "0x18713EB60", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x713EC30", Offset = "0x713E030", VA = "0x18713EC30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct EMKOHBIHIFI : BCFJABJPHMG, IEquatable<EMKOHBIHIFI>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MCCLHKLCIBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD2A260", Offset = "0xD29660", VA = "0x180D2A260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int FALKEIDFDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x293B520", Offset = "0x293A920", VA = "0x18293B520", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x634DE50", Offset = "0x634D250", VA = "0x18634DE50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BDPCGJLEFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x713E9C0", Offset = "0x713DDC0", VA = "0x18713E9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2220A80", Offset = "0x221FE80", VA = "0x182220A80", Slot = "8")]
	public bool Equals(EMKOHBIHIFI BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x713E930", Offset = "0x713DD30", VA = "0x18713E930", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x713EA00", Offset = "0x713DE00", VA = "0x18713EA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LLAPBLJBOHK : BCFJABJPHMG, IEquatable<LLAPBLJBOHK>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MCCLHKLCIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD2A260", Offset = "0xD29660", VA = "0x180D2A260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FALKEIDFDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x293B520", Offset = "0x293A920", VA = "0x18293B520", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x634DE50", Offset = "0x634D250", VA = "0x18634DE50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BDPCGJLEFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x713EB20", Offset = "0x713DF20", VA = "0x18713EB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2220A80", Offset = "0x221FE80", VA = "0x182220A80", Slot = "8")]
	public bool Equals(LLAPBLJBOHK BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x713EA90", Offset = "0x713DE90", VA = "0x18713EA90", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HPHPPPLGLDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OILBIADOAAJ(MKEMEHIOFOB NIMLNKDMKHI, BLEKIMGBKEH OLOMMHLDCCH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OILBIADOAAJ(EMKOHBIHIFI CIMDBEJPBGL, BLEKIMGBKEH OLOMMHLDCCH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLMGCIEHOCI(EMKOHBIHIFI CIMDBEJPBGL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJABNIMPCFD(EMKOHBIHIFI CIMDBEJPBGL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void APCPKNGIEMK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCBECAJHGKN(BLEKIMGBKEH IFBDJLKPHIG);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ONEODOMFJLI(MKEMEHIOFOB NIMLNKDMKHI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONEODOMFJLI(EMKOHBIHIFI CIMDBEJPBGL);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NJLEPEJAEEL(EMKOHBIHIFI CIMDBEJPBGL);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GFBKJKBEJGA(EMKOHBIHIFI CIMDBEJPBGL);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LJAKLHCEGIK();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OGNBBEPFMHL();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IAKOKIECECH(MKEMEHIOFOB NIMLNKDMKHI, PHLFHEADMAE IFBDJLKPHIG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HOHODHGJGAD(EMKOHBIHIFI CIMDBEJPBGL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AIAFGJIFGEO(EMKOHBIHIFI CIMDBEJPBGL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KPIKKEGKDEJ();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JIIIIHJJCLA(PHLFHEADMAE IFBDJLKPHIG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EFOENELOOGK(MKEMEHIOFOB NIMLNKDMKHI, Vector3 BCHDEDCEDEP, Vector3 DOLONOFHCCC, Vector3 DEIAKILONPK, float PHPMIFINHOA, float EKKCMCBJGFA, IReadOnlyList<Camera> HHCIGOBFMBH, GJHINECCNGL PNKOKJNBOBJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EFOENELOOGK(LLAPBLJBOHK GDCLBDIFOJN, Vector3 BCHDEDCEDEP, Vector3 DOLONOFHCCC, Vector3 DEIAKILONPK, float PHPMIFINHOA, float EKKCMCBJGFA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HAMODOLAMII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EHFFBACIMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKEMEHIOFOB DCBHLAGNIAE(EGLHNIPKIOL JGCOLLOOLHL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MKEMEHIOFOB DCBHLAGNIAE(EGLHNIPKIOL JGCOLLOOLHL, bool HOCALBJPLED);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIEMCNPBOMB(MKEMEHIOFOB NIMLNKDMKHI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KGHINHONDCL(MKEMEHIOFOB NIMLNKDMKHI);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EMKOHBIHIFI IIMKNJGBMNN(MKEMEHIOFOB NIMLNKDMKHI, CGDLKBEKKDO JGCOLLOOLHL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EMKOHBIHIFI MLEABJKOLIA(MKEMEHIOFOB NIMLNKDMKHI, AIKPDBPDPPK JGCOLLOOLHL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MGGCCMOPCEI(EMKOHBIHIFI CIMDBEJPBGL);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AGLONECDGNH(EMKOHBIHIFI CIMDBEJPBGL);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LLAPBLJBOHK KNIMHJNDKBH(ONICHPCBCFJ JGCOLLOOLHL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BHNNHMBEBOE(LLAPBLJBOHK GDCLBDIFOJN);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HCFMPHKALMG(LLAPBLJBOHK GDCLBDIFOJN);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task BLEKIGIOGBO();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task NLAHALBLHIL();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task OJEMEHPGMLD();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MDAPIMJJEEN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> JMCHNCEIMPF(MKEMEHIOFOB NIMLNKDMKHI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DCAEJNCDDKM
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum JMNDHOCDOEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum FKFKHDLPBGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum DKPGKCKJDLA
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum JICEBJJLNLB
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum MNJOJDJDEFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum BAOKBPNIHCA
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum EOIJHMGLEGC
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Quest3,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		MemoryBuild,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		PS4VR,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool DNNHHPIHLBB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static long FOEBFIPJEHM;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static bool DENPNKLMGHN;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long ODOKLGCIBKH;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static int HALFABMJFML;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static FKFKHDLPBGI MEKHGMJKLBG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float GPNNCBGMJAN;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float POPENHJFPOK;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static long FKEHGMDIPCL;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long MHIOAAPFBHL;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static int LHLNHDLGEFE;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static bool BDHCHBCLKCA;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static long NGKNOFHBEEI;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static int BPIPDAKOILG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static int MCFFOHHGNON;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static long ACCGLGBGLBI;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static long JLGLDNEDCBF;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static int LGBOOGGCOIC;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static int MJAELHBLJKF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static int LHHEAIKDFIP;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static long CIPFHJPDPPC;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static long FGGIMBELBKB;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static long JFNLAMIPBKJ;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static long MIIDMFHLDAG;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static int NCJJPLKJKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static int JLEKLEIEJOA;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int JCPIFKNLFAO;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int PDKLIKFNMGK;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int[] NPJECABJJNM;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int AKDLHHJKDDE;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static long FLLJKKFACFB;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long OHFALCHKCMN;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int DBNPMEFDBDO;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static long FGJADOIGLID;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static long HCHJAGEOEKB;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long DDPEBHBOGLF;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long DNAHJHMCPMK;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long MEONLOJKCJF;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long GMLGHOLLLAK;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long KGEKMJBBCOH;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static long JJNCGHOHPLI;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static long JJGMBEICNIL;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static float PIGFGMNEKDP;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long ECMPFAIDHCP;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int GGEJPJAOPNL;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long FJJALNNBKON;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long OLGLJBBPIHD;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static float OFFMFHPAFGI;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static long NCIOCEBHNCG;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long HNINLOAIGOF;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long PPKIOHAHBGM;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long EAAIGKOIOJF;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long PHLBAKACOLD;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long JAKOJNKBLLE;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long GCFGJMGMIMG;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long CFEHCNIJCBI;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long NNHGAFMJMFP;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long MOLDMKACGFL;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static long NOMNPNAEPNM;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long CDDKKLLNLHC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool DGMCOCBLBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7139A70", Offset = "0x7138E70", VA = "0x187139A70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x713DE40", Offset = "0x713D240", VA = "0x18713DE40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static EOIJHMGLEGC LGFDANKOPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x713A910", Offset = "0x7139D10", VA = "0x18713A910")]
		[CompilerGenerated]
		get
		{
			return default(EOIJHMGLEGC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x713AAE0", Offset = "0x7139EE0", VA = "0x18713AAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool DOCECLMIAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x713D9D0", Offset = "0x713CDD0", VA = "0x18713D9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x713C6D0", Offset = "0x713BAD0", VA = "0x18713C6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool HDDGBIIHECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x713C090", Offset = "0x713B490", VA = "0x18713C090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x713C400", Offset = "0x713B800", VA = "0x18713C400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static float IAAGLMECFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x713DD40", Offset = "0x713D140", VA = "0x18713DD40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7139900", Offset = "0x7138D00", VA = "0x187139900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static float NNAKJBPOPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7139500", Offset = "0x7138900", VA = "0x187139500")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x713A0E0", Offset = "0x71394E0", VA = "0x18713A0E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static int MBCBOHFPNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x713AB80", Offset = "0x7139F80", VA = "0x18713AB80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7139ED0", Offset = "0x71392D0", VA = "0x187139ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static BAOKBPNIHCA KHNFNFCLOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7139800", Offset = "0x7138C00", VA = "0x187139800")]
		[CompilerGenerated]
		get
		{
			return default(BAOKBPNIHCA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x713A2E0", Offset = "0x71396E0", VA = "0x18713A2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long KNJBLBOMFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7139C70", Offset = "0x7139070", VA = "0x187139C70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x713A480", Offset = "0x7139880", VA = "0x18713A480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float ADLEPGADMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x713AED0", Offset = "0x713A2D0", VA = "0x18713AED0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x713DB30", Offset = "0x713CF30", VA = "0x18713DB30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int EENDJMENFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x71397B0", Offset = "0x7138BB0", VA = "0x1871397B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x713DEF0", Offset = "0x713D2F0", VA = "0x18713DEF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int GHGMNAAEKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x71399C0", Offset = "0x7138DC0", VA = "0x1871399C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x713B080", Offset = "0x713A480", VA = "0x18713B080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int GJLLDGLMMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x713B250", Offset = "0x713A650", VA = "0x18713B250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x713B190", Offset = "0x713A590", VA = "0x18713B190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int MBDGIDJCMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x713DD90", Offset = "0x713D190", VA = "0x18713DD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x713C3B0", Offset = "0x713B7B0", VA = "0x18713C3B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int FHOKOABACIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x71398B0", Offset = "0x7138CB0", VA = "0x1871398B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x713C460", Offset = "0x713B860", VA = "0x18713C460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int NKHABAIJBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7139760", Offset = "0x7138B60", VA = "0x187139760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x713C1B0", Offset = "0x713B5B0", VA = "0x18713C1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int AHHBEDEMGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x713C250", Offset = "0x713B650", VA = "0x18713C250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x713A3E0", Offset = "0x71397E0", VA = "0x18713A3E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool HBJMCEFOFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x713DC90", Offset = "0x713D090", VA = "0x18713DC90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int AGMIFIJMGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7139BD0", Offset = "0x7138FD0", VA = "0x187139BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x713ADE0", Offset = "0x713A1E0", VA = "0x18713ADE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int IEJIHANKCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x713A430", Offset = "0x7139830", VA = "0x18713A430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x713ABD0", Offset = "0x7139FD0", VA = "0x18713ABD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int EOAHBGFOGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x713A330", Offset = "0x7139730", VA = "0x18713A330")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7139F70", Offset = "0x7139370", VA = "0x187139F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool PNIAOFCHAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7139D70", Offset = "0x7139170", VA = "0x187139D70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7139700", Offset = "0x7138B00", VA = "0x187139700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float AKKAGFHGAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7139600", Offset = "0x7138A00", VA = "0x187139600")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7139DC0", Offset = "0x71391C0", VA = "0x187139DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static bool HMKIIBBPHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7139E20", Offset = "0x7139220", VA = "0x187139E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x713AA80", Offset = "0x7139E80", VA = "0x18713AA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool OCKFGHKJKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x713A140", Offset = "0x7139540", VA = "0x18713A140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x713B0D0", Offset = "0x713A4D0", VA = "0x18713B0D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static JMNDHOCDOEM LILPJCMGDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x713A670", Offset = "0x7139A70", VA = "0x18713A670")]
		[CompilerGenerated]
		get
		{
			return default(JMNDHOCDOEM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7139E70", Offset = "0x7139270", VA = "0x187139E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool BDDNCEPELJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x713A6C0", Offset = "0x7139AC0", VA = "0x18713A6C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x713AC20", Offset = "0x713A020", VA = "0x18713AC20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool IJLCEGKIGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7139C20", Offset = "0x7139020", VA = "0x187139C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x713DE90", Offset = "0x713D290", VA = "0x18713DE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static bool PIKLINKFCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x71394B0", Offset = "0x71388B0", VA = "0x1871394B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7139960", Offset = "0x7138D60", VA = "0x187139960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int GFOGMBFDDLA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x713AB30", Offset = "0x7139F30", VA = "0x18713AB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x713A380", Offset = "0x7139780", VA = "0x18713A380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int NKDGCFPEFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7139550", Offset = "0x7138950", VA = "0x187139550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x713C2A0", Offset = "0x713B6A0", VA = "0x18713C2A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int BIDEPGOJBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7139B80", Offset = "0x7138F80", VA = "0x187139B80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x713C500", Offset = "0x713B900", VA = "0x18713C500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static int PEMFGLAIBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7139F20", Offset = "0x7139320", VA = "0x187139F20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x713DAD0", Offset = "0x713CED0", VA = "0x18713DAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static int PFJEOEPHDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x713A760", Offset = "0x7139B60", VA = "0x18713A760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x713DDE0", Offset = "0x713D1E0", VA = "0x18713DDE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static int IIJEAIOPEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x713A240", Offset = "0x7139640", VA = "0x18713A240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x713C350", Offset = "0x713B750", VA = "0x18713C350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static int LEPOMHAHFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x713AE80", Offset = "0x713A280", VA = "0x18713AE80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x713A610", Offset = "0x7139A10", VA = "0x18713A610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static int DFKHLNNGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x713DA80", Offset = "0x713CE80", VA = "0x18713DA80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x713C610", Offset = "0x713BA10", VA = "0x18713C610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float CPJFIKJLICM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x713A810", Offset = "0x7139C10", VA = "0x18713A810")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x713AA20", Offset = "0x7139E20", VA = "0x18713AA20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float KNGLHBNIBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x713A8C0", Offset = "0x7139CC0", VA = "0x18713A8C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x713A7B0", Offset = "0x7139BB0", VA = "0x18713A7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static float IOBPIEMDFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x713A290", Offset = "0x7139690", VA = "0x18713A290")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7139A10", Offset = "0x7138E10", VA = "0x187139A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int JFOJMMMFCMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x713D8D0", Offset = "0x713CCD0", VA = "0x18713D8D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x713A190", Offset = "0x7139590", VA = "0x18713A190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static int GGFINMFAIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x713AE30", Offset = "0x713A230", VA = "0x18713AE30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x713A9C0", Offset = "0x7139DC0", VA = "0x18713A9C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int ONMGNDFOMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x713C730", Offset = "0x713BB30", VA = "0x18713C730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x713A080", Offset = "0x7139480", VA = "0x18713A080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int NPEOGMEPLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x713B3F0", Offset = "0x713A7F0", VA = "0x18713B3F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x713AFD0", Offset = "0x713A3D0", VA = "0x18713AFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static bool OEDBNBLHLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x713C300", Offset = "0x713B700", VA = "0x18713C300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7139850", Offset = "0x7138C50", VA = "0x187139850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static DKPGKCKJDLA ADDBKIMPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x713AF20", Offset = "0x713A320", VA = "0x18713AF20")]
		[CompilerGenerated]
		get
		{
			return default(DKPGKCKJDLA);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x713A4E0", Offset = "0x71398E0", VA = "0x18713A4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static JICEBJJLNLB LBELHEFMFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x713C4B0", Offset = "0x713B8B0", VA = "0x18713C4B0")]
		[CompilerGenerated]
		get
		{
			return default(JICEBJJLNLB);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7139650", Offset = "0x7138A50", VA = "0x187139650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static bool ANHFGIDEGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x713C0E0", Offset = "0x713B4E0", VA = "0x18713C0E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x71395A0", Offset = "0x71389A0", VA = "0x1871395A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static float KGIEHFCEBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x713B030", Offset = "0x713A430", VA = "0x18713B030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x713C5B0", Offset = "0x713B9B0", VA = "0x18713C5B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float HABBDALHIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x713B2A0", Offset = "0x713A6A0", VA = "0x18713B2A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x713A860", Offset = "0x7139C60", VA = "0x18713A860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float JFBDGIILHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x713DB90", Offset = "0x713CF90", VA = "0x18713DB90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x713B340", Offset = "0x713A740", VA = "0x18713B340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float FBHCKEMCDHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x713DC40", Offset = "0x713D040", VA = "0x18713DC40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x713DBE0", Offset = "0x713CFE0", VA = "0x18713DBE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static float HFFCBJBCIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x713D980", Offset = "0x713CD80", VA = "0x18713D980")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x713DF40", Offset = "0x713D340", VA = "0x18713DF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static float DKEDDIOCCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x713A1F0", Offset = "0x71395F0", VA = "0x18713A1F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7139AC0", Offset = "0x7138EC0", VA = "0x187139AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static bool LGJMHKIGGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x713ACD0", Offset = "0x713A0D0", VA = "0x18713ACD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x713BFE0", Offset = "0x713B3E0", VA = "0x18713BFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static float OHLBEHAIACK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x713DFA0", Offset = "0x713D3A0", VA = "0x18713DFA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7139B20", Offset = "0x7138F20", VA = "0x187139B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static float KDLBMNKLAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x713B2F0", Offset = "0x713A6F0", VA = "0x18713B2F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x713AF70", Offset = "0x713A370", VA = "0x18713AF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static float MFCFJFKIJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7139460", Offset = "0x7138860", VA = "0x187139460")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7139FC0", Offset = "0x71393C0", VA = "0x187139FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static int HBJJFKOIHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x713B440", Offset = "0x713A840", VA = "0x18713B440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x713DCE0", Offset = "0x713D0E0", VA = "0x18713DCE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static float HPPECJOIJNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x713A710", Offset = "0x7139B10", VA = "0x18713A710")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static bool DIFPMDBIPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x713C200", Offset = "0x713B600", VA = "0x18713C200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7139D10", Offset = "0x7139110", VA = "0x187139D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static int AKIHNKMMCKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7139CC0", Offset = "0x71390C0", VA = "0x187139CC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x713D920", Offset = "0x713CD20", VA = "0x18713D920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static float FLPHAPKEBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x713C560", Offset = "0x713B960", VA = "0x18713C560")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x713AD80", Offset = "0x713A180", VA = "0x18713AD80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static float GHIBBKLHAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x713AC80", Offset = "0x713A080", VA = "0x18713AC80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x713C670", Offset = "0x713BA70", VA = "0x18713C670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public static bool APLHLMHAFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x71396B0", Offset = "0x7138AB0", VA = "0x1871396B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x713A020", Offset = "0x7139420", VA = "0x18713A020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public static float JCMLHOFCAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x713C040", Offset = "0x713B440", VA = "0x18713C040")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x713B130", Offset = "0x713A530", VA = "0x18713B130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static float4x4 BFPAKIMFIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x713C130", Offset = "0x713B530", VA = "0x18713C130")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x713A540", Offset = "0x7139940", VA = "0x18713A540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static float3 IJLMLGJHFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x713B1E0", Offset = "0x713A5E0", VA = "0x18713B1E0")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x713A960", Offset = "0x7139D60", VA = "0x18713A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static bool DOOHGKAIDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x713B3A0", Offset = "0x713A7A0", VA = "0x18713B3A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x713AD20", Offset = "0x713A120", VA = "0x18713AD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public static MNJOJDJDEFH JOHJODOOMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x713A5C0", Offset = "0x71399C0", VA = "0x18713A5C0")]
		[CompilerGenerated]
		get
		{
			return default(MNJOJDJDEFH);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x713DA20", Offset = "0x713CE20", VA = "0x18713DA20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x713C780", Offset = "0x713BB80", VA = "0x18713C780")]
	public static void NEKHEGHGAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x713B490", Offset = "0x713A890", VA = "0x18713B490")]
	public static void LAMHAJFOEDJ(EOIJHMGLEGC FLEOJPFOLGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ONPFNPHHHGK
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private struct MJFDHNJEFOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public Vector3 FGALHLKMLDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public Quaternion IKGAHCGJKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public float KOFPJFICEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Quaternion LOHPOANFEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public float OHFHOBHMKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public float OIPKMFHKEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float BDBEGDNCCKL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static List<MJFDHNJEFOG> MBPCLPCNHPA;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7140590", Offset = "0x713F990", VA = "0x187140590")]
	public static NativeList<LMKDMCGCAOO> EHKFFHGFECB(LPLOOLNENLA APBNMEDOGLK)
	{
		return default(NativeList<LMKDMCGCAOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7142150", Offset = "0x7141550", VA = "0x187142150")]
	private static bool NDDBGIACFOJ(int IBIAGDBMPOH, NativeList<LMKDMCGCAOO> CEDDFJCBLGM, List<MJFDHNJEFOG> JBEDJDHJIDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7140B30", Offset = "0x713FF30", VA = "0x187140B30")]
	private static LMKDMCGCAOO JHENFNFBNDA(int DEFGGFLHDDI, List<MJFDHNJEFOG> JBEDJDHJIDG)
	{
		return default(LMKDMCGCAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x71400A0", Offset = "0x713F4A0", VA = "0x1871400A0")]
	private static LMKDMCGCAOO DLKKAJEEIPF(int DEFGGFLHDDI, List<MJFDHNJEFOG> JBEDJDHJIDG)
	{
		return default(LMKDMCGCAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x713FFC0", Offset = "0x713F3C0", VA = "0x18713FFC0")]
	private static LMKDMCGCAOO CKFHMNCGEHD(Vector3 MIIBBEPBJLP, Quaternion GIOBPCBFDIE, float NCJKDICMFFP)
	{
		return default(LMKDMCGCAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7140CB0", Offset = "0x71400B0", VA = "0x187140CB0")]
	public static NativeList<LMKDMCGCAOO> LILPKBMMMAI(LPLOOLNENLA APBNMEDOGLK, float HBFMIMKNHMF)
	{
		return default(NativeList<LMKDMCGCAOO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NBFJHFMNHBH
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public static Vector3 CELGIAJFPEP;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public static Vector3 KFDBFIABGDD;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public static readonly float NKHDEHBNLKM;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x713F030", Offset = "0x713E430", VA = "0x18713F030")]
	public static Vector3 ANGONECJPCN(Vector3 PEHHHOKOAIC, Quaternion GIOBPCBFDIE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x713FAF0", Offset = "0x713EEF0", VA = "0x18713FAF0")]
	public static Vector3 HINCANHCGFF(Quaternion CBCAIPELAJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x713F8D0", Offset = "0x713ECD0", VA = "0x18713F8D0")]
	public static Vector3 GCGNGECPABJ(Quaternion CBCAIPELAJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x713ECC0", Offset = "0x713E0C0", VA = "0x18713ECC0")]
	public static Quaternion AKJALGAIIMP(Vector3 LIDLBHGKPBN, Vector3 ADDIIGBEIBA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x713F2B0", Offset = "0x713E6B0", VA = "0x18713F2B0")]
	public static Vector3 EAIALKLODJK(Vector3 HKBANFCEIDL, Vector3 PLFLKLFMDFJ, Vector3 ADDIIGBEIBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x713F4A0", Offset = "0x713E8A0", VA = "0x18713F4A0")]
	public static Vector3 EHPGENIMGHD(Vector3 PEHHHOKOAIC, Vector3 ADDIIGBEIBA, Quaternion CBCAIPELAJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x713FB90", Offset = "0x713EF90", VA = "0x18713FB90")]
	public static Quaternion JNADNFJCBIG(Quaternion GIOBPCBFDIE, Vector3 LIDLBHGKPBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x713F970", Offset = "0x713ED70", VA = "0x18713F970")]
	public static bool HAJBMCHIFBJ(Vector3 OPMHGBEGDCE, Vector3 PDLKFGGFEHL, [Out] Vector3 DKOKMOABENA, bool FMBMOCGLKNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x713ED40", Offset = "0x713E140", VA = "0x18713ED40")]
	public static Vector3 AKKDOFOKHHC(bool MNBFKCCKPAG, [Optional] Quaternion KEOFMEDACNC)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct LMKDMCGCAOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public float3 FGALHLKMLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public float3x3 IKGAHCGJKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public float KOFPJFICEPK;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LPLOOLNENLA
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int DNNNECGKMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BMHIFAIBDCJ(int DEFGGFLHDDI);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion BKHGEHGILPG(int DEFGGFLHDDI);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float IJFNEDMNMCM(int DEFGGFLHDDI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AIKPDBPDPPK : GHMLMFMOILD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool DKMLLJDHEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool MLADAJOKNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float EFJHHPMKNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int MDOHBLCPKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool IIKNHDJHPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	int NLOPINDHPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<LMKDMCGCAOO> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CGDLKBEKKDO : GHMLMFMOILD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	GPFOAHFBENB HJPEKEOHMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool FFFMDHIEOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 DAOKLOIBCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EGLHNIPKIOL
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	JBNHCDLOLNG DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	HEMKNAONLNN IDOOLOFOONG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GHMLMFMOILD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool KBLOLEBAPND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool GAGCIHMLCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	JBNHCDLOLNG DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	UniformTRS DCBJKPHEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	float INKCEBLHBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Vector3 OLILMPFLLBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	FLEIDECPCLB OGGNNJNDONE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	HDEGMGMJOHI GFDOEFACLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ONICHPCBCFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int AEPCILDCJME
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform ICPJGKCADGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool IMPGEJIIAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MKEMEHIOFOB GetBone(int DEFGGFLHDDI);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int DEFGGFLHDDI);
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
