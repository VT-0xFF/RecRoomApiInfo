using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Platforms;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA3A870", Offset = "0xA39C70", VA = "0x180A3A870")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum EMENBDFIOCA
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
	private EMENBDFIOCA bobAxis;

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
	private float BOJOACEFBOG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 KJBHLOFAMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA850", Offset = "0x6BC9C50", VA = "0x186BCA850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0B30", Offset = "0x1A9FF30", VA = "0x181AA0B30")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA9C0", Offset = "0x6BC9DC0", VA = "0x186BCA9C0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BCABC0", Offset = "0x6BC9FC0", VA = "0x186BCABC0")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, HEEELEEOPIF
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string ODACBNKEEKI = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string OKJMHJLKNAB = "_MainColor";

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
	private static List<Material> NGMNFDPNCJE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> DBMNHBLENGH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	public void PrepareImposter(LEHNJAODHGJ NPOLKGPPPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE5D0", Offset = "0x6BCD9D0", VA = "0x186BCE5D0")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ExecuteInEditMode]
[UnityEngine.Scripting.Preserve]
public class InstancedMeshGroup : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[FormerlySerializedAs("me")]
	public Mesh mesh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[FormerlySerializedAs("ma")]
	public Material material;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[FormerlySerializedAs("trs")]
	public Matrix4x4[] MatricesTRS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Component[] componentsToHide;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEA40", Offset = "0x6BCDE40", VA = "0x186BCEA40")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEAE0", Offset = "0x6BCDEE0", VA = "0x186BCEAE0")]
	public void initialize(Mesh NKFMDLBACDH, Material OLFBGGFDDAJ, Matrix4x4[] CAKLEFKNKHM, Component[] JJNPMJLAHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
	public InstancedMeshGroup()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RequireComponent(typeof(Camera))]
