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
public enum GLCEFHNBIFP
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
public static class GHDOAOGFODE
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<GLCEFHNBIFP> FOLJCLGEFHP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4D40F60", Offset = "0x4D3FB60", VA = "0x184D40F60")]
	static GHDOAOGFODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D40F60", Offset = "0x4D3FB60", VA = "0x184D40F60")]
	[FLDPBADOEFD]
	private static void JIBFOCILIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D41080", Offset = "0x4D3FC80", VA = "0x184D41080")]
	public static bool MLOALLBNHLN(this GLCEFHNBIFP FNCFGGPPKDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MLIMIBOGCDN
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
public enum OILEEBPHNIN
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
public enum DLOBCNCKIPI
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
public enum EIMBCDABDIE
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
public class MNNNKGBOBGA : CFPLBAHOLOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte EIIDFMCNKCE = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte INPKPKKDNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] ICMEONFDAEI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BPBABNHAMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x55CCD0", Offset = "0x55B8D0", VA = "0x18055CCD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA10", Offset = "0x5DC610", VA = "0x1805DDA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GPLGPEFBOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x55CCC0", Offset = "0x55B8C0", VA = "0x18055CCC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x694390", Offset = "0x692F90", VA = "0x180694390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JMBNCFGAAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1057C10", Offset = "0x1056810", VA = "0x181057C10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1369FD0", Offset = "0x1368BD0", VA = "0x181369FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float LEFFJLANGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD2DBA0", Offset = "0xD2C7A0", VA = "0x180D2DBA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xFAFBE0", Offset = "0xFAE7E0", VA = "0x180FAFBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> EACHAHDMLII
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4D46190", Offset = "0x4D44D90", VA = "0x184D46190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> EAGDKACGDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3F27B40", Offset = "0x3F26740", VA = "0x183F27B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject DPAECMOKAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x584A30", Offset = "0x583630", VA = "0x180584A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x671A50", Offset = "0x670650", VA = "0x180671A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte MIGMMAABECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4D461F0", Offset = "0x4D44DF0", VA = "0x184D461F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D46240", Offset = "0x4D44E40", VA = "0x184D46240")]
	public MNNNKGBOBGA(List<PNHIBHNBCJG> LAPJNLKCLLJ, List<PNHIBHNBCJG> BHAMBJJANIB, List<Transform> CBNIPJENLPL, Material IKKLJDCGDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D45FF0", Offset = "0x4D44BF0", VA = "0x184D45FF0")]
	private int DPIKMNHHOBI(List<PNHIBHNBCJG> CIEFFMPPCJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D45D60", Offset = "0x4D44960", VA = "0x184D45D60")]
	private void DGJKFGFPFOC(int EFLPEFMGBDF, bool DLLAMHDJPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D45F00", Offset = "0x4D44B00", VA = "0x184D45F00")]
	public void DNGNKOAFOKM(Vector3 LOJFDHDBNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D46100", Offset = "0x4D44D00", VA = "0x184D46100", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D45EC0", Offset = "0x4D44AC0", VA = "0x184D45EC0")]
	public void DMAABCDFBCK(Transform HDBMLDDAOLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KLFOJGDEDIO : NHFKLBBFDLH, GNBJJHBFELM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FBFENNMJBPO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KLFOJGDEDIO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x66D3E0", Offset = "0x66BFE0", VA = "0x18066D3E0")]
		[DebuggerHidden]
		public FBFENNMJBPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4D40D00", Offset = "0x4D3F900", VA = "0x184D40D00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4D40850", Offset = "0x4D3F450", VA = "0x184D40850", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4D40E80", Offset = "0x4D3FA80", VA = "0x184D40E80")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4D40EC0", Offset = "0x4D3FAC0", VA = "0x184D40EC0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4D40F10", Offset = "0x4D3FB10", VA = "0x184D40F10")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4D40CB0", Offset = "0x4D3F8B0", VA = "0x184D40CB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4D40C10", Offset = "0x4D3F810", VA = "0x184D40C10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4D40C10", Offset = "0x4D3F810", VA = "0x184D40C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HFIBPLPFCNH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KLFOJGDEDIO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x66D3E0", Offset = "0x66BFE0", VA = "0x18066D3E0")]
		[DebuggerHidden]
		public HFIBPLPFCNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4D42430", Offset = "0x4D41030", VA = "0x184D42430", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4D42090", Offset = "0x4D40C90", VA = "0x184D42090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4D42550", Offset = "0x4D41150", VA = "0x184D42550")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4D425A0", Offset = "0x4D411A0", VA = "0x184D425A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4D423E0", Offset = "0x4D40FE0", VA = "0x184D423E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4D42340", Offset = "0x4D40F40", VA = "0x184D42340", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D42340", Offset = "0x4D40F40", VA = "0x184D42340", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private JIKFJEMODKO BDNENBIHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<OPPDBOGKDGP> PCLCOJNJDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> AJIBIDKNGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer FBJOLLAADHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool EBDEJDOCFDP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<JNGGENGNNGN> GOJPMKFFDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FJHCDBELJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4D43C40", Offset = "0x4D42840", VA = "0x184D43C40", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform DMFLPBIDCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4D439A0", Offset = "0x4D425A0", VA = "0x184D439A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> JLJELLHKLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55D010", Offset = "0x55BC10", VA = "0x18055D010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55D020", Offset = "0x55BC20", VA = "0x18055D020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4D44890", Offset = "0x4D43490", VA = "0x184D44890")]
	public KLFOJGDEDIO(JIKFJEMODKO FNEPNPIENNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D43C10", Offset = "0x4D42810", VA = "0x184D43C10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4D43B40", Offset = "0x4D42740", VA = "0x184D43B40")]
	public void DNJODILJGAL(OPPDBOGKDGP NDAFIGLDBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D43D10", Offset = "0x4D42910", VA = "0x184D43D10")]
	public void JGCOEHFAOLL(OPPDBOGKDGP NDAFIGLDBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4D44340", Offset = "0x4D42F40", VA = "0x184D44340", Slot = "4")]
	public void PLHJPONFLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4D43C80", Offset = "0x4D42880", VA = "0x184D43C80")]
	public void JCFJPEDKEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4D439F0", Offset = "0x4D425F0", VA = "0x184D439F0")]
	private void DJNCNBIKPGL(OPPDBOGKDGP NDAFIGLDBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4D43E60", Offset = "0x4D42A60", VA = "0x184D43E60")]
	public void OEJGFDDNJEH(bool NLOJIIMHFDC, bool FBHCDEMFIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4D43860", Offset = "0x4D42460", VA = "0x184D43860")]
	protected void APMNIPKELOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4D43D80", Offset = "0x4D42980", VA = "0x184D43D80")]
	[IteratorStateMachine(typeof(FBFENNMJBPO))]
	public IEnumerable<Renderer> KCDADOHLINA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4D43DF0", Offset = "0x4D429F0", VA = "0x184D43DF0")]
	[IteratorStateMachine(typeof(HFIBPLPFCNH))]
	public IEnumerable<Renderer> ODMIMNJJOHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class KJFOMOIPIHJ : OPPDBOGKDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private IMKFFMPFBOE FHCBJMFEIEP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D42FF0", Offset = "0x4D41BF0", VA = "0x184D42FF0")]
	private NativeList<IMNAEEIOGPP> NGGGDBMKJLM()
	{
		return default(NativeList<IMNAEEIOGPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4D43810", Offset = "0x4D42410", VA = "0x184D43810")]
	public KJFOMOIPIHJ(KLFOJGDEDIO AMKOBFEBOFJ, IMKFFMPFBOE FNEPNPIENNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4D42DD0", Offset = "0x4D419D0", VA = "0x184D42DD0", Slot = "13")]
	public override int DPIKMNHHOBI(IMCEDJCLDKI DOHMILLIOJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4D435F0", Offset = "0x4D421F0", VA = "0x184D435F0", Slot = "14")]
	public override int PBBODNDKNII(IMCEDJCLDKI DOHMILLIOJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4D430C0", Offset = "0x4D41CC0", VA = "0x184D430C0", Slot = "15")]
	public override void OFJILKDDBBF(IMCEDJCLDKI DOHMILLIOJG, GCHGOLJHCBO JIDMNHPGIDN, int IBFFAMJJMEO = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct IENAGGIFGMH : global::BGJOIFBLCCO<IENAGGIFGMH>, DDFAHKBEHOJ, IEquatable<IENAGGIFGMH>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LCGDBDLDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x784510", Offset = "0x783110", VA = "0x180784510", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x81CE80", Offset = "0x81BA80", VA = "0x18081CE80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EBJEODMLMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7844F0", Offset = "0x7830F0", VA = "0x1807844F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F6720", Offset = "0x7F5320", VA = "0x1807F6720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9050", Offset = "0x3EE7C50", VA = "0x183EE9050", Slot = "8")]
	public bool Equals(IENAGGIFGMH PJEOMNDGEFC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4D42D90", Offset = "0x4D41990", VA = "0x184D42D90")]
	public static bool JKKJHEGKOOJ(IENAGGIFGMH LANDDCNNAHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HPCGGPPCFNL
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
public interface JIKFJEMODKO
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform BMNMGILCCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	HPCGGPPCFNL EIJKPKPHNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DKKFKAHKKGJ : global::BGJOIFBLCCO<DKKFKAHKKGJ>, DDFAHKBEHOJ, IEquatable<DKKFKAHKKGJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LCGDBDLDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x784510", Offset = "0x783110", VA = "0x180784510", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x81CE80", Offset = "0x81BA80", VA = "0x18081CE80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EBJEODMLMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7844F0", Offset = "0x7830F0", VA = "0x1807844F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6720", Offset = "0x7F5320", VA = "0x1807F6720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9050", Offset = "0x3EE7C50", VA = "0x183EE9050", Slot = "8")]
	public bool Equals(DKKFKAHKKGJ PJEOMNDGEFC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4D3E450", Offset = "0x4D3D050", VA = "0x184D3E450")]
	public static bool JKKJHEGKOOJ(DKKFKAHKKGJ LANDDCNNAHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface APKEOEABLBG
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform BMNMGILCCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float GBGPABENBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 CHNLHBJBPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GLCEFHNBIFP NHNMIPHHFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MLIMIBOGCDN EIICOJPFMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FCHLKBGDALF : APKEOEABLBG
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MAKABFPPCEE GDAGEFFGFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EBKNFJIKJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IMKFFMPFBOE : APKEOEABLBG
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool HDGGGEFIFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NGABGDJECKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float CDNPHILAKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int CADGPFBKOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HPFAOFEOHHP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<IMNAEEIOGPP> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EDEGLFLEMPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHBIEGFKIBM(DKKFKAHKKGJ NDAFIGLDBHD, DLOBCNCKIPI JJLNOCNOMJN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHBIEGFKIBM(IENAGGIFGMH AMKOBFEBOFJ, DLOBCNCKIPI JJLNOCNOMJN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBGLDLMMADI(IENAGGIFGMH AMKOBFEBOFJ);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBGLDLMMADI(DKKFKAHKKGJ NDAFIGLDBHD);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCJPHKPNDNM(IENAGGIFGMH AMKOBFEBOFJ, EIMBCDABDIE CEEEOOFNMPD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCABMBDHGDL(IENAGGIFGMH AMKOBFEBOFJ, Vector3 FBGMMGBJNIJ, Vector3 PAHGJLLPBAD, Vector3 DDBMNCKICPO, float BPHDGGEAEBL, float APPIDPEKFJB, IReadOnlyList<Camera> JALKFCPGEHF, OILEEBPHNIN HLEFJHPEMGN);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HCABMBDHGDL(HBPBCBIFDOJ NCAAHDKFGME, Vector3 FBGMMGBJNIJ, Vector3 PAHGJLLPBAD, Vector3 DDBMNCKICPO, float BPHDGGEAEBL, float APPIDPEKFJB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OADOHJLADGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IENAGGIFGMH BLJFEPGNMFE(JIKFJEMODKO FNEPNPIENNL);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLMFPBKAFJD(IENAGGIFGMH AMKOBFEBOFJ);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNPGHIPHMHL(IENAGGIFGMH AMKOBFEBOFJ);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DKKFKAHKKGJ IDJFNDAGBLP(IENAGGIFGMH AMKOBFEBOFJ, FCHLKBGDALF FNEPNPIENNL);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DKKFKAHKKGJ IMBENHNJINA(IENAGGIFGMH AMKOBFEBOFJ, IMKFFMPFBOE FNEPNPIENNL);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FEKGDHLHDOD(DKKFKAHKKGJ NDAFIGLDBHD);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OGHAHBEHACJ(DKKFKAHKKGJ NDAFIGLDBHD);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HBPBCBIFDOJ OONFBGALCIP(BCLAAMANHEF FNEPNPIENNL);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JBBJFOFOEBH(HBPBCBIFDOJ NCAAHDKFGME);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DIEKOFIPAML(HBPBCBIFDOJ NCAAHDKFGME);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LBINJGCGJPI CGDMJJPEEBK(Transform OJKJBHANAIA, IEnumerable<DKKFKAHKKGJ> PCLCOJNJDAE, int LNPDMIJMHEM);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> NAKFJHDECPF(IENAGGIFGMH AMKOBFEBOFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HBPBCBIFDOJ : global::BGJOIFBLCCO<HBPBCBIFDOJ>, DDFAHKBEHOJ, IEquatable<HBPBCBIFDOJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LCGDBDLDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x784510", Offset = "0x783110", VA = "0x180784510", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x81CE80", Offset = "0x81BA80", VA = "0x18081CE80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int EBJEODMLMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7844F0", Offset = "0x7830F0", VA = "0x1807844F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7F6720", Offset = "0x7F5320", VA = "0x1807F6720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9050", Offset = "0x3EE7C50", VA = "0x183EE9050", Slot = "8")]
	public bool Equals(HBPBCBIFDOJ PJEOMNDGEFC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4D41100", Offset = "0x4D3FD00", VA = "0x184D41100")]
	public static bool JKKJHEGKOOJ(HBPBCBIFDOJ LANDDCNNAHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BCLAAMANHEF
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int GIIKGPPALJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform GHAKFGPGCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool ODNFLGCEEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IENAGGIFGMH GetBone(int NPMCMFNDIKA);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int NPMCMFNDIKA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class OLBJPLMJAOC : OPPDBOGKDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public FCHLKBGDALF OGCDGCIJLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] ALBFJOHNGIO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override PDLKBNNDGAA HCGLNOFIEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4D465A0", Offset = "0x4D451A0", VA = "0x184D465A0", Slot = "12")]
		get
		{
			return default(PDLKBNNDGAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 KFEMPGFBFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4D46940", Offset = "0x4D45540", VA = "0x184D46940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4D43810", Offset = "0x4D42410", VA = "0x184D43810")]
	public OLBJPLMJAOC(KLFOJGDEDIO AMKOBFEBOFJ, FCHLKBGDALF FNEPNPIENNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4D46D60", Offset = "0x4D45960", VA = "0x184D46D60", Slot = "11")]
	public override bool NEBLLFGGIPN(Transform AMKOBFEBOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4D46500", Offset = "0x4D45100", VA = "0x184D46500", Slot = "13")]
	public override int DPIKMNHHOBI(IMCEDJCLDKI DOHMILLIOJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4D47910", Offset = "0x4D46510", VA = "0x184D47910", Slot = "14")]
	public override int PBBODNDKNII(IMCEDJCLDKI DOHMILLIOJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4D46B20", Offset = "0x4D45720", VA = "0x184D46B20")]
	private int KFMABKOLBFO(IMCEDJCLDKI DOHMILLIOJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4D47260", Offset = "0x4D45E60", VA = "0x184D47260", Slot = "15")]
	public override void OFJILKDDBBF(IMCEDJCLDKI DOHMILLIOJG, GCHGOLJHCBO JIDMNHPGIDN, int IBFFAMJJMEO = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CKPPFMJGOIN
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOMNHGHADMJ(EIMBCDABDIE CEEEOOFNMPD, Renderer HMFBPKLBEFA, int KAJDGNCFDED);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENNKNBAGHHK(Renderer HMFBPKLBEFA, OILEEBPHNIN HLEFJHPEMGN, Vector3 FBGMMGBJNIJ, Vector3 PAHGJLLPBAD, Vector3 DDBMNCKICPO, float BPHDGGEAEBL, float APPIDPEKFJB, float HDGGMELAEKN = -1f, [Optional] Color? IFMMHPFAIHO, [Optional] IReadOnlyList<Camera> MKNLMDMOBMP);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIPOMFDCDIH(Renderer HMFBPKLBEFA, int KAJDGNCFDED);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DLHNKCIHDCJ();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DEMEIOEOEKB(int ECJFPBODBNP, DLOBCNCKIPI CEEEOOFNMPD, Renderer HMFBPKLBEFA, int KAJDGNCFDED);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EKACAKKDHLG : EDEGLFLEMPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CKPPFMJGOIN HJIHIKHPBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly LGHBHNLFPOC FNMAIFEKDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer EEMGLINHLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private NGEEGMEBCLK FIDMNBGCEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer FIKGECPDKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private NGEEGMEBCLK GDLELFNDJEE;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x56F990", Offset = "0x56E590", VA = "0x18056F990")]
	public EKACAKKDHLG(CKPPFMJGOIN PLMABMMHLDB, LGHBHNLFPOC FNMAIFEKDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4D3F620", Offset = "0x4D3E220", VA = "0x184D3F620", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D40400", Offset = "0x4D3F000", VA = "0x184D40400", Slot = "4")]
	public void LHBIEGFKIBM(DKKFKAHKKGJ NDAFIGLDBHD, DLOBCNCKIPI JJLNOCNOMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4D40680", Offset = "0x4D3F280", VA = "0x184D40680", Slot = "5")]
	public void LHBIEGFKIBM(IENAGGIFGMH AMKOBFEBOFJ, DLOBCNCKIPI JJLNOCNOMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4D400C0", Offset = "0x4D3ECC0", VA = "0x184D400C0", Slot = "6")]
	public void JBGLDLMMADI(IENAGGIFGMH AMKOBFEBOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4D3FE70", Offset = "0x4D3EA70", VA = "0x184D3FE70", Slot = "7")]
	public void JBGLDLMMADI(DKKFKAHKKGJ NDAFIGLDBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4D40260", Offset = "0x4D3EE60", VA = "0x184D40260", Slot = "8")]
	public void LCJPHKPNDNM(IENAGGIFGMH AMKOBFEBOFJ, EIMBCDABDIE CEEEOOFNMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4D3F770", Offset = "0x4D3E370", VA = "0x184D3F770", Slot = "9")]
	public void HCABMBDHGDL(IENAGGIFGMH AMKOBFEBOFJ, Vector3 FBGMMGBJNIJ, Vector3 PAHGJLLPBAD, Vector3 DDBMNCKICPO, float BPHDGGEAEBL, float APPIDPEKFJB, IReadOnlyList<Camera> JALKFCPGEHF, OILEEBPHNIN HLEFJHPEMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4D3FAA0", Offset = "0x4D3E6A0", VA = "0x184D3FAA0", Slot = "10")]
	public void HCABMBDHGDL(HBPBCBIFDOJ NCAAHDKFGME, Vector3 FBGMMGBJNIJ, Vector3 PAHGJLLPBAD, Vector3 DDBMNCKICPO, float BPHDGGEAEBL, float APPIDPEKFJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class OPPDBOGKDGP : PBFGMFODGGJ, JNGGENGNNGN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds BFOLAGAHFCL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KLFOJGDEDIO DPAECMOKAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds LFCNGOFLBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x13A8F10", Offset = "0x13A7B10", VA = "0x1813A8F10", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual PDLKBNNDGAA HCGLNOFIEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4D47A20", Offset = "0x4D46620", VA = "0x184D47A20", Slot = "12")]
		get
		{
			return default(PDLKBNNDGAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4D479B0", Offset = "0x4D465B0", VA = "0x184D479B0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x55CEC0", Offset = "0x55BAC0", VA = "0x18055CEC0", Slot = "11")]
	public virtual bool NEBLLFGGIPN(Transform AMKOBFEBOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int DPIKMNHHOBI(IMCEDJCLDKI DOHMILLIOJG);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int PBBODNDKNII(IMCEDJCLDKI DOHMILLIOJG);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void OFJILKDDBBF(IMCEDJCLDKI DOHMILLIOJG, GCHGOLJHCBO JIDMNHPGIDN, int IBFFAMJJMEO = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	protected OPPDBOGKDGP()
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
		[Cpp2IlInjected.Address(RVA = "0x4D48C00", Offset = "0x4D47800", VA = "0x184D48C00")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum MAKABFPPCEE
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
public static class HEMMDPBLKEN
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HHKCKLAHFKO : IEnumerable<HEDCCJKGJCC>, IEnumerable, IEnumerator<HEDCCJKGJCC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private HEDCCJKGJCC <>2__current;

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
		private HEDCCJKGJCC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x66D3E0", Offset = "0x66BFE0", VA = "0x18066D3E0")]
		[DebuggerHidden]
		public HHKCKLAHFKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4D425E0", Offset = "0x4D411E0", VA = "0x184D425E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4D42750", Offset = "0x4D41350", VA = "0x184D42750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D426C0", Offset = "0x4D412C0", VA = "0x184D426C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HEDCCJKGJCC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4D426C0", Offset = "0x4D412C0", VA = "0x184D426C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int FMHIGGOEOLE = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static HEDCCJKGJCC[][] IOLCPDPJNPO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static FFEHHCBJIDA OJAJINHGPKI;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig IIFICHHPKMO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader HHALGNCLPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4D41D00", Offset = "0x4D40900", VA = "0x184D41D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer CLGIFJCBOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4D41870", Offset = "0x4D40470", VA = "0x184D41870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4D41F30", Offset = "0x4D40B30", VA = "0x184D41F30")]
	public static Mesh KLODEOIEFCM(MAKABFPPCEE KKJGACPOLME, int DOHMILLIOJG = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4D41860", Offset = "0x4D40460", VA = "0x184D41860")]
	public static int CJFOHGGEFBG(MAKABFPPCEE KKJGACPOLME, int DOHMILLIOJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4D41DE0", Offset = "0x4D409E0", VA = "0x184D41DE0")]
	public static FFEHHCBJIDA IMDPEHCFMDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4D41D80", Offset = "0x4D40980", VA = "0x184D41D80")]
	[IteratorStateMachine(typeof(HHKCKLAHFKO))]
	private static IEnumerable<HEDCCJKGJCC> HMFIILHHCEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4D41140", Offset = "0x4D3FD40", VA = "0x184D41140")]
	public static HEDCCJKGJCC AMGFKOCFILP(MAKABFPPCEE KKJGACPOLME, int DOHMILLIOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4D41FF0", Offset = "0x4D40BF0", VA = "0x184D41FF0")]
	public static bool LKCDBNJEAAM(this MAKABFPPCEE KKJGACPOLME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4D416A0", Offset = "0x4D402A0", VA = "0x184D416A0")]
	public static void BPDGIKBJJBO(MAKABFPPCEE KKJGACPOLME, float3 LICEFAHEEIC, out ACOIJJCKGAI FEFKFAFPDLD, out float3 KGMDOPENNEB, out float FGLONOBMIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4D418E0", Offset = "0x4D404E0", VA = "0x184D418E0")]
	public static void EFLEAJDKEGK(Vector3 LICEFAHEEIC, MAKABFPPCEE KKJGACPOLME, out Vector3 KGMDOPENNEB, out float FGLONOBMIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D41D70", Offset = "0x4D40970", VA = "0x184D41D70")]
	[ACEHNGBCINE(FAJKELLEMII.ExitingPlayMode, 0)]
	private static void GJJPIHCAIHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4D41480", Offset = "0x4D40080", VA = "0x184D41480")]
	[ACEHNGBCINE(FAJKELLEMII.ExitingPlayMode, 0)]
	private static void BGPLHKGHGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MABKLGIPHID
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool FOCNCEFPOML
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material ILKOBFFALPJ();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material PKABLDIOOED();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material FAMJCNCPAOI();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KFOHPAFKJMD(GLCEFHNBIFP AHHDPDCJCAJ);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int PNFECPIMODP(MLIMIBOGCDN EMICDKGFACL);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDJPCBEMBMM(GameObject NJBMHJCLPCJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IKLOMKNLNOH(GameObject NJBMHJCLPCJ, bool KEHCPIDHKAH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface LGHBHNLFPOC
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	KLFOJGDEDIO ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	OPPDBOGKDGP ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MMKPDOOKCLN ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class EAGHHFPMDHH : OADOHJLADGA, IDisposable, LGHBHNLFPOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::CIHNDCBFLJP<IENAGGIFGMH, KLFOJGDEDIO> IMNPAMCICMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::CIHNDCBFLJP<DKKFKAHKKGJ, OPPDBOGKDGP> PCLCOJNJDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::CIHNDCBFLJP<HBPBCBIFDOJ, MMKPDOOKCLN> DNABHEEHBHJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static MABKLGIPHID KHFIAHMGOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4D3EA50", Offset = "0x4D3D650", VA = "0x184D3EA50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4D3EF20", Offset = "0x4D3DB20", VA = "0x184D3EF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KLFOJGDEDIO ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4D3EE60", Offset = "0x4D3DA60", VA = "0x184D3EE60", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public OPPDBOGKDGP ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4D3EE00", Offset = "0x4D3DA00", VA = "0x184D3EE00", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public MMKPDOOKCLN ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4D3EEC0", Offset = "0x4D3DAC0", VA = "0x184D3EEC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4D3F1B0", Offset = "0x4D3DDB0", VA = "0x184D3F1B0")]
	public EAGHHFPMDHH(MABKLGIPHID PLMABMMHLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4D3E9E0", Offset = "0x4D3D5E0", VA = "0x184D3E9E0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4D3E490", Offset = "0x4D3D090", VA = "0x184D3E490", Slot = "4")]
	public IENAGGIFGMH BLJFEPGNMFE(JIKFJEMODKO FNEPNPIENNL)
	{
		return default(IENAGGIFGMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D3EB60", Offset = "0x4D3D760", VA = "0x184D3EB60", Slot = "5")]
	public void HLMFPBKAFJD(IENAGGIFGMH AMKOBFEBOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D3EAF0", Offset = "0x4D3D6F0", VA = "0x184D3EAF0", Slot = "6")]
	public void GNPGHIPHMHL(IENAGGIFGMH AMKOBFEBOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D3EF70", Offset = "0x4D3DB70", VA = "0x184D3EF70", Slot = "15")]
	public IEnumerable<Renderer> NAKFJHDECPF(IENAGGIFGMH AMKOBFEBOFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D3EBC0", Offset = "0x4D3D7C0", VA = "0x184D3EBC0", Slot = "7")]
	public DKKFKAHKKGJ IDJFNDAGBLP(IENAGGIFGMH AMKOBFEBOFJ, FCHLKBGDALF FNEPNPIENNL)
	{
		return default(DKKFKAHKKGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D3ECB0", Offset = "0x4D3D8B0", VA = "0x184D3ECB0", Slot = "8")]
	public DKKFKAHKKGJ IMBENHNJINA(IENAGGIFGMH AMKOBFEBOFJ, IMKFFMPFBOE FNEPNPIENNL)
	{
		return default(DKKFKAHKKGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4D3F030", Offset = "0x4D3DC30", VA = "0x184D3F030", Slot = "10")]
	public void OGHAHBEHACJ(DKKFKAHKKGJ NDAFIGLDBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4D3EA90", Offset = "0x4D3D690", VA = "0x184D3EA90", Slot = "9")]
	public void FEKGDHLHDOD(DKKFKAHKKGJ NDAFIGLDBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4D3F0A0", Offset = "0x4D3DCA0", VA = "0x184D3F0A0", Slot = "11")]
	public HBPBCBIFDOJ OONFBGALCIP(BCLAAMANHEF FNEPNPIENNL)
	{
		return default(HBPBCBIFDOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4D3E970", Offset = "0x4D3D570", VA = "0x184D3E970", Slot = "13")]
	public void DIEKOFIPAML(HBPBCBIFDOJ NCAAHDKFGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4D3EDA0", Offset = "0x4D3D9A0", VA = "0x184D3EDA0", Slot = "12")]
	public void JBBJFOFOEBH(HBPBCBIFDOJ NCAAHDKFGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4D3E570", Offset = "0x4D3D170", VA = "0x184D3E570", Slot = "14")]
	public LBINJGCGJPI CGDMJJPEEBK(Transform OJKJBHANAIA, IEnumerable<DKKFKAHKKGJ> PCLCOJNJDAE, int LNPDMIJMHEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MMKPDOOKCLN : NHFKLBBFDLH
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class BFHKGJDHFCA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public MMKPDOOKCLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x66D3E0", Offset = "0x66BFE0", VA = "0x18066D3E0")]
		[DebuggerHidden]
		public BFHKGJDHFCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4D3E370", Offset = "0x4D3CF70", VA = "0x184D3E370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4D3E090", Offset = "0x4D3CC90", VA = "0x184D3E090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4D3E410", Offset = "0x4D3D010", VA = "0x184D3E410")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4D3E320", Offset = "0x4D3CF20", VA = "0x184D3E320", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4D3E280", Offset = "0x4D3CE80", VA = "0x184D3E280", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4D3E280", Offset = "0x4D3CE80", VA = "0x184D3E280", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly BCLAAMANHEF IECFGLILMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly LGHBHNLFPOC FNMAIFEKDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MNNNKGBOBGA PMBDDCOOJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<PNHIBHNBCJG> FBGGDOECFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<PNHIBHNBCJG> DGNMDFPOPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject KENGFHKOKHF;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4D44D40", Offset = "0x4D43940", VA = "0x184D44D40")]
	public static MMKPDOOKCLN HAAFEALNCPN(BCLAAMANHEF FNEPNPIENNL, LGHBHNLFPOC FNMAIFEKDJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4D45A90", Offset = "0x4D44690", VA = "0x184D45A90")]
	private MMKPDOOKCLN(BCLAAMANHEF FNEPNPIENNL, LGHBHNLFPOC FNMAIFEKDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4D44920", Offset = "0x4D43520", VA = "0x184D44920")]
	public void GGKDCAFHFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4D44FF0", Offset = "0x4D43BF0", VA = "0x184D44FF0")]
	[IteratorStateMachine(typeof(BFHKGJDHFCA))]
	public IEnumerable<Renderer> KCDADOHLINA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4D45090", Offset = "0x4D43C90", VA = "0x184D45090", Slot = "4")]
	public void PLHJPONFLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4D45060", Offset = "0x4D43C60", VA = "0x184D45060")]
	private void NPJLKNKLJKH(Vector3 LOJFDHDBNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4D44E20", Offset = "0x4D43A20", VA = "0x184D44E20")]
	public void JCFJPEDKEOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PNHIBHNBCJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct LALKPFEJLOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public GCHGOLJHCBO EODMJHIAECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform INBONHLIJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int KKBBLKOEAJB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EDJNMIAMBMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public PNHIBHNBCJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public IMCEDJCLDKI lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<LALKPFEJLOL> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public EDJNMIAMBMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MNLFIKOJMGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public LBINJGCGJPI combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public EDJNMIAMBMO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public MNLFIKOJMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4D45B20", Offset = "0x4D44720", VA = "0x184D45B20")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4D45B90", Offset = "0x4D44790", VA = "0x184D45B90")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4D45BD0", Offset = "0x4D447D0", VA = "0x184D45BD0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] LHKLOBOCICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private PIMICJLNABA BFJAHGFBIIO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 BFPLAEGIHLL;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh LEAAFFMBIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int HFKMAMHBLNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8670", Offset = "0x5E7270", VA = "0x1805E8670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x68BAF0", Offset = "0x68A6F0", VA = "0x18068BAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D48190", Offset = "0x4D46D90", VA = "0x184D48190")]
	public void KGLIPNENOOD(List<Transform> CNMIJCNGDNK, Matrix4x4[] AJMDCKOHOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D47C30", Offset = "0x4D46830", VA = "0x184D47C30")]
	public static List<PNHIBHNBCJG> KGHLJHHMDNN(List<KLFOJGDEDIO> GJLABJOFACK, IMCEDJCLDKI DOHMILLIOJG, Bounds OIBAKLLOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4D48390", Offset = "0x4D46F90", VA = "0x184D48390")]
	private JobHandle NHAGCAKIDBG(LBINJGCGJPI IFMDKGIMHHO, int KOKGNKOPEIA, int KDIDPAFPFDN, IMCEDJCLDKI DOHMILLIOJG, List<LALKPFEJLOL> DMKDFODKEPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D47B30", Offset = "0x4D46730", VA = "0x184D47B30")]
	private void EGOCKCONGNH(List<LALKPFEJLOL> DMKDFODKEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D48850", Offset = "0x4D47450", VA = "0x184D48850")]
	private PNHIBHNBCJG(List<LALKPFEJLOL> DMKDFODKEPP, int KOKGNKOPEIA, int KDIDPAFPFDN, IMCEDJCLDKI DOHMILLIOJG, Bounds OIBAKLLOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4D47AB0", Offset = "0x4D466B0", VA = "0x184D47AB0", Slot = "4")]
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
		private MaterialPropertyBlock LOBINIFBJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private PNHIBHNBCJG BOPDJBBKDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> CBNIPJENLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture CIBFEOCIKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer CGFBMPBGGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader LDKMAMBJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] GFKJKNCPKHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int JKHPDJPGEOC;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer CIJMMOPINLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x55C4A0", Offset = "0x55B0A0", VA = "0x18055C4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int GIIKGPPALJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4D497A0", Offset = "0x4D483A0", VA = "0x184D497A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4D48C30", Offset = "0x4D47830", VA = "0x184D48C30")]
		public static List<SkinnedShapeRenderer> Create(GameObject AMKOBFEBOFJ, List<PNHIBHNBCJG> CIEFFMPPCJJ, List<Transform> CBNIPJENLPL, Material IKKLJDCGDJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4D48E40", Offset = "0x4D47A40", VA = "0x184D48E40")]
		public void Init(PNHIBHNBCJG BOPDJBBKDBP, List<Transform> CBNIPJENLPL, Material IKKLJDCGDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4D49710", Offset = "0x4D48310", VA = "0x184D49710")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4D49680", Offset = "0x4D48280", VA = "0x184D49680")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4D49640", Offset = "0x4D48240", VA = "0x184D49640")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4D495B0", Offset = "0x4D481B0", VA = "0x184D495B0")]
		private void NFEEJGKOPIP(ScriptableRenderContext MODEPFIKGLJ, Camera[] PBMNEFPLKBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4D49260", Offset = "0x4D47E60", VA = "0x184D49260")]
		private void KGLIPNENOOD(CommandBuffer IENFHPEJKKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HNGLDPHHCGI
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] HNCEJLIIPMJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int GPLDKCDHCAH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int JHGLEHDFIPO;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger ALPCFLGFGJH;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public HNGLDPHHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4D427A0", Offset = "0x4D413A0", VA = "0x184D427A0")]
	private static string CHLEKPLKKKF(byte[] GONCOEMNHPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4D428A0", Offset = "0x4D414A0", VA = "0x184D428A0")]
	public static string KBPCOEPOAHA(byte[] EDEEEGMMOHA, bool EDDELBNCJAF)
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
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
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
