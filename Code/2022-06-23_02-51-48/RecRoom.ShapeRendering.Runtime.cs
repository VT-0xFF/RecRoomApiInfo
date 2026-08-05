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
public enum FEGNBCHMNII
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
public static class DNGLPJOOJHG
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<FEGNBCHMNII> MMINHHIBLDC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF0D0", Offset = "0x4EAE2D0", VA = "0x184EAF0D0")]
	static DNGLPJOOJHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF0D0", Offset = "0x4EAE2D0", VA = "0x184EAF0D0")]
	[PMCBHEKBFGF]
	private static void GDDEOJNJOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF1F0", Offset = "0x4EAE3F0", VA = "0x184EAF1F0")]
	public static bool KHMMJKBHBGC(this FEGNBCHMNII MOOHGJCPKOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NBAAPCKLAHE
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
public enum HCOJDPFJMMJ
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
public enum EHCJBAHICEH
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
public enum AJBDBHPGKDB
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
public class HCFGCEFAFJG : BFLJBPEICKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte DKFGNLEFKKB = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte NHGOACOJIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] ODNJMPMACGD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MEKLDCAFPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x600CA0", Offset = "0x5FFEA0", VA = "0x180600CA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x814C50", Offset = "0x813E50", VA = "0x180814C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DBENGIAFECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CC160", Offset = "0x5CB360", VA = "0x1805CC160", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1D0", Offset = "0x5CB3D0", VA = "0x1805CC1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float AKLHJLJLHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCCCCC0", Offset = "0xCCBEC0", VA = "0x180CCCCC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCCC710", Offset = "0xCCB910", VA = "0x180CCC710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float LPBFLKGCMKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAB50D0", Offset = "0xAB42D0", VA = "0x180AB50D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCCD380", Offset = "0xCCC580", VA = "0x180CCD380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> KJLGKLPAPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4EB3A00", Offset = "0x4EB2C00", VA = "0x184EB3A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> EEKAEBGBAHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x407B480", Offset = "0x407A680", VA = "0x18407B480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject GHEDAMOCBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x573530", VA = "0x180574330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC170", Offset = "0x5CB370", VA = "0x1805CC170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte CJMEAKGALID
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4EB34E0", Offset = "0x4EB26E0", VA = "0x184EB34E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3A60", Offset = "0x4EB2C60", VA = "0x184EB3A60")]
	public HCFGCEFAFJG(List<JOIAJEFIJHJ> PKNNLOFHAEK, List<JOIAJEFIJHJ> JNOFOHDJIGL, List<Transform> FGPGKLDOEEG, Material JDMOJJJBGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3660", Offset = "0x4EB2860", VA = "0x184EB3660")]
	private int EMMEHAOIPHD(List<JOIAJEFIJHJ> PAPDKDBGGCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4EB38A0", Offset = "0x4EB2AA0", VA = "0x184EB38A0")]
	private void NMIFAOPEMGM(int MJLAOMIMIHF, bool NEIHOEKNJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4EB37B0", Offset = "0x4EB29B0", VA = "0x184EB37B0")]
	public void JAFKEPAGOAH(Vector3 BMDENEMNDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3530", Offset = "0x4EB2730", VA = "0x184EB3530", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3770", Offset = "0x4EB2970", VA = "0x184EB3770")]
	public void FEACJMPMIFO(Transform LDBNDPKMNCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ACGPFIDECKA : HOILCCGKDGH, EPOLJFAIFLJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MHPMHIIFGHI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public ACGPFIDECKA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9016D0", Offset = "0x9008D0", VA = "0x1809016D0")]
		[DebuggerHidden]
		public MHPMHIIFGHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7E20", Offset = "0x4EB7020", VA = "0x184EB7E20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7970", Offset = "0x4EB6B70", VA = "0x184EB7970", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7FA0", Offset = "0x4EB71A0", VA = "0x184EB7FA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7FE0", Offset = "0x4EB71E0", VA = "0x184EB7FE0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8030", Offset = "0x4EB7230", VA = "0x184EB8030")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7DD0", Offset = "0x4EB6FD0", VA = "0x184EB7DD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7D30", Offset = "0x4EB6F30", VA = "0x184EB7D30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7D30", Offset = "0x4EB6F30", VA = "0x184EB7D30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IFNCOOCJDMA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public ACGPFIDECKA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9016D0", Offset = "0x9008D0", VA = "0x1809016D0")]
		[DebuggerHidden]
		public IFNCOOCJDMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4B70", Offset = "0x4EB3D70", VA = "0x184EB4B70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4EB47D0", Offset = "0x4EB39D0", VA = "0x184EB47D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4C90", Offset = "0x4EB3E90", VA = "0x184EB4C90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4CE0", Offset = "0x4EB3EE0", VA = "0x184EB4CE0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4B20", Offset = "0x4EB3D20", VA = "0x184EB4B20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4A80", Offset = "0x4EB3C80", VA = "0x184EB4A80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4A80", Offset = "0x4EB3C80", VA = "0x184EB4A80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private AHNGJKPNAMF JCMCNFDBMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<FIAODDEEKLD> MCHIADBEGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> EKDGCHDLFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer HJBPLLEOADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool CNHIHBLBHKD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<BHABHNKEKAJ> MODIGMJLHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JGCCGDMICOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD020", Offset = "0x4EAC220", VA = "0x184EAD020", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform IOJGLNFBOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD090", Offset = "0x4EAC290", VA = "0x184EAD090", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> IIKGEHGINBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x573EE0", Offset = "0x5730E0", VA = "0x180573EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC180", Offset = "0x5CB380", VA = "0x1805CC180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE0B0", Offset = "0x4EAD2B0", VA = "0x184EAE0B0")]
	public ACGPFIDECKA(AHNGJKPNAMF NJOKIDJGNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD060", Offset = "0x4EAC260", VA = "0x184EAD060", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD0E0", Offset = "0x4EAC2E0", VA = "0x184EAD0E0")]
	public void INLOBDHPAIC(FIAODDEEKLD IGDHEGHDDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD900", Offset = "0x4EACB00", VA = "0x184EAD900")]
	public void MNIDDOJOCKH(FIAODDEEKLD IGDHEGHDDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD970", Offset = "0x4EACB70", VA = "0x184EAD970", Slot = "4")]
	public void NGHPECFEEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4EACF00", Offset = "0x4EAC100", VA = "0x184EACF00")]
	public void BOOBIECFMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4EADF60", Offset = "0x4EAD160", VA = "0x184EADF60")]
	private void OEFIFHCEHDL(FIAODDEEKLD IGDHEGHDDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD310", Offset = "0x4EAC510", VA = "0x184EAD310")]
	public void KIGKGHJPLEL(bool NMLIKILGFEB, bool LKPDMHOEOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD1D0", Offset = "0x4EAC3D0", VA = "0x184EAD1D0")]
	protected void KGDAIKFBOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4EACFB0", Offset = "0x4EAC1B0", VA = "0x184EACFB0")]
	[IteratorStateMachine(typeof(MHPMHIIFGHI))]
	public IEnumerable<Renderer> CGHEFFDILLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD890", Offset = "0x4EACA90", VA = "0x184EAD890")]
	[IteratorStateMachine(typeof(IFNCOOCJDMA))]
	public IEnumerable<Renderer> LEGIDGALJHN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class IDAHAICIEMH : FIAODDEEKLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private JODOFEGPIKK GEFILHHADKM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4EB41D0", Offset = "0x4EB33D0", VA = "0x184EB41D0")]
	private NativeList<HHEGNGLHKLA> GJJBOFNGHLI()
	{
		return default(NativeList<HHEGNGLHKLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0960", Offset = "0x4EAFB60", VA = "0x184EB0960")]
	public IDAHAICIEMH(ACGPFIDECKA ANEBBMNIFPH, JODOFEGPIKK NJOKIDJGNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3D90", Offset = "0x4EB2F90", VA = "0x184EB3D90", Slot = "13")]
	public override int EMMEHAOIPHD(PBGEDNJMKOF KJBOHPEHFAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3FB0", Offset = "0x4EB31B0", VA = "0x184EB3FB0", Slot = "14")]
	public override int GJDOPFMLPAL(PBGEDNJMKOF KJBOHPEHFAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4EB42A0", Offset = "0x4EB34A0", VA = "0x184EB42A0", Slot = "15")]
	public override void LHBGPAFHPCB(PBGEDNJMKOF KJBOHPEHFAO, EPNNHLNNDFC PGKCJGMOFLI, int BLNCMLJMMFI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PDHDAHFJAIA : global::HLGOJBMMLBF<PDHDAHFJAIA>, DJFLNBCFMEE, IEquatable<PDHDAHFJAIA>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AGIDOAOJPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x647070", Offset = "0x646270", VA = "0x180647070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x66D9C0", Offset = "0x66CBC0", VA = "0x18066D9C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JHEJHOEEPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x647080", Offset = "0x646280", VA = "0x180647080", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6470C0", Offset = "0x6462C0", VA = "0x1806470C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x406BDB0", Offset = "0x406AFB0", VA = "0x18406BDB0", Slot = "8")]
	public bool Equals(PDHDAHFJAIA EBJKBJMLDOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8080", Offset = "0x4EB7280", VA = "0x184EB8080")]
	public static bool ENKAAPCHLLB(PDHDAHFJAIA CKAMOFGOGEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum IGCKNPGOANP
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
public interface AHNGJKPNAMF
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform LIIPLFOEHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IGCKNPGOANP AGGDEHEPMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EJMCJJOLDCL : global::HLGOJBMMLBF<EJMCJJOLDCL>, DJFLNBCFMEE, IEquatable<EJMCJJOLDCL>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int AGIDOAOJPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x647070", Offset = "0x646270", VA = "0x180647070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x66D9C0", Offset = "0x66CBC0", VA = "0x18066D9C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int JHEJHOEEPME
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x647080", Offset = "0x646280", VA = "0x180647080", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6470C0", Offset = "0x6462C0", VA = "0x1806470C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x406BDB0", Offset = "0x406AFB0", VA = "0x18406BDB0", Slot = "8")]
	public bool Equals(EJMCJJOLDCL EBJKBJMLDOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF270", Offset = "0x4EAE470", VA = "0x184EAF270")]
	public static bool ENKAAPCHLLB(EJMCJJOLDCL CKAMOFGOGEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KKNGHMAOIKA
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform LIIPLFOEHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float DOMPLGJEBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 ABCBHFDCNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FEGNBCHMNII FIENLEKBJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	NBAAPCKLAHE CEPFGHGBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BHMBHDKAEAG : KKNGHMAOIKA
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CEDCEBEPKKP FEEKIDMPJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool HEMFIAPAIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JODOFEGPIKK : KKNGHMAOIKA
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool OIMHKGAOFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MEDFMIMNKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float DEKEHPHFEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int KGFANFMOGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IBCEOCHBAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<HHEGNGLHKLA> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CDFNDJKKMKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMKJFAJLCOI(EJMCJJOLDCL IGDHEGHDDEE, EHCJBAHICEH NGJJBMKEJJH);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMKJFAJLCOI(PDHDAHFJAIA ANEBBMNIFPH, EHCJBAHICEH NGJJBMKEJJH);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HAMMHBOHOJA(PDHDAHFJAIA ANEBBMNIFPH);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAMMHBOHOJA(EJMCJJOLDCL IGDHEGHDDEE);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HODDEGKPBBB(PDHDAHFJAIA ANEBBMNIFPH, AJBDBHPGKDB DEJAEMDNDIC);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DGFEOONLCNM(PDHDAHFJAIA ANEBBMNIFPH, Vector3 OCHBPOANHHH, Vector3 ALJKMHAOKKC, Vector3 GFBPDCAKDKF, float PNFBJEKEKNE, float DPHLBFLPHKK, IReadOnlyList<Camera> EKMDHJBAHDH, HCOJDPFJMMJ LLFJJOMLPLC);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DGFEOONLCNM(CLDEMFMCDPC KIDFJFANEDK, Vector3 OCHBPOANHHH, Vector3 ALJKMHAOKKC, Vector3 GFBPDCAKDKF, float PNFBJEKEKNE, float DPHLBFLPHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PELCCINOMDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PDHDAHFJAIA FKPIICACHCF(AHNGJKPNAMF NJOKIDJGNHA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COKAGGKNBCI(PDHDAHFJAIA ANEBBMNIFPH);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MHHOJJGCIMI(PDHDAHFJAIA ANEBBMNIFPH);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EJMCJJOLDCL CCKJEADDELK(PDHDAHFJAIA ANEBBMNIFPH, BHMBHDKAEAG NJOKIDJGNHA);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EJMCJJOLDCL JFGEJAJICEE(PDHDAHFJAIA ANEBBMNIFPH, JODOFEGPIKK NJOKIDJGNHA);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LMFEJDNLDMP(EJMCJJOLDCL IGDHEGHDDEE);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDPGCOAGJBE(EJMCJJOLDCL IGDHEGHDDEE);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CLDEMFMCDPC GJCGAJHKHHC(FGPHKCDPADM NJOKIDJGNHA);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HGMMIFLKKKM(CLDEMFMCDPC KIDFJFANEDK);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IBEHONGMLEF(CLDEMFMCDPC KIDFJFANEDK);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JIJPNLMKAPO GKLGOEPAMCE(Transform BIGFKPHCEAA, IEnumerable<EJMCJJOLDCL> MCHIADBEGHM, int DEBICKGHDGI);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> FMOOKPOPGKB(PDHDAHFJAIA ANEBBMNIFPH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CLDEMFMCDPC : global::HLGOJBMMLBF<CLDEMFMCDPC>, DJFLNBCFMEE, IEquatable<CLDEMFMCDPC>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AGIDOAOJPID
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x647070", Offset = "0x646270", VA = "0x180647070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x66D9C0", Offset = "0x66CBC0", VA = "0x18066D9C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int JHEJHOEEPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x647080", Offset = "0x646280", VA = "0x180647080", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6470C0", Offset = "0x6462C0", VA = "0x1806470C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x406BDB0", Offset = "0x406AFB0", VA = "0x18406BDB0", Slot = "8")]
	public bool Equals(CLDEMFMCDPC EBJKBJMLDOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE140", Offset = "0x4EAD340", VA = "0x184EAE140")]
	public static bool ENKAAPCHLLB(CLDEMFMCDPC CKAMOFGOGEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FGPHKCDPADM
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int FILCJFPJHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform CPJBPOOLFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool NJHHGFAFJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PDHDAHFJAIA GetBone(int BFDHACHGGPE);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int BFDHACHGGPE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class FCELBALHIKK : FIAODDEEKLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public BHMBHDKAEAG MKGNPLNEGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] OEMPMGCBMBH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override CHELLBJHOJL HLNKLJLIFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF6F0", Offset = "0x4EAE8F0", VA = "0x184EAF6F0", Slot = "12")]
		get
		{
			return default(CHELLBJHOJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 EBLDAMFKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF470", Offset = "0x4EAE670", VA = "0x184EAF470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0960", Offset = "0x4EAFB60", VA = "0x184EB0960")]
	public FCELBALHIKK(ACGPFIDECKA ANEBBMNIFPH, BHMBHDKAEAG NJOKIDJGNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0460", Offset = "0x4EAF660", VA = "0x184EB0460", Slot = "11")]
	public override bool OPEKDCIPFOJ(Transform ANEBBMNIFPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF650", Offset = "0x4EAE850", VA = "0x184EAF650", Slot = "13")]
	public override int EMMEHAOIPHD(PBGEDNJMKOF KJBOHPEHFAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4EAFA90", Offset = "0x4EAEC90", VA = "0x184EAFA90", Slot = "14")]
	public override int GJDOPFMLPAL(PBGEDNJMKOF KJBOHPEHFAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4EB01E0", Offset = "0x4EAF3E0", VA = "0x184EB01E0")]
	private int OMPLKJLPEAD(PBGEDNJMKOF KJBOHPEHFAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4EAFB30", Offset = "0x4EAED30", VA = "0x184EAFB30", Slot = "15")]
	public override void LHBGPAFHPCB(PBGEDNJMKOF KJBOHPEHFAO, EPNNHLNNDFC PGKCJGMOFLI, int BLNCMLJMMFI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LGJBAJAKEEE
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFGPMOICOHP(AJBDBHPGKDB DEJAEMDNDIC, Renderer AAPGIANNOAF, int CENAIJIDHHE);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPELKELFCGK(Renderer AAPGIANNOAF, HCOJDPFJMMJ LLFJJOMLPLC, Vector3 OCHBPOANHHH, Vector3 ALJKMHAOKKC, Vector3 GFBPDCAKDKF, float PNFBJEKEKNE, float DPHLBFLPHKK, float HBEKDLHFEAO = -1f, [Optional] Color? EBAIGGBEODO, [Optional] IReadOnlyList<Camera> FBLHKGCPCJG);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INOCKAJCJIM(Renderer AAPGIANNOAF, int CENAIJIDHHE);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LPBJDNCDIFM();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLHEBIPAKNL(int OIMDKLBLODE, EHCJBAHICEH DEJAEMDNDIC, Renderer AAPGIANNOAF, int CENAIJIDHHE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GDKCDANJAEN : CDFNDJKKMKI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly LGJBAJAKEEE APABDKEECOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly NILMMKOCLDB HLKOGAJJKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer CCKMDDDIGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private DCNLDEAKDHI GCAOBPFGAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer FKNKOPMHDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private DCNLDEAKDHI ALIENCNLDGO;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x617450", Offset = "0x616650", VA = "0x180617450")]
	public GDKCDANJAEN(LGJBAJAKEEE NEBFCOMFDEJ, NILMMKOCLDB HLKOGAJJKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4EB29B0", Offset = "0x4EB1BB0", VA = "0x184EB29B0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3090", Offset = "0x4EB2290", VA = "0x184EB3090", Slot = "4")]
	public void NMKJFAJLCOI(EJMCJJOLDCL IGDHEGHDDEE, EHCJBAHICEH NGJJBMKEJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3310", Offset = "0x4EB2510", VA = "0x184EB3310", Slot = "5")]
	public void NMKJFAJLCOI(PDHDAHFJAIA ANEBBMNIFPH, EHCJBAHICEH NGJJBMKEJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2D50", Offset = "0x4EB1F50", VA = "0x184EB2D50", Slot = "6")]
	public void HAMMHBOHOJA(PDHDAHFJAIA ANEBBMNIFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2B00", Offset = "0x4EB1D00", VA = "0x184EB2B00", Slot = "7")]
	public void HAMMHBOHOJA(EJMCJJOLDCL IGDHEGHDDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2EF0", Offset = "0x4EB20F0", VA = "0x184EB2EF0", Slot = "8")]
	public void HODDEGKPBBB(PDHDAHFJAIA ANEBBMNIFPH, AJBDBHPGKDB DEJAEMDNDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4EB22B0", Offset = "0x4EB14B0", VA = "0x184EB22B0", Slot = "9")]
	public void DGFEOONLCNM(PDHDAHFJAIA ANEBBMNIFPH, Vector3 OCHBPOANHHH, Vector3 ALJKMHAOKKC, Vector3 GFBPDCAKDKF, float PNFBJEKEKNE, float DPHLBFLPHKK, IReadOnlyList<Camera> EKMDHJBAHDH, HCOJDPFJMMJ LLFJJOMLPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4EB25E0", Offset = "0x4EB17E0", VA = "0x184EB25E0", Slot = "10")]
	public void DGFEOONLCNM(CLDEMFMCDPC KIDFJFANEDK, Vector3 OCHBPOANHHH, Vector3 ALJKMHAOKKC, Vector3 GFBPDCAKDKF, float PNFBJEKEKNE, float DPHLBFLPHKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class FIAODDEEKLD : HCHPPGAPEGB, BHABHNKEKAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds MDIPDMILGNC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ACGPFIDECKA GHEDAMOCBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1C0", Offset = "0x5CB3C0", VA = "0x1805CC1C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds CMJMPMLHNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x145CBE0", Offset = "0x145BDE0", VA = "0x18145CBE0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual CHELLBJHOJL HLNKLJLIFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0A20", Offset = "0x4EAFC20", VA = "0x184EB0A20", Slot = "12")]
		get
		{
			return default(CHELLBJHOJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4EB09B0", Offset = "0x4EAFBB0", VA = "0x184EB09B0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x5749E0", VA = "0x1805757E0", Slot = "11")]
	public virtual bool OPEKDCIPFOJ(Transform ANEBBMNIFPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int EMMEHAOIPHD(PBGEDNJMKOF KJBOHPEHFAO);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int GJDOPFMLPAL(PBGEDNJMKOF KJBOHPEHFAO);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void LHBGPAFHPCB(PBGEDNJMKOF KJBOHPEHFAO, EPNNHLNNDFC PGKCJGMOFLI, int BLNCMLJMMFI = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	protected FIAODDEEKLD()
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
		[Cpp2IlInjected.Address(RVA = "0x4EB80C0", Offset = "0x4EB72C0", VA = "0x184EB80C0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum CEDCEBEPKKP
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
public static class DLDLNJFNICD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EPAJFJLBECM : IEnumerable<OOOBFAELPEF>, IEnumerable, IEnumerator<OOOBFAELPEF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private OOOBFAELPEF <>2__current;

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
		private OOOBFAELPEF System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9016D0", Offset = "0x9008D0", VA = "0x1809016D0")]
		[DebuggerHidden]
		public EPAJFJLBECM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF2B0", Offset = "0x4EAE4B0", VA = "0x184EAF2B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF420", Offset = "0x4EAE620", VA = "0x184EAF420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF390", Offset = "0x4EAE590", VA = "0x184EAF390", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OOOBFAELPEF> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF390", Offset = "0x4EAE590", VA = "0x184EAF390", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int OLNECDCIJKK = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static OOOBFAELPEF[][] JOKEHKFIBEO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static MJHPBAMLGFC MJLNAGPDHCE;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig MDIMFBJLBDP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader CAHCBKPLDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4EAE5F0", Offset = "0x4EAD7F0", VA = "0x184EAE5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer IANAPHJKOPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4EAE660", Offset = "0x4EAD860", VA = "0x184EAE660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4EAEB60", Offset = "0x4EADD60", VA = "0x184EAEB60")]
	public static Mesh LMPDMHCJBKN(CEDCEBEPKKP GAPOMLLKHNB, int KJBOHPEHFAO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF040", Offset = "0x4EAE240", VA = "0x184EAF040")]
	public static int PLCGLKPBDIE(CEDCEBEPKKP GAPOMLLKHNB, int KJBOHPEHFAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4EAEA10", Offset = "0x4EADC10", VA = "0x184EAEA10")]
	public static MJHPBAMLGFC KLDGPDIPKFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE560", Offset = "0x4EAD760", VA = "0x184EAE560")]
	[IteratorStateMachine(typeof(EPAJFJLBECM))]
	private static IEnumerable<OOOBFAELPEF> ENAACAILJJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE6D0", Offset = "0x4EAD8D0", VA = "0x184EAE6D0")]
	public static OOOBFAELPEF JDNHHEDCEHA(CEDCEBEPKKP GAPOMLLKHNB, int KJBOHPEHFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE5D0", Offset = "0x4EAD7D0", VA = "0x184EAE5D0")]
	public static bool GDAOLEPGNPD(this CEDCEBEPKKP GAPOMLLKHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE3A0", Offset = "0x4EAD5A0", VA = "0x184EAE3A0")]
	public static void CMGELMFBAIC(CEDCEBEPKKP GAPOMLLKHNB, float3 PPABINNPHAE, out PHPBPLIINHC PMPBMIGDOHB, out float3 EOKENEDKJGP, out float JLMEGCPAICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4EAEC20", Offset = "0x4EADE20", VA = "0x184EAEC20")]
	public static void LNCMPHMGELG(Vector3 PPABINNPHAE, CEDCEBEPKKP GAPOMLLKHNB, out Vector3 EOKENEDKJGP, out float JLMEGCPAICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE5C0", Offset = "0x4EAD7C0", VA = "0x184EAE5C0")]
	[BBOEJKMFFAE(MBFFABDPJEM.ExitingPlayMode, 0)]
	private static void EPDPCHINONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE180", Offset = "0x4EAD380", VA = "0x184EAE180")]
	[BBOEJKMFFAE(MBFFABDPJEM.ExitingPlayMode, 0)]
	private static void ANBEKIPHJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LLEFMIIJDBE
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool FCGJGOPAAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material GCDPJGECPNM();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material IEOEKHHBIAN();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material HMCJLCJOOHE();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PJHEJFBLFFH(FEGNBCHMNII PDFKFCGHOHA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FMMLFOKJPDN(NBAAPCKLAHE DNHPNBJAAEB);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LONCBJHNAEG(GameObject CEEAMODAEEL);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NGIPEGINHEH(GameObject CEEAMODAEEL, bool FBDILNGBHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface NILMMKOCLDB
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	ACGPFIDECKA DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	FIAODDEEKLD DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	ILHOEPBPMMO DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class FNDOKNKBHEC : PELCCINOMDJ, IDisposable, NILMMKOCLDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::JJJOECKDPLE<PDHDAHFJAIA, ACGPFIDECKA> PAMHAOBOGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::JJJOECKDPLE<EJMCJJOLDCL, FIAODDEEKLD> MCHIADBEGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::JJJOECKDPLE<CLDEMFMCDPC, ILHOEPBPMMO> KFBPCFGLKCK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static LLEFMIIJDBE IHGGDLNHBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0C70", Offset = "0x4EAFE70", VA = "0x184EB0C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4EB15A0", Offset = "0x4EB07A0", VA = "0x184EB15A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public ACGPFIDECKA DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4EB1790", Offset = "0x4EB0990", VA = "0x184EB1790", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FIAODDEEKLD DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4EB17F0", Offset = "0x4EB09F0", VA = "0x184EB17F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public ILHOEPBPMMO DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4EB1730", Offset = "0x4EB0930", VA = "0x184EB1730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1850", Offset = "0x4EB0A50", VA = "0x184EB1850")]
	public FNDOKNKBHEC(LLEFMIIJDBE NEBFCOMFDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0C00", Offset = "0x4EAFE00", VA = "0x184EB0C00", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0CB0", Offset = "0x4EAFEB0", VA = "0x184EB0CB0", Slot = "4")]
	public PDHDAHFJAIA FKPIICACHCF(AHNGJKPNAMF NJOKIDJGNHA)
	{
		return default(PDHDAHFJAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0BA0", Offset = "0x4EAFDA0", VA = "0x184EB0BA0", Slot = "5")]
	public void COKAGGKNBCI(PDHDAHFJAIA ANEBBMNIFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1650", Offset = "0x4EB0850", VA = "0x184EB1650", Slot = "6")]
	public void MHHOJJGCIMI(PDHDAHFJAIA ANEBBMNIFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0D90", Offset = "0x4EAFF90", VA = "0x184EB0D90", Slot = "15")]
	public IEnumerable<Renderer> FMOOKPOPGKB(PDHDAHFJAIA ANEBBMNIFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0AB0", Offset = "0x4EAFCB0", VA = "0x184EB0AB0", Slot = "7")]
	public EJMCJJOLDCL CCKJEADDELK(PDHDAHFJAIA ANEBBMNIFPH, BHMBHDKAEAG NJOKIDJGNHA)
	{
		return default(EJMCJJOLDCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4EB14B0", Offset = "0x4EB06B0", VA = "0x184EB14B0", Slot = "8")]
	public EJMCJJOLDCL JFGEJAJICEE(PDHDAHFJAIA ANEBBMNIFPH, JODOFEGPIKK NJOKIDJGNHA)
	{
		return default(EJMCJJOLDCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4EB16C0", Offset = "0x4EB08C0", VA = "0x184EB16C0", Slot = "10")]
	public void NDPGCOAGJBE(EJMCJJOLDCL IGDHEGHDDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4EB15F0", Offset = "0x4EB07F0", VA = "0x184EB15F0", Slot = "9")]
	public void LMFEJDNLDMP(EJMCJJOLDCL IGDHEGHDDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0E50", Offset = "0x4EB0050", VA = "0x184EB0E50", Slot = "11")]
	public CLDEMFMCDPC GJCGAJHKHHC(FGPHKCDPADM NJOKIDJGNHA)
	{
		return default(CLDEMFMCDPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1440", Offset = "0x4EB0640", VA = "0x184EB1440", Slot = "13")]
	public void IBEHONGMLEF(CLDEMFMCDPC KIDFJFANEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4EB13E0", Offset = "0x4EB05E0", VA = "0x184EB13E0", Slot = "12")]
	public void HGMMIFLKKKM(CLDEMFMCDPC KIDFJFANEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0FE0", Offset = "0x4EB01E0", VA = "0x184EB0FE0", Slot = "14")]
	public JIJPNLMKAPO GKLGOEPAMCE(Transform BIGFKPHCEAA, IEnumerable<EJMCJJOLDCL> MCHIADBEGHM, int DEBICKGHDGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class ILHOEPBPMMO : HOILCCGKDGH
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IIOLLDFFAGO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public ILHOEPBPMMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9016D0", Offset = "0x9008D0", VA = "0x1809016D0")]
		[DebuggerHidden]
		public IIOLLDFFAGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4EB5000", Offset = "0x4EB4200", VA = "0x184EB5000", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4D20", Offset = "0x4EB3F20", VA = "0x184EB4D20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4EB50A0", Offset = "0x4EB42A0", VA = "0x184EB50A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4FB0", Offset = "0x4EB41B0", VA = "0x184EB4FB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4F10", Offset = "0x4EB4110", VA = "0x184EB4F10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4F10", Offset = "0x4EB4110", VA = "0x184EB4F10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly FGPHKCDPADM GEPLIKMIPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly NILMMKOCLDB HLKOGAJJKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private HCFGCEFAFJG MOLHINLKDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<JOIAJEFIJHJ> GOCPEFIAAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<JOIAJEFIJHJ> GEHMOCDOPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject FJDNIDGJPDP;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5FE0", Offset = "0x4EB51E0", VA = "0x184EB5FE0")]
	public static ILHOEPBPMMO NIMCKCDIPLC(FGPHKCDPADM NJOKIDJGNHA, NILMMKOCLDB HLKOGAJJKOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6690", Offset = "0x4EB5890", VA = "0x184EB6690")]
	private ILHOEPBPMMO(FGPHKCDPADM NJOKIDJGNHA, NILMMKOCLDB HLKOGAJJKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6140", Offset = "0x4EB5340", VA = "0x184EB6140")]
	public void PPFJJMADIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4EB54F0", Offset = "0x4EB46F0", VA = "0x184EB54F0")]
	[IteratorStateMachine(typeof(IIOLLDFFAGO))]
	public IEnumerable<Renderer> CGHEFFDILLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5590", Offset = "0x4EB4790", VA = "0x184EB5590", Slot = "4")]
	public void NGHPECFEEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5560", Offset = "0x4EB4760", VA = "0x184EB5560")]
	private void FCCHENDAFGO(Vector3 BMDENEMNDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5320", Offset = "0x4EB4520", VA = "0x184EB5320")]
	public void BOOBIECFMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JOIAJEFIJHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct LAHDAEFHOIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public EPNNHLNNDFC IALJGGLKGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform GPFBKNCCJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int AEKMKCOPKKA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KHMJAODMNNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public JOIAJEFIJHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public PBGEDNJMKOF lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<LAHDAEFHOIC> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public KHMJAODMNNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class IKAFPKDJGFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public JIJPNLMKAPO combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public KHMJAODMNNP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public IKAFPKDJGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4EB50E0", Offset = "0x4EB42E0", VA = "0x184EB50E0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4EB5150", Offset = "0x4EB4350", VA = "0x184EB5150")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EB5190", Offset = "0x4EB4390", VA = "0x184EB5190")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] OOGFMPEAINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private HFAGHFKNPOC GPDMDGEPEFC;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 GJKLDFEJJBI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh PJBDPMFFIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1C0", Offset = "0x5CB3C0", VA = "0x1805CC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int GPFKDJGMOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5ACAC0", Offset = "0x5ABCC0", VA = "0x1805ACAC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x640B80", Offset = "0x63FD80", VA = "0x180640B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7280", Offset = "0x4EB6480", VA = "0x184EB7280")]
	public void PDGDNDENAPI(List<Transform> ELAFGDNDEEP, Matrix4x4[] ALIHJCPHHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6D20", Offset = "0x4EB5F20", VA = "0x184EB6D20")]
	public static List<JOIAJEFIJHJ> EJKEJHFJNHJ(List<ACGPFIDECKA> PAELOKCIDMI, PBGEDNJMKOF KJBOHPEHFAO, Bounds BCLEKFJCDOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6790", Offset = "0x4EB5990", VA = "0x184EB6790")]
	private JobHandle BGNPIIBEMCD(JIJPNLMKAPO HOOAEMEFIDD, int OAEDDILPBND, int BCCLIJKOJGL, PBGEDNJMKOF KJBOHPEHFAO, List<LAHDAEFHOIC> FDKJPIKDOJG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6BA0", Offset = "0x4EB5DA0", VA = "0x184EB6BA0")]
	private void BICFHDKADPN(List<LAHDAEFHOIC> FDKJPIKDOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4EB75C0", Offset = "0x4EB67C0", VA = "0x184EB75C0")]
	private JOIAJEFIJHJ(List<LAHDAEFHOIC> FDKJPIKDOJG, int OAEDDILPBND, int BCCLIJKOJGL, PBGEDNJMKOF KJBOHPEHFAO, Bounds BCLEKFJCDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6CA0", Offset = "0x4EB5EA0", VA = "0x184EB6CA0", Slot = "4")]
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
		private MaterialPropertyBlock APGOKBLDBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private JOIAJEFIJHJ KEEALIHEENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> FGPGKLDOEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture PDBHCMEKJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer CBCFKDGJFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader LJBNJMEKPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] EBDNPNECCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int DEFFFEABNAK;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer LNBOFLJCHCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574B80", VA = "0x180575980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int FILCJFPJHHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4EB8C60", Offset = "0x4EB7E60", VA = "0x184EB8C60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4EB80F0", Offset = "0x4EB72F0", VA = "0x184EB80F0")]
		public static List<SkinnedShapeRenderer> Create(GameObject ANEBBMNIFPH, List<JOIAJEFIJHJ> PAPDKDBGGCE, List<Transform> FGPGKLDOEEG, Material JDMOJJJBGNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8390", Offset = "0x4EB7590", VA = "0x184EB8390")]
		public void Init(JOIAJEFIJHJ KEEALIHEENC, List<Transform> FGPGKLDOEEG, Material JDMOJJJBGNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8880", Offset = "0x4EB7A80", VA = "0x184EB8880")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4EB87F0", Offset = "0x4EB79F0", VA = "0x184EB87F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4EB87B0", Offset = "0x4EB79B0", VA = "0x184EB87B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8300", Offset = "0x4EB7500", VA = "0x184EB8300")]
		private void EDJLKBPHIKJ(ScriptableRenderContext JOBPOOEPEBN, Camera[] BCDDOLBCADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8910", Offset = "0x4EB7B10", VA = "0x184EB8910")]
		private void PDGDNDENAPI(CommandBuffer ABFPOJNDGLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FNGEDJFFIEL
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] JKCEPOEAODE;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int HMIFPHDBAAL;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int JLNLCKONFPG;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger EBGIPPCOABB;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FNGEDJFFIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1CC0", Offset = "0x4EB0EC0", VA = "0x184EB1CC0")]
	private static string CHCKGNJAKBF(byte[] CJCOEBBKILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1DC0", Offset = "0x4EB0FC0", VA = "0x184EB1DC0")]
	public static string PEFJMDOFNMG(byte[] PKBLLNJJAGK, bool HCHELKBPHNG)
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
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
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