public class ScreenshotGenerator : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int AntiAliasLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool UseAlpha;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD20F0", Offset = "0x6BD14F0", VA = "0x186BD20F0")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KIJFGNPCFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD27A0", Offset = "0x6BD1BA0", VA = "0x186BD27A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[SerializeField]
	private NCLIMOOEFEP playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NCLIMOOEFEP BGILJIDNHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x10A78A0", Offset = "0x10A6CA0", VA = "0x1810A78A0")]
		get
		{
			return default(NCLIMOOEFEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6BD20A0", Offset = "0x6BD14A0", VA = "0x186BD20A0")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[NativeContainer]
[DefaultMember("Item")]
public struct FJFOCOJGBGK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum DJBPAACCMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		CollapseSubMeshes,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		CollapseToUniqueMaterials,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		MergeAll
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct NFCMKBHFEIB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[ReadOnly]
		public FJFOCOJGBGK FEFCBABPKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[ReadOnly]
		public int KLHINBCIKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NLOFJFKEJBJ LOLBNJKBNJM;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF2C0", Offset = "0x6BCE6C0", VA = "0x186BCF2C0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct CPFCIGHIPGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Vector3> EHINMBJMMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<Vector3> DODGALICCGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Vector4> DDDJGNNBNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<Vector2> LLIKJIGPMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<Vector2> NEFFHEBLAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<Vector2> MIEEJCBHGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<Vector2> KHLBAIPAJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<Color> IIHFJPIIPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeSlice<BoneWeight> AFEENDBIONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NativeSlice<Matrix4x4> LBJJPCLNOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public NativeSlice<int> JBAEOFBJGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NativeSlice<int> MPAPCCCLKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NativeSlice<int> JJMOCOONIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NativeSlice<int> HLKBEKACNKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeSlice<byte> DGOIMIMLMNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int KDODGLMDLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Matrix4x4 IAEGKMJLKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public bool PCILJCLCKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int JDONNFDPABN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<Vector3> EHINMBJMMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> NDEABCDDFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<Vector3> DODGALICCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<Vector4> DDDJGNNBNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<Vector2> LLIKJIGPMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<Vector2> NEFFHEBLAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<Vector2> MIEEJCBHGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<Vector2> KHLBAIPAJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<Color> IIHFJPIIPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<BoneWeight> AFEENDBIONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> HLKBEKACNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> COOKIPGINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> ECAMJMPJLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<Matrix4x4> LBJJPCLNOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> ODPMKPNFCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> JBAEOFBJGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> GILPKEELGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<Matrix4x4> AFCIADJPIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeArray<byte> ILKEGHBLFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> HKFKKCGOMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NativeArray<int> OJCAIPLLGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NativeArray<int> KIFFFDBOENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<sbyte> OOHJFGOFCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<int> HBGOPFPFOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<int> MPLBBFDBMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<byte> KLLEMEFBOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private NativeArray<int> BJHCIHPEPDE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OINJDMKENKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCAE0", Offset = "0x6BCBEE0", VA = "0x186BCCAE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBFC0", Offset = "0x6BCB3C0", VA = "0x186BCBFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EPHIKLOLJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBFD0", Offset = "0x6BCB3D0", VA = "0x186BCBFD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCAD0", Offset = "0x6BCBED0", VA = "0x186BCCAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NPHDNBKLJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCB00", Offset = "0x6BCBF00", VA = "0x186BCCB00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCAF0", Offset = "0x6BCBEF0", VA = "0x186BCCAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DJBPAACCMPJ OMGJOIPDMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBFE0", Offset = "0x6BCB3E0", VA = "0x186BCBFE0")]
		get
		{
			return default(DJBPAACCMPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBFF0", Offset = "0x6BCB3F0", VA = "0x186BCBFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private CPFCIGHIPGE ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BCC470", Offset = "0x6BCB870", VA = "0x186BCC470")]
		get
		{
			return default(CPFCIGHIPGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BCCB10", Offset = "0x6BCBF10", VA = "0x186BCCB10")]
	public FJFOCOJGBGK(IList<Mesh> LNBJKCOAOFA, IList<int> OHOBFALAEPN, IList<int> NEBEBJFJADJ, IList<int[]> ICEFBCPALPO, IList<Matrix4x4> FPFNLDEDEHP, IList<bool> ONOLIANKCPE, IList<int> HLKONJAGGHN, Allocator DGGNDNPDKKD, DJBPAACCMPJ MFJBPDDAHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC280", Offset = "0x6BCB680", VA = "0x186BCC280")]
	public NLOFJFKEJBJ EIEADPLBAPC(int HGHPGKOBMPJ, Allocator DGGNDNPDKKD)
	{
		return default(NLOFJFKEJBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC000", Offset = "0x6BCB400", VA = "0x186BCC000", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[NativeContainer]
public struct NLOFJFKEJBJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Vector3> EHINMBJMMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<Vector3> DODGALICCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Vector4> DDDJGNNBNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<Vector2> LLIKJIGPMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public NativeArray<Vector2> NEFFHEBLAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public NativeArray<Vector2> MIEEJCBHGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public NativeArray<Vector2> KHLBAIPAJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<Color> IIHFJPIIPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public NativeArray<BoneWeight> AFEENDBIONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<Matrix4x4> LBJJPCLNOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<int> JBAEOFBJGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<int> MPAPCCCLKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<int> JJMOCOONIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> BJHCIHPEPDE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int OHBCJOOMAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BD06D0", Offset = "0x6BCFAD0", VA = "0x186BD06D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0110", Offset = "0x6BCF510", VA = "0x186BD0110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BD06E0", Offset = "0x6BCFAE0", VA = "0x186BD06E0")]
	public NLOFJFKEJBJ(int PKKOAPIFEAO, int EDPMPKEEEKK, int CFENILLFEKN, int HGHPGKOBMPJ, Allocator DGGNDNPDKKD, bool[] BOCBHCGKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0330", Offset = "0x6BCF730", VA = "0x186BD0330")]
	public void HDJAIMFMMJL(int DEINOKCLPPI, int AEHKIMOEIJL, int HBBGBOONHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0050", Offset = "0x6BCF450", VA = "0x186BD0050")]
	public int[] ANEAKIADJDF(int DEINOKCLPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0120", Offset = "0x6BCF520", VA = "0x186BD0120")]
	private NativeSlice<int> DMOGIBIDPND(int DEINOKCLPPI)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BD01C0", Offset = "0x6BCF5C0", VA = "0x186BD01C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0420", Offset = "0x6BCF820", VA = "0x186BD0420")]
	public Mesh KHKNMEDPIEG([Optional] string DNCEAKGFDJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MBGIOOLODJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private List<Mesh> EIGIANLDEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private List<int> GCDBIDNKCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private List<bool> MMPOJBFFNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<int[]> DBLHOOECALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private List<Matrix4x4> MECDNANIFNO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEED0", Offset = "0x6BCE2D0", VA = "0x186BCEED0")]
	public void LPINKKFCGBK(Mesh CAFJEBPKAHB, int[] APIGIPMDIOJ, Matrix4x4 HJHMBNKGKCK, bool ONOLIANKCPE = false, int GNCOEBPDEDM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEC60", Offset = "0x6BCE060", VA = "0x186BCEC60")]
	public FJFOCOJGBGK IBJDKDMOLHK(Allocator DGGNDNPDKKD, FJFOCOJGBGK.DJBPAACCMPJ MFJBPDDAHPK, [Optional] IList<int> NEBEBJFJADJ, [Optional] IList<int> DLAOMOONGHK)
	{
		return default(FJFOCOJGBGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BCED90", Offset = "0x6BCE190", VA = "0x186BCED90")]
	private void IBNGMOGNLON(Mesh CAFJEBPKAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF130", Offset = "0x6BCE530", VA = "0x186BCF130")]
	public MBGIOOLODJP()
	{
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, HEEELEEOPIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[HideInInspector]
		[SerializeField]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int OOCDEDPIGHD;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6BCE650", Offset = "0x6BCDA50", VA = "0x186BCE650")]
		private void HGENMNCICCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6BCE7A0", Offset = "0x6BCDBA0", VA = "0x186BCE7A0")]
		private void LOKPBEOHPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6BCE8F0", Offset = "0x6BCDCF0", VA = "0x186BCE8F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6BCE880", Offset = "0x6BCDC80", VA = "0x186BCE880", Slot = "4")]
		public void PrepareImposter(LEHNJAODHGJ NPOLKGPPPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F19D10", Offset = "0x1F19110", VA = "0x181F19D10")]
		public InstanceColor()
		{
		}
	}
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Light BOAONJCGOCH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Light ELHPCBAEOII
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6BD2000", Offset = "0x6BD1400", VA = "0x186BD2000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1E80", Offset = "0x6BD1280", VA = "0x186BD1E80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1FB0", Offset = "0x6BD13B0", VA = "0x186BD1FB0")]
		public ParticleScriptedLight()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EMOLPDELFAF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HGBFPNMKJDE CFKNPOKPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HGBFPNMKJDE> LKLMEPIJMLH;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum HGBFPNMKJDE
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Count
}
namespace RecRoom.ProBuilder
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AddComponentMenu("")]
	public class AGProBuilderStub : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public AGProBuilderStub()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void AIHBOICGKCH(ParticleEventListener NLKFHPJEICP, Collider ICELKIGIKKP, IEnumerable<ParticleCollisionEvent> JNANBPIOACK);

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly List<ParticleCollisionEvent> EHGHBBMEANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		[ADFAGCEIIIB(BLGBJPBFLHB.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event AIHBOICGKCH HMJONKNJMAF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6BD0E90", Offset = "0x6BD0290", VA = "0x186BD0E90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6BD0F30", Offset = "0x6BD0330", VA = "0x186BD0F30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0AF0", Offset = "0x6BCFEF0", VA = "0x186BD0AF0")]
		private void OnParticleCollision(GameObject ICELKIGIKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public ParticleEventListener()
		{
		}
	}
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class ActivationController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum DMEEKPJJBDL
		{
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		[NJBIPLMLOIA("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected virtual DMEEKPJJBDL ONOBJGGJANC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "4")]
			get
			{
				return default(DMEEKPJJBDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xF164B0", Offset = "0xF158B0", VA = "0x180F164B0")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class ActivationController<T> : ActivationController where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		protected bool? BIPIKJHKJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		protected T ILOKJCGOEPB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool PADFFEIFDAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3878630", Offset = "0x3877A30", VA = "0x183878630", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x38782D0", Offset = "0x38776D0", VA = "0x1838782D0", Slot = "6")]
		public virtual void SetActivation(T FPDDNAEJDGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool NGJPAGBLCBD(T FPDDNAEJDGC);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void JFFMCLMDLNB(bool LGLHMGLGFIE);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x38785B0", Offset = "0x38779B0", VA = "0x1838785B0")]
		protected ActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface HDEIDGLNNMC
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color DEJOCIOKOBF);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private List<Material> OACPHELOMLG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BackgroundObject DACDLJEPMBI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9FE0", Offset = "0x6BC93E0", VA = "0x186BC9FE0")]
		public void Init(BackgroundObject OGOBDKNMJKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA290", Offset = "0x6BC9690", VA = "0x186BCA290")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA3B0", Offset = "0x6BC97B0", VA = "0x186BCA3B0")]
		public void SetBlendValue(float CEJLJIFJDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA500", Offset = "0x6BC9900", VA = "0x186BCA500")]
		public void SetColor(Color DEJOCIOKOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA610", Offset = "0x6BC9A10", VA = "0x186BCA610")]
		public void SetRotation(float OCEJJKMFIJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA7A0", Offset = "0x6BC9BA0", VA = "0x186BCA7A0")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum NCLIMOOEFEP
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	HEAD_AND_BODY
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6BD28F0", Offset = "0x6BD1CF0", VA = "0x186BD28F0")]
		public bool HOMIOKGCCKP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2A30", Offset = "0x6BD1E30", VA = "0x186BD2A30")]
		public StaticBatchMeshData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[NJBIPLMLOIA("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("If true, the StaticBatcher will not generate batches that only contain 1 Renderer. Disabling this can be useful for debugging why certain objects cannot batch. This setting does not affect LOD groups: batches of 1 LOD group are never created.")]
		public bool RemoveBatchesOfOneRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD28D0", Offset = "0x6BD1CD0", VA = "0x186BD28D0")]
		public StaticBatchManager()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD22E0", Offset = "0x6BD16E0", VA = "0x186BD22E0", Slot = "9")]
		protected override LightRenderingMode GCFIHCACGDI(IRecRoomQualityConfigProvider BNBFBKGLLNF)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2340", Offset = "0x6BD1740", VA = "0x186BD2340", Slot = "7")]
		protected override bool NGJPAGBLCBD(LightRenderingMode COCMKBFKKGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2350", Offset = "0x6BD1750", VA = "0x186BD2350")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2450", Offset = "0x6BD1850", VA = "0x186BD2450", Slot = "9")]
		protected override TransparencyDetailLevel GCFIHCACGDI(IRecRoomQualityConfigProvider BNBFBKGLLNF)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6BD24A0", Offset = "0x6BD18A0", VA = "0x186BD24A0", Slot = "7")]
		protected override bool NGJPAGBLCBD(TransparencyDetailLevel COCMKBFKKGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6BD24C0", Offset = "0x6BD18C0", VA = "0x186BD24C0")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2390", Offset = "0x6BD1790", VA = "0x186BD2390", Slot = "9")]
		protected override SceneDecorationDetailLevel GCFIHCACGDI(IRecRoomQualityConfigProvider BNBFBKGLLNF)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6BD23E0", Offset = "0x6BD17E0", VA = "0x186BD23E0", Slot = "7")]
		protected override bool NGJPAGBLCBD(SceneDecorationDetailLevel COCMKBFKKGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2400", Offset = "0x6BD1800", VA = "0x186BD2400")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private enum MFPKCDCGHMM
		{
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private MFPKCDCGHMM behavior;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2110", Offset = "0x6BD1510", VA = "0x186BD2110", Slot = "9")]
		protected override bool GCFIHCACGDI(IRecRoomQualityConfigProvider BNBFBKGLLNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2160", Offset = "0x6BD1560", VA = "0x186BD2160", Slot = "7")]
		protected override bool NGJPAGBLCBD(bool COCMKBFKKGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2180", Offset = "0x6BD1580", VA = "0x186BD2180")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private Terrain FNKOFIAABJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TerrainData BAHACHBMDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TerrainData HOAAAIMCKNA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Terrain PEHPEOCLNGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6BD2FB0", Offset = "0x6BD23B0", VA = "0x186BD2FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2BA0", Offset = "0x6BD1FA0", VA = "0x186BD2BA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3240", Offset = "0x6BD2640", VA = "0x186BD3240")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3160", Offset = "0x6BD2560", VA = "0x186BD3160")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3150", Offset = "0x6BD2550", VA = "0x186BD3150")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2F20", Offset = "0x6BD2320", VA = "0x186BD2F20")]
		private void HEGFLNOLMKM(HGBFPNMKJDE MGBAMDAPEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3390", Offset = "0x6BD2790", VA = "0x186BD3390", Slot = "6")]
		public override void SetActivation(TerrainQualityLevel PLCOAMGEKPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x98A150", Offset = "0x989550", VA = "0x18098A150", Slot = "7")]
		protected override bool NGJPAGBLCBD(TerrainQualityLevel FPDDNAEJDGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "8")]
		protected override void JFFMCLMDLNB(bool LGLHMGLGFIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6BD30D0", Offset = "0x6BD24D0", VA = "0x186BD30D0")]
		private void OBODIJFKAPJ(Settings KHIAIPDLLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2C40", Offset = "0x6BD2040", VA = "0x186BD2C40")]
		private void GIMEEFPLJJD(TreePrefabOverride[] CLODBNNBOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2AB0", Offset = "0x6BD1EB0", VA = "0x186BD2AB0")]
		private void AEJFEOEHNLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3050", Offset = "0x6BD2450", VA = "0x186BD3050")]
		private Settings MLGMKAJGLJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3560", Offset = "0x6BD2960", VA = "0x186BD3560")]
		public TerrainQualitySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private bool MPKLCKFMAAF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override DMEEKPJJBDL ONOBJGGJANC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8C05F0", Offset = "0x8BF9F0", VA = "0x1808C05F0", Slot = "4")]
			get
			{
				return default(DMEEKPJJBDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBD50", Offset = "0x6BCB150", VA = "0x186BCBD50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBBF0", Offset = "0x6BCAFF0", VA = "0x186BCBBF0")]
		private void ABPBCMGKLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBF50", Offset = "0x6BCB350", VA = "0x186BCBF50")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBE70", Offset = "0x6BCB270", VA = "0x186BCBE70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBD60", Offset = "0x6BCB160", VA = "0x186BCBD60")]
		private void CCMAGCPODEI(HGBFPNMKJDE MGBAMDAPEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBE60", Offset = "0x6BCB260", VA = "0x186BCBE60", Slot = "7")]
		protected override bool NGJPAGBLCBD(bool COCMKBFKKGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBDF0", Offset = "0x6BCB1F0", VA = "0x186BCBDF0", Slot = "8")]
		protected override void JFFMCLMDLNB(bool LGLHMGLGFIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBF80", Offset = "0x6BCB380", VA = "0x186BCBF80")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2630", Offset = "0x6BD1A30", VA = "0x186BD2630", Slot = "7")]
		protected override bool NGJPAGBLCBD(BackgroundAnimationDetailLevel FPDDNAEJDGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6BD25A0", Offset = "0x6BD19A0", VA = "0x186BD25A0", Slot = "8")]
		protected override void JFFMCLMDLNB(bool BHEFCHPMIBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2510", Offset = "0x6BD1910", VA = "0x186BD2510")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6BD26D0", Offset = "0x6BD1AD0", VA = "0x186BD26D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2760", Offset = "0x6BD1B60", VA = "0x186BD2760")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x136980", Offset = "0x135D80")]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		[ADFAGCEIIIB(BLGBJPBFLHB.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private bool BCHCJKHDKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int AGKNPBAGHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private bool LLECGPLJACM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool CJJIICFELCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private float LAEDCFKPFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private float OCFJEOGKHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float KMLNDMNEJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float JPODICCGPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private float GEICEDPIDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private float EILEHGPFMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private ParticleSystem.MainModule JOENNMFBMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private ParticleSystem.TrailModule CHGKCDEGEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private ParticleSystem.EmissionModule BLOMLMLOINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private ParticleSystem.CollisionModule GLFDJBBPOGO;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1CF0", Offset = "0x6BD10F0", VA = "0x186BD1CF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1C10", Offset = "0x6BD1010", VA = "0x186BD1C10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0FD0", Offset = "0x6BD03D0", VA = "0x186BD0FD0")]
		private void CCMAGCPODEI(HGBFPNMKJDE MGBAMDAPEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6BD12C0", Offset = "0x6BD06C0", VA = "0x186BD12C0")]
		private void LHEDHMECLPB(IRecRoomQualityConfigProvider PPCPEOGMHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1650", Offset = "0x6BD0A50", VA = "0x186BD1650")]
		private void LPPHPDKNLMJ(OverrideSettings EFJHECNOFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD18A0", Offset = "0x6BD0CA0", VA = "0x186BD18A0")]
		private void MNIDDNGEJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1A50", Offset = "0x6BD0E50", VA = "0x186BD1A50")]
		private void ODMIGMJKBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1030", Offset = "0x6BD0430", VA = "0x186BD1030")]
		private void DEFNCHFHFLD(ParticleSystem.MinMaxCurve FJIMEGNIPGI, out float IJBJCAFANKB, out float AMGADMFJPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1170", Offset = "0x6BD0570", VA = "0x186BD1170")]
		private ParticleSystem.MinMaxCurve KFCBPAEBGBB(ParticleSystem.MinMaxCurve FJIMEGNIPGI, float IJBJCAFANKB, float AMGADMFJPLI)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override DMEEKPJJBDL ONOBJGGJANC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8C05F0", Offset = "0x8BF9F0", VA = "0x1808C05F0", Slot = "4")]
			get
			{
				return default(DMEEKPJJBDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract T GCFIHCACGDI(IRecRoomQualityConfigProvider BNBFBKGLLNF);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x57E07C0", Offset = "0x57DFBC0", VA = "0x1857E07C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x57E0CB0", Offset = "0x57E00B0", VA = "0x1857E0CB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x57E0AC0", Offset = "0x57DFEC0", VA = "0x1857E0AC0")]
		private void CCMAGCPODEI(HGBFPNMKJDE MGBAMDAPEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x57E0B70", Offset = "0x57DFF70", VA = "0x1857E0B70")]
		private void GEMFPIMCJIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x57E0C70", Offset = "0x57E0070", VA = "0x1857E0C70", Slot = "8")]
		protected override void JFFMCLMDLNB(bool LGLHMGLGFIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1D32680", Offset = "0x1D31A80", VA = "0x181D32680")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private enum FIAJDPHNFJB
		{
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private FIAJDPHNFJB behavior;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2250", Offset = "0x6BD1650", VA = "0x186BD2250", Slot = "9")]
		protected override bool GCFIHCACGDI(IRecRoomQualityConfigProvider BNBFBKGLLNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2160", Offset = "0x6BD1560", VA = "0x186BD2160", Slot = "7")]
		protected override bool NGJPAGBLCBD(bool COCMKBFKKGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD22A0", Offset = "0x6BD16A0", VA = "0x186BD22A0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class DBAHGHGDGEM
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBB00", Offset = "0x6BCAF00", VA = "0x186BCBB00")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.None)]
	private static void JOJBKOBJJHB(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private enum IAFOPOJPBLE
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private IAFOPOJPBLE behavior;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD21C0", Offset = "0x6BD15C0", VA = "0x186BD21C0", Slot = "9")]
		protected override bool GCFIHCACGDI(IRecRoomQualityConfigProvider BNBFBKGLLNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2160", Offset = "0x6BD1560", VA = "0x186BD2160", Slot = "7")]
		protected override bool NGJPAGBLCBD(bool COCMKBFKKGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2210", Offset = "0x6BD1610", VA = "0x186BD2210")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
}
namespace RecRoom.CullableBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[UnityEngine.Scripting.Preserve]
	public class CullableBatchLOD : MonoBehaviour, EGLIMKJGMKP
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public class BatchedRenderer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Renderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public bool visibleInBatch;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public bool Enabled
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x6BCA820", Offset = "0x6BC9C20", VA = "0x186BCA820")]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public BatchedRenderer[] revealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public LODGroup[] revealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public BatchedRenderer[] nonRevealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public LODGroup[] nonRevealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		public int subMeshCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		public int startRenderableSubmshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private FGLEPFCKOAH toggleBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private Bounds CHMGFONJEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Material NKAMKIHOODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private IKOPLHJLDJI<CullableBatchLOD> BBMDLCNKBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private Mesh CAFJEBPKAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool IDPPOIFLGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool GAKOBOKEGNB;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6BCAD70", Offset = "0x6BCA170", VA = "0x186BCAD70")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB290", Offset = "0x6BCA690", VA = "0x186BCB290")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5C58A20", Offset = "0x5C57E20", VA = "0x185C58A20")]
		private static float PJNOHIGJKKI(Vector3 DAOCAJOLDPP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6BCACD0", Offset = "0x6BCA0D0", VA = "0x186BCACD0")]
		public void SetContentsVisibility(bool BBLOKLBNBHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6BCABE0", Offset = "0x6BC9FE0", VA = "0x186BCABE0", Slot = "5")]
		public void OnChangedDistanceBand(FGLEPFCKOAH MKCCIDALIGJ, FGLEPFCKOAH JGAEINHKEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "6")]
		public void OnChangedVisibility(bool OAFKEEFNLAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BCAC20", Offset = "0x6BCA020", VA = "0x186BCAC20")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB530", Offset = "0x6BCA930", VA = "0x186BCB530")]
		public CullableBatchLOD()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xBB2B00", Offset = "0xBB1F00", VA = "0x180BB2B00", Slot = "4")]
		private Transform PPKCHOCBKDO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchLODMaterialData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Vector4[] baseColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Vector4[] specColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Vector4[] emissionColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Vector4[] halfProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Vector4[] secondaryTextureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[FormerlySerializedAs("renderer")]
		public MeshRenderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public CullableBatchLODMaterialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[RecRoom.NoEngine.Common.Preserve]
	[ExecuteInEditMode]
	public class RunTimeTextureAtlasData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6BD20B0", Offset = "0x6BD14B0", VA = "0x186BD20B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6BD20B0", Offset = "0x6BD14B0", VA = "0x186BD20B0")]
		private void MHJBECGDMOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public RunTimeTextureAtlasData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RecRoom.NoEngine.Common.Preserve]
	[ExecuteInEditMode]
	public class CullableBatchShaderManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB550", Offset = "0x6BCA950", VA = "0x186BCB550")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public CullableBatchShaderManager()
		{
		}
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
