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
using RecRoom.Attributes;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using RecRoom.Avatars.Face;
using RecRoom.Core.Studio;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C5DD60", Offset = "0x6C5C760", VA = "0x186C5DD60", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD960", Offset = "0x8AC360", VA = "0x1808AD960", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6C5E170", Offset = "0x6C5CB70", VA = "0x186C5E170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E090", Offset = "0x6C5CA90", VA = "0x186C5E090", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E130", Offset = "0x6C5CB30", VA = "0x186C5E130")]
		public RecNetCDNAssetReference(RecNetCDNKey PNABAFEIDND)
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
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB30", Offset = "0x8AC530", VA = "0x1808ADB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E1B0", Offset = "0x6C5CBB0", VA = "0x186C5E1B0")]
		public static RecNetCDNKey ALAOEHBLILE(string GFIIGBIIBOG, string AJJOOKEKOJN = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6439CB0", Offset = "0x64386B0", VA = "0x186439CB0")]
		public void OKCLLLMKJOF(string FKMFKOMDKMO, string CGIDNBEMCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E2B0", Offset = "0x6C5CCB0", VA = "0x186C5E2B0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AOOPPFIKPBO]
public class BMJIJPHFGAF : KPLGGIBDODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> LKPPOHCBDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> IANNNOPMGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> BMGPGIPCCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> OCINHLIPPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> NDOPBIJCCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> INEPCDODBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> MHONBMNNEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator NIEKICCJCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected CPGEBJEPEII DKNIFMLFEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte AFOFOMJMINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> CBKMLCCIMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> PJIGCLAHNFP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6C47F20", Offset = "0x6C46920", VA = "0x186C47F20", Slot = "4")]
	public void GGLNMPHDHGE(Mesh JMPEEMGIIHN, Matrix4x4 JJDMKAJDPGN, byte[] OILCEKBJFIE, bool NCHBJLBGLAD = false, NFCEEHLKBBE.NIHDBPDBFFB BBOHJOKNFLA = (NFCEEHLKBBE.NIHDBPDBFFB)0, int PIEDPAJDMCO = -1, bool KJPNBCEMLNB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C48130", Offset = "0x6C46B30", VA = "0x186C48130", Slot = "5")]
	public void KBALLNNCKBA(Allocator MCBEFIMHDPO, CPGEBJEPEII EECHIBLIDFD, byte NAPOEFBJCFI, [Optional] IList<int> LAKLDGFIAIJ, [Optional] IList<int> NMIKLKALEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C47CC0", Offset = "0x6C466C0", VA = "0x186C47CC0")]
	private static void ABNPBPDCAJJ(Mesh JMPEEMGIIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C48170", Offset = "0x6C46B70", VA = "0x186C48170")]
	public BMJIJPHFGAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AOOPPFIKPBO]
public struct GDPKDBDDDNE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public KHEFDICABPO BIGDHIIIAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int IMHGLNCHFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public KJIKHLPOOCF HACIAEAFIGJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C54700", Offset = "0x6C53100", VA = "0x186C54700", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AOOPPFIKPBO]
[NativeContainer]
public struct KJIKHLPOOCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct GDGALGGLOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 JNMOFFGBDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 LIGJJEDBJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 GNJMDOCGFJD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct PJIPOOEJOMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float GKCFLDKGOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float AAJJKGELFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float JGDIIPGIIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float AJFPKKIHMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte NGAAPOMICGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte DCLOEHCMCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte LBFNPNPCENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte HNPEEAFAGID;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct PMHILBKPJDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half GKCFLDKGOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half AAJJKGELFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half JGDIIPGIIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half AJFPKKIHMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte NGAAPOMICGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte DCLOEHCMCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte LBFNPNPCENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte HNPEEAFAGID;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MEJCMBEMLIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 GNADFIPFMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 MADBPFBEHNN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct LKIBLLMBLCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 GNADFIPFMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 MADBPFBEHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 GFFMFHGPODE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct LOGAPCIIIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 GNADFIPFMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 MADBPFBEHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 GFFMFHGPODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 GMGPPHLBKDI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct KKLFBIGIIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 GNADFIPFMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 MADBPFBEHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 GFFMFHGPODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 GMGPPHLBKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 BFNBJMEAECC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct LJLJOKHNEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float GKCFLDKGOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float AAJJKGELFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float JGDIIPGIIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float AJFPKKIHMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int NGAAPOMICGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int DCLOEHCMCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int LBFNPNPCENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int HNPEEAFAGID;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct CAJOBAIOOBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color GNADFIPFMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 MADBPFBEHNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct COFBCDGFNHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color GNADFIPFMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 MADBPFBEHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 GFFMFHGPODE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct BDHBLLHICFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color GNADFIPFMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 MADBPFBEHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 GFFMFHGPODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 GMGPPHLBKDI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct LAHACHOAGKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color GNADFIPFMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 MADBPFBEHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 GFFMFHGPODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 GMGPPHLBKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 BFNBJMEAECC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool CHLMJIHJLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<GDGALGGLOLC> PFFJLNGPIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<MEJCMBEMLIE> KPGJNNAKGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<LKIBLLMBLCD> FHLMGJGHCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<LOGAPCIIIMB> OPGOGDOPHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<KKLFBIGIIJO> FHKDFKLDKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<PMHILBKPJDD> HBIKPHEGCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<PJIPOOEJOMN> ECGCIPEHKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<CAJOBAIOOBK> JGBOIEBFIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<COFBCDGFNHD> FCJODAKIKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<BDHBLLHICFL> DEINDEKLAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<LAHACHOAGKN> HDDOCLOGLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<LJLJOKHNEKJ> BCAFFDPBCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> FDICEOGMCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> MPNAEOKBLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> IPNKPHCGFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> HOGPBEBJPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> GJCLOIAMLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> CBAPJIMGKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> NDNNJEIKIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> LCIINPNEDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> DIEJPPEOGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool BAKNBNANAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool BMNAODEOODN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KBIPEOLNCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C5AFD0", Offset = "0x6C599D0", VA = "0x186C5AFD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D320", Offset = "0x6C5BD20", VA = "0x186C5D320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MLILCCFBFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C5C770", Offset = "0x6C5B170", VA = "0x186C5C770")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C5BF30", Offset = "0x6C5A930", VA = "0x186C5BF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int HGECEHNEIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CF40", Offset = "0x6C5B940", VA = "0x186C5CF40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CF60", Offset = "0x6C5B960", VA = "0x186C5CF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CPCCDMMFLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C5BF40", Offset = "0x6C5A940", VA = "0x186C5BF40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D330", Offset = "0x6C5BD30", VA = "0x186C5D330")]
	public KJIKHLPOOCF(int HINGKCEBKFL, int OIKMKGOCDEG, int MLKEPONHMJO, int NPPFBMGGOCB, Allocator MCBEFIMHDPO, int LLIIMGHCMJD, HAIENOAIAJE FIKIDJHMFIG, bool BAKNBNANAAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CEB0", Offset = "0x6C5B8B0", VA = "0x186C5CEB0")]
	public void JFOHMBDINJP(int GCBONJOGHCD, Vector3 KGHNFJGNNEO, Vector3 DHCJGAOOJAG, Vector4 FOFGABNNIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C340", Offset = "0x6C5AD40", VA = "0x186C5C340")]
	public void HIAJBMAIBDN(int GCBONJOGHCD, BoneWeight HEMKKAACFPK, NativeSlice<byte> OILCEKBJFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CB80", Offset = "0x6C5B580", VA = "0x186C5CB80")]
	public Color JFHBELFDNFM(int GCBONJOGHCD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C780", Offset = "0x6C5B180", VA = "0x186C5C780")]
	public void IHIOGAODNBE(int GCBONJOGHCD, Color CLNPLAGFLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CF70", Offset = "0x6C5B970", VA = "0x186C5CF70")]
	public void NFDEJLNACCM(byte DLJCCBMIOBG, int GCBONJOGHCD, Vector2 PFAAFOBDCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CF50", Offset = "0x6C5B950", VA = "0x186C5CF50")]
	public void KMAJFKICAGP(int GCBONJOGHCD, int FDIFEFIDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C2E0", Offset = "0x6C5ACE0", VA = "0x186C5C2E0")]
	public bool EPJJFKBCEEA(int DLJCCBMIOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BFB0", Offset = "0x6C5A9B0", VA = "0x186C5BFB0")]
	public void DIPJDFJOKDJ(int ELBKMNEICOM, int FDHHGENAMHL, int JGKAMGBGMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C080", Offset = "0x6C5AA80", VA = "0x186C5C080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AFE0", Offset = "0x6C599E0", VA = "0x186C5AFE0")]
	public Mesh CAKEKOIJJJD([Optional] string CKFCPPFJAII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[AOOPPFIKPBO]
[DefaultMember("Item")]
public struct KHEFDICABPO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray HNKNLIFDFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> JFMJNIHFJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> PIEKEKDCOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> LCIINPNEDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> IOCJBPLKLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> GPHKCCADHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> JDLMLKPPPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> FODFNNIPOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> ELENPOKOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> CAGKEDHGBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> LDKNAJCFBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> KJPNBCEMLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> PIEDPAJDMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool BAKNBNANAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> JDOOHAMBOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool BMNAODEOODN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int LDEACHGFMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C59BE0", Offset = "0x6C585E0", VA = "0x186C59BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GEOGNFEIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C59BD0", Offset = "0x6C585D0", VA = "0x186C59BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MBDPCNOJNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C59CC0", Offset = "0x6C586C0", VA = "0x186C59CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PPLCAGBONJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C59DD0", Offset = "0x6C587D0", VA = "0x186C59DD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C59D90", Offset = "0x6C58790", VA = "0x186C59D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int KBIPEOLNCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C597E0", Offset = "0x6C581E0", VA = "0x186C597E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C59DC0", Offset = "0x6C587C0", VA = "0x186C59DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int MDMODGHJGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C59DA0", Offset = "0x6C587A0", VA = "0x186C59DA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C597D0", Offset = "0x6C581D0", VA = "0x186C597D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public CPGEBJEPEII BBEAPEOGJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C597C0", Offset = "0x6C581C0", VA = "0x186C597C0")]
		get
		{
			return default(CPGEBJEPEII);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C59DB0", Offset = "0x6C587B0", VA = "0x186C59DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte EEIGDJHMEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C59BC0", Offset = "0x6C585C0", VA = "0x186C59BC0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C59960", Offset = "0x6C58360", VA = "0x186C59960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JKGGDDNJMCC CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C59970", Offset = "0x6C58370", VA = "0x186C59970")]
		get
		{
			return default(JKGGDDNJMCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C59DE0", Offset = "0x6C587E0", VA = "0x186C59DE0")]
	public KHEFDICABPO(IList<Mesh> FGPBAADNFBG, IList<Matrix4x4> EIDHKBPPBOH, IList<bool> KJPNBCEMLNB, byte NAPOEFBJCFI, IList<byte[]> OOELEPEFEGD, IList<int> GGCGJNEICAD, IList<bool> NHEEIEHHDKK, IList<int> PIEDPAJDMCO, IList<int> LAKLDGFIAIJ, IList<int> ONFJLIACFFD, Allocator MCBEFIMHDPO, CPGEBJEPEII EECHIBLIDFD, bool BAKNBNANAAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C59BF0", Offset = "0x6C585F0", VA = "0x186C59BF0")]
	public KJIKHLPOOCF IPCJKKJFBLF(Allocator MCBEFIMHDPO, HAIENOAIAJE FIKIDJHMFIG)
	{
		return default(KJIKHLPOOCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C597F0", Offset = "0x6C581F0", VA = "0x186C597F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[AOOPPFIKPBO]
public class KAIMNCACKOO : BMJIJPHFGAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool BHAGAHJHGBK;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker AOEGPNHDMCJ;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C594B0", Offset = "0x6C57EB0", VA = "0x186C594B0")]
	public KHEFDICABPO HICFEHBBDPI()
	{
		return default(KHEFDICABPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C597B0", Offset = "0x6C581B0", VA = "0x186C597B0")]
	public KAIMNCACKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JKGGDDNJMCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData CBPKIFGOAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> LCIINPNEDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> MKHBAENHHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int MOFLOHDJHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 ENEPJNIKHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int AJFINJECLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> OILCEKBJFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool ACIDHEBHAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int GMEPHIOIADP;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AvatarElbowBendHelperController : MonoBehaviour, LMJMCLOPILC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Header("Scale")]
		[SerializeField]
		[FormerlySerializedAs("MinScaleValues")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private Vector3? HKPFCLNPJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool JCBGKECJJIA;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6C458C0", Offset = "0x6C442C0", VA = "0x186C458C0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6C45EE0", Offset = "0x6C448E0", VA = "0x186C45EE0", Slot = "4")]
		public void UpdateController(float OFFHKGFMEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C40", Offset = "0x9C2640", VA = "0x1809C3C40", Slot = "6")]
		public void SetEnabled(bool PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6C459A0", Offset = "0x6C443A0", VA = "0x186C459A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6C463A0", Offset = "0x6C44DA0", VA = "0x186C463A0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarElbowBendTargetController : MonoBehaviour, LMJMCLOPILC
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private const float PMMOEFBDHNI = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private Vector3 NIKHLOGHKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Vector3 EDAEHCDHEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool JCBGKECJJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float OBCCFKBEMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private float KMJCHKPJBMF;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6C46720", Offset = "0x6C45120", VA = "0x186C46720", Slot = "4")]
		public void UpdateController(float OFFHKGFMEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xC9D690", Offset = "0xC9C090", VA = "0x180C9D690", Slot = "6")]
		public void SetEnabled(bool PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C46440", Offset = "0x6C44E40", VA = "0x186C46440")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C471E0", Offset = "0x6C45BE0", VA = "0x186C471E0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarForearmRollController : MonoBehaviour, LMJMCLOPILC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float OBCCFKBEMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private bool JCBGKECJJIA;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C47210", Offset = "0x6C45C10", VA = "0x186C47210", Slot = "4")]
		public void UpdateController(float OFFHKGFMEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x11406A0", Offset = "0x113F0A0", VA = "0x1811406A0", Slot = "6")]
		public void SetEnabled(bool PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C47C90", Offset = "0x6C46690", VA = "0x186C47C90")]
		public AvatarForearmRollController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FNLOGGHCJGN : GIGKENLKLJE
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class GEAGGOIINLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public bool FBHBNFBGFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool MNLIJBKJNDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly MMMGGPPGMJP ELGFLFDICEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		protected bool AJDADMHPDCG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual NFCEEHLKBBE.NIHDBPDBFFB AJFINJECLAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "4")]
			get
			{
				return default(NFCEEHLKBBE.NIHDBPDBFFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool MEMNLFLBAEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xBB0080", Offset = "0xBAEA80", VA = "0x180BB0080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool OPIFIBPIALH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6C561E0", Offset = "0x6C54BE0", VA = "0x186C561E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool FBEILMKODNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6C56210", Offset = "0x6C54C10", VA = "0x186C56210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool FPMMFDAOMPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6C561F0", Offset = "0x6C54BF0", VA = "0x186C561F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C56220", Offset = "0x6C54C20", VA = "0x186C56220")]
		protected GEAGGOIINLA(MMMGGPPGMJP MGKDFEGEJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract HGKKEBPLLAP IPGAODEMIIL(int[] IGCDJBLFHMC, List<LOKHDAHPDJG> MFANIEFAEMI, List<LOKHDAHPDJG> KLKAFMKCABE);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract OLOHIPEIEJA DEIKBAJPCPD(uint CDLBFFAEOBG, AvatarSkinnedMeshBoneOrderRemapsData LFLGIPEALBM);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class FOKNEKPHONN : GEAGGOIINLA
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EFLLGFMMDMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public FFCGNKADKHD<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public FOKNEKPHONN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Action<string> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public EFLLGFMMDMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6C487D0", Offset = "0x6C471D0", VA = "0x186C487D0")]
			internal void FJKLAMKICBB(GameObject result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6C48BD0", Offset = "0x6C475D0", VA = "0x186C48BD0")]
			internal void NDNPCJFGEFO(string error)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly AvatarSkinAssetItem.BCEPNAMFHBB ABNPJDLGCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly AssetReference NFJLDPNEBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly NFCEEHLKBBE.NIHDBPDBFFB ALPAILMLEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly FNFEKAHOFPA? ABKGHFPHJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly Material[] AFCCEPMFHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private SkinnedMeshRenderer[] ICGABEGPMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private AvatarSkinAssetItem DDGCAPPHIIA;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override NFCEEHLKBBE.NIHDBPDBFFB AJFINJECLAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8AD570", Offset = "0x8ABF70", VA = "0x1808AD570", Slot = "4")]
			get
			{
				return default(NFCEEHLKBBE.NIHDBPDBFFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C545F0", Offset = "0x6C52FF0", VA = "0x186C545F0")]
		public FOKNEKPHONN(AvatarSkinAssetItem.BCEPNAMFHBB LFMMGKCNNDA, AssetReference NAIOGKGDODM, Material CLIMFIPHEKA, MMMGGPPGMJP FHIDJIFAFFI, NFCEEHLKBBE.NIHDBPDBFFB AEOGKBHENKK = (NFCEEHLKBBE.NIHDBPDBFFB)0, [Optional] FNFEKAHOFPA? NLAKACOCJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6C544E0", Offset = "0x6C52EE0", VA = "0x186C544E0")]
		public FOKNEKPHONN(AvatarSkinAssetItem.BCEPNAMFHBB LFMMGKCNNDA, AssetReference NAIOGKGDODM, Material CLIMFIPHEKA, NFCEEHLKBBE.NIHDBPDBFFB AEOGKBHENKK = (NFCEEHLKBBE.NIHDBPDBFFB)0, [Optional] FNFEKAHOFPA? NLAKACOCJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6C542A0", Offset = "0x6C52CA0", VA = "0x186C542A0", Slot = "5")]
		public override HGKKEBPLLAP IPGAODEMIIL(int[] IGCDJBLFHMC, List<LOKHDAHPDJG> MFANIEFAEMI, List<LOKHDAHPDJG> KLKAFMKCABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6C53FD0", Offset = "0x6C529D0", VA = "0x186C53FD0", Slot = "6")]
		public override OLOHIPEIEJA DEIKBAJPCPD(uint CDLBFFAEOBG, AvatarSkinnedMeshBoneOrderRemapsData LFLGIPEALBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6C54470", Offset = "0x6C52E70", VA = "0x186C54470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class HIMBGKJGBCC : GEAGGOIINLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public readonly NDBCELDDCHJ LBKMLJDAEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private FFCGNKADKHD<CKAAJNHBPIM> MKKNELEBBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public CKAAJNHBPIM KEICFKOIHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private FFCGNKADKHD<Material[]> OCINPDIHDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Material[] MJFINKPHGCM;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C56F30", Offset = "0x6C55930", VA = "0x186C56F30")]
		public HIMBGKJGBCC(MMMGGPPGMJP MGKDFEGEJPA, NDBCELDDCHJ LJJAGFLFCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C56630", Offset = "0x6C55030", VA = "0x186C56630", Slot = "5")]
		public override HGKKEBPLLAP IPGAODEMIIL(int[] IGCDJBLFHMC, List<LOKHDAHPDJG> MFANIEFAEMI, List<LOKHDAHPDJG> KLKAFMKCABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6C562D0", Offset = "0x6C54CD0", VA = "0x186C562D0", Slot = "6")]
		public override OLOHIPEIEJA DEIKBAJPCPD(uint CDLBFFAEOBG, AvatarSkinnedMeshBoneOrderRemapsData LFLGIPEALBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6C56420", Offset = "0x6C54E20", VA = "0x186C56420")]
		public OLOHIPEIEJA HMHCMEGBEFM(GameObject MNHDJJONFMN, uint CDLBFFAEOBG, bool IJKNFHMEMGM, bool KEMCNODKJPI, AvatarSkinnedMeshBoneOrderRemapsData LFLGIPEALBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6C56B80", Offset = "0x6C55580", VA = "0x186C56B80")]
		public static bool OCBPLINCOAL(Renderer[] ALHPFKMMOEL, string PEELFNIGGNP, [Out] Renderer PHFABOPFAGA, [Out] Renderer CFPNBCLMLKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C56EE0", Offset = "0x6C558E0", VA = "0x186C56EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C56AC0", Offset = "0x6C554C0", VA = "0x186C56AC0")]
		private (FFCGNKADKHD<CKAAJNHBPIM>, FFCGNKADKHD<Material[]>) KFALPLKDGJJ()
		{
			return default((FFCGNKADKHD<CKAAJNHBPIM>, FFCGNKADKHD<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6C56400", Offset = "0x6C54E00", VA = "0x186C56400")]
		[CompilerGenerated]
		private void DHPFPMBEEMP(CKAAJNHBPIM KIBAOEBFCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B0120", Offset = "0x8AEB20", VA = "0x1808B0120")]
		[CompilerGenerated]
		private void NBFBOKBCFHI(Material[] KIBAOEBFCJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HODGFOMFHNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public DIBDFLBFJHL avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public FNLOGGHCJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public BJOGDIODDMJ<Dictionary<string, FFCGNKADKHD<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public OLPMMAHKODD buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Action<KeyValuePair<string, FFCGNKADKHD<Texture2D>>> <>9__17;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HODGFOMFHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C59460", Offset = "0x6C57E60", VA = "0x186C59460")]
		internal bool OEDJHLHPPDI(NDBCELDDCHJ item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C59240", Offset = "0x6C57C40", VA = "0x186C59240")]
		internal void DIFFIMJGHEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C592C0", Offset = "0x6C57CC0", VA = "0x186C592C0")]
		internal void KDIGGAIDFBF(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C59290", Offset = "0x6C57C90", VA = "0x186C59290")]
		internal void JIOKABEBIHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6C59260", Offset = "0x6C57C60", VA = "0x186C59260")]
		internal void IJFBBGBCICK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
		internal BJOGDIODDMJ<Dictionary<string, FFCGNKADKHD<Texture2D>>> ODDFFBHKPCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C592E0", Offset = "0x6C57CE0", VA = "0x186C592E0")]
		internal void KPPLJFPJAHJ(Dictionary<string, FFCGNKADKHD<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C593A0", Offset = "0x6C57DA0", VA = "0x186C593A0")]
		internal void MGHHJBFAPBO(KeyValuePair<string, FFCGNKADKHD<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950")]
		internal HGKKEBPLLAP DJMPBKKKDAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CBKOALBHPHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public HODGFOMFHNL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CBKOALBHPHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6C483A0", Offset = "0x6C46DA0", VA = "0x186C483A0")]
		internal AJPNLLNBMFB POCDFHABFCF(int lod)
		{
			return default(AJPNLLNBMFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DMLDINIBPOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public List<OLPMMAHKODD> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DMLDINIBPOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6C486A0", Offset = "0x6C470A0", VA = "0x186C486A0")]
		internal void ADAJPPCECGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MCMHLHAOJAO : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public FNLOGGHCJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public List<GEAGGOIINLA> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public List<OLPMMAHKODD> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public Func<int, AJPNLLNBMFB> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public MKGDHCDLLIO materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public MCMHLHAOJAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6C5DDF0", Offset = "0x6C5C7F0", VA = "0x186C5DDF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6C5DFF0", Offset = "0x6C5C9F0", VA = "0x186C5DFF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OMLDAJNNLMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public FNLOGGHCJGN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public OMLDAJNNLMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E040", Offset = "0x6C5CA40", VA = "0x186C5E040")]
		internal HGKKEBPLLAP IKOKOLGMCNI(GEAGGOIINLA p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class EFPCBCFCABF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public JLMDJGDHNPI cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EFPCBCFCABF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xCC6650", Offset = "0xCC5050", VA = "0x180CC6650")]
		internal void KMNKIOEJPIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xD68B60", Offset = "0xD67560", VA = "0x180D68B60")]
		internal void HLHIBKCDEKP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class DAHDFAHLHPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public FNLOGGHCJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DAHDFAHLHPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class CEOCMNEJGGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public KJIKHLPOOCF defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public KHEFDICABPO defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public DAHDFAHLHPH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CEOCMNEJGGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C48460", Offset = "0x6C46E60", VA = "0x186C48460")]
		internal void KGFJAFNODDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xD6CE20", Offset = "0xD6B820", VA = "0x180D6CE20")]
		internal void BEHJNCJMBAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FACMLFKEOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public BFEAECAMENE legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public DKINEHDNFNE legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public DAHDFAHLHPH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public FACMLFKEOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6C48D10", Offset = "0x6C47710", VA = "0x186C48D10")]
		internal void CGDBFHBADGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD6B720", Offset = "0xD6A120", VA = "0x180D6B720")]
		internal void MHEGJEEEBJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HHGNOCOCLEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public MMMGGPPGMJP overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HHGNOCOCLEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C56250", Offset = "0x6C54C50", VA = "0x186C56250")]
		internal bool MNBGNPBGABB(KeyValuePair<string, NDBCELDDCHJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarConfiguration CDNHPLNECGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Transform KGMIKHOIBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private AssetReference NFJLDPNEBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private GameObject GPIAKAGLDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private GameObject KAKLELBOGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer NNGMJAPLPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private AvatarSkinnedMeshBoneOrderRemapsData CIGKEOMHPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Transform[] HPIMJDAOMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Matrix4x4[] DGKDCGPIGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Material AAGKLFKHMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Material NBLHENBABDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Material IMMLBNMPEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Shader EGJGFPCFJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Shader INGBCOPIOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Animator KJFKJNHMOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Renderer[] OFHNCKIINMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NFCEEHLKBBE.NIHDBPDBFFB MAKBMCEOLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private AvatarBodyPartShapesManager MKGMALBAKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private IReadOnlyDictionary<string, Transform> KIBLFFIFIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private AvatarFaceShapeData.HBLCLLGGKFE FOIEMAAOOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private AvatarBodyShapeData.NFOKFFDDBOM GJDBCAAMIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool HKBEMEOOENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool LKLCCOKFJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Color HJEELHOBOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Color BJBENMGJMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Color PNCAIPJFOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Color? FNGOBINOCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Color? LBOEPDBKPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Color? NOGPDIMAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Color? BONCKCOMGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Texture2D NICFPFEJIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Texture2D GLPPNDJADDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[CanBeNull]
	private NDBCELDDCHJ BMPJJPHBKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Texture MNOEIGBBNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Color CPIGOEIAIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Dictionary<Renderer, MKGDHCDLLIO> ILNGOFNMLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Dictionary<Renderer, MKGDHCDLLIO> CNMGNDLDBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Dictionary<string, List<GAKNBBLGFIG>> IDHNFKJACHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Dictionary<string, List<GAKNBBLGFIG>> BDHHMOFJKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly List<LOKHDAHPDJG> HHAGLKIFJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly List<LOKHDAHPDJG> MNBBMLEBPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly List<LOKHDAHPDJG> LLFPCFNLBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly List<LOKHDAHPDJG> DFKLPCHHOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<GAKNBBLGFIG, Material> FILFJPEEGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private Dictionary<GAKNBBLGFIG, Material> NLEDLPLOBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private SkinnedMeshRenderer[] EEIBCONHNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private SkinnedMeshRenderer[] ODBCHMNBFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private SkinnedMeshRenderer[] CHHHOOEPFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private SkinnedMeshRenderer[] BEBFJKOJGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<string, FFCGNKADKHD<Texture2D>> GHFPGOEAOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<string, FFCGNKADKHD<Texture2D>> APJLAFGLDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private AdditionalHatData EFEGCACHHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private AdditionalHatData NNBNFMODHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private HairData NCJJMPHKBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private HairData LFOEIIEDCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private IJDPLHMEMPG EONKOCEOHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool? JMLFCJGPFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private PositionAndRotation DCEEBLDFDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform MLFNAHFFOPF;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Material FJNPFECKKND;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Material FDLOBOANMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Dictionary<string, NDBCELDDCHJ> KAKKBMIIALL;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int CEJGHEDPMEF;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int LOKOKNOFBFJ;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly int BLNNLNIOIJK;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int JCDGHCDHMOK;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int KJEIAGAAJCA;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly int PEDGBNLDIHC;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly int HBJODFANLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly APNHDGDPKOI OPIJNLGHNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly APNHDGDPKOI BBDGFJEBIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool OPJBNDOGLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private List<Action> OKKDIALGMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private FOMNMHHOGJM PIOMPLPDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private SkinnedMeshRenderer[] EBDKDNDFGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private int BDCGOENEKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private bool HNMDLDONDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int AAPCDCKAFEM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarConfiguration AKACPMOKNLL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LIJIMGLIGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xCE3A10", Offset = "0xCE2410", VA = "0x180CE3A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xCE2380", Offset = "0xCE0D80", VA = "0x180CE2380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material MDOGNFLIADA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A040", Offset = "0x6C48A40", VA = "0x186C4A040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material JFGJMMFKMEH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D9A0", Offset = "0x6C4C3A0", VA = "0x186C4D9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool JFCKIHLGEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CNAPJFDNBAH AJHADNBDOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x941F40", Offset = "0x940940", VA = "0x180941F40", Slot = "21")]
		get
		{
			return default(CNAPJFDNBAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public APNHDGDPKOI KDNPONDMNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x97E760", Offset = "0x97D160", VA = "0x18097E760", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public APNHDGDPKOI JBJHAGFLHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x97E690", Offset = "0x97D090", VA = "0x18097E690", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public SkinnedMeshRenderer[] KJMHJEDHPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x173CAB0", Offset = "0x173B4B0", VA = "0x18173CAB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Renderer[] KAPHHOBJFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8B9770", Offset = "0x8B8170", VA = "0x1808B9770", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool EOEEIIKGOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C50A80", Offset = "0x6C4F480", VA = "0x186C50A80", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public NFCEEHLKBBE.NIHDBPDBFFB PPMMBMFHKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8B9680", Offset = "0x8B8080", VA = "0x1808B9680", Slot = "18")]
		get
		{
			return default(NFCEEHLKBBE.NIHDBPDBFFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OBNJDDPJAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1AEA6B0", Offset = "0x1AE90B0", VA = "0x181AEA6B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C49B40", Offset = "0x6C48540", VA = "0x186C49B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool EJILNGLKDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6C502F0", Offset = "0x6C4ECF0", VA = "0x186C502F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private static bool FBHHIPDEEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C53A40", Offset = "0x6C52440", VA = "0x186C53A40")]
	public FNLOGGHCJGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DA90", Offset = "0x6C4C490", VA = "0x186C4DA90", Slot = "29")]
	public void GCHKJEOLKFE(LFAIAGFNLEP BMBCHAHEJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C51610", Offset = "0x6C50010", VA = "0x186C51610", Slot = "4")]
	public void KKEBDKBINBN(BBICGPNDFKL LJFNIHCNJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C49B40", Offset = "0x6C48540", VA = "0x186C49B40", Slot = "5")]
	public void AGCJEMHJGFJ(int CDLBFFAEOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AEE0", Offset = "0x6C498E0", VA = "0x186C4AEE0", Slot = "10")]
	public void CNKGLGPFMEC(CLKLJGMJMAG OPGNMPHECNP, Texture2D AGFHPNOIBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620")]
	public static bool LNAJNKIBEOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C52D60", Offset = "0x6C51760", VA = "0x186C52D60", Slot = "11")]
	public bool OGIDIAGGMAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C51970", Offset = "0x6C50370", VA = "0x186C51970", Slot = "9")]
	public void LBIMBOOBGHP(FGCECDFKMCC MLHMODFCJOL, Color? GNADFIPFMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FA00", Offset = "0x6C4E400", VA = "0x186C4FA00")]
	private void GDJGJNJEEFL(Action PFPGKENHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C49020", Offset = "0x6C47A20", VA = "0x186C49020", Slot = "6")]
	public void ADNNBLMHIDP(NDBCELDDCHJ BBGAALBIIHP, Texture LGPCLONADGC, Color GHAFFACLIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xCE2380", Offset = "0xCE0D80", VA = "0x180CE2380", Slot = "7")]
	public void KMHEALMFIBH(bool FGEFPLNACGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1A8D390", Offset = "0x1A8BD90", VA = "0x181A8D390", Slot = "8")]
	public void JHAKAJPPLOF(FOMNMHHOGJM DIEJPPEOGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DE40", Offset = "0x6C4C840", VA = "0x186C4DE40", Slot = "14")]
	public OLPMMAHKODD GCPKALEJAEK(DIBDFLBFJHL KGINCINNJDN, bool NDCDOOMNKLN, int[] PADJMBGNEFD, Func<Dictionary<string, NDBCELDDCHJ>, (OLPMMAHKODD, BJOGDIODDMJ<Dictionary<string, FFCGNKADKHD<Texture2D>>>)> DNEJPIMFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D640", Offset = "0x6C4C040", VA = "0x186C4D640", Slot = "15")]
	public void FIHNPKLIHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C526B0", Offset = "0x6C510B0", VA = "0x186C526B0", Slot = "27")]
	public void MLGPHOFFCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C49090", Offset = "0x6C47A90", VA = "0x186C49090", Slot = "28")]
	public void AFFMOPONMAN([Optional] IJDPLHMEMPG GGPOINLIANA, [Optional] bool? HJEIAPMBBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C52C20", Offset = "0x6C51620", VA = "0x186C52C20")]
	private bool OANLGHADKIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C50240", Offset = "0x6C4EC40", VA = "0x186C50240", Slot = "19")]
	public bool HJHIGCBBAHH(NFCEEHLKBBE.NIHDBPDBFFB PGJNOKBAKEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C52ED0", Offset = "0x6C518D0", VA = "0x186C52ED0")]
	private bool OIELICOFJPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C53170", Offset = "0x6C51B70", VA = "0x186C53170")]
	private OLPMMAHKODD PGHICDLGKFN(bool NDCDOOMNKLN, List<GEAGGOIINLA> CNAKDOABPDB, int[] PADJMBGNEFD, Func<int, AJPNLLNBMFB> BEDOINLDLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C51D70", Offset = "0x6C50770", VA = "0x186C51D70")]
	[IteratorStateMachine(typeof(MCMHLHAOJAO))]
	private IEnumerator<BGFOJNANPKN> LBNGDHAJJNA(bool NDCDOOMNKLN, List<GEAGGOIINLA> CNAKDOABPDB, int[] PADJMBGNEFD, Func<int, AJPNLLNBMFB> BEDOINLDLNP, MKGDHCDLLIO OLJLLPFCMHP, Material OJDHFLBABNA, List<OLPMMAHKODD> MGPINPKANHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D380", Offset = "0x6C4BD80", VA = "0x186C4D380")]
	private OLPMMAHKODD FCHHMDBOOAB(List<GEAGGOIINLA> CNAKDOABPDB, int[] PADJMBGNEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C110", Offset = "0x6C4AB10", VA = "0x186C4C110")]
	private OIMBFIPCENK EPAKFLAPDJO(List<GEAGGOIINLA> CNAKDOABPDB, int CDLBFFAEOBG, bool NDCDOOMNKLN, AJPNLLNBMFB FLMAECPLNCE, bool AAAMFCOLFPH, MKGDHCDLLIO OLJLLPFCMHP, Material OJDHFLBABNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C50400", Offset = "0x6C4EE00", VA = "0x186C50400", Slot = "23")]
	public void IGLNPJNFGNK(AvatarFaceShape HOEAJIPLKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C500A0", Offset = "0x6C4EAA0", VA = "0x186C500A0", Slot = "24")]
	public void HGAMIGIGCFA(AvatarBodyShape BNAFFFKPJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6C537D0", Offset = "0x6C521D0", VA = "0x186C537D0", Slot = "26")]
	public void PKKMPPHNMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C50E30", Offset = "0x6C4F830", VA = "0x186C50E30", Slot = "25")]
	public void KBAMPFEIJPP(bool MNDFHCGFEIP, bool BEDGFHJMMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C514D0", Offset = "0x6C4FED0", VA = "0x186C514D0")]
	private void KGGKCFDEMEP(SkinnedMeshRenderer HPFEDOGGOKI, int CDLBFFAEOBG, Mesh JMPEEMGIIHN, List<Material> GGAOJOKKKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BE60", Offset = "0x6C4A860", VA = "0x186C4BE60")]
	private static Material EIEPJJLGNPH(Dictionary<GAKNBBLGFIG, Material> MPMJPFNPNFL, Material HLEFLOBJCAM, KEGLKCNJCJB NCONHOHPFDK, BMHFKOAGLMC BBJEEJDLEDG, MMMGGPPGMJP FHIDJIFAFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FF90", Offset = "0x6C4E990", VA = "0x186C4FF90")]
	private static KEGLKCNJCJB GPDIFLKIEOI(GEAGGOIINLA FKOKJKKHBHA, int GLFCBFPMCJP)
	{
		return default(KEGLKCNJCJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A630", Offset = "0x6C49030", VA = "0x186C4A630")]
	private void APBHDFCLEPA(int JJDMCGMMDHI, Material FLBCMGELMBF, GEAGGOIINLA FKOKJKKHBHA, [Out] Texture2D GIAFKBOMMAH, [Out] Vector4 BEAIBKEMPBI, [Out] Texture2D BJFMJPAAHKA, [Out] Texture2D CLCJAKNNALM, [Out] Texture2D HOOECKMHJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C50E40", Offset = "0x6C4F840", VA = "0x186C50E40")]
	private void KBJCEOBLIEH(int JJDMCGMMDHI, Material FLBCMGELMBF, GEAGGOIINLA FKOKJKKHBHA, [Out] Color MMJLBGNBGBI, [Out] Color LMEHIPBODIP, [Out] Color CFLNDOLFFHJ, [Out] Color PHLCDLDCJJB, [Out] Color JOEHGPNEGMH, [Out] Color NLFKGBEMHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BAA0", Offset = "0x6C4A4A0", VA = "0x186C4BAA0")]
	private bool EGJMEANPGNO(Material FLBCMGELMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AB60", Offset = "0x6C49560", VA = "0x186C4AB60")]
	private static Material APKONEHANEF(int JJDMCGMMDHI, HIMBGKJGBCC FKOKJKKHBHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C50160", Offset = "0x6C4EB60", VA = "0x186C50160")]
	private static BMHFKOAGLMC HHEFPIEKNGA(GEAGGOIINLA FKOKJKKHBHA, int GLFCBFPMCJP)
	{
		return default(BMHFKOAGLMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B7E0", Offset = "0x6C4A1E0", VA = "0x186C4B7E0")]
	private static void EDLKLNADJKF(Dictionary<string, List<GAKNBBLGFIG>> GBCGAMNIJHH, GEAGGOIINLA NMJALODMKLH, Material HLEFLOBJCAM, KEGLKCNJCJB MLHMODFCJOL, BMHFKOAGLMC OPGNMPHECNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4ABE0", Offset = "0x6C495E0", VA = "0x186C4ABE0")]
	private static SkinnedMeshRenderer BJDNJHFDBGB(Transform GFFEHICLKCM, Transform HPJFBICBPEB, SkinnedMeshRenderer[] ALHPFKMMOEL, int CDLBFFAEOBG, AJPNLLNBMFB FLMAECPLNCE, bool NDCDOOMNKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C524F0", Offset = "0x6C50EF0", VA = "0x186C524F0")]
	private void MGMKCMAMOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C52C10", Offset = "0x6C51610", VA = "0x186C52C10")]
	private void NOMBGJHAIHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BD00", Offset = "0x6C4A700", VA = "0x186C4BD00")]
	private static void EHBPGGLBNBC(Dictionary<GAKNBBLGFIG, Material> MPMJPFNPNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C50920", Offset = "0x6C4F320", VA = "0x186C50920")]
	private static void ILEIHEOHMAA(Dictionary<Renderer, MKGDHCDLLIO> BJAJNDJPBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AA40", Offset = "0x6C49440", VA = "0x186C4AA40")]
	private void APGHOEFMKAL(SkinnedMeshRenderer[] ALHPFKMMOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C52450", Offset = "0x6C50E50", VA = "0x186C52450")]
	private void MEGAEHNAAOJ(SkinnedMeshRenderer DEPAJOHPLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C52F90", Offset = "0x6C51990", VA = "0x186C52F90")]
	private void OMJKFNBHMMJ(List<LOKHDAHPDJG> DMHEDDEPBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C507A0", Offset = "0x6C4F1A0", VA = "0x186C507A0")]
	private void IKHDKOPMECC(Dictionary<string, FFCGNKADKHD<Texture2D>> GBCGAMNIJHH, bool GEHOHHKOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D330", Offset = "0x6C4BD30", VA = "0x186C4D330")]
	private void FCDEIGELEEB(Dictionary<string, List<GAKNBBLGFIG>> GBCGAMNIJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FE30", Offset = "0x6C4E830", VA = "0x186C4FE30")]
	private void GOLHBAPGBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6C52210", Offset = "0x6C50C10", VA = "0x186C52210")]
	private void LFDBAPIBJHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B230", Offset = "0x6C49C30", VA = "0x186C4B230")]
	private void EAMPFGODDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C50BF0", Offset = "0x6C4F5F0", VA = "0x186C50BF0")]
	private void JGAOKNHKCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C50260", Offset = "0x6C4EC60", VA = "0x186C50260")]
	private void HJPCGLPNEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BFC0", Offset = "0x6C4A9C0", VA = "0x186C4BFC0")]
	private void EJBOHIGHNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AE10", Offset = "0x6C49810", VA = "0x186C4AE10")]
	private void BNKMOPFGEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6C51690", Offset = "0x6C50090", VA = "0x186C51690")]
	private void KMEPOLGKIFA(bool INGEBHFHIDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C48F50", Offset = "0x6C47950", VA = "0x186C48F50")]
	private void ADMKFHCNEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FA80", Offset = "0x6C4E480", VA = "0x186C4FA80")]
	private void GENHLGDEOAC(bool INGEBHFHIDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F6E0", Offset = "0x6C4E0E0", VA = "0x186C4F6E0")]
	private void GDGIMLIKLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6C49B60", Offset = "0x6C48560", VA = "0x186C49B60")]
	private void AHCHFAKNKKE(Material OJDHFLBABNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C50CC0", Offset = "0x6C4F6C0", VA = "0x186C50CC0")]
	private void JJDGMCFNBNG(Material OJDHFLBABNA, Color IBKJGMDJINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FBF0", Offset = "0x6C4E5F0", VA = "0x186C4FBF0")]
	private void GKALGKCDBGO(Material OJDHFLBABNA, Color IBKJGMDJINC, Color GIGGHAHBMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6C51380", Offset = "0x6C4FD80", VA = "0x186C51380")]
	private void KEOHNJCFIEE(Material OJDHFLBABNA, Color MMJLBGNBGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C51770", Offset = "0x6C50170", VA = "0x186C51770")]
	private void LBIJNIHEILC(Material OJDHFLBABNA, Texture2D AGFHPNOIBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6C504C0", Offset = "0x6C4EEC0", VA = "0x186C504C0")]
	private void IGNEAOFJPLO(Material OJDHFLBABNA, Texture ACBIGJMDJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D840", Offset = "0x6C4C240", VA = "0x186C4D840")]
	private void FIKLOKJBNOJ(Action<MKGDHCDLLIO> CDNNPAOMCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C50620", Offset = "0x6C4F020", VA = "0x186C50620")]
	private void IJJGOBBCODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C52770", Offset = "0x6C51170", VA = "0x186C52770")]
	private void NEJHEFJHCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A260", Offset = "0x6C48C60", VA = "0x186C4A260")]
	private void ALNIEGJHGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C51E80", Offset = "0x6C50880", VA = "0x186C51E80")]
	public void LCEOMODHHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C523C0", Offset = "0x6C50DC0", VA = "0x186C523C0")]
	[CompilerGenerated]
	private void MEFLJAKEHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D300", Offset = "0x6C4BD00", VA = "0x186C4D300")]
	[CompilerGenerated]
	private void FBCHBAHCAJC(MKGDHCDLLIO FHMLENHKIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C50370", Offset = "0x6C4ED70", VA = "0x186C50370")]
	[CompilerGenerated]
	private void HNFPKDDNKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B1E0", Offset = "0x6C49BE0", VA = "0x186C4B1E0")]
	[CompilerGenerated]
	private void DLMDJODDFIL(MKGDHCDLLIO FHMLENHKIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FB60", Offset = "0x6C4E560", VA = "0x186C4FB60")]
	[CompilerGenerated]
	private void GJKCJAOOPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C523A0", Offset = "0x6C50DA0", VA = "0x186C523A0")]
	[CompilerGenerated]
	private void MDKNHHGECFA(MKGDHCDLLIO FHMLENHKIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C512F0", Offset = "0x6C4FCF0", VA = "0x186C512F0")]
	[CompilerGenerated]
	private void KCAKGBNEMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B200", Offset = "0x6C49C00", VA = "0x186C4B200")]
	[CompilerGenerated]
	private void DLPEMPKCJFJ(MKGDHCDLLIO FHMLENHKIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B100", Offset = "0x6C49B00", VA = "0x186C4B100")]
	[CompilerGenerated]
	private void CPFPJMDEOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B190", Offset = "0x6C49B90", VA = "0x186C4B190")]
	[CompilerGenerated]
	private void DDHCHBIJJCO(MKGDHCDLLIO FHMLENHKIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C53740", Offset = "0x6C52140", VA = "0x186C53740")]
	[CompilerGenerated]
	private void PGOCOOLKFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C52740", Offset = "0x6C51140", VA = "0x186C52740")]
	[CompilerGenerated]
	private void MPBJDNLIEAL(MKGDHCDLLIO FHMLENHKIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A1D0", Offset = "0x6C48BD0", VA = "0x186C4A1D0")]
	[CompilerGenerated]
	private void ALJKGHOCCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C52710", Offset = "0x6C51110", VA = "0x186C52710")]
	[CompilerGenerated]
	private void MMANPOILKFJ(MKGDHCDLLIO FHMLENHKIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C52B90", Offset = "0x6C51590", VA = "0x186C52B90")]
	[CompilerGenerated]
	private void NGNLHACDDBG(KeyValuePair<string, FFCGNKADKHD<Texture2D>> JKAAPOECKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B1D0", Offset = "0x6C49BD0", VA = "0x186C4B1D0")]
	[CompilerGenerated]
	private void DKCBLKCOKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C4ABB0", Offset = "0x6C495B0", VA = "0x186C4ABB0")]
	[CompilerGenerated]
	private void BECLBNNCDBA(MKGDHCDLLIO FHMLENHKIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B1C0", Offset = "0x6C49BC0", VA = "0x186C4B1C0")]
	[CompilerGenerated]
	private void DDPBHBLDIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C538D0", Offset = "0x6C522D0", VA = "0x186C538D0")]
	[CompilerGenerated]
	private void PLJKFPMLEKF(MKGDHCDLLIO FHMLENHKIEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HLHGOHCEHJI : AKDDLLHAOHM
{
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int FJGGIBNAGLH;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int LFPHBNAFBCI;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int GFACGLOHJFI;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int LEAELMPBICF;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int JDKBCGIGCBK;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int DADPPAGHFEC;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int IGNCHOMBDIG;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int DDEPHBKBJGE;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static readonly int GCIGKEFIOHG;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly int PBAILPGIHEI;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static readonly int DKHHEMMCCOL;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static readonly int NDBHFPBIMIM;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly int FEAFELOFFEA;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private static readonly int NNGHDNAMLPI;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly int EKLAPHMJJCE;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static readonly int HGCICBEPKDC;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly int AOMMNPHDDIJ;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly int DPKJFCHHGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Transform CKNFICBHEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Transform PEKJOKDHCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private Transform BPLGFOHMMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private Transform EOCDGFLPDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private Transform KJLMKGKJPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private Transform BCDDMOMHAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Transform HMJHMGDLHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private GOGKEBKGBPE LFEOGGPOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private MaterialPropertyBlock KGJMCONHMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private SkinnedMeshRenderer[] IIOEKOBMLDA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private MaterialPropertyBlock KABKHBCIFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C58CC0", Offset = "0x6C576C0", VA = "0x186C58CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6C58B40", Offset = "0x6C57540", VA = "0x186C58B40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6C58D40", Offset = "0x6C57740", VA = "0x186C58D40", Slot = "8")]
	public void GCHKJEOLKFE(GOGKEBKGBPE DKJHHPBKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C58B10", Offset = "0x6C57510", VA = "0x186C58B10", Slot = "5")]
	public void FIFDAAPEIFJ(BDFCKBBIOIL OEBJLDMOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C58530", Offset = "0x6C56F30", VA = "0x186C58530", Slot = "6")]
	public void CCODJNIDLGI(LHOGONLHLBH OMAAMOKHDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C57320", Offset = "0x6C55D20", VA = "0x186C57320")]
	private Vector2 APBGGDIHALD(Vector2 LFJOAPDCCKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6C57380", Offset = "0x6C55D80", VA = "0x186C57380", Slot = "7")]
	public void BKOIHCHNADK(JLHCGCDLNGE OEBJLDMOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C56FE0", Offset = "0x6C559E0", VA = "0x186C56FE0")]
	private void AFCHHACNMKK(JLHCGCDLNGE EJMCCECENOI, ENCLOPFLBLO FHJJCGBPNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6C58A30", Offset = "0x6C57430", VA = "0x186C58A30")]
	private void CMCFHOLIKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C591E0", Offset = "0x6C57BE0", VA = "0x186C591E0")]
	public HLHGOHCEHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C58E10", Offset = "0x6C57810", VA = "0x186C58E10")]
	[CompilerGenerated]
	internal static (float, float) IBHIKGIHCCO(float HJIBEKDHNNF)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6C58EA0", Offset = "0x6C578A0", VA = "0x186C58EA0")]
	[CompilerGenerated]
	internal static Vector4 LHGONBIDGFM(Vector2 PCPIJKGKPCE, Vector2 ECGPBBOMOPD)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NHCNFCHGAEN : APKMBPJNDFO
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C7E0", Offset = "0x6C6B1E0", VA = "0x186C6C7E0", Slot = "22")]
	public override float PAJGAHLMCPC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C830", Offset = "0x6C6B230", VA = "0x186C6C830")]
	public NHCNFCHGAEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class APKMBPJNDFO : FNNNPLJFKOG
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static int DKMOPGMKHJO;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private static int NNLODPINACC;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static int NMMNJNNIMLK;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static int JLFHEBJCCKM;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static int MPHIJLLEDAL;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private static int BNGKGKFKHMG;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static int HMGMCNNIDAG;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int[] OGCEOGFEFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private CBABHICOCID LFEOGGPOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private ANJALDBILAI DJALLCPPJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private int BMKJJMPCPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private float FOPBJDOANOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private Animator KJFKJNHMOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	protected bool PNEEGNIEGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected AvatarConfiguration GKNKEGEEBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private int HIAJKLDDAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private int FFFPONEGNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private int IKIEKFJHNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool ABHHPFJDNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private BCKEJPIEAAK OHLFIHCGPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private int PDHFPNGLEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private float HFDNMFEPMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private AvatarHandDisplaySettings IPJDJBJNOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private CNAPJFDNBAH ONANAEPALFM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform HJNLPPAIFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 LLFDGAIKJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1136B10", Offset = "0x1135510", VA = "0x181136B10")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1136B00", Offset = "0x1135500", VA = "0x181136B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Quaternion DDOIFJNPHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x11F09C0", Offset = "0x11EF3C0", VA = "0x1811F09C0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x11F0D60", Offset = "0x11EF760", VA = "0x1811F0D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool BHHEPLJMFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F700", Offset = "0x6C5E100", VA = "0x186C5F700")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F920", Offset = "0x6C5E320", VA = "0x186C5F920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Vector3 CBEFDMIFJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6BAA120", Offset = "0x6BA8B20", VA = "0x186BAA120", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6BAA140", Offset = "0x6BA8B40", VA = "0x186BAA140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Quaternion KNEGENKIELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FF20", Offset = "0x6C5E920", VA = "0x186C5FF20", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FA10", Offset = "0x6C5E410", VA = "0x186C5FA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public NBILNDMKKPI NFBMNECEELP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xF614C0", Offset = "0xF5FEC0", VA = "0x180F614C0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(NBILNDMKKPI);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xF61020", Offset = "0xF5FA20", VA = "0x180F61020", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NBILNDMKKPI JCBDAIJCEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xF614B0", Offset = "0xF5FEB0", VA = "0x180F614B0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(NBILNDMKKPI);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xF611F0", Offset = "0xF5FBF0", VA = "0x180F611F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float HMFFBMINCFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xE6CEB0", Offset = "0xE6B8B0", VA = "0x180E6CEB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xAABA30", Offset = "0xAAA430", VA = "0x180AABA30", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CIGKHINAFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F410", Offset = "0x6C5DE10", VA = "0x186C5F410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool ILLNMOLGPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FA00", Offset = "0x6C5E400", VA = "0x186C5FA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LAHFPMJBFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FD90", Offset = "0x6C5E790", VA = "0x186C5FD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NMJKONGECMN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x263FC40", Offset = "0x263E640", VA = "0x18263FC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F730", Offset = "0x6C5E130", VA = "0x186C5F730", Slot = "21")]
	public void GCHKJEOLKFE(CBABHICOCID DKJHHPBKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F670", Offset = "0x6C5E070", VA = "0x186C5F670")]
	public void FFKAGBCBFKN(ANJALDBILAI EDKFLPHBLIJ, AvatarHandDisplaySettings KCHCEBPPDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F970", Offset = "0x6C5E370", VA = "0x186C5F970", Slot = "12")]
	public void MAGMANCAMCM(bool PELDDJLLGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FA20", Offset = "0x6C5E420", VA = "0x186C5FA20", Slot = "11")]
	public void OLKMBMCADKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xE6CEB0", Offset = "0xE6B8B0", VA = "0x180E6CEB0", Slot = "22")]
	public virtual float PAJGAHLMCPC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FDA0", Offset = "0x6C5E7A0", VA = "0x186C5FDA0")]
	private int OLNNOFMBLNF(NBILNDMKKPI MCKJDGPEGCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F420", Offset = "0x6C5DE20", VA = "0x186C5F420")]
	private void AONAMIMIOCA(int PNKMIIAFDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F630", Offset = "0x6C5E030", VA = "0x186C5F630", Slot = "13")]
	public bool CBMIIPLPJOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F960", Offset = "0x6C5E360", VA = "0x186C5F960", Slot = "14")]
	public bool LCOJGHKJIJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F8D0", Offset = "0x6C5E2D0", VA = "0x186C5F8D0")]
	private NBILNDMKKPI GJCEGODABHF()
	{
		return default(NBILNDMKKPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4A73A80", Offset = "0x4A72480", VA = "0x184A73A80", Slot = "15")]
	public void PAJBKICLFGC(bool PELDDJLLGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F6C0", Offset = "0x6C5E0C0", VA = "0x186C5F6C0", Slot = "10")]
	public void FMDCDLMMDBJ(int PNKMIIAFDHM, float KGBPBFAONNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F650", Offset = "0x6C5E050", VA = "0x186C5F650", Slot = "8")]
	public void DNDHBPBFMAP(BCKEJPIEAAK DPGCKOGOMEN, bool EHKJPKOFIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F950", Offset = "0x6C5E350", VA = "0x186C5F950", Slot = "9")]
	public void ILFKBLLONEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F5E0", Offset = "0x6C5DFE0", VA = "0x186C5F5E0", Slot = "16")]
	public void APOKMHHNMPD(Transform NNFBEGDDJKL, Vector3 IECLOFFBHJA, Quaternion HGGGBJLEGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6C601C0", Offset = "0x6C5EBC0", VA = "0x186C601C0")]
	public APKMBPJNDFO()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6C601E0", Offset = "0x6C5EBE0", VA = "0x186C601E0")]
		public void IGMCENCOPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6C60300", Offset = "0x6C5ED00", VA = "0x186C60300")]
		public int IIMHMNLIONH(int CDDEHHFBIFN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public AvatarHandDisplaySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, LMJMCLOPILC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private Vector3 NIKHLOGHKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private Vector3 MPBCMHCBBEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Vector3 LKCHFDLHMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private Matrix4x4 OKMOEKLLECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private bool JCBGKECJJIA;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6C607E0", Offset = "0x6C5F1E0", VA = "0x186C607E0", Slot = "4")]
		public void UpdateController(float OFFHKGFMEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6C607D0", Offset = "0x6C5F1D0", VA = "0x186C607D0", Slot = "6")]
		public void SetEnabled(bool PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6C60370", Offset = "0x6C5ED70", VA = "0x186C60370")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6C60EA0", Offset = "0x6C5F8A0", VA = "0x186C60EA0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[AOOPPFIKPBO]
public struct LJEFPGBJLOG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[ReadOnly]
	public DKINEHDNFNE BIGDHIIIAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[ReadOnly]
	public int IMHGLNCHFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public BFEAECAMENE HACIAEAFIGJ;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6C68A30", Offset = "0x6C67430", VA = "0x186C68A30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[AOOPPFIKPBO]
public struct BFEAECAMENE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<Vector3> OODCEEMLGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<Vector3> ABAKPHCCLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<Vector4> FLNPIGMBOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<Vector2> PCPBDKGILKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<Vector2> GMGPPHLBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<Vector2> BFNBJMEAECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Vector2> PNGDMOGDJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Color> CKLFJMEEBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<int> FDICEOGMCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<int> MPNAEOKBLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private NativeArray<int> IPNKPHCGFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private NativeArray<int> HOGPBEBJPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<int> GJCLOIAMLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<int> CBAPJIMGKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<int> NDNNJEIKIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<BoneWeight> KJPKFNGCPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private NativeArray<int> DIEJPPEOGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private bool BMNAODEOODN;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int KBIPEOLNCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6C63220", Offset = "0x6C61C20", VA = "0x186C63220")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6C63C60", Offset = "0x6C62660", VA = "0x186C63C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int MLILCCFBFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6C63A90", Offset = "0x6C62490", VA = "0x186C63A90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6C63580", Offset = "0x6C61F80", VA = "0x186C63580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int HGECEHNEIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6C63B50", Offset = "0x6C62550", VA = "0x186C63B50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6C63C00", Offset = "0x6C62600", VA = "0x186C63C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6C63C70", Offset = "0x6C62670", VA = "0x186C63C70")]
	public BFEAECAMENE(int HINGKCEBKFL, int OIKMKGOCDEG, int MLKEPONHMJO, int NPPFBMGGOCB, Allocator MCBEFIMHDPO, int LLIIMGHCMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6C63AE0", Offset = "0x6C624E0", VA = "0x186C63AE0")]
	public void JFOHMBDINJP(int GCBONJOGHCD, Vector3 KGHNFJGNNEO, Vector3 DHCJGAOOJAG, Vector4 FOFGABNNIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6C638F0", Offset = "0x6C622F0", VA = "0x186C638F0")]
	public void HIAJBMAIBDN(int GCBONJOGHCD, BoneWeight HEMKKAACFPK, NativeSlice<byte> OILCEKBJFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6C63AC0", Offset = "0x6C624C0", VA = "0x186C63AC0")]
	public Color JFHBELFDNFM(int GCBONJOGHCD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6C63AA0", Offset = "0x6C624A0", VA = "0x186C63AA0")]
	public void IHIOGAODNBE(int GCBONJOGHCD, Color CLNPLAGFLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6C63C10", Offset = "0x6C62610", VA = "0x186C63C10")]
	public void NFDEJLNACCM(byte DLJCCBMIOBG, int GCBONJOGHCD, Vector2 PFAAFOBDCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6C63B60", Offset = "0x6C62560", VA = "0x186C63B60")]
	public void KMAJFKICAGP(int GCBONJOGHCD, int FDIFEFIDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6C63810", Offset = "0x6C62210", VA = "0x186C63810")]
	public bool EPJJFKBCEEA(int DLJCCBMIOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6C63590", Offset = "0x6C61F90", VA = "0x186C63590")]
	public void DIPJDFJOKDJ(int ELBKMNEICOM, int FDHHGENAMHL, int JGKAMGBGMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C63840", Offset = "0x6C62240", VA = "0x186C63840")]
	public int[] GIINIJBKCPN(int ELBKMNEICOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6C63B70", Offset = "0x6C62570", VA = "0x186C63B70")]
	private NativeSlice<int> KNHDPLEDBJD(int ELBKMNEICOM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C63660", Offset = "0x6C62060", VA = "0x186C63660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6C63230", Offset = "0x6C61C30", VA = "0x186C63230")]
	public Mesh CAKEKOIJJJD([Optional] string CKFCPPFJAII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[AOOPPFIKPBO]
[NativeContainer]
[DefaultMember("Item")]
public struct DKINEHDNFNE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector3> OODCEEMLGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector3> ABAKPHCCLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector4> FLNPIGMBOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector2> PCPBDKGILKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> GMGPPHLBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> BFNBJMEAECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> PNGDMOGDJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Color> CKLFJMEEBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<int> LDOGFPDFHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<int> DPFGNFALLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> LOIBPMMJOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> PFPJDOEFNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<bool> KJPNBCEMLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> PIEDPAJDMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> PIEKEKDCOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<BoneWeight> LCIINPNEDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private NativeArray<Matrix4x4> IOCJBPLKLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NativeArray<int> GPHKCCADHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NativeArray<byte> JDLMLKPPPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private NativeArray<int> FODFNNIPOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private NativeArray<int> ELENPOKOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<sbyte> CAGKEDHGBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<byte> LDKNAJCFBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private NativeArray<int> JDOOHAMBOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private bool BMNAODEOODN;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LDEACHGFMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x228D680", Offset = "0x228C080", VA = "0x18228D680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int GEOGNFEIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x136C8B0", Offset = "0x136B2B0", VA = "0x18136C8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int MBDPCNOJNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6C64A00", Offset = "0x6C63400", VA = "0x186C64A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int PPLCAGBONJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6C64A70", Offset = "0x6C63470", VA = "0x186C64A70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6C64A30", Offset = "0x6C63430", VA = "0x186C64A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int KBIPEOLNCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6C64180", Offset = "0x6C62B80", VA = "0x186C64180")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6C64A60", Offset = "0x6C63460", VA = "0x186C64A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int MDMODGHJGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6C64A40", Offset = "0x6C63440", VA = "0x186C64A40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6C64170", Offset = "0x6C62B70", VA = "0x186C64170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public CPGEBJEPEII BBEAPEOGJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6C64160", Offset = "0x6C62B60", VA = "0x186C64160")]
		get
		{
			return default(CPGEBJEPEII);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6C64A50", Offset = "0x6C63450", VA = "0x186C64A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public byte EEIGDJHMEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6C64920", Offset = "0x6C63320", VA = "0x186C64920")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6C643F0", Offset = "0x6C62DF0", VA = "0x186C643F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IDPKBLHINLM CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6C64400", Offset = "0x6C62E00", VA = "0x186C64400")]
		get
		{
			return default(IDPKBLHINLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6C64A80", Offset = "0x6C63480", VA = "0x186C64A80")]
	public DKINEHDNFNE(IList<Mesh> FGPBAADNFBG, IList<Matrix4x4> EIDHKBPPBOH, IList<bool> KJPNBCEMLNB, byte NAPOEFBJCFI, IList<byte[]> OOELEPEFEGD, IList<int> GGCGJNEICAD, IList<bool> NHEEIEHHDKK, IList<int> PIEDPAJDMCO, IList<int> LAKLDGFIAIJ, IList<int> ONFJLIACFFD, Allocator MCBEFIMHDPO, CPGEBJEPEII EECHIBLIDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6C64930", Offset = "0x6C63330", VA = "0x186C64930")]
	public BFEAECAMENE IPCJKKJFBLF(Allocator MCBEFIMHDPO)
	{
		return default(BFEAECAMENE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6C64190", Offset = "0x6C62B90", VA = "0x186C64190", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[AOOPPFIKPBO]
public class ENJGIPCKGCH : BMJIJPHFGAF
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6C66300", Offset = "0x6C64D00", VA = "0x186C66300")]
	public DKINEHDNFNE HICFEHBBDPI()
	{
		return default(DKINEHDNFNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6C597B0", Offset = "0x6C581B0", VA = "0x186C597B0")]
	public ENJGIPCKGCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct IDPKBLHINLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<Vector3> OODCEEMLGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<Vector3> ABAKPHCCLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<Vector4> FLNPIGMBOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<Vector2> PCPBDKGILKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<Vector2> GMGPPHLBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeSlice<Vector2> BFNBJMEAECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeSlice<Vector2> PNGDMOGDJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<Color> CKLFJMEEBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<int> CCDAGOGCGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeSlice<int> PFPJDOEFNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeSlice<BoneWeight> LCIINPNEDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeSlice<byte> MKHBAENHHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public int MOFLOHDJHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public Matrix4x4 ENEPJNIKHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public int AJFINJECLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeSlice<byte> OILCEKBJFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public bool ACIDHEBHAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public int GMEPHIOIADP;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct GAKNBBLGFIG : IEquatable<GAKNBBLGFIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	internal readonly Material NKKCKOMLDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	internal readonly KEGLKCNJCJB KANPHLGALJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	internal readonly BMHFKOAGLMC DOKOEDGBKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	internal readonly MMMGGPPGMJP AOEMNNKEDAM;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6C66810", Offset = "0x6C65210", VA = "0x186C66810")]
	public GAKNBBLGFIG(Material FLBCMGELMBF, KEGLKCNJCJB NCONHOHPFDK, BMHFKOAGLMC BBJEEJDLEDG, MMMGGPPGMJP FHIDJIFAFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6C665F0", Offset = "0x6C64FF0", VA = "0x186C665F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6C664D0", Offset = "0x6C64ED0", VA = "0x186C664D0", Slot = "4")]
	public bool Equals(GAKNBBLGFIG GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6C663F0", Offset = "0x6C64DF0", VA = "0x186C663F0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6C66550", Offset = "0x6C64F50", VA = "0x186C66550", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, LJNIBOLJLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		[Header("Configuration")]
		private CNAPJFDNBAH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private GIGKENLKLJE NMCLPBDKAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private AKDDLLHAOHM NAHDEFKHCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private FNNNPLJFKOG ICCDGNKOAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private FNNNPLJFKOG ELFIDCAKNMG;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public GIGKENLKLJE LCKIKINDCBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x6C61C40", Offset = "0x6C60640", VA = "0x186C61C40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public AKDDLLHAOHM IHOFENBCDPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x6C61C90", Offset = "0x6C60690", VA = "0x186C61C90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public FNNNPLJFKOG GKEJPLBBKAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x6C61E80", Offset = "0x6C60880", VA = "0x186C61E80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public FNNNPLJFKOG LDFFEHCFLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x6C61ED0", Offset = "0x6C608D0", VA = "0x186C61ED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Transform MIEFPHCCJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x6C61F20", Offset = "0x6C60920", VA = "0x186C61F20", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public CNAPJFDNBAH FICNCNPGIEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8AD570", Offset = "0x8ABF70", VA = "0x1808AD570", Slot = "12")]
			get
			{
				return default(CNAPJFDNBAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6C60EB0", Offset = "0x6C5F8B0", VA = "0x186C60EB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6C61AF0", Offset = "0x6C604F0", VA = "0x186C61AF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6C61430", Offset = "0x6C5FE30", VA = "0x186C61430", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6C61AF0", Offset = "0x6C604F0", VA = "0x186C61AF0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6C61100", Offset = "0x6C5FB00", VA = "0x186C61100", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6C61B60", Offset = "0x6C60560", VA = "0x186C61B60")]
		public void UpdatePostIKAnimControllers(float OFFHKGFMEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6C614C0", Offset = "0x6C5FEC0", VA = "0x186C614C0")]
		private void KDIGJMDCPGM(GameObject BBNKFKDCOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6C61550", Offset = "0x6C5FF50", VA = "0x186C61550")]
		private GIGKENLKLJE KLHNDBDJCEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6C60F40", Offset = "0x6C5F940", VA = "0x186C60F40")]
		private AKDDLLHAOHM CEDJJHGIILO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6C61860", Offset = "0x6C60260", VA = "0x186C61860")]
		private FNNNPLJFKOG OHMCMHKCGNO(BANGCCGDJKI DHCNMJBGHCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x1A48970", Offset = "0x1A47370", VA = "0x181A48970")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MKGDHCDLLIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private MaterialPropertyBlock EMAMEEDPLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	public Color? KPAFJOIOPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	public Color? DDKLANBHLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	public Color? NIJJLMCKDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public Color? KHNLLBEEMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public Color DJKLIIJDMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public Color FEDHPBBNPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public Color DEMAEEHPDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public Texture2D AHPGNANPNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public Texture2D DCGHJPICJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private Dictionary<GAKNBBLGFIG, int> BIKINIDKOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private KEGLKCNJCJB[] CDGLFHBEGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private BMHFKOAGLMC[] ECCKJDPGNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public Vector4[] IOGIHJEOPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Vector4[] CLMBDGFDNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public Vector4[] DHEIOAOPOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Vector4[] IPLBCDBBOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public Vector4[] HHMJOBJDKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public Vector4[] NDOKKLHHLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private List<Texture2D> FDLILFAPNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private Vector4[] BHOKDEHLJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private List<Texture2D> MNGGBPIHHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float[] OODOEJDPBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private Vector4[] PGEPNPOPBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float[] NPMHPFPHCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public float[] EPLCCHAIAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private List<Texture2D> NOGCKIGMICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private float[] PPAAOEODEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private List<Texture2D> KDLLIFPCGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Vector4[] JMKONAMFBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private float[] CDKLGKCLFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private Vector4[] DCHDPLBADJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public float[] LFPIFDDNMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Texture2DArray OJEJGNIDLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Texture2DArray BJPMBJNAOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Texture2DArray ILDFBFANACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Texture2DArray FHBICDJLCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private bool NCGANKCJAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private int PKFGJCFMFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector2? DCJDBGINCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private TextureFormat HEBOJBENADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private Vector2? HMHHIPANCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private TextureFormat BCEMEIEBBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private Vector2? PGJAMEOEBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private TextureFormat KKPNHHCFBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector2? GABHHBDBIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private TextureFormat FJADGNCEOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private bool IFCFLPBDAAE;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static int KIBPKNKOJOP;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static int HLIIBDIKDDE;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static int BJMDLKEAHAC;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static int MDIBANKGKIB;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static int CDDGBHNKENH;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static int LKOJFHDAJKA;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static int LPJEFEOKHPN;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static int LMFCCIALOBH;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static int OKPHJKJFBCA;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static int HDALKJEHLOA;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static int COKKPLANHDL;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static int MDDBOKEMLDP;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static int NACBMABBCMH;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static int MAKOANFCCOD;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static int BKPCIPGEKDB;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static int HDIGHCEPPPD;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int LLDHOPBPOAL;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int BONHJPOBFCG;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int IHBOLHLAKEH;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int LODBPEACBEL;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C060", Offset = "0x6C6AA60", VA = "0x186C6C060")]
	private MKGDHCDLLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6C6BFA0", Offset = "0x6C6A9A0", VA = "0x186C6BFA0")]
	public MKGDHCDLLIO(Color AHJFPMLDBHH, Color GGCJAJCCLND, Color JBHGLNJJJNA, Color? HKCIGKMGBDC, Color? MJPOMCEAFEC, Color? MFLKKNJHNJN, Texture2D CHHGIJGGNCL, Texture2D BPNGHGPIDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A9A0", Offset = "0x6C693A0", VA = "0x186C6A9A0")]
	internal int CLKCNMBNBFC(Material OFPAJFFLKPG, KEGLKCNJCJB NCONHOHPFDK, BMHFKOAGLMC BBJEEJDLEDG, MMMGGPPGMJP FHIDJIFAFFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AA90", Offset = "0x6C69490", VA = "0x186C6AA90")]
	private int CLKCNMBNBFC(GAKNBBLGFIG PNABAFEIDND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AE80", Offset = "0x6C69880", VA = "0x186C6AE80")]
	internal int IOHAOIGLOOM(Material OFPAJFFLKPG, Color MMJLBGNBGBI, Color LMEHIPBODIP, Color CFLNDOLFFHJ, Color PHLCDLDCJJB, Color JOEHGPNEGMH, Texture2D GAHELHHLLKM, Vector4 CBCDPIOHJFP, Texture2D JIKAKDAADOL, Vector4 JJKFOBBIHCB, float OAPENEMJACD, float JNPMJJMFHCC, Texture2D HLNCOFFOGHB, Vector4 DJOJPNNODMP, float NEEFACHHBFP, Texture2D ILLFPHGJHNL, Color NLFKGBEMHJI, Vector4 AIOCHMEOPCI, KEGLKCNJCJB NCONHOHPFDK, BMHFKOAGLMC BBJEEJDLEDG, MMMGGPPGMJP FHIDJIFAFFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ACC0", Offset = "0x6C696C0", VA = "0x186C6ACC0")]
	private void HIIBNKIIOKA(List<Texture2D> FDLILFAPNMK, [Out] Texture2DArray BAHKMJDBGIC, [Out] Texture2DArray MPAMMGAEFJL, [Out] Texture2DArray GBENFLLAFED, [Out] Texture2DArray DCPLBKJDIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6C69990", Offset = "0x6C68390", VA = "0x186C69990")]
	public void ADKDCMGEMPI(Shader MGPHEAPBBJG, Renderer OJIILOMBDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6C69CE0", Offset = "0x6C686E0", VA = "0x186C69CE0")]
	private void ANFCMPNLFPO(Shader MGPHEAPBBJG, Renderer OJIILOMBDFN, int LAOMEDIOFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6C69AE0", Offset = "0x6C684E0", VA = "0x186C69AE0")]
	private Color AEECBMEPKMG(Color FFGDOCPJKHO, KEGLKCNJCJB MLHMODFCJOL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6C6BA50", Offset = "0x6C6A450", VA = "0x186C6BA50")]
	private Color KOODNIPOKAF(Color CLEMGDMFBJH, KEGLKCNJCJB MLHMODFCJOL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AB60", Offset = "0x6C69560", VA = "0x186C6AB60")]
	private bool GJJGOAHMIBN(Texture2D BCCPFHFLHOG, BMHFKOAGLMC OPGNMPHECNP, [Out] Texture2D BIKDNPIINIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6C6BBA0", Offset = "0x6C6A5A0", VA = "0x186C6BBA0")]
	private void PHPLCFECGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AB20", Offset = "0x6C69520", VA = "0x186C6AB20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NDPGNHPAEJD
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static readonly int[] CLACACHIDLA;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static readonly int[] AJDLIMPKAMO;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static int[] ENIJDAIEOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C690", Offset = "0x6C6B090", VA = "0x186C6C690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C560", Offset = "0x6C6AF60", VA = "0x186C6C560")]
	public static int[] HPACGKCNONO(bool EKDNHIGIDLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C600", Offset = "0x6C6B000", VA = "0x186C6C600")]
	public static int NKNPDCGCKLC(DEMMDJFFENH FLFINEMEJLD, bool EKDNHIGIDLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C550", Offset = "0x6C6AF50", VA = "0x186C6C550")]
	private static int AAHPHIABFMI(DEMMDJFFENH FLFINEMEJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C5E0", Offset = "0x6C6AFE0", VA = "0x186C6C5E0")]
	private static int MLPBPCBFOPG(DEMMDJFFENH FLFINEMEJLD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class ICCMGJHGAMN
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class APICIJKAJBC : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public APICIJKAJBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xD6E750", Offset = "0xD6D150", VA = "0x180D6E750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F3C0", Offset = "0x6C5DDC0", VA = "0x186C5F3C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	public static void HJLMHDNGIPH(string CMEADPACGME, int CDLBFFAEOBG, long GIIFICHLFAB, long LEMCFMJEHFK, long DJCOMJIBMIJ, long DDADAPLLPBD, long JJMDLGIFFIL, long AALHLILHLEK, long KHDKFHALMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6C67040", Offset = "0x6C65A40", VA = "0x186C67040")]
	public static OIMBFIPCENK CPOPONNFHPJ(JobHandle MLAONLCNOJG, bool IJAFGKPEEOE, bool JFCKIHLGEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6C66FD0", Offset = "0x6C659D0", VA = "0x186C66FD0")]
	[IteratorStateMachine(typeof(APICIJKAJBC))]
	private static IEnumerator<BGFOJNANPKN> BGCFEGHLJDI(JobHandle DFEBEONMKNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class HBGILOFBFGB
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum ALCMCBIHPGC
	{
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly int CJCDOLKHAIJ;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly int GKNGGPNBGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly int HNKPDMBGHGA;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly int LPHOEDMGDFA;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly int LMECCCOBGPK;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly int KEGMHKODJDO;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly int JEKFBJKFKIH;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly int IAPKOKAOECC;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6C66D30", Offset = "0x6C65730", VA = "0x186C66D30")]
	public static bool HKFFNOHEMDD(Material FLBCMGELMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6C66DA0", Offset = "0x6C657A0", VA = "0x186C66DA0")]
	public static bool IDNGHDLKIEF(Material FLBCMGELMBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class JNMKNJLLNNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private List<int> KANLPDPLONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private List<IIDLIHOEMPD> MMBMKDEHOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private HashSet<Transform> PLNPNOHIPPK;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6C680B0", Offset = "0x6C66AB0", VA = "0x186C680B0")]
	public static JNMKNJLLNNL EMDAALFNAPD(Transform FOFGABNNIOJ, Dictionary<Transform, OutfitType?> PPGCLLBICFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C68250", Offset = "0x6C66C50", VA = "0x186C68250")]
	private void EMNCOEBNGND(Transform FOFGABNNIOJ, MMMGGPPGMJP FHIDJIFAFFI, Dictionary<Transform, OutfitType?> PPGCLLBICFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C67F80", Offset = "0x6C66980", VA = "0x186C67F80")]
	private void ECOICIPMJGE(Transform CLLNNCNFMMG, MMMGGPPGMJP FHIDJIFAFFI, bool MPGAHOENFHK, OutfitType? JMCPJFDLMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C68510", Offset = "0x6C66F10", VA = "0x186C68510")]
	public BFDEADLLPHH OAFJJBFMGOD(HashSet<string> ICDLOANAAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C68900", Offset = "0x6C67300", VA = "0x186C68900")]
	public JNMKNJLLNNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BFDEADLLPHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private List<IIDLIHOEMPD> MMBMKDEHOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private List<Matrix4x4> NEEAOEBBMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private Transform[] MBFCBACLFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private Matrix4x4[] GJAHEHLMEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private Dictionary<ILIAGAEIFFB, int> PGAEKNDKCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private List<GFLMHIJHLDN> DEOCJANHEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private bool EIMCKDADMDG;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6C62650", Offset = "0x6C61050", VA = "0x186C62650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public Transform[] JKOOGKLNLML
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C62BB0", Offset = "0x6C615B0", VA = "0x186C62BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public Matrix4x4[] DGNBJKNELBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C624A0", Offset = "0x6C60EA0", VA = "0x186C624A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C62690", Offset = "0x6C61090", VA = "0x186C62690")]
	public void ECOICIPMJGE(Transform CLLNNCNFMMG, MMMGGPPGMJP FHIDJIFAFFI, OutfitType? JMCPJFDLMPB, bool AJDOOEIPDPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C62880", Offset = "0x6C61280", VA = "0x186C62880")]
	private void ECOICIPMJGE(Transform CLLNNCNFMMG, MMMGGPPGMJP FHIDJIFAFFI, OutfitType? JMCPJFDLMPB, bool AJDOOEIPDPK, Matrix4x4 IPHCKGPNIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C62D10", Offset = "0x6C61710", VA = "0x186C62D10")]
	public int IOFIMEFOFED(ILIAGAEIFFB PNABAFEIDND, bool MOMOPJLHFLI, [Optional] OutfitType? JMCPJFDLMPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C62FB0", Offset = "0x6C619B0", VA = "0x186C62FB0")]
	public int PGGOJALAEKP(MMMGGPPGMJP FHIDJIFAFFI, [Optional] OutfitType? JMCPJFDLMPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C62EC0", Offset = "0x6C618C0", VA = "0x186C62EC0")]
	public void OKNLFDAGIEE(ILIAGAEIFFB PNABAFEIDND, Matrix4x4 ONHCAMFFAOP, bool MOMOPJLHFLI = false, [Optional] OutfitType? JMCPJFDLMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C62510", Offset = "0x6C60F10", VA = "0x186C62510")]
	public Matrix4x4 BNIDENOMCID(ILIAGAEIFFB PNABAFEIDND, bool MOMOPJLHFLI, [Optional] OutfitType? JMCPJFDLMPB)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xE2E390", Offset = "0xE2CD90", VA = "0x180E2E390")]
	public void IHEENMPCGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C630B0", Offset = "0x6C61AB0", VA = "0x186C630B0")]
	public BFDEADLLPHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct ILIAGAEIFFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public readonly string KHJEMFDBHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public readonly MMMGGPPGMJP AOEMNNKEDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public readonly OutfitType? BMPIGPFDBJF;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C67F40", Offset = "0x6C66940", VA = "0x186C67F40")]
	public ILIAGAEIFFB(string EJBPAJAJEGH, MMMGGPPGMJP FHIDJIFAFFI, [Optional] OutfitType? JMCPJFDLMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C67E90", Offset = "0x6C66890", VA = "0x186C67E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C67DD0", Offset = "0x6C667D0", VA = "0x186C67DD0")]
	public bool LLKODAGINCO(ILIAGAEIFFB GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C67CD0", Offset = "0x6C666D0", VA = "0x186C67CD0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C67D70", Offset = "0x6C66770", VA = "0x186C67D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct GFLMHIJHLDN : IEquatable<GFLMHIJHLDN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public readonly MMMGGPPGMJP AOEMNNKEDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public readonly OutfitType? GGAEHIMIBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public readonly int JGGJJHICHFK;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C66B20", Offset = "0x6C65520", VA = "0x186C66B20")]
	public GFLMHIJHLDN(MMMGGPPGMJP FHIDJIFAFFI, int HDAFAIEMGEI, [Optional] OutfitType? PDPEKICMLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C66A60", Offset = "0x6C65460", VA = "0x186C66A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x200A890", Offset = "0x2009290", VA = "0x18200A890")]
	public bool KFCKCHJGMFL(MMMGGPPGMJP FHIDJIFAFFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C66850", Offset = "0x6C65250", VA = "0x186C66850")]
	public bool AEMHIDKOHKD(OutfitType? PDPEKICMLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C669C0", Offset = "0x6C653C0", VA = "0x186C669C0", Slot = "4")]
	public bool Equals(GFLMHIJHLDN GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C668D0", Offset = "0x6C652D0", VA = "0x186C668D0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C66A10", Offset = "0x6C65410", VA = "0x186C66A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct IIDLIHOEMPD : IEquatable<IIDLIHOEMPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public readonly Transform JPCFEJNDGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public readonly bool EDDMOIMADLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public readonly MMMGGPPGMJP EAFONHFFBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public readonly OutfitType? BMPIGPFDBJF;

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C67C90", Offset = "0x6C66690", VA = "0x186C67C90")]
	public IIDLIHOEMPD(Transform CLLNNCNFMMG, bool MPGAHOENFHK, MMMGGPPGMJP KJPGGACJBAJ, [Optional] OutfitType? AGLNEGFKMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C67A80", Offset = "0x6C66480", VA = "0x186C67A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C67910", Offset = "0x6C66310", VA = "0x186C67910", Slot = "4")]
	public bool Equals(IIDLIHOEMPD GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6C67830", Offset = "0x6C66230", VA = "0x186C67830", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6C67A10", Offset = "0x6C66410", VA = "0x186C67A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface KPLGGIBDODG
{
	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGLNMPHDHGE(Mesh JMPEEMGIIHN, Matrix4x4 JJDMKAJDPGN, byte[] OILCEKBJFIE, bool NCHBJLBGLAD = false, NFCEEHLKBBE.NIHDBPDBFFB BBOHJOKNFLA = (NFCEEHLKBBE.NIHDBPDBFFB)0, int PIEDPAJDMCO = -1, bool KJPNBCEMLNB = false);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBALLNNCKBA(Allocator MCBEFIMHDPO, CPGEBJEPEII EECHIBLIDFD, byte NAPOEFBJCFI, [Optional] IList<int> LAKLDGFIAIJ, [Optional] IList<int> NMIKLKALEOE);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct CKAAJNHBPIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public readonly GameObject MNHDJJONFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private readonly AvatarItemMaterial CFNGIKBEPFM;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0xE07750", Offset = "0xE06150", VA = "0x180E07750")]
	public CKAAJNHBPIM(GameObject MNHDJJONFMN, AvatarItemMaterial CFNGIKBEPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C640D0", Offset = "0x6C62AD0", VA = "0x186C640D0")]
	public void CFBAINPPCCE(Material FLBCMGELMBF, int JJDMCGMMDHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class IFHPAONAKKK : MBIIHFDODNO<Task<(GameObject, AvatarItemMaterial)>, CKAAJNHBPIM>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct ANMCOJOFJMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6C5EE50", Offset = "0x6C5D850", VA = "0x186C5EE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F350", Offset = "0x6C5DD50", VA = "0x186C5F350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private FFCGNKADKHD<GameObject> DOEENNNGFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private FFCGNKADKHD<AvatarItemMaterial> FJCJBOAEEOH;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C677A0", Offset = "0x6C661A0", VA = "0x186C677A0")]
	private IFHPAONAKKK(Task<(GameObject, AvatarItemMaterial)> LPAAFOGOHKE, FFCGNKADKHD<GameObject> JEJHNEIAEJH, FFCGNKADKHD<AvatarItemMaterial> MFCFLEGIJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C67380", Offset = "0x6C65D80", VA = "0x186C67380")]
	public static IFHPAONAKKK LNCAGMGJJFK(AssetReference JAACHMMOGDM, [Optional] AssetReference EJBMLNKFNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6C67260", Offset = "0x6C65C60", VA = "0x186C67260", Slot = "11")]
	protected override CKAAJNHBPIM EOCJMLKEBNI(Task<(GameObject, AvatarItemMaterial)> BIJAKIMJMLF)
	{
		return default(CKAAJNHBPIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6C67300", Offset = "0x6C65D00", VA = "0x186C67300", Slot = "12")]
	protected override void HNMKLBOBHKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6C67130", Offset = "0x6C65B30", VA = "0x186C67130")]
	[AsyncStateMachine(typeof(ANMCOJOFJMJ))]
	private static Task<(GameObject, AvatarItemMaterial)> CKKGHHKNBBG(Task<GameObject> LHOFIHDOCCA, Task<AvatarItemMaterial> LAEMKHJOGLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ABBBIFEKECH
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class BBGEHNNIOPP : MBIIHFDODNO<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private FFCGNKADKHD<MaterialMapAsset> DFEBEONMKNH;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6C623C0", Offset = "0x6C60DC0", VA = "0x186C623C0")]
		public BBGEHNNIOPP(FFCGNKADKHD<MaterialMapAsset> DFEBEONMKNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6C61F40", Offset = "0x6C60940", VA = "0x186C61F40", Slot = "11")]
		protected override Material[] EOCJMLKEBNI(Task<MaterialMapAsset> LPAAFOGOHKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6C62360", Offset = "0x6C60D60", VA = "0x186C62360", Slot = "12")]
		protected override void HNMKLBOBHKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class GFOEAJFFGMG : MBIIHFDODNO<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private List<FFCGNKADKHD<Material>> PEIBLOJGPBB;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6C66CC0", Offset = "0x6C656C0", VA = "0x186C66CC0")]
		public GFOEAJFFGMG(Task<Material[]> LPAAFOGOHKE, List<FFCGNKADKHD<Material>> PEIBLOJGPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6C66B30", Offset = "0x6C65530", VA = "0x186C66B30", Slot = "11")]
		protected override Material[] EOCJMLKEBNI(Task<Material[]> BIJAKIMJMLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C66B80", Offset = "0x6C65580", VA = "0x186C66B80", Slot = "12")]
		protected override void HNMKLBOBHKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E9A0", Offset = "0x6C5D3A0", VA = "0x186C5E9A0")]
	public static FFCGNKADKHD<Material[]> PENGDGAOBJE(AssetReference[] DFGLBCILIDO)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public enum OKJIJOGELFA
		{
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum GIMINOMJJAJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public enum JIMPGMCNDFM : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct IOLMLLJGBEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			public readonly Material NKKCKOMLDBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public readonly OKJIJOGELFA KANPHLGALJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public readonly GIMINOMJJAJ DOKOEDGBKNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public readonly MMMGGPPGMJP AOEMNNKEDAM;

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x6C66810", Offset = "0x6C65210", VA = "0x186C66810")]
			public IOLMLLJGBEN(Material FLBCMGELMBF, OKJIJOGELFA NCONHOHPFDK, GIMINOMJJAJ BBJEEJDLEDG, MMMGGPPGMJP FHIDJIFAFFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F8B0", Offset = "0x6C7E2B0", VA = "0x186C7F8B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x6C664D0", Offset = "0x6C64ED0", VA = "0x186C664D0")]
			public bool LLKODAGINCO(IOLMLLJGBEN GDOGPMPJPOO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F730", Offset = "0x6C7E130", VA = "0x186C7F730", Slot = "0")]
			public override bool Equals(object BBNKFKDCOLP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F810", Offset = "0x6C7E210", VA = "0x186C7F810", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		protected struct OCDHEFPNDCE : IComparable<OCDHEFPNDCE>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			public int EHONCCNHDIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public PlayerAvatarDisplayBase BGELNEMCJAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public IList<MJOAJOOPMFL> EJFKJOJMFPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public AvatarItemBodyType FAOGDIELGIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public bool NLJJEOKGCGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public int[] PADJMBGNEFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public float NIPGNMFIFME;

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x6C820D0", Offset = "0x6C80AD0", VA = "0x186C820D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x6C820B0", Offset = "0x6C80AB0", VA = "0x186C820B0", Slot = "4")]
			public int CompareTo(OCDHEFPNDCE GDOGPMPJPOO)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		protected abstract class BGGDPIIFLHP
		{
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			public class LDAAEEDKCAE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000327")]
				public readonly Mesh HMNAGBOJDLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000328")]
				public readonly Material[] JKNNOJLGEDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000329")]
				public readonly Transform[] GFMEDKNGGGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				public readonly Matrix4x4[] AGCBIGACDOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				public readonly Transform PBBGCHEEGML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400032C")]
				public readonly bool HNNPPOIIPKD;

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
				protected LDAAEEDKCAE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x6C80900", Offset = "0x6C7F300", VA = "0x186C80900")]
				public LDAAEEDKCAE(Mesh JMPEEMGIIHN, Material[] MKMLOAIOLIN, bool EHJKBPGFCMH, Transform[] IMDKMCGLKCN, Transform LDPIBLKKLGM, Matrix4x4[] HMKMEHKFDGD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x6C80DB0", Offset = "0x6C7F7B0", VA = "0x186C80DB0")]
				private LDAAEEDKCAE(SkinnedMeshRenderer DEPAJOHPLLP, Material[] HPCKKLJBKNO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x6C80810", Offset = "0x6C7F210", VA = "0x186C80810")]
				private LDAAEEDKCAE(MeshRenderer FJMLLBKNEIH, Transform LDPIBLKKLGM, Material[] HPCKKLJBKNO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x6C804F0", Offset = "0x6C7EEF0", VA = "0x186C804F0")]
				public static LDAAEEDKCAE PLELGPNNBGG(Renderer OJIILOMBDFN, Material[] HPCKKLJBKNO)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public readonly MMMGGPPGMJP AOEMNNKEDAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public readonly Transform EMFIHGICEPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public readonly bool FLNMMIAKBHG;

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public virtual bool FBHBNFBGFMG
			{
				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public virtual bool MNLIJBKJNDN
			{
				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public virtual NFCEEHLKBBE.NIHDBPDBFFB AJFINJECLAP
			{
				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "6")]
				get
				{
					return default(NFCEEHLKBBE.NIHDBPDBFFB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool ACIDHEBHAFB
			{
				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x6C7A350", Offset = "0x6C78D50", VA = "0x186C7A350")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x6C7A360", Offset = "0x6C78D60", VA = "0x186C7A360")]
			protected BGGDPIIFLHP(MMMGGPPGMJP FHIDJIFAFFI, Transform PHICJCBAJBA, bool KHKDNBHOJIL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract HGKKEBPLLAP IPGAODEMIIL(int[] IGCDJBLFHMC, List<LOKHDAHPDJG> MFANIEFAEMI, List<LOKHDAHPDJG> KLKAFMKCABE);

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract LDAAEEDKCAE DEIKBAJPCPD(int CDLBFFAEOBG, PlayerHandBones AALPLPADEBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		protected class DBFBHAEMEFG : BGGDPIIFLHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			protected readonly BodyPartLODs ICGABEGPMIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			protected readonly Material[] AFCCEPMFHAH;

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C050", Offset = "0x6C7AA50", VA = "0x186C7C050")]
			public DBFBHAEMEFG(MMMGGPPGMJP FHIDJIFAFFI, BodyPartLODs GELKHKAKHKG, Material CLIMFIPHEKA, [Optional] Transform PHICJCBAJBA, bool KHKDNBHOJIL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BF50", Offset = "0x6C7A950", VA = "0x186C7BF50", Slot = "7")]
			public override HGKKEBPLLAP IPGAODEMIIL(int[] IGCDJBLFHMC, List<LOKHDAHPDJG> MFANIEFAEMI, List<LOKHDAHPDJG> KLKAFMKCABE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BD90", Offset = "0x6C7A790", VA = "0x186C7BD90", Slot = "8")]
			public override LDAAEEDKCAE DEIKBAJPCPD(int CDLBFFAEOBG, PlayerHandBones AALPLPADEBJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BFE0", Offset = "0x6C7A9E0", VA = "0x186C7BFE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected class ALMNDOOIJIJ : BGGDPIIFLHP
		{
			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public override bool FBHBNFBGFMG
			{
				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public override bool MNLIJBKJNDN
			{
				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x6C7A190", Offset = "0x6C78B90", VA = "0x186C7A190", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public FHPBLFIJPKH IANDNLAMJKP
			{
				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x8ADB30", Offset = "0x8AC530", VA = "0x1808ADB30")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x6C7A2E0", Offset = "0x6C78CE0", VA = "0x186C7A2E0")]
			public ALMNDOOIJIJ(MMMGGPPGMJP FHIDJIFAFFI, Transform PHICJCBAJBA, FHPBLFIJPKH PIICJMHEACM, bool KHKDNBHOJIL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x6C7A1E0", Offset = "0x6C78BE0", VA = "0x186C7A1E0", Slot = "7")]
			public override HGKKEBPLLAP IPGAODEMIIL(int[] IGCDJBLFHMC, List<LOKHDAHPDJG> MFANIEFAEMI, List<LOKHDAHPDJG> KLKAFMKCABE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "8")]
			public override LDAAEEDKCAE DEIKBAJPCPD(int CDLBFFAEOBG, PlayerHandBones AALPLPADEBJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x6C7A270", Offset = "0x6C78C70", VA = "0x186C7A270", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public class CNEIHNLIELC
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public enum KOCGNIAMJID
			{
				[Cpp2IlInjected.Token(Token = "0x4000340")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000341")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000342")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000343")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000344")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000345")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000346")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public static readonly int JNLDGJIGJLM;

			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public static readonly int BPJKFJEOEHE;

			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public static readonly int LMIFCEDEKFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			protected readonly BANGCCGDJKI DHCNMJBGHCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			protected readonly NFMINIFFNGH MEDCOAGPMIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			protected readonly Animator EMGPEOGCAEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			protected readonly Transform HHGACMMGJCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			protected readonly Vector3 JPGAEGIMIAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			protected readonly Transform HMGLNCDLGID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			protected readonly Vector3 GKHJFAJBJBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			protected bool PLNOJAEJNBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			protected FNNNPLJFKOG GLKCDHMACKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			protected bool FOLBCCFHNIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			protected float PKFHALBNKIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			protected FLHAJBLKMDB<NBILNDMKKPI> BEGJEBFNPEC;

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public FNNNPLJFKOG LJFFEAKLIFO
			{
				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x8AB1B0", Offset = "0x8A9BB0", VA = "0x1808AB1B0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x8AB240", Offset = "0x8A9C40", VA = "0x1808AB240")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public bool JOLMFFDECPD
			{
				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0xA0CA50", Offset = "0xA0B450", VA = "0x180A0CA50")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x6C7AC50", Offset = "0x6C79650", VA = "0x186C7AC50")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool BAMBKJLEOKI
			{
				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x8B0230", Offset = "0x8AEC30", VA = "0x1808B0230")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x6C7B570", Offset = "0x6C79F70", VA = "0x186C7B570")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public float MLLCCEIDNHJ
			{
				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0xBF0910", Offset = "0xBEF310", VA = "0x180BF0910")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x6C7B430", Offset = "0x6C79E30", VA = "0x186C7B430")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public NBILNDMKKPI NCBIOKDJLJP
			{
				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x6C7B340", Offset = "0x6C79D40", VA = "0x186C7B340")]
				get
				{
					return default(NBILNDMKKPI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x6C7ADD0", Offset = "0x6C797D0", VA = "0x186C7ADD0")]
			public bool ECFEKCCFMDP(NBILNDMKKPI JKFJACBJOJC, object AICEIDIHFDO, KOCGNIAMJID OFKEGOMNGIE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x6C7AA60", Offset = "0x6C79460", VA = "0x186C7AA60")]
			public bool BLEPDMAMEKO(object AICEIDIHFDO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x6C7B6E0", Offset = "0x6C7A0E0", VA = "0x186C7B6E0")]
			protected CNEIHNLIELC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x6C7B770", Offset = "0x6C7A170", VA = "0x186C7B770")]
			public CNEIHNLIELC(BANGCCGDJKI DHCNMJBGHCF, FNNNPLJFKOG KAKKFJOMIOJ, Animator EMGPEOGCAEK, Transform HHGACMMGJCI, Transform HMGLNCDLGID, Vector3 JPGAEGIMIAL, Vector3 GKHJFAJBJBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x6C7AD20", Offset = "0x6C79720", VA = "0x186C7AD20")]
			private void DJHKOPLCLMD(ushort DCLOCGAICPA, ushort HFFJLEIMCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x6C7AB60", Offset = "0x6C79560", VA = "0x186C7AB60")]
			protected void CNIFJPMHNPD(ushort DCLOCGAICPA, ushort HFFJLEIMCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x6C7B120", Offset = "0x6C79B20", VA = "0x186C7B120")]
			protected void ICMLGEBBCPK(ushort DCLOCGAICPA, ushort HFFJLEIMCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x6C7B000", Offset = "0x6C79A00", VA = "0x186C7B000")]
			protected void HKBEHJIFHHM(ushort DCLOCGAICPA, ushort HFFJLEIMCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x6C7B230", Offset = "0x6C79C30", VA = "0x186C7B230")]
			protected void LEEOEBCCCHN(ushort DCLOCGAICPA, ushort HFFJLEIMCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x6C7B3D0", Offset = "0x6C79DD0", VA = "0x186C7B3D0")]
			protected void NBHGNEHOJHB(ushort DCLOCGAICPA, ushort HFFJLEIMCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x6C7B1E0", Offset = "0x6C79BE0", VA = "0x186C7B1E0")]
			protected void JPBNDHOKHCM(ushort DCLOCGAICPA, ushort HFFJLEIMCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x6C7B380", Offset = "0x6C79D80", VA = "0x186C7B380")]
			protected void MJOCCMAFGLG(ushort DCLOCGAICPA, ushort HFFJLEIMCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x6C7AEE0", Offset = "0x6C798E0", VA = "0x186C7AEE0")]
			protected void FEBBJPMIMMG(ushort DCLOCGAICPA, ushort HFFJLEIMCMF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public class GIGDJMIIFGH : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public const int KMNNJIAEONB = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			protected MaterialPropertyBlock EMAMEEDPLAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public Color? KPAFJOIOPPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public Color? NIJJLMCKDEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public Color? KHNLLBEEMLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public Color DJKLIIJDMOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public Color FEDHPBBNPKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Color DEMAEEHPDDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public Texture2D AHPGNANPNKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public Texture2D DCGHJPICJAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			protected Dictionary<IOLMLLJGBEN, int> BIKINIDKOMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			protected OKJIJOGELFA[] CDGLFHBEGAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public Vector4[] IOGIHJEOPMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public Vector4[] CLMBDGFDNOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public Vector4[] DHEIOAOPOMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Vector4[] IPLBCDBBOLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public Vector4[] HHMJOBJDKIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public Vector4[] NDOKKLHHLFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			protected List<Texture2D> FDLILFAPNMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			protected Vector4[] BHOKDEHLJMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			protected List<Texture2D> MNGGBPIHHIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			protected float[] OODOEJDPBDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			protected Vector4[] PGEPNPOPBHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			protected float[] NPMHPFPHCDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public float[] EPLCCHAIAHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			protected List<Texture2D> NOGCKIGMICL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			protected float[] PPAAOEODEOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			protected List<Texture2D> KDLLIFPCGCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			protected Vector4[] JMKONAMFBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			protected float[] CDKLGKCLFLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			protected Vector4[] DCHDPLBADJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public float[] LFPIFDDNMCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public Texture2DArray OJEJGNIDLKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public Texture2DArray BJPMBJNAOAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public Texture2DArray ILDFBFANACD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Texture2DArray FHBICDJLCGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			protected bool NCGANKCJAIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected int PKFGJCFMFKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected Vector2? DCJDBGINCEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected TextureFormat HEBOJBENADO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected Vector2? HMHHIPANCAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected TextureFormat BCEMEIEBBBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected Vector2? PGJAMEOEBIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected TextureFormat KKPNHHCFBMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected Vector2? GABHHBDBIAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected TextureFormat FJADGNCEOFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected bool IFCFLPBDAAE;

			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected static int KIBPKNKOJOP;

			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected static int HLIIBDIKDDE;

			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected static int BJMDLKEAHAC;

			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected static int MDIBANKGKIB;

			[Cpp2IlInjected.Token(Token = "0x400037A")]
			protected static int CDDGBHNKENH;

			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected static int LKOJFHDAJKA;

			[Cpp2IlInjected.Token(Token = "0x400037C")]
			protected static int LPJEFEOKHPN;

			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected static int LMFCCIALOBH;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			protected static int OKPHJKJFBCA;

			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected static int HDALKJEHLOA;

			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected static int COKKPLANHDL;

			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected static int MDDBOKEMLDP;

			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected static int NACBMABBCMH;

			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected static int MAKOANFCCOD;

			[Cpp2IlInjected.Token(Token = "0x4000384")]
			protected static int BKPCIPGEKDB;

			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected static int HDIGHCEPPPD;

			[Cpp2IlInjected.Token(Token = "0x4000386")]
			protected static int LLDHOPBPOAL;

			[Cpp2IlInjected.Token(Token = "0x4000387")]
			protected static int BONHJPOBFCG;

			[Cpp2IlInjected.Token(Token = "0x4000388")]
			protected static int IHBOLHLAKEH;

			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected static int LODBPEACBEL;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x6C7EA90", Offset = "0x6C7D490", VA = "0x186C7EA90")]
			protected GIGDJMIIFGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x6C7EF50", Offset = "0x6C7D950", VA = "0x186C7EF50")]
			public GIGDJMIIFGH(Color AHJFPMLDBHH, Color GGCJAJCCLND, Color JBHGLNJJJNA, Color? HKCIGKMGBDC, Color? MJPOMCEAFEC, Color? MFLKKNJHNJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x6C7D4F0", Offset = "0x6C7BEF0", VA = "0x186C7D4F0")]
			public int CLKCNMBNBFC(Material OFPAJFFLKPG, OKJIJOGELFA NCONHOHPFDK, GIMINOMJJAJ BBJEEJDLEDG, MMMGGPPGMJP FHIDJIFAFFI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x6C7D5E0", Offset = "0x6C7BFE0", VA = "0x186C7D5E0")]
			public int CLKCNMBNBFC(IOLMLLJGBEN PNABAFEIDND)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x6C7D870", Offset = "0x6C7C270", VA = "0x186C7D870")]
			public int IOHAOIGLOOM(Material OFPAJFFLKPG, Color MMJLBGNBGBI, Color LMEHIPBODIP, Color CFLNDOLFFHJ, Color PHLCDLDCJJB, Color JOEHGPNEGMH, Texture2D GAHELHHLLKM, Vector4 CBCDPIOHJFP, Texture2D JIKAKDAADOL, Vector4 JJKFOBBIHCB, float OAPENEMJACD, float JNPMJJMFHCC, Texture2D HLNCOFFOGHB, Vector4 DJOJPNNODMP, float NEEFACHHBFP, Texture2D ILLFPHGJHNL, float MJPIHMNBPBO, Color NLFKGBEMHJI, Vector4 AIOCHMEOPCI, OKJIJOGELFA NCONHOHPFDK, GIMINOMJJAJ BBJEEJDLEDG, MMMGGPPGMJP FHIDJIFAFFI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6C7D6B0", Offset = "0x6C7C0B0", VA = "0x186C7D6B0")]
			protected void HIIBNKIIOKA([Out] Texture2DArray BAHKMJDBGIC, [Out] Texture2DArray MPAMMGAEFJL, [Out] Texture2DArray GBENFLLAFED, [Out] Texture2DArray DCPLBKJDIMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C5B0", Offset = "0x6C7AFB0", VA = "0x186C7C5B0")]
			public void ADKDCMGEMPI(PlayerAvatarDisplayBase JAHJMAGBOHM, Renderer OJIILOMBDFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x6C7CA00", Offset = "0x6C7B400", VA = "0x186C7CA00")]
			protected void ANFCMPNLFPO(PlayerAvatarDisplayBase JAHJMAGBOHM, Renderer OJIILOMBDFN, int LAOMEDIOFOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C810", Offset = "0x6C7B210", VA = "0x186C7C810")]
			private Color AEECBMEPKMG(Color FFGDOCPJKHO, OKJIJOGELFA MLHMODFCJOL)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x6C7E560", Offset = "0x6C7CF60", VA = "0x186C7E560")]
			private Color PELKPONJMDH(Color FLEAKFHPMFE, OKJIJOGELFA MLHMODFCJOL)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x6C7E6B0", Offset = "0x6C7D0B0", VA = "0x186C7E6B0")]
			protected void PHPLCFECGLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x6C7D670", Offset = "0x6C7C070", VA = "0x186C7D670", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x6C87F20", Offset = "0x6C86920", VA = "0x186C87F20")]
			public void GPENBGDKCMJ(MMMGGPPGMJP FHIDJIFAFFI, [Out] Transform ELFANOAFHKM, [Out] Transform[] IMDKMCGLKCN)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class OEOBBIEOAGA : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
			[DebuggerHidden]
			public OEOBBIEOAGA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x6C82220", Offset = "0x6C80C20", VA = "0x186C82220", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x6C824A0", Offset = "0x6C80EA0", VA = "0x186C824A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x6C823F0", Offset = "0x6C80DF0", VA = "0x186C823F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x6C823F0", Offset = "0x6C80DF0", VA = "0x186C823F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class CDFGOOGNMNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public CDFGOOGNMNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x6C7A980", Offset = "0x6C79380", VA = "0x186C7A980")]
			internal bool GELEOJMCMNA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class KOGKOFHLFOH : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private BGFOJNANPKN <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
			[DebuggerHidden]
			public KOGKOFHLFOH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x6C80210", Offset = "0x6C7EC10", VA = "0x186C80210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x6C804A0", Offset = "0x6C7EEA0", VA = "0x186C804A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private struct NNMBKEHHAMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public BPKALIODDHJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x6C819C0", Offset = "0x6C803C0", VA = "0x186C819C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x6C82050", Offset = "0x6C80A50", VA = "0x186C82050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class CNHHPPHIHIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public CNHHPPHIHIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BD60", Offset = "0x6C7A760", VA = "0x186C7BD60")]
			internal bool MNBGNPBGABB(MJOAJOOPMFL selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class NDILMAALJLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public Func<BJOGDIODDMJ<Dictionary<string, FFCGNKADKHD<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public NDILMAALJLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x6C81780", Offset = "0x6C80180", VA = "0x186C81780")]
			internal (OLPMMAHKODD, BJOGDIODDMJ<Dictionary<string, FFCGNKADKHD<Texture2D>>>) NKBAOJKKFBN(Dictionary<string, NDBCELDDCHJ> avatarItems)
			{
				return default((OLPMMAHKODD, BJOGDIODDMJ<Dictionary<string, FFCGNKADKHD<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x6C81710", Offset = "0x6C80110", VA = "0x186C81710")]
			internal BJOGDIODDMJ<Dictionary<string, FFCGNKADKHD<Texture2D>>> IOOLDLPMBCJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x6C81980", Offset = "0x6C80380", VA = "0x186C81980")]
			internal void PNCFIJKAKMI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class PJCFBCMLJDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public PJCFBCMLJDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x6C824F0", Offset = "0x6C80EF0", VA = "0x186C824F0")]
			internal bool AOOGCFJGMKJ(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct IDMCCDDHJHI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F500", Offset = "0x6C7DF00", VA = "0x186C7F500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F6D0", Offset = "0x6C7E0D0", VA = "0x186C7F6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		protected static readonly int LOKOKNOFBFJ;

		[Cpp2IlInjected.Token(Token = "0x400028E")]
		protected static readonly int BLNNLNIOIJK;

		[Cpp2IlInjected.Token(Token = "0x400028F")]
		protected static readonly int JCDGHCDHMOK;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		protected static readonly int KJEIAGAAJCA;

		[Cpp2IlInjected.Token(Token = "0x4000291")]
		protected static readonly int PEDGBNLDIHC;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		protected static readonly int HBJODFANLAK;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		protected static readonly int[] DAGPIMOKJFM;

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		protected static readonly int[] MIIONMHIJDH;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		protected static readonly int[] FOECBFPDLEG;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		protected static readonly int[] BDIFEMHCBJH;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		protected static readonly int[] CKIKBBBCIAK;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		protected static readonly int[] ELAJOHHKEEP;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		protected static List<PlayerAvatarDisplayBase> NHBOAMEBOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		protected EHJGPOKJPHL KIBJMIHKDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		protected bool MNDFHCGFEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		protected bool BEDGFHJMMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		protected static readonly int[] FJKEPLGGDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		protected Dictionary<IOLMLLJGBEN, Material> BEDEGICBLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		protected Dictionary<IOLMLLJGBEN, Material> IFGAMPICJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		protected Material FJNPFECKKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		protected GIGKENLKLJE DKEADOAHJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private FNNNPLJFKOG ICCDGNKOAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private FNNNPLJFKOG ELFIDCAKNMG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected Material FDLOBOANMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected FitMeshHemisphere DGCLDAMKLBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected bool LPBFMJBGLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected IJDPLHMEMPG DNNKGMFJIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected bool ALNIAHLDLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected AnchorParamsRestrictions KELLLPAOMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected bool OOMKLIKKKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected Transform BJHMNHMNHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected bool FDAFCHOFKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected bool FNFAIBOJCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected Vector3 BNKLCMJFDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected Quaternion HIFNPFBNFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		protected Vector2 ADJJJODDCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected FitMeshHemisphere IEMFHBNPJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected Collider[] JOCGFCNCMIJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		protected Collider[] GGEOFCDJCGH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		protected CNEIHNLIELC[] MLNMHEJIEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public Dictionary<Renderer, GIGDJMIIFGH> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		protected Dictionary<Renderer, GIGDJMIIFGH> AMFHNPNGGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected JNMKNJLLNNL MKMLPNMPDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected OLPMMAHKODD HICHPFKEKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public DEMMDJFFENH DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected int AAPCDCKAFEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected FLHAJBLKMDB<NFMINIFFNGH> BEGJEBFNPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		protected bool HNGIJELNLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected Dictionary<MJOAJOOPMFL, List<IOLMLLJGBEN>> LLNIAGIAFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		protected Dictionary<MJOAJOOPMFL, List<IOLMLLJGBEN>> DAJCMKIKLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		protected readonly Dictionary<string, FFCGNKADKHD<Texture2D>> BHALDKFLKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		protected readonly Dictionary<string, FFCGNKADKHD<Texture2D>> GOKPAJBDHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected bool DANBBEAPFOG;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		protected static int PMGCFEPOFGE;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		protected static List<OCDHEFPNDCE> BMOFFDIHAAF;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected static OIMBFIPCENK EMBNCFHGFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected Color? EOHKMGDCJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected bool AIGKHFAFPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected Color NPJHFHLFKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected Color? HOFGGDLIMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected Color? PNBOABMBEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected AvatarHairPattern DKHKHAFCPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected FHPBLFIJPKH PFPIDOOKPGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected Color GGLEIFNEJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected Color FFAPNBOAAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected AvatarHairPattern NFAHFAPCOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected FHPBLFIJPKH NOCGLBIFFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected FHPBLFIJPKH LJMFKEINGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected Color LGFIEEKFAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private AdditionalFeetData CGBLOJFJCAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected MJOAJOOPMFL? DGGCFGCOPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected Texture JEMBJHNCNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected Color IKPAEPHLKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected readonly IList<MJOAJOOPMFL> JFBADBGNNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected readonly IList<MJOAJOOPMFL> DDEMPNIIBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private AvatarItemBodyType DPHBKMAJPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B1")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected JIMPGMCNDFM JFHPECFJAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected int[] EJJIJFGKMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected bool OCABPKEBLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected int[] IFFJOICBDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected bool LHBNJDDJGIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected FOMNMHHOGJM PIOMPLPDJBK;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string LEGFCIMFMMP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool LIJIMGLIGKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x935D30", Offset = "0x934730", VA = "0x180935D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x9D8A20", Offset = "0x9D7420", VA = "0x1809D8A20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual bool CDFHPDDJCBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool NDJNLMGHNEE
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6C78F70", Offset = "0x6C77970", VA = "0x186C78F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual bool MMEMBGLDCJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual bool MHAFEJOPIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool MHNHCPEHDME
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public GIGKENLKLJE DOADFPLCOHG
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x97E7D0", Offset = "0x97D1D0", VA = "0x18097E7D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x6C79550", Offset = "0x6C77F50", VA = "0x186C79550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public FNNNPLJFKOG GKEJPLBBKAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x97E7F0", Offset = "0x97D1F0", VA = "0x18097E7F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x6C798A0", Offset = "0x6C782A0", VA = "0x186C798A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public FNNNPLJFKOG LDFFEHCFLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x97E800", Offset = "0x97D200", VA = "0x18097E800")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x6C79B50", Offset = "0x6C78550", VA = "0x186C79B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		protected Material MDOGNFLIADA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x6C6CF70", Offset = "0x6C6B970", VA = "0x186C6CF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected Material JFGJMMFKMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6C6F910", Offset = "0x6C6E310", VA = "0x186C6F910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool GGKJDKPHEOL
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1663770", Offset = "0x1662170", VA = "0x181663770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public PlayerFacialAnimatorBase BBKDECINCFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x97E9E0", Offset = "0x97D3E0", VA = "0x18097E9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public CNEIHNLIELC[] KDCPFHNCACI
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x6C78B40", Offset = "0x6C77540", VA = "0x186C78B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public CNEIHNLIELC HGKJPMKHHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x6C79160", Offset = "0x6C77B60", VA = "0x186C79160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public CNEIHNLIELC KOLNHNCGEFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x6C79190", Offset = "0x6C77B90", VA = "0x186C79190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Mesh NHGHBMKNBHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x97E710", Offset = "0x97D110", VA = "0x18097E710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		protected JNMKNJLLNNL EDLFFKKABGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x6C74500", Offset = "0x6C72F00", VA = "0x186C74500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected OLPMMAHKODD DKLGAGOOFOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x97E690", Offset = "0x97D090", VA = "0x18097E690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x6C70740", Offset = "0x6C6F140", VA = "0x186C70740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected bool JFCKIHLGEEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool JOEFJKJANCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x6C79150", Offset = "0x6C77B50", VA = "0x186C79150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int OBNJDDPJAIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1AEA3C0", Offset = "0x1AE8DC0", VA = "0x181AEA3C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x6C79AB0", Offset = "0x6C784B0", VA = "0x186C79AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual bool DNNCKLDIODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual int[] FALEEOMBOEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x6C6EBB0", Offset = "0x6C6D5B0", VA = "0x186C6EBB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected bool EJILNGLKDIO
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x6C70AE0", Offset = "0x6C6F4E0", VA = "0x186C70AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected static bool FBHHIPDEEFE
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool OCCPNMBIENF
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xCE2DD0", Offset = "0xCE17D0", VA = "0x180CE2DD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x6C79D60", Offset = "0x6C78760", VA = "0x186C79D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public IEnumerable<SkinnedMeshRenderer> DLKPEGJBFHF
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x6C78A20", Offset = "0x6C77420", VA = "0x186C78A20")]
			[IteratorStateMachine(typeof(OEOBBIEOAGA))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool NPNEBPFKOPN
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xCE3860", Offset = "0xCE2260", VA = "0x180CE3860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xCE3E90", Offset = "0xCE2890", VA = "0x180CE3E90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public CNAPJFDNBAH AJHADNBDOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x6C78AA0", Offset = "0x6C774A0", VA = "0x186C78AA0")]
			get
			{
				return default(CNAPJFDNBAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public static bool CLMMPLDEBLI
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x6C78EE0", Offset = "0x6C778E0", VA = "0x186C78EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		protected static OIMBFIPCENK FKAFCDHNNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x6C6E480", Offset = "0x6C6CE80", VA = "0x186C6E480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x6C6FA00", Offset = "0x6C6E400", VA = "0x186C6FA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		protected Color? NIJJLMCKDEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x6C6C890", Offset = "0x6C6B290", VA = "0x186C6C890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected Color? KHNLLBEEMLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x6C6F130", Offset = "0x6C6DB30", VA = "0x186C6F130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Texture2D LJMKHDNKHPK
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x6C6E1F0", Offset = "0x6C6CBF0", VA = "0x186C6E1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected Color DJKLIIJDMOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x6C73620", Offset = "0x6C72020", VA = "0x186C73620")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected Color FEDHPBBNPKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x6C6D280", Offset = "0x6C6BC80", VA = "0x186C6D280")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public FHPBLFIJPKH MLCFEBKDDEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x6C78B00", Offset = "0x6C77500", VA = "0x186C78B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected Texture2D IMAPGLIOAMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x6C6F540", Offset = "0x6C6DF40", VA = "0x186C6F540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public float MMNJKOEOEHM
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x6C78B20", Offset = "0x6C77520", VA = "0x186C78B20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public float APKNGJJHOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x6C78F50", Offset = "0x6C77950", VA = "0x186C78F50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool GCNFKBNIOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xE4FF20", Offset = "0xE4E920", VA = "0x180E4FF20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x6C79320", Offset = "0x6C77D20", VA = "0x186C79320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KDNPONDMNCC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x6C788C0", Offset = "0x6C772C0", VA = "0x186C788C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x6C791C0", Offset = "0x6C77BC0", VA = "0x186C791C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<BANGCCGDJKI, NBILNDMKKPI> GBBBOEIEJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x6C78960", Offset = "0x6C77360", VA = "0x186C78960")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x6C79260", Offset = "0x6C77C60", VA = "0x186C79260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C75B40", Offset = "0x6C74540", VA = "0x186C75B40")]
		public bool SetDeformation(bool MNDFHCGFEIP, bool BEDGFHJMMHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F330", Offset = "0x6C6DD30", VA = "0x186C6F330")]
		protected static Material EIEPJJLGNPH(Dictionary<IOLMLLJGBEN, Material> MPMJPFNPNFL, Material HLEFLOBJCAM, OKJIJOGELFA NCONHOHPFDK, GIMINOMJJAJ BBJEEJDLEDG, MMMGGPPGMJP FHIDJIFAFFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C70160", Offset = "0x6C6EB60", VA = "0x186C70160")]
		protected void GFMMJBNGAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C71910", Offset = "0x6C70310", VA = "0x186C71910")]
		protected bool JDECGPHKOBG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CB50", Offset = "0x6C6B550", VA = "0x186C6CB50")]
		protected void AGBDDLLGGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6C72F70", Offset = "0x6C71970", VA = "0x186C72F70", Slot = "10")]
		protected virtual void LFDBAPIBJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6C73D50", Offset = "0x6C72750", VA = "0x186C73D50")]
		public int MeshesAtLODCount(int KLNKGOMPHMO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6C6EE50", Offset = "0x6C6D850", VA = "0x186C6EE50")]
		protected static void EDLKLNADJKF(Dictionary<MJOAJOOPMFL, List<IOLMLLJGBEN>> GBCGAMNIJHH, BGGDPIIFLHP NMJALODMKLH, Material HLEFLOBJCAM, OKJIJOGELFA MLHMODFCJOL, GIMINOMJJAJ OPGNMPHECNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E020", Offset = "0x6C6CA20", VA = "0x186C6E020")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6C74770", Offset = "0x6C73170", VA = "0x186C74770")]
		protected void OPBLLNLIAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6C74AB0", Offset = "0x6C734B0", VA = "0x186C74AB0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "11")]
		protected virtual void MHLBPNGKDPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6C743C0", Offset = "0x6C72DC0", VA = "0x186C743C0")]
		protected static void NNNGNOIJFDM(List<Material> GLBMPPONGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F1D0", Offset = "0x6C6DBD0", VA = "0x186C6F1D0")]
		protected static void EHBPGGLBNBC(Dictionary<IOLMLLJGBEN, Material> MPMJPFNPNFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6C71180", Offset = "0x6C6FB80", VA = "0x186C71180")]
		protected static void ILEIHEOHMAA(Dictionary<Renderer, GIGDJMIIFGH> BJAJNDJPBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D640", Offset = "0x6C6C040", VA = "0x186C6D640")]
		protected void APGHOEFMKAL(SkinnedMeshRenderer[] ALHPFKMMOEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6C73C80", Offset = "0x6C72680", VA = "0x186C73C80")]
		protected void MEGAEHNAAOJ(SkinnedMeshRenderer DEPAJOHPLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6C73BB0", Offset = "0x6C725B0", VA = "0x186C73BB0")]
		protected void MEGAEHNAAOJ(MeshRenderer FJMLLBKNEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6C74590", Offset = "0x6C72F90", VA = "0x186C74590")]
		protected void OMJKFNBHMMJ(List<LOKHDAHPDJG> DMHEDDEPBPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6C70F60", Offset = "0x6C6F960", VA = "0x186C70F60")]
		protected void IKHDKOPMECC(Dictionary<string, FFCGNKADKHD<Texture2D>> GBCGAMNIJHH, bool GEHOHHKOHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6C73E10", Offset = "0x6C72810", VA = "0x186C73E10")]
		protected void NDHFJMBABMB(Dictionary<MJOAJOOPMFL, List<IOLMLLJGBEN>> GBCGAMNIJHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6C70640", Offset = "0x6C6F040", VA = "0x186C70640")]
		public float GetHandOpenClosedAxis(BANGCCGDJKI DHCNMJBGHCF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6C76400", Offset = "0x6C74E00", VA = "0x186C76400")]
		public void SetHandOpenClosedAxis(BANGCCGDJKI DHCNMJBGHCF, float JGAHEDHBINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6C70680", Offset = "0x6C6F080", VA = "0x186C70680")]
		public NBILNDMKKPI GetHandVisualState(BANGCCGDJKI DHCNMJBGHCF)
		{
			return default(NBILNDMKKPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D760", Offset = "0x6C6C160", VA = "0x186C6D760")]
		public bool AddHandVisualStateToken(BANGCCGDJKI DHCNMJBGHCF, NBILNDMKKPI BKEGDHEELEC, object AICEIDIHFDO, CNEIHNLIELC.KOCGNIAMJID OFKEGOMNGIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6C779C0", Offset = "0x6C763C0", VA = "0x186C779C0")]
		public void SetWatchHand(BANGCCGDJKI DHCNMJBGHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6C75220", Offset = "0x6C73C20", VA = "0x186C75220")]
		public bool RemoveHandVisualStateToken(BANGCCGDJKI DHCNMJBGHCF, object AICEIDIHFDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6C70700", Offset = "0x6C6F100", VA = "0x186C70700")]
		public bool GetThumbsUpActive(BANGCCGDJKI DHCNMJBGHCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6C775B0", Offset = "0x6C75FB0", VA = "0x186C775B0")]
		public void SetThumbsUpActive(BANGCCGDJKI DHCNMJBGHCF, bool GOIMGMLHNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6C706C0", Offset = "0x6C6F0C0", VA = "0x186C706C0")]
		public bool GetHandshakeActive(BANGCCGDJKI DHCNMJBGHCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6C76450", Offset = "0x6C74E50", VA = "0x186C76450")]
		public void SetHandshakeActive(BANGCCGDJKI DHCNMJBGHCF, bool LCPANPJJOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FE40", Offset = "0x6C6E840", VA = "0x186C6FE40")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6C6EAD0", Offset = "0x6C6D4D0", VA = "0x186C6EAD0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F7A0", Offset = "0x6C6E1A0", VA = "0x186C6F7A0")]
		protected static void FLENFPAIIJD(PlayerAvatarDisplayBase LIGGDLJGHGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6C74F60", Offset = "0x6C73960", VA = "0x186C74F60")]
		public void Rebuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6C741C0", Offset = "0x6C72BC0", VA = "0x186C741C0")]
		protected void NHHIGPIMCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6C74210", Offset = "0x6C72C10", VA = "0x186C74210", Slot = "12")]
		protected virtual HGKKEBPLLAP NHHIGPIMCHE(IList<MJOAJOOPMFL> GDMJCHJGHDI, AvatarItemBodyType IILEOGELHOD, bool NDCDOOMNKLN, int[] IGCDJBLFHMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6C71480", Offset = "0x6C6FE80", VA = "0x186C71480")]
		protected static HGKKEBPLLAP JANLFNFPJEC(OCDHEFPNDCE MIPMJFLONAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E3A0", Offset = "0x6C6CDA0", VA = "0x186C6E3A0")]
		[IteratorStateMachine(typeof(KOGKOFHLFOH))]
		protected static IEnumerator<BGFOJNANPKN> BLFBLEMNMHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6C712E0", Offset = "0x6C6FCE0", VA = "0x186C712E0")]
		protected static OCDHEFPNDCE IOKOFMIPGLM(List<OCDHEFPNDCE> KMGJHGKJHPF)
		{
			return default(OCDHEFPNDCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6C75C50", Offset = "0x6C74650", VA = "0x186C75C50")]
		[AsyncStateMachine(typeof(NNMBKEHHAMO))]
		public Task SetFaceCustomizationSettings(BPKALIODDHJ EMODBHKBJEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6C713A0", Offset = "0x6C6FDA0", VA = "0x186C713A0")]
		public void InitializeFaceFeatures(AvatarConfiguration HGDCCILLGDP, CNAPJFDNBAH IFNFJLLNCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6C77300", Offset = "0x6C75D00", VA = "0x186C77300")]
		public void SetTeamColors(Color? MFLKKNJHNJN, bool OHFEIHFLECE, Color FNOMDKEPLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xDA13F0", Offset = "0xD9FDF0", VA = "0x180DA13F0")]
		private static void LFHFNIECALB(Material FLBCMGELMBF, Color PKCLPFEIPFH, params int[] HEDABHJPOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xDA1A30", Offset = "0xDA0430", VA = "0x180DA1A30")]
		private static void MEIJHNLGHPP(Material FLBCMGELMBF, Texture PKCLPFEIPFH, params int[] HEDABHJPOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CBE0", Offset = "0x6C6B5E0", VA = "0x186C6CBE0")]
		protected void AHCHFAKNKKE(Material OJDHFLBABNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6C71B30", Offset = "0x6C70530", VA = "0x186C71B30")]
		protected void JJDGMCFNBNG(Material OJDHFLBABNA, Color IBKJGMDJINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6C70280", Offset = "0x6C6EC80", VA = "0x186C70280")]
		protected void GKALGKCDBGO(Material OJDHFLBABNA, Color IBKJGMDJINC, Color GIGGHAHBMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6C73410", Offset = "0x6C71E10", VA = "0x186C73410")]
		protected void LMFAHNOGNDJ(Material OJDHFLBABNA, Texture2D AGFHPNOIBGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C90", Offset = "0x6C6F690", VA = "0x186C70C90")]
		protected void IGNEAOFJPLO(Material OJDHFLBABNA, Texture ACBIGJMDJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F640", Offset = "0x6C6E040", VA = "0x186C6F640")]
		protected void FIKLOKJBNOJ(Action<GIGDJMIIFGH> CDNNPAOMCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FEA0", Offset = "0x6C6E8A0", VA = "0x186C6FEA0")]
		protected void GDGIMLIKLGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6C70DA0", Offset = "0x6C6F7A0", VA = "0x186C70DA0")]
		protected void IJJGOBBCODO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6C73E60", Offset = "0x6C72860", VA = "0x186C73E60")]
		protected void NEJHEFJHCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6C6DAB0", Offset = "0x6C6C4B0", VA = "0x186C6DAB0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6C755E0", Offset = "0x6C73FE0", VA = "0x186C755E0")]
		public void SetBeardPrimaryColor([Optional] Color? HGFDLOGOOLA, bool JOFHODAECFG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6C757F0", Offset = "0x6C741F0", VA = "0x186C757F0")]
		public void SetBeardSecondaryColor([Optional] Color? HGFDLOGOOLA, bool JOFHODAECFG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6C754A0", Offset = "0x6C73EA0", VA = "0x186C754A0")]
		public void SetBeardPattern([Optional] AvatarHairPattern OMDPCMMJDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6C74CF0", Offset = "0x6C736F0", VA = "0x186C74CF0")]
		private void PAIPGFAFFND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6C72EC0", Offset = "0x6C718C0", VA = "0x186C72EC0")]
		private bool KIGNLKAMEPI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6C75FC0", Offset = "0x6C749C0", VA = "0x186C75FC0")]
		public void SetHairPrimaryColor([Optional] Color? DALBIJFFNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6C761E0", Offset = "0x6C74BE0", VA = "0x186C761E0")]
		public void SetHairSecondaryColor([Optional] Color? DALBIJFFNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6C75E90", Offset = "0x6C74890", VA = "0x186C75E90")]
		public void SetHairPattern([Optional] AvatarHairPattern OMDPCMMJDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6C750C0", Offset = "0x6C73AC0", VA = "0x186C750C0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E130", Offset = "0x6C6CB30", VA = "0x186C6E130")]
		private bool BEIGAOPDIKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6C77140", Offset = "0x6C75B40", VA = "0x186C77140")]
		public void SetSkinColor(Color AHJFPMLDBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6C77600", Offset = "0x6C76000", VA = "0x186C77600")]
		public void SetUgcItemVisualOverrides(MJOAJOOPMFL BBGAALBIIHP, CNAPJFDNBAH IFNFJLLNCCJ, Texture FDDBGCBLPFB, Color IHDKLLBKAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6C6EB60", Offset = "0x6C6D560", VA = "0x186C6EB60")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6C75D50", Offset = "0x6C74750", VA = "0x186C75D50")]
		public bool SetFaceShape(AvatarFaceShape HOEAJIPLKOA, bool DIIOKCIFCBN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6C75A00", Offset = "0x6C74400", VA = "0x186C75A00")]
		public bool SetBodyShape(AvatarBodyShape BNAFFFKPJLG, bool DIIOKCIFCBN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6C77B10", Offset = "0x6C76510", VA = "0x186C77B10")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6C77090", Offset = "0x6C75A90", VA = "0x186C77090")]
		public bool SetHideEars(bool PNAEEIABIHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6C77080", Offset = "0x6C75A80", VA = "0x186C77080")]
		public bool SetHelmetHair(EHJGPOKJPHL BOAFJIEDLMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6C764A0", Offset = "0x6C74EA0", VA = "0x186C764A0")]
		public void SetHatAnchorParameters(IJDPLHMEMPG EMNBPJKHOLK, bool BMEHELBGDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6C77A80", Offset = "0x6C76480", VA = "0x186C77A80")]
		public void SetupDisplayLODs(JIMPGMCNDFM FKILCBPNHBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6C707E0", Offset = "0x6C6F1E0", VA = "0x186C707E0")]
		protected int[] HGDBMKHFNEL(JIMPGMCNDFM FKILCBPNHBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6C770E0", Offset = "0x6C75AE0", VA = "0x186C770E0")]
		public void SetOutfitSelections(IList<MJOAJOOPMFL> GDMJCHJGHDI, AvatarItemBodyType IILEOGELHOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6C77110", Offset = "0x6C75B10", VA = "0x186C77110")]
		public void SetOutfitSelections(IList<MJOAJOOPMFL> GDMJCHJGHDI, AvatarItemBodyType IILEOGELHOD, bool NDCDOOMNKLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6C770B0", Offset = "0x6C75AB0", VA = "0x186C770B0")]
		public HGKKEBPLLAP SetOutfitSelections(IList<MJOAJOOPMFL> GDMJCHJGHDI, AvatarItemBodyType IILEOGELHOD, JIMPGMCNDFM FKILCBPNHBL, bool NDCDOOMNKLN, bool DIIOKCIFCBN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FBC0", Offset = "0x6C6E5C0", VA = "0x186C6FBC0")]
		private HGKKEBPLLAP FOMKPEEKJPP(IList<MJOAJOOPMFL> GDMJCHJGHDI, AvatarItemBodyType IILEOGELHOD, bool NDCDOOMNKLN, JIMPGMCNDFM FKILCBPNHBL, bool DIIOKCIFCBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6C74E60", Offset = "0x6C73860", VA = "0x186C74E60")]
		protected int[] PFEAOIOHAPF(JIMPGMCNDFM FKILCBPNHBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "13")]
		protected virtual OLPMMAHKODD FGBNLMALCHJ(AvatarItemBodyType OKEIHNNHJNC, Dictionary<string, NDBCELDDCHJ> LJNKBLLDKAE, Dictionary<string, FFCGNKADKHD<Texture2D>> JLBKBPINANK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C930", Offset = "0x6C6B330", VA = "0x186C6C930", Slot = "14")]
		protected virtual HGKKEBPLLAP AEOAFOCDKFD(IList<MJOAJOOPMFL> GDMJCHJGHDI, AvatarItemBodyType IILEOGELHOD, bool NDCDOOMNKLN, int[] PADJMBGNEFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6C73670", Offset = "0x6C72070", VA = "0x186C73670", Slot = "15")]
		protected virtual NDBCELDDCHJ MBJGGKOMIFN(FHPBLFIJPKH PIICJMHEACM, AvatarItemBodyType OKEIHNNHJNC, MMMGGPPGMJP FHIDJIFAFFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E400", Offset = "0x6C6CE00", VA = "0x186C6E400")]
		protected void CCLGNDPFAKE(DIBDFLBFJHL MIIBHGLEEJG, NFCEEHLKBBE.NIHDBPDBFFB AANKKGLCJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6C72E40", Offset = "0x6C71840", VA = "0x186C72E40")]
		protected void KCOBONKKCPJ(DIBDFLBFJHL MIIBHGLEEJG, NFCEEHLKBBE.NIHDBPDBFFB AANKKGLCJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC80", Offset = "0x9D9680", VA = "0x1809DAC80", Slot = "16")]
		protected virtual DIBDFLBFJHL JFCMJFMDAJB(DIBDFLBFJHL MIIBHGLEEJG, HelmetHairStyle JBIGFKIPKCB, bool KIIFIEGLODO, AvatarItemBodyType IILEOGELHOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6C71D30", Offset = "0x6C70730", VA = "0x186C71D30")]
		protected DIBDFLBFJHL KAEINPMCDPK(IList<MJOAJOOPMFL> GDMJCHJGHDI, AvatarItemBodyType BOCNMMIAHDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E9B0", Offset = "0x6C6D3B0", VA = "0x186C6E9B0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6C6EC40", Offset = "0x6C6D640", VA = "0x186C6EC40")]
		protected void DGKJKFOEEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6C730E0", Offset = "0x6C71AE0", VA = "0x186C730E0")]
		protected void LJABCCCKBEF(Transform GFILMCPOALJ, IEnumerable<SkinnedMeshRenderer> HHAKPPFMHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D1B0", Offset = "0x6C6BBB0", VA = "0x186C6D1B0")]
		protected NFCEEHLKBBE.NIHDBPDBFFB AIKGDBIODBP(NFCEEHLKBBE.NIHDBPDBFFB PGJNOKBAKEL, MMMGGPPGMJP MGKDFEGEJPA)
		{
			return default(NFCEEHLKBBE.NIHDBPDBFFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FE90", Offset = "0x6C6E890", VA = "0x186C6FE90")]
		protected void GCLIAIIEDFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xD07480", Offset = "0xD05E80", VA = "0x180D07480")]
		protected void HOJKAJFFIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CE60", Offset = "0x6C6B860", VA = "0x186C6CE60")]
		protected void AIFDIPNPDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ECF0", Offset = "0x6C6D6F0", VA = "0x186C6ECF0")]
		[AsyncStateMachine(typeof(IDMCCDDHJHI))]
		protected Task DKMIIPBDDNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6C704A0", Offset = "0x6C6EEA0", VA = "0x186C704A0")]
		protected static OKJIJOGELFA GPDIFLKIEOI(BGGDPIIFLHP FKOKJKKHBHA, int GLFCBFPMCJP)
		{
			return default(OKJIJOGELFA);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6C70990", Offset = "0x6C6F390", VA = "0x186C70990")]
		protected static GIMINOMJJAJ HHEFPIEKNGA(BGGDPIIFLHP FKOKJKKHBHA, int GLFCBFPMCJP)
		{
			return default(GIMINOMJJAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6C72FD0", Offset = "0x6C719D0", VA = "0x186C72FD0")]
		protected Transform LFOIADNDDED(MMMGGPPGMJP FHIDJIFAFFI, OutfitType JMCPJFDLMPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D440", Offset = "0x6C6BE40", VA = "0x186C6D440")]
		protected void APBHDFCLEPA(int JJDMCGMMDHI, Material FLBCMGELMBF, BGGDPIIFLHP FKOKJKKHBHA, [Out] Texture2D GIAFKBOMMAH, [Out] Vector4 BEAIBKEMPBI, [Out] Texture2D BJFMJPAAHKA, [Out] Texture2D CLCJAKNNALM, [Out] Texture2D HOOECKMHJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6C72CF0", Offset = "0x6C716F0", VA = "0x186C72CF0")]
		protected void KBJCEOBLIEH(int JJDMCGMMDHI, Material FLBCMGELMBF, BGGDPIIFLHP FKOKJKKHBHA, [Out] Color MMJLBGNBGBI, [Out] Color LMEHIPBODIP, [Out] Color CFLNDOLFFHJ, [Out] Color PHLCDLDCJJB, [Out] Color JOEHGPNEGMH, [Out] Color NLFKGBEMHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6C74520", Offset = "0x6C72F20", VA = "0x186C74520")]
		protected void OMHPEEFHAPL(Vector3 CNDDIEKMION, Quaternion EAGIADDGNPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6C76A30", Offset = "0x6C75430", VA = "0x186C76A30")]
		public void SetHatAnchorParameters(IJDPLHMEMPG EMNBPJKHOLK, AnchorParamsRestrictions DHHOBPLFOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E4D0", Offset = "0x6C6CED0", VA = "0x186C6E4D0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere DGCLDAMKLBM, Transform BJHMNHMNHIE, IJDPLHMEMPG EMNBPJKHOLK, AnchorParamsRestrictions KELLLPAOMNB, [Out] Vector3 MBNCLINCGNN, [Out] Quaternion OMHOPFBFJAO, [Out] IJDPLHMEMPG GEAHBGAKHCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6C75330", Offset = "0x6C73D30", VA = "0x186C75330")]
		public void ResetHatAnchor(Vector2 HGNLIEFFAMO, Vector3 EFFDJLJEFNF, Vector3 OAKFOCGNLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xBF0780", Offset = "0xBEF180", VA = "0x180BF0780")]
		public ECGCIOHOBJL GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D8E0", Offset = "0x6C6C2E0", VA = "0x186C6D8E0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6C6DA20", Offset = "0x6C6C420", VA = "0x186C6DA20")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D850", Offset = "0x6C6C250", VA = "0x186C6D850")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6C77AB0", Offset = "0x6C764B0", VA = "0x186C77AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E2E0", Offset = "0x6C6CCE0", VA = "0x186C6E2E0")]
		protected void BKKCFOCDMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6C77940", Offset = "0x6C76340", VA = "0x186C77940")]
		public void SetWaitForUgcTextureLoads(bool FGEFPLNACGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6C77850", Offset = "0x6C76250", VA = "0x186C77850")]
		public void SetUgcTextureParameters(FOMNMHHOGJM DIEJPPEOGBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6C782D0", Offset = "0x6C76CD0", VA = "0x186C782D0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F490", Offset = "0x6C6DE90", VA = "0x186C6F490")]
		[CompilerGenerated]
		private void ENJOPEHAIDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6C73D20", Offset = "0x6C72720", VA = "0x186C73D20")]
		[CompilerGenerated]
		private void MKMCFPFHJJO(GIGDJMIIFGH FHMLENHKIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6C74330", Offset = "0x6C72D30", VA = "0x186C74330")]
		[CompilerGenerated]
		private void NNGAAKGPIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6C710E0", Offset = "0x6C6FAE0", VA = "0x186C710E0")]
		[CompilerGenerated]
		private void IKPBPAMDHBK(GIGDJMIIFGH FHMLENHKIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D2D0", Offset = "0x6C6BCD0", VA = "0x186C6D2D0")]
		[CompilerGenerated]
		private void ALKEFHDHOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6C71C50", Offset = "0x6C70650", VA = "0x186C71C50")]
		[CompilerGenerated]
		private void JOIPCNIHAJF(GIGDJMIIFGH FHMLENHKIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6C73050", Offset = "0x6C71A50", VA = "0x186C73050")]
		[CompilerGenerated]
		private void LHCKOJLMMPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D3F0", Offset = "0x6C6BDF0", VA = "0x186C6D3F0")]
		[CompilerGenerated]
		private void AOGIKLBOINF(GIGDJMIIFGH FHMLENHKIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D360", Offset = "0x6C6BD60", VA = "0x186C6D360")]
		[CompilerGenerated]
		private void AMFDAOGNCOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6C70B60", Offset = "0x6C6F560", VA = "0x186C70B60")]
		[CompilerGenerated]
		private void HOJHMOLECFO(GIGDJMIIFGH FHMLENHKIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6C6EDC0", Offset = "0x6C6D7C0", VA = "0x186C6EDC0")]
		[CompilerGenerated]
		private void EALOGDFOHMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F520", Offset = "0x6C6DF20", VA = "0x186C6F520")]
		[CompilerGenerated]
		private void FELIMICOKFD(GIGDJMIIFGH FHMLENHKIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6C70BB0", Offset = "0x6C6F5B0", VA = "0x186C70BB0")]
		[CompilerGenerated]
		internal static bool IDBPOIFPJEL(Transform OEPNMNKDAPK, IEnumerable<SkinnedMeshRenderer> LKPPOHCBDPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6C71CF0", Offset = "0x6C706F0", VA = "0x186C71CF0")]
		[CompilerGenerated]
		private void JPIMHMNKDIH(GIGDJMIIFGH FHMLENHKIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6C73010", Offset = "0x6C71A10", VA = "0x186C73010")]
		[CompilerGenerated]
		private void LGPIGLFEIBB(GIGDJMIIFGH FHMLENHKIEK)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private struct IDCGIBLFKKG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			public BPKALIODDHJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F210", Offset = "0x6C7DC10", VA = "0x186C7F210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F4A0", Offset = "0x6C7DEA0", VA = "0x186C7F4A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct HOPDLOIIKEO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public CNAPJFDNBAH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x6C7EFE0", Offset = "0x6C7D9E0", VA = "0x186C7EFE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F1B0", Offset = "0x6C7DBB0", VA = "0x186C7F1B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct MJEHCBCLPCH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public CNAPJFDNBAH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x6C80E70", Offset = "0x6C7F870", VA = "0x186C80E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x6C81010", Offset = "0x6C7FA10", VA = "0x186C81010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct GDNIBLMBLNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public BPKALIODDHJ avatarData;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct JDAFBDINLOD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public BPKALIODDHJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x6C7FAD0", Offset = "0x6C7E4D0", VA = "0x186C7FAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x6C801B0", Offset = "0x6C7EBB0", VA = "0x186C801B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct GGOOMGFHJII : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CNAPJFDNBAH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private TaskAwaiter<OADEAKEAHBP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C150", Offset = "0x6C7AB50", VA = "0x186C7C150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C550", Offset = "0x6C7AF50", VA = "0x186C7C550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct BMOMIFNHAFN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public CNAPJFDNBAH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x6C7A440", Offset = "0x6C78E40", VA = "0x186C7A440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x6C7A920", Offset = "0x6C79320", VA = "0x186C7A920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		protected const float KOPCMEKIGJH = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		protected const int OBMIGDAIKHK = 5;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		protected static readonly Dictionary<BJFNKBANEEA.MPKJOBKELDF, int> NCHAFPOAANC;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> CNMGEPEJALH;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		protected static readonly int FJGGIBNAGLH;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		protected static readonly int ACDKFBKMDEN;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		protected static readonly int DADPPAGHFEC;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		protected static readonly int LGIIBBCNKCD;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		protected static readonly int NDBHFPBIMIM;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		protected static readonly int BPCECBOLHPJ;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		protected static readonly int AOMMNPHDDIJ;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		protected static readonly int DPKJFCHHGKD;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		protected static Vector2 IGPOJNPNMPC;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		protected static Vector2 DPCGEPCPKNG;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		protected static Vector2 JEJCJGMDPOD;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		protected static Vector2 ENJNFOPEMFB;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		protected static Vector2 BIGBBPJOHNE;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		protected static Vector2 LBDIMCDHDEB;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		protected static Vector2 ANIJFMCIENO;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		protected static Vector2 MPGJLNANBEI;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		protected static Vector2 AJLBNAGODAK;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		protected static Vector2 FFIHIHDBDLN;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		protected static Vector2 NHEEPAHCGGC;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		protected static Vector2 LEMHOEGHCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private CNAPJFDNBAH BKDKOMGCNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private FaceStyleSet GKJPBMHIKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		protected const int MODDNAGKELA = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		protected int EDJCFFNEMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		protected int IDECHFFNHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		protected int EHDCCLLMFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		protected int MHEHCFMNOBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		protected Vector2 JCHKIKHKGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		protected float HGDCHFHJNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		protected Vector2 EKOFDDPEMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		protected float ANNCLOKBLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		protected Vector2 OMBFFGOJIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		protected float JNKBNMCDAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		protected Vector2 OHBCKKGCAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		protected float NJJPHIIHNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		protected List<SelectableFaceOption> HBCAJDMJFEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		protected List<SelectableFaceOption> DAIDOPFILEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected List<SelectableFaceOption> PJKDBOLGEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected List<SelectableFaceOption> IFNALPCLPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected Coroutine KFJPMPPKPPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected int? FEAKDELFKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected int IOFCCOGJOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected int AAKEPNLDPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected int MAIMBNHAKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected int EJFOAIOIDFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected int DPHDHEHLOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected int LPAJGBDKJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected Sprite ACMHMMIPHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected Sprite FPOCBKPIGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected Sprite EOFABJDOLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected Sprite MMEBLNHEOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected bool DAPFMKANHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected string JNJDPJOGEPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected string PBJJDCPOELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected string BFAHNGCNKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected string NMOKMFCAPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected AvatarConfiguration HGDCCILLGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected OADEAKEAHBP PKGICFGBJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected MaterialPropertyBlock OJGHGLCMOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected Dictionary<string, int> EAJADDMHFGC;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public FaceStyleSet PNBMAMAEAAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x6C87C80", Offset = "0x6C86680", VA = "0x186C87C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		protected virtual bool OLAGHBGLPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected virtual bool NCPFCHAOCPG
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		protected int PBMHDOPIFKL
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x6C849A0", Offset = "0x6C833A0", VA = "0x186C849A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Renderer PPLBKGGNNDG
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public bool AOKKEKMLJMA
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x1E45870", Offset = "0x1E44270", VA = "0x181E45870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x1E44A10", Offset = "0x1E43410", VA = "0x181E44A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Renderer[] KPAKCGLFBLO
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public bool MKLCLANOCFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x6C87CC0", Offset = "0x6C866C0", VA = "0x186C87CC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x6C87E80", Offset = "0x6C86880", VA = "0x186C87E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		protected int KJLMGMFCLCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x6C853C0", Offset = "0x6C83DC0", VA = "0x186C853C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		protected int LOIKJECHFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x6C84850", Offset = "0x6C83250", VA = "0x186C84850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public float CMPEOADOAAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x6C87CA0", Offset = "0x6C866A0", VA = "0x186C87CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x6C87E60", Offset = "0x6C86860", VA = "0x186C87E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public AKDDLLHAOHM IHOFENBCDPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x97E9C0", Offset = "0x97D3C0", VA = "0x18097E9C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xA69510", Offset = "0xA67F10", VA = "0x180A69510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public OADEAKEAHBP OOFAIPMHHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x97EA00", Offset = "0x97D400", VA = "0x18097EA00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x6C87DE0", Offset = "0x6C867E0", VA = "0x186C87DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public NoseFaceOption AOOGAKOJHEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x97E9F0", Offset = "0x97D3F0", VA = "0x18097E9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0xECBB80", Offset = "0xECA580", VA = "0x180ECBB80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		protected MaterialPropertyBlock KABKHBCIFKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x6C830F0", Offset = "0x6C81AF0", VA = "0x186C830F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action BADJBADKPGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x6C87BD0", Offset = "0x6C865D0", VA = "0x186C87BD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x6C87D30", Offset = "0x6C86730", VA = "0x186C87D30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6C848B0", Offset = "0x6C832B0", VA = "0x186C848B0")]
		public void LocalPlayEmote(BJFNKBANEEA.MPKJOBKELDF EMFHHGHMEPM, float KAOJMHNBMCH = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6C83C80", Offset = "0x6C82680", VA = "0x186C83C80")]
		public bool IsEmotePlaying(BJFNKBANEEA.MPKJOBKELDF EMFHHGHMEPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6C85D60", Offset = "0x6C84760", VA = "0x186C85D60")]
		public void SetIdleHappy(bool ELIAPAMAACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6C83740", Offset = "0x6C82140", VA = "0x186C83740")]
		protected void HIPJJMHHDCN(bool DJIPNBNHAEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6C83170", Offset = "0x6C81B70", VA = "0x186C83170")]
		protected void GGKPLHLFHIM(bool OOAKLGIKMOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x6C83080", Offset = "0x6C81A80", VA = "0x186C83080")]
		protected void FEAPONLAIPA(MMMGGPPGMJP FHIDJIFAFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6C829E0", Offset = "0x6C813E0", VA = "0x186C829E0")]
		protected void BMJIGPNEIGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6C85590", Offset = "0x6C83F90", VA = "0x186C85590")]
		public void PlayExpression(int EFKJIPCEELB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6C84AD0", Offset = "0x6C834D0", VA = "0x186C84AD0")]
		protected void MLDKHBFACFB(bool KJJJMONCBIO, bool EJNJNMGHLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6C83700", Offset = "0x6C82100", VA = "0x186C83700")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType DDEMMNBPHFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6C837C0", Offset = "0x6C821C0", VA = "0x186C837C0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration HGDCCILLGDP, CNAPJFDNBAH IFNFJLLNCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6C85B40", Offset = "0x6C84540", VA = "0x186C85B40")]
		[AsyncStateMachine(typeof(IDCGIBLFKKG))]
		public Task SetFaceSettings(BPKALIODDHJ EMODBHKBJEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6C85C30", Offset = "0x6C84630", VA = "0x186C85C30")]
		[AsyncStateMachine(typeof(HOPDLOIIKEO))]
		public Task SetFaceSettings(int DOAEDHCOBAL, int NIALNBIPHJB, int HNOIDAPCLKB, int MPOKAJBOJJP, CNAPJFDNBAH IFNFJLLNCCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6C85DE0", Offset = "0x6C847E0", VA = "0x186C85DE0")]
		[AsyncStateMachine(typeof(MJEHCBCLPCH))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType DDEMMNBPHFK, int ACBNHFNILGB, CNAPJFDNBAH IFNFJLLNCCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6C82870", Offset = "0x6C81270", VA = "0x186C82870")]
		protected void BFBIEEHDIOD(FaceFeatureType DDEMMNBPHFK, FNFEKAHOFPA BNFHAGLLHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6C84CB0", Offset = "0x6C836B0", VA = "0x186C84CB0")]
		protected void NNILIFFBMPM(FaceFeatureType DDEMMNBPHFK, int ACBNHFNILGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6C83530", Offset = "0x6C81F30", VA = "0x186C83530")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6C82B40", Offset = "0x6C81540", VA = "0x186C82B40")]
		[AsyncStateMachine(typeof(JDAFBDINLOD))]
		protected Task CPAKBPJCKJF(BPKALIODDHJ EMODBHKBJEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6C825A0", Offset = "0x6C80FA0", VA = "0x186C825A0")]
		protected static void AMBCICFOGFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6C845F0", Offset = "0x6C82FF0", VA = "0x186C845F0")]
		private void LIMOGOOHCDF(bool EEIMGFNDECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6C82C30", Offset = "0x6C81630", VA = "0x186C82C30")]
		protected void EAIKIMCDMBO(FaceFeatureType DDEMMNBPHFK, Vector2 DFLNFCIFCPK, CNAPJFDNBAH IFNFJLLNCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6C855B0", Offset = "0x6C83FB0", VA = "0x186C855B0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType DDEMMNBPHFK, Vector2 NFFEBPFFOII, CNAPJFDNBAH IFNFJLLNCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6C833B0", Offset = "0x6C81DB0", VA = "0x186C833B0")]
		protected void GOCDGAHNLBD(FaceFeatureType DDEMMNBPHFK, float EGIPEKJLBEM, CNAPJFDNBAH IFNFJLLNCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6C85920", Offset = "0x6C84320", VA = "0x186C85920")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType DDEMMNBPHFK, float JOIEBBJHDBN, CNAPJFDNBAH IFNFJLLNCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6C82FA0", Offset = "0x6C819A0", VA = "0x186C82FA0")]
		[AsyncStateMachine(typeof(GGOOMGFHJII))]
		protected Task FAOFOFAGJNG(CNAPJFDNBAH IFNFJLLNCCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6C83A70", Offset = "0x6C82470", VA = "0x186C83A70")]
		public void InitializeFaceFeatureStyleSet(CNAPJFDNBAH IFNFJLLNCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6C832D0", Offset = "0x6C81CD0", VA = "0x186C832D0")]
		protected bool GICCKNGADFG(string HKEHGINCEPD, [Out] int GCBONJOGHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6C82730", Offset = "0x6C81130", VA = "0x186C82730")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6C85420", Offset = "0x6C83E20", VA = "0x186C85420")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6C86DC0", Offset = "0x6C857C0", VA = "0x186C86DC0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6C82A50", Offset = "0x6C81450", VA = "0x186C82A50")]
		[AsyncStateMachine(typeof(BMOMIFNHAFN))]
		public Task BuildFaceStyleAsyncIfChanged(CNAPJFDNBAH IFNFJLLNCCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6C866D0", Offset = "0x6C850D0", VA = "0x186C866D0")]
		public void UpdateFaceDisplays(bool DANGGGAGOAA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6C83D90", Offset = "0x6C82790", VA = "0x186C83D90")]
		protected bool JKJPICPOBBD(bool DANGGGAGOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6C863F0", Offset = "0x6C84DF0", VA = "0x186C863F0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6C85EF0", Offset = "0x6C848F0", VA = "0x186C85EF0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6C86900", Offset = "0x6C85300", VA = "0x186C86900")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6C86AF0", Offset = "0x6C854F0", VA = "0x186C86AF0")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6C854A0", Offset = "0x6C83EA0", VA = "0x186C854A0")]
		protected void PBBEOLOFDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6C879D0", Offset = "0x6C863D0", VA = "0x186C879D0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6C84B80", Offset = "0x6C83580", VA = "0x186C84B80")]
		[CompilerGenerated]
		internal static MGAEPMBOLCO NKPBDEIPFLG(FaceFeatureType DDEMMNBPHFK, GDNIBLMBLNB P_1)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct LJLCALPJFCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public string OENPDLODONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public int PGOLDFNFDHI;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public CNAPJFDNBAH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public EHJGPOKJPHL useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public IJDPLHMEMPG hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public ECGCIOHOBJL HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public NFCEEHLKBBE.NIHDBPDBFFB baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private LJNIBOLJLFA MILAFFHEGEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public readonly LJLCALPJFCJ[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public readonly (string, NBILNDMKKPI)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		protected bool BMNAODEOODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		protected Guid OBFEBCMKFKI;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		protected static Guid LOAAMCCAMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private GIGKENLKLJE NMCLPBDKAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private AKDDLLHAOHM NAHDEFKHCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private FNNNPLJFKOG ICCDGNKOAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private FNNNPLJFKOG ELFIDCAKNMG;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public static Func<ADHBGBCBLIA> PHMGOJKFMFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x6C89F20", Offset = "0x6C88920", VA = "0x186C89F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x6C8A290", Offset = "0x6C88C90", VA = "0x186C8A290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool BEIGAOPDIKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x6C8A100", Offset = "0x6C88B00", VA = "0x186C8A100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public bool KIGNLKAMEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x6C89F70", Offset = "0x6C88970", VA = "0x186C89F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public PlayerAvatarDisplayBase JAHJMAGBOHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x9173E0", Offset = "0x915DE0", VA = "0x1809173E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected static Guid JPGLJFHDCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x6C88B20", Offset = "0x6C87520", VA = "0x186C88B20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6C88A50", Offset = "0x6C87450", VA = "0x186C88A50")]
		private void KJDKGMPJHKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xD83FE0", Offset = "0xD829E0", VA = "0x180D83FE0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6C88490", Offset = "0x6C86E90", VA = "0x186C88490")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6C88CB0", Offset = "0x6C876B0", VA = "0x186C88CB0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6C88C80", Offset = "0x6C87680", VA = "0x186C88C80")]
		public void ShowPose(string LBJDHLLIDED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x6C88C10", Offset = "0x6C87610", VA = "0x186C88C10")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x6C88FF0", Offset = "0x6C879F0", VA = "0x186C88FF0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x6C88EF0", Offset = "0x6C878F0", VA = "0x186C88EF0")]
		public void UpdateFaceAndBodyShapes(bool DIIOKCIFCBN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x6C890A0", Offset = "0x6C87AA0", VA = "0x186C890A0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x6C87FD0", Offset = "0x6C869D0", VA = "0x186C87FD0", Slot = "4")]
		protected virtual void DNJAEEMPKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x6C882E0", Offset = "0x6C86CE0", VA = "0x186C882E0", Slot = "5")]
		protected virtual void IDMDHBDBINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6C89120", Offset = "0x6C87B20", VA = "0x186C89120")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct MJOAJOOPMFL
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class BGMFAONHABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public BGMFAONHABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6C7A3C0", Offset = "0x6C78DC0", VA = "0x186C7A3C0")]
		internal bool JDFKFJJFPMA(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private FHPBLFIJPKH JLLFPLDKDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private MMMGGPPGMJP DJBJMFGCDDH;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public FHPBLFIJPKH IANDNLAMJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public MMMGGPPGMJP AOEMNNKEDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x228D680", Offset = "0x228C080", VA = "0x18228D680")]
		get
		{
			return default(MMMGGPPGMJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public string HNDKNHLBFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6C815D0", Offset = "0x6C7FFD0", VA = "0x186C815D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool CNIHCJAGHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6C812D0", Offset = "0x6C7FCD0", VA = "0x186C812D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool PGNMADPFAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6C816C0", Offset = "0x6C800C0", VA = "0x186C816C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x93D320", Offset = "0x93BD20", VA = "0x18093D320")]
	public MJOAJOOPMFL(FHPBLFIJPKH PIICJMHEACM, MMMGGPPGMJP FHIDJIFAFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6C81510", Offset = "0x6C7FF10", VA = "0x186C81510")]
	public bool IFMKMOLMEOE(OutfitType KOOIKDMDFNO, MMMGGPPGMJP DBLAHAPIDDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6C81070", Offset = "0x6C7FA70", VA = "0x186C81070")]
	public bool BLAJIPPAOLL(OutfitType KOOIKDMDFNO, MMMGGPPGMJP DBLAHAPIDDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6C81320", Offset = "0x6C7FD20", VA = "0x186C81320")]
	public bool CNOFEFGNCCC(MJOAJOOPMFL JIDELJAEHPC)
	{
		return default(bool);
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
