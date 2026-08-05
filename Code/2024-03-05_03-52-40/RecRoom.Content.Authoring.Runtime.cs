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
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum HCPKGEBPLPD
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
	private HCPKGEBPLPD bobAxis;

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
	private float DBMDMAEGBCM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 EMOBBFCJOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6056350", Offset = "0x6055150", VA = "0x186056350")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6056310", Offset = "0x6055110", VA = "0x186056310")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6056540", Offset = "0x6055340", VA = "0x186056540")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6056780", Offset = "0x6055580", VA = "0x186056780")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x947890", Offset = "0x946690", VA = "0x180947890")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, OEAGNGPIJEJ
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string IANGJHPIONJ = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string ELPOPJBLGFL = "_MainColor";

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
	private static List<Material> PGBODDAPEGC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> DJCBJDPAEIF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
	public void PrepareImposter(HGPPIDBFPBM JCKJBGDNIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60580A0", Offset = "0x6056EA0", VA = "0x1860580A0")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
[ExecuteInEditMode]
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
	[Cpp2IlInjected.Address(RVA = "0x6058510", Offset = "0x6057310", VA = "0x186058510")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60585B0", Offset = "0x60573B0", VA = "0x1860585B0")]
	public void initialize(Mesh ANEDHOMCFCC, Material DCPBAOMABHD, Matrix4x4[] MJKGHFBBMFJ, Component[] FEEIGECJNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
	public InstancedMeshGroup()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NativeContainer]
[DefaultMember("Item")]
public struct KEGHBNMKJAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum BENNJGGEMMJ
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
	public struct BEPAAMHDOGN : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[ReadOnly]
		public KEGHBNMKJAM BIHLPAECIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[ReadOnly]
		public int GFKOLPEHCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AFCOFIFJGHN NLKEEBODLMF;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6054CE0", Offset = "0x6053AE0", VA = "0x186054CE0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct PMKDAPDDDHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeSlice<Vector3> KHEKBMGHGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NativeSlice<Vector3> IMGHEOEJLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector4> JIFECIOHLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector2> LAFFDHEBNDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector2> GDHODDFANMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> PGHHPKMDPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> JCPMGJOKDJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Color> OPELOEONPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<BoneWeight> MADBBFFMIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Matrix4x4> FOMCDPHGDDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<int> FBMBJOHPPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<int> KFFGFKJNCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> AOIPGKBFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> MPFPDOOLHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<byte> HEIHLDEMCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int PCEPDLBFHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Matrix4x4 EDPJPDDCLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool KKFJMKNJOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int FFGMEGKLKGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> KHEKBMGHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<int> EEPDBLHAAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector3> IMGHEOEJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector4> JIFECIOHLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> LAFFDHEBNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> GDHODDFANMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Vector2> PGHHPKMDPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector2> JCPMGJOKDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<Color> OPELOEONPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<BoneWeight> MADBBFFMIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> MPFPDOOLHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> EPLMFKINDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> DCDBDKPKCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<Matrix4x4> FOMCDPHGDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> JCBIBBOAHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> FBMBJOHPPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> BHMAKGFFCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<Matrix4x4> MKGNJEGGLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<byte> OBFKIIDJEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> BBGGGFGKDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<int> AINCOGPCMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> LHAEKHEFHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<sbyte> GDGJBMDFMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> AFMCEOBMMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> OPNMPMBAHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<byte> ADMLNJABEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> IADHNMKNMOJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KINIINKAPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6058860", Offset = "0x6057660", VA = "0x186058860")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60590F0", Offset = "0x6057EF0", VA = "0x1860590F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JMGMFBAGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6058B00", Offset = "0x6057900", VA = "0x186058B00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6058AF0", Offset = "0x60578F0", VA = "0x186058AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MHMFNGHNMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6059100", Offset = "0x6057F00", VA = "0x186059100")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6059120", Offset = "0x6057F20", VA = "0x186059120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BENNJGGEMMJ COMHKODOJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6058850", Offset = "0x6057650", VA = "0x186058850")]
		get
		{
			return default(BENNJGGEMMJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6059110", Offset = "0x6057F10", VA = "0x186059110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private PMKDAPDDDHB GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6058B10", Offset = "0x6057910", VA = "0x186058B10")]
		get
		{
			return default(PMKDAPDDDHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6059130", Offset = "0x6057F30", VA = "0x186059130")]
	public KEGHBNMKJAM(IList<Mesh> MMCCNAGPOCD, IList<int> MKOGIBLKCBL, IList<int> BJMFNMNJKME, IList<int[]> HONGBLBNMKN, IList<Matrix4x4> GOPHJIJKKKI, IList<bool> EPMBCGDBIBK, IList<int> HGIMMJDLDBO, Allocator ALDDPOOJFGI, BENNJGGEMMJ CAPNAGJDMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6058720", Offset = "0x6057520", VA = "0x186058720")]
	public AFCOFIFJGHN ADPDILONPCB(int JAELBGABNKF, Allocator ALDDPOOJFGI)
	{
		return default(AFCOFIFJGHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6058870", Offset = "0x6057670", VA = "0x186058870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
public struct AFCOFIFJGHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<Vector3> KHEKBMGHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeArray<Vector3> IMGHEOEJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector4> JIFECIOHLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector2> LAFFDHEBNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector2> GDHODDFANMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> PGHHPKMDPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> JCPMGJOKDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Color> OPELOEONPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<BoneWeight> MADBBFFMIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Matrix4x4> FOMCDPHGDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> FBMBJOHPPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private NativeArray<int> KFFGFKJNCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private NativeArray<int> AOIPGKBFIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> IADHNMKNMOJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int EEGKMLOGJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60542B0", Offset = "0x60530B0", VA = "0x1860542B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x60545B0", Offset = "0x60533B0", VA = "0x1860545B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6054900", Offset = "0x6053700", VA = "0x186054900")]
	public AFCOFIFJGHN(int LAGECHBNBCA, int PIKGOJMIHLC, int HJLFJCOEKCD, int JAELBGABNKF, Allocator ALDDPOOJFGI, bool[] DBHOEMHIOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6054430", Offset = "0x6053230", VA = "0x186054430")]
	public void FIJICENHNEI(int MBAAGMDFGNI, int LBJEFCOBKGF, int AKCMMEDPGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6054500", Offset = "0x6053300", VA = "0x186054500")]
	public int[] IJIAHBODHKA(int MBAAGMDFGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6054870", Offset = "0x6053670", VA = "0x186054870")]
	private NativeSlice<int> PBPKIJPPKGD(int MBAAGMDFGNI)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60542C0", Offset = "0x60530C0", VA = "0x1860542C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60545C0", Offset = "0x60533C0", VA = "0x1860545C0")]
	public Mesh OKPPMAMFBAB([Optional] string IHJPDIMDCBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FFJOMNKAFDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<Mesh> NHOAEIIFNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<int> BLIBONGJBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<bool> GFEJFCOKJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int[]> AFFAEPEKPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Matrix4x4> ODOIOLCJNCE;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6057A90", Offset = "0x6056890", VA = "0x186057A90")]
	public void KCKNHKPHCBG(Mesh HCHDFAPIGCD, int[] MDLGPMBIJCP, Matrix4x4 ABOHGNCLMJC, bool EPMBCGDBIBK = false, int KFADJNECBFF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60579E0", Offset = "0x60567E0", VA = "0x1860579E0")]
	public KEGHBNMKJAM JHAAHPCAECC(Allocator ALDDPOOJFGI, KEGHBNMKJAM.BENNJGGEMMJ CAPNAGJDMFN, [Optional] IList<int> BJMFNMNJKME, [Optional] IList<int> CMDDCEEOLLD)
	{
		return default(KEGHBNMKJAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60578B0", Offset = "0x60566B0", VA = "0x1860578B0")]
	private void HHHNKADLBED(Mesh HCHDFAPIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6057DF0", Offset = "0x6056BF0", VA = "0x186057DF0")]
	public FFJOMNKAFDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	private BODIIHDCCKI playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BODIIHDCCKI ADNKGEBOFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB30", Offset = "0x7BE930", VA = "0x1807BFB30")]
		get
		{
			return default(BODIIHDCCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x56C5390", Offset = "0x56C4190", VA = "0x1856C5390")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
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

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x605C6F0", Offset = "0x605B4F0", VA = "0x18605C6F0")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
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
	public bool HHMCNIBBFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x605CD60", Offset = "0x605BB60", VA = "0x18605CD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JNLGHGENJBI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KIKPFMHBIIN NHPJBINEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KIKPFMHBIIN> ALJJLNJCCMO;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum KIKPFMHBIIN
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
	Count
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private Light GJLDBBGLNFP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Light AJCKFGNFAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x605C620", Offset = "0x605B420", VA = "0x18605C620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x605C4B0", Offset = "0x605B2B0", VA = "0x18605C4B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x605C5D0", Offset = "0x605B3D0", VA = "0x18605C5D0")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, OEAGNGPIJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int CCCLLECACIO;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6058130", Offset = "0x6056F30", VA = "0x186058130")]
		private void GEICDLEDGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6058270", Offset = "0x6057070", VA = "0x186058270")]
		private void HMEIHONCDJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x60583B0", Offset = "0x60571B0", VA = "0x1860583B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6058340", Offset = "0x6057140", VA = "0x186058340", Slot = "4")]
		public void PrepareImposter(HGPPIDBFPBM JCKJBGDNIAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public InstanceColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class MaterialInstance : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Renderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x605AB10", Offset = "0x6059910", VA = "0x18605AB10")]
		public void ClearProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x605ABE0", Offset = "0x60599E0", VA = "0x18605ABE0")]
		public void SetColor(string OCCHBLONHPL, Color MAEBFBHFPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x605ACF0", Offset = "0x6059AF0", VA = "0x18605ACF0")]
		public void SetFloat(string OCCHBLONHPL, float MAEBFBHFPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x605B020", Offset = "0x6059E20", VA = "0x18605B020")]
		public void SetVector(string OCCHBLONHPL, Vector4 MAEBFBHFPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x605AEF0", Offset = "0x6059CF0", VA = "0x18605AEF0")]
		public void SetVector(string OCCHBLONHPL, float BJKAJHEJDMP, float FPNMMAJHCIF, float NHBCGCKKFLL, float LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x605ADF0", Offset = "0x6059BF0", VA = "0x18605ADF0")]
		public void SetTexture(string OCCHBLONHPL, Texture2D MAEBFBHFPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public MaterialInstance()
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
		public delegate void EHAKKNDNFFN(ParticleEventListener HOGKGMHKKLK, Collider EDOEJIMPOFP, IEnumerable<ParticleCollisionEvent> OPFINALALHG);

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static readonly List<ParticleCollisionEvent> LCBFFOFKNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EHAKKNDNFFN CCGFKKIOFLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x605B5B0", Offset = "0x605A3B0", VA = "0x18605B5B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x605B650", Offset = "0x605A450", VA = "0x18605B650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x605B230", Offset = "0x605A030", VA = "0x18605B230")]
		private void OnParticleCollision(GameObject EDOEJIMPOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public ParticleEventListener()
		{
		}
	}
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[GCDOPMLLINA("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("If true, the StaticBatcher will not generate batches that only contain 1 Renderer. Disabling this can be useful for debugging why certain objects cannot batch. This setting does not affect LOD groups: batches of 1 LOD group are never created.")]
		public bool RemoveBatchesOfOneRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x605CE80", Offset = "0x605BC80", VA = "0x18605CE80")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x605CEA0", Offset = "0x605BCA0", VA = "0x18605CEA0")]
		public bool JHAKIOJAGPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x605CFD0", Offset = "0x605BDD0", VA = "0x18605CFD0")]
		public StaticBatchMeshData()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool MIFMKKGJHGD;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override NEGMINOMNJB FCBNJHKELLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8E9BC0", Offset = "0x8E89C0", VA = "0x1808E9BC0", Slot = "4")]
			get
			{
				return default(NEGMINOMNJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60574F0", Offset = "0x60562F0", VA = "0x1860574F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6057500", Offset = "0x6056300", VA = "0x186057500")]
		private void FGCMBAAMLOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6057840", Offset = "0x6056640", VA = "0x186057840")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6057760", Offset = "0x6056560", VA = "0x186057760")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60576D0", Offset = "0x60564D0", VA = "0x1860576D0")]
		private void MGFJPDGBMMM(KIKPFMHBIIN PHCJDGDKFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60576C0", Offset = "0x60564C0", VA = "0x1860576C0", Slot = "7")]
		protected override bool HKJBBFGMPLC(bool HFGBEEJBAED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6057650", Offset = "0x6056450", VA = "0x186057650", Slot = "8")]
		protected override void GLDPHMMCGLN(bool PLLPHFPNBPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6057870", Offset = "0x6056670", VA = "0x186057870")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool DJGLLLALGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int BEGLGHPLCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool PFMLGCJMAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool JHHLAHPLNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float AFPBNNNNBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float HCLANNHHMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float JFEOHKMADFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float GJGGCMKOLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float AAMOPKGKDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float BDGBGLMBPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private ParticleSystem.MainModule JIKEJJINGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ParticleSystem.TrailModule MAJGMFNJKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ParticleSystem.EmissionModule EJOMHAICOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ParticleSystem.CollisionModule MHPBABHKAIC;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x605C330", Offset = "0x605B130", VA = "0x18605C330")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x605C130", Offset = "0x605AF30", VA = "0x18605C130")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x605BF30", Offset = "0x605AD30", VA = "0x18605BF30")]
		private void MGFJPDGBMMM(KIKPFMHBIIN PHCJDGDKFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x605BA20", Offset = "0x605A820", VA = "0x18605BA20")]
		private void HEKCBGLBIKK(IRecRoomQualityConfigProvider OMMMKKDJPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x605B830", Offset = "0x605A630", VA = "0x18605B830")]
		private void EPCCBOOOGGJ(OverrideSettings PGJKLJLNBGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x605BD90", Offset = "0x605AB90", VA = "0x18605BD90")]
		private void JOHFBAPBEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x605BF90", Offset = "0x605AD90", VA = "0x18605BF90")]
		private void OBOMBIGADOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x605C200", Offset = "0x605B000", VA = "0x18605C200")]
		private void PIIGLPLIODF(ParticleSystem.MinMaxCurve MKFGBKPJNKE, [Out] float ACLLLKEJKPF, [Out] float BCGCMPAHLNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x605B6F0", Offset = "0x605A4F0", VA = "0x18605B6F0")]
		private ParticleSystem.MinMaxCurve CNNNANAJBMG(ParticleSystem.MinMaxCurve MKFGBKPJNKE, float ACLLLKEJKPF, float BCGCMPAHLNM)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override NEGMINOMNJB FCBNJHKELLN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8E9BC0", Offset = "0x8E89C0", VA = "0x1808E9BC0", Slot = "4")]
			get
			{
				return default(NEGMINOMNJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract T MLNGPJLIKBP(IRecRoomQualityConfigProvider PKHJDGEODIL);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x412E4C0", Offset = "0x412D2C0", VA = "0x18412E4C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x412EA50", Offset = "0x412D850", VA = "0x18412EA50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x412E950", Offset = "0x412D750", VA = "0x18412E950")]
		private void MGFJPDGBMMM(KIKPFMHBIIN PHCJDGDKFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x412E850", Offset = "0x412D650", VA = "0x18412E850")]
		private void HHNIJBOBKBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x412E790", Offset = "0x412D590", VA = "0x18412E790", Slot = "8")]
		protected override void GLDPHMMCGLN(bool PLLPHFPNBPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x32849F0", Offset = "0x32837F0", VA = "0x1832849F0")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal static class OGHDFDJILDF
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x605B130", Offset = "0x6059F30", VA = "0x18605B130")]
	[HBAMLEIOGOF(BHCECOANHAK.None)]
	private static void LKEMAGLDGMF(CMADEFPIMOE LANMIEEPANH)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private enum MCDHCGCJNMP
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private MCDHCGCJNMP behavior;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x605C730", Offset = "0x605B530", VA = "0x18605C730", Slot = "9")]
		protected override bool MLNGPJLIKBP(IRecRoomQualityConfigProvider PKHJDGEODIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x605C710", Offset = "0x605B510", VA = "0x18605C710", Slot = "7")]
		protected override bool HKJBBFGMPLC(bool HFGBEEJBAED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x605C780", Offset = "0x605B580", VA = "0x18605C780")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private enum JLHIPAGJNLD
		{
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private JLHIPAGJNLD behavior;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x605C7C0", Offset = "0x605B5C0", VA = "0x18605C7C0", Slot = "9")]
		protected override bool MLNGPJLIKBP(IRecRoomQualityConfigProvider PKHJDGEODIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x605C710", Offset = "0x605B510", VA = "0x18605C710", Slot = "7")]
		protected override bool HKJBBFGMPLC(bool HFGBEEJBAED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x605C810", Offset = "0x605B610", VA = "0x18605C810")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private enum HIBKIJAIIAD
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private HIBKIJAIIAD behavior;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x605C850", Offset = "0x605B650", VA = "0x18605C850", Slot = "9")]
		protected override bool MLNGPJLIKBP(IRecRoomQualityConfigProvider PKHJDGEODIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x605C710", Offset = "0x605B510", VA = "0x18605C710", Slot = "7")]
		protected override bool HKJBBFGMPLC(bool HFGBEEJBAED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x605C8A0", Offset = "0x605B6A0", VA = "0x18605C8A0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x605C8F0", Offset = "0x605B6F0", VA = "0x18605C8F0", Slot = "9")]
		protected override LightRenderingMode MLNGPJLIKBP(IRecRoomQualityConfigProvider PKHJDGEODIL)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x605C8E0", Offset = "0x605B6E0", VA = "0x18605C8E0", Slot = "7")]
		protected override bool HKJBBFGMPLC(LightRenderingMode HFGBEEJBAED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x605C950", Offset = "0x605B750", VA = "0x18605C950")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x605C9B0", Offset = "0x605B7B0", VA = "0x18605C9B0", Slot = "9")]
		protected override SceneDecorationDetailLevel MLNGPJLIKBP(IRecRoomQualityConfigProvider PKHJDGEODIL)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x605C990", Offset = "0x605B790", VA = "0x18605C990", Slot = "7")]
		protected override bool HKJBBFGMPLC(SceneDecorationDetailLevel HFGBEEJBAED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x605CA00", Offset = "0x605B800", VA = "0x18605CA00")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x605CA60", Offset = "0x605B860", VA = "0x18605CA60", Slot = "9")]
		protected override TransparencyDetailLevel MLNGPJLIKBP(IRecRoomQualityConfigProvider PKHJDGEODIL)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x605CA40", Offset = "0x605B840", VA = "0x18605CA40", Slot = "7")]
		protected override bool HKJBBFGMPLC(TransparencyDetailLevel HFGBEEJBAED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x605CAB0", Offset = "0x605B8B0", VA = "0x18605CAB0")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x605CC00", Offset = "0x605BA00", VA = "0x18605CC00", Slot = "7")]
		protected override bool HKJBBFGMPLC(BackgroundAnimationDetailLevel POJHCCCEPDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x605CB80", Offset = "0x605B980", VA = "0x18605CB80", Slot = "8")]
		protected override void GLDPHMMCGLN(bool OOONCECEHDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x605CAF0", Offset = "0x605B8F0", VA = "0x18605CAF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x605CC90", Offset = "0x605BA90", VA = "0x18605CC90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x605CD20", Offset = "0x605BB20", VA = "0x18605CD20")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Terrain FDHDPKDBCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TerrainData EDJPBEBKDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TerrainData DGEINMBAPCH;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Terrain LEFKAFCLKFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x605D380", Offset = "0x605C180", VA = "0x18605D380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x605D060", Offset = "0x605BE60", VA = "0x18605D060")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x605D750", Offset = "0x605C550", VA = "0x18605D750")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x605D680", Offset = "0x605C480", VA = "0x18605D680")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x605D670", Offset = "0x605C470", VA = "0x18605D670")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x605D510", Offset = "0x605C310", VA = "0x18605D510")]
		private void EJDDEDMPKLB(KIKPFMHBIIN PHCJDGDKFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x605D890", Offset = "0x605C690", VA = "0x18605D890", Slot = "6")]
		public override void SetActivation(TerrainQualityLevel HCNPHOPGHFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310", Slot = "7")]
		protected override bool HKJBBFGMPLC(TerrainQualityLevel POJHCCCEPDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "8")]
		protected override void GLDPHMMCGLN(bool PLLPHFPNBPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x605D490", Offset = "0x605C290", VA = "0x18605D490")]
		private void DBEDKLOLIID(Settings IICNKBNFHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x605D0F0", Offset = "0x605BEF0", VA = "0x18605D0F0")]
		private void BCGKPJJNDOG(TreePrefabOverride[] PMIDPBOOGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x605D5A0", Offset = "0x605C3A0", VA = "0x18605D5A0")]
		private void FDKMJINOMEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x605D410", Offset = "0x605C210", VA = "0x18605D410")]
		private Settings CPDLOACDKBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x605DA60", Offset = "0x605C860", VA = "0x18605DA60")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public enum BODIIHDCCKI
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface AJOALPJGKHM
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color DNOKCMICDIP);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private List<Material> FDMAJDPJPIO;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject LNIEINLILCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F50", Offset = "0x7B7D50", VA = "0x1807B8F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6055A70", Offset = "0x6054870", VA = "0x186055A70")]
		public void Init(BackgroundObject EMCJEOKFHFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6055CC0", Offset = "0x6054AC0", VA = "0x186055CC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6055DE0", Offset = "0x6054BE0", VA = "0x186055DE0")]
		public void SetBlendValue(float KMEKJBHPCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6055F50", Offset = "0x6054D50", VA = "0x186055F50")]
		public void SetColor(Color DNOKCMICDIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6056080", Offset = "0x6054E80", VA = "0x186056080")]
		public void SetRotation(float OKEJHHGCFPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6056250", Offset = "0x6055050", VA = "0x186056250")]
		public BackgroundObject()
		{
		}
	}
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public abstract class ActivationController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public enum NEGMINOMNJB
		{
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		[GCDOPMLLINA("OnSceneOrPrefabSaveBehavior", NEGMINOMNJB.EnableIfAllowed)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected virtual NEGMINOMNJB FCBNJHKELLN
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "4")]
			get
			{
				return default(NEGMINOMNJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class ActivationController<T> : ActivationController where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		protected bool? AGAMELJMOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		protected T OINFJPFAJAM;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool BPGDFLDPEIN
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x3C054D0", Offset = "0x3C042D0", VA = "0x183C054D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3C05160", Offset = "0x3C03F60", VA = "0x183C05160", Slot = "6")]
		public virtual void SetActivation(T POJHCCCEPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool HKJBBFGMPLC(T POJHCCCEPDP);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void GLDPHMMCGLN(bool PLLPHFPNBPA);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D5E80", Offset = "0x7D4C80", VA = "0x1807D5E80")]
		protected ActivationController()
		{
		}
	}
}
namespace RecRoom.CullableBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[UnityEngine.Scripting.Preserve]
	public class CullableBatchLOD : MonoBehaviour, EMNKEBKLFCH
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public class BatchedRenderer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Renderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public bool visibleInBatch;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public bool Enabled
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x60562E0", Offset = "0x60550E0", VA = "0x1860562E0")]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public BatchedRenderer[] revealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public LODGroup[] revealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public BatchedRenderer[] nonRevealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public LODGroup[] nonRevealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		public int subMeshCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		public int startRenderableSubmshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		private IMIGBJOIFIN toggleBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Bounds FDKGJFKELIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private Material NLKDDMHEDOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private HJHNEBPDCHJ<CullableBatchLOD> APONKBIHAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private Mesh HCHDFAPIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool DEBBDIBLGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool PEGOMIJIDKL;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6056930", Offset = "0x6055730", VA = "0x186056930")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6056E30", Offset = "0x6055C30", VA = "0x186056E30")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6056790", Offset = "0x6055590", VA = "0x186056790")]
		private static float FDFPLGOIOIC(Vector3 NEFNDKLHPML)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x60568A0", Offset = "0x60556A0", VA = "0x1860568A0")]
		public void SetContentsVisibility(bool ACHNONJBHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x60567B0", Offset = "0x60555B0", VA = "0x1860567B0", Slot = "5")]
		public void OnChangedDistanceBand(IMIGBJOIFIN JCCAIAGCGGH, IMIGBJOIFIN MGHFFGCLDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "6")]
		public void OnChangedVisibility(bool EEPDJDHMPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x60567E0", Offset = "0x60555E0", VA = "0x1860567E0")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x60570C0", Offset = "0x6055EC0", VA = "0x1860570C0")]
		public CullableBatchLOD()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7E28D0", Offset = "0x7E16D0", VA = "0x1807E28D0", Slot = "4")]
		private Transform COHDHAFAPPE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RecRoom.NoEngine.Common.Preserve]
	[ExecuteInEditMode]
	public class CullableBatchLODMaterialData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Vector4[] baseColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Vector4[] specColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Vector4[] emissionColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Vector4[] halfProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Vector4[] secondaryTextureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[FormerlySerializedAs("renderer")]
		public MeshRenderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public CullableBatchLODMaterialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchShaderManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x60570E0", Offset = "0x6055EE0", VA = "0x1860570E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public CullableBatchShaderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RecRoom.NoEngine.Common.Preserve]
	[ExecuteInEditMode]
	public class RunTimeTextureAtlasData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x605C6B0", Offset = "0x605B4B0", VA = "0x18605C6B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x605C6B0", Offset = "0x605B4B0", VA = "0x18605C6B0")]
		private void KGEBFEBEOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public RunTimeTextureAtlasData()
		{
		}
	}
}
namespace RecRoom.ProBuilder
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[AddComponentMenu(null)]
	public class AGProBuilderStub : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
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
