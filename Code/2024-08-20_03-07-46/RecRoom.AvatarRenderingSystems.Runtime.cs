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
using RecRoom.Avatars.Data.Shared;
using RecRoom.Core.Studio;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
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
	public class LogRegistrationIndex : AGBKNAFJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6812A10", Offset = "0x6811A10", VA = "0x186812A10", Slot = "4")]
		public override void GGLLICMBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8517B0", Offset = "0x8507B0", VA = "0x1808517B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6816710", Offset = "0x6815710", VA = "0x186816710", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6816640", Offset = "0x6815640", VA = "0x186816640", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68166D0", Offset = "0x68156D0", VA = "0x1868166D0")]
		public RecNetCDNAssetReference(RecNetCDNKey GMFCIHEFPPO)
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
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x855820", Offset = "0x854820", VA = "0x180855820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6816750", Offset = "0x6815750", VA = "0x186816750")]
		public static RecNetCDNKey JECLJLFFDMK(string KHFLJFIEKAL, string PFBGFLHMNJH = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6001640", Offset = "0x6000640", VA = "0x186001640")]
		public void IPGMHGIGDNI(string KKOEJOMMIJO, string NPOAPJJLLAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6816850", Offset = "0x6815850", VA = "0x186816850")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CCEMJNNADFH]
public class ACJBPHAJLHC : PNBGIPFLGBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> HAPKIGKJLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> GIJGFANEKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> DAHPIJBNPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> GBMKEINOMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> NMBMDOLONMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> CNLMPCEBFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> BLCGDODFELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator CKNGBCHLIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected PMPMBDGPMBD CCDCOPFLBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte ODMEEIHHFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> CACBDEKMNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> JDDOGNGDCFE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67FF120", Offset = "0x67FE120", VA = "0x1867FF120", Slot = "4")]
	public void CLDNNFBGPCO(Mesh EIOKGMMIDKC, Matrix4x4 LGLHBMCIIPD, byte[] MHIEANANIHF, bool JKEEBNGANDA = false, PMDMGKIOLAB.NJCPOFDIECP EGJBPKHEGNP = (PMDMGKIOLAB.NJCPOFDIECP)0, int ECHKJJDAGKD = -1, bool KALCHEPJNMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x67FF570", Offset = "0x67FE570", VA = "0x1867FF570", Slot = "5")]
	public void KFJIJNJKAAM(Allocator OOMMBGGEBLM, PMPMBDGPMBD KDLIJKKBKCH, byte IJOJNIEKAJP, [Optional] IList<int> PLFJMPKDPDD, [Optional] IList<int> PDLHNEKLCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67FF320", Offset = "0x67FE320", VA = "0x1867FF320")]
	private static void ICMKEEFEHDC(Mesh EIOKGMMIDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67FF5B0", Offset = "0x67FE5B0", VA = "0x1867FF5B0")]
	public ACJBPHAJLHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CCEMJNNADFH]
public struct KFCFNBHLANM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public ELGHIMHNKCE AFDLJIDONOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int JBALGICKFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public OLNDEDHDCBN CLHPBEJJOAE;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6802B50", Offset = "0x6801B50", VA = "0x186802B50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CCEMJNNADFH]
[NativeContainer]
public struct OLNDEDHDCBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct KCJOEMOIJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 CHFAOALDNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 NJOPFIOMLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 KGIJHOHKCND;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct DBHDMCGICHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float IPMNEBBHBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float IMCMLJIOGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float AKBHNAHBDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float HOMNHANJGBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte APFFPFEDBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte AHKLFLJCKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte KFNBAEGIIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte NBPFFJPFOLM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct AMEAKHJIPIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half IPMNEBBHBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half IMCMLJIOGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half AKBHNAHBDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half HOMNHANJGBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte APFFPFEDBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte AHKLFLJCKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte KFNBAEGIIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte NBPFFJPFOLM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct JKLAEONJJBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 NHCEIDKGILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 GDJEBONJHDD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct NJPJAKBKJDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 NHCEIDKGILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 GDJEBONJHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 JOJPHOHGHMO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct EMHLAJGABCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 NHCEIDKGILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 GDJEBONJHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 JOJPHOHGHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 HBJGFILLPEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BBOAGDDFLCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 NHCEIDKGILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 GDJEBONJHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 JOJPHOHGHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 HBJGFILLPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 OCELAGJBBIG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct BPLAOGCLFMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float IPMNEBBHBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float IMCMLJIOGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float AKBHNAHBDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float HOMNHANJGBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int APFFPFEDBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int AHKLFLJCKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int KFNBAEGIIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int NBPFFJPFOLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct MMLLKDIKFOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color NHCEIDKGILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 GDJEBONJHDD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct GADMFOAJDDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color NHCEIDKGILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 GDJEBONJHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 JOJPHOHGHMO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct AJDKBHKCMBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color NHCEIDKGILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 GDJEBONJHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 JOJPHOHGHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 HBJGFILLPEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct KKNKNBNOLKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color NHCEIDKGILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 GDJEBONJHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 JOJPHOHGHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 HBJGFILLPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 OCELAGJBBIG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool HJODEHKOEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<KCJOEMOIJOF> PNKANOGGIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<JKLAEONJJBP> EJLPLBJNCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<NJPJAKBKJDN> EIKGJKPNFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<EMHLAJGABCF> MMLDJLJINLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BBOAGDDFLCK> JCHOFOENAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<AMEAKHJIPIM> COFFDBJBONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<DBHDMCGICHB> ADFMNFCLLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<MMLLKDIKFOB> NIBABPBPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<GADMFOAJDDH> HKNODKIGBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<AJDKBHKCMBO> OOMGPHJDLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<KKNKNBNOLKL> CDACHHEACMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<BPLAOGCLFMB> OJGCMMCCCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> FFNKOCJCKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> HOJKMIMFCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> NDFPIAEMIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> LLJAPLLAIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> LPANPNEDCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> DLGEFPMBHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> BBAKHFBEELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> LPMGOLCIGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> OEFIADEKGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool LAMCNNIHIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool PECPAMJMMFP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HFELIGNPMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6814A40", Offset = "0x6813A40", VA = "0x186814A40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6814A30", Offset = "0x6813A30", VA = "0x186814A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MOHJJAPCOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6813830", Offset = "0x6812830", VA = "0x186813830")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6814A60", Offset = "0x6813A60", VA = "0x186814A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GBEELDOLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6814A50", Offset = "0x6813A50", VA = "0x186814A50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6814760", Offset = "0x6813760", VA = "0x186814760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DGDPEEPGHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6815330", Offset = "0x6814330", VA = "0x186815330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6815B50", Offset = "0x6814B50", VA = "0x186815B50")]
	public OLNDEDHDCBN(int JMKKKIMPLAJ, int KFJPCFNOIMA, int OMHAFODBGOI, int MDEEIGFFNGM, Allocator OOMMBGGEBLM, int NLKEKBHENIH, BPNHPIODJKB NHHJFKMPIKI, bool LAMCNNIHIBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6814A70", Offset = "0x6813A70", VA = "0x186814A70")]
	public void GOCGGFJHMKG(int HCALFJOJKJO, Vector3 CKOKPBDJPNC, Vector3 BBIKELPGJLE, Vector4 IGKMAMABJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6814B00", Offset = "0x6813B00", VA = "0x186814B00")]
	public void HHJEAOLFJMI(int HCALFJOJKJO, BoneWeight OFNHFLHIAHH, NativeSlice<byte> MHIEANANIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6815750", Offset = "0x6814750", VA = "0x186815750")]
	public Color LALECKBEPCI(int HCALFJOJKJO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6814F30", Offset = "0x6813F30", VA = "0x186814F30")]
	public void HKBELCOBCKB(int HCALFJOJKJO, Color MHIEIJBIEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68153A0", Offset = "0x68143A0", VA = "0x1868153A0")]
	public void IMOABNOJMHL(byte MGHLIFLJIJG, int HCALFJOJKJO, Vector2 JJKFHPJELDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6813820", Offset = "0x6812820", VA = "0x186813820")]
	public void AFNLKDLEKPB(int HCALFJOJKJO, int EJOHKCPDBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68149D0", Offset = "0x68139D0", VA = "0x1868149D0")]
	public bool EHNJJOJKHNA(int MGHLIFLJIJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6815A80", Offset = "0x6814A80", VA = "0x186815A80")]
	public void NENOPBANGPL(int OOKKOPIGEOA, int BEMLKOBANDO, int IGIHBEMLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6814770", Offset = "0x6813770", VA = "0x186814770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6813840", Offset = "0x6812840", VA = "0x186813840")]
	public Mesh DGAFICBDDJK([Optional] string MAALKLDDFME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[CCEMJNNADFH]
[DefaultMember("Item")]
public struct ELGHIMHNKCE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray ADDOHJFEKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> NMNPCHFBKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> HDIEKKLPCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> LPMGOLCIGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> GKHKKLMKDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> HIMJNMCPCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> CHCJNDECCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> MMGFBJLPEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> HDIDHPMIECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> IOAKOPDLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> NICKILNLHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> KALCHEPJNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> ECHKJJDAGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool LAMCNNIHIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> LFPNOLPFOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool PECPAMJMMFP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NCHJAONJJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6800BC0", Offset = "0x67FFBC0", VA = "0x186800BC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MDCLBHNECCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6800E60", Offset = "0x67FFE60", VA = "0x186800E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LJDIFGMEHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6800D40", Offset = "0x67FFD40", VA = "0x186800D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BDEPHBEJDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6800EA0", Offset = "0x67FFEA0", VA = "0x186800EA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6800E40", Offset = "0x67FFE40", VA = "0x186800E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int HFELIGNPMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6800E30", Offset = "0x67FFE30", VA = "0x186800E30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6800E20", Offset = "0x67FFE20", VA = "0x186800E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AOLDNCHANCH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6800E70", Offset = "0x67FFE70", VA = "0x186800E70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6800EB0", Offset = "0x67FFEB0", VA = "0x186800EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PMPMBDGPMBD LBCMHKOCFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6800E90", Offset = "0x67FFE90", VA = "0x186800E90")]
		get
		{
			return default(PMPMBDGPMBD);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6800E10", Offset = "0x67FFE10", VA = "0x186800E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte LJMMPBCELLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6800E80", Offset = "0x67FFE80", VA = "0x186800E80")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6800E50", Offset = "0x67FFE50", VA = "0x186800E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public PDKCMIHHBME OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6800970", Offset = "0x67FF970", VA = "0x186800970")]
		get
		{
			return default(PDKCMIHHBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6800F90", Offset = "0x67FFF90", VA = "0x186800F90")]
	public ELGHIMHNKCE(IList<Mesh> KAILGEHNCAI, IList<Matrix4x4> ELKFACGMAFA, IList<bool> KALCHEPJNMI, byte IJOJNIEKAJP, IList<byte[]> HEOEPIOAJAB, IList<int> GJFNBAFNKGF, IList<bool> LKEGJOGCBNC, IList<int> ECHKJJDAGKD, IList<int> PLFJMPKDPDD, IList<int> HNCLBPBGJGM, Allocator OOMMBGGEBLM, PMPMBDGPMBD KDLIJKKBKCH, bool LAMCNNIHIBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6800EC0", Offset = "0x67FFEC0", VA = "0x186800EC0")]
	public OLNDEDHDCBN PGIEOMFAOAA(Allocator OOMMBGGEBLM, BPNHPIODJKB NHHJFKMPIKI)
	{
		return default(OLNDEDHDCBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6800BD0", Offset = "0x67FFBD0", VA = "0x186800BD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[CCEMJNNADFH]
public class MHGMOGJPDEJ : ACJBPHAJLHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool GJPCCLOKBOB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker KIBMJCDDCOO;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6812AA0", Offset = "0x6811AA0", VA = "0x186812AA0")]
	public ELGHIMHNKCE CBNMHHLCJAA()
	{
		return default(ELGHIMHNKCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6812D60", Offset = "0x6811D60", VA = "0x186812D60")]
	public MHGMOGJPDEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PDKCMIHHBME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData PJJEBMBCFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> LPMGOLCIGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> KKBEAOJONII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int COBPFOOKIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 NAEBJPKHAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int EIIHLKOHCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> MHIEANANIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool JAFPJNLBLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int IKKOOMHAGME;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LOFDAKFIBBN : CBMBHBAHCAO
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class ENGFNINKFIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly OELEMBFEEON MEFFAGKEGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		protected bool GBKOBCMFPIB;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool HAHBOLPGHKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool IOPGGEMJLCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual PMDMGKIOLAB.NJCPOFDIECP EIIHLKOHCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "6")]
			get
			{
				return default(PMDMGKIOLAB.NJCPOFDIECP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool PBDGPKMMKII
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9F2A60", Offset = "0x9F1A60", VA = "0x1809F2A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool OPDGLCFNMAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x15C4030", Offset = "0x15C3030", VA = "0x1815C4030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool PMOBFGAMLMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6802170", Offset = "0x6801170", VA = "0x186802170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool ADAGCGCLPOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6802180", Offset = "0x6801180", VA = "0x186802180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		protected ENGFNINKFIF(OELEMBFEEON HJDPIOHPOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract OBDNBLKJHLC OGKELEJCJIO(int[] NGIMELLMAAD, List<KEHNINOIGAE> FJJFBJOMBEB, List<KEHNINOIGAE> IMDDHDOAKMI);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract PANDFAKEAOD AGGENKCMHHL(uint HCJLPFCODLH, AvatarSkinnedMeshBoneOrderRemapsData BCHBPCONEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class NLPJIKPKPHN : ENGFNINKFIF
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HMIPGPBIGPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public GJJBOODDAKM<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public NLPJIKPKPHN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public HMIPGPBIGPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6802630", Offset = "0x6801630", VA = "0x186802630")]
			internal void JGGKOBHFFNM(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly AvatarSkinAssetItem.DGKHHLCIJLD OEAFFEEDCNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly AssetReference BAGBMALHMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly PMDMGKIOLAB.NJCPOFDIECP JIAMCMGNKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly DFGLBGMNOFH? DNEPNKJPFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Material[] KEHAIIMCPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private SkinnedMeshRenderer[] OFONALILKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private AvatarSkinAssetItem KMIBPBNECNP;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override PMDMGKIOLAB.NJCPOFDIECP EIIHLKOHCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x854630", Offset = "0x853630", VA = "0x180854630", Slot = "6")]
			get
			{
				return default(PMDMGKIOLAB.NJCPOFDIECP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6813560", Offset = "0x6812560", VA = "0x186813560")]
		public NLPJIKPKPHN(AvatarSkinAssetItem.DGKHHLCIJLD HMKEMOEMJOA, AssetReference NMGBJLOLHDD, Material CMIDCIEPMFE, OELEMBFEEON ODGPAFEGIFN, PMDMGKIOLAB.NJCPOFDIECP JBAJAICGNAH = (PMDMGKIOLAB.NJCPOFDIECP)0, [Optional] DFGLBGMNOFH? CBEOHMEADJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6813670", Offset = "0x6812670", VA = "0x186813670")]
		public NLPJIKPKPHN(AvatarSkinAssetItem.DGKHHLCIJLD HMKEMOEMJOA, AssetReference NMGBJLOLHDD, Material CMIDCIEPMFE, PMDMGKIOLAB.NJCPOFDIECP JBAJAICGNAH = (PMDMGKIOLAB.NJCPOFDIECP)0, [Optional] DFGLBGMNOFH? CBEOHMEADJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6813320", Offset = "0x6812320", VA = "0x186813320", Slot = "7")]
		public override OBDNBLKJHLC OGKELEJCJIO(int[] NGIMELLMAAD, List<KEHNINOIGAE> FJJFBJOMBEB, List<KEHNINOIGAE> IMDDHDOAKMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6813040", Offset = "0x6812040", VA = "0x186813040", Slot = "8")]
		public override PANDFAKEAOD AGGENKCMHHL(uint HCJLPFCODLH, AvatarSkinnedMeshBoneOrderRemapsData BCHBPCONEAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x68134F0", Offset = "0x68124F0", VA = "0x1868134F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class CPNJBPGPLKO : ENGFNINKFIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly HOHPFNNLDGM JBLLHDKCMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private GJJBOODDAKM<JFFEIJJGKJG> OPJKAHOHGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public JFFEIJJGKJG INNGPPODDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private GJJBOODDAKM<Material[]> BGOBNOFCAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Material[] FMJDKHJEKGO;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool HAHBOLPGHKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool IOPGGEMJLCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6800060", Offset = "0x67FF060", VA = "0x186800060", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6800910", Offset = "0x67FF910", VA = "0x186800910")]
		public CPNJBPGPLKO(OELEMBFEEON HJDPIOHPOFO, HOHPFNNLDGM NAGBPMECBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x68000C0", Offset = "0x67FF0C0", VA = "0x1868000C0", Slot = "7")]
		public override OBDNBLKJHLC OGKELEJCJIO(int[] NGIMELLMAAD, List<KEHNINOIGAE> FJJFBJOMBEB, List<KEHNINOIGAE> IMDDHDOAKMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x67FFC60", Offset = "0x67FEC60", VA = "0x1867FFC60", Slot = "8")]
		public override PANDFAKEAOD AGGENKCMHHL(uint HCJLPFCODLH, AvatarSkinnedMeshBoneOrderRemapsData BCHBPCONEAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x67FFD90", Offset = "0x67FED90", VA = "0x1867FFD90")]
		public PANDFAKEAOD EMNBJBDINOI(GameObject KPFKPCLKMDA, uint HCJLPFCODLH, bool EMIGKPPDKFE, bool NJKHHGPNMDG, AvatarSkinnedMeshBoneOrderRemapsData BCHBPCONEAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6800550", Offset = "0x67FF550", VA = "0x186800550")]
		public static bool OJBHFPMAMBK(Renderer[] KDJDOAOHFDA, string GPGNOFHCLGH, [Out] Renderer KMDHNFKPJBL, [Out] Renderer ALGDDGLOIAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x68008C0", Offset = "0x67FF8C0", VA = "0x1868008C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x67FFFA0", Offset = "0x67FEFA0", VA = "0x1867FFFA0")]
		private (GJJBOODDAKM<JFFEIJJGKJG>, GJJBOODDAKM<Material[]>) NHGIPCDPHGN()
		{
			return default((GJJBOODDAKM<JFFEIJJGKJG>, GJJBOODDAKM<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4319D00", Offset = "0x4318D00", VA = "0x184319D00")]
		[CompilerGenerated]
		private void KLPBBDEEHHJ(JFFEIJJGKJG KNFGDDANCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8518E0", Offset = "0x8508E0", VA = "0x1808518E0")]
		[CompilerGenerated]
		private void EIPJHLGCPEM(Material[] KNFGDDANCCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LOEOJIMHHOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public MGJPADKOCDP avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public LOFDAKFIBBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AKGDPKBFKBL buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public LOEOJIMHHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6806760", Offset = "0x6805760", VA = "0x186806760")]
		internal bool EDLDKJCLLGI(HOHPFNNLDGM item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6806740", Offset = "0x6805740", VA = "0x186806740")]
		internal void CFILHDLKBCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x68068D0", Offset = "0x68058D0", VA = "0x1868068D0")]
		internal void PHPJOGLNBDE(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6806840", Offset = "0x6805840", VA = "0x186806840")]
		internal void HDJOGDPLGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x68067B0", Offset = "0x68057B0", VA = "0x1868067B0")]
		internal void GAHKGGDBIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		internal OBDNBLKJHLC BJCHIHIJOHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PJLMPFDMGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public LOEOJIMHHOG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public PJLMPFDMGNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6816580", Offset = "0x6815580", VA = "0x186816580")]
		internal MEKCNLOLNKA CHBKMIMEMBI(int lod)
		{
			return default(MEKCNLOLNKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JOMLIJHJMFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<AKGDPKBFKBL> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JOMLIJHJMFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6802A20", Offset = "0x6801A20", VA = "0x186802A20")]
		internal void ECHIEJBKBGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NCEAJALMKJL : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public LOFDAKFIBBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<ENGFNINKFIF> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<AKGDPKBFKBL> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Func<int, MEKCNLOLNKA> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public ONFJKLEFIOO materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public NCEAJALMKJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6812DF0", Offset = "0x6811DF0", VA = "0x186812DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6812FF0", Offset = "0x6811FF0", VA = "0x186812FF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NMCLFPLBOOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public LOFDAKFIBBN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NMCLFPLBOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6813780", Offset = "0x6812780", VA = "0x186813780")]
		internal OBDNBLKJHLC PGAGPHLDKJJ(ENGFNINKFIF p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HOLGPFGPMGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public CENFBDHFHEH cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public HOLGPFGPMGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC90", Offset = "0x8AAC90", VA = "0x1808ABC90")]
		internal void NNECHKJHKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xB123A0", Offset = "0xB113A0", VA = "0x180B123A0")]
		internal void KMIPAHCFPHP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class DCOOFAOFDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public LOFDAKFIBBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DCOOFAOFDMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class AHPCJONAGAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public OLNDEDHDCBN defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public ELGHIMHNKCE defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public DCOOFAOFDMF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public AHPCJONAGAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x67FF7E0", Offset = "0x67FE7E0", VA = "0x1867FF7E0")]
		internal void GHNBEKKKBJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB123C0", Offset = "0xB113C0", VA = "0x180B123C0")]
		internal void IPCAFEGHJCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class CLEKFNHEHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CCGFJKLMMJI legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public LGAOKHMJICK legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public DCOOFAOFDMF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CLEKFNHEHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x67FFA20", Offset = "0x67FEA20", VA = "0x1867FFA20")]
		internal void BDMNLIDFGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB0F700", Offset = "0xB0E700", VA = "0x180B0F700")]
		internal void IDHMCBCPBNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HKGCMEINEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public KeyValuePair<string, HOHPFNNLDGM> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public CENFBDHFHEH cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public HOHPFNNLDGM avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public LOFDAKFIBBN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public HKGCMEINEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x68021E0", Offset = "0x68011E0", VA = "0x1868021E0")]
		internal OBDNBLKJHLC FPBLGAJKEKK(OFDCHBFCKEB item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x68021A0", Offset = "0x68011A0", VA = "0x1868021A0")]
		internal void ENCGCEFOEHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class NNILIDJNNBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public GJJBOODDAKM<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NNILIDJNNBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x68137D0", Offset = "0x68127D0", VA = "0x1868137D0")]
		internal void BOFLJNLIAOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MNHODADJKHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public OELEMBFEEON overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MNHODADJKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6812D70", Offset = "0x6811D70", VA = "0x186812D70")]
		internal bool PBJKEOFIAID(KeyValuePair<string, HOHPFNNLDGM> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration CHIEKINDOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform MLFGKNLJAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference BAGBMALHMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject FLOOMHOBAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject INMAJNBFBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer LOLHHNDNLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData OHCMNMFDBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] ACKCGLIIHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] FHKOPIDFOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material KJFAJHNMOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material EGLHAINIFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material IJDPPMOGGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader IGKDDAIFIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader ADJOOMCKCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator BEBKBIKEFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] ENNHGODKEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private PMDMGKIOLAB.NJCPOFDIECP HFGOGFBEEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager JDOADCFFHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> EPLAAFGOHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.BJLEDDJBNFK CCDFEGCIBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.IAKGEKDDOMI MIKIELGBCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool NGPMBJFKGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool NHAMJMJEFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color PIPGOFCEHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color LMIENKDGKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color DNPOKOOGPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? GJFMLJLOGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? KLNDLFHOPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? AKAOJILJNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? ABFNAEHJOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D KAMEHHBPFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D IBOCEIADFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private HOHPFNNLDGM NJHDPHCMEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture EAHKMMPFLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color MLAKJGILMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, ONFJKLEFIOO> EMKACNMFAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, ONFJKLEFIOO> BNIIILJNEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<JCDPMBNJPFD>> FMKBIIGDDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<JCDPMBNJPFD>> IJKAKKDOHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<KEHNINOIGAE> DLFEKJAEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<KEHNINOIGAE> BFBPIDPEEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<KEHNINOIGAE> GPHDFJFLAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<KEHNINOIGAE> ECGKIDHICMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<JCDPMBNJPFD, Material> IALPMJEGJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<JCDPMBNJPFD, Material> HGJLLMJDOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] GLDJCNNNIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] PACHEJMKOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] PPMIKBHNEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] MOGGBJNLOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, GJJBOODDAKM<Texture2D>> DMIANHINLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, GJJBOODDAKM<Texture2D>> BKHFFGPJBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData CDIOPNICBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private MACMOFHFNNF OGEDGLEIEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private FitMeshHemisphere BLEHODPCKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private PositionAndRotation FDJOIDABLDN;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Material HIHKMJPKJKL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Material AGJAPBKMHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Dictionary<string, HOHPFNNLDGM> DLAOCOOBBID;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int PDDEOELKOOM;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int HAGHIIBFAHH;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int GCLKGLICLPI;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int MHIHHMAGIIL;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int LKINKJHNKII;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int CPHNEPPJIDE;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int ANNGPOLAOKH;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int FDABEDDFMBI;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int JACHFKPNHLH;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int JEJODOHGIHJ;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int FBMMHEAIBFP;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int JBFLCGGHCPG;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int AJHHPNPGKNF;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int DCIAPFDJJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly PEHINEDJEEO JGPIJLEKHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly PEHINEDJEEO MBNNNPLMOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool OJNBMGGJFEB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static Lazy<GFDNMDGANLI> NGGNGDBMOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Lazy<FHNMEMNNFGC> EOBPCELPOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Lazy<BGBCCAFOJKD> POFIMOIAJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private CJINGDNGAEK EMOFKAFJMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private List<Action> DBPBJNDOGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private MCJLLMFGIPJ CKBIIJLHBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private SkinnedMeshRenderer[] JEENDGDGCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int ELHFPEBNHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool DAGBFELALNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int DNFKNNKFNCA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KNEFIHBANAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1742180", Offset = "0x1741180", VA = "0x181742180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1739A90", Offset = "0x1738A90", VA = "0x181739A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material NAILCBIACEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x680D720", Offset = "0x680C720", VA = "0x18680D720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material LBFCAPIFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x680FF80", Offset = "0x680EF80", VA = "0x18680FF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool JKMKCAPEGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IOPEHOFLEFL ILFDINDAIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2F0", Offset = "0x9AE2F0", VA = "0x1809AF2F0", Slot = "21")]
		get
		{
			return default(IOPEHOFLEFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static GFDNMDGANLI NDHCAOHMMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x680A2E0", Offset = "0x68092E0", VA = "0x18680A2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private FHNMEMNNFGC JIAMPLGPADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68070E0", Offset = "0x68060E0", VA = "0x1868070E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private BGBCCAFOJKD IFAPPJMFDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x680A6B0", Offset = "0x68096B0", VA = "0x18680A6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private CJINGDNGAEK EHKHJOGFKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6810250", Offset = "0x680F250", VA = "0x186810250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PEHINEDJEEO EMFPELMCDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xC71970", Offset = "0xC70970", VA = "0x180C71970", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PEHINEDJEEO HAAOJLILGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x14DF2F0", Offset = "0x14DE2F0", VA = "0x1814DF2F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] HCCBEGFKINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x14E0730", Offset = "0x14DF730", VA = "0x1814E0730", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] MPDBFGGPADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85FBB0", Offset = "0x85EBB0", VA = "0x18085FBB0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KBKLBCFAFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x680E300", Offset = "0x680D300", VA = "0x18680E300", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation PKCCMMKEDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x680DEA0", Offset = "0x680CEA0", VA = "0x18680DEA0", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public PMDMGKIOLAB.NJCPOFDIECP BCDFNAABEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x85FAC0", Offset = "0x85EAC0", VA = "0x18085FAC0", Slot = "18")]
		get
		{
			return default(PMDMGKIOLAB.NJCPOFDIECP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JEEDODNFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x227C150", Offset = "0x227B150", VA = "0x18227C150")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6807090", Offset = "0x6806090", VA = "0x186807090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool PPEIIEEEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x68101D0", Offset = "0x680F1D0", VA = "0x1868101D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool OHIEIHIKGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6809F60", Offset = "0x6808F60", VA = "0x186809F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6812240", Offset = "0x6811240", VA = "0x186812240")]
	public LOFDAKFIBBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x680FCC0", Offset = "0x680ECC0", VA = "0x18680FCC0", Slot = "28")]
	public void LFNNOPDGNGK(IENPFBDIAAD IJGENKBIJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6807130", Offset = "0x6806130", VA = "0x186807130", Slot = "29")]
	public void CGPPMLPHELM(JOGNBOPMGPD LJFNCMNKCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6807090", Offset = "0x6806090", VA = "0x186807090", Slot = "4")]
	public void NFMJCBANIHP(int HCJLPFCODLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68113E0", Offset = "0x68103E0", VA = "0x1868113E0", Slot = "9")]
	public void ONBNGMAODNL(IBAJFNEGKOO JAFJCINAICH, Texture2D JCAGFNGDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6809670", Offset = "0x6808670", VA = "0x186809670", Slot = "10")]
	public void DJEBJAFJIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x680F600", Offset = "0x680E600", VA = "0x18680F600", Slot = "11")]
	public bool LCCBGFFMDJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x680A700", Offset = "0x6809700", VA = "0x18680A700", Slot = "8")]
	public void FKIKHMMJKBL(CAMDCMNKDHF GEEBFHBCPPB, Color? NHCEIDKGILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x680DED0", Offset = "0x680CED0", VA = "0x18680DED0")]
	private void JBHKALPMIFG(Action OGIAJFLACKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x680A1A0", Offset = "0x68091A0", VA = "0x18680A1A0", Slot = "5")]
	public void EKMIHIBJJBN(HOHPFNNLDGM GDPECDMNNLL, Texture IBBPHIODAOC, Color DFGCLMNNLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1739A90", Offset = "0x1738A90", VA = "0x181739A90", Slot = "6")]
	public void APLAPJKENMB(bool KDLLHJLDMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xBE9C50", Offset = "0xBE8C50", VA = "0x180BE9C50", Slot = "7")]
	public void IAADPEOCEBF(MCJLLMFGIPJ OEFIADEKGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x680B790", Offset = "0x680A790", VA = "0x18680B790", Slot = "14")]
	public AKGDPKBFKBL GLEKBPIHHHH(MGJPADKOCDP EPIIMCEBOOM, bool KAMEILPEPNC, int[] EPDIHPCLPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x680E470", Offset = "0x680D470", VA = "0x18680E470", Slot = "15")]
	public void JGHMEEMECOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x680E890", Offset = "0x680D890", VA = "0x18680E890", Slot = "26")]
	public void KBLJPMGKJHE([Optional] MACMOFHFNNF HDDLOHNNELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x680D2F0", Offset = "0x680C2F0", VA = "0x18680D2F0")]
	private bool HBIALBOOGKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68068F0", Offset = "0x68058F0", VA = "0x1868068F0", Slot = "19")]
	public bool ABAGLLNHFBJ(PMDMGKIOLAB.NJCPOFDIECP ABFMDJJGNDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x680E240", Offset = "0x680D240", VA = "0x18680E240")]
	private bool JFPLDAGKBNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6807250", Offset = "0x6806250", VA = "0x186807250")]
	private AKGDPKBFKBL CNIIGLDBPII(bool KAMEILPEPNC, List<ENGFNINKFIF> AFNOKLIHFEF, int[] EPDIHPCLPPF, Func<int, MEKCNLOLNKA> MDNPBJNLJDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6809E50", Offset = "0x6808E50", VA = "0x186809E50")]
	[IteratorStateMachine(typeof(NCEAJALMKJL))]
	private IEnumerator<FAKEPIEMOLB> DOCHCJCONOG(bool KAMEILPEPNC, List<ENGFNINKFIF> AFNOKLIHFEF, int[] EPDIHPCLPPF, Func<int, MEKCNLOLNKA> MDNPBJNLJDA, ONFJKLEFIOO OANCOFFOHLO, Material BDPFKKCPGNH, List<AKGDPKBFKBL> HJFKHKHFPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x680D460", Offset = "0x680C460", VA = "0x18680D460")]
	private AKGDPKBFKBL HKDOEKFPKMJ(List<ENGFNINKFIF> AFNOKLIHFEF, int[] EPDIHPCLPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6807A80", Offset = "0x6806A80", VA = "0x186807A80")]
	private HDBNHMIPDLF DILIGOKEICK(List<ENGFNINKFIF> AFNOKLIHFEF, int HCJLPFCODLH, bool KAMEILPEPNC, MEKCNLOLNKA HGBAHFEDPPC, bool FFFFLMEAKFP, ONFJKLEFIOO OANCOFFOHLO, Material BDPFKKCPGNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6810A20", Offset = "0x680FA20", VA = "0x186810A20", Slot = "22")]
	public void NGNJKCCKKGD(AvatarFaceShape LLPMGMCPNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68110C0", Offset = "0x68100C0", VA = "0x1868110C0", Slot = "23")]
	public void OKJFEAAMLCM(AvatarBodyShape KCONLHIAOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68112E0", Offset = "0x68102E0", VA = "0x1868112E0", Slot = "25")]
	public void OMKNCOKPNON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6807240", Offset = "0x6806240", VA = "0x186807240", Slot = "24")]
	public void CLOFIIIJCEJ(bool JIOCGEPPKMN, bool KNIBBKEOCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x680B650", Offset = "0x680A650", VA = "0x18680B650")]
	private void GHCMIKJNPFP(SkinnedMeshRenderer JFBJCIANJFH, int HCJLPFCODLH, Mesh EIOKGMMIDKC, List<Material> GKNFKFDCLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6806A50", Offset = "0x6805A50", VA = "0x186806A50")]
	private static Material ALDHDIEPMKM(Dictionary<JCDPMBNJPFD, Material> INKOLAACAKJ, Material MEJHEPJCELE, BIHABJEJLGF GNDMKPPOMLH, FJPDPDHAANH IHACKOBNBCK, OELEMBFEEON ODGPAFEGIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x680A590", Offset = "0x6809590", VA = "0x18680A590")]
	private static BIHABJEJLGF FFIMJKICLKB(ENGFNINKFIF KAGBAKINHMN, int AIEDOCOCKLD)
	{
		return default(BIHABJEJLGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x680AB00", Offset = "0x6809B00", VA = "0x18680AB00")]
	private void FMBGBHKOKJI(int BOBDGMLNJHN, Material JNFDDANGPCP, ENGFNINKFIF KAGBAKINHMN, [Out] Texture2D MODOLFKKEIN, [Out] Vector4 IIKGACMKFAN, [Out] Texture2D LBMNHNMBICH, [Out] Texture2D DBEPIABDJDL, [Out] Texture2D GDEAKEGDDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6811970", Offset = "0x6810970", VA = "0x186811970")]
	private void PMEANKCHAGN(int BOBDGMLNJHN, Material JNFDDANGPCP, ENGFNINKFIF KAGBAKINHMN, [Out] Color OPGILNOKCAP, [Out] Color OGFIPIMDOII, [Out] Color PBOGEPNCMLI, [Out] Color EDJCJPJEANN, [Out] Color LBONAILPLMI, [Out] Color BOEDIJHCGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x680DA20", Offset = "0x680CA20", VA = "0x18680DA20")]
	private bool IDHAEIHEGAJ(Material JNFDDANGPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6810480", Offset = "0x680F480", VA = "0x186810480")]
	private static Material NCMBMMMFECN(int BOBDGMLNJHN, CPNJBPGPLKO KAGBAKINHMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6809770", Offset = "0x6808770", VA = "0x186809770")]
	private static FJPDPDHAANH DLNLHDCABMP(ENGFNINKFIF KAGBAKINHMN, int AIEDOCOCKLD)
	{
		return default(FJPDPDHAANH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x680DF50", Offset = "0x680CF50", VA = "0x18680DF50")]
	private static void JBJICHMJNMA(Dictionary<string, List<JCDPMBNJPFD>> DPGGOEHOLKL, ENGFNINKFIF DKABAHJAPNG, Material MEJHEPJCELE, BIHABJEJLGF GEEBFHBCPPB, FJPDPDHAANH JAFJCINAICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x680A360", Offset = "0x6809360", VA = "0x18680A360")]
	private static SkinnedMeshRenderer FCAMDLCJPEN(Transform BNIKBDCMLIB, Transform MOKNHBOPFOJ, SkinnedMeshRenderer[] KDJDOAOHFDA, int HCJLPFCODLH, MEKCNLOLNKA HGBAHFEDPPC, bool KAMEILPEPNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6807820", Offset = "0x6806820", VA = "0x186807820")]
	private void CPLJMHIOJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6807080", Offset = "0x6806080", VA = "0x186807080")]
	private void BJJOAMLNDMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x680CDD0", Offset = "0x680BDD0", VA = "0x18680CDD0")]
	private static void GPEPCLJFLEI(Dictionary<JCDPMBNJPFD, Material> INKOLAACAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6811180", Offset = "0x6810180", VA = "0x186811180")]
	private static void OLHJMNFIOMG(Dictionary<Renderer, ONFJKLEFIOO> DJIJMFDOOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x680D900", Offset = "0x680C900", VA = "0x18680D900")]
	private void IAMMCCFIHEK(SkinnedMeshRenderer[] KDJDOAOHFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x680A100", Offset = "0x6809100", VA = "0x18680A100")]
	private void EEMAKODFMBH(SkinnedMeshRenderer DCAEOBJOLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x680F270", Offset = "0x680E270", VA = "0x18680F270")]
	private void KLNAIONJLDD(List<KEHNINOIGAE> OBEAIJOPPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x680E670", Offset = "0x680D670", VA = "0x18680E670")]
	private void JHACHKLBHAC(Dictionary<string, GJJBOODDAKM<Texture2D>> DPGGOEHOLKL, bool GLFABBELALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x680D8B0", Offset = "0x680C8B0", VA = "0x18680D8B0")]
	private void HOIKHANPNGO(Dictionary<string, List<JCDPMBNJPFD>> DPGGOEHOLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6810F60", Offset = "0x680FF60", VA = "0x186810F60")]
	private void OAAPKHIMBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x680DD10", Offset = "0x680CD10", VA = "0x18680DD10")]
	private void IFMJLJKFJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x68104D0", Offset = "0x680F4D0", VA = "0x1868104D0")]
	private void NDBMFFICLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6810070", Offset = "0x680F070", VA = "0x186810070")]
	private void MDGMBGMBKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6811E50", Offset = "0x6810E50", VA = "0x186811E50")]
	private void PNGIBGNJPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x680F090", Offset = "0x680E090", VA = "0x18680F090")]
	private void KEIAGIMGBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x680B0D0", Offset = "0x680A0D0", VA = "0x18680B0D0")]
	private void FPMOMCIAEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x680E7F0", Offset = "0x680D7F0", VA = "0x18680E7F0")]
	private void KABDGPEEPLC(bool LPKLPAPBNFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x680A210", Offset = "0x6809210", VA = "0x18680A210")]
	private void ELELCMOCGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x68095D0", Offset = "0x68085D0", VA = "0x1868095D0")]
	private void DINNGNLDENO(bool LPKLPAPBNFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x680B1A0", Offset = "0x680A1A0", VA = "0x18680B1A0")]
	private void GAGHIEPIFNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x680F780", Offset = "0x680E780", VA = "0x18680F780")]
	private void LCEHPBNDOJF(Material BDPFKKCPGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6806BB0", Offset = "0x6805BB0", VA = "0x186806BB0")]
	private void APOCFCAFKEN(Material BDPFKKCPGNH, Color HFEHACGOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x680B4E0", Offset = "0x680A4E0", VA = "0x18680B4E0")]
	private void GAOJIHDDKCF(Material BDPFKKCPGNH, Color CNBBKPEPOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x68102D0", Offset = "0x680F2D0", VA = "0x1868102D0")]
	private void MNJKDOMPEPA(Material BDPFKKCPGNH, Color OPGILNOKCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x68117E0", Offset = "0x68107E0", VA = "0x1868117E0")]
	private void PMDPPPJKJDD(Material BDPFKKCPGNH, Texture2D JCAGFNGDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x68115F0", Offset = "0x68105F0", VA = "0x1868115F0")]
	private void ONJGMNMMGEA(Material BDPFKKCPGNH, Texture DEFEGNGCLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x680AF10", Offset = "0x6809F10", VA = "0x18680AF10")]
	private void FMNANGOABML(Action<ONFJKLEFIOO> AKAFBNFAPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x680F480", Offset = "0x680E480", VA = "0x18680F480")]
	private void LBCDIDMLKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6806D20", Offset = "0x6805D20", VA = "0x186806D20")]
	private void BAEJEKDHOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6809860", Offset = "0x6808860", VA = "0x186809860")]
	private AKGDPKBFKBL DNLDGMMJDCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6810AE0", Offset = "0x680FAE0", VA = "0x186810AE0")]
	private void NJLJOKPLLEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x680CF60", Offset = "0x680BF60", VA = "0x18680CF60")]
	public void HABNKIDAKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x68069C0", Offset = "0x68059C0", VA = "0x1868069C0")]
	[CompilerGenerated]
	private void AILDLOHONPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x680CF30", Offset = "0x680BF30", VA = "0x18680CF30")]
	[CompilerGenerated]
	private void HABAKDBCBHG(ONFJKLEFIOO NHKDKMPMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x68079F0", Offset = "0x68069F0", VA = "0x1868079F0")]
	[CompilerGenerated]
	private void DFILEGLLLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x68069A0", Offset = "0x68059A0", VA = "0x1868069A0")]
	[CompilerGenerated]
	private void AHHEICDIEMD(ONFJKLEFIOO NHKDKMPMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6811750", Offset = "0x6810750", VA = "0x186811750")]
	[CompilerGenerated]
	private void PBPPIHOAAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6810EB0", Offset = "0x680FEB0", VA = "0x186810EB0")]
	[CompilerGenerated]
	private void NJOIHOCDBND(ONFJKLEFIOO NHKDKMPMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6810140", Offset = "0x680F140", VA = "0x186810140")]
	[CompilerGenerated]
	private void MIAAEDNKOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x680D430", Offset = "0x680C430", VA = "0x18680D430")]
	[CompilerGenerated]
	private void HCPJBPEJKLK(ONFJKLEFIOO NHKDKMPMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6806910", Offset = "0x6805910", VA = "0x186806910")]
	[CompilerGenerated]
	private void ACAGGKKIHAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x680FC90", Offset = "0x680EC90", VA = "0x18680FC90")]
	[CompilerGenerated]
	private void LFCICIOMJFE(ONFJKLEFIOO NHKDKMPMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x680F1E0", Offset = "0x680E1E0", VA = "0x18680F1E0")]
	[CompilerGenerated]
	private void KLHLLIFIIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x680F450", Offset = "0x680E450", VA = "0x18680F450")]
	[CompilerGenerated]
	private void KPPKOJAIOMA(ONFJKLEFIOO NHKDKMPMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x68071B0", Offset = "0x68061B0", VA = "0x1868071B0")]
	[CompilerGenerated]
	private void CHIHIAGPIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x68070B0", Offset = "0x68060B0", VA = "0x1868070B0")]
	[CompilerGenerated]
	private void BLBOECLMIJP(ONFJKLEFIOO NHKDKMPMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x68096F0", Offset = "0x68086F0", VA = "0x1868096F0")]
	[CompilerGenerated]
	private void DLAHDHCLJPP(KeyValuePair<string, GJJBOODDAKM<Texture2D>> CNFPLGGBHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6810ED0", Offset = "0x680FED0", VA = "0x186810ED0")]
	[CompilerGenerated]
	private void NNFAGKBFMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x680FC60", Offset = "0x680EC60", VA = "0x18680FC60")]
	[CompilerGenerated]
	private void LDLJPKHGMDM(ONFJKLEFIOO NHKDKMPMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x680DC80", Offset = "0x680CC80", VA = "0x18680DC80")]
	[CompilerGenerated]
	private void IDIHNEFGOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6810450", Offset = "0x680F450", VA = "0x186810450")]
	[CompilerGenerated]
	private void NBAPMANJFPJ(ONFJKLEFIOO NHKDKMPMOAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LKCJLEMCIII : AEPBOLAKNAO
{
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int IMAMOHCLOMI;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int DEBLGLILGKP;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int AILKNLIKEKM;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int BKFBFKODIHG;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int PGGBGDMAOHH;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int APCMKOMFGDJ;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int EMDANNAGDDF;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int HGNMMPEPKCN;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int HIFAAOANDFK;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int CMCEJAGPAFG;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int BJMMJMBLLNO;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int KJKCDMBJAOB;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int HNIHOKAOBBM;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int AFJLBCODGAD;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int DAKMOAJGMMA;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int HONJBNBCJJK;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int PBJIAPMLGHA;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int OOGLCMFOPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform DOHJGGHPMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform OJEPBMPDIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform NAPHNOGMGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform EEJLJMHNIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform HCNDOGOHIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform MIJDOOLKMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform FKCBCFCCFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private POKEEIBBGJO DHJPAPEDIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private MaterialPropertyBlock ELEBKFCBNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private SkinnedMeshRenderer[] DELOHKLMGDE;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock EOLFOOIBCMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6806100", Offset = "0x6805100", VA = "0x186806100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6804DF0", Offset = "0x6803DF0", VA = "0x186804DF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x68062F0", Offset = "0x68052F0", VA = "0x1868062F0", Slot = "7")]
	public void LFNNOPDGNGK(POKEEIBBGJO AFLKKDMHNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6804600", Offset = "0x6803600", VA = "0x186804600", Slot = "8")]
	public void AJFKJNIIOOK(IBAHNNBICOE IHOKOJNPFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x68049C0", Offset = "0x68039C0", VA = "0x1868049C0", Slot = "5")]
	public void BINKDKKFPLG(GKFDGMDLPBL JODBBCINCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x68060A0", Offset = "0x68050A0", VA = "0x1868060A0")]
	private Vector2 GOEPGLPIDMH(Vector2 EPCFAOBEBFJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6804F70", Offset = "0x6803F70", VA = "0x186804F70", Slot = "6")]
	public void GGCAOHIMKOI(HJBIJBLGIBO IHOKOJNPFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6804670", Offset = "0x6803670", VA = "0x186804670")]
	private void BCOGPEDGNEP(HJBIJBLGIBO MDINDOBILPD, LMAHHCPAAHC MFNMGIOHFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6806210", Offset = "0x6805210", VA = "0x186806210")]
	private void KMMABKACCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x68066E0", Offset = "0x68056E0", VA = "0x1868066E0")]
	public LKCJLEMCIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6806180", Offset = "0x6805180", VA = "0x186806180")]
	[CompilerGenerated]
	internal static (float, float) HONDHKKEJLA(float PICNKMEHMAI)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6804630", Offset = "0x6803630", VA = "0x186804630")]
	[CompilerGenerated]
	internal static Vector4 BBABPLLACFD(Vector2 LLLHNMGEKPM, Vector2 FHBDGLOPEKN)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NADJPEJAJKG? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public HAADOMONODM CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6817330", Offset = "0x6816330", VA = "0x186817330")]
			get
			{
				return default(HAADOMONODM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public NADJPEJAJKG MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6817360", Offset = "0x6816360", VA = "0x186817360")]
			get
			{
				return default(NADJPEJAJKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8515F0", Offset = "0x8505F0", VA = "0x1808515F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8516F0", Offset = "0x8506F0", VA = "0x1808516F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6816FB0", Offset = "0x6815FB0", VA = "0x186816FB0")]
		public Material[] LEOLCLDMIIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x68170A0", Offset = "0x68160A0", VA = "0x1868170A0")]
		public static void PNHICGLDEAD(AvatarItemMaterial AEELHGBJNEC, Material JNFDDANGPCP, int BOBDGMLNJHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6817260", Offset = "0x6816260", VA = "0x186817260")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[CCEMJNNADFH]
public struct KNMOGOBDENH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	public LGAOKHMJICK AFDLJIDONOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	public int JBALGICKFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public CCGFJKLMMJI CLHPBEJJOAE;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x681A720", Offset = "0x6819720", VA = "0x18681A720", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[NativeContainer]
[CCEMJNNADFH]
public struct CCGFJKLMMJI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public NativeArray<Vector3> OLFALFPLNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public NativeArray<Vector3> CKLECABJJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeArray<Vector4> HLMADOJIIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NativeArray<Vector2> OGJAPNIOAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Vector2> HBJGFILLPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<Vector2> OCELAGJBBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<Vector2> PCJACPALFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public NativeArray<Color> OIDBEIKILLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public NativeArray<int> FFNKOCJCKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<int> HOJKMIMFCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private NativeArray<int> NDFPIAEMIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private NativeArray<int> LLJAPLLAIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<int> LPANPNEDCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public NativeArray<int> DLGEFPMBHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public NativeArray<int> BBAKHFBEELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NativeArray<BoneWeight> HJCMBOOOPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private NativeArray<int> OEFIADEKGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private bool PECPAMJMMFP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int HFELIGNPMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6817A40", Offset = "0x6816A40", VA = "0x186817A40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6817A30", Offset = "0x6816A30", VA = "0x186817A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int MOHJJAPCOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x68174E0", Offset = "0x68164E0", VA = "0x1868174E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6817A60", Offset = "0x6816A60", VA = "0x186817A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int GBEELDOLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6817A50", Offset = "0x6816A50", VA = "0x186817A50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6817840", Offset = "0x6816840", VA = "0x186817840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6817E70", Offset = "0x6816E70", VA = "0x186817E70")]
	public CCGFJKLMMJI(int JMKKKIMPLAJ, int KFJPCFNOIMA, int OMHAFODBGOI, int MDEEIGFFNGM, Allocator OOMMBGGEBLM, int NLKEKBHENIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6817A70", Offset = "0x6816A70", VA = "0x186817A70")]
	public void GOCGGFJHMKG(int HCALFJOJKJO, Vector3 CKOKPBDJPNC, Vector3 BBIKELPGJLE, Vector4 IGKMAMABJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6817AE0", Offset = "0x6816AE0", VA = "0x186817AE0")]
	public void HHJEAOLFJMI(int HCALFJOJKJO, BoneWeight OFNHFLHIAHH, NativeSlice<byte> MHIEANANIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6817CF0", Offset = "0x6816CF0", VA = "0x186817CF0")]
	public Color LALECKBEPCI(int HCALFJOJKJO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6817C80", Offset = "0x6816C80", VA = "0x186817C80")]
	public void HKBELCOBCKB(int HCALFJOJKJO, Color MHIEIJBIEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6817CA0", Offset = "0x6816CA0", VA = "0x186817CA0")]
	public void IMOABNOJMHL(byte MGHLIFLJIJG, int HCALFJOJKJO, Vector2 JJKFHPJELDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6817420", Offset = "0x6816420", VA = "0x186817420")]
	public void AFNLKDLEKPB(int HCALFJOJKJO, int EJOHKCPDBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6817A00", Offset = "0x6816A00", VA = "0x186817A00")]
	public bool EHNJJOJKHNA(int MGHLIFLJIJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6817DA0", Offset = "0x6816DA0", VA = "0x186817DA0")]
	public void NENOPBANGPL(int OOKKOPIGEOA, int BEMLKOBANDO, int IGIHBEMLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6817430", Offset = "0x6816430", VA = "0x186817430")]
	public int[] ALDMBNLDFDD(int OOKKOPIGEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6817D10", Offset = "0x6816D10", VA = "0x186817D10")]
	private NativeSlice<int> NAJFPPIFNLP(int OOKKOPIGEOA)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6817850", Offset = "0x6816850", VA = "0x186817850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x68174F0", Offset = "0x68164F0", VA = "0x1868174F0")]
	public Mesh DGAFICBDDJK([Optional] string MAALKLDDFME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[DefaultMember("Item")]
[CCEMJNNADFH]
public struct LGAOKHMJICK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<Vector3> OLFALFPLNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<Vector3> CKLECABJJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NativeArray<Vector4> HLMADOJIIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public NativeArray<Vector2> OGJAPNIOAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Vector2> HBJGFILLPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<Vector2> OCELAGJBBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<Vector2> PCJACPALFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<Color> OIDBEIKILLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<int> PKOALMBMIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<int> BEEJANKPKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<int> OBLHNBPCDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<int> HBEFLDBFEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<bool> KALCHEPJNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public NativeArray<int> ECHKJJDAGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public NativeArray<int> HDIEKKLPCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public NativeArray<BoneWeight> LPMGOLCIGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeArray<Matrix4x4> GKHKKLMKDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeArray<int> HIMJNMCPCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NativeArray<byte> CHCJNDECCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private NativeArray<int> MMGFBJLPEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> HDIDHPMIECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public NativeArray<sbyte> IOAKOPDLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public NativeArray<byte> NICKILNLHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private NativeArray<int> LFPNOLPFOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private bool PECPAMJMMFP;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int NCHJAONJJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2032730", Offset = "0x2031730", VA = "0x182032730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MDCLBHNECCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x10F37D0", Offset = "0x10F27D0", VA = "0x1810F37D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int LJDIFGMEHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x681BDB0", Offset = "0x681ADB0", VA = "0x18681BDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int BDEPHBEJDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x681BE60", Offset = "0x681AE60", VA = "0x18681BE60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x681BE10", Offset = "0x681AE10", VA = "0x18681BE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int HFELIGNPMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x681BE00", Offset = "0x681AE00", VA = "0x18681BE00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x681BDF0", Offset = "0x681ADF0", VA = "0x18681BDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int AOLDNCHANCH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x681BE30", Offset = "0x681AE30", VA = "0x18681BE30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x681BE70", Offset = "0x681AE70", VA = "0x18681BE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public PMPMBDGPMBD LBCMHKOCFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x681BE50", Offset = "0x681AE50", VA = "0x18681BE50")]
		get
		{
			return default(PMPMBDGPMBD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x681BDE0", Offset = "0x681ADE0", VA = "0x18681BDE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte LJMMPBCELLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x681BE40", Offset = "0x681AE40", VA = "0x18681BE40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x681BE20", Offset = "0x681AE20", VA = "0x18681BE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GFDDKANECIP OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x681B630", Offset = "0x681A630", VA = "0x18681B630")]
		get
		{
			return default(GFDDKANECIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x681BF50", Offset = "0x681AF50", VA = "0x18681BF50")]
	public LGAOKHMJICK(IList<Mesh> KAILGEHNCAI, IList<Matrix4x4> ELKFACGMAFA, IList<bool> KALCHEPJNMI, byte IJOJNIEKAJP, IList<byte[]> HEOEPIOAJAB, IList<int> GJFNBAFNKGF, IList<bool> LKEGJOGCBNC, IList<int> ECHKJJDAGKD, IList<int> PLFJMPKDPDD, IList<int> HNCLBPBGJGM, Allocator OOMMBGGEBLM, PMPMBDGPMBD KDLIJKKBKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x681BE80", Offset = "0x681AE80", VA = "0x18681BE80")]
	public CCGFJKLMMJI PGIEOMFAOAA(Allocator OOMMBGGEBLM)
	{
		return default(CCGFJKLMMJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x681BB50", Offset = "0x681AB50", VA = "0x18681BB50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CCEMJNNADFH]
public class HMJMHPPBAOP : ACJBPHAJLHC
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6819AE0", Offset = "0x6818AE0", VA = "0x186819AE0")]
	public LGAOKHMJICK CBNMHHLCJAA()
	{
		return default(LGAOKHMJICK);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6812D60", Offset = "0x6811D60", VA = "0x186812D60")]
	public HMJMHPPBAOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GFDDKANECIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeSlice<Vector3> OLFALFPLNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public NativeSlice<Vector3> CKLECABJJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeSlice<Vector4> HLMADOJIIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeSlice<Vector2> OGJAPNIOAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Vector2> HBJGFILLPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<Vector2> OCELAGJBBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<Vector2> PCJACPALFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<Color> OIDBEIKILLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<int> CKIBBAFGPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeSlice<int> HBEFLDBFEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public NativeSlice<BoneWeight> LPMGOLCIGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public NativeSlice<byte> KKBEAOJONII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public int COBPFOOKIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public Matrix4x4 NAEBJPKHAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public int EIIHLKOHCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public NativeSlice<byte> MHIEANANIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public bool JAFPJNLBLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public int IKKOOMHAGME;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal readonly struct JCDPMBNJPFD : IEquatable<JCDPMBNJPFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	internal readonly Material DKEDIIKAFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	internal readonly BIHABJEJLGF NIPJKJALIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	internal readonly FJPDPDHAANH KDGIAKOPLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	internal readonly OELEMBFEEON MFLBBNNGABG;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xB11F70", Offset = "0xB10F70", VA = "0x180B11F70")]
	public JCDPMBNJPFD(Material JNFDDANGPCP, BIHABJEJLGF GNDMKPPOMLH, FJPDPDHAANH IHACKOBNBCK, OELEMBFEEON ODGPAFEGIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6819D60", Offset = "0x6818D60", VA = "0x186819D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xB11B30", Offset = "0xB10B30", VA = "0x180B11B30", Slot = "4")]
	public bool Equals(JCDPMBNJPFD ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6819BD0", Offset = "0x6818BD0", VA = "0x186819BD0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6819CC0", Offset = "0x6818CC0", VA = "0x186819CC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ONFJKLEFIOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private MaterialPropertyBlock BCMFGGNELPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public Color? GLEDNPFJLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Color? DAFEIAAMGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Color? CFIHDBKGBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Color? EJEMAMDJDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Color FABELBCJIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Color GFPABKOCOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Color MLIDEONLKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Texture2D BMMCINDOEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Texture2D KCFPHHNJHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private Dictionary<JCDPMBNJPFD, int> CJFJMKOLFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private BIHABJEJLGF[] AGDODGEAAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private FJPDPDHAANH[] DIEEPPCGFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector4[] CFPEIPFMJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector4[] POEBNDJBIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector4[] JCJKMOHOBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector4[] OPDIKIFALLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector4[] MIOGMAJIIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector4[] FHJPGFPHPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private List<Texture2D> JFEADFFPLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Vector4[] GBJJKLAKDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private List<Texture2D> IJKOIDMPBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private float[] DIOHIEGLHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private Vector4[] NIIAJACAODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private float[] KIBGNIDGAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float[] DDKKAAIGANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private List<Texture2D> CKCMMNMDDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private float[] LKBDDMNKMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private List<Texture2D> PIJOODEPNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private Vector4[] FNABGCAHMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private float[] OCNDPENFMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Vector4[] BNGGJMHEOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float[] FPOBKOHCJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Texture2DArray MEAJLAPLOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public Texture2DArray MLAKLBIDPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public Texture2DArray PMNCOINHPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public Texture2DArray PLIBDKKCNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private bool KJKHLNEIHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private int IHKEHJLNNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private Vector2? IOICNNHKBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private TextureFormat DIOFLGGODEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private Vector2? FNGHNDGDJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private TextureFormat BPFHBOOGJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Vector2? JGOEEIPLIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private TextureFormat LGNOMDLKBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private Vector2? GIKIHAJDPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private TextureFormat GBANJPAFLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private bool IHDIIKNEDCC;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static int HOHCJHNEBIK;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static int NPDBLMHLLMC;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static int OIMOAACNKAL;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int FPGGOLBGGIL;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int LDDOLBCGFIA;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int KCKDLHPBCOJ;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int FKHFLODOJFF;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int ALEIAMCEIBP;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int HMOGEHFGJAO;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int IMOIPBKDDKA;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int JBMNDGFDLAC;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int GCHFLBNKPEK;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int GIPKKMIEGIL;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int BBGOBEKFPPH;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int GLADACJAJPE;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int JAKHLPLHEEC;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int HFDFMBDIEOE;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static int EJFCGGBONJO;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static int PFEGEBAJPOA;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static int KKEKOLEHBEE;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6820EF0", Offset = "0x681FEF0", VA = "0x186820EF0")]
	private ONFJKLEFIOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x68213E0", Offset = "0x68203E0", VA = "0x1868213E0")]
	public ONFJKLEFIOO(Color KJCLAPCJBLJ, Color OMANOIIHPAN, Color DILMHGLGAMI, Color? NJELJEGDMKF, Color? LJFFBJGAGFJ, Color? EOBAPOGHECA, Texture2D DENIHHOBFID, Texture2D APINIDDMIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x68206C0", Offset = "0x681F6C0", VA = "0x1868206C0")]
	internal int EBOGJAABAMO(Material DJNILFJGMLE, BIHABJEJLGF GNDMKPPOMLH, FJPDPDHAANH IHACKOBNBCK, OELEMBFEEON ODGPAFEGIFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6820630", Offset = "0x681F630", VA = "0x186820630")]
	private int EBOGJAABAMO(JCDPMBNJPFD GMFCIHEFPPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x681E9C0", Offset = "0x681D9C0", VA = "0x18681E9C0")]
	internal int BECIHNAAPKH(Material DJNILFJGMLE, Color OPGILNOKCAP, Color OGFIPIMDOII, Color PBOGEPNCMLI, Color EDJCJPJEANN, Color LBONAILPLMI, Texture2D BOABGEHDBPO, Vector4 CIGHKGKEJKN, Texture2D BCGFIDFFCDF, Vector4 LEAPKGNBDKF, float CEOEMBLAIIL, float KJNCEGBCKCJ, Texture2D BFILHFJJBOM, Vector4 FCPCIJAGFHP, float LKAGDABIAII, Texture2D MLDLFGHBOOL, Color BOEDIJHCGPB, Vector4 FPABBFNIPDF, BIHABJEJLGF GNDMKPPOMLH, FJPDPDHAANH IHACKOBNBCK, OELEMBFEEON ODGPAFEGIFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x68202E0", Offset = "0x681F2E0", VA = "0x1868202E0")]
	private void BMLDCKIHGEE(List<Texture2D> JFEADFFPLFC, [Out] Texture2DArray JEHDOJCGGIB, [Out] Texture2DArray IIABLDDNJAN, [Out] Texture2DArray KFKCKOFBCFA, [Out] Texture2DArray ACFMBFIIIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x68204A0", Offset = "0x681F4A0", VA = "0x1868204A0")]
	public void CFIOINKHDCB(Shader OCEEJEEEGDE, Renderer EIOJIOLKBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x681F590", Offset = "0x681E590", VA = "0x18681F590")]
	private void BKGHLNCOBFO(Shader OCEEJEEEGDE, Renderer EIOJIOLKBHF, int DDABEPABPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6820960", Offset = "0x681F960", VA = "0x186820960")]
	private Color PFBFMIPKMLJ(Color LHAEJPDNHKH, BIHABJEJLGF GEEBFHBCPPB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x681E870", Offset = "0x681D870", VA = "0x18681E870")]
	private Color ABLEHHCFKNC(Color KIOFEANLOFJ, BIHABJEJLGF GEEBFHBCPPB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6820860", Offset = "0x681F860", VA = "0x186820860")]
	private bool KKKDHFKNBEG(Texture2D ECPONBIFJOO, FJPDPDHAANH JAFJCINAICH, [Out] Texture2D ADNNFGOFBAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x68207B0", Offset = "0x681F7B0", VA = "0x1868207B0")]
	private void KEODFKNANIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x68205F0", Offset = "0x681F5F0", VA = "0x1868205F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class ELKICILHBNA
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class PDAOIJLBHEB : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public PDAOIJLBHEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xB0EC50", Offset = "0xB0DC50", VA = "0x180B0EC50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x68214A0", Offset = "0x68204A0", VA = "0x1868214A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	public static void GMOFCPHFGCA(string KHLDDJPHOBA, int HCJLPFCODLH, long GHDPMJBAKBM, long MLFDNJJOBOG, long ODHIMFPGBMC, long ALLDLAHBCKB, long GHAFEEHAOEP, long EMJPOOPLDCK, long GCOMACKDGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6818BA0", Offset = "0x6817BA0", VA = "0x186818BA0")]
	public static HDBNHMIPDLF HAAGCFKMECE(JobHandle CBHGHDPLIPK, bool OKJIFKFPDFO, bool JKMKCAPEGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6818CF0", Offset = "0x6817CF0", VA = "0x186818CF0")]
	[IteratorStateMachine(typeof(PDAOIJLBHEB))]
	private static IEnumerator<FAKEPIEMOLB> HNICAGLBAKG(JobHandle EFPCBKOLOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class NOGBAHKKCHE : BGBCCAFOJKD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private KHLHBDNKPDA GHDJFOONAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private PLEHIOCMACE DGNEGLBEAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private IRecRoomQualityConfigProvider CPJMDENBMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool PECPAMJMMFP;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x681E100", Offset = "0x681D100", VA = "0x18681E100")]
	[ONAOIKEPAJE(IKAJKCKEGIH.GameOnly)]
	private static void EHAAFPDEPGI(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5B29EB0", Offset = "0x5B28EB0", VA = "0x185B29EB0")]
	[UnityEngine.Scripting.Preserve]
	public NOGBAHKKCHE([JONIFKKOOAA(null)] PLEHIOCMACE FOJHOFDJHCF, [JONIFKKOOAA(null)] KHLHBDNKPDA ENDHEIPOMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x681E200", Offset = "0x681D200", VA = "0x18681E200")]
	private void KELCJNAJBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x681E0A0", Offset = "0x681D0A0", VA = "0x18681E0A0", Slot = "4")]
	public void DJEBJAFJIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x681E3B0", Offset = "0x681D3B0", VA = "0x18681E3B0", Slot = "5")]
	public GJJBOODDAKM<Texture2D> PBOCNNCGHIA(OFDCHBFCKEB GBHJHGHFPDM, [Optional] MCJLLMFGIPJ OEFIADEKGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x681E270", Offset = "0x681D270", VA = "0x18681E270")]
	private uint MDGHFDJMEGG(OFDCHBFCKEB GBHJHGHFPDM, MCJLLMFGIPJ OEFIADEKGGF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface PNBGIPFLGBI
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLDNNFBGPCO(Mesh EIOKGMMIDKC, Matrix4x4 LGLHBMCIIPD, byte[] MHIEANANIHF, bool JKEEBNGANDA = false, PMDMGKIOLAB.NJCPOFDIECP EGJBPKHEGNP = (PMDMGKIOLAB.NJCPOFDIECP)0, int ECHKJJDAGKD = -1, bool KALCHEPJNMI = false);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFJIJNJKAAM(Allocator OOMMBGGEBLM, PMPMBDGPMBD KDLIJKKBKCH, byte IJOJNIEKAJP, [Optional] IList<int> PLFJMPKDPDD, [Optional] IList<int> PDLHNEKLCBO);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct JFFEIJJGKJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly GameObject KPFKPCLKMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly AvatarItemMaterial DCMKAHMNHJL;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
	public JFFEIJJGKJG(GameObject KPFKPCLKMDA, AvatarItemMaterial DCMKAHMNHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6819F90", Offset = "0x6818F90", VA = "0x186819F90")]
	public void LMFHCHLGKHK(Material JNFDDANGPCP, int BOBDGMLNJHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EEOHPJPDPJJ : MGBFCHOBOBP<Task<(GameObject, AvatarItemMaterial)>, JFFEIJJGKJG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct MKOCMICHPGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x681D780", Offset = "0x681C780", VA = "0x18681D780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x681DC80", Offset = "0x681CC80", VA = "0x18681DC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private GJJBOODDAKM<GameObject> JFBGDHADNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private GJJBOODDAKM<AvatarItemMaterial> AJGNPPGEEBO;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6818910", Offset = "0x6817910", VA = "0x186818910")]
	private EEOHPJPDPJJ(Task<(GameObject, AvatarItemMaterial)> FGPHJGHMKNM, GJJBOODDAKM<GameObject> MGCEFAHJMMO, GJJBOODDAKM<AvatarItemMaterial> GNIPFFDJLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6818350", Offset = "0x6817350", VA = "0x186818350")]
	public static EEOHPJPDPJJ EAPGIKBOING(AssetReference ELIHFGHHHJF, [Optional] AssetReference CFHMACACPJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x68182B0", Offset = "0x68172B0", VA = "0x1868182B0", Slot = "11")]
	protected override JFFEIJJGKJG CAIGDFEDKCP(Task<(GameObject, AvatarItemMaterial)> HMLOALPMAAP)
	{
		return default(JFFEIJJGKJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6818890", Offset = "0x6817890", VA = "0x186818890", Slot = "12")]
	protected override void HKMPBCKENOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6818760", Offset = "0x6817760", VA = "0x186818760")]
	[AsyncStateMachine(typeof(MKOCMICHPGL))]
	private static Task<(GameObject, AvatarItemMaterial)> EMGFCJCICND(Task<GameObject> EOBDOFOEMEK, Task<AvatarItemMaterial> FPGMEKOLIDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GCAMICOFFAP
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class KFEKPOHPBGE : MGBFCHOBOBP<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private GJJBOODDAKM<MaterialMapAsset> EFPCBKOLOGB;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x681A640", Offset = "0x6819640", VA = "0x18681A640")]
		public KFEKPOHPBGE(GJJBOODDAKM<MaterialMapAsset> EFPCBKOLOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x681A1A0", Offset = "0x68191A0", VA = "0x18681A1A0", Slot = "11")]
		protected override Material[] CAIGDFEDKCP(Task<MaterialMapAsset> FGPHJGHMKNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x681A5E0", Offset = "0x68195E0", VA = "0x18681A5E0", Slot = "12")]
		protected override void HKMPBCKENOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class EFBGLLKPGAO : MGBFCHOBOBP<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private List<GJJBOODDAKM<Material>> DFCFMCAFJAI;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6818B30", Offset = "0x6817B30", VA = "0x186818B30")]
		public EFBGLLKPGAO(Task<Material[]> FGPHJGHMKNM, List<GJJBOODDAKM<Material>> DFCFMCAFJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x68189A0", Offset = "0x68179A0", VA = "0x1868189A0", Slot = "11")]
		protected override Material[] CAIGDFEDKCP(Task<Material[]> HMLOALPMAAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x68189F0", Offset = "0x68179F0", VA = "0x1868189F0", Slot = "12")]
		protected override void HKMPBCKENOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6819640", Offset = "0x6818640", VA = "0x186819640")]
	public static GJJBOODDAKM<Material[]> MOBCOPPNFPF(AssetReference[] AJLNPCINJKA)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[IDHMMACJAGM(JFBJMOOHBCL.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x68214F0", Offset = "0x68204F0", VA = "0x1868214F0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct NLKBIOKLKHI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public AsyncTaskMethodBuilder<JHBGCGEMCNL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private TaskAwaiter<JHBGCGEMCNL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x681DCF0", Offset = "0x681CCF0", VA = "0x18681DCF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x681E030", Offset = "0x681D030", VA = "0x18681E030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private Dictionary<DFGLBGMNOFH, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Dictionary<DFGLBGMNOFH, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<DFGLBGMNOFH, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<DFGLBGMNOFH, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly Dictionary<DFGLBGMNOFH, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private JHBGCGEMCNL _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x6819610", Offset = "0x6818610", VA = "0x186819610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x68192E0", Offset = "0x68182E0", VA = "0x1868192E0")]
		public JHBGCGEMCNL MHAHPOJKGKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6819110", Offset = "0x6818110", VA = "0x186819110")]
		[AsyncStateMachine(typeof(NLKBIOKLKHI))]
		public Task<JHBGCGEMCNL> KFIBFFPCNOB(int GFCNBGNFLFK, int MJICDNHPEID, int DJCALOBLCIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6819240", Offset = "0x6818240", VA = "0x186819240")]
		public NoseFaceOption MABKKNELJOG(int HDBDOODOJEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6818D60", Offset = "0x6817D60", VA = "0x186818D60")]
		public SelectableFaceOption BEOHAHHPDPE(FaceFeatureType HKHKIDDPCIM, DFGLBGMNOFH JGOLMEOPBBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6819450", Offset = "0x6818450", VA = "0x186819450")]
		public int OBJPBPNFCBH(DFGLBGMNOFH JGOLMEOPBBM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6818EE0", Offset = "0x6817EE0", VA = "0x186818EE0")]
		private void JJONDAHKALA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0780", Offset = "0x2BAF780", VA = "0x182BB0780")]
		private void IHJFJGEMELF<T>(IDictionary<DFGLBGMNOFH, T> PDKIFAKOONJ, IReadOnlyList<T> PCGLLJCBIFP) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x68194D0", Offset = "0x68184D0", VA = "0x1868194D0")]
		public DFGLBGMNOFH PGJIKHHOBLF(FaceFeatureType HKHKIDDPCIM)
		{
			return default(DFGLBGMNOFH);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6819330", Offset = "0x6818330", VA = "0x186819330")]
		public DFGLBGMNOFH NHOIFOAFOOD(FaceFeatureType HKHKIDDPCIM)
		{
			return default(DFGLBGMNOFH);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6819580", Offset = "0x6818580", VA = "0x186819580")]
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
