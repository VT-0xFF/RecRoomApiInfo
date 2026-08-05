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
public enum KADGINDIKPL
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
public static class NGMEKKFOOAO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72D5610", Offset = "0x72D4610", VA = "0x1872D5610")]
	public static bool HNICFCAEJBE(this KADGINDIKPL ABNBGNGEODI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72D5630", Offset = "0x72D4630", VA = "0x1872D5630")]
	public static bool ICDDNBGOFLB(this KADGINDIKPL ABNBGNGEODI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72D5640", Offset = "0x72D4640", VA = "0x1872D5640")]
	public static bool JJMGEGAKECM(this KADGINDIKPL ABNBGNGEODI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct AKLCAEFHFBP : KCABKHEOOAI<AKLCAEFHFBP>, BCBJEENMDEC, IEquatable<AKLCAEFHFBP>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int EODOJNLPHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int EBOJEELKNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x12EC400", Offset = "0x12EB400", VA = "0x1812EC400", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1874F20", Offset = "0x1873F20", VA = "0x181874F20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MFPCNNNAAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72D1820", Offset = "0x72D0820", VA = "0x1872D1820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B19610", Offset = "0x2B18610", VA = "0x182B19610", Slot = "8")]
	public bool Equals(AKLCAEFHFBP BKLMLPFOMCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4954240", Offset = "0x4953240", VA = "0x184954240")]
	public static bool JIPCNIGMDBL(AKLCAEFHFBP LFEMLKHNBHE, AKLCAEFHFBP CNOAFMMFDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72D1780", Offset = "0x72D0780", VA = "0x1872D1780", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72D1860", Offset = "0x72D0860", VA = "0x1872D1860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BACGCBKMFNG
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
public struct NNOBDEBBKFG : KCABKHEOOAI<NNOBDEBBKFG>, BCBJEENMDEC, IEquatable<NNOBDEBBKFG>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int EODOJNLPHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int EBOJEELKNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x12EC400", Offset = "0x12EB400", VA = "0x1812EC400", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1874F20", Offset = "0x1873F20", VA = "0x181874F20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MFPCNNNAAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72D5710", Offset = "0x72D4710", VA = "0x1872D5710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2B19610", Offset = "0x2B18610", VA = "0x182B19610", Slot = "8")]
	public bool Equals(NNOBDEBBKFG BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72D5670", Offset = "0x72D4670", VA = "0x1872D5670", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72D5750", Offset = "0x72D4750", VA = "0x1872D5750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NPADONEKPIO
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
public enum PIHMDDPJOEG
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
public interface GCDOOFPGHGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDIOJGEKEEC(AKLCAEFHFBP EMIPEAKIENF, PIHMDDPJOEG OCBHNJLEKLG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDIOJGEKEEC(NNOBDEBBKFG GFPPIEEIIPL, PIHMDDPJOEG OCBHNJLEKLG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFFFHJKHBIL(NNOBDEBBKFG GFPPIEEIIPL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INCFKMDONIN(NNOBDEBBKFG GFPPIEEIIPL);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PIPEIGHLPON();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHNOHMEEJMJ(PIHMDDPJOEG DPPJBLOOGOO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBNNAMJFAIO(AKLCAEFHFBP EMIPEAKIENF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HBNNAMJFAIO(NNOBDEBBKFG GFPPIEEIIPL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CPNHBHLLHBF(AKLCAEFHFBP EMIPEAKIENF, PIMHGPGHACE DPPJBLOOGOO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CPNHBHLLHBF(NNOBDEBBKFG GFPPIEEIIPL, PIMHGPGHACE DPPJBLOOGOO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KDENDHDHAIL(NNOBDEBBKFG GFPPIEEIIPL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GFLOOECLNPF(NNOBDEBBKFG GFPPIEEIIPL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HPNDGNMEFFP();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BNBPCEHHMCK(PIMHGPGHACE DPPJBLOOGOO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NEEGIAEPOEK(AKLCAEFHFBP EMIPEAKIENF, Vector3 JHNNMDPKAFD, Vector3 ABLDLLLMMGI, Vector3 HJBDKPLCPOB, float PGNCBHODLFK, float HOHPELNKOOM, IReadOnlyList<Camera> JGMLJEHPKJF, NPADONEKPIO POJMCIAMNGD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NEEGIAEPOEK(HLIJEBGPFIJ FINGNOGBGLO, Vector3 JHNNMDPKAFD, Vector3 ABLDLLLMMGI, Vector3 HJBDKPLCPOB, float PGNCBHODLFK, float HOHPELNKOOM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HLIJEBGPFIJ : KCABKHEOOAI<HLIJEBGPFIJ>, BCBJEENMDEC, IEquatable<HLIJEBGPFIJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int EODOJNLPHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EBOJEELKNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x12EC400", Offset = "0x12EB400", VA = "0x1812EC400", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1874F20", Offset = "0x1873F20", VA = "0x181874F20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MFPCNNNAAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72D55D0", Offset = "0x72D45D0", VA = "0x1872D55D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B19610", Offset = "0x2B18610", VA = "0x182B19610", Slot = "8")]
	public bool Equals(HLIJEBGPFIJ BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72D5530", Offset = "0x72D4530", VA = "0x1872D5530", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HJFPJEFIOCE : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LIILGGONCFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DHJCMKDPBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKLCAEFHFBP OEMBDDJKBML(FOEIFBHKJKA HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AKLCAEFHFBP OEMBDDJKBML(FOEIFBHKJKA HHCEHFFEAKN, bool MHCMAPACBAE);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CHGAMPDKFCE(AKLCAEFHFBP EMIPEAKIENF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FDBGLBAJPAP(AKLCAEFHFBP EMIPEAKIENF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NNOBDEBBKFG IJNNBPKBMPN(AKLCAEFHFBP EMIPEAKIENF, CJADDPALMFO HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NNOBDEBBKFG OBFCGHBFOKI(AKLCAEFHFBP EMIPEAKIENF, APHDNBMIAEE HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJILCCOFPDC(NNOBDEBBKFG GFPPIEEIIPL);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KGKJCGBHFEO(NNOBDEBBKFG GFPPIEEIIPL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HLIJEBGPFIJ AHPMLJNNCFG(LDPKPLKGLJC HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CPOGFJIMIFI(HLIJEBGPFIJ FINGNOGBGLO);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FGLKJNKLLIO(HLIJEBGPFIJ FINGNOGBGLO);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task BGKFEDKGJCI();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task LNPLFDHJFML();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task PFBFKAEMMEO();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EEEDKFEADMM();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> GEFGKOONKNL(AKLCAEFHFBP EMIPEAKIENF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum PIMHGPGHACE
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
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FIMGFNPMDNA
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static Vector3 CJFLBJBDCAL;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static Vector3 DBFLLBOFBCL;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly float GNJFJNOJJKG;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72D1C70", Offset = "0x72D0C70", VA = "0x1872D1C70")]
	public static Vector3 EAONMABEFDJ(Vector3 LAPGOBJONBF, Quaternion MKMPGEPCIPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72D2080", Offset = "0x72D1080", VA = "0x1872D2080")]
	public static Vector3 GIIFEFPOGJJ(Quaternion NMKLOHCPMNL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72D2550", Offset = "0x72D1550", VA = "0x1872D2550")]
	public static Vector3 MCDLFDONPFP(Quaternion NMKLOHCPMNL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72D2600", Offset = "0x72D1600", VA = "0x1872D2600")]
	public static Quaternion MHJPBBBIGIB(Vector3 HCEFOMOBPKF, Vector3 CHHELNLAGNA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72D1ED0", Offset = "0x72D0ED0", VA = "0x1872D1ED0")]
	public static Vector3 GCFEOOEKJJL(Vector3 NGMPCPHJGIP, Vector3 FNKKFGAFMAM, Vector3 CHHELNLAGNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72D18F0", Offset = "0x72D08F0", VA = "0x1872D18F0")]
	public static Vector3 AHEKFFEKDCH(Vector3 LAPGOBJONBF, Vector3 CHHELNLAGNA, Quaternion NMKLOHCPMNL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72D2310", Offset = "0x72D1310", VA = "0x1872D2310")]
	public static Quaternion KKNINCIDPMN(Quaternion MKMPGEPCIPH, Vector3 HCEFOMOBPKF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72D1AF0", Offset = "0x72D0AF0", VA = "0x1872D1AF0")]
	public static bool AICJEPEAJAO(Vector3 DGFDLDPFDLD, Vector3 BGLNFMMIFCI, out Vector3 OHBIPHMJMMO, bool IIPNECOGMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72D2130", Offset = "0x72D1130", VA = "0x1872D2130")]
	public static Vector3 KFOPBNEMDHK(bool IJCPHNAIAOA, [Optional] Quaternion AMFCPNKMOBD)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum INJOGMFMJMF
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
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HEMHBHFPBED
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private struct NBPNELGNJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Vector3 JILJAGCFLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Quaternion AOEKNCDMNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float JCICFNPDFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Quaternion JPLONFNPIAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float BMCOHCHLIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public float HKJAEAJCNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public float NLMJKKFKOJO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static List<NBPNELGNJAA> NJAJDLCNCGL;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72D3560", Offset = "0x72D2560", VA = "0x1872D3560")]
	public static NativeList<LLBDJBHIAHE> GIOLHOMOFJP(AMNJHGAEEJL OAACCGHGNDI)
	{
		return default(NativeList<LLBDJBHIAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72D2740", Offset = "0x72D1740", VA = "0x1872D2740")]
	private static bool BOMPIAOEJII(int KJPGMJFNNHE, NativeList<LLBDJBHIAHE> ALIHEMGMHCE, List<NBPNELGNJAA> HCBHJPPICMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72D52C0", Offset = "0x72D42C0", VA = "0x1872D52C0")]
	private static LLBDJBHIAHE MPHGLGLCJHM(int AMHIBJFHICJ, List<NBPNELGNJAA> HCBHJPPICMK)
	{
		return default(LLBDJBHIAHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72D4D80", Offset = "0x72D3D80", VA = "0x1872D4D80")]
	private static LLBDJBHIAHE LBJIDKGGHEJ(int AMHIBJFHICJ, List<NBPNELGNJAA> HCBHJPPICMK)
	{
		return default(LLBDJBHIAHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72D51C0", Offset = "0x72D41C0", VA = "0x1872D51C0")]
	private static LLBDJBHIAHE MBOPPCAIMCJ(Vector3 EHELKFGJCKP, Quaternion MKMPGEPCIPH, float MFIGFOJHONE)
	{
		return default(LLBDJBHIAHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72D3A90", Offset = "0x72D2A90", VA = "0x1872D3A90")]
	public static NativeList<LLBDJBHIAHE> HCPBGOFKJLE(AMNJHGAEEJL OAACCGHGNDI, float OEEPMHOAJEN)
	{
		return default(NativeList<LLBDJBHIAHE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum NCOJDDKHLDM
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
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CJADDPALMFO : MCCJOMAAKKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	INJOGMFMJMF GDJODEIMNPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KLDDPGCOCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FOEIFBHKJKA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	ACILLLOIMMI CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	NCOJDDKHLDM EDNJFACNEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface APHDNBMIAEE : MCCJOMAAKKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool HENJCDHKMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool AOGPGDLNEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float FEPANCCNHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int GINPEICEDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool JIDABPDGLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int KMMFIBCBOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<LLBDJBHIAHE> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LDPKPLKGLJC
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int DMGBFPHHFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform BFAPELIBFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MNMGDAEKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AKLCAEFHFBP GetBone(int AMHIBJFHICJ);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int AMHIBJFHICJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MCCJOMAAKKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GGFNMPHBGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CBDIMKELNPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	ACILLLOIMMI CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float FAPPKDHDEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Vector3 IFGJOJEJKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	KADGINDIKPL AEMNEMGLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	BACGCBKMFNG FBNKCMFBCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LLBDJBHIAHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 JILJAGCFLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float3x3 AOEKNCDMNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float JCICFNPDFMB;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AMNJHGAEEJL
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int MJIIIAJCJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NFENKAEHKPF(int AMHIBJFHICJ);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion GMDKAJEFGBC(int AMHIBJFHICJ);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float DHKJENALFGH(int AMHIBJFHICJ);
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
