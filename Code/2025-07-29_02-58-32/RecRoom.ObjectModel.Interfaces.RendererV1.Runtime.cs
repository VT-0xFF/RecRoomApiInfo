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
public enum FHMHDKGBBFJ
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
public enum BCPAHBIDOOE
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
public enum DCKPNKNDMML
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
public enum FJPEEIJACFI
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
public enum DDEBPFHMGEL
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
public enum KJCFHBDBFJC
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
public static class DGAKFLPMPCA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84D1780", Offset = "0x84D0180", VA = "0x1884D1780")]
	public static bool MBFLMACPBEP(this KJCFHBDBFJC CFDNNOLAADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x84D1740", Offset = "0x84D0140", VA = "0x1884D1740")]
	public static bool BLHCLJFHOGE(this KJCFHBDBFJC CFDNNOLAADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84D1750", Offset = "0x84D0150", VA = "0x1884D1750")]
	public static bool KHEGBAKJLHN(this KJCFHBDBFJC CFDNNOLAADO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum GFPBOOEDAHD
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
public struct ELNDNCAALDE : NDJHBLEGILP, IEquatable<ELNDNCAALDE>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int ODEBCJMJOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int LDLHHBCPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5300", Offset = "0x2FA3D00", VA = "0x182FA5300", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2FA52F0", Offset = "0x2FA3CF0", VA = "0x182FA52F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DKCDJFPCHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84D3D10", Offset = "0x84D2710", VA = "0x1884D3D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x13BE6C0", Offset = "0x13BD0C0", VA = "0x1813BE6C0", Slot = "8")]
	public bool Equals(ELNDNCAALDE EFNHKCDKOGH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C78580", Offset = "0x3C76F80", VA = "0x183C78580")]
	public static bool JJNADAGGMDE(ELNDNCAALDE MLLJGIHINDJ, ELNDNCAALDE ABNAHAKPDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84D3D50", Offset = "0x84D2750", VA = "0x1884D3D50", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84D3DE0", Offset = "0x84D27E0", VA = "0x1884D3DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HGCANMCBGMK : NDJHBLEGILP, IEquatable<HGCANMCBGMK>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int ODEBCJMJOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int LDLHHBCPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5300", Offset = "0x2FA3D00", VA = "0x182FA5300", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2FA52F0", Offset = "0x2FA3CF0", VA = "0x182FA52F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DKCDJFPCHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84D3E70", Offset = "0x84D2870", VA = "0x1884D3E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x13BE6C0", Offset = "0x13BD0C0", VA = "0x1813BE6C0", Slot = "8")]
	public bool Equals(HGCANMCBGMK EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84D3EB0", Offset = "0x84D28B0", VA = "0x1884D3EB0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84D3F40", Offset = "0x84D2940", VA = "0x1884D3F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NKNKHJPNKGK : NDJHBLEGILP, IEquatable<NKNKHJPNKGK>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int ODEBCJMJOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LDLHHBCPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5300", Offset = "0x2FA3D00", VA = "0x182FA5300", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA52F0", Offset = "0x2FA3CF0", VA = "0x182FA52F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DKCDJFPCHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84D52F0", Offset = "0x84D3CF0", VA = "0x1884D52F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x13BE6C0", Offset = "0x13BD0C0", VA = "0x1813BE6C0", Slot = "8")]
	public bool Equals(NKNKHJPNKGK EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84D5330", Offset = "0x84D3D30", VA = "0x1884D5330", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JJOBGHILALB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNNOJFMDGFM(ELNDNCAALDE PJFDNMGHMBL, BCPAHBIDOOE MDAJNMHNCHC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNNOJFMDGFM(HGCANMCBGMK EBOPBDPOAOK, BCPAHBIDOOE MDAJNMHNCHC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPLJCMJFHAK(HGCANMCBGMK EBOPBDPOAOK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCPOOFLHIBH(HGCANMCBGMK EBOPBDPOAOK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CICEGLEPHEH();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBLLBLLKNGK(BCPAHBIDOOE AEOGKDPPBBE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJHPEEODILL(ELNDNCAALDE PJFDNMGHMBL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KJHPEEODILL(HGCANMCBGMK EBOPBDPOAOK);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JIBNIECBDEL(HGCANMCBGMK EBOPBDPOAOK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OIFLMNFPPNO(HGCANMCBGMK EBOPBDPOAOK);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KLEOCGFOGJH();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MBDLPDJMNGN();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NLCABEMFHBP(ELNDNCAALDE PJFDNMGHMBL, DDEBPFHMGEL AEOGKDPPBBE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GDKDGMECEAP(HGCANMCBGMK EBOPBDPOAOK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NHPDEDMDPHH(HGCANMCBGMK EBOPBDPOAOK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ECNHMMOLPCF();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CILFBEFFNDH(DDEBPFHMGEL AEOGKDPPBBE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void COOFCCGHEMP(ELNDNCAALDE PJFDNMGHMBL, Vector3 OBBGOKANJLG, Vector3 GEMNIMFHBBK, Vector3 BNGLDIIGCFH, float OHCAFKODECK, float BHKOMGFEGJM, IReadOnlyList<Camera> PGLAELDJFDK, FHMHDKGBBFJ DPNGPEJBLGB);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void COOFCCGHEMP(NKNKHJPNKGK DCGKNMIIMOP, Vector3 OBBGOKANJLG, Vector3 GEMNIMFHBBK, Vector3 BNGLDIIGCFH, float OHCAFKODECK, float BHKOMGFEGJM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LMLNMMEOLDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GIMGGOOEJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ELNDNCAALDE MGAOAKPBLLC(ABLIKGNMCAG GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELNDNCAALDE MGAOAKPBLLC(ABLIKGNMCAG GPCDCFCPGFK, bool ADPINENDEBH);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KODFPGOLINM(ELNDNCAALDE PJFDNMGHMBL);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MJBLAANBAIP(ELNDNCAALDE PJFDNMGHMBL);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HGCANMCBGMK CGOCNGJCFMP(ELNDNCAALDE PJFDNMGHMBL, KJNPACCILEH GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HGCANMCBGMK IBNHJENLHFC(ELNDNCAALDE PJFDNMGHMBL, MOIJMHAFLGA GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MEPHFHFGBLO(HGCANMCBGMK EBOPBDPOAOK);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JLAONONEBFD(HGCANMCBGMK EBOPBDPOAOK);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NKNKHJPNKGK HJPPNFEPIAF(BJJLDEADPIL GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LEBHJEJBILC(NKNKHJPNKGK DCGKNMIIMOP);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FADCEDHHMBC(NKNKHJPNKGK DCGKNMIIMOP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task IAMCJCPHNIL();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task EFICBJGBNAO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task ALGDPIJCIBN();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EJNJNHIINBH();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> CDKGEAMHJFM(ELNDNCAALDE PJFDNMGHMBL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DLDJHKIDKEI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum CLIGEKGOHJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum FDNEBHCMPKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum EDGHMLGJJLC
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
	public enum COJCNFHEJOI
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
	public enum DCGMHONLDBF
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
	public enum DDGDAFIEGHO
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
	public enum FPLGEHPHBKI
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum BPNPJNIHKGF
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
		LowQualityHighSpeed = 102
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool HGMMBEBBIPP;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long BMIFKCIPDMJ;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool ICODLGBNGKA;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool LLCAEKMDOAF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool ECKCBKLOHMC;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float AJNEMJBMIEJ;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float ECHCHNNBPDI;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int PNFPIMAIBCH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static DDGDAFIEGHO KOCPLGKJJFH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long KGMHENIBONB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float PJNDCICBFIO;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int FNGBKMKBAIN;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int KFKMODGAOCP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int MELDPLOGGDB;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int BMBFPGIGAHK;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int KFJNBMOIDBO;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int FKAIGINDMIK;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int LCBMGBCONNK;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int FFJADEFFAFK;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool FLFPAKPEODF;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int CPFEAAJBICJ;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int JNKFCIAFMIG;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int KIBLDCEKHJN;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool OLPMAEFFHIJ;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float IKNDEAPEHPG;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool EDLKJCFFMPM;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float LBFECDHOCJD;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long KIMHGHACBLC;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool JMENEGNFEGE;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long BJHGFOOHPAB;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int IOCLCHNOFKH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool NDPDPFHNOJL;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static CLIGEKGOHJK FENENLAADJG;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool LDFHOOLCOFL;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool MBDKKHMBECK;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int GHGAIHOLGLI;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int HNLDNLAFOGD;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int FGLEFBLHHEO;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int HGPJFFKPMDO;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int GEJJBBJBDPJ;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int LGGOMNNOODL;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int FMKOPKAINCM;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int KKLGJPLKMDC;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float EGANIDNINCF;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float ANBOHCAEHLA;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float GKNCGNGPJDA;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float MMFFIHFMCNK;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int HKOAGGBKPEB;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int LHOCOHAEFED;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int HOCLOOANBPN;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int HMPBHHJCCKN;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool ANLOBHHBJIL;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static EDGHMLGJJLC AFPJOPBCLFI;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static COJCNFHEJOI HFDMKEHGAGG;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool NJMNAKLMMKE;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static FDNEBHCMPKD OIBCBAICFLO;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float CCLAHMAHMLB;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float NMGHFGKDEEK;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float IAILCKDDGNB;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float LOAEDBDLLDA;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float CDKCCOAIPII;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float BPJBKKDJIDC;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float HAEEGHDEGGI;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float KGNGNHPHOOC;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool BHCKDALBKDB;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static FPLGEHPHBKI BDPJBNCIPMF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool OKFPKHOMBAK;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float BIKEIBJGIPM;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float LFLHJLNAAIK;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float LNILPMNLECK;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float AMLLILLJDLJ;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float DEDBBLBKJEH;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool OMLNACENKNA;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long JJBFHNMKCHK;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float LDINDGFFMAN;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float MCOLMCLLEOO;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float NELJNNKLNCB;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int AMDDIKOLNCO;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float BPJJADCBHKP;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool PBJFDGJLCLM;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long FBFFHCDMBKD;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int IIBAIAPCHLI;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int BIOPNLPFEDC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float NAPJOOGEEPF;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float JCKCIMOOICJ;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool EKFKJADOOBL;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool AFFLHCDCPFG;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float KKNMEKCHOJO;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long CDDMEGMPEMD;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long DBEADCNGAPE;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int APEAOBKEHJM;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static bool GNEPKEKIEIE;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float EOABMKGEDFB;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static float NOMFMMLCHJK;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static bool AJIMAHHCBCK;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long EKDJJBEOBMM;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int KFLJBMHFJII;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static float4x4 ADMCOBMNEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static float3 OJDNNHFOANJ;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static bool NMBPGLOBNDK;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static DCGMHONLDBF LELHEADFAFE;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long MINLFHLIJCK;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int BELCKNHDOLI;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int ALKAEHNMKMM;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int NGEGFPOIIBO;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int AMDEJFHFPLL;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int OOHKLPMDCGO;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int DJHOFGIBMLL;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int PNKEGAAHFMK;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long DDGKJLHKDFM;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int GKNNHFJPNLB;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int GAJDODCKMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int NKJPINIJDLH;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long BJCEPEOJDBM;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long MPFLLNHBLCH;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long LFDJKBHBMLJ;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long OFNLIDNNMAP;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int AJIEFIADEHB;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int LKPJFOMHFBG;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static int HPEOKDBJIAB;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static int EGNIGPJDOOJ;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static int AAADKPDDHME;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static int[] OAGBKJEOCCN;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static int[] EJODAGPCFGA;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static int GKOHPDPIFBK;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long FCMLIEGNNDF;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long BHGPJDMGMDK;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static int NLFPJLDIALF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static int PJPKGGJDOMG;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long DCEHMACABEI;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long FPDJLMBLABN;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long PLPDCDOGCAC;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long EBDMIBOHLPK;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long BMKEIKKLHHO;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long LFKIKBFCIFH;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long CKMEBNPBNNM;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long COKMCGJEODB;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long NCIGLMDJHJK;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static float OAHECDBGJNK;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static float IEENMDPIPHM;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long MNFDOPADMPF;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static int OGHPOPHKNFM;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long NADBMKFLOLP;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long HLMJNNIODAF;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static float AJHFNJGMKCD;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long LPMAHGOHCHK;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long BKNIPPHGNAK;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static long NNAACIEHIBD;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static long HICNIJMAKOP;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static long IAOLGHJLNDB;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static long ABJNCDOCGNI;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static long OFAHAGJLNEB;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static long GGLDGEEBMEL;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static long EKMCOFFKMCE;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static long BLFNEIIJAFP;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static long KONOIKMEMOO;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static long LCIDNLGEOBD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static BPNPJNIHKGF DDLKLBGAMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84D2F70", Offset = "0x84D1970", VA = "0x1884D2F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long KPNIKACGIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84D17A0", Offset = "0x84D01A0", VA = "0x1884D17A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84D1800", Offset = "0x84D0200", VA = "0x1884D1800")]
	public static void FAKBOPIOKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84D1EB0", Offset = "0x84D08B0", VA = "0x1884D1EB0")]
	public static void IMBFIOFOBFC(BPNPJNIHKGF GNEHKPBDFGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class BELEBKNBLDN
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct BILOAKIKHBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Vector3 FLMJNMGJKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Quaternion MBCEPOHNHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public float JPIOKNBMLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Quaternion BMNDNOOPPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public float PEHACNCIIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public float FONHLBLNDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public float GPAMCNHNNCF;
	}

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static List<BILOAKIKHBD> CDOFBHEFHMM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84CE660", Offset = "0x84CD060", VA = "0x1884CE660")]
	public static NativeList<PKFMPNIDAMO> DAJEBOGKNKK(NPPEEAEEPAM LJOFOOFMAON)
	{
		return default(NativeList<PKFMPNIDAMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x84CF1C0", Offset = "0x84CDBC0", VA = "0x1884CF1C0")]
	private static bool LEMOEGBHJJC(int BAMENPFPKND, NativeList<PKFMPNIDAMO> AEAMJGPOBKI, List<BILOAKIKHBD> DEOLMJPICHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84D0070", Offset = "0x84CEA70", VA = "0x1884D0070")]
	private static PKFMPNIDAMO PDBKLDHGCCL(int LLLLOEKJOOH, List<BILOAKIKHBD> DEOLMJPICHA)
	{
		return default(PKFMPNIDAMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84CECD0", Offset = "0x84CD6D0", VA = "0x1884CECD0")]
	private static PKFMPNIDAMO IIMGIPAINGI(int LLLLOEKJOOH, List<BILOAKIKHBD> DEOLMJPICHA)
	{
		return default(PKFMPNIDAMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84CEBF0", Offset = "0x84CD5F0", VA = "0x1884CEBF0")]
	private static PKFMPNIDAMO FAHKIKDKPII(Vector3 FBHMIIMHGKJ, Quaternion FDGBFBGBCCA, float DLJDKOFPIMN)
	{
		return default(PKFMPNIDAMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84D01F0", Offset = "0x84CEBF0", VA = "0x1884D01F0")]
	public static NativeList<PKFMPNIDAMO> PHNBIKAPEEJ(NPPEEAEEPAM LJOFOOFMAON, float PEABKKKPEDJ)
	{
		return default(NativeList<PKFMPNIDAMO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LPAAMCBCAGG
{
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static Vector3 KNPKCENDLHJ;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static Vector3 KJOBGJHHMHC;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly float HNHNHKMENOB;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84D3FD0", Offset = "0x84D29D0", VA = "0x1884D3FD0")]
	public static Vector3 ANENJCMEAGH(Vector3 HLDFGBGLIFF, Quaternion FDGBFBGBCCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x84D42E0", Offset = "0x84D2CE0", VA = "0x1884D42E0")]
	public static Vector3 FCLMJEMGBFH(Quaternion JCDLBIBEGAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84D4E10", Offset = "0x84D3810", VA = "0x1884D4E10")]
	public static Vector3 PMECHNGKFOP(Quaternion JCDLBIBEGAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84D4260", Offset = "0x84D2C60", VA = "0x1884D4260")]
	public static Quaternion DJCOBBGHJOK(Vector3 PNELABKCNPL, Vector3 HKIFHFOHPEK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84D4C20", Offset = "0x84D3620", VA = "0x1884D4C20")]
	public static Vector3 NIBLDDIHHGP(Vector3 DHIPJIGBBFH, Vector3 ILHDOAADPEF, Vector3 HKIFHFOHPEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x84D4380", Offset = "0x84D2D80", VA = "0x1884D4380")]
	public static Vector3 FIGONHKHBFI(Vector3 HLDFGBGLIFF, Vector3 HKIFHFOHPEK, Quaternion JCDLBIBEGAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x84D4EB0", Offset = "0x84D38B0", VA = "0x1884D4EB0")]
	public static Quaternion PMHGJNNHGJD(Quaternion FDGBFBGBCCA, Vector3 PNELABKCNPL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84D4AA0", Offset = "0x84D34A0", VA = "0x1884D4AA0")]
	public static bool MMPLBLODGMI(Vector3 OKJPPIKAMGE, Vector3 AADBCOOHCBN, [Out] Vector3 CBDPDNHHJDB, bool CHHOCKKOAOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84D47B0", Offset = "0x84D31B0", VA = "0x1884D47B0")]
	public static Vector3 MKHIPHALKIH(bool PNEHHNDAOFM, [Optional] Quaternion CCBJNKPGMJC)
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
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public float heightCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float slopeCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public Color topColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public GFPBOOEDAHD topMaterialInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public Color slopeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public GFPBOOEDAHD slopeMaterialInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class TerrainGenerationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public KLOKHGMABCA baseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public float baseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public float baseTerrainScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public TerrainGenerationLayer[] additionalLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public TerrainMaterialLayer[] materialLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public MGJDJHNEGLA playArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public float playAreaOpacity;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84D53C0", Offset = "0x84D3DC0", VA = "0x1884D53C0")]
		public TerrainGenerationInfo()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OFLIBJOKFGI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	TerrainData DENCCOAGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GameObject LJAALBEEFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<bool> ELOKPNODIHK(uint KKFEAIHODFG, bool JCAKGKELJMH = true, bool CJFMDHCMMIO = true, bool EFJEMHIBHAG = true, [Optional] TerrainGenerationInfo LJOFOOFMAON, JDJAJAGLKHD BFEONDIAKAM = JDJAJAGLKHD.Default, [Optional] float3? HBHCLNFNIOD, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NHMIPJFACPH(bool JBAOBMBMLEP);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHKOLEJFGIM(Action<Material> BNAMHOIPKKC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct PKFMPNIDAMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public float3 FLMJNMGJKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public float3x3 MBCEPOHNHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public float JPIOKNBMLCE;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NPPEEAEEPAM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int PCOGDDNMMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 CMMHCDKECFH(int LLLLOEKJOOH);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion JAOPFKGCNEP(int LLLLOEKJOOH);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float ACJJEHIJEFG(int LLLLOEKJOOH);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MOIJMHAFLGA : PKFHIANNIJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EOAOHNDNFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool BJBKBGGALFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float MECJDDEGIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int EMAKOKFPECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JHABFJEIJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int AOBMKIGIBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<PKFMPNIDAMO> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KJNPACCILEH : PKFHIANNIJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DCKPNKNDMML JFLNPJPEJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NDKFOINLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float3 OCECPNOIHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ABLIKGNMCAG
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	JFHFHCDHJDD AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FJPEEIJACFI HFJMDLOCFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface PKFHIANNIJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EIIOPDEBDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool ILMJBEIGOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JFHFHCDHJDD AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	UniformTRS NGMKJCFNJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float ENNPFLHHJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	Vector3 HEOGKKCLJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KJCFHBDBFJC AEONMGLHDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	GFPBOOEDAHD DAEFJDNACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface BJJLDEADPIL
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int DNJLIMDEEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	Transform NLFOKGKPNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool AOHJMAHMKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELNDNCAALDE GetBone(int LLLLOEKJOOH);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int LLLLOEKJOOH);
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
