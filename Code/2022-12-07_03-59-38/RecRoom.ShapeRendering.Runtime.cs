using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.ClusterLODs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BJFANGGBIOF
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
public static class JNCJKDOKNEA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D15780", Offset = "0x5D14380", VA = "0x185D15780")]
	public static bool KPJJKEEHDMJ(this BJFANGGBIOF JHCJJNOHNCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D157A0", Offset = "0x5D143A0", VA = "0x185D157A0")]
	public static bool KPJOCAPNGDI(this BJFANGGBIOF JHCJJNOHNCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D15750", Offset = "0x5D14350", VA = "0x185D15750")]
	public static bool KPDJMPBJLFB(this BJFANGGBIOF JHCJJNOHNCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KALJBMJLDAI
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NOCKOECFJAC
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum IEKCIEFPHIA
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	PivotHover,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DebugLocate,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	FrozenHover
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JDGEJCEALHH
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AJMIOOALKHB : JIGEJGIHOPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte ILHGIJNFFBE = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte PBDHDILIGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] NNDDGOKJBKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PCJFGODIKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6948E0", Offset = "0x6934E0", VA = "0x1806948E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x749ED0", Offset = "0x748AD0", VA = "0x180749ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LEPDNCNOPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74B6B0", Offset = "0x74A2B0", VA = "0x18074B6B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85ACF0", Offset = "0x8598F0", VA = "0x18085ACF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float NHCCHGLLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B5990", Offset = "0x8B4590", VA = "0x1808B5990", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E90", Offset = "0x8B4A90", VA = "0x1808B5E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DNJABCILHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89DB10", Offset = "0x89C710", VA = "0x18089DB10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89DB20", Offset = "0x89C720", VA = "0x18089DB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> AECGGLMODHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E6A0", Offset = "0x5D0D2A0", VA = "0x185D0E6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> HINDKAFIPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1449900", Offset = "0x1448500", VA = "0x181449900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject MNGIEAKGPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7070C0", Offset = "0x705CC0", VA = "0x1807070C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte GJEAOBDHMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E650", Offset = "0x5D0D250", VA = "0x185D0E650", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E700", Offset = "0x5D0D300", VA = "0x185D0E700")]
	public AJMIOOALKHB(List<HGDBLONCJGA> KLDMIMGBOPE, List<HGDBLONCJGA> NNAEODDEJMO, List<BALPOLLGHCC> JKAOJBCOGMO, Material GCODJMECPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E4A0", Offset = "0x5D0D0A0", VA = "0x185D0E4A0")]
	private int HGECHLADHFP(List<HGDBLONCJGA> BDJEKALGKPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E1E0", Offset = "0x5D0CDE0", VA = "0x185D0E1E0")]
	private void DGEHAPNMGMI(int LOENGHEBNMF, bool EMKILHIJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E5B0", Offset = "0x5D0D1B0", VA = "0x185D0E5B0")]
	public void KFAKIBDOFBD(Vector3 HOIBGFPEDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E370", Offset = "0x5D0CF70", VA = "0x185D0E370", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E330", Offset = "0x5D0CF30", VA = "0x185D0E330")]
	public void DIHLNJEMOAD(Transform DIABAGHPMHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MJDCANLDAIM : FOOFENKGEBC, BMBBENDABHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JHEMGKJAPHN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MJDCANLDAIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
		[DebuggerHidden]
		public JHEMGKJAPHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5D149F0", Offset = "0x5D135F0", VA = "0x185D149F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5D144C0", Offset = "0x5D130C0", VA = "0x185D144C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D14AF0", Offset = "0x5D136F0", VA = "0x185D14AF0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D14B40", Offset = "0x5D13740", VA = "0x185D14B40")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D14B90", Offset = "0x5D13790", VA = "0x185D14B90")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5D149B0", Offset = "0x5D135B0", VA = "0x185D149B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D14910", Offset = "0x5D13510", VA = "0x185D14910", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D14910", Offset = "0x5D13510", VA = "0x185D14910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JJOOGAAJALA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public MJDCANLDAIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
		[DebuggerHidden]
		public JJOOGAAJALA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5D14FA0", Offset = "0x5D13BA0", VA = "0x185D14FA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D14BE0", Offset = "0x5D137E0", VA = "0x185D14BE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5D15080", Offset = "0x5D13C80", VA = "0x185D15080")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5D150D0", Offset = "0x5D13CD0", VA = "0x185D150D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D14F60", Offset = "0x5D13B60", VA = "0x185D14F60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5D14EC0", Offset = "0x5D13AC0", VA = "0x185D14EC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5D14EC0", Offset = "0x5D13AC0", VA = "0x185D14EC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly ECHBKKGKAFJ HMPGCFJIKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<GPAJMLGJGME> CIHNLLOFDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> KOJPFNOPBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer LHGGKPLFIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool GADHDCCDMJG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<MCJGGHAHMBJ> NHCHJLCACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KCELLFBNNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D16FB0", Offset = "0x5D15BB0", VA = "0x185D16FB0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BALPOLLGHCC DLHIFPOKBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D16DD0", Offset = "0x5D159D0", VA = "0x185D16DD0", Slot = "7")]
		get
		{
			return default(BALPOLLGHCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> CLACEDGJINA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x694E70", Offset = "0x693A70", VA = "0x180694E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x695830", Offset = "0x694430", VA = "0x180695830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D179B0", Offset = "0x5D165B0", VA = "0x185D179B0")]
	public MJDCANLDAIM(ECHBKKGKAFJ GAGLKGONONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D16EA0", Offset = "0x5D15AA0", VA = "0x185D16EA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D166D0", Offset = "0x5D152D0", VA = "0x185D166D0")]
	public void AABPNGPFBPJ(GPAJMLGJGME MDGOHGCELLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D16FF0", Offset = "0x5D15BF0", VA = "0x185D16FF0")]
	public void KFPKFODPJHB(GPAJMLGJGME MDGOHGCELLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D170B0", Offset = "0x5D15CB0", VA = "0x185D170B0", Slot = "4")]
	public void KJMEFOKCJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D17620", Offset = "0x5D16220", VA = "0x185D17620")]
	public void KLLCLICJMAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D17760", Offset = "0x5D16360", VA = "0x185D17760")]
	private void NNNMODEJKKF(List<GPAJMLGJGME> CIHNLLOFDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D16D00", Offset = "0x5D15900", VA = "0x185D16D00")]
	private static Material BEHPKKMOOPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D17890", Offset = "0x5D16490", VA = "0x185D17890")]
	private void NNNMODEJKKF(GPAJMLGJGME MDGOHGCELLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D178E0", Offset = "0x5D164E0", VA = "0x185D178E0")]
	private void PFBEEDAKKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D167E0", Offset = "0x5D153E0", VA = "0x185D167E0")]
	public void AIHEOHHKMHF(bool GMIKAONGGPC, bool EIPEDCLPNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D176D0", Offset = "0x5D162D0", VA = "0x185D176D0")]
	protected void NGJMBINCPDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D16F40", Offset = "0x5D15B40", VA = "0x185D16F40")]
	[IteratorStateMachine(typeof(JHEMGKJAPHN))]
	public IEnumerable<Renderer> GOABGNNJNFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D16ED0", Offset = "0x5D15AD0", VA = "0x185D16ED0")]
	[IteratorStateMachine(typeof(JJOOGAAJALA))]
	public IEnumerable<Renderer> FMAJKOAGBGG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class HKLHGHEJFMH : GPAJMLGJGME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly OODAHPNMIKL DGOLOBGPDIK;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D12C20", Offset = "0x5D11820", VA = "0x185D12C20")]
	public HKLHGHEJFMH(MJDCANLDAIM KAHCIEGOGHO, OODAHPNMIKL GAGLKGONONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D12840", Offset = "0x5D11440", VA = "0x185D12840", Slot = "13")]
	public override int HGECHLADHFP(GDKHEHMFMDH GDADPCNKOEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D12A30", Offset = "0x5D11630", VA = "0x185D12A30", Slot = "14")]
	public override int LKKIBCMFKIH(GDKHEHMFMDH GDADPCNKOEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D12110", Offset = "0x5D10D10", VA = "0x185D12110", Slot = "15")]
	public override void FBCLEIMPELF(GDKHEHMFMDH GDADPCNKOEN, FNMEMNNHHCA LKKFFCFGPLH, int KHGOFDHLFBO = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CCHDLCFHNDN : global::AHIMPCNGIKJ<CCHDLCFHNDN>, IIENHJEKFBL, IEquatable<CCHDLCFHNDN>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int KLCIKJBGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6DB530", Offset = "0x6DA130", VA = "0x1806DB530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int LKNCJMEJAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x715000", Offset = "0x713C00", VA = "0x180715000", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x715010", Offset = "0x713C10", VA = "0x180715010", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BPOKJGMAKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5D10400", Offset = "0x5D0F000", VA = "0x185D10400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x131C780", Offset = "0x131B380", VA = "0x18131C780", Slot = "8")]
	public bool Equals(CCHDLCFHNDN GHLMPEGFGCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x131CC70", Offset = "0x131B870", VA = "0x18131CC70")]
	public static bool HIPCOIHOPDI(CCHDLCFHNDN APGJBFJMIBK, CCHDLCFHNDN APLKEMLCGID)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x131CC90", Offset = "0x131B890", VA = "0x18131CC90")]
	public static bool AMPJPPMBCJP(CCHDLCFHNDN APGJBFJMIBK, CCHDLCFHNDN APLKEMLCGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D10370", Offset = "0x5D0EF70", VA = "0x185D10370", Slot = "0")]
	public override bool Equals(object AOEMDAGAALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D10440", Offset = "0x5D0F040", VA = "0x185D10440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum BIHCFJPAMNI
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ECHBKKGKAFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BALPOLLGHCC NIFAEFGCFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	BIHCFJPAMNI CKPBPEGPAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CODEFDBNKOG : global::AHIMPCNGIKJ<CODEFDBNKOG>, IIENHJEKFBL, IEquatable<CODEFDBNKOG>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int KLCIKJBGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6DB530", Offset = "0x6DA130", VA = "0x1806DB530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int LKNCJMEJAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x715000", Offset = "0x713C00", VA = "0x180715000", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x715010", Offset = "0x713C10", VA = "0x180715010", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool BPOKJGMAKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5D10560", Offset = "0x5D0F160", VA = "0x185D10560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x131C780", Offset = "0x131B380", VA = "0x18131C780", Slot = "8")]
	public bool Equals(CODEFDBNKOG GHLMPEGFGCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x131CC70", Offset = "0x131B870", VA = "0x18131CC70")]
	public static bool HIPCOIHOPDI(CODEFDBNKOG APGJBFJMIBK, CODEFDBNKOG APLKEMLCGID)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x131CC90", Offset = "0x131B890", VA = "0x18131CC90")]
	public static bool AMPJPPMBCJP(CODEFDBNKOG APGJBFJMIBK, CODEFDBNKOG APLKEMLCGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D104D0", Offset = "0x5D0F0D0", VA = "0x185D104D0", Slot = "0")]
	public override bool Equals(object AOEMDAGAALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D105A0", Offset = "0x5D0F1A0", VA = "0x185D105A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KJADKDPNIBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	BALPOLLGHCC NIFAEFGCFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float OOMICCGKDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 IFOCGAAEPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	BJFANGGBIOF MIGJKLLCBPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	KALJBMJLDAI BONKELMAEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DEMJAMGDPEC : KJADKDPNIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FODELCHMHKP HOOMILOFNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool IDBLPDLALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OODAHPNMIKL : KJADKDPNIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool GFFIIIBOJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool KMGEIANEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float LIGLJEPCKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int MDHPJGNHEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool FGFDHJDHFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int PAHJBGLJNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<MBAOAEEJDEL> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MFDCLMAPBIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDNNNDJEOGH(CCHDLCFHNDN KAHCIEGOGHO, IEKCIEFPHIA KNIDHIKONMK);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDNNNDJEOGH(CODEFDBNKOG MDGOHGCELLE, IEKCIEFPHIA KNIDHIKONMK);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPLACPIGLIN(CODEFDBNKOG MDGOHGCELLE);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKEGPCPDMEA(CODEFDBNKOG MDGOHGCELLE);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLNPHMAELGC();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HLOOHCKPMAF();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FAJIEILNKGA(IEKCIEFPHIA JMPEGNOKOOB);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFLAGAMJFPE(CCHDLCFHNDN KAHCIEGOGHO);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PFLAGAMJFPE(CODEFDBNKOG MDGOHGCELLE);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NHPFENFLGCI(CCHDLCFHNDN KAHCIEGOGHO, JDGEJCEALHH JMPEGNOKOOB);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NHPFENFLGCI(CODEFDBNKOG MDGOHGCELLE, JDGEJCEALHH JMPEGNOKOOB);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JBOHJLMHGOM(CODEFDBNKOG MDGOHGCELLE);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HCIJCGILIMK(CODEFDBNKOG MDGOHGCELLE);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GENBAGEGGNO();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BCAPLDJEPIN();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CJDDKMAECDE(JDGEJCEALHH JMPEGNOKOOB);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HBLHMFMDFFA(CCHDLCFHNDN KAHCIEGOGHO, Vector3 POAGEOBCFFI, Vector3 NBOJBOGHKHE, Vector3 JODLCCFHKIF, float CIHCIECFMCE, float IPCKBOHNMKE, IReadOnlyList<Camera> KGFFNBIINIE, NOCKOECFJAC LDJPCLMLBCF);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HBLHMFMDFFA(ENLHIKMFBPC KOLOOGBIAME, Vector3 POAGEOBCFFI, Vector3 NBOJBOGHKHE, Vector3 JODLCCFHKIF, float CIHCIECFMCE, float IPCKBOHNMKE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PHEGBKGGLIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CCHDLCFHNDN DNMCHHNCIEC(ECHBKKGKAFJ GAGLKGONONJ);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELNCMHNELFE(CCHDLCFHNDN KAHCIEGOGHO);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPEODBHEECC(CCHDLCFHNDN KAHCIEGOGHO);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CODEFDBNKOG ALHKAOHFODH(CCHDLCFHNDN KAHCIEGOGHO, DEMJAMGDPEC GAGLKGONONJ);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CODEFDBNKOG MJIEFEGMFNC(CCHDLCFHNDN KAHCIEGOGHO, OODAHPNMIKL GAGLKGONONJ);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ALPIMGGCENJ(CODEFDBNKOG MDGOHGCELLE);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMNHKKFGFBA(CODEFDBNKOG MDGOHGCELLE);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ENLHIKMFBPC JABPGGKDDKM(CDBKBGBCHLK GAGLKGONONJ);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FIGPMCPBHLH(ENLHIKMFBPC KOLOOGBIAME);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KBNLKIKHDNI(ENLHIKMFBPC KOLOOGBIAME);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FFBGKCAFEKO NLMGBGAGDFF(BALPOLLGHCC KBGBHNENLAN, IEnumerable<CODEFDBNKOG> CIHNLLOFDFM, int PCDBJBDDLPD);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> GAHMIKDAJFG(CCHDLCFHNDN KAHCIEGOGHO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ENLHIKMFBPC : global::AHIMPCNGIKJ<ENLHIKMFBPC>, IIENHJEKFBL, IEquatable<ENLHIKMFBPC>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int KLCIKJBGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6DB530", Offset = "0x6DA130", VA = "0x1806DB530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int LKNCJMEJAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x715000", Offset = "0x713C00", VA = "0x180715000", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x715010", Offset = "0x713C10", VA = "0x180715010", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BPOKJGMAKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5D106C0", Offset = "0x5D0F2C0", VA = "0x185D106C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x131C780", Offset = "0x131B380", VA = "0x18131C780", Slot = "8")]
	public bool Equals(ENLHIKMFBPC GHLMPEGFGCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x131CC70", Offset = "0x131B870", VA = "0x18131CC70")]
	public static bool HIPCOIHOPDI(ENLHIKMFBPC APGJBFJMIBK, ENLHIKMFBPC APLKEMLCGID)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x131CC90", Offset = "0x131B890", VA = "0x18131CC90")]
	public static bool AMPJPPMBCJP(ENLHIKMFBPC APGJBFJMIBK, ENLHIKMFBPC APLKEMLCGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D10630", Offset = "0x5D0F230", VA = "0x185D10630", Slot = "0")]
	public override bool Equals(object AOEMDAGAALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CDBKBGBCHLK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int FCBOOLHFENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform KBMNGPFGAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool KNLNMOPOELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCHDLCFHNDN GetBone(int DNOJICAPJCM);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int DNOJICAPJCM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class JHDKLBBHMFJ : GPAJMLGJGME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly DEMJAMGDPEC CDFGGLJDNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] CGGJJPLFPCC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override FNLEILIENLM JGDOOODLJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D13FB0", Offset = "0x5D12BB0", VA = "0x185D13FB0", Slot = "12")]
		get
		{
			return default(FNLEILIENLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 BOEELMNIEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D12C70", Offset = "0x5D11870", VA = "0x185D12C70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D12C20", Offset = "0x5D11820", VA = "0x185D12C20")]
	public JHDKLBBHMFJ(MJDCANLDAIM KAHCIEGOGHO, DEMJAMGDPEC GAGLKGONONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D12FB0", Offset = "0x5D11BB0", VA = "0x185D12FB0", Slot = "11")]
	public override bool DFHDPIJDMKK(BALPOLLGHCC KAHCIEGOGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5D14360", Offset = "0x5D12F60", VA = "0x185D14360", Slot = "13")]
	public override int HGECHLADHFP(GDKHEHMFMDH GDADPCNKOEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D14410", Offset = "0x5D13010", VA = "0x185D14410", Slot = "14")]
	public override int LKKIBCMFKIH(GDKHEHMFMDH GDADPCNKOEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D13D00", Offset = "0x5D12900", VA = "0x185D13D00")]
	private int FLKOBIDMLND(GDKHEHMFMDH GDADPCNKOEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D13420", Offset = "0x5D12020", VA = "0x185D13420", Slot = "15")]
	public override void FBCLEIMPELF(GDKHEHMFMDH GDADPCNKOEN, FNMEMNNHHCA LKKFFCFGPLH, int KHGOFDHLFBO = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AONLFFPBNJH
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJEJEOCBOAI(JDGEJCEALHH JMPEGNOKOOB, Renderer HOONNFJFBIC, int KPDALCJPGGB);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHHBEGNFAPN(Renderer HOONNFJFBIC, NOCKOECFJAC LDJPCLMLBCF, Vector3 POAGEOBCFFI, Vector3 NBOJBOGHKHE, Vector3 JODLCCFHKIF, float CIHCIECFMCE, float IPCKBOHNMKE, float JAMEGEBGGGH = -1f, [Optional] Color? NCBJACAKLIH, [Optional] IReadOnlyList<Camera> DAOCKOCMCGA);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEDHMGKHGAJ(Renderer HOONNFJFBIC, int KPDALCJPGGB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int INEEHBKOFCC();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HJKKPAIEGPI(int GELNPGIIKJL, IEKCIEFPHIA JMPEGNOKOOB, Renderer HOONNFJFBIC, int KPDALCJPGGB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MNMNHIBMJPG : MFDCLMAPBIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class BPILEJFFBJH : global::NAHBDKFABLE<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5D10170", Offset = "0x5D0ED70", VA = "0x185D10170")]
		public BPILEJFFBJH(string MKPDFAEIFFO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly AONLFFPBNJH AFANFNDGAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly PEEKHBAGOFD OOBHJJGMMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer NFPKNAJFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private BPILEJFFBJH JEHMAFBLEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool KFBHMAJBHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer KHEIJKHAIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private BPILEJFFBJH OKLCIMCNIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool AKDKLHJGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer GMLMKDLKGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private BPILEJFFBJH MDGELJJGDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x733BB0", Offset = "0x7327B0", VA = "0x180733BB0")]
	public MNMNHIBMJPG(AONLFFPBNJH EKJGNLNBFOL, PEEKHBAGOFD OOBHJJGMMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5D17CC0", Offset = "0x5D168C0", VA = "0x185D17CC0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5D19720", Offset = "0x5D18320", VA = "0x185D19720")]
	private void OBIPAPOGMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D18E90", Offset = "0x5D17A90", VA = "0x185D18E90", Slot = "4")]
	public void LDNNNDJEOGH(CCHDLCFHNDN KAHCIEGOGHO, IEKCIEFPHIA KNIDHIKONMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D18C70", Offset = "0x5D17870", VA = "0x185D18C70", Slot = "5")]
	public void LDNNNDJEOGH(CODEFDBNKOG MDGOHGCELLE, IEKCIEFPHIA KNIDHIKONMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D17B90", Offset = "0x5D16790", VA = "0x185D17B90", Slot = "6")]
	public void CPLACPIGLIN(CODEFDBNKOG MDGOHGCELLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D19600", Offset = "0x5D18200", VA = "0x185D19600", Slot = "7")]
	public void NKEGPCPDMEA(CODEFDBNKOG MDGOHGCELLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D189E0", Offset = "0x5D175E0", VA = "0x185D189E0", Slot = "8")]
	public void JLNPHMAELGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1F112E0", Offset = "0x1F0FEE0", VA = "0x181F112E0", Slot = "9")]
	public void HLOOHCKPMAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D17F60", Offset = "0x5D16B60", VA = "0x185D17F60", Slot = "10")]
	public void FAJIEILNKGA(IEKCIEFPHIA KNIDHIKONMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D19CC0", Offset = "0x5D188C0", VA = "0x185D19CC0", Slot = "11")]
	public void PFLAGAMJFPE(CCHDLCFHNDN KAHCIEGOGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D19970", Offset = "0x5D18570", VA = "0x185D19970", Slot = "12")]
	public void PFLAGAMJFPE(CODEFDBNKOG MDGOHGCELLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D19280", Offset = "0x5D17E80", VA = "0x185D19280", Slot = "13")]
	public void NHPFENFLGCI(CCHDLCFHNDN KAHCIEGOGHO, JDGEJCEALHH JMPEGNOKOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5D19090", Offset = "0x5D17C90", VA = "0x185D19090", Slot = "14")]
	public void NHPFENFLGCI(CODEFDBNKOG MDGOHGCELLE, JDGEJCEALHH JMPEGNOKOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D180D0", Offset = "0x5D16CD0", VA = "0x185D180D0", Slot = "17")]
	public void GENBAGEGGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D18940", Offset = "0x5D17540", VA = "0x185D18940", Slot = "15")]
	public void JBOHJLMHGOM(CODEFDBNKOG MDGOHGCELLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D188B0", Offset = "0x5D174B0", VA = "0x185D188B0", Slot = "16")]
	public void HCIJCGILIMK(CODEFDBNKOG MDGOHGCELLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1852A00", Offset = "0x1851600", VA = "0x181852A00", Slot = "18")]
	public void BCAPLDJEPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D17A50", Offset = "0x5D16650", VA = "0x185D17A50", Slot = "19")]
	public void CJDDKMAECDE(JDGEJCEALHH JMPEGNOKOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D18A20", Offset = "0x5D17620", VA = "0x185D18A20")]
	private void KDDODGGLNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D19440", Offset = "0x5D18040", VA = "0x185D19440")]
	public void NHPFENFLGCI(CODEFDBNKOG MDGOHGCELLE, JDGEJCEALHH JMPEGNOKOOB, bool LBIHJFONJDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D17E90", Offset = "0x5D16A90", VA = "0x185D17E90")]
	private void EJEJEOCBOAI(JDGEJCEALHH JMPEGNOKOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D18530", Offset = "0x5D17130", VA = "0x185D18530", Slot = "20")]
	public void HBLHMFMDFFA(CCHDLCFHNDN KAHCIEGOGHO, Vector3 POAGEOBCFFI, Vector3 NBOJBOGHKHE, Vector3 JODLCCFHKIF, float CIHCIECFMCE, float IPCKBOHNMKE, IReadOnlyList<Camera> KGFFNBIINIE, NOCKOECFJAC LDJPCLMLBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D18110", Offset = "0x5D16D10", VA = "0x185D18110", Slot = "21")]
	public void HBLHMFMDFFA(ENLHIKMFBPC KOLOOGBIAME, Vector3 POAGEOBCFFI, Vector3 NBOJBOGHKHE, Vector3 JODLCCFHKIF, float CIHCIECFMCE, float IPCKBOHNMKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class GPAJMLGJGME : CMCNBMINKIM, MCJGGHAHMBJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly MJDCANLDAIM MNGIEAKGPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds LJKCANPEHME;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds KLNBNDDPDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x19ED140", Offset = "0x19EBD40", VA = "0x1819ED140", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual FNLEILIENLM JGDOOODLJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D10D60", Offset = "0x5D0F960", VA = "0x185D10D60", Slot = "12")]
		get
		{
			return default(FNLEILIENLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
	protected GPAJMLGJGME(MJDCANLDAIM KAHCIEGOGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D10C90", Offset = "0x5D0F890", VA = "0x185D10C90", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0", Slot = "11")]
	public virtual bool DFHDPIJDMKK(BALPOLLGHCC KAHCIEGOGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int HGECHLADHFP(GDKHEHMFMDH GDADPCNKOEN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int LKKIBCMFKIH(GDKHEHMFMDH GDADPCNKOEN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void FBCLEIMPELF(GDKHEHMFMDH GDADPCNKOEN, FNMEMNNHHCA LKKFFCFGPLH, int KHGOFDHLFBO = -1);
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D19E70", Offset = "0x5D18A70", VA = "0x185D19E70")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FODELCHMHKP
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class KPINHONCJKE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CCGPAABPOAC : IEnumerable<PPGLDPDLPGC>, IEnumerable, IEnumerator<PPGLDPDLPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private PPGLDPDLPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private PPGLDPDLPGC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
		[DebuggerHidden]
		public CCGPAABPOAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D101C0", Offset = "0x5D0EDC0", VA = "0x185D101C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D10330", Offset = "0x5D0EF30", VA = "0x185D10330", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D102A0", Offset = "0x5D0EEA0", VA = "0x185D102A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PPGLDPDLPGC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D102A0", Offset = "0x5D0EEA0", VA = "0x185D102A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int GJKONDJANNM = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static PPGLDPDLPGC[][] OMBOEFIMPFB;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static HJIOLHJLLKG LDMHBEBOPFC;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static ShapeRendererConfig NEHBHOABNHB;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader LKEEOODJEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D16550", Offset = "0x5D15150", VA = "0x185D16550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer PLAOJIPOKHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D165C0", Offset = "0x5D151C0", VA = "0x185D165C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D15B20", Offset = "0x5D14720", VA = "0x185D15B20")]
	public static Mesh CPNPNEEBHFK(FODELCHMHKP LKMNBOKBBCD, int GDADPCNKOEN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D16540", Offset = "0x5D15140", VA = "0x185D16540")]
	public static int PCMNBEHCCAJ(FODELCHMHKP LKMNBOKBBCD, int GDADPCNKOEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D15C00", Offset = "0x5D14800", VA = "0x185D15C00")]
	public static HJIOLHJLLKG FDHBIKOBCBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D15D60", Offset = "0x5D14960", VA = "0x185D15D60")]
	[IteratorStateMachine(typeof(CCGPAABPOAC))]
	private static IEnumerable<PPGLDPDLPGC> JNEEBBNFNBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D157C0", Offset = "0x5D143C0", VA = "0x185D157C0")]
	public static PPGLDPDLPGC CMMDKOIJDNI(FODELCHMHKP LKMNBOKBBCD, int GDADPCNKOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D15BE0", Offset = "0x5D147E0", VA = "0x185D15BE0")]
	public static bool ECPKNCJGIFK(this FODELCHMHKP LKMNBOKBBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D16170", Offset = "0x5D14D70", VA = "0x185D16170")]
	public static void LJMNNBLCIBP(FODELCHMHKP LKMNBOKBBCD, float3 BOLODDHNLMJ, out NNPLONOGMPI MHJEDGMGFBH, out float3 ALEMELBAMKF, out float IOMHJMHEMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D15DC0", Offset = "0x5D149C0", VA = "0x185D15DC0")]
	public static void KHBKFOPFOEB(Vector3 BOLODDHNLMJ, FODELCHMHKP LKMNBOKBBCD, out Vector3 ALEMELBAMKF, out float IOMHJMHEMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D157B0", Offset = "0x5D143B0", VA = "0x185D157B0")]
	[AKLMCCEMLAH(OAKCDKKFGKB.ExitingPlayMode, 0)]
	private static void BFHMCFPEGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D16320", Offset = "0x5D14F20", VA = "0x185D16320")]
	[AKLMCCEMLAH(OAKCDKKFGKB.ExitingPlayMode, 0)]
	private static void OIBBJMOFBLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LDCFOFFJIBE
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool JLPGOHHIJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material MPEIAFKNNKO();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material BEHPKKMOOPM();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material FDDKPAODDGI();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HPKPJNALPKH(BJFANGGBIOF JHCJJNOHNCL);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KNMEIIFHOOK(KALJBMJLDAI NOADINBLMJM);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HDCDOKOHFFM(GameObject AOEMDAGAALP);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHDHJBJEHDP(GameObject AOEMDAGAALP, bool NMCKNDEIPKC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface PEEKHBAGOFD
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MJDCANLDAIM KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	GPAJMLGJGME KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	ANDMPCGNKAL KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[DefaultMember("Item")]
	[GKALNADHNEP(DAHLALKJFLL.ShapeRendering)]
	public class ShapeRendererManager : PHEGBKGGLIJ, IDisposable, PEEKHBAGOFD
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly global::DJBGJNBMNEB<CCHDLCFHNDN, MJDCANLDAIM> OOMAPPLLDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly global::DJBGJNBMNEB<CODEFDBNKOG, GPAJMLGJGME> CIHNLLOFDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly global::DJBGJNBMNEB<ENLHIKMFBPC, ANDMPCGNKAL> JGAELMGBBBD;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static LDCFOFFJIBE HPPBNNLHOMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A390", Offset = "0x5D18F90", VA = "0x185D1A390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A010", Offset = "0x5D18C10", VA = "0x185D1A010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public MJDCANLDAIM KKLNJFMENLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A6F0", Offset = "0x5D192F0", VA = "0x185D1A6F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public GPAJMLGJGME KKLNJFMENLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A750", Offset = "0x5D19350", VA = "0x185D1A750", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public ANDMPCGNKAL KKLNJFMENLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A690", Offset = "0x5D19290", VA = "0x185D1A690", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AD90", Offset = "0x5D19990", VA = "0x185D1AD90")]
		public ShapeRendererManager(LDCFOFFJIBE EKJGNLNBFOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A180", Offset = "0x5D18D80", VA = "0x185D1A180", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A080", Offset = "0x5D18C80", VA = "0x185D1A080", Slot = "4")]
		public CCHDLCFHNDN DNMCHHNCIEC(ECHBKKGKAFJ GAGLKGONONJ)
		{
			return default(CCHDLCFHNDN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A210", Offset = "0x5D18E10", VA = "0x185D1A210", Slot = "5")]
		public void ELNCMHNELFE(CCHDLCFHNDN KAHCIEGOGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A8C0", Offset = "0x5D194C0", VA = "0x185D1A8C0", Slot = "6")]
		public void MPEODBHEECC(CCHDLCFHNDN KAHCIEGOGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D19EA0", Offset = "0x5D18AA0", VA = "0x185D19EA0", Slot = "7")]
		public CODEFDBNKOG ALHKAOHFODH(CCHDLCFHNDN KAHCIEGOGHO, DEMJAMGDPEC GAGLKGONONJ)
		{
			return default(CODEFDBNKOG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A7B0", Offset = "0x5D193B0", VA = "0x185D1A7B0", Slot = "8")]
		public CODEFDBNKOG MJIEFEGMFNC(CCHDLCFHNDN KAHCIEGOGHO, OODAHPNMIKL GAGLKGONONJ)
		{
			return default(CODEFDBNKOG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A3F0", Offset = "0x5D18FF0", VA = "0x185D1A3F0", Slot = "10")]
		public void IMNHKKFGFBA(CODEFDBNKOG MDGOHGCELLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D19FB0", Offset = "0x5D18BB0", VA = "0x185D19FB0", Slot = "9")]
		public void ALPIMGGCENJ(CODEFDBNKOG MDGOHGCELLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A2D0", Offset = "0x5D18ED0", VA = "0x185D1A2D0", Slot = "15")]
		public IEnumerable<Renderer> GAHMIKDAJFG(CCHDLCFHNDN KAHCIEGOGHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A480", Offset = "0x5D19080", VA = "0x185D1A480", Slot = "11")]
		public ENLHIKMFBPC JABPGGKDDKM(CDBKBGBCHLK GAGLKGONONJ)
		{
			return default(ENLHIKMFBPC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A620", Offset = "0x5D19220", VA = "0x185D1A620", Slot = "13")]
		public void KBNLKIKHDNI(ENLHIKMFBPC KOLOOGBIAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A270", Offset = "0x5D18E70", VA = "0x185D1A270", Slot = "12")]
		public void FIGPMCPBHLH(ENLHIKMFBPC KOLOOGBIAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A940", Offset = "0x5D19540", VA = "0x185D1A940", Slot = "14")]
		public FFBGKCAFEKO NLMGBGAGDFF(BALPOLLGHCC ABGDMLGFOEG, IEnumerable<CODEFDBNKOG> CIHNLLOFDFM, int PCDBJBDDLPD)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ANDMPCGNKAL : FOOFENKGEBC
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class FOGKKMDCHEC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public ANDMPCGNKAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
		[DebuggerHidden]
		public FOGKKMDCHEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5D109E0", Offset = "0x5D0F5E0", VA = "0x185D109E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5D10700", Offset = "0x5D0F300", VA = "0x185D10700", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D10A60", Offset = "0x5D0F660", VA = "0x185D10A60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5D109A0", Offset = "0x5D0F5A0", VA = "0x185D109A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D10900", Offset = "0x5D0F500", VA = "0x185D10900", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5D10900", Offset = "0x5D0F500", VA = "0x185D10900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly CDBKBGBCHLK AMGEBIBOJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly PEEKHBAGOFD OOBHJJGMMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private AJMIOOALKHB MKAFAABGAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private List<HGDBLONCJGA> HKGGMFGCAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private List<HGDBLONCJGA> IKKFIBDCGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject ANHNHONFHHI;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FF00", Offset = "0x5D0EB00", VA = "0x185D0FF00")]
	public static ANDMPCGNKAL OLPEGBBAAEB(CDBKBGBCHLK GAGLKGONONJ, PEEKHBAGOFD OOBHJJGMMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D10070", Offset = "0x5D0EC70", VA = "0x185D10070")]
	private ANDMPCGNKAL(CDBKBGBCHLK GAGLKGONONJ, PEEKHBAGOFD OOBHJJGMMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EAC0", Offset = "0x5D0D6C0", VA = "0x185D0EAC0")]
	public void EKCDHDCHCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EFA0", Offset = "0x5D0DBA0", VA = "0x185D0EFA0")]
	[IteratorStateMachine(typeof(FOGKKMDCHEC))]
	public IEnumerable<Renderer> GOABGNNJNFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F0B0", Offset = "0x5D0DCB0", VA = "0x185D0F0B0", Slot = "4")]
	public void KJMEFOKCJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F010", Offset = "0x5D0DC10", VA = "0x185D0F010")]
	private void IAOJLBFCPDK(Vector3 HOIBGFPEDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FC60", Offset = "0x5D0E860", VA = "0x185D0FC60")]
	public void KLLCLICJMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HGDBLONCJGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct BCBDAAFNPKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public FNMEMNNHHCA GOOMFKDMAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public BALPOLLGHCC HNBDMPFEMGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int EIMHAINJJNF;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GGLPNHKDHAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public HGDBLONCJGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public GDKHEHMFMDH lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<BCBDAAFNPKK> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public FFBGKCAFEKO combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public GGLPNHKDHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D10AB0", Offset = "0x5D0F6B0", VA = "0x185D10AB0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5D10B10", Offset = "0x5D0F710", VA = "0x185D10B10")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D10B40", Offset = "0x5D0F740", VA = "0x185D10B40")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int[] BLDPIKOAGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private JPPFCFOBGMO MLOMAIDJHLI;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static Matrix4x4 NHGELAOFFKN;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh NEOACDBPILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x695F10", Offset = "0x694B10", VA = "0x180695F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int KGIENBMOHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x749E90", Offset = "0x748A90", VA = "0x180749E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5D11260", Offset = "0x5D0FE60", VA = "0x185D11260")]
	public void GFAGIALFGPD(List<BALPOLLGHCC> PIJGFHFCHGF, Matrix4x4[] BBKEHPMMDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5D115A0", Offset = "0x5D101A0", VA = "0x185D115A0")]
	public static List<HGDBLONCJGA> NBONEDNFGGC(List<MJDCANLDAIM> DIKENCJMHLN, GDKHEHMFMDH GDADPCNKOEN, Bounds ACMFNPPAOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D10DF0", Offset = "0x5D0F9F0", VA = "0x185D10DF0")]
	private JobHandle DNKAOOLMKLO(FFBGKCAFEKO GAMLOADLMPP, int PLMNLIGKEMN, int KKEGFEFDCPN, GDKHEHMFMDH GDADPCNKOEN, List<BCBDAAFNPKK> AJKIJCDLDNO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D11490", Offset = "0x5D10090", VA = "0x185D11490")]
	private void KLCHMMFHIKM(List<BCBDAAFNPKK> AJKIJCDLDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D11D00", Offset = "0x5D10900", VA = "0x185D11D00")]
	private HGDBLONCJGA(List<BCBDAAFNPKK> AJKIJCDLDNO, int PLMNLIGKEMN, int KKEGFEFDCPN, GDKHEHMFMDH GDADPCNKOEN, Bounds ACMFNPPAOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D111D0", Offset = "0x5D0FDD0", VA = "0x185D111D0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private MaterialPropertyBlock GHDMHMNIJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private HGDBLONCJGA DNIOKNPDAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<BALPOLLGHCC> JKAOJBCOGMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private RenderTexture PHMGLBGNHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ComputeBuffer HAAMGFKMMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private ComputeShader GBNFJKONAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Matrix4x4[] CAFIBELJNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int LDBHBNCGEDI;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer IHJNCPMMMED
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x69FA00", Offset = "0x69E600", VA = "0x18069FA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int FCBOOLHFENL
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5D1BFC0", Offset = "0x5D1ABC0", VA = "0x185D1BFC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B330", Offset = "0x5D19F30", VA = "0x185D1B330")]
		public static List<SkinnedShapeRenderer> Create(GameObject KAHCIEGOGHO, List<HGDBLONCJGA> BDJEKALGKPK, List<BALPOLLGHCC> JKAOJBCOGMO, Material GCODJMECPPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B740", Offset = "0x5D1A340", VA = "0x185D1B740")]
		public void Init(HGDBLONCJGA DNIOKNPDAGH, List<BALPOLLGHCC> JKAOJBCOGMO, Material GCODJMECPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BF10", Offset = "0x5D1AB10", VA = "0x185D1BF10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BE60", Offset = "0x5D1AA60", VA = "0x185D1BE60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BE20", Offset = "0x5D1AA20", VA = "0x185D1BE20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BBF0", Offset = "0x5D1A7F0", VA = "0x185D1BBF0")]
		private void MKHIPDCBALE(ScriptableRenderContext MAMKOIKAADI, Camera[] KNKBGNCDFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B580", Offset = "0x5D1A180", VA = "0x185D1B580")]
		private void GFAGIALFGPD(CommandBuffer GIEBDHFODFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : BBLLDMGLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C0F0", Offset = "0x5D1ACF0", VA = "0x185D1C0F0", Slot = "4")]
		public sealed override void LOFJJDLCKCK()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5D15120", Offset = "0x5D13D20", VA = "0x185D15120")]
	private static string HIPMGELGEMF(byte[] APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5D15230", Offset = "0x5D13E30", VA = "0x185D15230")]
	public static string OIADEFGOGFH(byte[] FCLGIGIIKEH, bool ABEBLNADKAB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
	}
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
