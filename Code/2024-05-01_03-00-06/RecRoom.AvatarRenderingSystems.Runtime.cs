using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using RecRoom.Avatars;
using RecRoom.Core.Studio;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : KGHKLAJDNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x60BD470", Offset = "0x60BC270", VA = "0x1860BD470", Slot = "4")]
		public override void GEBEKKCKBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class RecNetCDNAssetReference : AssetReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private RecNetCDNKey key;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B1F00", Offset = "0x7B0D00", VA = "0x1807B1F00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x60CBD90", Offset = "0x60CAB90", VA = "0x1860CBD90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60CBCC0", Offset = "0x60CAAC0", VA = "0x1860CBCC0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60CBD50", Offset = "0x60CAB50", VA = "0x1860CBD50")]
		public RecNetCDNAssetReference(RecNetCDNKey OBPLDLNDJLE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string bundleUrl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string itemPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<RecNetCDNKey> Dependencies;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7B1ED0", Offset = "0x7B0CD0", VA = "0x1807B1ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60CBDD0", Offset = "0x60CABD0", VA = "0x1860CBDD0")]
		public static RecNetCDNKey LPIPAFGBBLC(string PFLPNBKPCGB, string DMCGEFKMDNO = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5906420", Offset = "0x5905220", VA = "0x185906420")]
		public void INGHJKCJIJN(string BAMLFIHJCFF, string CBBELKKKCJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60CBE60", Offset = "0x60CAC60", VA = "0x1860CBE60")]
		public RecNetCDNKey NLLIHELPJOO(string HDNLJKMHFKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60CBF10", Offset = "0x60CAD10", VA = "0x1860CBF10")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[HEFMNMOEFLM]
public class BMHKMPCOEHH : MFEIJKNJFBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> OBBELEBHECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> FLLEMBDLFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> FODODIMKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> OEMGNEJJAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> NHJGMOMALEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> IAPNEJGNLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> HNJPNIJGHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator PBKBAGEHLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected AAODJCMCBJN JBDGLNOCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte EGIMLGGADKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> BEHKCOGDAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> NHOPBFKAPKL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60B4E90", Offset = "0x60B3C90", VA = "0x1860B4E90", Slot = "4")]
	public void MAJPOCGNALJ(Mesh ANKNNGGBGOG, Matrix4x4 NMGJJMPPHPJ, byte[] CJJFPLELHMD, bool KMMFBCPPLLI = false, CPCJFDHFPLD.LCMFNGJPNFA GHOKPOKIEAM = (CPCJFDHFPLD.LCMFNGJPNFA)0, int JBANKMJGFPD = -1, bool LKMDPNIMMBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x60B4D20", Offset = "0x60B3B20", VA = "0x1860B4D20", Slot = "5")]
	public void APHFEADHBJD(Allocator ACBNCIGINAO, AAODJCMCBJN CJIBFKKKDHM, byte PEFGMPNALNC, [Optional] IList<int> LJLNLKDOHKL, [Optional] IList<int> CNBDHBBDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60B4D60", Offset = "0x60B3B60", VA = "0x1860B4D60")]
	private static void CHFEGNNDFDJ(Mesh ANKNNGGBGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60B5350", Offset = "0x60B4150", VA = "0x1860B5350")]
	public BMHKMPCOEHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HEFMNMOEFLM]
public struct LLOOIBHDADI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NDPBBCAGDEC EHNCEKCBLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int MFILOFEPBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EBLOPMMMGFJ HPJPGAPMOIM;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60BA8F0", Offset = "0x60B96F0", VA = "0x1860BA8F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[HEFMNMOEFLM]
[NativeContainer]
public struct EBLOPMMMGFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct IDCNOOAMMFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Vector3 JDEDMCCJIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Vector3 ELKFIDDLEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector4 CKPPHJKDBDN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct KMNOIGLCLDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public half MLAHKPOLKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public half HGMHIMMDCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public half OKLIDGPNAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public half CBFAJIGBKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public byte BGKAJMHGMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public byte FLOIKJNANOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte JOIAHPMEIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte CAKGGPGCKHE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct IPGDJCBGCAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public half4 BGJPICBMDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public half2 EGGJBFOKENO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct OEPNMMPANJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half4 BGJPICBMDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half2 EGGJBFOKENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half2 HMOJFMMPKCP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct FMPHDECPONL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half4 BGJPICBMDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public half2 EGGJBFOKENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half2 HMOJFMMPKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half2 BHPCJPCJPMG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct EMEKHLKJNLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half4 BGJPICBMDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half2 EGGJBFOKENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 HMOJFMMPKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half2 BHPCJPCJPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 ELDPJMFMHFA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct KOGAEOCANCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public float MLAHKPOLKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float HGMHIMMDCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float OKLIDGPNAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float CBFAJIGBKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int BGKAJMHGMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int FLOIKJNANOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int JOIAHPMEIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int CAKGGPGCKHE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct AGCFIICFBND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Color BGJPICBMDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Vector2 EGGJBFOKENO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct IDKCHONEICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Color BGJPICBMDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Vector2 EGGJBFOKENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Vector2 HMOJFMMPKCP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct JBODPCNGBPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Color BGJPICBMDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Vector2 EGGJBFOKENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Vector2 HMOJFMMPKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Vector2 BHPCJPCJPMG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct IGOCKANCPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Color BGJPICBMDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Vector2 EGGJBFOKENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 HMOJFMMPKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Vector2 BHPCJPCJPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 ELDPJMFMHFA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool IDHGNACBKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<IDCNOOAMMFG> MAFGKIKFAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<IPGDJCBGCAL> KEBOFGPKKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<OEPNMMPANJO> LBEHAEGMGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<FMPHDECPONL> MEDPFFLACHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<EMEKHLKJNLC> JPGEIBPJEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<KMNOIGLCLDM> IBJLMOHPPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<AGCFIICFBND> HPOMNDECPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<IDKCHONEICP> EHLFPPGDGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<JBODPCNGBPI> GHBEJNFPMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<IGOCKANCPKH> BGEEACADHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<KOGAEOCANCO> ILAALMABLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> NONDLDMHAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> PIOMOJOOPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<int> MBNCAFGKNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> HFCHOPNOGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<int> CLMCFHNMLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> GFKIGGNCIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> DMMAFJELLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<BoneWeight> IJGEMOPBOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> AHMCCAODOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool MNINBKEKMHJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int POINFOLDDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60B72F0", Offset = "0x60B60F0", VA = "0x1860B72F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60B7310", Offset = "0x60B6110", VA = "0x1860B7310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OODIBNCGDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60B7300", Offset = "0x60B6100", VA = "0x1860B7300")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60B6EE0", Offset = "0x60B5CE0", VA = "0x1860B6EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MFINMOJLIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60B6EC0", Offset = "0x60B5CC0", VA = "0x1860B6EC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60B60C0", Offset = "0x60B4EC0", VA = "0x1860B60C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KHLCGPFBONM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60B6050", Offset = "0x60B4E50", VA = "0x1860B6050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60B7640", Offset = "0x60B6440", VA = "0x1860B7640")]
	public EBLOPMMMGFJ(int PPEAENBDHAC, int PBJMADGCGJN, int DBJNJDGBDJJ, int GHHECOBFBGO, Allocator ACBNCIGINAO, int PANPHGKKEDI, HAAICPJEEGF JJOJCNLHJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60B5E90", Offset = "0x60B4C90", VA = "0x1860B5E90")]
	public void ELKCFLJHKEP(int AELAKOMEEDP, Vector3 ALCIJOKMJPM, Vector3 INMKDHNNFDB, Vector4 HKJAKBPEJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60B5920", Offset = "0x60B4720", VA = "0x1860B5920")]
	public void DOKLCEPODKD(int AELAKOMEEDP, BoneWeight BNFLLGIBKJN, NativeSlice<byte> CJJFPLELHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60B7320", Offset = "0x60B6120", VA = "0x1860B7320")]
	public Color PKJJKEHDJJJ(int AELAKOMEEDP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60B6EF0", Offset = "0x60B5CF0", VA = "0x1860B6EF0")]
	public void NFHKBNFNKPL(int AELAKOMEEDP, Color JJPJCHPNNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60B5580", Offset = "0x60B4380", VA = "0x1860B5580")]
	public void DFLLJBGGOIL(byte PIJKDAAHDLK, int AELAKOMEEDP, Vector2 ACBCKFMKPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60B6ED0", Offset = "0x60B5CD0", VA = "0x1860B6ED0")]
	public void MLKFLDEOKNK(int AELAKOMEEDP, int KDEMGAJLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60B5FF0", Offset = "0x60B4DF0", VA = "0x1860B5FF0")]
	public bool GKKCEEKBDNN(int PIJKDAAHDLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60B5F20", Offset = "0x60B4D20", VA = "0x1860B5F20")]
	public void GHPFLHDBPDI(int HAOOOCOPIEM, int PJPGJICIKPG, int PDCHCFIOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60B5C50", Offset = "0x60B4A50", VA = "0x1860B5C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60B60D0", Offset = "0x60B4ED0", VA = "0x1860B60D0")]
	public Mesh JKKBMDFDHPH([Optional] string COABOFKGCJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
[HEFMNMOEFLM]
[NativeContainer]
public struct NDPBBCAGDEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Mesh.MeshDataArray CKEJICFBGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<int> CONNKDGKPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<int> JOLOBPPKGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeArray<BoneWeight> IJGEMOPBOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<Matrix4x4> EHHGGPGIONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> KDMKPCFBKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<byte> MJKEGNGKPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> NMOEDEGPIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<int> FECIJFEOLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NativeArray<sbyte> DPGOHEOBPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public NativeArray<byte> FELKNFCKJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<bool> LKMDPNIMMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> JBANKMJGFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeArray<int> IEPBPHAGNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private bool MNINBKEKMHJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int OECAPJDPCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60BDAC0", Offset = "0x60BC8C0", VA = "0x1860BDAC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PIICOCMHKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60BDAE0", Offset = "0x60BC8E0", VA = "0x1860BDAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JPNGEKKBLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60BD850", Offset = "0x60BC650", VA = "0x1860BD850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NMPJGPBOEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60BD920", Offset = "0x60BC720", VA = "0x1860BD920")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60BDE30", Offset = "0x60BCC30", VA = "0x1860BDE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int POINFOLDDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x60BDD60", Offset = "0x60BCB60", VA = "0x1860BDD60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60BDD70", Offset = "0x60BCB70", VA = "0x1860BDD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GCAIIHOOEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60BDAB0", Offset = "0x60BC8B0", VA = "0x1860BDAB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60BDAD0", Offset = "0x60BC8D0", VA = "0x1860BDAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AAODJCMCBJN GAHBMNFPALE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60BDD50", Offset = "0x60BCB50", VA = "0x1860BDD50")]
		get
		{
			return default(AAODJCMCBJN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60BD840", Offset = "0x60BC640", VA = "0x1860BD840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte IFLMJMPAOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60BDD40", Offset = "0x60BCB40", VA = "0x1860BDD40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60BDAA0", Offset = "0x60BC8A0", VA = "0x1860BDAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public GJPLKHMLHNJ OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60BDAF0", Offset = "0x60BC8F0", VA = "0x1860BDAF0")]
		get
		{
			return default(GJPLKHMLHNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60BDE40", Offset = "0x60BCC40", VA = "0x1860BDE40")]
	public NDPBBCAGDEC(IList<Mesh> KOBCHLDHJOH, IList<Matrix4x4> KGMBBLHMCIK, IList<bool> LKMDPNIMMBG, byte PEFGMPNALNC, IList<byte[]> APEBIIBMAFI, IList<int> FGECEKJMDGN, IList<bool> MMJEMOGKNCD, IList<int> JBANKMJGFPD, IList<int> LJLNLKDOHKL, IList<int> IAODNPPAENK, Allocator ACBNCIGINAO, AAODJCMCBJN CJIBFKKKDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60BDD80", Offset = "0x60BCB80", VA = "0x1860BDD80")]
	public EBLOPMMMGFJ PCINBPIHBBH(Allocator ACBNCIGINAO, HAAICPJEEGF JJOJCNLHJPA)
	{
		return default(EBLOPMMMGFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60BD930", Offset = "0x60BC730", VA = "0x1860BD930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[HEFMNMOEFLM]
public class BDPAODODNDN : BMHKMPCOEHH
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60B4C20", Offset = "0x60B3A20", VA = "0x1860B4C20")]
	public NDPBBCAGDEC NMKOGOCBLAA()
	{
		return default(NDPBBCAGDEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60B4D10", Offset = "0x60B3B10", VA = "0x1860B4D10")]
	public BDPAODODNDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct GJPLKHMLHNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Mesh.MeshData OAHLOODJAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeSlice<BoneWeight> IJGEMOPBOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeSlice<byte> HOMJCKGCHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int OJBOIABICGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Matrix4x4 EJEACMJOLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public int NKDHOCEEIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeSlice<byte> CJJFPLELHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool GBPECGOLKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public int FLJNMOAFLOE;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PLKKDKPCCKE : EPNBCNMGLDK
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private abstract class EDDJBDAPNOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly ECLNJFJJGAI HJOEMCAAFDP;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool JNOIPICIFFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual bool OPIAPPGDEII
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual CPCJFDHFPLD.LCMFNGJPNFA NKDHOCEEIKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "6")]
			get
			{
				return default(CPCJFDHFPLD.LCMFNGJPNFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BGLLDANHJIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1343400", Offset = "0x1342200", VA = "0x181343400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool CENEOAKLFLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x60B7FE0", Offset = "0x60B6DE0", VA = "0x1860B7FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool EFCMHJLHJKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x60B7FC0", Offset = "0x60B6DC0", VA = "0x1860B7FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		protected EDDJBDAPNOD(ECLNJFJJGAI OADDCIPNFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract LKLLCIBDBNN HGALHJDIMCE(int[] ADJKLHFOBPH, List<LNKPACKCPAH> OHFPMAGBPAI, List<LNKPACKCPAH> LKINDHDEEMN);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract BPMIEPCDJJC EMPGMLLLHBI(uint AKDDGFBBJPG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class NMLOODJLPCP : EDDJBDAPNOD
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JFGFBCCNJDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public BCJOGHANCKE<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public NMLOODJLPCP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public JFGFBCCNJDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x60BA130", Offset = "0x60B8F30", VA = "0x1860BA130")]
			internal void IHMHIBDAJMD(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly AvatarSkinAssetItem.DCKKKMJJBGA KOMGJDPGBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly AssetReference NIGNPFFIFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly CPCJFDHFPLD.LCMFNGJPNFA DANBAOJNCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly BEPKGBHJAIF? LJPEDJIJMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly Material[] JCEDJFNCIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private SkinnedMeshRenderer[] MGDALJAJJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private AvatarSkinAssetItem AIOFBNPMEPL;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override CPCJFDHFPLD.LCMFNGJPNFA NKDHOCEEIKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7B5040", Offset = "0x7B3E40", VA = "0x1807B5040", Slot = "6")]
			get
			{
				return default(CPCJFDHFPLD.LCMFNGJPNFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x60BF6F0", Offset = "0x60BE4F0", VA = "0x1860BF6F0")]
		public NMLOODJLPCP(AvatarSkinAssetItem.DCKKKMJJBGA IPAKHIBBENL, AssetReference GOCPFIMBDCM, Material AHBLBFJIPEH, ECLNJFJJGAI EFIKBHICMCP, CPCJFDHFPLD.LCMFNGJPNFA JGEOEOBDEBM = (CPCJFDHFPLD.LCMFNGJPNFA)0, [Optional] BEPKGBHJAIF? IFJBMIAAOOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x60BF5E0", Offset = "0x60BE3E0", VA = "0x1860BF5E0")]
		public NMLOODJLPCP(AvatarSkinAssetItem.DCKKKMJJBGA IPAKHIBBENL, AssetReference GOCPFIMBDCM, Material AHBLBFJIPEH, CPCJFDHFPLD.LCMFNGJPNFA JGEOEOBDEBM = (CPCJFDHFPLD.LCMFNGJPNFA)0, [Optional] BEPKGBHJAIF? IFJBMIAAOOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x60BF350", Offset = "0x60BE150", VA = "0x1860BF350", Slot = "7")]
		public override LKLLCIBDBNN HGALHJDIMCE(int[] ADJKLHFOBPH, List<LNKPACKCPAH> OHFPMAGBPAI, List<LNKPACKCPAH> LKINDHDEEMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x60BF080", Offset = "0x60BDE80", VA = "0x1860BF080", Slot = "8")]
		public override BPMIEPCDJJC EMPGMLLLHBI(uint AKDDGFBBJPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60BF570", Offset = "0x60BE370", VA = "0x1860BF570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class LNGGCDGPLON : EDDJBDAPNOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly JAEIDGMCOAF HAJFADNGOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private BCJOGHANCKE<ODKEHMDIDPO> IJLDHCCIHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ODKEHMDIDPO KNGJBEEBDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private BCJOGHANCKE<Material>[] FJIKDJBENKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<Material> BINAPAPFEAG;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool JNOIPICIFFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool OPIAPPGDEII
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x60BC590", Offset = "0x60BB390", VA = "0x1860BC590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1B4E590", Offset = "0x1B4D390", VA = "0x181B4E590")]
		public LNGGCDGPLON(ECLNJFJJGAI OADDCIPNFHL, JAEIDGMCOAF MKHCCDDAEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x60BCDA0", Offset = "0x60BBBA0", VA = "0x1860BCDA0", Slot = "7")]
		public override LKLLCIBDBNN HGALHJDIMCE(int[] ADJKLHFOBPH, List<LNKPACKCPAH> OHFPMAGBPAI, List<LNKPACKCPAH> LKINDHDEEMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x60BCB50", Offset = "0x60BB950", VA = "0x1860BCB50", Slot = "8")]
		public override BPMIEPCDJJC EMPGMLLLHBI(uint AKDDGFBBJPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x60BC3A0", Offset = "0x60BB1A0", VA = "0x1860BC3A0")]
		public BPMIEPCDJJC AALKOIJLADI(GameObject HBFKAEJMBJE, uint AKDDGFBBJPG, bool PIIEGKCONLJ, bool LFGFBAGOHNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x60BC7F0", Offset = "0x60BB5F0", VA = "0x1860BC7F0")]
		public static bool EBFNNBKMJOD(Renderer[] IODPCCBHBIF, string KMNNNCJJCJF, [Out] Renderer BKHPPMLJGAJ, [Out] Renderer PNDPOLCIIBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x60BD420", Offset = "0x60BC220", VA = "0x1860BD420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60BC5F0", Offset = "0x60BB3F0", VA = "0x1860BC5F0")]
		private (BCJOGHANCKE<ODKEHMDIDPO>, BCJOGHANCKE<Material>[]) ADLCDKNJKHG()
		{
			return default((BCJOGHANCKE<ODKEHMDIDPO>, BCJOGHANCKE<Material>[]));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x60BD1F0", Offset = "0x60BBFF0", VA = "0x1860BD1F0")]
		private BCJOGHANCKE<Material>[] IPCLLLDNDKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3AB0", Offset = "0x3DD28B0", VA = "0x183DD3AB0")]
		[CompilerGenerated]
		private void MGDBJBEEACN(ODKEHMDIDPO FJMMLPMLLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60BCC80", Offset = "0x60BBA80", VA = "0x1860BCC80")]
		[CompilerGenerated]
		private void ENFAAJEAGOK(BCJOGHANCKE<Material> GNMFFDAAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x60BD370", Offset = "0x60BC170", VA = "0x1860BD370")]
		[CompilerGenerated]
		private void NMPEHKOMBPP(Material FJMMLPMLLGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FJABHLIMIPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public PLKKDKPCCKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public EEFNJOFHHBM buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public FJABHLIMIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x60B81D0", Offset = "0x60B6FD0", VA = "0x1860B81D0")]
		internal void PDENJKFFNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x60B81B0", Offset = "0x60B6FB0", VA = "0x1860B81B0")]
		internal void NNLJDACLGGN(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60B8120", Offset = "0x60B6F20", VA = "0x1860B8120")]
		internal void LNJBGOKIGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x60B8090", Offset = "0x60B6E90", VA = "0x1860B8090")]
		internal void CIHBGCIKJKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		internal LKLLCIBDBNN MDBPGLEILLJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class AJCFBBIBKED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public FJABHLIMIPD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AJCFBBIBKED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x60B4900", Offset = "0x60B3700", VA = "0x1860B4900")]
		internal GMIBLELGCJA HNIOIPEACGP(int lod)
		{
			return default(GMIBLELGCJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KPMEAKAMIBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<EEFNJOFHHBM> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public KPMEAKAMIBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x60BA7C0", Offset = "0x60B95C0", VA = "0x1860BA7C0")]
		internal void LJEGAFFMJKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AKBIFLNFMCJ : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public PLKKDKPCCKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<EDDJBDAPNOD> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public List<EEFNJOFHHBM> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Func<int, GMIBLELGCJA> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public KBGLCINGGBG materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public AKBIFLNFMCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60B49C0", Offset = "0x60B37C0", VA = "0x1860B49C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60B4BD0", Offset = "0x60B39D0", VA = "0x1860B4BD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FAPCOLNCPCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public PLKKDKPCCKE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public FAPCOLNCPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60B8040", Offset = "0x60B6E40", VA = "0x1860B8040")]
		internal LKLLCIBDBNN MHNOHPPOMHN(EDDJBDAPNOD p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EPPBALAKLHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public IKFJONDKNGE cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public EPPBALAKLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x819EF0", Offset = "0x818CF0", VA = "0x180819EF0")]
		internal void ICPFONJJHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAA0", Offset = "0x8BD8A0", VA = "0x1808BEAA0")]
		internal void JAJEFCHBPPJ(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OKIFHFHMIFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public PLKKDKPCCKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public OKIFHFHMIFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PGAEEBLIFIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public EBLOPMMMGFJ defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NDPBBCAGDEC defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public OKIFHFHMIFA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public PGAEEBLIFIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x60BF800", Offset = "0x60BE600", VA = "0x1860BF800")]
		internal void MMFLOPBPMOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x60BFA30", Offset = "0x60BE830", VA = "0x1860BFA30")]
		internal void OOHAMCAEADA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JHBDCCJADEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public BAAIHFMJMEH legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public PILNOFHNOJF legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public OKIFHFHMIFA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public JHBDCCJADEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x60BA590", Offset = "0x60B9390", VA = "0x1860BA590")]
		internal void PJIHFOPPDPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x60BA520", Offset = "0x60B9320", VA = "0x1860BA520")]
		internal void GMFBKPJKNJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MBMENNEBJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public IKFJONDKNGE cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public JAEIDGMCOAF avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public PLKKDKPCCKE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MBMENNEBJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x60BD500", Offset = "0x60BC300", VA = "0x1860BD500")]
		internal LKLLCIBDBNN BJAAOCCILCG(LEEPOJHPGMD item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x60BD800", Offset = "0x60BC600", VA = "0x1860BD800")]
		internal void JPLIFBMFNHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class EPLIDBAENAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public BCJOGHANCKE<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public EPLIDBAENAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x60B7FF0", Offset = "0x60B6DF0", VA = "0x1860B7FF0")]
		internal void AEKLDNFIOMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class AFLGJDODJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public ECLNJFJJGAI overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AFLGJDODJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x60B4880", Offset = "0x60B3680", VA = "0x1860B4880")]
		internal bool EICLPBMFHKL(KeyValuePair<string, JAEIDGMCOAF> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private AvatarConfiguration JOKHNAHLPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Transform KAEJKEKALOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private AssetReference NIGNPFFIFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private GameObject LAAJFECBCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private GameObject LPKACFFHENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private SkinnedMeshRenderer OOJOCFLFIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Transform[] HHFMGDODGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Matrix4x4[] CMLCAHMKGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Material NILBENKINKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Material PHLCBGFCFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Material EMIMDAGIPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private Shader KCOLMEOICCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private Shader OBBBJFLGLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Animator HFKBHCNEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Renderer[] GCNBHCNIPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private CPCJFDHFPLD.LCMFNGJPNFA EHHNKIDKNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Color JKBCNBBEOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Color GPJNKAOKNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Color NLDLHFDADEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Color? GHJGPCHGILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Color? NHGOLJNOILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Color? ECKLDOPKHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Color? JKHGMDKFEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Texture2D FFPIPCGPLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Texture2D GJLGJDPNHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[CanBeNull]
	private JAEIDGMCOAF LBFLMNJJIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Texture EICOJEKHCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Color FJOFGEHNBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Dictionary<Renderer, KBGLCINGGBG> KNHABNCLEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Dictionary<Renderer, KBGLCINGGBG> FMMMDMEAJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Dictionary<string, List<CHFCPJDDFME>> KIBJLGAMGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Dictionary<string, List<CHFCPJDDFME>> FEFADEFFMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly List<LNKPACKCPAH> OMFGCDNCPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<LNKPACKCPAH> NNOEMNLBAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<LNKPACKCPAH> JBKIFAKEFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<LNKPACKCPAH> BCCKEJJMBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Dictionary<CHFCPJDDFME, Material> EHEMJIHKKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Dictionary<CHFCPJDDFME, Material> OLPCMMJMGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private SkinnedMeshRenderer[] DDAMFGOFOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private SkinnedMeshRenderer[] KFLJCNKKJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer[] KIAPBDAEDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private SkinnedMeshRenderer[] JDIDBOKJGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<string, BCJOGHANCKE<Texture2D>> PPBKNMEEBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Dictionary<string, BCJOGHANCKE<Texture2D>> DMADJEDNMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private FitMeshHemisphere LINAGFJFBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool BLHLBGHCINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private PMDHNMGMOEM EDKCNFNILGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool JBBONDOCHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private AnchorParamsRestrictions DKECJMPMPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool OGIEHDGABOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Transform JIGPONBEELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Transform BLKCFJMEGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool GBPGHLKKLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x201")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool BJHFFIHAFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Vector3 MMGCCAKCAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Quaternion LEOFMMDFABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Vector2 BFCINKBOGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private FitMeshHemisphere ANJILFNMKCK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Material NJPBFLLMMLC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Material LCNKDFELJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Dictionary<string, JAEIDGMCOAF> HGAAPPFNPJA;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int BDDPGEKEEGD;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int EEBHBKBKOPL;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int KANPEKNDHHF;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int EHNJILBDAAP;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int HDIHMKOKKOL;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int FGPLGJMONLE;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int GCDBFPGBALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly BFNGIAHHPKE NDCOAMMHKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly BFNGIAHHPKE FONMJOLAPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool NKJLPEGFIGA;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static Lazy<EDCCCCKFKJD> EJBCPBEHIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Lazy<LJLPOIOPFKK> ENOJILPCNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Lazy<PKFLFFLCEJK> HABDFALPPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private List<Action> MEJNEDBJDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private CBPHCAMMFPP HCCNCOLKCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private SkinnedMeshRenderer[] PFPJJBHKANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int DFBGJOELNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool OGEMLKMGBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int LACNCIBIBFB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BJJBBKPOOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x60CA9E0", Offset = "0x60C97E0", VA = "0x1860CA9E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60C2D10", Offset = "0x60C1B10", VA = "0x1860C2D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool APGJDIMOHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xE4EA20", Offset = "0xE4D820", VA = "0x180E4EA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material GOLFHLFEPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60CA850", Offset = "0x60C9650", VA = "0x1860CA850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material EOMCHJADKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x60C1DC0", Offset = "0x60C0BC0", VA = "0x1860C1DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool CIPCGKNEMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static EDCCCCKFKJD KJGBIBABCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60C1670", Offset = "0x60C0470", VA = "0x1860C1670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private LJLPOIOPFKK OFOHNNOKLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60C5DB0", Offset = "0x60C4BB0", VA = "0x1860C5DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private PKFLFFLCEJK EMAHLFPOOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60C5F70", Offset = "0x60C4D70", VA = "0x1860C5F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BFNGIAHHPKE HKBKMJAEHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A6660", Offset = "0x9A5460", VA = "0x1809A6660", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BFNGIAHHPKE JFHKLHPJNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9A5DF0", Offset = "0x9A4BF0", VA = "0x1809A5DF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public SkinnedMeshRenderer[] EKDCCGONDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1244860", Offset = "0x1243660", VA = "0x181244860", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Renderer[] FABMDBKGPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7AE4C0", Offset = "0x7AD2C0", VA = "0x1807AE4C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DAPBFAIHPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x60C0E50", Offset = "0x60BFC50", VA = "0x1860C0E50", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public CPCJFDHFPLD.LCMFNGJPNFA LIBACJOJAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xE9FCE0", Offset = "0xE9EAE0", VA = "0x180E9FCE0", Slot = "18")]
		get
		{
			return default(CPCJFDHFPLD.LCMFNGJPNFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HDMEPFAEHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x847F40", Offset = "0x846D40", VA = "0x180847F40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x60BFC00", Offset = "0x60BEA00", VA = "0x1860BFC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool MGPCHFOOFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60C5EC0", Offset = "0x60C4CC0", VA = "0x1860C5EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private static bool JLDOFAAMBDI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x60C2080", Offset = "0x60C0E80", VA = "0x1860C2080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x60CB3D0", Offset = "0x60CA1D0", VA = "0x1860CB3D0")]
	public PLKKDKPCCKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x60C47F0", Offset = "0x60C35F0", VA = "0x1860C47F0", Slot = "21")]
	public void HBPIHILNAPB(OMOLKENECLO EHDCMDEEDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60C2220", Offset = "0x60C1020", VA = "0x1860C2220", Slot = "22")]
	public void EMKMCINDNGE(DIAKCGKHGHK GCNIEFBBOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x60BFC00", Offset = "0x60BEA00", VA = "0x1860BFC00", Slot = "4")]
	public void ABFFIICNFCB(int AKDDGFBBJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x60C22A0", Offset = "0x60C10A0", VA = "0x1860C22A0", Slot = "9")]
	public void EMODODINBFC(OOEFNIKLCCO PPGNBOOJHPH, Texture2D AOHFCHDJECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60CA520", Offset = "0x60C9320", VA = "0x1860CA520", Slot = "10")]
	public void NLKDAJLJAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60C4D10", Offset = "0x60C3B10", VA = "0x1860C4D10", Slot = "11")]
	public bool ICHEGAOMNIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60BFF50", Offset = "0x60BED50", VA = "0x1860BFF50", Slot = "8")]
	public void AGFCIBLOHOB(MDNKCLMDPPG DIAJHJLPHFI, Color? BGJPICBMDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60C3EB0", Offset = "0x60C2CB0", VA = "0x1860C3EB0")]
	private void GAEFGLLPKOG(Action ODNKHGNEMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60C5FC0", Offset = "0x60C4DC0", VA = "0x1860C5FC0", Slot = "5")]
	public void KIFLEAJKGHK(JAEIDGMCOAF NMEKMFADAJA, Texture BCFPKFCOPOP, Color FAPEDHOBMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60C2D10", Offset = "0x60C1B10", VA = "0x1860C2D10", Slot = "6")]
	public void FFBKMHDHKEE(bool COKBMAEBFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x99F4D0", Offset = "0x99E2D0", VA = "0x18099F4D0", Slot = "7")]
	public void BIFHCDGJNKM(CBPHCAMMFPP AHMCCAODOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x60C62B0", Offset = "0x60C50B0", VA = "0x1860C62B0", Slot = "14")]
	public EEFNJOFHHBM LADBEIENEKA(MEJCJKHPGID NMKAMCPLFKJ, bool AECLAFBCBNA, int[] LPINENDBGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x60C7CE0", Offset = "0x60C6AE0", VA = "0x1860C7CE0", Slot = "15")]
	public void LEOGAJDGJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60CAAA0", Offset = "0x60C98A0", VA = "0x1860CAAA0")]
	private bool PGGGCECHKJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xE9FFA0", Offset = "0xE9EDA0", VA = "0x180E9FFA0", Slot = "19")]
	public void KLCMHOMIPPK(CPCJFDHFPLD.LCMFNGJPNFA JHJOFPNJOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60CA5A0", Offset = "0x60C93A0", VA = "0x1860CA5A0")]
	private bool OBBDCADHIHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60C9CC0", Offset = "0x60C8AC0", VA = "0x1860C9CC0")]
	private EEFNJOFHHBM MHCAIHAGLDN(bool AECLAFBCBNA, List<EDDJBDAPNOD> PLIMBPDHOBH, int[] LPINENDBGME, Func<int, GMIBLELGCJA> ONLDMFCOKBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60C50A0", Offset = "0x60C3EA0", VA = "0x1860C50A0")]
	[IteratorStateMachine(typeof(AKBIFLNFMCJ))]
	private IEnumerator<KMOACDBBKNB> IFCPPHJCDCE(bool AECLAFBCBNA, List<EDDJBDAPNOD> PLIMBPDHOBH, int[] LPINENDBGME, Func<int, GMIBLELGCJA> ONLDMFCOKBB, KBGLCINGGBG LNHGPGICDKJ, Material EEJEEPIIKCC, List<EEFNJOFHHBM> MMIKKGMHMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60CABE0", Offset = "0x60C99E0", VA = "0x1860CABE0")]
	private EEFNJOFHHBM PGKOJMIEKAN(List<EDDJBDAPNOD> PLIMBPDHOBH, int[] LPINENDBGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60C82D0", Offset = "0x60C70D0", VA = "0x1860C82D0")]
	private DPFFPCFAMJN MGPMBHBHNCL(List<EDDJBDAPNOD> PLIMBPDHOBH, int AKDDGFBBJPG, bool AECLAFBCBNA, GMIBLELGCJA NLIBJLKDDFN, bool ENNBAOOOPHH, KBGLCINGGBG LNHGPGICDKJ, Material EEJEEPIIKCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60C7BC0", Offset = "0x60C69C0", VA = "0x1860C7BC0")]
	private void LDLBNGBMEEA(SkinnedMeshRenderer POOEFCFCCLE, Mesh ANKNNGGBGOG, List<Material> PLNMCHGKHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60BFAA0", Offset = "0x60BE8A0", VA = "0x1860BFAA0")]
	private static Material ABFBBBIJNGH(Dictionary<CHFCPJDDFME, Material> IOMDOLANIHJ, Material HLBEHBFKABC, IACLPKIDDKN ODAPNLKDOAE, JLGDBEPAMEA OIFKHNIKDFF, ECLNJFJJGAI EFIKBHICMCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60C0BF0", Offset = "0x60BF9F0", VA = "0x1860C0BF0")]
	private static IACLPKIDDKN BKPKPCILHDC(EDDJBDAPNOD COJOMOHPPMI, int GOABGOBPDMK)
	{
		return default(IACLPKIDDKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60C2490", Offset = "0x60C1290", VA = "0x1860C2490")]
	private void EPHFEJMOGNE(int JLNHOEJOONL, Material LKFHNDFBKCD, EDDJBDAPNOD COJOMOHPPMI, [Out] Texture2D FHLKBOHDCJL, [Out] Vector4 KNLJNFADLPJ, [Out] Texture2D NNDLCDMPLOI, [Out] Texture2D KOPENINNDNE, [Out] Texture2D EOCHMIBJJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60C16E0", Offset = "0x60C04E0", VA = "0x1860C16E0")]
	private void DPKGFJGCPHM(int JLNHOEJOONL, Material LKFHNDFBKCD, EDDJBDAPNOD COJOMOHPPMI, [Out] Color NDABFNMALCA, [Out] Color INPMFBONMCE, [Out] Color FOOKBMNHEKH, [Out] Color PPJLLPEOEGO, [Out] Color NKEFBMBKNLE, [Out] Color PKCLNAICCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60C3C50", Offset = "0x60C2A50", VA = "0x1860C3C50")]
	private bool GABPJEOEHNK(Material LKFHNDFBKCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60CA290", Offset = "0x60C9090", VA = "0x1860CA290")]
	private static Material MOLMHMFJICM(int JLNHOEJOONL, LNGGCDGPLON COJOMOHPPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60C4C20", Offset = "0x60C3A20", VA = "0x1860C4C20")]
	private static JLGDBEPAMEA ICEGLLGNOKO(EDDJBDAPNOD COJOMOHPPMI, int GOABGOBPDMK)
	{
		return default(JLGDBEPAMEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x60C5A30", Offset = "0x60C4830", VA = "0x1860C5A30")]
	private static void IOKNELJDJEM(Dictionary<string, List<CHFCPJDDFME>> PKHKCIJFODK, EDDJBDAPNOD CPLMMIGPLDF, Material HLBEHBFKABC, IACLPKIDDKN DIAJHJLPHFI, JLGDBEPAMEA PPGNBOOJHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60C13A0", Offset = "0x60C01A0", VA = "0x1860C13A0")]
	private static SkinnedMeshRenderer DCCHPMLCGJB(Transform MLHFFLCJDNC, Transform NDNLMADDKDC, SkinnedMeshRenderer[] IODPCCBHBIF, int AKDDGFBBJPG, GMIBLELGCJA NLIBJLKDDFN, bool AECLAFBCBNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60C2DB0", Offset = "0x60C1BB0", VA = "0x1860C2DB0")]
	private void FHMMPNBPNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60C1D30", Offset = "0x60C0B30", VA = "0x1860C1D30")]
	private void EAJPLMEPGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60C09B0", Offset = "0x60BF7B0", VA = "0x1860C09B0")]
	private static void BDPPCPOEOPL(Dictionary<CHFCPJDDFME, Material> IOMDOLANIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x60CA6F0", Offset = "0x60C94F0", VA = "0x1860CA6F0")]
	private static void OMDGPNEMBGG(Dictionary<Renderer, KBGLCINGGBG> GFJCKJLKNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60C3B30", Offset = "0x60C2930", VA = "0x1860C3B30")]
	private void FLPEALOAEGA(SkinnedMeshRenderer[] IODPCCBHBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60C15D0", Offset = "0x60C03D0", VA = "0x1860C15D0")]
	private void DJJDLGPHBAL(SkinnedMeshRenderer IMNCCBFJNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60C1EB0", Offset = "0x60C0CB0", VA = "0x1860C1EB0")]
	private void EJHNGKLOLDA(List<LNKPACKCPAH> MOFAFHLLBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60C4EB0", Offset = "0x60C3CB0", VA = "0x1860C4EB0")]
	private void IEDJDMGHCBM(Dictionary<string, BCJOGHANCKE<Texture2D>> PKHKCIJFODK, bool NBLLJCPNHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x60C03E0", Offset = "0x60BF1E0", VA = "0x1860C03E0")]
	private void AOHEDIMBNJA(Dictionary<string, List<CHFCPJDDFME>> PKHKCIJFODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60C4690", Offset = "0x60C3490", VA = "0x1860C4690")]
	private void GPIKDKMGAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x60C6120", Offset = "0x60C4F20", VA = "0x1860C6120")]
	private void KPNNCLCFEEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60C0460", Offset = "0x60BF260", VA = "0x1860C0460")]
	private void BBCKIELPLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60C28D0", Offset = "0x60C16D0", VA = "0x1860C28D0")]
	private void EPLIJBJPFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60C5CF0", Offset = "0x60C4AF0", VA = "0x1860C5CF0")]
	private void IPOIFDPLOGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60C1BE0", Offset = "0x60C09E0", VA = "0x1860C1BE0")]
	private void EAANHDHGLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60C0DA0", Offset = "0x60BFBA0", VA = "0x1860C0DA0")]
	private void CEJPIHLONEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60CA310", Offset = "0x60C9110", VA = "0x1860CA310")]
	private void NGADEONFHNO(bool HLHIFDILDCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60C1D40", Offset = "0x60C0B40", VA = "0x1860C1D40")]
	private void EFLGPPAFGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60C5E20", Offset = "0x60C4C20", VA = "0x1860C5E20")]
	private void KAEBNENKCME(bool HLHIFDILDCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60C29D0", Offset = "0x60C17D0", VA = "0x1860C29D0")]
	private void FDAOEDEICOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60C7860", Offset = "0x60C6660", VA = "0x1860C7860")]
	private void LBKBEBHNIHA(Material EEJEEPIIKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x60BFE60", Offset = "0x60BEC60", VA = "0x1860BFE60")]
	private void AGCKBLOMFKP(Material EEJEEPIIKCC, Color INPMFBONMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x60C6030", Offset = "0x60C4E30", VA = "0x1860C6030")]
	private void KOIPAMDNGDE(Material EEJEEPIIKCC, Color FOOKBMNHEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60CAEA0", Offset = "0x60C9CA0", VA = "0x1860CAEA0")]
	private void PIPONPDKFCC(Material EEJEEPIIKCC, Color NDABFNMALCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x60C4AB0", Offset = "0x60C38B0", VA = "0x1860C4AB0")]
	private void HKFDIONANJE(Material EEJEEPIIKCC, Texture2D AOHFCHDJECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x60C0B10", Offset = "0x60BF910", VA = "0x1860C0B10")]
	private void BFPCGJIMKGM(Material EEJEEPIIKCC, Texture HENFEMLHBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60C51B0", Offset = "0x60C3FB0", VA = "0x1860C51B0")]
	private void IHECDIDNBIP(Action<KBGLCINGGBG> IKHNKBMOGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60CAF90", Offset = "0x60C9D90", VA = "0x1860CAF90")]
	private void PJAFHDIOAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60C7EE0", Offset = "0x60C6CE0", VA = "0x1860C7EE0")]
	private void LOKECLBKHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60C3F90", Offset = "0x60C2D90", VA = "0x1860C3F90")]
	private EEFNJOFHHBM GAJFJMAICPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60C0FF0", Offset = "0x60BFDF0", VA = "0x1860C0FF0")]
	private void DBFPJIAODDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x60C5370", Offset = "0x60C4170", VA = "0x1860C5370")]
	public void IIDKJOEJDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x60C5030", Offset = "0x60C3E30", VA = "0x1860C5030")]
	private void IEMPEOMEFCE(Vector3 LDNPGPEOBDD, Quaternion FCDMNAEMCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60C5700", Offset = "0x60C4500", VA = "0x1860C5700")]
	private void IILHFOLAPFN(List<EDDJBDAPNOD> BLCGMDBKCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60C3640", Offset = "0x60C2440", VA = "0x1860C3640")]
	public void FIFGCOAOIGI(PMDHNMGMOEM JFJDNJKPOJF, bool HCKBFCKGIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x60C2FC0", Offset = "0x60C1DC0", VA = "0x1860C2FC0")]
	public void FIFGCOAOIGI(PMDHNMGMOEM JFJDNJKPOJF, AnchorParamsRestrictions MHMFONJDHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x89F370", Offset = "0x89E170", VA = "0x18089F370")]
	private static void IBKNMDHHEIK(FitMeshHemisphere NAAMCFPGBLL, Transform DJHJBKBHJHN, PMDHNMGMOEM JFJDNJKPOJF, AnchorParamsRestrictions DHBLOEFICNM, [Out] Vector3 ONAIBAMIBJL, [Out] Quaternion LCPHIJKNEAJ, [Out] PMDHNMGMOEM MFIIPBIBHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60BFC20", Offset = "0x60BEA20", VA = "0x1860BFC20")]
	public void ACKLCLABMCA(Vector2 KMIFNLKMBHA, Vector3 BCIAMAMLPDK, Vector3 JCKPLDNDGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60CA3B0", Offset = "0x60C91B0", VA = "0x1860CA3B0")]
	private void NIDLCLBPBKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x60C4580", Offset = "0x60C3380", VA = "0x1860C4580")]
	private void GEEHJLIEKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x60C8240", Offset = "0x60C7040", VA = "0x1860C8240")]
	[CompilerGenerated]
	private void MBIFEFHOCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x60C5D80", Offset = "0x60C4B80", VA = "0x1860C5D80")]
	[CompilerGenerated]
	private void JBHADDKBNDL(KBGLCINGGBG OOCGDLGKAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x60C0D10", Offset = "0x60BFB10", VA = "0x1860C0D10")]
	[CompilerGenerated]
	private void BPCNOEGEFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x60CA9F0", Offset = "0x60C97F0", VA = "0x1860CA9F0")]
	[CompilerGenerated]
	private void PBDACLONMOB(KBGLCINGGBG OOCGDLGKAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x60CB110", Offset = "0x60C9F10", VA = "0x1860CB110")]
	[CompilerGenerated]
	private void PLADGFHCOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x60C5E00", Offset = "0x60C4C00", VA = "0x1860C5E00")]
	[CompilerGenerated]
	private void JLDCIPBOCFP(KBGLCINGGBG OOCGDLGKAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x60C2D20", Offset = "0x60C1B20", VA = "0x1860C2D20")]
	[CompilerGenerated]
	private void FHGKNGJPGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x60C29A0", Offset = "0x60C17A0", VA = "0x1860C29A0")]
	[CompilerGenerated]
	private void FBBAPLONOFJ(KBGLCINGGBG OOCGDLGKAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x60CA660", Offset = "0x60C9460", VA = "0x1860CA660")]
	[CompilerGenerated]
	private void OHJLNGIBLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60C4E80", Offset = "0x60C3C80", VA = "0x1860C4E80")]
	[CompilerGenerated]
	private void ICMBBEEHAGD(KBGLCINGGBG OOCGDLGKAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x60C4B90", Offset = "0x60C3990", VA = "0x1860C4B90")]
	[CompilerGenerated]
	private void HLOEMMAANPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x60C5F40", Offset = "0x60C4D40", VA = "0x1860C5F40")]
	[CompilerGenerated]
	private void KGHFHDOCIJA(KBGLCINGGBG OOCGDLGKAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x60C4600", Offset = "0x60C3400", VA = "0x1860C4600")]
	[CompilerGenerated]
	private void GEMOAKJJBLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x60C0E20", Offset = "0x60BFC20", VA = "0x1860C0E20")]
	[CompilerGenerated]
	private void CGFJNFPPFEB(KBGLCINGGBG OOCGDLGKAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x60BFDE0", Offset = "0x60BEBE0", VA = "0x1860BFDE0")]
	[CompilerGenerated]
	private void ADGEGBBMLHG(KeyValuePair<string, BCJOGHANCKE<Texture2D>> IFIFPGOBPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x60CAA10", Offset = "0x60C9810", VA = "0x1860CAA10")]
	[CompilerGenerated]
	private void PGFINMAMJKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x60C0430", Offset = "0x60BF230", VA = "0x1860C0430")]
	[CompilerGenerated]
	private void BAJLHKNIGLK(KBGLCINGGBG OOCGDLGKAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x60C0350", Offset = "0x60BF150", VA = "0x1860C0350")]
	[CompilerGenerated]
	private void AHHONENPPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x60C0FC0", Offset = "0x60BFDC0", VA = "0x1860C0FC0")]
	[CompilerGenerated]
	private void CJNBAHGMHOD(KBGLCINGGBG OOCGDLGKAFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FKFDMJOFKDD : MAPDIKIMPAN
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int ONFEGIGHILC;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int PFOICKHMPFF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly int EOKCNJMKNKH;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly int OPNMEBDDCHL;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly int APHKEDIJBEF;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly int CKCJHEELCBG;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly int FEHDHFDKIKO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly int GGHAAMLDGBB;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly int MFONLAECECD;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly int CHFONDOBJDB;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly int GPACJDNCNCP;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly int CGHHIOBGKCI;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly int NBPCNILCFJF;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly int HBHFGHKGPDF;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int FGAPFNFFMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int MJFDONCAGCA;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int AMIKDAKPCHH;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int JKNKPGBCAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private Transform BCMDEMJNPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private Transform GEAGGKFLGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private Transform NGDFJOINHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private Transform PCMDGLJNMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private Transform OAPJDHGJEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Transform HOCONIDIMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Transform EMGBBLHEABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NGIIEKPEOGO BAFOGDDFKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private MaterialPropertyBlock LJPAJJKNNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private SkinnedMeshRenderer[] CPGHNBFLKPI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private MaterialPropertyBlock GMKBBIGEDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x60B8700", Offset = "0x60B7500", VA = "0x1860B8700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x60B87B0", Offset = "0x60B75B0", VA = "0x1860B87B0", Slot = "6")]
	public void HBPIHILNAPB(NGIIEKPEOGO GHPKHOAOIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x60B8780", Offset = "0x60B7580", VA = "0x1860B8780", Slot = "7")]
	public void DIJADLFBDGJ(HBELCEIBMJF DFCCJGDLCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x60B99C0", Offset = "0x60B87C0", VA = "0x1860B99C0", Slot = "4")]
	public void PNCOFKIHGIC(FGBLPFKFEMG ICMBODKHHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60B86A0", Offset = "0x60B74A0", VA = "0x1860B86A0")]
	private Vector2 CENMBDHHFDC(Vector2 BOOFBHEINJG)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60B88B0", Offset = "0x60B76B0", VA = "0x1860B88B0", Slot = "5")]
	public void LBOEHBGIGEH(IFEPJBGCLOH DFCCJGDLCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x60B8360", Offset = "0x60B7160", VA = "0x1860B8360")]
	private void BJDINEKNNJH(IFEPJBGCLOH DABNLIEAAPK, CHGPGFOGKAL DJCOLELPOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60B8280", Offset = "0x60B7080", VA = "0x1860B8280")]
	private void AHLFJOJIOME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x60BA0D0", Offset = "0x60B8ED0", VA = "0x1860BA0D0")]
	public FKFDMJOFKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60B81F0", Offset = "0x60B6FF0", VA = "0x1860B81F0")]
	[CompilerGenerated]
	internal static (float, float) ACIENKCGNLH(float KNEILDPDDMK)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60B8870", Offset = "0x60B7670", VA = "0x1860B8870")]
	[CompilerGenerated]
	internal static Vector4 JNOCBLCCAGM(Vector2 JPLKOMKCHGP, Vector2 HDBPIAOAHOC)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KBGLCINGGBG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private MaterialPropertyBlock ONJELNNILGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public Color? HOKNMDEONDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public Color? ODDNIJHCGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public Color? EBGFAMDCHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public Color? LNPLEAGMHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public Color LJCCLKCLEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public Color PHAMNHHAKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public Color COMFAECHNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public Texture2D BJAGCNONKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public Texture2D EICKDCKKGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Dictionary<CHFCPJDDFME, int> ECCLAHFCBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private IACLPKIDDKN[] NBDAKEADGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private JLGDBEPAMEA[] JOAEDLGDDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public Vector4[] GCMDHJODCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Vector4[] MPPMMBGCDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public Vector4[] HLMALKPJMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Vector4[] LODBLMDCEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public Vector4[] MNAFOMFGFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Vector4[] GNDDNAKHKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<Texture2D> OLOFICCOIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Vector4[] NAEHBFCFFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private List<Texture2D> GAHFLIADGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private float[] BDPBLLNHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private Vector4[] OOGGKEOGAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private float[] MOODEHAIFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public float[] FEFAPMDJCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private List<Texture2D> EEGONMOOMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private float[] KEFIEBBBIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private List<Texture2D> INJKCNJOMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private Vector4[] MHFOIBOMCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private float[] JAFNFOBHPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Vector4[] MKAHMMAAEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public float[] EMKFOAAHNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Texture2DArray JDGOMFPFNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Texture2DArray HGCAHGAHBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Texture2DArray PFCOBEAACCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Texture2DArray GADNMFKKELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private bool ODKLPNCGKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int JDBOCHCLIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private Vector2? HNIKIOGDMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private TextureFormat IIHBJKPFOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Vector2? BDKCMMEPLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private TextureFormat LFNJPBKMLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Vector2? JBLIGJGLCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private TextureFormat NPNNKILNBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private Vector2? MNNKOEOMNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private TextureFormat EBJFOPEPNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private bool KJIMDOIMIPD;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int IOPFPDBFFML;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int PMMPHHNDCIL;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static int PMBPAJOOMIH;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static int AGDNPBFKJGI;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static int AAKPFHMLKCH;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private static int GGILILHDJEO;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static int CEANEGHLFEK;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static int ODBONJLMJDK;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static int LCMFAJDFBFN;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private static int HDJNMOEMBNK;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static int MJOIJDCKLJO;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int AHNCJNAHLIK;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int CFOIAGJENPH;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int IKLOFBEDFNJ;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int MHGGLEOIPFG;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int HJPMFPBNNDG;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int ODFMGEEFFGP;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int JEODPIGGHNB;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int KAAAGPONMMF;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int IADIOHMCHGC;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x60D3B20", Offset = "0x60D2920", VA = "0x1860D3B20")]
	private KBGLCINGGBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x60D4010", Offset = "0x60D2E10", VA = "0x1860D4010")]
	public KBGLCINGGBG(Color NBCKBJAMGAP, Color CILMDFOCMBC, Color HCFDPHGHIBM, Color? CBGJONBHILP, Color? FPCICMDDOKI, Color? NJMLGLBPMKP, Texture2D CEDJNJHDPGB, Texture2D LOEPPNCOIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x60D19A0", Offset = "0x60D07A0", VA = "0x1860D19A0")]
	internal int JCFNMAALMAK(Material GKKNDNCKLDO, IACLPKIDDKN ODAPNLKDOAE, JLGDBEPAMEA OIFKHNIKDFF, ECLNJFJJGAI EFIKBHICMCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60D1A90", Offset = "0x60D0890", VA = "0x1860D1A90")]
	private int JCFNMAALMAK(CHFCPJDDFME OBPLDLNDJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60D2A00", Offset = "0x60D1800", VA = "0x1860D2A00")]
	internal int NEICNLAOBLL(Material GKKNDNCKLDO, Color NDABFNMALCA, Color INPMFBONMCE, Color FOOKBMNHEKH, Color PPJLLPEOEGO, Color NKEFBMBKNLE, Texture2D HKGCPEOLFFF, Vector4 DOEHKKHEDKI, Texture2D JJCIBDOKHJK, Vector4 MMGJHJDMJLF, float BFNFHJMJBFK, float BCBIOPIGMGL, Texture2D OPNILLDHGPP, Vector4 DKOPKDEACKE, float OINOJHPLOMD, Texture2D DEJAODEKNFP, Color PKCLNAICCLN, Vector4 ACDFHNJJAKL, IACLPKIDDKN ODAPNLKDOAE, JLGDBEPAMEA OIFKHNIKDFF, ECLNJFJJGAI EFIKBHICMCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x60D2840", Offset = "0x60D1640", VA = "0x1860D2840")]
	private void LBEBNEKAMJP(List<Texture2D> OLOFICCOIGA, [Out] Texture2DArray GLBKACJGODA, [Out] Texture2DArray IIINHKNAJLH, [Out] Texture2DArray MOBAPNJBEME, [Out] Texture2DArray KPPHLFIHMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x60D16C0", Offset = "0x60D04C0", VA = "0x1860D16C0")]
	public void CPLHNMKHKHD(Shader JKHPFKBNHNJ, Renderer INJBJDLKFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x60D1B20", Offset = "0x60D0920", VA = "0x1860D1B20")]
	private void JOGELLOMCMJ(Shader JKHPFKBNHNJ, Renderer INJBJDLKFFP, int OOGJMKOMPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x60D35D0", Offset = "0x60D23D0", VA = "0x1860D35D0")]
	private Color NFALODIDOBH(Color EKJAENJHOLH, IACLPKIDDKN DIAJHJLPHFI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60D1810", Offset = "0x60D0610", VA = "0x1860D1810")]
	private Color DKOGBBBCCAH(Color KDBAFIAPHON, IACLPKIDDKN DIAJHJLPHFI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x60D1510", Offset = "0x60D0310", VA = "0x1860D1510")]
	private bool BNKHECFIINE(Texture2D NIDONIMBGPF, JLGDBEPAMEA PPGNBOOJHPH, [Out] Texture2D ONMLPPPLNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x60D1610", Offset = "0x60D0410", VA = "0x1860D1610")]
	private void CCAFHBMDCNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60D1960", Offset = "0x60D0760", VA = "0x1860D1960", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private PMFBJDCPFFJ? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AJAHBIADNDL CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x60CCAF0", Offset = "0x60CB8F0", VA = "0x1860CCAF0")]
			get
			{
				return default(AJAHBIADNDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public PMFBJDCPFFJ MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x60CCB40", Offset = "0x60CB940", VA = "0x1860CCB40")]
			get
			{
				return default(PMFBJDCPFFJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7AE530", Offset = "0x7AD330", VA = "0x1807AE530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60CC940", Offset = "0x60CB740", VA = "0x1860CC940")]
		public Material[] NHLAMOLFGNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x60CC780", Offset = "0x60CB580", VA = "0x1860CC780")]
		public static void LDNCFJMCJBJ(AvatarItemMaterial NILDCJGNMKE, Material LKFHNDFBKCD, int JLNHOEJOONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x60CCA30", Offset = "0x60CB830", VA = "0x1860CCA30")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[HEFMNMOEFLM]
public struct BFPIEPHOCMH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[ReadOnly]
	public PILNOFHNOJF EHNCEKCBLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[ReadOnly]
	public int MFILOFEPBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public BAAIHFMJMEH HPJPGAPMOIM;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x60CDA90", Offset = "0x60CC890", VA = "0x1860CDA90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[NativeContainer]
[HEFMNMOEFLM]
public struct BAAIHFMJMEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeArray<Vector3> PLEDBCJGKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeArray<Vector3> PPGENHJPCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<Vector4> MEGLEIOIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<Vector2> FLOBDDNGNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<Vector2> BHPCJPCJPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<Vector2> ELDPJMFMHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public NativeArray<Vector2> LHLKGABLDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public NativeArray<Color> IBMEJLBBBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public NativeArray<int> NONDLDMHAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public NativeArray<int> PIOMOJOOPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeArray<int> MBNCAFGKNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private NativeArray<int> HFCHOPNOGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public NativeArray<int> CLMCFHNMLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public NativeArray<int> GFKIGGNCIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public NativeArray<int> DMMAFJELLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NativeArray<BoneWeight> KHCEPJOLDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private NativeArray<int> AHMCCAODOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private bool MNINBKEKMHJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int POINFOLDDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60CD600", Offset = "0x60CC400", VA = "0x1860CD600")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60CD620", Offset = "0x60CC420", VA = "0x1860CD620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int OODIBNCGDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x60CD610", Offset = "0x60CC410", VA = "0x1860CD610")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x60CD5D0", Offset = "0x60CC3D0", VA = "0x1860CD5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int MFINMOJLIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x60CD5B0", Offset = "0x60CC3B0", VA = "0x1860CD5B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x60CD250", Offset = "0x60CC050", VA = "0x1860CD250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x60CD650", Offset = "0x60CC450", VA = "0x1860CD650")]
	public BAAIHFMJMEH(int PPEAENBDHAC, int PBJMADGCGJN, int DBJNJDGBDJJ, int GHHECOBFBGO, Allocator ACBNCIGINAO, int PANPHGKKEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x60CD030", Offset = "0x60CBE30", VA = "0x1860CD030")]
	public void ELKCFLJHKEP(int AELAKOMEEDP, Vector3 ALCIJOKMJPM, Vector3 INMKDHNNFDB, Vector4 HKJAKBPEJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x60CCCE0", Offset = "0x60CBAE0", VA = "0x1860CCCE0")]
	public void DOKLCEPODKD(int AELAKOMEEDP, BoneWeight BNFLLGIBKJN, NativeSlice<byte> CJJFPLELHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x60CD630", Offset = "0x60CC430", VA = "0x1860CD630")]
	public Color PKJJKEHDJJJ(int AELAKOMEEDP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x60CD5E0", Offset = "0x60CC3E0", VA = "0x1860CD5E0")]
	public void NFHKBNFNKPL(int AELAKOMEEDP, Color JJPJCHPNNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x60CCC90", Offset = "0x60CBA90", VA = "0x1860CCC90")]
	public void DFLLJBGGOIL(byte PIJKDAAHDLK, int AELAKOMEEDP, Vector2 ACBCKFMKPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x60CD5C0", Offset = "0x60CC3C0", VA = "0x1860CD5C0")]
	public void MLKFLDEOKNK(int AELAKOMEEDP, int KDEMGAJLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x60CD170", Offset = "0x60CBF70", VA = "0x1860CD170")]
	public bool GKKCEEKBDNN(int PIJKDAAHDLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x60CD0A0", Offset = "0x60CBEA0", VA = "0x1860CD0A0")]
	public void GHPFLHDBPDI(int HAOOOCOPIEM, int PJPGJICIKPG, int PDCHCFIOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x60CD1A0", Offset = "0x60CBFA0", VA = "0x1860CD1A0")]
	public int[] IMGOPPGGIED(int HAOOOCOPIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x60CCC00", Offset = "0x60CBA00", VA = "0x1860CCC00")]
	private NativeSlice<int> CMFJOGDOAPG(int HAOOOCOPIEM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x60CCE80", Offset = "0x60CBC80", VA = "0x1860CCE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x60CD260", Offset = "0x60CC060", VA = "0x1860CD260")]
	public Mesh JKKBMDFDHPH([Optional] string COABOFKGCJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[DefaultMember("Item")]
[HEFMNMOEFLM]
public struct PILNOFHNOJF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public NativeArray<Vector3> PLEDBCJGKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public NativeArray<Vector3> PPGENHJPCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<Vector4> MEGLEIOIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector2> FLOBDDNGNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector2> BHPCJPCJPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector2> ELDPJMFMHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> LHLKGABLDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Color> IBMEJLBBBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<int> GBDBJNIBKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<int> NKEPPAAJBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> KBPHPJLJLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<int> KBACIOLGCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<bool> LKMDPNIMMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<int> JBANKMJGFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> JOLOBPPKGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<BoneWeight> IJGEMOPBOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private NativeArray<Matrix4x4> EHHGGPGIONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private NativeArray<int> KDMKPCFBKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private NativeArray<byte> MJKEGNGKPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private NativeArray<int> NMOEDEGPIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private NativeArray<int> FECIJFEOLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<sbyte> DPGOHEOBPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<byte> FELKNFCKJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private NativeArray<int> IEPBPHAGNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private bool MNINBKEKMHJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int OECAPJDPCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1E4F0B0", Offset = "0x1E4DEB0", VA = "0x181E4F0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int PIICOCMHKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xE9FCE0", Offset = "0xE9EAE0", VA = "0x180E9FCE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JPNGEKKBLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x60D4E90", Offset = "0x60D3C90", VA = "0x1860D4E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int NMPJGPBOEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x60D4EC0", Offset = "0x60D3CC0", VA = "0x1860D4EC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x60D5790", Offset = "0x60D4590", VA = "0x1860D5790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int POINFOLDDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x60D56A0", Offset = "0x60D44A0", VA = "0x1860D56A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x60D56B0", Offset = "0x60D44B0", VA = "0x1860D56B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int GCAIIHOOEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x60D5140", Offset = "0x60D3F40", VA = "0x1860D5140")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x60D5150", Offset = "0x60D3F50", VA = "0x1860D5150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public AAODJCMCBJN GAHBMNFPALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x60D5690", Offset = "0x60D4490", VA = "0x1860D5690")]
		get
		{
			return default(AAODJCMCBJN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x60D4E80", Offset = "0x60D3C80", VA = "0x1860D4E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public byte IFLMJMPAOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x60D5680", Offset = "0x60D4480", VA = "0x1860D5680")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x60D5130", Offset = "0x60D3F30", VA = "0x1860D5130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public LODOJMCDCME OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x60D5160", Offset = "0x60D3F60", VA = "0x1860D5160")]
		get
		{
			return default(LODOJMCDCME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x60D57A0", Offset = "0x60D45A0", VA = "0x1860D57A0")]
	public PILNOFHNOJF(IList<Mesh> KOBCHLDHJOH, IList<Matrix4x4> KGMBBLHMCIK, IList<bool> LKMDPNIMMBG, byte PEFGMPNALNC, IList<byte[]> APEBIIBMAFI, IList<int> FGECEKJMDGN, IList<bool> MMJEMOGKNCD, IList<int> JBANKMJGFPD, IList<int> LJLNLKDOHKL, IList<int> IAODNPPAENK, Allocator ACBNCIGINAO, AAODJCMCBJN CJIBFKKKDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x60D56C0", Offset = "0x60D44C0", VA = "0x1860D56C0")]
	public BAAIHFMJMEH PCINBPIHBBH(Allocator ACBNCIGINAO)
	{
		return default(BAAIHFMJMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x60D4ED0", Offset = "0x60D3CD0", VA = "0x1860D4ED0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[HEFMNMOEFLM]
public class ADBCCGHPKAK : BMHKMPCOEHH
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x60CC690", Offset = "0x60CB490", VA = "0x1860CC690")]
	public PILNOFHNOJF NMKOGOCBLAA()
	{
		return default(PILNOFHNOJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x60B4D10", Offset = "0x60B3B10", VA = "0x1860B4D10")]
	public ADBCCGHPKAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct LODOJMCDCME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeSlice<Vector3> PLEDBCJGKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeSlice<Vector3> PPGENHJPCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeSlice<Vector4> MEGLEIOIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeSlice<Vector2> FLOBDDNGNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeSlice<Vector2> BHPCJPCJPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeSlice<Vector2> ELDPJMFMHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeSlice<Vector2> LHLKGABLDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeSlice<Color> IBMEJLBBBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeSlice<int> IFOGJLCDGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeSlice<int> KBACIOLGCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeSlice<BoneWeight> IJGEMOPBOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeSlice<byte> HOMJCKGCHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int OJBOIABICGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public Matrix4x4 EJEACMJOLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int NKDHOCEEIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeSlice<byte> CJJFPLELHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public bool GBPECGOLKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public int FLJNMOAFLOE;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal readonly struct CHFCPJDDFME : IEquatable<CHFCPJDDFME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	internal readonly Material MHCLJLHGBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	internal readonly IACLPKIDDKN INAAOEKDPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	internal readonly JLGDBEPAMEA NIJIIPLLMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	internal readonly ECLNJFJJGAI NLKMGJEOLFL;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8B8410", Offset = "0x8B7210", VA = "0x1808B8410")]
	public CHFCPJDDFME(Material LKFHNDFBKCD, IACLPKIDDKN ODAPNLKDOAE, JLGDBEPAMEA OIFKHNIKDFF, ECLNJFJJGAI EFIKBHICMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x60CEB30", Offset = "0x60CD930", VA = "0x1860CEB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8B80C0", Offset = "0x8B6EC0", VA = "0x1808B80C0", Slot = "4")]
	public bool Equals(CHFCPJDDFME GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x60CE9A0", Offset = "0x60CD7A0", VA = "0x1860CE9A0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x60CEA90", Offset = "0x60CD890", VA = "0x1860CEA90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class FHJDOIMECIC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class FEEIFKBBNKF : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public FEEIFKBBNKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8B7930", Offset = "0x8B6730", VA = "0x1808B7930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x60D09B0", Offset = "0x60CF7B0", VA = "0x1860D09B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	public static void ECIMHMBIOEG(string NLFEJIHGBIC, int AKDDGFBBJPG, long MMMLPJMEGFE, long AFAKPHOCNJG, long HHOJEDFCCAI, long AOGPOLPLJAF, long HKJNEEBJLGI, long JPCGCPJGALM, long FNLGNGCBEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x60D0A70", Offset = "0x60CF870", VA = "0x1860D0A70")]
	public static DPFFPCFAMJN MGOHMFPFALN(JobHandle IAHDPHCAKAN, bool HBJOCMOFGHC, bool CIPCGKNEMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x60D0A00", Offset = "0x60CF800", VA = "0x1860D0A00")]
	[IteratorStateMachine(typeof(FEEIFKBBNKF))]
	private static IEnumerator<KMOACDBBKNB> BNCFIIPFMNE(JobHandle GMPBFHBNPFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class EKNELKFKEID : PKFLFFLCEJK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private IJJEKJCPJHC PBAFECEFPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private DEPGJPBMCAL MEOGGHMKIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private IRecRoomQualityConfigProvider HBFFKJLOHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private bool MNINBKEKMHJ;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x60D0350", Offset = "0x60CF150", VA = "0x1860D0350")]
	[DPHBJKOLDBD(OHNOEEJKPCM.GameOnly)]
	private static void GLMPPFGOPJL(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x54450C0", Offset = "0x5443EC0", VA = "0x1854450C0")]
	[UnityEngine.Scripting.Preserve]
	public EKNELKFKEID([PENMPEOFMMN(null)] DEPGJPBMCAL MHJLBNNKANL, [PENMPEOFMMN(null)] IJJEKJCPJHC LNHLLAKAADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x60D08E0", Offset = "0x60CF6E0", VA = "0x1860D08E0")]
	private void LJNENJBKHEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x60D0950", Offset = "0x60CF750", VA = "0x1860D0950", Slot = "4")]
	public void NLKDAJLJAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x60D0440", Offset = "0x60CF240", VA = "0x1860D0440", Slot = "5")]
	public BCJOGHANCKE<Texture2D> JOIGABIGBKO(LEEPOJHPGMD KNLIBMHADHD, [Optional] CBPHCAMMFPP AHMCCAODOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x60D0220", Offset = "0x60CF020", VA = "0x1860D0220")]
	private uint DOPMFPOAAAM(LEEPOJHPGMD KNLIBMHADHD, CBPHCAMMFPP AHMCCAODOOJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface MFEIJKNJFBH
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAJPOCGNALJ(Mesh ANKNNGGBGOG, Matrix4x4 NMGJJMPPHPJ, byte[] CJJFPLELHMD, bool KMMFBCPPLLI = false, CPCJFDHFPLD.LCMFNGJPNFA GHOKPOKIEAM = (CPCJFDHFPLD.LCMFNGJPNFA)0, int JBANKMJGFPD = -1, bool LKMDPNIMMBG = false);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APHFEADHBJD(Allocator ACBNCIGINAO, AAODJCMCBJN CJIBFKKKDHM, byte PEFGMPNALNC, [Optional] IList<int> LJLNLKDOHKL, [Optional] IList<int> CNBDHBBDJKL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct ODKEHMDIDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public readonly GameObject HBFKAEJMBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly AvatarItemMaterial BBLMOKPHPKC;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x93C520", Offset = "0x93B320", VA = "0x18093C520")]
	public ODKEHMDIDPO(GameObject HBFKAEJMBJE, AvatarItemMaterial BBLMOKPHPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x60D40D0", Offset = "0x60D2ED0", VA = "0x1860D40D0")]
	public void BBFIEGBAICL(Material LKFHNDFBKCD, int JLNHOEJOONL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class DHFAEDOPFHM : GEJKKAEHLKJ<Task<(GameObject, AvatarItemMaterial)>, ODKEHMDIDPO>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct CJHNBIJPFEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x60CED60", Offset = "0x60CDB60", VA = "0x1860CED60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x60CF260", Offset = "0x60CE060", VA = "0x1860CF260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private BCJOGHANCKE<GameObject> JKOBLHFJLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private BCJOGHANCKE<AvatarItemMaterial> JLABHLMJKBM;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x60CFCD0", Offset = "0x60CEAD0", VA = "0x1860CFCD0")]
	private DHFAEDOPFHM(Task<(GameObject, AvatarItemMaterial)> JKCFEOGKFBB, BCJOGHANCKE<GameObject> HPJCICOCIAC, BCJOGHANCKE<AvatarItemMaterial> BJOENPGDHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x60CF680", Offset = "0x60CE480", VA = "0x1860CF680")]
	public static DHFAEDOPFHM ANGJMEBBFOG(AssetReference BPFNIGPKKNL, [Optional] AssetReference NOGEDCGJNLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x60CFBB0", Offset = "0x60CE9B0", VA = "0x1860CFBB0", Slot = "11")]
	protected override ODKEHMDIDPO KBJJEKEEDMM(Task<(GameObject, AvatarItemMaterial)> AJLHJOIDHFC)
	{
		return default(ODKEHMDIDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x60CFC50", Offset = "0x60CEA50", VA = "0x1860CFC50", Slot = "12")]
	protected override void NIPEBFMDMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x60CFA80", Offset = "0x60CE880", VA = "0x1860CFA80")]
	[AsyncStateMachine(typeof(CJHNBIJPFEE))]
	private static Task<(GameObject, AvatarItemMaterial)> CLNPMCECBKB(Task<GameObject> MBAIMIIBHDL, Task<AvatarItemMaterial> BNPLMDPCCLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class ONHPAJPCCML : GEJKKAEHLKJ<Task<(Material, MaterialMapAsset)>, Material>
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class HJGHHEDOMKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public Material mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public MaterialEntry entry;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public HJGHHEDOMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x60D14A0", Offset = "0x60D02A0", VA = "0x1860D14A0")]
		internal object DNBJHPLAGMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EGKFPJKCLBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public string shaderNameToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public HJGHHEDOMKN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public EGKFPJKCLBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x60CFD60", Offset = "0x60CEB60", VA = "0x1860CFD60")]
		internal object IINCNCDHGMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x60CFFC0", Offset = "0x60CEDC0", VA = "0x1860CFFC0")]
		internal object NMHJIIPIHPE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct HEENHNALJML<T1, T2> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder<(T1, T2)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private T1 <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter<T1> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<T2> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x39B9D20", Offset = "0x39B8B20", VA = "0x1839B9D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x39BA3A0", Offset = "0x39B91A0", VA = "0x1839BA3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private BCJOGHANCKE<Material> IDBJHLBMKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private BCJOGHANCKE<MaterialMapAsset> LGHIBEGOJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private bool DILAACFGOML;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x60D48F0", Offset = "0x60D36F0", VA = "0x1860D48F0")]
	public static ONHPAJPCCML JGEOECKCMDH(AssetReference CCHGFLAFGNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x60D46B0", Offset = "0x60D34B0", VA = "0x1860D46B0")]
	private static BCJOGHANCKE<MaterialMapAsset> IOBAHGIHMBL(AssetReference CCHGFLAFGNG, [Out] bool DILAACFGOML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x60D4DF0", Offset = "0x60D3BF0", VA = "0x1860D4DF0")]
	private ONHPAJPCCML(Task<(Material, MaterialMapAsset)> JKCFEOGKFBB, BCJOGHANCKE<Material> IDBJHLBMKGK, BCJOGHANCKE<MaterialMapAsset> JMCJBDDGPHP, bool DILAACFGOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x60D4B30", Offset = "0x60D3930", VA = "0x1860D4B30", Slot = "11")]
	protected override Material KBJJEKEEDMM(Task<(Material, MaterialMapAsset)> AJLHJOIDHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x60D42E0", Offset = "0x60D30E0", VA = "0x1860D42E0")]
	private void AKJIJNCLDDD(Material DFJLFDCKFCO, MaterialMapAsset PKHKCIJFODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x60D4D10", Offset = "0x60D3B10", VA = "0x1860D4D10", Slot = "12")]
	protected override void NIPEBFMDMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2A24760", Offset = "0x2A23560", VA = "0x182A24760")]
	[AsyncStateMachine(typeof(HEENHNALJML<, >))]
	private static Task<(T1, T2)> AHEIGANNGLE<T1, T2>(Task<T1> INFFNGEACMP, Task<T2> LLLEGFKKLMP)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		[FHFEFOGEDAO(KLKJAELFHOF.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x60D7070", Offset = "0x60D5E70", VA = "0x1860D7070")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct CPODEPKFBMI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public AsyncTaskMethodBuilder<EECMHFMEFGK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private TaskAwaiter<EECMHFMEFGK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x60CF2D0", Offset = "0x60CE0D0", VA = "0x1860CF2D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x60CF610", Offset = "0x60CE410", VA = "0x1860CF610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private Dictionary<BEPKGBHJAIF, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private Dictionary<BEPKGBHJAIF, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private Dictionary<BEPKGBHJAIF, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private Dictionary<BEPKGBHJAIF, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private readonly Dictionary<BEPKGBHJAIF, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private EECMHFMEFGK _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x60D1470", Offset = "0x60D0270", VA = "0x1860D1470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x60D0D60", Offset = "0x60CFB60", VA = "0x1860D0D60")]
		public EECMHFMEFGK DDIJJDEMMFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x60D0E60", Offset = "0x60CFC60", VA = "0x1860D0E60")]
		[AsyncStateMachine(typeof(CPODEPKFBMI))]
		public Task<EECMHFMEFGK> FIHAOGCFGJL(int GCHEAHEAMFG, int JNINOPNBNHG, int NDAKEPNOJIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x60D11C0", Offset = "0x60CFFC0", VA = "0x1860D11C0")]
		public NoseFaceOption IKMEEKBBINH(int CHCNFMHGKCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x60D1260", Offset = "0x60D0060", VA = "0x1860D1260")]
		public SelectableFaceOption MLAEMMENNPO(FaceFeatureType GEMNHOACOIN, BEPKGBHJAIF MCJFOKONDCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x60D0CE0", Offset = "0x60CFAE0", VA = "0x1860D0CE0")]
		public int AODKFPIOOEO(BEPKGBHJAIF MCJFOKONDCL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x60D0F90", Offset = "0x60CFD90", VA = "0x1860D0F90")]
		private void HDNIPCDPJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x28BC590", Offset = "0x28BB390", VA = "0x1828BC590")]
		private void ILAMGBBDCMK<T>(IDictionary<BEPKGBHJAIF, T> BHHBJAICHNE, IReadOnlyList<T> GJFFGLKACOA) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x60D0DB0", Offset = "0x60CFBB0", VA = "0x1860D0DB0")]
		public BEPKGBHJAIF EIDIICKMMJK(FaceFeatureType GEMNHOACOIN)
		{
			return default(BEPKGBHJAIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x60D0BC0", Offset = "0x60CF9C0", VA = "0x1860D0BC0")]
		public BEPKGBHJAIF ABMJBIPLIEA(FaceFeatureType GEMNHOACOIN)
		{
			return default(BEPKGBHJAIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x60D13E0", Offset = "0x60D01E0", VA = "0x1860D13E0")]
		public FaceStyleSet()
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
