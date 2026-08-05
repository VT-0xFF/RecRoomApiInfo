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
public enum PNOALBMEAKL
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
public static class AAPEJLJNDJB
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<PNOALBMEAKL> LAMICECBGLM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4B75B10", Offset = "0x4B74910", VA = "0x184B75B10")]
	static AAPEJLJNDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B75B10", Offset = "0x4B74910", VA = "0x184B75B10")]
	[CKNNILEMGBJ]
	private static void OGICEOHIGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B75A90", Offset = "0x4B74890", VA = "0x184B75A90")]
	public static bool ABDDAHNGCJC(this PNOALBMEAKL NKKLCLMIPIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KCEDHMGMNFD
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
public enum GEGDBPOEGCC
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
public enum PPHPIIGGHEH
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
	Configure,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	HoverXRay
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BGCENEOBGFA
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LFCNCNBECCP : PFIPNJNJMBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private const byte BEKJKOMFAKH = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private byte HHNKEMCHGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly List<SkinnedShapeRenderer>[] KMHPHBIDIGD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FLAPICHGIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x551540", Offset = "0x550340", VA = "0x180551540", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x551530", Offset = "0x550330", VA = "0x180551530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GLOMDPNKKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x56CEA0", Offset = "0x56BCA0", VA = "0x18056CEA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4D0", Offset = "0x6BC2D0", VA = "0x1806BD4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float OGEOIDCMPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x681840", Offset = "0x680640", VA = "0x180681840", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x681D20", Offset = "0x680B20", VA = "0x180681D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OHFNFJAGJPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x681830", Offset = "0x680630", VA = "0x180681830", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x681D10", Offset = "0x680B10", VA = "0x180681D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> MIPHGAKNBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DDD0", Offset = "0x4B7CBD0", VA = "0x184B7DDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject BLGMEJFMEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x526A10", Offset = "0x525810", VA = "0x180526A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x54DCB0", Offset = "0x54CAB0", VA = "0x18054DCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte BHLIIKHPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DC00", Offset = "0x4B7CA00", VA = "0x184B7DC00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E0E0", Offset = "0x4B7CEE0", VA = "0x184B7E0E0")]
	public LFCNCNBECCP(List<LEELCPKGAKB> NICLHICBAPE, List<LEELCPKGAKB> AMOKKEJBGMD, List<Transform> BEFFGLLHOIO, Material MGBLBJHKAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DE70", Offset = "0x4B7CC70", VA = "0x184B7DE70")]
	private int NGIFLNIPECE(List<LEELCPKGAKB> BNNBOCBFGFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DF80", Offset = "0x4B7CD80", VA = "0x184B7DF80")]
	private void PPLCNIDGMGF(int PKEMGNFOGDA, bool NBMGDPFEPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DC50", Offset = "0x4B7CA50", VA = "0x184B7DC50")]
	public void DMFAHHCGOLA(Vector3 HMLKJCJLLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DD40", Offset = "0x4B7CB40", VA = "0x184B7DD40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DE30", Offset = "0x4B7CC30", VA = "0x184B7DE30")]
	public void NAAMKLHGKGE(Transform KOPEIGJGHMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OGOEHDLDBNN : IEEFANIPICD, BMPGDODANBA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PIAECIDNMBL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public OGOEHDLDBNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BA6C0", VA = "0x1807BB8C0")]
		[DebuggerHidden]
		public PIAECIDNMBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FC60", Offset = "0x4B7EA60", VA = "0x184B7FC60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4B7F7B0", Offset = "0x4B7E5B0", VA = "0x184B7F7B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FDE0", Offset = "0x4B7EBE0", VA = "0x184B7FDE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FE20", Offset = "0x4B7EC20", VA = "0x184B7FE20")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FE70", Offset = "0x4B7EC70", VA = "0x184B7FE70")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FC10", Offset = "0x4B7EA10", VA = "0x184B7FC10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FB70", Offset = "0x4B7E970", VA = "0x184B7FB70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FB70", Offset = "0x4B7E970", VA = "0x184B7FB70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private DDNGMHHFGBE OMNODFPGBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private List<PPPMDGEGHJO> EACGGGABBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<ClusterMeshRenderer> JBIHNAHPPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private BatchedMeshRenderer NFJFKIOCCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool AIAFIOPGGFB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<HCOPHBCLFIP> AIGEEBGHOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int OMKJKEIJKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E830", Offset = "0x4B7D630", VA = "0x184B7E830", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform PEOONJMCEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4B7EA20", Offset = "0x4B7D820", VA = "0x184B7EA20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4B7F720", Offset = "0x4B7E520", VA = "0x184B7F720")]
	public OGOEHDLDBNN(DDNGMHHFGBE CICAPJGMKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B7EA70", Offset = "0x4B7D870", VA = "0x184B7EA70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E760", Offset = "0x4B7D560", VA = "0x184B7E760")]
	public void ACLEHGEDHGC(PPPMDGEGHJO FPHBLGEPCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4B7F080", Offset = "0x4B7DE80", VA = "0x184B7F080")]
	public void MDMFJHECCDC(PPPMDGEGHJO FPHBLGEPCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B7EAA0", Offset = "0x4B7D8A0", VA = "0x184B7EAA0", Slot = "4")]
	public void EDBOKONEBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7EFF0", Offset = "0x4B7DDF0", VA = "0x184B7EFF0")]
	public void LAILODAHAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7F5D0", Offset = "0x4B7E3D0", VA = "0x184B7F5D0")]
	private void PJLFGFDKOHC(PPPMDGEGHJO FPHBLGEPCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4B7F0F0", Offset = "0x4B7DEF0", VA = "0x184B7F0F0")]
	public void OFPPDMCGHGP(bool JCEONDOFKFO, bool LDOIDFDKKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E870", Offset = "0x4B7D670", VA = "0x184B7E870")]
	protected void BEFAMFNOAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E9B0", Offset = "0x4B7D7B0", VA = "0x184B7E9B0")]
	[IteratorStateMachine(typeof(PIAECIDNMBL))]
	public IEnumerable<Renderer> BEPLNIKHLPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class HBCANIKEGOE : PPPMDGEGHJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private LPCBOKIFCAN LHEPJIMJLOA;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4B78F10", Offset = "0x4B77D10", VA = "0x184B78F10")]
	private NativeList<NPPNLLJEJAF> LNNBLNGCMHO()
	{
		return default(NativeList<NPPNLLJEJAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B79420", Offset = "0x4B78220", VA = "0x184B79420")]
	public HBCANIKEGOE(OGOEHDLDBNN FEAMLIHDEIF, LPCBOKIFCAN CICAPJGMKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B78FE0", Offset = "0x4B77DE0", VA = "0x184B78FE0", Slot = "13")]
	public override int NGIFLNIPECE(IKGOJPAHHIL DPMBBGBAAPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B79200", Offset = "0x4B78000", VA = "0x184B79200", Slot = "14")]
	public override int OEMNEOHIJDF(IKGOJPAHHIL DPMBBGBAAPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4B789E0", Offset = "0x4B777E0", VA = "0x184B789E0", Slot = "15")]
	public override void JMADOJPOLBB(IKGOJPAHHIL DPMBBGBAAPB, PFEOBINIJOH BADPADCJJBC, int FOGNFIMOBEP = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IKCALMEMJCC : global::HDPJKMLNJIB<IKCALMEMJCC>, OBPJHNKLAEJ, IEquatable<IKCALMEMJCC>
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int LFGMGBIAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5DA2D0", Offset = "0x5D90D0", VA = "0x1805DA2D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x732890", Offset = "0x731690", VA = "0x180732890", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GBJCFDLFDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xBCF590", Offset = "0xBCE390", VA = "0x180BCF590", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xCD7630", Offset = "0xCD6430", VA = "0x180CD7630", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x17736C0", Offset = "0x17724C0", VA = "0x1817736C0", Slot = "8")]
	public bool Equals(IKCALMEMJCC MDLBKDPKIHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4B79470", Offset = "0x4B78270", VA = "0x184B79470")]
	public static bool FDCAKKFAMJO(IKCALMEMJCC CBGDBIFJHEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum LAOLCJIIJGP
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DDNGMHHFGBE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform DGENDBJAJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	LAOLCJIIJGP BJGHLKJDMAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct IOHKKOBOBBF : global::HDPJKMLNJIB<IOHKKOBOBBF>, OBPJHNKLAEJ, IEquatable<IOHKKOBOBBF>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LFGMGBIAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA2D0", Offset = "0x5D90D0", VA = "0x1805DA2D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x732890", Offset = "0x731690", VA = "0x180732890", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GBJCFDLFDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xBCF590", Offset = "0xBCE390", VA = "0x180BCF590", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCD7630", Offset = "0xCD6430", VA = "0x180CD7630", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x17736C0", Offset = "0x17724C0", VA = "0x1817736C0", Slot = "8")]
	public bool Equals(IOHKKOBOBBF MDLBKDPKIHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4B794B0", Offset = "0x4B782B0", VA = "0x184B794B0")]
	public static bool FDCAKKFAMJO(IOHKKOBOBBF CBGDBIFJHEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GFDJPCCIFLN
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform DGENDBJAJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float KDDNDBFDDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Vector3 GDJKMJICFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PNOALBMEAKL DHMBJOFLNCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	KCEDHMGMNFD OBAFJPJFLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EGHCIJNMFKO : GFDJPCCIFLN
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MCJKCMIAKPC DLODKBMFOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HOAFJKNKHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LPCBOKIFCAN : GFDJPCCIFLN
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool DIDMNJGBIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CEGKAAHIMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float NHNELLOPFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int KEFFBKCOJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool POBGAGEKAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<NPPNLLJEJAF> LNNBLNGCMHO();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FKFNDFEDPHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKLDIHPMEEJ(IOHKKOBOBBF FPHBLGEPCFD, PPHPIIGGHEH ILECKDODMFD);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKLDIHPMEEJ(IKCALMEMJCC FEAMLIHDEIF, PPHPIIGGHEH ILECKDODMFD);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKFFLNAJJIE(IKCALMEMJCC FEAMLIHDEIF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKFFLNAJJIE(IOHKKOBOBBF FPHBLGEPCFD);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBMBELMPDMB(IKCALMEMJCC FEAMLIHDEIF, BGCENEOBGFA FHJGHNDLPMM);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LIFEGCJNHNC(IKCALMEMJCC FEAMLIHDEIF, Vector3 OGIMEBMNNFI, Vector3 FLCMFNAIGDN, Vector3 BMNGPPHIKJA, float JJHDJOHILIM, float LGEPIFOHIHF, IReadOnlyList<Camera> OHJOGAOKOHI, GEGDBPOEGCC EFAHODGMKKJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LIFEGCJNHNC(ECNDEEOOBAC KMOAOMJPPIM, Vector3 OGIMEBMNNFI, Vector3 FLCMFNAIGDN, Vector3 BMNGPPHIKJA, float JJHDJOHILIM, float LGEPIFOHIHF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GGMJBJGGKOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IKCALMEMJCC ADCBMOGKEBG(DDNGMHHFGBE CICAPJGMKGK);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMIDPEFCENG(IKCALMEMJCC FEAMLIHDEIF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHEOKPKGODI(IKCALMEMJCC FEAMLIHDEIF);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IOHKKOBOBBF PPBHNHJLLMI(IKCALMEMJCC FEAMLIHDEIF, EGHCIJNMFKO CICAPJGMKGK);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IOHKKOBOBBF CCNDFMEMEHH(IKCALMEMJCC FEAMLIHDEIF, LPCBOKIFCAN CICAPJGMKGK);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJMCDLICEOG(IOHKKOBOBBF FPHBLGEPCFD);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JJLADFOAJFA(IOHKKOBOBBF FPHBLGEPCFD);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ECNDEEOOBAC MLBAODBEAAD(EANHNLMKBLD CICAPJGMKGK);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GMPNNDBLGOK(ECNDEEOOBAC KMOAOMJPPIM);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DIKJBMCFMDO(ECNDEEOOBAC KMOAOMJPPIM);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BOFFGMEMCAF LEDLJDIIDDC(Transform HAPKAOPCKBF, IEnumerable<IOHKKOBOBBF> EACGGGABBDO, int BNLOINGMEPC);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> ABKDLFDJPKN(IKCALMEMJCC FEAMLIHDEIF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ECNDEEOOBAC : global::HDPJKMLNJIB<ECNDEEOOBAC>, OBPJHNKLAEJ, IEquatable<ECNDEEOOBAC>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int LFGMGBIAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5DA2D0", Offset = "0x5D90D0", VA = "0x1805DA2D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x732890", Offset = "0x731690", VA = "0x180732890", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int GBJCFDLFDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBCF590", Offset = "0xBCE390", VA = "0x180BCF590", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCD7630", Offset = "0xCD6430", VA = "0x180CD7630", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x17736C0", Offset = "0x17724C0", VA = "0x1817736C0", Slot = "8")]
	public bool Equals(ECNDEEOOBAC MDLBKDPKIHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4B76220", Offset = "0x4B75020", VA = "0x184B76220")]
	public static bool FDCAKKFAMJO(ECNDEEOOBAC CBGDBIFJHEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EANHNLMKBLD
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int JNJJIIHGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform OBGOBEAFJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HEIGFHBBBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IKCALMEMJCC GetBone(int MOELOMLCGOI);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MOELOMLCGOI);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class KNLLKPMBIGP : PPPMDGEGHJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public EGHCIJNMFKO IPCEHCBJDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int[] FJJLHFINECL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public override HCECKOMJOEC EOIGNGFNJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C3C0", Offset = "0x4B7B1C0", VA = "0x184B7C3C0", Slot = "12")]
		get
		{
			return default(HCECKOMJOEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Vector3 FNELCDNOHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C8A0", Offset = "0x4B7B6A0", VA = "0x184B7C8A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B79420", Offset = "0x4B78220", VA = "0x184B79420")]
	public KNLLKPMBIGP(OGOEHDLDBNN FEAMLIHDEIF, EGHCIJNMFKO CICAPJGMKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BEC0", Offset = "0x4B7ACC0", VA = "0x184B7BEC0", Slot = "11")]
	public override bool LIJDKDKFBPF(Transform FEAMLIHDEIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C760", Offset = "0x4B7B560", VA = "0x184B7C760", Slot = "13")]
	public override int NGIFLNIPECE(IKGOJPAHHIL DPMBBGBAAPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C800", Offset = "0x4B7B600", VA = "0x184B7C800", Slot = "14")]
	public override int OEMNEOHIJDF(IKGOJPAHHIL DPMBBGBAAPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BC80", Offset = "0x4B7AA80", VA = "0x184B7BC80")]
	private int JOAOOKECLKH(IKGOJPAHHIL DPMBBGBAAPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B5D0", Offset = "0x4B7A3D0", VA = "0x184B7B5D0", Slot = "15")]
	public override void JMADOJPOLBB(IKGOJPAHHIL DPMBBGBAAPB, PFEOBINIJOH BADPADCJJBC, int FOGNFIMOBEP = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FONLDEDELKM
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAHNDLCIKPC(BGCENEOBGFA FHJGHNDLPMM, Renderer HPJDLLLCBCJ, int LIDPDOAPIGK);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAPCINGCLAH(Renderer HPJDLLLCBCJ, GEGDBPOEGCC EFAHODGMKKJ, Vector3 OGIMEBMNNFI, Vector3 FLCMFNAIGDN, Vector3 BMNGPPHIKJA, float JJHDJOHILIM, float LGEPIFOHIHF, float IMDJNPOMAIC = -1f, [Optional] Color? OBPIEGPGIKF, [Optional] IReadOnlyList<Camera> KKJBEMGALKN);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBJOIGKIABG(Renderer HPJDLLLCBCJ, int LIDPDOAPIGK);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JIMABHMICNM();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCJJEIBGHJD(int OOCKOCHFGFB, PPHPIIGGHEH FHJGHNDLPMM, Renderer HPJDLLLCBCJ, int LIDPDOAPIGK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FMLKJHPNDHP : FKFNDFEDPHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly FONLDEDELKM BBDKLOFOBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly NMOFGPHPCOG BGLEOIAJKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private MeshRenderer CPHDGDJHBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private GHCFEPLBMLF HMHKGPHBHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private MeshRenderer OBPGMCHBBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private GHCFEPLBMLF NCBBMCDEIPC;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x57FA70", Offset = "0x57E870", VA = "0x18057FA70")]
	public FMLKJHPNDHP(FONLDEDELKM HKAODOLNGID, NMOFGPHPCOG BGLEOIAJKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4B77BA0", Offset = "0x4B769A0", VA = "0x184B77BA0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4B78590", Offset = "0x4B77390", VA = "0x184B78590", Slot = "4")]
	public void MKLDIHPMEEJ(IOHKKOBOBBF FPHBLGEPCFD, PPHPIIGGHEH ILECKDODMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4B78810", Offset = "0x4B77610", VA = "0x184B78810", Slot = "5")]
	public void MKLDIHPMEEJ(IKCALMEMJCC FEAMLIHDEIF, PPHPIIGGHEH ILECKDODMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4B777B0", Offset = "0x4B765B0", VA = "0x184B777B0", Slot = "6")]
	public void CKFFLNAJJIE(IKCALMEMJCC FEAMLIHDEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4B77950", Offset = "0x4B76750", VA = "0x184B77950", Slot = "7")]
	public void CKFFLNAJJIE(IOHKKOBOBBF FPHBLGEPCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4B783F0", Offset = "0x4B771F0", VA = "0x184B783F0", Slot = "8")]
	public void MBMBELMPDMB(IKCALMEMJCC FEAMLIHDEIF, BGCENEOBGFA FHJGHNDLPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4B780C0", Offset = "0x4B76EC0", VA = "0x184B780C0", Slot = "9")]
	public void LIFEGCJNHNC(IKCALMEMJCC FEAMLIHDEIF, Vector3 OGIMEBMNNFI, Vector3 FLCMFNAIGDN, Vector3 BMNGPPHIKJA, float JJHDJOHILIM, float LGEPIFOHIHF, IReadOnlyList<Camera> OHJOGAOKOHI, GEGDBPOEGCC EFAHODGMKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4B77CF0", Offset = "0x4B76AF0", VA = "0x184B77CF0", Slot = "10")]
	public void LIFEGCJNHNC(ECNDEEOOBAC KMOAOMJPPIM, Vector3 OGIMEBMNNFI, Vector3 FLCMFNAIGDN, Vector3 BMNGPPHIKJA, float JJHDJOHILIM, float LGEPIFOHIHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class PPPMDGEGHJO : PMFIJNFKJMD, HCOPHBCLFIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	protected Bounds DNLNKKNPILL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public OGOEHDLDBNN BLGMEJFMEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x54AEA0", Offset = "0x549CA0", VA = "0x18054AEA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Bounds EJKIHMHOLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2725550", Offset = "0x2724350", VA = "0x182725550", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public virtual HCECKOMJOEC EOIGNGFNJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FF30", Offset = "0x4B7ED30", VA = "0x184B7FF30", Slot = "12")]
		get
		{
			return default(HCECKOMJOEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4B7FEC0", Offset = "0x4B7ECC0", VA = "0x184B7FEC0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x56D080", Offset = "0x56BE80", VA = "0x18056D080", Slot = "11")]
	public virtual bool LIJDKDKFBPF(Transform FEAMLIHDEIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int NGIFLNIPECE(IKGOJPAHHIL DPMBBGBAAPB);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int OEMNEOHIJDF(IKGOJPAHHIL DPMBBGBAAPB);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void JMADOJPOLBB(IKGOJPAHHIL DPMBBGBAAPB, PFEOBINIJOH BADPADCJJBC, int FOGNFIMOBEP = -1);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	protected PPPMDGEGHJO()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FFC0", Offset = "0x4B7EDC0", VA = "0x184B7FFC0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum MCJKCMIAKPC
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class JKIIBCKLENK
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FHGDAPPLMHM : IEnumerable<IOCGLPBANEB>, IEnumerable, IEnumerator<IOCGLPBANEB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private IOCGLPBANEB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private IOCGLPBANEB System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BA6C0", VA = "0x1807BB8C0")]
		[DebuggerHidden]
		public FHGDAPPLMHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4B775F0", Offset = "0x4B763F0", VA = "0x184B775F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4B77760", Offset = "0x4B76560", VA = "0x184B77760", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4B776D0", Offset = "0x4B764D0", VA = "0x184B776D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IOCGLPBANEB> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4B776D0", Offset = "0x4B764D0", VA = "0x184B776D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int GNLOPLOEAIH = 3;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static IOCGLPBANEB[][] FDFIMHHLNBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static FGNPGOHHOPB ODHJBAHIAKD;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static ShapeRendererConfig HEOMJBAAMPD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static ComputeShader OBFEAHAKOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4B7A9C0", Offset = "0x4B797C0", VA = "0x184B7A9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static SkinnedShapeRenderer MPLBCDBFEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4B7B070", Offset = "0x4B79E70", VA = "0x184B7B070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B480", Offset = "0x4B7A280", VA = "0x184B7B480")]
	public static Mesh LDDPMCFEMCF(MCJKCMIAKPC GGDNCKFHLCG, int DPMBBGBAAPB = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B540", Offset = "0x4B7A340", VA = "0x184B7B540")]
	public static int MNIGCNDJFDA(MCJKCMIAKPC GGDNCKFHLCG, int DPMBBGBAAPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B2D0", Offset = "0x4B7A0D0", VA = "0x184B7B2D0")]
	public static FGNPGOHHOPB KADNMEHFPFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B420", Offset = "0x4B7A220", VA = "0x184B7B420")]
	[IteratorStateMachine(typeof(FHGDAPPLMHM))]
	private static IEnumerable<IOCGLPBANEB> KGBIAEKHPCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A680", Offset = "0x4B79480", VA = "0x184B7A680")]
	public static IOCGLPBANEB ACNNDKIENPL(MCJKCMIAKPC GGDNCKFHLCG, int DPMBBGBAAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B2B0", Offset = "0x4B7A0B0", VA = "0x184B7B2B0")]
	public static bool IKBPHBGPDOL(this MCJKCMIAKPC GGDNCKFHLCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B0E0", Offset = "0x4B79EE0", VA = "0x184B7B0E0")]
	public static void HEBEHIEODIB(MCJKCMIAKPC GGDNCKFHLCG, float3 NMNKHHOIAHK, out APLHGHANDEL CHJKOPKFCDH, out float3 PBDDIPECDFN, out float JNPJKDKFPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AA30", Offset = "0x4B79830", VA = "0x184B7AA30")]
	public static void FNJCNLDAPGH(Vector3 NMNKHHOIAHK, MCJKCMIAKPC GGDNCKFHLCG, out Vector3 PBDDIPECDFN, out float JNPJKDKFPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B2A0", Offset = "0x4B7A0A0", VA = "0x184B7B2A0")]
	[NONPLMHAFKG(NKOBICDJAEL.ExitingPlayMode, 0)]
	private static void HFFJMOMABDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AE50", Offset = "0x4B79C50", VA = "0x184B7AE50")]
	[NONPLMHAFKG(NKOBICDJAEL.ExitingPlayMode, 0)]
	private static void GBBENJHNFLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface APBGFNLGNHA
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool GDOICABELCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material GKCLAHAANLL();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material AJDPOCDHGKA();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material DNDILOKPFIC();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PNHMOADDDNM(PNOALBMEAKL AHJICNDMDFD);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OAOIIPLNMKH(KCEDHMGMNFD PEFAGMHEDOG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JAJKFNGDKPB(GameObject HOBENCJANIA);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FDJBBHBCKJH(GameObject HOBENCJANIA, bool LDEDJNIGKKK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public interface NMOFGPHPCOG
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OGOEHDLDBNN LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PPPMDGEGHJO LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	EIGKBCMBOHB LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class JGBBOHDEHHM : GGMJBJGGKOA, IDisposable, NMOFGPHPCOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly global::ANLCFPKMOGG<IKCALMEMJCC, OGOEHDLDBNN> JKHDJKHIADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly global::ANLCFPKMOGG<IOHKKOBOBBF, PPPMDGEGHJO> EACGGGABBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly global::ANLCFPKMOGG<ECNDEEOOBAC, EIGKBCMBOHB> EGEDBPAJONP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static APBGFNLGNHA NAEOEGFBBND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4B79860", Offset = "0x4B78660", VA = "0x184B79860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4B7A070", Offset = "0x4B78E70", VA = "0x184B7A070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public OGOEHDLDBNN LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B799C0", Offset = "0x4B787C0", VA = "0x184B799C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PPPMDGEGHJO LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4B79960", Offset = "0x4B78760", VA = "0x184B79960", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EIGKBCMBOHB LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4B79A20", Offset = "0x4B78820", VA = "0x184B79A20", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A210", Offset = "0x4B79010", VA = "0x184B7A210")]
	public JGBBOHDEHHM(APBGFNLGNHA HKAODOLNGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4B797F0", Offset = "0x4B785F0", VA = "0x184B797F0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4B795B0", Offset = "0x4B783B0", VA = "0x184B795B0", Slot = "4")]
	public IKCALMEMJCC ADCBMOGKEBG(DDNGMHHFGBE CICAPJGMKGK)
	{
		return default(IKCALMEMJCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A0C0", Offset = "0x4B78EC0", VA = "0x184B7A0C0", Slot = "5")]
	public void PMIDPEFCENG(IKCALMEMJCC FEAMLIHDEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4B79A80", Offset = "0x4B78880", VA = "0x184B79A80", Slot = "6")]
	public void JHEOKPKGODI(IKCALMEMJCC FEAMLIHDEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4B794F0", Offset = "0x4B782F0", VA = "0x184B794F0", Slot = "15")]
	public IEnumerable<Renderer> ABKDLFDJPKN(IKCALMEMJCC FEAMLIHDEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A120", Offset = "0x4B78F20", VA = "0x184B7A120", Slot = "7")]
	public IOHKKOBOBBF PPBHNHJLLMI(IKCALMEMJCC FEAMLIHDEIF, EGHCIJNMFKO CICAPJGMKGK)
	{
		return default(IOHKKOBOBBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4B79690", Offset = "0x4B78490", VA = "0x184B79690", Slot = "8")]
	public IOHKKOBOBBF CCNDFMEMEHH(IKCALMEMJCC FEAMLIHDEIF, LPCBOKIFCAN CICAPJGMKGK)
	{
		return default(IOHKKOBOBBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4B79AF0", Offset = "0x4B788F0", VA = "0x184B79AF0", Slot = "10")]
	public void JJLADFOAJFA(IOHKKOBOBBF FPHBLGEPCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4B798A0", Offset = "0x4B786A0", VA = "0x184B798A0", Slot = "9")]
	public void GJMCDLICEOG(IOHKKOBOBBF FPHBLGEPCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4B79F60", Offset = "0x4B78D60", VA = "0x184B79F60", Slot = "11")]
	public ECNDEEOOBAC MLBAODBEAAD(EANHNLMKBLD CICAPJGMKGK)
	{
		return default(ECNDEEOOBAC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4B79780", Offset = "0x4B78580", VA = "0x184B79780", Slot = "13")]
	public void DIKJBMCFMDO(ECNDEEOOBAC KMOAOMJPPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4B79900", Offset = "0x4B78700", VA = "0x184B79900", Slot = "12")]
	public void GMPNNDBLGOK(ECNDEEOOBAC KMOAOMJPPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4B79B60", Offset = "0x4B78960", VA = "0x184B79B60", Slot = "14")]
	public BOFFGMEMCAF LEDLJDIIDDC(Transform HAPKAOPCKBF, IEnumerable<IOHKKOBOBBF> EACGGGABBDO, int BNLOINGMEPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EIGKBCMBOHB : IEEFANIPICD
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NCEFNPDHKDG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public EIGKBCMBOHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BA6C0", VA = "0x1807BB8C0")]
		[DebuggerHidden]
		public NCEFNPDHKDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E680", Offset = "0x4B7D480", VA = "0x184B7E680", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E3A0", Offset = "0x4B7D1A0", VA = "0x184B7E3A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E720", Offset = "0x4B7D520", VA = "0x184B7E720")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E630", Offset = "0x4B7D430", VA = "0x184B7E630", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E590", Offset = "0x4B7D390", VA = "0x184B7E590", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E590", Offset = "0x4B7D390", VA = "0x184B7E590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly EANHNLMKBLD KOGPFHBDDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly NMOFGPHPCOG BGLEOIAJKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private LFCNCNBECCP BPLLFAOKIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private List<LEELCPKGAKB> POEKANCFNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private List<LEELCPKGAKB> ADOKEPBPHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private GameObject DKEEPKJAMLI;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4B76C50", Offset = "0x4B75A50", VA = "0x184B76C50")]
	public static EIGKBCMBOHB IHHODGBFFJN(EANHNLMKBLD CICAPJGMKGK, NMOFGPHPCOG BGLEOIAJKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4B77320", Offset = "0x4B76120", VA = "0x184B77320")]
	private EIGKBCMBOHB(EANHNLMKBLD CICAPJGMKGK, NMOFGPHPCOG BGLEOIAJKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B76D30", Offset = "0x4B75B30", VA = "0x184B76D30")]
	public void JHKCEBHDNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4B76260", Offset = "0x4B75060", VA = "0x184B76260")]
	[IteratorStateMachine(typeof(NCEFNPDHKDG))]
	public IEnumerable<Renderer> BEPLNIKHLPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4B762D0", Offset = "0x4B750D0", VA = "0x184B762D0", Slot = "4")]
	public void EDBOKONEBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4B76C20", Offset = "0x4B75A20", VA = "0x184B76C20")]
	private void GMPDAGHONLP(Vector3 HMLKJCJLLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4B77150", Offset = "0x4B75F50", VA = "0x184B77150")]
	public void LAILODAHAHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LEELCPKGAKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct IJFHMBJELIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public PFEOBINIJOH KMFKEJHGJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Transform CPGCNLHOOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int OLFNMABEFHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class DPFDEEHFJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public LEELCPKGAKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public IKGOJPAHHIL lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public List<IJFHMBJELIO> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public DPFDEEHFJCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class ELFDNFBFOPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public BOFFGMEMCAF combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public DPFDEEHFJCO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public ELFDNFBFOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4B773B0", Offset = "0x4B761B0", VA = "0x184B773B0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4B77420", Offset = "0x4B76220", VA = "0x184B77420")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4B77460", Offset = "0x4B76260", VA = "0x184B77460")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private int[] PJNHPOLCBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private KELGIOPGHNO GCFPLNGBGON;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static Matrix4x4 EGDIJPNNCMB;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Mesh KFGFLJEMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x54AEA0", Offset = "0x549CA0", VA = "0x18054AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int AAKOEFCINFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x527470", Offset = "0x526270", VA = "0x180527470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x54BBD0", Offset = "0x54A9D0", VA = "0x18054BBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D510", Offset = "0x4B7C310", VA = "0x184B7D510")]
	public void OJFADKABNDO(List<Transform> BGOFOAGEKIH, Matrix4x4[] AJJMFOLAOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CC00", Offset = "0x4B7BA00", VA = "0x184B7CC00")]
	public static List<LEELCPKGAKB> EPOPAOGMFCF(List<BMPGDODANBA> LOGEKBHDKCG, IKGOJPAHHIL DPMBBGBAAPB, Bounds LKJAGHOKCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D190", Offset = "0x4B7BF90", VA = "0x184B7D190")]
	private JobHandle KBAGHOBPNJJ(BOFFGMEMCAF IJCLIGAPIML, int HLNNDMJAFKA, int CPPNBPNIIGE, IKGOJPAHHIL DPMBBGBAAPB, List<IJFHMBJELIO> FCBAKMBALFO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CA80", Offset = "0x4B7B880", VA = "0x184B7CA80")]
	private void BENJLGBGFHF(List<IJFHMBJELIO> FCBAKMBALFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D850", Offset = "0x4B7C650", VA = "0x184B7D850")]
	private LEELCPKGAKB(List<IJFHMBJELIO> FCBAKMBALFO, int HLNNDMJAFKA, int CPPNBPNIIGE, IKGOJPAHHIL DPMBBGBAAPB, Bounds LKJAGHOKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CB80", Offset = "0x4B7B980", VA = "0x184B7CB80", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private MaterialPropertyBlock DKCMMMDCDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private LEELCPKGAKB KNAMODKBDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private List<Transform> BEFFGLLHOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private RenderTexture DHKKINELLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private ComputeBuffer JEIPCIHEKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private ComputeShader HKDDANEHHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private Matrix4x4[] AICLOMLNKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private int JDDCGLKDNBB;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public MeshRenderer NMCPJHBKBMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x52A460", Offset = "0x529260", VA = "0x18052A460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int JNJJIIHGCLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4B80B60", Offset = "0x4B7F960", VA = "0x184B80B60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4B7FFF0", Offset = "0x4B7EDF0", VA = "0x184B7FFF0")]
		public static List<SkinnedShapeRenderer> Create(GameObject FEAMLIHDEIF, List<LEELCPKGAKB> BNNBOCBFGFD, List<Transform> BEFFGLLHOIO, Material MGBLBJHKAGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4B80200", Offset = "0x4B7F000", VA = "0x184B80200")]
		public void Init(LEELCPKGAKB KNAMODKBDNN, List<Transform> BEFFGLLHOIO, Material MGBLBJHKAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4B80AD0", Offset = "0x4B7F8D0", VA = "0x184B80AD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4B80A40", Offset = "0x4B7F840", VA = "0x184B80A40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4B80A00", Offset = "0x4B7F800", VA = "0x184B80A00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4B80620", Offset = "0x4B7F420", VA = "0x184B80620")]
		private void NNEDNCGMPCA(ScriptableRenderContext FLMJHFDBGLA, Camera[] DNJHDMCJIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4B806B0", Offset = "0x4B7F4B0", VA = "0x184B806B0")]
		private void OJFADKABNDO(CommandBuffer FDOAOJFCMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x523A60", Offset = "0x522860", VA = "0x180523A60")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DFPNJGLKJCK
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static byte[] BHKGCCOPMJC;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int GBDAOKLIGMK;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int OHPBAKOKAFL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static BigInteger DGIAGADGPEN;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public DFPNJGLKJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4B75F60", Offset = "0x4B74D60", VA = "0x184B75F60")]
	private static string JPCMDGFJHKL(byte[] JLGJJNEIJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B75C30", Offset = "0x4B74A30", VA = "0x184B75C30")]
	public static string FNPNBMDGJBN(byte[] LPHHCMJDKLK, bool DODMIEKCDBF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
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
