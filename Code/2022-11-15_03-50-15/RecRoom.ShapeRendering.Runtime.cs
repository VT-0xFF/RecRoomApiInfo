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
public enum LCCJIDMGBBG
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
public static class MNGBABEGIEK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BAE680", Offset = "0x5BAD080", VA = "0x185BAE680")]
	public static bool LMHIGIBNBLL(this LCCJIDMGBBG GHGDFMPLIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BAE6A0", Offset = "0x5BAD0A0", VA = "0x185BAE6A0")]
	public static bool MBJPFGCBFPN(this LCCJIDMGBBG GHGDFMPLIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BAE650", Offset = "0x5BAD050", VA = "0x185BAE650")]
	public static bool JALIGLFPCOM(this LCCJIDMGBBG GHGDFMPLIOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LHEJCNLGNOE
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
public enum MOBKLBPNDHO
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
public enum DCHPDKAOPMK
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
public enum DINGDHLILGP
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
public class FPGCEICPPFF : KPICLELKMBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte ELDODGGLFOJ = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte OAIKBDBHILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] CGPGENGPNHA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AMOAIOLBDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E5670", Offset = "0x6E4070", VA = "0x1806E5670", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E5970", Offset = "0x6E4370", VA = "0x1806E5970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CBHLINEHCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA78EF0", Offset = "0xA778F0", VA = "0x180A78EF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1004F30", Offset = "0x1003930", VA = "0x181004F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float MMGPEKNIPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69F9D0", Offset = "0x69E3D0", VA = "0x18069F9D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69FAE0", Offset = "0x69E4E0", VA = "0x18069FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DHLDEEEEGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69F970", Offset = "0x69E370", VA = "0x18069F970", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69FD20", Offset = "0x69E720", VA = "0x18069FD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> KAKMKAHLBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA7B0", Offset = "0x5BA91B0", VA = "0x185BAA7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> KFPGHOCAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x579C4E0", Offset = "0x579AEE0", VA = "0x18579C4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject OBODCAIPJIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7939F0", Offset = "0x7923F0", VA = "0x1807939F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte OAFAMDDBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA330", Offset = "0x5BA8D30", VA = "0x185BAA330", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA850", Offset = "0x5BA9250", VA = "0x185BAA850")]
	public FPGCEICPPFF(List<OKAIIJDDGOF> LGFLFNJLOEL, List<OKAIIJDDGOF> MMHIPIHJIKO, List<BKOCAKKCKCA> EPLPEHGIPJM, Material AJAKNINAIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA380", Offset = "0x5BA8D80", VA = "0x185BAA380")]
	private int CFCOMADFHOB(List<OKAIIJDDGOF> LLPKMCFLEFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA490", Offset = "0x5BA8E90", VA = "0x185BAA490")]
	private void DNEALCIHONP(int PADINDJLKLA, bool BGGOFFFFDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA710", Offset = "0x5BA9110", VA = "0x185BAA710")]
	public void GBJLDGLGHLJ(Vector3 DENDMCAONEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA5E0", Offset = "0x5BA8FE0", VA = "0x185BAA5E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA810", Offset = "0x5BA9210", VA = "0x185BAA810")]
	public void OHBGKHBILLB(Transform ANAHHHBFECN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KBEMDCDGAOC : JPBLLJNBKGK, NPMOOKFNAGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HBDPLFKEOGJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KBEMDCDGAOC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
		[DebuggerHidden]
		public HBDPLFKEOGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB480", Offset = "0x5BA9E80", VA = "0x185BAB480", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5BAAF50", Offset = "0x5BA9950", VA = "0x185BAAF50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB580", Offset = "0x5BA9F80", VA = "0x185BAB580")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB5D0", Offset = "0x5BA9FD0", VA = "0x185BAB5D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB620", Offset = "0x5BAA020", VA = "0x185BAB620")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB440", Offset = "0x5BA9E40", VA = "0x185BAB440", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB3A0", Offset = "0x5BA9DA0", VA = "0x185BAB3A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB3A0", Offset = "0x5BA9DA0", VA = "0x185BAB3A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EHGDHDOGJDN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KBEMDCDGAOC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
		[DebuggerHidden]
		public EHGDHDOGJDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA1B0", Offset = "0x5BA8BB0", VA = "0x185BAA1B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5BA9DF0", Offset = "0x5BA87F0", VA = "0x185BA9DF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA290", Offset = "0x5BA8C90", VA = "0x185BAA290")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA2E0", Offset = "0x5BA8CE0", VA = "0x185BAA2E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA170", Offset = "0x5BA8B70", VA = "0x185BAA170", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA0D0", Offset = "0x5BA8AD0", VA = "0x185BAA0D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA0D0", Offset = "0x5BA8AD0", VA = "0x185BAA0D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly HHBFDMPPKCP EOFFBOLECPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<DMNPMPKMLDN> ALMIICDENJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> LMLMPJIFGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer KHJINFCMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool BOJHPKNLKOF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<EPCJPPBNGIC> BMLDJKDDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GJDODKPCOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5BAD090", Offset = "0x5BABA90", VA = "0x185BAD090", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BKOCAKKCKCA KLHDMKMGLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5BACF50", Offset = "0x5BAB950", VA = "0x185BACF50", Slot = "7")]
		get
		{
			return default(BKOCAKKCKCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> BBIJFJMJEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0AB0", Offset = "0x6AF4B0", VA = "0x1806B0AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8588D0", Offset = "0x8572D0", VA = "0x1808588D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD9D0", Offset = "0x5BAC3D0", VA = "0x185BAD9D0")]
	public KBEMDCDGAOC(HHBFDMPPKCP PJIINDGLAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5BAC9B0", Offset = "0x5BAB3B0", VA = "0x185BAC9B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD0D0", Offset = "0x5BABAD0", VA = "0x185BAD0D0")]
	public void MJIKPLNABDE(DMNPMPKMLDN HEAJFIBKOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD860", Offset = "0x5BAC260", VA = "0x185BAD860")]
	public void OMBMHDCIFDM(DMNPMPKMLDN HEAJFIBKOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5BAC9E0", Offset = "0x5BAB3E0", VA = "0x185BAC9E0", Slot = "4")]
	public void EJOMNGHIOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD920", Offset = "0x5BAC320", VA = "0x185BAD920")]
	public void OPDLCGHKCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5BAC880", Offset = "0x5BAB280", VA = "0x185BAC880")]
	private void DAAFHCKKPML(List<DMNPMPKMLDN> ALMIICDENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5BAC760", Offset = "0x5BAB160", VA = "0x185BAC760")]
	private static Material BMJNHDEMMGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BAC830", Offset = "0x5BAB230", VA = "0x185BAC830")]
	private void DAAFHCKKPML(DMNPMPKMLDN HEAJFIBKOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD270", Offset = "0x5BABC70", VA = "0x185BAD270")]
	private void NOEAHMFABDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD340", Offset = "0x5BABD40", VA = "0x185BAD340")]
	public void OBOBEDPBFCK(bool GECODBNLNCJ, bool FHOCJPAADJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD1E0", Offset = "0x5BABBE0", VA = "0x185BAD1E0")]
	protected void MLGOMMFNKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD020", Offset = "0x5BABA20", VA = "0x185BAD020")]
	[IteratorStateMachine(typeof(HBDPLFKEOGJ))]
	public IEnumerable<Renderer> IGDGCDFJFIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BAC6F0", Offset = "0x5BAB0F0", VA = "0x185BAC6F0")]
	[IteratorStateMachine(typeof(EHGDHDOGJDN))]
	public IEnumerable<Renderer> AHNHBFFHHPF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class PFJKKJJEKDL : DMNPMPKMLDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly DLEJFIGOFGJ CNIDFLMFHEF;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5BB05B0", Offset = "0x5BAEFB0", VA = "0x185BB05B0")]
	public PFJKKJJEKDL(KBEMDCDGAOC JBBMOMLGMKJ, DLEJFIGOFGJ PJIINDGLAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5BAFAA0", Offset = "0x5BAE4A0", VA = "0x185BAFAA0", Slot = "13")]
	public override int CFCOMADFHOB(ELDADGLNPNI HGNNAGKFJJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5BAFC90", Offset = "0x5BAE690", VA = "0x185BAFC90", Slot = "14")]
	public override int CGDDHBNMEPF(ELDADGLNPNI HGNNAGKFJJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5BAFE80", Offset = "0x5BAE880", VA = "0x185BAFE80", Slot = "15")]
	public override void DMANKFKOBDE(ELDADGLNPNI HGNNAGKFJJB, MBCMOPENIMM NNCEECFDAPH, int BLAFPBEKIKE = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HDCDFLOPCLG : global::MDCCNADMIFA<HDCDFLOPCLG>, AMGKOAKLCKE, IEquatable<HDCDFLOPCLG>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int HMIPEGLEEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x760940", Offset = "0x75F340", VA = "0x180760940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int MIEMBAEOINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x18486F0", Offset = "0x18470F0", VA = "0x1818486F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1848730", Offset = "0x1847130", VA = "0x181848730", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool CHKFJDOKALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB670", Offset = "0x5BAA070", VA = "0x185BAB670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x20A5990", Offset = "0x20A4390", VA = "0x1820A5990", Slot = "8")]
	public bool Equals(HDCDFLOPCLG BPKBHFMGOOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x25E96F0", Offset = "0x25E80F0", VA = "0x1825E96F0")]
	public static bool MOBCKBANPBO(HDCDFLOPCLG LDIEPFCHCFG, HDCDFLOPCLG KCHCODPDAGF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x434D3E0", Offset = "0x434BDE0", VA = "0x18434D3E0")]
	public static bool DEKNKNJGCDK(HDCDFLOPCLG LDIEPFCHCFG, HDCDFLOPCLG KCHCODPDAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5BAB6B0", Offset = "0x5BAA0B0", VA = "0x185BAB6B0", Slot = "0")]
	public override bool Equals(object PDHKCBEBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5BAB740", Offset = "0x5BAA140", VA = "0x185BAB740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum EDODNCKFCAA
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
public interface HHBFDMPPKCP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BKOCAKKCKCA OCHLAIKCOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	EDODNCKFCAA HCOKKLKPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GFOMFGPCGCF : global::MDCCNADMIFA<GFOMFGPCGCF>, AMGKOAKLCKE, IEquatable<GFOMFGPCGCF>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int HMIPEGLEEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x760940", Offset = "0x75F340", VA = "0x180760940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int MIEMBAEOINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x18486F0", Offset = "0x18470F0", VA = "0x1818486F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1848730", Offset = "0x1847130", VA = "0x181848730", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CHKFJDOKALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5BAAC10", Offset = "0x5BA9610", VA = "0x185BAAC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20A5990", Offset = "0x20A4390", VA = "0x1820A5990", Slot = "8")]
	public bool Equals(GFOMFGPCGCF BPKBHFMGOOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25E96F0", Offset = "0x25E80F0", VA = "0x1825E96F0")]
	public static bool MOBCKBANPBO(GFOMFGPCGCF LDIEPFCHCFG, GFOMFGPCGCF KCHCODPDAGF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x434D3E0", Offset = "0x434BDE0", VA = "0x18434D3E0")]
	public static bool DEKNKNJGCDK(GFOMFGPCGCF LDIEPFCHCFG, GFOMFGPCGCF KCHCODPDAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5BAAC50", Offset = "0x5BA9650", VA = "0x185BAAC50", Slot = "0")]
	public override bool Equals(object PDHKCBEBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5BAACE0", Offset = "0x5BA96E0", VA = "0x185BAACE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HPBGCJHCMJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	BKOCAKKCKCA OCHLAIKCOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float NEPJMKNMMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 CFDNHPCPPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	LCCJIDMGBBG EFNILGEPIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	LHEJCNLGNOE KOKNGLLGKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NOGOBPIONDO : HPBGCJHCMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	GMNPCMPHAIE CFJJEHPOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OLDCKOEFONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DLEJFIGOFGJ : HPBGCJHCMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MILKNFKFIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MJJFOPPPLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float NKKGDKAOHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int NBGPFIBINEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool ICNBOODANLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int AGGPFBBDLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<MMCDDLNMBHF> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ILMHAIDGNBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCJJEALGIGP(HDCDFLOPCLG JBBMOMLGMKJ, DCHPDKAOPMK PPLFDLJGNFN);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCJJEALGIGP(GFOMFGPCGCF HEAJFIBKOHF, DCHPDKAOPMK PPLFDLJGNFN);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDJKBIILMAB(GFOMFGPCGCF HEAJFIBKOHF);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OINDKICCFMK(GFOMFGPCGCF HEAJFIBKOHF);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OOGNFONDMHG();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFBDJLGDJJG();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HLGABJMPBAE(DCHPDKAOPMK NFMPIOLJBMO);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHPIEDMBPCF(HDCDFLOPCLG JBBMOMLGMKJ);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHPIEDMBPCF(GFOMFGPCGCF HEAJFIBKOHF);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HDMCDBCBBFM(HDCDFLOPCLG JBBMOMLGMKJ, DINGDHLILGP NFMPIOLJBMO);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HDMCDBCBBFM(GFOMFGPCGCF HEAJFIBKOHF, DINGDHLILGP NFMPIOLJBMO);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ODKDHMBKMJN(GFOMFGPCGCF HEAJFIBKOHF);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FLABEAAIDMH(GFOMFGPCGCF HEAJFIBKOHF);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FOCMHLNPCAM();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LGOEEGEDLAE();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BHMAIDBKIPG(DINGDHLILGP NFMPIOLJBMO);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EECMHABLJGK(HDCDFLOPCLG JBBMOMLGMKJ, Vector3 LBIBGDOMFJL, Vector3 HJOFEEIMLFF, Vector3 FOJLAOLHCLM, float KOIOFMOLDHL, float OLMKBHLOLOJ, IReadOnlyList<Camera> JOHCICPOLLG, MOBKLBPNDHO GCNPEOLGCAC);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EECMHABLJGK(NOAFFKIANHD LMNHOJFBOKL, Vector3 LBIBGDOMFJL, Vector3 HJOFEEIMLFF, Vector3 FOJLAOLHCLM, float KOIOFMOLDHL, float OLMKBHLOLOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BJMELLEBIEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HDCDFLOPCLG CCNIOCJEIOM(HHBFDMPPKCP PJIINDGLAPJ);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDNIAEJOCEA(HDCDFLOPCLG JBBMOMLGMKJ);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKKLBJJBNBB(HDCDFLOPCLG JBBMOMLGMKJ);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GFOMFGPCGCF OJEIAGFAAAA(HDCDFLOPCLG JBBMOMLGMKJ, NOGOBPIONDO PJIINDGLAPJ);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GFOMFGPCGCF NNIGDJMAPCO(HDCDFLOPCLG JBBMOMLGMKJ, DLEJFIGOFGJ PJIINDGLAPJ);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PNHCECFADFG(GFOMFGPCGCF HEAJFIBKOHF);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DNFBFEGJJCL(GFOMFGPCGCF HEAJFIBKOHF);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NOAFFKIANHD PKEMCELJKKI(EKLOOMFNAPL PJIINDGLAPJ);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CDDOFLDIHHD(NOAFFKIANHD LMNHOJFBOKL);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MIJBBNAFKPO(NOAFFKIANHD LMNHOJFBOKL);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HEIPKPPCIGL EECKLNANPEJ(BKOCAKKCKCA OAINEHDIEDG, IEnumerable<GFOMFGPCGCF> ALMIICDENJN, int GHJPKBBIMLM);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> HDKOPGMBGOB(HDCDFLOPCLG JBBMOMLGMKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NOAFFKIANHD : global::MDCCNADMIFA<NOAFFKIANHD>, AMGKOAKLCKE, IEquatable<NOAFFKIANHD>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int HMIPEGLEEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x760940", Offset = "0x75F340", VA = "0x180760940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int MIEMBAEOINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x18486F0", Offset = "0x18470F0", VA = "0x1818486F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1848730", Offset = "0x1847130", VA = "0x181848730", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CHKFJDOKALL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE6B0", Offset = "0x5BAD0B0", VA = "0x185BAE6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x20A5990", Offset = "0x20A4390", VA = "0x1820A5990", Slot = "8")]
	public bool Equals(NOAFFKIANHD BPKBHFMGOOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x25E96F0", Offset = "0x25E80F0", VA = "0x1825E96F0")]
	public static bool MOBCKBANPBO(NOAFFKIANHD LDIEPFCHCFG, NOAFFKIANHD KCHCODPDAGF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x434D3E0", Offset = "0x434BDE0", VA = "0x18434D3E0")]
	public static bool DEKNKNJGCDK(NOAFFKIANHD LDIEPFCHCFG, NOAFFKIANHD KCHCODPDAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5BAE6F0", Offset = "0x5BAD0F0", VA = "0x185BAE6F0", Slot = "0")]
	public override bool Equals(object PDHKCBEBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EKLOOMFNAPL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int DFFEPAMAKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform KNEPOKLICKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool CFJEBPGEJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HDCDFLOPCLG GetBone(int KCNIBIMHJMC);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int KCNIBIMHJMC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class PKGICEONACI : DMNPMPKMLDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly NOGOBPIONDO EAKGIFAIECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] IFHJEJHPPHA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override AEBNNJHBPKD GOFMIHOIIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5BB0760", Offset = "0x5BAF160", VA = "0x185BB0760", Slot = "12")]
		get
		{
			return default(AEBNNJHBPKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 KHDHOIBDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5BB13F0", Offset = "0x5BAFDF0", VA = "0x185BB13F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5BB05B0", Offset = "0x5BAEFB0", VA = "0x185BB05B0")]
	public PKGICEONACI(KBEMDCDGAOC JBBMOMLGMKJ, NOGOBPIONDO PJIINDGLAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5BB19E0", Offset = "0x5BB03E0", VA = "0x185BB19E0", Slot = "11")]
	public override bool LHOIJCOHLMH(BKOCAKKCKCA JBBMOMLGMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0600", Offset = "0x5BAF000", VA = "0x185BB0600", Slot = "13")]
	public override int CFCOMADFHOB(ELDADGLNPNI HGNNAGKFJJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5BB06B0", Offset = "0x5BAF0B0", VA = "0x185BB06B0", Slot = "14")]
	public override int CGDDHBNMEPF(ELDADGLNPNI HGNNAGKFJJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5BB1730", Offset = "0x5BB0130", VA = "0x185BB1730")]
	private int EKECLAPIOKD(ELDADGLNPNI HGNNAGKFJJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0B10", Offset = "0x5BAF510", VA = "0x185BB0B10", Slot = "15")]
	public override void DMANKFKOBDE(ELDADGLNPNI HGNNAGKFJJB, MBCMOPENIMM NNCEECFDAPH, int BLAFPBEKIKE = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NIABBCJDCEF
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGICBIFGKMA(DINGDHLILGP NFMPIOLJBMO, Renderer FOLNJCJLFAO, int FADFHNFCANM);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIHEGIMEFNB(Renderer FOLNJCJLFAO, MOBKLBPNDHO GCNPEOLGCAC, Vector3 LBIBGDOMFJL, Vector3 HJOFEEIMLFF, Vector3 FOJLAOLHCLM, float KOIOFMOLDHL, float OLMKBHLOLOJ, float GMOCAAEFCBC = -1f, [Optional] Color? FDMANEGJPBO, [Optional] IReadOnlyList<Camera> NBAHAKIONDG);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NFDMOFNCFLJ(Renderer FOLNJCJLFAO, int FADFHNFCANM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GPEENKBFHBM();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJOEGFINMGP(int CCALDALIDEJ, DCHPDKAOPMK NFMPIOLJBMO, Renderer FOLNJCJLFAO, int FADFHNFCANM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BACFGOHDJPI : ILMHAIDGNBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class LOHMMDOFALO : global::MLCFHEFHMJG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE450", Offset = "0x5BACE50", VA = "0x185BAE450")]
		public LOHMMDOFALO(string KKJOOAJGLJI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly NIABBCJDCEF JGJNCOBJKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly NBLLOCBBEBB JNKCCKJAOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer NPKBGMLMLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private LOHMMDOFALO DOLBMCMHGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool NACNFNPLJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer ENFDHAEFNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private LOHMMDOFALO JPIFBNPKDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool PFMCJIAKLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer LCALNGKNGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private LOHMMDOFALO MMADLCLDFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x75DFF0", Offset = "0x75C9F0", VA = "0x18075DFF0")]
	public BACFGOHDJPI(NIABBCJDCEF ANHBHKIAIFF, NBLLOCBBEBB JNKCCKJAOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5BA83A0", Offset = "0x5BA6DA0", VA = "0x185BA83A0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9840", Offset = "0x5BA8240", VA = "0x185BA9840")]
	private void LNIMLLFLPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7CA0", Offset = "0x5BA66A0", VA = "0x185BA7CA0", Slot = "4")]
	public void CCJJEALGIGP(HDCDFLOPCLG JBBMOMLGMKJ, DCHPDKAOPMK PPLFDLJGNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7A80", Offset = "0x5BA6480", VA = "0x185BA7A80", Slot = "5")]
	public void CCJJEALGIGP(GFOMFGPCGCF HEAJFIBKOHF, DCHPDKAOPMK PPLFDLJGNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5BA94C0", Offset = "0x5BA7EC0", VA = "0x185BA94C0", Slot = "6")]
	public void JDJKBIILMAB(GFOMFGPCGCF HEAJFIBKOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9B30", Offset = "0x5BA8530", VA = "0x185BA9B30", Slot = "7")]
	public void OINDKICCFMK(GFOMFGPCGCF HEAJFIBKOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9C50", Offset = "0x5BA8650", VA = "0x185BA9C50", Slot = "8")]
	public void OOGNFONDMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x118F5D0", Offset = "0x118DFD0", VA = "0x18118F5D0", Slot = "9")]
	public void OFBDJLGDJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9350", Offset = "0x5BA7D50", VA = "0x185BA9350", Slot = "10")]
	public void HLGABJMPBAE(DCHPDKAOPMK PPLFDLJGNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5BA81F0", Offset = "0x5BA6BF0", VA = "0x185BA81F0", Slot = "11")]
	public void CHPIEDMBPCF(HDCDFLOPCLG JBBMOMLGMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7EA0", Offset = "0x5BA68A0", VA = "0x185BA7EA0", Slot = "12")]
	public void CHPIEDMBPCF(GFOMFGPCGCF HEAJFIBKOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8DE0", Offset = "0x5BA77E0", VA = "0x185BA8DE0", Slot = "13")]
	public void HDMCDBCBBFM(HDCDFLOPCLG JBBMOMLGMKJ, DINGDHLILGP NFMPIOLJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8FA0", Offset = "0x5BA79A0", VA = "0x185BA8FA0", Slot = "14")]
	public void HDMCDBCBBFM(GFOMFGPCGCF HEAJFIBKOHF, DINGDHLILGP NFMPIOLJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8DA0", Offset = "0x5BA77A0", VA = "0x185BA8DA0", Slot = "17")]
	public void FOCMHLNPCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9A90", Offset = "0x5BA8490", VA = "0x185BA9A90", Slot = "15")]
	public void ODKDHMBKMJN(GFOMFGPCGCF HEAJFIBKOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8D10", Offset = "0x5BA7710", VA = "0x185BA8D10", Slot = "16")]
	public void FLABEAAIDMH(GFOMFGPCGCF HEAJFIBKOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7514F0", Offset = "0x74FEF0", VA = "0x1807514F0", Slot = "18")]
	public void LGOEEGEDLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7940", Offset = "0x5BA6340", VA = "0x185BA7940", Slot = "19")]
	public void BHMAIDBKIPG(DINGDHLILGP NFMPIOLJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5BA95F0", Offset = "0x5BA7FF0", VA = "0x185BA95F0")]
	private void KMHGGPHPFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9190", Offset = "0x5BA7B90", VA = "0x185BA9190")]
	public void HDMCDBCBBFM(GFOMFGPCGCF HEAJFIBKOHF, DINGDHLILGP NFMPIOLJBMO, bool FCBIIEMMEFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7870", Offset = "0x5BA6270", VA = "0x185BA7870")]
	private void AGICBIFGKMA(DINGDHLILGP NFMPIOLJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8570", Offset = "0x5BA6F70", VA = "0x185BA8570", Slot = "20")]
	public void EECMHABLJGK(HDCDFLOPCLG JBBMOMLGMKJ, Vector3 LBIBGDOMFJL, Vector3 HJOFEEIMLFF, Vector3 FOJLAOLHCLM, float KOIOFMOLDHL, float OLMKBHLOLOJ, IReadOnlyList<Camera> JOHCICPOLLG, MOBKLBPNDHO GCNPEOLGCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5BA88F0", Offset = "0x5BA72F0", VA = "0x185BA88F0", Slot = "21")]
	public void EECMHABLJGK(NOAFFKIANHD LMNHOJFBOKL, Vector3 LBIBGDOMFJL, Vector3 HJOFEEIMLFF, Vector3 FOJLAOLHCLM, float KOIOFMOLDHL, float OLMKBHLOLOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class DMNPMPKMLDN : ANNJHAHACOM, EPCJPPBNGIC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly KBEMDCDGAOC OBODCAIPJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds PFFLFHAEEEM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds DEGLIGPGNPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xC3CF80", Offset = "0xC3B980", VA = "0x180C3CF80", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual AEBNNJHBPKD GOFMIHOIIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5BA9C90", Offset = "0x5BA8690", VA = "0x185BA9C90", Slot = "12")]
		get
		{
			return default(AEBNNJHBPKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6B6EE0", Offset = "0x6B58E0", VA = "0x1806B6EE0")]
	protected DMNPMPKMLDN(KBEMDCDGAOC JBBMOMLGMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9D20", Offset = "0x5BA8720", VA = "0x185BA9D20", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "11")]
	public virtual bool LHOIJCOHLMH(BKOCAKKCKCA JBBMOMLGMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int CFCOMADFHOB(ELDADGLNPNI HGNNAGKFJJB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int CGDDHBNMEPF(ELDADGLNPNI HGNNAGKFJJB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void DMANKFKOBDE(ELDADGLNPNI HGNNAGKFJJB, MBCMOPENIMM NNCEECFDAPH, int BLAFPBEKIKE = -1);
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
		[Cpp2IlInjected.Address(RVA = "0x5BB1E50", Offset = "0x5BB0850", VA = "0x185BB1E50")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum GMNPCMPHAIE
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
public static class JFAAHNONJJO
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MAGAOLEDCIH : IEnumerable<GOIKNLFCEOM>, IEnumerable, IEnumerator<GOIKNLFCEOM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private GOIKNLFCEOM <>2__current;

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
		private GOIKNLFCEOM System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
		[DebuggerHidden]
		public MAGAOLEDCIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE4A0", Offset = "0x5BACEA0", VA = "0x185BAE4A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE610", Offset = "0x5BAD010", VA = "0x185BAE610", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE580", Offset = "0x5BACF80", VA = "0x185BAE580", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GOIKNLFCEOM> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE580", Offset = "0x5BACF80", VA = "0x185BAE580", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int MBKHIONJAHG = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static GOIKNLFCEOM[][] NADMAKEBMLO;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static ILKOBCCAHKJ MOHOGCCILDO;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static ShapeRendererConfig KLIFNPFLOPD;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader GBJFFLNBFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5BABEA0", Offset = "0x5BAA8A0", VA = "0x185BABEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer FKJHICAOKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB840", Offset = "0x5BAA240", VA = "0x185BAB840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5BABAD0", Offset = "0x5BAA4D0", VA = "0x185BABAD0")]
	public static Mesh IAAIMMOODEE(GMNPCMPHAIE INGJMBKHDPJ, int HGNNAGKFJJB = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5BAB830", Offset = "0x5BAA230", VA = "0x185BAB830")]
	public static int BFNDDJFDIPE(GMNPCMPHAIE INGJMBKHDPJ, int HGNNAGKFJJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5BABB90", Offset = "0x5BAA590", VA = "0x185BABB90")]
	public static ILKOBCCAHKJ ICDKEKAABGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5BAB7D0", Offset = "0x5BAA1D0", VA = "0x185BAB7D0")]
	[IteratorStateMachine(typeof(MAGAOLEDCIH))]
	private static IEnumerable<GOIKNLFCEOM> AMKKLJCODDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5BABF20", Offset = "0x5BAA920", VA = "0x185BABF20")]
	public static GOIKNLFCEOM MHLMHBMLJCK(GMNPCMPHAIE INGJMBKHDPJ, int HGNNAGKFJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5BAC280", Offset = "0x5BAAC80", VA = "0x185BAC280")]
	public static bool NAPIHFBFCAB(this GMNPCMPHAIE INGJMBKHDPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5BABCF0", Offset = "0x5BAA6F0", VA = "0x185BABCF0")]
	public static void IHOFMCDOAON(GMNPCMPHAIE INGJMBKHDPJ, float3 FNCNCBEBFGP, out GBCMNBBPGAN BHJLIANGMCF, out float3 EKKLLKJKLEI, out float OHLPKBBHJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5BAC2A0", Offset = "0x5BAACA0", VA = "0x185BAC2A0")]
	public static void NONAMDEDCOM(Vector3 FNCNCBEBFGP, GMNPCMPHAIE INGJMBKHDPJ, out Vector3 EKKLLKJKLEI, out float OHLPKBBHJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5BABF10", Offset = "0x5BAA910", VA = "0x185BABF10")]
	[DDIKHCMIJDB(CAOPMCLNOKH.ExitingPlayMode, 0)]
	private static void LFFLNHMHNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5BAB8B0", Offset = "0x5BAA2B0", VA = "0x185BAB8B0")]
	[DDIKHCMIJDB(CAOPMCLNOKH.ExitingPlayMode, 0)]
	private static void FJHGGBLEFLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface DHGFKODPAPO
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool PNOHENGCBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KLJFPHAMPGE();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material BMJNHDEMMGM();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material PFFHPLDBGNF();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OIPFMAHJBBM(LCCJIDMGBBG GHGDFMPLIOE);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GLOAKJJFGBA(LHEJCNLGNOE FDHJICJOFOM);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FJCIMGFAJED(GameObject PDHKCBEBPNG);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LHODFLNGFPB(GameObject PDHKCBEBPNG, bool HOALBOIBPIP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface NBLLOCBBEBB
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KBEMDCDGAOC GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	DMNPMPKMLDN GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	AOKBDFBKJGC GMLDPDCPAEM
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
	[OJEJDFBPPED(FHFOPEOFOPD.ShapeRendering)]
	public class ShapeRendererManager : BJMELLEBIEA, IDisposable, NBLLOCBBEBB
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly global::FBHHCKKAPBO<HDCDFLOPCLG, KBEMDCDGAOC> JIJGGIJLGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly global::FBHHCKKAPBO<GFOMFGPCGCF, DMNPMPKMLDN> ALMIICDENJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly global::FBHHCKKAPBO<NOAFFKIANHD, AOKBDFBKJGC> EOKDINHIGNB;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static DHGFKODPAPO NDBGDAMFEOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5BB1FE0", Offset = "0x5BB09E0", VA = "0x185BB1FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5BB2560", Offset = "0x5BB0F60", VA = "0x185BB2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public KBEMDCDGAOC GMLDPDCPAEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x5BB2A00", Offset = "0x5BB1400", VA = "0x185BB2A00", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public DMNPMPKMLDN GMLDPDCPAEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5BB2A60", Offset = "0x5BB1460", VA = "0x185BB2A60", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AOKBDFBKJGC GMLDPDCPAEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5BB2AC0", Offset = "0x5BB14C0", VA = "0x185BB2AC0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5BB2D70", Offset = "0x5BB1770", VA = "0x185BB2D70")]
		public ShapeRendererManager(DHGFKODPAPO ANHBHKIAIFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5BB20D0", Offset = "0x5BB0AD0", VA = "0x185BB20D0", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5BB1E80", Offset = "0x5BB0880", VA = "0x185BB1E80", Slot = "4")]
		public HDCDFLOPCLG CCNIOCJEIOM(HHBFDMPPKCP PJIINDGLAPJ)
		{
			return default(HDCDFLOPCLG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5BB2690", Offset = "0x5BB1090", VA = "0x185BB2690", Slot = "5")]
		public void KDNIAEJOCEA(HDCDFLOPCLG JBBMOMLGMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5BB2760", Offset = "0x5BB1160", VA = "0x185BB2760", Slot = "6")]
		public void MKKLBJJBNBB(HDCDFLOPCLG JBBMOMLGMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5BB28F0", Offset = "0x5BB12F0", VA = "0x185BB28F0", Slot = "7")]
		public GFOMFGPCGCF OJEIAGFAAAA(HDCDFLOPCLG JBBMOMLGMKJ, NOGOBPIONDO PJIINDGLAPJ)
		{
			return default(GFOMFGPCGCF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5BB27E0", Offset = "0x5BB11E0", VA = "0x185BB27E0", Slot = "8")]
		public GFOMFGPCGCF NNIGDJMAPCO(HDCDFLOPCLG JBBMOMLGMKJ, DLEJFIGOFGJ PJIINDGLAPJ)
		{
			return default(GFOMFGPCGCF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5BB2040", Offset = "0x5BB0A40", VA = "0x185BB2040", Slot = "10")]
		public void DNFBFEGJJCL(GFOMFGPCGCF HEAJFIBKOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5BB2CC0", Offset = "0x5BB16C0", VA = "0x185BB2CC0", Slot = "9")]
		public void PNHCECFADFG(GFOMFGPCGCF HEAJFIBKOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5BB25D0", Offset = "0x5BB0FD0", VA = "0x185BB25D0", Slot = "15")]
		public IEnumerable<Renderer> HDKOPGMBGOB(HDCDFLOPCLG JBBMOMLGMKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5BB2B20", Offset = "0x5BB1520", VA = "0x185BB2B20", Slot = "11")]
		public NOAFFKIANHD PKEMCELJKKI(EKLOOMFNAPL PJIINDGLAPJ)
		{
			return default(NOAFFKIANHD);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5BB26F0", Offset = "0x5BB10F0", VA = "0x185BB26F0", Slot = "13")]
		public void MIJBBNAFKPO(NOAFFKIANHD LMNHOJFBOKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5BB1F80", Offset = "0x5BB0980", VA = "0x185BB1F80", Slot = "12")]
		public void CDDOFLDIHHD(NOAFFKIANHD LMNHOJFBOKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5BB2160", Offset = "0x5BB0B60", VA = "0x185BB2160", Slot = "14")]
		public HEIPKPPCIGL EECKLNANPEJ(BKOCAKKCKCA LMNCNCMINKD, IEnumerable<GFOMFGPCGCF> ALMIICDENJN, int GHJPKBBIMLM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class AOKBDFBKJGC : JPBLLJNBKGK
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KGHCNBEKLKF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public AOKBDFBKJGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
		[DebuggerHidden]
		public KGHCNBEKLKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5BADD50", Offset = "0x5BAC750", VA = "0x185BADD50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5BADA70", Offset = "0x5BAC470", VA = "0x185BADA70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5BADDD0", Offset = "0x5BAC7D0", VA = "0x185BADDD0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5BADD10", Offset = "0x5BAC710", VA = "0x185BADD10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5BADC70", Offset = "0x5BAC670", VA = "0x185BADC70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5BADC70", Offset = "0x5BAC670", VA = "0x185BADC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly EKLOOMFNAPL HFDKBNEKMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly NBLLOCBBEBB JNKCCKJAOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private FPGCEICPPFF JOCAIHLJENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private List<OKAIIJDDGOF> ADJFJHLKOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private List<OKAIIJDDGOF> EDALBDJMNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject HFJHHILGPCG;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7360", Offset = "0x5BA5D60", VA = "0x185BA7360")]
	public static AOKBDFBKJGC IIKNBJPPEOP(EKLOOMFNAPL PJIINDGLAPJ, NBLLOCBBEBB JNKCCKJAOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7770", Offset = "0x5BA6170", VA = "0x185BA7770")]
	private AOKBDFBKJGC(EKLOOMFNAPL PJIINDGLAPJ, NBLLOCBBEBB JNKCCKJAOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5BA61C0", Offset = "0x5BA4BC0", VA = "0x185BA61C0")]
	public void DMDPJFLHNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5BA72F0", Offset = "0x5BA5CF0", VA = "0x185BA72F0")]
	[IteratorStateMachine(typeof(KGHCNBEKLKF))]
	public IEnumerable<Renderer> IGDGCDFJFIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5BA66A0", Offset = "0x5BA50A0", VA = "0x185BA66A0", Slot = "4")]
	public void EJOMNGHIOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7250", Offset = "0x5BA5C50", VA = "0x185BA7250")]
	private void HHCPAEPDFGM(Vector3 DENDMCAONEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5BA74D0", Offset = "0x5BA5ED0", VA = "0x185BA74D0")]
	public void OPDLCGHKCDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OKAIIJDDGOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct MKDGLADKBEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public MBCMOPENIMM LNECNBGLBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public BKOCAKKCKCA JMNJOJGBABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int GEFKBDEFDNP;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GJHJIFAMMCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public OKAIIJDDGOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public ELDADGLNPNI lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<MKDGLADKBEB> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public HEIPKPPCIGL combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public GJHJIFAMMCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5BAAD70", Offset = "0x5BA9770", VA = "0x185BAAD70")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5BAADD0", Offset = "0x5BA97D0", VA = "0x185BAADD0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5BAAE00", Offset = "0x5BA9800", VA = "0x185BAAE00")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int[] NBBCLNILFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private KLJLCOJBAJF HLHJFAMBKBA;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static Matrix4x4 DAFEHOAAPNC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh KHJELOJGAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EA0", Offset = "0x6A38A0", VA = "0x1806A4EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int KJMNLILIJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF20", Offset = "0x7FD920", VA = "0x1807FEF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5BAEDB0", Offset = "0x5BAD7B0", VA = "0x185BAEDB0")]
	public void DODBGCEGJMJ(List<BKOCAKKCKCA> BFENMBBDMMH, Matrix4x4[] FCDEDMJDAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5BAE780", Offset = "0x5BAD180", VA = "0x185BAE780")]
	public static List<OKAIIJDDGOF> BJHKCBAGIGH(List<KBEMDCDGAOC> LGMANBMAOJF, ELDADGLNPNI HGNNAGKFJJB, Bounds DKDHAMFEDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5BAF180", Offset = "0x5BADB80", VA = "0x185BAF180")]
	private JobHandle OFHEIPAMJHK(HEIPKPPCIGL NGPDHGPPANF, int MGOODIPBLMJ, int HONMPKOIELP, ELDADGLNPNI HGNNAGKFJJB, List<MKDGLADKBEB> FBAEJHHAGIO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5BAF070", Offset = "0x5BADA70", VA = "0x185BAF070")]
	private void KNIFKDAAGIO(List<MKDGLADKBEB> FBAEJHHAGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5BAF690", Offset = "0x5BAE090", VA = "0x185BAF690")]
	private OKAIIJDDGOF(List<MKDGLADKBEB> FBAEJHHAGIO, int MGOODIPBLMJ, int HONMPKOIELP, ELDADGLNPNI HGNNAGKFJJB, Bounds DKDHAMFEDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5BAEFE0", Offset = "0x5BAD9E0", VA = "0x185BAEFE0", Slot = "4")]
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
		private MaterialPropertyBlock MEFLFNEADIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private OKAIIJDDGOF LJOHGOPFNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<BKOCAKKCKCA> EPLPEHGIPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private RenderTexture MLLBEOJACLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ComputeBuffer FCCMLAOEHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private ComputeShader FDFGCJENKCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Matrix4x4[] DJBAMAAPKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int LJDCGHNKADN;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer LFHHCPEKLDP
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6A4ED0", Offset = "0x6A38D0", VA = "0x1806A4ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int DFFEPAMAKKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5BB3FA0", Offset = "0x5BB29A0", VA = "0x185BB3FA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5BB3310", Offset = "0x5BB1D10", VA = "0x185BB3310")]
		public static List<SkinnedShapeRenderer> Create(GameObject JBBMOMLGMKJ, List<OKAIIJDDGOF> LLPKMCFLEFB, List<BKOCAKKCKCA> EPLPEHGIPJM, Material AJAKNINAIMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5BB3950", Offset = "0x5BB2350", VA = "0x185BB3950")]
		public void Init(OKAIIJDDGOF LJOHGOPFNGB, List<BKOCAKKCKCA> EPLPEHGIPJM, Material AJAKNINAIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5BB3EF0", Offset = "0x5BB28F0", VA = "0x185BB3EF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5BB3E40", Offset = "0x5BB2840", VA = "0x185BB3E40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5BB3E00", Offset = "0x5BB2800", VA = "0x185BB3E00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5BB3720", Offset = "0x5BB2120", VA = "0x185BB3720")]
		private void FCFAJOOKPMM(ScriptableRenderContext ABFHDOGCMDC, Camera[] BEKIBICAMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5BB3560", Offset = "0x5BB1F60", VA = "0x185BB3560")]
		private void DODBGCEGJMJ(CommandBuffer NCKKDGCCMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : ODIDKPKCBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5BB40D0", Offset = "0x5BB2AD0", VA = "0x185BB40D0", Slot = "4")]
		public sealed override void HGKEFMKAFGI()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5BADE20", Offset = "0x5BAC820", VA = "0x185BADE20")]
	private static string GKOJACPJHAL(byte[] KCHCODPDAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5BADF30", Offset = "0x5BAC930", VA = "0x185BADF30")]
	public static string MEDIDALCMKC(byte[] GHEBPHBJKNK, bool FPEGHFMMINI)
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
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
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
