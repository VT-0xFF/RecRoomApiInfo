using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Platforms;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x155FDE0", Offset = "0x155F1E0", VA = "0x18155FDE0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum JJLMADDAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private JJLMADDAFLO bobAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private float scaleBobAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private float scaleBobSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private bool inWorldSpace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float NBPNGNOAFDO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 CKLHNIMDHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x155FA50", Offset = "0x155EE50", VA = "0x18155FA50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x155FA10", Offset = "0x155EE10", VA = "0x18155FA10")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x155FBC0", Offset = "0x155EFC0", VA = "0x18155FBC0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x155FDC0", Offset = "0x155F1C0", VA = "0x18155FDC0")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, HLMFPEIHCPC
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string KKJCENEFHKI = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string KBPPDNCGLPP = "_MainColor";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[Tooltip("List of Renderers to increase color alpha")]
	private List<Renderer> imposterRenderers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Range(0f, 1f)]
	private float imposterAlpha;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static List<Material> EFOLPMJCPAL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> MKMHPAKFNJJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "4")]
	public void PrepareImposter(GIGFBDAKNKF IHHAIAFPENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1561240", Offset = "0x1560640", VA = "0x181561240")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RequireComponent(typeof(Camera))]
public class ScreenshotGenerator : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public int AntiAliasLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool UseAlpha;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1566630", Offset = "0x1565A30", VA = "0x181566630")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EOHDDNOHLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1566CE0", Offset = "0x15660E0", VA = "0x181566CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[SerializeField]
	private DDOPOMLGFDC playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DDOPOMLGFDC FLOFAEPMNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA03550", Offset = "0xA02950", VA = "0x180A03550")]
		get
		{
			return default(DDOPOMLGFDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1566620", Offset = "0x1565A20", VA = "0x181566620")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
[DefaultMember("Item")]
public struct KOIEIHIPMMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum FNNKHPAEPJK
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		CollapseSubMeshes,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		CollapseToUniqueMaterials,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		MergeAll
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct FDJHDAAOAIP : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[ReadOnly]
		public KOIEIHIPMMJ HGCDIMDHPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ReadOnly]
		public int NKFCBCDBCKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public PBDBFMKMICL DBLKHEADMFN;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x15601E0", Offset = "0x155F5E0", VA = "0x1815601E0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct HIIFPMIJPDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Vector3> AOICNKDCMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<Vector3> AIKIJDHIMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<Vector4> BEGEDNHMJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<Vector2> LGLLKLIODOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<Vector2> HBNGKGNEIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<Vector2> NMLOFPNKJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeSlice<Vector2> OEPADPCGGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NativeSlice<Color> JLLDOIIEOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public NativeSlice<BoneWeight> IIJMDEPCOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NativeSlice<Matrix4x4> GHJNANECKBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NativeSlice<int> CJHPHMKLLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NativeSlice<int> BKCJCOMNODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeSlice<int> LIPDDDNPJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NativeSlice<int> BECDIBLLNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NativeSlice<byte> PIGONMNEHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int HMODLCKLDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Matrix4x4 ACPILIDGHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public bool LOAKPNDIEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int NPLANINJHDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const int FCEBEIJOJJD = 1;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int GGFNOCGCMEG = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector3> AOICNKDCMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> MDNLLKHDLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<Vector3> AIKIJDHIMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<Vector4> BEGEDNHMJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<Vector2> LGLLKLIODOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<Vector2> HBNGKGNEIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<Vector2> NMLOFPNKJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<Vector2> OEPADPCGGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<Color> JLLDOIIEOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<BoneWeight> IIJMDEPCOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<int> BECDIBLLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<int> CEJJBKLBAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> PLLBCAJLANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<Matrix4x4> GHJNANECKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> CGKGBIDNGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> CJHPHMKLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> CDLCDHNMNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeArray<Matrix4x4> LPGAFHJIBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeArray<byte> PNKPAPMNECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> ONBJCCPCOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeArray<int> BJLGPDIGKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> MPNMECHFOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<sbyte> EHPMPELFIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<int> LABPIGGNHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<int> GLLLDCIKEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<byte> MNDICPGJMPP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const int BMMEJBPALGD = 0;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private const int LPFHBJEGNBI = 1;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private const int FOEAIJKBMAN = 2;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private const int KCGMMNALLKF = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<int> AOOFDPEJKJI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AMENAIEKDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1561FC0", Offset = "0x15613C0", VA = "0x181561FC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1561D20", Offset = "0x1561120", VA = "0x181561D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IPIBPAIKNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x15621C0", Offset = "0x15615C0", VA = "0x1815621C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1561FB0", Offset = "0x15613B0", VA = "0x181561FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DLIMHDBFJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x15621E0", Offset = "0x15615E0", VA = "0x1815621E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x15621D0", Offset = "0x15615D0", VA = "0x1815621D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FNNKHPAEPJK FBBEPDAHOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x15621F0", Offset = "0x15615F0", VA = "0x1815621F0")]
		get
		{
			return default(FNNKHPAEPJK);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x15616C0", Offset = "0x1560AC0", VA = "0x1815616C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private HIIFPMIJPDH KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x15616D0", Offset = "0x1560AD0", VA = "0x1815616D0")]
		get
		{
			return default(HIIFPMIJPDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1562200", Offset = "0x1561600", VA = "0x181562200")]
	public KOIEIHIPMMJ(IList<Mesh> KALINEBFOFC, IList<int> GGKMAIKCNGH, IList<int> APMJFBAEEOP, IList<int[]> FFNLAOCPBNM, IList<Matrix4x4> OIPDLFGPCCE, IList<bool> NNPKJILAPMP, IList<int> MOAPLMGPLEC, Allocator NAFCEIMFOBK, FNNKHPAEPJK JBCBEKDCAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1561FD0", Offset = "0x15613D0", VA = "0x181561FD0")]
	public PBDBFMKMICL IMFPELJGJBD(int DABMJOOMPNM, Allocator NAFCEIMFOBK)
	{
		return default(PBDBFMKMICL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1561D30", Offset = "0x1561130", VA = "0x181561D30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[NativeContainer]
public struct PBDBFMKMICL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Vector3> AOICNKDCMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<Vector3> AIKIJDHIMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public NativeArray<Vector4> BEGEDNHMJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public NativeArray<Vector2> LGLLKLIODOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public NativeArray<Vector2> HBNGKGNEIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<Vector2> NMLOFPNKJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public NativeArray<Vector2> OEPADPCGGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<Color> JLLDOIIEOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<BoneWeight> IIJMDEPCOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeArray<Matrix4x4> GHJNANECKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public NativeArray<int> CJHPHMKLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> BKCJCOMNODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> LIPDDDNPJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> AOOFDPEJKJI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JNCJLEJNANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x15648E0", Offset = "0x1563CE0", VA = "0x1815648E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1564830", Offset = "0x1563C30", VA = "0x181564830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x15649E0", Offset = "0x1563DE0", VA = "0x1815649E0")]
	public PBDBFMKMICL(int HCMDFHBGABE, int MCOEJOBKBEM, int HIJADLDIBDL, int DABMJOOMPNM, Allocator NAFCEIMFOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1564AA0", Offset = "0x1563EA0", VA = "0x181564AA0")]
	public PBDBFMKMICL(int HCMDFHBGABE, int MCOEJOBKBEM, int HIJADLDIBDL, int DABMJOOMPNM, Allocator NAFCEIMFOBK, bool[] FFDECNBBJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x15648F0", Offset = "0x1563CF0", VA = "0x1815648F0")]
	public void OMPADCBGPIF(int LLBHDJNDBNN, int OKCABOJFCGG, int JNPIFHIHMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1564350", Offset = "0x1563750", VA = "0x181564350")]
	public int[] BKHCPDENJJE(int LLBHDJNDBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1564840", Offset = "0x1563C40", VA = "0x181564840")]
	private NativeSlice<int> GBLDLDMFMGC(int LLBHDJNDBNN)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x15646C0", Offset = "0x1563AC0", VA = "0x1815646C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1564410", Offset = "0x1563810", VA = "0x181564410")]
	public Mesh CPDLAEOIOJN([Optional] string OACHKKEIFPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OCNICFFMACJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private List<Mesh> MBLLBLFHPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<int> OEGCJBBMHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private List<bool> FFKCMEDDDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private List<int[]> GDBCMNIFHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<Matrix4x4> BEAFFKGJGHM;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1563F50", Offset = "0x1563350", VA = "0x181563F50")]
	public void NFGPLGLMNPH(Mesh CKHGFHPLIDD, int[] MLHONJHLNLG, Matrix4x4 OFHPCJKIFNP, bool NNPKJILAPMP = false, int DIJDIPMEIJO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1563CE0", Offset = "0x15630E0", VA = "0x181563CE0")]
	public KOIEIHIPMMJ ENPINIIGFIO(Allocator NAFCEIMFOBK, KOIEIHIPMMJ.FNNKHPAEPJK JBCBEKDCAFD, [Optional] IList<int> APMJFBAEEOP, [Optional] IList<int> ODFAMONDMEM)
	{
		return default(KOIEIHIPMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1563E10", Offset = "0x1563210", VA = "0x181563E10")]
	private void INEBBEEAPJB(Mesh CKHGFHPLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x15641C0", Offset = "0x15635C0", VA = "0x1815641C0")]
	public OCNICFFMACJ()
	{
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, HLMFPEIHCPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int PAFPPNMEFIA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x15612C0", Offset = "0x15606C0", VA = "0x1815612C0")]
		private void GDHFBPFJPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1561410", Offset = "0x1560810", VA = "0x181561410")]
		private void JKCAKNNNCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1561560", Offset = "0x1560960", VA = "0x181561560")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x15614F0", Offset = "0x15608F0", VA = "0x1815614F0", Slot = "4")]
		public void PrepareImposter(GIGFBDAKNKF IHHAIAFPENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB2B3E0", Offset = "0xB2A7E0", VA = "0x180B2B3E0")]
		public InstanceColor()
		{
		}
	}
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Light HFNDDJPFFFH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Light DJEBEBCGKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1566580", Offset = "0x1565980", VA = "0x181566580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1566400", Offset = "0x1565800", VA = "0x181566400")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1566530", Offset = "0x1565930", VA = "0x181566530")]
		public ParticleScriptedLight()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FMNFIKCKOJI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NCNHPGBCCLG ELHLJKLJAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NCNHPGBCCLG> PCEHKKNDBFC;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DOOHADPNMPI();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum NCNHPGBCCLG
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Count
}
namespace RecRoom.ProBuilder
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[AddComponentMenu("")]
	public class AGProBuilderStub : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public AGProBuilderStub()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void NOECGEMCBCH(ParticleEventListener BACPAEOHKDH, Collider CCJMBGJFGLH, IEnumerable<ParticleCollisionEvent> AKOPKPBPEOA);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> JPLFILMJDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NOECGEMCBCH BFMDEHFGNEP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1565250", Offset = "0x1564650", VA = "0x181565250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x15652F0", Offset = "0x15646F0", VA = "0x1815652F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1564EB0", Offset = "0x15642B0", VA = "0x181564EB0")]
		private void OnParticleCollision(GameObject CCJMBGJFGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public ParticleEventListener()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DPKCDOMGELM
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OADNOFOAHKD<T> : DPKCDOMGELM
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PMJADBKMOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T ECGNNFMGMIC);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class ActivationController : MonoBehaviour, DPKCDOMGELM
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum AFHGFJHNAGL
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[MJNEDKHJIPG("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected virtual AFHGFJHNAGL ONIIJFMPPIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7F1D90", Offset = "0x7F1190", VA = "0x1807F1D90", Slot = "4")]
			get
			{
				return default(AFHGFJHNAGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x155F1C0", Offset = "0x155E5C0", VA = "0x18155F1C0")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class ActivationController<T> : ActivationController, global::OADNOFOAHKD<T>, DPKCDOMGELM where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		protected bool? ALLNABHDGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		protected T BGBPGAKKCOI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PMJADBKMOKD
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x405F3D0", Offset = "0x405E7D0", VA = "0x18405F3D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x405F0B0", Offset = "0x405E4B0", VA = "0x18405F0B0", Slot = "7")]
		public virtual void SetActivation(T ECGNNFMGMIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool PHMBFKJCGHE(T ECGNNFMGMIC);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void ALKPPHBGJHA(bool LBEENJMGFNA);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x405F350", Offset = "0x405E750", VA = "0x18405F350")]
		protected ActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface LLJINCMMMJP
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color OGGMNJPGMJE);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<Material> OMHJJLFJIKG;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject GBFCJKICICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810E60", VA = "0x180811A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x155F1D0", Offset = "0x155E5D0", VA = "0x18155F1D0")]
		public void Init(BackgroundObject BLJDINJOMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x155F470", Offset = "0x155E870", VA = "0x18155F470")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x155F590", Offset = "0x155E990", VA = "0x18155F590")]
		public void SetBlendValue(float ICIPBMMDKNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x155F6F0", Offset = "0x155EAF0", VA = "0x18155F6F0")]
		public void SetColor(Color OGGMNJPGMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x155F800", Offset = "0x155EC00", VA = "0x18155F800")]
		public void SetRotation(float FKJONOBDEOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x155F990", Offset = "0x155ED90", VA = "0x18155F990")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DDOPOMLGFDC
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	HEAD_AND_BODY
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1566E30", Offset = "0x1566230", VA = "0x181566E30")]
		public bool HDMBJDKPJDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1566F70", Offset = "0x1566370", VA = "0x181566F70")]
		public StaticBatchMeshData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[MJNEDKHJIPG("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1566E10", Offset = "0x1566210", VA = "0x181566E10")]
		public StaticBatchManager()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1566820", Offset = "0x1565C20", VA = "0x181566820", Slot = "10")]
		protected override LightRenderingMode NHDIKGBGLMI(IRecRoomQualityConfigProvider OAKKNJPJALK)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1566880", Offset = "0x1565C80", VA = "0x181566880", Slot = "8")]
		protected override bool PHMBFKJCGHE(LightRenderingMode GCCKMLAAGKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1566890", Offset = "0x1565C90", VA = "0x181566890")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1566990", Offset = "0x1565D90", VA = "0x181566990", Slot = "10")]
		protected override TransparencyDetailLevel NHDIKGBGLMI(IRecRoomQualityConfigProvider OAKKNJPJALK)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x15669E0", Offset = "0x1565DE0", VA = "0x1815669E0", Slot = "8")]
		protected override bool PHMBFKJCGHE(TransparencyDetailLevel GCCKMLAAGKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1566A00", Offset = "0x1565E00", VA = "0x181566A00")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x15668D0", Offset = "0x1565CD0", VA = "0x1815668D0", Slot = "10")]
		protected override SceneDecorationDetailLevel NHDIKGBGLMI(IRecRoomQualityConfigProvider OAKKNJPJALK)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1566920", Offset = "0x1565D20", VA = "0x181566920", Slot = "8")]
		protected override bool PHMBFKJCGHE(SceneDecorationDetailLevel GCCKMLAAGKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1566940", Offset = "0x1565D40", VA = "0x181566940")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private enum MNBMONNCFCJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private MNBMONNCFCJ behavior;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1566650", Offset = "0x1565A50", VA = "0x181566650", Slot = "10")]
		protected override bool NHDIKGBGLMI(IRecRoomQualityConfigProvider OAKKNJPJALK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x15666A0", Offset = "0x1565AA0", VA = "0x1815666A0", Slot = "8")]
		protected override bool PHMBFKJCGHE(bool GCCKMLAAGKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x15666C0", Offset = "0x1565AC0", VA = "0x1815666C0")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private Terrain ANBBIBKCBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TerrainData HMOBGFPFKOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TerrainData OBNEDJLHKDF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Terrain KHIMIELEAOF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1567220", Offset = "0x1566620", VA = "0x181567220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1566FF0", Offset = "0x15663F0", VA = "0x181566FF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1567770", Offset = "0x1566B70", VA = "0x181567770")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1567690", Offset = "0x1566A90", VA = "0x181567690")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1567680", Offset = "0x1566A80", VA = "0x181567680")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1567110", Offset = "0x1566510", VA = "0x181567110")]
		private void IBLNNPGBFNI(NCNHPGBCCLG IAKBILIMNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x15678C0", Offset = "0x1566CC0", VA = "0x1815678C0", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel BAAGAFFJIFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x812940", Offset = "0x811D40", VA = "0x180812940", Slot = "8")]
		protected override bool PHMBFKJCGHE(TerrainQualityLevel ECGNNFMGMIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "9")]
		protected override void ALKPPHBGJHA(bool LBEENJMGFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x15671A0", Offset = "0x15665A0", VA = "0x1815671A0")]
		private void JPBHIBIMOFN(Settings AIPHKCIPHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x15673B0", Offset = "0x15667B0", VA = "0x1815673B0")]
		private void OLBOGNJIMLP(TreePrefabOverride[] DIEBPEOGLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x15672C0", Offset = "0x15666C0", VA = "0x1815672C0")]
		private void KPLOCGDDPMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1567090", Offset = "0x1566490", VA = "0x181567090")]
		private Settings BGFIDGNFKEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1567A80", Offset = "0x1566E80", VA = "0x181567A80")]
		public TerrainQualitySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private bool NOJCNLGGDFO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override AFHGFJHNAGL ONIIJFMPPIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x90E310", Offset = "0x90D710", VA = "0x18090E310", Slot = "4")]
			get
			{
				return default(AFHGFJHNAGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x155FE80", Offset = "0x155F280", VA = "0x18155FE80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x155FF20", Offset = "0x155F320", VA = "0x18155FF20")]
		private void MBIPEINHFMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1560170", Offset = "0x155F570", VA = "0x181560170")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1560080", Offset = "0x155F480", VA = "0x181560080")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x155FE90", Offset = "0x155F290", VA = "0x18155FE90")]
		private void DPJBOKJLDKN(NCNHPGBCCLG IAKBILIMNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1560160", Offset = "0x155F560", VA = "0x181560160", Slot = "8")]
		protected override bool PHMBFKJCGHE(bool GCCKMLAAGKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x155FE10", Offset = "0x155F210", VA = "0x18155FE10", Slot = "9")]
		protected override void ALKPPHBGJHA(bool LBEENJMGFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x15601A0", Offset = "0x155F5A0", VA = "0x1815601A0")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1566C00", Offset = "0x1566000", VA = "0x181566C00", Slot = "8")]
		protected override bool PHMBFKJCGHE(BackgroundAnimationDetailLevel ECGNNFMGMIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1566A50", Offset = "0x1565E50", VA = "0x181566A50", Slot = "9")]
		protected override void ALKPPHBGJHA(bool BIECHBLBGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1566AE0", Offset = "0x1565EE0", VA = "0x181566AE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1566B70", Offset = "0x1565F70", VA = "0x181566B70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1566CA0", Offset = "0x15660A0", VA = "0x181566CA0")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x488E0", Offset = "0x47CE0")]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private bool FGPJPPJCMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int EBODMEHDEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool MMNLEMPIBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool PIKMJHPKIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private float BDDFEEBIJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float FKLOLJDLODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float CKINHCOJPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private float MBMNINJEGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private float NDJAAGFHLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private float EJEKDNFAMEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private ParticleSystem.MainModule BIEOBOACENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private ParticleSystem.TrailModule OFEMLCBLEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private ParticleSystem.EmissionModule DPKIEKGFICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private ParticleSystem.CollisionModule ENCBIDFIKPC;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1566270", Offset = "0x1565670", VA = "0x181566270")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1566190", Offset = "0x1565590", VA = "0x181566190")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1565390", Offset = "0x1564790", VA = "0x181565390")]
		private void DPJBOKJLDKN(NCNHPGBCCLG IAKBILIMNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1565800", Offset = "0x1564C00", VA = "0x181565800")]
		private void JAFFJCACBBC(IRecRoomQualityConfigProvider GBKHEJGDEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x15655A0", Offset = "0x15649A0", VA = "0x1815655A0")]
		private void HKHOOEEIPFN(OverrideSettings OELBIPBPJBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x15653F0", Offset = "0x15647F0", VA = "0x1815653F0")]
		private void FHPKDOJFIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1565FD0", Offset = "0x15653D0", VA = "0x181565FD0")]
		private void OIEMPJFKKMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1565E90", Offset = "0x1565290", VA = "0x181565E90")]
		private void LPIPBOCBIIB(ParticleSystem.MinMaxCurve IAIOFFMKMGF, out float CGJIHHJDDAI, out float ILMMOIJNOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1565D40", Offset = "0x1565140", VA = "0x181565D40")]
		private ParticleSystem.MinMaxCurve KKJJBAKLDIG(ParticleSystem.MinMaxCurve IAIOFFMKMGF, float CGJIHHJDDAI, float ILMMOIJNOAA)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override AFHGFJHNAGL ONIIJFMPPIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x90E310", Offset = "0x90D710", VA = "0x18090E310", Slot = "4")]
			get
			{
				return default(AFHGFJHNAGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T NHDIKGBGLMI(IRecRoomQualityConfigProvider OAKKNJPJALK);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6007320", Offset = "0x6006720", VA = "0x186007320")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x60077D0", Offset = "0x6006BD0", VA = "0x1860077D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6007620", Offset = "0x6006A20", VA = "0x186007620")]
		private void DPJBOKJLDKN(NCNHPGBCCLG IAKBILIMNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x60076D0", Offset = "0x6006AD0", VA = "0x1860076D0")]
		private void NKKGEPIHLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x60072E0", Offset = "0x60066E0", VA = "0x1860072E0", Slot = "9")]
		protected override void ALKPPHBGJHA(bool LBEENJMGFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1C6C2F0", Offset = "0x1C6B6F0", VA = "0x181C6C2F0")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private enum PMCNKPLOLLI
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private PMCNKPLOLLI behavior;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1566790", Offset = "0x1565B90", VA = "0x181566790", Slot = "10")]
		protected override bool NHDIKGBGLMI(IRecRoomQualityConfigProvider OAKKNJPJALK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x15666A0", Offset = "0x1565AA0", VA = "0x1815666A0", Slot = "8")]
		protected override bool PHMBFKJCGHE(bool GCCKMLAAGKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x15667E0", Offset = "0x1565BE0", VA = "0x1815667E0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class LLMLGBMBILN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1563BF0", Offset = "0x1562FF0", VA = "0x181563BF0")]
	[HECCOHDEPAK(JCKMLGOOEHJ.None)]
	private static void PKIDGDOGENM(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private enum PLBFJBLEFAE
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private PLBFJBLEFAE behavior;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1566700", Offset = "0x1565B00", VA = "0x181566700", Slot = "10")]
		protected override bool NHDIKGBGLMI(IRecRoomQualityConfigProvider OAKKNJPJALK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x15666A0", Offset = "0x1565AA0", VA = "0x1815666A0", Slot = "8")]
		protected override bool PHMBFKJCGHE(bool GCCKMLAAGKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1566750", Offset = "0x1565B50", VA = "0x181566750")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
