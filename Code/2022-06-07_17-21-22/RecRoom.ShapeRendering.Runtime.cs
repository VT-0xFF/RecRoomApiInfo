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
public enum HJJAPKBOODA
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
public static class IFDMLBOHIBH
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<HJJAPKBOODA> ALOEIEELDNG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7CB0", Offset = "0x4DE64B0", VA = "0x184DE7CB0")]
	static IFDMLBOHIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7CB0", Offset = "0x4DE64B0", VA = "0x184DE7CB0")]
	[KPKNGEGAIEI]
	private static void EMFGCIHFDBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7DD0", Offset = "0x4DE65D0", VA = "0x184DE7DD0")]
	public static bool GKILKEJENKN(this HJJAPKBOODA AEMKABJHBHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MLDBBNIDEKG
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
public enum GKNCGEAOFKL
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
public enum DNPIEFKPOLP
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
public enum HOGIOMDECBL
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
public class FDPEIDPHNAG : LHCHHDLHEJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte OOOIJFBHCPD = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte KDHMMPOBOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] PKDJKEKGFAE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GFPNILNEEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x561CD0", Offset = "0x5604D0", VA = "0x180561CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A10", Offset = "0x5E1210", VA = "0x1805E2A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KACGGCOMFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x561CC0", Offset = "0x5604C0", VA = "0x180561CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C5AD0", Offset = "0x6C42D0", VA = "0x1806C5AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float DBGDBJACMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEA7970", Offset = "0xEA6170", VA = "0x180EA7970", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xFA0180", Offset = "0xF9E980", VA = "0x180FA0180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CHINNIMMFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE748E0", Offset = "0xE730E0", VA = "0x180E748E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE748D0", Offset = "0xE730D0", VA = "0x180E748D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> ACBMDCCKDNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4F50", Offset = "0x4DE3750", VA = "0x184DE4F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> GLCMDMIGMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x40D6370", Offset = "0x40D4B70", VA = "0x1840D6370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject APMCDMMCIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x589A30", Offset = "0x588230", VA = "0x180589A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6828D0", Offset = "0x6810D0", VA = "0x1806828D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte PJADPOLFFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4DE5210", Offset = "0x4DE3A10", VA = "0x184DE5210", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4DE54D0", Offset = "0x4DE3CD0", VA = "0x184DE54D0")]
	public FDPEIDPHNAG(List<KJPJKFJGFKG> AJJCBCBIDFC, List<KJPJKFJGFKG> EFKPEFEEMFB, List<Transform> JJGJHNLEIMO, Material LLCIFIIKFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4DE5260", Offset = "0x4DE3A60", VA = "0x184DE5260")]
	private int JFMFJCOGOHB(List<KJPJKFJGFKG> MAGEDIOBFKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4DE5370", Offset = "0x4DE3B70", VA = "0x184DE5370")]
	private void PMAGEFJONAI(int GKJFDEMLFIA, bool NFOGJPFOBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DE5120", Offset = "0x4DE3920", VA = "0x184DE5120")]
	public void GBKCBALCLCM(Vector3 GOLLHPLLPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4DE4FB0", Offset = "0x4DE37B0", VA = "0x184DE4FB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4DE50E0", Offset = "0x4DE38E0", VA = "0x184DE50E0")]
	public void FINMFEJBHDG(Transform DBLPPJNENOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KKHCIFBNEJF : NMEAKKDPDIG, JAJIGDHNMEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DNFKNMNONEI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KKHCIFBNEJF <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6723E0", Offset = "0x670BE0", VA = "0x1806723E0")]
		[DebuggerHidden]
		public DNFKNMNONEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4B30", Offset = "0x4DE3330", VA = "0x184DE4B30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4680", Offset = "0x4DE2E80", VA = "0x184DE4680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4CB0", Offset = "0x4DE34B0", VA = "0x184DE4CB0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4CF0", Offset = "0x4DE34F0", VA = "0x184DE4CF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4D40", Offset = "0x4DE3540", VA = "0x184DE4D40")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4AE0", Offset = "0x4DE32E0", VA = "0x184DE4AE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4A40", Offset = "0x4DE3240", VA = "0x184DE4A40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4A40", Offset = "0x4DE3240", VA = "0x184DE4A40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KLKPJPNBKAP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KKHCIFBNEJF <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6723E0", Offset = "0x670BE0", VA = "0x1806723E0")]
		[DebuggerHidden]
		public KLKPJPNBKAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4DEA710", Offset = "0x4DE8F10", VA = "0x184DEA710", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4DEA370", Offset = "0x4DE8B70", VA = "0x184DEA370", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4DEA830", Offset = "0x4DE9030", VA = "0x184DEA830")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4DEA880", Offset = "0x4DE9080", VA = "0x184DEA880")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4DEA6C0", Offset = "0x4DE8EC0", VA = "0x184DEA6C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4DEA620", Offset = "0x4DE8E20", VA = "0x184DEA620", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4DEA620", Offset = "0x4DE8E20", VA = "0x184DEA620", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private DFPMHFFAGFL ACDDFBBOOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<JANKJBEEDPG> NHLOJJNIELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> OBGGMHPANAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer PPPCHFCEEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool BMFKLBAMLPN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<PABLPJMAJCM> HHIMBFOAPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AGMMPGOCFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4DE9930", Offset = "0x4DE8130", VA = "0x184DE9930", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform IABLAMADKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4DE92F0", Offset = "0x4DE7AF0", VA = "0x184DE92F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> ONMCAIKMLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x562010", Offset = "0x560810", VA = "0x180562010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x562020", Offset = "0x560820", VA = "0x180562020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA2E0", Offset = "0x4DE8AE0", VA = "0x184DEA2E0")]
	public KKHCIFBNEJF(DFPMHFFAGFL JIJMHNDPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4DE91E0", Offset = "0x4DE79E0", VA = "0x184DE91E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9970", Offset = "0x4DE8170", VA = "0x184DE9970")]
	public void IONNJMGFDPB(JANKJBEEDPG DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9A60", Offset = "0x4DE8260", VA = "0x184DE9A60")]
	public void JPAMCOIJOBL(JANKJBEEDPG DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9340", Offset = "0x4DE7B40", VA = "0x184DE9340", Slot = "4")]
	public void GNOHBPNCEAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9130", Offset = "0x4DE7930", VA = "0x184DE9130")]
	public void ADBHOPCDBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9C10", Offset = "0x4DE8410", VA = "0x184DE9C10")]
	private void OHOFHCJGIOH(JANKJBEEDPG DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9D60", Offset = "0x4DE8560", VA = "0x184DE9D60")]
	public void PBGFHDKNGJP(bool EMOACMHLHGE, bool OOGPGELDONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9AD0", Offset = "0x4DE82D0", VA = "0x184DE9AD0")]
	protected void MOMOEMAGMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9280", Offset = "0x4DE7A80", VA = "0x184DE9280")]
	[IteratorStateMachine(typeof(DNFKNMNONEI))]
	public IEnumerable<Renderer> GJEBCJMEMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9210", Offset = "0x4DE7A10", VA = "0x184DE9210")]
	[IteratorStateMachine(typeof(KLKPJPNBKAP))]
	public IEnumerable<Renderer> FJADLHCONHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class GCNGLCHOABH : JANKJBEEDPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private IPFPEDNIODL NIBMGBIOBJF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4DE5A20", Offset = "0x4DE4220", VA = "0x184DE5A20")]
	private NativeList<JIJEBGFCFPK> HFMOIDCJNOP()
	{
		return default(NativeList<JIJEBGFCFPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4DE36E0", Offset = "0x4DE1EE0", VA = "0x184DE36E0")]
	public GCNGLCHOABH(KKHCIFBNEJF FFGCFPCOLFD, IPFPEDNIODL JIJMHNDPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4DE5AF0", Offset = "0x4DE42F0", VA = "0x184DE5AF0", Slot = "13")]
	public override int JFMFJCOGOHB(GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4DE5800", Offset = "0x4DE4000", VA = "0x184DE5800", Slot = "14")]
	public override int BDEHGAJBGCO(GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4DE5D10", Offset = "0x4DE4510", VA = "0x184DE5D10", Slot = "15")]
	public override void LEDBKMAFOMD(GMFMCAOCJOB FJMMOCNCCBH, HEEPHPELEBO LEHANDPMPPM, int EPNNCKJAFLP = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MCBKKOBEEDE : global::OINIFKJKGPO<MCBKKOBEEDE>, ONPIFBCILPJ, IEquatable<MCBKKOBEEDE>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int MPBCIHFGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7961F0", Offset = "0x7949F0", VA = "0x1807961F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x826E70", Offset = "0x825670", VA = "0x180826E70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JJMKFDIMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7961D0", Offset = "0x7949D0", VA = "0x1807961D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x800720", Offset = "0x7FEF20", VA = "0x180800720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x40A81E0", Offset = "0x40A69E0", VA = "0x1840A81E0", Slot = "8")]
	public bool Equals(MCBKKOBEEDE GKBKHIIEFAH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC0C0", Offset = "0x4DEA8C0", VA = "0x184DEC0C0")]
	public static bool AIKMOHENPEH(MCBKKOBEEDE FJNPOOOECPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NDKGIDGMIKH
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
public interface DFPMHFFAGFL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform JJLBACLEIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NDKGIDGMIKH PAIAENPOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NJLHPJJNMBH : global::OINIFKJKGPO<NJLHPJJNMBH>, ONPIFBCILPJ, IEquatable<NJLHPJJNMBH>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MPBCIHFGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7961F0", Offset = "0x7949F0", VA = "0x1807961F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x826E70", Offset = "0x825670", VA = "0x180826E70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int JJMKFDIMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7961D0", Offset = "0x7949D0", VA = "0x1807961D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x800720", Offset = "0x7FEF20", VA = "0x180800720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40A81E0", Offset = "0x40A69E0", VA = "0x1840A81E0", Slot = "8")]
	public bool Equals(NJLHPJJNMBH GKBKHIIEFAH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC140", Offset = "0x4DEA940", VA = "0x184DEC140")]
	public static bool AIKMOHENPEH(NJLHPJJNMBH FJNPOOOECPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NJNJCAMHFEN
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform JJLBACLEIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float BIHENIEOFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 FBNIGGNGHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HJJAPKBOODA DNOPDDPACOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MLDBBNIDEKG PKDMBMEMPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LFMGCBIEOMF : NJNJCAMHFEN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	FBJLLDPAKON CAPFDGPLLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EIIBLFAFCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IPFPEDNIODL : NJNJCAMHFEN
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool IBNDEMMHKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool COBODMJJOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float NJEDACBNPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int HANCIIEOBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NAAAFEENOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<JIJEBGFCFPK> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CHGADNDLAEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEKIOKIPFJG(NJLHPJJNMBH DBGDLOALBPN, DNPIEFKPOLP IGHLGHODIDD);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEKIOKIPFJG(MCBKKOBEEDE FFGCFPCOLFD, DNPIEFKPOLP IGHLGHODIDD);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FIKOJNOBAKP(MCBKKOBEEDE FFGCFPCOLFD);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIKOJNOBAKP(NJLHPJJNMBH DBGDLOALBPN);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJFKIMGDDAI(MCBKKOBEEDE FFGCFPCOLFD, HOGIOMDECBL DMBEFJIHONB);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MPBAFEGHIHO(MCBKKOBEEDE FFGCFPCOLFD, Vector3 PIKKPPHIPOC, Vector3 DJKHGLCLMKE, Vector3 NJOIELNHJOA, float CCPOLABDPMJ, float ABLIMNDKJMC, IReadOnlyList<Camera> KIACIHDHCPB, GKNCGEAOFKL PEKCNIKCJKL);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MPBAFEGHIHO(NBCDHEIDBOE JCBPKNJFMMA, Vector3 PIKKPPHIPOC, Vector3 DJKHGLCLMKE, Vector3 NJOIELNHJOA, float CCPOLABDPMJ, float ABLIMNDKJMC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MKJLIPOLKKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCBKKOBEEDE GEPNEHNOOIE(DFPMHFFAGFL JIJMHNDPFCA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHIHBNNDLEL(MCBKKOBEEDE FFGCFPCOLFD);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPDAAJCAFBN(MCBKKOBEEDE FFGCFPCOLFD);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJLHPJJNMBH PHHCBOBEBMF(MCBKKOBEEDE FFGCFPCOLFD, LFMGCBIEOMF JIJMHNDPFCA);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NJLHPJJNMBH FJDDHCKNIKD(MCBKKOBEEDE FFGCFPCOLFD, IPFPEDNIODL JIJMHNDPFCA);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMHPKPEKDFA(NJLHPJJNMBH DBGDLOALBPN);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IAKMGDOIGCH(NJLHPJJNMBH DBGDLOALBPN);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NBCDHEIDBOE JMEJCCEMLEN(PPBJAFOFDCF JIJMHNDPFCA);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HCNEOPOGDOP(NBCDHEIDBOE JCBPKNJFMMA);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LMHIOJNDCFB(NBCDHEIDBOE JCBPKNJFMMA);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HEHFIMBCOJI PMODMFEICNM(Transform NGPLIOECNKM, IEnumerable<NJLHPJJNMBH> NHLOJJNIELN, int DNDBBNEHKJE);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> PNKGBHAGELE(MCBKKOBEEDE FFGCFPCOLFD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NBCDHEIDBOE : global::OINIFKJKGPO<NBCDHEIDBOE>, ONPIFBCILPJ, IEquatable<NBCDHEIDBOE>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MPBCIHFGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7961F0", Offset = "0x7949F0", VA = "0x1807961F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x826E70", Offset = "0x825670", VA = "0x180826E70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int JJMKFDIMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7961D0", Offset = "0x7949D0", VA = "0x1807961D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x800720", Offset = "0x7FEF20", VA = "0x180800720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x40A81E0", Offset = "0x40A69E0", VA = "0x1840A81E0", Slot = "8")]
	public bool Equals(NBCDHEIDBOE GKBKHIIEFAH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC100", Offset = "0x4DEA900", VA = "0x184DEC100")]
	public static bool AIKMOHENPEH(NBCDHEIDBOE FJNPOOOECPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PPBJAFOFDCF
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int IDMNLJKCFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform FILPHEJNLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JHHAOICDHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MCBKKOBEEDE GetBone(int CPDLKGDIAIE);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int CPDLKGDIAIE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class ABFAHMAFPDD : JANKJBEEDPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public LFMGCBIEOMF DMKBLGIMOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] PMCJELCKHFA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override CEHABHFAEKI HPKIDHLMPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2510", Offset = "0x4DE0D10", VA = "0x184DE2510", Slot = "12")]
		get
		{
			return default(CEHABHFAEKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 HACCKDPPGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3000", Offset = "0x4DE1800", VA = "0x184DE3000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4DE36E0", Offset = "0x4DE1EE0", VA = "0x184DE36E0")]
	public ABFAHMAFPDD(KKHCIFBNEJF FFGCFPCOLFD, LFMGCBIEOMF JIJMHNDPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4DE31E0", Offset = "0x4DE19E0", VA = "0x184DE31E0", Slot = "11")]
	public override bool PMEOKPIGKIH(Transform FFGCFPCOLFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4DE28B0", Offset = "0x4DE10B0", VA = "0x184DE28B0", Slot = "13")]
	public override int JFMFJCOGOHB(GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4DE21F0", Offset = "0x4DE09F0", VA = "0x184DE21F0", Slot = "14")]
	public override int BDEHGAJBGCO(GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2290", Offset = "0x4DE0A90", VA = "0x184DE2290")]
	private int BMPLAAMKMPA(GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2950", Offset = "0x4DE1150", VA = "0x184DE2950", Slot = "15")]
	public override void LEDBKMAFOMD(GMFMCAOCJOB FJMMOCNCCBH, HEEPHPELEBO LEHANDPMPPM, int EPNNCKJAFLP = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HMIPIAJLBPL
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNAMEBFHCPL(HOGIOMDECBL DMBEFJIHONB, Renderer ALFJGJIMIDK, int JCNNLPOLIEI);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPDMHHCOHEA(Renderer ALFJGJIMIDK, GKNCGEAOFKL PEKCNIKCJKL, Vector3 PIKKPPHIPOC, Vector3 DJKHGLCLMKE, Vector3 NJOIELNHJOA, float CCPOLABDPMJ, float ABLIMNDKJMC, float HIOENAHADNM = -1f, [Optional] Color? NJHACKAPJOO, [Optional] IReadOnlyList<Camera> BMIADKKIEBB);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMGEFLCPCNK(Renderer ALFJGJIMIDK, int JCNNLPOLIEI);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MAHCILIGCON();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJLLIONBFNL(int HJOOCAGMOJG, DNPIEFKPOLP DMBEFJIHONB, Renderer ALFJGJIMIDK, int JCNNLPOLIEI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PMIACOPHHGD : CHGADNDLAEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly HMIPIAJLBPL LOGIONAOBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly NMLJINKIENI JLNGPFEKKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer BODKOLAIGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private MGCCKKHHPIN JGEJDHODICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer JEMJCMFKDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private MGCCKKHHPIN HKDGBOLAPNM;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x574990", Offset = "0x573190", VA = "0x180574990")]
	public PMIACOPHHGD(HMIPIAJLBPL BKNKBCIBHGO, NMLJINKIENI JLNGPFEKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC5D0", Offset = "0x4DEADD0", VA = "0x184DEC5D0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC180", Offset = "0x4DEA980", VA = "0x184DEC180", Slot = "4")]
	public void BEKIOKIPFJG(NJLHPJJNMBH DBGDLOALBPN, DNPIEFKPOLP IGHLGHODIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC400", Offset = "0x4DEAC00", VA = "0x184DEC400", Slot = "5")]
	public void BEKIOKIPFJG(MCBKKOBEEDE FFGCFPCOLFD, DNPIEFKPOLP IGHLGHODIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC970", Offset = "0x4DEB170", VA = "0x184DEC970", Slot = "6")]
	public void FIKOJNOBAKP(MCBKKOBEEDE FFGCFPCOLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC720", Offset = "0x4DEAF20", VA = "0x184DEC720", Slot = "7")]
	public void FIKOJNOBAKP(NJLHPJJNMBH DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4DECB10", Offset = "0x4DEB310", VA = "0x184DECB10", Slot = "8")]
	public void FJFKIMGDDAI(MCBKKOBEEDE FFGCFPCOLFD, HOGIOMDECBL DMBEFJIHONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4DED080", Offset = "0x4DEB880", VA = "0x184DED080", Slot = "9")]
	public void MPBAFEGHIHO(MCBKKOBEEDE FFGCFPCOLFD, Vector3 PIKKPPHIPOC, Vector3 DJKHGLCLMKE, Vector3 NJOIELNHJOA, float CCPOLABDPMJ, float ABLIMNDKJMC, IReadOnlyList<Camera> KIACIHDHCPB, GKNCGEAOFKL PEKCNIKCJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4DECCB0", Offset = "0x4DEB4B0", VA = "0x184DECCB0", Slot = "10")]
	public void MPBAFEGHIHO(NBCDHEIDBOE JCBPKNJFMMA, Vector3 PIKKPPHIPOC, Vector3 DJKHGLCLMKE, Vector3 NJOIELNHJOA, float CCPOLABDPMJ, float ABLIMNDKJMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class JANKJBEEDPG : OOELDOIPJKM, PABLPJMAJCM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds PDDHINPENOG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KKHCIFBNEJF APMCDMMCIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x561490", Offset = "0x55FC90", VA = "0x180561490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds MOGOMPMIDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1280CF0", Offset = "0x127F4F0", VA = "0x181280CF0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual CEHABHFAEKI HPKIDHLMPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4DE7EC0", Offset = "0x4DE66C0", VA = "0x184DE7EC0", Slot = "12")]
		get
		{
			return default(CEHABHFAEKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7E50", Offset = "0x4DE6650", VA = "0x184DE7E50", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x561EC0", Offset = "0x5606C0", VA = "0x180561EC0", Slot = "11")]
	public virtual bool PMEOKPIGKIH(Transform FFGCFPCOLFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int JFMFJCOGOHB(GMFMCAOCJOB FJMMOCNCCBH);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int BDEHGAJBGCO(GMFMCAOCJOB FJMMOCNCCBH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void LEDBKMAFOMD(GMFMCAOCJOB FJMMOCNCCBH, HEEPHPELEBO LEHANDPMPPM, int EPNNCKJAFLP = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	protected JANKJBEEDPG()
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
		[Cpp2IlInjected.Address(RVA = "0x4DED3B0", Offset = "0x4DEBBB0", VA = "0x184DED3B0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum FBJLLDPAKON
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
public static class DCCJCKFODOP
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EBIDPEFBOFI : IEnumerable<CHIDKPEJMNC>, IEnumerable, IEnumerator<CHIDKPEJMNC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private CHIDKPEJMNC <>2__current;

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
		private CHIDKPEJMNC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6723E0", Offset = "0x670BE0", VA = "0x1806723E0")]
		[DebuggerHidden]
		public EBIDPEFBOFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4D90", Offset = "0x4DE3590", VA = "0x184DE4D90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4F00", Offset = "0x4DE3700", VA = "0x184DE4F00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4E70", Offset = "0x4DE3670", VA = "0x184DE4E70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CHIDKPEJMNC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4E70", Offset = "0x4DE3670", VA = "0x184DE4E70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int MALHBCDHMLN = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static CHIDKPEJMNC[][] CBKCIBMPILG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static HECMHNJFHKO EIBDHFDIBPG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig FAPOOAGCJMN;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader EFFKNOFLBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3B30", Offset = "0x4DE2330", VA = "0x184DE3B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer NFNPCFGAHID
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3730", Offset = "0x4DE1F30", VA = "0x184DE3730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4DE4530", Offset = "0x4DE2D30", VA = "0x184DE4530")]
	public static Mesh PFNIAMMOLBM(FBJLLDPAKON DDFDBAFJANE, int FJMMOCNCCBH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4DE45F0", Offset = "0x4DE2DF0", VA = "0x184DE45F0")]
	public static int PIPJLBDLAJK(FBJLLDPAKON DDFDBAFJANE, int FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4DE39C0", Offset = "0x4DE21C0", VA = "0x184DE39C0")]
	public static HECMHNJFHKO DKCICJALFME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4DE4310", Offset = "0x4DE2B10", VA = "0x184DE4310")]
	[IteratorStateMachine(typeof(EBIDPEFBOFI))]
	private static IEnumerable<CHIDKPEJMNC> MDCIFNIFBDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3FD0", Offset = "0x4DE27D0", VA = "0x184DE3FD0")]
	public static CHIDKPEJMNC JEIIFFEEJCD(FBJLLDPAKON DDFDBAFJANE, int FJMMOCNCCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3B10", Offset = "0x4DE2310", VA = "0x184DE3B10")]
	public static bool FAFGPKDPMEH(this FBJLLDPAKON DDFDBAFJANE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4DE4370", Offset = "0x4DE2B70", VA = "0x184DE4370")]
	public static void NHCPNMKOGIG(FBJLLDPAKON DDFDBAFJANE, float3 NOGHPDEIIJI, out OBBOONDINNF FAKJHODGBOC, out float3 FHJHJJJPLKL, out float BNPEIILNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3BB0", Offset = "0x4DE23B0", VA = "0x184DE3BB0")]
	public static void HHDOOHACNJI(Vector3 NOGHPDEIIJI, FBJLLDPAKON DDFDBAFJANE, out Vector3 FHJHJJJPLKL, out float BNPEIILNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3BA0", Offset = "0x4DE23A0", VA = "0x184DE3BA0")]
	[OMDJHDHMGFL(MFFCDMKLBEG.ExitingPlayMode, 0)]
	private static void GOHLIDDBIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4DE37A0", Offset = "0x4DE1FA0", VA = "0x184DE37A0")]
	[OMDJHDHMGFL(MFFCDMKLBEG.ExitingPlayMode, 0)]
	private static void COGNHHDEKIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BBMHEHMJLJB
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool EIJAIOLCAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KONOJPFNBJC();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material OICFPHKMBHP();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material MKIMADICMAG();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OMMOGCBCILJ(HJJAPKBOODA LJIAGIABFIH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AKPCEEMBHAK(MLDBBNIDEKG HHBJJKAMFHF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void APOBAHDLPNO(GameObject OMILIKJDDEJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MMPPLPLMONB(GameObject OMILIKJDDEJ, bool FLFGEIJBOMF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface NMLJINKIENI
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	KKHCIFBNEJF PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	JANKJBEEDPG PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	GFNJBLEAIAB PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class MAIBMEEIFFO : MKJLIPOLKKP, IDisposable, NMLJINKIENI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::EIIKLAMBHDF<MCBKKOBEEDE, KKHCIFBNEJF> PBHFIGBOFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::EIIKLAMBHDF<NJLHPJJNMBH, JANKJBEEDPG> NHLOJJNIELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::EIIKLAMBHDF<NBCDHEIDBOE, GFNJBLEAIAB> GILEEECBNDP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static BBMHEHMJLJB NBKGMPBAGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4DEB4E0", Offset = "0x4DE9CE0", VA = "0x184DEB4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4DEAEB0", Offset = "0x4DE96B0", VA = "0x184DEAEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KKHCIFBNEJF PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4DEB730", Offset = "0x4DE9F30", VA = "0x184DEB730", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public JANKJBEEDPG PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4DEB670", Offset = "0x4DE9E70", VA = "0x184DEB670", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public GFNJBLEAIAB PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4DEB6D0", Offset = "0x4DE9ED0", VA = "0x184DEB6D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4DEBC50", Offset = "0x4DEA450", VA = "0x184DEBC50")]
	public MAIBMEEIFFO(BBMHEHMJLJB BKNKBCIBHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4DEAF00", Offset = "0x4DE9700", VA = "0x184DEAF00", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB0C0", Offset = "0x4DE98C0", VA = "0x184DEB0C0", Slot = "4")]
	public MCBKKOBEEDE GEPNEHNOOIE(DFPMHFFAGFL JIJMHNDPFCA)
	{
		return default(MCBKKOBEEDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4DEAF70", Offset = "0x4DE9770", VA = "0x184DEAF70", Slot = "5")]
	public void EHIHBNNDLEL(MCBKKOBEEDE FFGCFPCOLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB400", Offset = "0x4DE9C00", VA = "0x184DEB400", Slot = "6")]
	public void JPDAAJCAFBN(MCBKKOBEEDE FFGCFPCOLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4DEBB90", Offset = "0x4DEA390", VA = "0x184DEBB90", Slot = "15")]
	public IEnumerable<Renderer> PNKGBHAGELE(MCBKKOBEEDE FFGCFPCOLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB520", Offset = "0x4DE9D20", VA = "0x184DEB520", Slot = "7")]
	public NJLHPJJNMBH PHHCBOBEBMF(MCBKKOBEEDE FFGCFPCOLFD, LFMGCBIEOMF JIJMHNDPFCA)
	{
		return default(NJLHPJJNMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DEAFD0", Offset = "0x4DE97D0", VA = "0x184DEAFD0", Slot = "8")]
	public NJLHPJJNMBH FJDDHCKNIKD(MCBKKOBEEDE FFGCFPCOLFD, IPFPEDNIODL JIJMHNDPFCA)
	{
		return default(NJLHPJJNMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB200", Offset = "0x4DE9A00", VA = "0x184DEB200", Slot = "10")]
	public void IAKMGDOIGCH(NJLHPJJNMBH DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB610", Offset = "0x4DE9E10", VA = "0x184DEB610", Slot = "9")]
	public void PMHPKPEKDFA(NJLHPJJNMBH DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB270", Offset = "0x4DE9A70", VA = "0x184DEB270", Slot = "11")]
	public NBCDHEIDBOE JMEJCCEMLEN(PPBJAFOFDCF JIJMHNDPFCA)
	{
		return default(NBCDHEIDBOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB470", Offset = "0x4DE9C70", VA = "0x184DEB470", Slot = "13")]
	public void LMHIOJNDCFB(NBCDHEIDBOE JCBPKNJFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB1A0", Offset = "0x4DE99A0", VA = "0x184DEB1A0", Slot = "12")]
	public void HCNEOPOGDOP(NBCDHEIDBOE JCBPKNJFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB790", Offset = "0x4DE9F90", VA = "0x184DEB790", Slot = "14")]
	public HEHFIMBCOJI PMODMFEICNM(Transform NGPLIOECNKM, IEnumerable<NJLHPJJNMBH> NHLOJJNIELN, int DNDBBNEHKJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GFNJBLEAIAB : NMEAKKDPDIG
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class HHFCKHOJOAB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GFNJBLEAIAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6723E0", Offset = "0x670BE0", VA = "0x1806723E0")]
		[DebuggerHidden]
		public HHFCKHOJOAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4DE7BD0", Offset = "0x4DE63D0", VA = "0x184DE7BD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4DE78F0", Offset = "0x4DE60F0", VA = "0x184DE78F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4DE7C70", Offset = "0x4DE6470", VA = "0x184DE7C70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4DE7B80", Offset = "0x4DE6380", VA = "0x184DE7B80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4DE7AE0", Offset = "0x4DE62E0", VA = "0x184DE7AE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4DE7AE0", Offset = "0x4DE62E0", VA = "0x184DE7AE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly PPBJAFOFDCF BKDBPGIBELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly NMLJINKIENI JLNGPFEKKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FDPEIDPHNAG CCKJNAOCEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<KJPJKFJGFKG> NFJLHAAECAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<KJPJKFJGFKG> JJCFFAIKOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject FLIKAGKCFFG;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7450", Offset = "0x4DE5C50", VA = "0x184DE7450")]
	public static GFNJBLEAIAB OHMBBNDLLOE(PPBJAFOFDCF JIJMHNDPFCA, NMLJINKIENI JLNGPFEKKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4DE75B0", Offset = "0x4DE5DB0", VA = "0x184DE75B0")]
	private GFNJBLEAIAB(PPBJAFOFDCF JIJMHNDPFCA, NMLJINKIENI JLNGPFEKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6ED0", Offset = "0x4DE56D0", VA = "0x184DE6ED0")]
	public void GPGHDCEFFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6410", Offset = "0x4DE4C10", VA = "0x184DE6410")]
	[IteratorStateMachine(typeof(HHFCKHOJOAB))]
	public IEnumerable<Renderer> GJEBCJMEMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6480", Offset = "0x4DE4C80", VA = "0x184DE6480", Slot = "4")]
	public void GNOHBPNCEAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7420", Offset = "0x4DE5C20", VA = "0x184DE7420")]
	private void LAFKNIDOKFF(Vector3 GOLLHPLLPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6240", Offset = "0x4DE4A40", VA = "0x184DE6240")]
	public void ADBHOPCDBIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KJPJKFJGFKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct FCCOOGDDHCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HEEPHPELEBO KLHPKDLBEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform OEGKAHIHOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int KODKEKAKGGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class HGADAPCFCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public KJPJKFJGFKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public GMFMCAOCJOB lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<FCCOOGDDHCK> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public HGADAPCFCCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GLALAHOKDNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public HEHFIMBCOJI combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public HGADAPCFCCO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public GLALAHOKDNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4DE76B0", Offset = "0x4DE5EB0", VA = "0x184DE76B0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4DE7720", Offset = "0x4DE5F20", VA = "0x184DE7720")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4DE7760", Offset = "0x4DE5F60", VA = "0x184DE7760")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] CKKEEJJKKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private LECOGMKDAFL FILAGPMMJEO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 BGNIHGOELJI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh FLOCMKDBCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x561490", Offset = "0x55FC90", VA = "0x180561490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int DKNAPJEHCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5ED670", Offset = "0x5EBE70", VA = "0x1805ED670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BD230", Offset = "0x6BBA30", VA = "0x1806BD230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4DE8050", Offset = "0x4DE6850", VA = "0x184DE8050")]
	public void CIJCGPILDPM(List<Transform> LCIPNBKODML, Matrix4x4[] LMLMHHIMAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4DE86E0", Offset = "0x4DE6EE0", VA = "0x184DE86E0")]
	public static List<KJPJKFJGFKG> JHOEBDGEJAE(List<KKHCIFBNEJF> NOGIAGLIBJI, GMFMCAOCJOB FJMMOCNCCBH, Bounds IMMOIOCNOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4DE82D0", Offset = "0x4DE6AD0", VA = "0x184DE82D0")]
	private JobHandle GFEKBINHDNJ(HEHFIMBCOJI DPLIMDEEHIG, int IOLIAJJECFM, int IOLKGOCEIDO, GMFMCAOCJOB FJMMOCNCCBH, List<FCCOOGDDHCK> GJCHIDLOBJJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7F50", Offset = "0x4DE6750", VA = "0x184DE7F50")]
	private void BEPODBDOPFH(List<FCCOOGDDHCK> GJCHIDLOBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4DE8D80", Offset = "0x4DE7580", VA = "0x184DE8D80")]
	private KJPJKFJGFKG(List<FCCOOGDDHCK> GJCHIDLOBJJ, int IOLIAJJECFM, int IOLKGOCEIDO, GMFMCAOCJOB FJMMOCNCCBH, Bounds IMMOIOCNOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4DE8250", Offset = "0x4DE6A50", VA = "0x184DE8250", Slot = "4")]
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
		private MaterialPropertyBlock ANBHHNHFMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private KJPJKFJGFKG ACEMLDCDLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> JJGJHNLEIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture JHHKIFLNANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer OFGEIGBNFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader AOOEOCPGPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] IDEMEACCBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int DHELIJEOOJE;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer NHNNHEMHLDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5614A0", Offset = "0x55FCA0", VA = "0x1805614A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int IDMNLJKCFOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4DEDF50", Offset = "0x4DEC750", VA = "0x184DEDF50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4DED730", Offset = "0x4DEBF30", VA = "0x184DED730")]
		public static List<SkinnedShapeRenderer> Create(GameObject FFGCFPCOLFD, List<KJPJKFJGFKG> MAGEDIOBFKO, List<Transform> JJGJHNLEIMO, Material LLCIFIIKFDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4DED940", Offset = "0x4DEC140", VA = "0x184DED940")]
		public void Init(KJPJKFJGFKG ACEMLDCDLCF, List<Transform> JJGJHNLEIMO, Material LLCIFIIKFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4DEDEC0", Offset = "0x4DEC6C0", VA = "0x184DEDEC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4DEDE30", Offset = "0x4DEC630", VA = "0x184DEDE30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4DEDDF0", Offset = "0x4DEC5F0", VA = "0x184DEDDF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4DEDD60", Offset = "0x4DEC560", VA = "0x184DEDD60")]
		private void NAAICBBFOJP(ScriptableRenderContext OLNEIJPLPKF, Camera[] EHILDGMNOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4DED3E0", Offset = "0x4DEBBE0", VA = "0x184DED3E0")]
		private void CIJCGPILDPM(CommandBuffer FHNMLCKMKHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xC71680", Offset = "0xC6FE80", VA = "0x180C71680")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LCEEBCMBKCD
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] FOBLDOOIPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int MKBJJHBJLOC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int IFDBKDIOMPI;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger GDKMPNMIOJK;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA8C0", Offset = "0x4DE90C0", VA = "0x184DEA8C0")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA9C0", Offset = "0x4DE91C0", VA = "0x184DEA9C0")]
	public static string CAJPNALAKAJ(byte[] JNPIAJHKCKB, bool GKIDOBEBBAE)
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
