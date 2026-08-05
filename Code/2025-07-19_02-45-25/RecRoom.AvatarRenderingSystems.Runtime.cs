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
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FA22D0", Offset = "0x7FA12D0", VA = "0x187FA22D0", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
			[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7FA25C0", Offset = "0x7FA15C0", VA = "0x187FA25C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2550", Offset = "0x7FA1550", VA = "0x187FA2550", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2580", Offset = "0x7FA1580", VA = "0x187FA2580")]
		public RecNetCDNAssetReference(RecNetCDNKey DAKIIEIEKNI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum OMFBNCAFBDG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			Bundle,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Prefab,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			MaterialMap
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string BundleFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8D4F0", VA = "0x180A8E4F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA8E310", Offset = "0xA8D310", VA = "0x180A8E310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OMFBNCAFBDG PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF00130", Offset = "0xEFF130", VA = "0x180F00130")]
			[CompilerGenerated]
			get
			{
				return default(OMFBNCAFBDG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1544370", Offset = "0x1543370", VA = "0x181544370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7FA26D0", Offset = "0x7FA16D0", VA = "0x187FA26D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2600", Offset = "0x7FA1600", VA = "0x187FA2600")]
		public static RecNetCDNKey CEBBIMHEIBE(string JKIEOHLHGEI, OMFBNCAFBDG CNBKMOLKJBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2680", Offset = "0x7FA1680", VA = "0x187FA2680")]
		public void GGADPJKMCGJ(string BACOAHBLONI, string EGEGACCNNEK, bool JCNIFNCOOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NMAHPGPJLGN]
public class GCLJFDBHAML : NAPPMNHDAFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> AMJCCLEGGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> CFKCFHAPNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> EOFNKLFAFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> BGGHNJCNPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> LEIKPALMMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> FLKGDDBJHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> ENCJGADMLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator MFPDCFBHMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected ANMDKMAFHBE PJMCAOIMKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte LGIOLLPNLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> ILEBJLEDEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> KFHNMBHIKHO;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E510", Offset = "0x7F9D510", VA = "0x187F9E510", Slot = "4")]
	public void MDBBEBODOOP(Mesh BFBFJIKLAEJ, Matrix4x4 PCPIEJKHNBN, byte[] BJBKBHNDJOJ, bool JGHNCEJOFAF = false, GJIEMCFIFPN.OHDBKEAJCKP AGAHKNNMAOK = (GJIEMCFIFPN.OHDBKEAJCKP)0L, int HCKCIPBAEKH = -1, bool NIOONJBKGCE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E270", Offset = "0x7F9D270", VA = "0x187F9E270", Slot = "5")]
	public void KFKLDNALDEN(Allocator FKPBEKMFPLB, ANMDKMAFHBE FFJMAKAAEEE, byte KFAPCBDOICE, [Optional] IList<int> IADDCNLIKCL, [Optional] IList<int> BGEOABNEBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E2B0", Offset = "0x7F9D2B0", VA = "0x187F9E2B0")]
	private static void LIJLDEIHPEP(Mesh BFBFJIKLAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E8D0", Offset = "0x7F9D8D0", VA = "0x187F9E8D0")]
	public GCLJFDBHAML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NMAHPGPJLGN]
public struct HJLHKPINFJB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public ICGKBNHDHFD PNFGLLNGNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int GJONCNMAFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public AAJHOGHLBBK FPOHODDDGDH;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EE70", Offset = "0x7F9DE70", VA = "0x187F9EE70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NMAHPGPJLGN]
[NativeContainer]
public struct AAJHOGHLBBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HCLEOOBGMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 OCGKJEBFKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 PNJPAIKKPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 DBOJEEOCMGD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct HLCGNPMKBLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float KNJFKAFHHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float JPJPPKNDNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float EEKDMOECLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float PEGOKMDAIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte KMNCHHHIFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte BIHLCOMBOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte PBPNPKEEILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte CBIALPKPBOH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MLCODFCFGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half KNJFKAFHHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half JPJPPKNDNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half EEKDMOECLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half PEGOKMDAIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte KMNCHHHIFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte BIHLCOMBOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte PBPNPKEEILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte CBIALPKPBOH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct OFJFACGNKJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 AHIICABHHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 DGBCLJKCENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 BMPANBAJGEL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NAGMCGPMGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half4 AHIICABHHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 DGBCLJKCENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 GPJADNOFNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half4 BMPANBAJGEL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct JALMBIALPAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 AHIICABHHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 DGBCLJKCENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half2 GPJADNOFNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 CNBFDAOLDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half4 BMPANBAJGEL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CKJBAKOHCBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half4 AHIICABHHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 DGBCLJKCENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public half2 GPJADNOFNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public half2 CNBFDAOLDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public half2 KPGKJOJDBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public half4 BMPANBAJGEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct GLDNFPHEMAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float KNJFKAFHHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float JPJPPKNDNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float EEKDMOECLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float PEGOKMDAIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int KMNCHHHIFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int BIHLCOMBOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int PBPNPKEEILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int CBIALPKPBOH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct GBELEIOAOFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color AHIICABHHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 DGBCLJKCENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4 BMPANBAJGEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct GOEKGMELOEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Color AHIICABHHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 DGBCLJKCENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector2 GPJADNOFNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4 BMPANBAJGEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct IMHCIAGNOPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Color AHIICABHHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 DGBCLJKCENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 GPJADNOFNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Vector2 CNBFDAOLDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Vector4 BMPANBAJGEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct JFGDGGBBKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Color AHIICABHHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Vector2 DGBCLJKCENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector2 GPJADNOFNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Vector2 CNBFDAOLDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Vector2 KPGKJOJDBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Vector4 BMPANBAJGEL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool PHOMJILHEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<HCLEOOBGMIJ> LBGFIMNJGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<OFJFACGNKJF> PJHIDFALJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<NAGMCGPMGFB> INFACGCNNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<JALMBIALPAE> BBLDIACMKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<CKJBAKOHCBG> HNGFPHBBFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<MLCODFCFGHP> GENBDHIHDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<HLCGNPMKBLL> CICFCJBABNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<GBELEIOAOFK> DDMLPPLGKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<GOEKGMELOEI> JAIAPNBDGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<IMHCIAGNOPD> CNJAKMIHONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<JFGDGGBBKHK> MMMNBFILOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<GLDNFPHEMAC> CBJDEIMDBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> PHHLLDFHELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> BCLKMMEEJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> DEBPKFCNBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> ICBNDHNEICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> IBDGBIJKACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> KIKDIOKEIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> LFKECLIGOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> KFPJPOCCHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> OGEALFKCCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool HOIBJIIDEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool ELGBPIJDJIK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BCGDNMIDPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E320", Offset = "0x7F8D320", VA = "0x187F8E320")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E760", Offset = "0x7F8D760", VA = "0x187F8E760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EEBCHDJHDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E2A0", Offset = "0x7F8D2A0", VA = "0x187F8E2A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E2B0", Offset = "0x7F8D2B0", VA = "0x187F8E2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AMJAIGDGHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E120", Offset = "0x7F8D120", VA = "0x187F8E120")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E130", Offset = "0x7F8D130", VA = "0x187F8E130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int AHKIGOHHLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E140", Offset = "0x7F8D140", VA = "0x187F8E140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F8EA50", Offset = "0x7F8DA50", VA = "0x187F8EA50")]
	public AAJHOGHLBBK(int IKEMENMCACL, int PMGHJEHHPEI, int MDAHOMOOMBL, int NODJMFOHHGK, Allocator FKPBEKMFPLB, int JHPINEGDGMP, GFJLJFGJBCH HCEMCFCIMMA, bool HOIBJIIDEBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E9C0", Offset = "0x7F8D9C0", VA = "0x187F8E9C0")]
	public void POPFKBFCHKM(int HLGKMAPOEBE, Vector3 LJALOPCLDCK, Vector3 FPGAPNMDKDK, Vector4 HBPDACJCCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E330", Offset = "0x7F8D330", VA = "0x187F8E330")]
	public void NFBGLEMMBEI(int HLGKMAPOEBE, BoneWeight OLINNPLBLLA, NativeSlice<byte> BJBKBHNDJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C210", Offset = "0x7F8B210", VA = "0x187F8C210")]
	public Color ADMNIDICDPK(int HLGKMAPOEBE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D9C0", Offset = "0x7F8C9C0", VA = "0x187F8D9C0")]
	public void DJGCGCFFJAB(int HLGKMAPOEBE, Color JKODNDABGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E1B0", Offset = "0x7F8D1B0", VA = "0x187F8E1B0")]
	public void JMPAPJAMCMG(int HLGKMAPOEBE, Vector3 GGHGIDAMNEE, Vector3 JFEIPHCCDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C530", Offset = "0x7F8B530", VA = "0x187F8C530")]
	public void BCACBCMPHIO(int HLGKMAPOEBE, half4 CBLFGBNPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E770", Offset = "0x7F8D770", VA = "0x187F8E770")]
	public void OFEAFALIPCP(int HLGKMAPOEBE, Vector3 CBLFGBNPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D5A0", Offset = "0x7F8C5A0", VA = "0x187F8D5A0")]
	public void DDECHIGFCGD(byte HKDKKMNDGBA, int HLGKMAPOEBE, Vector2 CBLFGBNPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D9B0", Offset = "0x7F8C9B0", VA = "0x187F8D9B0")]
	public void DIOKBHILCPL(int HLGKMAPOEBE, int BJJBMMPFMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E2C0", Offset = "0x7F8D2C0", VA = "0x187F8E2C0")]
	public bool LBFKCLOOOHA(int HKDKKMNDGBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E050", Offset = "0x7F8D050", VA = "0x187F8E050")]
	public void GLLLHMACJOD(int BCLKMAEKJFD, int MOAJDMPNBPN, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8DDF0", Offset = "0x7F8CDF0", VA = "0x187F8DDF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C680", Offset = "0x7F8B680", VA = "0x187F8C680")]
	public Mesh CHEHPIGPHEK([Optional] string ANFPEDPKMDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NMAHPGPJLGN]
[NativeContainer]
public struct ICGKBNHDHFD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Mesh.MeshDataArray CFFCGIJODOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> COPMAOPOGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<int> BBEPOJCDMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<BoneWeight> KFPJPOCCHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<Matrix4x4> LBIGMLPGALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<long> BEDEJHJCCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<byte> GIJOEEOJMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<int> FBJIBDJDDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<int> ADKKEAAFAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeArray<sbyte> BEJMFAANMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<byte> IEDIFMPMCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<bool> NIOONJBKGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<int> HCKCIPBAEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool HOIBJIIDEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<int> GGOFBLLIDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool ELGBPIJDJIK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NPELIGPLHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0800", Offset = "0x7F9F800", VA = "0x187FA0800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int OKCAECMBKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0E10", Offset = "0x7F9FE10", VA = "0x187FA0E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PIAPAIMFDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0C40", Offset = "0x7F9FC40", VA = "0x187FA0C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LOJBOMNDGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0830", Offset = "0x7F9F830", VA = "0x187FA0830")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0A90", Offset = "0x7F9FA90", VA = "0x187FA0A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BCGDNMIDPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0E00", Offset = "0x7F9FE00", VA = "0x187FA0E00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0E20", Offset = "0x7F9FE20", VA = "0x187FA0E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int AFAPADGNEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0C20", Offset = "0x7F9FC20", VA = "0x187FA0C20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0810", Offset = "0x7F9F810", VA = "0x187FA0810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ANMDKMAFHBE PDLNJBOBAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0D10", Offset = "0x7F9FD10", VA = "0x187FA0D10")]
		get
		{
			return default(ANMDKMAFHBE);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0DF0", Offset = "0x7F9FDF0", VA = "0x187FA0DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte NLBNNOEEJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0820", Offset = "0x7F9F820", VA = "0x187FA0820")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0C30", Offset = "0x7F9FC30", VA = "0x187FA0C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HAFPKIDMMFA LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0840", Offset = "0x7F9F840", VA = "0x187FA0840")]
		get
		{
			return default(HAFPKIDMMFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0E30", Offset = "0x7F9FE30", VA = "0x187FA0E30")]
	public ICGKBNHDHFD(IList<Mesh> CFGJHBDALBM, IList<Matrix4x4> CBBMPLKLHDD, IList<bool> NIOONJBKGCE, byte KFAPCBDOICE, IList<byte[]> CBKADDOEMMD, IList<long> OIKLKNCCHII, IList<bool> NMEDMLNCKPB, IList<int> HCKCIPBAEKH, IList<int> IADDCNLIKCL, IList<int> KDIOADKCJKP, Allocator FKPBEKMFPLB, ANMDKMAFHBE FFJMAKAAEEE, bool HOIBJIIDEBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0D20", Offset = "0x7F9FD20", VA = "0x187FA0D20")]
	public AAJHOGHLBBK KBEDPKGMDFM(Allocator FKPBEKMFPLB, GFJLJFGJBCH HCEMCFCIMMA)
	{
		return default(AAJHOGHLBBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0AA0", Offset = "0x7F9FAA0", VA = "0x187FA0AA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[NMAHPGPJLGN]
public class HGOFEMNNIOH : GCLJFDBHAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool DPPINBOEINC;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly ProfilerMarker CKIHMGPIDMK;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EBA0", Offset = "0x7F9DBA0", VA = "0x187F9EBA0")]
	public ICGKBNHDHFD IMBFDDJGDJO()
	{
		return default(ICGKBNHDHFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EE60", Offset = "0x7F9DE60", VA = "0x187F9EE60")]
	public HGOFEMNNIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HAFPKIDMMFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Mesh.MeshData ILGEFJJADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeSlice<BoneWeight> KFPJPOCCHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeSlice<byte> HONMPMDHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public int EMMHBMKNBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Matrix4x4 GNHENMLILKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public long AIPKCMFIPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeSlice<byte> BJBKBHNDJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool BGNPCACLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public int ALJHJIENLOL;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AGEDNKOPNGF : DBKAMJMIKIH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class CJPAMDLMACM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AGEDNKOPNGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GKMAAPKKHOG buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Action<KeyValuePair<string, PHNCGCCJBCF<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public CJPAMDLMACM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E0E0", Offset = "0x7F9D0E0", VA = "0x187F9E0E0")]
		internal bool HKAAGMFMHGP(NPGINOMBEOC item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E000", Offset = "0x7F9D000", VA = "0x187F9E000")]
		internal void DKDOGEDFAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E120", Offset = "0x7F9D120", VA = "0x187F9E120")]
		internal void JIMDNJEHGHM(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E000", Offset = "0x7F9D000", VA = "0x187F9E000")]
		internal void DMKANKEHBCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E120", Offset = "0x7F9D120", VA = "0x187F9E120")]
		internal void IEGEELHGGCD(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E140", Offset = "0x7F9D140", VA = "0x187F9E140")]
		internal void KPDGHGCBICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F9DFD0", Offset = "0x7F9CFD0", VA = "0x187F9DFD0")]
		internal void CJJHEPIDEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E170", Offset = "0x7F9D170", VA = "0x187F9E170")]
		internal void OPMNNPJJANF(Dictionary<string, PHNCGCCJBCF<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E020", Offset = "0x7F9D020", VA = "0x187F9E020")]
		internal void FEEIKHEOFOI(KeyValuePair<string, PHNCGCCJBCF<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		internal JCFICNGFDLA IICFAADAGFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OHCKMJLBBMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CJPAMDLMACM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OHCKMJLBBMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2490", Offset = "0x7FA1490", VA = "0x187FA2490")]
		internal DEINJGGBOFP CLNBPIBOCNC(int lod)
		{
			return default(DEINJGGBOFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HEHCJDFFKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public KPIPLFECKNC<Dictionary<string, PHNCGCCJBCF<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HEHCJDFFKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		internal KPIPLFECKNC<Dictionary<string, PHNCGCCJBCF<Texture2D>>> PICPJFLFIJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NICHMAMBANP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<GKMAAPKKHOG> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public NICHMAMBANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2360", Offset = "0x7FA1360", VA = "0x187FA2360")]
		internal void OGFPKLAPMCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class AGKLLEFEFJC : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private CMMCHACHDBH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AGEDNKOPNGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public List<JLDENJGGNMJ> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<GKMAAPKKHOG> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Func<int, DEINJGGBOFP> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public LNMDEHJKKPB materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public AGKLLEFEFJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F9CB00", Offset = "0x7F9BB00", VA = "0x187F9CB00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F9CD80", Offset = "0x7F9BD80", VA = "0x187F9CD80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HGDJPNIGLFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public FKDDAAHCHGD cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HGDJPNIGLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xBA0310", Offset = "0xB9F310", VA = "0x180BA0310")]
		internal void OADPMLMDGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xDF8A20", Offset = "0xDF7A20", VA = "0x180DF8A20")]
		internal void KOKFFPBHEHN(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GNOKGFOEGFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AGEDNKOPNGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public List<(int mat, int part)> avatarItemMaterialPartIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public List<Bounds> avatarPartMeshBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GNOKGFOEGFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BAIMFJMPBNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AAJHOGHLBBK defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public ICGKBNHDHFD defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public GNOKGFOEGFJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public BAIMFJMPBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F9D9D0", Offset = "0x7F9C9D0", VA = "0x187F9D9D0")]
		internal void OMNCDJLEDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F9D960", Offset = "0x7F9C960", VA = "0x187F9D960")]
		internal void FIDHPENKMKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JLCMMBIGDEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public JJJOPBMCKAG legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public JHDMHLNBCNF legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public GNOKGFOEGFJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public JLCMMBIGDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2020", Offset = "0x7FA1020", VA = "0x187FA2020")]
		internal void CNIHLECCDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2260", Offset = "0x7FA1260", VA = "0x187FA2260")]
		internal void OGDLLNHFLHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FNOJHJJOLDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public AGEDNKOPNGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public FNOJHJJOLDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E230", Offset = "0x7F9D230", VA = "0x187F9E230")]
		internal void DBCIIOKEPIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HCLKLDNAGBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IJELGOILOGJ overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HCLKLDNAGBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EB20", Offset = "0x7F9DB20", VA = "0x187F9EB20")]
		internal bool IJJECGDEONI(KeyValuePair<string, NPGINOMBEOC> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LELKCPPPMEI CPGPLNAPGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly LELKCPPPMEI DAKNBDOPCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Dictionary<CCMNMMMAHPL, float> IBMCMAAMIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Dictionary<LHBPJEFHJCK, float> DFLNKBMNMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Dictionary<LFAMFJEGOEL, float> KCJOKKLJBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, IINLGMKLAGC> IAADKKCONJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Dictionary<string, IINLGMKLAGC> ELEDKJGPDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<string, IINLGMKLAGC> LPNLNAHPEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<string, IINLGMKLAGC> EPIINGDNNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private DFKKHJIJFHD BKPMLDMDGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private DFKKHJIJFHD AGGLAMPJGNB;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static float HOFLJPHMAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool? IIDPILFDGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool? JHKLGLBHLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool? IGDPBBMJJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool? NFLMAAMAGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private AvatarConfiguration JKJEBOFDMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Transform LOMDINMLJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private AvatarSkinAssetItem LAOMDFEOOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private AssetReference LPAIPIGOBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private GameObject AEPCOPBBMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private GameObject IOKPGDFCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private SkinnedMeshRenderer NGPNBGMIFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private AvatarSkinnedMeshBoneOrderRemapsData INPJHBPEKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Transform[] JDEJMNIDDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Matrix4x4[] MBOENGHCMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Material DEOOFPEKEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Material NPHHBOKJFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Material HHGBHOAPKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Material ALBFGICFJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Shader CGNNDHPKNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Shader HDKCBMHMAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Animator JBCPCPGIHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Renderer[] AGEHGGKMPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private GJIEMCFIFPN.OHDBKEAJCKP AOOKOFAFOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private AvatarBodyPartShapesManager CCJEFIFAOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private IReadOnlyDictionary<string, Transform> OHNPOGFPGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private AvatarFaceShapeData.FKEBDBOBNEO KJJMLNAPJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AvatarBodyShapeData.OPGLGNIGCPP FECLOPPHDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private DJJBHOIMIGD DNCDEEFCPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool JEIDBGLNHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool GHINFEIIKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Color ABHGGNFNDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Color BOCKAAMJEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Color EHDGFCEHCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color? BHEDDEFBBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Color? DMKAKJEAGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Color? FJBCBJLGPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Color? DONNMFNCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Texture2D OAEAJHCMNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Texture2D KIOIFLOFIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[CanBeNull]
	private NPGINOMBEOC DHBAJNELEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Texture PICEFKCCHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Color BCELENOCBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Dictionary<Renderer, LNMDEHJKKPB> MBIJHLPKAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<Renderer, LNMDEHJKKPB> NPNNAHBGBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Dictionary<string, List<FLABNCCLAIP>> HAKLGNGANBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Dictionary<string, List<FLABNCCLAIP>> BDMCHKJMKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly List<INKKKBPBHOJ> CMBJFPHNJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly List<INKKKBPBHOJ> MIILHDEPLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<INKKKBPBHOJ> ECOIDMHGBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly List<INKKKBPBHOJ> NIGOPNGADHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<FLABNCCLAIP, Material> BINFFHHGBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<FLABNCCLAIP, Material> DGJOKBLMMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private SkinnedMeshRenderer[] JNNNHHMBKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private SkinnedMeshRenderer[] BIGDFDKJEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private SkinnedMeshRenderer[] ACOFKANKJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private SkinnedMeshRenderer[] PAPMHDBIHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Dictionary<string, PHNCGCCJBCF<Texture2D>> PJCIAKFIECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<string, PHNCGCCJBCF<Texture2D>> KKLBLMOFMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private AdditionalHatData JBNIBAMIIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private AdditionalHatData DEALMDMPEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private HairData MJAAJICACBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private HairData OCHNKKBNLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private KCJIIMMAEMJ KGLHAJKDBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool? OMCOCPJCLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PositionAndRotation IPBFLGCJDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private Transform LNCICDGPHCM;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Material DIOJLNCEAJC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Material KAPFHGLAKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private Dictionary<string, NPGINOMBEOC> CHEJNFHAJLN;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int OBIECIGGMMC;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int KPBAHJHAJGK;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int KEEELMNCJEE;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int BNMEDOINIGO;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int GALCDPLJELA;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int KDPPOMNOEAJ;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int LDALCCHMIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool EMDMMNPPHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private List<Action> KDPJMIPFNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private FABAOFAOADM JKHNDMLNIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private SkinnedMeshRenderer[] IHJANBIKLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private int AHLKAANNGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool CCMONHBBNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int DNFDHBCGLNE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LELKCPPPMEI HAPKBEDIKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LELKCPPPMEI EGAONMBDFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private MEPJMFNAPAB BCCDLAFBNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F91F90", Offset = "0x7F90F90", VA = "0x187F91F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool DMLMAHCGDPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7F979F0", Offset = "0x7F969F0", VA = "0x187F979F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool ABLMILCFAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F91EB0", Offset = "0x7F90EB0", VA = "0x187F91EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool FMDLCOEIDAE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F90380", Offset = "0x7F8F380", VA = "0x187F90380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool PGMFKPIDGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F91DD0", Offset = "0x7F90DD0", VA = "0x187F91DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration JCEKOCBIJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA63200", Offset = "0xA62200", VA = "0x180A63200", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IJGCGHDINIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7F9BD70", Offset = "0x7F9AD70", VA = "0x187F9BD70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F90610", Offset = "0x7F8F610", VA = "0x187F90610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material PPAAOAJOLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F94F80", Offset = "0x7F93F80", VA = "0x187F94F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material EGJEIAGCOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F98780", Offset = "0x7F97780", VA = "0x187F98780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool IDLKAAIJLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public NOKGHIEMFJK MGCKOPBBIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x132C950", Offset = "0x132B950", VA = "0x18132C950", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(NOKGHIEMFJK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x132D3D0", Offset = "0x132C3D0", VA = "0x18132D3D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material IOOEONAOOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB12240", Offset = "0xB11240", VA = "0x180B12240", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] OCFFLOOEKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1B44250", Offset = "0x1B43250", VA = "0x181B44250", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] MFAGHLHCONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAD8620", Offset = "0xAD7620", VA = "0x180AD8620", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CHEJCLCHDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F9BB60", Offset = "0x7F9AB60", VA = "0x187F9BB60", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public GJIEMCFIFPN.OHDBKEAJCKP JJGMCDJJLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAE6140", Offset = "0xAE5140", VA = "0x180AE6140", Slot = "20")]
		get
		{
			return default(GJIEMCFIFPN.OHDBKEAJCKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int DNKHBJNJMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F92330", Offset = "0x7F91330", VA = "0x187F92330")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7F905C0", Offset = "0x7F8F5C0", VA = "0x187F905C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool HGGOHFHAJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B6D0", Offset = "0x7F9A6D0", VA = "0x187F9B6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool PLHLPBEMAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F91DA0", Offset = "0x7F90DA0", VA = "0x187F91DA0", Slot = "15")]
	public GKMAAPKKHOG DNDHFAOMPCC(CLKPANLDEFD KNKGLELFCIJ, bool AKOCNFAHJLB, int[] PANEDKGJPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F97630", Offset = "0x7F96630", VA = "0x187F97630", Slot = "14")]
	public GKMAAPKKHOG JGAHMGNKIBF(CLKPANLDEFD KNKGLELFCIJ, bool AKOCNFAHJLB, int[] PANEDKGJPLB, Func<Dictionary<string, NPGINOMBEOC>, (GKMAAPKKHOG, KPIPLFECKNC<Dictionary<string, PHNCGCCJBCF<Texture2D>>>)> KOFDKIGBPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F959D0", Offset = "0x7F949D0", VA = "0x187F959D0")]
	public GKMAAPKKHOG IKPEIJDPNKN(CLKPANLDEFD KNKGLELFCIJ, bool AKOCNFAHJLB, int[] PANEDKGJPLB, bool EFLINDMDGJM, DFKKHJIJFHD MPFAJNOOOEO, [Optional] Func<Dictionary<string, NPGINOMBEOC>, (GKMAAPKKHOG, KPIPLFECKNC<Dictionary<string, PHNCGCCJBCF<Texture2D>>>)> KOFDKIGBPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F95120", Offset = "0x7F94120", VA = "0x187F95120")]
	private bool GONODEBIKMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F929B0", Offset = "0x7F919B0", VA = "0x187F929B0")]
	private GKMAAPKKHOG FJLGBLPNMJI(bool AKOCNFAHJLB, List<JLDENJGGNMJ> JLOLFNPLNEG, int[] PANEDKGJPLB, Func<int, DEINJGGBOFP> ADJPDIJLHMN, bool EFLINDMDGJM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A060", Offset = "0x7F99060", VA = "0x187F9A060")]
	[IteratorStateMachine(typeof(AGKLLEFEFJC))]
	private IEnumerator<CMMCHACHDBH> NMIHCCJOEHE(bool AKOCNFAHJLB, List<JLDENJGGNMJ> JLOLFNPLNEG, int[] PANEDKGJPLB, Func<int, DEINJGGBOFP> ADJPDIJLHMN, LNMDEHJKKPB FMOALAMGLEC, Material NPGBFHGOJBE, List<GKMAAPKKHOG> IPJBBIOOFIL, bool FPBPLIALFGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F94250", Offset = "0x7F93250", VA = "0x187F94250")]
	private void FPGNGJOAPPH(List<JLDENJGGNMJ> JLOLFNPLNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A180", Offset = "0x7F99180", VA = "0x187F9A180")]
	private GKMAAPKKHOG NMKABPIDLLD(List<JLDENJGGNMJ> JLOLFNPLNEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F92F90", Offset = "0x7F91F90", VA = "0x187F92F90")]
	private HHGNPNNJJPG FLOLCIJKBNO(List<JLDENJGGNMJ> JLOLFNPLNEG, int AOHLAGDAFAF, bool AKOCNFAHJLB, DEINJGGBOFP CHOCDIANLNI, bool EEOEOFKGBIE, LNMDEHJKKPB FMOALAMGLEC, Material NPGBFHGOJBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BEF0", Offset = "0x7F9AEF0", VA = "0x187F9BEF0", Slot = "27")]
	public void POAEMGPPDEB(CCMNMMMAHPL JLIPNKCEGAN, float IOALKPFEKEK, bool ODAJBGLFGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F92650", Offset = "0x7F91650", VA = "0x187F92650", Slot = "29")]
	public void FCDHFIFLMIM(LHBPJEFHJCK OGMJGGKPKEC, float IOALKPFEKEK, bool CEKHJKAOLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F97800", Offset = "0x7F96800", VA = "0x187F97800", Slot = "30")]
	public void JLDFHOJHDCB(LFAMFJEGOEL JENMMLGGAKB, float IOALKPFEKEK, bool KLJHFNDMANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F97AD0", Offset = "0x7F96AD0", VA = "0x187F97AD0", Slot = "28")]
	public void JPBEEMFBGAK(bool LEHJEJIEIBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B670", Offset = "0x7F9A670", VA = "0x187F9B670", Slot = "31")]
	public void OIJHOBFMKNK(bool LEHJEJIEIBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F927F0", Offset = "0x7F917F0", VA = "0x187F927F0", Slot = "32")]
	public void FFPDNALAKMF(bool LEHJEJIEIBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F99B70", Offset = "0x7F98B70", VA = "0x187F99B70")]
	private void NADLJCPLDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F98590", Offset = "0x7F97590", VA = "0x187F98590")]
	private void LBDNBJBMFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B5F0", Offset = "0x7F9A5F0", VA = "0x187F9B5F0")]
	private void OHCHKFMBKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F95640", Offset = "0x7F94640", VA = "0x187F95640", Slot = "25")]
	public void HHBNJBIGCJP(AvatarFaceShape OIDFLPFILCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F92730", Offset = "0x7F91730", VA = "0x187F92730", Slot = "26")]
	public void FCPNPDIHFBG(AvatarBodyShape MDPNKIKJGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xBC53F0", Offset = "0xBC43F0", VA = "0x180BC53F0", Slot = "33")]
	public void BDIKNHLFLCP(DJJBHOIMIGD GALKAIFGIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FDF0", Offset = "0x7F8EDF0", VA = "0x187F8FDF0", Slot = "35")]
	public void AKEPEBCGBGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F97B30", Offset = "0x7F96B30", VA = "0x187F97B30", Slot = "39")]
	public void KBCAHGLOMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7F98CC0", Offset = "0x7F97CC0", VA = "0x187F98CC0", Slot = "34")]
	public void LMBKOAHAMGP(bool KMIFDOHGMCL, bool EHDCMEKIABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F924D0", Offset = "0x7F914D0", VA = "0x187F924D0")]
	private void EOGJNOLOBCM(SkinnedMeshRenderer LJHBDOKGLLC, int AOHLAGDAFAF, Mesh BFBFJIKLAEJ, List<Material> HPMCLMMPGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F95870", Offset = "0x7F94870", VA = "0x187F95870")]
	private static Material IHPPIKNLDDM(Dictionary<FLABNCCLAIP, Material> IBCHCMOCEPN, Material BLEPNLHMOOO, JJMECFFEICE HOPAJMDFFKB, OCCOLDBFJCE PEDAHFEEMAM, IJELGOILOGJ MOINPJHGPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F978F0", Offset = "0x7F968F0", VA = "0x187F978F0")]
	private static JJMECFFEICE JNHFBECAFEM(JLDENJGGNMJ MNLACDGHLOA, int JFNHNGKBMKM)
	{
		return default(JJMECFFEICE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B750", Offset = "0x7F9A750", VA = "0x187F9B750")]
	private void OKKGCBCPHEN(int IFGMJLPFAMJ, Material JNBIMACAHOC, JLDENJGGNMJ MNLACDGHLOA, [Out] Texture2D FDEHCODGHJB, [Out] Vector4 BPMLCBFBLGD, [Out] Texture2D JLLCKMLOCPK, [Out] Texture2D DCHINNCNOOM, [Out] Texture2D OMGILABPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F99030", Offset = "0x7F98030", VA = "0x187F99030")]
	private void MEBCKMLBBIB(int IFGMJLPFAMJ, Material JNBIMACAHOC, JLDENJGGNMJ MNLACDGHLOA, [Out] Color LLOHAALHPID, [Out] Color GFEFHGGCPPP, [Out] Color MENHNPNJFNK, [Out] Color HAPDAADECOH, [Out] Color HPNNKMBHJON, [Out] Color LPCALCNBBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7F98A30", Offset = "0x7F97A30", VA = "0x187F98A30")]
	private bool LJFFPCHDBOM(Material JNBIMACAHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F922E0", Offset = "0x7F912E0", VA = "0x187F922E0")]
	private static Material EEHDKODBBCB(int IFGMJLPFAMJ, GHEPCIFAOCN MNLACDGHLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F90A50", Offset = "0x7F8FA50", VA = "0x187F90A50")]
	private static OCCOLDBFJCE DDHGMEMKLGC(JLDENJGGNMJ MNLACDGHLOA, int JFNHNGKBMKM)
	{
		return default(OCCOLDBFJCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7F97D90", Offset = "0x7F96D90", VA = "0x187F97D90")]
	private static void KDFHADGFCAO(Dictionary<string, List<FLABNCCLAIP>> JPAPECBEEIF, JLDENJGGNMJ PBPANNLNIFD, Material BLEPNLHMOOO, JJMECFFEICE MNJNKHEPJFG, OCCOLDBFJCE KLCEEABFDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F99D70", Offset = "0x7F98D70", VA = "0x187F99D70")]
	private static SkinnedMeshRenderer NDJFBKOCFPP(Transform BHDJGBHLDMF, Transform OOEOKIFGGJF, SkinnedMeshRenderer[] MIPONMCOHKI, int AOHLAGDAFAF, DEINJGGBOFP CHOCDIANLNI, bool AKOCNFAHJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C140", Offset = "0x7F9B140", VA = "0x187F9C140")]
	public AGEDNKOPNGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9AEF0", Offset = "0x7F99EF0", VA = "0x187F9AEF0")]
	public void OCOPJMCPGIB([In] KODBFLCAOOC BCCKMGPKIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F98030", Offset = "0x7F97030", VA = "0x187F98030")]
	public void KDGNCMBFHFE([In] NABIJBAICJA KENALKHDJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F905C0", Offset = "0x7F8F5C0", VA = "0x187F905C0", Slot = "5")]
	public void AOJPPIMKDAG(int AOHLAGDAFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F948D0", Offset = "0x7F938D0", VA = "0x187F948D0", Slot = "10")]
	public void GHJPCANBEAJ(AFINAFOMFNA KLCEEABFDHM, Texture2D GHHJBAFAEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0")]
	public static bool FKIDMFCNHLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F92340", Offset = "0x7F91340", VA = "0x187F92340", Slot = "11")]
	public bool EHFEFDEGDDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F98190", Offset = "0x7F97190", VA = "0x187F98190", Slot = "9")]
	public void LACEALEKEFI(NJIJBJFOPON MNJNKHEPJFG, Color? AHIICABHHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BE10", Offset = "0x7F9AE10", VA = "0x187F9BE10")]
	private void PBKIBKEPONF(Action LLJLBCKPHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F99FF0", Offset = "0x7F98FF0", VA = "0x187F99FF0", Slot = "6")]
	public void NKILPHGPNAD(NPGINOMBEOC JFICGBELHBL, Texture PFHANKOIKDK, Color AJHNHBCMIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F90610", Offset = "0x7F8F610", VA = "0x187F90610", Slot = "7")]
	public void CDGFEGIFCFJ(bool FPBPLIALFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC980", Offset = "0x1ECB980", VA = "0x181ECC980", Slot = "8")]
	public void NOAFEAIJHBL(FABAOFAOADM OGEALFKCCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F91B70", Offset = "0x7F90B70", VA = "0x187F91B70", Slot = "16")]
	public void DJNIACCPHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F94870", Offset = "0x7F93870", VA = "0x187F94870", Slot = "36")]
	public void GFJKJMAMEPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7F90B30", Offset = "0x7F8FB30", VA = "0x187F90B30", Slot = "37")]
	public void DFENDEFCGNL([Optional] KCJIIMMAEMJ NLKFKEDGKDH, [Optional] bool? GHACLNGCBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7F98EF0", Offset = "0x7F97EF0", VA = "0x187F98EF0")]
	private bool MDLPOMEPAEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7F95850", Offset = "0x7F94850", VA = "0x187F95850", Slot = "21")]
	public bool IBEELNJBLHI(GJIEMCFIFPN.OHDBKEAJCKP MCGKIGCFMPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7F98D60", Offset = "0x7F97D60", VA = "0x187F98D60", Slot = "38")]
	public void LOFHMCFBCLH(float MPFHMNPFEJI, Color AHIICABHHJO, bool KBMAAHNKBIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F94BF0", Offset = "0x7F93BF0", VA = "0x187F94BF0")]
	public void GMAMAGNPPKM(float MPFHMNPFEJI, Color AHIICABHHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7F953C0", Offset = "0x7F943C0", VA = "0x187F953C0")]
	private static bool HAIMEEPEBGA(Material NPGBFHGOJBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F951F0", Offset = "0x7F941F0", VA = "0x187F951F0")]
	private void GPKAHEHNLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7F924C0", Offset = "0x7F914C0", VA = "0x187F924C0")]
	private void EMCCOMLHBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7F92850", Offset = "0x7F91850", VA = "0x187F92850")]
	private static void FJJBBEAOBBH(Dictionary<FLABNCCLAIP, Material> IBCHCMOCEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7F91A10", Offset = "0x7F90A10", VA = "0x187F91A10")]
	private static void DIKLPMBFHKA(Dictionary<Renderer, LNMDEHJKKPB> COPLPLJOHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F98870", Offset = "0x7F97870", VA = "0x187F98870")]
	private void LHIJKHPLKFJ(SkinnedMeshRenderer[] MIPONMCOHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F98990", Offset = "0x7F97990", VA = "0x187F98990")]
	private void LJBIBCFOECG(SkinnedMeshRenderer CFNGLDDBAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A3D0", Offset = "0x7F993D0", VA = "0x187F9A3D0")]
	private void NNFCNNAPJGK(List<INKKKBPBHOJ> KPDAAMEHGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F908D0", Offset = "0x7F8F8D0", VA = "0x187F908D0")]
	private void DBIFBDKECDE(Dictionary<string, PHNCGCCJBCF<Texture2D>> JPAPECBEEIF, bool KDJCLIKFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F99FA0", Offset = "0x7F98FA0", VA = "0x187F99FA0")]
	private void NHLJCBDNEJL(Dictionary<string, List<FLABNCCLAIP>> JPAPECBEEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A5B0", Offset = "0x7F995B0", VA = "0x187F9A5B0")]
	private void NOFJEKIPLDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F954B0", Offset = "0x7F944B0", VA = "0x187F954B0")]
	private void HBJIKFGKNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F830", Offset = "0x7F8E830", VA = "0x187F8F830")]
	private void AHNPAOAHABN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F901D0", Offset = "0x7F8F1D0", VA = "0x187F901D0")]
	private void ANBEDEOOBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F94AD0", Offset = "0x7F93AD0", VA = "0x187F94AD0")]
	private void GIFLBAIMMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F95700", Offset = "0x7F94700", VA = "0x187F95700")]
	private void HNIBELIOKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F90810", Offset = "0x7F8F810", VA = "0x187F90810")]
	private void CDJOKMPJLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F902A0", Offset = "0x7F8F2A0", VA = "0x187F902A0")]
	private void ANKKDNOCGPB(bool MJHFCLJGGJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F98E70", Offset = "0x7F97E70", VA = "0x187F98E70")]
	private void MBHJJINAJLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F97C80", Offset = "0x7F96C80", VA = "0x187F97C80")]
	private void KCCKOILDLND(bool MJHFCLJGGJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F480", Offset = "0x7F8E480", VA = "0x187F8F480")]
	private void AAJDGOBFMLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F994F0", Offset = "0x7F984F0", VA = "0x187F994F0")]
	private void MFKIBGACOPE(Material NPGBFHGOJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F99BF0", Offset = "0x7F98BF0", VA = "0x187F99BF0")]
	private void NBFJOADCEKJ(Material NPGBFHGOJBE, Color DEEHIIHBAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F92000", Offset = "0x7F91000", VA = "0x187F92000")]
	private void ECFOGFJLGFN(Material NPGBFHGOJBE, Color DEEHIIHBAFK, Color GIBAHFJLHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F97660", Offset = "0x7F96660", VA = "0x187F97660")]
	private void JJFBNDDONDA(Material NPGBFHGOJBE, Color LLOHAALHPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F90620", Offset = "0x7F8F620", VA = "0x187F90620")]
	private void CDJGGJHDHID(Material NPGBFHGOJBE, Texture2D GHHJBAFAEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F98610", Offset = "0x7F97610", VA = "0x187F98610")]
	private void LBNOBOBIIFG(Material NPGBFHGOJBE, Texture JNHJOIEJJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F90460", Offset = "0x7F8F460", VA = "0x187F90460")]
	private void AOHPMLAHFCA(Action<LNMDEHJKKPB> CCJJFMFOKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F999F0", Offset = "0x7F989F0", VA = "0x187F999F0")]
	private void MOEFJLNGBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A700", Offset = "0x7F99700", VA = "0x187F9A700")]
	private void OABKDAHMNLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F9AB20", Offset = "0x7F99B20", VA = "0x187F9AB20")]
	private void OCGLILKJGGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B260", Offset = "0x7F9A260", VA = "0x187F9B260")]
	public void OGGPCMKAHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F98030", Offset = "0x7F97030", VA = "0x187F98030", Slot = "4")]
	private void LHPGGJDOAPK([In] NABIJBAICJA KENALKHDJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F90890", Offset = "0x7F8F890", VA = "0x187F90890")]
	[CompilerGenerated]
	private JCFICNGFDLA CGFKODKDBKE(JLDENJGGNMJ GDJJGAEMLNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BD80", Offset = "0x7F9AD80", VA = "0x187F9BD80")]
	[CompilerGenerated]
	private void PAFADEEGJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F92620", Offset = "0x7F91620", VA = "0x187F92620")]
	[CompilerGenerated]
	private void FALMPFDIJAB(LNMDEHJKKPB GBHDPELDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F94B60", Offset = "0x7F93B60", VA = "0x187F94B60")]
	[CompilerGenerated]
	private void GJDNCLAPNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F97610", Offset = "0x7F96610", VA = "0x187F97610")]
	[CompilerGenerated]
	private void JEHNCMBOPIL(LNMDEHJKKPB GBHDPELDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F98CD0", Offset = "0x7F97CD0", VA = "0x187F98CD0")]
	[CompilerGenerated]
	private void LMJKFPMOBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F905F0", Offset = "0x7F8F5F0", VA = "0x187F905F0")]
	[CompilerGenerated]
	private void BLCNPNBLIME(LNMDEHJKKPB GBHDPELDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F91980", Offset = "0x7F90980", VA = "0x187F91980")]
	[CompilerGenerated]
	private void DFHHBCOMAOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F91D70", Offset = "0x7F90D70", VA = "0x187F91D70")]
	[CompilerGenerated]
	private void DLLCFJOLPGJ(LNMDEHJKKPB GBHDPELDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BCE0", Offset = "0x7F9ACE0", VA = "0x187F9BCE0")]
	[CompilerGenerated]
	private void OOEPBHNCPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F975E0", Offset = "0x7F965E0", VA = "0x187F975E0")]
	[CompilerGenerated]
	private void ILEJPLBOLNP(LNMDEHJKKPB GBHDPELDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F92250", Offset = "0x7F91250", VA = "0x187F92250")]
	[CompilerGenerated]
	private void EEBFPDGABCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F980E0", Offset = "0x7F970E0", VA = "0x187F980E0")]
	[CompilerGenerated]
	private void KGFCBEPNNHO(LNMDEHJKKPB GBHDPELDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F7A0", Offset = "0x7F8E7A0", VA = "0x187F8F7A0")]
	[CompilerGenerated]
	private void AEAHIMCGGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F98C90", Offset = "0x7F97C90", VA = "0x187F98C90")]
	[CompilerGenerated]
	private void LKBHCFNCFJG(LNMDEHJKKPB GBHDPELDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F98110", Offset = "0x7F97110", VA = "0x187F98110")]
	[CompilerGenerated]
	private void KPGEONKICKA(KeyValuePair<string, PHNCGCCJBCF<Texture2D>> EKBAEMLNOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BCD0", Offset = "0x7F9ACD0", VA = "0x187F9BCD0")]
	[CompilerGenerated]
	private void OOBPDJJAIGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F980B0", Offset = "0x7F970B0", VA = "0x187F980B0")]
	[CompilerGenerated]
	private void KFAIHJCMJHC(LNMDEHJKKPB GBHDPELDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F905E0", Offset = "0x7F8F5E0", VA = "0x187F905E0")]
	[CompilerGenerated]
	private void APNFPMHENKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F97D60", Offset = "0x7F96D60", VA = "0x187F97D60")]
	[CompilerGenerated]
	private void KCGJEIJAJLF(LNMDEHJKKPB GBHDPELDFIL)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendHelperController : MonoBehaviour, BHHGJJDGPBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Vector3? HHDFINFEFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private bool POIBLCINEHC;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F9CDD0", Offset = "0x7F9BDD0", VA = "0x187F9CDD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F9D400", Offset = "0x7F9C400", VA = "0x187F9D400", Slot = "4")]
		public void UpdateController(float PFFBKHOBAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xD4C1D0", Offset = "0xD4B1D0", VA = "0x180D4C1D0", Slot = "6")]
		public void SetEnabled(bool IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7F9CEB0", Offset = "0x7F9BEB0", VA = "0x187F9CEB0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7F9D8C0", Offset = "0x7F9C8C0", VA = "0x187F9D8C0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarElbowBendTargetController : MonoBehaviour, BHHGJJDGPBM
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private const float JJCMAIPNLJL = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Vector3 JIHENINKHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private Vector3 EJIFGIPCCNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private bool POIBLCINEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private float LONOKGMIOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private float EKGINGJLGGN;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2F50", Offset = "0x7FA1F50", VA = "0x187FA2F50", Slot = "4")]
		public void UpdateController(float PFFBKHOBAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xFBDCA0", Offset = "0xFBCCA0", VA = "0x180FBDCA0", Slot = "6")]
		public void SetEnabled(bool IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2C70", Offset = "0x7FA1C70", VA = "0x187FA2C70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3A10", Offset = "0x7FA2A10", VA = "0x187FA3A10")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OHHINBPGLJI : PLOEHKAEILB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int GBCOGHHAFDP;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int DBKHHIKEFFL;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int LGLNFILBAMG;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int GLMNIPGNFFL;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int GCDIAFIGBGK;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int LCDHFPCDMJD;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int LDGMLEDBGFD;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static readonly int DCDMDGJNHFD;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly int BGONLAMENNB;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static readonly int EBAGMACMHAB;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static readonly int ACKFMEGMALG;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly int NAFOIDLPDNJ;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private static readonly int DKOOMEEPAIE;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly int JKGNKFHOFPN;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static readonly int CCKHCPKHNKN;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly int LHIMGEMDEAM;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly int JMHCDEBAAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Transform JLCNJMCJMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private Transform HJNGGPENCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private Transform BGHNBPFFDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private Transform EPCMOONGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private Transform AFELBPFJFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Transform DFGJNLJHGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private NIBMMELLCJM DBFEJANLMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Material NAEJMMFENII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private SkinnedMeshRenderer[] ONBGLKMGMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly List<Material> DFFKILAEMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private KCLPKJACDBA EJFFBJAPCLA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LELKCPPPMEI BENBLNFOBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private KCLPKJACDBA CJDFLFNKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2CC0", Offset = "0x7FB1CC0", VA = "0x187FB2CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EMJBEIDFIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2D40", Offset = "0x7FB1D40", VA = "0x187FB2D40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4200", Offset = "0x7FB3200", VA = "0x187FB4200")]
	public void OCOPJMCPGIB([In] NIBMMELLCJM MCJMEPOLFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2B40", Offset = "0x7FB1B40", VA = "0x187FB2B40")]
	public void BLKDKKMDDLK([In] EGJIMOHCDCN JCNAIOGCFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7FB42B0", Offset = "0x7FB32B0", VA = "0x187FB42B0", Slot = "6")]
	public void OPEKNJGCOJG(MECBIPJMALB PBBIEBJEFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2C50", Offset = "0x7FB1C50", VA = "0x187FB2C50")]
	private Vector2 EKKOFNCIAOC(Vector2 EKEPKBOHCLA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2E90", Offset = "0x7FB1E90", VA = "0x187FB2E90")]
	public void IKMEONACMDB([In] NGCELFAPBAH JCNAIOGCFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2770", Offset = "0x7FB1770", VA = "0x187FB2770")]
	private void BJJHOJOOOOB(EGLIJJDHMLI MDACDFIHDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3D80", Offset = "0x7FB2D80", VA = "0x187FB3D80")]
	private void JMBMOOLJICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2BE0", Offset = "0x7FB1BE0", VA = "0x187FB2BE0")]
	private void NGOMBKCILMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2BE0", Offset = "0x7FB1BE0", VA = "0x187FB2BE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4AF0", Offset = "0x7FB3AF0", VA = "0x187FB4AF0")]
	public OHHINBPGLJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2B40", Offset = "0x7FB1B40", VA = "0x187FB2B40", Slot = "5")]
	private void IHBKECJAOIE([In] EGJIMOHCDCN JCNAIOGCFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2CB0", Offset = "0x7FB1CB0", VA = "0x187FB2CB0", Slot = "7")]
	private void FICKFOPNCFP([In] NGCELFAPBAH JCNAIOGCFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2760", Offset = "0x7FB1760", VA = "0x187FB2760")]
	[CompilerGenerated]
	internal static float BACOMNEEODO(float IOALKPFEKEK, float ABEGKHABHKG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4110", Offset = "0x7FB3110", VA = "0x187FB4110")]
	[CompilerGenerated]
	internal static void OCAGLLJKGLJ(Vector2 POLMDHLPNEH, Vector2 LFLGIGIJFHD, Vector2 BKLOHAHJLKP, Vector2 IEGNAFDKBMI, Vector2 EOMGFLMBKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2720", Offset = "0x7FB1720", VA = "0x187FB2720")]
	[CompilerGenerated]
	internal static Vector4 AHGIJJDKKGB(Vector2 EBGKGBGFPOC, Vector2 AJNABLFIHCD)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarForearmRollController : MonoBehaviour, BHHGJJDGPBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private float LONOKGMIOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private bool POIBLCINEHC;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3A40", Offset = "0x7FA2A40", VA = "0x187FA3A40", Slot = "4")]
		public void UpdateController(float PFFBKHOBAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2207490", Offset = "0x2206490", VA = "0x182207490", Slot = "6")]
		public void SetEnabled(bool IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA42B0", Offset = "0x7FA32B0", VA = "0x187FA42B0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4350", Offset = "0x7FA3350", VA = "0x187FA4350")]
		public void LMCEEELLBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7FA42E0", Offset = "0x7FA32E0", VA = "0x187FA42E0")]
		public int IIJNIADCOHK(int NKCMILOENIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BKLFMGBIIDB : KDGKGOEHABA
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7FA66A0", Offset = "0x7FA56A0", VA = "0x187FA66A0", Slot = "24")]
	public override float CNIPLAAFNOH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7FA66F0", Offset = "0x7FA56F0", VA = "0x187FA66F0")]
	public BKLFMGBIIDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KDGKGOEHABA : CJMKPNNMLPB
{
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int JFLFDOKLOEE;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int JJOMPBDFIHL;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int JDJDJBMKDJE;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int IIKLDFELHID;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int LKNBGLCILBB;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int LNCKGAHNDCI;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int NJPMKKDEDOD;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int[] LNHDEBENBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private OOAEKCDKLHF DBFEJANLMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private GPDHHMFPDIP GIDJMHAPFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private int LKPLCCFJFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private float IODKDCPEBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	protected Animator JBCPCPGIHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	protected AvatarConfiguration KLLNNAGFENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	protected int GDMICJLDGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private int HDFBHGELJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private int GKCONEGEHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool EGKENJKDIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private LIIMBAPEJAB EINCLLLABPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private int HICDDILKJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private float FCMGPFCCHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AvatarHandDisplaySettings ENFEAACHADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private NOKGHIEMFJK KCNEJMCKHHF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform MAPCMOOGPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 JIEIEHDILHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x18FEC30", Offset = "0x18FDC30", VA = "0x1818FEC30")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x18FEA40", Offset = "0x18FDA40", VA = "0x1818FEA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion DAIJHILDKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xE55660", Offset = "0xE54660", VA = "0x180E55660")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1057940", Offset = "0x1056940", VA = "0x181057940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ONJOJEGAALF
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEDD0", Offset = "0x7FADDD0", VA = "0x187FAEDD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEBE0", Offset = "0x7FADBE0", VA = "0x187FAEBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool HEAFDMELMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xAD3250", Offset = "0xAD2250", VA = "0x180AD3250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 EADAKCNHJDE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA8DCD0", Offset = "0xA8CCD0", VA = "0x180A8DCD0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA8CE60", Offset = "0xA8BE60", VA = "0x180A8CE60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion GLJLAPFAEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x122F430", Offset = "0x122E430", VA = "0x18122F430", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1696510", Offset = "0x1695510", VA = "0x181696510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KMMCOCGLCJN AAADFKPNNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xB04BE0", Offset = "0xB03BE0", VA = "0x180B04BE0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(KMMCOCGLCJN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xB042D0", Offset = "0xB032D0", VA = "0x180B042D0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public KMMCOCGLCJN OKMGHNACGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xB04BD0", Offset = "0xB03BD0", VA = "0x180B04BD0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(KMMCOCGLCJN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xB04700", Offset = "0xB03700", VA = "0x180B04700", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float NCAMIKELGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xBC5D40", Offset = "0xBC4D40", VA = "0x180BC5D40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x10432B0", Offset = "0x10422B0", VA = "0x1810432B0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool APCGPOBIBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEBD0", Offset = "0x7FADBD0", VA = "0x187FAEBD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEBB0", Offset = "0x7FADBB0", VA = "0x187FAEBB0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MHGDIMKDLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEBC0", Offset = "0x7FADBC0", VA = "0x187FAEBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool ENDFJHBJANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEB50", Offset = "0x7FADB50", VA = "0x187FAEB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OGANGIMCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEC10", Offset = "0x7FADC10", VA = "0x187FAEC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JOFPIKJHMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7FAE970", Offset = "0x7FAD970", VA = "0x187FAE970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7FAEC30", Offset = "0x7FADC30", VA = "0x187FAEC30", Slot = "23")]
	public void OCOPJMCPGIB(OOAEKCDKLHF MCJMEPOLFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE370", Offset = "0x7FAD370", VA = "0x187FAE370")]
	public void ALOFFDNNBBE(GPDHHMFPDIP FLKAGOEDHHD, AvatarHandDisplaySettings KGDNAKPKMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE750", Offset = "0x7FAD750", VA = "0x187FAE750", Slot = "14")]
	public void DIGMIIDGLMM(bool DAKNLGLKCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE3C0", Offset = "0x7FAD3C0", VA = "0x187FAE3C0", Slot = "13")]
	public void BGOKHCNCEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xBC5D40", Offset = "0xBC4D40", VA = "0x180BC5D40", Slot = "24")]
	public virtual float CNIPLAAFNOH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE7E0", Offset = "0x7FAD7E0", VA = "0x187FAE7E0")]
	private int EIEMLIIACDH(KMMCOCGLCJN BIDHJKLPPIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE980", Offset = "0x7FAD980", VA = "0x187FAE980")]
	private void FDGAPNBCLBM(int BLIMBEMADDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE300", Offset = "0x7FAD300", VA = "0x187FAE300", Slot = "15")]
	public bool ADMLECEOOIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7FAEC20", Offset = "0x7FADC20", VA = "0x187FAEC20", Slot = "16")]
	public bool NKPEEJFJPHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7FAEB60", Offset = "0x7FADB60", VA = "0x187FAEB60")]
	private KMMCOCGLCJN IIIKCPAAIPL()
	{
		return default(KMMCOCGLCJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1E90D00", Offset = "0x1E8FD00", VA = "0x181E90D00", Slot = "17")]
	public void AHHKGAKGMPA(bool DAKNLGLKCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7FAEE00", Offset = "0x7FADE00", VA = "0x187FAEE00", Slot = "12")]
	public void PKBBIMLNNDK(int BLIMBEMADDN, float ICLMGNNIJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE730", Offset = "0x7FAD730", VA = "0x187FAE730", Slot = "10")]
	public void BKFONEDJBEG(LIIMBAPEJAB GICMHPOANOB, bool OJKKBHHDPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7FAEB40", Offset = "0x7FADB40", VA = "0x187FAEB40", Slot = "11")]
	public void GKIMKNKPEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE320", Offset = "0x7FAD320", VA = "0x187FAE320", Slot = "18")]
	public void ALBOFFLODFF(Transform EBJBKAEFOPM, Vector3 BDEAKCBJHMK, Quaternion MKFBIKJKPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF110", Offset = "0x7FAE110", VA = "0x187FAF110")]
	public KDGKGOEHABA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GHEPCIFAOCN : JLDENJGGNMJ
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KAJNANCPGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public GHEPCIFAOCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public List<INKKKBPBHOJ> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public List<INKKKBPBHOJ> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public PHNCGCCJBCF<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public PHNCGCCJBCF<ENEENJAPGHB> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KAJNANCPGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7FAE0C0", Offset = "0x7FAD0C0", VA = "0x187FAE0C0")]
		internal JCFICNGFDLA JECFAEPAOPJ(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NPGINOMBEOC DNDODHPHOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public ENEENJAPGHB GNLHCEOMDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private PHNCGCCJBCF<ENEENJAPGHB> OCOHADJFOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private PHNCGCCJBCF<Material[]> OMGMKNNAGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Material[] INNBCFMGBOI;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MPLBHBLPGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8D4F0", VA = "0x180A8E4F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA8E310", Offset = "0xA8D310", VA = "0x180A8E310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public GJIEMCFIFPN.OHDBKEAJCKP AAGJHPDFHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return default(GJIEMCFIFPN.OHDBKEAJCKP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA672F0", Offset = "0xA662F0", VA = "0x180A672F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9620", Offset = "0x7FA8620", VA = "0x187FA9620")]
	public GHEPCIFAOCN(IJELGOILOGJ BEFOLJOLPFG, NPGINOMBEOC DBJDJNOLHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8A90", Offset = "0x7FA7A90", VA = "0x187FA8A90", Slot = "6")]
	public override JCFICNGFDLA LAANEIEMOCG(List<INKKKBPBHOJ> OGMOKCEMJJD, List<INKKKBPBHOJ> PKJHNOAEDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7FA92C0", Offset = "0x7FA82C0", VA = "0x187FA92C0")]
	public JCFICNGFDLA PCIDFKMIPLP(List<INKKKBPBHOJ> OGMOKCEMJJD, List<INKKKBPBHOJ> PKJHNOAEDPB, PHNCGCCJBCF<Material[]> OMGMKNNAGEM, [Optional] PHNCGCCJBCF<ENEENJAPGHB> FHELCKLEFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8650", Offset = "0x7FA7650", VA = "0x187FA8650")]
	public (PHNCGCCJBCF<Material[]>, PHNCGCCJBCF<ENEENJAPGHB>) JKHNJOJFEKC(List<INKKKBPBHOJ> OGMOKCEMJJD, List<INKKKBPBHOJ> PKJHNOAEDPB)
	{
		return default((PHNCGCCJBCF<Material[]>, PHNCGCCJBCF<ENEENJAPGHB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8520", Offset = "0x7FA7520", VA = "0x187FA8520", Slot = "7")]
	public override INJNFCMGIML GCNBJJDIICE(uint AOHLAGDAFAF, AvatarSkinnedMeshBoneOrderRemapsData DFLBFPPGFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8240", Offset = "0x7FA7240", VA = "0x187FA8240")]
	public INJNFCMGIML AMEILLHHCNA(GameObject PCNIKBDDLGH, uint AOHLAGDAFAF, bool ADLIDCLMKHP, bool LKCHJJBCAEP, AvatarSkinnedMeshBoneOrderRemapsData DFLBFPPGFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8F50", Offset = "0x7FA7F50", VA = "0x187FA8F50")]
	public static bool NCEDDGGMAOI(Renderer[] MIPONMCOHKI, string CKCHMHKHKIG, [Out] Renderer HMGNKIELKAC, [Out] Renderer PIFAJDFCDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA95D0", Offset = "0x7FA85D0", VA = "0x187FA95D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8450", Offset = "0x7FA7450", VA = "0x187FA8450")]
	private (PHNCGCCJBCF<ENEENJAPGHB>, PHNCGCCJBCF<Material[]>) BAFJLDHELBA()
	{
		return default((PHNCGCCJBCF<ENEENJAPGHB>, PHNCGCCJBCF<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8A70", Offset = "0x7FA7A70", VA = "0x187FA8A70")]
	[CompilerGenerated]
	private void KKCKOMNBJDL(ENEENJAPGHB BGOCMPMGKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0xA631F0", Offset = "0xA621F0", VA = "0x180A631F0")]
	[CompilerGenerated]
	private void PBCFFCIBILJ(Material[] BGOCMPMGKKI)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, BHHGJJDGPBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Vector3 JIHENINKHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Vector3 NDDOJPIMLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Vector3 JIHLIBGEMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Matrix4x4 BBDDGLFBKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private bool POIBLCINEHC;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7FA48E0", Offset = "0x7FA38E0", VA = "0x187FA48E0", Slot = "4")]
		public void UpdateController(float PFFBKHOBAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7FA48D0", Offset = "0x7FA38D0", VA = "0x187FA48D0", Slot = "6")]
		public void SetEnabled(bool IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4470", Offset = "0x7FA3470", VA = "0x187FA4470")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4FA0", Offset = "0x7FA3FA0", VA = "0x187FA4FA0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NMAHPGPJLGN]
public struct PMCHABCACAN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[ReadOnly]
	public JHDMHLNBCNF PNFGLLNGNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	[ReadOnly]
	public int GJONCNMAFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public JJJOPBMCKAG FPOHODDDGDH;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6580", Offset = "0x7FB5580", VA = "0x187FB6580", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NMAHPGPJLGN]
[NativeContainer]
public struct JJJOPBMCKAG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<Vector3> PFDIJGMBDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<Vector3> FNDOEAKANDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<Vector4> ELFPDJAIPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<Vector2> LOIJPHFHCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<Vector2> CNBFDAOLDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector2> KPGKJOJDBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector2> EGOFPAGGGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Color> GBKGCENHJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<int> PHHLLDFHELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<int> BCLKMMEEJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private NativeArray<int> DEBPKFCNBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private NativeArray<int> ICBNDHNEICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<int> IBDGBIJKACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> KIKDIOKEIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> LFKECLIGOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<BoneWeight> NEPGCLKMNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private NativeArray<int> OGEALFKCCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private bool ELGBPIJDJIK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BCGDNMIDPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7FAD280", Offset = "0x7FAC280", VA = "0x187FAD280")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7FAD430", Offset = "0x7FAC430", VA = "0x187FAD430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int EEBCHDJHDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7FAD180", Offset = "0x7FAC180", VA = "0x187FAD180")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7FAD190", Offset = "0x7FAC190", VA = "0x187FAD190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int AMJAIGDGHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7FAD160", Offset = "0x7FAC160", VA = "0x187FAD160")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7FAD170", Offset = "0x7FAC170", VA = "0x187FAD170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD4B0", Offset = "0x7FAC4B0", VA = "0x187FAD4B0")]
	public JJJOPBMCKAG(int IKEMENMCACL, int PMGHJEHHPEI, int MDAHOMOOMBL, int NODJMFOHHGK, Allocator FKPBEKMFPLB, int JHPINEGDGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD440", Offset = "0x7FAC440", VA = "0x187FAD440")]
	public void POPFKBFCHKM(int HLGKMAPOEBE, Vector3 LJALOPCLDCK, Vector3 FPGAPNMDKDK, Vector4 HBPDACJCCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD290", Offset = "0x7FAC290", VA = "0x187FAD290")]
	public void NFBGLEMMBEI(int HLGKMAPOEBE, BoneWeight OLINNPLBLLA, NativeSlice<byte> BJBKBHNDJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7FACA60", Offset = "0x7FABA60", VA = "0x187FACA60")]
	public Color ADMNIDICDPK(int HLGKMAPOEBE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7FACE30", Offset = "0x7FABE30", VA = "0x187FACE30")]
	public void DJGCGCFFJAB(int HLGKMAPOEBE, Color JKODNDABGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7FACDD0", Offset = "0x7FABDD0", VA = "0x187FACDD0")]
	public void DDECHIGFCGD(byte HKDKKMNDGBA, int HLGKMAPOEBE, Vector2 CBLFGBNPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7FACE20", Offset = "0x7FABE20", VA = "0x187FACE20")]
	public void DIOKBHILCPL(int HLGKMAPOEBE, int BJJBMMPFMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD1A0", Offset = "0x7FAC1A0", VA = "0x187FAD1A0")]
	public bool LBFKCLOOOHA(int HKDKKMNDGBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD090", Offset = "0x7FAC090", VA = "0x187FAD090")]
	public void GLLLHMACJOD(int BCLKMAEKJFD, int MOAJDMPNBPN, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD1D0", Offset = "0x7FAC1D0", VA = "0x187FAD1D0")]
	public int[] LKCFPJBDIAA(int BCLKMAEKJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD000", Offset = "0x7FAC000", VA = "0x187FAD000")]
	private NativeSlice<int> GAJKKGLKBCE(int BCLKMAEKJFD)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7FACE50", Offset = "0x7FABE50", VA = "0x187FACE50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7FACA80", Offset = "0x7FABA80", VA = "0x187FACA80")]
	public Mesh CHEHPIGPHEK([Optional] string ANFPEDPKMDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
[NMAHPGPJLGN]
[NativeContainer]
public struct JHDMHLNBCNF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<Vector3> PFDIJGMBDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<Vector3> FNDOEAKANDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<Vector4> ELFPDJAIPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<Vector2> LOIJPHFHCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<Vector2> CNBFDAOLDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeArray<Vector2> KPGKJOJDBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeArray<Vector2> EGOFPAGGGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeArray<Color> GBKGCENHJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<int> KKFHFODCFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeArray<int> CNFLDOGPFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<int> JKMNKAIBBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<int> BPANDIFLLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<bool> NIOONJBKGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeArray<int> HCKCIPBAEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeArray<int> BBEPOJCDMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeArray<BoneWeight> KFPJPOCCHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private NativeArray<Matrix4x4> LBIGMLPGALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private NativeArray<long> BEDEJHJCCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private NativeArray<byte> GIJOEEOJMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private NativeArray<int> FBJIBDJDDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private NativeArray<int> ADKKEAAFAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeArray<sbyte> BEJMFAANMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeArray<byte> IEDIFMPMCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private NativeArray<int> GGOFBLLIDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private bool ELGBPIJDJIK;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int NPELIGPLHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xEE6980", Offset = "0xEE5980", VA = "0x180EE6980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int OKCAECMBKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xD4ECD0", Offset = "0xD4DCD0", VA = "0x180D4ECD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int PIAPAIMFDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB080", Offset = "0x7FAA080", VA = "0x187FAB080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int LOJBOMNDGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA8A0", Offset = "0x7FA98A0", VA = "0x187FAA8A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7FAADE0", Offset = "0x7FA9DE0", VA = "0x187FAADE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int BCGDNMIDPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB1A0", Offset = "0x7FAA1A0", VA = "0x187FAB1A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB1B0", Offset = "0x7FAA1B0", VA = "0x187FAB1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int AFAPADGNEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB060", Offset = "0x7FAA060", VA = "0x187FAB060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA880", Offset = "0x7FA9880", VA = "0x187FAA880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public ANMDKMAFHBE PDLNJBOBAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB0B0", Offset = "0x7FAA0B0", VA = "0x187FAB0B0")]
		get
		{
			return default(ANMDKMAFHBE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB190", Offset = "0x7FAA190", VA = "0x187FAB190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte NLBNNOEEJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA890", Offset = "0x7FA9890", VA = "0x187FAA890")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB070", Offset = "0x7FAA070", VA = "0x187FAB070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public KHEKEDJAOIF LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA8B0", Offset = "0x7FA98B0", VA = "0x187FAA8B0")]
		get
		{
			return default(KHEKEDJAOIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7FAB1C0", Offset = "0x7FAA1C0", VA = "0x187FAB1C0")]
	public JHDMHLNBCNF(IList<Mesh> CFGJHBDALBM, IList<Matrix4x4> CBBMPLKLHDD, IList<bool> NIOONJBKGCE, byte KFAPCBDOICE, IList<byte[]> CBKADDOEMMD, IList<long> OIKLKNCCHII, IList<bool> NMEDMLNCKPB, IList<int> HCKCIPBAEKH, IList<int> IADDCNLIKCL, IList<int> KDIOADKCJKP, Allocator FKPBEKMFPLB, ANMDKMAFHBE FFJMAKAAEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7FAB0C0", Offset = "0x7FAA0C0", VA = "0x187FAB0C0")]
	public JJJOPBMCKAG KBEDPKGMDFM(Allocator FKPBEKMFPLB)
	{
		return default(JJJOPBMCKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7FAADF0", Offset = "0x7FA9DF0", VA = "0x187FAADF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[NMAHPGPJLGN]
public class FEAOEHLLNIA : GCLJFDBHAML
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6F00", Offset = "0x7FA5F00", VA = "0x187FA6F00")]
	public JHDMHLNBCNF IMBFDDJGDJO()
	{
		return default(JHDMHLNBCNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EE60", Offset = "0x7F9DE60", VA = "0x187F9EE60")]
	public FEAOEHLLNIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KHEKEDJAOIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<Vector3> PFDIJGMBDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<Vector3> FNDOEAKANDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public NativeSlice<Vector4> ELFPDJAIPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public NativeSlice<Vector2> LOIJPHFHCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeSlice<Vector2> CNBFDAOLDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeSlice<Vector2> KPGKJOJDBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public NativeSlice<Vector2> EGOFPAGGGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public NativeSlice<Color> GBKGCENHJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public NativeSlice<int> FBFDDHHJKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public NativeSlice<int> BPANDIFLLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public NativeSlice<BoneWeight> KFPJPOCCHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public NativeSlice<byte> HONMPMDHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public int EMMHBMKNBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public Matrix4x4 GNHENMLILKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public long AIPKCMFIPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeSlice<byte> BJBKBHNDJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public bool BGNPCACLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public int ALJHJIENLOL;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct FLABNCCLAIP : IEquatable<FLABNCCLAIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	internal readonly Material AGLIMLFKBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	internal readonly JJMECFFEICE HMGCHBNGPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	internal readonly OCCOLDBFJCE MOHCFPDFFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	internal readonly IJELGOILOGJ NCCGFBHCLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	internal readonly bool PEFKLKJNLKE;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7DC0", Offset = "0x7FA6DC0", VA = "0x187FA7DC0")]
	public FLABNCCLAIP(Material JNBIMACAHOC, JJMECFFEICE HOPAJMDFFKB, OCCOLDBFJCE PEDAHFEEMAM, IJELGOILOGJ MOINPJHGPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7B20", Offset = "0x7FA6B20", VA = "0x187FA7B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7880", Offset = "0x7FA6880", VA = "0x187FA7880", Slot = "4")]
	public bool Equals(FLABNCCLAIP EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7910", Offset = "0x7FA6910", VA = "0x187FA7910", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7A10", Offset = "0x7FA6A10", VA = "0x187FA7A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, JKEEOANKNDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		[Header("Configuration")]
		private NOKGHIEMFJK avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[FormerlySerializedAs("BodyMaterial")]
		[SerializeField]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private DBKAMJMIKIH HJEEEMOLJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private PLOEHKAEILB AHPCMMKMHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private CJMKPNNMLPB BBGDFBJECFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private CJMKPNNMLPB EPCACKMHOLJ;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DBKAMJMIKIH IOLENHCLKDO
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7FA5F90", Offset = "0x7FA4F90", VA = "0x187FA5F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public PLOEHKAEILB NNOLPDMMCJO
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7FA5FE0", Offset = "0x7FA4FE0", VA = "0x187FA5FE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public CJMKPNNMLPB AELCANFJJJA
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA6030", Offset = "0x7FA5030", VA = "0x187FA6030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public CJMKPNNMLPB CLMEFFBDPJA
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA6080", Offset = "0x7FA5080", VA = "0x187FA6080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform EELELAKHJOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7FA60D0", Offset = "0x7FA50D0", VA = "0x187FA60D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NOKGHIEMFJK HNFIPMLFCMM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA674E0", Offset = "0xA664E0", VA = "0x180A674E0", Slot = "12")]
			get
			{
				return default(NOKGHIEMFJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4FB0", Offset = "0x7FA3FB0", VA = "0x187FA4FB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5DF0", Offset = "0x7FA4DF0", VA = "0x187FA5DF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA57B0", Offset = "0x7FA47B0", VA = "0x187FA57B0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5DF0", Offset = "0x7FA4DF0", VA = "0x187FA5DF0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4FF0", Offset = "0x7FA3FF0", VA = "0x187FA4FF0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5EA0", Offset = "0x7FA4EA0", VA = "0x187FA5EA0")]
		public void UpdatePostIKAnimControllers(float PFFBKHOBAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5720", Offset = "0x7FA4720", VA = "0x187FA5720")]
		private void HNEENKGGMMI(GameObject PGIOEBKALDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5A80", Offset = "0x7FA4A80", VA = "0x187FA5A80")]
		private DBKAMJMIKIH MKOALGCNIMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA53E0", Offset = "0x7FA43E0", VA = "0x187FA53E0")]
		private PLOEHKAEILB FJIJBIDFGAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA57F0", Offset = "0x7FA47F0", VA = "0x187FA57F0")]
		private CJMKPNNMLPB LNHPJIGDEIL(ALOALKLLOBH NFBECJJEBDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5F80", Offset = "0x7FA4F80", VA = "0x187FA5F80")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class LNMDEHJKKPB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private MaterialPropertyBlock JOPFFBCLNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Color? LJMBAFKABKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Color? MIMECMMENLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Color? BLGMEGPBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Color? GPNDEJLMACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Color FBOMABHBLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Color HNJKMJCCHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public Color IDEPLNEPIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public float MBEFLPAHIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Texture2D HGNDLGJAMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public Texture2D FMFMEOFNJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Dictionary<FLABNCCLAIP, int> FCMMMKFGJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private JJMECFFEICE[] JLAHIDPGMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private OCCOLDBFJCE[] MENKIOCOGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public Vector4[] MIOFAELJGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public Vector4[] APGIILDLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public Vector4[] PDKFALJMJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public Vector4[] HDAGELCCELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public Vector4[] NFAJFAHFDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Vector4[] DHNEDOMJDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private List<Texture2D> IMOIEBKBPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private Vector4[] ONDAHJNHCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private List<Texture2D> GJHHKPFMEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private float[] EPBABLOIAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private Vector4[] LANJKIOEFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private float[] LNNGCGACLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public float[] MHOFFPCCOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private List<Texture2D> AFKBLAANPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private float[] ODHMLNAHJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private List<Texture2D> IDAFNLJFOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector4[] BJKAHJFMADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private float[] FJDBBMMMEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Vector4[] PMCEEKLFMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public float[] HLDCFEDKBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public Texture2DArray MNIHAGDOJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public Texture2DArray NLDPOCCFLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public Texture2DArray HFNHLOKJNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public Texture2DArray DKKLHFKCPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool HNCADMOIEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private int NCKJPNOIOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private Vector2? JPEAJFDHBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private TextureFormat LDHLBAMHGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private Vector2? MMKOLMBLHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private TextureFormat ALBOBPNHPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private Vector2? EKFIFFJGIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private TextureFormat KLDLFIKEOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private Vector2? BODOFDHJDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private TextureFormat IHPANIHCLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private bool BFHCDNIGCPC;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int NEONCCMLMFO;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int CGNICMDMEOE;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int DGEMDOPHAMN;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int DINHGHCMEHO;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int OEGIPBOIHKG;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int JDPMCFILJJO;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int ENMHCKPNAIC;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static int MEODOBCACLP;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static int DOJLMMIJCDP;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private static int NNPDMOEMHED;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static int KLOEJLKEOMK;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static int HGHAMKJCMAF;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private static int NAKKCCBMFGG;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static int JCBMCKEGFND;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static int NEIINKNECKB;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private static int KIINKNJFDGO;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static int IFFAKEAPEPC;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private static int JOLPEHNFFOB;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private static int IOAFPPPPBBD;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private static int HLHOLIKLNFK;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7FB1A90", Offset = "0x7FB0A90", VA = "0x187FB1A90")]
	private LNMDEHJKKPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7FB1F90", Offset = "0x7FB0F90", VA = "0x187FB1F90")]
	public LNMDEHJKKPB(Color PNGHECBCHKC, Color OEKLKCMPFBG, Color HOCPHJMMCLO, Color? EANHCLOHLFL, Color? IIOPABPPBMG, Color? ECJBENKLEJI, Texture2D MGHNOJHLHPO, Texture2D DBDDOLCMKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7FB10F0", Offset = "0x7FB00F0", VA = "0x187FB10F0")]
	internal int JGHDPCONAFB(Material LNOECCDADGA, JJMECFFEICE HOPAJMDFFKB, OCCOLDBFJCE PEDAHFEEMAM, IJELGOILOGJ MOINPJHGPMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7FB11C0", Offset = "0x7FB01C0", VA = "0x187FB11C0")]
	private int JGHDPCONAFB(FLABNCCLAIP DAKIIEIEKNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF4D0", Offset = "0x7FAE4D0", VA = "0x187FAF4D0")]
	internal int COJDBBOGIJM(Material LNOECCDADGA, Color LLOHAALHPID, Color GFEFHGGCPPP, Color MENHNPNJFNK, Color HAPDAADECOH, Color HPNNKMBHJON, Texture2D KAENOKLMEIL, Vector4 CGEELOEKBMO, Texture2D GELILAKFFLI, Vector4 OHHGAKDOBMN, float EBHEJAJEJCL, float NEOBLGEFHBI, Texture2D LPFCCMNOJGP, Vector4 EEEAIHFGNID, float OLMJHONMEJN, Texture2D LFHICHEGKMA, Color LPCALCNBBHO, Vector4 GAAPNCKPLPJ, JJMECFFEICE HOPAJMDFFKB, OCCOLDBFJCE PEDAHFEEMAM, IJELGOILOGJ MOINPJHGPMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0F30", Offset = "0x7FAFF30", VA = "0x187FB0F30")]
	private void EDJFMFAFMPJ(List<Texture2D> IMOIEBKBPHB, [Out] Texture2DArray OPLEGBFOIIA, [Out] Texture2DArray AGNLMAKILLL, [Out] Texture2DArray CGKBHDJHBHE, [Out] Texture2DArray GHDILECKMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0DA0", Offset = "0x7FAFDA0", VA = "0x187FB0DA0")]
	public void DLKKEFJFOAB(Shader OPPPEKEJIGN, Renderer LBNDIMGOFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x7FB00A0", Offset = "0x7FAF0A0", VA = "0x187FB00A0")]
	private void DHLIDFOGPDH(Shader OPPPEKEJIGN, Renderer LBNDIMGOFLA, int HBDMNBPGLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7FB1250", Offset = "0x7FB0250", VA = "0x187FB1250")]
	private Color KFMFBMHCABA(Color HPBLFIBOGCB, JJMECFFEICE MNJNKHEPJFG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7FB15B0", Offset = "0x7FB05B0", VA = "0x187FB15B0")]
	private Color PLANGCMOFLJ(Color OPCFFFKNHIE, JJMECFFEICE MNJNKHEPJFG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7FB1450", Offset = "0x7FB0450", VA = "0x187FB1450")]
	private bool LGPAHHDEPIJ(Texture2D LKGBGFHPPFO, OCCOLDBFJCE KLCEEABFDHM, [Out] Texture2D ADPJNMBGKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF420", Offset = "0x7FAE420", VA = "0x187FAF420")]
	private void COALBOAHAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0EF0", Offset = "0x7FAFEF0", VA = "0x187FB0EF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class JLDENJGGNMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public readonly IJELGOILOGJ KFEHIPGKDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	protected bool PCFIONDDIGI;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool NGOGKEFLIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xB3C210", Offset = "0xB3B210", VA = "0x180B3C210")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool JBKDOELDPKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xB3C180", Offset = "0xB3B180", VA = "0x180B3C180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xB3C190", Offset = "0xB3B190", VA = "0x180B3C190")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual GJIEMCFIFPN.OHDBKEAJCKP AIPKCMFIPEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GJIEMCFIFPN.OHDBKEAJCKP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool GCOIHDEFHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x15155C0", Offset = "0x15145C0", VA = "0x1815155C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool EMMLEDCGFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FAE050", Offset = "0x7FAD050", VA = "0x187FAE050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool ONLEDEJKFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FAE060", Offset = "0x7FAD060", VA = "0x187FAE060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool BEFHKJDLIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7FAE070", Offset = "0x7FAD070", VA = "0x187FAE070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE090", Offset = "0x7FAD090", VA = "0x187FAE090")]
	protected JLDENJGGNMJ(IJELGOILOGJ BEFOLJOLPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract JCFICNGFDLA LAANEIEMOCG(List<INKKKBPBHOJ> OGMOKCEMJJD, List<INKKKBPBHOJ> PKJHNOAEDPB);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract INJNFCMGIML GCNBJJDIICE(uint AOHLAGDAFAF, AvatarSkinnedMeshBoneOrderRemapsData DFLBFPPGFLC);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class FECNDBDNDFM : JJPBMGIGPOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private AvatarSkinAssetItem LAOMDFEOOIN;

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7260", Offset = "0x7FA6260", VA = "0x187FA7260")]
	public FECNDBDNDFM(AvatarSkinAssetItem FPFFJDLEKGL, AvatarSkinAssetItem.FDIEJFJCLBB OLJNAIIJBLA, IJELGOILOGJ MOINPJHGPMM, [Optional] AHAMFIMFGBH? GMLJIIPLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6FF0", Offset = "0x7FA5FF0", VA = "0x187FA6FF0", Slot = "6")]
	public override JCFICNGFDLA LAANEIEMOCG(List<INKKKBPBHOJ> OGMOKCEMJJD, List<INKKKBPBHOJ> PKJHNOAEDPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IEFGPFHNBDN
{
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private static readonly int[] IIONMKGLKCD;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private static readonly int[] FNFNPPKKJHA;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] OJPEIPGMKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA1A0", Offset = "0x7FA91A0", VA = "0x187FAA1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA1F0", Offset = "0x7FA91F0", VA = "0x187FAA1F0")]
	public static int[] LIKIDJIEINK(bool NPHOBLGJDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA100", Offset = "0x7FA9100", VA = "0x187FAA100")]
	public static int BMBOICNFKPA(FECJOJFDCBL PCBOAOPDCHC, bool NPHOBLGJDMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA190", Offset = "0x7FA9190", VA = "0x187FAA190")]
	private static int FBELPAILKOG(FECJOJFDCBL PCBOAOPDCHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA0E0", Offset = "0x7FA90E0", VA = "0x187FAA0E0")]
	private static int AEBBPLICBKK(FECJOJFDCBL PCBOAOPDCHC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class MGANJHEAIDM
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DBKGLDOJAHO : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private CMMCHACHDBH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public DBKGLDOJAHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x14896D0", Offset = "0x14886D0", VA = "0x1814896D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6950", Offset = "0x7FA5950", VA = "0x187FA6950", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	public static void ADPAMIGDFMM(string PBJHGGBBAAF, int AOHLAGDAFAF, long FLJGDNIPLBP, long BAHOMBKGDPJ, long ECJHLLPJDCD, long MACDFMNCBFD, long ICBIGIMFBHL, long GMPDHEAEIBD, long BEFFIBBBFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7FB20C0", Offset = "0x7FB10C0", VA = "0x187FB20C0")]
	public static HHGNPNNJJPG JKDDABMNGNK(JobHandle EGNCPFHLPAJ, bool FALODAENJGM, bool IDLKAAIJLLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2050", Offset = "0x7FB1050", VA = "0x187FB2050")]
	[IteratorStateMachine(typeof(DBKGLDOJAHO))]
	private static IEnumerator<CMMCHACHDBH> EJMLEJGFOBH(JobHandle EBEJPHPLJAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GHPKGCIBMGI
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum LODNOKCOGFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly int ODHDPGLAANI;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int JOIHLIBDIAN;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly int KMJKHNOBCEG;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly int NLHAPFMFCNH;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly int ONFJBINMHHC;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly int HABLACNGHKI;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly int MFLFEOPNACE;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly int AJJJHCDEPNP;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly int OIJLIELAPLD;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly int MEKDNFLAIDF;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly int OINIKCEODCE;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly int JOBJIEONDCP;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9750", Offset = "0x7FA8750", VA = "0x187FA9750")]
	public static bool KLLELGLLDJC(Material JNBIMACAHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9690", Offset = "0x7FA8690", VA = "0x187FA9690")]
	public static bool EFJDEBONJPC(Material JNBIMACAHOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JJPBMGIGPOC : JLDENJGGNMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class FJEMKEOGPBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public PHNCGCCJBCF<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public JJPBMGIGPOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public FJEMKEOGPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA74A0", Offset = "0x7FA64A0", VA = "0x187FA74A0")]
		internal void OPAALNGFEBE(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7360", Offset = "0x7FA6360", VA = "0x187FA7360")]
		internal void JECFAEPAOPJ(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	protected AvatarSkinAssetItem NJKDLPHCPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	protected Material[] DENKHMELEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly AvatarSkinAssetItem.FDIEJFJCLBB DJJAKCABFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly AssetReference LPAIPIGOBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly AHAMFIMFGBH? NPJLIPMFNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private SkinnedMeshRenderer[] EMBIGIHOPJJ;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override GJIEMCFIFPN.OHDBKEAJCKP AIPKCMFIPEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GJIEMCFIFPN.OHDBKEAJCKP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA673D0", VA = "0x180A683D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7FADE00", Offset = "0x7FACE00", VA = "0x187FADE00")]
	public JJPBMGIGPOC(AvatarSkinAssetItem.FDIEJFJCLBB OLJNAIIJBLA, AssetReference FMGMCHGCNGF, Material LBAONHBPIOD, IJELGOILOGJ MOINPJHGPMM, GJIEMCFIFPN.OHDBKEAJCKP EJFNGIIBNHH = (GJIEMCFIFPN.OHDBKEAJCKP)0L, [Optional] AHAMFIMFGBH? GMLJIIPLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7FADF30", Offset = "0x7FACF30", VA = "0x187FADF30")]
	public JJPBMGIGPOC(AvatarSkinAssetItem.FDIEJFJCLBB OLJNAIIJBLA, AssetReference FMGMCHGCNGF, Material LBAONHBPIOD, GJIEMCFIFPN.OHDBKEAJCKP EJFNGIIBNHH = (GJIEMCFIFPN.OHDBKEAJCKP)0L, [Optional] AHAMFIMFGBH? GMLJIIPLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7FADB70", Offset = "0x7FACB70", VA = "0x187FADB70", Slot = "6")]
	public override JCFICNGFDLA LAANEIEMOCG(List<INKKKBPBHOJ> OGMOKCEMJJD, List<INKKKBPBHOJ> PKJHNOAEDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD960", Offset = "0x7FAC960", VA = "0x187FAD960", Slot = "7")]
	public override INJNFCMGIML GCNBJJDIICE(uint AOHLAGDAFAF, AvatarSkinnedMeshBoneOrderRemapsData DFLBFPPGFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7FADD90", Offset = "0x7FACD90", VA = "0x187FADD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD910", Offset = "0x7FAC910", VA = "0x187FAD910")]
	protected void DKGLKPKONOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class PCMJJOFMKCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private List<int> NDLOOHPGNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private List<DFHAHKNHBBC> EMMBHOFGLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private HashSet<Transform> IFOHNMKLJAH;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5FA0", Offset = "0x7FB4FA0", VA = "0x187FB5FA0")]
	public static PCMJJOFMKCL JMDLBDBKKOI(Transform HBPDACJCCKM, Dictionary<Transform, OutfitType?> FOCDPEDFIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6130", Offset = "0x7FB5130", VA = "0x187FB6130")]
	private void OJACNLKPKJG(Transform HBPDACJCCKM, IJELGOILOGJ MOINPJHGPMM, Dictionary<Transform, OutfitType?> FOCDPEDFIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5A20", Offset = "0x7FB4A20", VA = "0x187FB5A20")]
	private void BNPIDBCIMEI(Transform ABHJFPEILBJ, IJELGOILOGJ MOINPJHGPMM, bool BMDNIMHLHGC, OutfitType? HNEBPDAGPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5BB0", Offset = "0x7FB4BB0", VA = "0x187FB5BB0")]
	public OKMCPIBDEGI CMIMBIEOKOJ(HashSet<string> ODLNBFHAMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6450", Offset = "0x7FB5450", VA = "0x187FB6450")]
	public PCMJJOFMKCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class OKMCPIBDEGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private List<DFHAHKNHBBC> EMMBHOFGLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private List<Matrix4x4> KBFNMLPPGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Transform[] JJFFLPOAHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private Matrix4x4[] DGLGABDGCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private Dictionary<FOMEJPPEBON, int> MLHJGIDAAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private List<LHAAOAGADBP> FGEOJKLIEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private bool BEGGNACPBLO;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5870", Offset = "0x7FB4870", VA = "0x187FB5870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] KPDELNJKCKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5350", Offset = "0x7FB4350", VA = "0x187FB5350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] NCLKAIDHIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7FB56B0", Offset = "0x7FB46B0", VA = "0x187FB56B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4FA0", Offset = "0x7FB3FA0", VA = "0x187FB4FA0")]
	public void BNPIDBCIMEI(Transform ABHJFPEILBJ, IJELGOILOGJ MOINPJHGPMM, OutfitType? HNEBPDAGPDP, bool FFBKLEJJAOL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4C30", Offset = "0x7FB3C30", VA = "0x187FB4C30")]
	private void BNPIDBCIMEI(Transform ABHJFPEILBJ, IJELGOILOGJ MOINPJHGPMM, OutfitType? HNEBPDAGPDP, bool FFBKLEJJAOL, Matrix4x4 BMPKNAJKMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7FB51A0", Offset = "0x7FB41A0", VA = "0x187FB51A0")]
	public int CFKGLCGGKIL(FOMEJPPEBON DAKIIEIEKNI, bool FCBACBADBMF, [Optional] OutfitType? HNEBPDAGPDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7FB54C0", Offset = "0x7FB44C0", VA = "0x187FB54C0")]
	public int HNJICIMPCFG(IJELGOILOGJ MOINPJHGPMM, [Optional] OutfitType? HNEBPDAGPDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7FB55C0", Offset = "0x7FB45C0", VA = "0x187FB55C0")]
	public void HPFJBLCAHIG(FOMEJPPEBON DAKIIEIEKNI, Matrix4x4 KGEENCCJCEN, bool FCBACBADBMF = false, [Optional] OutfitType? HNEBPDAGPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5720", Offset = "0x7FB4720", VA = "0x187FB5720")]
	public Matrix4x4 MCNHBEADCMH(FOMEJPPEBON DAKIIEIEKNI, bool FCBACBADBMF, [Optional] OutfitType? HNEBPDAGPDP)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0xDD00E0", Offset = "0xDCF0E0", VA = "0x180DD00E0")]
	public void PBNCDDHGIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7FB58B0", Offset = "0x7FB48B0", VA = "0x187FB58B0")]
	public OKMCPIBDEGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct FOMEJPPEBON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public readonly string GMKNDAJNEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public readonly IJELGOILOGJ NCCGFBHCLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public readonly OutfitType? KNMOHPHDCBI;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8190", Offset = "0x7FA7190", VA = "0x187FA8190")]
	public FOMEJPPEBON(string BMDKEGJEJAJ, IJELGOILOGJ MOINPJHGPMM, [Optional] OutfitType? HNEBPDAGPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7FA80E0", Offset = "0x7FA70E0", VA = "0x187FA80E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7F00", Offset = "0x7FA6F00", VA = "0x187FA7F00")]
	public bool AENKCNBBPNI(FOMEJPPEBON EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7FC0", Offset = "0x7FA6FC0", VA = "0x187FA7FC0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8070", Offset = "0x7FA7070", VA = "0x187FA8070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LHAAOAGADBP : IEquatable<LHAAOAGADBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public readonly IJELGOILOGJ NCCGFBHCLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly OutfitType? DMDNILAPNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly int OJPMGAOFBNB;

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF410", Offset = "0x7FAE410", VA = "0x187FAF410")]
	public LHAAOAGADBP(IJELGOILOGJ MOINPJHGPMM, int GLGJBIKLJAD, [Optional] OutfitType? BJBIGGKCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF340", Offset = "0x7FAE340", VA = "0x187FAF340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7194550", Offset = "0x7193550", VA = "0x187194550")]
	public bool FEKHJOPEHOB(IJELGOILOGJ MOINPJHGPMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF2C0", Offset = "0x7FAE2C0", VA = "0x187FAF2C0")]
	public bool JDEHPFOBGJE(OutfitType? BJBIGGKCAKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF130", Offset = "0x7FAE130", VA = "0x187FAF130", Slot = "4")]
	public bool Equals(LHAAOAGADBP EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF180", Offset = "0x7FAE180", VA = "0x187FAF180", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF270", Offset = "0x7FAE270", VA = "0x187FAF270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct DFHAHKNHBBC : IEquatable<DFHAHKNHBBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly Transform PDJCGFIMNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public readonly bool NGALLDHOFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public readonly IJELGOILOGJ FMDPAOKMCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public readonly OutfitType? KNMOHPHDCBI;

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6E20", Offset = "0x7FA5E20", VA = "0x187FA6E20")]
	public DFHAHKNHBBC(Transform ABHJFPEILBJ, bool BMDNIMHLHGC, IJELGOILOGJ GKNGCKHBGBH, [Optional] OutfitType? GHGONLBNGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6C00", Offset = "0x7FA5C00", VA = "0x187FA6C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7FA69A0", Offset = "0x7FA59A0", VA = "0x187FA69A0", Slot = "4")]
	public bool Equals(DFHAHKNHBBC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6AA0", Offset = "0x7FA5AA0", VA = "0x187FA6AA0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6B80", Offset = "0x7FA5B80", VA = "0x187FA6B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7FA81D0", Offset = "0x7FA71D0", VA = "0x187FA81D0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface NAPPMNHDAFP
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDBBEBODOOP(Mesh BFBFJIKLAEJ, Matrix4x4 PCPIEJKHNBN, byte[] BJBKBHNDJOJ, bool JGHNCEJOFAF = false, GJIEMCFIFPN.OHDBKEAJCKP AGAHKNNMAOK = (GJIEMCFIFPN.OHDBKEAJCKP)0L, int HCKCIPBAEKH = -1, bool NIOONJBKGCE = false);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFKLDNALDEN(Allocator FKPBEKMFPLB, ANMDKMAFHBE FFJMAKAAEEE, byte KFAPCBDOICE, [Optional] IList<int> IADDCNLIKCL, [Optional] IList<int> BGEOABNEBAK);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct ENEENJAPGHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public readonly GameObject PCNIKBDDLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private readonly AvatarItemMaterial BOLJJPIMIGO;

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xBDB810", Offset = "0xBDA810", VA = "0x180BDB810")]
	public ENEENJAPGHB(GameObject PCNIKBDDLGH, AvatarItemMaterial BOLJJPIMIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6E70", Offset = "0x7FA5E70", VA = "0x187FA6E70")]
	public void OPKEMMNIEHN(Material JNBIMACAHOC, int IFGMJLPFAMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GJPIIBODFDD : LLDFFJLICBL<Task<(GameObject, AvatarItemMaterial)>, ENEENJAPGHB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct NIMLOBBANFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7FB21B0", Offset = "0x7FB11B0", VA = "0x187FB21B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7FB26B0", Offset = "0x7FB16B0", VA = "0x187FB26B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private PHNCGCCJBCF<GameObject> OIHPCLACLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private PHNCGCCJBCF<AvatarItemMaterial> ALMONAOGELJ;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA050", Offset = "0x7FA9050", VA = "0x187FAA050")]
	private GJPIIBODFDD(Task<(GameObject, AvatarItemMaterial)> CAIMNCAIJDI, PHNCGCCJBCF<GameObject> ENBBADHPLLF, PHNCGCCJBCF<AvatarItemMaterial> FKDCIANKPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9B10", Offset = "0x7FA8B10", VA = "0x187FA9B10")]
	public static GJPIIBODFDD MEFBGKEPBLF(AssetReference OBEPKIMELKG, [Optional] AssetReference NMHMEIPAGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9A70", Offset = "0x7FA8A70", VA = "0x187FA9A70", Slot = "11")]
	protected override ENEENJAPGHB KNHIMANFDCI(Task<(GameObject, AvatarItemMaterial)> NEDGHPKHHHC)
	{
		return default(ENEENJAPGHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7FA99F0", Offset = "0x7FA89F0", VA = "0x187FA99F0", Slot = "12")]
	protected override void AFGNFJCCJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9F20", Offset = "0x7FA8F20", VA = "0x187FA9F20")]
	[AsyncStateMachine(typeof(NIMLOBBANFJ))]
	private static Task<(GameObject, AvatarItemMaterial)> NGMFOGHOIBP(Task<GameObject> HCNHEMDPCIO, Task<AvatarItemMaterial> EBKCNMDNFIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IPAJMIDFOGP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class BBBDDKMKLCL : LLDFFJLICBL<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private PHNCGCCJBCF<MaterialMapAsset> EBEJPHPLJAD;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA65C0", Offset = "0x7FA55C0", VA = "0x187FA65C0")]
		public BBBDDKMKLCL(PHNCGCCJBCF<MaterialMapAsset> EBEJPHPLJAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6150", Offset = "0x7FA5150", VA = "0x187FA6150", Slot = "11")]
		protected override Material[] KNHIMANFDCI(Task<MaterialMapAsset> CAIMNCAIJDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA60F0", Offset = "0x7FA50F0", VA = "0x187FA60F0", Slot = "12")]
		protected override void AFGNFJCCJFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class CGEIODNEKJM : LLDFFJLICBL<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private List<PHNCGCCJBCF<Material>> KNFPKIKAMOM;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7FA68E0", Offset = "0x7FA58E0", VA = "0x187FA68E0")]
		public CGEIODNEKJM(Task<Material[]> CAIMNCAIJDI, List<PHNCGCCJBCF<Material>> KNFPKIKAMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6890", Offset = "0x7FA5890", VA = "0x187FA6890", Slot = "11")]
		protected override Material[] KNHIMANFDCI(Task<Material[]> NEDGHPKHHHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6750", Offset = "0x7FA5750", VA = "0x187FA6750", Slot = "12")]
		protected override void AFGNFJCCJFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA380", Offset = "0x7FA9380", VA = "0x187FAA380")]
	public static PHNCGCCJBCF<Material[]> HGCFDGJCIPF(AssetReference[] AEKLLCOIBEH)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum EAPNDPLNHMI
		{
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum GMEJMKCOBPK
		{
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public enum CMDIOKHFGBE : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct HBDKLKGACIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public readonly Material AGLIMLFKBOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public readonly EAPNDPLNHMI HMGCHBNGPKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public readonly GMEJMKCOBPK MOHCFPDFFOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public readonly IJELGOILOGJ NCCGFBHCLAE;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x7FC7820", Offset = "0x7FC6820", VA = "0x187FC7820")]
			public HBDKLKGACIM(Material JNBIMACAHOC, EAPNDPLNHMI HOPAJMDFFKB, GMEJMKCOBPK PEDAHFEEMAM, IJELGOILOGJ MOINPJHGPMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7FC75F0", Offset = "0x7FC65F0", VA = "0x187FC75F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x7FC73E0", Offset = "0x7FC63E0", VA = "0x187FC73E0")]
			public bool AENKCNBBPNI(HBDKLKGACIM EDJHHGMLKFA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x7FC7460", Offset = "0x7FC6460", VA = "0x187FC7460", Slot = "0")]
			public override bool Equals(object PGIOEBKALDP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x7FC7550", Offset = "0x7FC6550", VA = "0x187FC7550", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class BGJJLNHGACO : IComparable<BGJJLNHGACO>, IEquatable<BGJJLNHGACO>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public int PFBLJMBEHOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public PlayerAvatarDisplayBase OFBAEHEOPOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public IList<HDBFLGDIIHB> BMCGFMFBDAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public AvatarItemBodyType MDHPDHHHDCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public DFKKHJIJFHD NIIDLHHPALC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public bool OLEHFGKLCMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public bool IJLEPPPCBLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public int[] PANEDKGJPLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public float FLLGNJHECIA;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x7FC6F30", Offset = "0x7FC5F30", VA = "0x187FC6F30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x7FC6DE0", Offset = "0x7FC5DE0", VA = "0x187FC6DE0", Slot = "4")]
			public int CompareTo(BGJJLNHGACO EDJHHGMLKFA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x7FC6E10", Offset = "0x7FC5E10", VA = "0x187FC6E10", Slot = "5")]
			public bool Equals(BGJJLNHGACO EDJHHGMLKFA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public BGJJLNHGACO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected abstract class DHFHEHLAJFK
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public class KDEDAJOFBOM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				public readonly Mesh OJBKBOOIDBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				public readonly Material[] KHEOMBFDFGK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				public readonly Transform[] BIAPFPBNHOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				public readonly Matrix4x4[] MHJNLLFKLPG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				public readonly Transform DBNLPKGPDBO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				public readonly bool HJJOGNFJDKJ;

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
				protected KDEDAJOFBOM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x7FCA630", Offset = "0x7FC9630", VA = "0x187FCA630")]
				public KDEDAJOFBOM(Mesh BFBFJIKLAEJ, Material[] JMBOJPLNOPK, bool NEJOEKMBOHK, Transform[] NPMNMGOGMEG, Transform PAKLGJAMJCJ, Matrix4x4[] OHFEHODEHHI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x7FCA570", Offset = "0x7FC9570", VA = "0x187FCA570")]
				private KDEDAJOFBOM(SkinnedMeshRenderer CFNGLDDBAGO, Material[] PFCEIJPPEDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x7FCA480", Offset = "0x7FC9480", VA = "0x187FCA480")]
				private KDEDAJOFBOM(MeshRenderer GLAGAMPIFGI, Transform PAKLGJAMJCJ, Material[] PFCEIJPPEDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x7FCA160", Offset = "0x7FC9160", VA = "0x187FCA160")]
				public static KDEDAJOFBOM BOGNHIFHJLP(Renderer LBNDIMGOFLA, Material[] PFCEIJPPEDH)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public readonly IJELGOILOGJ NCCGFBHCLAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public readonly Transform AAMEJJPLPAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public readonly bool MEDJOIONFCL;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool NGOGKEFLIPP
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool JBKDOELDPKG
			{
				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual GJIEMCFIFPN.OHDBKEAJCKP AIPKCMFIPEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "6")]
				get
				{
					return default(GJIEMCFIFPN.OHDBKEAJCKP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool BGNPCACLGGJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x7FC7080", Offset = "0x7FC6080", VA = "0x187FC7080")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x7FC7090", Offset = "0x7FC6090", VA = "0x187FC7090")]
			protected DHFHEHLAJFK(IJELGOILOGJ MOINPJHGPMM, Transform DMBLAMNBPJI, bool LMAHDIGOCOK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract JCFICNGFDLA LAANEIEMOCG(List<INKKKBPBHOJ> OGMOKCEMJJD, List<INKKKBPBHOJ> PKJHNOAEDPB);

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract KDEDAJOFBOM GCNBJJDIICE(int AOHLAGDAFAF, PlayerHandBones KPOOPGANIIK);
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class NLGFHKMCIGL : DHFHEHLAJFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			protected readonly BodyPartLODs EMBIGIHOPJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected readonly Material[] DENKHMELEKK;

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE0A0", Offset = "0x7FCD0A0", VA = "0x187FCE0A0")]
			public NLGFHKMCIGL(IJELGOILOGJ MOINPJHGPMM, BodyPartLODs CAEGLHBEOIK, Material LBAONHBPIOD, [Optional] Transform DMBLAMNBPJI, bool LMAHDIGOCOK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x7FCDFA0", Offset = "0x7FCCFA0", VA = "0x187FCDFA0", Slot = "7")]
			public override JCFICNGFDLA LAANEIEMOCG(List<INKKKBPBHOJ> OGMOKCEMJJD, List<INKKKBPBHOJ> PKJHNOAEDPB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x7FCDDE0", Offset = "0x7FCCDE0", VA = "0x187FCDDE0", Slot = "8")]
			public override KDEDAJOFBOM GCNBJJDIICE(int AOHLAGDAFAF, PlayerHandBones KPOOPGANIIK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE030", Offset = "0x7FCD030", VA = "0x187FCE030", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected class HIIIJHDPDNK : DHFHEHLAJFK
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool NGOGKEFLIPP
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public override bool JBKDOELDPKG
			{
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x7FC83D0", Offset = "0x7FC73D0", VA = "0x187FC83D0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public GJDMPDNLENL FNKLCNBHJCN
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8520", Offset = "0x7FC7520", VA = "0x187FC8520")]
			public HIIIJHDPDNK(IJELGOILOGJ MOINPJHGPMM, Transform DMBLAMNBPJI, GJDMPDNLENL NDBLNNAFIKN, bool LMAHDIGOCOK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8420", Offset = "0x7FC7420", VA = "0x187FC8420", Slot = "7")]
			public override JCFICNGFDLA LAANEIEMOCG(List<INKKKBPBHOJ> OGMOKCEMJJD, List<INKKKBPBHOJ> PKJHNOAEDPB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "8")]
			public override KDEDAJOFBOM GCNBJJDIICE(int AOHLAGDAFAF, PlayerHandBones KPOOPGANIIK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x7FC84B0", Offset = "0x7FC74B0", VA = "0x187FC84B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class HMMIFCMPLJF
		{
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum NAHFDFKCGNB
			{
				[Cpp2IlInjected.Token(Token = "0x400038D")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x400038E")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x400038F")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000390")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000391")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000392")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000393")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public static readonly int GGNFLFCPHKH;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public static readonly int NIOHIIPAPHH;

			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public static readonly int AFCKAAKGCNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected readonly ALOALKLLOBH NFBECJJEBDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected readonly GGLELKKAJFL BDFBEOLNCBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected readonly Animator DGFJMJBMLBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected readonly Transform CKJPJCCONND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Vector3 IGKGALIDICG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected readonly Transform BDANGJJLOHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Vector3 IDLPKEFOPEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			protected bool AKBAOOODLPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			protected CJMKPNNMLPB BGIJOAAJIGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected bool BFEBMAMJPOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected float ENJIKPJJNGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected MENADNEACFB<KMMCOCGLCJN> JJCDPFNKCEE;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public CJMKPNNMLPB EOCDBMEHINN
			{
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xA631B0", Offset = "0xA621B0", VA = "0x180A631B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool FJBOOBKGHOI
			{
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0xD17AA0", Offset = "0xD16AA0", VA = "0x180D17AA0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x7FC8590", Offset = "0x7FC7590", VA = "0x187FC8590")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool OJPDCGDNDDF
			{
				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0xA683F0", Offset = "0xA673F0", VA = "0x180A683F0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x7FC8F80", Offset = "0x7FC7F80", VA = "0x187FC8F80")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public float LMDOLPNMDEC
			{
				[Cpp2IlInjected.Token(Token = "0x6000321")]
				[Cpp2IlInjected.Address(RVA = "0xDB0980", Offset = "0xDAF980", VA = "0x180DB0980")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0x7FC89B0", Offset = "0x7FC79B0", VA = "0x187FC89B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public KMMCOCGLCJN BAGKECAPGHM
			{
				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x7FC8770", Offset = "0x7FC7770", VA = "0x187FC8770")]
				get
				{
					return default(KMMCOCGLCJN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8AF0", Offset = "0x7FC7AF0", VA = "0x187FC8AF0")]
			public bool JEDLGEAHIIN(KMMCOCGLCJN AENKAPPFHPB, object GFDDDAIMFOH, NAHFDFKCGNB PAAKFDIMFIA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8800", Offset = "0x7FC7800", VA = "0x187FC8800")]
			public bool CFFDBNAJPCK(object GFDDDAIMFOH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7FC9230", Offset = "0x7FC8230", VA = "0x187FC9230")]
			protected HMMIFCMPLJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7FC92C0", Offset = "0x7FC82C0", VA = "0x187FC92C0")]
			public HMMIFCMPLJF(ALOALKLLOBH NFBECJJEBDE, CJMKPNNMLPB FILAOOMILAA, Animator DGFJMJBMLBM, Transform CKJPJCCONND, Transform BDANGJJLOHH, Vector3 IGKGALIDICG, Vector3 IDLPKEFOPEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8D20", Offset = "0x7FC7D20", VA = "0x187FC8D20")]
			private void LIIKJNMBHHO(ushort OLJBODCHEOC, ushort NHBHOFAJNNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8E90", Offset = "0x7FC7E90", VA = "0x187FC8E90")]
			protected void NOAOBODOOKO(ushort OLJBODCHEOC, ushort NHBHOFAJNNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8DD0", Offset = "0x7FC7DD0", VA = "0x187FC8DD0")]
			protected void LOAOMDCHFCJ(ushort OLJBODCHEOC, ushort NHBHOFAJNNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7FC9050", Offset = "0x7FC8050", VA = "0x187FC9050")]
			protected void PEFBEJLKCFM(ushort OLJBODCHEOC, ushort NHBHOFAJNNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8660", Offset = "0x7FC7660", VA = "0x187FC8660")]
			protected void AFCPHGLGEOG(ushort OLJBODCHEOC, ushort NHBHOFAJNNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8950", Offset = "0x7FC7950", VA = "0x187FC8950")]
			protected void GAKFKNFMEGC(ushort OLJBODCHEOC, ushort NHBHOFAJNNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7FC87B0", Offset = "0x7FC77B0", VA = "0x187FC87B0")]
			protected void CDMEBHKAPNF(ushort OLJBODCHEOC, ushort NHBHOFAJNNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8900", Offset = "0x7FC7900", VA = "0x187FC8900")]
			protected void CKOPDIJDDOO(ushort OLJBODCHEOC, ushort NHBHOFAJNNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8C00", Offset = "0x7FC7C00", VA = "0x187FC8C00")]
			protected void JENFHBBFEBG(ushort OLJBODCHEOC, ushort NHBHOFAJNNL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class KEJKHHNPINI : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public const int JBOHFNNMKCD = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected MaterialPropertyBlock JOPFFBCLNAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Color? LJMBAFKABKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Color? BLGMEGPBHPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Color? GPNDEJLMACJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Color FBOMABHBLOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public Color HNJKMJCCHAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public Color IDEPLNEPIPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public Texture2D HGNDLGJAMIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public Texture2D FMFMEOFNJEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Dictionary<HBDKLKGACIM, int> FCMMMKFGJDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected EAPNDPLNHMI[] JLAHIDPGMDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Vector4[] MIOFAELJGHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Vector4[] APGIILDLFJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Vector4[] PDKFALJMJIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Vector4[] HDAGELCCELO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public Vector4[] NFAJFAHFDCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public Vector4[] DHNEDOMJDDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected List<Texture2D> IMOIEBKBPHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected Vector4[] ONDAHJNHCHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected List<Texture2D> GJHHKPFMEPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected float[] EPBABLOIAMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector4[] LANJKIOEFAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected float[] LNNGCGACLND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public float[] MHOFFPCCOCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected List<Texture2D> AFKBLAANPDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected float[] ODHMLNAHJFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected List<Texture2D> IDAFNLJFOCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Vector4[] BJKAHJFMADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected float[] FJDBBMMMEPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector4[] PMCEEKLFMHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public float[] HLDCFEDKBMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public Texture2DArray MNIHAGDOJKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public Texture2DArray NLDPOCCFLEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public Texture2DArray HFNHLOKJNFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Texture2DArray DKKLHFKCPGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected bool HNCADMOIEDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected int NCKJPNOIOIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected Vector2? JPEAJFDHBFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected TextureFormat LDHLBAMHGGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected Vector2? MMKOLMBLHJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected TextureFormat ALBOBPNHPGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected Vector2? EKFIFFJGIPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected TextureFormat KLDLFIKEOPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected Vector2? BODOFDHJDOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected TextureFormat IHPANIHCLPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected bool BFHCDNIGCPC;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected static int NEONCCMLMFO;

			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected static int CGNICMDMEOE;

			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected static int DGEMDOPHAMN;

			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected static int DINHGHCMEHO;

			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected static int OEGIPBOIHKG;

			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected static int JDPMCFILJJO;

			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected static int ENMHCKPNAIC;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected static int MEODOBCACLP;

			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected static int DOJLMMIJCDP;

			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected static int NNPDMOEMHED;

			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			protected static int KLOEJLKEOMK;

			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			protected static int HGHAMKJCMAF;

			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			protected static int NAKKCCBMFGG;

			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			protected static int JCBMCKEGFND;

			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			protected static int NEIINKNECKB;

			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			protected static int KIINKNJFDGO;

			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			protected static int IFFAKEAPEPC;

			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			protected static int JOLPEHNFFOB;

			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			protected static int IOAFPPPPBBD;

			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			protected static int HLHOLIKLNFK;

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD0F0", Offset = "0x7FCC0F0", VA = "0x187FCD0F0")]
			protected KEJKHHNPINI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD060", Offset = "0x7FCC060", VA = "0x187FCD060")]
			public KEJKHHNPINI(Color PNGHECBCHKC, Color OEKLKCMPFBG, Color HOCPHJMMCLO, Color? EANHCLOHLFL, Color? IIOPABPPBMG, Color? ECJBENKLEJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7FCC8A0", Offset = "0x7FCB8A0", VA = "0x187FCC8A0")]
			public int JGHDPCONAFB(Material LNOECCDADGA, EAPNDPLNHMI HOPAJMDFFKB, GMEJMKCOBPK PEDAHFEEMAM, IJELGOILOGJ MOINPJHGPMM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7FCC810", Offset = "0x7FCB810", VA = "0x187FCC810")]
			public int JGHDPCONAFB(HBDKLKGACIM DAKIIEIEKNI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x7FCAB70", Offset = "0x7FC9B70", VA = "0x187FCAB70")]
			public int COJDBBOGIJM(Material LNOECCDADGA, Color LLOHAALHPID, Color GFEFHGGCPPP, Color MENHNPNJFNK, Color HAPDAADECOH, Color HPNNKMBHJON, Texture2D KAENOKLMEIL, Vector4 CGEELOEKBMO, Texture2D GELILAKFFLI, Vector4 OHHGAKDOBMN, float EBHEJAJEJCL, float NEOBLGEFHBI, Texture2D LPFCCMNOJGP, Vector4 EEEAIHFGNID, float OLMJHONMEJN, Texture2D LFHICHEGKMA, float MHFKFAEAIEM, Color LPCALCNBBHO, Vector4 GAAPNCKPLPJ, EAPNDPLNHMI HOPAJMDFFKB, GMEJMKCOBPK PEDAHFEEMAM, IJELGOILOGJ MOINPJHGPMM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7FCC650", Offset = "0x7FCB650", VA = "0x187FCC650")]
			protected void EDJFMFAFMPJ([Out] Texture2DArray OPLEGBFOIIA, [Out] Texture2DArray AGNLMAKILLL, [Out] Texture2DArray CGKBHDJHBHE, [Out] Texture2DArray GHDILECKMMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7FCC3A0", Offset = "0x7FCB3A0", VA = "0x187FCC3A0")]
			public void DLKKEFJFOAB(PlayerAvatarDisplayBase KDDEPKEJMCD, Renderer LBNDIMGOFLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7FCB870", Offset = "0x7FCA870", VA = "0x187FCB870")]
			protected void DHLIDFOGPDH(PlayerAvatarDisplayBase KDDEPKEJMCD, Renderer LBNDIMGOFLA, int HBDMNBPGLPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x7FCCAE0", Offset = "0x7FCBAE0", VA = "0x187FCCAE0")]
			private Color KFMFBMHCABA(Color HPBLFIBOGCB, EAPNDPLNHMI MNJNKHEPJFG)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x7FCC990", Offset = "0x7FCB990", VA = "0x187FCC990")]
			private Color JOCNCKFLNEM(Color HOOCMJEPMBG, EAPNDPLNHMI MNJNKHEPJFG)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7FCAAE0", Offset = "0x7FC9AE0", VA = "0x187FCAAE0")]
			protected void COALBOAHAIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x7FCC610", Offset = "0x7FCB610", VA = "0x187FCC610", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x7FD5820", Offset = "0x7FD4820", VA = "0x187FD5820")]
			public void JLLFIPFBJIB(IJELGOILOGJ MOINPJHGPMM, [Out] Transform NKBKNNLLHKF, [Out] Transform[] NPMNMGOGMEG)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class JOAKCBPCHMH : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034B")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034D")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
			[DebuggerHidden]
			public JOAKCBPCHMH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7FC9E90", Offset = "0x7FC8E90", VA = "0x187FC9E90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7FCA110", Offset = "0x7FC9110", VA = "0x187FCA110", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7FCA060", Offset = "0x7FC9060", VA = "0x187FCA060", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x7FCA060", Offset = "0x7FC9060", VA = "0x187FCA060", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class EAOFLGBDICB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public EAOFLGBDICB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7FC70F0", Offset = "0x7FC60F0", VA = "0x187FC70F0")]
			internal bool DNJPFPOLDMJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class MLKMBFMBKFF : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			private CMMCHACHDBH <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000357")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
			[DebuggerHidden]
			public MLKMBFMBKFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x7FCDA40", Offset = "0x7FCCA40", VA = "0x187FCDA40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7FCDD90", Offset = "0x7FCCD90", VA = "0x187FCDD90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct HEIIJPLABPA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public KLFIFDMNKOJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7FC7F20", Offset = "0x7FC6F20", VA = "0x187FC7F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x7FC82C0", Offset = "0x7FC72C0", VA = "0x187FC82C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class PFFELCLOCDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public PFFELCLOCDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x7FCEAD0", Offset = "0x7FCDAD0", VA = "0x187FCEAD0")]
			internal bool IJJECGDEONI(HDBFLGDIIHB selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class PPIEDOKAIDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public Func<KPIPLFECKNC<Dictionary<string, PHNCGCCJBCF<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public PPIEDOKAIDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x7FCEDB0", Offset = "0x7FCDDB0", VA = "0x187FCEDB0")]
			internal (GKMAAPKKHOG, KPIPLFECKNC<Dictionary<string, PHNCGCCJBCF<Texture2D>>>) GDGEDGLFHDI(Dictionary<string, NPGINOMBEOC> avatarItems)
			{
				return default((GKMAAPKKHOG, KPIPLFECKNC<Dictionary<string, PHNCGCCJBCF<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x7FCEFF0", Offset = "0x7FCDFF0", VA = "0x187FCEFF0")]
			internal KPIPLFECKNC<Dictionary<string, PHNCGCCJBCF<Texture2D>>> JJKDELHJGCH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7FCEFB0", Offset = "0x7FCDFB0", VA = "0x187FCEFB0")]
			internal void GKJMBKEGCMF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class HHBOJIMABHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public HHBOJIMABHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8320", Offset = "0x7FC7320", VA = "0x187FC8320")]
			internal bool OMOEAFKNBLC(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct PJNNJNFIHMJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7FCEB80", Offset = "0x7FCDB80", VA = "0x187FCEB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x7FCED50", Offset = "0x7FCDD50", VA = "0x187FCED50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected static readonly int KPBAHJHAJGK;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected static readonly int KEEELMNCJEE;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected static readonly int BNMEDOINIGO;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected static readonly int GALCDPLJELA;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		protected static readonly int KDPPOMNOEAJ;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		protected static readonly int LDALCCHMIGM;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected static readonly int[] CPMODOHLHEE;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		protected static readonly int[] BDCHNICKFGC;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		protected static readonly int[] GIDMBCJCILG;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected static readonly int[] JMNNNDIBFFI;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected static readonly int[] AJOMCOJPEOC;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		protected static readonly int[] CFFNIDCHMAN;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		protected static List<PlayerAvatarDisplayBase> CGKMNMLGNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected AGBKNCCKDNN LKOCHBFHGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected bool KMIFDOHGMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected bool EHDCMEKIABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected static readonly int[] KKGCJEKKLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		protected Dictionary<HBDKLKGACIM, Material> HCJFHPFHJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected Dictionary<HBDKLKGACIM, Material> JPIIFJDEIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected Material DIOJLNCEAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected DBKAMJMIKIH EDBNNDGMEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private CJMKPNNMLPB BBGDFBJECFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private CJMKPNNMLPB EPCACKMHOLJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected Material KAPFHGLAKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected FitMeshHemisphere AKEOODCBBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected bool HELINPCEEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected KCJIIMMAEMJ PIBKHBBDFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected bool AFNBBCBAJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected AnchorParamsRestrictions EKNDMANPHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected bool OEKBLKPEBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Transform MLPLGFLNCCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected bool PGNOEIIAEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected bool MNOKLNIIFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected Vector3 GKOIICOIDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected Quaternion PONCNCIJIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected Vector2 ELKCMLPPNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected FitMeshHemisphere HDADHIIAGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected Collider[] ILFPHMMLGDD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected Collider[] EJBABKDPFDO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected HMMIFCMPLJF[] CPGBPGPCMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Dictionary<Renderer, KEJKHHNPINI> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Dictionary<Renderer, KEJKHHNPINI> OMCIKHNJLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected PCMJJOFMKCL JKCEIDMDKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected GKMAAPKKHOG IILOGCHDDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public FECJOJFDCBL DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected int DNFDHBCGLNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected (bool isLodForced, int forcedLOD) CLJLGOPPNAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected MENADNEACFB<GGLELKKAJFL> JJCDPFNKCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected bool OKHGFFBDADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected Dictionary<HDBFLGDIIHB, List<HBDKLKGACIM>> MFCEJBNGDAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Dictionary<HDBFLGDIIHB, List<HBDKLKGACIM>> LPLPHOJODEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected readonly Dictionary<string, PHNCGCCJBCF<Texture2D>> IEPPLBMCKMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected readonly Dictionary<string, PHNCGCCJBCF<Texture2D>> LILIBNJMMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected bool FHEBGKPEMEM;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected static int PODJPHAFOIC;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected static List<BGJJLNHGACO> IMGNMOJNKGG;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected static List<BGJJLNHGACO> KGDEGMCHMOK;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected static HHGNPNNJJPG OHANCLFOLIB;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected static Func<List<BGJJLNHGACO>, BGJJLNHGACO> HDJJAHIBLGF;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected static bool NBFCBBPDPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected Color? PCOFHJINOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected bool MIMNJHJIEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected Color JLBNGCCGMAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected Color JJPIFAFENFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected Color GPMKDKIBCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected AvatarHairPattern LDDNLNOPIPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected GJDMPDNLENL NEGMCFNKNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected Color CIKFODOBLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected Color AKIGNBFEAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected AvatarHairPattern OFHFJHIPBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		protected GJDMPDNLENL ONJBNJOGIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected GJDMPDNLENL CFLGJKOGJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected Color MFNGMFNJNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private AdditionalFeetData DHEEOJGMGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected HDBFLGDIIHB? HFEGNDBGFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected Texture BLCGLCCEGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected Color FFECIHACIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected readonly IList<HDBFLGDIIHB> KOMOIOLDIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected readonly IList<HDBFLGDIIHB> ENDHFKPABJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private AvatarItemBodyType LOJCLONCBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		[SerializeField]
		protected DJJBHOIMIGD _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		protected CMDIOKHFGBE KNEKBPPIIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		protected int[] CNFNBKKCECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected bool HBGGFFMLKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected int[] KOKENJCKNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected bool LHMBCKEFFOM;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static readonly GJIEMCFIFPN.OHDBKEAJCKP MLJNHLDACHD;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private static readonly GJIEMCFIFPN.OHDBKEAJCKP EOBKPBPKKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		protected bool NFFPOMNALME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		protected FABAOFAOADM JKHNDMLNIKP;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string AEBFNEIAKIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool IJGCGHDINIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xD0EA60", Offset = "0xD0DA60", VA = "0x180D0EA60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xD0E020", Offset = "0xD0D020", VA = "0x180D0E020")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool NBAFBEEMOCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool BOIHMALBNFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5120", Offset = "0x7FC4120", VA = "0x187FC5120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool LJJGNDCLOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool HMDCCNAPOJC
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool CGOHDHIMECA
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool BEDKHGJLLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public DBKAMJMIKIH BKEELPLNEEF
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xBB8140", Offset = "0xBB7140", VA = "0x180BB8140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5910", Offset = "0x7FC4910", VA = "0x187FC5910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public CJMKPNNMLPB AELCANFJJJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xBB9A50", Offset = "0xBB8A50", VA = "0x180BB9A50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5D10", Offset = "0x7FC4D10", VA = "0x187FC5D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public CJMKPNNMLPB CLMEFFBDPJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xBD2150", Offset = "0xBD1150", VA = "0x180BD2150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5FD0", Offset = "0x7FC4FD0", VA = "0x187FC5FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material PPAAOAJOLFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x7FBBC90", Offset = "0x7FBAC90", VA = "0x187FBBC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected Material EGJEIAGCOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x7FBDB60", Offset = "0x7FBCB60", VA = "0x187FBDB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool PGAEFNAOJJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1338470", Offset = "0x1337470", VA = "0x181338470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PlayerFacialAnimatorBase FMCHFANHNFD
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xBD2350", Offset = "0xBD1350", VA = "0x180BD2350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public HMMIFCMPLJF[] PAGBADINMGF
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4CA0", Offset = "0x7FC3CA0", VA = "0x187FC4CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public HMMIFCMPLJF OLLEIJJMFJM
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5330", Offset = "0x7FC4330", VA = "0x187FC5330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public HMMIFCMPLJF HGIKGAHFHBE
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5370", Offset = "0x7FC4370", VA = "0x187FC5370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Mesh NHDMEHMHLFK
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xBD2AA0", Offset = "0xBD1AA0", VA = "0x180BD2AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected PCMJJOFMKCL NABDKOAAIEK
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7FBC620", Offset = "0x7FBB620", VA = "0x187FBC620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected GKMAAPKKHOG BEGGIGDNIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xBD2E30", Offset = "0xBD1E30", VA = "0x180BD2E30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7FB8970", Offset = "0x7FB7970", VA = "0x187FB8970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected bool IDLKAAIJLLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool BJDGCGDFBEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5320", Offset = "0x7FC4320", VA = "0x187FC5320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int DNKHBJNJMGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5360", Offset = "0x7FC4360", VA = "0x187FC5360")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5F20", Offset = "0x7FC4F20", VA = "0x187FC5F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int NEIJCBLCFKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5C60", Offset = "0x7FC4C60", VA = "0x187FC5C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual bool BKIHGCKGJKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected virtual int[] ECKOAIPLMNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x7FB9970", Offset = "0x7FB8970", VA = "0x187FB9970", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected bool HGGOHFHAJNB
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x7FBFA30", Offset = "0x7FBEA30", VA = "0x187FBFA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected static bool PLHLPBEMAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool CNGAEMAAIJL
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x7FC53A0", Offset = "0x7FC43A0", VA = "0x187FC53A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x7FC61F0", Offset = "0x7FC51F0", VA = "0x187FC61F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<SkinnedMeshRenderer> GDGJKDJDHHA
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4B20", Offset = "0x7FC3B20", VA = "0x187FC4B20")]
			[IteratorStateMachine(typeof(JOAKCBPCHMH))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool EMJBEIDFIBH
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5310", Offset = "0x7FC4310", VA = "0x187FC5310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x7FB92B0", Offset = "0x7FB82B0", VA = "0x187FB92B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public NOKGHIEMFJK MGCKOPBBIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4BA0", Offset = "0x7FC3BA0", VA = "0x187FC4BA0")]
			get
			{
				return default(NOKGHIEMFJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public static bool JMBFHCEKLEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5050", Offset = "0x7FC4050", VA = "0x187FC5050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected static HHGNPNNJJPG JHOLENOFFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x7FBC4A0", Offset = "0x7FBB4A0", VA = "0x187FBC4A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x7FBD880", Offset = "0x7FBC880", VA = "0x187FBD880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color BLGMEGPBHPA
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x7FBD830", Offset = "0x7FBC830", VA = "0x187FBD830")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color GPNDEJLMACJ
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x7FB9D40", Offset = "0x7FB8D40", VA = "0x187FB9D40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D DINJCNBMMHA
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x7FBFDB0", Offset = "0x7FBEDB0", VA = "0x187FBFDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Color FBOMABHBLOG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4C50", Offset = "0x7FC3C50", VA = "0x187FC4C50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Color HNJKMJCCHAG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x7FC0240", Offset = "0x7FBF240", VA = "0x187FC0240")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public GJDMPDNLENL FIHNCFKGDME
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4C10", Offset = "0x7FC3C10", VA = "0x187FC4C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Texture2D PDIDFCINGKO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x7FBFAB0", Offset = "0x7FBEAB0", VA = "0x187FBFAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float HJCBELKPPAD
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4C30", Offset = "0x7FC3C30", VA = "0x187FC4C30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public float MEMOLHMLFGM
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5100", Offset = "0x7FC4100", VA = "0x187FC5100")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool DBCGKHLNBFD
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4C00", Offset = "0x7FC3C00", VA = "0x187FC4C00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x7FC56F0", Offset = "0x7FC46F0", VA = "0x187FC56F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HAPKBEDIKBA
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4880", Offset = "0x7FC3880", VA = "0x187FC4880")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5450", Offset = "0x7FC4450", VA = "0x187FC5450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action OECNOFFHBFK
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7FC47E0", Offset = "0x7FC37E0", VA = "0x187FC47E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7FC53B0", Offset = "0x7FC43B0", VA = "0x187FC53B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action NOLDFDEEODO
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4920", Offset = "0x7FC3920", VA = "0x187FC4920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7FC54F0", Offset = "0x7FC44F0", VA = "0x187FC54F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OBIFOKAHGCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7FC49C0", Offset = "0x7FC39C0", VA = "0x187FC49C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5590", Offset = "0x7FC4590", VA = "0x187FC5590")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ALOALKLLOBH, KMMCOCGLCJN> CNICGOIPGCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4A60", Offset = "0x7FC3A60", VA = "0x187FC4A60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x7FC5630", Offset = "0x7FC4630", VA = "0x187FC5630")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1030", Offset = "0x7FC0030", VA = "0x187FC1030")]
		public bool SetDeformation(bool KMIFDOHGMCL, bool EHDCMEKIABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC640", Offset = "0x7FBB640", VA = "0x187FBC640")]
		protected static Material IHPPIKNLDDM(Dictionary<HBDKLKGACIM, Material> IBCHCMOCEPN, Material BLEPNLHMOOO, EAPNDPLNHMI HOPAJMDFFKB, GMEJMKCOBPK PEDAHFEEMAM, IJELGOILOGJ MOINPJHGPMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7FB94A0", Offset = "0x7FB84A0", VA = "0x187FB94A0")]
		protected void DGBCDJJCFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB370", Offset = "0x7FBA370", VA = "0x187FBB370")]
		protected bool FKIPCPHALOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7FB88E0", Offset = "0x7FB78E0", VA = "0x187FB88E0")]
		protected void BNGNKEMBFAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC300", Offset = "0x7FBB300", VA = "0x187FBC300", Slot = "11")]
		protected virtual void HBJIKFGKNII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7FBEDB0", Offset = "0x7FBDDB0", VA = "0x187FBEDB0")]
		public int MeshesAtLODCount(int MHLDJPKJDAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7FBD560", Offset = "0x7FBC560", VA = "0x187FBD560")]
		protected static void KDFHADGFCAO(Dictionary<HDBFLGDIIHB, List<HBDKLKGACIM>> JPAPECBEEIF, DHFHEHLAJFK PBPANNLNIFD, Material BLEPNLHMOOO, EAPNDPLNHMI MNJNKHEPJFG, GMEJMKCOBPK KLCEEABFDHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8670", Offset = "0x7FB7670", VA = "0x187FB8670")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7740", Offset = "0x7FB6740", VA = "0x187FB7740")]
		protected void ADNHKBNNBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7FBFF50", Offset = "0x7FBEF50", VA = "0x187FBFF50")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "12")]
		protected virtual void PNOBCOHPOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7FBEF90", Offset = "0x7FBDF90", VA = "0x187FBEF90")]
		protected static void NDLCHKFNIFO(List<Material> EHNIDOLJAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB210", Offset = "0x7FBA210", VA = "0x187FBB210")]
		protected static void FJJBBEAOBBH(Dictionary<HBDKLKGACIM, Material> IBCHCMOCEPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7FB95C0", Offset = "0x7FB85C0", VA = "0x187FB95C0")]
		protected static void DIKLPMBFHKA(Dictionary<Renderer, KEJKHHNPINI> COPLPLJOHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDCC0", Offset = "0x7FBCCC0", VA = "0x187FBDCC0")]
		protected void LHIJKHPLKFJ(SkinnedMeshRenderer[] MIPONMCOHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDE70", Offset = "0x7FBCE70", VA = "0x187FBDE70")]
		protected void LJBIBCFOECG(SkinnedMeshRenderer CFNGLDDBAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDF10", Offset = "0x7FBCF10", VA = "0x187FBDF10")]
		protected void LJBIBCFOECG(MeshRenderer GLAGAMPIFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF450", Offset = "0x7FBE450", VA = "0x187FBF450")]
		protected void NNFCNNAPJGK(List<INKKKBPBHOJ> KPDAAMEHGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9130", Offset = "0x7FB8130", VA = "0x187FB9130")]
		protected void DBIFBDKECDE(Dictionary<string, PHNCGCCJBCF<Texture2D>> JPAPECBEEIF, bool KDJCLIKFKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7BE0", Offset = "0x7FB6BE0", VA = "0x187FB7BE0")]
		protected void AJHHIMEPPOM(Dictionary<HDBFLGDIIHB, List<HBDKLKGACIM>> JPAPECBEEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC200", Offset = "0x7FBB200", VA = "0x187FBC200")]
		public float GetHandOpenClosedAxis(ALOALKLLOBH NFBECJJEBDE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7FC18D0", Offset = "0x7FC08D0", VA = "0x187FC18D0")]
		public void SetHandOpenClosedAxis(ALOALKLLOBH NFBECJJEBDE, float OKALOKMOPEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC240", Offset = "0x7FBB240", VA = "0x187FBC240")]
		public KMMCOCGLCJN GetHandVisualState(ALOALKLLOBH NFBECJJEBDE)
		{
			return default(KMMCOCGLCJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7DB0", Offset = "0x7FB6DB0", VA = "0x187FB7DB0")]
		public bool AddHandVisualStateToken(ALOALKLLOBH NFBECJJEBDE, KMMCOCGLCJN HDLPAFIDKLK, object GFDDDAIMFOH, HMMIFCMPLJF.NAHFDFKCGNB PAAKFDIMFIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3160", Offset = "0x7FC2160", VA = "0x187FC3160")]
		public void SetWatchHand(ALOALKLLOBH NFBECJJEBDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3220", Offset = "0x7FC2220", VA = "0x187FC3220")]
		public void SetWatchHands(bool PMDDNEGONFA, bool FBKPJGOJKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7FC06F0", Offset = "0x7FBF6F0", VA = "0x187FC06F0")]
		public bool RemoveHandVisualStateToken(ALOALKLLOBH NFBECJJEBDE, object GFDDDAIMFOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC2C0", Offset = "0x7FBB2C0", VA = "0x187FBC2C0")]
		public bool GetThumbsUpActive(ALOALKLLOBH NFBECJJEBDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2B70", Offset = "0x7FC1B70", VA = "0x187FC2B70")]
		public void SetThumbsUpActive(ALOALKLLOBH NFBECJJEBDE, bool FAFKNAFNEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC280", Offset = "0x7FBB280", VA = "0x187FBC280")]
		public bool GetHandshakeActive(ALOALKLLOBH NFBECJJEBDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1920", Offset = "0x7FC0920", VA = "0x187FC1920")]
		public void SetHandshakeActive(ALOALKLLOBH NFBECJJEBDE, bool OCKMLHPJCIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB590", Offset = "0x7FBA590", VA = "0x187FBB590")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3050", Offset = "0x7FC2050", VA = "0x187FC3050")]
		public void SetUseClassicBeanHandScale(bool IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9010", Offset = "0x7FB8010", VA = "0x187FB9010")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE1C0", Offset = "0x7FBD1C0", VA = "0x187FBE1C0")]
		private static void LPGNNHIDJLA(Scene KJIOEGBKNOL, LoadSceneMode PBBNDGKGPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB5E0", Offset = "0x7FBA5E0", VA = "0x187FBB5E0")]
		protected static void GEAOFIIAMIB(PlayerAvatarDisplayBase AJNFFEHBLCA, List<BGJJLNHGACO> MNFBLMPEAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0410", Offset = "0x7FBF410", VA = "0x187FC0410")]
		public JCFICNGFDLA Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9D90", Offset = "0x7FB8D90", VA = "0x187FB9D90")]
		protected JCFICNGFDLA EHCBIKAMDMK(bool OPGGNFBBLHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9DF0", Offset = "0x7FB8DF0", VA = "0x187FB9DF0", Slot = "13")]
		protected virtual JCFICNGFDLA EHCBIKAMDMK(IList<HDBFLGDIIHB> PBNNHMCPBEJ, AvatarItemBodyType OHFGLCBMGHE, bool AKOCNFAHJLB, bool BAHFLDAOCKI, int[] JFMMNOGELOB, bool OPGGNFBBLHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7FBD000", Offset = "0x7FBC000", VA = "0x187FBD000")]
		protected static JCFICNGFDLA KALAACGJKEC(BGJJLNHGACO JGLJILNDDPA, List<BGJJLNHGACO> MNFBLMPEAJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7FBFEA0", Offset = "0x7FBEEA0", VA = "0x187FBFEA0")]
		[IteratorStateMachine(typeof(MLKMBFMBKFF))]
		protected static IEnumerator<CMMCHACHDBH> OMHAAILKGIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDDE0", Offset = "0x7FBCDE0", VA = "0x187FBDDE0")]
		protected static BGJJLNHGACO LIIFLKPFLJA(List<BGJJLNHGACO> MNFBLMPEAJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1140", Offset = "0x7FC0140", VA = "0x187FC1140")]
		[AsyncStateMachine(typeof(HEIIJPLABPA))]
		public Task SetFaceCustomizationSettings(KLFIFDMNKOJ FMHHPPLDGPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3380", Offset = "0x7FC2380", VA = "0x187FC3380")]
		public bool UpdateFaceAndBodyCustomizationSettings(KLFIFDMNKOJ FMHHPPLDGPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC910", Offset = "0x7FBB910", VA = "0x187FBC910")]
		public void InitializeFaceFeatures(AvatarConfiguration NOCAFBHLAOD, NOKGHIEMFJK IEAPGKOBGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC28C0", Offset = "0x7FC18C0", VA = "0x187FC28C0")]
		public void SetTeamColors(Color? ECJBENKLEJI, bool KLDLOCNOLPI, Color LCOKFJMGNCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x14C0330", Offset = "0x14BF330", VA = "0x1814C0330")]
		private static void GPDCOHFJFLE(Material JNBIMACAHOC, Color IOALKPFEKEK, params int[] OFGBBBBCIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x14BFC00", Offset = "0x14BEC00", VA = "0x1814BFC00")]
		private static void CGGCOPMIFDB(Material JNBIMACAHOC, Texture IOALKPFEKEK, params int[] OFGBBBBCIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE480", Offset = "0x7FBD480", VA = "0x187FBE480")]
		protected void MFKIBGACOPE(Material NPGBFHGOJBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7FBEE70", Offset = "0x7FBDE70", VA = "0x187FBEE70")]
		protected void NBFJOADCEKJ(Material NPGBFHGOJBE, Color DEEHIIHBAFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9B10", Offset = "0x7FB8B10", VA = "0x187FB9B10")]
		protected void ECFOGFJLGFN(Material NPGBFHGOJBE, Color DEEHIIHBAFK, Color GIBAHFJLHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE9D0", Offset = "0x7FBD9D0", VA = "0x187FBE9D0")]
		protected void MICBECMKJOM(Material NPGBFHGOJBE, Texture2D GHHJBAFAEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDA50", Offset = "0x7FBCA50", VA = "0x187FBDA50")]
		protected void LBNOBOBIIFG(Material NPGBFHGOJBE, Texture JNHJOIEJJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7C30", Offset = "0x7FB6C30", VA = "0x187FB7C30")]
		protected void AOHPMLAHFCA(Action<KEJKHHNPINI> CCJJFMFOKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7500", Offset = "0x7FB6500", VA = "0x187FB7500")]
		protected void AAJDGOBFMLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7FBEBF0", Offset = "0x7FBDBF0", VA = "0x187FBEBF0")]
		protected void MOEFJLNGBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF6D0", Offset = "0x7FBE6D0", VA = "0x187FBF6D0")]
		protected void OABKDAHMNLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8100", Offset = "0x7FB7100", VA = "0x187FB8100")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0AB0", Offset = "0x7FBFAB0", VA = "0x187FC0AB0")]
		public void SetBeardPrimaryColor([Optional] Color? NLILOMINAGM, bool KCGGBEKOJKG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0CD0", Offset = "0x7FBFCD0", VA = "0x187FC0CD0")]
		public void SetBeardSecondaryColor([Optional] Color? NLILOMINAGM, bool KCGGBEKOJKG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0970", Offset = "0x7FBF970", VA = "0x187FC0970")]
		public void SetBeardPattern([Optional] AvatarHairPattern GNGFEKDNLIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7A70", Offset = "0x7FB6A70", VA = "0x187FB7A70")]
		private void AFELPCCCHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC7A0", Offset = "0x7FBB7A0", VA = "0x187FBC7A0")]
		private bool IIJMHJDJFAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FC14B0", Offset = "0x7FC04B0", VA = "0x187FC14B0")]
		public void SetHairPrimaryColor([Optional] Color? CGNCEODDNOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7FC16C0", Offset = "0x7FC06C0", VA = "0x187FC16C0")]
		public void SetHairSecondaryColor([Optional] Color? CGNCEODDNOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1380", Offset = "0x7FC0380", VA = "0x187FC1380")]
		public void SetHairPattern([Optional] AvatarHairPattern GNGFEKDNLIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0590", Offset = "0x7FBF590", VA = "0x187FC0590")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7FBCD00", Offset = "0x7FBBD00", VA = "0x187FBCD00")]
		private bool JHHBKDBHKIO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2700", Offset = "0x7FC1700", VA = "0x187FC2700")]
		public void SetSkinColor(Color PNGHECBCHKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2BC0", Offset = "0x7FC1BC0", VA = "0x187FC2BC0")]
		public void SetUgcItemVisualOverrides(HDBFLGDIIHB JFICGBELHBL, NOKGHIEMFJK IEAPGKOBGAD, Texture JAKPHBIJNCC, Color LICMDCLNGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FB90E0", Offset = "0x7FB80E0", VA = "0x187FB90E0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1240", Offset = "0x7FC0240", VA = "0x187FC1240")]
		public bool SetFaceShape(AvatarFaceShape OIDFLPFILCF, bool LHLJLBIDLMJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0290", Offset = "0x7FBF290", VA = "0x187FC0290")]
		private void POAEMGPPDEB(CCMNMMMAHPL JLIPNKCEGAN, float IOALKPFEKEK, bool ODAJBGLFGHK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7FBCB00", Offset = "0x7FBBB00", VA = "0x187FBCB00")]
		private void JHEBJLICMBG(CENDIBEPPLM LFGHKAHBHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB0F0", Offset = "0x7FBA0F0", VA = "0x187FBB0F0")]
		private void FCDHFIFLMIM(LHBPJEFHJCK OGMJGGKPKEC, float IOALKPFEKEK, bool CEKHJKAOLGA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7FBCDC0", Offset = "0x7FBBDC0", VA = "0x187FBCDC0")]
		private void JLDFHOJHDCB(LFAMFJEGOEL JENMMLGGAKB, float IOALKPFEKEK, bool KLJHFNDMANI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDFE0", Offset = "0x7FBCFE0", VA = "0x187FBDFE0")]
		private void LJPBDBODBNF(EMBMAHDHALO GHJJPPPOKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC4F0", Offset = "0x7FBB4F0", VA = "0x187FBC4F0")]
		private void IGHEKJPOHPJ(MPKPIGNDFNB DHCHIDHPBID, float IJPPIBLMHJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0EF0", Offset = "0x7FBFEF0", VA = "0x187FC0EF0")]
		public bool SetBodyShape(AvatarBodyShape MDPNKIKJGBO, bool LHLJLBIDLMJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2590", Offset = "0x7FC1590", VA = "0x187FC2590")]
		public bool SetNoseType(DJJBHOIMIGD GALKAIFGIIP, bool LHLJLBIDLMJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3A70", Offset = "0x7FC2A70", VA = "0x187FC3A70")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2570", Offset = "0x7FC1570", VA = "0x187FC2570")]
		public bool SetHideEars(bool AAHPFNPEMGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2560", Offset = "0x7FC1560", VA = "0x187FC2560")]
		public bool SetHelmetHair(AGBKNCCKDNN JNGLNDIMCCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1FC0", Offset = "0x7FC0FC0", VA = "0x187FC1FC0")]
		public void SetHatAnchorParameters(KCJIIMMAEMJ JFLINKKKBHM, bool MJBHHMDFNJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FC32F0", Offset = "0x7FC22F0", VA = "0x187FC32F0")]
		public void SetupDisplayLODs(CMDIOKHFGBE KOEBFOCJKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9720", Offset = "0x7FB8720", VA = "0x187FB9720")]
		protected int[] DKELICBNLID(CMDIOKHFGBE KOEBFOCJKMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2680", Offset = "0x7FC1680", VA = "0x187FC2680")]
		public void SetOutfitSelections(IList<HDBFLGDIIHB> PBNNHMCPBEJ, AvatarItemBodyType OHFGLCBMGHE, bool BAHFLDAOCKI, bool OPGGNFBBLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2630", Offset = "0x7FC1630", VA = "0x187FC2630")]
		public void SetOutfitSelections(IList<HDBFLGDIIHB> PBNNHMCPBEJ, AvatarItemBodyType OHFGLCBMGHE, bool AKOCNFAHJLB, bool BAHFLDAOCKI, bool OPGGNFBBLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7FC26C0", Offset = "0x7FC16C0", VA = "0x187FC26C0")]
		public JCFICNGFDLA SetOutfitSelections(IList<HDBFLGDIIHB> PBNNHMCPBEJ, AvatarItemBodyType OHFGLCBMGHE, CMDIOKHFGBE KOEBFOCJKMM, bool AKOCNFAHJLB, bool BAHFLDAOCKI, bool LHLJLBIDLMJ = false, bool OPGGNFBBLHB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF0D0", Offset = "0x7FBE0D0", VA = "0x187FBF0D0", Slot = "14")]
		protected virtual JCFICNGFDLA NJNNKCKKPEF(IList<HDBFLGDIIHB> PBNNHMCPBEJ, AvatarItemBodyType OHFGLCBMGHE, bool AKOCNFAHJLB, bool BAHFLDAOCKI, CMDIOKHFGBE KOEBFOCJKMM, bool LHLJLBIDLMJ, bool OPGGNFBBLHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF350", Offset = "0x7FBE350", VA = "0x187FBF350")]
		protected int[] NJPHFGCAEGP(CMDIOKHFGBE KOEBFOCJKMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "15")]
		protected virtual GKMAAPKKHOG NIKDMOKJOHI(AvatarItemBodyType KAAFKPPFGAL, Dictionary<string, NPGINOMBEOC> DFMINDDCOEJ, Dictionary<string, PHNCGCCJBCF<Texture2D>> IHBCBGHEHLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE700", Offset = "0x7FBD700", VA = "0x187FBE700", Slot = "16")]
		protected virtual JCFICNGFDLA MHFNNFLBNGI(IList<HDBFLGDIIHB> PBNNHMCPBEJ, AvatarItemBodyType OHFGLCBMGHE, bool AKOCNFAHJLB, bool BAHFLDAOCKI, int[] PANEDKGJPLB, DFKKHJIJFHD IKPFJJGIBHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB6E0", Offset = "0x7FBA6E0", VA = "0x187FBB6E0", Slot = "17")]
		protected virtual NPGINOMBEOC GEJDDAGBAEC(GJDMPDNLENL NDBLNNAFIKN, AvatarItemBodyType KAAFKPPFGAL, IJELGOILOGJ MOINPJHGPMM, NPGINOMBEOC FNPMGBILPIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "18")]
		protected virtual NPGINOMBEOC FOPPHBJNGML(AvatarItemBodyType KAAFKPPFGAL, IJELGOILOGJ MOINPJHGPMM, KNCMLMAEOOD IEHKKLCADNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC9F0", Offset = "0x7FBB9F0", VA = "0x187FBC9F0")]
		protected void JDONIFDFBIF(CLKPANLDEFD PCIBNJHDOFL, GJIEMCFIFPN.OHDBKEAJCKP AFIEEGGCBOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB190", Offset = "0x7FBA190", VA = "0x187FBB190")]
		protected void FCLFDELABNB(CLKPANLDEFD PCIBNJHDOFL, GJIEMCFIFPN.OHDBKEAJCKP AFIEEGGCBOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xAC9D70", Offset = "0xAC8D70", VA = "0x180AC9D70", Slot = "19")]
		protected virtual CLKPANLDEFD DCFGMCJOLPG(CLKPANLDEFD PCIBNJHDOFL, HelmetHairStyle IBAIDJLGPMJ, bool JADMGJHFNGM, AvatarItemBodyType OHFGLCBMGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA0D0", Offset = "0x7FB90D0", VA = "0x187FBA0D0")]
		protected CLKPANLDEFD FAFLDCLFMDI(IList<HDBFLGDIIHB> PBNNHMCPBEJ, AvatarItemBodyType PLDGCKAGDFB, bool BAHFLDAOCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8EF0", Offset = "0x7FB7EF0", VA = "0x187FB8EF0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC3F0", Offset = "0x7FBB3F0", VA = "0x187FBC3F0")]
		protected void HKCHEMIGGMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7FBBED0", Offset = "0x7FBAED0", VA = "0x187FBBED0")]
		protected void GODNHEDEIBC(Transform GOMAKOAAMEN, IEnumerable<SkinnedMeshRenderer> FMJDAPBPIEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC850", Offset = "0x7FBB850", VA = "0x187FBC850")]
		protected GJIEMCFIFPN.OHDBKEAJCKP IJEOKONMBKK(GJIEMCFIFPN.OHDBKEAJCKP MCGKIGCFMPJ, IJELGOILOGJ BEFOLJOLPFG)
		{
			return default(GJIEMCFIFPN.OHDBKEAJCKP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7FB88D0", Offset = "0x7FB78D0", VA = "0x187FB88D0")]
		protected void BELLBCLBKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x19F6660", Offset = "0x19F5660", VA = "0x1819F6660")]
		protected void LEAHDPCKMLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9A00", Offset = "0x7FB8A00", VA = "0x187FB9A00")]
		protected void EAKMBIOENLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9F70", Offset = "0x7FB8F70", VA = "0x187FB9F70")]
		[AsyncStateMachine(typeof(PJNNJNFIHMJ))]
		protected Task EMPJHIEIFAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7FBCE60", Offset = "0x7FBBE60", VA = "0x187FBCE60")]
		protected static EAPNDPLNHMI JNHFBECAFEM(DHFHEHLAJFK MNLACDGHLOA, int JFNHNGKBMKM)
		{
			return default(EAPNDPLNHMI);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9350", Offset = "0x7FB8350", VA = "0x187FB9350")]
		protected static GMEJMKCOBPK DDHGMEMKLGC(DHFHEHLAJFK MNLACDGHLOA, int JFNHNGKBMKM)
		{
			return default(GMEJMKCOBPK);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9F20", Offset = "0x7FB8F20", VA = "0x187FB9F20")]
		protected Transform EJLFEIJFIHB(IJELGOILOGJ MOINPJHGPMM, OutfitType HNEBPDAGPDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FBFBB0", Offset = "0x7FBEBB0", VA = "0x187FBFBB0")]
		protected void OKKGCBCPHEN(int IFGMJLPFAMJ, Material JNBIMACAHOC, DHFHEHLAJFK MNLACDGHLOA, [Out] Texture2D FDEHCODGHJB, [Out] Vector4 BPMLCBFBLGD, [Out] Texture2D JLLCKMLOCPK, [Out] Texture2D DCHINNCNOOM, [Out] Texture2D OMGILABPIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE330", Offset = "0x7FBD330", VA = "0x187FBE330")]
		protected void MEBCKMLBBIB(int IFGMJLPFAMJ, Material JNBIMACAHOC, DHFHEHLAJFK MNLACDGHLOA, [Out] Color LLOHAALHPID, [Out] Color GFEFHGGCPPP, [Out] Color MENHNPNJFNK, [Out] Color HAPDAADECOH, [Out] Color HPNNKMBHJON, [Out] Color LPCALCNBBHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDC50", Offset = "0x7FBCC50", VA = "0x187FBDC50")]
		protected void LHAMMOCPBHP(Vector3 JILMILDHLCJ, Quaternion FOJJHGMABOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1970", Offset = "0x7FC0970", VA = "0x187FC1970")]
		public void SetHatAnchorParameters(KCJIIMMAEMJ JFLINKKKBHM, AnchorParamsRestrictions JEGHIKBJONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8A10", Offset = "0x7FB7A10", VA = "0x187FB8A10")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere AKEOODCBBBN, Transform MLPLGFLNCCK, KCJIIMMAEMJ JFLINKKKBHM, AnchorParamsRestrictions EKNDMANPHMF, [Out] Vector3 GKANPAILENO, [Out] Quaternion MMKPIDNBBJN, [Out] KCJIIMMAEMJ IAMEGOGPDBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0800", Offset = "0x7FBF800", VA = "0x187FC0800")]
		public void ResetHatAnchor(Vector2 CDFDKAHBKBM, Vector3 COBIMMANOAJ, Vector3 FHACMMGNAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xBBE3B0", Offset = "0xBBD3B0", VA = "0x180BBE3B0")]
		public JOFBOADHHGM GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7F30", Offset = "0x7FB6F30", VA = "0x187FB7F30")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8070", Offset = "0x7FB7070", VA = "0x187FB8070")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7EA0", Offset = "0x7FB6EA0", VA = "0x187FB7EA0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3320", Offset = "0x7FC2320", VA = "0x187FC3320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE0F0", Offset = "0x7FBD0F0", VA = "0x187FBE0F0")]
		protected void LOJDOIPDBNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7FC30E0", Offset = "0x7FC20E0", VA = "0x187FC30E0")]
		public void SetWaitForUgcTextureLoads(bool FPBPLIALFGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2F60", Offset = "0x7FC1F60", VA = "0x187FC2F60")]
		public void SetUgcTextureParameters(FABAOFAOADM OGEALFKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7FC41D0", Offset = "0x7FC31D0", VA = "0x187FC41D0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7FB98E0", Offset = "0x7FB88E0", VA = "0x187FB98E0")]
		[CompilerGenerated]
		private void DOPPGDKCPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8850", Offset = "0x7FB7850", VA = "0x187FB8850")]
		[CompilerGenerated]
		private void BBFNPCIEGAE(KEJKHHNPINI GBHDPELDFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7FBCA70", Offset = "0x7FBBA70", VA = "0x187FBCA70")]
		[CompilerGenerated]
		private void JFCHOIGDKHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF630", Offset = "0x7FBE630", VA = "0x187FBF630")]
		[CompilerGenerated]
		private void NOMCBGMMKEI(KEJKHHNPINI GBHDPELDFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7FB92C0", Offset = "0x7FB82C0", VA = "0x187FB92C0")]
		[CompilerGenerated]
		private void DDGKKIMKDMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FBBBF0", Offset = "0x7FBABF0", VA = "0x187FBBBF0")]
		[CompilerGenerated]
		private void GKPEKFIIOGA(KEJKHHNPINI GBHDPELDFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC360", Offset = "0x7FBB360", VA = "0x187FBC360")]
		[CompilerGenerated]
		private void HHEHAKILKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8880", Offset = "0x7FB7880", VA = "0x187FB8880")]
		[CompilerGenerated]
		private void BEADFLEIPFJ(KEJKHHNPINI GBHDPELDFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA040", Offset = "0x7FB9040", VA = "0x187FBA040")]
		[CompilerGenerated]
		private void EPNHBDNJKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FBFF00", Offset = "0x7FBEF00", VA = "0x187FBFF00")]
		[CompilerGenerated]
		private void OPICIBAIPDP(KEJKHHNPINI GBHDPELDFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7FBBB60", Offset = "0x7FBAB60", VA = "0x187FBBB60")]
		[CompilerGenerated]
		private void GKOPDHMGPKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7D90", Offset = "0x7FB6D90", VA = "0x187FB7D90")]
		[CompilerGenerated]
		private void APCKEBFBADG(KEJKHHNPINI GBHDPELDFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0330", Offset = "0x7FBF330", VA = "0x187FC0330")]
		[CompilerGenerated]
		internal static bool POHAMFAPFJN(Transform IHOLLLLHHOF, IEnumerable<SkinnedMeshRenderer> AMJCCLEGGOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0200", Offset = "0x7FBF200", VA = "0x187FC0200")]
		[CompilerGenerated]
		private void PBLNIKNPDPK(KEJKHHNPINI GBHDPELDFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE2F0", Offset = "0x7FBD2F0", VA = "0x187FBE2F0")]
		[CompilerGenerated]
		private void MAANCCFDNJH(KEJKHHNPINI GBHDPELDFIL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, BDBAOHOAIEN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct KNPKLMECOEM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public KLFIFDMNKOJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD5B0", Offset = "0x7FCC5B0", VA = "0x187FCD5B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD840", Offset = "0x7FCC840", VA = "0x187FCD840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct AMPOLPKGCNC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public NOKGHIEMFJK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7FC67A0", Offset = "0x7FC57A0", VA = "0x187FC67A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7FC6980", Offset = "0x7FC5980", VA = "0x187FC6980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct AOIGOAEKOGM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public NOKGHIEMFJK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7FC6BE0", Offset = "0x7FC5BE0", VA = "0x187FC6BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x7FC6D80", Offset = "0x7FC5D80", VA = "0x187FC6D80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct GIDBOCGCOIE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public KLFIFDMNKOJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7FC71D0", Offset = "0x7FC61D0", VA = "0x187FC71D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7FC7380", Offset = "0x7FC6380", VA = "0x187FC7380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct PBMJGAMMHDG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			public NOKGHIEMFJK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			private TaskAwaiter<NOFPJPODCJM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE630", Offset = "0x7FCD630", VA = "0x187FCE630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x7FCEA70", Offset = "0x7FCDA70", VA = "0x187FCEA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct OADBOJPELAM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public NOKGHIEMFJK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE1B0", Offset = "0x7FCD1B0", VA = "0x187FCE1B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE5D0", Offset = "0x7FCD5D0", VA = "0x187FCE5D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected const float CKMOIAJPLMM = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected const int CJFLHGPHDNO = 5;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private static readonly int GBCOGHHAFDP;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private static readonly int DBKHHIKEFFL;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private static readonly int GLMNIPGNFFL;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected static readonly Dictionary<FKJKGLGGLAF.KCPACIJMGPB, int> HNHMKCKFEOE;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> GHKIAHOCAFG;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected static readonly int CKPFPJEKNFJ;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected static readonly int AHHNINNIMMH;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected static readonly int AHCDAMGHFGJ;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected static readonly int KOGOMBDIAEN;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected static readonly int LHIMGEMDEAM;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected static Vector2 DHKFEHMOBFC;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected static Vector2 GMJNJHOKHOD;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected static Vector2 JGOPAPELJKH;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected static Vector2 FBJCAIFHDBF;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected static Vector2 IDOBLNGDPML;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected static Vector2 ABDHMGLNCCF;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected static Vector2 ICBCOFBEJDI;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected static Vector2 ONOAOCIJDLC;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected static Vector2 IPHPILDKOHP;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected static Vector2 EHKLAOJEIBK;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected static Vector2 EEMIHKFONNF;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected static Vector2 PIKFCHJPJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		[SerializeField]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private NOKGHIEMFJK ONBPNHHDMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private FaceStyleSet NAMCNDGLCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected const int HMHDJPABCHN = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected int FFKKNIJGLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected int MNDJJJBECNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected int AAAMHOEJKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected int FJGJPNODMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Vector2 PDKCAOGPBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected float OGBOLJMKOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected float PJDNEDAGABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected float MLIALNJCBJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected Vector2 ODGGNHFOKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected float BMHOPBMMMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected float LNOJEIMCAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected float OJJOKCEHCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Vector2 NOHCKNFMFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected float OAAKMFFGEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected float IMKBODGPJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected float HLJFFJALOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected Vector2 KCLIGEINECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected float PJFMFAPGKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected float PDINELNBOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected float MMLFENEGGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected List<SelectableFaceOption> EBDBMDNIPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected List<SelectableFaceOption> GMJGAKLHEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected List<SelectableFaceOption> BJEGFJJKNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected List<SelectableFaceOption> JBGPIKGPOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected Coroutine AHNGMJBJCIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		protected int? EOIDFFABNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected int LEEDAKIABGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected int GENMHBNBHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected int CAHNJCFBJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected int GOKNHDCCCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		protected Sprite DLJLCBAIALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		protected Sprite EECIFGHIGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		protected Sprite CCJADOLJJEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected Sprite IOFGBAJGPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected bool DCJFKAAGNNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		protected string DGGFCJJCAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected string MJNJOKMALFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected string KOBPDOCMGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected string HKKFOMAPFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		protected AvatarConfiguration NOCAFBHLAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		protected NOFPJPODCJM GFGAFNGKDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private readonly List<Material> DFFKILAEMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		protected KCLPKJACDBA CDEBHIIEJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		protected Dictionary<string, int> PHAKBJBMJII;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public FaceStyleSet AHLLHHNNLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x7FD5570", Offset = "0x7FD4570", VA = "0x187FD5570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool LIBBMOMCAPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xAFD940", Offset = "0xAFC940", VA = "0x180AFD940", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xE152C0", Offset = "0xE142C0", VA = "0x180E152C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool FEPEPJEDFHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool DEINDIFKPFN
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int PFFOIEDECKG
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x7FCF380", Offset = "0x7FCE380", VA = "0x187FCF380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer HFKLHCGKMGF
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool PCLPIAPHGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x26957B0", Offset = "0x26947B0", VA = "0x1826957B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x268EB00", Offset = "0x268DB00", VA = "0x18268EB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] JHPJMGIIPJE
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool KDKECHNODNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x7FD55C0", Offset = "0x7FD45C0", VA = "0x187FD55C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x7FD5780", Offset = "0x7FD4780", VA = "0x187FD5780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int GFAEOILEEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x7FD1BB0", Offset = "0x7FD0BB0", VA = "0x187FD1BB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int NCNCKPMDJON
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x7FCFFA0", Offset = "0x7FCEFA0", VA = "0x187FCFFA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float LDGKNCGFFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x7FD55A0", Offset = "0x7FD45A0", VA = "0x187FD55A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x7FD5760", Offset = "0x7FD4760", VA = "0x187FD5760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public PLOEHKAEILB NNOLPDMMCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xB23C90", Offset = "0xB22C90", VA = "0x180B23C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xB20180", Offset = "0xB1F180", VA = "0x180B20180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public NOFPJPODCJM NADCOGHBIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xB591C0", Offset = "0xB581C0", VA = "0x180B591C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x7FD56E0", Offset = "0x7FD46E0", VA = "0x187FD56E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption ECEGKAMMFPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xB2E090", Offset = "0xB2D090", VA = "0x180B2E090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xBBD930", Offset = "0xBBC930", VA = "0x180BBD930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected KCLPKJACDBA CJDFLFNKGMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x7FD0980", Offset = "0x7FCF980", VA = "0x187FD0980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action NPOKHBBLHBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x7FD54C0", Offset = "0x7FD44C0", VA = "0x187FD54C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x7FD5630", Offset = "0x7FD4630", VA = "0x187FD5630")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1CF0", Offset = "0x7FD0CF0", VA = "0x187FD1CF0")]
		public void LocalPlayEmote(FKJKGLGGLAF.KCPACIJMGPB HJCAOADMIPK, float NAHAEFCJPMI = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1500", Offset = "0x7FD0500", VA = "0x187FD1500")]
		public bool IsEmotePlaying(FKJKGLGGLAF.KCPACIJMGPB HJCAOADMIPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD33F0", Offset = "0x7FD23F0", VA = "0x187FD33F0")]
		public void SetIdleHappy(bool OJGPHLAECIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0DA0", Offset = "0x7FCFDA0", VA = "0x187FD0DA0")]
		protected void HBGNOAMBPEJ(bool CHHNADGILFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1DF0", Offset = "0x7FD0DF0", VA = "0x187FD1DF0")]
		protected void MKCMDGFNBBM(bool FMIAPFLLGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1C10", Offset = "0x7FD0C10", VA = "0x187FD1C10")]
		protected void LOFFONHIBOB(IJELGOILOGJ MOINPJHGPMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1C80", Offset = "0x7FD0C80", VA = "0x187FD1C80")]
		protected void LPIIMMPFDCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2AC0", Offset = "0x7FD1AC0", VA = "0x187FD2AC0")]
		public void PlayExpression(int ANMKNMJEJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7FD08C0", Offset = "0x7FCF8C0", VA = "0x187FD08C0")]
		protected void GGPPNBAOMHE(bool PPGDFNMJMBI, bool MELEFOHHKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0BE0", Offset = "0x7FCFBE0", VA = "0x187FD0BE0")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType DCHBLEHBBOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0FD0", Offset = "0x7FCFFD0", VA = "0x187FD0FD0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration NOCAFBHLAOD, NOKGHIEMFJK IEAPGKOBGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7FD31C0", Offset = "0x7FD21C0", VA = "0x187FD31C0")]
		[AsyncStateMachine(typeof(KNPKLMECOEM))]
		public Task SetFaceSettings(KLFIFDMNKOJ FMHHPPLDGPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3090", Offset = "0x7FD2090", VA = "0x187FD3090")]
		[AsyncStateMachine(typeof(AMPOLPKGCNC))]
		public Task SetFaceSettings(int CFEMLCKKIKB, int AOCLLIOIJDL, int MHAOEDNKFDH, int ELLMBJFMIGP, NOKGHIEMFJK IEAPGKOBGAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3470", Offset = "0x7FD2470", VA = "0x187FD3470")]
		[AsyncStateMachine(typeof(AOIGOAEKOGM))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType DCHBLEHBBOL, int HKIHAHKIIBC, NOKGHIEMFJK IEAPGKOBGAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0C20", Offset = "0x7FCFC20", VA = "0x187FD0C20")]
		protected void HBELDCOCMJF(FaceFeatureType DCHBLEHBBOL, AHAMFIMFGBH EEPCHHCKJOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF5B0", Offset = "0x7FCE5B0", VA = "0x187FCF5B0")]
		protected void CBPHIDIFMAI(FaceFeatureType DCHBLEHBBOL, int HKIHAHKIIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0A00", Offset = "0x7FCFA00", VA = "0x187FD0A00")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF060", Offset = "0x7FCE060", VA = "0x187FCF060")]
		[AsyncStateMachine(typeof(GIDBOCGCOIE))]
		protected Task AEFCMKFEDKE(KLFIFDMNKOJ FMHHPPLDGPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1620", Offset = "0x7FD0620", VA = "0x187FD1620")]
		protected void JLKLHFJNBLI(KLFIFDMNKOJ FMHHPPLDGPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD20D0", Offset = "0x7FD10D0", VA = "0x187FD20D0")]
		protected static void OAFKBPPEONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1920", Offset = "0x7FD0920", VA = "0x187FD1920")]
		private void KNKFMMFNMEA(bool DLCFINIGLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2270", Offset = "0x7FD1270", VA = "0x187FD2270")]
		protected void OBLKDJEGENF(FaceFeatureType DCHBLEHBBOL, Vector2 ALIGBGJLFCC, NOKGHIEMFJK IEAPGKOBGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2AE0", Offset = "0x7FD1AE0", VA = "0x187FD2AE0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType DCHBLEHBBOL, Vector2 ACIMPHABDNI, NOKGHIEMFJK IEAPGKOBGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0740", Offset = "0x7FCF740", VA = "0x187FD0740")]
		protected void GDNKJAHKPNI(FaceFeatureType DCHBLEHBBOL, float ONMACOBCPLG, NOKGHIEMFJK IEAPGKOBGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1F50", Offset = "0x7FD0F50", VA = "0x187FD1F50")]
		protected void MNJJAGCPDOC(FaceFeatureType DCHBLEHBBOL, float KDHLIJMPIFF, NOKGHIEMFJK IEAPGKOBGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0F00", Offset = "0x7FCFF00", VA = "0x187FD0F00")]
		protected void IIKHKIMCAPA(FaceFeatureType DCHBLEHBBOL, float ABEGKHABHKG, NOKGHIEMFJK IEAPGKOBGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2E70", Offset = "0x7FD1E70", VA = "0x187FD2E70")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType DCHBLEHBBOL, float DALLPDCFDHC, NOKGHIEMFJK IEAPGKOBGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0E20", Offset = "0x7FCFE20", VA = "0x187FD0E20")]
		[AsyncStateMachine(typeof(PBMJGAMMHDG))]
		protected Task HFFBGDLOLKN(NOKGHIEMFJK IEAPGKOBGAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7FD12F0", Offset = "0x7FD02F0", VA = "0x187FD12F0")]
		public void InitializeFaceFeatureStyleSet(NOKGHIEMFJK IEAPGKOBGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCFD10", Offset = "0x7FCED10", VA = "0x187FCFD10")]
		protected bool CKMDOFBPLCM(string OKKJHAFLOGD, [Out] int HLGKMAPOEBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF150", Offset = "0x7FCE150", VA = "0x187FCF150")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3580", Offset = "0x7FD2580", VA = "0x187FD3580", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD28B0", Offset = "0x7FD18B0", VA = "0x187FD28B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4570", Offset = "0x7FD3570", VA = "0x187FD4570")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF4B0", Offset = "0x7FCE4B0", VA = "0x187FCF4B0")]
		[AsyncStateMachine(typeof(OADBOJPELAM))]
		public Task BuildFaceStyleAsyncIfChanged(NOKGHIEMFJK IEAPGKOBGAD, bool LHLJLBIDLMJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3E80", Offset = "0x7FD2E80", VA = "0x187FD3E80")]
		public void UpdateFaceDisplays(bool JOEIBMGIFCH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0000", Offset = "0x7FCF000", VA = "0x187FD0000")]
		protected bool FHDONCFANJB(bool JOEIBMGIFCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3BE0", Offset = "0x7FD2BE0", VA = "0x187FD3BE0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD32B0", Offset = "0x7FD22B0", VA = "0x187FD32B0")]
		public void SetFaceSpriteIndices(string LCCIEKCGOAI, string BFLPBGMBODO, string GDIOICGDHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3590", Offset = "0x7FD2590", VA = "0x187FD3590")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD40A0", Offset = "0x7FD30A0", VA = "0x187FD40A0")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4290", Offset = "0x7FD3290", VA = "0x187FD4290")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF290", Offset = "0x7FCE290", VA = "0x187FCF290")]
		protected void BGJIHHOFKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2600", Offset = "0x7FD1600", VA = "0x187FD2600")]
		private void OIJHOBFMKNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7FCFDF0", Offset = "0x7FCEDF0", VA = "0x187FCFDF0")]
		private void CMAAOJFEOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5260", Offset = "0x7FD4260", VA = "0x187FD5260")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA8DCB0", Offset = "0xA8CCB0", VA = "0x180A8DCB0", Slot = "4")]
		private bool NGEOPDNHGCK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct JJOMNKGLJCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public string GHLJANJDNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public int CMGKJAEFCGA;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct AOFJGCKEEMC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x7FC69E0", Offset = "0x7FC59E0", VA = "0x187FC69E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct JMFHMLHOHEN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x7FC9930", Offset = "0x7FC8930", VA = "0x187FC9930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x7FC9E30", Offset = "0x7FC8E30", VA = "0x187FC9E30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public NOKGHIEMFJK avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public AGBKNCCKDNN useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public KCJIIMMAEMJ hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public JOFBOADHHGM HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private JKEEOANKNDN BAJGFICNNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private AnimatorOverrideController ECJCNFPPAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> MCDKJALFNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public readonly JJOMNKGLJCN[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public readonly (string, KMMCOCGLCJN)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		protected bool ELGBPIJDJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		protected Guid EILMHPLMLCE;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		protected static Guid KNEDEEILCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private DBKAMJMIKIH HJEEEMOLJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private PLOEHKAEILB AHPCMMKMHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private CJMKPNNMLPB BBGDFBJECFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private CJMKPNNMLPB EPCACKMHOLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private AdditionalHatData MBJDCBMONNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private readonly Dictionary<GameObject, GJDMPDNLENL> JLNIMBGGNMO;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<KNCMLMAEOOD> DBLPAHDLEFN
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x7FDA830", Offset = "0x7FD9830", VA = "0x187FDA830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x7FDAE70", Offset = "0x7FD9E70", VA = "0x187FDAE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool JHHBKDBHKIO
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x7FDA990", Offset = "0x7FD9990", VA = "0x187FDA990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool IIJMHJDJFAA
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x7FDA880", Offset = "0x7FD9880", VA = "0x187FDA880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase KDDEPKEJMCD
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xBB9A50", Offset = "0xBB8A50", VA = "0x180BB9A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid DGNILBOPAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x7FD6610", Offset = "0x7FD5610", VA = "0x187FD6610")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject, IJELGOILOGJ)[] BINNGBLENKC
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x7FDAAA0", Offset = "0x7FD9AA0", VA = "0x187FDAAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8560", Offset = "0x7FD7560", VA = "0x187FD8560")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD73D0", Offset = "0x7FD63D0", VA = "0x187FD73D0")]
		private IEnumerable<GameObject> LACEMALAEFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8A30", Offset = "0x7FD7A30", VA = "0x187FD8A30")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5E60", Offset = "0x7FD4E60", VA = "0x187FD5E60")]
		private void BGMMOFEDPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x14A3740", Offset = "0x14A2740", VA = "0x1814A3740")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6C40", Offset = "0x7FD5C40", VA = "0x187FD6C40")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8A40", Offset = "0x7FD7A40", VA = "0x187FD8A40")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8850", Offset = "0x7FD7850", VA = "0x187FD8850")]
		public void ShowPose(AnimationClip PDJEAGKDAOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8A00", Offset = "0x7FD7A00", VA = "0x187FD8A00")]
		public void ShowPose(string BNBKKLPKHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD86B0", Offset = "0x7FD76B0", VA = "0x187FD86B0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8570", Offset = "0x7FD7570", VA = "0x187FD8570")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9510", Offset = "0x7FD8510", VA = "0x187FD9510")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9360", Offset = "0x7FD8360", VA = "0x187FD9360")]
		public void UpdateFaceAndBodyShapes(bool LHLJLBIDLMJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9910", Offset = "0x7FD8910", VA = "0x187FD9910")]
		public void UpdateNoseShape(DJJBHOIMIGD GALKAIFGIIP, bool LHLJLBIDLMJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD98E0", Offset = "0x7FD88E0", VA = "0x187FD98E0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8190", Offset = "0x7FD7190", VA = "0x187FD8190", Slot = "4")]
		protected virtual void ODPNNFKGGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6700", Offset = "0x7FD5700", VA = "0x187FD6700", Slot = "5")]
		protected virtual void HEJNEMLMJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5A90", Offset = "0x7FD4A90", VA = "0x187FD5A90")]
		public void ApplyHatData(AdditionalHatData NHCOIPFGPGI, bool LNHMDKPCFJB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD58D0", Offset = "0x7FD48D0", VA = "0x187FD58D0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5DF0", Offset = "0x7FD4DF0", VA = "0x187FD5DF0")]
		public void ApplyHatUVOverride(Vector2 HAFKKIOBMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5D10", Offset = "0x7FD4D10", VA = "0x187FD5D10")]
		public void ApplyHatPositionAdjustment(Vector3 CEEJJHFJEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5D80", Offset = "0x7FD4D80", VA = "0x187FD5D80")]
		public void ApplyHatRotationAdjustment(Vector3 JILDCJFMJBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5F40", Offset = "0x7FD4F40", VA = "0x187FD5F40")]
		public HDBFLGDIIHB BuildAvatarItemSelection(GameObject HPAPCPMHCFK, NOKGHIEMFJK KAAFKPPFGAL, IJELGOILOGJ CEEJOHHKIKM)
		{
			return default(HDBFLGDIIHB);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5FE0", Offset = "0x7FD4FE0", VA = "0x187FD5FE0")]
		public void BuildAvatar(bool LHLJLBIDLMJ = false, bool LNHMDKPCFJB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8DA0", Offset = "0x7FD7DA0", VA = "0x187FD8DA0")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5A10", Offset = "0x7FD4A10", VA = "0x187FD5A10")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9730", Offset = "0x7FD8730", VA = "0x187FD9730")]
		public void UpdateHatAnchor(bool LNHMDKPCFJB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9460", Offset = "0x7FD8460", VA = "0x187FD9460")]
		[AsyncStateMachine(typeof(AOFJGCKEEMC))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8490", Offset = "0x7FD7490", VA = "0x187FD8490")]
		[AsyncStateMachine(typeof(JMFHMLHOHEN))]
		private Task PHDDNOALGGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6970", Offset = "0x7FD5970", VA = "0x187FD6970")]
		private void IOOPIICDHPP(FaceFeatureType HNLPFAFEGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7340", Offset = "0x7FD6340", VA = "0x187FD7340")]
		private void JEMJDCMMMBB(FaceFeatureType HNLPFAFEGCJ, [Out] float ILJKICJJGPG, [Out] float COOEFBNOHDF, [Out] float AJNABLFIHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9220", Offset = "0x7FD8220", VA = "0x187FD9220")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD95C0", Offset = "0x7FD85C0", VA = "0x187FD95C0")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7860", Offset = "0x7FD6860", VA = "0x187FD7860")]
		private void MBACGMPKMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		private void GBJKHOBFPKD(GJDMPDNLENL NDBLNNAFIKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		private void EBAKFLAMJKE(GJDMPDNLENL NDBLNNAFIKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7E30", Offset = "0x7FD6E30", VA = "0x187FD7E30")]
		private void NBKEINGBGKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD99A0", Offset = "0x7FD89A0", VA = "0x187FD99A0")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7D80", Offset = "0x7FD6D80", VA = "0x187FD7D80")]
		[CompilerGenerated]
		private HDBFLGDIIHB MHDEMEOOGMB((GameObject, IJELGOILOGJ) PEHHHALDMEL)
		{
			return default(HDBFLGDIIHB);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct HDBFLGDIIHB
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class PJLBGFOGLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PJLBGFOGLFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FCEB00", Offset = "0x7FCDB00", VA = "0x187FCEB00")]
		internal bool MJDPOJFKOIK(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private GJDMPDNLENL KCNDDJIOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private IJELGOILOGJ GCCHBPECDLM;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public GJDMPDNLENL FNKLCNBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public IJELGOILOGJ NCCGFBHCLAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xE50950", Offset = "0xE4F950", VA = "0x180E50950")]
		get
		{
			return default(IJELGOILOGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string HKANNBMMEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7FC7930", Offset = "0x7FC6930", VA = "0x187FC7930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool JLMEFDNMCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FC7A70", Offset = "0x7FC6A70", VA = "0x187FC7A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool HJGGODDJNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7FC7A20", Offset = "0x7FC6A20", VA = "0x187FC7A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x1A08DD0", Offset = "0x1A07DD0", VA = "0x181A08DD0")]
	public HDBFLGDIIHB(GJDMPDNLENL NDBLNNAFIKN, IJELGOILOGJ MOINPJHGPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7FC7860", Offset = "0x7FC6860", VA = "0x187FC7860")]
	public bool AGMDJJMOAJG(OutfitType MKMCALBODJF, IJELGOILOGJ BDBOKGEFDIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7FC7CB0", Offset = "0x7FC6CB0", VA = "0x187FC7CB0")]
	public bool PGCCLNGJEAG(OutfitType MKMCALBODJF, IJELGOILOGJ BDBOKGEFDIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7FC7AC0", Offset = "0x7FC6AC0", VA = "0x187FC7AC0")]
	public bool NEOODHGKPCK(HDBFLGDIIHB LAOMCCNMMNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class LCMHCFFPMGE
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class HOMJOAOGIAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HOMJOAOGIAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x7FC98B0", Offset = "0x7FC88B0", VA = "0x187FC98B0")]
		internal bool MJDPOJFKOIK(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private GJDMPDNLENL KCNDDJIOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private OOMOBMPOMPL GCCHBPECDLM;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GJDMPDNLENL FNKLCNBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public OOMOBMPOMPL NCCGFBHCLAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160")]
		get
		{
			return default(OOMOBMPOMPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Color CHNEPDKGONI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xE16CB0", Offset = "0xE15CB0", VA = "0x180E16CB0")]
		[CompilerGenerated]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xE16B30", Offset = "0xE15B30", VA = "0x180E16B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 FOJJHGMABOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xE4DFD0", Offset = "0xE4CFD0", VA = "0x180E4DFD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xE4E110", Offset = "0xE4D110", VA = "0x180E4E110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD9D0", Offset = "0x7FCC9D0", VA = "0x187FCD9D0")]
	public LCMHCFFPMGE(GJDMPDNLENL NDBLNNAFIKN, OOMOBMPOMPL MOINPJHGPMM, Color AHIICABHHJO, Vector3 KDHLIJMPIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD8A0", Offset = "0x7FCC8A0", VA = "0x187FCD8A0")]
	public bool NEOODHGKPCK(LCMHCFFPMGE LAOMCCNMMNN)
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
