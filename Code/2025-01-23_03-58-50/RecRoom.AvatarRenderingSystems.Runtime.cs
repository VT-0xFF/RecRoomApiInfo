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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DA27D0", Offset = "0x6DA0FD0", VA = "0x186DA27D0", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6DB0810", Offset = "0x6DAF010", VA = "0x186DB0810", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0730", Offset = "0x6DAEF30", VA = "0x186DB0730", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6DB07D0", Offset = "0x6DAEFD0", VA = "0x186DB07D0")]
		public RecNetCDNAssetReference(RecNetCDNKey KCGKBDGKIOP)
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
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8BE300", Offset = "0x8BCB00", VA = "0x1808BE300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0850", Offset = "0x6DAF050", VA = "0x186DB0850")]
		public static RecNetCDNKey CIKBOPKAAHO(string FGLPPOBNHBI, string MKEKKNDLGJF = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x655AFF0", Offset = "0x65597F0", VA = "0x18655AFF0")]
		public void NDAHBLIIGFD(string FCFDLALJDNK, string MLPIEBMLKAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0950", Offset = "0x6DAF150", VA = "0x186DB0950")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CEOCIAMIFJE]
public class IJNEJABAIDL : HLBFEEALFNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> KFLFHDFBHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> FKJBCPOOAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> PCNJEFFIBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> IFOBFKCMCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> PJBHNGHOBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> ELJLHMDODCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> HHFLGOPBHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator MGKOJFAAGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected BDBJJGAKCLO DJAHKIHIKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte FGHJJLCLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> GHONGGBHCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> JINIKCHHJNC;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F300", Offset = "0x6D9DB00", VA = "0x186D9F300", Slot = "4")]
	public void INDEEDGJMKE(Mesh CGIEBOGCCKF, Matrix4x4 BAPJNJGEKNN, byte[] OFHOOBGMHDP, bool ICMHKKLAPKJ = false, EAIGMANLNFK.LFNICJCICHD NKOAPEHBIKH = (EAIGMANLNFK.LFNICJCICHD)0, int MMKNHANONKJ = -1, bool ANMKMKHONHA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F510", Offset = "0x6D9DD10", VA = "0x186D9F510", Slot = "5")]
	public void PHAJDEIEPIM(Allocator MOBIJPCBMOB, BDBJJGAKCLO PBNGBAKKBNK, byte KACMHBDGKHB, [Optional] IList<int> JJNAHMECMGF, [Optional] IList<int> FOEBCBPBFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F0A0", Offset = "0x6D9D8A0", VA = "0x186D9F0A0")]
	private static void EGMDNLLBKGP(Mesh CGIEBOGCCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F550", Offset = "0x6D9DD50", VA = "0x186D9F550")]
	public IJNEJABAIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CEOCIAMIFJE]
public struct GOJBIOBBOJM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public HBFFCCNNDFC DDAPEHNGLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int NBHOGONLJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public LCDIKJDKFJB COKHAEPACFG;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BBC0", Offset = "0x6D9A3C0", VA = "0x186D9BBC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CEOCIAMIFJE]
[NativeContainer]
public struct LCDIKJDKFJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct AIDIGPMMGHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 AEGEJEKEIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 LHHMNOGMEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 FKLEHDCHMOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct FHGIPFOHJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float GHLIKAMJPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float FDBKDEEPMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float LNPJBPMDICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float EJKLMFJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte EJBEOHNELJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte EAGCPLIFGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte DILKOGNECLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte CMGINNHCGNE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct JIBNOAPLNCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half GHLIKAMJPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half FDBKDEEPMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half LNPJBPMDICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half EJKLMFJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte EJBEOHNELJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte EAGCPLIFGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte DILKOGNECLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte CMGINNHCGNE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct HCIOGOHOPIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 LCDEMOPFJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 PPMBLKMJDHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct JMFPLANEJBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 LCDEMOPFJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 PPMBLKMJDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 IADLABMDPIH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct FKOGCFKLIJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 LCDEMOPFJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 PPMBLKMJDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 IADLABMDPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 CCLNHIEIOLE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BLOCMGBBFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 LCDEMOPFJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 PPMBLKMJDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 IADLABMDPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 CCLNHIEIOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 BCLBHLFDHPE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CJKFADINFLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float GHLIKAMJPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float FDBKDEEPMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float LNPJBPMDICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float EJKLMFJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int EJBEOHNELJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int EAGCPLIFGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int DILKOGNECLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int CMGINNHCGNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct CCNKLBLGNIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color LCDEMOPFJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 PPMBLKMJDHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct IEBOOMIBALE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color LCDEMOPFJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 PPMBLKMJDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 IADLABMDPIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PHGHMJLDEBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color LCDEMOPFJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 PPMBLKMJDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 IADLABMDPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 CCLNHIEIOLE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct EPMOKBCGBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color LCDEMOPFJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 PPMBLKMJDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 IADLABMDPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 CCLNHIEIOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 BCLBHLFDHPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool HIOCDCBDMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<AIDIGPMMGHL> IEMMLKDNCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<HCIOGOHOPIG> IOECBBHFFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<JMFPLANEJBB> FKOAAPHINKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<FKOGCFKLIJP> PDCAGBBNEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BLOCMGBBFEA> PJGIJAIGBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<JIBNOAPLNCN> JNCNDGGIPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<FHGIPFOHJOK> ABOLCPNGAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<CCNKLBLGNIH> FFBPAGCEEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<IEBOOMIBALE> LHHFGAOMKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<PHGHMJLDEBC> JKAGPHKLMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<EPMOKBCGBGP> AOILHKMJNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<CJKFADINFLF> CEMKMPOOGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> MOCLLGFPOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> NCFEFPPIEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> CBEDDDHEEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> ADFIBAIOEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> FDJELCMBONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> FFEBIDKKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> IDPMCLOHOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> MHIAMMKHJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> OFGFBCNFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool AGNAONBPHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool KKMIPFCDMEP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FPCKEKHECLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1CC0", Offset = "0x6DA04C0", VA = "0x186DA1CC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0CF0", Offset = "0x6D9F4F0", VA = "0x186DA0CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BNKALBOLBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D9FE60", Offset = "0x6D9E660", VA = "0x186D9FE60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0590", Offset = "0x6D9ED90", VA = "0x186DA0590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NLPFJCPMGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DA08E0", Offset = "0x6D9F0E0", VA = "0x186DA08E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DA08D0", Offset = "0x6D9F0D0", VA = "0x186DA08D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GKGJAEFAGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0D00", Offset = "0x6D9F500", VA = "0x186DA0D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA1DA0", Offset = "0x6DA05A0", VA = "0x186DA1DA0")]
	public LCDIKJDKFJB(int EOINPDOKINC, int IJINDPAOGID, int GIBDKIDEKMB, int BJHPCBANKDN, Allocator MOBIJPCBMOB, int KOHPGNCBDNF, CBNJPNJADMP JOPPCDNPAJF, bool AGNAONBPHEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0500", Offset = "0x6D9ED00", VA = "0x186DA0500")]
	public void EPLIMOLGKLD(int ECDOOAABOPD, Vector3 JBEGGBDGOGM, Vector3 JOADBJGEHIP, Vector4 EBDGHJJPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FE70", Offset = "0x6D9E670", VA = "0x186D9FE70")]
	public void DIHDBAKMHBB(int ECDOOAABOPD, BoneWeight EIKJKBAEHDJ, NativeSlice<byte> OFHOOBGMHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA05A0", Offset = "0x6D9EDA0", VA = "0x186DA05A0")]
	public Color GMDINGBANLD(int ECDOOAABOPD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA08F0", Offset = "0x6D9F0F0", VA = "0x186DA08F0")]
	public void JIDCCIIILCC(int ECDOOAABOPD, Color HPEMNIMCDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FAB0", Offset = "0x6D9E2B0", VA = "0x186D9FAB0")]
	public void AMCJNNBOACE(byte BAONDMFEGDF, int ECDOOAABOPD, Vector2 OAMKHHDHFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0D70", Offset = "0x6D9F570", VA = "0x186DA0D70")]
	public void LIKJNEFOOCD(int ECDOOAABOPD, int CFLPNBCLAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FA50", Offset = "0x6D9E250", VA = "0x186D9FA50")]
	public bool AAFMJAOBHAD(int BAONDMFEGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6DA1CD0", Offset = "0x6DA04D0", VA = "0x186DA1CD0")]
	public void PHCFHNFADIA(int LPBBLDHOHLK, int MHPJBPKHONI, int OANKAJFHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DA02A0", Offset = "0x6D9EAA0", VA = "0x186DA02A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0D80", Offset = "0x6D9F580", VA = "0x186DA0D80")]
	public Mesh MIDDGMLKNBE([Optional] string KLCAHMJNBKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
[CEOCIAMIFJE]
[NativeContainer]
public struct HBFFCCNNDFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray BPDACKABKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> LDINGIJPKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> AKDAHAPFCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> MHIAMMKHJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> PKEGJGKPJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> FGLHFPNADFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> KHJFEINDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> EENMLBDJNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> EINHBCDDAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> DJIHKCMAMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> NOHCDGACCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> ANMKMKHONHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> MMKNHANONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool AGNAONBPHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> HBCBGFGGEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool KKMIPFCDMEP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int ODIBBBECMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D920", Offset = "0x6D9C120", VA = "0x186D9D920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MEILFFKLINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D960", Offset = "0x6D9C160", VA = "0x186D9D960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EMFGEJAKDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D9DBF0", Offset = "0x6D9C3F0", VA = "0x186D9DBF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MNAEKHAAHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D6A0", Offset = "0x6D9BEA0", VA = "0x186D9D6A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D6B0", Offset = "0x6D9BEB0", VA = "0x186D9D6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FPCKEKHECLH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D9DBE0", Offset = "0x6D9C3E0", VA = "0x186D9DBE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D940", Offset = "0x6D9C140", VA = "0x186D9D940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int HFANCCCBMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D970", Offset = "0x6D9C170", VA = "0x186D9D970")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D980", Offset = "0x6D9C180", VA = "0x186D9D980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BDBJJGAKCLO CAMFJEABEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D840", Offset = "0x6D9C040", VA = "0x186D9D840")]
		get
		{
			return default(BDBJJGAKCLO);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D6C0", Offset = "0x6D9BEC0", VA = "0x186D9D6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte BKPNNBOBIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D950", Offset = "0x6D9C150", VA = "0x186D9D950")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D930", Offset = "0x6D9C130", VA = "0x186D9D930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public ACKBBNEBJAE DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D990", Offset = "0x6D9C190", VA = "0x186D9D990")]
		get
		{
			return default(ACKBBNEBJAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DCC0", Offset = "0x6D9C4C0", VA = "0x186D9DCC0")]
	public HBFFCCNNDFC(IList<Mesh> FKOGPNIGJHE, IList<Matrix4x4> BDEBKJMOBID, IList<bool> ANMKMKHONHA, byte KACMHBDGKHB, IList<byte[]> JAOOJKGGAJL, IList<int> DADDPMOKGPL, IList<bool> PIGIPJBOIKO, IList<int> MMKNHANONKJ, IList<int> JJNAHMECMGF, IList<int> HEGINCOIBFG, Allocator MOBIJPCBMOB, BDBJJGAKCLO PBNGBAKKBNK, bool AGNAONBPHEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D850", Offset = "0x6D9C050", VA = "0x186D9D850")]
	public LCDIKJDKFJB GHODMJCNEGE(Allocator MOBIJPCBMOB, CBNJPNJADMP JOPPCDNPAJF)
	{
		return default(LCDIKJDKFJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D6D0", Offset = "0x6D9BED0", VA = "0x186D9D6D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[CEOCIAMIFJE]
public class LABJGCDGNJK : IJNEJABAIDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool DOPLGFHFHME;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker LOMFDOPDBJH;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F780", Offset = "0x6D9DF80", VA = "0x186D9F780")]
	public HBFFCCNNDFC ACMBCCCCOFB()
	{
		return default(HBFFCCNNDFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FA40", Offset = "0x6D9E240", VA = "0x186D9FA40")]
	public LABJGCDGNJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ACKBBNEBJAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData FBALMFHLONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> MHIAMMKHJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> DOKFMDIHHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int MGAPIAJGAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 GMJPPMGCNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int KFDELGIMFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> OFHOOBGMHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool CFCGCOHPPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int NMOBKIAOJAC;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NJFHCIPENBA : JHNODDJNGEL
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AGAPBGCFBFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AEIPNJOAFNB avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public NJFHCIPENBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public DGGJLAPANLP buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action<KeyValuePair<string, MGNFCCKNAGM<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AGAPBGCFBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D99A60", Offset = "0x6D98260", VA = "0x186D99A60")]
		internal bool NNIKNGGHGCN(DJEJFNMFNJK item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D998C0", Offset = "0x6D980C0", VA = "0x186D998C0")]
		internal void IGLNHLFBELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D998A0", Offset = "0x6D980A0", VA = "0x186D998A0")]
		internal void CAPMBHGDONN(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6D998C0", Offset = "0x6D980C0", VA = "0x186D998C0")]
		internal void CKAIGOOKECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6D998A0", Offset = "0x6D980A0", VA = "0x186D998A0")]
		internal void BJEONPOGGGN(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6D99870", Offset = "0x6D98070", VA = "0x186D99870")]
		internal void ANEHIOCDHAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6D99AB0", Offset = "0x6D982B0", VA = "0x186D99AB0")]
		internal void PDKLJOPHPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D999A0", Offset = "0x6D981A0", VA = "0x186D999A0")]
		internal void IIHFLJFKAIN(Dictionary<string, MGNFCCKNAGM<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6D998E0", Offset = "0x6D980E0", VA = "0x186D998E0")]
		internal void FCJBAGGMOMI(KeyValuePair<string, MGNFCCKNAGM<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
		internal MOPOHKAGKCI DBOJBMDJOIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EAGBNKHFBKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AGAPBGCFBFE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EAGBNKHFBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B4C0", Offset = "0x6D99CC0", VA = "0x186D9B4C0")]
		internal CNMFFFELHKO NACAJDHLHEH(int lod)
		{
			return default(CNMFFFELHKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class PMGMOHNDFIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AKLEHMINLPM<Dictionary<string, MGNFCCKNAGM<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public PMGMOHNDFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		internal AKLEHMINLPM<Dictionary<string, MGNFCCKNAGM<Texture2D>>> CPDEBMONMJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GBAOPDOMELK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public List<DGGJLAPANLP> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GBAOPDOMELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D9BA90", Offset = "0x6D9A290", VA = "0x186D9BA90")]
		internal void LOIBOEIAKAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FJMICKPKEEL : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public NJFHCIPENBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public List<EMOPPALHKBK> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public List<DGGJLAPANLP> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Func<int, CNMFFFELHKO> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public EMIJBNBKBIJ materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public FJMICKPKEEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B7C0", Offset = "0x6D99FC0", VA = "0x186D9B7C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6D9BA40", Offset = "0x6D9A240", VA = "0x186D9BA40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CFDDDGAAEBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public JGKPNINCKEI cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CFDDDGAAEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x92AFB0", Offset = "0x9297B0", VA = "0x18092AFB0")]
		internal void OPADOMNNFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x92AF90", Offset = "0x929790", VA = "0x18092AF90")]
		internal void DGDOMAKIMIO(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DFBPJJBCHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public NJFHCIPENBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DFBPJJBCHLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FHGMMCEPPAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public LCDIKJDKFJB defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public HBFFCCNNDFC defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public DFBPJJBCHLI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FHGMMCEPPAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B580", Offset = "0x6D99D80", VA = "0x186D9B580")]
		internal void GHHDIOGGNKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xDE9250", Offset = "0xDE7A50", VA = "0x180DE9250")]
		internal void AGEABPIHIMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IAAAMPCMNAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public KBIPNDNDEOP legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public MLOJNNBCLBI legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public DFBPJJBCHLI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public IAAAMPCMNAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D9EE60", Offset = "0x6D9D660", VA = "0x186D9EE60")]
		internal void OGMNFOLOOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xDE9CD0", Offset = "0xDE84D0", VA = "0x180DE9CD0")]
		internal void LPHIKMPJEFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class AOELFMDJGLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AEIOBEGHMKA overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AOELFMDJGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6D99AE0", Offset = "0x6D982E0", VA = "0x186D99AE0")]
		internal bool ECCJANLHNCH(KeyValuePair<string, DJEJFNMFNJK> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly GCOJJNPJFGN MDILBLMCLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly GCOJJNPJFGN DLCBFBEBDDF;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static float DDLIDJHCOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private AvatarConfiguration PGAEHCNMADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Transform NMCDLNFEGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private AvatarSkinAssetItem CEHFNALEHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AssetReference NOLCPEEPFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private GameObject LLILNFDECAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private GameObject JOJBBBIBHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private SkinnedMeshRenderer MBIADPBEAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private AvatarSkinnedMeshBoneOrderRemapsData EGCLDEFAJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform[] KMLIDFLEPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Matrix4x4[] KMBGKFMMMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Material DJJGAGNBIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Material KBFNDKCKKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Material BOEHFDNJHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Shader GHOMPIMCHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Shader KOBFNGCFOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Animator KGMFIPIKCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Renderer[] DOCKDABBCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EAIGMANLNFK.LFNICJCICHD KOMGFPMCDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarBodyPartShapesManager HEHHBCMODAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private IReadOnlyDictionary<string, Transform> CJMDAKAENHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarFaceShapeData.PJCIPJHBAPP KDAMCBCBAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AvatarBodyShapeData.EGIDOCOEJPI BFKJHNMCPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool NFCACJBFKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool DEKANKFPHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color ACIMKKJGEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color PHAENJCAEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color EEIPIFKAALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Color? DKNHEHFDMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Color? FJHPIFAIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Color? DOECPKLOLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Color? NGGPLHHBNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Texture2D IBFHOFBGBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Texture2D PBCAADBBOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[CanBeNull]
	private DJEJFNMFNJK JCBPDLPDNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Texture CEJHBBBOLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Color GNIFPIDFPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Dictionary<Renderer, EMIJBNBKBIJ> DDBKGMPLBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<Renderer, EMIJBNBKBIJ> GBMJNDLBGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Dictionary<string, List<BEJAMHIFFPM>> LIDCMCJICCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Dictionary<string, List<BEJAMHIFFPM>> KJALBOGLKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<FGNKNNJACKL> PBJOIPBMINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<FGNKNNJACKL> INJMFFNDOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly List<FGNKNNJACKL> FIJEBDILKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly List<FGNKNNJACKL> PKBBEEHFPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Dictionary<BEJAMHIFFPM, Material> OGJMDMMFIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Dictionary<BEJAMHIFFPM, Material> PHENBFODGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private SkinnedMeshRenderer[] LMLFONBHIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private SkinnedMeshRenderer[] GLDKFMIOCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private SkinnedMeshRenderer[] PBMOHODNDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private SkinnedMeshRenderer[] EELEBIGOHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Dictionary<string, MGNFCCKNAGM<Texture2D>> IMKLFKIFGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<string, MGNFCCKNAGM<Texture2D>> NIFJBGGCMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private PGEPFFCGHEN AAPIJDAGGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private PGEPFFCGHEN PFDJDLFMICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private AdditionalHatData IOLBKDFBGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private AdditionalHatData GHEEBDDDHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private HairData PEEJJCAMCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private HairData GBKKJHMLJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private IOKFCBDBELC LBKANPKBAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool? HBMBCCKOCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PositionAndRotation JODHPMOOACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Transform BLKBBPIIIAI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material BPFAKKEJIHP;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Material JKJLOPKPFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<string, DJEJFNMFNJK> GAJEILADIIM;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int DAMLOMFGEDH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int PODEMMKMONA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int LFFEJKGALEO;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int MAIPJOAIFJH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int HAKMJAAHDMC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int JJMMJJNOGPB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int NJCCHKOGEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private bool DDCDBJLMNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private List<Action> BAAFHJKFGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private AHGGHFEHEPP FNJGJJFGKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private SkinnedMeshRenderer[] OHHNIBCHOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int OEFODMGBMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool ANMIKNMODFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private int NEHMIAKGOEC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GCOJJNPJFGN PPGOCHBKMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GCOJJNPJFGN KMICHLFDFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public AvatarConfiguration DFOBANNLHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JKOGGICADKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CA00", VA = "0x180D5E200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD5DE00", Offset = "0xD5C600", VA = "0x180D5DE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Material HLGIKMDMMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7EF0", Offset = "0x6DA66F0", VA = "0x186DA7EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private Material IAEFIIIKGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6DA71E0", Offset = "0x6DA59E0", VA = "0x186DA71E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool INPNAAIOLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public HBPDIAMDKLD PCNKPJGKKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x92F1C0", Offset = "0x92D9C0", VA = "0x18092F1C0", Slot = "23")]
		get
		{
			return default(HBPDIAMDKLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Material HBEBPCNMPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC110", Offset = "0x8BA910", VA = "0x1808BC110", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public SkinnedMeshRenderer[] DJAHPBKHPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1801B90", Offset = "0x1800390", VA = "0x181801B90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Renderer[] EFECNOLCHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF10", Offset = "0xA7C710", VA = "0x180A7DF10", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool KJBKBKBAMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD820", Offset = "0x6DAC020", VA = "0x186DAD820", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EAIGMANLNFK.LFNICJCICHD JEFIBIHKDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2E0", Offset = "0x8BDAE0", VA = "0x1808BF2E0", Slot = "20")]
		get
		{
			return default(EAIGMANLNFK.LFNICJCICHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PEELKILCNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1C32CC0", Offset = "0x1C314C0", VA = "0x181C32CC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7460", Offset = "0x6DA5C60", VA = "0x186DA7460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool KALOHHPNNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6DA92E0", Offset = "0x6DA7AE0", VA = "0x186DA92E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private static bool IJJOJLAIKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4F60", Offset = "0x6DA3760", VA = "0x186DA4F60", Slot = "15")]
	public DGGJLAPANLP CMOACDOMBDJ(AEIPNJOAFNB HHOHBPIDLPK, bool MBHGAHNCAGP, int[] ECCCKABODGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD7F0", Offset = "0x6DABFF0", VA = "0x186DAD7F0", Slot = "14")]
	public DGGJLAPANLP PNLLAFALJIO(AEIPNJOAFNB HHOHBPIDLPK, bool MBHGAHNCAGP, int[] ECCCKABODGB, Func<Dictionary<string, DJEJFNMFNJK>, (DGGJLAPANLP, AKLEHMINLPM<Dictionary<string, MGNFCCKNAGM<Texture2D>>>)> BHFMHDPMLCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2C60", Offset = "0x6DA1460", VA = "0x186DA2C60")]
	public DGGJLAPANLP ALLKKIFEHNI(AEIPNJOAFNB HHOHBPIDLPK, bool MBHGAHNCAGP, int[] ECCCKABODGB, bool FIOPKODJMIJ, PGEPFFCGHEN NMHECAAOIGN, [Optional] Func<Dictionary<string, DJEJFNMFNJK>, (DGGJLAPANLP, AKLEHMINLPM<Dictionary<string, MGNFCCKNAGM<Texture2D>>>)> BHFMHDPMLCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8DF0", Offset = "0x6DA75F0", VA = "0x186DA8DF0")]
	private bool IEIFBFADPCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6DA98E0", Offset = "0x6DA80E0", VA = "0x186DA98E0")]
	private DGGJLAPANLP JJOFBCDPBND(bool MBHGAHNCAGP, List<EMOPPALHKBK> IFKLMLPDJCA, int[] ECCCKABODGB, Func<int, CNMFFFELHKO> CADJDEGOHJA, bool FIOPKODJMIJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4900", Offset = "0x6DA3100", VA = "0x186DA4900")]
	[IteratorStateMachine(typeof(FJMICKPKEEL))]
	private IEnumerator<IJKEOMMDACC> BKHLDIIMMAF(bool MBHGAHNCAGP, List<EMOPPALHKBK> IFKLMLPDJCA, int[] ECCCKABODGB, Func<int, CNMFFFELHKO> CADJDEGOHJA, EMIJBNBKBIJ PDEBKNDPJAE, Material PFFBGKIAAII, List<DGGJLAPANLP> KAFHEHLEJDG, bool ANEBCMLDCEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8090", Offset = "0x6DA6890", VA = "0x186DA8090")]
	private void EJGIOJNPGFM(List<EMOPPALHKBK> IFKLMLPDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA9F0", Offset = "0x6DA91F0", VA = "0x186DAA9F0")]
	private DGGJLAPANLP LDDOBJHFLJA(List<EMOPPALHKBK> IFKLMLPDJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6DA57B0", Offset = "0x6DA3FB0", VA = "0x186DA57B0")]
	private EBBFPAKHIHA DIIMOEHMIAM(List<EMOPPALHKBK> IFKLMLPDJCA, int PBCKDIKKJCB, bool MBHGAHNCAGP, CNMFFFELHKO AKANAFFGCPI, bool EBCKDMGJPOJ, EMIJBNBKBIJ PDEBKNDPJAE, Material PFFBGKIAAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8AE0", Offset = "0x6DA72E0", VA = "0x186DA8AE0", Slot = "25")]
	public void GHNHFNDMLDN(AvatarFaceShape OMCGAIAJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9FD0", Offset = "0x6DA87D0", VA = "0x186DA9FD0", Slot = "26")]
	public void KEBPNMKNCBB(AvatarBodyShape CBGLDGEOAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD400", Offset = "0x6DABC00", VA = "0x186DAD400", Slot = "28")]
	public void OKKGKHEHOIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA98D0", Offset = "0x6DA80D0", VA = "0x186DA98D0", Slot = "27")]
	public void JIPLEEHAFLM(bool CGGMPNIAHMK, bool OIKDINIEOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC830", Offset = "0x6DAB030", VA = "0x186DAC830")]
	private void NFPNJPILBHF(SkinnedMeshRenderer PHKNKNHFABB, int PBCKDIKKJCB, Mesh CGIEBOGCCKF, List<Material> OLJBJIGPECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4F90", Offset = "0x6DA3790", VA = "0x186DA4F90")]
	private static Material COAIDGIHFKK(Dictionary<BEJAMHIFFPM, Material> KKNGIJPJIIE, Material MJHJHMBIGAN, AGEOOIMHKJF GHJFOFFDIDB, DMGIDOOBPMF KLHPPCFCKIP, AEIOBEGHMKA ALHMBEPBCGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC530", Offset = "0x6DAAD30", VA = "0x186DAC530")]
	private static AGEOOIMHKJF MJAOJNDKBNP(EMOPPALHKBK OOAKFMJKDKO, int GOHKKLDBFAM)
	{
		return default(AGEOOIMHKJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6DD0", Offset = "0x6DA55D0", VA = "0x186DA6DD0")]
	private void DOJECOEKLDH(int FNFFHMPGFMC, Material KMOLIAGHFFN, EMOPPALHKBK OOAKFMJKDKO, [Out] Texture2D GNIHKNJJNJD, [Out] Vector4 BJLFCNHAGME, [Out] Texture2D HOMADOPBLNN, [Out] Texture2D GLCEGOGCDLH, [Out] Texture2D PFFOIOIPPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA7810", Offset = "0x6DA6010", VA = "0x186DA7810")]
	private void EHMBCOIOOFN(int FNFFHMPGFMC, Material KMOLIAGHFFN, EMOPPALHKBK OOAKFMJKDKO, [Out] Color HJHJIMLHCBH, [Out] Color KJODLKNHGNM, [Out] Color IAJHFMNBCPC, [Out] Color BOBBJLCFBAE, [Out] Color KNMKIAFBFGC, [Out] Color LLBNLMJIGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2A00", Offset = "0x6DA1200", VA = "0x186DA2A00")]
	private bool AKMFLKKLLKP(Material KMOLIAGHFFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8870", Offset = "0x6DA7070", VA = "0x186DA8870")]
	private static Material FMDFEDJKJLM(int FNFFHMPGFMC, ABPFGMCOOPL OOAKFMJKDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4E80", Offset = "0x6DA3680", VA = "0x186DA4E80")]
	private static DMGIDOOBPMF CJDPJMNMKDE(EMOPPALHKBK OOAKFMJKDKO, int GOHKKLDBFAM)
	{
		return default(DMGIDOOBPMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8EB0", Offset = "0x6DA76B0", VA = "0x186DA8EB0")]
	private static void IELPOAEIHCJ(Dictionary<string, List<BEJAMHIFFPM>> HHFOKDEELMJ, EMOPPALHKBK AENKKGNBDNE, Material MJHJHMBIGAN, AGEOOIMHKJF LJHKKNICJMJ, DMGIDOOBPMF DOPLPLBKGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DACC50", Offset = "0x6DAB450", VA = "0x186DACC50")]
	private static SkinnedMeshRenderer OALPAMNNOBM(Transform NHFOCEDPCMF, Transform GHJKMNOHIEK, SkinnedMeshRenderer[] FAOHBBNGEKO, int PBCKDIKKJCB, CNMFFFELHKO AKANAFFGCPI, bool MBHGAHNCAGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6DADE20", Offset = "0x6DAC620", VA = "0x186DADE20")]
	public NJFHCIPENBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA7510", Offset = "0x6DA5D10", VA = "0x186DA7510")]
	public void EHFCOOMFLME([In] FGPKKDONEAO OAMOCAHGEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9380", Offset = "0x6DA7B80", VA = "0x186DA9380")]
	public void NPBGKLCLCDF([In] HMCEMPHPCBB EPJLBJCGDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DA7460", Offset = "0x6DA5C60", VA = "0x186DA7460", Slot = "5")]
	public void KFOHCOKIPBO(int PBCKDIKKJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DACA20", Offset = "0x6DAB220", VA = "0x186DACA20", Slot = "10")]
	public void NKEJNLOBHAM(EIDJHFBIHJL DOPLPLBKGCI, Texture2D NOCDIJBAKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0")]
	public static bool EHDLKMJALPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6DA88F0", Offset = "0x6DA70F0", VA = "0x186DA88F0", Slot = "11")]
	public bool FNHCIGJKMGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DACE80", Offset = "0x6DAB680", VA = "0x186DACE80", Slot = "9")]
	public void OEOFOHDLNHN(AINGIJEMIFC LJHKKNICJMJ, Color? LCDEMOPFJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC970", Offset = "0x6DAB170", VA = "0x186DAC970")]
	private void NHLBCMKEAAF(Action JCGBILNDCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8A70", Offset = "0x6DA7270", VA = "0x186DA8A70", Slot = "6")]
	public void GBEOGFDNGPF(DJEJFNMFNJK AAJAFNMHMFI, Texture LOKFGIAFOEI, Color BBFHHIPEKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xD5DE00", Offset = "0xD5C600", VA = "0x180D5DE00", Slot = "7")]
	public void ADDGLOLILDF(bool ANEBCMLDCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1827400", Offset = "0x1825C00", VA = "0x181827400", Slot = "8")]
	public void MHJJMLFINAI(AHGGHFEHEPP OFGFBCNFINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4A30", Offset = "0x6DA3230", VA = "0x186DA4A30", Slot = "16")]
	public void BOLDLJGJBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9450", Offset = "0x6DA7C50", VA = "0x186DA9450", Slot = "29")]
	public void JDCAIBMFDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6DABA70", Offset = "0x6DAA270", VA = "0x186DABA70", Slot = "30")]
	public void MINLLHKFJCI([Optional] IOKFCBDBELC GNONKEKBDJI, [Optional] bool? OOOJDHLOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA94D0", Offset = "0x6DA7CD0", VA = "0x186DA94D0")]
	private bool JELLPDECFJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9360", Offset = "0x6DA7B60", VA = "0x186DA9360", Slot = "21")]
	public bool IMLFJBGNPHE(EAIGMANLNFK.LFNICJCICHD DIALOLLAGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6DA55E0", Offset = "0x6DA3DE0", VA = "0x186DA55E0")]
	private void DHFEFLHHEFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4A20", Offset = "0x6DA3220", VA = "0x186DA4A20")]
	private void BLKICFAIIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9180", Offset = "0x6DA7980", VA = "0x186DA9180")]
	private static void IKFAIDKDGIL(Dictionary<BEJAMHIFFPM, Material> KKNGIJPJIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD530", Offset = "0x6DABD30", VA = "0x186DAD530")]
	private static void OPNFKIFCBCO(Dictionary<Renderer, EMIJBNBKBIJ> FGEMBEFFECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA220", Offset = "0x6DA8A20", VA = "0x186DAA220")]
	private void KHMPPAJGGLM(SkinnedMeshRenderer[] FAOHBBNGEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8BA0", Offset = "0x6DA73A0", VA = "0x186DA8BA0")]
	private void GLJLCEPCHAK(SkinnedMeshRenderer FLIAFEBHCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC630", Offset = "0x6DAAE30", VA = "0x186DAC630")]
	private void MPPPAICGCJK(List<FGNKNNJACKL> KJGFJMLLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6DAB7A0", Offset = "0x6DA9FA0", VA = "0x186DAB7A0")]
	private void LNHPODJFMOK(Dictionary<string, MGNFCCKNAGM<Texture2D>> HHFOKDEELMJ, bool NCAIBLCDNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8820", Offset = "0x6DA7020", VA = "0x186DA8820")]
	private void FIFBNFPNJKJ(Dictionary<string, List<BEJAMHIFFPM>> HHFOKDEELMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAB920", Offset = "0x6DAA120", VA = "0x186DAB920")]
	private void MEMNEACMEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA090", Offset = "0x6DA8890", VA = "0x186DAA090")]
	private void KFNHEKMHHHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAACD0", Offset = "0x6DA94D0", VA = "0x186DAACD0")]
	private void LHPLEMKODCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9610", Offset = "0x6DA7E10", VA = "0x186DA9610")]
	private void JFGOCONBLFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA960", Offset = "0x6DA9160", VA = "0x186DAA960")]
	private void LBPHDOAEEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DA7DA0", Offset = "0x6DA65A0", VA = "0x186DA7DA0")]
	private void EICJLDMLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DA7CD0", Offset = "0x6DA64D0", VA = "0x186DA7CD0")]
	private void EHNNLFEOIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DA86B0", Offset = "0x6DA6EB0", VA = "0x186DA86B0")]
	private void FCMLKEEHKKB(bool CNFJCHAIDOL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6DA72D0", Offset = "0x6DA5AD0", VA = "0x186DA72D0")]
	private void EBIAHJKOKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA710", Offset = "0x6DA8F10", VA = "0x186DAA710")]
	private void KJIALGOILLC(bool CNFJCHAIDOL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD990", Offset = "0x6DAC190", VA = "0x186DAD990")]
	private void POOJCGFFNLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6DAB2A0", Offset = "0x6DA9AA0", VA = "0x186DAB2A0")]
	private void LKBCHPLLAFB(Material PFFBGKIAAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD280", Offset = "0x6DABA80", VA = "0x186DAD280")]
	private void OKGEHBJBPGC(Material PFFBGKIAAII, Color BNFDKDMBEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4C30", Offset = "0x6DA3430", VA = "0x186DA4C30")]
	private void CGOKMFPPDJO(Material PFFBGKIAAII, Color BNFDKDMBEAF, Color MDHMLBMHJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2860", Offset = "0x6DA1060", VA = "0x186DA2860")]
	private void AIPJLHLGFCP(Material PFFBGKIAAII, Color HJHJIMLHCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA96E0", Offset = "0x6DA7EE0", VA = "0x186DA96E0")]
	private void JHKMMIBHDGK(Material PFFBGKIAAII, Texture2D NOCDIJBAKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA7F0", Offset = "0x6DA8FF0", VA = "0x186DAA7F0")]
	private void KPHNGKODHJA(Material PFFBGKIAAII, Texture CPBBFELOJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA50F0", Offset = "0x6DA38F0", VA = "0x186DA50F0")]
	private void DDFENKBGLAN(Action<EMIJBNBKBIJ> FCPJCHEGGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8C40", Offset = "0x6DA7440", VA = "0x186DA8C40")]
	private void HKIFAEJDPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6DA69B0", Offset = "0x6DA51B0", VA = "0x186DA69B0")]
	private void DLHFFPFPOLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA340", Offset = "0x6DA8B40", VA = "0x186DAA340")]
	private void KIAABALIBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6DA5250", Offset = "0x6DA3A50", VA = "0x186DA5250")]
	public void DGIHIODNGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9380", Offset = "0x6DA7B80", VA = "0x186DA9380", Slot = "4")]
	private void INOFJKILNFG([In] HMCEMPHPCBB EPJLBJCGDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD690", Offset = "0x6DABE90", VA = "0x186DAD690")]
	[CompilerGenerated]
	private MOPOHKAGKCI PHHNNKKLNLL(EMOPPALHKBK DOCBAALINAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9EC0", Offset = "0x6DA86C0", VA = "0x186DA9EC0")]
	[CompilerGenerated]
	private void JMLLNPCEMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6DA88C0", Offset = "0x6DA70C0", VA = "0x186DA88C0")]
	[CompilerGenerated]
	private void FMIMFNAELFE(EMIJBNBKBIJ KMDNLDCLAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8790", Offset = "0x6DA6F90", VA = "0x186DA8790")]
	[CompilerGenerated]
	private void FDLHHONAINP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9430", Offset = "0x6DA7C30", VA = "0x186DA9430")]
	[CompilerGenerated]
	private void JBALIPOHNFJ(EMIJBNBKBIJ KMDNLDCLAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA7480", Offset = "0x6DA5C80", VA = "0x186DA7480")]
	[CompilerGenerated]
	private void EHADPIODPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA94B0", Offset = "0x6DA7CB0", VA = "0x186DA94B0")]
	[CompilerGenerated]
	private void JDFNLCAEMLC(EMIJBNBKBIJ KMDNLDCLAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAAC40", Offset = "0x6DA9440", VA = "0x186DAAC40")]
	[CompilerGenerated]
	private void LGACKDIHBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA73A0", Offset = "0x6DA5BA0", VA = "0x186DA73A0")]
	[CompilerGenerated]
	private void ECEJNCJFPDK(EMIJBNBKBIJ KMDNLDCLAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6DA73D0", Offset = "0x6DA5BD0", VA = "0x186DA73D0")]
	[CompilerGenerated]
	private void EEMOLLJEJLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC800", Offset = "0x6DAB000", VA = "0x186DAC800")]
	[CompilerGenerated]
	private void NCCGPIECELC(EMIJBNBKBIJ KMDNLDCLAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD760", Offset = "0x6DABF60", VA = "0x186DAD760")]
	[CompilerGenerated]
	private void PLNBFDKEEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD500", Offset = "0x6DABD00", VA = "0x186DAD500")]
	[CompilerGenerated]
	private void OMDJKCDCKPM(EMIJBNBKBIJ KMDNLDCLAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD6D0", Offset = "0x6DABED0", VA = "0x186DAD6D0")]
	[CompilerGenerated]
	private void PLHKEOCLCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC9F0", Offset = "0x6DAB1F0", VA = "0x186DAC9F0")]
	[CompilerGenerated]
	private void NIDKIHHLLJI(EMIJBNBKBIJ KMDNLDCLAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9F50", Offset = "0x6DA8750", VA = "0x186DA9F50")]
	[CompilerGenerated]
	private void KBHONMEPPAK(KeyValuePair<string, MGNFCCKNAGM<Texture2D>> KLPGNEJKOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6DACC40", Offset = "0x6DAB440", VA = "0x186DACC40")]
	[CompilerGenerated]
	private void NMHGIDKKLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9400", Offset = "0x6DA7C00", VA = "0x186DA9400")]
	[CompilerGenerated]
	private void JACCGFAAEOC(EMIJBNBKBIJ KMDNLDCLAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9170", Offset = "0x6DA7970", VA = "0x186DA9170")]
	[CompilerGenerated]
	private void IGPPDBJBCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8DC0", Offset = "0x6DA75C0", VA = "0x186DA8DC0")]
	[CompilerGenerated]
	private void HNPAHPINMCJ(EMIJBNBKBIJ KMDNLDCLAAE)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarElbowBendHelperController : MonoBehaviour, HMPFKGKOKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[Header("Scale")]
		[SerializeField]
		[FormerlySerializedAs("MinScaleValues")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private Vector3? GKIHNOCICPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private bool BHJHEJPHOEE;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6D99B60", Offset = "0x6D98360", VA = "0x186D99B60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A190", Offset = "0x6D98990", VA = "0x186D9A190", Slot = "4")]
		public void UpdateController(float HKMEEJMCKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA261D0", Offset = "0xA249D0", VA = "0x180A261D0", Slot = "6")]
		public void SetEnabled(bool INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D99C40", Offset = "0x6D98440", VA = "0x186D99C40")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A650", Offset = "0x6D98E50", VA = "0x186D9A650")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendTargetController : MonoBehaviour, HMPFKGKOKMN
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const float FBFOJALKJPE = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[SerializeField]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 LLKNEALGCKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Vector3 MBKLDFMOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private bool BHJHEJPHOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private float MFGNNFEKEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float BMMBPDFMOHH;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A9D0", Offset = "0x6D991D0", VA = "0x186D9A9D0", Slot = "4")]
		public void UpdateController(float HKMEEJMCKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xD10B40", Offset = "0xD0F340", VA = "0x180D10B40", Slot = "6")]
		public void SetEnabled(bool INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A6F0", Offset = "0x6D98EF0", VA = "0x186D9A6F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B490", Offset = "0x6D99C90", VA = "0x186D9B490")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OJLMAKMHOOO : FGBCLENDEKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int BELHFAGDAFP;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int AMGGGFMDCDK;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int HNPOFODPOEP;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int HPLMNAPEFAF;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int MCLOJPEJCJL;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int OPJICLNEGCA;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int NNLAGINIKOF;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int CHHNGMCOBKD;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int ODCLKMNLJDM;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int JPPCNOFKPKK;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int GIHOCFCBLGE;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int KKNLIEAFEMD;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int MGKDEJKFEHI;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int KGJCFHLONLF;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int KCIIMCGBIIO;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int FAEHOBEGFJH;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int IGADJONBMKB;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int OBNLJKPLLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform NFOEKKIHEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform GPBCICMOHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform DBABCHADAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform EFKDMEAHMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform FPABNPOOAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform DEFLJJDOGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Transform EBEGMFMJLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private MNKEANPGICH BAOPFPHMOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Material IKNIIGBLAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private SkinnedMeshRenderer[] IJFIFBAEIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<Material> CBFNIFHGODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private KFLNLACGMDN CIHNMNKFJEP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private KFLNLACGMDN ECPCAEJGMHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6DAE710", Offset = "0x6DACF10", VA = "0x186DAE710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool KNPGJHABEDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6DAE3C0", Offset = "0x6DACBC0", VA = "0x186DAE3C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE640", Offset = "0x6DACE40", VA = "0x186DAE640")]
	public void EHFCOOMFLME([In] MNKEANPGICH EKFKJKKDGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB60", Offset = "0x6DAD360", VA = "0x186DAEB60")]
	public void HJJGICAFFFC([In] NNBJGAFCGME LLHHILENPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFE60", Offset = "0x6DAE660", VA = "0x186DAFE60", Slot = "6")]
	public void PKNPFPOJJFM(GHOFDNKCHEJ KGDINMPAKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEF50", Offset = "0x6DAD750", VA = "0x186DAEF50")]
	private Vector2 IHEILFJHEHN(Vector2 BIDBGEHLGLK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEFB0", Offset = "0x6DAD7B0", VA = "0x186DAEFB0")]
	public void LKCPBBBAFCH([In] IACJCADCABN LLHHILENPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEC00", Offset = "0x6DAD400", VA = "0x186DAEC00")]
	private void HNJJBBGJJMD(POGNKNHKHMP EDMDGBMCOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE790", Offset = "0x6DACF90", VA = "0x186DAE790")]
	private void FMLNLGDLNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE5D0", Offset = "0x6DACDD0", VA = "0x186DAE5D0")]
	private void IGHLMGNOCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE5D0", Offset = "0x6DACDD0", VA = "0x186DAE5D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0670", Offset = "0x6DAEE70", VA = "0x186DB0670")]
	public OJLMAKMHOOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB60", Offset = "0x6DAD360", VA = "0x186DAEB60", Slot = "5")]
	private void JJDDEDEMENH([In] NNBJGAFCGME LLHHILENPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE3B0", Offset = "0x6DACBB0", VA = "0x186DAE3B0", Slot = "7")]
	private void BJAKPBNJCDF([In] IACJCADCABN LLHHILENPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE540", Offset = "0x6DACD40", VA = "0x186DAE540")]
	[CompilerGenerated]
	internal static (float, float) DNHJMIIIAHN(float GFIHHLHKODK)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB20", Offset = "0x6DAD320", VA = "0x186DAEB20")]
	[CompilerGenerated]
	internal static Vector4 HBFMKAHCMHF(Vector2 BALIIBCILHH, Vector2 FKICLIIJEHG)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarForearmRollController : MonoBehaviour, HMPFKGKOKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private float MFGNNFEKEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private bool BHJHEJPHOEE;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2130", Offset = "0x6DB0930", VA = "0x186DB2130", Slot = "4")]
		public void UpdateController(float HKMEEJMCKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x11C6F00", Offset = "0x11C5700", VA = "0x1811C6F00", Slot = "6")]
		public void SetEnabled(bool INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2BC0", Offset = "0x6DB13C0", VA = "0x186DB2BC0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2BF0", Offset = "0x6DB13F0", VA = "0x186DB2BF0")]
		public void LDJJIOLOFEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2D10", Offset = "0x6DB1510", VA = "0x186DB2D10")]
		public int PMAAJNDFLGP(int KPBFLFFBHDE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class PLLMCEELJMF : EGOCOEIPOBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1F50", Offset = "0x6DC0750", VA = "0x186DC1F50", Slot = "22")]
	public override float GECDGCJCGMK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1FA0", Offset = "0x6DC07A0", VA = "0x186DC1FA0")]
	public PLLMCEELJMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EGOCOEIPOBJ : BKBJJNPBHHC
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static int DMMGHJCGAFD;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static int GPJHLAPDOAI;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static int HAEKGHEAHHB;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static int PDLCBDNIEKP;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static int FJHANPCEKED;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static int CDKKKKDJJPB;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static int KDMDJKHFDMA;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static int[] BKHHNJPBCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private OLKKOGAHLDD BAOPFPHMOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private NJAAOBEJOHB BHBCFPEPBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int KCKKIPOLGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private float LMKBFMOMJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected Animator KGMFIPIKCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	protected bool MPEFBHHJCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	protected AvatarConfiguration MIDKBIPFIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected int ALOGNKIMOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private int AMBGEOKJDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private int CLCNFAHJDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private bool IDHMMCICMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private OMAGDJKIFFD LPMEGGFNPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private int LODHJHBAKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private float DJAALAHNHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private AvatarHandDisplaySettings CPBINPMACOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private HBPDIAMDKLD DCBPNDOCEOL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Transform KOHDJICCELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Vector3 OCACJKNOCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x11C48C0", Offset = "0x11C30C0", VA = "0x1811C48C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x11C49B0", Offset = "0x11C31B0", VA = "0x1811C49B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Quaternion PNGMEKOHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9589A0", Offset = "0x9571A0", VA = "0x1809589A0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x125A5A0", Offset = "0x1258DA0", VA = "0x18125A5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GMBEHLDNFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6DB7390", Offset = "0x6DB5B90", VA = "0x186DB7390")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6DB7360", Offset = "0x6DB5B60", VA = "0x186DB7360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Vector3 ANEEANFHLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6DB72F0", Offset = "0x6DB5AF0", VA = "0x186DB72F0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6DB6BD0", Offset = "0x6DB53D0", VA = "0x186DB6BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Quaternion JEBFMPAMDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6DB6D90", Offset = "0x6DB5590", VA = "0x186DB6D90", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6DB72D0", Offset = "0x6DB5AD0", VA = "0x186DB72D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ODEBCAINGAD LCKPHNNNKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x19CC580", Offset = "0x19CAD80", VA = "0x1819CC580", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(ODEBCAINGAD);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x1D11310", Offset = "0x1D0FB10", VA = "0x181D11310", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public ODEBCAINGAD FKPKHGDMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x1DE88A0", Offset = "0x1DE70A0", VA = "0x181DE88A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(ODEBCAINGAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7550", Offset = "0x1DE5D50", VA = "0x181DE7550", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public float KBKOFFOAFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xEFF6A0", Offset = "0xEFDEA0", VA = "0x180EFF6A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xB0F0A0", Offset = "0xB0D8A0", VA = "0x180B0F0A0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool KFPHMBBLJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6DB7130", Offset = "0x6DB5930", VA = "0x186DB7130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IJBCHIEPNIE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB6CC0", Offset = "0x6DB54C0", VA = "0x186DB6CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GDBOHLDNMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6DB73C0", Offset = "0x6DB5BC0", VA = "0x186DB73C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PGIODNGENGO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x271FDF0", Offset = "0x271E5F0", VA = "0x18271FDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6DC0", Offset = "0x6DB55C0", VA = "0x186DB6DC0", Slot = "21")]
	public void EHFCOOMFLME(OLKKOGAHLDD EKFKJKKDGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6DB7310", Offset = "0x6DB5B10", VA = "0x186DB7310")]
	public void MNONKHLBNIC(NJAAOBEJOHB ANPLJHEONOB, AvatarHandDisplaySettings IHCECPGCMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6C30", Offset = "0x6DB5430", VA = "0x186DB6C30", Slot = "12")]
	public void ANELPFGJAKN(bool NLMMCMCMPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6DB73D0", Offset = "0x6DB5BD0", VA = "0x186DB73D0", Slot = "11")]
	public void PNBBMCGMEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xEFF6A0", Offset = "0xEFDEA0", VA = "0x180EFF6A0", Slot = "22")]
	public virtual float GECDGCJCGMK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6DB7140", Offset = "0x6DB5940", VA = "0x186DB7140")]
	private int KJDPEKHKPFJ(ODEBCAINGAD DAPAONJILOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6F70", Offset = "0x6DB5770", VA = "0x186DB6F70")]
	private void JBADDKBEADN(int DFOABBIFEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6D20", Offset = "0x6DB5520", VA = "0x186DB6D20", Slot = "13")]
	public bool CPLLLOABINP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6F60", Offset = "0x6DB5760", VA = "0x186DB6F60", Slot = "14")]
	public bool GPPNDDFELNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6CD0", Offset = "0x6DB54D0", VA = "0x186DB6CD0")]
	private ODEBCAINGAD COBLNEKMHKM()
	{
		return default(ODEBCAINGAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x177E730", Offset = "0x177CF30", VA = "0x18177E730", Slot = "15")]
	public void KJJAMCNDECG(bool NLMMCMCMPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6BF0", Offset = "0x6DB53F0", VA = "0x186DB6BF0", Slot = "10")]
	public void AHFEILABOFM(int DFOABBIFEGH, float LOEFAELKJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6DA0", Offset = "0x6DB55A0", VA = "0x186DB6DA0", Slot = "8")]
	public void DMOJFFAGPFF(OMAGDJKIFFD LCFHGACCKAF, bool PBBJGOAILGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6DB72E0", Offset = "0x6DB5AE0", VA = "0x186DB72E0", Slot = "9")]
	public void LFKEKBCCKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6D40", Offset = "0x6DB5540", VA = "0x186DB6D40", Slot = "16")]
	public void DCDIPLNEMBO(Transform NCCLECGLDAO, Vector3 IOJIMOEKKDH, Quaternion KHJJMBJPBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6DB7A10", Offset = "0x6DB6210", VA = "0x186DB7A10")]
	public EGOCOEIPOBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ABPFGMCOOPL : EMOPPALHKBK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class KHIFHPLAPJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public ABPFGMCOOPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public List<FGNKNNJACKL> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public List<FGNKNNJACKL> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public MGNFCCKNAGM<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public MGNFCCKNAGM<HHIAOGOANPG> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public KHIFHPLAPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6DBEC50", Offset = "0x6DBD450", VA = "0x186DBEC50")]
		internal MOPOHKAGKCI EFDHDOHLENG(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public DJEJFNMFNJK NFDFJCKKJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public HHIAOGOANPG NEIAHGMJCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private MGNFCCKNAGM<HHIAOGOANPG> IBEPEIEEAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private MGNFCCKNAGM<Material[]> BIIOCMPGGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public Material[] HHNPADNEFGN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool EOLJFNLMANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA02A00", Offset = "0xA01200", VA = "0x180A02A00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA028C0", Offset = "0xA010C0", VA = "0x180A028C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EAIGMANLNFK.LFNICJCICHD ELOECALKKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xCEF3B0", Offset = "0xCEDBB0", VA = "0x180CEF3B0")]
		[CompilerGenerated]
		get
		{
			return default(EAIGMANLNFK.LFNICJCICHD);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xF38FF0", Offset = "0xF377F0", VA = "0x180F38FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB20C0", Offset = "0x6DB08C0", VA = "0x186DB20C0")]
	public ABPFGMCOOPL(AEIOBEGHMKA LOAJBBPNOKD, DJEJFNMFNJK OAMDOAKKKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1880", Offset = "0x6DB0080", VA = "0x186DB1880", Slot = "6")]
	public override MOPOHKAGKCI NAIHOEBOHMG(List<FGNKNNJACKL> CJFEEEHHKNB, List<FGNKNNJACKL> LILADLFLJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1130", Offset = "0x6DAF930", VA = "0x186DB1130")]
	public MOPOHKAGKCI EIGGGOKNOBB(List<FGNKNNJACKL> CJFEEEHHKNB, List<FGNKNNJACKL> LILADLFLJLC, MGNFCCKNAGM<Material[]> BIIOCMPGGCL, MGNFCCKNAGM<HHIAOGOANPG> MIMLDJGBIPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1BD0", Offset = "0x6DB03D0", VA = "0x186DB1BD0")]
	public (MGNFCCKNAGM<Material[]>, MGNFCCKNAGM<HHIAOGOANPG>) NOHCCMNLNPE(List<FGNKNNJACKL> CJFEEEHHKNB, List<FGNKNNJACKL> LILADLFLJLC)
	{
		return default((MGNFCCKNAGM<Material[]>, MGNFCCKNAGM<HHIAOGOANPG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1F40", Offset = "0x6DB0740", VA = "0x186DB1F40", Slot = "7")]
	public override BHMMEPENJGN PKJAMJIPGAE(uint PBCKDIKKJCB, AvatarSkinnedMeshBoneOrderRemapsData LLAIGADFCAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0F20", Offset = "0x6DAF720", VA = "0x186DB0F20")]
	public BHMMEPENJGN BAJNIJONCBI(GameObject CHAOLNOOACE, uint PBCKDIKKJCB, bool JDILDAEMBAK, bool MHAIGCKMHHG, AvatarSkinnedMeshBoneOrderRemapsData LLAIGADFCAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6DB14F0", Offset = "0x6DAFCF0", VA = "0x186DB14F0")]
	public static bool HKJGJCPBIAE(Renderer[] FAOHBBNGEKO, string BFICKDIAABG, [Out] Renderer IKJLHADEKHK, [Out] Renderer AACDBAJJDOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2070", Offset = "0x6DB0870", VA = "0x186DB2070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1430", Offset = "0x6DAFC30", VA = "0x186DB1430")]
	private (MGNFCCKNAGM<HHIAOGOANPG>, MGNFCCKNAGM<Material[]>) EJJFCMCIOPG()
	{
		return default((MGNFCCKNAGM<HHIAOGOANPG>, MGNFCCKNAGM<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1860", Offset = "0x6DB0060", VA = "0x186DB1860")]
	[CompilerGenerated]
	private void LOOACDFLPCC(HHIAOGOANPG HANDIANDCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8B7510", Offset = "0x8B5D10", VA = "0x1808B7510")]
	[CompilerGenerated]
	private void NCJNHHOEBKK(Material[] HANDIANDCDI)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class AvatarKneeBendTargetController : MonoBehaviour, HMPFKGKOKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private Vector3 LLKNEALGCKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private Vector3 LJPEMHGJPNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private Vector3 DBFGPNEKKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Matrix4x4 DMBOEBBLEBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private bool BHJHEJPHOEE;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6DB31F0", Offset = "0x6DB19F0", VA = "0x186DB31F0", Slot = "4")]
		public void UpdateController(float HKMEEJMCKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6DB31E0", Offset = "0x6DB19E0", VA = "0x186DB31E0", Slot = "6")]
		public void SetEnabled(bool INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2D80", Offset = "0x6DB1580", VA = "0x186DB2D80")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6DB38B0", Offset = "0x6DB20B0", VA = "0x186DB38B0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[CEOCIAMIFJE]
public struct BMBFBLDCBHK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[ReadOnly]
	public MLOJNNBCLBI DDAPEHNGLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[ReadOnly]
	public int NBHOGONLJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public KBIPNDNDEOP COKHAEPACFG;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4FD0", Offset = "0x6DB37D0", VA = "0x186DB4FD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CEOCIAMIFJE]
[NativeContainer]
public struct KBIPNDNDEOP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<Vector3> KELFIBOCKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<Vector3> LHPMBLLAFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<Vector4> KADNAHLPLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<Vector2> JGDGMJBALFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<Vector2> CCLNHIEIOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<Vector2> BCLBHLFDHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<Vector2> BDJDBPJPMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Color> KCPADFBPBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<int> MOCLLGFPOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<int> NCFEFPPIEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private NativeArray<int> CBEDDDHEEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private NativeArray<int> ADFIBAIOEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<int> FDJELCMBONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<int> FFEBIDKKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<int> IDPMCLOHOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<BoneWeight> EKKPIBPLKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private NativeArray<int> OFGFBCNFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private bool KKMIPFCDMEP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int FPCKEKHECLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE1E0", Offset = "0x6DBC9E0", VA = "0x186DBE1E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6DBDE70", Offset = "0x6DBC670", VA = "0x186DBDE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int BNKALBOLBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6DBD9A0", Offset = "0x6DBC1A0", VA = "0x186DBD9A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6DBDD70", Offset = "0x6DBC570", VA = "0x186DBDD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int NLPFJCPMGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6DBDE40", Offset = "0x6DBC640", VA = "0x186DBDE40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6DBDE30", Offset = "0x6DBC630", VA = "0x186DBDE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE2C0", Offset = "0x6DBCAC0", VA = "0x186DBE2C0")]
	public KBIPNDNDEOP(int EOINPDOKINC, int IJINDPAOGID, int GIBDKIDEKMB, int BJHPCBANKDN, Allocator MOBIJPCBMOB, int KOHPGNCBDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDD00", Offset = "0x6DBC500", VA = "0x186DBDD00")]
	public void EPLIMOLGKLD(int ECDOOAABOPD, Vector3 JBEGGBDGOGM, Vector3 JOADBJGEHIP, Vector4 EBDGHJJPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD9B0", Offset = "0x6DBC1B0", VA = "0x186DBD9B0")]
	public void DIHDBAKMHBB(int ECDOOAABOPD, BoneWeight EIKJKBAEHDJ, NativeSlice<byte> OFHOOBGMHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDE10", Offset = "0x6DBC610", VA = "0x186DBDE10")]
	public Color GMDINGBANLD(int ECDOOAABOPD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDE50", Offset = "0x6DBC650", VA = "0x186DBDE50")]
	public void JIDCCIIILCC(int ECDOOAABOPD, Color HPEMNIMCDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD8A0", Offset = "0x6DBC0A0", VA = "0x186DBD8A0")]
	public void AMCJNNBOACE(byte BAONDMFEGDF, int ECDOOAABOPD, Vector2 OAMKHHDHFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDE80", Offset = "0x6DBC680", VA = "0x186DBDE80")]
	public void LIKJNEFOOCD(int ECDOOAABOPD, int CFLPNBCLAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD870", Offset = "0x6DBC070", VA = "0x186DBD870")]
	public bool AAFMJAOBHAD(int BAONDMFEGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE1F0", Offset = "0x6DBC9F0", VA = "0x186DBE1F0")]
	public void PHCFHNFADIA(int LPBBLDHOHLK, int MHPJBPKHONI, int OANKAJFHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD8F0", Offset = "0x6DBC0F0", VA = "0x186DBD8F0")]
	public int[] AOHFLCDCBNL(int LPBBLDHOHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDD80", Offset = "0x6DBC580", VA = "0x186DBDD80")]
	private NativeSlice<int> GBGAKILMJCO(int LPBBLDHOHLK)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDB50", Offset = "0x6DBC350", VA = "0x186DBDB50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDE90", Offset = "0x6DBC690", VA = "0x186DBDE90")]
	public Mesh MIDDGMLKNBE([Optional] string KLCAHMJNBKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[DefaultMember("Item")]
[CEOCIAMIFJE]
public struct MLOJNNBCLBI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector3> KELFIBOCKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector3> LHPMBLLAFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector4> KADNAHLPLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector2> JGDGMJBALFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector2> CCLNHIEIOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> BCLBHLFDHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> BDJDBPJPMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Color> KCPADFBPBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> BGLBFBPACEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<int> BAKCHPILEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<int> LCMIOPIMKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> LCFDGNOCLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<bool> ANMKMKHONHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<int> MMKNHANONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> AKDAHAPFCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<BoneWeight> MHIAMMKHJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private NativeArray<Matrix4x4> PKEGJGKPJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private NativeArray<int> FGLHFPNADFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NativeArray<byte> KHJFEINDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NativeArray<int> EENMLBDJNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private NativeArray<int> EINHBCDDAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<sbyte> DJIHKCMAMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<byte> NOHCDGACCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private NativeArray<int> HBCBGFGGEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private bool KKMIPFCDMEP;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ODIBBBECMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x23206E0", Offset = "0x231EEE0", VA = "0x1823206E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int MEILFFKLINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x13EFF50", Offset = "0x13EE750", VA = "0x1813EFF50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int EMFGEJAKDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6DC0710", Offset = "0x6DBEF10", VA = "0x186DC0710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MNAEKHAAHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6DBFE20", Offset = "0x6DBE620", VA = "0x186DBFE20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6DBFE30", Offset = "0x6DBE630", VA = "0x186DBFE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int FPCKEKHECLH
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC0700", Offset = "0x6DBEF00", VA = "0x186DC0700")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC01A0", Offset = "0x6DBE9A0", VA = "0x186DC01A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int HFANCCCBMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC01C0", Offset = "0x6DBE9C0", VA = "0x186DC01C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC01D0", Offset = "0x6DBE9D0", VA = "0x186DC01D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public BDBJJGAKCLO CAMFJEABEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC00B0", Offset = "0x6DBE8B0", VA = "0x186DC00B0")]
		get
		{
			return default(BDBJJGAKCLO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6DBFE40", Offset = "0x6DBE640", VA = "0x186DBFE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public byte BKPNNBOBIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6DC01B0", Offset = "0x6DBE9B0", VA = "0x186DC01B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6DC0190", Offset = "0x6DBE990", VA = "0x186DC0190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NODDNMDMHDB DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6DC01E0", Offset = "0x6DBE9E0", VA = "0x186DC01E0")]
		get
		{
			return default(NODDNMDMHDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0740", Offset = "0x6DBEF40", VA = "0x186DC0740")]
	public MLOJNNBCLBI(IList<Mesh> FKOGPNIGJHE, IList<Matrix4x4> BDEBKJMOBID, IList<bool> ANMKMKHONHA, byte KACMHBDGKHB, IList<byte[]> JAOOJKGGAJL, IList<int> DADDPMOKGPL, IList<bool> PIGIPJBOIKO, IList<int> MMKNHANONKJ, IList<int> JJNAHMECMGF, IList<int> HEGINCOIBFG, Allocator MOBIJPCBMOB, BDBJJGAKCLO PBNGBAKKBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6DC00C0", Offset = "0x6DBE8C0", VA = "0x186DC00C0")]
	public KBIPNDNDEOP GHODMJCNEGE(Allocator MOBIJPCBMOB)
	{
		return default(KBIPNDNDEOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFE50", Offset = "0x6DBE650", VA = "0x186DBFE50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[CEOCIAMIFJE]
public class CBLMBPDCPHL : IJNEJABAIDL
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB63F0", Offset = "0x6DB4BF0", VA = "0x186DB63F0")]
	public MLOJNNBCLBI ACMBCCCCOFB()
	{
		return default(MLOJNNBCLBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FA40", Offset = "0x6D9E240", VA = "0x186D9FA40")]
	public CBLMBPDCPHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct NODDNMDMHDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<Vector3> KELFIBOCKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<Vector3> LHPMBLLAFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<Vector4> KADNAHLPLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<Vector2> JGDGMJBALFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<Vector2> CCLNHIEIOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<Vector2> BCLBHLFDHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeSlice<Vector2> BDJDBPJPMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeSlice<Color> KCPADFBPBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<int> IDLODPBACLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<int> LCFDGNOCLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeSlice<BoneWeight> MHIAMMKHJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeSlice<byte> DOKFMDIHHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public int MGAPIAJGAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public Matrix4x4 GMJPPMGCNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public int KFDELGIMFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeSlice<byte> OFHOOBGMHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public bool CFCGCOHPPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public int NMOBKIAOJAC;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal readonly struct BEJAMHIFFPM : IEquatable<BEJAMHIFFPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	internal readonly Material OAPEFBDFDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	internal readonly AGEOOIMHKJF OKGOBAFJIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	internal readonly DMGIDOOBPMF FALIEABGNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	internal readonly AEIOBEGHMKA NHCDKHMODOC;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4F90", Offset = "0x6DB3790", VA = "0x186DB4F90")]
	public BEJAMHIFFPM(Material KMOLIAGHFFN, AGEOOIMHKJF GHJFOFFDIDB, DMGIDOOBPMF KLHPPCFCKIP, AEIOBEGHMKA ALHMBEPBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4D70", Offset = "0x6DB3570", VA = "0x186DB4D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4C50", Offset = "0x6DB3450", VA = "0x186DB4C50", Slot = "4")]
	public bool Equals(BEJAMHIFFPM LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4B70", Offset = "0x6DB3370", VA = "0x186DB4B70", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4CD0", Offset = "0x6DB34D0", VA = "0x186DB4CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, BCHKMJBMDFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		[Header("Configuration")]
		private HBPDIAMDKLD avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private JHNODDJNGEL PDGLKHGOAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private FGBCLENDEKC DLLKENEPOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private BKBJJNPBHHC DHEKPGMBODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private BKBJJNPBHHC KECGAGFEGPJ;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public JHNODDJNGEL GIMOKDCDPJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x6DB46E0", Offset = "0x6DB2EE0", VA = "0x186DB46E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public FGBCLENDEKC ECPAMDKEEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x6DB4730", Offset = "0x6DB2F30", VA = "0x186DB4730", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public BKBJJNPBHHC KOMMDGIKAHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x6DB4950", Offset = "0x6DB3150", VA = "0x186DB4950", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public BKBJJNPBHHC GALKFAMHKFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x6DB49A0", Offset = "0x6DB31A0", VA = "0x186DB49A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform OMHIIPPFPBN
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x6DB49F0", Offset = "0x6DB31F0", VA = "0x186DB49F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public HBPDIAMDKLD GEODLHLDENN
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8C1590", Offset = "0x8BFD90", VA = "0x1808C1590", Slot = "12")]
			get
			{
				return default(HBPDIAMDKLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6DB38C0", Offset = "0x6DB20C0", VA = "0x186DB38C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6DB4540", Offset = "0x6DB2D40", VA = "0x186DB4540")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6DB4260", Offset = "0x6DB2A60", VA = "0x186DB4260", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6DB4540", Offset = "0x6DB2D40", VA = "0x186DB4540", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3930", Offset = "0x6DB2130", VA = "0x186DB3930", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6DB45F0", Offset = "0x6DB2DF0", VA = "0x186DB45F0")]
		public void UpdatePostIKAnimControllers(float HKMEEJMCKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB42C0", Offset = "0x6DB2AC0", VA = "0x186DB42C0")]
		private void NGBCDFPLPDP(GameObject INCBEIDOHDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3EF0", Offset = "0x6DB26F0", VA = "0x186DB3EF0")]
		private JHNODDJNGEL HEFIFNDAKLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6DB4350", Offset = "0x6DB2B50", VA = "0x186DB4350")]
		private FGBCLENDEKC NJNDJMJPBAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3C60", Offset = "0x6DB2460", VA = "0x186DB3C60")]
		private BKBJJNPBHHC GNBINLPKOFN(BPFDFNAOGMP KBPCJMDFINF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6DB46D0", Offset = "0x6DB2ED0", VA = "0x186DB46D0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class EMIJBNBKBIJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private MaterialPropertyBlock EENGNPMJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	public Color? HPCBIHNJIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	public Color? PNANGMGNCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	public Color? AMJOGGEJJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public Color? FJMLLDCPKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public Color AMEENABEBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public Color AFNPDDAHBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public Color KAPGPCCHLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public Texture2D MJDHDAOKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public Texture2D NNCDJIJOFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private Dictionary<BEJAMHIFFPM, int> IDHIPFKPOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private AGEOOIMHKJF[] PECNMEEEEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private DMGIDOOBPMF[] PKGEAAMHGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public Vector4[] DOIILMIHMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Vector4[] EBNCACKLJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public Vector4[] PAPEKLPFLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Vector4[] MDKBDKKOJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public Vector4[] MDDKBCFMNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public Vector4[] APDLMAHJKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private List<Texture2D> KNJAGBHGBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private Vector4[] GDIBCBDBBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private List<Texture2D> IDAGHPJFMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float[] HBDHDDCNBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private Vector4[] BCCCHDLJJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float[] GGCHKBKOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public float[] CPEJPDIDEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private List<Texture2D> ONPBKNGMABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private float[] PJCICGONJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private List<Texture2D> AMHNMPJKCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Vector4[] LBEKFDCELIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private float[] BDBAOFMCHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private Vector4[] BHCCOIFCHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public float[] OLEKGNBEFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Texture2DArray EGBKEIOCHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Texture2DArray GJHBLIJPKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Texture2DArray JDJPDJLAOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Texture2DArray NJDCBGEPJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private bool OPDLDCEHOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private int FIIBKGAPBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector2? OAHPPNCIPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private TextureFormat KHHCLNKHNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private Vector2? ADJPKHDDMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private TextureFormat ALHHHGDLPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private Vector2? IPENOPDFHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private TextureFormat FEFMPJNCPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector2? HIOKAIKMHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private TextureFormat JPFMBJGAHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private bool LOEKDIGJGDI;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static int PMONKFOOHHN;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static int CCOJJHNCJLB;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static int IGFEICDNFGD;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static int LEFJFGOFCFJ;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static int HOBPCHEJNHG;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static int BDHBKBKKOCK;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static int PIJIPFFAEIM;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static int AEMOAMIECKD;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static int DMHBDNKOPKM;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static int OEJOCENIDJO;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static int MMOOLIFHKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static int DOJKODGHAIP;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static int DIIADFJKDFL;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static int IMINHNKNNIG;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static int LFJIGBMHHHL;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static int KNPBBJPHCOE;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int JAAPHJHCJDA;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int AAPJEGLJHFA;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int NJBLPOJCIHE;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int DCHLGLPKGPN;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6DBA6F0", Offset = "0x6DB8EF0", VA = "0x186DBA6F0")]
	private EMIJBNBKBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6DBA630", Offset = "0x6DB8E30", VA = "0x186DBA630")]
	public EMIJBNBKBIJ(Color KIPDOKLMKNH, Color ELNACFBLMFB, Color OBCLIDMNGBF, Color? HOLEOGPLEIJ, Color? PBOKBIIDCFB, Color? DDFOJPCMIPH, Texture2D OGEPCJJCHNJ, Texture2D IGCMCEKAFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6DB8F20", Offset = "0x6DB7720", VA = "0x186DB8F20")]
	internal int JKKILBIFCEL(Material COIAGFNLALP, AGEOOIMHKJF GHJFOFFDIDB, DMGIDOOBPMF KLHPPCFCKIP, AEIOBEGHMKA ALHMBEPBCGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9010", Offset = "0x6DB7810", VA = "0x186DB9010")]
	private int JKKILBIFCEL(BEJAMHIFFPM KCGKBDGKIOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6DB8060", Offset = "0x6DB6860", VA = "0x186DB8060")]
	internal int DBJKKHCNJIP(Material COIAGFNLALP, Color HJHJIMLHCBH, Color KJODLKNHGNM, Color IAJHFMNBCPC, Color BOBBJLCFBAE, Color KNMKIAFBFGC, Texture2D FFDDCMFIACF, Vector4 HBNNLDCOPNB, Texture2D MLFJBLGLBCI, Vector4 KNGGHAKJNNE, float DKNFPDEAGCA, float HGIHGJEIFIM, Texture2D NKMLOOAPLHJ, Vector4 IFFPHGBKOOB, float HENBBIKFHHL, Texture2D BKIEBINFBBL, Color LLBNLMJIGOB, Vector4 LJCEAMHGIDM, AGEOOIMHKJF GHJFOFFDIDB, DMGIDOOBPMF KLHPPCFCKIP, AEIOBEGHMKA ALHMBEPBCGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9D90", Offset = "0x6DB8590", VA = "0x186DB9D90")]
	private void LDOCDHPHHEG(List<Texture2D> KNJAGBHGBLE, [Out] Texture2DArray DFMFGFGHDFL, [Out] Texture2DArray CMEACNEOHBE, [Out] Texture2DArray OBPEKAPHCIJ, [Out] Texture2DArray JMMIJNOEALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6DBA150", Offset = "0x6DB8950", VA = "0x186DBA150")]
	public void PONHMEMBNBP(Shader OCOIDGGNCKF, Renderer ALAKDHHJBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6DB90A0", Offset = "0x6DB78A0", VA = "0x186DB90A0")]
	private void KBFANFADGJH(Shader OCOIDGGNCKF, Renderer ALAKDHHJBKP, int PFEHMDJINEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9F50", Offset = "0x6DB8750", VA = "0x186DB9F50")]
	private Color PEODFBNIMFJ(Color MJGHICDAAPE, AGEOOIMHKJF LJHKKNICJMJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB8C30", Offset = "0x6DB7430", VA = "0x186DB8C30")]
	private Color DHFEOAADEGN(Color GGKAJFPPHCK, AGEOOIMHKJF LJHKKNICJMJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB8DC0", Offset = "0x6DB75C0", VA = "0x186DB8DC0")]
	private bool GPNOAPACACJ(Texture2D NONOMHENPKG, DMGIDOOBPMF DOPLPLBKGCI, [Out] Texture2D OMEAPBINNJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB7FB0", Offset = "0x6DB67B0", VA = "0x186DB7FB0")]
	private void DAAMJOGDGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB8D80", Offset = "0x6DB7580", VA = "0x186DB8D80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class EMOPPALHKBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public readonly AEIOBEGHMKA FDGNEAIDEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected bool BNAPCBDFCBC;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool ANPHKLNBGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ADD0", VA = "0x18095C5D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x95C5F0", Offset = "0x95ADF0", VA = "0x18095C5F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool KHPINKJICBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xF57710", Offset = "0xF55F10", VA = "0x180F57710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xF57700", Offset = "0xF55F00", VA = "0x180F57700")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual EAIGMANLNFK.LFNICJCICHD KFDELGIMFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA8EA70", Offset = "0xA8D270", VA = "0x180A8EA70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(EAIGMANLNFK.LFNICJCICHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA8EAA0", Offset = "0xA8D2A0", VA = "0x180A8EAA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool OHPKKIFODOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x95C5E0", Offset = "0x95ADE0", VA = "0x18095C5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool DCEICDIPILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1997010", Offset = "0x1995810", VA = "0x181997010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool GLBHGPPPFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6DBABE0", Offset = "0x6DB93E0", VA = "0x186DBABE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool EOKMKFMPAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6DBABF0", Offset = "0x6DB93F0", VA = "0x186DBABF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6DBAC10", Offset = "0x6DB9410", VA = "0x186DBAC10")]
	protected EMOPPALHKBK(AEIOBEGHMKA LOAJBBPNOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract MOPOHKAGKCI NAIHOEBOHMG(List<FGNKNNJACKL> CJFEEEHHKNB, List<FGNKNNJACKL> LILADLFLJLC);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract BHMMEPENJGN PKJAMJIPGAE(uint PBCKDIKKJCB, AvatarSkinnedMeshBoneOrderRemapsData LLAIGADFCAC);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class IJMACOGJMNF : LFFKLNEGBFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private AvatarSkinAssetItem CEHFNALEHHE;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD2D0", Offset = "0x6DBBAD0", VA = "0x186DBD2D0")]
	public IJMACOGJMNF(AvatarSkinAssetItem PEBCFKJBIGO, AvatarSkinAssetItem.DCNCGDGHHLJ NGOOBCHJJDE, AEIOBEGHMKA ALHMBEPBCGJ, [Optional] ILOBAEFMBMP? IMAANLMBKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD050", Offset = "0x6DBB850", VA = "0x186DBD050", Slot = "6")]
	public override MOPOHKAGKCI NAIHOEBOHMG(List<FGNKNNJACKL> CJFEEEHHKNB, List<FGNKNNJACKL> LILADLFLJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IIPOAOMFEDG
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static readonly int[] MNJFCNHLMBB;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly int[] IMNECGPCEFO;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static int[] LIKMELICGII
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6DBCDB0", Offset = "0x6DBB5B0", VA = "0x186DBCDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6DBCEC0", Offset = "0x6DBB6C0", VA = "0x186DBCEC0")]
	public static int[] PPNPAAMOMOF(bool JCABHAAJIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6DBCE20", Offset = "0x6DBB620", VA = "0x186DBCE20")]
	public static int GPADENJJELJ(HNNBIECDFEH EHMNMNPJAGC, bool JCABHAAJIGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6DBCEB0", Offset = "0x6DBB6B0", VA = "0x186DBCEB0")]
	private static int IIEHIBPPIOG(HNNBIECDFEH EHMNMNPJAGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6DBCE00", Offset = "0x6DBB600", VA = "0x186DBCE00")]
	private static int CGMHMLKMMHC(HNNBIECDFEH EHMNMNPJAGC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BEEEJIFCHLI
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class LIECCNKDCGF : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public LIECCNKDCGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xDECC00", Offset = "0xDEB400", VA = "0x180DECC00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6DBF8F0", Offset = "0x6DBE0F0", VA = "0x186DBF8F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	public static void FIEBMPHDEHN(string DOBPKLNCBDO, int PBCKDIKKJCB, long NMANLIBFCKO, long DNMNHPCDMCO, long EJDGPFNIMOD, long FELHMPMJOCG, long PACEFFDOLMO, long IOBJAEMEEFO, long MGEHCHJEMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4A80", Offset = "0x6DB3280", VA = "0x186DB4A80")]
	public static EBBFPAKHIHA PPICPNBAPMK(JobHandle PDDFHEEFJKM, bool CAGPCNEFHNG, bool INPNAAIOLMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4A10", Offset = "0x6DB3210", VA = "0x186DB4A10")]
	[IteratorStateMachine(typeof(LIECCNKDCGF))]
	private static IEnumerator<IJKEOMMDACC> HKGBPCOEMJF(JobHandle KACBIAOBGKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class KKJPHHJMHBN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum ABBBFAONPPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly int BAAMKKPJBKO;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly int LPLGONJHJEJ;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly int GGMJJKIHIPC;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly int OONCKKDCLCO;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly int JCGAOJBNGEJ;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly int OKJCGPPDLMG;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly int EOCCJIBGIGM;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly int EAKODNDHHAL;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6DBEF50", Offset = "0x6DBD750", VA = "0x186DBEF50")]
	public static bool CHJINIPJCCH(Material KMOLIAGHFFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6DBEE90", Offset = "0x6DBD690", VA = "0x186DBEE90")]
	public static bool BFCFJCBHCAH(Material KMOLIAGHFFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class LFFKLNEGBFK : EMOPPALHKBK
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class KDIEMOALKJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public MGNFCCKNAGM<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public LFFKLNEGBFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public KDIEMOALKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE860", Offset = "0x6DBD060", VA = "0x186DBE860")]
		internal void HGLJMCPNCFC(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE720", Offset = "0x6DBCF20", VA = "0x186DBE720")]
		internal void EFDHDOHLENG(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	protected AvatarSkinAssetItem AODLFGHPFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	protected Material[] OOLCMNIPHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private readonly AvatarSkinAssetItem.DCNCGDGHHLJ PDJMJNDHLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly AssetReference NOLCPEEPFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private readonly ILOBAEFMBMP? OCOHIOOAKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private SkinnedMeshRenderer[] MANNELLCACH;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override EAIGMANLNFK.LFNICJCICHD KFDELGIMFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(EAIGMANLNFK.LFNICJCICHD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x95C4E0", Offset = "0x95ACE0", VA = "0x18095C4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF7D0", Offset = "0x6DBDFD0", VA = "0x186DBF7D0")]
	public LFFKLNEGBFK(AvatarSkinAssetItem.DCNCGDGHHLJ NGOOBCHJJDE, AssetReference AMLFGEIBJHG, Material HIHGBOPCNDN, AEIOBEGHMKA ALHMBEPBCGJ, EAIGMANLNFK.LFNICJCICHD POAGPEBCNEL = (EAIGMANLNFK.LFNICJCICHD)0, [Optional] ILOBAEFMBMP? IMAANLMBKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF6B0", Offset = "0x6DBDEB0", VA = "0x186DBF6B0")]
	public LFFKLNEGBFK(AvatarSkinAssetItem.DCNCGDGHHLJ NGOOBCHJJDE, AssetReference AMLFGEIBJHG, Material HIHGBOPCNDN, EAIGMANLNFK.LFNICJCICHD POAGPEBCNEL = (EAIGMANLNFK.LFNICJCICHD)0, [Optional] ILOBAEFMBMP? IMAANLMBKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF1A0", Offset = "0x6DBD9A0", VA = "0x186DBF1A0", Slot = "6")]
	public override MOPOHKAGKCI NAIHOEBOHMG(List<FGNKNNJACKL> CJFEEEHHKNB, List<FGNKNNJACKL> LILADLFLJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF370", Offset = "0x6DBDB70", VA = "0x186DBF370", Slot = "7")]
	public override BHMMEPENJGN PKJAMJIPGAE(uint PBCKDIKKJCB, AvatarSkinnedMeshBoneOrderRemapsData LLAIGADFCAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF640", Offset = "0x6DBDE40", VA = "0x186DBF640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF140", Offset = "0x6DBD940", VA = "0x186DBF140")]
	protected void IGFKPEOBJPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class GHHHBFNBJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private List<int> LMOAGHKJBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private List<KADOGLANDHL> BPHGHGHCONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private HashSet<Transform> GLDEGPOJJDB;

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBD00", Offset = "0x6DBA500", VA = "0x186DBBD00")]
	public static GHHHBFNBJJJ CFIECDGCGDK(Transform EBDGHJJPDEM, Dictionary<Transform, OutfitType?> MGEHABOFHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBEA0", Offset = "0x6DBA6A0", VA = "0x186DBBEA0")]
	private void FCFIPDMNMPO(Transform EBDGHJJPDEM, AEIOBEGHMKA ALHMBEPBCGJ, Dictionary<Transform, OutfitType?> MGEHABOFHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC550", Offset = "0x6DBAD50", VA = "0x186DBC550")]
	private void PBNBMCBADFA(Transform AAFNBMMBJJB, AEIOBEGHMKA ALHMBEPBCGJ, bool CKDIODOHLJB, OutfitType? DOAOHLJCGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC160", Offset = "0x6DBA960", VA = "0x186DBC160")]
	public EOKODHAPDHF LJCPIHAJMIK(HashSet<string> JIDGMNMEMOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC680", Offset = "0x6DBAE80", VA = "0x186DBC680")]
	public GHHHBFNBJJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class EOKODHAPDHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private List<KADOGLANDHL> BPHGHGHCONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private List<Matrix4x4> NIMNPJGGJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private Transform[] JOIKFGFLLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private Matrix4x4[] LFFLJJFNIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private Dictionary<FDNGJDIOGPM, int> GBLCMAENHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private List<LNFBMJCEDJB> PJLLENNMNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private bool KIONHPMFCKL;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB310", Offset = "0x6DB9B10", VA = "0x186DBB310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Transform[] HBFOFIPIOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6DBAC40", Offset = "0x6DB9440", VA = "0x186DBAC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Matrix4x4[] OHHAAGCIFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB2A0", Offset = "0x6DB9AA0", VA = "0x186DBB2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6DBB670", Offset = "0x6DB9E70", VA = "0x186DBB670")]
	public void PBNBMCBADFA(Transform AAFNBMMBJJB, AEIOBEGHMKA ALHMBEPBCGJ, OutfitType? DOAOHLJCGOI, bool CJBMDOOEGPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6DBB350", Offset = "0x6DB9B50", VA = "0x186DBB350")]
	private void PBNBMCBADFA(Transform AAFNBMMBJJB, AEIOBEGHMKA ALHMBEPBCGJ, OutfitType? DOAOHLJCGOI, bool CJBMDOOEGPJ, Matrix4x4 HCFLHEHEGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6DBADB0", Offset = "0x6DB95B0", VA = "0x186DBADB0")]
	public int EBHPFJKLKDD(FDNGJDIOGPM KCGKBDGKIOP, bool PLKGHJDGOFO, [Optional] OutfitType? DOAOHLJCGOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6DBB1A0", Offset = "0x6DB99A0", VA = "0x186DBB1A0")]
	public int OCHBNJBIDIE(AEIOBEGHMKA ALHMBEPBCGJ, [Optional] OutfitType? DOAOHLJCGOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6DBAF60", Offset = "0x6DB9760", VA = "0x186DBAF60")]
	public void FENCJJOPLMC(FDNGJDIOGPM KCGKBDGKIOP, Matrix4x4 FKGPDNIBFHO, bool PLKGHJDGOFO = false, [Optional] OutfitType? DOAOHLJCGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6DBB050", Offset = "0x6DB9850", VA = "0x186DBB050")]
	public Matrix4x4 KLKPKJDMNDH(FDNGJDIOGPM KCGKBDGKIOP, bool PLKGHJDGOFO, [Optional] OutfitType? DOAOHLJCGOI)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0xEAAD10", Offset = "0xEA9510", VA = "0x180EAAD10")]
	public void HMJEONCOOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6DBB870", Offset = "0x6DBA070", VA = "0x186DBB870")]
	public EOKODHAPDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct FDNGJDIOGPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public readonly string CCIHDLMPPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public readonly AEIOBEGHMKA NHCDKHMODOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public readonly OutfitType? JCNLGHKBJCJ;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBC50", Offset = "0x6DBA450", VA = "0x186DBBC50")]
	public FDNGJDIOGPM(string JNPGLNANKNH, AEIOBEGHMKA ALHMBEPBCGJ, [Optional] OutfitType? DOAOHLJCGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBBA0", Offset = "0x6DBA3A0", VA = "0x186DBBBA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBA80", Offset = "0x6DBA280", VA = "0x186DBBA80")]
	public bool GBNBMLOJEOB(FDNGJDIOGPM LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6DBB9E0", Offset = "0x6DBA1E0", VA = "0x186DBB9E0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBB40", Offset = "0x6DBA340", VA = "0x186DBBB40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct LNFBMJCEDJB : IEquatable<LNFBMJCEDJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public readonly AEIOBEGHMKA NHCDKHMODOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public readonly OutfitType? NJIJNCMKHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public readonly int LFPHMOFIEKP;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFC10", Offset = "0x6DBE410", VA = "0x186DBFC10")]
	public LNFBMJCEDJB(AEIOBEGHMKA ALHMBEPBCGJ, int AKKLGNOCKIO, [Optional] OutfitType? IMCDGHLGGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFB50", Offset = "0x6DBE350", VA = "0x186DBFB50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B8F0", Offset = "0x1B1A0F0", VA = "0x181B1B8F0")]
	public bool PFGHKMOEAPG(AEIOBEGHMKA ALHMBEPBCGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFAD0", Offset = "0x6DBE2D0", VA = "0x186DBFAD0")]
	public bool INNADAADAAF(OutfitType? IMCDGHLGGAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFA30", Offset = "0x6DBE230", VA = "0x186DBFA30", Slot = "4")]
	public bool Equals(LNFBMJCEDJB LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF940", Offset = "0x6DBE140", VA = "0x186DBF940", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFA80", Offset = "0x6DBE280", VA = "0x186DBFA80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct KADOGLANDHL : IEquatable<KADOGLANDHL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public readonly Transform BINHLIFOMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public readonly bool PKDJACNGBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public readonly AEIOBEGHMKA MCAFGPBJJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public readonly OutfitType? JCNLGHKBJCJ;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD830", Offset = "0x6DBC030", VA = "0x186DBD830")]
	public KADOGLANDHL(Transform AAFNBMMBJJB, bool CKDIODOHLJB, AEIOBEGHMKA POOIOOMFAJF, [Optional] OutfitType? DADIOEBAJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD620", Offset = "0x6DBBE20", VA = "0x186DBD620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD3D0", Offset = "0x6DBBBD0", VA = "0x186DBD3D0", Slot = "4")]
	public bool Equals(KADOGLANDHL LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD4D0", Offset = "0x6DBBCD0", VA = "0x186DBD4D0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD5B0", Offset = "0x6DBBDB0", VA = "0x186DBD5B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6DBBC90", Offset = "0x6DBA490", VA = "0x186DBBC90")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface HLBFEEALFNE
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INDEEDGJMKE(Mesh CGIEBOGCCKF, Matrix4x4 BAPJNJGEKNN, byte[] OFHOOBGMHDP, bool ICMHKKLAPKJ = false, EAIGMANLNFK.LFNICJCICHD NKOAPEHBIKH = (EAIGMANLNFK.LFNICJCICHD)0, int MMKNHANONKJ = -1, bool ANMKMKHONHA = false);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHAJDEIEPIM(Allocator MOBIJPCBMOB, BDBJJGAKCLO PBNGBAKKBNK, byte KACMHBDGKHB, [Optional] IList<int> JJNAHMECMGF, [Optional] IList<int> FOEBCBPBFIN);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct HHIAOGOANPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly GameObject CHAOLNOOACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private readonly AvatarItemMaterial KICCPJPCEAH;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0xE64E60", Offset = "0xE63660", VA = "0x180E64E60")]
	public HHIAOGOANPG(GameObject CHAOLNOOACE, AvatarItemMaterial KICCPJPCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC7B0", Offset = "0x6DBAFB0", VA = "0x186DBC7B0")]
	public void JNFBIMDLNOG(Material KMOLIAGHFFN, int FNFFHMPGFMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class CMCOCMKJDIN : IKILHEFGINO<Task<(GameObject, AvatarItemMaterial)>, HHIAOGOANPG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct IEFEECECION : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6DBC840", Offset = "0x6DBB040", VA = "0x186DBC840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6DBCD40", Offset = "0x6DBB540", VA = "0x186DBCD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private MGNFCCKNAGM<GameObject> DJONDCDDGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private MGNFCCKNAGM<AvatarItemMaterial> PEBBDBEAFFD;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6B40", Offset = "0x6DB5340", VA = "0x186DB6B40")]
	private CMCOCMKJDIN(Task<(GameObject, AvatarItemMaterial)> DIGFCMIOIEB, MGNFCCKNAGM<GameObject> LDIODGJEMGJ, MGNFCCKNAGM<AvatarItemMaterial> FCDJKABEFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6DB66B0", Offset = "0x6DB4EB0", VA = "0x186DB66B0")]
	public static CMCOCMKJDIN JHEOKMMJDLF(AssetReference IKMGPJDEKPM, [Optional] AssetReference NEHLGLLANOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6610", Offset = "0x6DB4E10", VA = "0x186DB6610", Slot = "11")]
	protected override HHIAOGOANPG JCJMKJDPMGM(Task<(GameObject, AvatarItemMaterial)> HNOLFOALILG)
	{
		return default(HHIAOGOANPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6AC0", Offset = "0x6DB52C0", VA = "0x186DB6AC0", Slot = "12")]
	protected override void KILLBIPFPJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6DB64E0", Offset = "0x6DB4CE0", VA = "0x186DB64E0")]
	[AsyncStateMachine(typeof(IEFEECECION))]
	private static Task<(GameObject, AvatarItemMaterial)> EAEEHNIHHEO(Task<GameObject> IJDFHJIHPGA, Task<AvatarItemMaterial> MKCKBEKNFHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class BNJBMKNCDCF
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class EHJFDPMFBFN : IKILHEFGINO<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private MGNFCCKNAGM<MaterialMapAsset> KACBIAOBGKP;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6DB7ED0", Offset = "0x6DB66D0", VA = "0x186DB7ED0")]
		public EHJFDPMFBFN(MGNFCCKNAGM<MaterialMapAsset> KACBIAOBGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6DB7A30", Offset = "0x6DB6230", VA = "0x186DB7A30", Slot = "11")]
		protected override Material[] JCJMKJDPMGM(Task<MaterialMapAsset> DIGFCMIOIEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6DB7E70", Offset = "0x6DB6670", VA = "0x186DB7E70", Slot = "12")]
		protected override void KILLBIPFPJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MGGKECBPBON : IKILHEFGINO<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private List<MGNFCCKNAGM<Material>> FOOPPDKFADO;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6DBFDB0", Offset = "0x6DBE5B0", VA = "0x186DBFDB0")]
		public MGGKECBPBON(Task<Material[]> DIGFCMIOIEB, List<MGNFCCKNAGM<Material>> FOOPPDKFADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6DBFC20", Offset = "0x6DBE420", VA = "0x186DBFC20", Slot = "11")]
		protected override Material[] JCJMKJDPMGM(Task<Material[]> HNOLFOALILG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6DBFC70", Offset = "0x6DBE470", VA = "0x186DBFC70", Slot = "12")]
		protected override void KILLBIPFPJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5F30", Offset = "0x6DB4730", VA = "0x186DB5F30")]
	public static MGNFCCKNAGM<Material[]> HHOKNDPCDHP(AssetReference[] JLPGNGNNOPL)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public enum OHCAKJBOHBG
		{
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum AHMHEBKPEDD
		{
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum PFPHPCBCNEC : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct LDCGIOIKDEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public readonly Material OAPEFBDFDDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public readonly OHCAKJBOHBG OKGOBAFJIGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public readonly AHMHEBKPEDD FALIEABGNBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public readonly AEIOBEGHMKA NHCDKHMODOC;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x6DB4F90", Offset = "0x6DB3790", VA = "0x186DB4F90")]
			public LDCGIOIKDEN(Material KMOLIAGHFFN, OHCAKJBOHBG GHJFOFFDIDB, AHMHEBKPEDD KLHPPCFCKIP, AEIOBEGHMKA ALHMBEPBCGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x6DD81D0", Offset = "0x6DD69D0", VA = "0x186DD81D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x6DB4C50", Offset = "0x6DB3450", VA = "0x186DB4C50")]
			public bool GBNBMLOJEOB(LDCGIOIKDEN LIHCAHPMPHD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x6DD8050", Offset = "0x6DD6850", VA = "0x186DD8050", Slot = "0")]
			public override bool Equals(object INCBEIDOHDO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x6DD8130", Offset = "0x6DD6930", VA = "0x186DD8130", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		protected struct CKMHDFIEMNI : IComparable<CKMHDFIEMNI>, IEquatable<CKMHDFIEMNI>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public int HCPNIHPPFIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public PlayerAvatarDisplayBase DHOBPLNCIMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public IList<BMDNNHFLKKG> FBFLFLPNPGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public AvatarItemBodyType BOKHMJHPEGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public PGEPFFCGHEN MFKPOKBNCLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public bool BIBJODPOJBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public int[] ECCCKABODGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public float GGBLJOHLBEJ;

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x6DD1330", Offset = "0x6DCFB30", VA = "0x186DD1330", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x6DD11D0", Offset = "0x6DCF9D0", VA = "0x186DD11D0", Slot = "4")]
			public int CompareTo(CKMHDFIEMNI LIHCAHPMPHD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x6DD11F0", Offset = "0x6DCF9F0", VA = "0x186DD11F0", Slot = "5")]
			public bool Equals(CKMHDFIEMNI LIHCAHPMPHD)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected abstract class NBMABALEDMJ
		{
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			public class BENIBNPMEFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000346")]
				public readonly Mesh ENCDJHLLEFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000347")]
				public readonly Material[] NPPJPOKPDNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000348")]
				public readonly Transform[] FDBJPPCFCEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000349")]
				public readonly Matrix4x4[] PPIOFONPCPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400034A")]
				public readonly Transform BDIMFAKBCLC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400034B")]
				public readonly bool IMKPDNOJODH;

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
				protected BENIBNPMEFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x6DD0590", Offset = "0x6DCED90", VA = "0x186DD0590")]
				public BENIBNPMEFB(Mesh CGIEBOGCCKF, Material[] BJPAIAGNIAF, bool BLDNOKKNALP, Transform[] CBPFNKIMEFM, Transform DDHEKGIDAFE, Matrix4x4[] EKLLEGKLHHD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x6DD04D0", Offset = "0x6DCECD0", VA = "0x186DD04D0")]
				private BENIBNPMEFB(SkinnedMeshRenderer FLIAFEBHCJO, Material[] CHENINHDANP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x6DD0A40", Offset = "0x6DCF240", VA = "0x186DD0A40")]
				private BENIBNPMEFB(MeshRenderer GJCHMCPNOMN, Transform DDHEKGIDAFE, Material[] CHENINHDANP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x6DD01B0", Offset = "0x6DCE9B0", VA = "0x186DD01B0")]
				public static BENIBNPMEFB JAJJKLNNHDA(Renderer ALAKDHHJBKP, Material[] CHENINHDANP)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public readonly AEIOBEGHMKA NHCDKHMODOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public readonly Transform GHDMJHFCNOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public readonly bool GAPOCILAINN;

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public virtual bool ANPHKLNBGCH
			{
				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public virtual bool KHPINKJICBM
			{
				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual EAIGMANLNFK.LFNICJCICHD KFDELGIMFCG
			{
				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "6")]
				get
				{
					return default(EAIGMANLNFK.LFNICJCICHD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public bool CFCGCOHPPAH
			{
				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x6DD85F0", Offset = "0x6DD6DF0", VA = "0x186DD85F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x6DD8600", Offset = "0x6DD6E00", VA = "0x186DD8600")]
			protected NBMABALEDMJ(AEIOBEGHMKA ALHMBEPBCGJ, Transform BAGKGOFOIJP, bool FHKDPJBNPJL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract MOPOHKAGKCI NAIHOEBOHMG(List<FGNKNNJACKL> CJFEEEHHKNB, List<FGNKNNJACKL> LILADLFLJLC);

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract BENIBNPMEFB PKJAMJIPGAE(int PBCKDIKKJCB, PlayerHandBones DCMHNMCPJPI);
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected class FJBBFOCPEGF : NBMABALEDMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			protected readonly BodyPartLODs MANNELLCACH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			protected readonly Material[] OOLCMNIPHGL;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4BD0", Offset = "0x6DD33D0", VA = "0x186DD4BD0")]
			public FJBBFOCPEGF(AEIOBEGHMKA ALHMBEPBCGJ, BodyPartLODs FKLHOLJLPBO, Material HIHGBOPCNDN, [Optional] Transform BAGKGOFOIJP, bool FHKDPJBNPJL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4910", Offset = "0x6DD3110", VA = "0x186DD4910", Slot = "7")]
			public override MOPOHKAGKCI NAIHOEBOHMG(List<FGNKNNJACKL> CJFEEEHHKNB, List<FGNKNNJACKL> LILADLFLJLC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x6DD49A0", Offset = "0x6DD31A0", VA = "0x186DD49A0", Slot = "8")]
			public override BENIBNPMEFB PKJAMJIPGAE(int PBCKDIKKJCB, PlayerHandBones DCMHNMCPJPI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4B60", Offset = "0x6DD3360", VA = "0x186DD4B60", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class GABPCOPJAHJ : NBMABALEDMJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public override bool ANPHKLNBGCH
			{
				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public override bool KHPINKJICBM
			{
				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x6DD53F0", Offset = "0x6DD3BF0", VA = "0x186DD53F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public BGKNDGLJPPE DOAGALGGMHJ
			{
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x8BE300", Offset = "0x8BCB00", VA = "0x1808BE300")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5540", Offset = "0x6DD3D40", VA = "0x186DD5540")]
			public GABPCOPJAHJ(AEIOBEGHMKA ALHMBEPBCGJ, Transform BAGKGOFOIJP, BGKNDGLJPPE CGKGEPKOEPB, bool FHKDPJBNPJL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5440", Offset = "0x6DD3C40", VA = "0x186DD5440", Slot = "7")]
			public override MOPOHKAGKCI NAIHOEBOHMG(List<FGNKNNJACKL> CJFEEEHHKNB, List<FGNKNNJACKL> LILADLFLJLC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "8")]
			public override BENIBNPMEFB PKJAMJIPGAE(int PBCKDIKKJCB, PlayerHandBones DCMHNMCPJPI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x6DD54D0", Offset = "0x6DD3CD0", VA = "0x186DD54D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public class HCMFEKHLGPE
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			public enum KPLAHGGKDLE
			{
				[Cpp2IlInjected.Token(Token = "0x400035F")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public static readonly int IDCHFFOOLEN;

			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public static readonly int AIBACNBFOPE;

			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public static readonly int BAJHCGHMDIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			protected readonly BPFDFNAOGMP KBPCJMDFINF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			protected readonly DBKLEGDAAIA PCBNAINDBFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			protected readonly Animator GAHOFLKDHMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			protected readonly Transform HNHFDDHBHLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			protected readonly Vector3 EGGIIJMEHBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			protected readonly Transform GLIJJGAKEIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			protected readonly Vector3 HGFHDKPLGMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			protected bool JJMAGGLAPGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			protected BKBJJNPBHHC CACCKMIGJJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			protected bool MBDLGOGHJPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			protected float NBAIOECCJMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			protected LMHDAIHDIFF<ODEBCAINGAD> OHGNJJAKKFF;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public BKBJJNPBHHC DGDDILAEFHO
			{
				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x8B7520", Offset = "0x8B5D20", VA = "0x1808B7520")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x8B7570", Offset = "0x8B5D70", VA = "0x1808B7570")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public bool DHFIHEJMOKG
			{
				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0xA999B0", Offset = "0xA981B0", VA = "0x180A999B0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x6DD5A70", Offset = "0x6DD4270", VA = "0x186DD5A70")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public bool AHNOJJNBBED
			{
				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x8BD190", Offset = "0x8BB990", VA = "0x1808BD190")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x6DD63F0", Offset = "0x6DD4BF0", VA = "0x186DD63F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public float DECGMCOGDAP
			{
				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0xC73420", Offset = "0xC71C20", VA = "0x180C73420")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x6DD62B0", Offset = "0x6DD4AB0", VA = "0x186DD62B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public ODEBCAINGAD JEFEOFCBAKJ
			{
				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0x6DD5A30", Offset = "0x6DD4230", VA = "0x186DD5A30")]
				get
				{
					return default(ODEBCAINGAD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x6DD61A0", Offset = "0x6DD49A0", VA = "0x186DD61A0")]
			public bool NLPCAODPBEI(ODEBCAINGAD MGBFFKFKEGI, object DJIMHLGHFGI, KPLAHGGKDLE LAICNCJBINH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5B40", Offset = "0x6DD4340", VA = "0x186DD5B40")]
			public bool BNCJNEAHMPH(object DJIMHLGHFGI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6B60", Offset = "0x6DD5360", VA = "0x186DD6B60")]
			protected HCMFEKHLGPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6570", Offset = "0x6DD4D70", VA = "0x186DD6570")]
			public HCMFEKHLGPE(BPFDFNAOGMP KBPCJMDFINF, BKBJJNPBHHC HPGMEIEFLEL, Animator GAHOFLKDHMI, Transform HNHFDDHBHLI, Transform GLIJJGAKEIO, Vector3 EGGIIJMEHBL, Vector3 HGFHDKPLGMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5C40", Offset = "0x6DD4440", VA = "0x186DD5C40")]
			private void FKNCEKJIHOE(ushort ELDKKNGFGPD, ushort BEGCOKIJDDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5D40", Offset = "0x6DD4540", VA = "0x186DD5D40")]
			protected void JGILDOANOOF(ushort ELDKKNGFGPD, ushort BEGCOKIJDDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5E30", Offset = "0x6DD4630", VA = "0x186DD5E30")]
			protected void KHBJOMGDKEA(ushort ELDKKNGFGPD, ushort BEGCOKIJDDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5EF0", Offset = "0x6DD46F0", VA = "0x186DD5EF0")]
			protected void KIEGIOFJBKN(ushort ELDKKNGFGPD, ushort BEGCOKIJDDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x6DD58D0", Offset = "0x6DD40D0", VA = "0x186DD58D0")]
			protected void AJFEHHGHPKB(ushort ELDKKNGFGPD, ushort BEGCOKIJDDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6140", Offset = "0x6DD4940", VA = "0x186DD6140")]
			protected void NBKFGGHIMLA(ushort ELDKKNGFGPD, ushort BEGCOKIJDDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x6DD59E0", Offset = "0x6DD41E0", VA = "0x186DD59E0")]
			protected void AKNNAEBENJM(ushort ELDKKNGFGPD, ushort BEGCOKIJDDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5CF0", Offset = "0x6DD44F0", VA = "0x186DD5CF0")]
			protected void GEAPINEFPEM(ushort ELDKKNGFGPD, ushort BEGCOKIJDDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6020", Offset = "0x6DD4820", VA = "0x186DD6020")]
			protected void MLBNONIHBHF(ushort ELDKKNGFGPD, ushort BEGCOKIJDDD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class FJAICODAPEI : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public const int NCIFLIPOEJF = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected MaterialPropertyBlock EENGNPMJDPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public Color? HPCBIHNJIBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public Color? AMJOGGEJJID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Color? FJMLLDCPKHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Color AMEENABEBNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public Color AFNPDDAHBKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public Color KAPGPCCHLOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Texture2D MJDHDAOKIBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Texture2D NNCDJIJOFEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected Dictionary<LDCGIOIKDEN, int> IDHIPFKPOCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected OHCAKJBOHBG[] PECNMEEEEBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public Vector4[] DOIILMIHMMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public Vector4[] EBNCACKLJLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public Vector4[] PAPEKLPFLLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public Vector4[] MDKBDKKOJBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public Vector4[] MDDKBCFMNIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public Vector4[] APDLMAHJKMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected List<Texture2D> KNJAGBHGBLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected Vector4[] GDIBCBDBBKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			protected List<Texture2D> IDAGHPJFMDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected float[] HBDHDDCNBFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			protected Vector4[] BCCCHDLJJAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected float[] GGCHKBKOKKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public float[] CPEJPDIDEFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected List<Texture2D> ONPBKNGMABO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected float[] PJCICGONJPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected List<Texture2D> AMHNMPJKCHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected Vector4[] LBEKFDCELIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected float[] BDBAOFMCHKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			protected Vector4[] BHCCOIFCHOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public float[] OLEKGNBEFGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Texture2DArray EGBKEIOCHIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Texture2DArray GJHBLIJPKJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Texture2DArray JDJPDJLAOGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Texture2DArray NJDCBGEPJGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected bool OPDLDCEHOCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected int FIIBKGAPBCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected Vector2? OAHPPNCIPCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected TextureFormat KHHCLNKHNDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			protected Vector2? ADJPKHDDMGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			protected TextureFormat ALHHHGDLPBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected Vector2? IPENOPDFHDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			protected TextureFormat FEFMPJNCPCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected Vector2? HIOKAIKMHME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected TextureFormat JPFMBJGAHDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected bool LOEKDIGJGDI;

			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected static int PMONKFOOHHN;

			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected static int CCOJJHNCJLB;

			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected static int IGFEICDNFGD;

			[Cpp2IlInjected.Token(Token = "0x4000398")]
			protected static int LEFJFGOFCFJ;

			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected static int HOBPCHEJNHG;

			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected static int BDHBKBKKOCK;

			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected static int PIJIPFFAEIM;

			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected static int AEMOAMIECKD;

			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected static int DMHBDNKOPKM;

			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected static int OEJOCENIDJO;

			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected static int MMOOLIFHKNJ;

			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected static int DOJKODGHAIP;

			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected static int DIIADFJKDFL;

			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected static int IMINHNKNNIG;

			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected static int LFJIGBMHHHL;

			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected static int KNPBBJPHCOE;

			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected static int JAAPHJHCJDA;

			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected static int AAPJEGLJHFA;

			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected static int NJBLPOJCIHE;

			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected static int DCHLGLPKGPN;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x6DD43C0", Offset = "0x6DD2BC0", VA = "0x186DD43C0")]
			protected FJAICODAPEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4880", Offset = "0x6DD3080", VA = "0x186DD4880")]
			public FJAICODAPEI(Color KIPDOKLMKNH, Color ELNACFBLMFB, Color OBCLIDMNGBF, Color? HOLEOGPLEIJ, Color? PBOKBIIDCFB, Color? DDFOJPCMIPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x6DD2E00", Offset = "0x6DD1600", VA = "0x186DD2E00")]
			public int JKKILBIFCEL(Material COIAGFNLALP, OHCAKJBOHBG GHJFOFFDIDB, AHMHEBKPEDD KLHPPCFCKIP, AEIOBEGHMKA ALHMBEPBCGJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x6DD2D70", Offset = "0x6DD1570", VA = "0x186DD2D70")]
			public int JKKILBIFCEL(LDCGIOIKDEN KCGKBDGKIOP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x6DD2030", Offset = "0x6DD0830", VA = "0x186DD2030")]
			public int DBJKKHCNJIP(Material COIAGFNLALP, Color HJHJIMLHCBH, Color KJODLKNHGNM, Color IAJHFMNBCPC, Color BOBBJLCFBAE, Color KNMKIAFBFGC, Texture2D FFDDCMFIACF, Vector4 HBNNLDCOPNB, Texture2D MLFJBLGLBCI, Vector4 KNGGHAKJNNE, float DKNFPDEAGCA, float HGIHGJEIFIM, Texture2D NKMLOOAPLHJ, Vector4 IFFPHGBKOOB, float HENBBIKFHHL, Texture2D BKIEBINFBBL, float NKBIMOGKBHM, Color LLBNLMJIGOB, Vector4 LJCEAMHGIDM, OHCAKJBOHBG GHJFOFFDIDB, AHMHEBKPEDD KLHPPCFCKIP, AEIOBEGHMKA ALHMBEPBCGJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x6DD3A10", Offset = "0x6DD2210", VA = "0x186DD3A10")]
			protected void LDOCDHPHHEG([Out] Texture2DArray DFMFGFGHDFL, [Out] Texture2DArray CMEACNEOHBE, [Out] Texture2DArray OBPEKAPHCIJ, [Out] Texture2DArray JMMIJNOEALP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x6DD3DC0", Offset = "0x6DD25C0", VA = "0x186DD3DC0")]
			public void PONHMEMBNBP(PlayerAvatarDisplayBase KBNKHCEKIGP, Renderer ALAKDHHJBKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x6DD2EF0", Offset = "0x6DD16F0", VA = "0x186DD2EF0")]
			protected void KBFANFADGJH(PlayerAvatarDisplayBase KBNKHCEKIGP, Renderer ALAKDHHJBKP, int PFEHMDJINEP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x6DD3BD0", Offset = "0x6DD23D0", VA = "0x186DD3BD0")]
			private Color PEODFBNIMFJ(Color MJGHICDAAPE, OHCAKJBOHBG LJHKKNICJMJ)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x6DD1E50", Offset = "0x6DD0650", VA = "0x186DD1E50")]
			private Color CGIDHGIKEKB(Color NHIMCAMGNGF, OHCAKJBOHBG LJHKKNICJMJ)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x6DD1FA0", Offset = "0x6DD07A0", VA = "0x186DD1FA0")]
			protected void DAAMJOGDGDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x6DD2D30", Offset = "0x6DD1530", VA = "0x186DD2D30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x6DDE610", Offset = "0x6DDCE10", VA = "0x186DDE610")]
			public void DKMNPPLMJEC(AEIOBEGHMKA ALHMBEPBCGJ, [Out] Transform KAMAKIBPPKG, [Out] Transform[] CBPFNKIMEFM)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class AFLPNDPIIJN : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0xAC8700", Offset = "0xAC6F00", VA = "0x180AC8700")]
			[DebuggerHidden]
			public AFLPNDPIIJN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x6DCFEE0", Offset = "0x6DCE6E0", VA = "0x186DCFEE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x6DD0160", Offset = "0x6DCE960", VA = "0x186DD0160", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x6DD00B0", Offset = "0x6DCE8B0", VA = "0x186DD00B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x6DD00B0", Offset = "0x6DCE8B0", VA = "0x186DD00B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class ENMELODOJIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public ENMELODOJIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x6DD1D70", Offset = "0x6DD0570", VA = "0x186DD1D70")]
			internal bool JHPOMMJOFIK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class LCPAKCMMBHJ : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private IJKEOMMDACC <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public LCPAKCMMBHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x6DD7C20", Offset = "0x6DD6420", VA = "0x186DD7C20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x6DD8000", Offset = "0x6DD6800", VA = "0x186DD8000", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private struct FJILEBCDBKP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public KCALCFCCDIJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4CD0", Offset = "0x6DD34D0", VA = "0x186DD4CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5390", Offset = "0x6DD3B90", VA = "0x186DD5390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class DPNAIDFKFNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public DPNAIDFKFNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x6DD19A0", Offset = "0x6DD01A0", VA = "0x186DD19A0")]
			internal bool ECCJANLHNCH(BMDNNHFLKKG selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class GCNCOFLEMFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public Func<AKLEHMINLPM<Dictionary<string, MGNFCCKNAGM<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public GCNCOFLEMFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5620", Offset = "0x6DD3E20", VA = "0x186DD5620")]
			internal (DGGJLAPANLP, AKLEHMINLPM<Dictionary<string, MGNFCCKNAGM<Texture2D>>>) DHHKHGNNNBP(Dictionary<string, DJEJFNMFNJK> avatarItems)
			{
				return default((DGGJLAPANLP, AKLEHMINLPM<Dictionary<string, MGNFCCKNAGM<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x6DD55B0", Offset = "0x6DD3DB0", VA = "0x186DD55B0")]
			internal AKLEHMINLPM<Dictionary<string, MGNFCCKNAGM<Texture2D>>> BCPDOFKFMEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5810", Offset = "0x6DD4010", VA = "0x186DD5810")]
			internal void JHNNOAOPFHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class EIDGIMPJAAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public EIDGIMPJAAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x6DD1CC0", Offset = "0x6DD04C0", VA = "0x186DD1CC0")]
			internal bool ABOMHPLHMHI(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct IKHNBAFLBHA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6BF0", Offset = "0x6DD53F0", VA = "0x186DD6BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6DC0", Offset = "0x6DD55C0", VA = "0x186DD6DC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		protected static readonly int PODEMMKMONA;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		protected static readonly int LFFEJKGALEO;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		protected static readonly int MAIPJOAIFJH;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		protected static readonly int HAKMJAAHDMC;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		protected static readonly int JJMMJJNOGPB;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		protected static readonly int NJCCHKOGEOA;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		protected static readonly int[] FAADNHBIBGJ;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		protected static readonly int[] OGPKIDIDMMA;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		protected static readonly int[] GIPFJFJPMPH;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		protected static readonly int[] PCCEMCONPAO;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		protected static readonly int[] DAMNDAMOCDM;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		protected static readonly int[] CKLKMPIINCP;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		protected static List<PlayerAvatarDisplayBase> EFJBBFHKJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		protected AAOHFBHHFPJ LJKPCBHBKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected bool CGGMPNIAHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected bool OIKDINIEOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int[] OJHGBKAHLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected Dictionary<LDCGIOIKDEN, Material> GDNHCEJDALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected Dictionary<LDCGIOIKDEN, Material> MMNJMCHDEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		protected Material BPFAKKEJIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected JHNODDJNGEL DCBCHEGIMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private BKBJJNPBHHC DHEKPGMBODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private BKBJJNPBHHC KECGAGFEGPJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected Material JKJLOPKPFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected FitMeshHemisphere OBIOCBKCPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		protected bool MDKJHAOJCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		protected IOKFCBDBELC FMLBLJEBPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected bool FDIFHNPIBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected AnchorParamsRestrictions NCNFDAKMKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected bool JNBLOILFDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected Transform GMBEMBLMHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected bool JLMIBPOLMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		protected bool ONLLHMCEPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected Vector3 JHDOJKPJIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected Quaternion FFKIKIOLDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		protected Vector2 JBCEHHJGMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		protected FitMeshHemisphere ENPMOIKIINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		[SerializeField]
		[AEOOJFCMMHH(CPHBAPBBNNI.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected Collider[] PAHOOCCPMBA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected Collider[] EJGCCFLIEOE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected HCMFEKHLGPE[] CDGGEBCCEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public Dictionary<Renderer, FJAICODAPEI> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected Dictionary<Renderer, FJAICODAPEI> DBPNBHDHJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected GHHHBFNBJJJ EPHMIKKJOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected DGGJLAPANLP AMBOMJAAFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public HNNBIECDFEH DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected int NEHMIAKGOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected LMHDAIHDIFF<DBKLEGDAAIA> OHGNJJAKKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected bool HMGBICDNPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Dictionary<BMDNNHFLKKG, List<LDCGIOIKDEN>> GMGLOBBFANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected Dictionary<BMDNNHFLKKG, List<LDCGIOIKDEN>> IIJFCLHIMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected readonly Dictionary<string, MGNFCCKNAGM<Texture2D>> LHHCCFCHHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected readonly Dictionary<string, MGNFCCKNAGM<Texture2D>> OJOGNEHAFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected bool KNBNABLNHNP;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected static int OIJHCEEMEJF;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected static List<CKMHDFIEMNI> EIOPMEEGPBH;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected static List<CKMHDFIEMNI> KPFHNDPIJDO;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected static EBBFPAKHIHA HKAKPHDEHJN;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected static bool EIPBDGKKDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected Color? EOMFPFADOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected bool NLBPNPEIOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected Color AHLOLCKHHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Color DEBJMBKGKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected Color NMAOGFHNIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected AvatarHairPattern LCLCOEAICGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected BGKNDGLJPPE GHNOFNLGPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected Color LKHHLABJDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected Color BLCOGDLIFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected AvatarHairPattern BJEMONHAIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected BGKNDGLJPPE EEJCPFDMPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected BGKNDGLJPPE HHAOADDPJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected Color PJOCDJEJKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private AdditionalFeetData PICIPNMABBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected BMDNNHFLKKG? DCAFJJCDJME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected Texture LKIBINNMNDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected Color KAHIIPKEAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected readonly IList<BMDNNHFLKKG> NKGAINEOJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected readonly IList<BMDNNHFLKKG> MCGEEHJAKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private AvatarItemBodyType CEFCJECLFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B1")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected PFPHPCBCNEC OJFGJELAKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected int[] BEIFPGAKEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected bool EAIAPILPFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected int[] MOPDCOBJAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected bool DFBOLAKDKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected AHGGHFEHEPP FNJGJJFGKJM;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string CAJOFJMCBCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool JKOGGICADKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x933530", Offset = "0x931D30", VA = "0x180933530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x932FF0", Offset = "0x9317F0", VA = "0x180932FF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool HNJIOJFHBNG
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool OENDBEJJPCE
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x6DCEB30", Offset = "0x6DCD330", VA = "0x186DCEB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool CIEIAHMHODE
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool HCCKKANDKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool DGFLLKOPDJP
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public JHNODDJNGEL FCJDKIHNMDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x9DB460", Offset = "0x9D9C60", VA = "0x1809DB460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x6DCF120", Offset = "0x6DCD920", VA = "0x186DCF120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public BKBJJNPBHHC KOMMDGIKAHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x9DB470", Offset = "0x9D9C70", VA = "0x1809DB470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x6DCF470", Offset = "0x6DCDC70", VA = "0x186DCF470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public BKBJJNPBHHC GALKFAMHKFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x9DB480", Offset = "0x9D9C80", VA = "0x1809DB480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x6DCF720", Offset = "0x6DCDF20", VA = "0x186DCF720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected Material HLGIKMDMMEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x6DC5740", Offset = "0x6DC3F40", VA = "0x186DC5740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		protected Material IAEFIIIKGJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x6DC5480", Offset = "0x6DC3C80", VA = "0x186DC5480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool CDAODNKIFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x19B8020", Offset = "0x19B6820", VA = "0x1819B8020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public PlayerFacialAnimatorBase HCPMNAJOEDN
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x9DB620", Offset = "0x9D9E20", VA = "0x1809DB620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public HCMFEKHLGPE[] IBEOKMFDEAD
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE6F0", Offset = "0x6DCCEF0", VA = "0x186DCE6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public HCMFEKHLGPE CLLGAPHOHCF
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x6DCED40", Offset = "0x6DCD540", VA = "0x186DCED40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public HCMFEKHLGPE IIPPGIGNFHD
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x6DCED70", Offset = "0x6DCD570", VA = "0x186DCED70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Mesh FDCOHAJJDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x9DB3E0", Offset = "0x9D9BE0", VA = "0x1809DB3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected GHHHBFNBJJJ ODNNEEFDDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x6DC6890", Offset = "0x6DC5090", VA = "0x186DC6890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected DGGJLAPANLP CCJJCDCMBIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x9DB420", Offset = "0x9D9C20", VA = "0x1809DB420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x6DC33B0", Offset = "0x6DC1BB0", VA = "0x186DC33B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected bool INPNAAIOLMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool PEKDMGFPPBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x6DCED30", Offset = "0x6DCD530", VA = "0x186DCED30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int PEELKILCNKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1BBE9B0", Offset = "0x1BBD1B0", VA = "0x181BBE9B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x6DCF680", Offset = "0x6DCDE80", VA = "0x186DCF680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected virtual bool HNEDNIOGDHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected virtual int[] MEEILKEIHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x6DC4830", Offset = "0x6DC3030", VA = "0x186DC4830", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected bool KALOHHPNNEE
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x6DC6810", Offset = "0x6DC5010", VA = "0x186DC6810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		protected static bool IJJOJLAIKBG
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool NIDLLCEILBE
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x26B9F90", Offset = "0x26B8790", VA = "0x1826B9F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x6DCF930", Offset = "0x6DCE130", VA = "0x186DCF930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public IEnumerable<SkinnedMeshRenderer> ELMDKPIFFFP
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE5D0", Offset = "0x6DCCDD0", VA = "0x186DCE5D0")]
			[IteratorStateMachine(typeof(AFLPNDPIIJN))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool KNPGJHABEDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x6DCED20", Offset = "0x6DCD520", VA = "0x186DCED20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x6DC3CF0", Offset = "0x6DC24F0", VA = "0x186DC3CF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public HBPDIAMDKLD PCNKPJGKKNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE650", Offset = "0x6DCCE50", VA = "0x186DCE650")]
			get
			{
				return default(HBPDIAMDKLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public static bool MJBIEOFDKMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x6DCEAA0", Offset = "0x6DCD2A0", VA = "0x186DCEAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected static EBBFPAKHIHA HNEOMJNBKMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x6DC3B00", Offset = "0x6DC2300", VA = "0x186DC3B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x6DC9970", Offset = "0x6DC8170", VA = "0x186DC9970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected Color AMJOGGEJJID
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x6DC2170", Offset = "0x6DC0970", VA = "0x186DC2170")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected Color FJMLLDCPKHG
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x6DC7240", Offset = "0x6DC5A40", VA = "0x186DC7240")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected Texture2D AHAAGBPJDGC
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x6DCA3C0", Offset = "0x6DC8BC0", VA = "0x186DCA3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected Color AMEENABEBNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x6DC9FD0", Offset = "0x6DC87D0", VA = "0x186DC9FD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected Color AFNPDDAHBKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x6DC47E0", Offset = "0x6DC2FE0", VA = "0x186DC47E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public BGKNDGLJPPE HKHGDONNHNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE6B0", Offset = "0x6DCCEB0", VA = "0x186DCE6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected Texture2D ONEILBFELML
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x6DC2FF0", Offset = "0x6DC17F0", VA = "0x186DC2FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public float MNKDODIHKOM
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE6D0", Offset = "0x6DCCED0", VA = "0x186DCE6D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public float EEMGBMBFDDL
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x6DCEB10", Offset = "0x6DCD310", VA = "0x186DCEB10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool KDLAEPCHAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xECFEA0", Offset = "0xECE6A0", VA = "0x180ECFEA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x6DCEF00", Offset = "0x6DCD700", VA = "0x186DCEF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PPGOCHBKMPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE470", Offset = "0x6DCCC70", VA = "0x186DCE470")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x6DCEDA0", Offset = "0x6DCD5A0", VA = "0x186DCEDA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<BPFDFNAOGMP, ODEBCAINGAD> DPDKPIDCMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE510", Offset = "0x6DCCD10", VA = "0x186DCE510")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x6DCEE40", Offset = "0x6DCD640", VA = "0x186DCEE40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB420", Offset = "0x6DC9C20", VA = "0x186DCB420")]
		public bool SetDeformation(bool CGGMPNIAHMK, bool OIKDINIEOMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3D00", Offset = "0x6DC2500", VA = "0x186DC3D00")]
		protected static Material COAIDGIHFKK(Dictionary<LDCGIOIKDEN, Material> KKNGIJPJIIE, Material MJHJHMBIGAN, OHCAKJBOHBG GHJFOFFDIDB, AHMHEBKPEDD KLHPPCFCKIP, AEIOBEGHMKA ALHMBEPBCGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8E40", Offset = "0x6DC7640", VA = "0x186DC8E40")]
		protected void NAFAONLILMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9B40", Offset = "0x6DC8340", VA = "0x186DC9B40")]
		protected bool NPHNEPLODIJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6C10", Offset = "0x6DC5410", VA = "0x186DC6C10")]
		protected void KENOAEKEKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6CA0", Offset = "0x6DC54A0", VA = "0x186DC6CA0", Slot = "10")]
		protected virtual void KFNHEKMHHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8D80", Offset = "0x6DC7580", VA = "0x186DC8D80")]
		public int MeshesAtLODCount(int PHILGECLPDM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6DC63D0", Offset = "0x6DC4BD0", VA = "0x186DC63D0")]
		protected static void IELPOAEIHCJ(Dictionary<BMDNNHFLKKG, List<LDCGIOIKDEN>> HHFOKDEELMJ, NBMABALEDMJ AENKKGNBDNE, Material MJHJHMBIGAN, OHCAKJBOHBG LJHKKNICJMJ, AHMHEBKPEDD DOPLPLBKGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2B50", Offset = "0x6DC1350", VA = "0x186DC2B50")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2CB0", Offset = "0x6DC14B0", VA = "0x186DC2CB0")]
		protected void BBFAHOFCEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA180", Offset = "0x6DC8980", VA = "0x186DCA180")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "11")]
		protected virtual void GIPJHIFBCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6AD0", Offset = "0x6DC52D0", VA = "0x186DC6AD0")]
		protected static void KBMJPKOEJBJ(List<Material> DJOIBHHAAKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC66B0", Offset = "0x6DC4EB0", VA = "0x186DC66B0")]
		protected static void IKFAIDKDGIL(Dictionary<LDCGIOIKDEN, Material> KKNGIJPJIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA020", Offset = "0x6DC8820", VA = "0x186DCA020")]
		protected static void OPNFKIFCBCO(Dictionary<Renderer, FJAICODAPEI> FGEMBEFFECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6D00", Offset = "0x6DC5500", VA = "0x186DC6D00")]
		protected void KHMPPAJGGLM(SkinnedMeshRenderer[] FAOHBBNGEKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5DF0", Offset = "0x6DC45F0", VA = "0x186DC5DF0")]
		protected void GLJLCEPCHAK(SkinnedMeshRenderer FLIAFEBHCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5E90", Offset = "0x6DC4690", VA = "0x186DC5E90")]
		protected void GLJLCEPCHAK(MeshRenderer GJCHMCPNOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8BB0", Offset = "0x6DC73B0", VA = "0x186DC8BB0")]
		protected void MPPPAICGCJK(List<FGNKNNJACKL> KJGFJMLLKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7670", Offset = "0x6DC5E70", VA = "0x186DC7670")]
		protected void LNHPODJFMOK(Dictionary<string, MGNFCCKNAGM<Texture2D>> HHFOKDEELMJ, bool NCAIBLCDNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5D10", Offset = "0x6DC4510", VA = "0x186DC5D10")]
		protected void FHJKKPMOJAN(Dictionary<BMDNNHFLKKG, List<LDCGIOIKDEN>> HHFOKDEELMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5F60", Offset = "0x6DC4760", VA = "0x186DC5F60")]
		public float GetHandOpenClosedAxis(BPFDFNAOGMP KBPCJMDFINF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6DCBCB0", Offset = "0x6DCA4B0", VA = "0x186DCBCB0")]
		public void SetHandOpenClosedAxis(BPFDFNAOGMP KBPCJMDFINF, float OPIHLFBEBMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5FA0", Offset = "0x6DC47A0", VA = "0x186DC5FA0")]
		public ODEBCAINGAD GetHandVisualState(BPFDFNAOGMP KBPCJMDFINF)
		{
			return default(ODEBCAINGAD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2290", Offset = "0x6DC0A90", VA = "0x186DC2290")]
		public bool AddHandVisualStateToken(BPFDFNAOGMP KBPCJMDFINF, ODEBCAINGAD OANCCLDPEFB, object DJIMHLGHFGI, HCMFEKHLGPE.KPLAHGGKDLE LAICNCJBINH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD3C0", Offset = "0x6DCBBC0", VA = "0x186DCD3C0")]
		public void SetWatchHand(BPFDFNAOGMP KBPCJMDFINF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD480", Offset = "0x6DCBC80", VA = "0x186DCD480")]
		public void SetWatchHands(bool MJPAMGJGALA, bool DFOOGDPLMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6DCAAE0", Offset = "0x6DC92E0", VA = "0x186DCAAE0")]
		public bool RemoveHandVisualStateToken(BPFDFNAOGMP KBPCJMDFINF, object DJIMHLGHFGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6020", Offset = "0x6DC4820", VA = "0x186DC6020")]
		public bool GetThumbsUpActive(BPFDFNAOGMP KBPCJMDFINF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCE70", Offset = "0x6DCB670", VA = "0x186DCCE70")]
		public void SetThumbsUpActive(BPFDFNAOGMP KBPCJMDFINF, bool EIABIMAGHBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5FE0", Offset = "0x6DC47E0", VA = "0x186DC5FE0")]
		public bool GetHandshakeActive(BPFDFNAOGMP KBPCJMDFINF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6DCBD00", Offset = "0x6DCA500", VA = "0x186DCBD00")]
		public void SetHandshakeActive(BPFDFNAOGMP KBPCJMDFINF, bool GCCDOKODMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5D60", Offset = "0x6DC4560", VA = "0x186DC5D60")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4460", Offset = "0x6DC2C60", VA = "0x186DC4460")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7290", Offset = "0x6DC5A90", VA = "0x186DC7290")]
		protected static void LHAHFJNPDDA(PlayerAvatarDisplayBase GFEPIFIFNPJ, List<CKMHDFIEMNI> HCMOCBDBHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA800", Offset = "0x6DC9000", VA = "0x186DCA800")]
		public void Rebuild(bool HGJIOGPLIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3660", Offset = "0x6DC1E60", VA = "0x186DC3660")]
		protected void BPOHHAKPCLD(bool HGJIOGPLIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3510", Offset = "0x6DC1D10", VA = "0x186DC3510", Slot = "12")]
		protected virtual MOPOHKAGKCI BPOHHAKPCLD(IList<BMDNNHFLKKG> CNACADCANJD, AvatarItemBodyType ONKLNIFDAAG, bool MBHGAHNCAGP, int[] OFJIHOIIKPG, bool HGJIOGPLIHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8FA0", Offset = "0x6DC77A0", VA = "0x186DC8FA0")]
		protected static MOPOHKAGKCI NGDECCPBBJI(CKMHDFIEMNI KOFCAIIFJFB, List<CKMHDFIEMNI> HCMOCBDBHPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6370", Offset = "0x6DC4B70", VA = "0x186DC6370")]
		[IteratorStateMachine(typeof(LCPAKCMMBHJ))]
		protected static IEnumerator<IJKEOMMDACC> ICDBPJLOLEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3450", Offset = "0x6DC1C50", VA = "0x186DC3450")]
		protected static CKMHDFIEMNI BLHHDEOOONN(List<CKMHDFIEMNI> HCMOCBDBHPO)
		{
			return default(CKMHDFIEMNI);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB520", Offset = "0x6DC9D20", VA = "0x186DCB520")]
		[AsyncStateMachine(typeof(FJILEBCDBKP))]
		public Task SetFaceCustomizationSettings(KCALCFCCDIJ BKGPNGLOPKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC68B0", Offset = "0x6DC50B0", VA = "0x186DC68B0")]
		public void InitializeFaceFeatures(AvatarConfiguration JJMFPHKJCJN, HBPDIAMDKLD OAFFOKJEIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCBD0", Offset = "0x6DCB3D0", VA = "0x186DCCBD0")]
		public void SetTeamColors(Color? DDFOJPCMIPH, bool HJOKPDIGBOL, Color FMIKIBKGNFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xE36790", Offset = "0xE34F90", VA = "0x180E36790")]
		private static void NKJCEFMBFFF(Material KMOLIAGHFFN, Color INDENPJBLHO, params int[] LPLMHKBFNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xE35B60", Offset = "0xE34360", VA = "0x180E35B60")]
		private static void FAEGKMMMHDC(Material KMOLIAGHFFN, Texture INDENPJBLHO, params int[] LPLMHKBFNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6DC73A0", Offset = "0x6DC5BA0", VA = "0x186DC73A0")]
		protected void LKBCHPLLAFB(Material PFFBGKIAAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9EB0", Offset = "0x6DC86B0", VA = "0x186DC9EB0")]
		protected void OKGEHBJBPGC(Material PFFBGKIAAII, Color BNFDKDMBEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3780", Offset = "0x6DC1F80", VA = "0x186DC3780")]
		protected void CGOKMFPPDJO(Material PFFBGKIAAII, Color BNFDKDMBEAF, Color MDHMLBMHJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6DC77F0", Offset = "0x6DC5FF0", VA = "0x186DC77F0")]
		protected void LOBGJPELDCJ(Material PFFBGKIAAII, Texture2D NOCDIJBAKKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6E20", Offset = "0x6DC5620", VA = "0x186DC6E20")]
		protected void KPHNGKODHJA(Material PFFBGKIAAII, Texture CPBBFELOJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4580", Offset = "0x6DC2D80", VA = "0x186DC4580")]
		protected void DDFENKBGLAN(Action<FJAICODAPEI> FCPJCHEGGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA5C0", Offset = "0x6DC8DC0", VA = "0x186DCA5C0")]
		protected void POOJCGFFNLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6060", Offset = "0x6DC4860", VA = "0x186DC6060")]
		protected void HKIFAEJDPBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6DC48C0", Offset = "0x6DC30C0", VA = "0x186DC48C0")]
		protected void DLHFFPFPOLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6DC25E0", Offset = "0x6DC0DE0", VA = "0x186DC25E0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6DCAEA0", Offset = "0x6DC96A0", VA = "0x186DCAEA0")]
		public void SetBeardPrimaryColor([Optional] Color? BGEAHOAINIE, bool MDGPAOLJFIP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB0C0", Offset = "0x6DC98C0", VA = "0x186DCB0C0")]
		public void SetBeardSecondaryColor([Optional] Color? BGEAHOAINIE, bool MDGPAOLJFIP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6DCAD60", Offset = "0x6DC9560", VA = "0x186DCAD60")]
		public void SetBeardPattern([Optional] AvatarHairPattern LBPEHMPNGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2000", Offset = "0x6DC0800", VA = "0x186DC2000")]
		private void AJKJOOKMLNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6A20", Offset = "0x6DC5220", VA = "0x186DC6A20")]
		private bool JPKKGILEGMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB890", Offset = "0x6DCA090", VA = "0x186DCB890")]
		public void SetHairPrimaryColor([Optional] Color? ADBOBMAONBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6DCBAA0", Offset = "0x6DCA2A0", VA = "0x186DCBAA0")]
		public void SetHairSecondaryColor([Optional] Color? ADBOBMAONBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB760", Offset = "0x6DC9F60", VA = "0x186DCB760")]
		public void SetHairPattern([Optional] AvatarHairPattern LBPEHMPNGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA980", Offset = "0x6DC9180", VA = "0x186DCA980")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6F30", Offset = "0x6DC5730", VA = "0x186DC6F30")]
		private bool LBEIGEBCIJK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCA10", Offset = "0x6DCB210", VA = "0x186DCCA10")]
		public void SetSkinColor(Color KIPDOKLMKNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCEC0", Offset = "0x6DCB6C0", VA = "0x186DCCEC0")]
		public void SetUgcItemVisualOverrides(BMDNNHFLKKG AAJAFNMHMFI, HBPDIAMDKLD OAFFOKJEIOL, Texture MBEDEFEHHOP, Color IKDICHEPPKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4530", Offset = "0x6DC2D30", VA = "0x186DC4530")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB620", Offset = "0x6DC9E20", VA = "0x186DCB620")]
		public bool SetFaceShape(AvatarFaceShape OMCGAIAJMLG, bool KHCLPHIANIF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB2E0", Offset = "0x6DC9AE0", VA = "0x186DCB2E0")]
		public bool SetBodyShape(AvatarBodyShape CBGLDGEOAHC, bool KHCLPHIANIF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD5E0", Offset = "0x6DCBDE0", VA = "0x186DCD5E0")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC950", Offset = "0x6DCB150", VA = "0x186DCC950")]
		public bool SetHideEars(bool PIIMIBKAFII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC940", Offset = "0x6DCB140", VA = "0x186DCC940")]
		public bool SetHelmetHair(AAOHFBHHFPJ GBFCDDPKHIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC3A0", Offset = "0x6DCABA0", VA = "0x186DCC3A0")]
		public void SetHatAnchorParameters(IOKFCBDBELC EEDMLLFCGLB, bool ALFPNOJJFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD550", Offset = "0x6DCBD50", VA = "0x186DCD550")]
		public void SetupDisplayLODs(PFPHPCBCNEC NPHPFOLMCFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5AC0", Offset = "0x6DC42C0", VA = "0x186DC5AC0")]
		protected int[] FAMMMFEEPPJ(PFPHPCBCNEC NPHPFOLMCFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC970", Offset = "0x6DCB170", VA = "0x186DCC970")]
		public void SetOutfitSelections(IList<BMDNNHFLKKG> CNACADCANJD, AvatarItemBodyType ONKLNIFDAAG, bool HGJIOGPLIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC9E0", Offset = "0x6DCB1E0", VA = "0x186DCC9E0")]
		public void SetOutfitSelections(IList<BMDNNHFLKKG> CNACADCANJD, AvatarItemBodyType ONKLNIFDAAG, bool MBHGAHNCAGP, bool HGJIOGPLIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC9A0", Offset = "0x6DCB1A0", VA = "0x186DCC9A0")]
		public MOPOHKAGKCI SetOutfitSelections(IList<BMDNNHFLKKG> CNACADCANJD, AvatarItemBodyType ONKLNIFDAAG, PFPHPCBCNEC NPHPFOLMCFF, bool MBHGAHNCAGP, bool KHCLPHIANIF = false, bool HGJIOGPLIHO = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6FF0", Offset = "0x6DC57F0", VA = "0x186DC6FF0")]
		private MOPOHKAGKCI LDIAIFKBBBO(IList<BMDNNHFLKKG> CNACADCANJD, AvatarItemBodyType ONKLNIFDAAG, bool MBHGAHNCAGP, PFPHPCBCNEC NPHPFOLMCFF, bool KHCLPHIANIF, bool HGJIOGPLIHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC46E0", Offset = "0x6DC2EE0", VA = "0x186DC46E0")]
		protected int[] DIAHMEJPFCF(PFPHPCBCNEC NPHPFOLMCFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "13")]
		protected virtual DGGJLAPANLP MDFNKOMJGCB(AvatarItemBodyType PABCJGJOBAA, Dictionary<string, DJEJFNMFNJK> PJNJODOMJMG, Dictionary<string, MGNFCCKNAGM<Texture2D>> AKPPHOKHFID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC30F0", Offset = "0x6DC18F0", VA = "0x186DC30F0", Slot = "14")]
		protected virtual MOPOHKAGKCI BEHACAMCNIN(IList<BMDNNHFLKKG> CNACADCANJD, AvatarItemBodyType ONKLNIFDAAG, bool MBHGAHNCAGP, int[] ECCCKABODGB, PGEPFFCGHEN MCDMGECDKGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4C20", Offset = "0x6DC3420", VA = "0x186DC4C20", Slot = "15")]
		protected virtual DJEJFNMFNJK DLKOBLEFKDK(BGKNDGLJPPE CGKGEPKOEPB, AvatarItemBodyType PABCJGJOBAA, AEIOBEGHMKA ALHMBEPBCGJ, DJEJFNMFNJK INLIDHGBLOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "16")]
		protected virtual DJEJFNMFNJK OMAKEMLIGBH(AvatarItemBodyType PABCJGJOBAA, AEIOBEGHMKA ALHMBEPBCGJ, LHEFGIGDDND AFFIFGJEAGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5C90", Offset = "0x6DC4490", VA = "0x186DC5C90")]
		protected void FBJDAGJBELG(AEIPNJOAFNB JNEMJOOPHKP, EAIGMANLNFK.LFNICJCICHD DDCFOILEMME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA4B0", Offset = "0x6DC8CB0", VA = "0x186DCA4B0")]
		protected void PBMCDCKNBBN(AEIPNJOAFNB JNEMJOOPHKP, EAIGMANLNFK.LFNICJCICHD DDCFOILEMME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA3B090", Offset = "0xA39890", VA = "0x180A3B090", Slot = "17")]
		protected virtual AEIPNJOAFNB HJGEIHGCLIJ(AEIPNJOAFNB JNEMJOOPHKP, HelmetHairStyle CIJHDKOIONL, bool NENAKAJFIOG, AvatarItemBodyType ONKLNIFDAAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7BB0", Offset = "0x6DC63B0", VA = "0x186DC7BB0")]
		protected AEIPNJOAFNB MJPMFLLKJKL(IList<BMDNNHFLKKG> CNACADCANJD, AvatarItemBodyType FDCJIHKPPMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4340", Offset = "0x6DC2B40", VA = "0x186DC4340")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6220", Offset = "0x6DC4A20", VA = "0x186DC6220")]
		protected void HLHNLNCFCLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9650", Offset = "0x6DC7E50", VA = "0x186DC9650")]
		protected void NKGANBIICHI(Transform AHHKANIIBFJ, IEnumerable<SkinnedMeshRenderer> NKJJBMFFOKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6DC36B0", Offset = "0x6DC1EB0", VA = "0x186DC36B0")]
		protected EAIGMANLNFK.LFNICJCICHD CBEFECPBFEE(EAIGMANLNFK.LFNICJCICHD DIALOLLAGFL, AEIOBEGHMKA LOAJBBPNOKD)
		{
			return default(EAIGMANLNFK.LFNICJCICHD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5C80", Offset = "0x6DC4480", VA = "0x186DC5C80")]
		protected void FBFOMAIGGLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xDAC710", Offset = "0xDAAF10", VA = "0x180DAC710")]
		protected void IIFMKCDKBAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3BE0", Offset = "0x6DC23E0", VA = "0x186DC3BE0")]
		protected void CLJILCDPLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5980", Offset = "0x6DC4180", VA = "0x186DC5980")]
		[AsyncStateMachine(typeof(IKHNBAFLBHA))]
		protected Task EJPLOPCCPGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7A10", Offset = "0x6DC6210", VA = "0x186DC7A10")]
		protected static OHCAKJBOHBG MJAOJNDKBNP(NBMABALEDMJ OOAKFMJKDKO, int GOHKKLDBFAM)
		{
			return default(OHCAKJBOHBG);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC39B0", Offset = "0x6DC21B0", VA = "0x186DC39B0")]
		protected static AHMHEBKPEDD CJDPJMNMKDE(NBMABALEDMJ OOAKFMJKDKO, int GOHKKLDBFAM)
		{
			return default(AHMHEBKPEDD);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8F60", Offset = "0x6DC7760", VA = "0x186DC8F60")]
		protected Transform NFELNJAFDLA(AEIOBEGHMKA ALHMBEPBCGJ, OutfitType DOAOHLJCGOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5110", Offset = "0x6DC3910", VA = "0x186DC5110")]
		protected void DOJECOEKLDH(int FNFFHMPGFMC, Material KMOLIAGHFFN, NBMABALEDMJ OOAKFMJKDKO, [Out] Texture2D GNIHKNJJNJD, [Out] Vector4 BJLFCNHAGME, [Out] Texture2D HOMADOPBLNN, [Out] Texture2D GLCEGOGCDLH, [Out] Texture2D PFFOIOIPPPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6DC55F0", Offset = "0x6DC3DF0", VA = "0x186DC55F0")]
		protected void EHMBCOIOOFN(int FNFFHMPGFMC, Material KMOLIAGHFFN, NBMABALEDMJ OOAKFMJKDKO, [Out] Color HJHJIMLHCBH, [Out] Color KJODLKNHGNM, [Out] Color IAJHFMNBCPC, [Out] Color BOBBJLCFBAE, [Out] Color KNMKIAFBFGC, [Out] Color LLBNLMJIGOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5A50", Offset = "0x6DC4250", VA = "0x186DC5A50")]
		protected void EMFLMIGIFLG(Vector3 CMIONGHAGGG, Quaternion HMMDLPIJNBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6DCBD50", Offset = "0x6DCA550", VA = "0x186DCBD50")]
		public void SetHatAnchorParameters(IOKFCBDBELC EEDMLLFCGLB, AnchorParamsRestrictions NDLMGGKMKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3E60", Offset = "0x6DC2660", VA = "0x186DC3E60")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere OBIOCBKCPLD, Transform GMBEMBLMHFM, IOKFCBDBELC EEDMLLFCGLB, AnchorParamsRestrictions NCNFDAKMKEM, [Out] Vector3 BIIIOAKOBBK, [Out] Quaternion HAODNGMNEJG, [Out] IOKFCBDBELC JDABNIIPKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6DCABF0", Offset = "0x6DC93F0", VA = "0x186DCABF0")]
		public void ResetHatAnchor(Vector2 CGDDAEPIOGL, Vector3 CDDPMBDFJJC, Vector3 ICEMFMMEPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x9DB310", Offset = "0x9D9B10", VA = "0x1809DB310")]
		public PDGDLGHNGDC GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2410", Offset = "0x6DC0C10", VA = "0x186DC2410")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2550", Offset = "0x6DC0D50", VA = "0x186DC2550")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2380", Offset = "0x6DC0B80", VA = "0x186DC2380")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD580", Offset = "0x6DCBD80", VA = "0x186DCD580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6DC21C0", Offset = "0x6DC09C0", VA = "0x186DC21C0")]
		protected void AODIBDCIEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD340", Offset = "0x6DCBB40", VA = "0x186DCD340")]
		public void SetWaitForUgcTextureLoads(bool ANEBCMLDCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD260", Offset = "0x6DCBA60", VA = "0x186DCD260")]
		public void SetUgcTextureParameters(AHGGHFEHEPP OFGFBCNFINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6DCDE70", Offset = "0x6DCC670", VA = "0x186DCDE70")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9D80", Offset = "0x6DC8580", VA = "0x186DC9D80")]
		[CompilerGenerated]
		private void OEGHCLDLDPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6DC55C0", Offset = "0x6DC3DC0", VA = "0x186DC55C0")]
		[CompilerGenerated]
		private void EECINNHMDEJ(FJAICODAPEI KMDNLDCLAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6990", Offset = "0x6DC5190", VA = "0x186DC6990")]
		[CompilerGenerated]
		private void JKFODPKOAFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9E10", Offset = "0x6DC8610", VA = "0x186DC9E10")]
		[CompilerGenerated]
		private void OFNFDJEHIFD(FJAICODAPEI KMDNLDCLAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3B50", Offset = "0x6DC2350", VA = "0x186DC3B50")]
		[CompilerGenerated]
		private void CJKELHFOCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6DC62D0", Offset = "0x6DC4AD0", VA = "0x186DC62D0")]
		[CompilerGenerated]
		private void IBNABJMCGEO(FJAICODAPEI KMDNLDCLAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA530", Offset = "0x6DC8D30", VA = "0x186DCA530")]
		[CompilerGenerated]
		private void PFNLGNDCIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7620", Offset = "0x6DC5E20", VA = "0x186DC7620")]
		[CompilerGenerated]
		private void LKCOLOBKDGP(FJAICODAPEI KMDNLDCLAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5310", Offset = "0x6DC3B10", VA = "0x186DC5310")]
		[CompilerGenerated]
		private void DOJLNLDJCOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5570", Offset = "0x6DC3D70", VA = "0x186DC5570")]
		[CompilerGenerated]
		private void EAKHLOMCEFM(FJAICODAPEI KMDNLDCLAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6DC95C0", Offset = "0x6DC7DC0", VA = "0x186DC95C0")]
		[CompilerGenerated]
		private void NJPFLLCJPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9D60", Offset = "0x6DC8560", VA = "0x186DC9D60")]
		[CompilerGenerated]
		private void OBLCAPIENCN(FJAICODAPEI KMDNLDCLAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6DC53A0", Offset = "0x6DC3BA0", VA = "0x186DC53A0")]
		[CompilerGenerated]
		internal static bool DPNCBKMPEHK(Transform OLDMDDKKFFI, IEnumerable<SkinnedMeshRenderer> KFLFHDFBHPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5DB0", Offset = "0x6DC45B0", VA = "0x186DC5DB0")]
		[CompilerGenerated]
		private void GAHJFGJMMAA(FJAICODAPEI KMDNLDCLAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2C70", Offset = "0x6DC1470", VA = "0x186DC2C70")]
		[CompilerGenerated]
		private void BALEPCKPOEF(FJAICODAPEI KMDNLDCLAAE)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, DLKJMFLDODE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct EELEIAIIKHD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public KCALCFCCDIJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x6DD19D0", Offset = "0x6DD01D0", VA = "0x186DD19D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x6DD1C60", Offset = "0x6DD0460", VA = "0x186DD1C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct LBIGDFPLNEG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public HBPDIAMDKLD avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x6DD79F0", Offset = "0x6DD61F0", VA = "0x186DD79F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x6DD7BC0", Offset = "0x6DD63C0", VA = "0x186DD7BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct MMPFDAOGFGJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public HBPDIAMDKLD avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x6DD83F0", Offset = "0x6DD6BF0", VA = "0x186DD83F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x6DD8590", Offset = "0x6DD6D90", VA = "0x186DD8590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct MAGBEDFCCOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public KCALCFCCDIJ avatarData;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct KOHLKLPDELL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public KCALCFCCDIJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x6DD72A0", Offset = "0x6DD5AA0", VA = "0x186DD72A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x6DD7990", Offset = "0x6DD6190", VA = "0x186DD7990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct KBEGGIIFFDJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public HBPDIAMDKLD avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			private TaskAwaiter<DBELEKGLJEP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6E20", Offset = "0x6DD5620", VA = "0x186DD6E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x6DD7240", Offset = "0x6DD5A40", VA = "0x186DD7240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct CKOLAAHKGDJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public HBPDIAMDKLD avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x6DD1480", Offset = "0x6DCFC80", VA = "0x186DD1480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x6DD1940", Offset = "0x6DD0140", VA = "0x186DD1940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		protected const float PEKFDJHAHDG = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		protected const int EPKMLLMJJHC = 5;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		protected static readonly Dictionary<JLDEDNBPGBN.LPLGBBLCAGO, int> BGMMALOELLO;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> IAMNJOCCHPF;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		protected static readonly int BELHFAGDAFP;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		protected static readonly int PIGCDJJPAPJ;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		protected static readonly int OPJICLNEGCA;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		protected static readonly int FEIBLOEHJNB;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		protected static readonly int KKNLIEAFEMD;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		protected static readonly int AOJPEOFNAEC;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		protected static readonly int IGADJONBMKB;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		protected static readonly int OBNLJKPLLBO;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		protected static Vector2 BLJPJJDEECN;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		protected static Vector2 GMGHKIGJCBM;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		protected static Vector2 JFOOFCHFMMI;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		protected static Vector2 FLDMOOIFDMF;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		protected static Vector2 KOLCJLDCMOB;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected static Vector2 HFAIKKKFAPM;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected static Vector2 JFHEOBHNDGO;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected static Vector2 JMLOEMEOKNL;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected static Vector2 IAKJBNPOBFH;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static Vector2 JEBJABFKHNN;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static Vector2 GPFALDIOEJP;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static Vector2 EENJMPBAFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		[SerializeField]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private HBPDIAMDKLD OCMODFBJFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private FaceStyleSet AEEJKOIALMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected const int DCDDDFEGKFM = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected int LKFALAOHOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected int GLPIDJNLLND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected int FLFNMJMJOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected int ONMFOPLCBEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected Vector2 GHADKGAAEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected float DOJAAHJCEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected Vector2 LPLIOCFODCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected float DOIPGKBGAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected Vector2 GINPCPLMKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected float CAKIMCOMGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected Vector2 OJMIODCGOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected float GOLAHCIMHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected List<SelectableFaceOption> MIIIABBKPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected List<SelectableFaceOption> CFIJEKENKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected List<SelectableFaceOption> PPPIPDANIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected List<SelectableFaceOption> FBNBDPICKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected Coroutine KECMDOIPJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected int? IEBOGNJANDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected int MHOEJLBAEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected int GBIFAAODCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected int JDFPOOOJGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected int OGGGMGOOMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected int PMCDCBBJCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected int IMDDIGPNEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected Sprite BOGNCGPPGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected Sprite ADGHGLBNAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected Sprite FGDOJMGAKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected Sprite MDMECKAFHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected bool DHDJLJJLMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected string KIMEALPOFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected string NCLNMCBADAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected string GKNHBHKGMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected string FIIBIPDOGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected AvatarConfiguration JJMFPHKJCJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected DBELEKGLJEP IINCHILCPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private readonly List<Material> CBFNIFHGODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected KFLNLACGMDN OPEHEDNGCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Dictionary<string, int> HHHKEHPJKHB;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public FaceStyleSet GFNKEJOCFHI
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x6DDE370", Offset = "0x6DDCB70", VA = "0x186DDE370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public bool DALNJCHFIBP
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x1042410", Offset = "0x1040C10", VA = "0x181042410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x103DA30", Offset = "0x103C230", VA = "0x18103DA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		protected virtual bool EIOPADHFAAP
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		protected virtual bool LDMKJLGEJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		protected int MBEENJJCPIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x6DD9490", Offset = "0x6DD7C90", VA = "0x186DD9490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public Renderer EOGDNAPJMMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public bool EKOLMLCJLDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x1042590", Offset = "0x1040D90", VA = "0x181042590")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x1042880", Offset = "0x1041080", VA = "0x181042880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Renderer[] DLNHCHMOACE
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool FOHDHIBEDCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x6DDE3B0", Offset = "0x6DDCBB0", VA = "0x186DDE3B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x6DDE570", Offset = "0x6DDCD70", VA = "0x186DDE570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		protected int GFBNJDJBPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x6DDAD10", Offset = "0x6DD9510", VA = "0x186DDAD10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		protected int FFKLKAJPGAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x6DD87A0", Offset = "0x6DD6FA0", VA = "0x186DD87A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public float FLIGOFLIIJK
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x6DDE390", Offset = "0x6DDCB90", VA = "0x186DDE390")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x6DDE550", Offset = "0x6DDCD50", VA = "0x186DDE550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public FGBCLENDEKC ECPAMDKEEAL
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x9DB610", Offset = "0x9D9E10", VA = "0x1809DB610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0xF682E0", Offset = "0xF66AE0", VA = "0x180F682E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public DBELEKGLJEP FLLHDPBDLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x9DB650", Offset = "0x9D9E50", VA = "0x1809DB650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x6DDE4D0", Offset = "0x6DDCCD0", VA = "0x186DDE4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public NoseFaceOption CDHKDKOJDFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x9DB640", Offset = "0x9D9E40", VA = "0x1809DB640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xF68380", Offset = "0xF66B80", VA = "0x180F68380")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected KFLNLACGMDN ECPCAEJGMHC
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x6DD8F80", Offset = "0x6DD7780", VA = "0x186DD8F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action HOPFEJBBFGL
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x6DDE2C0", Offset = "0x6DDCAC0", VA = "0x186DDE2C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x6DDE420", Offset = "0x6DDCC20", VA = "0x186DDE420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6DDA4D0", Offset = "0x6DD8CD0", VA = "0x186DDA4D0")]
		public void LocalPlayEmote(JLDEDNBPGBN.LPLGBBLCAGO HHFIOCBKPLO, float GEFOOALKJOG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9AA0", Offset = "0x6DD82A0", VA = "0x186DD9AA0")]
		public bool IsEmotePlaying(JLDEDNBPGBN.LPLGBBLCAGO HHFIOCBKPLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6DDC320", Offset = "0x6DDAB20", VA = "0x186DDC320")]
		public void SetIdleHappy(bool EDACDDBJLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6DDAD70", Offset = "0x6DD9570", VA = "0x186DDAD70")]
		protected void NBNPLOGADID(bool BLAEOBJGLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6DDADF0", Offset = "0x6DD95F0", VA = "0x186DDADF0")]
		protected void NNKIIDPJFGA(bool GDONDCLIKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6DDB7A0", Offset = "0x6DD9FA0", VA = "0x186DDB7A0")]
		protected void OKKAFLCNABO(AEIOBEGHMKA ALHMBEPBCGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8E30", Offset = "0x6DD7630", VA = "0x186DD8E30")]
		protected void FCFJKGNKHAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6DDBB50", Offset = "0x6DDA350", VA = "0x186DDBB50")]
		public void PlayExpression(int FOBCBHOOCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8D70", Offset = "0x6DD7570", VA = "0x186DD8D70")]
		protected void DHEHLBGOLHJ(bool DAPMBGGEEPF, bool PMHDPFDOIHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9360", Offset = "0x6DD7B60", VA = "0x186DD9360")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType ILPFELNDDBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6DD95C0", Offset = "0x6DD7DC0", VA = "0x186DD95C0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration JJMFPHKJCJN, HBPDIAMDKLD OAFFOKJEIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x6DDC100", Offset = "0x6DDA900", VA = "0x186DDC100")]
		[AsyncStateMachine(typeof(EELEIAIIKHD))]
		public Task SetFaceSettings(KCALCFCCDIJ BKGPNGLOPKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6DDC1F0", Offset = "0x6DDA9F0", VA = "0x186DDC1F0")]
		[AsyncStateMachine(typeof(LBIGDFPLNEG))]
		public Task SetFaceSettings(int PBFANGAFLME, int EHOBPMNOIFE, int HFLJIFEJGBC, int MEGDGFLDPIO, HBPDIAMDKLD OAFFOKJEIOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x6DDC3A0", Offset = "0x6DDABA0", VA = "0x186DDC3A0")]
		[AsyncStateMachine(typeof(MMPFDAOGFGJ))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType ILPFELNDDBN, int PIJEJHCKJOE, HBPDIAMDKLD OAFFOKJEIOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x6DDA1C0", Offset = "0x6DD89C0", VA = "0x186DDA1C0")]
		protected void LCHCHJGIDCE(FaceFeatureType ILPFELNDDBN, ILOBAEFMBMP FIFMKOOKIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6DDA5D0", Offset = "0x6DD8DD0", VA = "0x186DDA5D0")]
		protected void MHIFHBHANND(FaceFeatureType ILPFELNDDBN, int PIJEJHCKJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9180", Offset = "0x6DD7980", VA = "0x186DD9180")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD93A0", Offset = "0x6DD7BA0", VA = "0x186DD93A0")]
		[AsyncStateMachine(typeof(KOHLKLPDELL))]
		protected Task IAFPDDPPDIJ(KCALCFCCDIJ BKGPNGLOPKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6DDA330", Offset = "0x6DD8B30", VA = "0x186DDA330")]
		protected static void LIGNPBEFECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9BC0", Offset = "0x6DD83C0", VA = "0x186DD9BC0")]
		private void JBGMLCAJFKE(bool EOBGIPFLHOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9E50", Offset = "0x6DD8650", VA = "0x186DD9E50")]
		protected void JLNFNFEKOKJ(FaceFeatureType ILPFELNDDBN, Vector2 PJKGBAIBAOB, HBPDIAMDKLD OAFFOKJEIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6DDBB70", Offset = "0x6DDA370", VA = "0x186DDBB70")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType ILPFELNDDBN, Vector2 JDJHFNEPAJL, HBPDIAMDKLD OAFFOKJEIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9000", Offset = "0x6DD7800", VA = "0x186DD9000")]
		protected void GPCOEFKDANO(FaceFeatureType ILPFELNDDBN, float FGDJALHEPCH, HBPDIAMDKLD OAFFOKJEIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6DDBEE0", Offset = "0x6DDA6E0", VA = "0x186DDBEE0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType ILPFELNDDBN, float KHALBHCCDEC, HBPDIAMDKLD OAFFOKJEIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8800", Offset = "0x6DD7000", VA = "0x186DD8800")]
		[AsyncStateMachine(typeof(KBEGGIIFFDJ))]
		protected Task BPNKGOFMGBN(HBPDIAMDKLD OAFFOKJEIOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9890", Offset = "0x6DD8090", VA = "0x186DD9890")]
		public void InitializeFaceFeatureStyleSet(HBPDIAMDKLD OAFFOKJEIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8EA0", Offset = "0x6DD76A0", VA = "0x186DD8EA0")]
		protected bool FDPOKNCODHA(string PDFHOCFAEGN, [Out] int ECDOOAABOPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8660", Offset = "0x6DD6E60", VA = "0x186DD8660")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x109E970", Offset = "0x109D170", VA = "0x18109E970", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x6DDB810", Offset = "0x6DDA010", VA = "0x186DDB810")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x6DDD370", Offset = "0x6DDBB70", VA = "0x186DDD370")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x6DD88E0", Offset = "0x6DD70E0", VA = "0x186DD88E0")]
		[AsyncStateMachine(typeof(CKOLAAHKGDJ))]
		public Task BuildFaceStyleAsyncIfChanged(HBPDIAMDKLD OAFFOKJEIOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6DDCCA0", Offset = "0x6DDB4A0", VA = "0x186DDCCA0")]
		public void UpdateFaceDisplays(bool HCDCDKIEPJG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6DDAF50", Offset = "0x6DD9750", VA = "0x186DDAF50")]
		protected bool OJFPEPLDJLL(bool HCDCDKIEPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6DDC9C0", Offset = "0x6DDB1C0", VA = "0x186DDC9C0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6DDC4B0", Offset = "0x6DDACB0", VA = "0x186DDC4B0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6DDCEB0", Offset = "0x6DDB6B0", VA = "0x186DDCEB0")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6DDD0A0", Offset = "0x6DDB8A0", VA = "0x186DDD0A0")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8C80", Offset = "0x6DD7480", VA = "0x186DD8C80")]
		protected void DABENCIDLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6DD89D0", Offset = "0x6DD71D0", VA = "0x186DD89D0")]
		private void CGBHMAAHMNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE060", Offset = "0x6DDC860", VA = "0x186DDE060")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8E2910", Offset = "0x8E1110", VA = "0x1808E2910", Slot = "4")]
		private bool KPBLGHLFFCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6DDBA20", Offset = "0x6DDA220", VA = "0x186DDBA20")]
		[CompilerGenerated]
		internal static NNFIHCFOBOK PFBLKKPNHAI(FaceFeatureType ILPFELNDDBN, MAGBEDFCCOP P_1)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LBGKBPJDGKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public string AEHPFKGBHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public int JPPMHDHPBLI;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[SelectionBase]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public HBPDIAMDKLD avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AAOHFBHHFPJ useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public IOKFCBDBELC hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public PDGDLGHNGDC HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public EAIGMANLNFK.LFNICJCICHD baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		[SerializeField]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private BCHKMJBMDFJ ACIOJEOLHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		[SerializeField]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private AnimatorOverrideController CKLLBEIFKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> OALNALEBLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public readonly LBGKBPJDGKN[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public readonly (string, ODEBCAINGAD)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		protected bool KKMIPFCDMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		protected Guid AFEIHEAPPOA;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		protected static Guid JMNLGBGGDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private JHNODDJNGEL PDGLKHGOAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private FGBCLENDEKC DLLKENEPOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private BKBJJNPBHHC DHEKPGMBODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private BKBJJNPBHHC KECGAGFEGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private AdditionalHatData MAANHKLJJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private readonly Dictionary<GameObject, BGKNDGLJPPE> GOALNLALGMC;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public static Func<LHEFGIGDDND> PGLBLFFOCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x6DE2760", Offset = "0x6DE0F60", VA = "0x186DE2760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x6DE2DC0", Offset = "0x6DE15C0", VA = "0x186DE2DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool LBEIGEBCIJK
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x6DE28C0", Offset = "0x6DE10C0", VA = "0x186DE28C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool JPKKGILEGMA
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x6DE27B0", Offset = "0x6DE0FB0", VA = "0x186DE27B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public PlayerAvatarDisplayBase KBNKHCEKIGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x976780", Offset = "0x974F80", VA = "0x180976780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected static Guid PBAFCNFINJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x6DE0840", Offset = "0x6DDF040", VA = "0x186DE0840")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public (GameObject, AEIOBEGHMKA)[] AOILKKGOCIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x6DE29D0", Offset = "0x6DE11D0", VA = "0x186DE29D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6DDF7A0", Offset = "0x6DDDFA0", VA = "0x186DDF7A0")]
		private IEnumerable<GameObject> IONKEMEEJOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1160", Offset = "0x6DDF960", VA = "0x186DE1160")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6DE0C30", Offset = "0x6DDF430", VA = "0x186DE0C30")]
		private void OHGHIAKMNKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xE029B0", Offset = "0xE011B0", VA = "0x180E029B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6DDFC10", Offset = "0x6DDE410", VA = "0x186DDFC10")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1170", Offset = "0x6DDF970", VA = "0x186DE1170")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6DE0F60", Offset = "0x6DDF760", VA = "0x186DE0F60")]
		public void ShowPose(AnimationClip CLOPIJFLBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1130", Offset = "0x6DDF930", VA = "0x186DE1130")]
		public void ShowPose(string PNNEFBDCDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6DE0EE0", Offset = "0x6DDF6E0", VA = "0x186DE0EE0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6DE0D10", Offset = "0x6DDF510", VA = "0x186DE0D10")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE15D0", Offset = "0x6DDFDD0", VA = "0x186DE15D0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE14D0", Offset = "0x6DDFCD0", VA = "0x186DE14D0")]
		public void UpdateFaceAndBodyShapes(bool KHCLPHIANIF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1830", Offset = "0x6DE0030", VA = "0x186DE1830")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE0930", Offset = "0x6DDF130", VA = "0x186DE0930", Slot = "4")]
		protected virtual void MLNJGALHKNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6DDF520", Offset = "0x6DDDD20", VA = "0x186DDF520", Slot = "5")]
		protected virtual void EEGFMKCHAOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE880", Offset = "0x6DDD080", VA = "0x186DDE880")]
		public void ApplyHatData(AdditionalHatData JHBBGGCCPMK, bool BDPHKOBGGNL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE6C0", Offset = "0x6DDCEC0", VA = "0x186DDE6C0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x6DDEBE0", Offset = "0x6DDD3E0", VA = "0x186DDEBE0")]
		public void ApplyHatUVOverride(Vector2 HOEADHGMEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x6DDEB00", Offset = "0x6DDD300", VA = "0x186DDEB00")]
		public void ApplyHatPositionAdjustment(Vector3 NNOKKHEMOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x6DDEB70", Offset = "0x6DDD370", VA = "0x186DDEB70")]
		public void ApplyHatRotationAdjustment(Vector3 CAPDKMBHGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x6DDEC50", Offset = "0x6DDD450", VA = "0x186DDEC50")]
		public BMDNNHFLKKG BuildAvatarItemSelection(GameObject AMFFPLIEHAH, HBPDIAMDKLD PABCJGJOBAA, AEIOBEGHMKA OBBFLJMOIGC)
		{
			return default(BMDNNHFLKKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6DDECF0", Offset = "0x6DDD4F0", VA = "0x186DDECF0")]
		public void BuildAvatar(bool KHCLPHIANIF = false, bool BDPHKOBGGNL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE800", Offset = "0x6DDD000", VA = "0x186DDE800")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1680", Offset = "0x6DDFE80", VA = "0x186DE1680")]
		public void UpdateHatAnchor(bool BDPHKOBGGNL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6DE0310", Offset = "0x6DDEB10", VA = "0x186DE0310")]
		private void JKKPDIKFFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		private void LDFECAKOAJO(BGKNDGLJPPE CGKGEPKOEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		private void CKNJDLGDIBC(BGKNDGLJPPE CGKGEPKOEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6DDF790", Offset = "0x6DDDF90", VA = "0x186DDF790")]
		private void FDMBHAGOMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE18C0", Offset = "0x6DE00C0", VA = "0x186DE18C0")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x6DDF470", Offset = "0x6DDDC70", VA = "0x186DDF470")]
		[CompilerGenerated]
		private BMDNNHFLKKG DPKJGAIIIKN((GameObject, AEIOBEGHMKA) KKBBEENHGJN)
		{
			return default(BMDNNHFLKKG);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		[SerializeField]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct BMDNNHFLKKG
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class GOONBIKMEGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GOONBIKMEGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x6DD5850", Offset = "0x6DD4050", VA = "0x186DD5850")]
		internal bool JBNCLLEBABN(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private BGKNDGLJPPE GOFPNBBBBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private AEIOBEGHMKA CMNIOHKNGKG;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public BGKNDGLJPPE DOAGALGGMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public AEIOBEGHMKA NHCDKHMODOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x23206E0", Offset = "0x231EEE0", VA = "0x1823206E0")]
		get
		{
			return default(AEIOBEGHMKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public string MLLPMCOGDIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x6DD0DE0", Offset = "0x6DCF5E0", VA = "0x186DD0DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool DEAPCLGCIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x6DD1130", Offset = "0x6DCF930", VA = "0x186DD1130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool JAACCJCLDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x6DD1180", Offset = "0x6DCF980", VA = "0x186DD1180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x9961A0", Offset = "0x9949A0", VA = "0x1809961A0")]
	public BMDNNHFLKKG(BGKNDGLJPPE CGKGEPKOEPB, AEIOBEGHMKA ALHMBEPBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0B30", Offset = "0x6DCF330", VA = "0x186DD0B30")]
	public bool BLFCKACPDDP(OutfitType EHBDBDKIKPC, AEIOBEGHMKA IKGAKCOIKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0ED0", Offset = "0x6DCF6D0", VA = "0x186DD0ED0")]
	public bool ILLEPIOBIOM(OutfitType EHBDBDKIKPC, AEIOBEGHMKA IKGAKCOIKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0BF0", Offset = "0x6DCF3F0", VA = "0x186DD0BF0")]
	public bool DHDKIHCPJFC(BMDNNHFLKKG CKBEPJPKHPA)
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
