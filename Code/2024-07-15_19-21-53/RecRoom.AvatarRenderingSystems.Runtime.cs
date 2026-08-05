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
		[Cpp2IlInjected.Address(RVA = "0x6771410", Offset = "0x676FC10", VA = "0x186771410", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8552B0", VA = "0x180856AB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6776870", Offset = "0x6775070", VA = "0x186776870", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67767A0", Offset = "0x6774FA0", VA = "0x1867767A0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6776830", Offset = "0x6775030", VA = "0x186776830")]
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
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851070", VA = "0x180852870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8577C0", VA = "0x180858FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67768B0", Offset = "0x67750B0", VA = "0x1867768B0")]
		public static RecNetCDNKey OHBAGDNOBOH(string AALLHBPLGBD, string ACJNIJOJKAK = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F690A0", Offset = "0x5F678A0", VA = "0x185F690A0")]
		public void CPBLCAFPFKN(string HLCLBMCLPCO, string BGMAOMLOOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67769B0", Offset = "0x67751B0", VA = "0x1867769B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x675EE20", Offset = "0x675D620", VA = "0x18675EE20", Slot = "4")]
	public void GNCDIBNJHAL(Mesh DICFBCCFLEI, Matrix4x4 EDCJGOBHCEF, byte[] DBKJBDCMJKO, bool BMPOEDNJLJB = false, DPBKAJAMMON.JBNKIJKKBDP MFNGANCKCAO = (DPBKAJAMMON.JBNKIJKKBDP)0, int HICAHCGIPFN = -1, bool ELIMPKJEPNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x675EDE0", Offset = "0x675D5E0", VA = "0x18675EDE0", Slot = "5")]
	public void FNMKELPLOJM(Allocator CHDJMCMMMLJ, GNMEONFECFB FJPGPFOHGJM, byte GHHAMCLNJHM, [Optional] IList<int> FIBPFBMKFIN, [Optional] IList<int> NJPIBFBJMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x675EB90", Offset = "0x675D390", VA = "0x18675EB90")]
	private static void DHCANFHLEKG(Mesh DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x675F020", Offset = "0x675D820", VA = "0x18675F020")]
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
	[Cpp2IlInjected.Address(RVA = "0x676F960", Offset = "0x676E160", VA = "0x18676F960", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x67748C0", Offset = "0x67730C0", VA = "0x1867748C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6775D60", Offset = "0x6774560", VA = "0x186775D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CFFONAKGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6775D50", Offset = "0x6774550", VA = "0x186775D50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6773E40", Offset = "0x6772640", VA = "0x186773E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int HBMDLLOJIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67745C0", Offset = "0x6772DC0", VA = "0x1867745C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6774180", Offset = "0x6772980", VA = "0x186774180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DJLDIHIGKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6774D50", Offset = "0x6773550", VA = "0x186774D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6775D70", Offset = "0x6774570", VA = "0x186775D70")]
	public PMKDNEGPHEH(int JPGPFGMDFFJ, int JOAOBPKBJPK, int OFICJAKPOPC, int ENKLOOOFMNC, Allocator CHDJMCMMMLJ, int LKHEAAKNHMP, DLFECEDNMGA ACHCCBNIADG, bool HFIBACDLHOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6774830", Offset = "0x6773030", VA = "0x186774830")]
	public void EDDLNIEMBEB(int DHNLEFJCEAH, Vector3 NJJHKDBJDAC, Vector3 IPBCPNHEHBB, Vector4 DOGPFNGIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6774190", Offset = "0x6772990", VA = "0x186774190")]
	public void DDMBNNDLMDO(int DHNLEFJCEAH, BoneWeight CLPIOJNHBDJ, NativeSlice<byte> DBKJBDCMJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6773E50", Offset = "0x6772650", VA = "0x186773E50")]
	public Color CIPADPJBGGE(int DHNLEFJCEAH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6773A40", Offset = "0x6772240", VA = "0x186773A40")]
	public void ABEFFJMJNGG(int DHNLEFJCEAH, Color DDJHOHBDMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67748D0", Offset = "0x67730D0", VA = "0x1867748D0")]
	public void HDMLHMIPCGG(byte BKALJKAMJJI, int DHNLEFJCEAH, Vector2 EMLOHHMFJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6774DC0", Offset = "0x67735C0", VA = "0x186774DC0")]
	public void KAFEMIOCBEL(int DHNLEFJCEAH, int EDFEBNBLMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6775CF0", Offset = "0x67744F0", VA = "0x186775CF0")]
	public bool MBKPEHHBCJO(int BKALJKAMJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6774C80", Offset = "0x6773480", VA = "0x186774C80")]
	public void HKLOKJAPOPO(int MJDDAIDLEAO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67745D0", Offset = "0x6772DD0", VA = "0x1867745D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6774DD0", Offset = "0x67735D0", VA = "0x186774DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6771E40", Offset = "0x6770640", VA = "0x186771E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MHKAMAIMFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6771E70", Offset = "0x6770670", VA = "0x186771E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OMKKHCGEBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6771D50", Offset = "0x6770550", VA = "0x186771D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MCCMDICLGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6771C60", Offset = "0x6770460", VA = "0x186771C60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6771E20", Offset = "0x6770620", VA = "0x186771E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int DIPIJGHDLNE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6771C70", Offset = "0x6770470", VA = "0x186771C70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6771E90", Offset = "0x6770690", VA = "0x186771E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OCAGAFPJIOB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6771AE0", Offset = "0x67702E0", VA = "0x186771AE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6771E60", Offset = "0x6770660", VA = "0x186771E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GNMEONFECFB HFLHFFEHFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6771E50", Offset = "0x6770650", VA = "0x186771E50")]
		get
		{
			return default(GNMEONFECFB);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6771AD0", Offset = "0x67702D0", VA = "0x186771AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte ELBNJADKBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6771E80", Offset = "0x6770680", VA = "0x186771E80")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6771E30", Offset = "0x6770630", VA = "0x186771E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OGLGCOHOEPA NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6771EA0", Offset = "0x67706A0", VA = "0x186771EA0")]
		get
		{
			return default(OGLGCOHOEPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x67720F0", Offset = "0x67708F0", VA = "0x1867720F0")]
	public OFOOBONMNLC(IList<Mesh> PMMMOPOAEHG, IList<Matrix4x4> ILMHAIKBKKP, IList<bool> ELIMPKJEPNP, byte GHHAMCLNJHM, IList<byte[]> FFDICJIFLNJ, IList<int> ECLOBPKDDJL, IList<bool> MLACCLNDBHG, IList<int> HICAHCGIPFN, IList<int> FIBPFBMKFIN, IList<int> MPPIEEAMPNA, Allocator CHDJMCMMMLJ, GNMEONFECFB FJPGPFOHGJM, bool HFIBACDLHOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6771C80", Offset = "0x6770480", VA = "0x186771C80")]
	public PMKDNEGPHEH GPNBBLPGFJJ(Allocator CHDJMCMMMLJ, DLFECEDNMGA ACHCCBNIADG)
	{
		return default(PMKDNEGPHEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6771AF0", Offset = "0x67702F0", VA = "0x186771AF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x676F450", Offset = "0x676DC50", VA = "0x18676F450")]
	public OFOOBONMNLC JOEHHKCEINB()
	{
		return default(OFOOBONMNLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x676F710", Offset = "0x676DF10", VA = "0x18676F710")]
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
			[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public virtual bool AKPAALEDFDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual DPBKAJAMMON.JBNKIJKKBDP GMBFGCEDECP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "6")]
			get
			{
				return default(DPBKAJAMMON.JBNKIJKKBDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IPHFAOGAOKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x14C4930", Offset = "0x14C3130", VA = "0x1814C4930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool NOJHKHJKLBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x67732D0", Offset = "0x6771AD0", VA = "0x1867732D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool BKGCMNNOOON
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x67732E0", Offset = "0x6771AE0", VA = "0x1867732E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public NEJIFLKANJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x67714A0", Offset = "0x676FCA0", VA = "0x1867714A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851080", VA = "0x180852880", Slot = "6")]
			get
			{
				return default(DPBKAJAMMON.JBNKIJKKBDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6773930", Offset = "0x6772130", VA = "0x186773930")]
		public PEIPJPBCCAH(AvatarSkinAssetItem.LDDHCLGGBEN MNFNGNGFKBG, AssetReference CJLEPKNFNOK, Material GILFLFFMNJC, NMIPMBEMGJG IKLHFGHGNGC, DPBKAJAMMON.JBNKIJKKBDP LPNIGDLFGIN = (DPBKAJAMMON.JBNKIJKKBDP)0, [Optional] CIJBFEOBFPG? DMHPFHPLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6773820", Offset = "0x6772020", VA = "0x186773820")]
		public PEIPJPBCCAH(AvatarSkinAssetItem.LDDHCLGGBEN MNFNGNGFKBG, AssetReference CJLEPKNFNOK, Material GILFLFFMNJC, DPBKAJAMMON.JBNKIJKKBDP LPNIGDLFGIN = (DPBKAJAMMON.JBNKIJKKBDP)0, [Optional] CIJBFEOBFPG? DMHPFHPLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x67735E0", Offset = "0x6771DE0", VA = "0x1867735E0", Slot = "7")]
		public override OABICBNODGM MLNMPHDGJJF(int[] NFFJJJJIMPO, List<IABENFAMAOM> LDBBGMCPCML, List<IABENFAMAOM> PDBHGKPPEDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6773300", Offset = "0x6771B00", VA = "0x186773300", Slot = "8")]
		public override KJOCJOAHANM IEANLOBMFOO(uint JMKELNHPPCF, AvatarSkinnedMeshBoneOrderRemapsData JDNGGLBFDLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x67737B0", Offset = "0x6771FB0", VA = "0x1867737B0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool AKPAALEDFDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x676EA80", Offset = "0x676D280", VA = "0x18676EA80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D2DA20", Offset = "0x1D2C220", VA = "0x181D2DA20")]
		public JGNBJDJJJOA(NMIPMBEMGJG NLOFGPCJIFE, EFAADAJCLPJ MEADPGHDIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x676EE50", Offset = "0x676D650", VA = "0x18676EE50", Slot = "7")]
		public override OABICBNODGM MLNMPHDGJJF(int[] NFFJJJJIMPO, List<IABENFAMAOM> LDBBGMCPCML, List<IABENFAMAOM> PDBHGKPPEDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x676E950", Offset = "0x676D150", VA = "0x18676E950", Slot = "8")]
		public override KJOCJOAHANM IEANLOBMFOO(uint JMKELNHPPCF, AvatarSkinnedMeshBoneOrderRemapsData JDNGGLBFDLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x676E760", Offset = "0x676CF60", VA = "0x18676E760")]
		public KJOCJOAHANM EODLAPCDPIL(GameObject HAIDJCMMNJE, uint JMKELNHPPCF, bool KIIIFOCLGIP, bool HMMJGIGIODK, AvatarSkinnedMeshBoneOrderRemapsData JDNGGLBFDLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x676EAE0", Offset = "0x676D2E0", VA = "0x18676EAE0")]
		public static bool KGBCIOBPOLN(Renderer[] OGJOAEGIENG, string DEDIMOCCFCO, [Out] Renderer KOCMGDJLEKP, [Out] Renderer HDBILFEDIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x676F400", Offset = "0x676DC00", VA = "0x18676F400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x676F330", Offset = "0x676DB30", VA = "0x18676F330")]
		private (GBMNPHMLGKB<PFDGDHGOBNO>, GBMNPHMLGKB<Material[]>) OGFPIBBAKFB()
		{
			return default((GBMNPHMLGKB<PFDGDHGOBNO>, GBMNPHMLGKB<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x429E7F0", Offset = "0x429CFF0", VA = "0x18429E7F0")]
		[CompilerGenerated]
		private void ICMPMDNALLD(PFDGDHGOBNO ADPMAHMCGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x676E700", Offset = "0x676CF00", VA = "0x18676E700")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public DABBPGHGJMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6761370", Offset = "0x675FB70", VA = "0x186761370")]
		internal void BALEIELEPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6761420", Offset = "0x675FC20", VA = "0x186761420")]
		internal void JAJNLEHIMHH(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6761390", Offset = "0x675FB90", VA = "0x186761390")]
		internal void EBKNBKPOIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6761440", Offset = "0x675FC40", VA = "0x186761440")]
		internal void MFOFOOFPBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public IFDNJHJJKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x676E5F0", Offset = "0x676CDF0", VA = "0x18676E5F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public DJBDODNJHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x67614D0", Offset = "0x675FCD0", VA = "0x1867614D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public HKGLGEFINHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x676E310", Offset = "0x676CB10", VA = "0x18676E310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x676E520", Offset = "0x676CD20", VA = "0x18676E520", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public JAOJIPFKNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x676E6B0", Offset = "0x676CEB0", VA = "0x18676E6B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PMLBAGHFCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9440", Offset = "0x8A7C40", VA = "0x1808A9440")]
		internal void ACJNFIHPBPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA2C5D0", Offset = "0xA2ADD0", VA = "0x180A2C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public KHOMKOLHFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x676F720", Offset = "0x676DF20", VA = "0x18676F720")]
		internal void IFNIBIBIHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA303C0", Offset = "0xA2EBC0", VA = "0x180A303C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public OBINLLLLELI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6771890", Offset = "0x6770090", VA = "0x186771890")]
		internal void OOBFIDLKFLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA33480", Offset = "0xA31C80", VA = "0x180A33480")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public ANILNNGJOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x675E7A0", Offset = "0x675CFA0", VA = "0x18675E7A0")]
		internal OABICBNODGM FCPNCKLHPPE(LFDCJCJMMGM item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x675EB50", Offset = "0x675D350", VA = "0x18675EB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public GNEBLDMOLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6761600", Offset = "0x675FE00", VA = "0x186761600")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public IAKMNMMPEHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x676E570", Offset = "0x676CD70", VA = "0x18676E570")]
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
		[Cpp2IlInjected.Address(RVA = "0x190C4C0", Offset = "0x190ACC0", VA = "0x18190C4C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x18F9ED0", Offset = "0x18F86D0", VA = "0x1818F9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LIMIMALNKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x67658E0", Offset = "0x67640E0", VA = "0x1867658E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material JBDACDBGEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6761650", Offset = "0x675FE50", VA = "0x186761650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material AHJJGDOLIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6769400", Offset = "0x6767C00", VA = "0x186769400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool GCJGIKJCMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public FCPIIIBEPDH GANCAJJMOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EC0", Offset = "0x8C26C0", VA = "0x1808C3EC0", Slot = "21")]
		get
		{
			return default(FCPIIIBEPDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool BPLNHOJNDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x676CCC0", Offset = "0x676B4C0", VA = "0x18676CCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private static PMIHDANGMFM KHLLEDBKIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6766C90", Offset = "0x6765490", VA = "0x186766C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private MHKMFCOCHAP ELINHKLJNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6761CC0", Offset = "0x67604C0", VA = "0x186761CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private CCIAMLADOEA ACDJHAGGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x676CE00", Offset = "0x676B600", VA = "0x18676CE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private NICHJPMKMDF DOFIDBNKPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6769970", Offset = "0x6768170", VA = "0x186769970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private FJDMGDBCEIP FIANHDNOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x676D720", Offset = "0x676BF20", VA = "0x18676D720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EHODCIMNDCH NPAPPGLKGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA0CDA0", Offset = "0xA0B5A0", VA = "0x180A0CDA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public EHODCIMNDCH BMOCGEAPLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x13D7E50", Offset = "0x13D6650", VA = "0x1813D7E50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public SkinnedMeshRenderer[] JJFJAMBKPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x12E00A0", Offset = "0x12DE8A0", VA = "0x1812E00A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Renderer[] GGNIFLBHLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x85FE70", Offset = "0x85E670", VA = "0x18085FE70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool CHAKJAOEKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x676CFE0", Offset = "0x676B7E0", VA = "0x18676CFE0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DPBKAJAMMON.JBNKIJKKBDP DEDFHIDAGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x85FE30", Offset = "0x85E630", VA = "0x18085FE30", Slot = "18")]
		get
		{
			return default(DPBKAJAMMON.JBNKIJKKBDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int HMEONGMOAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x190D720", Offset = "0x190BF20", VA = "0x18190D720")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67683C0", Offset = "0x6766BC0", VA = "0x1867683C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool LGFCJHMFGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6761920", Offset = "0x6760120", VA = "0x186761920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private static bool ENHONLLJFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6764500", Offset = "0x6762D00", VA = "0x186764500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool DMLINAMNMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x676C920", Offset = "0x676B120", VA = "0x18676C920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x676D9F0", Offset = "0x676C1F0", VA = "0x18676D9F0")]
	public HIOPMNHGHAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67683E0", Offset = "0x6766BE0", VA = "0x1867683E0", Slot = "26")]
	public void HMCGAKKBHMB(PCLIHIGPBDC EOBMHGNPJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67668E0", Offset = "0x67650E0", VA = "0x1867668E0", Slot = "27")]
	public void GBGAKFNOANO(JFMKJGFNJLF GLCDBAANOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x67683C0", Offset = "0x6766BC0", VA = "0x1867683C0", Slot = "4")]
	public void HFCGJBGLHKC(int JMKELNHPPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6766960", Offset = "0x6765160", VA = "0x186766960", Slot = "9")]
	public void GDJJHEICHGA(OFGNGPMIPGJ AJBECKEBCAN, Texture2D IPABEBMKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x676CC40", Offset = "0x676B440", VA = "0x18676CC40", Slot = "10")]
	public void NOOFMDHAOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67697F0", Offset = "0x6767FF0", VA = "0x1867697F0", Slot = "11")]
	public bool JMBCOGMEPGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6765DF0", Offset = "0x67645F0", VA = "0x186765DF0", Slot = "8")]
	public void EMALGMKGMMH(FOIFDKEJMPA DOCPLINHPIO, Color? KIJNHGNFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x676C740", Offset = "0x676AF40", VA = "0x18676C740")]
	private void MICMIKFPPOJ(Action PHNKPOHDPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x67654A0", Offset = "0x6763CA0", VA = "0x1867654A0", Slot = "5")]
	public void DMLNOBDOCAI(EFAADAJCLPJ GNCNHHCIKFO, Texture IEKNJHBBHLN, Color KMCGDDCHOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x18F9ED0", Offset = "0x18F86D0", VA = "0x1818F9ED0", Slot = "6")]
	public void JCNGPOOEIKD(bool NFJCBMPJKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x12D95A0", Offset = "0x12D7DA0", VA = "0x1812D95A0", Slot = "7")]
	public void FBPPIFHHEDA(OFKHGODDDHI LDMPLMIKDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x67699F0", Offset = "0x67681F0", VA = "0x1867699F0", Slot = "14")]
	public HBGKBCMOMOE KGIMEMICEPP(LEDCDLLGGBL BHCEDLNADDA, bool ODHKDJIAEEC, int[] LLKJANJINHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6766270", Offset = "0x6764A70", VA = "0x186766270", Slot = "15")]
	public void EOJEBCEEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67617E0", Offset = "0x675FFE0", VA = "0x1867617E0")]
	private bool AKOGDBFPPKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85FE20", Offset = "0x85E620", VA = "0x18085FE20", Slot = "19")]
	public void LCEDANIJBBH(DPBKAJAMMON.JBNKIJKKBDP ACOCDFKILDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6767A50", Offset = "0x6766250", VA = "0x186767A50")]
	private bool GIJDJFIAFLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6768E30", Offset = "0x6767630", VA = "0x186768E30")]
	private HBGKBCMOMOE JEFHBENJJBF(bool ODHKDJIAEEC, List<PBNAAKGJKHF> PLPGKJGOCNC, int[] LLKJANJINHI, Func<int, AAHJJDJBBBG> PEOJBOCGNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x676D370", Offset = "0x676BB70", VA = "0x18676D370")]
	[IteratorStateMachine(typeof(HKGLGEFINHH))]
	private IEnumerator<JMPDKMJKKGA> ONFGOKMKFOJ(bool ODHKDJIAEEC, List<PBNAAKGJKHF> PLPGKJGOCNC, int[] LLKJANJINHI, Func<int, AAHJJDJBBBG> PEOJBOCGNOI, JCFGHMPOJGM DBJDFNNLDPO, Material IIKGHMJJEPI, List<HBGKBCMOMOE> CEMBKHIMCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x676BB10", Offset = "0x676A310", VA = "0x18676BB10")]
	private HBGKBCMOMOE LPKFJGKNAFA(List<PBNAAKGJKHF> PLPGKJGOCNC, int[] LLKJANJINHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6761D10", Offset = "0x6760510", VA = "0x186761D10")]
	private GOOHGCNPLOF AOIBMMHBNHN(List<PBNAAKGJKHF> PLPGKJGOCNC, int JMKELNHPPCF, bool ODHKDJIAEEC, AAHJJDJBBBG JLMHPKHAOHJ, bool EMNIPMNGBCG, JCFGHMPOJGM DBJDFNNLDPO, Material IIKGHMJJEPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6768C80", Offset = "0x6767480", VA = "0x186768C80", Slot = "22")]
	public void IDLOOJNIHIF(AvatarFaceShape MNOCGOBJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x676D150", Offset = "0x676B950", VA = "0x18676D150", Slot = "23")]
	public void OIBAPOKOLOL(AvatarBodyShape GLLKCMAKDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6765140", Offset = "0x6763940", VA = "0x186765140", Slot = "25")]
	public void DHEBLJLCKKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x676BEC0", Offset = "0x676A6C0", VA = "0x18676BEC0", Slot = "24")]
	public void MDEHOJNBDPB(bool MGBJCOGGOOM, bool FFGHEOMOEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6769580", Offset = "0x6767D80", VA = "0x186769580")]
	private void JHHONBFFFAC(SkinnedMeshRenderer ODFJMFEMDEL, int JMKELNHPPCF, Mesh DICFBCCFLEI, List<Material> FJMFFMBIILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6764BB0", Offset = "0x67633B0", VA = "0x186764BB0")]
	private static Material DDEHILFJDPI(Dictionary<CMHENJFEHOI, Material> DDLOAFKGEJB, Material CEKLJJNAFLP, IDNEJHNIOEO PCFFMOAHAAO, PCOOGPNENBN HDBFGOLNBFE, NMIPMBEMGJG IKLHFGHGNGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6766B70", Offset = "0x6765370", VA = "0x186766B70")]
	private static IDNEJHNIOEO GEEAEIJAKCD(PBNAAKGJKHF BFLMNODAICA, int PBJFIAJOOFC)
	{
		return default(IDNEJHNIOEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x676C210", Offset = "0x676AA10", VA = "0x18676C210")]
	private void MGNCOHHOPEE(int ABEOMGGAPKL, Material GIIKGEKINDH, PBNAAKGJKHF BFLMNODAICA, [Out] Texture2D GGFECACAKCL, [Out] Vector4 PIOHIMPAGMB, [Out] Texture2D MMGKFOGEOIL, [Out] Texture2D IAEDCGOJEGD, [Out] Texture2D OPELLMDBHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x67658F0", Offset = "0x67640F0", VA = "0x1867658F0")]
	private void ECHECDHDIGC(int ABEOMGGAPKL, Material GIIKGEKINDH, PBNAAKGJKHF BFLMNODAICA, [Out] Color FDNIDKGGKLL, [Out] Color IBPJCOCMPLN, [Out] Color JJFIFHALOFI, [Out] Color GICAHBIPDBG, [Out] Color BJJDHKDBCNF, [Out] Color KFGEMLIHHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6767D00", Offset = "0x6766500", VA = "0x186767D00")]
	private bool HDLOEPPCKDE(Material GIIKGEKINDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x676CBC0", Offset = "0x676B3C0", VA = "0x18676CBC0")]
	private static Material NOKJPMOFMGC(int ABEOMGGAPKL, JGNBJDJJJOA BFLMNODAICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6761BD0", Offset = "0x67603D0", VA = "0x186761BD0")]
	private static PCOOGPNENBN AMICLCGMBOC(PBNAAKGJKHF BFLMNODAICA, int PBJFIAJOOFC)
	{
		return default(PCOOGPNENBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x676B100", Offset = "0x6769900", VA = "0x18676B100")]
	private static void KOBLPNACMAK(Dictionary<string, List<CMHENJFEHOI>> NAOKJFLCLAE, PBNAAKGJKHF JCBFGMJDFOB, Material CEKLJJNAFLP, IDNEJHNIOEO DOCPLINHPIO, PCOOGPNENBN AJBECKEBCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6764D10", Offset = "0x6763510", VA = "0x186764D10")]
	private static SkinnedMeshRenderer DELFDELEIND(Transform BHKPGHNPMGG, Transform CIIGKAGNLNN, SkinnedMeshRenderer[] OGJOAEGIENG, int JMKELNHPPCF, AAHJJDJBBBG JLMHPKHAOHJ, bool ODHKDJIAEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x676C040", Offset = "0x676A840", VA = "0x18676C040")]
	private void MFGEELBJAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x676C030", Offset = "0x676A830", VA = "0x18676C030")]
	private void MDNJIKMPEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x676D210", Offset = "0x676BA10", VA = "0x18676D210")]
	private static void OKPBGKCKMBC(Dictionary<CMHENJFEHOI, Material> DDLOAFKGEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x676BED0", Offset = "0x676A6D0", VA = "0x18676BED0")]
	private static void MDGCGCLBAHJ(Dictionary<Renderer, JCFGHMPOJGM> CFAADCLFONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6765360", Offset = "0x6763B60", VA = "0x186765360")]
	private void DJHOINHCPKF(SkinnedMeshRenderer[] OGJOAEGIENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x676C7E0", Offset = "0x676AFE0", VA = "0x18676C7E0")]
	private void MLALHCHCOAM(SkinnedMeshRenderer GEINJFCFBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6763760", Offset = "0x6761F60", VA = "0x186763760")]
	private void AOLPPFHHOKN(List<IABENFAMAOM> NNOPGHBIOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6764A30", Offset = "0x6763230", VA = "0x186764A30")]
	private void DCNFDFNAEGH(Dictionary<string, GBMNPHMLGKB<Texture2D>> NAOKJFLCLAE, bool EBCIKALBMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x67644B0", Offset = "0x6762CB0", VA = "0x1867644B0")]
	private void CHMGFHAPLEP(Dictionary<string, List<CMHENJFEHOI>> NAOKJFLCLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6764F40", Offset = "0x6763740", VA = "0x186764F40")]
	private void DFCKKMBLNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x676CE50", Offset = "0x676B650", VA = "0x18676CE50")]
	private void OEFDHKKHEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67686A0", Offset = "0x6766EA0", VA = "0x1867686A0")]
	private void HMHILAALMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x67619A0", Offset = "0x67601A0", VA = "0x1867619A0")]
	private void ALEMMKNMGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67694F0", Offset = "0x6767CF0", VA = "0x1867694F0")]
	private void JHDEELFMACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6763CE0", Offset = "0x67624E0", VA = "0x186763CE0")]
	private void BIMGOFOGGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x676B3F0", Offset = "0x6769BF0", VA = "0x18676B3F0")]
	private void LCALFHKDHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x676C880", Offset = "0x676B080", VA = "0x18676C880")]
	private void MNKPBOJGCIH(bool LMKKFGDJBIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6761B00", Offset = "0x6760300", VA = "0x186761B00")]
	private void AMHLCOGLDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x67650A0", Offset = "0x67638A0", VA = "0x1867650A0")]
	private void DGJIBIHDHDN(bool LMKKFGDJBIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6765510", Offset = "0x6763D10", VA = "0x186765510")]
	private void DPPPEBMCBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6766470", Offset = "0x6764C70", VA = "0x186766470")]
	private void EPFEEKICMHO(Material IIKGHMJJEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x676D630", Offset = "0x676BE30", VA = "0x18676D630")]
	private void PHMHJAEPGLG(Material IIKGHMJJEPI, Color IBPJCOCMPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6768D40", Offset = "0x6767540", VA = "0x186768D40")]
	private void IPGAFIMGLBL(Material IIKGHMJJEPI, Color JJFIFHALOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x676B010", Offset = "0x6769810", VA = "0x18676B010")]
	private void KLHJEIFJOON(Material IIKGHMJJEPI, Color FDNIDKGGKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x676BDD0", Offset = "0x676A5D0", VA = "0x18676BDD0")]
	private void MCIHBIDFKJN(Material IIKGHMJJEPI, Texture2D IPABEBMKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x676C650", Offset = "0x676AE50", VA = "0x18676C650")]
	private void MGNIFCNKGNA(Material IIKGHMJJEPI, Texture HLJMHJMJPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6767890", Offset = "0x6766090", VA = "0x186767890")]
	private void GHPNPDBCCFH(Action<JCFGHMPOJGM> NEEHCPBKJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x676D480", Offset = "0x676BC80", VA = "0x18676D480")]
	private void PBJGFMPLCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x67646A0", Offset = "0x6762EA0", VA = "0x1867646A0")]
	private void CPKCEKHGKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x676B4C0", Offset = "0x6769CC0", VA = "0x18676B4C0")]
	private HBGKBCMOMOE LLPCNMEAJGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6767FF0", Offset = "0x67667F0", VA = "0x186767FF0")]
	private void HEMFJGOJIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6764060", Offset = "0x6762860", VA = "0x186764060")]
	public void CBPOGAKODJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x67667E0", Offset = "0x6764FE0", VA = "0x1867667E0")]
	private void FCOKJDNCIFG(Vector3 PHJFFHJCDOD, Quaternion OILJGEIJHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6763940", Offset = "0x6762140", VA = "0x186763940")]
	private void BBODEAJDDDJ(List<PBNAAKGJKHF> BFFLCBOBKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6767390", Offset = "0x6765B90", VA = "0x186767390")]
	public void GGKDHJFNGEE(GOLAHOGMBDI NNMMPJLDIFI, bool LFFNKFIILIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6766D10", Offset = "0x6765510", VA = "0x186766D10")]
	public void GGKDHJFNGEE(GOLAHOGMBDI NNMMPJLDIFI, AnchorParamsRestrictions MOHDKCNMCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9F7340", Offset = "0x9F5B40", VA = "0x1809F7340")]
	private static void DFBJPMPCKAF(FitMeshHemisphere ENNLBIHIFOG, Transform OBAFGKLCEOA, GOLAHOGMBDI NNMMPJLDIFI, AnchorParamsRestrictions CEFLPIJDIKH, [Out] Vector3 NJGBBMKGAPK, [Out] Quaternion IJKPBDDGPGD, [Out] GOLAHOGMBDI GGFOCCEAGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6767B40", Offset = "0x6766340", VA = "0x186767B40")]
	public void GMHDJHGBBDM(Vector2 IJOPGECCBLF, Vector3 JMJBCJHHIMN, Vector3 FGHENCLBGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6763E60", Offset = "0x6762660", VA = "0x186763E60")]
	private void BLNOIEPJFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6767F60", Offset = "0x6766760", VA = "0x186767F60")]
	private void HEIGIFHGEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67696D0", Offset = "0x6767ED0", VA = "0x1867696D0")]
	[CompilerGenerated]
	private void JIKCLGOIOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x676BAE0", Offset = "0x676A2E0", VA = "0x18676BAE0")]
	[CompilerGenerated]
	private void LOIAHCHEHOJ(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6761A70", Offset = "0x6760270", VA = "0x186761A70")]
	[CompilerGenerated]
	private void AMFIHKGKBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x676C7C0", Offset = "0x676AFC0", VA = "0x18676C7C0")]
	[CompilerGenerated]
	private void MKLFJPGDHML(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6765850", Offset = "0x6764050", VA = "0x186765850")]
	[CompilerGenerated]
	private void EAKKNPBJIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6765480", Offset = "0x6763C80", VA = "0x186765480")]
	[CompilerGenerated]
	private void DLKOMCFHGBF(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6766850", Offset = "0x6765050", VA = "0x186766850")]
	[CompilerGenerated]
	private void FONCIHIOPHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x67643F0", Offset = "0x6762BF0", VA = "0x1867643F0")]
	[CompilerGenerated]
	private void CDGOKMIJCJH(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6768BF0", Offset = "0x67673F0", VA = "0x186768BF0")]
	[CompilerGenerated]
	private void HPLMIPKMOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x676BAB0", Offset = "0x676A2B0", VA = "0x18676BAB0")]
	[CompilerGenerated]
	private void LNPAEABGNKI(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6764420", Offset = "0x6762C20", VA = "0x186764420")]
	[CompilerGenerated]
	private void CDJENBODEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6767B10", Offset = "0x6766310", VA = "0x186767B10")]
	[CompilerGenerated]
	private void GLEKPJAAEKO(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6769760", Offset = "0x6767F60", VA = "0x186769760")]
	[CompilerGenerated]
	private void JKEPOEDMDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6763E30", Offset = "0x6762630", VA = "0x186763E30")]
	[CompilerGenerated]
	private void BIOPEOIEEOH(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x67661F0", Offset = "0x67649F0", VA = "0x1867661F0")]
	[CompilerGenerated]
	private void EMHPFAMJLDA(KeyValuePair<string, GBMNPHMLGKB<Texture2D>> HDDCDBLOLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6763FD0", Offset = "0x67627D0", VA = "0x186763FD0")]
	[CompilerGenerated]
	private void BNOKPIEABML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6764A00", Offset = "0x6763200", VA = "0x186764A00")]
	[CompilerGenerated]
	private void DCGHMNCKNMK(JCFGHMPOJGM PMFFGJMHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x676CB30", Offset = "0x676B330", VA = "0x18676CB30")]
	[CompilerGenerated]
	private void NFHPPHKPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x676D600", Offset = "0x676BE00", VA = "0x18676D600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6760D50", Offset = "0x675F550", VA = "0x186760D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HPJBMFGHLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6760E60", Offset = "0x675F660", VA = "0x186760E60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6760C90", Offset = "0x675F490", VA = "0x186760C90", Slot = "7")]
	public void HMCGAKKBHMB(DNDGIEPGFML KJNCKGILAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x675F250", Offset = "0x675DA50", VA = "0x18675F250", Slot = "8")]
	public void AAGGJKGLFEP(GBJONGNNFPA HNHJMAFBDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x675F5D0", Offset = "0x675DDD0", VA = "0x18675F5D0", Slot = "5")]
	public void CDFHGFJFMMO(IHEGNEEOHJB OIJKNNIAIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6760B50", Offset = "0x675F350", VA = "0x186760B50")]
	private Vector2 DDIFKCMLFPD(Vector2 POEDMBBLNID)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x675FA00", Offset = "0x675E200", VA = "0x18675FA00", Slot = "6")]
	public void CJJNCINNIPG(DCFHDECNJAL HNHJMAFBDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x675F280", Offset = "0x675DA80", VA = "0x18675F280")]
	private void BDAKMJLDKGM(DCFHDECNJAL CNKCOGJJMDL, ALBKENOMFOK BCAJDJKHFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6760BB0", Offset = "0x675F3B0", VA = "0x186760BB0")]
	private void DJAGNMAEBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6761310", Offset = "0x675FB10", VA = "0x186761310")]
	public CHOCPCMEKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6760DD0", Offset = "0x675F5D0", VA = "0x186760DD0")]
	[CompilerGenerated]
	internal static (float, float) MLBFDPLIICO(float JBPKKAKBAND)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6760B10", Offset = "0x675F310", VA = "0x186760B10")]
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
	[Cpp2IlInjected.Address(RVA = "0x6780700", Offset = "0x677EF00", VA = "0x186780700")]
	private JCFGHMPOJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6780640", Offset = "0x677EE40", VA = "0x186780640")]
	public JCFGHMPOJGM(Color JKINDAGENFE, Color JNFOKIPIGLJ, Color AIFKEMOPKJL, Color? KDEDBHJBFND, Color? AGGNNOHCNDM, Color? NHBNJPLMIML, Texture2D BLEICALDIAF, Texture2D PDPLBINDDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x677FBC0", Offset = "0x677E3C0", VA = "0x18677FBC0")]
	internal int IIDLJDGOFJD(Material CFLFHCBFGIE, IDNEJHNIOEO PCFFMOAHAAO, PCOOGPNENBN HDBFGOLNBFE, NMIPMBEMGJG IKLHFGHGNGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x677FCB0", Offset = "0x677E4B0", VA = "0x18677FCB0")]
	private int IIDLJDGOFJD(CMHENJFEHOI NDDCLPHCEEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x677E110", Offset = "0x677C910", VA = "0x18677E110")]
	internal int BGJAPKKKFFC(Material CFLFHCBFGIE, Color FDNIDKGGKLL, Color IBPJCOCMPLN, Color JJFIFHALOFI, Color GICAHBIPDBG, Color BJJDHKDBCNF, Texture2D IMKEJGFFEJD, Vector4 IPBIIJEEMPB, Texture2D FJPAONAMPBK, Vector4 LFGIOGOJEBG, float KFPECIJPNBH, float OHLHIOKOLNB, Texture2D OHDGIFMBMOB, Vector4 BLMIDEAHLFN, float OOKNEOJANOA, Texture2D KFEKOCKLMCH, Color KFGEMLIHHME, Vector4 KHPKKHCDFMG, IDNEJHNIOEO PCFFMOAHAAO, PCOOGPNENBN HDBFGOLNBFE, NMIPMBEMGJG IKLHFGHGNGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x677FD40", Offset = "0x677E540", VA = "0x18677FD40")]
	private void KHLDHAKGGLE(List<Texture2D> NEJLHNPDAMC, [Out] Texture2DArray IMCGLDDHJGJ, [Out] Texture2DArray HIOMELIOCAO, [Out] Texture2DArray FDHBLOMAMGM, [Out] Texture2DArray FLKOADLCBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x677DFC0", Offset = "0x677C7C0", VA = "0x18677DFC0")]
	public void APBJAFGCPKP(Shader HCNOMBIEHDM, Renderer GHBIMLIJLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x677EE30", Offset = "0x677D630", VA = "0x18677EE30")]
	private void DMPADAKKOII(Shader HCNOMBIEHDM, Renderer GHBIMLIJLGK, int AGMAGNELEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67800B0", Offset = "0x677E8B0", VA = "0x1867800B0")]
	private Color PCHHLGCFHOF(Color GKKPNEFMHBD, IDNEJHNIOEO DOCPLINHPIO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x677ECE0", Offset = "0x677D4E0", VA = "0x18677ECE0")]
	private Color CFFPKBEDKFF(Color LNFDKOOHPAM, IDNEJHNIOEO DOCPLINHPIO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x677FFB0", Offset = "0x677E7B0", VA = "0x18677FFB0")]
	private bool NEHAEHDFHEA(Texture2D IFGLGGOMOPL, PCOOGPNENBN AJBECKEBCAN, [Out] Texture2D GPLDJLDKFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x677FF00", Offset = "0x677E700", VA = "0x18677FF00")]
	private void KIHDJPLCNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x677FB80", Offset = "0x677E380", VA = "0x18677FB80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6777C60", Offset = "0x6776460", VA = "0x186777C60")]
			get
			{
				return default(NPONJLDPMAN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IKDKKLKECDH MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6777CB0", Offset = "0x67764B0", VA = "0x186777CB0")]
			get
			{
				return default(IKDKKLKECDH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x856BA0", Offset = "0x8553A0", VA = "0x180856BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x85FD30", Offset = "0x85E530", VA = "0x18085FD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x67778E0", Offset = "0x67760E0", VA = "0x1867778E0")]
		public Material[] BFIIEPOHMGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x67779D0", Offset = "0x67761D0", VA = "0x1867779D0")]
		public static void IELLBPLJIFD(AvatarItemMaterial PKACLIAFEPJ, Material GIIKGEKINDH, int ABEOMGGAPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6777B90", Offset = "0x6776390", VA = "0x186777B90")]
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
	[Cpp2IlInjected.Address(RVA = "0x6777D70", Offset = "0x6776570", VA = "0x186777D70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x677B060", Offset = "0x6779860", VA = "0x18677B060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x677B670", Offset = "0x6779E70", VA = "0x18677B670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int CFFONAKGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x677B5B0", Offset = "0x6779DB0", VA = "0x18677B5B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x677AC50", Offset = "0x6779450", VA = "0x18677AC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int HBMDLLOJIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x677AE30", Offset = "0x6779630", VA = "0x18677AE30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x677AC80", Offset = "0x6779480", VA = "0x18677AC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x677B680", Offset = "0x6779E80", VA = "0x18677B680")]
	public HHGHLBHJHGC(int JPGPFGMDFFJ, int JOAOBPKBJPK, int OFICJAKPOPC, int ENKLOOOFMNC, Allocator CHDJMCMMMLJ, int LKHEAAKNHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x677AFF0", Offset = "0x67797F0", VA = "0x18677AFF0")]
	public void EDDLNIEMBEB(int DHNLEFJCEAH, Vector3 NJJHKDBJDAC, Vector3 IPBCPNHEHBB, Vector4 DOGPFNGIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x677AC90", Offset = "0x6779490", VA = "0x18677AC90")]
	public void DDMBNNDLMDO(int DHNLEFJCEAH, BoneWeight CLPIOJNHBDJ, NativeSlice<byte> DBKJBDCMJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x677AC60", Offset = "0x6779460", VA = "0x18677AC60")]
	public Color CIPADPJBGGE(int DHNLEFJCEAH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x677AC30", Offset = "0x6779430", VA = "0x18677AC30")]
	public void ABEFFJMJNGG(int DHNLEFJCEAH, Color DDJHOHBDMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x677B070", Offset = "0x6779870", VA = "0x18677B070")]
	public void HDMLHMIPCGG(byte BKALJKAMJJI, int DHNLEFJCEAH, Vector2 EMLOHHMFJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x677B220", Offset = "0x6779A20", VA = "0x18677B220")]
	public void KAFEMIOCBEL(int DHNLEFJCEAH, int EDFEBNBLMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x677B580", Offset = "0x6779D80", VA = "0x18677B580")]
	public bool MBKPEHHBCJO(int BKALJKAMJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x677B150", Offset = "0x6779950", VA = "0x18677B150")]
	public void HKLOKJAPOPO(int MJDDAIDLEAO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x677B5C0", Offset = "0x6779DC0", VA = "0x18677B5C0")]
	public int[] ODKFFGGLMOE(int MJDDAIDLEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x677B0C0", Offset = "0x67798C0", VA = "0x18677B0C0")]
	private NativeSlice<int> HIAAMJIGNJN(int MJDDAIDLEAO)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x677AE40", Offset = "0x6779640", VA = "0x18677AE40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x677B230", Offset = "0x6779A30", VA = "0x18677B230")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int MHKAMAIMFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x100E810", Offset = "0x100D010", VA = "0x18100E810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int OMKKHCGEBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x677C1E0", Offset = "0x677A9E0", VA = "0x18677C1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int MCCMDICLGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x677C0F0", Offset = "0x677A8F0", VA = "0x18677C0F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x677C210", Offset = "0x677AA10", VA = "0x18677C210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int DIPIJGHDLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x677C100", Offset = "0x677A900", VA = "0x18677C100")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x677C260", Offset = "0x677AA60", VA = "0x18677C260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int OCAGAFPJIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x677BE80", Offset = "0x677A680", VA = "0x18677BE80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x677C240", Offset = "0x677AA40", VA = "0x18677C240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GNMEONFECFB HFLHFFEHFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x677C230", Offset = "0x677AA30", VA = "0x18677C230")]
		get
		{
			return default(GNMEONFECFB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x677BE70", Offset = "0x677A670", VA = "0x18677BE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public byte ELBNJADKBJM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x677C250", Offset = "0x677AA50", VA = "0x18677C250")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x677C220", Offset = "0x677AA20", VA = "0x18677C220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public ABOMMDNNEFK NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x677C270", Offset = "0x677AA70", VA = "0x18677C270")]
		get
		{
			return default(ABOMMDNNEFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x677C790", Offset = "0x677AF90", VA = "0x18677C790")]
	public JAFHMCOFADM(IList<Mesh> PMMMOPOAEHG, IList<Matrix4x4> ILMHAIKBKKP, IList<bool> ELIMPKJEPNP, byte GHHAMCLNJHM, IList<byte[]> FFDICJIFLNJ, IList<int> ECLOBPKDDJL, IList<bool> MLACCLNDBHG, IList<int> HICAHCGIPFN, IList<int> FIBPFBMKFIN, IList<int> MPPIEEAMPNA, Allocator CHDJMCMMMLJ, GNMEONFECFB FJPGPFOHGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x677C110", Offset = "0x677A910", VA = "0x18677C110")]
	public HHGHLBHJHGC GPNBBLPGFJJ(Allocator CHDJMCMMMLJ)
	{
		return default(HHGHLBHJHGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x677BE90", Offset = "0x677A690", VA = "0x18677BE90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[OJAAPNLEIHM]
public class KPEJLBFLIFK : BAAPDJDFOIL
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x67812A0", Offset = "0x677FAA0", VA = "0x1867812A0")]
	public JAFHMCOFADM JOEHHKCEINB()
	{
		return default(JAFHMCOFADM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x676F710", Offset = "0x676DF10", VA = "0x18676F710")]
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
	[Cpp2IlInjected.Address(RVA = "0xA2FB00", Offset = "0xA2E300", VA = "0x180A2FB00")]
	public CMHENJFEHOI(Material GIIKGEKINDH, IDNEJHNIOEO PCFFMOAHAAO, PCOOGPNENBN HDBFGOLNBFE, NMIPMBEMGJG IKLHFGHGNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6778E10", Offset = "0x6777610", VA = "0x186778E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA2F850", Offset = "0xA2E050", VA = "0x180A2F850", Slot = "4")]
	public bool Equals(CMHENJFEHOI OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6778C80", Offset = "0x6777480", VA = "0x186778C80", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6778D70", Offset = "0x6777570", VA = "0x186778D70", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public GLPJJIEONMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA2C250", Offset = "0xA2AA50", VA = "0x180A2C250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x677A4F0", Offset = "0x6778CF0", VA = "0x18677A4F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	public static void OONKJJMBDJE(string DKFNFHGODON, int JMKELNHPPCF, long ILJAAMOBPMB, long FNIHGDMMNON, long GGINLMOMDKJ, long EJMKACCHJDG, long NEAGBBGFPKE, long MBLCHPGOCMI, long CCFBOANMLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x67790B0", Offset = "0x67778B0", VA = "0x1867790B0")]
	public static GOOHGCNPLOF EJNLGLJGHLO(JobHandle DABNJNCEFAN, bool OBGJKDHLFGI, bool GCJGIKJCMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6779040", Offset = "0x6777840", VA = "0x186779040")]
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
	[Cpp2IlInjected.Address(RVA = "0x67772C0", Offset = "0x6775AC0", VA = "0x1867772C0")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void LAHBKIPICAO(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5A91360", Offset = "0x5A8FB60", VA = "0x185A91360")]
	[UnityEngine.Scripting.Preserve]
	public ALDBDHFAEPC([OMAPKKAGFIL(null)] KAMLGKGKOBL HLMKDLMBKLO, [OMAPKKAGFIL(null)] PLBGCIENHLF BMBMPAMFPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6777250", Offset = "0x6775A50", VA = "0x186777250")]
	private void INKNBHIFCOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6777880", Offset = "0x6776080", VA = "0x186777880", Slot = "4")]
	public void NOOFMDHAOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x67773C0", Offset = "0x6775BC0", VA = "0x1867773C0", Slot = "5")]
	public GBMNPHMLGKB<Texture2D> MPEPEFKJFGA(LFDCJCJMMGM HLBMAJHLBDM, [Optional] OFKHGODDDHI LDMPLMIKDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6777110", Offset = "0x6775910", VA = "0x186777110")]
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
	[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAAFE00", VA = "0x180AB1600")]
	public PFDGDHGOBNO(GameObject HAIDJCMMNJE, AvatarItemMaterial MPCHMAIKIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6781890", Offset = "0x6780090", VA = "0x186781890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6779F80", Offset = "0x6778780", VA = "0x186779F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x677A480", Offset = "0x6778C80", VA = "0x18677A480", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x677ABA0", Offset = "0x67793A0", VA = "0x18677ABA0")]
	private HBPNEGLCFDL(Task<(GameObject, AvatarItemMaterial)> LEDCCMOCHJB, GBMNPHMLGKB<GameObject> LLPLMDBEFGO, GBMNPHMLGKB<AvatarItemMaterial> EFFALMLDAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x677A790", Offset = "0x6778F90", VA = "0x18677A790")]
	public static HBPNEGLCFDL JGIIBNEOBDO(AssetReference EKKJHCNNOBB, [Optional] AssetReference FDACPNPAAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x677A670", Offset = "0x6778E70", VA = "0x18677A670", Slot = "11")]
	protected override PFDGDHGOBNO DOCHOJKICPF(Task<(GameObject, AvatarItemMaterial)> OMBNLOMPPEF)
	{
		return default(PFDGDHGOBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x677A710", Offset = "0x6778F10", VA = "0x18677A710", Slot = "12")]
	protected override void GLGFOCIIMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x677A540", Offset = "0x6778D40", VA = "0x18677A540")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public FLOHOJEBPIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6779200", Offset = "0x6777A00", VA = "0x186779200")]
			internal object EPHIGJDHDEL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x6779450", Offset = "0x6777C50", VA = "0x186779450")]
			internal object KOPEHCEAKGN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private GBMNPHMLGKB<MaterialMapAsset> IIMJMBJHGDI;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x67817B0", Offset = "0x677FFB0", VA = "0x1867817B0")]
		public LLEBPMBOPIG(GBMNPHMLGKB<MaterialMapAsset> IIMJMBJHGDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6781390", Offset = "0x677FB90", VA = "0x186781390", Slot = "11")]
		protected override Material[] DOCHOJKICPF(Task<MaterialMapAsset> LEDCCMOCHJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6781480", Offset = "0x677FC80", VA = "0x186781480", Slot = "12")]
		protected override void GLGFOCIIMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x67814E0", Offset = "0x677FCE0", VA = "0x1867814E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6781230", Offset = "0x677FA30", VA = "0x186781230")]
		public KACCDGJBNBP(Task<Material[]> LEDCCMOCHJB, List<GBMNPHMLGKB<Material>> GHJAKKOFDML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x67810A0", Offset = "0x677F8A0", VA = "0x1867810A0", Slot = "11")]
		protected override Material[] DOCHOJKICPF(Task<Material[]> OMBNLOMPPEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x67810F0", Offset = "0x677F8F0", VA = "0x1867810F0", Slot = "12")]
		protected override void GLGFOCIIMBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6780BF0", Offset = "0x677F3F0", VA = "0x186780BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6781AA0", Offset = "0x67802A0", VA = "0x186781AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x677BAC0", Offset = "0x677A2C0", VA = "0x18677BAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x677BE00", Offset = "0x677A600", VA = "0x18677BE00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6779F50", Offset = "0x6778750", VA = "0x186779F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x67799F0", Offset = "0x67781F0", VA = "0x1867799F0")]
		public GPLHFGMFLBD HJDLAPLOFGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6779CE0", Offset = "0x67784E0", VA = "0x186779CE0")]
		[AsyncStateMachine(typeof(IOJDBDOFEOJ))]
		public Task<GPLHFGMFLBD> MKMEIDNFGCC(int OMKAOBOICNG, int EMJMFFHKMGC, int CBICNGAPCGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x67798D0", Offset = "0x67780D0", VA = "0x1867798D0")]
		public NoseFaceOption EHLNBFHHNOH(int BGMJIJJAPOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6779B60", Offset = "0x6778360", VA = "0x186779B60")]
		public SelectableFaceOption MHJFPPDGKJA(FaceFeatureType PKKJLBIABIH, CIJBFEOBFPG DMABPPCLGPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6779970", Offset = "0x6778170", VA = "0x186779970")]
		public int EPIGKHDHLME(CIJBFEOBFPG DMABPPCLGPE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x67796A0", Offset = "0x6777EA0", VA = "0x1867796A0")]
		private void BAPOMBOLKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2B19F60", Offset = "0x2B18760", VA = "0x182B19F60")]
		private void PCNMEKLGFPG<T>(IDictionary<CIJBFEOBFPG, T> ENCKOMKBEOC, IReadOnlyList<T> FHIBBDMNBLE) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6779E10", Offset = "0x6778610", VA = "0x186779E10")]
		public CIJBFEOBFPG MPMDNBALMOO(FaceFeatureType PKKJLBIABIH)
		{
			return default(CIJBFEOBFPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6779A40", Offset = "0x6778240", VA = "0x186779A40")]
		public CIJBFEOBFPG KEILKEMLPHH(FaceFeatureType PKKJLBIABIH)
		{
			return default(CIJBFEOBFPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6779EC0", Offset = "0x67786C0", VA = "0x186779EC0")]
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
