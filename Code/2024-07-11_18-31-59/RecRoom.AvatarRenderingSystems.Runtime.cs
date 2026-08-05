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
	public class LogRegistrationIndex : MKCMLEJGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6771510", Offset = "0x676FF10", VA = "0x186771510", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8554B0", VA = "0x180856AB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6776970", Offset = "0x6775370", VA = "0x186776970", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67768A0", Offset = "0x67752A0", VA = "0x1867768A0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6776930", Offset = "0x6775330", VA = "0x186776930")]
		public RecNetCDNAssetReference(RecNetCDNKey NDDCLPHCEEO)
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
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8579C0", VA = "0x180858FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67769B0", Offset = "0x67753B0", VA = "0x1867769B0")]
		public static RecNetCDNKey OHBAGDNOBOH(string AALLHBPLGBD, string ACJNIJOJKAK = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F691A0", Offset = "0x5F67BA0", VA = "0x185F691A0")]
		public void CPBLCAFPFKN(string HLCLBMCLPCO, string BGMAOMLOOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6776AB0", Offset = "0x67754B0", VA = "0x186776AB0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[OJAAPNLEIHM]
public class BAAPDJDFOIL : ELBFEJGFGLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> IHINLJKMHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> PCEMBFJDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> ALDEFKNGKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> KNFEJNBHJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> OCFMPBEAPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> IFACFPJFJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> ECOEAIFDGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator CNBOLKBJKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected GNMEONFECFB LKNOCJKLAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte OHMIDONEJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> IKBEABHMGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> CKLMJFNHFFE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x675EF20", Offset = "0x675D920", VA = "0x18675EF20", Slot = "4")]
	public void GNCDIBNJHAL(Mesh DICFBCCFLEI, Matrix4x4 EDCJGOBHCEF, byte[] DBKJBDCMJKO, bool BMPOEDNJLJB = false, DPBKAJAMMON.JBNKIJKKBDP MFNGANCKCAO = (DPBKAJAMMON.JBNKIJKKBDP)0, int HICAHCGIPFN = -1, bool ELIMPKJEPNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x675EEE0", Offset = "0x675D8E0", VA = "0x18675EEE0", Slot = "5")]
	public void FNMKELPLOJM(Allocator CHDJMCMMMLJ, GNMEONFECFB FJPGPFOHGJM, byte GHHAMCLNJHM, [Optional] IList<int> FIBPFBMKFIN, [Optional] IList<int> NJPIBFBJMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x675EC90", Offset = "0x675D690", VA = "0x18675EC90")]
	private static void DHCANFHLEKG(Mesh DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x675F120", Offset = "0x675DB20", VA = "0x18675F120")]
	public BAAPDJDFOIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OJAAPNLEIHM]
public struct LIOHMJGEIOE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public OFOOBONMNLC EIONCDLBHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int JPNEAEFEHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public PMKDNEGPHEH FNEKPNADEHB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x676FA60", Offset = "0x676E460", VA = "0x18676FA60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OJAAPNLEIHM]
[NativeContainer]
public struct PMKDNEGPHEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct IMEFKKIAAJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 BJHNDNBDIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 NFFLDAHKGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 AKIMOBCHKEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct NFLCGGOFKLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float PLFJGGBGFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float CBPDNFELCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float PKACCJKIBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float AOHOKMIJKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte IBCENIIDMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte FEBMNIPNKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte OHMLDLHBCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte MDKAAEOGNKD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct ABABJMFMEDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half PLFJGGBGFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half CBPDNFELCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half PKACCJKIBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half AOHOKMIJKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte IBCENIIDMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte FEBMNIPNKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte OHMLDLHBCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte MDKAAEOGNKD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct CPPDNIFKIMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 KIJNHGNFMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 OMDKPAEEMBP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct KHNHLIJPOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 KIJNHGNFMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 OMDKPAEEMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 HHKKNKLEJPM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NIEMCNHNNAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 KIJNHGNFMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 OMDKPAEEMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 HHKKNKLEJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 PMMFPJFCMBC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PFGGCDJGLEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 KIJNHGNFMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 OMDKPAEEMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 HHKKNKLEJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 PMMFPJFCMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 CFCCLGAEECF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct IOICFAIMHJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float PLFJGGBGFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float CBPDNFELCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float PKACCJKIBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float AOHOKMIJKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int IBCENIIDMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int FEBMNIPNKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int OHMLDLHBCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int MDKAAEOGNKD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct CCNIJGJGFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color KIJNHGNFMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 OMDKPAEEMBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct GFDKPHLEHHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color KIJNHGNFMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 OMDKPAEEMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 HHKKNKLEJPM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct KJBFOFKLKHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color KIJNHGNFMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 OMDKPAEEMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 HHKKNKLEJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 PMMFPJFCMBC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct EELIHFJEBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color KIJNHGNFMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 OMDKPAEEMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 HHKKNKLEJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 PMMFPJFCMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 CFCCLGAEECF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool KHHCEDLJFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<IMEFKKIAAJE> MLOAGCKILME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<CPPDNIFKIMN> LOJILJFGBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<KHNHLIJPOAN> HAGKMABFFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<NIEMCNHNNAC> NCHLOPCBNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<PFGGCDJGLEF> BHHMHLCCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ABABJMFMEDG> CPOIEHCFBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<NFLCGGOFKLB> FBEIIMEHLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<CCNIJGJGFPF> PPGNPLLBADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<GFDKPHLEHHN> HGHOOLCALEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<KJBFOFKLKHE> KEBGHFHMBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<EELIHFJEBCN> FPGLHLJLFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<IOICFAIMHJE> JABKKKBAEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> FBGCIOJNDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> GLDKADLKPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> JPBNFIOGBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> EKDCPKBFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> GBKIDOIHGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> KDAFMAACIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> FAEMCMMIHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> DNDAHKKDOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> LDMPLMIKDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool HFIBACDLHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool BEHCNKCKEMO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DIPIJGHDLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x67749C0", Offset = "0x67733C0", VA = "0x1867749C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6775E60", Offset = "0x6774860", VA = "0x186775E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CFFONAKGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6775E50", Offset = "0x6774850", VA = "0x186775E50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6773F40", Offset = "0x6772940", VA = "0x186773F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int HBMDLLOJIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67746C0", Offset = "0x67730C0", VA = "0x1867746C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6774280", Offset = "0x6772C80", VA = "0x186774280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DJLDIHIGKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6774E50", Offset = "0x6773850", VA = "0x186774E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6775E70", Offset = "0x6774870", VA = "0x186775E70")]
	public PMKDNEGPHEH(int JPGPFGMDFFJ, int JOAOBPKBJPK, int OFICJAKPOPC, int ENKLOOOFMNC, Allocator CHDJMCMMMLJ, int LKHEAAKNHMP, DLFECEDNMGA ACHCCBNIADG, bool HFIBACDLHOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6774930", Offset = "0x6773330", VA = "0x186774930")]
	public void EDDLNIEMBEB(int DHNLEFJCEAH, Vector3 NJJHKDBJDAC, Vector3 IPBCPNHEHBB, Vector4 DOGPFNGIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6774290", Offset = "0x6772C90", VA = "0x186774290")]
	public void DDMBNNDLMDO(int DHNLEFJCEAH, BoneWeight CLPIOJNHBDJ, NativeSlice<byte> DBKJBDCMJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6773F50", Offset = "0x6772950", VA = "0x186773F50")]
	public Color CIPADPJBGGE(int DHNLEFJCEAH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6773B40", Offset = "0x6772540", VA = "0x186773B40")]
	public void ABEFFJMJNGG(int DHNLEFJCEAH, Color DDJHOHBDMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67749D0", Offset = "0x67733D0", VA = "0x1867749D0")]
	public void HDMLHMIPCGG(byte BKALJKAMJJI, int DHNLEFJCEAH, Vector2 EMLOHHMFJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6774EC0", Offset = "0x67738C0", VA = "0x186774EC0")]
	public void KAFEMIOCBEL(int DHNLEFJCEAH, int EDFEBNBLMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6775DF0", Offset = "0x67747F0", VA = "0x186775DF0")]
	public bool MBKPEHHBCJO(int BKALJKAMJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6774D80", Offset = "0x6773780", VA = "0x186774D80")]
	public void HKLOKJAPOPO(int MJDDAIDLEAO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67746D0", Offset = "0x67730D0", VA = "0x1867746D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6774ED0", Offset = "0x67738D0", VA = "0x186774ED0")]
	public Mesh LKECLIMBOCL([Optional] string IJCHBIMDHCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[OJAAPNLEIHM]
[DefaultMember("Item")]
public struct OFOOBONMNLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray LFKAIFDDBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> LCBCGHCBAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> GHAIJDPFBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> DNDAHKKDOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> AEGDJACGHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> NJCGJGKKHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> CCBMPAJILLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> IGIMENDFPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> LEIHKNAHPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> EEPHJDJOLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> JNIFCNKJDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> ELIMPKJEPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> HICAHCGIPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool HFIBACDLHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> EINJJPLOGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool BEHCNKCKEMO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int GGLDKOAFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6771F40", Offset = "0x6770940", VA = "0x186771F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MHKAMAIMFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6771F70", Offset = "0x6770970", VA = "0x186771F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OMKKHCGEBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6771E50", Offset = "0x6770850", VA = "0x186771E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MCCMDICLGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6771D60", Offset = "0x6770760", VA = "0x186771D60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6771F20", Offset = "0x6770920", VA = "0x186771F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int DIPIJGHDLNE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6771D70", Offset = "0x6770770", VA = "0x186771D70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6771F90", Offset = "0x6770990", VA = "0x186771F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OCAGAFPJIOB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6771BE0", Offset = "0x67705E0", VA = "0x186771BE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6771F60", Offset = "0x6770960", VA = "0x186771F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GNMEONFECFB HFLHFFEHFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6771F50", Offset = "0x6770950", VA = "0x186771F50")]
		get
		{
			return default(GNMEONFECFB);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6771BD0", Offset = "0x67705D0", VA = "0x186771BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte ELBNJADKBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6771F80", Offset = "0x6770980", VA = "0x186771F80")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6771F30", Offset = "0x6770930", VA = "0x186771F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OGLGCOHOEPA NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6771FA0", Offset = "0x67709A0", VA = "0x186771FA0")]
		get
		{
			return default(OGLGCOHOEPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x67721F0", Offset = "0x6770BF0", VA = "0x1867721F0")]
	public OFOOBONMNLC(IList<Mesh> PMMMOPOAEHG, IList<Matrix4x4> ILMHAIKBKKP, IList<bool> ELIMPKJEPNP, byte GHHAMCLNJHM, IList<byte[]> FFDICJIFLNJ, IList<int> ECLOBPKDDJL, IList<bool> MLACCLNDBHG, IList<int> HICAHCGIPFN, IList<int> FIBPFBMKFIN, IList<int> MPPIEEAMPNA, Allocator CHDJMCMMMLJ, GNMEONFECFB FJPGPFOHGJM, bool HFIBACDLHOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6771D80", Offset = "0x6770780", VA = "0x186771D80")]
	public PMKDNEGPHEH GPNBBLPGFJJ(Allocator CHDJMCMMMLJ, DLFECEDNMGA ACHCCBNIADG)
	{
		return default(PMKDNEGPHEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6771BF0", Offset = "0x67705F0", VA = "0x186771BF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[OJAAPNLEIHM]
public class JICOPEPGBDM : BAAPDJDFOIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool CBOJCFFDOFO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker ECIHJJGKJPD;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x676F550", Offset = "0x676DF50", VA = "0x18676F550")]
	public OFOOBONMNLC JOEHHKCEINB()
	{
		return default(OFOOBONMNLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x676F810", Offset = "0x676E210", VA = "0x18676F810")]
	public JICOPEPGBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OGLGCOHOEPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData FOELLJABMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> DNDAHKKDOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> PCNDIKABGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int OHAIFHPBCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 FEKAGFEPGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int GMBFGCEDECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> DBKJBDCMJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool BHOIFJIAHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int DCIHOPOCBJK;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HIOPMNHGHAD : LJPKHPDDJGG
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class PBNAAKGJKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly NMIPMBEMGJG DAAMBABJLBO;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public virtual bool FBAHMJCOFAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public virtual bool AKPAALEDFDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual DPBKAJAMMON.JBNKIJKKBDP GMBFGCEDECP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "6")]
			get
			{
				return default(DPBKAJAMMON.JBNKIJKKBDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IPHFAOGAOKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x14C4930", Offset = "0x14C3330", VA = "0x1814C4930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool NOJHKHJKLBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x67733D0", Offset = "0x6771DD0", VA = "0x1867733D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool BKGCMNNOOON
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x67733E0", Offset = "0x6771DE0", VA = "0x1867733E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		protected PBNAAKGJKHF(NMIPMBEMGJG NLOFGPCJIFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract OABICBNODGM MLNMPHDGJJF(int[] NFFJJJJIMPO, List<IABENFAMAOM> LDBBGMCPCML, List<IABENFAMAOM> PDBHGKPPEDJ);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract KJOCJOAHANM IEANLOBMFOO(uint JMKELNHPPCF, AvatarSkinnedMeshBoneOrderRemapsData JDNGGLBFDLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class PEIPJPBCCAH : PBNAAKGJKHF
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class NEJIFLKANJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public GBMNPHMLGKB<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public PEIPJPBCCAH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public NEJIFLKANJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x67715A0", Offset = "0x676FFA0", VA = "0x1867715A0")]
			internal void EJBEMEBAPJI(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly AvatarSkinAssetItem.LDDHCLGGBEN EAOIDCDEADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly AssetReference KMOGLONBDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly DPBKAJAMMON.JBNKIJKKBDP DCIJDDKIOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly CIJBFEOBFPG? IBLIPMCFPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly Material[] JLAEHCBCPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private SkinnedMeshRenderer[] CPABLMGJDAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private AvatarSkinAssetItem DCJKKEKKLIH;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DPBKAJAMMON.JBNKIJKKBDP GMBFGCEDECP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851280", VA = "0x180852880", Slot = "6")]
			get
			{
				return default(DPBKAJAMMON.JBNKIJKKBDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6773A30", Offset = "0x6772430", VA = "0x186773A30")]
		public PEIPJPBCCAH(AvatarSkinAssetItem.LDDHCLGGBEN MNFNGNGFKBG, AssetReference CJLEPKNFNOK, Material GILFLFFMNJC, NMIPMBEMGJG IKLHFGHGNGC, DPBKAJAMMON.JBNKIJKKBDP LPNIGDLFGIN = (DPBKAJAMMON.JBNKIJKKBDP)0, [Optional] CIJBFEOBFPG? DMHPFHPLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6773920", Offset = "0x6772320", VA = "0x186773920")]
		public PEIPJPBCCAH(AvatarSkinAssetItem.LDDHCLGGBEN MNFNGNGFKBG, AssetReference CJLEPKNFNOK, Material GILFLFFMNJC, DPBKAJAMMON.JBNKIJKKBDP LPNIGDLFGIN = (DPBKAJAMMON.JBNKIJKKBDP)0, [Optional] CIJBFEOBFPG? DMHPFHPLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x67736E0", Offset = "0x67720E0", VA = "0x1867736E0", Slot = "7")]
		public override OABICBNODGM MLNMPHDGJJF(int[] NFFJJJJIMPO, List<IABENFAMAOM> LDBBGMCPCML, List<IABENFAMAOM> PDBHGKPPEDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6773400", Offset = "0x6771E00", VA = "0x186773400", Slot = "8")]
		public override KJOCJOAHANM IEANLOBMFOO(uint JMKELNHPPCF, AvatarSkinnedMeshBoneOrderRemapsData JDNGGLBFDLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x67738B0", Offset = "0x67722B0", VA = "0x1867738B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class JGNBJDJJJOA : PBNAAKGJKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly EFAADAJCLPJ NAEDPBEKGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private GBMNPHMLGKB<PFDGDHGOBNO> MFENNFLBOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public PFDGDHGOBNO IHGOOCJKPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private GBMNPHMLGKB<Material[]> ANKPIFBKEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public List<Material> ICBICMLPICB;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool FBAHMJCOFAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool AKPAALEDFDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x676EB80", Offset = "0x676D580", VA = "0x18676EB80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D2DA20", Offset = "0x1D2C420", VA = "0x181D2DA20")]
		public JGNBJDJJJOA(NMIPMBEMGJG NLOFGPCJIFE, EFAADAJCLPJ MEADPGHDIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x676EF50", Offset = "0x676D950", VA = "0x18676EF50", Slot = "7")]
		public override OABICBNODGM MLNMPHDGJJF(int[] NFFJJJJIMPO, List<IABENFAMAOM> LDBBGMCPCML, List<IABENFAMAOM> PDBHGKPPEDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x676EA50", Offset = "0x676D450", VA = "0x18676EA50", Slot = "8")]
		public override KJOCJOAHANM IEANLOBMFOO(uint JMKELNHPPCF, AvatarSkinnedMeshBoneOrderRemapsData JDNGGLBFDLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x676E860", Offset = "0x676D260", VA = "0x18676E860")]
		public KJOCJOAHANM EODLAPCDPIL(GameObject HAIDJCMMNJE, uint JMKELNHPPCF, bool KIIIFOCLGIP, bool HMMJGIGIODK, AvatarSkinnedMeshBoneOrderRemapsData JDNGGLBFDLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x676EBE0", Offset = "0x676D5E0", VA = "0x18676EBE0")]
		public static bool KGBCIOBPOLN(Renderer[] OGJOAEGIENG, string DEDIMOCCFCO, [Out] Renderer KOCMGDJLEKP, [Out] Renderer HDBILFEDIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x676F500", Offset = "0x676DF00", VA = "0x18676F500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x676F430", Offset = "0x676DE30", VA = "0x18676F430")]
		private (GBMNPHMLGKB<PFDGDHGOBNO>, GBMNPHMLGKB<Material[]>) OGFPIBBAKFB()
		{
			return default((GBMNPHMLGKB<PFDGDHGOBNO>, GBMNPHMLGKB<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x429E8F0", Offset = "0x429D2F0", VA = "0x18429E8F0")]
		[CompilerGenerated]
		private void ICMPMDNALLD(PFDGDHGOBNO ADPMAHMCGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x676E800", Offset = "0x676D200", VA = "0x18676E800")]
		[CompilerGenerated]
		private void APMJBCOOIMI(Material[] ADPMAHMCGNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DABBPGHGJMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public HIOPMNHGHAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public HBGKBCMOMOE buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public DABBPGHGJMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6761470", Offset = "0x675FE70", VA = "0x186761470")]
		internal void BALEIELEPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6761520", Offset = "0x675FF20", VA = "0x186761520")]
		internal void JAJNLEHIMHH(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6761490", Offset = "0x675FE90", VA = "0x186761490")]
		internal void EBKNBKPOIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6761540", Offset = "0x675FF40", VA = "0x186761540")]
		internal void MFOFOOFPBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
		internal OABICBNODGM ILDGPCCLMNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IFDNJHJJKLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public DABBPGHGJMM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IFDNJHJJKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x676E6F0", Offset = "0x676D0F0", VA = "0x18676E6F0")]
		internal AAHJJDJBBBG PEGDJJDMKLH(int lod)
		{
			return default(AAHJJDJBBBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DJBDODNJHDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<HBGKBCMOMOE> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public DJBDODNJHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x67615D0", Offset = "0x675FFD0", VA = "0x1867615D0")]
		internal void GHAKCMEDGLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HKGLGEFINHH : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public HIOPMNHGHAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<PBNAAKGJKHF> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public List<HBGKBCMOMOE> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Func<int, AAHJJDJBBBG> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public JCFGHMPOJGM materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public HKGLGEFINHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x676E410", Offset = "0x676CE10", VA = "0x18676E410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x676E620", Offset = "0x676D020", VA = "0x18676E620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JAOJIPFKNOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public HIOPMNHGHAD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public JAOJIPFKNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x676E7B0", Offset = "0x676D1B0", VA = "0x18676E7B0")]
		internal OABICBNODGM IJPEPNLEHFN(PBNAAKGJKHF p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PMLBAGHFCII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public FKLBBJCBHCC cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PMLBAGHFCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9440", Offset = "0x8A7E40", VA = "0x1808A9440")]
		internal void ACJNFIHPBPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA2C5D0", Offset = "0xA2AFD0", VA = "0x180A2C5D0")]
		internal void KMAIHIHJNFA(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HPFNHIEIGAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public HIOPMNHGHAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public HPFNHIEIGAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class KHOMKOLHFEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public PMKDNEGPHEH defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public OFOOBONMNLC defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HPFNHIEIGAG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KHOMKOLHFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x676F820", Offset = "0x676E220", VA = "0x18676F820")]
		internal void IFNIBIBIHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA303C0", Offset = "0xA2EDC0", VA = "0x180A303C0")]
		internal void LLOODBFFKGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OBINLLLLELI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public HHGHLBHJHGC legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JAFHMCOFADM legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public HPFNHIEIGAG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public OBINLLLLELI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6771990", Offset = "0x6770390", VA = "0x186771990")]
		internal void OOBFIDLKFLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA33480", Offset = "0xA31E80", VA = "0x180A33480")]
		internal void NPHFACDDMBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class ANILNNGJOJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public FKLBBJCBHCC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public EFAADAJCLPJ avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public HIOPMNHGHAD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public ANILNNGJOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x675E8A0", Offset = "0x675D2A0", VA = "0x18675E8A0")]
		internal OABICBNODGM FCPNCKLHPPE(LFDCJCJMMGM item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x675EC50", Offset = "0x675D650", VA = "0x18675EC50")]
		internal void KHIGGPOGCPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class GNEBLDMOLIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public GBMNPHMLGKB<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public GNEBLDMOLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6761700", Offset = "0x6760100", VA = "0x186761700")]
		internal void DHBHCHCOPMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class IAKMNMMPEHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public NMIPMBEMGJG overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IAKMNMMPEHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x676E670", Offset = "0x676D070", VA = "0x18676E670")]
		internal bool HCMCCDMHMHD(KeyValuePair<string, EFAADAJCLPJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration BGICIJKNPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform CNPDKLICJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference KMOGLONBDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject NHDCIAMEDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject ILFDHEINHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer CEOJEKAHFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData MOCIEKKAIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] DINFLLMCBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] DMFGLLOJGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material EEIBEKEBFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material CLKJNGHHGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material HFGBIFDPNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader NGJMPEDHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader IPOKGKNCDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator EOAGJJJPALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] FBDANOIJOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private DPBKAJAMMON.JBNKIJKKBDP AIMIJAAMOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager KBOMOKLPDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> JFDFADIIDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.MPOFJCBKJIF KFHIAKDCDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.KKCOJCGPCLF IJAOKOAEAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool CDGMIPNCEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool JBDDPLNHLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color AEDMGDDNEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color GJIINNJEBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color EJJKLMNDDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? CCIIIHNAELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? KBNOLDHJNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? BGMAFHJFJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? CJLDBMFGMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D HMDEMKLKHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D JGPMIBLHLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private EFAADAJCLPJ JKCHMFBFNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture OLBDANJCAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color MMLJKNCMDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, JCFGHMPOJGM> AOBGKNCDMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, JCFGHMPOJGM> MPJGEIDAAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<CMHENJFEHOI>> AMEEMPIAJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<CMHENJFEHOI>> FGLDDOPKIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<IABENFAMAOM> MFOLPKINIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<IABENFAMAOM> OKEGOAKKLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<IABENFAMAOM> OIDOEKCJFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<IABENFAMAOM> CNDJAOPKAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<CMHENJFEHOI, Material> ECMOBAKKDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<CMHENJFEHOI, Material> KPLMBMIJPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] LMOCDAJNKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] KLHOKIFBMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] BEIPIGHMJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] CADIFHDKOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, GBMNPHMLGKB<Texture2D>> OELADKDEEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, GBMNPHMLGKB<Texture2D>> LAAKKMMOAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private FitMeshHemisphere HEIHIIIDABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool LAPPEMMEIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private GOLAHOGMBDI JNPMOCKPPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool ACLHMPLJHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AnchorParamsRestrictions CADJJAAMFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool GKBIPFOHBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Transform EONKLIHFHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Transform OEHJJDDMCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool LIPOHMNKOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool FBDFIDBEPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Vector3 DGABPBDBJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Quaternion PKEKEPABJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Vector2 AKFPDCHFNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private FitMeshHemisphere ADBKICEPDPK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material AJBNPPJCDAC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Material AFICEDCBNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<string, EFAADAJCLPJ> KLPCBHPMPPH;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int NALDEKLIJMN;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int CFDCLLCIPGD;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int AAGNNMHBONG;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int MJIAHJDEHAH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int CJALDIFLPJK;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int PPDBFNNCIMD;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int LDLNFEHGCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly EHODCIMNDCH DHJNJGBMFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly EHODCIMNDCH LHMMMFBHIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool PCLNLPEGOKK;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static Lazy<PMIHDANGMFM> CKHMLLCLNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Lazy<MHKMFCOCHAP> EDIJCHIEDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Lazy<CCIAMLADOEA> HKBIHKBAADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private NICHJPMKMDF BLEKBGCPHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private FJDMGDBCEIP IIPBPEJBBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private List<Action> BIGMPCNPOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private OFKHGODDDHI BAMEENABNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private SkinnedMeshRenderer[] DILJCKIFMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int ONJJKHMBCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool MMGIBCJFLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private int GIOCNNKJCNA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LGGINJHAOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x190C4C0", Offset = "0x190AEC0", VA = "0x18190C4C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x18F9ED0", Offset = "0x18F88D0", VA = "0x1818F9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LIMIMALNKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x67659E0", Offset = "0x67643E0", VA = "0x1867659E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material JBDACDBGEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6761750", Offset = "0x6760150", VA = "0x186761750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material AHJJGDOLIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6769500", Offset = "0x6767F00", VA = "0x186769500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool GCJGIKJCMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public FCPIIIBEPDH GANCAJJMOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EC0", Offset = "0x8C28C0", VA = "0x1808C3EC0", Slot = "21")]
		get
		{
			return default(FCPIIIBEPDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool BPLNHOJNDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x676CDC0", Offset = "0x676B7C0", VA = "0x18676CDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private static PMIHDANGMFM KHLLEDBKIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6766D90", Offset = "0x6765790", VA = "0x186766D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private MHKMFCOCHAP ELINHKLJNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6761DC0", Offset = "0x67607C0", VA = "0x186761DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private CCIAMLADOEA ACDJHAGGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x676CF00", Offset = "0x676B900", VA = "0x18676CF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private NICHJPMKMDF DOFIDBNKPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6769A70", Offset = "0x6768470", VA = "0x186769A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private FJDMGDBCEIP FIANHDNOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x676D820", Offset = "0x676C220", VA = "0x18676D820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EHODCIMNDCH NPAPPGLKGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA0CDA0", Offset = "0xA0B7A0", VA = "0x180A0CDA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public EHODCIMNDCH BMOCGEAPLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x13D7E50", Offset = "0x13D6850", VA = "0x1813D7E50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public SkinnedMeshRenderer[] JJFJAMBKPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x12E00A0", Offset = "0x12DEAA0", VA = "0x1812E00A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Renderer[] GGNIFLBHLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x85FE70", Offset = "0x85E870", VA = "0x18085FE70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool CHAKJAOEKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x676D0E0", Offset = "0x676BAE0", VA = "0x18676D0E0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DPBKAJAMMON.JBNKIJKKBDP DEDFHIDAGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x85FE30", Offset = "0x85E830", VA = "0x18085FE30", Slot = "18")]
		get
		{
			return default(DPBKAJAMMON.JBNKIJKKBDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int HMEONGMOAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x190D720", Offset = "0x190C120", VA = "0x18190D720")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67684C0", Offset = "0x6766EC0", VA = "0x1867684C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool LGFCJHMFGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6761A20", Offset = "0x6760420", VA = "0x186761A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private static bool ENHONLLJFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6764600", Offset = "0x6763000", VA = "0x186764600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool DMLINAMNMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x676CA20", Offset = "0x676B420", VA = "0x18676CA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x676DAF0", Offset = "0x676C4F0", VA = "0x18676DAF0")]
	public HIOPMNHGHAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67684E0", Offset = "0x6766EE0", VA = "0x1867684E0", Slot = "26")]
	public void HMCGAKKBHMB(PCLIHIGPBDC EOBMHGNPJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67669E0", Offset = "0x67653E0", VA = "0x1867669E0", Slot = "27")]
	public void GBGAKFNOANO(JFMKJGFNJLF GLCDBAANOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x67684C0", Offset = "0x6766EC0", VA = "0x1867684C0", Slot = "4")]
	public void HFCGJBGLHKC(int JMKELNHPPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6766A60", Offset = "0x6765460", VA = "0x186766A60", Slot = "9")]
	public void GDJJHEICHGA(OFGNGPMIPGJ AJBECKEBCAN, Texture2D IPABEBMKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x676CD40", Offset = "0x676B740", VA = "0x18676CD40", Slot = "10")]
	public void NOOFMDHAOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67698F0", Offset = "0x67682F0", VA = "0x1867698F0", Slot = "11")]
	public bool JMBCOGMEPGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6765EF0", Offset = "0x67648F0", VA = "0x186765EF0", Slot = "8")]
	public void EMALGMKGMMH(FOIFDKEJMPA DOCPLINHPIO, Color? KIJNHGNFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x676C840", Offset = "0x676B240", VA = "0x18676C840")]
	private void MICMIKFPPOJ(Action PHNKPOHDPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x67655A0", Offset = "0x6763FA0", VA = "0x1867655A0", Slot = "5")]
	public void DMLNOBDOCAI(EFAADAJCLPJ GNCNHHCIKFO, Texture IEKNJHBBHLN, Color KMCGDDCHOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x18F9ED0", Offset = "0x18F88D0", VA = "0x1818F9ED0", Slot = "6")]
	public void JCNGPOOEIKD(bool NFJCBMPJKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x12D95A0", Offset = "0x12D7FA0", VA = "0x1812D95A0", Slot = "7")]
	public void FBPPIFHHEDA(OFKHGODDDHI LDMPLMIKDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6769AF0", Offset = "0x67684F0", VA = "0x186769AF0", Slot = "14")]
	public HBGKBCMOMOE KGIMEMICEPP(LEDCDLLGGBL BHCEDLNADDA, bool ODHKDJIAEEC, int[] LLKJANJINHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6766370", Offset = "0x6764D70", VA = "0x186766370", Slot = "15")]
	public void EOJEBCEEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67618E0", Offset = "0x67602E0", VA = "0x1867618E0")]
	private bool AKOGDBFPPKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85FE20", Offset = "0x85E820", VA = "0x18085FE20", Slot = "19")]
	public void LCEDANIJBBH(DPBKAJAMMON.JBNKIJKKBDP ACOCDFKILDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6767B50", Offset = "0x6766550", VA = "0x186767B50")]
	private bool GIJDJFIAFLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6768F30", Offset = "0x6767930", VA = "0x186768F30")]
	private HBGKBCMOMOE JEFHBENJJBF(bool ODHKDJIAEEC, List<PBNAAKGJKHF> PLPGKJGOCNC, int[] LLKJANJINHI, Func<int, AAHJJDJBBBG> PEOJBOCGNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x676D470", Offset = "0x676BE70", VA = "0x18676D470")]
	[IteratorStateMachine(typeof(HKGLGEFINHH))]
	private IEnumerator<JMPDKMJKKGA> ONFGOKMKFOJ(bool ODHKDJIAEEC, List<PBNAAKGJKHF> PLPGKJGOCNC, int[] LLKJANJINHI, Func<int, AAHJJDJBBBG> PEOJBOCGNOI, JCFGHMPOJGM DBJDFNNLDPO, Material IIKGHMJJEPI, List<HBGKBCMOMOE> CEMBKHIMCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x676BC10", Offset = "0x676A610", VA = "0x18676BC10")]
	private HBGKBCMOMOE LPKFJGKNAFA(List<PBNAAKGJKHF> PLPGKJGOCNC, int[] LLKJANJINHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6761E10", Offset = "0x6760810", VA = "0x186761E10")]
	private GOOHGCNPLOF AOIBMMHBNHN(List<PBNAAKGJKHF> PLPGKJGOCNC, int JMKELNHPPCF, bool ODHKDJIAEEC, AAHJJDJBBBG JLMHPKHAOHJ, bool EMNIPMNGBCG, JCFGHMPOJGM DBJDFNNLDPO, Material IIKGHMJJEPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6768D80", Offset = "0x6767780", VA = "0x186768D80", Slot = "22")]
	public void IDLOOJNIHIF(AvatarFaceShape MNOCGOBJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x676D250", Offset = "0x676BC50", VA = "0x18676D250", Slot = "23")]
	public void OIBAPOKOLOL(AvatarBodyShape GLLKCMAKDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6765240", Offset = "0x6763C40", VA = "0x186765240", Slot = "25")]
	public void DHEBLJLCKKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x676BFC0", Offset = "0x676A9C0", VA = "0x18676BFC0", Slot = "24")]
	public void MDEHOJNBDPB(bool MGBJCOGGOOM, bool FFGHEOMOEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6769680", Offset = "0x6768080", VA = "0x186769680")]
	private void JHHONBFFFAC(SkinnedMeshRenderer ODFJMFEMDEL, int JMKELNHPPCF, Mesh DICFBCCFLEI, List<Material> FJMFFMBIILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6764CB0", Offset = "0x67636B0", VA = "0x186764CB0")]
	private static Material DDEHILFJDPI(Dictionary<CMHENJFEHOI, Material> DDLOAFKGEJB, Material CEKLJJNAFLP, IDNEJHNIOEO PCFFMOAHAAO, PCOOGPNENBN HDBFGOLNBFE, NMIPMBEMGJG IKLHFGHGNGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6766C70", Offset = "0x6765670", VA = "0x186766C70")]
	private static IDNEJHNIOEO GEEAEIJAKCD(PBNAAKGJKHF BFLMNODAICA, int PBJFIAJOOFC)
	{
		return default(IDNEJHNIOEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x676C310", Offset = "0x676AD10", VA = "0x18676C310")]
	private void MGNCOHHOPEE(int ABEOMGGAPKL, Material GIIKGEKINDH, PBNAAKGJKHF BFLMNODAICA, [Out] Texture2D GGFECACAKCL, [Out] Vector4 PIOHIMPAGMB, [Out] Texture2D MMGKFOGEOIL, [Out] Texture2D IAEDCGOJEGD, [Out] Texture2D OPELLMDBHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x67659F0", Offset = "0x67643F0", VA = "0x1867659F0")]
	private void ECHECDHDIGC(int ABEOMGGAPKL, Material GIIKGEKINDH, PBNAAKGJKHF BFLMNODAICA, [Out] Color FDNIDKGGKLL, [Out] Color IBPJCOCMPLN, [Out] Color JJFIFHALOFI, [Out] Color GICAHBIPDBG, [Out] Color BJJDHKDBCNF, [Out] Color KFGEMLIHHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6767E00", Offset = "0x6766800", VA = "0x186767E00")]
	private bool HDLOEPPCKDE(Material GIIKGEKINDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x676CCC0", Offset = "0x676B6C0", VA = "0x18676CCC0")]
	private static Material NOKJPMOFMGC(int ABEOMGGAPKL, JGNBJDJJJOA BFLMNODAICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6761CD0", Offset = "0x67606D0", VA = "0x186761CD0")]
	private static PCOOGPNENBN AMICLCGMBOC(PBNAAKGJKHF BFLMNODAICA, int PBJFIAJOOFC)
	{
		return default(PCOOGPNENBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x676B200", Offset = "0x6769C00", VA = "0x18676B200")]
	private static void KOBLPNACMAK(Dictionary<string, List<CMHENJFEHOI>> NAOKJFLCLAE, PBNAAKGJKHF JCBFGMJDFOB, Material CEKLJJNAFLP, IDNEJHNIOEO DOCPLINHPIO, PCOOGPNENBN AJBECKEBCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6764E10", Offset = "0x6763810", VA = "0x186764E10")]
	private static SkinnedMeshRenderer DELFDELEIND(Transform BHKPGHNPMGG, Transform CIIGKAGNLNN, SkinnedMeshRenderer[] OGJOAEGIENG, int JMKELNHPPCF, AAHJJDJBBBG JLMHPKHAOHJ, bool ODHKDJIAEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x676C140", Offset = "0x676AB40", VA = "0x18676C140")]
	private void MFGEELBJAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x676C130", Offset = "0x676AB30", VA = "0x18676C130")]
	private void MDNJIKMPEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x676D310", Offset = "0x676BD10", VA = "0x18676D310")]
	private static void OKPBGKCKMBC(Dictionary<CMHENJFEHOI, Material> DDLOAFKGEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x676BFD0", Offset = "0x676A9D0", VA = "0x18676BFD0")]
	private static void MDGCGCLBAHJ(Dictionary<Renderer, JCFGHMPOJGM> CFAADCLFONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6765460", Offset = "0x6763E60", VA = "0x186765460")]
	private void DJHOINHCPKF(SkinnedMeshRenderer[] OGJOAEGIENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x676C8E0", Offset = "0x676B2E0", VA = "0x18676C8E0")]
	private void MLALHCHCOAM(SkinnedMeshRenderer GEINJFCFBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6763860", Offset = "0x6762260", VA = "0x186763860")]
	private void AOLPPFHHOKN(List<IABENFAMAOM> NNOPGHBIOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6764B30", Offset = "0x6763530", VA = "0x186764B30")]
	private void DCNFDFNAEGH(Dictionary<string, GBMNPHMLGKB<Texture2D>> NAOKJFLCLAE, bool EBCIKALBMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x67645B0", Offset = "0x6762FB0", VA = "0x1867645B0")]
	private void CHMGFHAPLEP(Dictionary<string, List<CMHENJFEHOI>> NAOKJFLCLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6765040", Offset = "0x6763A40", VA = "0x186765040")]
	private void DFCKKMBLNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x676CF50", Offset = "0x676B950", VA = "0x18676CF50")]
	private void OEFDHKKHEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67687A0", Offset = "0x67671A0", VA = "0x1867687A0")]
	private void HMHILAALMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6761AA0", Offset = "0x67604A0", VA = "0x186761AA0")]
	private void ALEMMKNMGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67695F0", Offset = "0x6767FF0", VA = "0x1867695F0")]
	private void JHDEELFMACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6763DE0", Offset = "0x67627E0", VA = "0x186763DE0")]
	private void BIMGOFOGGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x676B4F0", Offset = "0x6769EF0", VA = "0x18676B4F0")]
	private void LCALFHKDHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x676C980", Offset = "0x676B380", VA = "0x18676C980")]
	private void MNKPBOJGCIH(bool LMKKFGDJBIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6761C00", Offset = "0x6760600", VA = "0x186761C00")]
	private void AMHLCOGLDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x67651A0", Offset = "0x6763BA0", VA = "0x1867651A0")]
	private void DGJIBIHDHDN(bool LMKKFGDJBIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6765610", Offset = "0x6764010", VA = "0x186765610")]
	private void DPPPEBMCBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6766570", Offset = "0x6764F70", VA = "0x186766570")]
	private void EPFEEKICMHO(Material IIKGHMJJEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x676D730", Offset = "0x676C130", VA = "0x18676D730")]
	private void PHMHJAEPGLG(Material IIKGHMJJEPI, Color IBPJCOCMPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6768E40", Offset = "0x6767840", VA = "0x186768E40")]
	private void IPGAFIMGLBL(Material IIKGHMJJEPI, Color JJFIFHALOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x676B110", Offset = "0x6769B10", VA = "0x18676B110")]
	private void KLHJEIFJOON(Material IIKGHMJJEPI, Color FDNIDKGGKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x676BED0", Offset = "0x676A8D0", VA = "0x18676BED0")]
	private void MCIHBIDFKJN(Material IIKGHMJJEPI, Texture2D IPABEBMKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x676C750", Offset = "0x676B150", VA = "0x18676C750")]
	private void MGNIFCNKGNA(Material IIKGHMJJEPI, Texture HLJMHJMJPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6767990", Offset = "0x6766390", VA = "0x186767990")]
	private void GHPNPDBCCFH(Action<JCFGHMPOJGM> NEEHCPBKJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x676D580", Offset = "0x676BF80", VA = "0x18676D580")]
	private void PBJGFMPLCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x67647A0", Offset = "0x67631A0", VA = "0x1867647A0")]
	private void CPKCEKHGKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x676B5C0", Offset = "0x6769FC0", VA = "0x18676B5C0")]
	private HBGKBCMOMOE LLPCNMEAJGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x67680F0", Offset = "0x6766AF0", VA = "0x1867680F0")]
	private void HEMFJGOJIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6764160", Offset = "0x6762B60", VA = "0x186764160")]
	public void CBPOGAKODJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x67668E0", Offset = "0x67652E0", VA = "0x1867668E0")]
	private void FCOKJDNCIFG(Vector3 PHJFFHJCDOD, Quaternion OILJGEIJHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6763A40", Offset = "0x6762440", VA = "0x186763A40")]
	private void BBODEAJDDDJ(List<PBNAAKGJKHF> BFFLCBOBKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6767490", Offset = "0x6765E90", VA = "0x186767490")]
	public void GGKDHJFNGEE(GOLAHOGMBDI NNMMPJLDIFI, bool LFFNKFIILIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6766E10", Offset = "0x6765810", VA = "0x186766E10")]
	public void GGKDHJFNGEE(GOLAHOGMBDI NNMMPJLDIFI, AnchorParamsRestrictions MOHDKCNMCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9F7340", Offset = "0x9F5D40", VA = "0x1809F7340")]
	private static void DFBJPMPCKAF(FitMeshHemisphere ENNLBIHIFOG, Transform OBAFGKLCEOA, GOLAHOGMBDI NNMMPJLDIFI, AnchorParamsRestrictions CEFLPIJDIKH, [Out] Vector3 NJGBBMKGAPK, [Out] Quaternion IJKPBDDGPGD, [Out] GOLAHOGMBDI GGFOCCEAGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6767C40", Offset = "0x6766640", VA = "0x186767C40")]
	public void GMHDJHGBBDM(Vector2 IJOPGECCBLF, Vector3 JMJBCJHHIMN, Vector3 FGHENCLBGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6763F60", Offset = "0x6762960", VA = "0x186763F60")]
	private void BLNOIEPJFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6768060", Offset = "0x6766A60", VA = "0x186768060")]
	private void HEIGIFHGEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67697D0", Offset = "0x67681D0", VA = "0x1867697D0")]
	[CompilerGenerated]
	private void JIKCLGOIOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x676BBE0", Offset = "0x676A5E0", VA = "0x18676BBE0")]
	[CompilerGenerated]
	private void LOIAHCHEHOJ(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6761B70", Offset = "0x6760570", VA = "0x186761B70")]
	[CompilerGenerated]
	private void AMFIHKGKBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x676C8C0", Offset = "0x676B2C0", VA = "0x18676C8C0")]
	[CompilerGenerated]
	private void MKLFJPGDHML(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6765950", Offset = "0x6764350", VA = "0x186765950")]
	[CompilerGenerated]
	private void EAKKNPBJIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6765580", Offset = "0x6763F80", VA = "0x186765580")]
	[CompilerGenerated]
	private void DLKOMCFHGBF(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6766950", Offset = "0x6765350", VA = "0x186766950")]
	[CompilerGenerated]
	private void FONCIHIOPHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x67644F0", Offset = "0x6762EF0", VA = "0x1867644F0")]
	[CompilerGenerated]
	private void CDGOKMIJCJH(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6768CF0", Offset = "0x67676F0", VA = "0x186768CF0")]
	[CompilerGenerated]
	private void HPLMIPKMOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x676BBB0", Offset = "0x676A5B0", VA = "0x18676BBB0")]
	[CompilerGenerated]
	private void LNPAEABGNKI(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6764520", Offset = "0x6762F20", VA = "0x186764520")]
	[CompilerGenerated]
	private void CDJENBODEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6767C10", Offset = "0x6766610", VA = "0x186767C10")]
	[CompilerGenerated]
	private void GLEKPJAAEKO(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6769860", Offset = "0x6768260", VA = "0x186769860")]
	[CompilerGenerated]
	private void JKEPOEDMDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6763F30", Offset = "0x6762930", VA = "0x186763F30")]
	[CompilerGenerated]
	private void BIOPEOIEEOH(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x67662F0", Offset = "0x6764CF0", VA = "0x1867662F0")]
	[CompilerGenerated]
	private void EMHPFAMJLDA(KeyValuePair<string, GBMNPHMLGKB<Texture2D>> HDDCDBLOLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x67640D0", Offset = "0x6762AD0", VA = "0x1867640D0")]
	[CompilerGenerated]
	private void BNOKPIEABML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6764B00", Offset = "0x6763500", VA = "0x186764B00")]
	[CompilerGenerated]
	private void DCGHMNCKNMK(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x676CC30", Offset = "0x676B630", VA = "0x18676CC30")]
	[CompilerGenerated]
	private void NFHPPHKPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x676D700", Offset = "0x676C100", VA = "0x18676D700")]
	[CompilerGenerated]
	private void PGILAPDJBNL(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CHOCPCMEKIB : BFEGAKELAJO
{
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int KPJLDBNICKD;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int ILCOLFGCHME;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int LIOCIIFIMFD;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int DLAPJNPPOMF;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int BFMNJIODMOI;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int BOGJNPGNFPI;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int DIKADDFPJKA;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int NFDEIEMALIG;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int EFDGEKOEOFC;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int FFBEJBHMCBC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int JEDJNMGEMNN;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int IEMLDJOBBLD;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int BILFHOGAHJH;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int EJAFIDLMION;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int DGPAODDEALG;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int DFAOFCCHEII;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int BFGEKDMEHIJ;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int DJKAHGLGJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform JLHPFINBMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform FJCJIBEHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform AKAMDBNOPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform CNKLCDLPDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform AADCMJMLPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform OOGFPOKIJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Transform NEJMPDFONMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private DNDGIEPGFML MGDFENEAJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private MaterialPropertyBlock LKBBBFHOMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private SkinnedMeshRenderer[] LBOPBOMIMGP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MaterialPropertyBlock OODPLELICIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6760E50", Offset = "0x675F850", VA = "0x186760E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HPJBMFGHLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6760F60", Offset = "0x675F960", VA = "0x186760F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6760D90", Offset = "0x675F790", VA = "0x186760D90", Slot = "7")]
	public void HMCGAKKBHMB(DNDGIEPGFML KJNCKGILAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x675F350", Offset = "0x675DD50", VA = "0x18675F350", Slot = "8")]
	public void AAGGJKGLFEP(GBJONGNNFPA HNHJMAFBDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x675F6D0", Offset = "0x675E0D0", VA = "0x18675F6D0", Slot = "5")]
	public void CDFHGFJFMMO(IHEGNEEOHJB OIJKNNIAIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6760C50", Offset = "0x675F650", VA = "0x186760C50")]
	private Vector2 DDIFKCMLFPD(Vector2 POEDMBBLNID)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x675FB00", Offset = "0x675E500", VA = "0x18675FB00", Slot = "6")]
	public void CJJNCINNIPG(DCFHDECNJAL HNHJMAFBDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x675F380", Offset = "0x675DD80", VA = "0x18675F380")]
	private void BDAKMJLDKGM(DCFHDECNJAL CNKCOGJJMDL, ALBKENOMFOK BCAJDJKHFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6760CB0", Offset = "0x675F6B0", VA = "0x186760CB0")]
	private void DJAGNMAEBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6761410", Offset = "0x675FE10", VA = "0x186761410")]
	public CHOCPCMEKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6760ED0", Offset = "0x675F8D0", VA = "0x186760ED0")]
	[CompilerGenerated]
	internal static (float, float) MLBFDPLIICO(float JBPKKAKBAND)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6760C10", Offset = "0x675F610", VA = "0x186760C10")]
	[CompilerGenerated]
	internal static Vector4 DCCFOMEHLMD(Vector2 HGDCPNGLIKJ, Vector2 CDPPGBMBKAI)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JCFGHMPOJGM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private MaterialPropertyBlock NAMOAHACINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Color? KENDPMGLLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Color? GAKDJGEOJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Color? EOPENEAKGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Color? EKENJMKAEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Color GIBADOAPOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Color GPPGPGBNOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Color DECPBAMEJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Texture2D PCDKNHNLKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Texture2D AHHBBMJAHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Dictionary<CMHENJFEHOI, int> NIDIHFKKIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private IDNEJHNIOEO[] FCLGHBDAHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private PCOOGPNENBN[] MPCIEDCKALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4[] MCCGKKJMJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4[] MHOIJOGCIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4[] FMLJAAOGGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector4[] JBDFPEPPKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Vector4[] DIMCAJMKFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public Vector4[] HJJPFONFDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private List<Texture2D> NEJLHNPDAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Vector4[] FOMAGBKPPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private List<Texture2D> JAFFHBLNIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private float[] MALMNKCDFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private Vector4[] EEIBIEDENOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private float[] BKMGOIGMECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public float[] MPOJEJEFBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private List<Texture2D> FPAHBPJDKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private float[] HINEHCOPONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private List<Texture2D> HDNBCCKNGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Vector4[] LBOPBJELJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private float[] KFCDADNBPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private Vector4[] FHMBEKJFDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float[] LGADFLFELNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Texture2DArray HMIJFAHPPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Texture2DArray LPFCICACIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Texture2DArray OBAHINMLBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public Texture2DArray JNDEGAGFJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool OHKMKPOOFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private int JGHGMEPCGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private Vector2? DOFHJFPHFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private TextureFormat OAFMANDKFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private Vector2? MEOEAADGHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private TextureFormat PAPJCJALMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private Vector2? DBLOLILAFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private TextureFormat GDMPCMOHAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Vector2? HJFEMJECOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private TextureFormat FHJEBBGBNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private bool MAFFMBBADNE;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int JDNEMKDGIBM;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int AMPKBOJFHEA;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int JKKLIIJGEHN;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int GNDNAHGOOAA;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int MIMFEMOINHB;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int FGDGDLIPHPD;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int HEBEEKKKPOA;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int NMCECAFPLDP;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int ENHJDGJLCDK;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int AFBNAIAMLMA;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int AAKLNJHMNIK;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int DAIALPIJHJK;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int HAOOOFDFDOP;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int HPOKFCKNPEP;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int DFJIDKMIDJN;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int NOOKLMDMANB;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int EHNFKMGAMOH;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static int OHGNEHKIIIC;

	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private static int KPLFDADIIMH;

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static int FLFNLJAJEEB;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6780800", Offset = "0x677F200", VA = "0x186780800")]
	private JCFGHMPOJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6780740", Offset = "0x677F140", VA = "0x186780740")]
	public JCFGHMPOJGM(Color JKINDAGENFE, Color JNFOKIPIGLJ, Color AIFKEMOPKJL, Color? KDEDBHJBFND, Color? AGGNNOHCNDM, Color? NHBNJPLMIML, Texture2D BLEICALDIAF, Texture2D PDPLBINDDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x677FCC0", Offset = "0x677E6C0", VA = "0x18677FCC0")]
	internal int IIDLJDGOFJD(Material CFLFHCBFGIE, IDNEJHNIOEO PCFFMOAHAAO, PCOOGPNENBN HDBFGOLNBFE, NMIPMBEMGJG IKLHFGHGNGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x677FDB0", Offset = "0x677E7B0", VA = "0x18677FDB0")]
	private int IIDLJDGOFJD(CMHENJFEHOI NDDCLPHCEEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x677E210", Offset = "0x677CC10", VA = "0x18677E210")]
	internal int BGJAPKKKFFC(Material CFLFHCBFGIE, Color FDNIDKGGKLL, Color IBPJCOCMPLN, Color JJFIFHALOFI, Color GICAHBIPDBG, Color BJJDHKDBCNF, Texture2D IMKEJGFFEJD, Vector4 IPBIIJEEMPB, Texture2D FJPAONAMPBK, Vector4 LFGIOGOJEBG, float KFPECIJPNBH, float OHLHIOKOLNB, Texture2D OHDGIFMBMOB, Vector4 BLMIDEAHLFN, float OOKNEOJANOA, Texture2D KFEKOCKLMCH, Color KFGEMLIHHME, Vector4 KHPKKHCDFMG, IDNEJHNIOEO PCFFMOAHAAO, PCOOGPNENBN HDBFGOLNBFE, NMIPMBEMGJG IKLHFGHGNGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x677FE40", Offset = "0x677E840", VA = "0x18677FE40")]
	private void KHLDHAKGGLE(List<Texture2D> NEJLHNPDAMC, [Out] Texture2DArray IMCGLDDHJGJ, [Out] Texture2DArray HIOMELIOCAO, [Out] Texture2DArray FDHBLOMAMGM, [Out] Texture2DArray FLKOADLCBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x677E0C0", Offset = "0x677CAC0", VA = "0x18677E0C0")]
	public void APBJAFGCPKP(Shader HCNOMBIEHDM, Renderer GHBIMLIJLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x677EF30", Offset = "0x677D930", VA = "0x18677EF30")]
	private void DMPADAKKOII(Shader HCNOMBIEHDM, Renderer GHBIMLIJLGK, int AGMAGNELEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67801B0", Offset = "0x677EBB0", VA = "0x1867801B0")]
	private Color PCHHLGCFHOF(Color GKKPNEFMHBD, IDNEJHNIOEO DOCPLINHPIO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x677EDE0", Offset = "0x677D7E0", VA = "0x18677EDE0")]
	private Color CFFPKBEDKFF(Color LNFDKOOHPAM, IDNEJHNIOEO DOCPLINHPIO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x67800B0", Offset = "0x677EAB0", VA = "0x1867800B0")]
	private bool NEHAEHDFHEA(Texture2D IFGLGGOMOPL, PCOOGPNENBN AJBECKEBCAN, [Out] Texture2D GPLDJLDKFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6780000", Offset = "0x677EA00", VA = "0x186780000")]
	private void KIHDJPLCNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x677FC80", Offset = "0x677E680", VA = "0x18677FC80", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private IKDKKLKECDH? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public NPONJLDPMAN CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6777D60", Offset = "0x6776760", VA = "0x186777D60")]
			get
			{
				return default(NPONJLDPMAN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IKDKKLKECDH MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6777DB0", Offset = "0x67767B0", VA = "0x186777DB0")]
			get
			{
				return default(IKDKKLKECDH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x856BA0", Offset = "0x8555A0", VA = "0x180856BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x85FD30", Offset = "0x85E730", VA = "0x18085FD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x67779E0", Offset = "0x67763E0", VA = "0x1867779E0")]
		public Material[] BFIIEPOHMGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6777AD0", Offset = "0x67764D0", VA = "0x186777AD0")]
		public static void IELLBPLJIFD(AvatarItemMaterial PKACLIAFEPJ, Material GIIKGEKINDH, int ABEOMGGAPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6777C90", Offset = "0x6776690", VA = "0x186777C90")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[OJAAPNLEIHM]
public struct BILPCMFMMPK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[ReadOnly]
	public JAFHMCOFADM EIONCDLBHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[ReadOnly]
	public int JPNEAEFEHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public HHGHLBHJHGC FNEKPNADEHB;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6777E70", Offset = "0x6776870", VA = "0x186777E70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[OJAAPNLEIHM]
[NativeContainer]
public struct HHGHLBHJHGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector3> PCCMAMFAHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector3> JDGBACHKNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector4> KKMEEHMLFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> IKMIIPIICMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Vector2> PMMFPJFCMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<Vector2> CFCCLGAEECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<Vector2> CNECALJHCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<Color> LELAJPCGINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<int> FBGCIOJNDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<int> GLDKADLKPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private NativeArray<int> JPBNFIOGBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private NativeArray<int> EKDCPKBFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<int> GBKIDOIHGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<int> KDAFMAACIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<int> FAEMCMMIHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<BoneWeight> KNILEEOHBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private NativeArray<int> LDMPLMIKDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private bool BEHCNKCKEMO;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int DIPIJGHDLNE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x677B160", Offset = "0x6779B60", VA = "0x18677B160")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x677B770", Offset = "0x677A170", VA = "0x18677B770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int CFFONAKGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x677B6B0", Offset = "0x677A0B0", VA = "0x18677B6B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x677AD50", Offset = "0x6779750", VA = "0x18677AD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int HBMDLLOJIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x677AF30", Offset = "0x6779930", VA = "0x18677AF30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x677AD80", Offset = "0x6779780", VA = "0x18677AD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x677B780", Offset = "0x677A180", VA = "0x18677B780")]
	public HHGHLBHJHGC(int JPGPFGMDFFJ, int JOAOBPKBJPK, int OFICJAKPOPC, int ENKLOOOFMNC, Allocator CHDJMCMMMLJ, int LKHEAAKNHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x677B0F0", Offset = "0x6779AF0", VA = "0x18677B0F0")]
	public void EDDLNIEMBEB(int DHNLEFJCEAH, Vector3 NJJHKDBJDAC, Vector3 IPBCPNHEHBB, Vector4 DOGPFNGIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x677AD90", Offset = "0x6779790", VA = "0x18677AD90")]
	public void DDMBNNDLMDO(int DHNLEFJCEAH, BoneWeight CLPIOJNHBDJ, NativeSlice<byte> DBKJBDCMJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x677AD60", Offset = "0x6779760", VA = "0x18677AD60")]
	public Color CIPADPJBGGE(int DHNLEFJCEAH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x677AD30", Offset = "0x6779730", VA = "0x18677AD30")]
	public void ABEFFJMJNGG(int DHNLEFJCEAH, Color DDJHOHBDMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x677B170", Offset = "0x6779B70", VA = "0x18677B170")]
	public void HDMLHMIPCGG(byte BKALJKAMJJI, int DHNLEFJCEAH, Vector2 EMLOHHMFJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x677B320", Offset = "0x6779D20", VA = "0x18677B320")]
	public void KAFEMIOCBEL(int DHNLEFJCEAH, int EDFEBNBLMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x677B680", Offset = "0x677A080", VA = "0x18677B680")]
	public bool MBKPEHHBCJO(int BKALJKAMJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x677B250", Offset = "0x6779C50", VA = "0x18677B250")]
	public void HKLOKJAPOPO(int MJDDAIDLEAO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x677B6C0", Offset = "0x677A0C0", VA = "0x18677B6C0")]
	public int[] ODKFFGGLMOE(int MJDDAIDLEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x677B1C0", Offset = "0x6779BC0", VA = "0x18677B1C0")]
	private NativeSlice<int> HIAAMJIGNJN(int MJDDAIDLEAO)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x677AF40", Offset = "0x6779940", VA = "0x18677AF40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x677B330", Offset = "0x6779D30", VA = "0x18677B330")]
	public Mesh LKECLIMBOCL([Optional] string IJCHBIMDHCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[OJAAPNLEIHM]
[NativeContainer]
[DefaultMember("Item")]
public struct JAFHMCOFADM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector3> PCCMAMFAHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector3> JDGBACHKNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector4> KKMEEHMLFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector2> IKMIIPIICMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Vector2> PMMFPJFCMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector2> CFCCLGAEECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector2> CNECALJHCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Color> LELAJPCGINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> LBAFKHCJJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> NHHCHHOMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> FJFFKHKLCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<int> CGJAMCBMIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<bool> ELIMPKJEPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> HICAHCGIPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> GHAIJDPFBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<BoneWeight> DNDAHKKDOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<Matrix4x4> AEGDJACGHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<int> NJCGJGKKHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<byte> CCBMPAJILLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> IGIMENDFPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private NativeArray<int> LEIHKNAHPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<sbyte> EEPHJDJOLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<byte> JNIFCNKJDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private NativeArray<int> EINJJPLOGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private bool BEHCNKCKEMO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int GGLDKOAFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECD30", VA = "0x181FEE330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int MHKAMAIMFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x100E810", Offset = "0x100D210", VA = "0x18100E810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int OMKKHCGEBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x677C2E0", Offset = "0x677ACE0", VA = "0x18677C2E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int MCCMDICLGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x677C1F0", Offset = "0x677ABF0", VA = "0x18677C1F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x677C310", Offset = "0x677AD10", VA = "0x18677C310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int DIPIJGHDLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x677C200", Offset = "0x677AC00", VA = "0x18677C200")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x677C360", Offset = "0x677AD60", VA = "0x18677C360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int OCAGAFPJIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x677BF80", Offset = "0x677A980", VA = "0x18677BF80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x677C340", Offset = "0x677AD40", VA = "0x18677C340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GNMEONFECFB HFLHFFEHFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x677C330", Offset = "0x677AD30", VA = "0x18677C330")]
		get
		{
			return default(GNMEONFECFB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x677BF70", Offset = "0x677A970", VA = "0x18677BF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public byte ELBNJADKBJM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x677C350", Offset = "0x677AD50", VA = "0x18677C350")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x677C320", Offset = "0x677AD20", VA = "0x18677C320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public ABOMMDNNEFK NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x677C370", Offset = "0x677AD70", VA = "0x18677C370")]
		get
		{
			return default(ABOMMDNNEFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x677C890", Offset = "0x677B290", VA = "0x18677C890")]
	public JAFHMCOFADM(IList<Mesh> PMMMOPOAEHG, IList<Matrix4x4> ILMHAIKBKKP, IList<bool> ELIMPKJEPNP, byte GHHAMCLNJHM, IList<byte[]> FFDICJIFLNJ, IList<int> ECLOBPKDDJL, IList<bool> MLACCLNDBHG, IList<int> HICAHCGIPFN, IList<int> FIBPFBMKFIN, IList<int> MPPIEEAMPNA, Allocator CHDJMCMMMLJ, GNMEONFECFB FJPGPFOHGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x677C210", Offset = "0x677AC10", VA = "0x18677C210")]
	public HHGHLBHJHGC GPNBBLPGFJJ(Allocator CHDJMCMMMLJ)
	{
		return default(HHGHLBHJHGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x677BF90", Offset = "0x677A990", VA = "0x18677BF90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[OJAAPNLEIHM]
public class KPEJLBFLIFK : BAAPDJDFOIL
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x67813A0", Offset = "0x677FDA0", VA = "0x1867813A0")]
	public JAFHMCOFADM JOEHHKCEINB()
	{
		return default(JAFHMCOFADM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x676F810", Offset = "0x676E210", VA = "0x18676F810")]
	public KPEJLBFLIFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct ABOMMDNNEFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Vector3> PCCMAMFAHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<Vector3> JDGBACHKNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<Vector4> KKMEEHMLFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<Vector2> IKMIIPIICMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<Vector2> PMMFPJFCMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeSlice<Vector2> CFCCLGAEECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<Vector2> CNECALJHCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<Color> LELAJPCGINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<int> LOOFHOGCGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<int> CGJAMCBMIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<BoneWeight> DNDAHKKDOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<byte> PCNDIKABGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public int OHAIFHPBCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public Matrix4x4 FEKAGFEPGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public int GMBFGCEDECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<byte> DBKJBDCMJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public bool BHOIFJIAHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public int DCIHOPOCBJK;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct CMHENJFEHOI : IEquatable<CMHENJFEHOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	internal readonly Material KHHANACNIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	internal readonly IDNEJHNIOEO BDDGHHANJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	internal readonly PCOOGPNENBN KMPCFJBBNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	internal readonly NMIPMBEMGJG FMHNHJDLAAC;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA2FB00", Offset = "0xA2E500", VA = "0x180A2FB00")]
	public CMHENJFEHOI(Material GIIKGEKINDH, IDNEJHNIOEO PCFFMOAHAAO, PCOOGPNENBN HDBFGOLNBFE, NMIPMBEMGJG IKLHFGHGNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6778F10", Offset = "0x6777910", VA = "0x186778F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA2F850", Offset = "0xA2E250", VA = "0x180A2F850", Slot = "4")]
	public bool Equals(CMHENJFEHOI OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6778D80", Offset = "0x6777780", VA = "0x186778D80", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6778E70", Offset = "0x6777870", VA = "0x186778E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EMELCGJCADE
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class GLPJJIEONMI : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public GLPJJIEONMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA2C250", Offset = "0xA2AC50", VA = "0x180A2C250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x677A5F0", Offset = "0x6778FF0", VA = "0x18677A5F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	public static void OONKJJMBDJE(string DKFNFHGODON, int JMKELNHPPCF, long ILJAAMOBPMB, long FNIHGDMMNON, long GGINLMOMDKJ, long EJMKACCHJDG, long NEAGBBGFPKE, long MBLCHPGOCMI, long CCFBOANMLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x67791B0", Offset = "0x6777BB0", VA = "0x1867791B0")]
	public static GOOHGCNPLOF EJNLGLJGHLO(JobHandle DABNJNCEFAN, bool OBGJKDHLFGI, bool GCJGIKJCMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6779140", Offset = "0x6777B40", VA = "0x186779140")]
	[IteratorStateMachine(typeof(GLPJJIEONMI))]
	private static IEnumerator<JMPDKMJKKGA> ADINBFLDGJI(JobHandle IIMJMBJHGDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class ALDBDHFAEPC : CCIAMLADOEA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private PLBGCIENHLF DLHFODPNGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private KAMLGKGKOBL PADECBFGGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private IRecRoomQualityConfigProvider KLMIJFOIKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private bool BEHCNKCKEMO;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x67773C0", Offset = "0x6775DC0", VA = "0x1867773C0")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void LAHBKIPICAO(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5A91460", Offset = "0x5A8FE60", VA = "0x185A91460")]
	[UnityEngine.Scripting.Preserve]
	public ALDBDHFAEPC([OMAPKKAGFIL(null)] KAMLGKGKOBL HLMKDLMBKLO, [OMAPKKAGFIL(null)] PLBGCIENHLF BMBMPAMFPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6777350", Offset = "0x6775D50", VA = "0x186777350")]
	private void INKNBHIFCOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6777980", Offset = "0x6776380", VA = "0x186777980", Slot = "4")]
	public void NOOFMDHAOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x67774C0", Offset = "0x6775EC0", VA = "0x1867774C0", Slot = "5")]
	public GBMNPHMLGKB<Texture2D> MPEPEFKJFGA(LFDCJCJMMGM HLBMAJHLBDM, [Optional] OFKHGODDDHI LDMPLMIKDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6777210", Offset = "0x6775C10", VA = "0x186777210")]
	private uint CGHICALGNNL(LFDCJCJMMGM HLBMAJHLBDM, OFKHGODDDHI LDMPLMIKDPA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface ELBFEJGFGLE
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNCDIBNJHAL(Mesh DICFBCCFLEI, Matrix4x4 EDCJGOBHCEF, byte[] DBKJBDCMJKO, bool BMPOEDNJLJB = false, DPBKAJAMMON.JBNKIJKKBDP MFNGANCKCAO = (DPBKAJAMMON.JBNKIJKKBDP)0, int HICAHCGIPFN = -1, bool ELIMPKJEPNP = false);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNMKELPLOJM(Allocator CHDJMCMMMLJ, GNMEONFECFB FJPGPFOHGJM, byte GHHAMCLNJHM, [Optional] IList<int> FIBPFBMKFIN, [Optional] IList<int> NJPIBFBJMEF);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct PFDGDHGOBNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public readonly GameObject HAIDJCMMNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly AvatarItemMaterial MPCHMAIKIKD;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAB0000", VA = "0x180AB1600")]
	public PFDGDHGOBNO(GameObject HAIDJCMMNJE, AvatarItemMaterial MPCHMAIKIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6781990", Offset = "0x6780390", VA = "0x186781990")]
	public void PLPOGDFEKDD(Material GIIKGEKINDH, int ABEOMGGAPKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HBPNEGLCFDL : OBLJHNCCPPP<Task<(GameObject, AvatarItemMaterial)>, PFDGDHGOBNO>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct GHHAPFMJDAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x677A080", Offset = "0x6778A80", VA = "0x18677A080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x677A580", Offset = "0x6778F80", VA = "0x18677A580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private GBMNPHMLGKB<GameObject> JBIHJACMAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private GBMNPHMLGKB<AvatarItemMaterial> IHJFPICEGGF;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x677ACA0", Offset = "0x67796A0", VA = "0x18677ACA0")]
	private HBPNEGLCFDL(Task<(GameObject, AvatarItemMaterial)> LEDCCMOCHJB, GBMNPHMLGKB<GameObject> LLPLMDBEFGO, GBMNPHMLGKB<AvatarItemMaterial> EFFALMLDAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x677A890", Offset = "0x6779290", VA = "0x18677A890")]
	public static HBPNEGLCFDL JGIIBNEOBDO(AssetReference EKKJHCNNOBB, [Optional] AssetReference FDACPNPAAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x677A770", Offset = "0x6779170", VA = "0x18677A770", Slot = "11")]
	protected override PFDGDHGOBNO DOCHOJKICPF(Task<(GameObject, AvatarItemMaterial)> OMBNLOMPPEF)
	{
		return default(PFDGDHGOBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x677A810", Offset = "0x6779210", VA = "0x18677A810", Slot = "12")]
	protected override void GLGFOCIIMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x677A640", Offset = "0x6779040", VA = "0x18677A640")]
	[AsyncStateMachine(typeof(GHHAPFMJDAI))]
	private static Task<(GameObject, AvatarItemMaterial)> CPEGHMDAOMM(Task<GameObject> DBPAEFOBHCA, Task<AvatarItemMaterial> KIPMCNLOFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JJHJGGPHOBL
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class LLEBPMBOPIG : OBLJHNCCPPP<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class FLOHOJEBPIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public MaterialEntry entry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public string shaderNameToFind;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public FLOHOJEBPIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6779300", Offset = "0x6777D00", VA = "0x186779300")]
			internal object EPHIGJDHDEL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x6779550", Offset = "0x6777F50", VA = "0x186779550")]
			internal object KOPEHCEAKGN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private GBMNPHMLGKB<MaterialMapAsset> IIMJMBJHGDI;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x67818B0", Offset = "0x67802B0", VA = "0x1867818B0")]
		public LLEBPMBOPIG(GBMNPHMLGKB<MaterialMapAsset> IIMJMBJHGDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6781490", Offset = "0x677FE90", VA = "0x186781490", Slot = "11")]
		protected override Material[] DOCHOJKICPF(Task<MaterialMapAsset> LEDCCMOCHJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6781580", Offset = "0x677FF80", VA = "0x186781580", Slot = "12")]
		protected override void GLGFOCIIMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x67815E0", Offset = "0x677FFE0", VA = "0x1867815E0")]
		private Material KGCCOJBIFGD(MaterialEntry MDJIPNANEBE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class KACCDGJBNBP : OBLJHNCCPPP<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private List<GBMNPHMLGKB<Material>> GHJAKKOFDML;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6781330", Offset = "0x677FD30", VA = "0x186781330")]
		public KACCDGJBNBP(Task<Material[]> LEDCCMOCHJB, List<GBMNPHMLGKB<Material>> GHJAKKOFDML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x67811A0", Offset = "0x677FBA0", VA = "0x1867811A0", Slot = "11")]
		protected override Material[] DOCHOJKICPF(Task<Material[]> OMBNLOMPPEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x67811F0", Offset = "0x677FBF0", VA = "0x1867811F0", Slot = "12")]
		protected override void GLGFOCIIMBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6780CF0", Offset = "0x677F6F0", VA = "0x186780CF0")]
	public static GBMNPHMLGKB<Material[]> CNGFOGINHEA(AssetReference[] CIPDACJLHBO)
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
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
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

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6781BA0", Offset = "0x67805A0", VA = "0x186781BA0")]
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
		private struct IOJDBDOFEOJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public AsyncTaskMethodBuilder<GPLHFGMFLBD> <>t__builder;

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
			private TaskAwaiter<GPLHFGMFLBD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x677BBC0", Offset = "0x677A5C0", VA = "0x18677BBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x677BF00", Offset = "0x677A900", VA = "0x18677BF00", Slot = "5")]
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
		private Dictionary<CIJBFEOBFPG, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Dictionary<CIJBFEOBFPG, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<CIJBFEOBFPG, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<CIJBFEOBFPG, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly Dictionary<CIJBFEOBFPG, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private GPLHFGMFLBD _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x677A050", Offset = "0x6778A50", VA = "0x18677A050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6779AF0", Offset = "0x67784F0", VA = "0x186779AF0")]
		public GPLHFGMFLBD HJDLAPLOFGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6779DE0", Offset = "0x67787E0", VA = "0x186779DE0")]
		[AsyncStateMachine(typeof(IOJDBDOFEOJ))]
		public Task<GPLHFGMFLBD> MKMEIDNFGCC(int OMKAOBOICNG, int EMJMFFHKMGC, int CBICNGAPCGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x67799D0", Offset = "0x67783D0", VA = "0x1867799D0")]
		public NoseFaceOption EHLNBFHHNOH(int BGMJIJJAPOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6779C60", Offset = "0x6778660", VA = "0x186779C60")]
		public SelectableFaceOption MHJFPPDGKJA(FaceFeatureType PKKJLBIABIH, CIJBFEOBFPG DMABPPCLGPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6779A70", Offset = "0x6778470", VA = "0x186779A70")]
		public int EPIGKHDHLME(CIJBFEOBFPG DMABPPCLGPE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x67797A0", Offset = "0x67781A0", VA = "0x1867797A0")]
		private void BAPOMBOLKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2B19CE0", Offset = "0x2B186E0", VA = "0x182B19CE0")]
		private void PCNMEKLGFPG<T>(IDictionary<CIJBFEOBFPG, T> ENCKOMKBEOC, IReadOnlyList<T> FHIBBDMNBLE) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6779F10", Offset = "0x6778910", VA = "0x186779F10")]
		public CIJBFEOBFPG MPMDNBALMOO(FaceFeatureType PKKJLBIABIH)
		{
			return default(CIJBFEOBFPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6779B40", Offset = "0x6778540", VA = "0x186779B40")]
		public CIJBFEOBFPG KEILKEMLPHH(FaceFeatureType PKKJLBIABIH)
		{
			return default(CIJBFEOBFPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6779FC0", Offset = "0x67789C0", VA = "0x186779FC0")]
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
