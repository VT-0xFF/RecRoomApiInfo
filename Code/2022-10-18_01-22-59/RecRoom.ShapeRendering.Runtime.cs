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
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MGEFPCNKMIB
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
public static class BLNIBPMJIPA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5B063C0", Offset = "0x5B053C0", VA = "0x185B063C0")]
	public static bool HAOOMLLGKFF(this MGEFPCNKMIB OKHCMJBGFFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B063E0", Offset = "0x5B053E0", VA = "0x185B063E0")]
	public static bool KEKOFANONAL(this MGEFPCNKMIB OKHCMJBGFFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5B06390", Offset = "0x5B05390", VA = "0x185B06390")]
	public static bool GNHDGOKFDPP(this MGEFPCNKMIB OKHCMJBGFFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HNKHNOJCOFP
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
public enum CJJFHIJKLJN
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
public enum DKODOLBCJOB
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
public enum JMKIMCMCJGJ
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
public class CKLPLBCNDBH : NIBOGNHEKFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte FHPHHLPCJGC = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte OPPOMOMJNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] IIJHIDLOAPI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KPIHMDMCLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x656010", VA = "0x180657010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A0CC0", Offset = "0x69FCC0", VA = "0x1806A0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HNFGFOMDMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x677D90", Offset = "0x676D90", VA = "0x180677D90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x844950", Offset = "0x843950", VA = "0x180844950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float MEAKBEOKHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1290830", Offset = "0x128F830", VA = "0x181290830", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1291290", Offset = "0x1290290", VA = "0x181291290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float FJFIPKPHDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xF8F1F0", Offset = "0xF8E1F0", VA = "0x180F8F1F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF8F330", Offset = "0xF8E330", VA = "0x180F8F330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> JFPNDBJCDHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B0AC80", Offset = "0x5B09C80", VA = "0x185B0AC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> FPCELNCJLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5710030", Offset = "0x570F030", VA = "0x185710030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject BPBHOPDAIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EEAE0", VA = "0x1806EFAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte NOMAIOFLGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5B0AC30", Offset = "0x5B09C30", VA = "0x185B0AC30", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5B0ADF0", Offset = "0x5B09DF0", VA = "0x185B0ADF0")]
	public CKLPLBCNDBH(List<CBCNANMJICB> JMPPEBOMNEP, List<CBCNANMJICB> MKCFCDNMDFN, List<NECAAJONGCL> PAGMHKADCCL, Material IMPAAPCBNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B0ACE0", Offset = "0x5B09CE0", VA = "0x185B0ACE0")]
	private int PFCGMANFCAA(List<CBCNANMJICB> BFHINHGMNBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B0AAE0", Offset = "0x5B09AE0", VA = "0x185B0AAE0")]
	private void IMNLGCGJCNJ(int AKKIKBGNCMM, bool CJONJKNGENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A8D0", Offset = "0x5B098D0", VA = "0x185B0A8D0")]
	public void DBOBELLNLFG(Vector3 AFNNDEBMLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A970", Offset = "0x5B09970", VA = "0x185B0A970", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B0AAA0", Offset = "0x5B09AA0", VA = "0x185B0AAA0")]
	public void EOGAHJIOGIE(Transform IDEDOOPNBHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KAEDHBMDOGC : ONOJJMODHGP, DFBPAAJHDPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PKGGOBJKJFC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KAEDHBMDOGC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E90", Offset = "0x8E2E90", VA = "0x1808E3E90")]
		[DebuggerHidden]
		public PKGGOBJKJFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5B116A0", Offset = "0x5B106A0", VA = "0x185B116A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5B11170", Offset = "0x5B10170", VA = "0x185B11170", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B117A0", Offset = "0x5B107A0", VA = "0x185B117A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5B117F0", Offset = "0x5B107F0", VA = "0x185B117F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B11840", Offset = "0x5B10840", VA = "0x185B11840")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B11660", Offset = "0x5B10660", VA = "0x185B11660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5B115C0", Offset = "0x5B105C0", VA = "0x185B115C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B115C0", Offset = "0x5B105C0", VA = "0x185B115C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IGIMLEKJLLM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KAEDHBMDOGC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E90", Offset = "0x8E2E90", VA = "0x1808E3E90")]
		[DebuggerHidden]
		public IGIMLEKJLLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F870", Offset = "0x5B0E870", VA = "0x185B0F870", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F4B0", Offset = "0x5B0E4B0", VA = "0x185B0F4B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F950", Offset = "0x5B0E950", VA = "0x185B0F950")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F9A0", Offset = "0x5B0E9A0", VA = "0x185B0F9A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F830", Offset = "0x5B0E830", VA = "0x185B0F830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F790", Offset = "0x5B0E790", VA = "0x185B0F790", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F790", Offset = "0x5B0E790", VA = "0x185B0F790", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly GPBFABPKGJB DAOBFAHMFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<EMBMAIHHDCA> ALEBIABAGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> DBDAMEINPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer JFFDJLBECPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool ALPHPOGJAPG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<ACBOCPDLAKE> KAMFAKMGEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PBKAJLNPACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FE90", Offset = "0x5B0EE90", VA = "0x185B0FE90", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NECAAJONGCL JHNMGANNPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B10EE0", Offset = "0x5B0FEE0", VA = "0x185B10EE0", Slot = "7")]
		get
		{
			return default(NECAAJONGCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> IKPCNBFLLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D570", VA = "0x18065E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D590", VA = "0x18065E590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B10FB0", Offset = "0x5B0FFB0", VA = "0x185B10FB0")]
	public KAEDHBMDOGC(GPBFABPKGJB JANIFNADDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B0FDF0", Offset = "0x5B0EDF0", VA = "0x185B0FDF0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B10030", Offset = "0x5B0F030", VA = "0x185B10030")]
	public void HEFJCCLOLGO(EMBMAIHHDCA OJNGAEAKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B0FD80", Offset = "0x5B0ED80", VA = "0x185B0FD80")]
	public void AKJLIPOIGHF(EMBMAIHHDCA OJNGAEAKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5B10970", Offset = "0x5B0F970", VA = "0x185B10970", Slot = "4")]
	public void KIMLPJMNKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5B10330", Offset = "0x5B0F330", VA = "0x185B10330")]
	public void JBCFLHJDAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5B10140", Offset = "0x5B0F140", VA = "0x185B10140")]
	private void HJHOHMKENNM(List<EMBMAIHHDCA> ALEBIABAGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5B0FE20", Offset = "0x5B0EE20", VA = "0x185B0FE20")]
	private static Material FADMAOEJNMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5B10270", Offset = "0x5B0F270", VA = "0x185B10270")]
	private void HJHOHMKENNM(EMBMAIHHDCA OJNGAEAKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B0FF60", Offset = "0x5B0EF60", VA = "0x185B0FF60")]
	private void FKNOOMEGGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B10450", Offset = "0x5B0F450", VA = "0x185B10450")]
	public void KFODGELOGEL(bool LBOMPECJDDF, bool KFLCEOEPLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B0FED0", Offset = "0x5B0EED0", VA = "0x185B0FED0")]
	protected void FJGIDBDBLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B102C0", Offset = "0x5B0F2C0", VA = "0x185B102C0")]
	[IteratorStateMachine(typeof(PKGGOBJKJFC))]
	public IEnumerable<Renderer> IKJAEGANABH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B103E0", Offset = "0x5B0F3E0", VA = "0x185B103E0")]
	[IteratorStateMachine(typeof(IGIMLEKJLLM))]
	public IEnumerable<Renderer> KECBIKLPPHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class BPNMLMLPDAK : EMBMAIHHDCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly GGOPFJGGNDJ JJKFMGLFJAH;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5B07320", Offset = "0x5B06320", VA = "0x185B07320")]
	public BPNMLMLPDAK(KAEDHBMDOGC KOJLKBNIDFO, GGOPFJGGNDJ JANIFNADDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5B07130", Offset = "0x5B06130", VA = "0x185B07130", Slot = "13")]
	public override int PFCGMANFCAA(CGGDHFKEBKC DGNFKMOFJKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5B06870", Offset = "0x5B05870", VA = "0x185B06870", Slot = "14")]
	public override int CJDKPMOGAGN(CGGDHFKEBKC DGNFKMOFJKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5B06A60", Offset = "0x5B05A60", VA = "0x185B06A60", Slot = "15")]
	public override void MBNGCEHNOLO(CGGDHFKEBKC DGNFKMOFJKN, LPHIFDNBAIG FINKDHKFDHL, int FMPHCAKJFLG = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BMPBKCLLOCB : global::OCGKPONDJPA<BMPBKCLLOCB>, GPAFGALANDE, IEquatable<BMPBKCLLOCB>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KIJOKCLKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x708D90", Offset = "0x707D90", VA = "0x180708D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B0600", Offset = "0x8AF600", VA = "0x1808B0600", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xEAA480", Offset = "0xEA9480", VA = "0x180EAA480", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5B06480", Offset = "0x5B05480", VA = "0x185B06480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F600", Offset = "0x2C3E600", VA = "0x182C3F600", Slot = "8")]
	public bool Equals(BMPBKCLLOCB HNOJKNGFFBE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD9E150", Offset = "0xD9D150", VA = "0x180D9E150")]
	public static bool CJJJLAGEFIA(BMPBKCLLOCB BMPDKJEHGIN, BMPBKCLLOCB BMMLDIMMAAK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x46CB530", Offset = "0x46CA530", VA = "0x1846CB530")]
	public static bool HNHKEOFMCPG(BMPBKCLLOCB BMPDKJEHGIN, BMPBKCLLOCB BMMLDIMMAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B063F0", Offset = "0x5B053F0", VA = "0x185B063F0", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FMLCENKEABN
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
public interface GPBFABPKGJB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NECAAJONGCL GEEJJOEIINC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FMLCENKEABN IDDOJKEAGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MDLKGIIFKNI : global::OCGKPONDJPA<MDLKGIIFKNI>, GPAFGALANDE, IEquatable<MDLKGIIFKNI>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int KIJOKCLKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x708D90", Offset = "0x707D90", VA = "0x180708D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8B0600", Offset = "0x8AF600", VA = "0x1808B0600", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xEAA480", Offset = "0xEA9480", VA = "0x180EAA480", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5B11130", Offset = "0x5B10130", VA = "0x185B11130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F600", Offset = "0x2C3E600", VA = "0x182C3F600", Slot = "8")]
	public bool Equals(MDLKGIIFKNI HNOJKNGFFBE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xD9E150", Offset = "0xD9D150", VA = "0x180D9E150")]
	public static bool CJJJLAGEFIA(MDLKGIIFKNI BMPDKJEHGIN, MDLKGIIFKNI BMMLDIMMAAK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x46CB530", Offset = "0x46CA530", VA = "0x1846CB530")]
	public static bool HNHKEOFMCPG(MDLKGIIFKNI BMPDKJEHGIN, MDLKGIIFKNI BMMLDIMMAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5B110A0", Offset = "0x5B100A0", VA = "0x185B110A0", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MEBOBDBJAFG
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	NECAAJONGCL GEEJJOEIINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float PPPFLAPHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 EPFLGGIADBG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MGEFPCNKMIB NKOLCGOGNEF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	HNKHNOJCOFP KJNLPKCGBCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NCILFKLLHIP : MEBOBDBJAFG
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FDFGNCIOBBG GOPGDOFPKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool ODCAAPJKHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GGOPFJGGNDJ : MEBOBDBJAFG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BIPIDANGNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FKIKKPGIGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float MLHFFDFFAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int FIKMLNDEAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool PPJMPLPOAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int CAJMENNDFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<BDOLKKENBFA> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MKOMGJIGEBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGPNILOPFIL(BMPBKCLLOCB KOJLKBNIDFO, DKODOLBCJOB JHKPEMKDAGI);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGPNILOPFIL(MDLKGIIFKNI OJNGAEAKOOD, DKODOLBCJOB JHKPEMKDAGI);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCNLKNMELJC(MDLKGIIFKNI OJNGAEAKOOD);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EGAGOGKLMJM(MDLKGIIFKNI OJNGAEAKOOD);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFAKEIPEMJL();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AIOLCCBKIHD();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AICMCELKEJC(DKODOLBCJOB NKICFHCCMMH);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FJHFLAJBPEB(BMPBKCLLOCB KOJLKBNIDFO);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FJHFLAJBPEB(MDLKGIIFKNI OJNGAEAKOOD);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OMMAOJBBFML(BMPBKCLLOCB KOJLKBNIDFO, JMKIMCMCJGJ NKICFHCCMMH);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OMMAOJBBFML(MDLKGIIFKNI OJNGAEAKOOD, JMKIMCMCJGJ NKICFHCCMMH);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ONFFOOCEDFG(MDLKGIIFKNI OJNGAEAKOOD);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BOFPNNFIPIH(MDLKGIIFKNI OJNGAEAKOOD);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GEOMFOBMLFG();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EANIADFCFBD();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IONOAMOHNFB(JMKIMCMCJGJ NKICFHCCMMH);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NEDDICOECEE(BMPBKCLLOCB KOJLKBNIDFO, Vector3 OFOHJPDDLKG, Vector3 CFKBGCHBMBE, Vector3 FIHJPFLAHDO, float DCEOOBOPLIL, float BOKNAKNKNLB, IReadOnlyList<Camera> IAOKPBOMHAF, CJJFHIJKLJN MHAKPPNPBNK);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NEDDICOECEE(GFACJKGLMFM ENINECENGCD, Vector3 OFOHJPDDLKG, Vector3 CFKBGCHBMBE, Vector3 FIHJPFLAHDO, float DCEOOBOPLIL, float BOKNAKNKNLB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AJIFNFCMPCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMPBKCLLOCB NNPGGCABMNI(GPBFABPKGJB JANIFNADDOP);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKPGFNFHGMF(BMPBKCLLOCB KOJLKBNIDFO);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOJLDHLNLKC(BMPBKCLLOCB KOJLKBNIDFO);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MDLKGIIFKNI CFOFDDPIGDD(BMPBKCLLOCB KOJLKBNIDFO, NCILFKLLHIP JANIFNADDOP);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MDLKGIIFKNI OCGJDKLFMMN(BMPBKCLLOCB KOJLKBNIDFO, GGOPFJGGNDJ JANIFNADDOP);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GFFOICBGCAM(MDLKGIIFKNI OJNGAEAKOOD);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LCFALFOGCCH(MDLKGIIFKNI OJNGAEAKOOD);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GFACJKGLMFM OGPDEAANKJA(DEKHKHEBJEO JANIFNADDOP);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GJMHLKIDAAE(GFACJKGLMFM ENINECENGCD);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HHGJKPPHHLN(GFACJKGLMFM ENINECENGCD);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FGBHHFNILHF HMCCCJJDPFK(NECAAJONGCL HPNHPIKEOHF, IEnumerable<MDLKGIIFKNI> ALEBIABAGDJ, int JDLENLNFLBJ);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> IKJLLKPLPAD(BMPBKCLLOCB KOJLKBNIDFO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct GFACJKGLMFM : global::OCGKPONDJPA<GFACJKGLMFM>, GPAFGALANDE, IEquatable<GFACJKGLMFM>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int KIJOKCLKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x708D90", Offset = "0x707D90", VA = "0x180708D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8B0600", Offset = "0x8AF600", VA = "0x1808B0600", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xEAA480", Offset = "0xEA9480", VA = "0x180EAA480", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5B0DC90", Offset = "0x5B0CC90", VA = "0x185B0DC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F600", Offset = "0x2C3E600", VA = "0x182C3F600", Slot = "8")]
	public bool Equals(GFACJKGLMFM HNOJKNGFFBE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xD9E150", Offset = "0xD9D150", VA = "0x180D9E150")]
	public static bool CJJJLAGEFIA(GFACJKGLMFM BMPDKJEHGIN, GFACJKGLMFM BMMLDIMMAAK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x46CB530", Offset = "0x46CA530", VA = "0x1846CB530")]
	public static bool HNHKEOFMCPG(GFACJKGLMFM BMPDKJEHGIN, GFACJKGLMFM BMMLDIMMAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5B0DC00", Offset = "0x5B0CC00", VA = "0x185B0DC00", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DEKHKHEBJEO
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int JGBCBBCLIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform KIPJGEGODLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool MBPDHJHJFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMPBKCLLOCB GetBone(int HBBCNOKMOMD);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int HBBCNOKMOMD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class IADCKMCIEBI : EMBMAIHHDCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly NCILFKLLHIP PHLKHINKKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] BJPOEGIOHHM;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override MLCJACEFBLD CPFBDCCLABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5B0E7E0", Offset = "0x5B0D7E0", VA = "0x185B0E7E0", Slot = "12")]
		get
		{
			return default(MLCJACEFBLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 OGFONIJMOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5B0DCD0", Offset = "0x5B0CCD0", VA = "0x185B0DCD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5B07320", Offset = "0x5B06320", VA = "0x185B07320")]
	public IADCKMCIEBI(KAEDHBMDOGC KOJLKBNIDFO, NCILFKLLHIP JANIFNADDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E370", Offset = "0x5B0D370", VA = "0x185B0E370", Slot = "11")]
	public override bool GKJIBCLHDLP(NECAAJONGCL KOJLKBNIDFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F400", Offset = "0x5B0E400", VA = "0x185B0F400", Slot = "13")]
	public override int PFCGMANFCAA(CGGDHFKEBKC DGNFKMOFJKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E2C0", Offset = "0x5B0D2C0", VA = "0x185B0E2C0", Slot = "14")]
	public override int CJDKPMOGAGN(CGGDHFKEBKC DGNFKMOFJKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E010", Offset = "0x5B0D010", VA = "0x185B0E010")]
	private int BIOIHBOHNKO(CGGDHFKEBKC DGNFKMOFJKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5B0EB90", Offset = "0x5B0DB90", VA = "0x185B0EB90", Slot = "15")]
	public override void MBNGCEHNOLO(CGGDHFKEBKC DGNFKMOFJKN, LPHIFDNBAIG FINKDHKFDHL, int FMPHCAKJFLG = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FBIMDHJFLFJ
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGAENAJGNGA(JMKIMCMCJGJ NKICFHCCMMH, Renderer LDHLNCMNAJI, int PDOEHENLPBD);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAJNOGEMNHM(Renderer LDHLNCMNAJI, CJJFHIJKLJN MHAKPPNPBNK, Vector3 OFOHJPDDLKG, Vector3 CFKBGCHBMBE, Vector3 FIHJPFLAHDO, float DCEOOBOPLIL, float BOKNAKNKNLB, float CJGLADABEMF = -1f, [Optional] Color? OODGAOEPCCI, [Optional] IReadOnlyList<Camera> IGFJDKEDKGJ);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBDLMOKKJFE(Renderer LDHLNCMNAJI, int PDOEHENLPBD);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NDNAFJAOJNB();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPEMFNICBJL(int LOCFJBPAGJD, DKODOLBCJOB NKICFHCCMMH, Renderer LDHLNCMNAJI, int PDOEHENLPBD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CGFFIPLEODP : MKOMGJIGEBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class LCAEHAAMNLG : global::GODDKCPEING<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5B11050", Offset = "0x5B10050", VA = "0x185B11050")]
		public LCAEHAAMNLG(string BEMAPDNKPAD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly FBIMDHJFLFJ MGOMHFMCCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly LEAIECGJKIL HPGPENAELBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer MLEBPHDFLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private LCAEHAAMNLG JIPNPHIDABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool AGLNJEDMFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer LAONFHNKAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private LCAEHAAMNLG FHGKGNJKKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool NOFFPBPNDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer AANPBLBNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private LCAEHAAMNLG BKHCCDPHNBL;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6576E0", Offset = "0x6566E0", VA = "0x1806576E0")]
	public CGFFIPLEODP(FBIMDHJFLFJ DBGKMDEIJJM, LEAIECGJKIL HPGPENAELBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5B08A50", Offset = "0x5B07A50", VA = "0x185B08A50", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B09FE0", Offset = "0x5B08FE0", VA = "0x185B09FE0")]
	private void OALMDEONHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5B09360", Offset = "0x5B08360", VA = "0x185B09360", Slot = "4")]
	public void HGPNILOPFIL(BMPBKCLLOCB KOJLKBNIDFO, DKODOLBCJOB JHKPEMKDAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5B09560", Offset = "0x5B08560", VA = "0x185B09560", Slot = "5")]
	public void HGPNILOPFIL(MDLKGIIFKNI OJNGAEAKOOD, DKODOLBCJOB JHKPEMKDAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5B08D40", Offset = "0x5B07D40", VA = "0x185B08D40", Slot = "6")]
	public void FCNLKNMELJC(MDLKGIIFKNI OJNGAEAKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5B08C20", Offset = "0x5B07C20", VA = "0x185B08C20", Slot = "7")]
	public void EGAGOGKLMJM(MDLKGIIFKNI OJNGAEAKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A7C0", Offset = "0x5B097C0", VA = "0x185B0A7C0", Slot = "8")]
	public void PFAKEIPEMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1612140", Offset = "0x1611140", VA = "0x181612140", Slot = "9")]
	public void AIOLCCBKIHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B08690", Offset = "0x5B07690", VA = "0x185B08690", Slot = "10")]
	public void AICMCELKEJC(DKODOLBCJOB JHKPEMKDAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B09170", Offset = "0x5B08170", VA = "0x185B09170", Slot = "11")]
	public void FJHFLAJBPEB(BMPBKCLLOCB KOJLKBNIDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5B08E70", Offset = "0x5B07E70", VA = "0x185B08E70", Slot = "12")]
	public void FJHFLAJBPEB(MDLKGIIFKNI OJNGAEAKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A1E0", Offset = "0x5B091E0", VA = "0x185B0A1E0", Slot = "13")]
	public void OMMAOJBBFML(BMPBKCLLOCB KOJLKBNIDFO, JMKIMCMCJGJ NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A560", Offset = "0x5B09560", VA = "0x185B0A560", Slot = "14")]
	public void OMMAOJBBFML(MDLKGIIFKNI OJNGAEAKOOD, JMKIMCMCJGJ NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5B09320", Offset = "0x5B08320", VA = "0x185B09320", Slot = "17")]
	public void GEOMFOBMLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A720", Offset = "0x5B09720", VA = "0x185B0A720", Slot = "15")]
	public void ONFFOOCEDFG(MDLKGIIFKNI OJNGAEAKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5B087C0", Offset = "0x5B077C0", VA = "0x185B087C0", Slot = "16")]
	public void BOFPNNFIPIH(MDLKGIIFKNI OJNGAEAKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1192F90", Offset = "0x1191F90", VA = "0x181192F90", Slot = "18")]
	public void EANIADFCFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5B09740", Offset = "0x5B08740", VA = "0x185B09740", Slot = "19")]
	public void IONOAMOHNFB(JMKIMCMCJGJ NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B08850", Offset = "0x5B07850", VA = "0x185B08850")]
	private void CPNKLNLKFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A3A0", Offset = "0x5B093A0", VA = "0x185B0A3A0")]
	public void OMMAOJBBFML(MDLKGIIFKNI OJNGAEAKOOD, JMKIMCMCJGJ NKICFHCCMMH, bool NEHLFFAOHOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A800", Offset = "0x5B09800", VA = "0x185B0A800")]
	private void PGAENAJGNGA(JMKIMCMCJGJ NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B09840", Offset = "0x5B08840", VA = "0x185B09840", Slot = "20")]
	public void NEDDICOECEE(BMPBKCLLOCB KOJLKBNIDFO, Vector3 OFOHJPDDLKG, Vector3 CFKBGCHBMBE, Vector3 FIHJPFLAHDO, float DCEOOBOPLIL, float BOKNAKNKNLB, IReadOnlyList<Camera> IAOKPBOMHAF, CJJFHIJKLJN MHAKPPNPBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B09BC0", Offset = "0x5B08BC0", VA = "0x185B09BC0", Slot = "21")]
	public void NEDDICOECEE(GFACJKGLMFM ENINECENGCD, Vector3 OFOHJPDDLKG, Vector3 CFKBGCHBMBE, Vector3 FIHJPFLAHDO, float DCEOOBOPLIL, float BOKNAKNKNLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class EMBMAIHHDCA : JFMBPJDJAFM, ACBOCPDLAKE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly KAEDHBMDOGC BPBHOPDAIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	protected Bounds CADLKMNOGHB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds KNBIEKJPLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1183480", Offset = "0x1182480", VA = "0x181183480", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual MLCJACEFBLD CPFBDCCLABP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B220", Offset = "0x5B0A220", VA = "0x185B0B220", Slot = "12")]
		get
		{
			return default(MLCJACEFBLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656F40", VA = "0x180657F40")]
	protected EMBMAIHHDCA(KAEDHBMDOGC KOJLKBNIDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B1B0", Offset = "0x5B0A1B0", VA = "0x185B0B1B0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659D00", VA = "0x18065AD00", Slot = "11")]
	public virtual bool GKJIBCLHDLP(NECAAJONGCL KOJLKBNIDFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int PFCGMANFCAA(CGGDHFKEBKC DGNFKMOFJKN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int CJDKPMOGAGN(CGGDHFKEBKC DGNFKMOFJKN);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void MBNGCEHNOLO(CGGDHFKEBKC DGNFKMOFJKN, LPHIFDNBAIG FINKDHKFDHL, int FMPHCAKJFLG = -1);
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
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5B11890", Offset = "0x5B10890", VA = "0x185B11890")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FDFGNCIOBBG
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class AADNHKECPEE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class INCFPOLNDCO : IEnumerable<CFFLGLGINDE>, IEnumerable, IEnumerator<CFFLGLGINDE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private CFFLGLGINDE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private CFFLGLGINDE System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E90", Offset = "0x8E2E90", VA = "0x1808E3E90")]
		[DebuggerHidden]
		public INCFPOLNDCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F9F0", Offset = "0x5B0E9F0", VA = "0x185B0F9F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FB60", Offset = "0x5B0EB60", VA = "0x185B0FB60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FAD0", Offset = "0x5B0EAD0", VA = "0x185B0FAD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CFFLGLGINDE> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FAD0", Offset = "0x5B0EAD0", VA = "0x185B0FAD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int GGONGPOAJIG = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static CFFLGLGINDE[][] NFGCFDLIHIC;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static ONNJEEOBMIC GPFFIKBMHOF;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static ShapeRendererConfig ILIGNJOMPKE;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader LKEFLCBNIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5B04E60", Offset = "0x5B03E60", VA = "0x185B04E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer GFNFMGFMLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5B04ED0", Offset = "0x5B03ED0", VA = "0x185B04ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5B056D0", Offset = "0x5B046D0", VA = "0x185B056D0")]
	public static Mesh HLMDEELGIPD(FDFGNCIOBBG LAOBCKMNOIM, int DGNFKMOFJKN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5B04E50", Offset = "0x5B03E50", VA = "0x185B04E50")]
	public static int APANPEHENKF(FDFGNCIOBBG LAOBCKMNOIM, int DGNFKMOFJKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B05790", Offset = "0x5B04790", VA = "0x185B05790")]
	public static ONNJEEOBMIC JHCNGPKBJHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5B04F40", Offset = "0x5B03F40", VA = "0x185B04F40")]
	[IteratorStateMachine(typeof(INCFPOLNDCO))]
	private static IEnumerable<CFFLGLGINDE> DBGJLBMIBGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B04FA0", Offset = "0x5B03FA0", VA = "0x185B04FA0")]
	public static CFFLGLGINDE DMCEIMGKGEA(FDFGNCIOBBG LAOBCKMNOIM, int DGNFKMOFJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B058F0", Offset = "0x5B048F0", VA = "0x185B058F0")]
	public static bool JLJIKKANHLN(this FDFGNCIOBBG LAOBCKMNOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B05300", Offset = "0x5B04300", VA = "0x185B05300")]
	public static void EJLANLGBFHF(FDFGNCIOBBG LAOBCKMNOIM, float3 KCJGGKKJAJA, out ADDACGMIHHN DCACEFNGMKJ, out float3 MKIEBACHLIB, out float PLNFJDGGHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5B05910", Offset = "0x5B04910", VA = "0x185B05910")]
	public static void OLHPFEHODHF(Vector3 KCJGGKKJAJA, FDFGNCIOBBG LAOBCKMNOIM, out Vector3 MKIEBACHLIB, out float PLNFJDGGHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5B04E40", Offset = "0x5B03E40", VA = "0x185B04E40")]
	[CCHBFIAMMOL(HBPLHMNGKEN.ExitingPlayMode, 0)]
	private static void AGGPKNLAMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5B054B0", Offset = "0x5B044B0", VA = "0x185B054B0")]
	[CCHBFIAMMOL(HBPLHMNGKEN.ExitingPlayMode, 0)]
	private static void HJOKDILFHNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AMKHMKJNMNF
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool LDHNNEEDOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material IPGCHIFBDNM();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material FADMAOEJNMC();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material CMEPMDBFMHI();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int AGCJPMKBNKB(MGEFPCNKMIB OKHCMJBGFFN);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NDDOBGFINOG(HNKHNOJCOFP ONNEDKBLJNL);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ACEDNMJBGPK(GameObject CCPIHKCBGHF);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FJDFDPBFOKM(GameObject CCPIHKCBGHF, bool CMCOFBFBOIB);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface LEAIECGJKIL
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KAEDHBMDOGC MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EMBMAIHHDCA MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FNBEHDNPKBE MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class FMKOKPKBFFA : AJIFNFCMPCJ, IDisposable, LEAIECGJKIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly global::OHAJLNOFLKM<BMPBKCLLOCB, KAEDHBMDOGC> EINOFMLPJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly global::OHAJLNOFLKM<MDLKGIIFKNI, EMBMAIHHDCA> ALEBIABAGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly global::OHAJLNOFLKM<GFACJKGLMFM, FNBEHDNPKBE> DGLOOMOOJHB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static AMKHMKJNMNF HHFFCMKJNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B2B0", Offset = "0x5B0A2B0", VA = "0x185B0B2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B2F0", Offset = "0x5B0A2F0", VA = "0x185B0B2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public KAEDHBMDOGC MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5B0BC70", Offset = "0x5B0AC70", VA = "0x185B0BC70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public EMBMAIHHDCA MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5B0BC10", Offset = "0x5B0AC10", VA = "0x185B0BC10", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public FNBEHDNPKBE MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5B0BBB0", Offset = "0x5B0ABB0", VA = "0x185B0BBB0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C0F0", Offset = "0x5B0B0F0", VA = "0x185B0C0F0")]
	public FMKOKPKBFFA(AMKHMKJNMNF DBGKMDEIJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B450", Offset = "0x5B0A450", VA = "0x185B0B450", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BD40", Offset = "0x5B0AD40", VA = "0x185B0BD40", Slot = "4")]
	public BMPBKCLLOCB NNPGGCABMNI(GPBFABPKGJB JANIFNADDOP)
	{
		return default(BMPBKCLLOCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B5A0", Offset = "0x5B0A5A0", VA = "0x185B0B5A0", Slot = "5")]
	public void GKPGFNFHGMF(BMPBKCLLOCB KOJLKBNIDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BB30", Offset = "0x5B0AB30", VA = "0x185B0BB30", Slot = "6")]
	public void JOJLDHLNLKC(BMPBKCLLOCB KOJLKBNIDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BA70", Offset = "0x5B0AA70", VA = "0x185B0BA70", Slot = "15")]
	public IEnumerable<Renderer> IKJLLKPLPAD(BMPBKCLLOCB KOJLKBNIDFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B340", Offset = "0x5B0A340", VA = "0x185B0B340", Slot = "7")]
	public MDLKGIIFKNI CFOFDDPIGDD(BMPBKCLLOCB KOJLKBNIDFO, NCILFKLLHIP JANIFNADDOP)
	{
		return default(MDLKGIIFKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BE40", Offset = "0x5B0AE40", VA = "0x185B0BE40", Slot = "8")]
	public MDLKGIIFKNI OCGJDKLFMMN(BMPBKCLLOCB KOJLKBNIDFO, GGOPFJGGNDJ JANIFNADDOP)
	{
		return default(MDLKGIIFKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BCD0", Offset = "0x5B0ACD0", VA = "0x185B0BCD0", Slot = "10")]
	public void LCFALFOGCCH(MDLKGIIFKNI OJNGAEAKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B4E0", Offset = "0x5B0A4E0", VA = "0x185B0B4E0", Slot = "9")]
	public void GFFOICBGCAM(MDLKGIIFKNI OJNGAEAKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BF50", Offset = "0x5B0AF50", VA = "0x185B0BF50", Slot = "11")]
	public GFACJKGLMFM OGPDEAANKJA(DEKHKHEBJEO JANIFNADDOP)
	{
		return default(GFACJKGLMFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B600", Offset = "0x5B0A600", VA = "0x185B0B600", Slot = "13")]
	public void HHGJKPPHHLN(GFACJKGLMFM ENINECENGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B540", Offset = "0x5B0A540", VA = "0x185B0B540", Slot = "12")]
	public void GJMHLKIDAAE(GFACJKGLMFM ENINECENGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B670", Offset = "0x5B0A670", VA = "0x185B0B670", Slot = "14")]
	public FGBHHFNILHF HMCCCJJDPFK(NECAAJONGCL HPNHPIKEOHF, IEnumerable<MDLKGIIFKNI> ALEBIABAGDJ, int JDLENLNFLBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FNBEHDNPKBE : ONOJJMODHGP
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BOKHFHJHNIH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public FNBEHDNPKBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E90", Offset = "0x8E2E90", VA = "0x1808E3E90")]
		[DebuggerHidden]
		public BOKHFHJHNIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5B067A0", Offset = "0x5B057A0", VA = "0x185B067A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5B064C0", Offset = "0x5B054C0", VA = "0x185B064C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5B06820", Offset = "0x5B05820", VA = "0x185B06820")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5B06760", Offset = "0x5B05760", VA = "0x185B06760", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5B066C0", Offset = "0x5B056C0", VA = "0x185B066C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B066C0", Offset = "0x5B056C0", VA = "0x185B066C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly DEKHKHEBJEO NCADPEEEPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly LEAIECGJKIL HPGPENAELBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private CKLPLBCNDBH HPMFBFJLOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private List<CBCNANMJICB> FIEDKKMJKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private List<CBCNANMJICB> BJACNCDJLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private GameObject HLODNHBFCLN;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D990", Offset = "0x5B0C990", VA = "0x185B0D990")]
	public static FNBEHDNPKBE PDBMDCGGLNI(DEKHKHEBJEO JANIFNADDOP, LEAIECGJKIL HPGPENAELBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5B0DB00", Offset = "0x5B0CB00", VA = "0x185B0DB00")]
	private FNBEHDNPKBE(DEKHKHEBJEO JANIFNADDOP, LEAIECGJKIL HPGPENAELBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C640", Offset = "0x5B0B640", VA = "0x185B0C640")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CBC0", Offset = "0x5B0BBC0", VA = "0x185B0CBC0")]
	[IteratorStateMachine(typeof(BOKHFHJHNIH))]
	public IEnumerable<Renderer> IKJAEGANABH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CE70", Offset = "0x5B0BE70", VA = "0x185B0CE70", Slot = "4")]
	public void KIMLPJMNKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CB20", Offset = "0x5B0BB20", VA = "0x185B0CB20")]
	private void IFIHAIHIMFF(Vector3 AFNNDEBMLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CC30", Offset = "0x5B0BC30", VA = "0x185B0CC30")]
	public void JBCFLHJDAGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CBCNANMJICB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct MGLNCOBJHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public LPHIFDNBAIG COAHMAHENPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public NECAAJONGCL EFJOALFMCKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int HBJKFMEMJPA;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class JMAPCOKJGPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public CBCNANMJICB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CGGDHFKEBKC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public List<MGLNCOBJHKP> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public FGBHHFNILHF combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public JMAPCOKJGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FBA0", Offset = "0x5B0EBA0", VA = "0x185B0FBA0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FC00", Offset = "0x5B0EC00", VA = "0x185B0FC00")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FC30", Offset = "0x5B0EC30", VA = "0x185B0FC30")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private int[] GOBMBFDNFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private BCFLAMMDJKJ GHPNNPPJDIA;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static Matrix4x4 IGEILACLFND;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh IHNGPENLHJF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x676130", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int KAGHDBEPHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x657BD0", VA = "0x180658BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB410", Offset = "0x6FA410", VA = "0x1806FB410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5B07B40", Offset = "0x5B06B40", VA = "0x185B07B40")]
	public void GHDFEGICFGH(List<NECAAJONGCL> IEKBPIFIEOM, Matrix4x4[] BLEAFAMMJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5B07370", Offset = "0x5B06370", VA = "0x185B07370")]
	public static List<CBCNANMJICB> DAKLFHBAJIH(List<KAEDHBMDOGC> MFKFNNGJPIM, CGGDHFKEBKC DGNFKMOFJKN, Bounds HEICMLFEKLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5B07D70", Offset = "0x5B06D70", VA = "0x185B07D70")]
	private JobHandle GOGCIPIKCJA(FGBHHFNILHF IOIGJGHGDGD, int JNLEFOCOCCP, int FKLMDLIDEAH, CGGDHFKEBKC DGNFKMOFJKN, List<MGLNCOBJHKP> PFJIBGICKHG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5B07A30", Offset = "0x5B06A30", VA = "0x185B07A30")]
	private void FLKGEBBKNIM(List<MGLNCOBJHKP> PFJIBGICKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5B08280", Offset = "0x5B07280", VA = "0x185B08280")]
	private CBCNANMJICB(List<MGLNCOBJHKP> PFJIBGICKHG, int JNLEFOCOCCP, int FKLMDLIDEAH, CGGDHFKEBKC DGNFKMOFJKN, Bounds HEICMLFEKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5B079A0", Offset = "0x5B069A0", VA = "0x185B079A0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private MaterialPropertyBlock OOJFGNJEBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private CBCNANMJICB CNMNFNJMBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private List<NECAAJONGCL> PAGMHKADCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private RenderTexture IACKACCNCGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private ComputeBuffer LLMPKCFHPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private ComputeShader IIPIMNPODDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private Matrix4x4[] OJMGMIHFHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int GDFMBOJIKLD;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer GGPMENBCPCA
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x676140", VA = "0x180677140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int JGBCBBCLIPI
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x5B12550", Offset = "0x5B11550", VA = "0x185B12550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5B118C0", Offset = "0x5B108C0", VA = "0x185B118C0")]
		public static List<SkinnedShapeRenderer> Create(GameObject KOJLKBNIDFO, List<CBCNANMJICB> BFHINHGMNBP, List<NECAAJONGCL> PAGMHKADCCL, Material IMPAAPCBNPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5B11CD0", Offset = "0x5B10CD0", VA = "0x185B11CD0")]
		public void Init(CBCNANMJICB CNMNFNJMBFD, List<NECAAJONGCL> PAGMHKADCCL, Material IMPAAPCBNPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5B124A0", Offset = "0x5B114A0", VA = "0x185B124A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5B123F0", Offset = "0x5B113F0", VA = "0x185B123F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5B123B0", Offset = "0x5B113B0", VA = "0x185B123B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5B12180", Offset = "0x5B11180", VA = "0x185B12180")]
		private void LCMAPNKGNEO(ScriptableRenderContext NAHJDDBGMOA, Camera[] CIFBKGOHJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5B11B10", Offset = "0x5B10B10", VA = "0x185B11B10")]
		private void GHDFEGICFGH(CommandBuffer HCEGEPHPFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5B05D60", Offset = "0x5B04D60", VA = "0x185B05D60")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5B05E70", Offset = "0x5B04E70", VA = "0x185B05E70")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
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
