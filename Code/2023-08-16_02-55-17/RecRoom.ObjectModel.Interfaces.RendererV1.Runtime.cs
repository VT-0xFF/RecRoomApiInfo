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
public enum HJGGJBIGLCH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	RRO_MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	RRO_COLORS_COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	RRO_MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	GENERATED_MIN_VALUE = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	GENERATED_COLORS_BITS_PER_CHANNEL = 8,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	GENERATED_COLORS_COUNT = 16777216,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	GENERATED_MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	LEGACY_GENERATED_COLORS_COUNT = 4096,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	GENERATED_TO_GPU_OFFSET = -939,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LMKAGOBFPJM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F44D70", Offset = "0x6F43F70", VA = "0x186F44D70")]
	public static bool HBMLCAJONBL(this HJGGJBIGLCH JBPKHBMCLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F44D90", Offset = "0x6F43F90", VA = "0x186F44D90")]
	public static bool KFGAFILJJFF(this HJGGJBIGLCH JBPKHBMCLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F44D40", Offset = "0x6F43F40", VA = "0x186F44D40")]
	public static bool ADIPCENDJIL(this HJGGJBIGLCH JBPKHBMCLEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LIIJACJPKCA : GBHJAOJCEHA, IEquatable<LIIJACJPKCA>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int BBOMBIMAMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int DGOHENJLBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC50", Offset = "0x15BCE50", VA = "0x1815BDC50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2454AF0", Offset = "0x2453CF0", VA = "0x182454AF0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HEOJOBHHAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F44BD0", Offset = "0x6F43DD0", VA = "0x186F44BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28C68F0", Offset = "0x28C5AF0", VA = "0x1828C68F0", Slot = "8")]
	public bool Equals(LIIJACJPKCA JMNBIHILIIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x45F8990", Offset = "0x45F7B90", VA = "0x1845F8990")]
	public static bool PFFDPAELFMB(LIIJACJPKCA GGFLAOCNMAP, LIIJACJPKCA PIINDHALINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F44C10", Offset = "0x6F43E10", VA = "0x186F44C10", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F44CB0", Offset = "0x6F43EB0", VA = "0x186F44CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AFKEAPAJDHP
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NBKCBPOCILE : GBHJAOJCEHA, IEquatable<NBKCBPOCILE>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int BBOMBIMAMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int DGOHENJLBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC50", Offset = "0x15BCE50", VA = "0x1815BDC50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2454AF0", Offset = "0x2453CF0", VA = "0x182454AF0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HEOJOBHHAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F44DA0", Offset = "0x6F43FA0", VA = "0x186F44DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x28C68F0", Offset = "0x28C5AF0", VA = "0x1828C68F0", Slot = "8")]
	public bool Equals(NBKCBPOCILE JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F44DE0", Offset = "0x6F43FE0", VA = "0x186F44DE0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F44E80", Offset = "0x6F44080", VA = "0x186F44E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OCJBCNFPLFL
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BLPFGIECEBB
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	PivotHover,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DebugLocate,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	FrozenHover
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CEFCOHEOOAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJPLPMNFDKG(LIIJACJPKCA MKADPIPCNMO, BLPFGIECEBB DPBBKDNKPAE);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJPLPMNFDKG(NBKCBPOCILE BFCABOCHBCH, BLPFGIECEBB DPBBKDNKPAE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFGGDOBJDAH(NBKCBPOCILE BFCABOCHBCH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNEALBBOEJJ(NBKCBPOCILE BFCABOCHBCH);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFMMPKDOGCN();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DDDOADKFBGJ(BLPFGIECEBB FBNKHAJKFLM);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OPCNLGHJCNH(LIIJACJPKCA MKADPIPCNMO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPCNLGHJCNH(NBKCBPOCILE BFCABOCHBCH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JFKKLHABBGC(LIIJACJPKCA MKADPIPCNMO, LLKOGLCAJBN FBNKHAJKFLM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JFKKLHABBGC(NBKCBPOCILE BFCABOCHBCH, LLKOGLCAJBN FBNKHAJKFLM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JABMBLBMDLE(NBKCBPOCILE BFCABOCHBCH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NNFGHPMLFGD(NBKCBPOCILE BFCABOCHBCH);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LHFIIHFDKPD();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KDDJBIAEBPH(LLKOGLCAJBN FBNKHAJKFLM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ACAJBFLGJNK(LIIJACJPKCA MKADPIPCNMO, Vector3 NADAIPAFPDB, Vector3 LHJAPLFOAFA, Vector3 DMHEJHIIGAK, float HAKMPNFEKBO, float JLKNBHOEMJN, IReadOnlyList<Camera> FNJMMEKCNDG, OCJBCNFPLFL GOBLNCJKDHH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ACAJBFLGJNK(FAIOOLDBMIH ANAPJIFAFBP, Vector3 NADAIPAFPDB, Vector3 LHJAPLFOAFA, Vector3 DMHEJHIIGAK, float HAKMPNFEKBO, float JLKNBHOEMJN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FAIOOLDBMIH : GBHJAOJCEHA, IEquatable<FAIOOLDBMIH>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BBOMBIMAMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DGOHENJLBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC50", Offset = "0x15BCE50", VA = "0x1815BDC50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2454AF0", Offset = "0x2453CF0", VA = "0x182454AF0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HEOJOBHHAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F44AF0", Offset = "0x6F43CF0", VA = "0x186F44AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x28C68F0", Offset = "0x28C5AF0", VA = "0x1828C68F0", Slot = "8")]
	public bool Equals(FAIOOLDBMIH JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F44B30", Offset = "0x6F43D30", VA = "0x186F44B30", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CADEDIIOKBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MNEIBBJIFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIIJACJPKCA DADOIDGEKJB(GPFKOIGOAJP JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LIIJACJPKCA DADOIDGEKJB(GPFKOIGOAJP JFGIPFOFKHL, bool AKPFFCFOCNF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PCCMKKHECEE(LIIJACJPKCA MKADPIPCNMO);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFCGFHJBBNI(LIIJACJPKCA MKADPIPCNMO);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NBKCBPOCILE JCGKHHMPMLF(LIIJACJPKCA MKADPIPCNMO, OHHKPPKECEG JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NBKCBPOCILE FFLCAEMPDAA(LIIJACJPKCA MKADPIPCNMO, EIJJFHIOKKF JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOMPADKAHCI(NBKCBPOCILE BFCABOCHBCH);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IHEKHNPMIHM(NBKCBPOCILE BFCABOCHBCH);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FAIOOLDBMIH IFILIFEBMHO(PPCHLICLNCA JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NCGPDIBECBC(FAIOOLDBMIH ANAPJIFAFBP);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JGDNGJFANDM(FAIOOLDBMIH ANAPJIFAFBP);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task CFABGMCGBPA();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task AGKKACJKDKN();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task HJIKKLIJLEC();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PFIFIALJHAH();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> OFOCDBBCMDE(LIIJACJPKCA MKADPIPCNMO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum LLKOGLCAJBN
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AOAKMFLAKPO
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static Vector3 OEIBIIIGJNP;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static Vector3 JGNGPEPAICO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly float GKBFAPBFHJG;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F41A00", Offset = "0x6F40C00", VA = "0x186F41A00")]
	public static Vector3 OHBJJNKFGNC(Vector3 MOMLOJBPMEF, Quaternion IBNMCFBIENP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F41460", Offset = "0x6F40660", VA = "0x186F41460")]
	public static Vector3 JPCJDPMKNAF(Quaternion ELGEECMLAMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F41510", Offset = "0x6F40710", VA = "0x186F41510")]
	public static Vector3 LJHADNDPNGN(Quaternion ELGEECMLAMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F40EB0", Offset = "0x6F400B0", VA = "0x186F40EB0")]
	public static Quaternion AJFKJKGKFCG(Vector3 KCEMMLEMANI, Vector3 AHEOGBFEFAD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F412B0", Offset = "0x6F404B0", VA = "0x186F412B0")]
	public static Vector3 FDOOOCGLDPO(Vector3 ADGDBEONGNM, Vector3 KCDAIGFLCIO, Vector3 AHEOGBFEFAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F41800", Offset = "0x6F40A00", VA = "0x186F41800")]
	public static Vector3 MJKGOKCPIHM(Vector3 MOMLOJBPMEF, Vector3 AHEOGBFEFAD, Quaternion ELGEECMLAMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F415C0", Offset = "0x6F407C0", VA = "0x186F415C0")]
	public static Quaternion LKPBHAFCEID(Quaternion IBNMCFBIENP, Vector3 KCEMMLEMANI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F41130", Offset = "0x6F40330", VA = "0x186F41130")]
	public static bool EOAFCMDNOKL(Vector3 GFOKIBGCELI, Vector3 DGPIPLGLFEA, out Vector3 DOEPFNODJHK, bool OOJFMCDLPMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F40F50", Offset = "0x6F40150", VA = "0x186F40F50")]
	public static Vector3 APAMIHGOHKG(bool INLIOAHHJLO, [Optional] Quaternion NOLLBBFANGB)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum JFNHOKLDIOK
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EADBDLDHGJD
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct ANOMIGOINAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Vector3 AHMAIAGANPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Quaternion IIKKJHMHDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float NCIJIFIOKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Quaternion LLOELNDBFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float OBDFOHCINIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public float GMKCNGAONAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public float CEKMKBJKFBG;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static List<ANOMIGOINAM> OBEDNMHDLIB;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F43620", Offset = "0x6F42820", VA = "0x186F43620")]
	public static NativeList<ODPLFDHPHAB> JIAMAKEKBIL(CMCCAKIEIHB OJDIKMLBBCE)
	{
		return default(NativeList<ODPLFDHPHAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F43C50", Offset = "0x6F42E50", VA = "0x186F43C50")]
	private static bool MKDFLCKCPEC(int LHPGLCOPMKK, NativeList<ODPLFDHPHAB> GAMJEJDMFJF, List<ANOMIGOINAM> NLPPJLIGDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F43430", Offset = "0x6F42630", VA = "0x186F43430")]
	private static ODPLFDHPHAB JAJIEOOPAOL(int LMDOCEDFAOL, List<ANOMIGOINAM> NLPPJLIGDJN)
	{
		return default(ODPLFDHPHAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F41D00", Offset = "0x6F40F00", VA = "0x186F41D00")]
	private static ODPLFDHPHAB CIEFMNAOHNA(int LMDOCEDFAOL, List<ANOMIGOINAM> NLPPJLIGDJN)
	{
		return default(ODPLFDHPHAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F43B50", Offset = "0x6F42D50", VA = "0x186F43B50")]
	private static ODPLFDHPHAB LBFFBFBJKPC(Vector3 MKEBBICDMDG, Quaternion IBNMCFBIENP, float ADBNNNLLGEN)
	{
		return default(ODPLFDHPHAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F42140", Offset = "0x6F41340", VA = "0x186F42140")]
	public static NativeList<ODPLFDHPHAB> GGPABNJPINF(CMCCAKIEIHB OJDIKMLBBCE, float ENACLEOCOFD)
	{
		return default(NativeList<ODPLFDHPHAB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum NOKFFCIFJFD
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OHHKPPKECEG : DMFLLJNMNDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JFNHOKLDIOK PMAHBCGECDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool OPGMGJICJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GPFKOIGOAJP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HCKALGFFMDC JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	NOKFFCIFJFD AGIGOGKOFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EIJJFHIOKKF : DMFLLJNMNDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool DOFLJBPHBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EFMENDIJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float COIDJKLNONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int PBHGFJBEIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool MKIMGGMOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int NMCPCMPOOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<ODPLFDHPHAB> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PPCHLICLNCA
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int CMKIELKBPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform ECMEFBPJEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NKAKFCPMLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LIIJACJPKCA GetBone(int LMDOCEDFAOL);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int LMDOCEDFAOL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DMFLLJNMNDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool BKIGNCGFBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool FNELCMMLHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HCKALGFFMDC JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float FACNDNMNCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Vector3 CDDKLHIKCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	HJGGJBIGLCH DNJOKOFALAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	AFKEAPAJDHP EAPKLOJBNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ODPLFDHPHAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 AHMAIAGANPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float3x3 IIKKJHMHDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float NCIJIFIOKJG;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CMCCAKIEIHB
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int KNKLAGFHKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 JFKMJCNOLKM(int LMDOCEDFAOL);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion AICMMPHLPFC(int LMDOCEDFAOL);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float HCKBEGPIOEP(int LMDOCEDFAOL);
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
