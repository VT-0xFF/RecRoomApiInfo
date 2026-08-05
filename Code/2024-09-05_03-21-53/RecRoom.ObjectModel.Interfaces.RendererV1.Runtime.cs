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
public enum HIKLJPELLBA
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
public enum NIDBICOIDOK
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
public enum DLBBPBLJBPM
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
public enum KEMEMJMNCHE
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
public enum MKHKMPLGLOM
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
public enum KKGOBCNALDK
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
public static class GLCGGCPMKPD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6CB0400", Offset = "0x6CAEE00", VA = "0x186CB0400")]
	public static bool MHFJHBMBLLK(this KKGOBCNALDK FMHFHPFEEOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6CB03F0", Offset = "0x6CAEDF0", VA = "0x186CB03F0")]
	public static bool MGMMMJINJNB(this KKGOBCNALDK FMHFHPFEEOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6CB03C0", Offset = "0x6CAEDC0", VA = "0x186CB03C0")]
	public static bool GLONHIPCBJG(this KKGOBCNALDK FMHFHPFEEOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DCLHCFNCEDH
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
public struct DLDFPOMGDOP : LCMEFFHGKGH, IEquatable<DLDFPOMGDOP>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int MOMFAOPBBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int EBJFPPIDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2664280", Offset = "0x2662C80", VA = "0x182664280", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F77A80", Offset = "0x5F76480", VA = "0x185F77A80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IMCHLNDGPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF000", Offset = "0x6CADA00", VA = "0x186CAF000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7AC0", Offset = "0x1FA64C0", VA = "0x181FA7AC0", Slot = "8")]
	public bool Equals(DLDFPOMGDOP AIPFCMFLDKG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B69F50", Offset = "0x6B68950", VA = "0x186B69F50")]
	public static bool CIBBJNPKHCF(DLDFPOMGDOP GPKBBMJKBAE, DLDFPOMGDOP AAMOGMLMOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6CAEF60", Offset = "0x6CAD960", VA = "0x186CAEF60", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF040", Offset = "0x6CADA40", VA = "0x186CAF040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DDLNHDPCINE : LCMEFFHGKGH, IEquatable<DDLNHDPCINE>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MOMFAOPBBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int EBJFPPIDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2664280", Offset = "0x2662C80", VA = "0x182664280", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5F77A80", Offset = "0x5F76480", VA = "0x185F77A80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IMCHLNDGPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6CAEE90", Offset = "0x6CAD890", VA = "0x186CAEE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7AC0", Offset = "0x1FA64C0", VA = "0x181FA7AC0", Slot = "8")]
	public bool Equals(DDLNHDPCINE AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6CAEDF0", Offset = "0x6CAD7F0", VA = "0x186CAEDF0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CAEED0", Offset = "0x6CAD8D0", VA = "0x186CAEED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KCNFFJOGDNE : LCMEFFHGKGH, IEquatable<KCNFFJOGDNE>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MOMFAOPBBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EBJFPPIDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2664280", Offset = "0x2662C80", VA = "0x182664280", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5F77A80", Offset = "0x5F76480", VA = "0x185F77A80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IMCHLNDGPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB04C0", Offset = "0x6CAEEC0", VA = "0x186CB04C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7AC0", Offset = "0x1FA64C0", VA = "0x181FA7AC0", Slot = "8")]
	public bool Equals(KCNFFJOGDNE AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB0420", Offset = "0x6CAEE20", VA = "0x186CB0420", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CBHFJOBOEMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APCDMONNIEG(DLDFPOMGDOP MGPJOGDJPHA, NIDBICOIDOK GHFGJIAINPB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APCDMONNIEG(DDLNHDPCINE OEHDLGBIBKH, NIDBICOIDOK GHFGJIAINPB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFGECPMCBKA(DDLNHDPCINE OEHDLGBIBKH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DKBJPAMDMEH(DDLNHDPCINE OEHDLGBIBKH);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPINOOIIEAO();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABIOBAGCCBM(NIDBICOIDOK NNCMOPPBEEE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NOLFGMDILJJ(DLDFPOMGDOP MGPJOGDJPHA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NOLFGMDILJJ(DDLNHDPCINE OEHDLGBIBKH);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CAPNFJHFCNK(DDLNHDPCINE OEHDLGBIBKH);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MOMPADJAPCB(DDLNHDPCINE OEHDLGBIBKH);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JDCIPJBDIDD();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DDBCGDPAIFI();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LEGBJMHCLNB(DLDFPOMGDOP MGPJOGDJPHA, MKHKMPLGLOM NNCMOPPBEEE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ODNIHGEGGPA(DDLNHDPCINE OEHDLGBIBKH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LHPKJFBAJIC(DDLNHDPCINE OEHDLGBIBKH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AHBMKMDAMAP();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LMPLGLIBDIO(MKHKMPLGLOM NNCMOPPBEEE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AIOGMFDAHOH(DLDFPOMGDOP MGPJOGDJPHA, Vector3 DOAODIEEIGN, Vector3 HNIIDGAFLFD, Vector3 CFCCIEPFNEJ, float HFDFAGCHKHB, float IEGJNCIIPAH, IReadOnlyList<Camera> HKDKAPGAJPO, HIKLJPELLBA KPLKEEMGIKF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AIOGMFDAHOH(KCNFFJOGDNE CKKGBLDOPHM, Vector3 DOAODIEEIGN, Vector3 HNIIDGAFLFD, Vector3 CFCCIEPFNEJ, float HFDFAGCHKHB, float IEGJNCIIPAH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ONKLLCFHLEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PEEGDHAFIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DLDFPOMGDOP EJBNCBJEKIC(ONKGMCFPKGJ OIGMDCDEKEG);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DLDFPOMGDOP EJBNCBJEKIC(ONKGMCFPKGJ OIGMDCDEKEG, bool BKICCMMDLMG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOECMCBAIKJ(DLDFPOMGDOP MGPJOGDJPHA);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKHLCINMMEI(DLDFPOMGDOP MGPJOGDJPHA);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DDLNHDPCINE HOKIINLNBLJ(DLDFPOMGDOP MGPJOGDJPHA, HKOHCMODGAK OIGMDCDEKEG);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DDLNHDPCINE DMPLALIKEPJ(DLDFPOMGDOP MGPJOGDJPHA, AFMNBNBECDC OIGMDCDEKEG);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IADOHFMCKKH(DDLNHDPCINE OEHDLGBIBKH);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PNBCPAFHCGG(DDLNHDPCINE OEHDLGBIBKH);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KCNFFJOGDNE JHPEKKEFFMA(CCBKJCBBPEG OIGMDCDEKEG);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PCJLFKDPNDF(KCNFFJOGDNE CKKGBLDOPHM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JCFHHDLOHHE(KCNFFJOGDNE CKKGBLDOPHM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task ENDLDHILDHH();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task ILPPECDGBLA();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task ALMGDFIKPHB();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AICEPEEFDAB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> ILNFFMMKKPE(DLDFPOMGDOP MGPJOGDJPHA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OCKJGOBGGCG
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum MGNNLCEOJJO
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		PercentOfMax,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		PercentByDistance,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		ScreenPixels
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum NDJFHAPBNMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum IAFIADMEDMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum DNIIJJEHOGA
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum JBEMPHGFABA
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum JAEEPKHJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Quest3,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		MemoryBuild,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static int HCFBJGBHBLP;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static int EMDNMNOHIKI;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static int MOCPHPAAHGG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static int PEBDIODHDLF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static int[] OOBAFLHNNFM;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static int CCFODKEEIOD;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static int ELKFKFOIDKO;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static int GLMOOMDOMNH;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static int GDGDHLBBGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long JGGHDBJOFOM;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long OBDLBAAJLFB;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static long IKDPMDLPPPE;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static long PLJAMIBAMDC;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static long BFNEJCINLEF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long DDMLBMPCHPC;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long CCKGFJPCMMP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static long MPMBNIOEPNN;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long KHGGLMGELBO;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static long JPEJPEIFKFP;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static long FFODCDMMPHI;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static long GEIAKHPKLAB;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static long GOFOOLEPBBH;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static long ONOBFFMBPEM;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static float DAELFPDKMJN;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long GBFHNMPCLHA;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static long OEJIHBBAKIK;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static long JOGMHKDMLEI;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static long PGEMLOGACHN;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float IPIFNHABAAH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static long NPNOBLJGNFG;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static long LCHBOGAGCOC;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static long OEFCMECEJKF;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long DKKLIMCLEPF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long LJEFIDKIJBB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool BEMNGBMMCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6CB49A0", Offset = "0x6CB33A0", VA = "0x186CB49A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6CB49F0", Offset = "0x6CB33F0", VA = "0x186CB49F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static JAEEPKHJGCA APFJNDLAAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6CB55E0", Offset = "0x6CB3FE0", VA = "0x186CB55E0")]
		[CompilerGenerated]
		get
		{
			return default(JAEEPKHJGCA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6CB56D0", Offset = "0x6CB40D0", VA = "0x186CB56D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool OKHFOJEBCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6CB40F0", Offset = "0x6CB2AF0", VA = "0x186CB40F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4CF0", Offset = "0x6CB36F0", VA = "0x186CB4CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool BCJDKODDNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4790", Offset = "0x6CB3190", VA = "0x186CB4790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5450", Offset = "0x6CB3E50", VA = "0x186CB5450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static MGNNLCEOJJO LJIGIMNLJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB39D0", Offset = "0x6CB23D0", VA = "0x186CB39D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool JLFFLPNKJML
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4F30", Offset = "0x6CB3930", VA = "0x186CB4F30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5290", Offset = "0x6CB3C90", VA = "0x186CB5290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static NDJFHAPBNMO HOMJDEPBKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3980", Offset = "0x6CB2380", VA = "0x186CB3980")]
		[CompilerGenerated]
		get
		{
			return default(NDJFHAPBNMO);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5080", Offset = "0x6CB3A80", VA = "0x186CB5080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool DKCJOCMEDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4FD0", Offset = "0x6CB39D0", VA = "0x186CB4FD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6CB48E0", Offset = "0x6CB32E0", VA = "0x186CB48E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool HEJNLLOEMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3A20", Offset = "0x6CB2420", VA = "0x186CB3A20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5120", Offset = "0x6CB3B20", VA = "0x186CB5120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool LJGAPCBLONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4E40", Offset = "0x6CB3840", VA = "0x186CB4E40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3920", Offset = "0x6CB2320", VA = "0x186CB3920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static float MGMKABDABOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4190", Offset = "0x6CB2B90", VA = "0x186CB4190")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6CB42E0", Offset = "0x6CB2CE0", VA = "0x186CB42E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int LKNIHONAGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4340", Offset = "0x6CB2D40", VA = "0x186CB4340")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5A50", Offset = "0x6CB4450", VA = "0x186CB5A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int BBEPOKEALPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB40A0", Offset = "0x6CB2AA0", VA = "0x186CB40A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB38D0", Offset = "0x6CB22D0", VA = "0x186CB38D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int DPKLIPEAIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3FB0", Offset = "0x6CB29B0", VA = "0x186CB3FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5850", Offset = "0x6CB4250", VA = "0x186CB5850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int FDDFOKOAMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3A70", Offset = "0x6CB2470", VA = "0x186CB3A70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB50D0", Offset = "0x6CB3AD0", VA = "0x186CB50D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int LHCKPBMKEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4EE0", Offset = "0x6CB38E0", VA = "0x186CB4EE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4A90", Offset = "0x6CB3490", VA = "0x186CB4A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int PDCBAEDAPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5680", Offset = "0x6CB4080", VA = "0x186CB5680")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6CB43F0", Offset = "0x6CB2DF0", VA = "0x186CB43F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static float GNEAGHOADFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4B90", Offset = "0x6CB3590", VA = "0x186CB4B90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4390", Offset = "0x6CB2D90", VA = "0x186CB4390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int OIOKHCFBONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4000", Offset = "0x6CB2A00", VA = "0x186CB4000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6CB45A0", Offset = "0x6CB2FA0", VA = "0x186CB45A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int KJAIPINJDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3830", Offset = "0x6CB2230", VA = "0x186CB3830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6CB59A0", Offset = "0x6CB43A0", VA = "0x186CB59A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int JDHOBGIFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4E90", Offset = "0x6CB3890", VA = "0x186CB4E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB51E0", Offset = "0x6CB3BE0", VA = "0x186CB51E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static float GLDFAHHCMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB71A0", Offset = "0x6CB5BA0", VA = "0x186CB71A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3F50", Offset = "0x6CB2950", VA = "0x186CB3F50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float GDKGNBHDABD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4650", Offset = "0x6CB3050", VA = "0x186CB4650")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5180", Offset = "0x6CB3B80", VA = "0x186CB5180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float EJPMMKFNIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4DF0", Offset = "0x6CB37F0", VA = "0x186CB4DF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4280", Offset = "0x6CB2C80", VA = "0x186CB4280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool DGIGOBOAJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4A40", Offset = "0x6CB3440", VA = "0x186CB4A40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5790", Offset = "0x6CB4190", VA = "0x186CB5790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static int ACEPPACHADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3EA0", Offset = "0x6CB28A0", VA = "0x186CB3EA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7100", Offset = "0x6CB5B00", VA = "0x186CB7100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static int KPLJMIFFKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3E00", Offset = "0x6CB2800", VA = "0x186CB3E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4230", Offset = "0x6CB2C30", VA = "0x186CB4230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static int MACPBAMLPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3E50", Offset = "0x6CB2850", VA = "0x186CB3E50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3B70", Offset = "0x6CB2570", VA = "0x186CB3B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int LGDAHBPLDJA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3780", Offset = "0x6CB2180", VA = "0x186CB3780")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4DA0", Offset = "0x6CB37A0", VA = "0x186CB4DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static bool CGHAJCHOGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4B40", Offset = "0x6CB3540", VA = "0x186CB4B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4880", Offset = "0x6CB3280", VA = "0x186CB4880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static bool DIKGBJGLCNK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4140", Offset = "0x6CB2B40", VA = "0x186CB4140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB71F0", Offset = "0x6CB5BF0", VA = "0x186CB71F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float PCFMDMMKLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4D50", Offset = "0x6CB3750", VA = "0x186CB4D50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6CB45F0", Offset = "0x6CB2FF0", VA = "0x186CB45F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static IAFIADMEDMP GGCCMCEBOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4440", Offset = "0x6CB2E40", VA = "0x186CB4440")]
		[CompilerGenerated]
		get
		{
			return default(IAFIADMEDMP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5950", Offset = "0x6CB4350", VA = "0x186CB5950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static DNIIJJEHOGA PCEMHBILOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4490", Offset = "0x6CB2E90", VA = "0x186CB4490")]
		[CompilerGenerated]
		get
		{
			return default(DNIIJJEHOGA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6CB70B0", Offset = "0x6CB5AB0", VA = "0x186CB70B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool AIGAOOFEBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6CB52F0", Offset = "0x6CB3CF0", VA = "0x186CB52F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4540", Offset = "0x6CB2F40", VA = "0x186CB4540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float GKAKOMAOLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6CB58A0", Offset = "0x6CB42A0", VA = "0x186CB58A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6CB37D0", Offset = "0x6CB21D0", VA = "0x186CB37D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float BNHGDDGBFJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4830", Offset = "0x6CB3230", VA = "0x186CB4830")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4C90", Offset = "0x6CB3690", VA = "0x186CB4C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float CCDOHHCFHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB46A0", Offset = "0x6CB30A0", VA = "0x186CB46A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3BC0", Offset = "0x6CB25C0", VA = "0x186CB3BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float ODOPBDCCKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3880", Offset = "0x6CB2280", VA = "0x186CB3880")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3EF0", Offset = "0x6CB28F0", VA = "0x186CB3EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static float OKPBJNBACAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4F80", Offset = "0x6CB3980", VA = "0x186CB4F80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6CB57F0", Offset = "0x6CB41F0", VA = "0x186CB57F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static float FLFNCGEJGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7150", Offset = "0x6CB5B50", VA = "0x186CB7150")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6CB53A0", Offset = "0x6CB3DA0", VA = "0x186CB53A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool OHEBILNJEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4C40", Offset = "0x6CB3640", VA = "0x186CB4C40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4BE0", Offset = "0x6CB35E0", VA = "0x186CB4BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static float NLEOMGEBJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3B20", Offset = "0x6CB2520", VA = "0x186CB3B20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5230", Offset = "0x6CB3C30", VA = "0x186CB5230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int PDNEGDLBNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3730", Offset = "0x6CB2130", VA = "0x186CB3730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7250", Offset = "0x6CB5C50", VA = "0x186CB7250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static int AJFJNCJEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4740", Offset = "0x6CB3140", VA = "0x186CB4740")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3AC0", Offset = "0x6CB24C0", VA = "0x186CB3AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static bool DODALDGKEDA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3D60", Offset = "0x6CB2760", VA = "0x186CB3D60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static int DOHEDCMMBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5530", Offset = "0x6CB3F30", VA = "0x186CB5530")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3C80", Offset = "0x6CB2680", VA = "0x186CB3C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static int GGJDOCKGAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5580", Offset = "0x6CB3F80", VA = "0x186CB5580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool KIABPFHBCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3DB0", Offset = "0x6CB27B0", VA = "0x186CB3DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5020", Offset = "0x6CB3A20", VA = "0x186CB5020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float BENMLAJFAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5400", Offset = "0x6CB3E00", VA = "0x186CB5400")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6CB44E0", Offset = "0x6CB2EE0", VA = "0x186CB44E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float GGJGMNLFKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6CB47E0", Offset = "0x6CB31E0", VA = "0x186CB47E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5340", Offset = "0x6CB3D40", VA = "0x186CB5340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float OKDDIEOFMCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4050", Offset = "0x6CB2A50", VA = "0x186CB4050")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4AE0", Offset = "0x6CB34E0", VA = "0x186CB4AE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static int EJPHHFNMMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6CB46F0", Offset = "0x6CB30F0", VA = "0x186CB46F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6CB59F0", Offset = "0x6CB43F0", VA = "0x186CB59F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static float4x4 DCJAJIGHJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6CB54B0", Offset = "0x6CB3EB0", VA = "0x186CB54B0")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3CE0", Offset = "0x6CB26E0", VA = "0x186CB3CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float3 EICDLDPJIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5720", Offset = "0x6CB4120", VA = "0x186CB5720")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6CB58F0", Offset = "0x6CB42F0", VA = "0x186CB58F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static bool MIAPJCICKEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5630", Offset = "0x6CB4030", VA = "0x186CB5630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3C20", Offset = "0x6CB2620", VA = "0x186CB3C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static JBEMPHGFABA CAKFKAMAAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6CB41E0", Offset = "0x6CB2BE0", VA = "0x186CB41E0")]
		[CompilerGenerated]
		get
		{
			return default(JBEMPHGFABA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4940", Offset = "0x6CB3340", VA = "0x186CB4940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5AA0", Offset = "0x6CB44A0", VA = "0x186CB5AA0")]
	public static void PDKEALEBMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6830", Offset = "0x6CB5230", VA = "0x186CB6830")]
	public static void PDLEKHALCJM(JAEEPKHJGCA NDFOILKALHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NPNGLGJOPBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct NKJJJKLHCHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Vector3 FDBNADNMDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Quaternion MHMMIDFOFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float IJFGAPPPCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public Quaternion JFMMDFNJAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public float ABIMEIJMCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public float LEEEIBKANEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float BLGIHIEDPCA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static List<NKJJJKLHCHH> BLLABJNLPFE;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB0A10", Offset = "0x6CAF410", VA = "0x186CB0A10")]
	public static NativeList<JMCOJBGJDJJ> JPNCEGGKFPJ(HEOFEOJFEHK NKKPFKFLMOH)
	{
		return default(NativeList<JMCOJBGJDJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB0FA0", Offset = "0x6CAF9A0", VA = "0x186CB0FA0")]
	private static bool MMBKBDBKLAL(int PPNCECJAFNC, NativeList<JMCOJBGJDJJ> DFEFBOIIPKP, List<NKJJJKLHCHH> BOKMODFGJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3510", Offset = "0x6CB1F10", VA = "0x186CB3510")]
	private static JMCOJBGJDJJ PODICAFIJGN(int PEMICEPHOKB, List<NKJJJKLHCHH> BOKMODFGJLK)
	{
		return default(JMCOJBGJDJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6CB0500", Offset = "0x6CAEF00", VA = "0x186CB0500")]
	private static JMCOJBGJDJJ CJAKKDDEGMC(int PEMICEPHOKB, List<NKJJJKLHCHH> BOKMODFGJLK)
	{
		return default(JMCOJBGJDJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1F70", Offset = "0x6CB0970", VA = "0x186CB1F70")]
	private static JMCOJBGJDJJ OJCJLKDGILL(Vector3 OADBGCPFPOE, Quaternion CJJEGFAGPAN, float MNBMJJFKKCE)
	{
		return default(JMCOJBGJDJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2050", Offset = "0x6CB0A50", VA = "0x186CB2050")]
	public static NativeList<JMCOJBGJDJJ> PIKBCFEKCME(HEOFEOJFEHK NKKPFKFLMOH, float NLHKDKLOILJ)
	{
		return default(NativeList<JMCOJBGJDJJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FOKMBBDOIKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static Vector3 IOBDFFMLMFI;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static Vector3 IMILONLPANM;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public static readonly float IILEJEEKDNF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6CAFD10", Offset = "0x6CAE710", VA = "0x186CAFD10")]
	public static Vector3 MHOHELINNMJ(Vector3 NEIPMHLPFII, Quaternion CJJEGFAGPAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF910", Offset = "0x6CAE310", VA = "0x186CAF910")]
	public static Vector3 GKMCOABNGBH(Quaternion FJFNLINEAKI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF870", Offset = "0x6CAE270", VA = "0x186CAF870")]
	public static Vector3 DBNMPMHJKNO(Quaternion FJFNLINEAKI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF3C0", Offset = "0x6CADDC0", VA = "0x186CAF3C0")]
	public static Quaternion CFEPKINANHJ(Vector3 IMGPFEFAFKM, Vector3 BELBOBCMBGH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF9B0", Offset = "0x6CAE3B0", VA = "0x186CAF9B0")]
	public static Vector3 ILNCBPIKOJI(Vector3 DLONKMKBECP, Vector3 GGFEDFNDMHB, Vector3 BELBOBCMBGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF440", Offset = "0x6CADE40", VA = "0x186CAF440")]
	public static Vector3 CNJEPLMMBBJ(Vector3 NEIPMHLPFII, Vector3 BELBOBCMBGH, Quaternion FJFNLINEAKI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6CAFF90", Offset = "0x6CAE990", VA = "0x186CAFF90")]
	public static Quaternion OKDLBJLALMJ(Quaternion CJJEGFAGPAN, Vector3 IMGPFEFAFKM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6CAFBA0", Offset = "0x6CAE5A0", VA = "0x186CAFBA0")]
	public static bool MBOCNLHNPAP(Vector3 MLAGMGOCGAB, Vector3 LBDJMGGIKNF, [Out] Vector3 PMGHDGKDGKL, bool PELKLDFIHFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF0D0", Offset = "0x6CADAD0", VA = "0x186CAF0D0")]
	public static Vector3 BMLALBNMIEE(bool JNCCGIIAAPK, [Optional] Quaternion KLNDFICKLJF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JMCOJBGJDJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public float3 FDBNADNMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public float3x3 MHMMIDFOFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public float IJFGAPPPCPB;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HEOFEOJFEHK
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int MKNMANDONFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 MABECBCBCHB(int PEMICEPHOKB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion OFPIFPOJAEO(int PEMICEPHOKB);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float CKCJAKJLIDN(int PEMICEPHOKB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AFMNBNBECDC : CEPJBCIFANF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool OFKIJPPIHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool BPEDFPOLHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	float BAHFOLKKJBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int NEDBOLLIONO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool MLCLNAHBKOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int IMPNHIDEPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<JMCOJBGJDJJ> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface HKOHCMODGAK : CEPJBCIFANF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	DLBBPBLJBPM LHHCODBJGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool NJPNGNEOBND
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float3 NCBLGONCDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface ONKGMCFPKGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	HPFOPEMMFAI DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	KEMEMJMNCHE OGICHMFOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CEPJBCIFANF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool HLGNNJJFIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool OAIOBNPBEIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	HPFOPEMMFAI DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	UniformTRS FKPNNEPABND
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float EAPAIDANJME
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 GPOFBGPLJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	KKGOBCNALDK JGCOJDDBJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	DCLHCFNCEDH GFKOPBDGAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CCBKJCBBPEG
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int NBLLBLOHMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Transform IACLLGCBDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool BDJIGKKBMAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DLDFPOMGDOP GetBone(int PEMICEPHOKB);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int PEMICEPHOKB);
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
