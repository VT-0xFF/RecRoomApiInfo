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
public enum KIEKGGPMJIE
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
public enum MNEOPFCLMIK
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
public enum JBBAGKFDBNF
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
public enum MFLNAOCPGAE
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
public enum BBFHFFOIEKE
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
public enum FLGDJDIBGKI
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
public static class HFPCDAKMMLG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F59B20", Offset = "0x7F58920", VA = "0x187F59B20")]
	public static bool HNOGMPGPNNP(this FLGDJDIBGKI CKEOIJBAIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F59B10", Offset = "0x7F58910", VA = "0x187F59B10")]
	public static bool GBJDJPJNADF(this FLGDJDIBGKI CKEOIJBAIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F59AE0", Offset = "0x7F588E0", VA = "0x187F59AE0")]
	public static bool EMFBMHGKPPP(this FLGDJDIBGKI CKEOIJBAIFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BDLOEKFKAIO
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
public struct BLHOJKOBONC : OBLKINNOMIA, IEquatable<BLHOJKOBONC>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int KBDABDGGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int JCCDJKBJEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6640", Offset = "0x2EB5440", VA = "0x182EB6640", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F2F0", Offset = "0x6F9E0F0", VA = "0x186F9F2F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JOCIPIGBAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F598B0", Offset = "0x7F586B0", VA = "0x187F598B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xF1EF30", Offset = "0xF1DD30", VA = "0x180F1EF30", Slot = "8")]
	public bool Equals(BLHOJKOBONC HBLONCAMFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x38FA8C0", Offset = "0x38F96C0", VA = "0x1838FA8C0")]
	public static bool PBEBFPKJKLO(BLHOJKOBONC CHIPBNNCPBF, BLHOJKOBONC MDEAIGKHMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F59820", Offset = "0x7F58620", VA = "0x187F59820", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F598F0", Offset = "0x7F586F0", VA = "0x187F598F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FANFIOCPJIG : OBLKINNOMIA, IEquatable<FANFIOCPJIG>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int KBDABDGGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int JCCDJKBJEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6640", Offset = "0x2EB5440", VA = "0x182EB6640", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F2F0", Offset = "0x6F9E0F0", VA = "0x186F9F2F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JOCIPIGBAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F59A10", Offset = "0x7F58810", VA = "0x187F59A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xF1EF30", Offset = "0xF1DD30", VA = "0x180F1EF30", Slot = "8")]
	public bool Equals(FANFIOCPJIG HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F59980", Offset = "0x7F58780", VA = "0x187F59980", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F59A50", Offset = "0x7F58850", VA = "0x187F59A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NHKMHBFHALC : OBLKINNOMIA, IEquatable<NHKMHBFHALC>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int KBDABDGGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JCCDJKBJEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6640", Offset = "0x2EB5440", VA = "0x182EB6640", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F2F0", Offset = "0x6F9E0F0", VA = "0x186F9F2F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JOCIPIGBAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D3F0", Offset = "0x7F5C1F0", VA = "0x187F5D3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xF1EF30", Offset = "0xF1DD30", VA = "0x180F1EF30", Slot = "8")]
	public bool Equals(NHKMHBFHALC HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D360", Offset = "0x7F5C160", VA = "0x187F5D360", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GDJLPLLNOFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIFCCANFDME(BLHOJKOBONC IPCOMOHMNHK, MNEOPFCLMIK IBFIHEMIHJO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIFCCANFDME(FANFIOCPJIG HMDNNMIJNJJ, MNEOPFCLMIK IBFIHEMIHJO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIIKFJACJOE(FANFIOCPJIG HMDNNMIJNJJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMHBLAAODJE(FANFIOCPJIG HMDNNMIJNJJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KPIGFAICOFP();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ENINGCEJIDA(MNEOPFCLMIK AAFMBEEMJAC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGNAHCEEKJL(BLHOJKOBONC IPCOMOHMNHK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JGNAHCEEKJL(FANFIOCPJIG HMDNNMIJNJJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OMBLNFFMLEH(FANFIOCPJIG HMDNNMIJNJJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JFPIAMGCFMO(FANFIOCPJIG HMDNNMIJNJJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AONFEHOGFKB();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KCFOJBPIFBL();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FHFHKEDINLC(BLHOJKOBONC IPCOMOHMNHK, BBFHFFOIEKE AAFMBEEMJAC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FEOOJHIAHEN(FANFIOCPJIG HMDNNMIJNJJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ICLLDDEFFGI(FANFIOCPJIG HMDNNMIJNJJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LGAPJMJPFME();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CBONONFPGKI(BBFHFFOIEKE AAFMBEEMJAC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BHHGONCGIBP(BLHOJKOBONC IPCOMOHMNHK, Vector3 EJDCLBEPIIF, Vector3 FPEBAKKCMKF, Vector3 FDFEMBFABEA, float MDBLJGPKLGO, float JDKANEIJCPG, IReadOnlyList<Camera> NFMPFCNFPIM, KIEKGGPMJIE ALNLEONPBLH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BHHGONCGIBP(NHKMHBFHALC DNFLEEIEPFC, Vector3 EJDCLBEPIIF, Vector3 FPEBAKKCMKF, Vector3 FDFEMBFABEA, float MDBLJGPKLGO, float JDKANEIJCPG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NBGHGFAEDDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EPHAMJLKPII
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BLHOJKOBONC MPLMOFIKBNL(HFMBOPLHMPF FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BLHOJKOBONC MPLMOFIKBNL(HFMBOPLHMPF FFEMKICJPKP, bool EDNKHAAOADF);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLCFNNEDOMD(BLHOJKOBONC IPCOMOHMNHK);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCCNNFGLLKJ(BLHOJKOBONC IPCOMOHMNHK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FANFIOCPJIG APBBHGOLELJ(BLHOJKOBONC IPCOMOHMNHK, EPJPNHNLMPC FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FANFIOCPJIG LHNJBODKCCO(BLHOJKOBONC IPCOMOHMNHK, FLPJCOCICAD FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLGLCHMBIHA(FANFIOCPJIG HMDNNMIJNJJ);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DBNFJNBLIOG(FANFIOCPJIG HMDNNMIJNJJ);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NHKMHBFHALC CLGCKKIAJNM(JLNFEINOIPI FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ABPMIKJPJIJ(NHKMHBFHALC DNFLEEIEPFC);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LCMNJFFDKIC(NHKMHBFHALC DNFLEEIEPFC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task FHBGKNKGDLO();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task FFFELJIKHAA();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FBLHIDCDMFD();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IIPICOCAPDM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> AJLHHKJGDHO(BLHOJKOBONC IPCOMOHMNHK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JACOPDBFINC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum NLNOHFKHNON
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum MDIOEHEFNAB
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum EDGMIKNMIEI
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
	public enum AFLBENHIHPB
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
	public enum KLEEJCBFPNK
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
	public enum KLFCHFBEEPG
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
	public enum CCGEMCAHKAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum GOLALHHLFPK
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
	public static bool MNDGGGLHJFI;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long DCMCCEHCBNA;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool OCGIGBELBDE;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool AJMMONLHHBI;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool GMEOFCPLLCB;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float FEACIIJIAKK;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float HHNOHCPMNGH;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int HOHAMJGHNIG;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static KLFCHFBEEPG NGGIGFEOCAG;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long ENIBOLAIAIL;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float FGFBHCLFDDH;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int NPCEPIECPPJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int HNIFJHGLLAE;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int JHNNNOPCBBJ;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int OJMEICEIFOP;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int DHCOGMFNELC;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int CHDKFLAJNGH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int FIDHAOLMOML;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int CJBLEOCAEKN;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool JBMBKPLKCHD;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int PHOBAEHJMHF;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int BIEOOFGEOOI;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int EOEIMGEEMAH;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool MIHOKNHLLOK;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float PNCPKHGAPND;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool KIAPFGBLCHI;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float AKCEEKHLMJM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long HHEJJAFIACH;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool JMECMDMFGON;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long FCIIFBLCGOM;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int ELHAHIGBLEB;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool EDABKKPNKHC;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static NLNOHFKHNON CLIKEBGMIHH;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool KAKPIEIAMFA;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool HFAOFBIKHCK;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int CBFJNGDBPCC;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int JDNIFJCEPLO;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int NBDIBGCGNMJ;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int ONMGAFOJLGN;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int MPCPJKOPPJL;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int ICDMBPLJGPK;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int IKPHEKNANCA;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int JCPDLKNJAKL;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float MCGEGPLDBKF;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float MENBAAEHDED;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float MIEEJCDLEIK;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float NCEIHEMABAN;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int GFMDBGMIBKO;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int MOLIEJHPDMH;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int KONAJNJEJFP;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int BOOHFLBBHDI;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool KNGBEIHLGNC;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static EDGMIKNMIEI PPEDMMELJJG;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static AFLBENHIHPB KCFNGCKIBEP;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool BKPINPENAMH;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static MDIOEHEFNAB HPLIIFGACLJ;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float GOOBCFIMJJK;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float JBCNNNBDINF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float OPMOJJKJNGE;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float HCEDEHHDLID;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float LIHDKIFBKHM;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float JLNPLLLPKNB;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float NNADOBMNPPC;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float FCBJEMLKHIP;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool CKOPAAAHBPC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static CCGEMCAHKAI GIIHFOOCPEB;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool AJBEGDAGPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float EBKLMLIMGNB;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float IBMAIJNGOBA;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float OJBGHJNLAMG;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float KDABKHODAEP;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float OAMNADBLJHI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool GJMBEJEPHNI;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long MECJOIJIIFO;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float HKAJFFPFECG;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float JEENKIOBPGI;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float GHMIKBCDOPN;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int JJCGCIFFGKP;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float POILCMJIEJH;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool FODLKIJBOEF;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long LEDGGNJCLPD;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int NKDGCHMNHHB;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int IIAFGDDJFLM;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float FBIIAIPPMKM;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float BJJCJBJOLIA;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool BFDMIICKJKI;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool LEOLAOIAHMP;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float DHJMOBFGFJB;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long CBFHJAGADMB;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long AEOAMEEGELG;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int HFFDLOCABBK;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 FCCBEFNNKJG;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 OHGGDJCDHFF;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool DDFKHLPLLNF;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static KLEEJCBFPNK PBPGMGPLKDH;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long OHMLCGDKAKK;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int DCFLGCIPJCF;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int BCBDICHBHOM;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int IPCDPFCJKDB;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int CJAGJNNCHBM;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int NHLMNDBDJLB;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long OGGNKCPNPOD;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int BCLLFOJLEKD;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int FPJDIJLFKCL;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int PDLKIJCMPLM;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long JOMLNFPHDEN;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long NFBKEJKJMMA;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long BODHPJMIBJK;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long NGHDIFALDKP;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int NBCLMLEBIEO;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int LGHBJODBDPP;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int GAFAPHDHPCG;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int CINDEHMEKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] ADMCDGEBNEE;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int KDAOELENAHC;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long MLBAEMGJAEB;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long BIFDFPFFELC;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int MKCDOPLOGEH;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int OINOIKDBPIN;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long PBNBMLNMIBM;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long INBCJLNNJGF;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long OPPBOKKKAHA;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long MHEEIBLMJFO;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long OBPHOMCODGN;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long EBKKKBDOBAC;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long LFMPJGAOGBM;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long LKDBHECKIBD;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long FPFCHLCOKIM;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float BJKMPEEELBG;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float KAHJDFFJPKF;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long DAKPDKPLGBA;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int AACLMEBMKII;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long OHBIPBGPHHK;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long KEGODBAIGLD;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float DGMAHADFCCI;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long MGMOMDIKNCN;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long MHEMONNCOHL;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long JGPCAKLHEBH;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long PCGMCBBBPKI;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long IPAJBKMJBGF;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long MIPLMDOKDCK;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long CBOOEFBMKJD;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long GPGFKNNOMIH;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long GEKOIMLAOGE;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long IDBKBBALNPE;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long OANMOMBFEML;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long NBILDAAHPMI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static GOLALHHLFPK CKNNKFLFGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F59B40", Offset = "0x7F58940", VA = "0x187F59B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long DCHEKLLMGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F59BA0", Offset = "0x7F589A0", VA = "0x187F59BA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AD50", Offset = "0x7F59B50", VA = "0x187F5AD50")]
	public static void GJDPALFEFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F59C00", Offset = "0x7F58A00", VA = "0x187F59C00")]
	public static void FKDPKIENKIP(GOLALHHLFPK GGOPMMFDIIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class PCCLPIGLEBI
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct BLJIDPCIFAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 HKMBNCFKKMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Quaternion PHNPMAOBIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float LLINGMLBPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Quaternion GBNAELNBKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float LMLAOEOEACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float FBCBCAMFNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public float MAIIBBOJHCG;
	}

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static List<BLJIDPCIFAH> KBIFDGGNEEI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E2E0", Offset = "0x7F5D0E0", VA = "0x187F5E2E0")]
	public static NativeList<CCHLCODHAON> DNHNJIKJCMN(IEAOPNPEIDM DOKMLDLFBEF)
	{
		return default(NativeList<CCHLCODHAON>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D430", Offset = "0x7F5C230", VA = "0x187F5D430")]
	private static bool BECFAIJGNBD(int CPKBMDHHFLH, NativeList<CCHLCODHAON> BPINCJLADGC, List<BLJIDPCIFAH> FKOKJEMCHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F5FE20", Offset = "0x7F5EC20", VA = "0x187F5FE20")]
	private static CCHLCODHAON KLLDJAHPKBM(int KILCKNBNPEG, List<BLJIDPCIFAH> FKOKJEMCHKJ)
	{
		return default(CCHLCODHAON);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F5FFA0", Offset = "0x7F5EDA0", VA = "0x187F5FFA0")]
	private static CCHLCODHAON LNKJAIANEOG(int KILCKNBNPEG, List<BLJIDPCIFAH> FKOKJEMCHKJ)
	{
		return default(CCHLCODHAON);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F5FD40", Offset = "0x7F5EB40", VA = "0x187F5FD40")]
	private static CCHLCODHAON JCNCNGHJDOF(Vector3 HAMOKFILEGG, Quaternion NHBCDKIJGAO, float MEHMJKKFJEH)
	{
		return default(CCHLCODHAON);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E880", Offset = "0x7F5D680", VA = "0x187F5E880")]
	public static NativeList<CCHLCODHAON> HKPIFEJGIMH(IEAOPNPEIDM DOKMLDLFBEF, float FLFAHPODEKL)
	{
		return default(NativeList<CCHLCODHAON>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NEPBKENEINN
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 CGKHIOGJBBG;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static Vector3 ALKPKDLKFON;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly float MHKHPILDONI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CCE0", Offset = "0x7F5BAE0", VA = "0x187F5CCE0")]
	public static Vector3 KPFMOOGLMHA(Vector3 OLPHNJJOIBM, Quaternion NHBCDKIJGAO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C8E0", Offset = "0x7F5B6E0", VA = "0x187F5C8E0")]
	public static Vector3 GJMJFFCLIGB(Quaternion LJIHJJKHDDH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D160", Offset = "0x7F5BF60", VA = "0x187F5D160")]
	public static Vector3 OLAMLFHBBJG(Quaternion LJIHJJKHDDH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D200", Offset = "0x7F5C000", VA = "0x187F5D200")]
	public static Quaternion OLLELCLIBMF(Vector3 MACLBEFOGKL, Vector3 KODPDAPHGHG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CF70", Offset = "0x7F5BD70", VA = "0x187F5CF70")]
	public static Vector3 NACHGJPNNNJ(Vector3 OMIJNNNJAEH, Vector3 MOLDHLHGKKJ, Vector3 KODPDAPHGHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C4B0", Offset = "0x7F5B2B0", VA = "0x187F5C4B0")]
	public static Vector3 DBOADCIONIK(Vector3 OLPHNJJOIBM, Vector3 KODPDAPHGHG, Quaternion LJIHJJKHDDH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C980", Offset = "0x7F5B780", VA = "0x187F5C980")]
	public static Quaternion GPGIEPEJJGH(Quaternion NHBCDKIJGAO, Vector3 MACLBEFOGKL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C330", Offset = "0x7F5B130", VA = "0x187F5C330")]
	public static bool BHIEOFLHOPC(Vector3 MHJPPCCMDNL, Vector3 LAHOFGBBLAE, [Out] Vector3 PLJNDIABGEJ, bool FPOEMGOLAHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C040", Offset = "0x7F5AE40", VA = "0x187F5C040")]
	public static Vector3 AMODKAOLLOL(bool ECBGJLKFFAD, [Optional] Quaternion AHDENHOIGDG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CCHLCODHAON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3 HKMBNCFKKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float3x3 PHNPMAOBIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float LLINGMLBPPJ;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IEAOPNPEIDM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int OKLKEEHKKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 HAJDHAFPCHP(int KILCKNBNPEG);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion OHELCOIBEHN(int KILCKNBNPEG);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float HAGKCEGKFBF(int KILCKNBNPEG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FLPJCOCICAD : GJFJJPHBPAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool JBNHOGIHMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool IMDCLHNOKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float BIGFHKNOFML
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int MNLNKGDCNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool LCBEGGAOLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int KODFJIDKBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CCHLCODHAON> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EPJPNHNLMPC : GJFJJPHBPAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JBBAGKFDBNF JPGHHKCECDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LPEOJCIOMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 PFEPEINALJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HFMBOPLHMPF
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GNLCMFNGHKL MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MFLNAOCPGAE JCHFAJHFICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GJFJJPHBPAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PFHEOOCJDHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool KEEDMBONBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	GNLCMFNGHKL MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS IGLGKLOBDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float DCFNGINFAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 BBGPGAAGFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	FLGDJDIBGKI IEFMMANJDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	BDLOEKFKAIO CHHIJKLIBIF
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
public interface JLNFEINOIPI
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int NOELFLGKBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform DKKJBIBLPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool PBHOGPDIKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BLHOJKOBONC GetBone(int KILCKNBNPEG);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int KILCKNBNPEG);
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
