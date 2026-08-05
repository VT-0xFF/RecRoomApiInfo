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
public enum AGEOAJGPFMD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HDBPACGBDDK
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<AGEOAJGPFMD> OOFKDJFNIJH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1125ED0", Offset = "0x11246D0", VA = "0x181125ED0")]
	static HDBPACGBDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1125ED0", Offset = "0x11246D0", VA = "0x181125ED0")]
	[HFMCDBILDCC]
	private static void CDGCMJJMEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1125FF0", Offset = "0x11247F0", VA = "0x181125FF0")]
	public static bool PEMEPPKKGHI(this AGEOAJGPFMD ALMOBGHIPAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EJBFCJLCFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PLACEHOLDER_16 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BKIAKNMONIG
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JGJNLOAHADE
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	HoverXRay
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FBCDNMIJFEE
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EBAPIFKGJNF : CKKNDJMNFLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte LAFAEMGBFGA = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte LEEEADDDNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] GNLHPADDEIH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JFLGKMMPBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5EB260", Offset = "0x5E9A60", VA = "0x1805EB260", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5EB270", Offset = "0x5E9A70", VA = "0x1805EB270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AMPLMBAKPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9D0", Offset = "0x5E91D0", VA = "0x1805EA9D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9E0", Offset = "0x5E91E0", VA = "0x1805EA9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float LANHKCPMBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69BDB0", Offset = "0x69A5B0", VA = "0x18069BDB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69C290", Offset = "0x69AA90", VA = "0x18069C290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float MMHGGMJILEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69BDA0", Offset = "0x69A5A0", VA = "0x18069BDA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69C280", Offset = "0x69AA80", VA = "0x18069C280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> LHLNJIGFCPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1124D30", Offset = "0x1123530", VA = "0x181124D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> HNKEHICGDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF58DF0", Offset = "0xF575F0", VA = "0x180F58DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject ANEDAECPNGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x572B30", VA = "0x180574330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6155C0", Offset = "0x613DC0", VA = "0x1806155C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte PDIHHLPCPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1124BB0", Offset = "0x11233B0", VA = "0x181124BB0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1125130", Offset = "0x1123930", VA = "0x181125130")]
	public EBAPIFKGJNF(List<DJHEJOIDJDH> GHCJGLFKFGI, List<DJHEJOIDJDH> LDIMALCLFNK, List<Transform> HDAKLPIJAHI, Material GFJHDCCBOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1125020", Offset = "0x1123820", VA = "0x181125020")]
	private int MNFCFIAGLLG(List<DJHEJOIDJDH> GKPPFPFALGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1124EC0", Offset = "0x11236C0", VA = "0x181124EC0")]
	private void MCCJFNMNEEI(int BKHCOCHPDNI, bool MOHLEKJIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1124D90", Offset = "0x1123590", VA = "0x181124D90")]
	public void ILEDBBIFGED(Vector3 KCGKLKAFIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1124C00", Offset = "0x1123400", VA = "0x181124C00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1124E80", Offset = "0x1123680", VA = "0x181124E80")]
	public void MBOFJAEKCLM(Transform JHKNKKGBOLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OJJKCIICPPI : IDLGMKHLPIG, GBGKIHKNDHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JLBCCIHOLPP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public OJJKCIICPPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A20", Offset = "0x7B1220", VA = "0x1807B2A20")]
		[DebuggerHidden]
		public JLBCCIHOLPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x11265A0", Offset = "0x1124DA0", VA = "0x1811265A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x11260F0", Offset = "0x11248F0", VA = "0x1811260F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1126720", Offset = "0x1124F20", VA = "0x181126720")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1126760", Offset = "0x1124F60", VA = "0x181126760")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x11267B0", Offset = "0x1124FB0", VA = "0x1811267B0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1126550", Offset = "0x1124D50", VA = "0x181126550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x11264B0", Offset = "0x1124CB0", VA = "0x1811264B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x11264B0", Offset = "0x1124CB0", VA = "0x1811264B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FMLGOPLLNOI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public OJJKCIICPPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A20", Offset = "0x7B1220", VA = "0x1807B2A20")]
		[DebuggerHidden]
		public FMLGOPLLNOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1125CE0", Offset = "0x11244E0", VA = "0x181125CE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1125940", Offset = "0x1124140", VA = "0x181125940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1125E00", Offset = "0x1124600", VA = "0x181125E00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1125E50", Offset = "0x1124650", VA = "0x181125E50")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1125C90", Offset = "0x1124490", VA = "0x181125C90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1125BF0", Offset = "0x11243F0", VA = "0x181125BF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1125BF0", Offset = "0x11243F0", VA = "0x181125BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private MLGMJCGOGHL FOHOJFDFEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<EMMDBEEOOFA> IAFNNFIJHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> EOEJFEMANLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer AGINBLMEOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool CLJENBFMMCN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<NEJLIOHCGLB> GNPNPMBEFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MPBFEPAJOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x112C1B0", Offset = "0x112A9B0", VA = "0x18112C1B0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform DGGAGGHKAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x112B360", Offset = "0x1129B60", VA = "0x18112B360", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> LJGDCFGMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x573EE0", Offset = "0x5726E0", VA = "0x180573EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5B5120", Offset = "0x5B3920", VA = "0x1805B5120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x112C1F0", Offset = "0x112A9F0", VA = "0x18112C1F0")]
	public OJJKCIICPPI(MLGMJCGOGHL BPPCNFHJMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x112B280", Offset = "0x1129A80", VA = "0x18112B280", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x112B190", Offset = "0x1129990", VA = "0x18112B190")]
	public void DEOBKNOOHMB(EMMDBEEOOFA MGPLLJLFHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x112BA70", Offset = "0x112A270", VA = "0x18112BA70")]
	public void IIDOOJBFPNM(EMMDBEEOOFA MGPLLJLFHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x112BB50", Offset = "0x112A350", VA = "0x18112BB50", Slot = "4")]
	public void JEJHBLKDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x112B2B0", Offset = "0x1129AB0", VA = "0x18112B2B0")]
	public void EOMPEFKMIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x112B040", Offset = "0x1129840", VA = "0x18112B040")]
	private void CAKKAKLJENA(EMMDBEEOOFA MGPLLJLFHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x112B4F0", Offset = "0x1129CF0", VA = "0x18112B4F0")]
	public void HDNIEBAOKDE(bool FBEINGFGKHA, bool KKGGGKBKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x112B3B0", Offset = "0x1129BB0", VA = "0x18112B3B0")]
	protected void GNKKEEKPKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x112C140", Offset = "0x112A940", VA = "0x18112C140")]
	[IteratorStateMachine(typeof(JLBCCIHOLPP))]
	public IEnumerable<Renderer> KNIBINJMKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x112BAE0", Offset = "0x112A2E0", VA = "0x18112BAE0")]
	[IteratorStateMachine(typeof(FMLGOPLLNOI))]
	public IEnumerable<Renderer> INCCLGGDHBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class LPGFJLEFFNA : EMMDBEEOOFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private GDBHEBNLOBG DIHNPLFBEKA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1128240", Offset = "0x1126A40", VA = "0x181128240")]
	private NativeList<GBJOAAGIJOK> DHJLALNMPPG()
	{
		return default(NativeList<GBJOAAGIJOK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1123980", Offset = "0x1122180", VA = "0x181123980")]
	public LPGFJLEFFNA(OJJKCIICPPI JMNKBNCDHOH, GDBHEBNLOBG BPPCNFHJMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1128A60", Offset = "0x1127260", VA = "0x181128A60", Slot = "13")]
	public override int MNFCFIAGLLG(BMFGNDHCCGF EOOEBDHGOCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1128840", Offset = "0x1127040", VA = "0x181128840", Slot = "14")]
	public override int HHOBEEEJKFM(BMFGNDHCCGF EOOEBDHGOCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1128310", Offset = "0x1126B10", VA = "0x181128310", Slot = "15")]
	public override void EEMCCEFJNJE(BMFGNDHCCGF EOOEBDHGOCJ, OKPFJAGMEAI JMBLBKOCNDC, int NNJCACPGBOJ = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct IGGPIHKAOGD : global::DMEBJJLLDIP<IGGPIHKAOGD>, KKIKBKBCNID, IEquatable<IGGPIHKAOGD>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EHCNLDNBCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60DDA0", Offset = "0x60C5A0", VA = "0x18060DDA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x855720", Offset = "0x853F20", VA = "0x180855720", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LPDIHOLGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C50", Offset = "0x9C0450", VA = "0x1809C1C50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C80", Offset = "0x9C0480", VA = "0x1809C1C80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xF2B1A0", Offset = "0xF299A0", VA = "0x180F2B1A0", Slot = "8")]
	public bool Equals(IGGPIHKAOGD EFDJFLPIKFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x11260B0", Offset = "0x11248B0", VA = "0x1811260B0")]
	public static bool EMMCEJFBHBP(IGGPIHKAOGD IFKKNJFNCCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FEIKFMCBDNJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MLGMJCGOGHL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform PIPDGPFJAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FEIKFMCBDNJ KKOBBPPNDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HDLICMJBJPE : global::DMEBJJLLDIP<HDLICMJBJPE>, KKIKBKBCNID, IEquatable<HDLICMJBJPE>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int EHCNLDNBCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60DDA0", Offset = "0x60C5A0", VA = "0x18060DDA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x855720", Offset = "0x853F20", VA = "0x180855720", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int LPDIHOLGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C50", Offset = "0x9C0450", VA = "0x1809C1C50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C80", Offset = "0x9C0480", VA = "0x1809C1C80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xF2B1A0", Offset = "0xF299A0", VA = "0x180F2B1A0", Slot = "8")]
	public bool Equals(HDLICMJBJPE EFDJFLPIKFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1126070", Offset = "0x1124870", VA = "0x181126070")]
	public static bool EMMCEJFBHBP(HDLICMJBJPE IFKKNJFNCCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LLBLJBPFHKM
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform PIPDGPFJAJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float KFMCLOHAFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 POOBAPMNKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AGEOAJGPFMD PJGENLLJJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	EJBFCJLCFMM FOPOILBKGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OONEDONPKBK : LLBLJBPFHKM
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	HAHFOECNJCB AGJECPINDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BLFOKPMCFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GDBHEBNLOBG : LLBLJBPFHKM
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BGDPBCDBBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NMDFPEGNBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float DOMDGHGPKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int PBHIBEBGCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OANKNEHAPKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<GBJOAAGIJOK> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JPCFNOJFNLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPCGKAMLKKM(HDLICMJBJPE MGPLLJLFHBF, JGJNLOAHADE LNIJNPJFNCN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPCGKAMLKKM(IGGPIHKAOGD JMNKBNCDHOH, JGJNLOAHADE LNIJNPJFNCN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKNFFHNNHJD(IGGPIHKAOGD JMNKBNCDHOH);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKNFFHNNHJD(HDLICMJBJPE MGPLLJLFHBF);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KMEKMGJFANM(IGGPIHKAOGD JMNKBNCDHOH, FBCDNMIJFEE LIBGCFIILKM);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFBFMNDOJGO(IGGPIHKAOGD JMNKBNCDHOH, Vector3 HOFDCIIGEPL, Vector3 OGPPKCABNJJ, Vector3 PBOOMOPANHI, float BIJJIJCEADA, float POGOPODFGII, IReadOnlyList<Camera> KBAMOIJHPAO, BKIAKNMONIG DCOHJKCFEJK);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FFBFMNDOJGO(FPACCMCBOFF OIFCPIBBKEE, Vector3 HOFDCIIGEPL, Vector3 OGPPKCABNJJ, Vector3 PBOOMOPANHI, float BIJJIJCEADA, float POGOPODFGII);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JLGMAMDACDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IGGPIHKAOGD GJILLAPHBAA(MLGMJCGOGHL BPPCNFHJMAA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBBBBKILBKI(IGGPIHKAOGD JMNKBNCDHOH);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBLCMJNGEOP(IGGPIHKAOGD JMNKBNCDHOH);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HDLICMJBJPE MAHGPKPDJIL(IGGPIHKAOGD JMNKBNCDHOH, OONEDONPKBK BPPCNFHJMAA);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HDLICMJBJPE MNOCAAPLBAN(IGGPIHKAOGD JMNKBNCDHOH, GDBHEBNLOBG BPPCNFHJMAA);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NOABNBJNABB(HDLICMJBJPE MGPLLJLFHBF);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJGPOMPIODE(HDLICMJBJPE MGPLLJLFHBF);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FPACCMCBOFF KJDOCDILMEC(EAPLEPEBCKG BPPCNFHJMAA);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MPNBMNALFIO(FPACCMCBOFF OIFCPIBBKEE);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JNINBGGMOGH(FPACCMCBOFF OIFCPIBBKEE);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FNPAOOCDMLK FAEPKGIBNGJ(Transform CPADHPKEBBI, IEnumerable<HDLICMJBJPE> IAFNNFIJHKH, int KIELDPNCLDG);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> LJJHDHINFPP(IGGPIHKAOGD JMNKBNCDHOH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FPACCMCBOFF : global::DMEBJJLLDIP<FPACCMCBOFF>, KKIKBKBCNID, IEquatable<FPACCMCBOFF>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EHCNLDNBCOB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60DDA0", Offset = "0x60C5A0", VA = "0x18060DDA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x855720", Offset = "0x853F20", VA = "0x180855720", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int LPDIHOLGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C50", Offset = "0x9C0450", VA = "0x1809C1C50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C80", Offset = "0x9C0480", VA = "0x1809C1C80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xF2B1A0", Offset = "0xF299A0", VA = "0x180F2B1A0", Slot = "8")]
	public bool Equals(FPACCMCBOFF EFDJFLPIKFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1125E90", Offset = "0x1124690", VA = "0x181125E90")]
	public static bool EMMCEJFBHBP(FPACCMCBOFF IFKKNJFNCCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EAPLEPEBCKG
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int CIAIEBLHGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform PAJHCMAHEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool BPNAFDEHCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IGGPIHKAOGD GetBone(int EOKLONKFABC);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int EOKLONKFABC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class DDOIEPAIEIN : EMMDBEEOOFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public OONEDONPKBK GOHOHJNCEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] EMPDDGNKGJJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override NCEGIBAADAK EHLKOMMKLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1123360", Offset = "0x1121B60", VA = "0x181123360", Slot = "12")]
		get
		{
			return default(NCEGIBAADAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 IOIPLAMENKL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x11237A0", Offset = "0x1121FA0", VA = "0x1811237A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1123980", Offset = "0x1122180", VA = "0x181123980")]
	public DDOIEPAIEIN(OJJKCIICPPI JMNKBNCDHOH, OONEDONPKBK BPPCNFHJMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1122490", Offset = "0x1120C90", VA = "0x181122490", Slot = "11")]
	public override bool AKFFHJOGPJG(Transform JMNKBNCDHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1123700", Offset = "0x1121F00", VA = "0x181123700", Slot = "13")]
	public override int MNFCFIAGLLG(BMFGNDHCCGF EOOEBDHGOCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x11232C0", Offset = "0x1121AC0", VA = "0x1811232C0", Slot = "14")]
	public override int HHOBEEEJKFM(BMFGNDHCCGF EOOEBDHGOCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1122990", Offset = "0x1121190", VA = "0x181122990")]
	private int ANKDCDDAPNJ(BMFGNDHCCGF EOOEBDHGOCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1122C10", Offset = "0x1121410", VA = "0x181122C10", Slot = "15")]
	public override void EEMCCEFJNJE(BMFGNDHCCGF EOOEBDHGOCJ, OKPFJAGMEAI JMBLBKOCNDC, int NNJCACPGBOJ = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PMOLFKGDMHG
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJCJAFMMFMD(FBCDNMIJFEE LIBGCFIILKM, Renderer GMBIAABBFGK, int LHBOONKOPOH);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNLPMNKAFPK(Renderer GMBIAABBFGK, BKIAKNMONIG DCOHJKCFEJK, Vector3 HOFDCIIGEPL, Vector3 OGPPKCABNJJ, Vector3 PBOOMOPANHI, float BIJJIJCEADA, float POGOPODFGII, float LIIIFKDJFAI = -1f, [Optional] Color? PNNFNJIOJPK, [Optional] IReadOnlyList<Camera> OFBGHEHOGDK);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGOLIEMMKBP(Renderer GMBIAABBFGK, int LHBOONKOPOH);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ALIENDDMCLF();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IECCCHOONLN(int MMKLMIHJCEM, JGJNLOAHADE LIBGCFIILKM, Renderer GMBIAABBFGK, int LHBOONKOPOH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PCJCMDPLGEK : JPCFNOJFNLD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly PMOLFKGDMHG MANAAOJMOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly FMJMEAGLOPF LHNMNALBADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer DIHLOEFCGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private EBGAGMCNEJH COJHLPOBFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer ECIKHKKBOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private EBGAGMCNEJH IHLPFMAIBBO;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F80", Offset = "0x6DF780", VA = "0x1806E0F80")]
	public PCJCMDPLGEK(PMOLFKGDMHG DBIPEKAEDJL, FMJMEAGLOPF LHNMNALBADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x112C280", Offset = "0x112AA80", VA = "0x18112C280", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x112CAD0", Offset = "0x112B2D0", VA = "0x18112CAD0", Slot = "4")]
	public void IPCGKAMLKKM(HDLICMJBJPE MGPLLJLFHBF, JGJNLOAHADE LNIJNPJFNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x112CD50", Offset = "0x112B550", VA = "0x18112CD50", Slot = "5")]
	public void IPCGKAMLKKM(IGGPIHKAOGD JMNKBNCDHOH, JGJNLOAHADE LNIJNPJFNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x112D0C0", Offset = "0x112B8C0", VA = "0x18112D0C0", Slot = "6")]
	public void MKNFFHNNHJD(IGGPIHKAOGD JMNKBNCDHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x112D260", Offset = "0x112BA60", VA = "0x18112D260", Slot = "7")]
	public void MKNFFHNNHJD(HDLICMJBJPE MGPLLJLFHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x112CF20", Offset = "0x112B720", VA = "0x18112CF20", Slot = "8")]
	public void KMEKMGJFANM(IGGPIHKAOGD JMNKBNCDHOH, FBCDNMIJFEE LIBGCFIILKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x112C7A0", Offset = "0x112AFA0", VA = "0x18112C7A0", Slot = "9")]
	public void FFBFMNDOJGO(IGGPIHKAOGD JMNKBNCDHOH, Vector3 HOFDCIIGEPL, Vector3 OGPPKCABNJJ, Vector3 PBOOMOPANHI, float BIJJIJCEADA, float POGOPODFGII, IReadOnlyList<Camera> KBAMOIJHPAO, BKIAKNMONIG DCOHJKCFEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x112C3D0", Offset = "0x112ABD0", VA = "0x18112C3D0", Slot = "10")]
	public void FFBFMNDOJGO(FPACCMCBOFF OIFCPIBBKEE, Vector3 HOFDCIIGEPL, Vector3 OGPPKCABNJJ, Vector3 PBOOMOPANHI, float BIJJIJCEADA, float POGOPODFGII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class EMMDBEEOOFA : PDCBNOJNAPN, NEJLIOHCGLB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds DNOBOCCJBGC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public OJJKCIICPPI ANEDAECPNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA30", Offset = "0x5DC230", VA = "0x1805DDA30")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds OBDKFCGMGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1125920", Offset = "0x1124120", VA = "0x181125920", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual NCEGIBAADAK EHLKOMMKLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1125890", Offset = "0x1124090", VA = "0x181125890", Slot = "12")]
		get
		{
			return default(NCEGIBAADAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1125820", Offset = "0x1124020", VA = "0x181125820", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x573FE0", VA = "0x1805757E0", Slot = "11")]
	public virtual bool AKFFHJOGPJG(Transform JMNKBNCDHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int MNFCFIAGLLG(BMFGNDHCCGF EOOEBDHGOCJ);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int HHOBEEEJKFM(BMFGNDHCCGF EOOEBDHGOCJ);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void EEMCCEFJNJE(BMFGNDHCCGF EOOEBDHGOCJ, OKPFJAGMEAI JMBLBKOCNDC, int NNJCACPGBOJ = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	protected EMMDBEEOOFA()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x112D4B0", Offset = "0x112BCB0", VA = "0x18112D4B0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum HAHFOECNJCB
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class NLNDLLNMJHD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AANOABLKMGJ : IEnumerable<DIGLLDOKEIK>, IEnumerable, IEnumerator<DIGLLDOKEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DIGLLDOKEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private DIGLLDOKEIK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A20", Offset = "0x7B1220", VA = "0x1807B2A20")]
		[DebuggerHidden]
		public AANOABLKMGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1122270", Offset = "0x1120A70", VA = "0x181122270", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x11223E0", Offset = "0x1120BE0", VA = "0x1811223E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1122350", Offset = "0x1120B50", VA = "0x181122350", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DIGLLDOKEIK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1122350", Offset = "0x1120B50", VA = "0x181122350", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int LCFPMKJHFAB = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static DIGLLDOKEIK[][] HAAIDGPDOFC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static HFLCICFJOKC BFEBCPFCBIM;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig AMACPKMGGED;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader IAPMIJGOJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1129AE0", Offset = "0x11282E0", VA = "0x181129AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer LEDCFMEICHF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1128FD0", Offset = "0x11277D0", VA = "0x181128FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x11298D0", Offset = "0x11280D0", VA = "0x1811298D0")]
	public static Mesh PGLDMAMJEIL(HAHFOECNJCB MICKLDJLCCI, int EOOEBDHGOCJ = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1128FC0", Offset = "0x11277C0", VA = "0x181128FC0")]
	public static int DPDFFHEAEJL(HAHFOECNJCB MICKLDJLCCI, int EOOEBDHGOCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1129990", Offset = "0x1128190", VA = "0x181129990")]
	public static HFLCICFJOKC PHEDICIMDEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1129040", Offset = "0x1127840", VA = "0x181129040")]
	[IteratorStateMachine(typeof(AANOABLKMGJ))]
	private static IEnumerable<DIGLLDOKEIK> HEKEICBMCBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1128C80", Offset = "0x1127480", VA = "0x181128C80")]
	public static DIGLLDOKEIK CGCLPPGMEAE(HAHFOECNJCB MICKLDJLCCI, int EOOEBDHGOCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x11296F0", Offset = "0x1127EF0", VA = "0x1811296F0")]
	public static bool OBAAPOIBNOF(this HAHFOECNJCB MICKLDJLCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1129710", Offset = "0x1127F10", VA = "0x181129710")]
	public static void PGKAPBDJANE(HAHFOECNJCB MICKLDJLCCI, float3 OLLLLJADKCC, out EEHCMEAHPJI NKJDHNOBKEN, out float3 MLBLJPAOCKG, out float IBBFPKPIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x11292D0", Offset = "0x1127AD0", VA = "0x1811292D0")]
	public static void MHOGEAPEIMC(Vector3 OLLLLJADKCC, HAHFOECNJCB MICKLDJLCCI, out Vector3 MLBLJPAOCKG, out float IBBFPKPIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x11292C0", Offset = "0x1127AC0", VA = "0x1811292C0")]
	[OILNIGDFCEG(KHPJBCINGDL.ExitingPlayMode, 0)]
	private static void LHKLIGFECKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x11290A0", Offset = "0x11278A0", VA = "0x1811290A0")]
	[OILNIGDFCEG(KHPJBCINGDL.ExitingPlayMode, 0)]
	private static void LGGIHEDHMHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OMLHFEJAJLE
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool LOCCOKBFLLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material JLBIKADJEII();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material FHHKBIDOOJM();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material AJBDGNGABEP();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PHKMNDHEMJC(AGEOAJGPFMD BFGDCFELJDC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IPBKICPMMCO(EJBFCJLCFMM HNFKDOACNBM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FEGBKIFNPIH(GameObject ALCFLDIFDGE);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CFNBMKIAOPB(GameObject ALCFLDIFDGE, bool CFJDNOECEBH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface FMJMEAGLOPF
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OJJKCIICPPI KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	EMMDBEEOOFA KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OJICBALBBCC KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class JPLEPIFCPIB : JLGMAMDACDB, IDisposable, FMJMEAGLOPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::KNMHEHLIHHL<IGGPIHKAOGD, OJJKCIICPPI> DLCKOCKBOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::KNMHEHLIHHL<HDLICMJBJPE, EMMDBEEOOFA> IAFNNFIJHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::KNMHEHLIHHL<FPACCMCBOFF, OJICBALBBCC> MAJEGABAENP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static OMLHFEJAJLE IIKIKBADBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1126DF0", Offset = "0x11255F0", VA = "0x181126DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1126E90", Offset = "0x1125690", VA = "0x181126E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OJJKCIICPPI KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x11274F0", Offset = "0x1125CF0", VA = "0x1811274F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public EMMDBEEOOFA KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1127430", Offset = "0x1125C30", VA = "0x181127430", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OJICBALBBCC KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1127490", Offset = "0x1125C90", VA = "0x181127490", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1127B90", Offset = "0x1126390", VA = "0x181127B90")]
	public JPLEPIFCPIB(OMLHFEJAJLE DBIPEKAEDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1126EE0", Offset = "0x11256E0", VA = "0x181126EE0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1127350", Offset = "0x1125B50", VA = "0x181127350", Slot = "4")]
	public IGGPIHKAOGD GJILLAPHBAA(MLGMJCGOGHL BPPCNFHJMAA)
	{
		return default(IGGPIHKAOGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1126E30", Offset = "0x1125630", VA = "0x181126E30", Slot = "5")]
	public void BBBBBKILBKI(IGGPIHKAOGD JMNKBNCDHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1127AC0", Offset = "0x11262C0", VA = "0x181127AC0", Slot = "6")]
	public void NBLCMJNGEOP(IGGPIHKAOGD JMNKBNCDHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x11277C0", Offset = "0x1125FC0", VA = "0x1811277C0", Slot = "15")]
	public IEnumerable<Renderer> LJJHDHINFPP(IGGPIHKAOGD JMNKBNCDHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1127880", Offset = "0x1126080", VA = "0x181127880", Slot = "7")]
	public HDLICMJBJPE MAHGPKPDJIL(IGGPIHKAOGD JMNKBNCDHOH, OONEDONPKBK BPPCNFHJMAA)
	{
		return default(HDLICMJBJPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1127970", Offset = "0x1126170", VA = "0x181127970", Slot = "8")]
	public HDLICMJBJPE MNOCAAPLBAN(IGGPIHKAOGD JMNKBNCDHOH, GDBHEBNLOBG BPPCNFHJMAA)
	{
		return default(HDLICMJBJPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1125F50", VA = "0x181127750", Slot = "10")]
	public void KJGPOMPIODE(HDLICMJBJPE MGPLLJLFHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1127B30", Offset = "0x1126330", VA = "0x181127B30", Slot = "9")]
	public void NOABNBJNABB(HDLICMJBJPE MGPLLJLFHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x11275C0", Offset = "0x1125DC0", VA = "0x1811275C0", Slot = "11")]
	public FPACCMCBOFF KJDOCDILMEC(EAPLEPEBCKG BPPCNFHJMAA)
	{
		return default(FPACCMCBOFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1127550", Offset = "0x1125D50", VA = "0x181127550", Slot = "13")]
	public void JNINBGGMOGH(FPACCMCBOFF OIFCPIBBKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1127A60", Offset = "0x1126260", VA = "0x181127A60", Slot = "12")]
	public void MPNBMNALFIO(FPACCMCBOFF OIFCPIBBKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1126F50", Offset = "0x1125750", VA = "0x181126F50", Slot = "14")]
	public FNPAOOCDMLK FAEPKGIBNGJ(Transform CPADHPKEBBI, IEnumerable<HDLICMJBJPE> IAFNNFIJHKH, int KIELDPNCLDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OJICBALBBCC : IDLGMKHLPIG
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EDNGCGAHJBB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public OJICBALBBCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A20", Offset = "0x7B1220", VA = "0x1807B2A20")]
		[DebuggerHidden]
		public EDNGCGAHJBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1125740", Offset = "0x1123F40", VA = "0x181125740", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1125460", Offset = "0x1123C60", VA = "0x181125460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x11257E0", Offset = "0x1123FE0", VA = "0x1811257E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x11256F0", Offset = "0x1123EF0", VA = "0x1811256F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1125650", Offset = "0x1123E50", VA = "0x181125650", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1125650", Offset = "0x1123E50", VA = "0x181125650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly EAPLEPEBCKG KJPJANFKNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly FMJMEAGLOPF LHNMNALBADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private EBAPIFKGJNF MKKAPBFHDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<DJHEJOIDJDH> NIANALHLFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<DJHEJOIDJDH> PJFDPPOEPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject FLFMMHEMHLO;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x112ADE0", Offset = "0x11295E0", VA = "0x18112ADE0")]
	public static OJICBALBBCC MJJIEILFJPL(EAPLEPEBCKG BPPCNFHJMAA, FMJMEAGLOPF LHNMNALBADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x112AF40", Offset = "0x1129740", VA = "0x18112AF40")]
	private OJICBALBBCC(EAPLEPEBCKG BPPCNFHJMAA, FMJMEAGLOPF LHNMNALBADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1129DD0", Offset = "0x11285D0", VA = "0x181129DD0")]
	public void HCHOKKKPDGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x112AD70", Offset = "0x1129570", VA = "0x18112AD70")]
	[IteratorStateMachine(typeof(EDNGCGAHJBB))]
	public IEnumerable<Renderer> KNIBINJMKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x112A320", Offset = "0x1128B20", VA = "0x18112A320", Slot = "4")]
	public void JEJHBLKDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1129DA0", Offset = "0x11285A0", VA = "0x181129DA0")]
	private void HBOBHMBLFHP(Vector3 KCGKLKAFIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1129BD0", Offset = "0x11283D0", VA = "0x181129BD0")]
	public void EOMPEFKMIJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DJHEJOIDJDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct CMNDADFNDJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public OKPFJAGMEAI CODOHAHILOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform FFFPOIIMKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int LPJHMODBBOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class GMFMHLCCBHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public DJHEJOIDJDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public BMFGNDHCCGF lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<CMNDADFNDJC> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GMFMHLCCBHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KKELKPNNMME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FNPAOOCDMLK combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public GMFMHLCCBHP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KKELKPNNMME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1128000", Offset = "0x1126800", VA = "0x181128000")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1128070", Offset = "0x1126870", VA = "0x181128070")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x11280B0", Offset = "0x11268B0", VA = "0x1811280B0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] IMMLGCIEIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CEFNDNIFHDE POJPICOHCIN;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 CPMLGJAJMJD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh BALCGMPGLCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA30", Offset = "0x5DC230", VA = "0x1805DDA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int ELDMBAFCKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D78C0", Offset = "0x5D60C0", VA = "0x1805D78C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5EA020", Offset = "0x5E8820", VA = "0x1805EA020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x11243C0", Offset = "0x1122BC0", VA = "0x1811243C0")]
	public void KOLDABCPHDI(List<Transform> CJAAGFOODIG, Matrix4x4[] PIBFLDECIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x11239D0", Offset = "0x11221D0", VA = "0x1811239D0")]
	public static List<DJHEJOIDJDH> DIFMOOHBFDA(List<OJJKCIICPPI> MPAPPEMCHOB, BMFGNDHCCGF EOOEBDHGOCJ, Bounds JNALAJFPILO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1123FB0", Offset = "0x11227B0", VA = "0x181123FB0")]
	private JobHandle EKDOKAHCDNL(FNPAOOCDMLK NEOPBCHGNBG, int DBCNMJKEHAK, int FDFCNPCNMPC, BMFGNDHCCGF EOOEBDHGOCJ, List<CMNDADFNDJC> HEDDGPDMCLF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x11245C0", Offset = "0x1122DC0", VA = "0x1811245C0")]
	private void LPAMDDDIPJP(List<CMNDADFNDJC> HEDDGPDMCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1124800", Offset = "0x1123000", VA = "0x181124800")]
	private DJHEJOIDJDH(List<CMNDADFNDJC> HEDDGPDMCLF, int DBCNMJKEHAK, int FDFCNPCNMPC, BMFGNDHCCGF EOOEBDHGOCJ, Bounds JNALAJFPILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1123F30", Offset = "0x1122730", VA = "0x181123F30", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private MaterialPropertyBlock DFKFMMFCLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private DJHEJOIDJDH LCNEKKDHJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> HDAKLPIJAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture KOPODODMCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer FHNDNIAEPKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader MMAOMPINKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] FFODAKCJAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int KPMLEACKMOO;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer PMAGECLDIKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574180", VA = "0x180575980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int CIAIEBLHGEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x112E150", Offset = "0x112C950", VA = "0x18112E150")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x112D5E0", Offset = "0x112BDE0", VA = "0x18112D5E0")]
		public static List<SkinnedShapeRenderer> Create(GameObject JMNKBNCDHOH, List<DJHEJOIDJDH> GKPPFPFALGG, List<Transform> HDAKLPIJAHI, Material GFJHDCCBOAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x112D7F0", Offset = "0x112BFF0", VA = "0x18112D7F0")]
		public void Init(DJHEJOIDJDH LCNEKKDHJPB, List<Transform> HDAKLPIJAHI, Material GFJHDCCBOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x112E0C0", Offset = "0x112C8C0", VA = "0x18112E0C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x112E030", Offset = "0x112C830", VA = "0x18112E030")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x112DFF0", Offset = "0x112C7F0", VA = "0x18112DFF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x112DF60", Offset = "0x112C760", VA = "0x18112DF60")]
		private void LOMLOEFELKN(ScriptableRenderContext JPCKENBNJIJ, Camera[] JJKKLHJAMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x112DC10", Offset = "0x112C410", VA = "0x18112DC10")]
		private void KOLDABCPHDI(CommandBuffer LCLDMHKIKDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x60B930", Offset = "0x60A130", VA = "0x18060B930")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JOLDJLBOGLF
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] NNDNCLBIBCO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int BOAHHKDAAGN;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int BEAECOMNAKK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger HPFDFIDLOGO;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JOLDJLBOGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1126800", Offset = "0x1125000", VA = "0x181126800")]
	private static string AAANGJFGDHI(byte[] EOEFACHALFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1126900", Offset = "0x1125100", VA = "0x181126900")]
	public static string CHJFNPPOLEP(byte[] IFAOIOLKGMC, bool CCLJOEHHPGP)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
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
