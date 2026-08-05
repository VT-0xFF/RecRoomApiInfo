using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Platforms;
using RecRoom.DataLayer.Attributes;
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
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum INHPPEFNFHM
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
	private INHPPEFNFHM bobAxis;

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
	private float LKMDNACICPF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 BBMMPOMDEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2E00", Offset = "0x6AE1800", VA = "0x186AE2E00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2DC0", Offset = "0x6AE17C0", VA = "0x186AE2DC0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2FE0", Offset = "0x6AE19E0", VA = "0x186AE2FE0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3210", Offset = "0x6AE1C10", VA = "0x186AE3210")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD0E430", Offset = "0xD0CE30", VA = "0x180D0E430")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, AEEBIDPALBN
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string GEJIJGDODED = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string KFCPHBJGCBE = "_MainColor";

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
	private static List<Material> JJJJJFJMBHB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> KDGOAIBKDLE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void PrepareImposter(GNNJABNPOOC LFOFLLOHBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AE68B0", Offset = "0x6AE52B0", VA = "0x186AE68B0")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
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

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6D00", Offset = "0x6AE5700", VA = "0x186AE6D00")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6DA0", Offset = "0x6AE57A0", VA = "0x186AE6DA0")]
	public void initialize(Mesh JGHAKHECPKB, Material PINPLNHFGMG, Matrix4x4[] PNAODHBADGI, Component[] ELEHJOEMAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	public InstancedMeshGroup()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
[NativeContainer]
public struct FELLELPOPCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum CBJEGMGIABC
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		CollapseSubMeshes,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		CollapseToUniqueMaterials,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		MergeAll
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct MPBAAIICKEF : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[ReadOnly]
		public FELLELPOPCI KNAEDMKHOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[ReadOnly]
		public int OHMCPIDNGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public ADADBIKFKIG MMNNMJNHFOA;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7690", Offset = "0x6AE6090", VA = "0x186AE7690", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct ALBJMEJFCCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeSlice<Vector3> NOHDOPIDDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NativeSlice<Vector3> PPFPMPHOIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector4> NNLIGJLJJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector2> ODOCABHGPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector2> IFCJACHHENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> JPHNBCGOOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> JEOODCDIBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Color> BOPGACMAPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<BoneWeight> MPPBPLGOPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Matrix4x4> BPLLIOOODIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<int> MDHOPKHDPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<int> EEFBBDFOLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> KLDLOFLACJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> HEAHBIMCLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<byte> DHLLIINDLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int PJIHHKDHNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Matrix4x4 GKPNJMEJDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool HEBPOBEOIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int DOEKDDJMFAJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> NOHDOPIDDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<int> DPKHDMNCAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector3> PPFPMPHOIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector4> NNLIGJLJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> ODOCABHGPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> IFCJACHHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Vector2> JPHNBCGOOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector2> JEOODCDIBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<Color> BOPGACMAPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<BoneWeight> MPPBPLGOPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> HEAHBIMCLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> CHNGEIDPMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> MHCCMBPNLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<Matrix4x4> BPLLIOOODIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> EBINGDFOKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> MDHOPKHDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> AIMHKAPIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<Matrix4x4> JIJBFNMPFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<byte> BKEPCGINMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> NGHFGNIHJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<int> PAHACGOBMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> JKGJDJPAMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<sbyte> KEPKNICLFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> FPBNBCMOEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> NDILANAPCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<byte> MJMFIGPBPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> DBOAONNCMGG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JBNCALADOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4400", Offset = "0x6AE2E00", VA = "0x186AE4400")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4420", Offset = "0x6AE2E20", VA = "0x186AE4420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CEBCLOAKDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE43E0", Offset = "0x6AE2DE0", VA = "0x186AE43E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6AE46B0", Offset = "0x6AE30B0", VA = "0x186AE46B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CIEMGIMKPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6AE43D0", Offset = "0x6AE2DD0", VA = "0x186AE43D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4410", Offset = "0x6AE2E10", VA = "0x186AE4410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CBJEGMGIABC GKPGBPKIGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6AE47F0", Offset = "0x6AE31F0", VA = "0x186AE47F0")]
		get
		{
			return default(CBJEGMGIABC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6AE43F0", Offset = "0x6AE2DF0", VA = "0x186AE43F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ALBJMEJFCCP BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4800", Offset = "0x6AE3200", VA = "0x186AE4800")]
		get
		{
			return default(ALBJMEJFCCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4DE0", Offset = "0x6AE37E0", VA = "0x186AE4DE0")]
	public FELLELPOPCI(IList<Mesh> CKFEPJHINEL, IList<int> BDJEIPJFDIL, IList<int> MFOPCLCHPBM, IList<int[]> ODLAGBIJBEN, IList<Matrix4x4> NDOFAEAKFMH, IList<bool> KLNMFEDDGJI, IList<int> LMEMHCMBOJN, Allocator MPFEIGMBFCP, CBJEGMGIABC HPBMCJPOHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6AE46C0", Offset = "0x6AE30C0", VA = "0x186AE46C0")]
	public ADADBIKFKIG GEGHIACLDPA(int PONGGOFJABF, Allocator MPFEIGMBFCP)
	{
		return default(ADADBIKFKIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4430", Offset = "0x6AE2E30", VA = "0x186AE4430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
public struct ADADBIKFKIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<Vector3> NOHDOPIDDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeArray<Vector3> PPFPMPHOIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector4> NNLIGJLJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector2> ODOCABHGPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector2> IFCJACHHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> JPHNBCGOOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> JEOODCDIBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Color> BOPGACMAPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<BoneWeight> MPPBPLGOPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Matrix4x4> BPLLIOOODIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> MDHOPKHDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private NativeArray<int> EEFBBDFOLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private NativeArray<int> KLDLOFLACJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> DBOAONNCMGG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GAGFPIDDCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1F00", Offset = "0x6AE0900", VA = "0x186AE1F00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1F10", Offset = "0x6AE0910", VA = "0x186AE1F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2130", Offset = "0x6AE0B30", VA = "0x186AE2130")]
	public ADADBIKFKIG(int BDPIJAGKBEL, int OABDDCANPEA, int FKNOKBNDHJP, int PONGGOFJABF, Allocator MPFEIGMBFCP, bool[] GIBONECKGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2060", Offset = "0x6AE0A60", VA = "0x186AE2060")]
	public void ONAHJMIPIBH(int OMJBBKNLDGL, int EDCGGCHLNEI, int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1F20", Offset = "0x6AE0920", VA = "0x186AE1F20")]
	public int[] IDKNNOAHOJP(int OMJBBKNLDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1FD0", Offset = "0x6AE09D0", VA = "0x186AE1FD0")]
	private NativeSlice<int> LKJNMJOABJI(int OMJBBKNLDGL)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1D90", Offset = "0x6AE0790", VA = "0x186AE1D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1AE0", Offset = "0x6AE04E0", VA = "0x186AE1AE0")]
	public Mesh AAGMBJEHJIP([Optional] string DNKKNNFJONL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LDOGIGHHPPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<Mesh> PGBBIFGLPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<int> CDCJCIKJOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<bool> JEOHEFIJLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int[]> LGCFHGNIGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Matrix4x4> IJAACGPCMGA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6FC0", Offset = "0x6AE59C0", VA = "0x186AE6FC0")]
	public void GOCPGLDBIPD(Mesh LDNHICGPCIN, int[] AAPFMOENNMF, Matrix4x4 PGKCIOEMCIG, bool KLNMFEDDGJI = false, int DMDHAFGNAJI = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6F10", Offset = "0x6AE5910", VA = "0x186AE6F10")]
	public FELLELPOPCI DGNPHPBPCDP(Allocator MPFEIGMBFCP, FELLELPOPCI.CBJEGMGIABC HPBMCJPOHKA, [Optional] IList<int> MFOPCLCHPBM, [Optional] IList<int> EHIIBACCBLG)
	{
		return default(FELLELPOPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7280", Offset = "0x6AE5C80", VA = "0x186AE7280")]
	private static void JICAKCKCCMN(Mesh LDNHICGPCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AE74D0", Offset = "0x6AE5ED0", VA = "0x186AE74D0")]
	public LDOGIGHHPPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[RequireComponent(typeof(ParticleSystem))]
[DisallowMultipleComponent]
public class ParticleSystemTextureStreamerTag : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6AEA0B0", Offset = "0x6AE8AB0", VA = "0x186AEA0B0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	public ParticleSystemTextureStreamerTag()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	private LECMAHMDCEH playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LECMAHMDCEH EBOEMHCNICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10")]
		get
		{
			return default(LECMAHMDCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60F7CD0", Offset = "0x60F66D0", VA = "0x1860F7CD0")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RequireComponent(typeof(Camera))]
public class ScreenshotGenerator : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int AntiAliasLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool UseAlpha;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEA380", Offset = "0x6AE8D80", VA = "0x186AEA380")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NLLCOMGFMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAA30", Offset = "0x6AE9430", VA = "0x186AEAA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	public ShippingContainer()
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Content_Authoring_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB930", Offset = "0x6AEA330", VA = "0x186AEB930", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AIFDKFLGKPB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GOFEHOKIIOK CGLCMOHMEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ANPPHEALLCN<GOFEHOKIIOK> BNPKEICJMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum GOFEHOKIIOK
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Count
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private Light HMEBBGMNOHM;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Light NGGHODGPAKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6AEA020", Offset = "0x6AE8A20", VA = "0x186AEA020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9EB0", Offset = "0x6AE88B0", VA = "0x186AE9EB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9FD0", Offset = "0x6AE89D0", VA = "0x186AE9FD0")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, AEEBIDPALBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly int JMBIEJGNPKK;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6940", Offset = "0x6AE5340", VA = "0x186AE6940")]
		private void HMMOHDKMJGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6A70", Offset = "0x6AE5470", VA = "0x186AE6A70")]
		private void PMIDGOAABCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6BB0", Offset = "0x6AE55B0", VA = "0x186AE6BB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6B40", Offset = "0x6AE5540", VA = "0x186AE6B40", Slot = "4")]
		public void PrepareImposter(GNNJABNPOOC LFOFLLOHBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public InstanceColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class MaterialInstance : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Renderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE83E0", Offset = "0x6AE6DE0", VA = "0x186AE83E0")]
		public void ClearProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6AE84B0", Offset = "0x6AE6EB0", VA = "0x186AE84B0")]
		public void SetColor(string DDDMPLCOGIM, Color IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6AE85C0", Offset = "0x6AE6FC0", VA = "0x186AE85C0")]
		public void SetFloat(string DDDMPLCOGIM, float IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6AE88F0", Offset = "0x6AE72F0", VA = "0x186AE88F0")]
		public void SetVector(string DDDMPLCOGIM, Vector4 IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6AE87C0", Offset = "0x6AE71C0", VA = "0x186AE87C0")]
		public void SetVector(string DDDMPLCOGIM, float OFCNMBDJPHM, float CONCKFNNMJO, float DKJMHGLFONC, float LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6AE86C0", Offset = "0x6AE70C0", VA = "0x186AE86C0")]
		public void SetTexture(string DDDMPLCOGIM, Texture2D IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public MaterialInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LDGJLFFAMIG
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GetDesiredMipLevel();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LCLHLCBAAMB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHPPGPNAEEI(LDGJLFFAMIG MEKLHFBMLFD, Texture2D CGILPHBKMOF);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAABNEGDCDI(LDGJLFFAMIG MEKLHFBMLFD, Texture2D CGILPHBKMOF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLDMAIEFJLB(ParticleSystem OHAMMHPAJHF);
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public delegate void HBJGPAPGAJJ(ParticleEventListener DCNJJNPNFCO, Collider CGCLEIBHLHF, IEnumerable<ParticleCollisionEvent> ABLHOMFEHBO);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> JJCIAAEOLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HBJGPAPGAJJ FMEDEAHFCAH
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8D60", Offset = "0x6AE7760", VA = "0x186AE8D60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8E00", Offset = "0x6AE7800", VA = "0x186AE8E00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8A00", Offset = "0x6AE7400", VA = "0x186AE8A00")]
		private void OnParticleCollision(GameObject CGCLEIBHLHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public ParticleEventListener()
		{
		}
	}
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[CKLIEFGDNGH("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("If true, the StaticBatcher will not generate batches that only contain 1 Renderer. Disabling this can be useful for debugging why certain objects cannot batch. This setting does not affect LOD groups: batches of 1 LOD group are never created.")]
		public bool RemoveBatchesOfOneRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAB40", Offset = "0x6AE9540", VA = "0x186AEAB40")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAB60", Offset = "0x6AE9560", VA = "0x186AEAB60")]
		public bool ACDLLDDHKAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAC80", Offset = "0x6AE9680", VA = "0x186AEAC80")]
		public StaticBatchMeshData()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool PKHFDLCDHEO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override FANCEBNIFOL KAAIDLOOBFB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x975980", Offset = "0x974380", VA = "0x180975980", Slot = "4")]
			get
			{
				return default(FANCEBNIFOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3F70", Offset = "0x6AE2970", VA = "0x186AE3F70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3F80", Offset = "0x6AE2980", VA = "0x186AE3F80")]
		private void EKCICFNPPIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4360", Offset = "0x6AE2D60", VA = "0x186AE4360")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4240", Offset = "0x6AE2C40", VA = "0x186AE4240")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4120", Offset = "0x6AE2B20", VA = "0x186AE4120")]
		private void FFOBMPACEDF(GOFEHOKIIOK FCCHDNMJADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x16780E0", Offset = "0x1676AE0", VA = "0x1816780E0", Slot = "7")]
		protected override bool GPMOMEJLLFC(bool MNLIKPKKOMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE41D0", Offset = "0x6AE2BD0", VA = "0x186AE41D0", Slot = "8")]
		protected override void LKMDOBKIMDI(bool DOFMKOIACME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4390", Offset = "0x6AE2D90", VA = "0x186AE4390")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool PAKGGCBJMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int NPIHEPHHPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool HOFCOOCNCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool MOEMGDEAPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float DMJBLIBIBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float OPGAHMOEPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float IMNOPELACBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float ABMABALMCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float EFEEBNDCLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float IEOLKNOKJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ParticleSystem.MainModule LKFKGCOJKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ParticleSystem.TrailModule LBBFLNEPODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ParticleSystem.EmissionModule IMKIKMJEPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ParticleSystem.CollisionModule FLAPDCLJJGJ;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9CF0", Offset = "0x6AE86F0", VA = "0x186AE9CF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9A40", Offset = "0x6AE8440", VA = "0x186AE9A40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8FE0", Offset = "0x6AE79E0", VA = "0x186AE8FE0")]
		private void FFOBMPACEDF(GOFEHOKIIOK FCCHDNMJADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9330", Offset = "0x6AE7D30", VA = "0x186AE9330")]
		private void KIFPCFDKPGM(IRecRoomQualityConfigProvider EILKMNJGOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9830", Offset = "0x6AE8230", VA = "0x186AE9830")]
		private void OOOIICMEFJF(OverrideSettings DINHKDMCKNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9060", Offset = "0x6AE7A60", VA = "0x186AE9060")]
		private void GBOENFDIBBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9B50", Offset = "0x6AE8550", VA = "0x186AE9B50")]
		private void PEPHIOMIBIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9200", Offset = "0x6AE7C00", VA = "0x186AE9200")]
		private void JGKJICGKKCL(ParticleSystem.MinMaxCurve INPHFGEGPBD, [Out] float GEKEFKDCOCG, [Out] float CEIBFGFGBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8EA0", Offset = "0x6AE78A0", VA = "0x186AE8EA0")]
		private ParticleSystem.MinMaxCurve CODJBIMIBFE(ParticleSystem.MinMaxCurve INPHFGEGPBD, float GEKEFKDCOCG, float CEIBFGFGBDM)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override FANCEBNIFOL KAAIDLOOBFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x975980", Offset = "0x974380", VA = "0x180975980", Slot = "4")]
			get
			{
				return default(FANCEBNIFOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract T HFCPPIEAILE(IRecRoomQualityConfigProvider CDNGDGIHDCC);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x49FCB30", Offset = "0x49FB530", VA = "0x1849FCB30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x49FD290", Offset = "0x49FBC90", VA = "0x1849FD290")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x49FCF20", Offset = "0x49FB920", VA = "0x1849FCF20")]
		private void FFOBMPACEDF(GOFEHOKIIOK FCCHDNMJADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x49FCF90", Offset = "0x49FB990", VA = "0x1849FCF90")]
		private void MAJHJKEHPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x49FCF50", Offset = "0x49FB950", VA = "0x1849FCF50", Slot = "8")]
		protected override void LKMDOBKIMDI(bool DOFMKOIACME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x39EAC50", Offset = "0x39E9650", VA = "0x1839EAC50")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class HJACCKNFLFC
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6AE66D0", Offset = "0x6AE50D0", VA = "0x186AE66D0")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void CNFNMOPOGFM(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private enum IMGJCFJKFNB
		{
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private IMGJCFJKFNB behavior;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA3C0", Offset = "0x6AE8DC0", VA = "0x186AEA3C0", Slot = "9")]
		protected override bool HFCPPIEAILE(IRecRoomQualityConfigProvider CDNGDGIHDCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA3A0", Offset = "0x6AE8DA0", VA = "0x186AEA3A0", Slot = "7")]
		protected override bool GPMOMEJLLFC(bool MNLIKPKKOMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA410", Offset = "0x6AE8E10", VA = "0x186AEA410")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private enum DAACAPDDNCK
		{
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private DAACAPDDNCK behavior;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA450", Offset = "0x6AE8E50", VA = "0x186AEA450", Slot = "9")]
		protected override bool HFCPPIEAILE(IRecRoomQualityConfigProvider CDNGDGIHDCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA3A0", Offset = "0x6AE8DA0", VA = "0x186AEA3A0", Slot = "7")]
		protected override bool GPMOMEJLLFC(bool MNLIKPKKOMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA4A0", Offset = "0x6AE8EA0", VA = "0x186AEA4A0")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private enum OIEAJKAOAOH
		{
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private OIEAJKAOAOH behavior;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA4E0", Offset = "0x6AE8EE0", VA = "0x186AEA4E0", Slot = "9")]
		protected override bool HFCPPIEAILE(IRecRoomQualityConfigProvider CDNGDGIHDCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA3A0", Offset = "0x6AE8DA0", VA = "0x186AEA3A0", Slot = "7")]
		protected override bool GPMOMEJLLFC(bool MNLIKPKKOMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA530", Offset = "0x6AE8F30", VA = "0x186AEA530")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA580", Offset = "0x6AE8F80", VA = "0x186AEA580", Slot = "9")]
		protected override LightRenderingMode HFCPPIEAILE(IRecRoomQualityConfigProvider CDNGDGIHDCC)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA570", Offset = "0x6AE8F70", VA = "0x186AEA570", Slot = "7")]
		protected override bool GPMOMEJLLFC(LightRenderingMode MNLIKPKKOMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA5E0", Offset = "0x6AE8FE0", VA = "0x186AEA5E0")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA640", Offset = "0x6AE9040", VA = "0x186AEA640", Slot = "9")]
		protected override SceneDecorationDetailLevel HFCPPIEAILE(IRecRoomQualityConfigProvider CDNGDGIHDCC)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA620", Offset = "0x6AE9020", VA = "0x186AEA620", Slot = "7")]
		protected override bool GPMOMEJLLFC(SceneDecorationDetailLevel MNLIKPKKOMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA690", Offset = "0x6AE9090", VA = "0x186AEA690")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA6F0", Offset = "0x6AE90F0", VA = "0x186AEA6F0", Slot = "9")]
		protected override TransparencyDetailLevel HFCPPIEAILE(IRecRoomQualityConfigProvider CDNGDGIHDCC)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA6D0", Offset = "0x6AE90D0", VA = "0x186AEA6D0", Slot = "7")]
		protected override bool GPMOMEJLLFC(TransparencyDetailLevel MNLIKPKKOMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA740", Offset = "0x6AE9140", VA = "0x186AEA740")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA830", Offset = "0x6AE9230", VA = "0x186AEA830", Slot = "7")]
		protected override bool GPMOMEJLLFC(BackgroundAnimationDetailLevel KMLMNLGLKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA8C0", Offset = "0x6AE92C0", VA = "0x186AEA8C0", Slot = "8")]
		protected override void LKMDOBKIMDI(bool GJHDHJFGOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA780", Offset = "0x6AE9180", VA = "0x186AEA780")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA940", Offset = "0x6AE9340", VA = "0x186AEA940")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA9F0", Offset = "0x6AE93F0", VA = "0x186AEA9F0")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Terrain DDBKCLMHOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TerrainData HOPMJLBPMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TerrainData OAHOLACHPAC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Terrain FEFNFGNBCHG
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6AEAE50", Offset = "0x6AE9850", VA = "0x186AEAE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAD10", Offset = "0x6AE9710", VA = "0x186AEAD10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB460", Offset = "0x6AE9E60", VA = "0x186AEB460")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB350", Offset = "0x6AE9D50", VA = "0x186AEB350")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB340", Offset = "0x6AE9D40", VA = "0x186AEB340")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6AEADA0", Offset = "0x6AE97A0", VA = "0x186AEADA0")]
		private void DFCFCCJDHID(GOFEHOKIIOK FCCHDNMJADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB5E0", Offset = "0x6AE9FE0", VA = "0x186AEB5E0", Slot = "6")]
		public override void SetActivation(TerrainQualityLevel AGJJJFLEKCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "7")]
		protected override bool GPMOMEJLLFC(TerrainQualityLevel KMLMNLGLKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "8")]
		protected override void LKMDOBKIMDI(bool DOFMKOIACME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAF60", Offset = "0x6AE9960", VA = "0x186AEAF60")]
		private void FFOFDBPEIED(Settings ONONNKMGMKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAFE0", Offset = "0x6AE99E0", VA = "0x186AEAFE0")]
		private void FMLKBJEJFPJ(TreePrefabOverride[] NADHNKNFKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB270", Offset = "0x6AE9C70", VA = "0x186AEB270")]
		private void MIEMANHCNHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAEE0", Offset = "0x6AE98E0", VA = "0x186AEAEE0")]
		private Settings FFFKHBGPOEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB7B0", Offset = "0x6AEA1B0", VA = "0x186AEB7B0")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum LECMAHMDCEH
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface CJAMEBNBPDI
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color BJCIGJMGMBG);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private List<Material> DEFPBNBCDGL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BackgroundObject MHGHOGJDILL
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2520", Offset = "0x6AE0F20", VA = "0x186AE2520")]
		public void Init(BackgroundObject IGOFBEPEIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2770", Offset = "0x6AE1170", VA = "0x186AE2770")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2890", Offset = "0x6AE1290", VA = "0x186AE2890")]
		public void SetBlendValue(float CLBFFDPBPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2A00", Offset = "0x6AE1400", VA = "0x186AE2A00")]
		public void SetColor(Color BJCIGJMGMBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2B30", Offset = "0x6AE1530", VA = "0x186AE2B30")]
		public void SetRotation(float PCIAHIPKDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2D00", Offset = "0x6AE1700", VA = "0x186AE2D00")]
		public BackgroundObject()
		{
		}
	}
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class ActivationController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public enum FANCEBNIFOL
		{
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		[CKLIEFGDNGH("OnSceneOrPrefabSaveBehavior", FANCEBNIFOL.EnableIfAllowed)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual FANCEBNIFOL KAAIDLOOBFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "4")]
			get
			{
				return default(FANCEBNIFOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class ActivationController<T> : ActivationController where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		protected bool? MFHHBJKPKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		protected T FLFMNPPAOMJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ANPAJCECOBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x436D800", Offset = "0x436C200", VA = "0x18436D800", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x436D4A0", Offset = "0x436BEA0", VA = "0x18436D4A0", Slot = "6")]
		public virtual void SetActivation(T KMLMNLGLKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool GPMOMEJLLFC(T KMLMNLGLKJO);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void LKMDOBKIMDI(bool DOFMKOIACME);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8A0AF0", Offset = "0x89F4F0", VA = "0x1808A0AF0")]
		protected ActivationController()
		{
		}
	}
}
namespace RecRoom.CullableBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[UnityEngine.Scripting.Preserve]
	public class CullableBatchLOD : MonoBehaviour, FNJKPCHPEGH
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public class BatchedRenderer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Renderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public bool visibleInBatch;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public bool Enabled
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x6AE2D90", Offset = "0x6AE1790", VA = "0x186AE2D90")]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public BatchedRenderer[] revealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public LODGroup[] revealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public BatchedRenderer[] nonRevealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public LODGroup[] nonRevealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		public int subMeshCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		public int startRenderableSubmshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		private HDLBMLPIHPN toggleBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private Bounds OBOMBLGEGIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private Material PPFNGNPGEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private EJOJBBEGKFK<CullableBatchLOD> FGKAOJPFKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Mesh LDNHICGPCIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool HGCNPKNGBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool DOMPLGGJENF;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6AE33C0", Offset = "0x6AE1DC0", VA = "0x186AE33C0")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6AE38B0", Offset = "0x6AE22B0", VA = "0x186AE38B0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3220", Offset = "0x6AE1C20", VA = "0x186AE3220")]
		private static float DGGAECFDEKJ(Vector3 NGHJADPNLBC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3330", Offset = "0x6AE1D30", VA = "0x186AE3330")]
		public void SetContentsVisibility(bool HBDBNDAIPFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3240", Offset = "0x6AE1C40", VA = "0x186AE3240", Slot = "5")]
		public void OnChangedDistanceBand(HDLBMLPIHPN KEMJDCKCHMC, HDLBMLPIHPN PDPCPICHGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
		public void OnChangedVisibility(bool ELHHPBLDOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3270", Offset = "0x6AE1C70", VA = "0x186AE3270")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3B40", Offset = "0x6AE2540", VA = "0x186AE3B40")]
		public CullableBatchLOD()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8AD490", Offset = "0x8ABE90", VA = "0x1808AD490", Slot = "4")]
		private Transform GDOGPCGINGN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchLODMaterialData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Vector4[] baseColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Vector4[] specColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Vector4[] emissionColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Vector4[] halfProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Vector4[] secondaryTextureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[FormerlySerializedAs("renderer")]
		public MeshRenderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public CullableBatchLODMaterialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchShaderManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3B60", Offset = "0x6AE2560", VA = "0x186AE3B60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public CullableBatchShaderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[RecRoom.NoEngine.Common.Preserve]
	[ExecuteInEditMode]
	public class RunTimeTextureAtlasData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA340", Offset = "0x6AE8D40", VA = "0x186AEA340")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA340", Offset = "0x6AE8D40", VA = "0x186AEA340")]
		private void PHIOONOCALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public RunTimeTextureAtlasData()
		{
		}
	}
}
namespace RecRoom.ProBuilder
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[AddComponentMenu(null)]
	public class AGProBuilderStub : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public AGProBuilderStub()
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
