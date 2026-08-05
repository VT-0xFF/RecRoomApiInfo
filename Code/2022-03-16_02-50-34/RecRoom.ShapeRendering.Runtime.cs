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
public enum DOJDHPJHGEJ
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
public enum MGKGLFOKONI
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
public enum CMJBCPAPJBB
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
public enum GHKBJLBKGBP
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
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	HoverXRay
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum AFOAODMJEJA
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HFMFBEEEPPN : PANDFKHDBNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private const byte PHJHMKONIAC = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private byte KIBFGHJCPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly List<SkinnedShapeRenderer>[] GAABCFJPBGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CCDMHKODFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x51CCD0", Offset = "0x51BAD0", VA = "0x18051CCD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x59DA10", Offset = "0x59C810", VA = "0x18059DA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AOALIBCBCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x51CCC0", Offset = "0x51BAC0", VA = "0x18051CCC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x676E70", Offset = "0x675C70", VA = "0x180676E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float EIFCNEDFOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEFB970", Offset = "0xEFA770", VA = "0x180EFB970", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xEFB160", Offset = "0xEF9F60", VA = "0x180EFB160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float MJOJCJFJMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xEFBE00", Offset = "0xEFAC00", VA = "0x180EFBE00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEFBE10", Offset = "0xEFAC10", VA = "0x180EFBE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> LOKKOOEOOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x49F2240", Offset = "0x49F1040", VA = "0x1849F2240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject GGOGHAHJCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x544A30", Offset = "0x543830", VA = "0x180544A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x654540", Offset = "0x653340", VA = "0x180654540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte CHNBPMDIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x49F2160", Offset = "0x49F0F60", VA = "0x1849F2160", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x49F2640", Offset = "0x49F1440", VA = "0x1849F2640")]
	public HFMFBEEEPPN(List<OANDDPLOPMA> MMMHMGBMHEP, List<OANDDPLOPMA> KEJCIGACMIL, List<Transform> OHBAKAIPCLD, Material MGDMNKEFDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x49F2530", Offset = "0x49F1330", VA = "0x1849F2530")]
	private int OOEELGAOHNI(List<OANDDPLOPMA> JCOJBMFBNCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x49F23D0", Offset = "0x49F11D0", VA = "0x1849F23D0")]
	private void MJNIJEKCJCN(int BKMPLOBAGJP, bool CCFKCILEEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x49F22A0", Offset = "0x49F10A0", VA = "0x1849F22A0")]
	public void LFIMGBNHEGD(Vector3 DBJODHEDEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x49F21B0", Offset = "0x49F0FB0", VA = "0x1849F21B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x49F2390", Offset = "0x49F1190", VA = "0x1849F2390")]
	public void LLNCCFOBDMD(Transform AAJKLOGCDKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AJGMAGHOAIJ : CLDOBCIEEBM, KAKMCHOBLLC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BDGEELFCDNF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AJGMAGHOAIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62D3E0", Offset = "0x62C1E0", VA = "0x18062D3E0")]
		[DebuggerHidden]
		public BDGEELFCDNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x49F05D0", Offset = "0x49EF3D0", VA = "0x1849F05D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x49F0120", Offset = "0x49EEF20", VA = "0x1849F0120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x49F0750", Offset = "0x49EF550", VA = "0x1849F0750")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x49F0790", Offset = "0x49EF590", VA = "0x1849F0790")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x49F07E0", Offset = "0x49EF5E0", VA = "0x1849F07E0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x49F0580", Offset = "0x49EF380", VA = "0x1849F0580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x49F04E0", Offset = "0x49EF2E0", VA = "0x1849F04E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x49F04E0", Offset = "0x49EF2E0", VA = "0x1849F04E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private JKKPIPIEPGA HAFNGGKNKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private List<GKKDHBENBGC> JKGIHMHMKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private List<ClusterMeshRenderer> PCLILAOFDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private BatchedMeshRenderer PDABPMLCOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool LEDLPPFKBAG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<PKNECAEPMKC> CDEBPFMFFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int KMHHPCKAOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x49F0050", Offset = "0x49EEE50", VA = "0x1849F0050", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform HJNBLGPDMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x49EFEA0", Offset = "0x49EECA0", VA = "0x1849EFEA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x49F0090", Offset = "0x49EEE90", VA = "0x1849F0090")]
	public AJGMAGHOAIJ(JKKPIPIEPGA EJHODAMHLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x49EFB00", Offset = "0x49EE900", VA = "0x1849EFB00", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x49EFF80", Offset = "0x49EED80", VA = "0x1849EFF80")]
	public void PEIDOEKHNGH(GKKDHBENBGC DDDHCMGDCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x49EFB30", Offset = "0x49EE930", VA = "0x1849EFB30")]
	public void FKDIFICKHIH(GKKDHBENBGC DDDHCMGDCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x49EF0D0", Offset = "0x49EDED0", VA = "0x1849EF0D0", Slot = "4")]
	public void AJJHHDDMEAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x49EFEF0", Offset = "0x49EECF0", VA = "0x1849EFEF0")]
	public void OLEACKIIGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x49EFBA0", Offset = "0x49EE9A0", VA = "0x1849EFBA0")]
	private void GPNBDIFNAJH(GKKDHBENBGC DDDHCMGDCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x49EF620", Offset = "0x49EE420", VA = "0x1849EF620")]
	public void CMEFPDOEJGA(bool CDPGFDHICCG, bool NCAOMDEKJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x49EFCF0", Offset = "0x49EEAF0", VA = "0x1849EFCF0")]
	protected void HHGHELJHNOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x49EFE30", Offset = "0x49EEC30", VA = "0x1849EFE30")]
	[IteratorStateMachine(typeof(BDGEELFCDNF))]
	public IEnumerable<Renderer> JNEOABLMGNG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class HLFCCNFANJH : GKKDHBENBGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private PLHIEMNHFFL EALEDLPBLLF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x49F3850", Offset = "0x49F2650", VA = "0x1849F3850")]
	private NativeList<AHHFIJICLCE> GKGENNEPJGC()
	{
		return default(NativeList<AHHFIJICLCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49F4290", Offset = "0x49F3090", VA = "0x1849F4290")]
	public HLFCCNFANJH(AJGMAGHOAIJ FBADHAKMLIA, PLHIEMNHFFL EJHODAMHLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49F4070", Offset = "0x49F2E70", VA = "0x1849F4070", Slot = "13")]
	public override int OOEELGAOHNI(NAMEMILJEON KDJHNALPMDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49F3E50", Offset = "0x49F2C50", VA = "0x1849F3E50", Slot = "14")]
	public override int MMKBOCMLBNK(NAMEMILJEON KDJHNALPMDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49F3920", Offset = "0x49F2720", VA = "0x1849F3920", Slot = "15")]
	public override void KCCACPKKHMF(NAMEMILJEON KDJHNALPMDH, JPLPDGOBJNE CCEMHDFCGEF, int NJIEEEGMLCA = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MNIBBOAKCGI : global::AIEEHLPHPGE<MNIBBOAKCGI>, GNIMDDFELAE, IEquatable<MNIBBOAKCGI>
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FOJANJPFBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2B0", Offset = "0x7DE0B0", VA = "0x1807DF2B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x877BF0", Offset = "0x8769F0", VA = "0x180877BF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CMHPHALLLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7DF290", Offset = "0x7DE090", VA = "0x1807DF290", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8514A0", Offset = "0x8502A0", VA = "0x1808514A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF190", Offset = "0x3BFDF90", VA = "0x183BFF190", Slot = "8")]
	public bool Equals(MNIBBOAKCGI NDGDPPHIMJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x49F8260", Offset = "0x49F7060", VA = "0x1849F8260")]
	public static bool POHLMDNMDAL(MNIBBOAKCGI BGMPHLJIJDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum COELOFFDNPK
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JKKPIPIEPGA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform OKHJFOKGBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	COELOFFDNPK JHJEFBANCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct MNIKGOIJAID : global::AIEEHLPHPGE<MNIKGOIJAID>, GNIMDDFELAE, IEquatable<MNIKGOIJAID>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FOJANJPFBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2B0", Offset = "0x7DE0B0", VA = "0x1807DF2B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x877BF0", Offset = "0x8769F0", VA = "0x180877BF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CMHPHALLLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF290", Offset = "0x7DE090", VA = "0x1807DF290", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8514A0", Offset = "0x8502A0", VA = "0x1808514A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF190", Offset = "0x3BFDF90", VA = "0x183BFF190", Slot = "8")]
	public bool Equals(MNIKGOIJAID NDGDPPHIMJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x49F82A0", Offset = "0x49F70A0", VA = "0x1849F82A0")]
	public static bool POHLMDNMDAL(MNIKGOIJAID BGMPHLJIJDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FJMDBEFJFLI
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform OKHJFOKGBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float JJBLGLFDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Vector3 OHNHJBJDILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DOJDHPJHGEJ FKIGFCINDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MGKGLFOKONI GGGHEPJHHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JBLLNPCAECC : FJMDBEFJFLI
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KCBOMJLAIDC DEPAEOCLINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NBCFGHGCODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PLHIEMNHFFL : FJMDBEFJFLI
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PHJNEPPINAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JCOLIGEHPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float NACAJGDECLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int HNMMCJBPCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool EIICIPPOHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<AHHFIJICLCE> GKGENNEPJGC();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KNLHAEPGOBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHHCNIOMOJN(MNIKGOIJAID DDDHCMGDCIK, GHKBJLBKGBP PPDLPBGHOIG);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHHCNIOMOJN(MNIBBOAKCGI FBADHAKMLIA, GHKBJLBKGBP PPDLPBGHOIG);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKGICJJCGEM(MNIBBOAKCGI FBADHAKMLIA);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKGICJJCGEM(MNIKGOIJAID DDDHCMGDCIK);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOGBGKAHBHO(MNIBBOAKCGI FBADHAKMLIA, AFOAODMJEJA IDPNMFPNBCP);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPGMPEANEKF(MNIBBOAKCGI FBADHAKMLIA, Vector3 CHEGBIPHBOJ, Vector3 OCGKNJJMGCN, Vector3 GNGBHOAHJGL, float GMPIBGHEALI, float PCPIBANLCHF, IReadOnlyList<Camera> BCOKMMKLCGJ, CMJBCPAPJBB IDMBOAKLCHL);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BPGMPEANEKF(KDPNDGDNKAN NJOEBIHCDLG, Vector3 CHEGBIPHBOJ, Vector3 OCGKNJJMGCN, Vector3 GNGBHOAHJGL, float GMPIBGHEALI, float PCPIBANLCHF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OKADEGLHHNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNIBBOAKCGI AAOHPHCBCFG(JKKPIPIEPGA EJHODAMHLKL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEPOBADOFNB(MNIBBOAKCGI FBADHAKMLIA);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GCJHENEIHFN(MNIBBOAKCGI FBADHAKMLIA);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MNIKGOIJAID OJPGIHCGMKE(MNIBBOAKCGI FBADHAKMLIA, JBLLNPCAECC EJHODAMHLKL);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MNIKGOIJAID MICPCDFMFCO(MNIBBOAKCGI FBADHAKMLIA, PLHIEMNHFFL EJHODAMHLKL);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JECPCNCJEHE(MNIKGOIJAID DDDHCMGDCIK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GNMKGHKKADF(MNIKGOIJAID DDDHCMGDCIK);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KDPNDGDNKAN OMAPNNEANCB(LENKBFHBHKH EJHODAMHLKL);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PABELDKBDKJ(KDPNDGDNKAN NJOEBIHCDLG);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JCBOJNAIEFO(KDPNDGDNKAN NJOEBIHCDLG);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DEBDNLBMIJH JOBJGHPIEBC(Transform AFKFBFKKEHJ, IEnumerable<MNIKGOIJAID> JKGIHMHMKHC, int PHHEKCDGOBL);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> EFOEIKJDKPH(MNIBBOAKCGI FBADHAKMLIA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KDPNDGDNKAN : global::AIEEHLPHPGE<KDPNDGDNKAN>, GNIMDDFELAE, IEquatable<KDPNDGDNKAN>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int FOJANJPFBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2B0", Offset = "0x7DE0B0", VA = "0x1807DF2B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x877BF0", Offset = "0x8769F0", VA = "0x180877BF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int CMHPHALLLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7DF290", Offset = "0x7DE090", VA = "0x1807DF290", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8514A0", Offset = "0x8502A0", VA = "0x1808514A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF190", Offset = "0x3BFDF90", VA = "0x183BFF190", Slot = "8")]
	public bool Equals(KDPNDGDNKAN NDGDPPHIMJG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x49F5950", Offset = "0x49F4750", VA = "0x1849F5950")]
	public static bool POHLMDNMDAL(KDPNDGDNKAN BGMPHLJIJDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LENKBFHBHKH
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int CGFMFOENIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform CEALMKECLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HKHBAKLPNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MNIBBOAKCGI GetBone(int KHNNLHNFBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int KHNNLHNFBNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class HNPBHICFIJI : GKKDHBENBGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public JBLLNPCAECC KOGCIECKHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int[] KBOFABGCPHP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public override ILHGJLIBIMO FBAFGPDDNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x49F44A0", Offset = "0x49F32A0", VA = "0x1849F44A0", Slot = "12")]
		get
		{
			return default(ILHGJLIBIMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Vector3 IJGBPMMMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x49F4EF0", Offset = "0x49F3CF0", VA = "0x1849F4EF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x49F4290", Offset = "0x49F3090", VA = "0x1849F4290")]
	public HNPBHICFIJI(AJGMAGHOAIJ FBADHAKMLIA, JBLLNPCAECC EJHODAMHLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x49F5210", Offset = "0x49F4010", VA = "0x1849F5210", Slot = "11")]
	public override bool PAOLNLJFAAD(Transform FBADHAKMLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x49F5170", Offset = "0x49F3F70", VA = "0x1849F5170", Slot = "13")]
	public override int OOEELGAOHNI(NAMEMILJEON KDJHNALPMDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x49F50D0", Offset = "0x49F3ED0", VA = "0x1849F50D0", Slot = "14")]
	public override int MMKBOCMLBNK(NAMEMILJEON KDJHNALPMDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x49F5710", Offset = "0x49F4510", VA = "0x1849F5710")]
	private int PCPJCGFJLKM(NAMEMILJEON KDJHNALPMDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x49F4840", Offset = "0x49F3640", VA = "0x1849F4840", Slot = "15")]
	public override void KCCACPKKHMF(NAMEMILJEON KDJHNALPMDH, JPLPDGOBJNE CCEMHDFCGEF, int NJIEEEGMLCA = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ELJMFBJDAPG
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBJPELOIENJ(AFOAODMJEJA IDPNMFPNBCP, Renderer KNMKPEIBPGN, int GEJMJODEHGO);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBMABIMDOKP(Renderer KNMKPEIBPGN, CMJBCPAPJBB IDMBOAKLCHL, Vector3 CHEGBIPHBOJ, Vector3 OCGKNJJMGCN, Vector3 GNGBHOAHJGL, float GMPIBGHEALI, float PCPIBANLCHF, float NAAGJCINCHH = -1f, [Optional] Color? BCAEJLJHMOC, [Optional] IReadOnlyList<Camera> IEKJFEEANOL);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEJAIADOPFB(Renderer KNMKPEIBPGN, int GEJMJODEHGO);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KLFCLGAFLMK();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LMELKIAEIHN(int GGBBLAKEOCJ, GHKBJLBKGBP IDPNMFPNBCP, Renderer KNMKPEIBPGN, int GEJMJODEHGO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EDEIJACJDME : KNLHAEPGOBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ELJMFBJDAPG FMHFJBNOBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly LPJLECLOMNE KMBAMHHHBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private MeshRenderer CCLJKEFHKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private PNOMNKOFAPL EMAHLBHIFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private MeshRenderer ICFFKJKJINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private PNOMNKOFAPL CDMPLLFCFNJ;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x52F990", Offset = "0x52E790", VA = "0x18052F990")]
	public EDEIJACJDME(ELJMFBJDAPG PMMPMOBNHDH, LPJLECLOMNE KMBAMHHHBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x49F1170", Offset = "0x49EFF70", VA = "0x1849F1170", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x49F12C0", Offset = "0x49F00C0", VA = "0x1849F12C0", Slot = "4")]
	public void IHHCNIOMOJN(MNIKGOIJAID DDDHCMGDCIK, GHKBJLBKGBP PPDLPBGHOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x49F1540", Offset = "0x49F0340", VA = "0x1849F1540", Slot = "5")]
	public void IHHCNIOMOJN(MNIBBOAKCGI FBADHAKMLIA, GHKBJLBKGBP PPDLPBGHOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x49F1710", Offset = "0x49F0510", VA = "0x1849F1710", Slot = "6")]
	public void NKGICJJCGEM(MNIBBOAKCGI FBADHAKMLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x49F18B0", Offset = "0x49F06B0", VA = "0x1849F18B0", Slot = "7")]
	public void NKGICJJCGEM(MNIKGOIJAID DDDHCMGDCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x49F1B00", Offset = "0x49F0900", VA = "0x1849F1B00", Slot = "8")]
	public void NOGBGKAHBHO(MNIBBOAKCGI FBADHAKMLIA, AFOAODMJEJA IDPNMFPNBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x49F0A70", Offset = "0x49EF870", VA = "0x1849F0A70", Slot = "9")]
	public void BPGMPEANEKF(MNIBBOAKCGI FBADHAKMLIA, Vector3 CHEGBIPHBOJ, Vector3 OCGKNJJMGCN, Vector3 GNGBHOAHJGL, float GMPIBGHEALI, float PCPIBANLCHF, IReadOnlyList<Camera> BCOKMMKLCGJ, CMJBCPAPJBB IDMBOAKLCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x49F0DA0", Offset = "0x49EFBA0", VA = "0x1849F0DA0", Slot = "10")]
	public void BPGMPEANEKF(KDPNDGDNKAN NJOEBIHCDLG, Vector3 CHEGBIPHBOJ, Vector3 OCGKNJJMGCN, Vector3 GNGBHOAHJGL, float GMPIBGHEALI, float PCPIBANLCHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class GKKDHBENBGC : JNAFBFAIOCJ, PKNECAEPMKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	protected Bounds HHEBBCKJNAH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AJGMAGHOAIJ GGOGHAHJCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x51C490", Offset = "0x51B290", VA = "0x18051C490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Bounds FFBBIOBKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xFFEFA0", Offset = "0xFFDDA0", VA = "0x180FFEFA0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public virtual ILHGJLIBIMO FBAFGPDDNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x49F2060", Offset = "0x49F0E60", VA = "0x1849F2060", Slot = "12")]
		get
		{
			return default(ILHGJLIBIMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x49F20F0", Offset = "0x49F0EF0", VA = "0x1849F20F0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x51CEC0", Offset = "0x51BCC0", VA = "0x18051CEC0", Slot = "11")]
	public virtual bool PAOLNLJFAAD(Transform FBADHAKMLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int OOEELGAOHNI(NAMEMILJEON KDJHNALPMDH);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int MMKBOCMLBNK(NAMEMILJEON KDJHNALPMDH);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void KCCACPKKHMF(NAMEMILJEON KDJHNALPMDH, JPLPDGOBJNE CCEMHDFCGEF, int NJIEEEGMLCA = -1);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	protected GKKDHBENBGC()
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
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x49F9460", Offset = "0x49F8260", VA = "0x1849F9460")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum KCBOMJLAIDC
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HJADDFCNFOL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HLPEOOKGDEA : IEnumerable<MHFLNCAHAFK>, IEnumerable, IEnumerator<MHFLNCAHAFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private MHFLNCAHAFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private MHFLNCAHAFK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x62D3E0", Offset = "0x62C1E0", VA = "0x18062D3E0")]
		[DebuggerHidden]
		public HLPEOOKGDEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x49F42E0", Offset = "0x49F30E0", VA = "0x1849F42E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x49F4450", Offset = "0x49F3250", VA = "0x1849F4450", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x49F43C0", Offset = "0x49F31C0", VA = "0x1849F43C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MHFLNCAHAFK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x49F43C0", Offset = "0x49F31C0", VA = "0x1849F43C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int FJLMCJCIOPO = 3;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static MHFLNCAHAFK[][] GHFIOBHEOKF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static HHJIOOIFHHG MOAAMHFIMBD;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static ShapeRendererConfig ECEMPDCOMCD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static ComputeShader KKOOBMOJJHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x49F2B50", Offset = "0x49F1950", VA = "0x1849F2B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static SkinnedShapeRenderer FPJMLNAJMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x49F2900", Offset = "0x49F1700", VA = "0x1849F2900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x49F2DE0", Offset = "0x49F1BE0", VA = "0x1849F2DE0")]
	public static Mesh HNBKKEMAIMK(KCBOMJLAIDC HLEFKBMINHP, int KDJHNALPMDH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x49F3390", Offset = "0x49F2190", VA = "0x1849F3390")]
	public static int MLBKOIKAKPG(KCBOMJLAIDC HLEFKBMINHP, int KDJHNALPMDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x49F2EA0", Offset = "0x49F1CA0", VA = "0x1849F2EA0")]
	public static HHJIOOIFHHG IEAALIBFONM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x49F2FF0", Offset = "0x49F1DF0", VA = "0x1849F2FF0")]
	[IteratorStateMachine(typeof(HLPEOOKGDEA))]
	private static IEnumerable<MHFLNCAHAFK> IFAKFLLNDGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x49F3050", Offset = "0x49F1E50", VA = "0x1849F3050")]
	public static MHFLNCAHAFK IKGDHJDOMGK(KCBOMJLAIDC HLEFKBMINHP, int KDJHNALPMDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x49F2970", Offset = "0x49F1770", VA = "0x1849F2970")]
	public static bool DCCAEKDFOPJ(this KCBOMJLAIDC HLEFKBMINHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x49F2990", Offset = "0x49F1790", VA = "0x1849F2990")]
	public static void FDNCJCJJHCF(KCBOMJLAIDC HLEFKBMINHP, float3 BOKALEIIBEE, out FEBHLAHEIEJ HNHKBOJHGKH, out float3 HJAILLGHEHP, out float FCOJAFCONDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x49F33A0", Offset = "0x49F21A0", VA = "0x1849F33A0")]
	public static void ONEBNFJFEJN(Vector3 BOKALEIIBEE, KCBOMJLAIDC HLEFKBMINHP, out Vector3 HJAILLGHEHP, out float FCOJAFCONDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x49F37C0", Offset = "0x49F25C0", VA = "0x1849F37C0")]
	[OENDEPLIANP(AJFNGMOAHIK.ExitingPlayMode, 0)]
	private static void PCHHJALBOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x49F2BC0", Offset = "0x49F19C0", VA = "0x1849F2BC0")]
	[OENDEPLIANP(AJFNGMOAHIK.ExitingPlayMode, 0)]
	private static void HFIKIABLNHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface IBJGKNMMMPH
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool MNEPANEODAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material DOODKFHEFLN();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material KKNNDOPHKKC();

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material IAOGGJPMEBE();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MGJMFIIABKG(DOJDHPJHGEJ JDIPANIJJEK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NJGLOPBMHPL(MGKGLFOKONI FHHLOLMFOIK);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MMKBKKLGPCM(GameObject PJNABAALNPP);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EKBJMGBKFGC(GameObject PJNABAALNPP, bool HCACEMAGDHH);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public interface LPJLECLOMNE
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	AJGMAGHOAIJ MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GKKDHBENBGC MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	KMMMGEPDFLP MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class LNALGNKGIGP : OKADEGLHHNC, IDisposable, LPJLECLOMNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly global::DGJKFKFAPMJ<MNIBBOAKCGI, AJGMAGHOAIJ> LPFBODDPEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly global::DGJKFKFAPMJ<MNIKGOIJAID, GKKDHBENBGC> JKGIHMHMKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly global::DGJKFKFAPMJ<KDPNDGDNKAN, KMMMGEPDFLP> JIEPIBNPHGF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static IBJGKNMMMPH JKFKOPHIHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x49F6CF0", Offset = "0x49F5AF0", VA = "0x1849F6CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x49F7460", Offset = "0x49F6260", VA = "0x1849F7460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public AJGMAGHOAIJ MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x49F6DF0", Offset = "0x49F5BF0", VA = "0x1849F6DF0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public GKKDHBENBGC MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x49F6E50", Offset = "0x49F5C50", VA = "0x1849F6E50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KMMMGEPDFLP MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x49F6D90", Offset = "0x49F5B90", VA = "0x1849F6D90", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x49F7800", Offset = "0x49F6600", VA = "0x1849F7800")]
	public LNALGNKGIGP(IBJGKNMMMPH PMMPMOBNHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x49F6BC0", Offset = "0x49F59C0", VA = "0x1849F6BC0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x49F6AE0", Offset = "0x49F58E0", VA = "0x1849F6AE0", Slot = "4")]
	public MNIBBOAKCGI AAOHPHCBCFG(JKKPIPIEPGA EJHODAMHLKL)
	{
		return default(MNIBBOAKCGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x49F6D30", Offset = "0x49F5B30", VA = "0x1849F6D30", Slot = "5")]
	public void FEPOBADOFNB(MNIBBOAKCGI FBADHAKMLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x49F6EB0", Offset = "0x49F5CB0", VA = "0x1849F6EB0", Slot = "6")]
	public void GCJHENEIHFN(MNIBBOAKCGI FBADHAKMLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x49F6C30", Offset = "0x49F5A30", VA = "0x1849F6C30", Slot = "15")]
	public IEnumerable<Renderer> EFOEIKJDKPH(MNIBBOAKCGI FBADHAKMLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x49F75A0", Offset = "0x49F63A0", VA = "0x1849F75A0", Slot = "7")]
	public MNIKGOIJAID OJPGIHCGMKE(MNIBBOAKCGI FBADHAKMLIA, JBLLNPCAECC EJHODAMHLKL)
	{
		return default(MNIKGOIJAID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x49F74B0", Offset = "0x49F62B0", VA = "0x1849F74B0", Slot = "8")]
	public MNIKGOIJAID MICPCDFMFCO(MNIBBOAKCGI FBADHAKMLIA, PLHIEMNHFFL EJHODAMHLKL)
	{
		return default(MNIKGOIJAID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x49F6F20", Offset = "0x49F5D20", VA = "0x1849F6F20", Slot = "10")]
	public void GNMKGHKKADF(MNIKGOIJAID DDDHCMGDCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x49F7000", Offset = "0x49F5E00", VA = "0x1849F7000", Slot = "9")]
	public void JECPCNCJEHE(MNIKGOIJAID DDDHCMGDCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x49F7690", Offset = "0x49F6490", VA = "0x1849F7690", Slot = "11")]
	public KDPNDGDNKAN OMAPNNEANCB(LENKBFHBHKH EJHODAMHLKL)
	{
		return default(KDPNDGDNKAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x49F6F90", Offset = "0x49F5D90", VA = "0x1849F6F90", Slot = "13")]
	public void JCBOJNAIEFO(KDPNDGDNKAN NJOEBIHCDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x49F77A0", Offset = "0x49F65A0", VA = "0x1849F77A0", Slot = "12")]
	public void PABELDKBDKJ(KDPNDGDNKAN NJOEBIHCDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x49F7060", Offset = "0x49F5E60", VA = "0x1849F7060", Slot = "14")]
	public DEBDNLBMIJH JOBJGHPIEBC(Transform AFKFBFKKEHJ, IEnumerable<MNIKGOIJAID> JKGIHMHMKHC, int PHHEKCDGOBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KMMMGEPDFLP : CLDOBCIEEBM
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GIBDCDMJJHO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public KMMMGEPDFLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x62D3E0", Offset = "0x62C1E0", VA = "0x18062D3E0")]
		[DebuggerHidden]
		public GIBDCDMJJHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x49F1F80", Offset = "0x49F0D80", VA = "0x1849F1F80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x49F1CA0", Offset = "0x49F0AA0", VA = "0x1849F1CA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x49F2020", Offset = "0x49F0E20", VA = "0x1849F2020")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x49F1F30", Offset = "0x49F0D30", VA = "0x1849F1F30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x49F1E90", Offset = "0x49F0C90", VA = "0x1849F1E90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x49F1E90", Offset = "0x49F0C90", VA = "0x1849F1E90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly LENKBFHBHKH FAOCDFGKHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly LPJLECLOMNE KMBAMHHHBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private HFMFBEEEPPN OIODINPFHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private List<OANDDPLOPMA> CIFCDNNLADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private List<OANDDPLOPMA> BEEPCIGEMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private GameObject NCFMBFBFBOB;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x49F62E0", Offset = "0x49F50E0", VA = "0x1849F62E0")]
	public static KMMMGEPDFLP FJMPNNDEFOG(LENKBFHBHKH EJHODAMHLKL, LPJLECLOMNE KMBAMHHHBFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x49F6A50", Offset = "0x49F5850", VA = "0x1849F6A50")]
	private KMMMGEPDFLP(LENKBFHBHKH EJHODAMHLKL, LPJLECLOMNE KMBAMHHHBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x49F63C0", Offset = "0x49F51C0", VA = "0x1849F63C0")]
	public void JCPBCAEBHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x49F67E0", Offset = "0x49F55E0", VA = "0x1849F67E0")]
	[IteratorStateMachine(typeof(GIBDCDMJJHO))]
	public IEnumerable<Renderer> JNEOABLMGNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x49F5990", Offset = "0x49F4790", VA = "0x1849F5990", Slot = "4")]
	public void AJJHHDDMEAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x49F6850", Offset = "0x49F5650", VA = "0x1849F6850")]
	private void NBKAJLGACCK(Vector3 DBJODHEDEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x49F6880", Offset = "0x49F5680", VA = "0x1849F6880")]
	public void OLEACKIIGIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OANDDPLOPMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct PLMKPIGMFKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public JPLPDGOBJNE DNABHIGCLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Transform LMLALMHABKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int PPOCLLAFMMG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class COHKDBKJCAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public OANDDPLOPMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public NAMEMILJEON lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<PLMKPIGMFKD> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public COHKDBKJCAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class CHOMDKHNBCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public DEBDNLBMIJH combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public COHKDBKJCAA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public CHOMDKHNBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x49F0830", Offset = "0x49EF630", VA = "0x1849F0830")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x49F08A0", Offset = "0x49EF6A0", VA = "0x1849F08A0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x49F08E0", Offset = "0x49EF6E0", VA = "0x1849F08E0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private int[] FKIKFEFGBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private FFNFNMALHEF NFBEFNENJOO;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static Matrix4x4 DEGNGJBKJPE;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Mesh JAOAFNLHICA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x51C490", Offset = "0x51B290", VA = "0x18051C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int GMIFLDNAFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5A8670", Offset = "0x5A7470", VA = "0x1805A8670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x66E5D0", Offset = "0x66D3D0", VA = "0x18066E5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x49F8460", Offset = "0x49F7260", VA = "0x1849F8460")]
	public void FBHGLFBIKDA(List<Transform> JFPJLKJDMFE, Matrix4x4[] BMGNPOJNAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x49F89E0", Offset = "0x49F77E0", VA = "0x1849F89E0")]
	public static List<OANDDPLOPMA> PEDPEIEILOF(List<KAKMCHOBLLC> KOFJDICCCHB, NAMEMILJEON KDJHNALPMDH, Bounds NNLDFIOPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x49F8660", Offset = "0x49F7460", VA = "0x1849F8660")]
	private JobHandle JPPEECNCEPF(DEBDNLBMIJH PCICLCOIFCK, int FMAAGJMDOEP, int HIHKGALDNFO, NAMEMILJEON KDJHNALPMDH, List<PLMKPIGMFKD> NMILCGNMPAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x49F8360", Offset = "0x49F7160", VA = "0x1849F8360")]
	private void EEMBLECNMNC(List<PLMKPIGMFKD> NMILCGNMPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x49F90B0", Offset = "0x49F7EB0", VA = "0x1849F90B0")]
	private OANDDPLOPMA(List<PLMKPIGMFKD> NMILCGNMPAC, int FMAAGJMDOEP, int HIHKGALDNFO, NAMEMILJEON KDJHNALPMDH, Bounds NNLDFIOPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x49F82E0", Offset = "0x49F70E0", VA = "0x1849F82E0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private MaterialPropertyBlock NCFNNIOALJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private OANDDPLOPMA JJINPOBHIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private List<Transform> OHBAKAIPCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private RenderTexture ELNILPOKLPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private ComputeBuffer GEBNGHLLIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private ComputeShader CLADMKOPBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private Matrix4x4[] GKFEFJKDOPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int NLIIFNGAGHN;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public MeshRenderer NDHPGDOGHIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x51C4A0", Offset = "0x51B2A0", VA = "0x18051C4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int CGFMFOENIJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x49FA000", Offset = "0x49F8E00", VA = "0x1849FA000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x49F9520", Offset = "0x49F8320", VA = "0x1849F9520")]
		public static List<SkinnedShapeRenderer> Create(GameObject FBADHAKMLIA, List<OANDDPLOPMA> JCOJBMFBNCA, List<Transform> OHBAKAIPCLD, Material MGDMNKEFDHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x49F9A80", Offset = "0x49F8880", VA = "0x1849F9A80")]
		public void Init(OANDDPLOPMA JJINPOBHIAK, List<Transform> OHBAKAIPCLD, Material MGDMNKEFDHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x49F9F70", Offset = "0x49F8D70", VA = "0x1849F9F70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x49F9EE0", Offset = "0x49F8CE0", VA = "0x1849F9EE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x49F9EA0", Offset = "0x49F8CA0", VA = "0x1849F9EA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x49F9490", Offset = "0x49F8290", VA = "0x1849F9490")]
		private void BPBPBGDLDDJ(ScriptableRenderContext BKOJMLFMNLI, Camera[] JCHKEAAJACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x49F9730", Offset = "0x49F8530", VA = "0x1849F9730")]
		private void FBHGLFBIKDA(CommandBuffer GCJKJGLALMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xD85B10", Offset = "0xD84910", VA = "0x180D85B10")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MLACDHJHDFG
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static byte[] PCFDJLIAIEK;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static int CNEHBAAIPJM;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int NEIKIABHABD;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static BigInteger NOAFCEFHHAN;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public MLACDHJHDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x49F7C70", Offset = "0x49F6A70", VA = "0x1849F7C70")]
	private static string JLOFJIHEBDA(byte[] KBBKPHEOPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x49F7D70", Offset = "0x49F6B70", VA = "0x1849F7D70")]
	public static string NCFNLEDFEPP(byte[] NBHAFAAIDII, bool IGLBINIMLIE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
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
