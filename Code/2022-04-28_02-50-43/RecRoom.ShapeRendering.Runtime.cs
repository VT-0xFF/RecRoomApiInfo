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
public enum JCKGONBFBHM
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
public static class CLFNLNGFAJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<JCKGONBFBHM> OAACEKFFDJF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4B1FB20", Offset = "0x4B1ED20", VA = "0x184B1FB20")]
	static CLFNLNGFAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B1FB20", Offset = "0x4B1ED20", VA = "0x184B1FB20")]
	[DNILEMOABIK]
	private static void DMAPEOFMGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B1FAA0", Offset = "0x4B1ECA0", VA = "0x184B1FAA0")]
	public static bool BFEIMDBGADE(this JCKGONBFBHM HAFJDIKHDEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IAOAHFCENOL
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
public enum IMBOAMAMOGC
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
public enum IFCKNKGGBKE
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
public enum KCBBHPHCOPD
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
public class LGECCIJBCID : BJCNNAGCAHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private const byte EJINOCLPHJL = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private byte HEEPBGBEHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly List<SkinnedShapeRenderer>[] EELLCEKLGIG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HACLCIANAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x527CD0", Offset = "0x526ED0", VA = "0x180527CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5A8A10", Offset = "0x5A7C10", VA = "0x1805A8A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NAIDDOIOBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x527CC0", Offset = "0x526EC0", VA = "0x180527CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AE590", Offset = "0x6AD790", VA = "0x1806AE590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float MJENIDJHANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD883A0", Offset = "0xD875A0", VA = "0x180D883A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD88470", Offset = "0xD87670", VA = "0x180D88470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float LGAIOFJMKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD887D0", Offset = "0xD879D0", VA = "0x180D887D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD88450", Offset = "0xD87650", VA = "0x180D88450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> OHOMFDKMODL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B21210", Offset = "0x4B20410", VA = "0x184B21210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> MMKBHCBFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E1F710", Offset = "0x3E1E910", VA = "0x183E1F710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject AJOEJMPPIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x54FA30", Offset = "0x54EC30", VA = "0x18054FA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66B3A0", Offset = "0x66A5A0", VA = "0x18066B3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte PIOJIEJLHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4B21020", Offset = "0x4B20220", VA = "0x184B21020", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B21500", Offset = "0x4B20700", VA = "0x184B21500")]
	public LGECCIJBCID(List<NDKPDKCCJFC> AGFIBPOLMBI, List<NDKPDKCCJFC> AGEHMGEAHMH, List<Transform> NBMIJPENBEH, Material NAEPHFLMGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B21100", Offset = "0x4B20300", VA = "0x184B21100")]
	private int GJMJDEGLGPE(List<NDKPDKCCJFC> KILMGNBHKML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4B213A0", Offset = "0x4B205A0", VA = "0x184B213A0")]
	private void NLPEEMPKOFD(int KGJDLCHAALC, bool AIKMGIHJJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B212B0", Offset = "0x4B204B0", VA = "0x184B212B0")]
	public void KGBOHCNKDHP(Vector3 CLNGALLIAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B21070", Offset = "0x4B20270", VA = "0x184B21070", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B21270", Offset = "0x4B20470", VA = "0x184B21270")]
	public void IHOBLLMPNBL(Transform ENBJABFPGEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NMDEAOOCEFC : DGHPDDKFODH, EEGAMDAFMGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FAIDCKODIEL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public NMDEAOOCEFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6383E0", Offset = "0x6375E0", VA = "0x1806383E0")]
		[DebuggerHidden]
		public FAIDCKODIEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4B200F0", Offset = "0x4B1F2F0", VA = "0x184B200F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4B1FC40", Offset = "0x4B1EE40", VA = "0x184B1FC40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4B20270", Offset = "0x4B1F470", VA = "0x184B20270")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4B202B0", Offset = "0x4B1F4B0", VA = "0x184B202B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4B20300", Offset = "0x4B1F500", VA = "0x184B20300")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4B200A0", Offset = "0x4B1F2A0", VA = "0x184B200A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4B20000", Offset = "0x4B1F200", VA = "0x184B20000", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4B20000", Offset = "0x4B1F200", VA = "0x184B20000", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ACANAAKIAHF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NMDEAOOCEFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6383E0", Offset = "0x6375E0", VA = "0x1806383E0")]
		[DebuggerHidden]
		public ACANAAKIAHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4B1E5A0", Offset = "0x4B1D7A0", VA = "0x184B1E5A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4B1E200", Offset = "0x4B1D400", VA = "0x184B1E200", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4B1E6C0", Offset = "0x4B1D8C0", VA = "0x184B1E6C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4B1E710", Offset = "0x4B1D910", VA = "0x184B1E710")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4B1E550", Offset = "0x4B1D750", VA = "0x184B1E550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4B1E4B0", Offset = "0x4B1D6B0", VA = "0x184B1E4B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4B1E4B0", Offset = "0x4B1D6B0", VA = "0x184B1E4B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private EELCKLGPLIL LDMHLMDFNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private List<NHKLJCOFAEL> ILPMLAJLAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<ClusterMeshRenderer> DDLJPDMOOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private BatchedMeshRenderer PKMPIPLAFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool DGMAHKDANML;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<DOHHFHAJLJD> OEDLKGLNACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BLOGJMILHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4B25B60", Offset = "0x4B24D60", VA = "0x184B25B60", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform AFBOFNFLIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4B25DF0", Offset = "0x4B24FF0", VA = "0x184B25DF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PMOBJGGDCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x528010", Offset = "0x527210", VA = "0x180528010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x528020", Offset = "0x527220", VA = "0x180528020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4B26160", Offset = "0x4B25360", VA = "0x184B26160")]
	public NMDEAOOCEFC(EELCKLGPLIL EHJEONLOBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B25BA0", Offset = "0x4B24DA0", VA = "0x184B25BA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B25F40", Offset = "0x4B25140", VA = "0x184B25F40")]
	public void JPGLGPDLMNH(NHKLJCOFAEL OMCEMBJPIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4B25D10", Offset = "0x4B24F10", VA = "0x184B25D10")]
	public void FPHPJLPLMOJ(NHKLJCOFAEL OMCEMBJPIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4B25610", Offset = "0x4B24810", VA = "0x184B25610", Slot = "4")]
	public void CPNCDFLBMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4B25EB0", Offset = "0x4B250B0", VA = "0x184B25EB0")]
	public void IGIHOBELMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4B26010", Offset = "0x4B25210", VA = "0x184B26010")]
	private void LOJHEOLBFCK(NHKLJCOFAEL OMCEMBJPIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4B25130", Offset = "0x4B24330", VA = "0x184B25130")]
	public void AMGIBINCCGE(bool JOIAAJONEGA, bool LCMEBMPEKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B25BD0", Offset = "0x4B24DD0", VA = "0x184B25BD0")]
	protected void ENGHHAHIEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4B25D80", Offset = "0x4B24F80", VA = "0x184B25D80")]
	[IteratorStateMachine(typeof(FAIDCKODIEL))]
	public IEnumerable<Renderer> GMJGNNPKGLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4B25E40", Offset = "0x4B25040", VA = "0x184B25E40")]
	[IteratorStateMachine(typeof(ACANAAKIAHF))]
	public IEnumerable<Renderer> IFMJEKCMJMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class HLNHIABJKBC : NHKLJCOFAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private FAMADJGINIP GCNCGBICGCO;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4B20AA0", Offset = "0x4B1FCA0", VA = "0x184B20AA0")]
	private NativeList<EIENLCBEBLN> PJCILCKDMNN()
	{
		return default(NativeList<EIENLCBEBLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4B20D90", Offset = "0x4B1FF90", VA = "0x184B20D90")]
	public HLNHIABJKBC(NMDEAOOCEFC AOFPBKDCBAI, FAMADJGINIP EHJEONLOBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4B20350", Offset = "0x4B1F550", VA = "0x184B20350", Slot = "13")]
	public override int GJMJDEGLGPE(GCPOJHCCJAJ JNHBFGDICNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4B20B70", Offset = "0x4B1FD70", VA = "0x184B20B70", Slot = "14")]
	public override int PMNJCPPOGOL(GCPOJHCCJAJ JNHBFGDICNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4B20570", Offset = "0x4B1F770", VA = "0x184B20570", Slot = "15")]
	public override void JGLPKMFFHHG(GCPOJHCCJAJ JNHBFGDICNI, BPGGFIADKDC JGGCNLIJCPH, int DEAPKKJJNME = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NPLGJCDIJGI : global::IPFMBECLOKB<NPLGJCDIJGI>, MHCNELDBBJC, IEquatable<NPLGJCDIJGI>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PENJMDLPEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7D34F0", Offset = "0x7D26F0", VA = "0x1807D34F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8834C0", Offset = "0x8826C0", VA = "0x1808834C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OJFIGHCBHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7D34D0", Offset = "0x7D26D0", VA = "0x1807D34D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85CD70", Offset = "0x85BF70", VA = "0x18085CD70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA4A0", Offset = "0x3DF96A0", VA = "0x183DFA4A0", Slot = "8")]
	public bool Equals(NPLGJCDIJGI CDPFMCDBFNL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4B261F0", Offset = "0x4B253F0", VA = "0x184B261F0")]
	public static bool NHACLHBAJHL(NPLGJCDIJGI LHJGJOFJCNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KBELAOAOKCM
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EELCKLGPLIL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform MFECNDGJLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KBELAOAOKCM EMEGHDKGALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PNLLIGBBKBC : global::IPFMBECLOKB<PNLLIGBBKBC>, MHCNELDBBJC, IEquatable<PNLLIGBBKBC>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int PENJMDLPEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D34F0", Offset = "0x7D26F0", VA = "0x1807D34F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8834C0", Offset = "0x8826C0", VA = "0x1808834C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int OJFIGHCBHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7D34D0", Offset = "0x7D26D0", VA = "0x1807D34D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85CD70", Offset = "0x85BF70", VA = "0x18085CD70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA4A0", Offset = "0x3DF96A0", VA = "0x183DFA4A0", Slot = "8")]
	public bool Equals(PNLLIGBBKBC CDPFMCDBFNL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4B28D30", Offset = "0x4B27F30", VA = "0x184B28D30")]
	public static bool NHACLHBAJHL(PNLLIGBBKBC LHJGJOFJCNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CBCMKFJOGHP
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform MFECNDGJLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float APEHCNDDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 KEODCPNKMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	JCKGONBFBHM LJMDAABHBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IAOAHFCENOL GCNAFIJNBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HEKIEDELODG : CBCMKFJOGHP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	AHMFDMCNFJN FABGHGNHJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GBGPFLLBLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FAMADJGINIP : CBCMKFJOGHP
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BHMIFEDHIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JNDKJMFMHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float IAACCFCFGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int ONHPHBJHFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool JDDIANCDEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<EIENLCBEBLN> PJCILCKDMNN();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JIHJCANDDKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLMCJEKKFPM(PNLLIGBBKBC OMCEMBJPIBP, IFCKNKGGBKE HGALJLGLKME);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLMCJEKKFPM(NPLGJCDIJGI AOFPBKDCBAI, IFCKNKGGBKE HGALJLGLKME);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMPNFKHLBHL(NPLGJCDIJGI AOFPBKDCBAI);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMPNFKHLBHL(PNLLIGBBKBC OMCEMBJPIBP);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFDOPKIOPMM(NPLGJCDIJGI AOFPBKDCBAI, KCBBHPHCOPD OMCCJKNHBML);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void COBFGJMEFCJ(NPLGJCDIJGI AOFPBKDCBAI, Vector3 IANAMKKKLCC, Vector3 DLACBLCEEOD, Vector3 JMJHIJGCIIM, float CECADAMMOIE, float GEKPIPLNMCL, IReadOnlyList<Camera> NJDKGJPBLDF, IMBOAMAMOGC JLPNGEPENPN);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void COBFGJMEFCJ(MKEHFOLCNKK MELJNPIHHFA, Vector3 IANAMKKKLCC, Vector3 DLACBLCEEOD, Vector3 JMJHIJGCIIM, float CECADAMMOIE, float GEKPIPLNMCL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DDEFJDPHHID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPLGJCDIJGI CCKJNIOCJLN(EELCKLGPLIL EHJEONLOBCF);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOEKBKDEBNC(NPLGJCDIJGI AOFPBKDCBAI);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCAPEONMDDD(NPLGJCDIJGI AOFPBKDCBAI);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PNLLIGBBKBC ACPKOEPBANB(NPLGJCDIJGI AOFPBKDCBAI, HEKIEDELODG EHJEONLOBCF);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PNLLIGBBKBC PAJHKGDHMFH(NPLGJCDIJGI AOFPBKDCBAI, FAMADJGINIP EHJEONLOBCF);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OICAHPPKIKM(PNLLIGBBKBC OMCEMBJPIBP);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IAMJJBIOIGL(PNLLIGBBKBC OMCEMBJPIBP);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MKEHFOLCNKK GJEOEKAGBOO(JGMEJIEHNCM EHJEONLOBCF);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OIONMLIDLDO(MKEHFOLCNKK MELJNPIHHFA);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DMDJBGFIHBE(MKEHFOLCNKK MELJNPIHHFA);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OGNOIBAIHLG EEOGABFMGJI(Transform OMFFPGNGAKG, IEnumerable<PNLLIGBBKBC> ILPMLAJLAFG, int FDBCMKBBHDO);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> FDJFHEAAEED(NPLGJCDIJGI AOFPBKDCBAI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MKEHFOLCNKK : global::IPFMBECLOKB<MKEHFOLCNKK>, MHCNELDBBJC, IEquatable<MKEHFOLCNKK>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int PENJMDLPEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7D34F0", Offset = "0x7D26F0", VA = "0x1807D34F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8834C0", Offset = "0x8826C0", VA = "0x1808834C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int OJFIGHCBHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D34D0", Offset = "0x7D26D0", VA = "0x1807D34D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x85CD70", Offset = "0x85BF70", VA = "0x18085CD70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA4A0", Offset = "0x3DF96A0", VA = "0x183DFA4A0", Slot = "8")]
	public bool Equals(MKEHFOLCNKK CDPFMCDBFNL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4B229F0", Offset = "0x4B21BF0", VA = "0x184B229F0")]
	public static bool NHACLHBAJHL(MKEHFOLCNKK LHJGJOFJCNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JGMEJIEHNCM
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int FDNKLFHOIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform PBHHMCKOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool PEDJHGLEHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NPLGJCDIJGI GetBone(int IEKMGHJGILG);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int IEKMGHJGILG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class NKCFNEIFJJB : NHKLJCOFAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public HEKIEDELODG FJFGOAOMEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int[] GEFBCBOGDBE;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override HIDEMNMNBKB OHIBILPJFGK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4B23C80", Offset = "0x4B22E80", VA = "0x184B23C80", Slot = "12")]
		get
		{
			return default(HIDEMNMNBKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 HODDONCGMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4B24020", Offset = "0x4B23220", VA = "0x184B24020")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4B20D90", Offset = "0x4B1FF90", VA = "0x184B20D90")]
	public NKCFNEIFJJB(NMDEAOOCEFC AOFPBKDCBAI, HEKIEDELODG EHJEONLOBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4B24950", Offset = "0x4B23B50", VA = "0x184B24950", Slot = "11")]
	public override bool KDMMDNNDBJP(Transform AOFPBKDCBAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4B24200", Offset = "0x4B23400", VA = "0x184B24200", Slot = "13")]
	public override int GJMJDEGLGPE(GCPOJHCCJAJ JNHBFGDICNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4B25090", Offset = "0x4B24290", VA = "0x184B25090", Slot = "14")]
	public override int PMNJCPPOGOL(GCPOJHCCJAJ JNHBFGDICNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4B24E50", Offset = "0x4B24050", VA = "0x184B24E50")]
	private int OCCBILNGCEG(GCPOJHCCJAJ JNHBFGDICNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4B242A0", Offset = "0x4B234A0", VA = "0x184B242A0", Slot = "15")]
	public override void JGLPKMFFHHG(GCPOJHCCJAJ JNHBFGDICNI, BPGGFIADKDC JGGCNLIJCPH, int DEAPKKJJNME = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GCKFJIEHPPP
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJNJPBDMMIF(KCBBHPHCOPD OMCCJKNHBML, Renderer EKFGJNNOINP, int AJMHHHLLMAN);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIKOHLNAHOI(Renderer EKFGJNNOINP, IMBOAMAMOGC JLPNGEPENPN, Vector3 IANAMKKKLCC, Vector3 DLACBLCEEOD, Vector3 JMJHIJGCIIM, float CECADAMMOIE, float GEKPIPLNMCL, float PAACKFPEOJN = -1f, [Optional] Color? FBOHHNMLIAL, [Optional] IReadOnlyList<Camera> PJGAECDKFDM);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBOOBKLCPIJ(Renderer EKFGJNNOINP, int AJMHHHLLMAN);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GNOLCDPOKLF();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOACCFAGFOO(int ADGKEDMDOPL, IFCKNKGGBKE OMCCJKNHBML, Renderer EKFGJNNOINP, int AJMHHHLLMAN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LIFJADMJOML : JIHJCANDDKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly GCKFJIEHPPP IMEOLFPBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly OHHHMJFOKHK IGGGINGFCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private MeshRenderer HOEABNDAFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private FKNGMGMNHCH GHDAMKOBGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private MeshRenderer KPCPPHDJGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private FKNGMGMNHCH KNIMHKHGEBC;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x53A990", Offset = "0x539B90", VA = "0x18053A990")]
	public LIFJADMJOML(GCKFJIEHPPP JNFEMNFADGF, OHHHMJFOKHK IGGGINGFCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4B222B0", Offset = "0x4B214B0", VA = "0x184B222B0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4B22400", Offset = "0x4B21600", VA = "0x184B22400", Slot = "4")]
	public void FLMCJEKKFPM(PNLLIGBBKBC OMCEMBJPIBP, IFCKNKGGBKE HGALJLGLKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4B22680", Offset = "0x4B21880", VA = "0x184B22680", Slot = "5")]
	public void FLMCJEKKFPM(NPLGJCDIJGI AOFPBKDCBAI, IFCKNKGGBKE HGALJLGLKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4B21A10", Offset = "0x4B20C10", VA = "0x184B21A10", Slot = "6")]
	public void AMPNFKHLBHL(NPLGJCDIJGI AOFPBKDCBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4B217C0", Offset = "0x4B209C0", VA = "0x184B217C0", Slot = "7")]
	public void AMPNFKHLBHL(PNLLIGBBKBC OMCEMBJPIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4B22850", Offset = "0x4B21A50", VA = "0x184B22850", Slot = "8")]
	public void MFDOPKIOPMM(NPLGJCDIJGI AOFPBKDCBAI, KCBBHPHCOPD OMCCJKNHBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4B21F80", Offset = "0x4B21180", VA = "0x184B21F80", Slot = "9")]
	public void COBFGJMEFCJ(NPLGJCDIJGI AOFPBKDCBAI, Vector3 IANAMKKKLCC, Vector3 DLACBLCEEOD, Vector3 JMJHIJGCIIM, float CECADAMMOIE, float GEKPIPLNMCL, IReadOnlyList<Camera> NJDKGJPBLDF, IMBOAMAMOGC JLPNGEPENPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4B21BB0", Offset = "0x4B20DB0", VA = "0x184B21BB0", Slot = "10")]
	public void COBFGJMEFCJ(MKEHFOLCNKK MELJNPIHHFA, Vector3 IANAMKKKLCC, Vector3 DLACBLCEEOD, Vector3 JMJHIJGCIIM, float CECADAMMOIE, float GEKPIPLNMCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class NHKLJCOFAEL : APMLIKJDHMI, DOHHFHAJLJD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	protected Bounds CAMFNKFKGNH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NMDEAOOCEFC AJOEJMPPIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526690", VA = "0x180527490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds KMCGCCLLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xFD18A0", Offset = "0xFD0AA0", VA = "0x180FD18A0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual HIDEMNMNBKB OHIBILPJFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4B23BF0", Offset = "0x4B22DF0", VA = "0x184B23BF0", Slot = "12")]
		get
		{
			return default(HIDEMNMNBKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4B23B80", Offset = "0x4B22D80", VA = "0x184B23B80", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x527EC0", Offset = "0x5270C0", VA = "0x180527EC0", Slot = "11")]
	public virtual bool KDMMDNNDBJP(Transform AOFPBKDCBAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int GJMJDEGLGPE(GCPOJHCCJAJ JNHBFGDICNI);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int PMNJCPPOGOL(GCPOJHCCJAJ JNHBFGDICNI);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void JGLPKMFFHHG(GCPOJHCCJAJ JNHBFGDICNI, BPGGFIADKDC JGGCNLIJCPH, int DEAPKKJJNME = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	protected NHKLJCOFAEL()
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
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4B28D70", Offset = "0x4B27F70", VA = "0x184B28D70")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum AHMFDMCNFJN
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class PINLIMONBCD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BIJPBNGCPNN : IEnumerable<HOEOIKKADGI>, IEnumerable, IEnumerator<HOEOIKKADGI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private HOEOIKKADGI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private HOEOIKKADGI System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6383E0", Offset = "0x6375E0", VA = "0x1806383E0")]
		[DebuggerHidden]
		public BIJPBNGCPNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F8E0", Offset = "0x4B1EAE0", VA = "0x184B1F8E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4B1FA50", Offset = "0x4B1EC50", VA = "0x184B1FA50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F9C0", Offset = "0x4B1EBC0", VA = "0x184B1F9C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HOEOIKKADGI> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F9C0", Offset = "0x4B1EBC0", VA = "0x184B1F9C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const int AMDGFOIPGMJ = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static HOEOIKKADGI[][] MPCMOLLAEMD;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static KDJKBLLMBJN FHJOCAKJFMD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static ShapeRendererConfig KBBKLIFCCHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader DIJMMEJFLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4B28820", Offset = "0x4B27A20", VA = "0x184B28820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer EJJJHPAFACD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4B27DE0", Offset = "0x4B26FE0", VA = "0x184B27DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4B28080", Offset = "0x4B27280", VA = "0x184B28080")]
	public static Mesh EKHLIMKICNI(AHMFDMCNFJN KIOBJIGLPDC, int JNHBFGDICNI = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4B28070", Offset = "0x4B27270", VA = "0x184B28070")]
	public static int EHGMDLEHPHO(AHMFDMCNFJN KIOBJIGLPDC, int JNHBFGDICNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4B28490", Offset = "0x4B27690", VA = "0x184B28490")]
	public static KDJKBLLMBJN IEEFIDMPGCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4B287C0", Offset = "0x4B279C0", VA = "0x184B287C0")]
	[IteratorStateMachine(typeof(BIJPBNGCPNN))]
	private static IEnumerable<HOEOIKKADGI> LCCKAPHJENA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4B28140", Offset = "0x4B27340", VA = "0x184B28140")]
	public static HOEOIKKADGI FJPCCKIOBJF(AHMFDMCNFJN KIOBJIGLPDC, int JNHBFGDICNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4B285E0", Offset = "0x4B277E0", VA = "0x184B285E0")]
	public static bool IKAACONOAJF(this AHMFDMCNFJN KIOBJIGLPDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4B28600", Offset = "0x4B27800", VA = "0x184B28600")]
	public static void JJFMBLAGJEG(AHMFDMCNFJN KIOBJIGLPDC, float3 IKCIPMLDGGM, out ALOIJGNGNDH KEKAGHKBLBA, out float3 NOIECCMFJLG, out float FNHAHJPIICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B28890", Offset = "0x4B27A90", VA = "0x184B28890")]
	public static void OJBFELACDOB(Vector3 IKCIPMLDGGM, AHMFDMCNFJN KIOBJIGLPDC, out Vector3 NOIECCMFJLG, out float FNHAHJPIICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4B28480", Offset = "0x4B27680", VA = "0x184B28480")]
	[CLKPILCBOON(IMMNKPOABLM.ExitingPlayMode, 0)]
	private static void FMDKHOCCBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4B27E50", Offset = "0x4B27050", VA = "0x184B27E50")]
	[CLKPILCBOON(IMMNKPOABLM.ExitingPlayMode, 0)]
	private static void BOFCNIKFEHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KEIKDJNELJH
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool HHPKLGJAOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material AAKPMMEDOFC();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material AIAPIHJHMKE();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material AHNAFMGHLEM();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IKMFFKENKDO(JCKGONBFBHM MKFOAIEHHAC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KHGABBPHJKH(IAOAHFCENOL BICCDDNDCOH);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GCIKBDODJAM(GameObject KFCOOCIKJFL);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HMKABJLDIJC(GameObject KFCOOCIKJFL, bool FKDDCGIBGAB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface OHHHMJFOKHK
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	NMDEAOOCEFC HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	NHKLJCOFAEL HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	PIIPKLHGHDH HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class AOJLNPBDIBK : DDEFJDPHHID, IDisposable, OHHHMJFOKHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly global::FEFFDKAOFDB<NPLGJCDIJGI, NMDEAOOCEFC> LJPKLLAHELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::FEFFDKAOFDB<PNLLIGBBKBC, NHKLJCOFAEL> ILPMLAJLAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::FEFFDKAOFDB<MKEHFOLCNKK, PIIPKLHGHDH> OEJKHEEHPNE;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static KEIKDJNELJH JCCGIBKFBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F2E0", Offset = "0x4B1E4E0", VA = "0x184B1F2E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F110", Offset = "0x4B1E310", VA = "0x184B1F110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NMDEAOOCEFC HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F280", Offset = "0x4B1E480", VA = "0x184B1F280", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public NHKLJCOFAEL HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F1C0", Offset = "0x4B1E3C0", VA = "0x184B1F1C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public PIIPKLHGHDH HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F220", Offset = "0x4B1E420", VA = "0x184B1F220", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F470", Offset = "0x4B1E670", VA = "0x184B1F470")]
	public AOJLNPBDIBK(KEIKDJNELJH JNFEMNFADGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E990", Offset = "0x4B1DB90", VA = "0x184B1E990", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E840", Offset = "0x4B1DA40", VA = "0x184B1E840", Slot = "4")]
	public NPLGJCDIJGI CCKJNIOCJLN(EELCKLGPLIL EHJEONLOBCF)
	{
		return default(NPLGJCDIJGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F0B0", Offset = "0x4B1E2B0", VA = "0x184B1F0B0", Slot = "5")]
	public void JOEKBKDEBNC(NPLGJCDIJGI AOFPBKDCBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F040", Offset = "0x4B1E240", VA = "0x184B1F040", Slot = "6")]
	public void JCAPEONMDDD(NPLGJCDIJGI AOFPBKDCBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4B1EE00", Offset = "0x4B1E000", VA = "0x184B1EE00", Slot = "15")]
	public IEnumerable<Renderer> FDJFHEAAEED(NPLGJCDIJGI AOFPBKDCBAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E750", Offset = "0x4B1D950", VA = "0x184B1E750", Slot = "7")]
	public PNLLIGBBKBC ACPKOEPBANB(NPLGJCDIJGI AOFPBKDCBAI, HEKIEDELODG EHJEONLOBCF)
	{
		return default(PNLLIGBBKBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F380", Offset = "0x4B1E580", VA = "0x184B1F380", Slot = "8")]
	public PNLLIGBBKBC PAJHKGDHMFH(NPLGJCDIJGI AOFPBKDCBAI, FAMADJGINIP EHJEONLOBCF)
	{
		return default(PNLLIGBBKBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4B1EFD0", Offset = "0x4B1E1D0", VA = "0x184B1EFD0", Slot = "10")]
	public void IAMJJBIOIGL(PNLLIGBBKBC OMCEMBJPIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F160", Offset = "0x4B1E360", VA = "0x184B1F160", Slot = "9")]
	public void OICAHPPKIKM(PNLLIGBBKBC OMCEMBJPIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4B1EEC0", Offset = "0x4B1E0C0", VA = "0x184B1EEC0", Slot = "11")]
	public MKEHFOLCNKK GJEOEKAGBOO(JGMEJIEHNCM EHJEONLOBCF)
	{
		return default(MKEHFOLCNKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E920", Offset = "0x4B1DB20", VA = "0x184B1E920", Slot = "13")]
	public void DMDJBGFIHBE(MKEHFOLCNKK MELJNPIHHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F320", Offset = "0x4B1E520", VA = "0x184B1F320", Slot = "12")]
	public void OIONMLIDLDO(MKEHFOLCNKK MELJNPIHHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4B1EA00", Offset = "0x4B1DC00", VA = "0x184B1EA00", Slot = "14")]
	public OGNOIBAIHLG EEOGABFMGJI(Transform OMFFPGNGAKG, IEnumerable<PNLLIGBBKBC> ILPMLAJLAFG, int FDBCMKBBHDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PIIPKLHGHDH : DGHPDDKFODH
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OGOOAJDJPHE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public PIIPKLHGHDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6383E0", Offset = "0x6375E0", VA = "0x1806383E0")]
		[DebuggerHidden]
		public OGOOAJDJPHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4B26510", Offset = "0x4B25710", VA = "0x184B26510", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4B26230", Offset = "0x4B25430", VA = "0x184B26230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4B265B0", Offset = "0x4B257B0", VA = "0x184B265B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4B264C0", Offset = "0x4B256C0", VA = "0x184B264C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4B26420", Offset = "0x4B25620", VA = "0x184B26420", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4B26420", Offset = "0x4B25620", VA = "0x184B26420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly JGMEJIEHNCM KGDDKIGOBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly OHHHMJFOKHK IGGGINGFCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private LGECCIJBCID LNKKPPLGKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private List<NDKPDKCCJFC> FIPGNLFIGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<NDKPDKCCJFC> FCIMFJBFLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private GameObject PADFNMNBMNA;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B26BE0", Offset = "0x4B25DE0", VA = "0x184B26BE0")]
	public static PIIPKLHGHDH CIHEMEJDKNJ(JGMEJIEHNCM EHJEONLOBCF, OHHHMJFOKHK IGGGINGFCOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4B27D50", Offset = "0x4B26F50", VA = "0x184B27D50")]
	private PIIPKLHGHDH(JGMEJIEHNCM EHJEONLOBCF, OHHHMJFOKHK IGGGINGFCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4B27930", Offset = "0x4B26B30", VA = "0x184B27930")]
	public void NNIOEGIMEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B276C0", Offset = "0x4B268C0", VA = "0x184B276C0")]
	[IteratorStateMachine(typeof(OGOOAJDJPHE))]
	public IEnumerable<Renderer> GMJGNNPKGLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4B26CC0", Offset = "0x4B25EC0", VA = "0x184B26CC0", Slot = "4")]
	public void CPNCDFLBMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B27900", Offset = "0x4B26B00", VA = "0x184B27900")]
	private void NECJMHOJPOI(Vector3 CLNGALLIAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4B27730", Offset = "0x4B26930", VA = "0x184B27730")]
	public void IGIHOBELMJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NDKPDKCCJFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct HLKNFHBGHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public BPGGFIADKDC BCMDFODDGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Transform DPDKCOHIDKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int CPMGCJGKCCB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class OPNJKEAMKEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NDKPDKCCJFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public GCPOJHCCJAJ lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public List<HLKNFHBGHNC> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public OPNJKEAMKEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class IKABBGJKALD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public OGNOIBAIHLG combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public OPNJKEAMKEC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public IKABBGJKALD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4B20DE0", Offset = "0x4B1FFE0", VA = "0x184B20DE0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4B20E50", Offset = "0x4B20050", VA = "0x184B20E50")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4B20E90", Offset = "0x4B20090", VA = "0x184B20E90")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int[] AFIBOMNAJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GLMONBKJILN PHNBABDDGLF;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static Matrix4x4 IHNGMBLNBND;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh JBLPLBGIDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526690", VA = "0x180527490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int HDDABEFFNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5B3670", Offset = "0x5B2870", VA = "0x1805B3670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6A5CF0", Offset = "0x6A4EF0", VA = "0x1806A5CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4B22A30", Offset = "0x4B21C30", VA = "0x184B22A30")]
	public void AMPKKIACHIF(List<Transform> MKEFKNNFELN, Matrix4x4[] NDIKEEJAGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4B23130", Offset = "0x4B22330", VA = "0x184B23130")]
	public static List<NDKPDKCCJFC> JOBPNILIBDA(List<NMDEAOOCEFC> JHHAFLBKEPK, GCPOJHCCJAJ JNHBFGDICNI, Bounds NIEPJDKJDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4B22DB0", Offset = "0x4B21FB0", VA = "0x184B22DB0")]
	private JobHandle JDHBCEIHBIP(OGNOIBAIHLG OAIBPBGBFMO, int NAHCIGBDEBG, int AHIOBFMLIDC, GCPOJHCCJAJ JNHBFGDICNI, List<HLKNFHBGHNC> GOIJKHOOKLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4B22CB0", Offset = "0x4B21EB0", VA = "0x184B22CB0")]
	private void JADONJMKGIM(List<HLKNFHBGHNC> GOIJKHOOKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4B237D0", Offset = "0x4B229D0", VA = "0x184B237D0")]
	private NDKPDKCCJFC(List<HLKNFHBGHNC> GOIJKHOOKLL, int NAHCIGBDEBG, int AHIOBFMLIDC, GCPOJHCCJAJ JNHBFGDICNI, Bounds NIEPJDKJDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4B22C30", Offset = "0x4B21E30", VA = "0x184B22C30", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private MaterialPropertyBlock FEPBAJCCLHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private NDKPDKCCJFC BBEEEJLCJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private List<Transform> NBMIJPENBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private RenderTexture GMPNAIJCLIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private ComputeBuffer MCNEJBPDILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeShader BCNHABDMBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private Matrix4x4[] CJMPDELMDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int DGGMNNGGHGK;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer ENOJBDJMBEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5274A0", Offset = "0x5266A0", VA = "0x1805274A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int FDNKLFHOIJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4B29910", Offset = "0x4B28B10", VA = "0x184B29910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4B290F0", Offset = "0x4B282F0", VA = "0x184B290F0")]
		public static List<SkinnedShapeRenderer> Create(GameObject AOFPBKDCBAI, List<NDKPDKCCJFC> KILMGNBHKML, List<Transform> NBMIJPENBEH, Material NAEPHFLMGPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4B29390", Offset = "0x4B28590", VA = "0x184B29390")]
		public void Init(NDKPDKCCJFC BBEEEJLCJOC, List<Transform> NBMIJPENBEH, Material NAEPHFLMGPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4B29880", Offset = "0x4B28A80", VA = "0x184B29880")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4B297F0", Offset = "0x4B289F0", VA = "0x184B297F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4B297B0", Offset = "0x4B289B0", VA = "0x184B297B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4B29300", Offset = "0x4B28500", VA = "0x184B29300")]
		private void DCOIOALDMNB(ScriptableRenderContext EKDIFLKNOLC, Camera[] BJAJPGDOAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4B28DA0", Offset = "0x4B27FA0", VA = "0x184B28DA0")]
		private void AMPKKIACHIF(CommandBuffer MFNHLGFIAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD72680", Offset = "0xD71880", VA = "0x180D72680")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class PEGOPLHHMHI
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static byte[] HIBFFCCJJHD;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int BICBCGELOBK;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int ILHMFLHJGFF;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static BigInteger OJJMNJJEBED;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public PEGOPLHHMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4B26920", Offset = "0x4B25B20", VA = "0x184B26920")]
	private static string MCCHLMPJJNK(byte[] DCOPGELFIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4B265F0", Offset = "0x4B257F0", VA = "0x184B265F0")]
	public static string ACFPKMGBPMA(byte[] GMBNEFEOHLO, bool EDLKFPFOADI)
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

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
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
