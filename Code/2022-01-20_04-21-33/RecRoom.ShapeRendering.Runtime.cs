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
public enum GIMGKACPMAM
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
	DARK_TAN = 33,
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
public enum KBDKMDGOCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	PLACEHOLDER_16 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IELPKOIHPCO
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HOHICNIFIKA
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	NearbyContextual
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BCKNEFPJFOC
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KGLKLGNKAAC : DPFLNHGMNFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private const byte INFODLINPMP = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private byte LMCPLEFEMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly List<SkinnedShapeRenderer>[] DDECOBCNGGM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DNFCDLLBFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E2910", Offset = "0x5E1110", VA = "0x1805E2910", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x631A30", Offset = "0x630230", VA = "0x180631A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BHHIKGDNAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62CF50", Offset = "0x62B750", VA = "0x18062CF50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62CF70", Offset = "0x62B770", VA = "0x18062CF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float EPJIEHOLCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C8090", Offset = "0x7C6890", VA = "0x1807C8090", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBFC050", Offset = "0xBFA850", VA = "0x180BFC050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JBPJNIECNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5A3720", Offset = "0x5A1F20", VA = "0x1805A3720", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5A3170", Offset = "0x5A1970", VA = "0x1805A3170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> OALCDPILHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x43A9860", Offset = "0x43A8060", VA = "0x1843A9860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject IOHEHEBKIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD90", Offset = "0x4DA590", VA = "0x1804DBD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD70", Offset = "0x4DA570", VA = "0x1804DBD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte FDJHKBKFIIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x43A95A0", Offset = "0x43A7DA0", VA = "0x1843A95A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x43A9900", Offset = "0x43A8100", VA = "0x1843A9900")]
	public KGLKLGNKAAC(List<GPHAKJEKCOA> EMGGCFKKEKC, List<GPHAKJEKCOA> NGOAGKBDFFE, List<Transform> BPLJFKPNKBJ, Material ELNAGKLKGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x43A95F0", Offset = "0x43A7DF0", VA = "0x1843A95F0")]
	private int HCCGGHNPNGE(List<GPHAKJEKCOA> ENDFMMIKMHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x43A9700", Offset = "0x43A7F00", VA = "0x1843A9700")]
	private void JGAFAKPLLNO(int MKOIACIKJGP, bool OKFOOIACHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x43A9420", Offset = "0x43A7C20", VA = "0x1843A9420")]
	public void BNKEIIOJCOJ(Vector3 KHMLMJNGEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x43A9510", Offset = "0x43A7D10", VA = "0x1843A9510", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x43A98C0", Offset = "0x43A80C0", VA = "0x1843A98C0")]
	public void NCNAHMIKENO(Transform IBEOEJHEKIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HJILJIBBNGJ : DLDLAOFHMHI, EHEFPKMLOKN, NGKFDMLOMOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GODEEJOKGKK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public HJILJIBBNGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7748B0", Offset = "0x7730B0", VA = "0x1807748B0")]
		[DebuggerHidden]
		public GODEEJOKGKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x43A59B0", Offset = "0x43A41B0", VA = "0x1843A59B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x43A5540", Offset = "0x43A3D40", VA = "0x1843A5540", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x43A5B30", Offset = "0x43A4330", VA = "0x1843A5B30")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x43A5B70", Offset = "0x43A4370", VA = "0x1843A5B70")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x43A5BC0", Offset = "0x43A43C0", VA = "0x1843A5BC0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x43A5960", Offset = "0x43A4160", VA = "0x1843A5960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x43A58C0", Offset = "0x43A40C0", VA = "0x1843A58C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x43A58C0", Offset = "0x43A40C0", VA = "0x1843A58C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private OIMOBAIHPFL NEMOKKFEKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private List<MIDBINPBIEJ> OGEFHPCGKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private List<ClusterMeshRenderer> MMJOJKBNEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private BatchedMeshRenderer HDINEALKBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool MGNPIIFOGNB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<AEOAHPKBJJA> KGHGOBNIOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int BOKNEIDMEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x43A7590", Offset = "0x43A5D90", VA = "0x1843A7590", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform OHDBODDDLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x43A7BB0", Offset = "0x43A63B0", VA = "0x1843A7BB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal override HJILJIBBNGJ DCLEOPGNPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F50", Offset = "0x5A4750", VA = "0x1805A5F50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x43A7C00", Offset = "0x43A6400", VA = "0x1843A7C00")]
	public HJILJIBBNGJ(OIMOBAIHPFL MBGHNFHMMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x43A6DF0", Offset = "0x43A55F0", VA = "0x1843A6DF0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x43A6EB0", Offset = "0x43A56B0", VA = "0x1843A6EB0")]
	public void GMBMAEFCBMN(MIDBINPBIEJ AHDAOMFLKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x43A75D0", Offset = "0x43A5DD0", VA = "0x1843A75D0")]
	public void MEHJLGGLJCP(MIDBINPBIEJ AHDAOMFLKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x43A7630", Offset = "0x43A5E30", VA = "0x1843A7630", Slot = "5")]
	public void NKPAIFAJIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x43A6E20", Offset = "0x43A5620", VA = "0x1843A6E20")]
	public void GEBMKMPLJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x43A6F80", Offset = "0x43A5780", VA = "0x1843A6F80")]
	private void IFMNBCNLNOF(MIDBINPBIEJ AHDAOMFLKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x43A70C0", Offset = "0x43A58C0", VA = "0x1843A70C0")]
	public void JJMCNOHNBLB(bool GCIOAOFOOHB, bool NJOLHBABKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x43A6CE0", Offset = "0x43A54E0", VA = "0x1843A6CE0")]
	protected void AHCHGFEAAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x43A7B40", Offset = "0x43A6340", VA = "0x1843A7B40")]
	[IteratorStateMachine(typeof(GODEEJOKGKK))]
	public IEnumerable<Renderer> OGFNCEGLHIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class HOFMCABIANL : MIDBINPBIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private EGCGDGPGCHE HFPDPPJGOBM;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43A85E0", Offset = "0x43A6DE0", VA = "0x1843A85E0")]
	private NativeList<FACJFONPHHO> KPJPCOGFDGJ()
	{
		return default(NativeList<FACJFONPHHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43A86B0", Offset = "0x43A6EB0", VA = "0x1843A86B0")]
	public HOFMCABIANL(HJILJIBBNGJ LHEBAIHADCN, EGCGDGPGCHE MBGHNFHMMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x43A81A0", Offset = "0x43A69A0", VA = "0x1843A81A0", Slot = "14")]
	public override int HCCGGHNPNGE(NEMIOKPMGJC LGLCJGAGAEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x43A83C0", Offset = "0x43A6BC0", VA = "0x1843A83C0", Slot = "15")]
	public override int JLNFGEKNBCB(NEMIOKPMGJC LGLCJGAGAEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x43A7C70", Offset = "0x43A6470", VA = "0x1843A7C70", Slot = "16")]
	public override void DFMKKOMEPKA(NEMIOKPMGJC LGLCJGAGAEP, PMMHIBIOLKN KBLFEOAKGAA, int JNIJNHBIDBB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class DLDLAOFHMHI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	internal virtual HJILJIBBNGJ DCLEOPGNPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x575030", Offset = "0x573830", VA = "0x180575030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	protected DLDLAOFHMHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum PPONDIADGOI
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OIMOBAIHPFL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform FHGBAJNPJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	PPONDIADGOI HHKFNDJPCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class IIIGOAPHPEH
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal virtual MIDBINPBIEJ IBPGNCKJOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x575030", Offset = "0x573830", VA = "0x180575030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	protected IIIGOAPHPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OEICEBEPCEF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform FHGBAJNPJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float DBOONODFMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Vector3 IDDBGIKLNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	GIMGKACPMAM GDDLMHLIFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KBDKMDGOCDF FJMECGHBJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JNEMIBJEBPC : OEICEBEPCEF
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MPPPLMNJJKK OFKNIDPGEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HKDIJKHECGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EGCGDGPGCHE : OEICEBEPCEF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CMAGGIHDEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool AAHKHJKAGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float BGBPJHMLOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	int KHCCJEIBECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NCNCBDMBFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<FACJFONPHHO> KPJPCOGFDGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BLDOFBNBJJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNOPHGJJHCN(IIIGOAPHPEH AHDAOMFLKHJ, HOHICNIFIKA IKBFGOBECKE);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNOPHGJJHCN(DLDLAOFHMHI LHEBAIHADCN, HOHICNIFIKA IKBFGOBECKE);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKFDPPJLHNP(DLDLAOFHMHI LHEBAIHADCN);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void POEDCHCAPJH(DLDLAOFHMHI LHEBAIHADCN, BCKNEFPJFOC AOIJDDCBKCK);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHKNKCPNONC(DLDLAOFHMHI LHEBAIHADCN, Vector3 FAJGOHOHCNP, Vector3 DJABGDFKDGE, Vector3 DIMFKEHKECI, float CDKIOGHNGIH, float EADDNPHKNPJ, IReadOnlyList<Camera> DCOBGJKIODC, IELPKOIHPCO BJOEELIIJDH);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHKNKCPNONC(IBKDAPIDLLH GLIPHCENJFO, object LFKHECCFNCA, object IBCDGINELOB, float LLJGLJHCJHP, Color? IIGHMMKCHLM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KCHGOMCAHNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DLDLAOFHMHI FCKCILLHJNL(OIMOBAIHPFL MBGHNFHMMHH);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEIEBBAAFON(DLDLAOFHMHI LHEBAIHADCN);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCKOOJJPOEN(DLDLAOFHMHI LHEBAIHADCN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IIIGOAPHPEH IJBJHEGFOIL(DLDLAOFHMHI LHEBAIHADCN, JNEMIBJEBPC MBGHNFHMMHH);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IIIGOAPHPEH POECNDAJCKH(DLDLAOFHMHI LHEBAIHADCN, EGCGDGPGCHE MBGHNFHMMHH);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BCFIFDDIILC(IIIGOAPHPEH AHDAOMFLKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GGOFODKOMCC(IIIGOAPHPEH AHDAOMFLKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IBKDAPIDLLH JJGJIMOBKFK(PGOGCOKEKOM MBGHNFHMMHH);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ONGKPMLIJAI(IBKDAPIDLLH GLIPHCENJFO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GAFNCFGCIKJ(IBKDAPIDLLH GLIPHCENJFO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BBALKBLIGPE NPAIGBILAJK(Transform OJMHDKHMEMA, IEnumerable<IIIGOAPHPEH> OGEFHPCGKNG, int APJCINPMAHI);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> EOCGMKFCJIL(DLDLAOFHMHI LHEBAIHADCN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class IBKDAPIDLLH
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal virtual BPBAAGIBAOM DPHDCPJACCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x575030", Offset = "0x573830", VA = "0x180575030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	protected IBKDAPIDLLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PGOGCOKEKOM
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int MKAKIMLKJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	Transform NNKACHKOFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MJEPNBPIDPM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DLDLAOFHMHI GetBone(int MEPCOBOJIDE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MEPCOBOJIDE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class PNHJKBNMFJD : MIDBINPBIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public JNEMIBJEBPC ODIDKBIMBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int[] KBIPKGLPCOB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public override JFNGNGFNHLC HMAOPCHBLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x43ABD80", Offset = "0x43AA580", VA = "0x1843ABD80", Slot = "13")]
		get
		{
			return default(JFNGNGFNHLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Vector3 OMLCOOEMNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x43AC990", Offset = "0x43AB190", VA = "0x1843AC990")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x43A86B0", Offset = "0x43A6EB0", VA = "0x1843A86B0")]
	public PNHJKBNMFJD(HJILJIBBNGJ LHEBAIHADCN, JNEMIBJEBPC MBGHNFHMMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x43AC1C0", Offset = "0x43AA9C0", VA = "0x1843AC1C0", Slot = "12")]
	public override bool HNAMCOEGOND(Transform LHEBAIHADCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x43AC120", Offset = "0x43AA920", VA = "0x1843AC120", Slot = "14")]
	public override int HCCGGHNPNGE(NEMIOKPMGJC LGLCJGAGAEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x43AC6C0", Offset = "0x43AAEC0", VA = "0x1843AC6C0", Slot = "15")]
	public override int JLNFGEKNBCB(NEMIOKPMGJC LGLCJGAGAEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x43AC760", Offset = "0x43AAF60", VA = "0x1843AC760")]
	private int MEPBLEEMBKB(NEMIOKPMGJC LGLCJGAGAEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x43AB6D0", Offset = "0x43A9ED0", VA = "0x1843AB6D0", Slot = "16")]
	public override void DFMKKOMEPKA(NEMIOKPMGJC LGLCJGAGAEP, PMMHIBIOLKN KBLFEOAKGAA, int JNIJNHBIDBB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NDCCBGAPEEO
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DENFCEJLLDK(BCKNEFPJFOC AOIJDDCBKCK, Renderer DEJBIJHCHBG, int OEBNJEDALFE);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPAKHFEAFHL(Renderer DEJBIJHCHBG, IELPKOIHPCO BJOEELIIJDH, Vector3 FAJGOHOHCNP, Vector3 DJABGDFKDGE, Vector3 DIMFKEHKECI, float CDKIOGHNGIH, float EADDNPHKNPJ, float LLJGLJHCJHP = -1f, [Optional] Color? IIGHMMKCHLM, [Optional] IReadOnlyList<Camera> EOJMLKDJJCC);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPAKHFEAFHL(Renderer DEJBIJHCHBG, object LFKHECCFNCA, object IBCDGINELOB, bool BAGBDDDNOLI, float LLJGLJHCJHP, Color? IIGHMMKCHLM, bool FBOJAFLDLCD = false);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MOLCMHIKIGJ(Renderer DEJBIJHCHBG, int OEBNJEDALFE);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OFLGGJKEDKP();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMNAENDDHJN(int JGIKAJILGPP, HOHICNIFIKA AOIJDDCBKCK, Renderer DEJBIJHCHBG, int OEBNJEDALFE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AKIOPEJPHGL : BLDOFBNBJJD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private NDCCBGAPEEO EJBKCHOCAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private MeshRenderer HHEPPBLNIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private CHHNBDLBDDP BLCMKMJLBGI;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x59DDB0", Offset = "0x59C5B0", VA = "0x18059DDB0")]
	public AKIOPEJPHGL(NDCCBGAPEEO JHNNILPHNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x43A3A60", Offset = "0x43A2260", VA = "0x1843A3A60", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x43A3810", Offset = "0x43A2010", VA = "0x1843A3810", Slot = "4")]
	public void CNOPHGJJHCN(IIIGOAPHPEH AHDAOMFLKHJ, HOHICNIFIKA IKBFGOBECKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x43A3600", Offset = "0x43A1E00", VA = "0x1843A3600", Slot = "5")]
	public void CNOPHGJJHCN(DLDLAOFHMHI LHEBAIHADCN, HOHICNIFIKA IKBFGOBECKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x43A4140", Offset = "0x43A2940", VA = "0x1843A4140", Slot = "6")]
	public void FKFDPPJLHNP(DLDLAOFHMHI LHEBAIHADCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x43A4300", Offset = "0x43A2B00", VA = "0x1843A4300", Slot = "7")]
	public void POEDCHCAPJH(DLDLAOFHMHI LHEBAIHADCN, BCKNEFPJFOC AOIJDDCBKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x43A3B00", Offset = "0x43A2300", VA = "0x1843A3B00", Slot = "8")]
	public void FHKNKCPNONC(DLDLAOFHMHI LHEBAIHADCN, Vector3 FAJGOHOHCNP, Vector3 DJABGDFKDGE, Vector3 DIMFKEHKECI, float CDKIOGHNGIH, float EADDNPHKNPJ, IReadOnlyList<Camera> DCOBGJKIODC, IELPKOIHPCO BJOEELIIJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x43A3E70", Offset = "0x43A2670", VA = "0x1843A3E70", Slot = "9")]
	public void FHKNKCPNONC(IBKDAPIDLLH GLIPHCENJFO, object LFKHECCFNCA, object IBCDGINELOB, float LLJGLJHCJHP, Color? IIGHMMKCHLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class MIDBINPBIEJ : IIIGOAPHPEH, NDHHMAGGOLL, AEOAHPKBJJA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected Bounds JHAMGINPCCA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public HJILJIBBNGJ IOHEHEBKIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4D7850", Offset = "0x4D6050", VA = "0x1804D7850")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal override MIDBINPBIEJ IBPGNCKJOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F50", Offset = "0x5A4750", VA = "0x1805A5F50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Bounds DBCBJPAEKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xF31F40", Offset = "0xF30740", VA = "0x180F31F40", Slot = "5")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual JFNGNGFNHLC HMAOPCHBLID
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x43A9DC0", Offset = "0x43A85C0", VA = "0x1843A9DC0", Slot = "13")]
		get
		{
			return default(JFNGNGFNHLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5121A0", Offset = "0x5109A0", VA = "0x1805121A0", Slot = "12")]
	public virtual bool HNAMCOEGOND(Transform LHEBAIHADCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int HCCGGHNPNGE(NEMIOKPMGJC LGLCJGAGAEP);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract int JLNFGEKNBCB(NEMIOKPMGJC LGLCJGAGAEP);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract void DFMKKOMEPKA(NEMIOKPMGJC LGLCJGAGAEP, PMMHIBIOLKN KBLFEOAKGAA, int JNIJNHBIDBB = -1);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	protected MIDBINPBIEJ()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x43ACB70", Offset = "0x43AB370", VA = "0x1843ACB70")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum MPPPLMNJJKK
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OHBMGHCDNKC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IHEPPKJPLEJ : IEnumerable<KGCPCCDPOFL>, IEnumerable, IEnumerator<KGCPCCDPOFL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private KGCPCCDPOFL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private KGCPCCDPOFL System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7748B0", Offset = "0x7730B0", VA = "0x1807748B0")]
		[DebuggerHidden]
		public IHEPPKJPLEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x43A9270", Offset = "0x43A7A70", VA = "0x1843A9270", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x43A93D0", Offset = "0x43A7BD0", VA = "0x1843A93D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x43A9340", Offset = "0x43A7B40", VA = "0x1843A9340", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KGCPCCDPOFL> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x43A9340", Offset = "0x43A7B40", VA = "0x1843A9340", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const int LLALIABPKMD = 3;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static KGCPCCDPOFL[][] NPJMOGNNGMF;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static DFLJODNIFHO BPHGODPCPBM;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public static ShapeRendererConfig EFCDNOCOEED;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static ComputeShader ILIAIHPLMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x43AB580", Offset = "0x43A9D80", VA = "0x1843AB580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static SkinnedShapeRenderer OHEPFAICBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x43AB5F0", Offset = "0x43A9DF0", VA = "0x1843AB5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x43AB4C0", Offset = "0x43A9CC0", VA = "0x1843AB4C0")]
	public static Mesh NLMOBPPCIEP(MPPPLMNJJKK LGPBAPFGDGE, int LGLCJGAGAEP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x43AA7E0", Offset = "0x43A8FE0", VA = "0x1843AA7E0")]
	public static int ACCAGIJLAMD(MPPPLMNJJKK LGPBAPFGDGE, int LGLCJGAGAEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x43AA9B0", Offset = "0x43A91B0", VA = "0x1843AA9B0")]
	public static DFLJODNIFHO CFHBFBAMIPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x43AAD20", Offset = "0x43A9520", VA = "0x1843AAD20")]
	[IteratorStateMachine(typeof(IHEPPKJPLEJ))]
	private static IEnumerable<KGCPCCDPOFL> IKMPHIGOBEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x43AAD80", Offset = "0x43A9580", VA = "0x1843AAD80")]
	public static KGCPCCDPOFL INDAOMGMPNL(MPPPLMNJJKK LGPBAPFGDGE, int LGLCJGAGAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x43AAAF0", Offset = "0x43A92F0", VA = "0x1843AAAF0")]
	public static bool DBMNGDLOLIO(this MPPPLMNJJKK LGPBAPFGDGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x43AA7F0", Offset = "0x43A8FF0", VA = "0x1843AA7F0")]
	public static void APOFJOMEPLC(MPPPLMNJJKK LGPBAPFGDGE, float3 DEMNMIOKCLM, out NMJDIDBOCGB OFGGFOFGGGL, out float3 OHCLPBLHIEC, out float MEBBHHKGNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x43AB0A0", Offset = "0x43A98A0", VA = "0x1843AB0A0")]
	public static void MEMKKOKEJDD(Vector3 DEMNMIOKCLM, MPPPLMNJJKK LGPBAPFGDGE, out Vector3 OHCLPBLHIEC, out float MEBBHHKGNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x43AAD10", Offset = "0x43A9510", VA = "0x1843AAD10")]
	[CCBCLBBLEBF(APPEKHCMHHD.ExitingPlayMode, 0)]
	private static void EGPKCLAOBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x43AAB10", Offset = "0x43A9310", VA = "0x1843AAB10")]
	[CCBCLBBLEBF(APPEKHCMHHD.ExitingPlayMode, 0)]
	private static void DHPHAODDDCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NPPOMMPHFAO
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool LGPPMBJJAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material JMJHIMJAMKF();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material FECBCBBFMGG();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material ECCLHNOPFGI();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IPBDMPNIMLJ(GIMGKACPMAM DHILNFFHCIG);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ENINDEFMIJD(KBDKMDGOCDF DOAPHFGKDOJ);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LGLFCJIGKKG(GameObject ANEGDOBGOJI);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PLAHEHFHGAA(GameObject ANEGDOBGOJI, bool IKAHCNNKAEE);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IECDIHFNFJE : KCHGOMCAHNO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static NPPOMMPHFAO OEMPLOJNNCE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x43A8B40", Offset = "0x43A7340", VA = "0x1843A8B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x43A8B80", Offset = "0x43A7380", VA = "0x1843A8B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x43A90B0", Offset = "0x43A78B0", VA = "0x1843A90B0")]
	public IECDIHFNFJE(NPPOMMPHFAO JHNNILPHNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x43A8810", Offset = "0x43A7010", VA = "0x1843A8810", Slot = "4")]
	public DLDLAOFHMHI FCKCILLHJNL(OIMOBAIHPFL MBGHNFHMMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x43A8940", Offset = "0x43A7140", VA = "0x1843A8940", Slot = "5")]
	public void IEIEBBAAFON(DLDLAOFHMHI LHEBAIHADCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x43A8A50", Offset = "0x43A7250", VA = "0x1843A8A50", Slot = "6")]
	public void JCKOOJJPOEN(DLDLAOFHMHI LHEBAIHADCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x43A8780", Offset = "0x43A6F80", VA = "0x1843A8780", Slot = "15")]
	public IEnumerable<Renderer> EOCGMKFCJIL(DLDLAOFHMHI LHEBAIHADCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x43A89A0", Offset = "0x43A71A0", VA = "0x1843A89A0", Slot = "7")]
	public IIIGOAPHPEH IJBJHEGFOIL(DLDLAOFHMHI LHEBAIHADCN, JNEMIBJEBPC MBGHNFHMMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x43A9000", Offset = "0x43A7800", VA = "0x1843A9000", Slot = "8")]
	public IIIGOAPHPEH POECNDAJCKH(DLDLAOFHMHI LHEBAIHADCN, EGCGDGPGCHE MBGHNFHMMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x43A86F0", Offset = "0x43A6EF0", VA = "0x1843A86F0", Slot = "9")]
	public void BCFIFDDIILC(IIIGOAPHPEH AHDAOMFLKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x43A88F0", Offset = "0x43A70F0", VA = "0x1843A88F0", Slot = "10")]
	public void GGOFODKOMCC(IIIGOAPHPEH AHDAOMFLKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x43A8A90", Offset = "0x43A7290", VA = "0x1843A8A90", Slot = "11")]
	public IBKDAPIDLLH JJGJIMOBKFK(PGOGCOKEKOM MBGHNFHMMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x43A8FC0", Offset = "0x43A77C0", VA = "0x1843A8FC0", Slot = "12")]
	public void ONGKPMLIJAI(IBKDAPIDLLH GLIPHCENJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x43A88B0", Offset = "0x43A70B0", VA = "0x1843A88B0", Slot = "13")]
	public void GAFNCFGCIKJ(IBKDAPIDLLH GLIPHCENJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x43A8BC0", Offset = "0x43A73C0", VA = "0x1843A8BC0", Slot = "14")]
	public BBALKBLIGPE NPAIGBILAJK(Transform OJMHDKHMEMA, IEnumerable<IIIGOAPHPEH> OGEFHPCGKNG, int APJCINPMAHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BPBAAGIBAOM : IBKDAPIDLLH, EHEFPKMLOKN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NMDPGJBFMIA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public BPBAAGIBAOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7748B0", Offset = "0x7730B0", VA = "0x1807748B0")]
		[DebuggerHidden]
		public NMDPGJBFMIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x43AA120", Offset = "0x43A8920", VA = "0x1843AA120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x43A9E50", Offset = "0x43A8650", VA = "0x1843A9E50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x43AA1C0", Offset = "0x43A89C0", VA = "0x1843AA1C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x43AA0D0", Offset = "0x43A88D0", VA = "0x1843AA0D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x43AA030", Offset = "0x43A8830", VA = "0x1843AA030", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x43AA030", Offset = "0x43A8830", VA = "0x1843AA030", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private PGOGCOKEKOM DHJFIPBAMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private KGLKLGNKAAC HOODAJBJPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private List<GPHAKJEKCOA> APHEFGBLNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private List<GPHAKJEKCOA> NIJCNAKHJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private GameObject EFPDPGBFFCE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	internal override BPBAAGIBAOM DPHDCPJACCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F50", Offset = "0x5A4750", VA = "0x1805A5F50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x43A4AF0", Offset = "0x43A32F0", VA = "0x1843A4AF0")]
	public static BPBAAGIBAOM NHEALNMJMEI(PGOGCOKEKOM MBGHNFHMMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x43A54D0", Offset = "0x43A3CD0", VA = "0x1843A54D0")]
	private BPBAAGIBAOM(PGOGCOKEKOM MBGHNFHMMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x43A44D0", Offset = "0x43A2CD0", VA = "0x1843A44D0")]
	public void ADDJJGOGOME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x43A5460", Offset = "0x43A3C60", VA = "0x1843A5460")]
	[IteratorStateMachine(typeof(NMDPGJBFMIA))]
	public IEnumerable<Renderer> OGFNCEGLHIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x43A4BA0", Offset = "0x43A33A0", VA = "0x1843A4BA0", Slot = "5")]
	public void NKPAIFAJIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x43A4AC0", Offset = "0x43A32C0", VA = "0x1843A4AC0")]
	private void LIOAPKGDAEB(Vector3 KHMLMJNGEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x43A48F0", Offset = "0x43A30F0", VA = "0x1843A48F0")]
	public void GEBMKMPLJAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GPHAKJEKCOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct HHNHGGEIPAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public PMMHIBIOLKN DEBJEIHJHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Transform KJGNNHLDENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int GGJOLEECCEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KNKFDNEACNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public GPHAKJEKCOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public NEMIOKPMGJC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public List<HHNHGGEIPAK> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public KNKFDNEACNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class LCKKHCGBCHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public BBALKBLIGPE combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public KNKFDNEACNP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public LCKKHCGBCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x43A9B90", Offset = "0x43A8390", VA = "0x1843A9B90")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x43A9C00", Offset = "0x43A8400", VA = "0x1843A9C00")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x43A9C40", Offset = "0x43A8440", VA = "0x1843A9C40")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int[] ILHKEFJGPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private CMLHLHBIEME DOPGOEMCENE;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static Matrix4x4 CBHJHNJKMLM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Mesh LOJJJEPAAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4D7850", Offset = "0x4D6050", VA = "0x1804D7850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int GGJKALMIIJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5907C0", Offset = "0x58EFC0", VA = "0x1805907C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x590780", Offset = "0x58EF80", VA = "0x180590780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x43A5C90", Offset = "0x43A4490", VA = "0x1843A5C90")]
	public void FKFDOECAELM(List<Transform> NKDKCPPAPJE, Matrix4x4[] GHJJDIKCPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x43A6210", Offset = "0x43A4A10", VA = "0x1843A6210")]
	public static List<GPHAKJEKCOA> MJCPAEDCHAE(List<NGKFDMLOMOO> KCNDEMGDCBF, NEMIOKPMGJC LGLCJGAGAEP, Bounds NEHFEFOGHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x43A5E90", Offset = "0x43A4690", VA = "0x1843A5E90")]
	private JobHandle LKBOHDPGIKI(BBALKBLIGPE CKCABGGDAKI, int LEOJEPPGEAJ, int NELLGOHPCCK, NEMIOKPMGJC LGLCJGAGAEP, List<HHNHGGEIPAK> AJFCBMFAGFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x43A6780", Offset = "0x43A4F80", VA = "0x1843A6780")]
	private void OBCKGGCBGHD(List<HHNHGGEIPAK> AJFCBMFAGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x43A69B0", Offset = "0x43A51B0", VA = "0x1843A69B0")]
	private GPHAKJEKCOA(List<HHNHGGEIPAK> AJFCBMFAGFE, int LEOJEPPGEAJ, int NELLGOHPCCK, NEMIOKPMGJC LGLCJGAGAEP, Bounds NEHFEFOGHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x43A5C10", Offset = "0x43A4410", VA = "0x1843A5C10", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private MaterialPropertyBlock EDBAPJCLOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private GPHAKJEKCOA IFPHMJDNGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<Transform> BPLJFKPNKBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private RenderTexture JMOPGJFFAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private ComputeBuffer BNDHDBPIKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private ComputeShader CELKEOHDMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private Matrix4x4[] EOMOAHDLOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int KAOFDAPDLFJ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MeshRenderer EBACAEKFPCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4D7820", Offset = "0x4D6020", VA = "0x1804D7820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int MKAKIMLKJIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x43AD6A0", Offset = "0x43ABEA0", VA = "0x1843AD6A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x43ACBA0", Offset = "0x43AB3A0", VA = "0x1843ACBA0")]
		public static List<SkinnedShapeRenderer> Create(GameObject LHEBAIHADCN, List<GPHAKJEKCOA> ENDFMMIKMHN, List<Transform> BPLJFKPNKBJ, Material ELNAGKLKGPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x43AD100", Offset = "0x43AB900", VA = "0x1843AD100")]
		public void Init(GPHAKJEKCOA IFPHMJDNGCM, List<Transform> BPLJFKPNKBJ, Material ELNAGKLKGPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x43AD610", Offset = "0x43ABE10", VA = "0x1843AD610")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x43AD580", Offset = "0x43ABD80", VA = "0x1843AD580")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x43AD540", Offset = "0x43ABD40", VA = "0x1843AD540")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x43AD4B0", Offset = "0x43ABCB0", VA = "0x1843AD4B0")]
		private void LEFEPEFKPOF(ScriptableRenderContext PFCNEODPHJH, Camera[] CBAGIPEFOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x43ACDB0", Offset = "0x43AB5B0", VA = "0x1843ACDB0")]
		private void FKFDOECAELM(CommandBuffer KEDHLIENCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5083B0", Offset = "0x506BB0", VA = "0x1805083B0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NNEGPLICMMD
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static byte[] JIMKOONODID;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static int NMMFCBLNDCI;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static int PHIEOBCOOJB;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static BigInteger DPMJLFEPCLI;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	public NNEGPLICMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x43AA200", Offset = "0x43A8A00", VA = "0x1843AA200")]
	private static string CFIIEEFNNDM(byte[] DALEFJAMHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x43AA300", Offset = "0x43A8B00", VA = "0x1843AA300")]
	public static string DHILBOIALCB(byte[] EGBGAEKCIGK, bool DAJGEBLMHFN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
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
