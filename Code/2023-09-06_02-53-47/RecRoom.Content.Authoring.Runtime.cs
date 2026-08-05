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
	[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9F7000", Offset = "0x9F5600", VA = "0x1809F7000")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum KADJJOLDPPE
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
	private KADJJOLDPPE bobAxis;

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
	private float PKBKKICJDLI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 HEHEIEPCPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69CF920", Offset = "0x69CDF20", VA = "0x1869CF920")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x19D1CB0", Offset = "0x19D02B0", VA = "0x1819D1CB0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69CFA90", Offset = "0x69CE090", VA = "0x1869CFA90")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69CFC90", Offset = "0x69CE290", VA = "0x1869CFC90")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, OJJJLFFCFPL
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string MECBEGDGNCP = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string ANDGHGLJAKN = "_MainColor";

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
	private static List<Material> ECIKKJELEGN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> KDCKNILCCAD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	public void PrepareImposter(FPGBCAIOHNO FKGPFMNALNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69D2160", Offset = "0x69D0760", VA = "0x1869D2160")]
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
	[Cpp2IlInjected.Address(RVA = "0x69D25D0", Offset = "0x69D0BD0", VA = "0x1869D25D0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69D2670", Offset = "0x69D0C70", VA = "0x1869D2670")]
	public void initialize(Mesh DNIMBFHINHA, Material AGGGHPBAMKH, Matrix4x4[] HNKICBBHIBC, Component[] JPBMDKJCDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
	[Cpp2IlInjected.Address(RVA = "0x69D71C0", Offset = "0x69D57C0", VA = "0x1869D71C0")]
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
	public bool NNMBLDACHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69D7870", Offset = "0x69D5E70", VA = "0x1869D7870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
	private GNBBFEAEOHF playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GNBBFEAEOHF FBLINOMKPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE49710", Offset = "0xE47D10", VA = "0x180E49710")]
		get
		{
			return default(GNBBFEAEOHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69D7170", Offset = "0x69D5770", VA = "0x1869D7170")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[NativeContainer]
[DefaultMember("Item")]
public struct LNFHFLIDKIN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum HGAGMCGGIEG
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
	public struct NLJOMINMIIG : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[ReadOnly]
		public LNFHFLIDKIN DDDNHNOILAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[ReadOnly]
		public int HIBGEANHGPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CDCDHHECJME MNIFPBMFHFN;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69D4E30", Offset = "0x69D3430", VA = "0x1869D4E30", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct CGMNHEADOGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Vector3> HLAEBELMOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<Vector3> NDCPKLEAPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Vector4> AEJLGDFFFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<Vector2> APNDJCNLGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<Vector2> JBGDNAEKKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<Vector2> DHCJEJLOPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<Vector2> DCHKHAOEHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<Color> LGFGAMGPOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeSlice<BoneWeight> BHNGEEIDGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NativeSlice<Matrix4x4> CDMKCACKHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public NativeSlice<int> NOIFOCJGJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NativeSlice<int> OOPIMOBHALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NativeSlice<int> CCKEABMHAND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NativeSlice<int> ENGEPINKHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeSlice<byte> IHFFFFCKLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int MJNHAKAGAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Matrix4x4 HHGKANAJAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public bool LHDHIBHGFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int GBJBCBKEJIH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<Vector3> HLAEBELMOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> NGPLGJHDCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<Vector3> NDCPKLEAPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<Vector4> AEJLGDFFFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<Vector2> APNDJCNLGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<Vector2> JBGDNAEKKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<Vector2> DHCJEJLOPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<Vector2> DCHKHAOEHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<Color> LGFGAMGPOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<BoneWeight> BHNGEEIDGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> ENGEPINKHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> LLAAIBLNAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> HMCJGIKHNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<Matrix4x4> CDMKCACKHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> HNLBADBCFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> NOIFOCJGJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> GNNHFGGFHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<Matrix4x4> CBLLMNEJFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeArray<byte> HJHEMIICNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> NNKFMANBPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NativeArray<int> NDIEGGAMEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NativeArray<int> OJJOBELGDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<sbyte> CIJHDGHPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<int> FBPLDPKFFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<int> PAPAIIGLHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<byte> BFLMCACCOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private NativeArray<int> ICBPMNNIBIB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IIOEECODAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69D3420", Offset = "0x69D1A20", VA = "0x1869D3420")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69D28F0", Offset = "0x69D0EF0", VA = "0x1869D28F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HCPKHGCLDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69D3400", Offset = "0x69D1A00", VA = "0x1869D3400")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69D31E0", Offset = "0x69D17E0", VA = "0x1869D31E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JAKFGEGPFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69D28E0", Offset = "0x69D0EE0", VA = "0x1869D28E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69D33E0", Offset = "0x69D19E0", VA = "0x1869D33E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HGAGMCGGIEG NMPNKHBMCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69D3410", Offset = "0x69D1A10", VA = "0x1869D3410")]
		get
		{
			return default(HGAGMCGGIEG);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69D33F0", Offset = "0x69D19F0", VA = "0x1869D33F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private CGMNHEADOGF ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69D2B80", Offset = "0x69D1180", VA = "0x1869D2B80")]
		get
		{
			return default(CGMNHEADOGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69D3430", Offset = "0x69D1A30", VA = "0x1869D3430")]
	public LNFHFLIDKIN(IList<Mesh> CKAHEPONKJO, IList<int> MKMAKBONGCC, IList<int> BAMFEIMFLHN, IList<int[]> FNCAKDMEFMJ, IList<Matrix4x4> HPLKICKGMFD, IList<bool> LNIJDLEOCPA, IList<int> MLBNHCFEHMP, Allocator HINEEPDGLPG, HGAGMCGGIEG NCLEADMBCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69D31F0", Offset = "0x69D17F0", VA = "0x1869D31F0")]
	public CDCDHHECJME IKECAKKNKDL(int KAEOJEIGPOO, Allocator HINEEPDGLPG)
	{
		return default(CDCDHHECJME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69D2900", Offset = "0x69D0F00", VA = "0x1869D2900", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[NativeContainer]
public struct CDCDHHECJME : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Vector3> HLAEBELMOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<Vector3> NDCPKLEAPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Vector4> AEJLGDFFFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<Vector2> APNDJCNLGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public NativeArray<Vector2> JBGDNAEKKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public NativeArray<Vector2> DHCJEJLOPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public NativeArray<Vector2> DCHKHAOEHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<Color> LGFGAMGPOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public NativeArray<BoneWeight> BHNGEEIDGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<Matrix4x4> CDMKCACKHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<int> NOIFOCJGJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<int> OOPIMOBHALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<int> CCKEABMHAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> ICBPMNNIBIB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int KAGDBICGBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69D0240", Offset = "0x69CE840", VA = "0x1869D0240")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69CFD50", Offset = "0x69CE350", VA = "0x1869CFD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69D0340", Offset = "0x69CE940", VA = "0x1869D0340")]
	public CDCDHHECJME(int ODCIDFHKBDG, int CIFCCNFHDEO, int FMHJLBPIJGD, int KAEOJEIGPOO, Allocator HINEEPDGLPG, bool[] NOPJDODLEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69D0250", Offset = "0x69CE850", VA = "0x1869D0250")]
	public void MOAJKKPFFKO(int AMAFFMOMPID, int EBMCNIDEEKK, int BFDDLCIBNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69CFED0", Offset = "0x69CE4D0", VA = "0x1869CFED0")]
	public int[] FPCOEOCKGED(int AMAFFMOMPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69CFCB0", Offset = "0x69CE2B0", VA = "0x1869CFCB0")]
	private NativeSlice<int> CEFFFIPBBHG(int AMAFFMOMPID)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69CFD60", Offset = "0x69CE360", VA = "0x1869CFD60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69CFF90", Offset = "0x69CE590", VA = "0x1869CFF90")]
	public Mesh GLAJOFJJLNG([Optional] string OEPAOIJJDNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HOIOJFIIKNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private List<Mesh> BGIAJLNJGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private List<int> CBJJGHLBDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private List<bool> CDBADFPBPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<int[]> HNEBPKIHCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private List<Matrix4x4> BJMKCMGEPOD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69D1CB0", Offset = "0x69D02B0", VA = "0x1869D1CB0")]
	public void LIFIADDDDMG(Mesh GKJMNHLJMAJ, int[] CMECDBFMHPP, Matrix4x4 FIIJPMEBGMM, bool LNIJDLEOCPA = false, int IMOKBDDENGN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69D1B80", Offset = "0x69D0180", VA = "0x1869D1B80")]
	public LNFHFLIDKIN HCBKOPOOIEK(Allocator HINEEPDGLPG, LNFHFLIDKIN.HGAGMCGGIEG NCLEADMBCJL, [Optional] IList<int> BAMFEIMFLHN, [Optional] IList<int> NKKBCBEKLIF)
	{
		return default(LNFHFLIDKIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69D1A40", Offset = "0x69D0040", VA = "0x1869D1A40")]
	private void GPJDOKPHJHE(Mesh GKJMNHLJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69D1F10", Offset = "0x69D0510", VA = "0x1869D1F10")]
	public HOIOJFIIKNO()
	{
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, OJJJLFFCFPL
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
		private static readonly int NJCGHJGHPOE;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69D21E0", Offset = "0x69D07E0", VA = "0x1869D21E0")]
		private void FBCGGPPNCPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69D2330", Offset = "0x69D0930", VA = "0x1869D2330")]
		private void PJOOFLNDDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x69D2480", Offset = "0x69D0A80", VA = "0x1869D2480")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69D2410", Offset = "0x69D0A10", VA = "0x1869D2410", Slot = "4")]
		public void PrepareImposter(FPGBCAIOHNO FKGPFMNALNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F2C920", Offset = "0x1F2AF20", VA = "0x181F2C920")]
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
		private Light HJDGNMNPAIE;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Light PENJPNLGAGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x69D70D0", Offset = "0x69D56D0", VA = "0x1869D70D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69D6F50", Offset = "0x69D5550", VA = "0x1869D6F50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69D7080", Offset = "0x69D5680", VA = "0x1869D7080")]
		public ParticleScriptedLight()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GBINNPBHLEL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OKHJBFNGEPO KLLOONFEBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OKHJBFNGEPO> EGLABCOHLGI;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum OKHJBFNGEPO
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
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
		public delegate void EFDPGEEPNEA(ParticleEventListener OLNCGAFBPGP, Collider FKJGPCABBJN, IEnumerable<ParticleCollisionEvent> BLBOIJKHOMK);

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly List<ParticleCollisionEvent> GEKFNNAOAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		[GBPFONMOEMB(JHNBNMNOADF.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EFDPGEEPNEA JHCIFEMOMLE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x69D5F60", Offset = "0x69D4560", VA = "0x1869D5F60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x69D6000", Offset = "0x69D4600", VA = "0x1869D6000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x69D5BC0", Offset = "0x69D41C0", VA = "0x1869D5BC0")]
		private void OnParticleCollision(GameObject FKJGPCABBJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
		public enum DHMBJABLFMA
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
		[JMHBNGAJCDE("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected virtual DHMBJABLFMA MGFMFODHEMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "4")]
			get
			{
				return default(DHMBJABLFMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x11BD860", Offset = "0x11BBE60", VA = "0x1811BD860")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class ActivationController<T> : ActivationController where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		protected bool? KBDNFHONFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		protected T CGNCKGDFGAE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool AFJDJFHNHMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3CA3890", Offset = "0x3CA1E90", VA = "0x183CA3890", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3530", Offset = "0x3CA1B30", VA = "0x183CA3530", Slot = "6")]
		public virtual void SetActivation(T HLFKJGHALEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool JLLJNPGKJDK(T HLFKJGHALEB);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void FAAPMCFKNMM(bool OBDPEKMNEOL);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3810", Offset = "0x3CA1E10", VA = "0x183CA3810")]
		protected ActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface EGFALKPCGHB
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color CMDNLIJPJJE);
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
		private List<Material> OPLKFIMFFJP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BackgroundObject NDIOFBFLBNN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x69CF0B0", Offset = "0x69CD6B0", VA = "0x1869CF0B0")]
		public void Init(BackgroundObject LMLNLGDAFGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x69CF360", Offset = "0x69CD960", VA = "0x1869CF360")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69CF480", Offset = "0x69CDA80", VA = "0x1869CF480")]
		public void SetBlendValue(float NHFENOICBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69CF5D0", Offset = "0x69CDBD0", VA = "0x1869CF5D0")]
		public void SetColor(Color CMDNLIJPJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x69CF6E0", Offset = "0x69CDCE0", VA = "0x1869CF6E0")]
		public void SetRotation(float MEHKCJCIOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69CF870", Offset = "0x69CDE70", VA = "0x1869CF870")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum GNBBFEAEOHF
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
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D79C0", Offset = "0x69D5FC0", VA = "0x1869D79C0")]
		public bool IAIGAFFHIIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69D7B00", Offset = "0x69D6100", VA = "0x1869D7B00")]
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
		[JMHBNGAJCDE("UseSpacePartition")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D79A0", Offset = "0x69D5FA0", VA = "0x1869D79A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D73B0", Offset = "0x69D59B0", VA = "0x1869D73B0", Slot = "9")]
		protected override LightRenderingMode JHNBBEPMECO(IRecRoomQualityConfigProvider HINHIGGCLIA)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x69D7410", Offset = "0x69D5A10", VA = "0x1869D7410", Slot = "7")]
		protected override bool JLLJNPGKJDK(LightRenderingMode OGEBFBENJEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x69D7420", Offset = "0x69D5A20", VA = "0x1869D7420")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D7520", Offset = "0x69D5B20", VA = "0x1869D7520", Slot = "9")]
		protected override TransparencyDetailLevel JHNBBEPMECO(IRecRoomQualityConfigProvider HINHIGGCLIA)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69D7570", Offset = "0x69D5B70", VA = "0x1869D7570", Slot = "7")]
		protected override bool JLLJNPGKJDK(TransparencyDetailLevel OGEBFBENJEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69D7590", Offset = "0x69D5B90", VA = "0x1869D7590")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D7460", Offset = "0x69D5A60", VA = "0x1869D7460", Slot = "9")]
		protected override SceneDecorationDetailLevel JHNBBEPMECO(IRecRoomQualityConfigProvider HINHIGGCLIA)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69D74B0", Offset = "0x69D5AB0", VA = "0x1869D74B0", Slot = "7")]
		protected override bool JLLJNPGKJDK(SceneDecorationDetailLevel OGEBFBENJEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69D74D0", Offset = "0x69D5AD0", VA = "0x1869D74D0")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private enum AJONONDPKEC
		{
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private AJONONDPKEC behavior;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69D71E0", Offset = "0x69D57E0", VA = "0x1869D71E0", Slot = "9")]
		protected override bool JHNBBEPMECO(IRecRoomQualityConfigProvider HINHIGGCLIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69D7230", Offset = "0x69D5830", VA = "0x1869D7230", Slot = "7")]
		protected override bool JLLJNPGKJDK(bool OGEBFBENJEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69D7250", Offset = "0x69D5850", VA = "0x1869D7250")]
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
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
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
		private Terrain BELKKEMJFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TerrainData AHLFIEGHFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TerrainData KEEBJMONBFH;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Terrain FEFHNNJNGFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x69D8090", Offset = "0x69D6690", VA = "0x1869D8090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69D7C10", Offset = "0x69D6210", VA = "0x1869D7C10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69D8220", Offset = "0x69D6820", VA = "0x1869D8220")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69D8140", Offset = "0x69D6740", VA = "0x1869D8140")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69D8130", Offset = "0x69D6730", VA = "0x1869D8130")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69D7B80", Offset = "0x69D6180", VA = "0x1869D7B80")]
		private void ALMALFFDKMK(OKHJBFNGEPO EIJMADLIEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x69D8460", Offset = "0x69D6A60", VA = "0x1869D8460", Slot = "6")]
		public override void SetActivation(TerrainQualityLevel HKEFGMHFOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x91EA10", Offset = "0x91D010", VA = "0x18091EA10", Slot = "7")]
		protected override bool JLLJNPGKJDK(TerrainQualityLevel HLFKJGHALEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
		protected override void FAAPMCFKNMM(bool OBDPEKMNEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D30", Offset = "0x69D6330", VA = "0x1869D7D30")]
		private void HOKPLCMEAEC(Settings FGIOGJGPMCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69D7DB0", Offset = "0x69D63B0", VA = "0x1869D7DB0")]
		private void LMBDMJLMGHF(TreePrefabOverride[] DNMLPEGBNIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69D8370", Offset = "0x69D6970", VA = "0x1869D8370")]
		private void PNIIPKGICMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x69D7CB0", Offset = "0x69D62B0", VA = "0x1869D7CB0")]
		private Settings GJGBIFDIDAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69D8630", Offset = "0x69D6C30", VA = "0x1869D8630")]
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
		private bool GLECDIBBKJJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override DHMBJABLFMA MGFMFODHEMO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8C58E0", Offset = "0x8C3EE0", VA = "0x1808C58E0", Slot = "4")]
			get
			{
				return default(DHMBJABLFMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69D1670", Offset = "0x69CFC70", VA = "0x1869D1670")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69D1790", Offset = "0x69CFD90", VA = "0x1869D1790")]
		private void OPLLMMFCGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69D19D0", Offset = "0x69CFFD0", VA = "0x1869D19D0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69D18F0", Offset = "0x69CFEF0", VA = "0x1869D18F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69D1700", Offset = "0x69CFD00", VA = "0x1869D1700")]
		private void ODILGFLAODK(OKHJBFNGEPO EIJMADLIEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69D16F0", Offset = "0x69CFCF0", VA = "0x1869D16F0", Slot = "7")]
		protected override bool JLLJNPGKJDK(bool OGEBFBENJEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69D1680", Offset = "0x69CFC80", VA = "0x1869D1680", Slot = "8")]
		protected override void FAAPMCFKNMM(bool OBDPEKMNEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69D1A00", Offset = "0x69D0000", VA = "0x1869D1A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D7700", Offset = "0x69D5D00", VA = "0x1869D7700", Slot = "7")]
		protected override bool JLLJNPGKJDK(BackgroundAnimationDetailLevel HLFKJGHALEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69D7670", Offset = "0x69D5C70", VA = "0x1869D7670", Slot = "8")]
		protected override void FAAPMCFKNMM(bool OLELHLONAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69D75E0", Offset = "0x69D5BE0", VA = "0x1869D75E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x69D77A0", Offset = "0x69D5DA0", VA = "0x1869D77A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69D7830", Offset = "0x69D5E30", VA = "0x1869D7830")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x12EFE0", Offset = "0x12E3E0")]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		[GBPFONMOEMB(JHNBNMNOADF.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private bool ODGNCFLNFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int KBMDOEHMFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private bool AJPGNJOKEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool LNFLIKILNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private float EDNMKPOANOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private float GKBIFBKMEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float KGLKHBHHECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float BOMMGCAPEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private float CINDFEABPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private float MINJLFIKAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private ParticleSystem.MainModule KOPOOMFFKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private ParticleSystem.TrailModule KHANFPIHKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private ParticleSystem.EmissionModule CCOEIFBKNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private ParticleSystem.CollisionModule OBLDNGCJOGA;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69D6DC0", Offset = "0x69D53C0", VA = "0x1869D6DC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x69D6B90", Offset = "0x69D5190", VA = "0x1869D6B90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x69D6B30", Offset = "0x69D5130", VA = "0x1869D6B30")]
		private void ODILGFLAODK(OKHJBFNGEPO EIJMADLIEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69D6660", Offset = "0x69D4C60", VA = "0x1869D6660")]
		private void IIIAJJIBFHN(IRecRoomQualityConfigProvider GCGOLIKBAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69D6410", Offset = "0x69D4A10", VA = "0x1869D6410")]
		private void DGPLGHELNHD(OverrideSettings NPCKCMGLKGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69D60A0", Offset = "0x69D46A0", VA = "0x1869D60A0")]
		private void CKMFDELCIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69D6250", Offset = "0x69D4850", VA = "0x1869D6250")]
		private void CNKMJMCHJEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x69D69F0", Offset = "0x69D4FF0", VA = "0x1869D69F0")]
		private void JHHBGDPBLKF(ParticleSystem.MinMaxCurve EHPBOKCPMLG, out float FEAPAPBBAFD, out float MODOAKNPMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x69D6C70", Offset = "0x69D5270", VA = "0x1869D6C70")]
		private ParticleSystem.MinMaxCurve PJJMEKODEPL(ParticleSystem.MinMaxCurve EHPBOKCPMLG, float FEAPAPBBAFD, float MODOAKNPMEE)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override DHMBJABLFMA MGFMFODHEMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8C58E0", Offset = "0x8C3EE0", VA = "0x1808C58E0", Slot = "4")]
			get
			{
				return default(DHMBJABLFMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract T JHNBBEPMECO(IRecRoomQualityConfigProvider HINHIGGCLIA);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x59C4CC0", Offset = "0x59C32C0", VA = "0x1859C4CC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x59C51B0", Offset = "0x59C37B0", VA = "0x1859C51B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x59C5000", Offset = "0x59C3600", VA = "0x1859C5000")]
		private void ODILGFLAODK(OKHJBFNGEPO EIJMADLIEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x59C50B0", Offset = "0x59C36B0", VA = "0x1859C50B0")]
		private void OJAEIMBKLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x59C4FC0", Offset = "0x59C35C0", VA = "0x1859C4FC0", Slot = "8")]
		protected override void FAAPMCFKNMM(bool OBDPEKMNEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x18C5720", Offset = "0x18C3D20", VA = "0x1818C5720")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private enum BCODLFIPMOG
		{
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private BCODLFIPMOG behavior;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69D7320", Offset = "0x69D5920", VA = "0x1869D7320", Slot = "9")]
		protected override bool JHNBBEPMECO(IRecRoomQualityConfigProvider HINHIGGCLIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69D7230", Offset = "0x69D5830", VA = "0x1869D7230", Slot = "7")]
		protected override bool JLLJNPGKJDK(bool OGEBFBENJEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69D7370", Offset = "0x69D5970", VA = "0x1869D7370")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class JFCOHDBOEOG
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x69D27F0", Offset = "0x69D0DF0", VA = "0x1869D27F0")]
	[HFALCAKMDCP(BFPOMPMIJIJ.None)]
	private static void KDCCKDGHAKL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private enum PKCNJFBHBMO
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private PKCNJFBHBMO behavior;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x69D7290", Offset = "0x69D5890", VA = "0x1869D7290", Slot = "9")]
		protected override bool JHNBBEPMECO(IRecRoomQualityConfigProvider HINHIGGCLIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x69D7230", Offset = "0x69D5830", VA = "0x1869D7230", Slot = "7")]
		protected override bool JLLJNPGKJDK(bool OGEBFBENJEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69D72E0", Offset = "0x69D58E0", VA = "0x1869D72E0")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
}
namespace RecRoom.CullableBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[UnityEngine.Scripting.Preserve]
	public class CullableBatchLOD : MonoBehaviour, GBKLBEOOIJI
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
				[Cpp2IlInjected.Address(RVA = "0x69CF8F0", Offset = "0x69CDEF0", VA = "0x1869CF8F0")]
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
		private DBOALJMGPFL toggleBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private Bounds IKBGILGFONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Material FMBPBGHJJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private GMKJDBIOCHA<CullableBatchLOD> KEJDPMGJDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private Mesh GKJMNHLJMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool LDMNPPJDCKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool MDGGFLJKODJ;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x69D08E0", Offset = "0x69CEEE0", VA = "0x1869D08E0")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69D0E00", Offset = "0x69CF400", VA = "0x1869D0E00")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x56499F0", Offset = "0x5647FF0", VA = "0x1856499F0")]
		private static float GGKPPGENLJD(Vector3 AMIFPEMLHDF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69D0840", Offset = "0x69CEE40", VA = "0x1869D0840")]
		public void SetContentsVisibility(bool JNNBGOIBEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69D0750", Offset = "0x69CED50", VA = "0x1869D0750", Slot = "5")]
		public void OnChangedDistanceBand(DBOALJMGPFL PPJEODAFBKD, DBOALJMGPFL FFAOKGEEGLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "6")]
		public void OnChangedVisibility(bool NEDCLNHOJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69D0790", Offset = "0x69CED90", VA = "0x1869D0790")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69D10A0", Offset = "0x69CF6A0", VA = "0x1869D10A0")]
		public CullableBatchLOD()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xBD8590", Offset = "0xBD6B90", VA = "0x180BD8590", Slot = "4")]
		private Transform KNFHECJCGDP()
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
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D7180", Offset = "0x69D5780", VA = "0x1869D7180")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69D7180", Offset = "0x69D5780", VA = "0x1869D7180")]
		private void BLCBJBEAFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D10C0", Offset = "0x69CF6C0", VA = "0x1869D10C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
