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
public enum BEOAGMLPKLB
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
public enum LIGLMNBGNIO
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
public enum EFDNHOFOELB
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
public enum IMKBGKEKPMO
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
public enum CNMFJGBLGMD
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
public enum EPEJMPHDPHB
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
public static class NJAFJIKLGIO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F7C0", Offset = "0x7E3E9C0", VA = "0x187E3F7C0")]
	public static bool HNMJHJGHCIE(this EPEJMPHDPHB FJMFFNHCKNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F7B0", Offset = "0x7E3E9B0", VA = "0x187E3F7B0")]
	public static bool HCCIKFOFDDA(this EPEJMPHDPHB FJMFFNHCKNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F780", Offset = "0x7E3E980", VA = "0x187E3F780")]
	public static bool AJKBMCCBNCN(this EPEJMPHDPHB FJMFFNHCKNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KBHAGNPMANG
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
public struct HEJBBJOONEM : AKEBFDHKPEH, IEquatable<HEJBBJOONEM>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int PMLOAHGMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D960", Offset = "0x2E1CB60", VA = "0x182E1D960", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EB12E0", Offset = "0x6EB04E0", VA = "0x186EB12E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KJALJJOFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D4C0", Offset = "0x7E3C6C0", VA = "0x187E3D4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xEFE3F0", Offset = "0xEFD5F0", VA = "0x180EFE3F0", Slot = "8")]
	public bool Equals(HEJBBJOONEM FNJGMJGALLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3620750", Offset = "0x361F950", VA = "0x183620750")]
	public static bool NDBPPCEOMJH(HEJBBJOONEM FCKEKMKDGOB, HEJBBJOONEM PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D500", Offset = "0x7E3C700", VA = "0x187E3D500", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D590", Offset = "0x7E3C790", VA = "0x187E3D590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FJJNPNKHKFF : AKEBFDHKPEH, IEquatable<FJJNPNKHKFF>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int PMLOAHGMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D960", Offset = "0x2E1CB60", VA = "0x182E1D960", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EB12E0", Offset = "0x6EB04E0", VA = "0x186EB12E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KJALJJOFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C060", Offset = "0x7E3B260", VA = "0x187E3C060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xEFE3F0", Offset = "0xEFD5F0", VA = "0x180EFE3F0", Slot = "8")]
	public bool Equals(FJJNPNKHKFF FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C0A0", Offset = "0x7E3B2A0", VA = "0x187E3C0A0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C130", Offset = "0x7E3B330", VA = "0x187E3C130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KDKEMAMEJBC : AKEBFDHKPEH, IEquatable<KDKEMAMEJBC>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PMLOAHGMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D960", Offset = "0x2E1CB60", VA = "0x182E1D960", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EB12E0", Offset = "0x6EB04E0", VA = "0x186EB12E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KJALJJOFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F6B0", Offset = "0x7E3E8B0", VA = "0x187E3F6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xEFE3F0", Offset = "0xEFD5F0", VA = "0x180EFE3F0", Slot = "8")]
	public bool Equals(KDKEMAMEJBC FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F6F0", Offset = "0x7E3E8F0", VA = "0x187E3F6F0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DNOHAGJNPAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGGKPPOAIIA(HEJBBJOONEM FHPKLENNKKO, LIGLMNBGNIO CFHFANILNME);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGGKPPOAIIA(FJJNPNKHKFF FDPAKEMBDAE, LIGLMNBGNIO CFHFANILNME);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKCGJIGCBCP(FJJNPNKHKFF FDPAKEMBDAE);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBBKHAIBLJG(FJJNPNKHKFF FDPAKEMBDAE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FANPIFGLGIF();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IDHOMLEGDNN(LIGLMNBGNIO EDLOHJEBKFM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OIEIEGNGELK(HEJBBJOONEM FHPKLENNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OIEIEGNGELK(FJJNPNKHKFF FDPAKEMBDAE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JFNBAHJAFOE(FJJNPNKHKFF FDPAKEMBDAE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JHKDKNGOOKC(FJJNPNKHKFF FDPAKEMBDAE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GMOOICOHCKG();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OIBJGEPCKIA();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LKCFAPBLOOC(HEJBBJOONEM FHPKLENNKKO, CNMFJGBLGMD EDLOHJEBKFM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AFNEIDJJBDC(FJJNPNKHKFF FDPAKEMBDAE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GJGINEAHPPH(FJJNPNKHKFF FDPAKEMBDAE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NKMGLFJPNCA();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EBJLNHIMPOL(CNMFJGBLGMD EDLOHJEBKFM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LFBIPIIFHOG(HEJBBJOONEM FHPKLENNKKO, Vector3 IHNPJFNBJBE, Vector3 IIOLMPCPGEC, Vector3 FCHLBEBMFED, float NKAKEPANHCF, float KACFJENLELK, IReadOnlyList<Camera> KINFPMNFAFA, BEOAGMLPKLB FGFHIDECMGG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LFBIPIIFHOG(KDKEMAMEJBC NPAJCEMAICN, Vector3 IHNPJFNBJBE, Vector3 IIOLMPCPGEC, Vector3 FCHLBEBMFED, float NKAKEPANHCF, float KACFJENLELK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PFOKOKEKMHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MBBFPKAOJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HEJBBJOONEM FOAPKDBABBO(NPAJLANHHDD DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HEJBBJOONEM FOAPKDBABBO(NPAJLANHHDD DHAOEHNLNON, bool PHCDLLOIANI);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDIEJLHOCJC(HEJBBJOONEM FHPKLENNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCOMMAACKCB(HEJBBJOONEM FHPKLENNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FJJNPNKHKFF JKNBBMHJGMB(HEJBBJOONEM FHPKLENNKKO, CJMNDOAJBNF DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FJJNPNKHKFF NGKNGGAIEJO(HEJBBJOONEM FHPKLENNKKO, CNEDPOGNDBG DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOOJOALDKIC(FJJNPNKHKFF FDPAKEMBDAE);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LEDNCMJPDAF(FJJNPNKHKFF FDPAKEMBDAE);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KDKEMAMEJBC LHFPEEJOJEA(DKDDHCECMFH DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PNLNEIDOFFC(KDKEMAMEJBC NPAJCEMAICN);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GDIKKHACIEJ(KDKEMAMEJBC NPAJCEMAICN);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task PMMBLIBENFG();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task OGBGMODGACC();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task PGJKOFJNLLN();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NKBKCEOGLFH();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> FFBJLGFKPOE(HEJBBJOONEM FHPKLENNKKO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IOBCCJFAAHB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum AHKIADEGNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum EICGIHKJKOC
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum JCAPIPDHKMI
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
	public enum AKGDKFNJBAL
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
	public enum BGJILKNBFCB
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
	public enum PNKCGHDLCHD
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
	public enum NENLOFDAMKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum CBCIAHJPJEA
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
	public static bool BIEKMPAJINF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long GBJPMNNNGFF;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool GKLEFEIMLFP;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool MPJMFPBMNLJ;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool BJKGGIPJMPF;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float NHGDAJFCNCH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float LDLOOLOPLNP;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int CLEPDDKDHMJ;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static PNKCGHDLCHD HGFELPMNKHC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long FPNPOKBHFNH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float HJJJJLGJMKG;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int PNLDFGMIKOH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int PCCFEFOJCOO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int NNHKIMMAGMP;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int HIJDLGBGADE;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int DIKICHCACAG;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int DCFPKIEMLPC;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int FIICPFFAAPM;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int MEFNLMEGHFG;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool AIODIIJDPAL;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int PGBNPDBIDLD;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int NIFBCPMJANO;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int OPBKGJIFEEP;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool JHFMIEBLKCP;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float EBMEJGIADHH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool NKGPHBEMIFD;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float HLBMOOJANAE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long FCIFFFDOGEB;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool LJMAPFFHGEE;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long JAJEBNNHALK;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int AACMAGIDLOO;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool FMOCMBMIOEA;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static AHKIADEGNFJ AMPNOOIDLIB;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool CFKNAABBCEG;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool HJBDMGCMILN;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int HFOJGONBMFG;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int NFAMIBABJAL;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int AOCGDBIHOFK;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int NEEHGEGAKOC;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int EGBNHCICFFN;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int NBFMOAICPBH;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int CHDLEIEMNOD;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int HJIAPMHEHIK;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float LKOAJBOGFDP;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float HDIPONIFEII;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float KGNLHJNEGOP;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float IKJNDPIIIAI;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int GBHFNAGHAKM;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int KEBFAEOLNIJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int JOMOKNAIGBE;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int KILNBNMDCCC;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool IEFLGMOCOAO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static JCAPIPDHKMI CIFHBGIKBGJ;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static AKGDKFNJBAL PKGJCIGGDCG;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool BCBFEONFALE;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static EICGIHKJKOC CGHJBDOOFNC;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float ABCHMJLKEGG;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float JFDIFGNMAMA;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float DNFLDNMCIIM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float EKMDCKENLGN;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float GPHHJEBEGIF;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float NNKAKFPLDND;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float FDNHEFHGBEO;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float CNCONCBOFLE;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool FECNKIEAPEI;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static NENLOFDAMKH GIHEDEKHJIE;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool HEBACOCKDHK;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float HMMLLPEHLGC;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float FBOHAJPFNJF;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float AKIJPHLHOJO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float KAKLPNKFEBI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float CGAFBNOPNGO;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool COOAIKCLNMA;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long CDMINEJAHLN;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float DMMBPDCKFNP;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float MIBBGGJBPGN;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float KDAIOBCNGGK;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int KGGNGKDACBP;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float EDCGEDPIOGP;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool GOBNEIMDNDB;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long CJKOGLHHOAH;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int IAMFAIJJAEB;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int LDBHNFNHMKN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float GALLGIOONJO;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float OCIMEGJLJAO;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool OPAHJIKMCEM;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool ABFLCNAKKKC;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float LCMHPFOPBIP;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long GEJFPBFJKIF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long KCKDJPHGEAP;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int EALKGOLIHBG;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 MHCNPOIPAOB;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 FHEDAGJPNKM;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool LCKNNCHNGPO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static BGJILKNBFCB IOKHCACHKBE;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long GICKIPJGEDB;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int GLMAJFEKFPE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int OEJIHBDNDMD;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int OKHECNCMMML;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int KMBKDIBBIFO;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int KFAEFLIMFBP;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long ONAAMAONGDM;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int OPEGDIKNPCD;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int AJLAAOHMEOA;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int EPKLBPFFMJB;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long IDJMDFAEDKJ;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long ABJBMIOEEMK;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long BLFPGOCNCFP;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long LJLLDELIFFP;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int EGBBHHOKJPC;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int NAHCDDKKECO;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int PBMHHIFIKLB;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int GACKNFKOHDI;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] EPLNLOCEHNN;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int OOCIPEPCPLC;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long CCACPHNFNGN;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long NOOAGDOHIHF;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int CLADOBMMFNH;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int PKAFLABNALF;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long FAOPLONMAKC;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long FKBOJBFJNCJ;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long DDGPJJFFAMJ;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long DEAANGIMHEO;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long LCIAOGPLMJH;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long HBMPLIDJEPB;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long IPKBNMGCEAG;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long AOFFMIMAMOJ;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long BABKPAEGMMN;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float NCGKPEPKFOI;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float MLPEPMOOBNK;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long HIPHIFIDPCO;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int BNBDNDMBCFF;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long BPIHPJJDLJG;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long GMAPJLHKCDH;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float LGINAHPLMKC;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long HLKJHGKINKO;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long CKLKFKPFPMA;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long KHJDMBHPOIN;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long AAANOPNIMKF;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long OLIIOLKJAJO;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long CMGLCPIDMKE;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long FNBMBCHFLDG;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long NDOOMOFGHCG;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long LFCIOKGPHFP;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long HONGLEFLJHK;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long NBLPABFAPHM;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long IJNIJCGANGI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static CBCIAHJPJEA MPDPJNHDANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D620", Offset = "0x7E3C820", VA = "0x187E3D620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long PJKOPCKKEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7E3DC40", Offset = "0x7E3CE40", VA = "0x187E3DC40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D670", Offset = "0x7E3C870", VA = "0x187E3D670")]
	public static void CBPEFFFELJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DCA0", Offset = "0x7E3CEA0", VA = "0x187E3DCA0")]
	public static void PCEAPEJBEKM(CBCIAHJPJEA GAIDEHPHNDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class CKNNBOFLNGI
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct LGGJJBLGBMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 PHGICKGLDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Quaternion JPIDPNKLHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float AMBCENEAEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Quaternion CFMIPMNBFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float AKBMAMANAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float IHKBDKOFBPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public float OFMCEFNMOEC;
	}

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static List<LGGJJBLGBMB> LLEONBBODPO;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E39130", Offset = "0x7E38330", VA = "0x187E39130")]
	public static NativeList<NOFEPGIGNGP> CALJJLAAJCB(DEAIOHIJNMA HDDBABKJHIG)
	{
		return default(NativeList<NOFEPGIGNGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E3B140", Offset = "0x7E3A340", VA = "0x187E3B140")]
	private static bool OLMHDODHCKL(int EOIAPGKFGAB, NativeList<NOFEPGIGNGP> IGGKBIDIAJL, List<LGGJJBLGBMB> HEDDMJOGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E38FB0", Offset = "0x7E381B0", VA = "0x187E38FB0")]
	private static NOFEPGIGNGP AGJMLFLICFA(int DLMCFJOIHHD, List<LGGJJBLGBMB> HEDDMJOGMMB)
	{
		return default(NOFEPGIGNGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3AC50", Offset = "0x7E39E50", VA = "0x187E3AC50")]
	private static NOFEPGIGNGP MPPEFBOMEFB(int DLMCFJOIHHD, List<LGGJJBLGBMB> HEDDMJOGMMB)
	{
		return default(NOFEPGIGNGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E396D0", Offset = "0x7E388D0", VA = "0x187E396D0")]
	private static NOFEPGIGNGP DPBJOJKLKOA(Vector3 IOHMIDHCEGD, Quaternion GKAAOLAMBLP, float IHBIKJPLAHJ)
	{
		return default(NOFEPGIGNGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E397B0", Offset = "0x7E389B0", VA = "0x187E397B0")]
	public static NativeList<NOFEPGIGNGP> GFFDFJDFCCN(DEAIOHIJNMA HDDBABKJHIG, float AGEFCABHDDA)
	{
		return default(NativeList<NOFEPGIGNGP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FNEGHDFKEOK
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 KGCCHKCOKGL;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static Vector3 FLFDCAMKBJA;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly float OIFDPMKGLEN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C7C0", Offset = "0x7E3B9C0", VA = "0x187E3C7C0")]
	public static Vector3 HNFPJEONNOK(Vector3 ENHLLEFMPIN, Quaternion GKAAOLAMBLP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C720", Offset = "0x7E3B920", VA = "0x187E3C720")]
	public static Vector3 GOIBOKJDCDE(Quaternion PANMBKPFLFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D350", Offset = "0x7E3C550", VA = "0x187E3D350")]
	public static Vector3 OJFKFIJHDDI(Quaternion PANMBKPFLFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C6A0", Offset = "0x7E3B8A0", VA = "0x187E3C6A0")]
	public static Quaternion FBDNKGDPFCO(Vector3 ACBMNMFGAEN, Vector3 PLEIILPBIGD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C4B0", Offset = "0x7E3B6B0", VA = "0x187E3C4B0")]
	public static Vector3 BNGOOEINDBK(Vector3 EIBMCAHEFNB, Vector3 ICAJOHNAIOA, Vector3 PLEIILPBIGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E3CA40", Offset = "0x7E3BC40", VA = "0x187E3CA40")]
	public static Vector3 IEPIPJIJPNJ(Vector3 ENHLLEFMPIN, Vector3 PLEIILPBIGD, Quaternion PANMBKPFLFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7E3CE70", Offset = "0x7E3C070", VA = "0x187E3CE70")]
	public static Quaternion LGCJODMAJBH(Quaternion GKAAOLAMBLP, Vector3 ACBMNMFGAEN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D1D0", Offset = "0x7E3C3D0", VA = "0x187E3D1D0")]
	public static bool LIMKEABHOBN(Vector3 DGCFNHKBCJE, Vector3 CEFEHCEINKA, [Out] Vector3 AHKONODNLEG, bool GEOFPFCFJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C1C0", Offset = "0x7E3B3C0", VA = "0x187E3C1C0")]
	public static Vector3 APCHPMIAABL(bool HJMLOPMOKDK, [Optional] Quaternion HPNKCJIILEE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NOFEPGIGNGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3 PHGICKGLDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float3x3 JPIDPNKLHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float AMBCENEAEIN;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DEAIOHIJNMA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int HGNCNJONNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 GHKBGHFPEIN(int DLMCFJOIHHD);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion FIMMLHFJMFJ(int DLMCFJOIHHD);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float CKINAFAFHGE(int DLMCFJOIHHD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CNEDPOGNDBG : JHGPEPAFDAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool AKOHBLFNOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KGAMKAHFDDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float MCGNGODPHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int NGNCNBKFGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool PNMFKGACHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int PGPNCFPPDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<NOFEPGIGNGP> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CJMNDOAJBNF : JHGPEPAFDAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EFDNHOFOELB GODHNAIMKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KNCGLOHGPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 BCBEMHEKLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NPAJLANHHDD
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AOECEAGCFFM NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	IMKBGKEKPMO JKHPJJCGIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JHGPEPAFDAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KJLNOHDCHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MOHDLOCPJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AOECEAGCFFM NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS JDNCPBDBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float BFACDLAHFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 DEJMIACCAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	EPEJMPHDPHB ALDNIBLHJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	KBHAGNPMANG PFKPMMLAFGP
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
public interface DKDDHCECMFH
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int IAJNGNBOMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform FELOBJBKBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool KAKOFGDDDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HEJBBJOONEM GetBone(int DLMCFJOIHHD);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int DLMCFJOIHHD);
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
