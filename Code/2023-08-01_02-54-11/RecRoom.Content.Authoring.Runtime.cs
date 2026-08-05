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
	[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA85F10", Offset = "0xA84F10", VA = "0x180A85F10")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum MAGLFLEDNHE
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
	private MAGLFLEDNHE bobAxis;

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
	private float AKEJOMEIECI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 OHLPEEAFKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E98920", Offset = "0x6E97920", VA = "0x186E98920")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A151B0", Offset = "0x1A141B0", VA = "0x181A151B0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E98A90", Offset = "0x6E97A90", VA = "0x186E98A90")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E98C90", Offset = "0x6E97C90", VA = "0x186E98C90")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, DJLDMDMILGL
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string PBBBEKFCNJJ = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string COKONKNHLHD = "_MainColor";

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
	private static List<Material> JAMKMGJOEGE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> GCHOPDLILDE;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "4")]
	public void PrepareImposter(EKBGHDNNIGM OBPACCONAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E99140", Offset = "0x6E98140", VA = "0x186E99140")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E9EAA0", Offset = "0x6E9DAA0", VA = "0x186E9EAA0")]
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
	public bool FDFANCFICPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F150", Offset = "0x6E9E150", VA = "0x186E9F150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
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
	private FIOADOCPPOE playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FIOADOCPPOE GLAAAPNFMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAAA230", Offset = "0xAA9230", VA = "0x180AAA230")]
		get
		{
			return default(FIOADOCPPOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EA90", Offset = "0x6E9DA90", VA = "0x186E9EA90")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
[DefaultMember("Item")]
public struct NIHKHAFJJLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum DOKJILAOMJI
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
	public struct LIIGOBNANHM : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[ReadOnly]
		public NIHKHAFJJLF JBHIGHNAEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ReadOnly]
		public int OBBIEFMBBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public KFBFMNIIHOK IPILLHNCDGO;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A110", Offset = "0x6E99110", VA = "0x186E9A110", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct FBEODGLPIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Vector3> HOKDNKFKCMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<Vector3> KJEFLIOJEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<Vector4> EMOKCBMPEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<Vector2> MGMPEBHGJLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<Vector2> PMCLLBEFPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<Vector2> FILKLHOFELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeSlice<Vector2> PHFFMPCCJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NativeSlice<Color> PNMJBCODCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public NativeSlice<BoneWeight> FCGIJOCAOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NativeSlice<Matrix4x4> MCHHFOLENID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NativeSlice<int> LMAIINAAKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NativeSlice<int> GDBFCGEBNMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeSlice<int> JOJDIOECKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NativeSlice<int> LIPBKBFHBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NativeSlice<byte> HICELBGGOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int KHONPCHIPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Matrix4x4 HKNMCBJPMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public bool NEKNIAHKNBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int ALHKNCAFLBN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const int PJGIIDMFMIB = 1;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int AKCKIMJCKPN = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector3> HOKDNKFKCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> OENDLCOKCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<Vector3> KJEFLIOJEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<Vector4> EMOKCBMPEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<Vector2> MGMPEBHGJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<Vector2> PMCLLBEFPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<Vector2> FILKLHOFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<Vector2> PHFFMPCCJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<Color> PNMJBCODCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<BoneWeight> FCGIJOCAOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<int> LIPBKBFHBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<int> JLCOGBMKILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> PBFBBHPPNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<Matrix4x4> MCHHFOLENID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> HCLGMOPFCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> LMAIINAAKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> JFCDBGFNIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeArray<Matrix4x4> HBIKMIFLEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeArray<byte> DCMHKDFBBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> PFDOGKPPDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeArray<int> PCDKNBOAKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> BLBKHCADLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<sbyte> NFLOLEBAFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<int> IPHABDJGBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<int> HCLNBFLLKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<byte> BALLJCGDDOO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const int DGOIGOPPEFG = 0;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private const int ICBBFLNDAIE = 1;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private const int EIKKDDPFJED = 2;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private const int ODCGOEOLJIN = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<int> NABGCJDACOJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FJLDKFLBPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B780", Offset = "0x6E9A780", VA = "0x186E9B780")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B9C0", Offset = "0x6E9A9C0", VA = "0x186E9B9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LKHDBCCHLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B7A0", Offset = "0x6E9A7A0", VA = "0x186E9B7A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B9A0", Offset = "0x6E9A9A0", VA = "0x186E9B9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FENDGBAJNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B9D0", Offset = "0x6E9A9D0", VA = "0x186E9B9D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B790", Offset = "0x6E9A790", VA = "0x186E9B790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DOKJILAOMJI BFIFOHIBAJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B9B0", Offset = "0x6E9A9B0", VA = "0x186E9B9B0")]
		get
		{
			return default(DOKJILAOMJI);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B9E0", Offset = "0x6E9A9E0", VA = "0x186E9B9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private FBEODGLPIHC IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AEA0", Offset = "0x6E99EA0", VA = "0x186E9AEA0")]
		get
		{
			return default(FBEODGLPIHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B9F0", Offset = "0x6E9A9F0", VA = "0x186E9B9F0")]
	public NIHKHAFJJLF(IList<Mesh> PIGPEBLDHOH, IList<int> BDNDJFKFIML, IList<int> BMJFBGNMNCC, IList<int[]> EMJCEDAFMFJ, IList<Matrix4x4> APMOFEGDCAJ, IList<bool> EKGDKKLPDOJ, IList<int> AOLKPPGAAJJ, Allocator LEPNDEGMIDH, DOKJILAOMJI JMCNFHAMAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B7B0", Offset = "0x6E9A7B0", VA = "0x186E9B7B0")]
	public KFBFMNIIHOK HOCACCGOLKD(int JHBMJODIGKO, Allocator LEPNDEGMIDH)
	{
		return default(KFBFMNIIHOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B500", Offset = "0x6E9A500", VA = "0x186E9B500", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[NativeContainer]
public struct KFBFMNIIHOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Vector3> HOKDNKFKCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<Vector3> KJEFLIOJEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public NativeArray<Vector4> EMOKCBMPEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public NativeArray<Vector2> MGMPEBHGJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public NativeArray<Vector2> PMCLLBEFPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<Vector2> FILKLHOFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public NativeArray<Vector2> PHFFMPCCJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<Color> PNMJBCODCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<BoneWeight> FCGIJOCAOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeArray<Matrix4x4> MCHHFOLENID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public NativeArray<int> LMAIINAAKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> GDBFCGEBNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> JOJDIOECKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> NABGCJDACOJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int KIJGMCLEDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6E99C30", Offset = "0x6E98C30", VA = "0x186E99C30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E995B0", Offset = "0x6E985B0", VA = "0x186E995B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A050", Offset = "0x6E99050", VA = "0x186E9A050")]
	public KFBFMNIIHOK(int EDKLHAHGJGK, int KODIKMEMLFP, int GEENHNBDPPK, int JHBMJODIGKO, Allocator LEPNDEGMIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E99C40", Offset = "0x6E98C40", VA = "0x186E99C40")]
	public KFBFMNIIHOK(int EDKLHAHGJGK, int KODIKMEMLFP, int GEENHNBDPPK, int JHBMJODIGKO, Allocator LEPNDEGMIDH, bool[] IIPDALPDBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E99910", Offset = "0x6E98910", VA = "0x186E99910")]
	public void BHMGNPEPBKI(int NMHJJGKBNHI, int OBKOEDDJOMJ, int GAKMECKICIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E99B70", Offset = "0x6E98B70", VA = "0x186E99B70")]
	public int[] IHHPMDOJGJA(int NMHJJGKBNHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E995C0", Offset = "0x6E985C0", VA = "0x186E995C0")]
	private NativeSlice<int> AFDFOLDGDAI(int NMHJJGKBNHI)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E99A00", Offset = "0x6E98A00", VA = "0x186E99A00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E99660", Offset = "0x6E98660", VA = "0x186E99660")]
	public Mesh BBGKDIMJHLH([Optional] string GNHFNFHCEMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AIAAGMINDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private List<Mesh> NLAMNLKCJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<int> BDEPCNPHKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private List<bool> ABGMBHOJLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private List<int[]> HODHALNOCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<Matrix4x4> PBBLKEOABDF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E97CF0", Offset = "0x6E96CF0", VA = "0x186E97CF0")]
	public void NDHJHGNJIBD(Mesh DHAKOBAHEEC, int[] LJADAEFKKOG, Matrix4x4 DNBDLMHINKH, bool EKGDKKLPDOJ = false, int DPNNALPCCMG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E97BC0", Offset = "0x6E96BC0", VA = "0x186E97BC0")]
	public NIHKHAFJJLF EJBHGJELEDC(Allocator LEPNDEGMIDH, NIHKHAFJJLF.DOKJILAOMJI JMCNFHAMAJE, [Optional] IList<int> BMJFBGNMNCC, [Optional] IList<int> LJNICLCCNCO)
	{
		return default(NIHKHAFJJLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E97A80", Offset = "0x6E96A80", VA = "0x186E97A80")]
	private void CDPELOEJGDF(Mesh DHAKOBAHEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E97F50", Offset = "0x6E96F50", VA = "0x186E97F50")]
	public AIAAGMINDPL()
	{
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, DJLDMDMILGL
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
		private static readonly int HPHKKFDCIEC;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6E992A0", Offset = "0x6E982A0", VA = "0x186E992A0")]
		private void EONIPFNFJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6E991C0", Offset = "0x6E981C0", VA = "0x186E991C0")]
		private void EHKOLEBHINK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E99460", Offset = "0x6E98460", VA = "0x186E99460")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E993F0", Offset = "0x6E983F0", VA = "0x186E993F0", Slot = "4")]
		public void PrepareImposter(EKBGHDNNIGM OBPACCONAMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x11B9B30", Offset = "0x11B8B30", VA = "0x1811B9B30")]
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
		private Light GCLMCCBLMCM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Light OANPCFLLPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6E9E9F0", Offset = "0x6E9D9F0", VA = "0x186E9E9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E870", Offset = "0x6E9D870", VA = "0x186E9E870")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E9A0", Offset = "0x6E9D9A0", VA = "0x186E9E9A0")]
		public ParticleScriptedLight()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DLKEHCFPJBD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LKABLBCKFAB HGGFCEILIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<LKABLBCKFAB> JHMKAIPDHIE;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KPJDHNHEJNG();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum LKABLBCKFAB
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
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
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
		public delegate void OAFIFJNPPEC(ParticleEventListener JJEOHPKCNHO, Collider JONIFABKCAI, IEnumerable<ParticleCollisionEvent> OMKAJDBGFND);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> KBGDPGGPMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OAFIFJNPPEC JLDJBKGONHD
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D880", Offset = "0x6E9C880", VA = "0x186E9D880")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D920", Offset = "0x6E9C920", VA = "0x186E9D920")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9D4E0", Offset = "0x6E9C4E0", VA = "0x186E9D4E0")]
		private void OnParticleCollision(GameObject JONIFABKCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		public ParticleEventListener()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HKNHLMOIPAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GNHPEJJOHHG<T> : HKNHLMOIPAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PBCEIFCMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T EDIGOOJKBKJ);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class ActivationController : MonoBehaviour, HKNHLMOIPAC
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum GLJNFEEPELL
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
		[DFFLAPBPAEA("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected virtual GLJNFEEPELL EGCGANOJANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "4")]
			get
			{
				return default(GLJNFEEPELL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xF48D00", Offset = "0xF47D00", VA = "0x180F48D00")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class ActivationController<T> : ActivationController, GNHPEJJOHHG<T>, HKNHLMOIPAC where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		protected bool? FHKFEABPHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		protected T MENGKOPHJIN;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PBCEIFCMKLO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3EF5C40", Offset = "0x3EF4C40", VA = "0x183EF5C40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF58E0", Offset = "0x3EF48E0", VA = "0x183EF58E0", Slot = "7")]
		public virtual void SetActivation(T EDIGOOJKBKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool FCGFALEPEBH(T EDIGOOJKBKJ);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void PGEGBHELDEI(bool BKKAPJNJPGL);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5BC0", Offset = "0x3EF4BC0", VA = "0x183EF5BC0")]
		protected ActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface JPFLDHJHAKP
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color OAIMCLIJEAP);
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
		private List<Material> BOHAABCCPMC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject JGINGPGOIKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x92E3F0", Offset = "0x92D3F0", VA = "0x18092E3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6E980E0", Offset = "0x6E970E0", VA = "0x186E980E0")]
		public void Init(BackgroundObject CNMMOEIHJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E98390", Offset = "0x6E97390", VA = "0x186E98390")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6E984B0", Offset = "0x6E974B0", VA = "0x186E984B0")]
		public void SetBlendValue(float MPPHAPDGMDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E98600", Offset = "0x6E97600", VA = "0x186E98600")]
		public void SetColor(Color OAIMCLIJEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6E98710", Offset = "0x6E97710", VA = "0x186E98710")]
		public void SetRotation(float DEANJFCCEBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6E988A0", Offset = "0x6E978A0", VA = "0x186E988A0")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FIOADOCPPOE
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
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E9F2A0", Offset = "0x6E9E2A0", VA = "0x186E9F2A0")]
		public bool AGJBLIDDKEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F3E0", Offset = "0x6E9E3E0", VA = "0x186E9F3E0")]
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
		[DFFLAPBPAEA("UseSpacePartition")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("If true, the StaticBatcher will not generate batches that only contain 1 Renderer. Disabling this can be useful for debugging why certain objects cannot batch. This setting does not affect LOD groups: batches of 1 LOD group are never created.")]
		public bool RemoveBatchesOfOneRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F280", Offset = "0x6E9E280", VA = "0x186E9F280")]
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
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EC90", Offset = "0x6E9DC90", VA = "0x186E9EC90", Slot = "10")]
		protected override LightRenderingMode BFCMFHKACAJ(IRecRoomQualityConfigProvider BBDEGLIAEJP)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6E9ECF0", Offset = "0x6E9DCF0", VA = "0x186E9ECF0", Slot = "8")]
		protected override bool FCGFALEPEBH(LightRenderingMode MKCEDNFLONP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6E9ED00", Offset = "0x6E9DD00", VA = "0x186E9ED00")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EE00", Offset = "0x6E9DE00", VA = "0x186E9EE00", Slot = "10")]
		protected override TransparencyDetailLevel BFCMFHKACAJ(IRecRoomQualityConfigProvider BBDEGLIAEJP)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EE50", Offset = "0x6E9DE50", VA = "0x186E9EE50", Slot = "8")]
		protected override bool FCGFALEPEBH(TransparencyDetailLevel MKCEDNFLONP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EE70", Offset = "0x6E9DE70", VA = "0x186E9EE70")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6E9ED40", Offset = "0x6E9DD40", VA = "0x186E9ED40", Slot = "10")]
		protected override SceneDecorationDetailLevel BFCMFHKACAJ(IRecRoomQualityConfigProvider BBDEGLIAEJP)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E9ED90", Offset = "0x6E9DD90", VA = "0x186E9ED90", Slot = "8")]
		protected override bool FCGFALEPEBH(SceneDecorationDetailLevel MKCEDNFLONP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EDB0", Offset = "0x6E9DDB0", VA = "0x186E9EDB0")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private enum BMNGABAODNP
		{
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private BMNGABAODNP behavior;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EAC0", Offset = "0x6E9DAC0", VA = "0x186E9EAC0", Slot = "10")]
		protected override bool BFCMFHKACAJ(IRecRoomQualityConfigProvider BBDEGLIAEJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EB10", Offset = "0x6E9DB10", VA = "0x186E9EB10", Slot = "8")]
		protected override bool FCGFALEPEBH(bool MKCEDNFLONP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EB30", Offset = "0x6E9DB30", VA = "0x186E9EB30")]
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
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Terrain EEKFLAFLDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TerrainData KBGBALAIDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TerrainData NKNAFDINDLG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Terrain OGIMNBCGIHA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6E9F670", Offset = "0x6E9E670", VA = "0x186E9F670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F4E0", Offset = "0x6E9E4E0", VA = "0x186E9F4E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F890", Offset = "0x6E9E890", VA = "0x186E9F890")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F7B0", Offset = "0x6E9E7B0", VA = "0x186E9F7B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F7A0", Offset = "0x6E9E7A0", VA = "0x186E9F7A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F710", Offset = "0x6E9E710", VA = "0x186E9F710")]
		private void MJANIAKHAIH(LKABLBCKFAB OFDPKPOJECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E9FD40", Offset = "0x6E9ED40", VA = "0x186E9FD40", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel HIBGHPBNBMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x97FE10", Offset = "0x97EE10", VA = "0x18097FE10", Slot = "8")]
		protected override bool FCGFALEPEBH(TerrainQualityLevel EDIGOOJKBKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "9")]
		protected override void PGEGBHELDEI(bool BKKAPJNJPGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F460", Offset = "0x6E9E460", VA = "0x186E9F460")]
		private void AMOIBPEJEMB(Settings PLGDPIENMDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6E9FA60", Offset = "0x6E9EA60", VA = "0x186E9FA60")]
		private void PGALNCJIDJG(TreePrefabOverride[] CNBBOOMAPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F580", Offset = "0x6E9E580", VA = "0x186E9F580")]
		private void BKEPLMNJILK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F9E0", Offset = "0x6E9E9E0", VA = "0x186E9F9E0")]
		private Settings PFOLGPPMDGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6E9FF10", Offset = "0x6E9EF10", VA = "0x186E9FF10")]
		public TerrainQualitySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private bool GAMIFCPGHOH;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override GLJNFEEPELL EGCGANOJANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x843410", Offset = "0x842410", VA = "0x180843410", Slot = "4")]
			get
			{
				return default(GLJNFEEPELL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6E98CB0", Offset = "0x6E97CB0", VA = "0x186E98CB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E98CD0", Offset = "0x6E97CD0", VA = "0x186E98CD0")]
		private void JJOJDCHMJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6E99010", Offset = "0x6E98010", VA = "0x186E99010")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6E98EC0", Offset = "0x6E97EC0", VA = "0x186E98EC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6E98E30", Offset = "0x6E97E30", VA = "0x186E98E30")]
		private void ONOOGKENKDC(LKABLBCKFAB OFDPKPOJECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6E98CC0", Offset = "0x6E97CC0", VA = "0x186E98CC0", Slot = "8")]
		protected override bool FCGFALEPEBH(bool MKCEDNFLONP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6E98FA0", Offset = "0x6E97FA0", VA = "0x186E98FA0", Slot = "9")]
		protected override void PGEGBHELDEI(bool BKKAPJNJPGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E99040", Offset = "0x6E98040", VA = "0x186E99040")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EF50", Offset = "0x6E9DF50", VA = "0x186E9EF50", Slot = "8")]
		protected override bool FCGFALEPEBH(BackgroundAnimationDetailLevel EDIGOOJKBKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F080", Offset = "0x6E9E080", VA = "0x186E9F080", Slot = "9")]
		protected override void PGEGBHELDEI(bool LEOEHJANNDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EEC0", Offset = "0x6E9DEC0", VA = "0x186E9EEC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EFF0", Offset = "0x6E9DFF0", VA = "0x186E9EFF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F110", Offset = "0x6E9E110", VA = "0x186E9F110")]
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
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x13DAA0", Offset = "0x13CEA0")]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private bool IHJFKFGBBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int IFFEGPLACIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool LOCADEANONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private bool PCGIFIOKGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float CJKNLDEEAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float FDIECJOIKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private float ACENFDIIBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private float HAJCKDLICOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private float KNIDBJEIMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private float LGDEAHDMKMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private ParticleSystem.MainModule GIJHLBGOPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private ParticleSystem.TrailModule BOPHPIIBPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private ParticleSystem.EmissionModule CBJNDFEOBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private ParticleSystem.CollisionModule PGLBKPFBMOO;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E6E0", Offset = "0x6E9D6E0", VA = "0x186E9E6E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E600", Offset = "0x6E9D600", VA = "0x186E9E600")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E5A0", Offset = "0x6E9D5A0", VA = "0x186E9E5A0")]
		private void ONOOGKENKDC(LKABLBCKFAB OFDPKPOJECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E0C0", Offset = "0x6E9D0C0", VA = "0x186E9E0C0")]
		private void OCAMCDIKEJH(IRecRoomQualityConfigProvider MNBJEIBNFOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9DE70", Offset = "0x6E9CE70", VA = "0x186E9DE70")]
		private void NMGLLEDAIKF(OverrideSettings KMNPKIMOADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9DB80", Offset = "0x6E9CB80", VA = "0x186E9DB80")]
		private void EHJGCINMPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9D9C0", Offset = "0x6E9C9C0", VA = "0x186E9D9C0")]
		private void CPJMEBCAEMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9DD30", Offset = "0x6E9CD30", VA = "0x186E9DD30")]
		private void GCJAINEGMNK(ParticleSystem.MinMaxCurve GOAGAOHOBKI, out float DOBCIFMOHGK, out float KNNOMCDMNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E450", Offset = "0x6E9D450", VA = "0x186E9E450")]
		private ParticleSystem.MinMaxCurve ONDGBMFEFIE(ParticleSystem.MinMaxCurve GOAGAOHOBKI, float DOBCIFMOHGK, float KNNOMCDMNDJ)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override GLJNFEEPELL EGCGANOJANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x843410", Offset = "0x842410", VA = "0x180843410", Slot = "4")]
			get
			{
				return default(GLJNFEEPELL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T BFCMFHKACAJ(IRecRoomQualityConfigProvider BBDEGLIAEJP);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E0CDA0", Offset = "0x5E0BDA0", VA = "0x185E0CDA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D250", Offset = "0x5E0C250", VA = "0x185E0D250")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D220", Offset = "0x5E0C220", VA = "0x185E0D220")]
		private void ONOOGKENKDC(LKABLBCKFAB OFDPKPOJECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D120", Offset = "0x5E0C120", VA = "0x185E0D120")]
		private void ODALFMHLJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D4F0", Offset = "0x5E0C4F0", VA = "0x185E0D4F0", Slot = "9")]
		protected override void PGEGBHELDEI(bool BKKAPJNJPGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1859900", Offset = "0x1858900", VA = "0x181859900")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private enum EGBNEBPOLBO
		{
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private EGBNEBPOLBO behavior;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EC00", Offset = "0x6E9DC00", VA = "0x186E9EC00", Slot = "10")]
		protected override bool BFCMFHKACAJ(IRecRoomQualityConfigProvider BBDEGLIAEJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EB10", Offset = "0x6E9DB10", VA = "0x186E9EB10", Slot = "8")]
		protected override bool FCGFALEPEBH(bool MKCEDNFLONP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EC50", Offset = "0x6E9DC50", VA = "0x186E9EC50")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class OAADOLELHIK
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D3F0", Offset = "0x6E9C3F0", VA = "0x186E9D3F0")]
	[OHDKPIIHCBL(BGEACDHIFOF.None)]
	private static void FHIGGLJNFIH(ECDJHHJLGGB LADPAJPBFMP)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private enum EHEBOIMBPDH
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private EHEBOIMBPDH behavior;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EB70", Offset = "0x6E9DB70", VA = "0x186E9EB70", Slot = "10")]
		protected override bool BFCMFHKACAJ(IRecRoomQualityConfigProvider BBDEGLIAEJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EB10", Offset = "0x6E9DB10", VA = "0x186E9EB10", Slot = "8")]
		protected override bool FCGFALEPEBH(bool MKCEDNFLONP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EBC0", Offset = "0x6E9DBC0", VA = "0x186E9EBC0")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
