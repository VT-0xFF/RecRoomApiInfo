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
public enum FJKMEOPNDGG
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
public static class DABKHJAHEFH
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<FJKMEOPNDGG> OBKAGHBHJAB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA380", Offset = "0x4DF8D80", VA = "0x184DFA380")]
	static DABKHJAHEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA380", Offset = "0x4DF8D80", VA = "0x184DFA380")]
	[FJICHKELHED]
	private static void LPDEJFLNIEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA300", Offset = "0x4DF8D00", VA = "0x184DFA300")]
	public static bool JGJKLFDHHEF(this FJKMEOPNDGG AKGPBMLKIBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IIOAHOMEEGA
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
public enum EFAMMGANPNP
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
public enum CAFBEPNNPMK
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
public enum DEOMEEOBOGG
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
public class AOLOAHJPJJJ : EKJHEBEFBCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte EMKPAOBELCM = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte ELNOMFJNIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] FJPBODEMBML;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NBPHIALCGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5889B0", Offset = "0x5873B0", VA = "0x1805889B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6974A0", Offset = "0x695EA0", VA = "0x1806974A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EGJLEHJBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5889A0", Offset = "0x5873A0", VA = "0x1805889A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x774D10", Offset = "0x773710", VA = "0x180774D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float LOBCJBGCMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98E8A0", Offset = "0x98D2A0", VA = "0x18098E8A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB7B780", Offset = "0xB7A180", VA = "0x180B7B780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OAKBJFBPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D5100", Offset = "0x6D3B00", VA = "0x1806D5100", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D5120", Offset = "0x6D3B20", VA = "0x1806D5120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GCMFBIEFAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4DF8A50", Offset = "0x4DF7450", VA = "0x184DF8A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> CKEKMAAENOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x156FC80", Offset = "0x156E680", VA = "0x18156FC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject OOHCCBDKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x563A10", Offset = "0x562410", VA = "0x180563A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x638A00", Offset = "0x637400", VA = "0x180638A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte FPEGECKFKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4DF8AF0", Offset = "0x4DF74F0", VA = "0x184DF8AF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8D90", Offset = "0x4DF7790", VA = "0x184DF8D90")]
	public AOLOAHJPJJJ(List<IIEGENAOIDF> ILBEFIBFMPC, List<IIEGENAOIDF> KIHFLJLEGFP, List<Transform> DOICBBMCBEJ, Material KFBCCEEBAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8810", Offset = "0x4DF7210", VA = "0x184DF8810")]
	private int AMDABMDFAGE(List<IIEGENAOIDF> FIJECPPAIPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8B40", Offset = "0x4DF7540", VA = "0x184DF8B40")]
	private void LBAEFDAPCGE(int AHKICEGIOAE, bool CEJHMGDHMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8CA0", Offset = "0x4DF76A0", VA = "0x184DF8CA0")]
	public void NMGAIAPGPNE(Vector3 NPFGBLLKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8920", Offset = "0x4DF7320", VA = "0x184DF8920", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8AB0", Offset = "0x4DF74B0", VA = "0x184DF8AB0")]
	public void FFCCJMLNAAO(Transform POEBOIMPGGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BIJBIMOACMI : NKMGCNOGOGF, KCDCFEGOCBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EMAGFAMPMPF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BIJBIMOACMI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F9380", Offset = "0x6F7D80", VA = "0x1806F9380")]
		[DebuggerHidden]
		public EMAGFAMPMPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD520", Offset = "0x4DFBF20", VA = "0x184DFD520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD070", Offset = "0x4DFBA70", VA = "0x184DFD070", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD6A0", Offset = "0x4DFC0A0", VA = "0x184DFD6A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD6E0", Offset = "0x4DFC0E0", VA = "0x184DFD6E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD730", Offset = "0x4DFC130", VA = "0x184DFD730")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD4D0", Offset = "0x4DFBED0", VA = "0x184DFD4D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD430", Offset = "0x4DFBE30", VA = "0x184DFD430", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD430", Offset = "0x4DFBE30", VA = "0x184DFD430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DLDOKJGFIDP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BIJBIMOACMI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F9380", Offset = "0x6F7D80", VA = "0x1806F9380")]
		[DebuggerHidden]
		public DLDOKJGFIDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4DFBA50", Offset = "0x4DFA450", VA = "0x184DFBA50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4DFB6B0", Offset = "0x4DFA0B0", VA = "0x184DFB6B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4DFBB70", Offset = "0x4DFA570", VA = "0x184DFBB70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4DFBBC0", Offset = "0x4DFA5C0", VA = "0x184DFBBC0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4DFBA00", Offset = "0x4DFA400", VA = "0x184DFBA00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4DFB960", Offset = "0x4DFA360", VA = "0x184DFB960", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4DFB960", Offset = "0x4DFA360", VA = "0x184DFB960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private CPMIIMNAJPP KELAGAECJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<GJMDEMKDHEC> DMGCAAGHDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> KLNDPHGPPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer OIENMDONCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool MJDJGJHFINK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<FKIIHBDDFPH> JMBHAPLDHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MGKKJPDDNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA0E0", Offset = "0x4DF8AE0", VA = "0x184DFA0E0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform GJPKOAJMMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4DF96B0", Offset = "0x4DF80B0", VA = "0x184DF96B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PINCMBBIOED
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5644A0", Offset = "0x562EA0", VA = "0x1805644A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x588CD0", Offset = "0x5876D0", VA = "0x180588CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA270", Offset = "0x4DF8C70", VA = "0x184DFA270")]
	public BIJBIMOACMI(CPMIIMNAJPP CIBAGEDPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4DF98D0", Offset = "0x4DF82D0", VA = "0x184DF98D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9770", Offset = "0x4DF8170", VA = "0x184DF9770")]
	public void CEGAKGBDODP(GJMDEMKDHEC DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9860", Offset = "0x4DF8260", VA = "0x184DF9860")]
	public void DFDJPGANONL(GJMDEMKDHEC DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4DF90C0", Offset = "0x4DF7AC0", VA = "0x184DF90C0", Slot = "4")]
	public void BGDNFCPCDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA030", Offset = "0x4DF8A30", VA = "0x184DFA030")]
	public void JCPEDGKMAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA120", Offset = "0x4DF8B20", VA = "0x184DFA120")]
	private void PPBPDCOFJAJ(GJMDEMKDHEC DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9970", Offset = "0x4DF8370", VA = "0x184DF9970")]
	public void GOLAPBKKKKA(bool MHGLIDBOIMA, bool HGAMLFPJGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9EF0", Offset = "0x4DF88F0", VA = "0x184DF9EF0")]
	protected void ILGBFMFIGAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9700", Offset = "0x4DF8100", VA = "0x184DF9700")]
	[IteratorStateMachine(typeof(EMAGFAMPMPF))]
	public IEnumerable<Renderer> CCDMONLDPIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9900", Offset = "0x4DF8300", VA = "0x184DF9900")]
	[IteratorStateMachine(typeof(DLDOKJGFIDP))]
	public IEnumerable<Renderer> GCDHANCCNGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class MIDAIHCDOPA : GJMDEMKDHEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private EDAOINBINCJ OCBPKMEBADG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4E01380", Offset = "0x4DFFD80", VA = "0x184E01380")]
	private NativeList<FKHBENHEGHH> LHCLMOOHPOE()
	{
		return default(NativeList<FKHBENHEGHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4DFEF30", Offset = "0x4DFD930", VA = "0x184DFEF30")]
	public MIDAIHCDOPA(BIJBIMOACMI DDLLFFEEEME, EDAOINBINCJ CIBAGEDPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4E00A10", Offset = "0x4DFF410", VA = "0x184E00A10", Slot = "13")]
	public override int AMDABMDFAGE(FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4E00C30", Offset = "0x4DFF630", VA = "0x184E00C30", Slot = "14")]
	public override int EKLCEJOICID(FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4E00E50", Offset = "0x4DFF850", VA = "0x184E00E50", Slot = "15")]
	public override void JNNLKDFEIGK(FNAOJINHLPB OPAANEOCAHH, DDNJIGMIAPI FLCPIGBNHNH, int IBEALIMNFFI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MHPDJOBMMJB : global::ICODKHMKNJJ<MHPDJOBMMJB>, JPKBKOFGKDG, IEquatable<MHPDJOBMMJB>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LJFCMJHPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x631210", Offset = "0x62FC10", VA = "0x180631210", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x736C30", Offset = "0x735630", VA = "0x180736C30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int AJBHNBBCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA9C150", Offset = "0xA9AB50", VA = "0x180A9C150", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xBC1570", Offset = "0xBBFF70", VA = "0x180BC1570", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1560540", Offset = "0x155EF40", VA = "0x181560540", Slot = "8")]
	public bool Equals(MHPDJOBMMJB KKPJJILPNAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4E009D0", Offset = "0x4DFF3D0", VA = "0x184E009D0")]
	public static bool EDEIDOGAGHI(MHPDJOBMMJB ANNMBFABHDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum JCMAEHJHGEJ
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
public interface CPMIIMNAJPP
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform FLELOEMNDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JCMAEHJHGEJ IFAAJGGOOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AGPPPDGBKCD : global::ICODKHMKNJJ<AGPPPDGBKCD>, JPKBKOFGKDG, IEquatable<AGPPPDGBKCD>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LJFCMJHPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x631210", Offset = "0x62FC10", VA = "0x180631210", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x736C30", Offset = "0x735630", VA = "0x180736C30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int AJBHNBBCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C150", Offset = "0xA9AB50", VA = "0x180A9C150", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xBC1570", Offset = "0xBBFF70", VA = "0x180BC1570", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1560540", Offset = "0x155EF40", VA = "0x181560540", Slot = "8")]
	public bool Equals(AGPPPDGBKCD KKPJJILPNAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4DF87D0", Offset = "0x4DF71D0", VA = "0x184DF87D0")]
	public static bool EDEIDOGAGHI(AGPPPDGBKCD ANNMBFABHDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OGHNEKBLGPF
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform FLELOEMNDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float CNLPKJCIMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 HMFCKKPHBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FJKMEOPNDGG ECKGGFFAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IIOAHOMEEGA HDKAEAIBNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HOGCLBMCGKM : OGHNEKBLGPF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	JHCOMBHMCGI DPCLBKHHNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LNLDNFLCKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EDAOINBINCJ : OGHNEKBLGPF
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool ALMIJDGGOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GMBBOLLDMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float KAOEHEBEGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int ILFNHECGGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NHCJGEBFJMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<FKHBENHEGHH> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KNOMEIIENEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFEHMDFGKDE(AGPPPDGBKCD DELEJHEPEEE, CAFBEPNNPMK OCIFKCBODJN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFEHMDFGKDE(MHPDJOBMMJB DDLLFFEEEME, CAFBEPNNPMK OCIFKCBODJN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHJCHLKMCOL(MHPDJOBMMJB DDLLFFEEEME);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BHJCHLKMCOL(AGPPPDGBKCD DELEJHEPEEE);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFKAHGPHDDI(MHPDJOBMMJB DDLLFFEEEME, DEOMEEOBOGG IEADHAAGEDA);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNOENHOILOJ(MHPDJOBMMJB DDLLFFEEEME, Vector3 AMDEMIMDPIG, Vector3 OEKBIKEINBC, Vector3 KFBPAPGJGOB, float PNJCIHGCNJB, float AKNCHPABDGH, IReadOnlyList<Camera> BKOONPGEBNE, EFAMMGANPNP JBOLLCOGNHI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JNOENHOILOJ(LICGLAEBIPH HHHKPMEFAJC, Vector3 AMDEMIMDPIG, Vector3 OEKBIKEINBC, Vector3 KFBPAPGJGOB, float PNJCIHGCNJB, float AKNCHPABDGH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LFAEGBKLGBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MHPDJOBMMJB GNMINOEGHOO(CPMIIMNAJPP CIBAGEDPOOH);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMBLFDECMEL(MHPDJOBMMJB DDLLFFEEEME);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANIAEJDLDLN(MHPDJOBMMJB DDLLFFEEEME);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AGPPPDGBKCD FFCEMIHEJCD(MHPDJOBMMJB DDLLFFEEEME, HOGCLBMCGKM CIBAGEDPOOH);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AGPPPDGBKCD IALMEJPPCAC(MHPDJOBMMJB DDLLFFEEEME, EDAOINBINCJ CIBAGEDPOOH);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MPCJJGOACAJ(AGPPPDGBKCD DELEJHEPEEE);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void COHIGKDGAIL(AGPPPDGBKCD DELEJHEPEEE);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LICGLAEBIPH IMEDPHLJOMF(GMPMCHFDGEN CIBAGEDPOOH);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AKMEBPNNMMK(LICGLAEBIPH HHHKPMEFAJC);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FPOFAMHPHBE(LICGLAEBIPH HHHKPMEFAJC);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FDNGLNHKOBP LIJMKLOAMDC(Transform BEDJIMAHPNA, IEnumerable<AGPPPDGBKCD> DMGCAAGHDAH, int HLJHLJBBGGG);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> JKMGPFCNBDC(MHPDJOBMMJB DDLLFFEEEME);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LICGLAEBIPH : global::ICODKHMKNJJ<LICGLAEBIPH>, JPKBKOFGKDG, IEquatable<LICGLAEBIPH>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LJFCMJHPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x631210", Offset = "0x62FC10", VA = "0x180631210", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x736C30", Offset = "0x735630", VA = "0x180736C30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int AJBHNBBCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA9C150", Offset = "0xA9AB50", VA = "0x180A9C150", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xBC1570", Offset = "0xBBFF70", VA = "0x180BC1570", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1560540", Offset = "0x155EF40", VA = "0x181560540", Slot = "8")]
	public bool Equals(LICGLAEBIPH KKPJJILPNAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4E00990", Offset = "0x4DFF390", VA = "0x184E00990")]
	public static bool EDEIDOGAGHI(LICGLAEBIPH ANNMBFABHDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GMPMCHFDGEN
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int EHDBDLODPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform PMFCPMOOHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JKCACFMMGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MHPDJOBMMJB GetBone(int EPEDGGPALGC);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int EPEDGGPALGC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class IDCHJNGAOJI : GJMDEMKDHEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public HOGCLBMCGKM LEAKMKLMDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] BNNFDPEFJAA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override EOKOJNFCPLK LKGDNMMMDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4DFDAE0", Offset = "0x4DFC4E0", VA = "0x184DFDAE0", Slot = "12")]
		get
		{
			return default(EOKOJNFCPLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 JMMJLMDDIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4DFED50", Offset = "0x4DFD750", VA = "0x184DFED50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4DFEF30", Offset = "0x4DFD930", VA = "0x184DFEF30")]
	public IDCHJNGAOJI(BIJBIMOACMI DDLLFFEEEME, HOGCLBMCGKM CIBAGEDPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4DFE850", Offset = "0x4DFD250", VA = "0x184DFE850", Slot = "11")]
	public override bool MNMFGBAEHJA(Transform DDLLFFEEEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4DFDA40", Offset = "0x4DFC440", VA = "0x184DFDA40", Slot = "13")]
	public override int AMDABMDFAGE(FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4DFE100", Offset = "0x4DFCB00", VA = "0x184DFE100", Slot = "14")]
	public override int EKLCEJOICID(FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4DFDE80", Offset = "0x4DFC880", VA = "0x184DFDE80")]
	private int ECKBLFCPJIC(FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4DFE1A0", Offset = "0x4DFCBA0", VA = "0x184DFE1A0", Slot = "15")]
	public override void JNNLKDFEIGK(FNAOJINHLPB OPAANEOCAHH, DDNJIGMIAPI FLCPIGBNHNH, int IBEALIMNFFI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JLHOKGKDGBP
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKPPIBHFDAB(DEOMEEOBOGG IEADHAAGEDA, Renderer GAIJLBPLIBE, int GGCCHJJHIGI);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMGJLNLOFNE(Renderer GAIJLBPLIBE, EFAMMGANPNP JBOLLCOGNHI, Vector3 AMDEMIMDPIG, Vector3 OEKBIKEINBC, Vector3 KFBPAPGJGOB, float PNJCIHGCNJB, float AKNCHPABDGH, float MLLNICMCMFE = -1f, [Optional] Color? FELGEKLHNJA, [Optional] IReadOnlyList<Camera> DFOOACHGIMB);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGHLFGCIFNO(Renderer GAIJLBPLIBE, int GGCCHJJHIGI);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BHDCIKJCMGP();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFANJIGDOEI(int KPLBIIIGLKO, CAFBEPNNPMK IEADHAAGEDA, Renderer GAIJLBPLIBE, int GGCCHJJHIGI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NAMGNICJGIP : KNOMEIIENEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly JLHOKGKDGBP LDBMMCJDFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CPHDBINAMAC EMJIDAGKLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer JKKCMMGBPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private DMBGPDJFDBI ADHHJHMMNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer KLDLAECHHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private DMBGPDJFDBI NOELHBGOIOJ;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x59B610", Offset = "0x59A010", VA = "0x18059B610")]
	public NAMGNICJGIP(JLHOKGKDGBP MIKNOMCIOLJ, CPHDBINAMAC EMJIDAGKLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E01C90", Offset = "0x4E00690", VA = "0x184E01C90", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4E01A10", Offset = "0x4E00410", VA = "0x184E01A10", Slot = "4")]
	public void DFEHMDFGKDE(AGPPPDGBKCD DELEJHEPEEE, CAFBEPNNPMK OCIFKCBODJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4E01840", Offset = "0x4E00240", VA = "0x184E01840", Slot = "5")]
	public void DFEHMDFGKDE(MHPDJOBMMJB DDLLFFEEEME, CAFBEPNNPMK OCIFKCBODJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4E01450", Offset = "0x4DFFE50", VA = "0x184E01450", Slot = "6")]
	public void BHJCHLKMCOL(MHPDJOBMMJB DDLLFFEEEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4E015F0", Offset = "0x4DFFFF0", VA = "0x184E015F0", Slot = "7")]
	public void BHJCHLKMCOL(AGPPPDGBKCD DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4E024E0", Offset = "0x4E00EE0", VA = "0x184E024E0", Slot = "8")]
	public void MFKAHGPHDDI(MHPDJOBMMJB DDLLFFEEEME, DEOMEEOBOGG IEADHAAGEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4E021B0", Offset = "0x4E00BB0", VA = "0x184E021B0", Slot = "9")]
	public void JNOENHOILOJ(MHPDJOBMMJB DDLLFFEEEME, Vector3 AMDEMIMDPIG, Vector3 OEKBIKEINBC, Vector3 KFBPAPGJGOB, float PNJCIHGCNJB, float AKNCHPABDGH, IReadOnlyList<Camera> BKOONPGEBNE, EFAMMGANPNP JBOLLCOGNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4E01DE0", Offset = "0x4E007E0", VA = "0x184E01DE0", Slot = "10")]
	public void JNOENHOILOJ(LICGLAEBIPH HHHKPMEFAJC, Vector3 AMDEMIMDPIG, Vector3 OEKBIKEINBC, Vector3 KFBPAPGJGOB, float PNJCIHGCNJB, float AKNCHPABDGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class GJMDEMKDHEC : EAEJMALDCGI, FKIIHBDDFPH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds PBLIKFBCNHB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BIJBIMOACMI OOHCCBDKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds JKDFLENDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x20442D0", Offset = "0x2042CD0", VA = "0x1820442D0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual EOKOJNFCPLK LKGDNMMMDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD940", Offset = "0x4DFC340", VA = "0x184DFD940", Slot = "12")]
		get
		{
			return default(EOKOJNFCPLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4DFD9D0", Offset = "0x4DFC3D0", VA = "0x184DFD9D0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x588B90", Offset = "0x587590", VA = "0x180588B90", Slot = "11")]
	public virtual bool MNMFGBAEHJA(Transform DDLLFFEEEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int AMDABMDFAGE(FNAOJINHLPB OPAANEOCAHH);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int EKLCEJOICID(FNAOJINHLPB OPAANEOCAHH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void JNNLKDFEIGK(FNAOJINHLPB OPAANEOCAHH, DDNJIGMIAPI FLCPIGBNHNH, int IBEALIMNFFI = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	protected GJMDEMKDHEC()
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
		[Cpp2IlInjected.Address(RVA = "0x4E03990", Offset = "0x4E02390", VA = "0x184E03990")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum JHCOMBHMCGI
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
public static class OMMEBDCCCKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FJBGLMMPKIH : IEnumerable<AJPAPAIKBDC>, IEnumerable, IEnumerator<AJPAPAIKBDC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private AJPAPAIKBDC <>2__current;

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
		private AJPAPAIKBDC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F9380", Offset = "0x6F7D80", VA = "0x1806F9380")]
		[DebuggerHidden]
		public FJBGLMMPKIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD780", Offset = "0x4DFC180", VA = "0x184DFD780", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD8F0", Offset = "0x4DFC2F0", VA = "0x184DFD8F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD860", Offset = "0x4DFC260", VA = "0x184DFD860", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AJPAPAIKBDC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD860", Offset = "0x4DFC260", VA = "0x184DFD860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int HPPHHAKFJOF = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static AJPAPAIKBDC[][] HGKKHBLJGJF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static JHDHMLIDPJF JEIFMNMKGLK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig BLAAIEJNGJP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader IPPFLAJAFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4E02A60", Offset = "0x4E01460", VA = "0x184E02A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer ACPJJOBOOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4E03830", Offset = "0x4E02230", VA = "0x184E03830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4E03770", Offset = "0x4E02170", VA = "0x184E03770")]
	public static Mesh JMPOENFOBBA(JHCOMBHMCGI DHECJFKALEN, int OPAANEOCAHH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4E02EB0", Offset = "0x4E018B0", VA = "0x184E02EB0")]
	public static int GDBIMOEPMBD(JHCOMBHMCGI DHECJFKALEN, int OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4E03620", Offset = "0x4E02020", VA = "0x184E03620")]
	public static JHDHMLIDPJF IBKEMBLPFFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4E038B0", Offset = "0x4E022B0", VA = "0x184E038B0")]
	[IteratorStateMachine(typeof(FJBGLMMPKIH))]
	private static IEnumerable<AJPAPAIKBDC> PNIODOKNLIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4E02EC0", Offset = "0x4E018C0", VA = "0x184E02EC0")]
	public static AJPAPAIKBDC HKCPGGKFAPL(JHCOMBHMCGI DHECJFKALEN, int OPAANEOCAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4E02A40", Offset = "0x4E01440", VA = "0x184E02A40")]
	public static bool ANIGBKDHPMK(this JHCOMBHMCGI DHECJFKALEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4E02CF0", Offset = "0x4E016F0", VA = "0x184E02CF0")]
	public static void FMNAKIAAHKI(JHCOMBHMCGI DHECJFKALEN, float3 HONMIFJJGFA, out JDPEKGDEJHA DOOAAOLBFMB, out float3 MHFLGKCEDOH, out float FFFBIDMBCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4E03200", Offset = "0x4E01C00", VA = "0x184E03200")]
	public static void IAAKJMLMAGL(Vector3 HONMIFJJGFA, JHCOMBHMCGI DHECJFKALEN, out Vector3 MHFLGKCEDOH, out float FFFBIDMBCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4E038A0", Offset = "0x4E022A0", VA = "0x184E038A0")]
	[FJOEOFBCKFM(DEGJMHBBGDK.ExitingPlayMode, 0)]
	private static void OHBADDGMCHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4E02AD0", Offset = "0x4E014D0", VA = "0x184E02AD0")]
	[FJOEOFBCKFM(DEGJMHBBGDK.ExitingPlayMode, 0)]
	private static void EKHFELLJCIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DLFBBKAMBMM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool JBFJPCKMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material CGKGFKLPHDG();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MAOJIGDBMKO();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material LDMMAHBNAJN();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BKOMAIDDMMI(FJKMEOPNDGG DDKCCIMCMMD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CONLOIEOLJG(IIOAHOMEEGA NHIEILFLBDN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LFGGCJDNFLB(GameObject FBOGCDJOCBP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHBHJCHABPD(GameObject FBOGCDJOCBP, bool JHIILNFNAHE);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface CPHDBINAMAC
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BIJBIMOACMI INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GJMDEMKDHEC INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	EEJCNLJPJGP INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class DKIINNHGNKG : LFAEGBKLGBC, IDisposable, CPHDBINAMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::MFPGGCIEKBM<MHPDJOBMMJB, BIJBIMOACMI> MKDIAOIJAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::MFPGGCIEKBM<AGPPPDGBKCD, GJMDEMKDHEC> DMGCAAGHDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::MFPGGCIEKBM<LICGLAEBIPH, EEJCNLJPJGP> MHHIHDPGOBB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static DLFBBKAMBMM FCCMLGDFIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4DFAA10", Offset = "0x4DF9410", VA = "0x184DFAA10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4DFB1F0", Offset = "0x4DF9BF0", VA = "0x184DFB1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BIJBIMOACMI INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA870", Offset = "0x4DF9270", VA = "0x184DFA870", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GJMDEMKDHEC INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA8D0", Offset = "0x4DF92D0", VA = "0x184DFA8D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public EEJCNLJPJGP INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA810", Offset = "0x4DF9210", VA = "0x184DFA810", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4DFB240", Offset = "0x4DF9C40", VA = "0x184DFB240")]
	public DKIINNHGNKG(DLFBBKAMBMM MIKNOMCIOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA640", Offset = "0x4DF9040", VA = "0x184DFA640", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA930", Offset = "0x4DF9330", VA = "0x184DFA930", Slot = "4")]
	public MHPDJOBMMJB GNMINOEGHOO(CPMIIMNAJPP CIBAGEDPOOH)
	{
		return default(MHPDJOBMMJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA5E0", Offset = "0x4DF8FE0", VA = "0x184DFA5E0", Slot = "5")]
	public void DMBLFDECMEL(MHPDJOBMMJB DDLLFFEEEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA500", Offset = "0x4DF8F00", VA = "0x184DFA500", Slot = "6")]
	public void ANIAEJDLDLN(MHPDJOBMMJB DDLLFFEEEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4DFACD0", Offset = "0x4DF96D0", VA = "0x184DFACD0", Slot = "15")]
	public IEnumerable<Renderer> JKMGPFCNBDC(MHPDJOBMMJB DDLLFFEEEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA6B0", Offset = "0x4DF90B0", VA = "0x184DFA6B0", Slot = "7")]
	public AGPPPDGBKCD FFCEMIHEJCD(MHPDJOBMMJB DDLLFFEEEME, HOGCLBMCGKM CIBAGEDPOOH)
	{
		return default(AGPPPDGBKCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DFAA50", Offset = "0x4DF9450", VA = "0x184DFAA50", Slot = "8")]
	public AGPPPDGBKCD IALMEJPPCAC(MHPDJOBMMJB DDLLFFEEEME, EDAOINBINCJ CIBAGEDPOOH)
	{
		return default(AGPPPDGBKCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA570", Offset = "0x4DF8F70", VA = "0x184DFA570", Slot = "10")]
	public void COHIGKDGAIL(AGPPPDGBKCD DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4DFB190", Offset = "0x4DF9B90", VA = "0x184DFB190", Slot = "9")]
	public void MPCJJGOACAJ(AGPPPDGBKCD DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4DFAB40", Offset = "0x4DF9540", VA = "0x184DFAB40", Slot = "11")]
	public LICGLAEBIPH IMEDPHLJOMF(GMPMCHFDGEN CIBAGEDPOOH)
	{
		return default(LICGLAEBIPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA7A0", Offset = "0x4DF91A0", VA = "0x184DFA7A0", Slot = "13")]
	public void FPOFAMHPHBE(LICGLAEBIPH HHHKPMEFAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA4A0", Offset = "0x4DF8EA0", VA = "0x184DFA4A0", Slot = "12")]
	public void AKMEBPNNMMK(LICGLAEBIPH HHHKPMEFAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4DFAD90", Offset = "0x4DF9790", VA = "0x184DFAD90", Slot = "14")]
	public FDNGLNHKOBP LIJMKLOAMDC(Transform BEDJIMAHPNA, IEnumerable<AGPPPDGBKCD> DMGCAAGHDAH, int HLJHLJBBGGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EEJCNLJPJGP : NKMGCNOGOGF
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class NPEJEBJLDEE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EEJCNLJPJGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F9380", Offset = "0x6F7D80", VA = "0x1806F9380")]
		[DebuggerHidden]
		public NPEJEBJLDEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4E02960", Offset = "0x4E01360", VA = "0x184E02960", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4E02680", Offset = "0x4E01080", VA = "0x184E02680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4E02A00", Offset = "0x4E01400", VA = "0x184E02A00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4E02910", Offset = "0x4E01310", VA = "0x184E02910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4E02870", Offset = "0x4E01270", VA = "0x184E02870", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4E02870", Offset = "0x4E01270", VA = "0x184E02870", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly GMPMCHFDGEN HPJEHLJBLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CPHDBINAMAC EMJIDAGKLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private AOLOAHJPJJJ BBAMLFONCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<IIEGENAOIDF> AGFMLJFPFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<IIEGENAOIDF> HAGOFPLFOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject GLJKNPCJNLH;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4DFC6C0", Offset = "0x4DFB0C0", VA = "0x184DFC6C0")]
	public static EEJCNLJPJGP IIMAFMCCNHM(GMPMCHFDGEN CIBAGEDPOOH, CPHDBINAMAC EMJIDAGKLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4DFCF70", Offset = "0x4DFB970", VA = "0x184DFCF70")]
	private EEJCNLJPJGP(GMPMCHFDGEN CIBAGEDPOOH, CPHDBINAMAC EMJIDAGKLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4DFCA20", Offset = "0x4DFB420", VA = "0x184DFCA20")]
	public void OHNGCEIGACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4DFC650", Offset = "0x4DFB050", VA = "0x184DFC650")]
	[IteratorStateMachine(typeof(NPEJEBJLDEE))]
	public IEnumerable<Renderer> CCDMONLDPIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4DFBC00", Offset = "0x4DFA600", VA = "0x184DFBC00", Slot = "4")]
	public void BGDNFCPCDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4DFC9F0", Offset = "0x4DFB3F0", VA = "0x184DFC9F0")]
	private void OBPOHIBCFPD(Vector3 NPFGBLLKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4DFC820", Offset = "0x4DFB220", VA = "0x184DFC820")]
	public void JCPEDGKMAKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IIEGENAOIDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct GOPEGBBABEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DDNJIGMIAPI HADGHNFOKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform NFGJIMDLEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int PGCNIMLLBFK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class IABGLGPJJOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public IIEGENAOIDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public FNAOJINHLPB lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<GOPEGBBABEA> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IABGLGPJJOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KOOGFNNHGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FDNGLNHKOBP combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public IABGLGPJJOP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public KOOGFNNHGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4E00160", Offset = "0x4DFEB60", VA = "0x184E00160")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4E001D0", Offset = "0x4DFEBD0", VA = "0x184E001D0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4E00210", Offset = "0x4DFEC10", VA = "0x184E00210")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] OCFIHAOCNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private PMDPHBDMHMF FNIIEOLDFLI;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 INCMJBGNKPJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh BMGOPFBLNOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int PAOMDMPGOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x564470", Offset = "0x562E70", VA = "0x180564470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5EF180", Offset = "0x5EDB80", VA = "0x1805EF180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4DFFA70", Offset = "0x4DFE470", VA = "0x184DFFA70")]
	public void LMFBMKLEAAK(List<Transform> JMFNFBDPCDF, Matrix4x4[] ICGFIDEBPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4DFEF80", Offset = "0x4DFD980", VA = "0x184DFEF80")]
	public static List<IIEGENAOIDF> AEEGCHIFHAD(List<BIJBIMOACMI> ECAIIOOKKHF, FNAOJINHLPB OPAANEOCAHH, Bounds MJKIPNFICIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4DFF4E0", Offset = "0x4DFDEE0", VA = "0x184DFF4E0")]
	private JobHandle AJJNFBCCKNN(FDNGLNHKOBP HPCINANDOPG, int OCBAIJNKCNN, int JJDBOJDNNBD, FNAOJINHLPB OPAANEOCAHH, List<GOPEGBBABEA> IILGELOJKMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4DFF8F0", Offset = "0x4DFE2F0", VA = "0x184DFF8F0")]
	private void DNMNNGMAKGF(List<GOPEGBBABEA> IILGELOJKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4DFFDB0", Offset = "0x4DFE7B0", VA = "0x184DFFDB0")]
	private IIEGENAOIDF(List<GOPEGBBABEA> IILGELOJKMB, int OCBAIJNKCNN, int JJDBOJDNNBD, FNAOJINHLPB OPAANEOCAHH, Bounds MJKIPNFICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4DFF9F0", Offset = "0x4DFE3F0", VA = "0x184DFF9F0", Slot = "4")]
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
		private MaterialPropertyBlock EJJLNMNJNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private IIEGENAOIDF EALEDNNEEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> DOICBBMCBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture ALAMIALEAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer PGAFHKGBMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader KENKCNAKGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] BJAMCLBBMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int OABMFIHADCE;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer JKFFGKFCNOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x567460", Offset = "0x565E60", VA = "0x180567460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int EHDBDLODPMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4E04530", Offset = "0x4E02F30", VA = "0x184E04530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4E039C0", Offset = "0x4E023C0", VA = "0x184E039C0")]
		public static List<SkinnedShapeRenderer> Create(GameObject DDLLFFEEEME, List<IIEGENAOIDF> FIJECPPAIPA, List<Transform> DOICBBMCBEJ, Material KFBCCEEBAFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4E03BD0", Offset = "0x4E025D0", VA = "0x184E03BD0")]
		public void Init(IIEGENAOIDF EALEDNNEEBC, List<Transform> DOICBBMCBEJ, Material KFBCCEEBAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4E04410", Offset = "0x4E02E10", VA = "0x184E04410")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4E04380", Offset = "0x4E02D80", VA = "0x184E04380")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4E04340", Offset = "0x4E02D40", VA = "0x184E04340")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4E044A0", Offset = "0x4E02EA0", VA = "0x184E044A0")]
		private void PMDOOCGJBOG(ScriptableRenderContext PHFLFPJELLC, Camera[] KJJJNJFBCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4E03FF0", Offset = "0x4E029F0", VA = "0x184E03FF0")]
		private void LMFBMKLEAAK(CommandBuffer LIINGCCKOCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4E006D0", Offset = "0x4DFF0D0", VA = "0x184E006D0")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4E003A0", Offset = "0x4DFEDA0", VA = "0x184E003A0")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
