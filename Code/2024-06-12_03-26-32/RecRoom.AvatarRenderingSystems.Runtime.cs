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
	public class LogRegistrationIndex : BOJNKDJNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x676A140", Offset = "0x6768D40", VA = "0x18676A140", Slot = "4")]
		public override void FHCDBNBHAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x843210", Offset = "0x841E10", VA = "0x180843210", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x67771D0", Offset = "0x6775DD0", VA = "0x1867771D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6777100", Offset = "0x6775D00", VA = "0x186777100", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6777190", Offset = "0x6775D90", VA = "0x186777190")]
		public RecNetCDNAssetReference(RecNetCDNKey DPHIOKCFMFC)
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
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6777210", Offset = "0x6775E10", VA = "0x186777210")]
		public static RecNetCDNKey AEBPAKBFPIG(string AOMMAPMHJKP, string INANJLGPBOI = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9ADD0", Offset = "0x5F999D0", VA = "0x185F9ADD0")]
		public void LAKJGPMMDAM(string KCNOPDDBKEJ, string LNMBFIMPMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67772A0", Offset = "0x6775EA0", VA = "0x1867772A0")]
		public RecNetCDNKey KCELPCBALNF(string FCGGPPHGGDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6777350", Offset = "0x6775F50", VA = "0x186777350")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[KPAMBFFNOBG]
public class EOPPMDLKMKC : BIBJCGEPPHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> OHLHNKHNNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> OKMILOPCEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> PEHLGDIFFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> JLDIOOHACHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> MJDDMLPOOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> KFNMEMGIFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> KKGPHLIDAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator PJCHMEHLCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected MCCPHDBNPAI EEAMMJMHDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte OFBNNABHBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> PDIPPBLGLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> APANGIBKLBJ;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6760920", Offset = "0x675F520", VA = "0x186760920", Slot = "4")]
	public void JBINENPFJDC(Mesh AIKMKIOPGIF, Matrix4x4 BFNNMDHBOEG, byte[] AFNAAHCEKJG, bool JFFBLBEENCM = false, OCPDNKAOFCI.LFAEFIBNIJB FMOIIHAOCMP = (OCPDNKAOFCI.LFAEFIBNIJB)0, int FLDKMDEHOEO = -1, bool NMINCIONGOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6760C30", Offset = "0x675F830", VA = "0x186760C30", Slot = "5")]
	public void JLCEACIPFON(Allocator BLMBIIGOJPG, MCCPHDBNPAI JGFOGMPNAFM, byte POKIPIOBFBK, [Optional] IList<int> BKANEMKBDCB, [Optional] IList<int> GIHIIOAJLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67607F0", Offset = "0x675F3F0", VA = "0x1867607F0")]
	private static void FIGNNHIFCBF(Mesh AIKMKIOPGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6760C70", Offset = "0x675F870", VA = "0x186760C70")]
	public EOPPMDLKMKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KPAMBFFNOBG]
public struct FAKDCNDKMBC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public JDHGBHFHNMM OBMNAEGOONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int CLOPHPCHNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public HAMLMGNLENK HHLLGNCEHGI;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6760EA0", Offset = "0x675FAA0", VA = "0x186760EA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[KPAMBFFNOBG]
[NativeContainer]
public struct HAMLMGNLENK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct IKAIFIPPFDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 NKMLCGFDPGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 KLEPCPADMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 GLLONGLNLBL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct KPKBMPNKPOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float GKDJAOLAOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float NKEICPOJEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float JCIALMDMMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float OCGFKDPHLNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte PNHHGELEHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte PADHEDLDAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte FKPIDAAJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte EOBIEINHKEA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct LOKDLFEMPNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half GKDJAOLAOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half NKEICPOJEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half JCIALMDMMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half OCGFKDPHLNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte PNHHGELEHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte PADHEDLDAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte FKPIDAAJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte EOBIEINHKEA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct DNAPKBGJJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 BFOBNFFGJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 EODKKGLEAGO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct NDGHGCNIELG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 BFOBNFFGJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 EODKKGLEAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 GFMEHICNLDP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct LHJGNENNLGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 BFOBNFFGJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 EODKKGLEAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 GFMEHICNLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 MEDMABIAEDG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HMMINLECEOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 BFOBNFFGJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 EODKKGLEAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 GFMEHICNLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 MEDMABIAEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 MIEOLMOMHCF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct FPCCGAGBDLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float GKDJAOLAOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float NKEICPOJEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float JCIALMDMMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float OCGFKDPHLNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int PNHHGELEHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int PADHEDLDAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int FKPIDAAJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int EOBIEINHKEA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct EGFPBEFKBAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color BFOBNFFGJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 EODKKGLEAGO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct DDGCOCHAJBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color BFOBNFFGJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 EODKKGLEAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 GFMEHICNLDP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct ELFPPBDLJFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color BFOBNFFGJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 EODKKGLEAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 GFMEHICNLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 MEDMABIAEDG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct HLBGCHEJHKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color BFOBNFFGJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 EODKKGLEAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 GFMEHICNLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 MEDMABIAEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 MIEOLMOMHCF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool GPHHLLKLLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<IKAIFIPPFDI> LCGBFNMKAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<DNAPKBGJJCO> HBMCFNOAMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<NDGHGCNIELG> MAJGLLJDAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<LHJGNENNLGK> EMHIEFOBJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<HMMINLECEOJ> IGDKKDEAOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<LOKDLFEMPNA> NDKLGEKFDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<KPKBMPNKPOM> CFJHENALMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<EGFPBEFKBAM> BMONDOCMFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<DDGCOCHAJBM> CIMJMHOFBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<ELFPPBDLJFM> IFFBCBGIOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<HLBGCHEJHKH> LLKFPGCKBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<FPCCGAGBDLL> KPKKBFFBANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> LOHDJLMMHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> BMBHLEJIMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> BMFMGKAIMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> LHGBGFJDFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> JCBGHBPFKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> KOPGHBMKNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> DAMEGLMPCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> MLLHNGGJHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> ENFOCCMDNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool PPNMMIMBKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool KLFALJOMPLF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AGAMJGOCDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6764CE0", Offset = "0x67638E0", VA = "0x186764CE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6764CF0", Offset = "0x67638F0", VA = "0x186764CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NABHMHPMAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6764BF0", Offset = "0x67637F0", VA = "0x186764BF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6763500", Offset = "0x6762100", VA = "0x186763500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CDJJFAHCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6764D00", Offset = "0x6763900", VA = "0x186764D00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6762D90", Offset = "0x6761990", VA = "0x186762D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int AOHECOPPKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6762E00", Offset = "0x6761A00", VA = "0x186762E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x67650C0", Offset = "0x6763CC0", VA = "0x1867650C0")]
	public HAMLMGNLENK(int IPFIILKFJCO, int DKOEAAGFEDL, int IHJDBGAGKMG, int OMIGHHHAPOG, Allocator BLMBIIGOJPG, int DDBIEIBFIEN, JEBGGKMIFPF NIDMJDOOPIH, bool PPNMMIMBKBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6764B60", Offset = "0x6763760", VA = "0x186764B60")]
	public void IHEGKBEHJLL(int OPDMGNJCACB, Vector3 BGNEHGMDHMD, Vector3 LGIJFEHDJIO, Vector4 NEAJEANMBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6762E70", Offset = "0x6761A70", VA = "0x186762E70")]
	public void DLEFLGOEJOI(int OPDMGNJCACB, BoneWeight FOFINEOPMHL, NativeSlice<byte> AFNAAHCEKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6764430", Offset = "0x6763030", VA = "0x186764430")]
	public Color HENAJEFMNII(int OPDMGNJCACB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6764760", Offset = "0x6763360", VA = "0x186764760")]
	public void IEOLCHODNIL(int OPDMGNJCACB, Color PIIKINJOJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6764D10", Offset = "0x6763910", VA = "0x186764D10")]
	public void OJPFCPLFMBI(byte PGFBBGLHBMF, int OPDMGNJCACB, Vector2 DMDMOCABFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6764CD0", Offset = "0x67638D0", VA = "0x186764CD0")]
	public void LOIDGJAFDFD(int OPDMGNJCACB, int DDCNOBKIDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6762DA0", Offset = "0x67619A0", VA = "0x186762DA0")]
	public bool BNECDJOCPCJ(int PGFBBGLHBMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6764C00", Offset = "0x6763800", VA = "0x186764C00")]
	public void LGKDIGCPADN(int AGAAAFAEGCB, int MANKJHLJMBO, int JKBHNDINMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67632A0", Offset = "0x6761EA0", VA = "0x1867632A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6763510", Offset = "0x6762110", VA = "0x186763510")]
	public Mesh GNMBBAGPOPA([Optional] string DPMDKEPNEIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
[KPAMBFFNOBG]
[NativeContainer]
public struct JDHGBHFHNMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray MDGNKGCGLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> DNFJMDFDJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> DOCEOGJCFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> MLLHNGGJHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> LIDFLMANAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> KEKAMPGOFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> CMABICPIEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> AGCOCFOBFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> PDIACHEEIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> BIADHEOPMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> PDEMPIICDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> NMINCIONGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> FLDKMDEHOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool PPNMMIMBKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> OLGMPBJIKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool KLFALJOMPLF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int ENFOLADMNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67668D0", Offset = "0x67654D0", VA = "0x1867668D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NHHLKBFEJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6766C50", Offset = "0x6765850", VA = "0x186766C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DDCMLFLPDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6766B40", Offset = "0x6765740", VA = "0x186766B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BEKNDGJLMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67667D0", Offset = "0x67653D0", VA = "0x1867667D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67668C0", Offset = "0x67654C0", VA = "0x1867668C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int AGAMJGOCDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6766C30", Offset = "0x6765830", VA = "0x186766C30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6766C40", Offset = "0x6765840", VA = "0x186766C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IEJJOCNBJJL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6766650", Offset = "0x6765250", VA = "0x186766650")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67667E0", Offset = "0x67653E0", VA = "0x1867667E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MCCPHDBNPAI DHODOMPICCB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6766C60", Offset = "0x6765860", VA = "0x186766C60")]
		get
		{
			return default(MCCPHDBNPAI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6766B30", Offset = "0x6765730", VA = "0x186766B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte NIADLJOAECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6766C10", Offset = "0x6765810", VA = "0x186766C10")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6766C20", Offset = "0x6765820", VA = "0x186766C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OBAGFBIIFDJ ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67668E0", Offset = "0x67654E0", VA = "0x1867668E0")]
		get
		{
			return default(OBAGFBIIFDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6766C70", Offset = "0x6765870", VA = "0x186766C70")]
	public JDHGBHFHNMM(IList<Mesh> ALHNEGKLCIP, IList<Matrix4x4> PGCPKEHGGDD, IList<bool> NMINCIONGOF, byte POKIPIOBFBK, IList<byte[]> HMONCEGAKFA, IList<int> IBDMGFEDJBL, IList<bool> IHGHCGCAKFE, IList<int> FLDKMDEHOEO, IList<int> BKANEMKBDCB, IList<int> DEKFHBLHEMJ, Allocator BLMBIIGOJPG, MCCPHDBNPAI JGFOGMPNAFM, bool PPNMMIMBKBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x67667F0", Offset = "0x67653F0", VA = "0x1867667F0")]
	public HAMLMGNLENK HAOIEFGOLPE(Allocator BLMBIIGOJPG, JEBGGKMIFPF NIDMJDOOPIH)
	{
		return default(HAMLMGNLENK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6766660", Offset = "0x6765260", VA = "0x186766660", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[KPAMBFFNOBG]
public class OJNDOBIPBJK : EOPPMDLKMKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool EPMPOPCOPAA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x676A1D0", Offset = "0x6768DD0", VA = "0x18676A1D0")]
	public JDHGBHFHNMM AHCKJECMKAI()
	{
		return default(JDHGBHFHNMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x676A2F0", Offset = "0x6768EF0", VA = "0x18676A2F0")]
	public OJNDOBIPBJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OBAGFBIIFDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Mesh.MeshData NBFNCKOKLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeSlice<BoneWeight> MLLHNGGJHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<byte> ANJMDDPIJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int APCLFENOJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Matrix4x4 FONOGAAMDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public int DMGDAAPIACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeSlice<byte> AFNAAHCEKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool GMIEHBNFPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int BCOGPKNCFFL;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PEFKMCHIDBK : KGCFGBIOMLM
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class HJJMICFLLCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly BHNAMMMFFGC DNOELALLCLL;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual bool LPNOGJMIMNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public virtual bool JAJNAODECLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public virtual OCPDNKAOFCI.LFAEFIBNIJB DMGDAAPIACK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "6")]
			get
			{
				return default(OCPDNKAOFCI.LFAEFIBNIJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool CHLMMIFICMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x14BF080", Offset = "0x14BDC80", VA = "0x1814BF080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool CGFOAKGJBID
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6766230", Offset = "0x6764E30", VA = "0x186766230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool KEEIBAMBIPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6766240", Offset = "0x6764E40", VA = "0x186766240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		protected HJJMICFLLCD(BHNAMMMFFGC OFHHCEHPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract CEIMLGOLMNM EGGFDJENMBE(int[] CJDJNAKDDPC, List<MFIADEKAGDN> ABFNBGGAKPF, List<MFIADEKAGDN> OHOGECJCIGJ);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract OLNGIDOLPIA ANCJFLKBBHB(uint ICDAEIIIEFB, AvatarSkinnedMeshBoneOrderRemapsData IPLDBICNJGM);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class HCDHJCDLCLC : HJJMICFLLCD
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class IBJANHLFMON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public OBOGMAPJNLF<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public HCDHJCDLCLC <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public IBJANHLFMON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6766260", Offset = "0x6764E60", VA = "0x186766260")]
			internal void HHAMAHHBJOO(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly AvatarSkinAssetItem.FJNNMOANEBC HIOMIMOCHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly AssetReference JKHBDABADEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly OCPDNKAOFCI.LFAEFIBNIJB OFLKHABPNDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly EPAIPDBBJOB? IHJHJKAINOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly Material[] AOBNDBBFJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private SkinnedMeshRenderer[] BDHAIHIJPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private AvatarSkinAssetItem PDKEDIIALPL;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override OCPDNKAOFCI.LFAEFIBNIJB DMGDAAPIACK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x844560", Offset = "0x843160", VA = "0x180844560", Slot = "6")]
			get
			{
				return default(OCPDNKAOFCI.LFAEFIBNIJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6766010", Offset = "0x6764C10", VA = "0x186766010")]
		public HCDHJCDLCLC(AvatarSkinAssetItem.FJNNMOANEBC JPIGKIJLPAF, AssetReference PHDEBLGIEOO, Material KPCFJBNHJEJ, BHNAMMMFFGC OIAOOOECAOK, OCPDNKAOFCI.LFAEFIBNIJB KMKMAOIGIDH = (OCPDNKAOFCI.LFAEFIBNIJB)0, [Optional] EPAIPDBBJOB? OPCBNACKJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6766120", Offset = "0x6764D20", VA = "0x186766120")]
		public HCDHJCDLCLC(AvatarSkinAssetItem.FJNNMOANEBC JPIGKIJLPAF, AssetReference PHDEBLGIEOO, Material KPCFJBNHJEJ, OCPDNKAOFCI.LFAEFIBNIJB KMKMAOIGIDH = (OCPDNKAOFCI.LFAEFIBNIJB)0, [Optional] EPAIPDBBJOB? OPCBNACKJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6765DD0", Offset = "0x67649D0", VA = "0x186765DD0", Slot = "7")]
		public override CEIMLGOLMNM EGGFDJENMBE(int[] CJDJNAKDDPC, List<MFIADEKAGDN> ABFNBGGAKPF, List<MFIADEKAGDN> OHOGECJCIGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6765AF0", Offset = "0x67646F0", VA = "0x186765AF0", Slot = "8")]
		public override OLNGIDOLPIA ANCJFLKBBHB(uint ICDAEIIIEFB, AvatarSkinnedMeshBoneOrderRemapsData IPLDBICNJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6765FA0", Offset = "0x6764BA0", VA = "0x186765FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class DCAAKBPCGNF : HJJMICFLLCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly MFEHKIDNCCC CGFCCCBENNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private OBOGMAPJNLF<ODEJKAFNGNC> MAMODHFMDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ODEJKAFNGNC KJNOMEPNNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private OBOGMAPJNLF<Material>[] HILNDMKAHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public List<Material> LDLCNKBBBPF;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool LPNOGJMIMNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool JAJNAODECLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x675FFA0", Offset = "0x675EBA0", VA = "0x18675FFA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F090", Offset = "0x1D0DC90", VA = "0x181D0F090")]
		public DCAAKBPCGNF(BHNAMMMFFGC OFHHCEHPAKH, MFEHKIDNCCC NGFMGONHAHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x675FA30", Offset = "0x675E630", VA = "0x18675FA30", Slot = "7")]
		public override CEIMLGOLMNM EGGFDJENMBE(int[] CJDJNAKDDPC, List<MFIADEKAGDN> ABFNBGGAKPF, List<MFIADEKAGDN> OHOGECJCIGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x675F760", Offset = "0x675E360", VA = "0x18675F760", Slot = "8")]
		public override OLNGIDOLPIA ANCJFLKBBHB(uint ICDAEIIIEFB, AvatarSkinnedMeshBoneOrderRemapsData IPLDBICNJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67604F0", Offset = "0x675F0F0", VA = "0x1867604F0")]
		public OLNGIDOLPIA MIBBHILEBDD(GameObject NFFIDCOMGHO, uint ICDAEIIIEFB, bool IMEILDICPHF, bool DEBOPCBOJPO, AvatarSkinnedMeshBoneOrderRemapsData IPLDBICNJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6760000", Offset = "0x675EC00", VA = "0x186760000")]
		public static bool HACIFMDFHHO(Renderer[] NIGOLCGOLGC, string MACKIIDFAPM, [Out] Renderer KGEOPNIGDFJ, [Out] Renderer MDEBDAIHNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x67606E0", Offset = "0x675F2E0", VA = "0x1867606E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x675F890", Offset = "0x675E490", VA = "0x18675F890")]
		private (OBOGMAPJNLF<ODEJKAFNGNC>, OBOGMAPJNLF<Material>[]) CFFJLJPLEJG()
		{
			return default((OBOGMAPJNLF<ODEJKAFNGNC>, OBOGMAPJNLF<Material>[]));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x67603D0", Offset = "0x675EFD0", VA = "0x1867603D0")]
		private OBOGMAPJNLF<Material>[] MBFLFNMENGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x422E5C0", Offset = "0x422D1C0", VA = "0x18422E5C0")]
		[CompilerGenerated]
		private void JNNPGGKBJII(ODEJKAFNGNC JFBAIGMLPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x675F630", Offset = "0x675E230", VA = "0x18675F630")]
		[CompilerGenerated]
		private void AECFDCEDGAL(OBOGMAPJNLF<Material> ALGCLKACMBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6760370", Offset = "0x675EF70", VA = "0x186760370")]
		[CompilerGenerated]
		private void IBHFFDKCBGP(Material JFBAIGMLPKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PIDNKHHMHAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public PEFKMCHIDBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public LKPPGGKMHON buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public PIDNKHHMHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6776FA0", Offset = "0x6775BA0", VA = "0x186776FA0")]
		internal void AFGONFDHFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6777050", Offset = "0x6775C50", VA = "0x186777050")]
		internal void KGNIJGLDIOP(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6776FC0", Offset = "0x6775BC0", VA = "0x186776FC0")]
		internal void HLGJNOLABLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6777070", Offset = "0x6775C70", VA = "0x186777070")]
		internal void LIPIJOHDJLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		internal CEIMLGOLMNM FOCFKDNCLKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DLCKKCAMFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public PIDNKHHMHAA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public DLCKKCAMFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6760730", Offset = "0x675F330", VA = "0x186760730")]
		internal KGPEDFBHKEI FKKKEHNMMID(int lod)
		{
			return default(KGPEDFBHKEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CHBGCCEMOBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<LKPPGGKMHON> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CHBGCCEMOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x675F4B0", Offset = "0x675E0B0", VA = "0x18675F4B0")]
		internal void AMKNDABDOBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BANDKPFEFLH : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public PEFKMCHIDBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<HJJMICFLLCD> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public List<LKPPGGKMHON> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Func<int, KGPEDFBHKEI> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NGCBEGIHFDJ materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public BANDKPFEFLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x675F010", Offset = "0x675DC10", VA = "0x18675F010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x675F220", Offset = "0x675DE20", VA = "0x18675F220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CIKJJNKKJOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public PEFKMCHIDBK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CIKJJNKKJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x675F5E0", Offset = "0x675E1E0", VA = "0x18675F5E0")]
		internal CEIMLGOLMNM KJIMLBPGHFD(HJJMICFLLCD p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ABJCKMCNBEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public DHGFLENDOMM cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ABJCKMCNBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x966180", Offset = "0x964D80", VA = "0x180966180")]
		internal void OAONKNMNBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA1F010", Offset = "0xA1DC10", VA = "0x180A1F010")]
		internal void OMBGKFGCHHK(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ICNKOOJDLGL
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
		public PEFKMCHIDBK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ICNKOOJDLGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class BIOBGFHOOIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public HAMLMGNLENK defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JDHGBHFHNMM defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public ICNKOOJDLGL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BIOBGFHOOIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x675F270", Offset = "0x675DE70", VA = "0x18675F270")]
		internal void PLIJBBIBNAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA19860", Offset = "0xA18460", VA = "0x180A19860")]
		internal void DJAKBJANFNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class JDKCBIDPHNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public LOBKMOBONGL legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JIAECBCDBFM legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public ICNKOOJDLGL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JDKCBIDPHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6767EE0", Offset = "0x6766AE0", VA = "0x186767EE0")]
		internal void KHGIBMEADBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA1FA30", Offset = "0xA1E630", VA = "0x180A1FA30")]
		internal void IOIDBANLOMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class GNHMOCBJJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public DHGFLENDOMM cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public MFEHKIDNCCC avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public PEFKMCHIDBK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public GNHMOCBJJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x67629A0", Offset = "0x67615A0", VA = "0x1867629A0")]
		internal CEIMLGOLMNM BJIAJELNDKM(CHECCMHAHDJ item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6762D50", Offset = "0x6761950", VA = "0x186762D50")]
		internal void DIBBJDPKBMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FMHIFIKPHAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public OBOGMAPJNLF<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public FMHIFIKPHAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6762950", Offset = "0x6761550", VA = "0x186762950")]
		internal void NHENDGKLHJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class LFLIGPJDDOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public BHNAMMMFFGC overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LFLIGPJDDOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x676A0C0", Offset = "0x6768CC0", VA = "0x18676A0C0")]
		internal bool DEPEEFELPML(KeyValuePair<string, MFEHKIDNCCC> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AvatarConfiguration LKNNBHJCOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Transform DIDEPPMABGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private AssetReference JKHBDABADEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private GameObject HKJECMIBDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject NAHNPOKPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private SkinnedMeshRenderer GBGKLBHHGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private AvatarSkinnedMeshBoneOrderRemapsData EPADEOBIJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Transform[] EEBCENKEMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Matrix4x4[] BEDGOGPAIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Material PMBGBMLFLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material OCHNHCHKEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material DCBBMGLAIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Shader PDAKEBNEFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader PHOKCEFFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Animator GCKDCKDBPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Renderer[] KBOOOGFHLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private OCPDNKAOFCI.LFAEFIBNIJB MFIOANFDFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private AvatarBodyPartShapesManager HKKOGFGMOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IReadOnlyDictionary<string, Transform> HLJDPNNNIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private AvatarFaceShapeData.GBHONPHPKHH MGBOJDAEFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarBodyShapeData.LDEABGDMDAI KIHIIPLPPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool HLDBEIFAJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool DEPDLLADCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Color OJMKDDAILJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color NGKGLKNMNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color GBLDMAOFJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color? BPGOEGADKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? NEBCEKIBJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? MJDENLFAEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? HJDDKNDBFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Texture2D NMDACNDPJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D BFNEOPDFCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[CanBeNull]
	private MFEHKIDNCCC GIPJOLIOCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Texture CGJMGKBDBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Color FMGMEJOCANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Dictionary<Renderer, NGCBEGIHFDJ> JJKFHOHMEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Dictionary<Renderer, NGCBEGIHFDJ> JCOLHEDBOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<string, List<ENGBGEDJDLP>> JEMBNFCKNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<ENGBGEDJDLP>> LMFCLJKLOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly List<MFIADEKAGDN> CPKLGNJANKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<MFIADEKAGDN> KLNKOCOEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<MFIADEKAGDN> PNJAOLJNIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<MFIADEKAGDN> KAEGHHHGBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Dictionary<ENGBGEDJDLP, Material> JEHDAOIOGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<ENGBGEDJDLP, Material> JGFDLMAINIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private SkinnedMeshRenderer[] AFLCMEPMLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] BAMDOGKPCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] HOGEBNLIFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] DBCMMCPKNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly Dictionary<string, OBOGMAPJNLF<Texture2D>> MEONLMKGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, OBOGMAPJNLF<Texture2D>> FNKKDHCIMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private FitMeshHemisphere GJBKJBDNOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool HLJPLDEACPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private POPGKCADAAO CCOMIIGGPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool NIGJMDHPAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private AnchorParamsRestrictions AFENAHMEIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool LMGJFMOEPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Transform DCLFHAJLOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Transform MDDPCECKEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool AHMFOGKPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool HIANGACEGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Vector3 HJBNAOOGEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Quaternion NKCGPFONFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Vector2 HKLFIPGPGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private FitMeshHemisphere NJLHJNHCBIA;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Material MPIJNNMDFHO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material LGHAJBAAFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Dictionary<string, MFEHKIDNCCC> JJPIICIHBGL;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int KPOPCNGJBAK;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int LKEDEPJDEAG;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int BMEJNEMOMIC;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int CODBBEIODLA;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int BLNJNIGCDIH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int FLDAFBIJMIF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int MIEAJMNLOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly DEHOLECDIJP AEGMCEKFEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly DEHOLECDIJP GCBIGPNAFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool ABEPJKBNIDE;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static Lazy<PPMGCPLFFBF> OCAEHFEFMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Lazy<FHKLFIOGDLB> OGGAJCGBLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Lazy<OMKKDGMGOAD> DDEONLHCOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private GKDHMMKGFLI HBOEHMOCMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private NJPLNDPCKFC ONPCOFJINDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private List<Action> MFKAIPPGGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private HODPMKGAFIK PJGEKHFDNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private SkinnedMeshRenderer[] HDPOFCBBPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int NDAMBOIBFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool LGHJDPNFCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int LBHCOFMHGIB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KMLAKDPIJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6773B70", Offset = "0x6772770", VA = "0x186773B70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x676FC30", Offset = "0x676E830", VA = "0x18676FC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EBNKHLIPPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xE17220", Offset = "0xE15E20", VA = "0x180E17220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material AJHCCEEBMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x676F640", Offset = "0x676E240", VA = "0x18676F640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material OALPDPGBPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x676A300", Offset = "0x6768F00", VA = "0x18676A300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool PGOKKBJPDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool OEAKEPEGBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6773750", Offset = "0x6772350", VA = "0x186773750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private static PPMGCPLFFBF FCLIIADOKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x67736D0", Offset = "0x67722D0", VA = "0x1867736D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private FHKLFIOGDLB DGKMJGMOFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6776280", Offset = "0x6774E80", VA = "0x186776280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private OMKKDGMGOAD CMJEOBEADCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x676A5F0", Offset = "0x67691F0", VA = "0x18676A5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private GKDHMMKGFLI MPAGJNLPKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x676D910", Offset = "0x676C510", VA = "0x18676D910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private NJPLNDPCKFC IELMIEHDDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x676FAC0", Offset = "0x676E6C0", VA = "0x18676FAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public DEHOLECDIJP NOHCCMKKGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F84E0", Offset = "0x9F70E0", VA = "0x1809F84E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public DEHOLECDIJP NLHDNNGABLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x13B6DA0", Offset = "0x13B59A0", VA = "0x1813B6DA0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public SkinnedMeshRenderer[] OPPKFAJIIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAE56A0", Offset = "0xAE42A0", VA = "0x180AE56A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Renderer[] CHHJIHOENPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8514C0", Offset = "0x8500C0", VA = "0x1808514C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool MNFENPNKLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x676A3F0", Offset = "0x6768FF0", VA = "0x18676A3F0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public OCPDNKAOFCI.LFAEFIBNIJB KECNMNAAOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x851570", Offset = "0x850170", VA = "0x180851570", Slot = "18")]
		get
		{
			return default(OCPDNKAOFCI.LFAEFIBNIJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MHANIEFHPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6773890", Offset = "0x6772490", VA = "0x186773890")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x676FAA0", Offset = "0x676E6A0", VA = "0x18676FAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool GMNAFGLIMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x676F1F0", Offset = "0x676DDF0", VA = "0x18676F1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private static bool MJJBHNOIILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x676B520", Offset = "0x676A120", VA = "0x18676B520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool JJNKDAIMOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x676C040", Offset = "0x676AC40", VA = "0x18676C040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6776680", Offset = "0x6775280", VA = "0x186776680")]
	public PEFKMCHIDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x676CF60", Offset = "0x676BB60", VA = "0x18676CF60", Slot = "25")]
	public void EHHLDMLDHNI(MFBFMPCFHEP EHIFJPDMNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6776130", Offset = "0x6774D30", VA = "0x186776130", Slot = "26")]
	public void PCMIJKJGMKN(AIOPABHBAFF KIACKHPCODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x676FAA0", Offset = "0x676E6A0", VA = "0x18676FAA0", Slot = "4")]
	public void IAMFLEAJEGI(int ICDAEIIIEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x676E270", Offset = "0x676CE70", VA = "0x18676E270", Slot = "9")]
	public void FLPJEJPBKHI(NHJHPLIGHLG BFCBFHPBNPC, Texture2D BHCOMKIMBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x676B6C0", Offset = "0x676A2C0", VA = "0x18676B6C0", Slot = "10")]
	public void CJCKOJMAGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x676F070", Offset = "0x676DC70", VA = "0x18676F070", Slot = "11")]
	public bool GNGLEJIHEIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x676E640", Offset = "0x676D240", VA = "0x18676E640", Slot = "8")]
	public void GGGABEBBIIM(CIEBJCCMIDM BBCIHDOOABK, Color? BFOBNFFGJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6772FE0", Offset = "0x6771BE0", VA = "0x186772FE0")]
	private void MPIHCEPMPJO(Action MJNCMDOOBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x676CE40", Offset = "0x676BA40", VA = "0x18676CE40", Slot = "5")]
	public void EBDKLJIGGBN(MFEHKIDNCCC IDMBCLCJJDG, Texture NFFCOFBIMBF, Color DIBHFPHAFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x676FC30", Offset = "0x676E830", VA = "0x18676FC30", Slot = "6")]
	public void JNIIAGIAAIN(bool FALJPJAOMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x12BCC40", Offset = "0x12BB840", VA = "0x1812BCC40", Slot = "7")]
	public void LJFMHONDGLD(HODPMKGAFIK ENFOCCMDNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6770AA0", Offset = "0x676F6A0", VA = "0x186770AA0", Slot = "14")]
	public LKPPGGKMHON JKBEBDFBCAP(EFHJEIJOCLJ LGENPFJKJEI, bool OJJNILOBLLL, int[] PCABKCPKGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x676CA20", Offset = "0x676B620", VA = "0x18676CA20", Slot = "15")]
	public void DKIOIKPIJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x676F960", Offset = "0x676E560", VA = "0x18676F960")]
	private bool HLFMCCHCCOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x851620", Offset = "0x850220", VA = "0x180851620", Slot = "19")]
	public void NLPCJIAMNFD(OCPDNKAOFCI.LFAEFIBNIJB NHDPMPABJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x676F270", Offset = "0x676DE70", VA = "0x18676F270")]
	private bool GPLEGFBDFHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x676A640", Offset = "0x6769240", VA = "0x18676A640")]
	private LKPPGGKMHON APGCBLDOJFK(bool OJJNILOBLLL, List<HJJMICFLLCD> CIHDNBNGAMP, int[] PCABKCPKGJO, Func<int, KGPEDFBHKEI> JCJKJOJLKCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6772750", Offset = "0x6771350", VA = "0x186772750")]
	[IteratorStateMachine(typeof(BANDKPFEFLH))]
	private IEnumerator<OGKGDFEHPGC> KDPKFCECNGI(bool OJJNILOBLLL, List<HJJMICFLLCD> CIHDNBNGAMP, int[] PCABKCPKGJO, Func<int, KGPEDFBHKEI> JCJKJOJLKCC, NGCBEGIHFDJ ICHMEBAABDJ, Material JGJJMCPJOJF, List<LKPPGGKMHON> PHMDOMHFLLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67707E0", Offset = "0x676F3E0", VA = "0x1867707E0")]
	private LKPPGGKMHON JJIKCLPAIOI(List<HJJMICFLLCD> CIHDNBNGAMP, int[] PCABKCPKGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6773B80", Offset = "0x6772780", VA = "0x186773B80")]
	private GNHKJFLENJL ONNIPFFIFPL(List<HJJMICFLLCD> CIHDNBNGAMP, int ICDAEIIIEFB, bool OJJNILOBLLL, KGPEDFBHKEI IGOCEJPANBF, bool KDDKFNPOBNK, NGCBEGIHFDJ ICHMEBAABDJ, Material JGJJMCPJOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x676B170", Offset = "0x6769D70", VA = "0x18676B170", Slot = "21")]
	public void BIEOJFMLHIH(AvatarFaceShape AEGMFFKJOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x676D850", Offset = "0x676C450", VA = "0x18676D850", Slot = "22")]
	public void EJKDICIHAOF(AvatarBodyShape IOMBKHDAGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x676BD30", Offset = "0x676A930", VA = "0x18676BD30", Slot = "24")]
	public void CLIMOPEICDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6772FD0", Offset = "0x6771BD0", VA = "0x186772FD0", Slot = "23")]
	public void MOFMIAOIJAM(bool FNHMFMANADE, bool ALKMHPPBACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6770690", Offset = "0x676F290", VA = "0x186770690")]
	private void JHAKABDKCLK(SkinnedMeshRenderer AFMHDJMADPF, int ICDAEIIIEFB, Mesh AIKMKIOPGIF, List<Material> JNPOHJPFBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x67762D0", Offset = "0x6774ED0", VA = "0x1867762D0")]
	private static Material POHIENPKGJP(Dictionary<ENGBGEDJDLP, Material> KGCLCIJIJBL, Material DDDBCHKKFIN, PJCPHABLHKP HMOFJCGFIFP, EAOGGLFPFIF JDPJJJHGHPJ, BHNAMMMFFGC OIAOOOECAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x676EA40", Offset = "0x676D640", VA = "0x18676EA40")]
	private static PJCPHABLHKP GGIHDAHNLAC(HJJMICFLLCD HFEEPEOJOBL, int DEIFEGINCOO)
	{
		return default(PJCPHABLHKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x676D990", Offset = "0x676C590", VA = "0x18676D990")]
	private void EPHCGJNIKLF(int BOAHGJOJALD, Material MBCOMNNFJFG, HJJMICFLLCD HFEEPEOJOBL, [Out] Texture2D IAHDHANFEBM, [Out] Vector4 HCBOJFLPHDA, [Out] Texture2D GFMKEKLNEAP, [Out] Texture2D FGIDINHANCK, [Out] Texture2D GMIIEJFBFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x676C520", Offset = "0x676B120", VA = "0x18676C520")]
	private void DJDCEFCGKEH(int BOAHGJOJALD, Material MBCOMNNFJFG, HJJMICFLLCD HFEEPEOJOBL, [Out] Color CLJELFDEHHE, [Out] Color LLNEFDINILF, [Out] Color CHECCABIMEA, [Out] Color LOAOOLKLPCL, [Out] Color BHCFKONNFOC, [Out] Color IPOAGAKBJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x676AF10", Offset = "0x6769B10", VA = "0x18676AF10")]
	private bool BEGGCGLIBCP(Material MBCOMNNFJFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6773650", Offset = "0x6772250", VA = "0x186773650")]
	private static Material NLFLMNILCHM(int BOAHGJOJALD, DCAAKBPCGNF HFEEPEOJOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x676F870", Offset = "0x676E470", VA = "0x18676F870")]
	private static EAOGGLFPFIF HKGFDHIEBLD(HJJMICFLLCD HFEEPEOJOBL, int DEIFEGINCOO)
	{
		return default(EAOGGLFPFIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x676D560", Offset = "0x676C160", VA = "0x18676D560")]
	private static void EJFFAIBIFLH(Dictionary<string, List<ENGBGEDJDLP>> KIGGFALNMEA, HJJMICFLLCD JCDONKDHICC, Material DDDBCHKKFIN, PJCPHABLHKP BBCIHDOOABK, EAOGGLFPFIF BFCBFHPBNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x676FD30", Offset = "0x676E930", VA = "0x18676FD30")]
	private static SkinnedMeshRenderer IPLPFGKEEOK(Transform JMMPGIALLAH, Transform JGLCLEHJEBL, SkinnedMeshRenderer[] NIGOLCGOLGC, int ICDAEIIIEFB, KGPEDFBHKEI IGOCEJPANBF, bool OJJNILOBLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x676C320", Offset = "0x676AF20", VA = "0x18676C320")]
	private void DGIEGGGPFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6772680", Offset = "0x6771280", VA = "0x186772680")]
	private void JPEJBEGEHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x676F3C0", Offset = "0x676DFC0", VA = "0x18676F3C0")]
	private static void HDHBNMKEFOI(Dictionary<ENGBGEDJDLP, Material> KGCLCIJIJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x676B230", Offset = "0x6769E30", VA = "0x18676B230")]
	private static void BJFDPEKNMNO(Dictionary<Renderer, NGCBEGIHFDJ> HODGFAPDKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x676F520", Offset = "0x676E120", VA = "0x18676F520")]
	private void HFMAKPJOFHA(SkinnedMeshRenderer[] NIGOLCGOLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6772CC0", Offset = "0x67718C0", VA = "0x186772CC0")]
	private void LHDPKCHIOPN(SkinnedMeshRenderer OLCDJHGFCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x676AC40", Offset = "0x6769840", VA = "0x18676AC40")]
	private void BALNEBEJCAK(List<MFIADEKAGDN> DIBIGLDPFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x676EB90", Offset = "0x676D790", VA = "0x18676EB90")]
	private void GGPJFLJAIHA(Dictionary<string, OBOGMAPJNLF<Texture2D>> KIGGFALNMEA, bool OHGPCMBFDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6773600", Offset = "0x6772200", VA = "0x186773600")]
	private void NJPHKLPIMOH(Dictionary<string, List<ENGBGEDJDLP>> KIGGFALNMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x67734A0", Offset = "0x67720A0", VA = "0x1867734A0")]
	private void NJBBLJHIAEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x676CC20", Offset = "0x676B820", VA = "0x18676CC20")]
	private void DLOKDKKIMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67720C0", Offset = "0x6770CC0", VA = "0x1867720C0")]
	private void JLKLOJLKIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6773AA0", Offset = "0x67726A0", VA = "0x186773AA0")]
	private void OKCLBODJICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x676CEB0", Offset = "0x676BAB0", VA = "0x18676CEB0")]
	private void EEOKHONMILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6772DF0", Offset = "0x67719F0", VA = "0x186772DF0")]
	private void MNDHEGPJJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x676C250", Offset = "0x676AE50", VA = "0x18676C250")]
	private void DFGCLPIMONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6773060", Offset = "0x6771C60", VA = "0x186773060")]
	private void NAFDPDCNMKD(bool LOPDPIBPJJG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x67761B0", Offset = "0x6774DB0", VA = "0x1867761B0")]
	private void PEGAAAANLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x676F7D0", Offset = "0x676E3D0", VA = "0x18676F7D0")]
	private void HJPPPEMGPIA(bool LOPDPIBPJJG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x676D220", Offset = "0x676BE20", VA = "0x18676D220")]
	private void EHPGABOEIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x67702F0", Offset = "0x676EEF0", VA = "0x1867702F0")]
	private void JDMJJHGIOEK(Material JGJJMCPJOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x676FB40", Offset = "0x676E740", VA = "0x18676FB40")]
	private void IJDABOFCJID(Material JGJJMCPJOJF, Color LLNEFDINILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6772980", Offset = "0x6771580", VA = "0x186772980")]
	private void KPALOGDIHJB(Material JGJJMCPJOJF, Color CHECCABIMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x676BF50", Offset = "0x676AB50", VA = "0x18676BF50")]
	private void CLJFOIMBCOH(Material JGJJMCPJOJF, Color CLJELFDEHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x676AE20", Offset = "0x6769A20", VA = "0x18676AE20")]
	private void BCNMMJBDBCK(Material JGJJMCPJOJF, Texture2D BHCOMKIMBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x676FC40", Offset = "0x676E840", VA = "0x18676FC40")]
	private void IPLANBDAMKC(Material JGJJMCPJOJF, Texture GEKAKKKCDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6772B00", Offset = "0x6771700", VA = "0x186772B00")]
	private void LEKJKLAHEJP(Action<NGCBEGIHFDJ> IKCFLMNGNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x67738A0", Offset = "0x67724A0", VA = "0x1867738A0")]
	private void OGOLPOAAHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x676ED10", Offset = "0x676D910", VA = "0x18676ED10")]
	private void GIBIDPINIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x676B740", Offset = "0x676A340", VA = "0x18676B740")]
	private LKPPGGKMHON CKHAELHCBKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x676DDD0", Offset = "0x676C9D0", VA = "0x18676DDD0")]
	private void FDBOMJAGDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x676FF60", Offset = "0x676EB60", VA = "0x18676FF60")]
	public void JBHGMKAMIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6772610", Offset = "0x6771210", VA = "0x186772610")]
	private void JNGHIICLOGB(Vector3 KJEIHCPEBJE, Quaternion INEDIBJAGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6773100", Offset = "0x6771D00", VA = "0x186773100")]
	private void NDOGLLLIODA(List<HJJMICFLLCD> BHBIKLPOEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x67755B0", Offset = "0x67741B0", VA = "0x1867755B0")]
	public void OOMEDGOMMMB(POPGKCADAAO GCKGMGDPIEL, bool HEBIKNLKADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6775AB0", Offset = "0x67746B0", VA = "0x186775AB0")]
	public void OOMEDGOMMMB(POPGKCADAAO GCKGMGDPIEL, AnchorParamsRestrictions PGFOPOKNAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9E7CC0", Offset = "0x9E68C0", VA = "0x1809E7CC0")]
	private static void JPBPBOKDNLL(FitMeshHemisphere JIGILGLFCAE, Transform ALJLNOHKIKA, POPGKCADAAO GCKGMGDPIEL, AnchorParamsRestrictions PECIAINNINA, [Out] Vector3 FKKCBKBCNEL, [Out] Quaternion MFHPKPAOAAP, [Out] POPGKCADAAO BNMABEBPDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x676E480", Offset = "0x676D080", VA = "0x18676E480")]
	public void GBFNHLHPDGG(Vector2 OCHOKIJKHFP, Vector3 DCGPCGKMAGD, Vector3 PJBOJGIPEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x676B390", Offset = "0x6769F90", VA = "0x18676B390")]
	private void BLLBJNENAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x676F330", Offset = "0x676DF30", VA = "0x18676F330")]
	private void HBICMIAIFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6772F40", Offset = "0x6771B40", VA = "0x186772F40")]
	[CompilerGenerated]
	private void MNKMCAHKFIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6770660", Offset = "0x676F260", VA = "0x186770660")]
	[CompilerGenerated]
	private void JFDMFFOBFLE(NGCBEGIHFDJ MLIKIKJHJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x676E1B0", Offset = "0x676CDB0", VA = "0x18676E1B0")]
	[CompilerGenerated]
	private void FFPEOLMPONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x676CF40", Offset = "0x676BB40", VA = "0x18676CF40")]
	[CompilerGenerated]
	private void EFEEFBBAHJO(NGCBEGIHFDJ MLIKIKJHJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67726C0", Offset = "0x67712C0", VA = "0x1867726C0")]
	[CompilerGenerated]
	private void KBCGLJFDNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x676B500", Offset = "0x676A100", VA = "0x18676B500")]
	[CompilerGenerated]
	private void BMJEBIPELLM(NGCBEGIHFDJ MLIKIKJHJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6772860", Offset = "0x6771460", VA = "0x186772860")]
	[CompilerGenerated]
	private void KEGNMNMKPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6772690", Offset = "0x6771290", VA = "0x186772690")]
	[CompilerGenerated]
	private void KANNPIPCCEP(NGCBEGIHFDJ MLIKIKJHJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6772D60", Offset = "0x6771960", VA = "0x186772D60")]
	[CompilerGenerated]
	private void MIPODFIJIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x676EB60", Offset = "0x676D760", VA = "0x18676EB60")]
	[CompilerGenerated]
	private void GGJBJIMNDBN(NGCBEGIHFDJ MLIKIKJHJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6772A70", Offset = "0x6771670", VA = "0x186772A70")]
	[CompilerGenerated]
	private void LBNDPOELNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x676C4F0", Offset = "0x676B0F0", VA = "0x18676C4F0")]
	[CompilerGenerated]
	private void DIDDOMJPHHG(NGCBEGIHFDJ MLIKIKJHJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x676CDB0", Offset = "0x676B9B0", VA = "0x18676CDB0")]
	[CompilerGenerated]
	private void DMKONIBIAEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x676E240", Offset = "0x676CE40", VA = "0x18676E240")]
	[CompilerGenerated]
	private void FLOCNHDMPGN(NGCBEGIHFDJ MLIKIKJHJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6773A20", Offset = "0x6772620", VA = "0x186773A20")]
	[CompilerGenerated]
	private void OHIODNOOBMJ(KeyValuePair<string, OBOGMAPJNLF<Texture2D>> IJFLOGOPBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x67728F0", Offset = "0x67714F0", VA = "0x1867728F0")]
	[CompilerGenerated]
	private void KKBMJEHEGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x676E180", Offset = "0x676CD80", VA = "0x18676E180")]
	[CompilerGenerated]
	private void FDJIDIKBKBN(NGCBEGIHFDJ MLIKIKJHJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x676A560", Offset = "0x6769160", VA = "0x18676A560")]
	[CompilerGenerated]
	private void ALCOGMMHKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x676AC10", Offset = "0x6769810", VA = "0x18676AC10")]
	[CompilerGenerated]
	private void APNGDIHOGAJ(NGCBEGIHFDJ MLIKIKJHJNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JKOJGCHGPBC : OGDFMPCHDJF
{
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int NJFBHGIHLNH;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int BNILIIAFANN;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int EAGFEBGBKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int LINNHCBNGPL;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int HIMNIDFOKJN;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int PIKGPIEPDFH;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int CNCDOFDJBOC;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int NKAJOOPIBGB;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int JEAMBPGNAKL;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int BPKBDHNLJID;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int MBOLGLDGBKL;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int AIPFJFFINDN;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int HCNGINBKHKI;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int HJFJMBDAFEM;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int LACONGFBHKI;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int AMHCJODJIDB;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int LBEEJJIAFAM;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int KGHFABENBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform KMNLIPIHDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform NPLGPAJMPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform EJNGEIKAAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform DLNKEHEGJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform NLJAOBEFBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform GBEFECDJJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Transform BKHEEIAPILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private POJPECEJPPN DGJAIHMIDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private MaterialPropertyBlock IOBHHJNJCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private SkinnedMeshRenderer[] LLCJDFOJJPO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private MaterialPropertyBlock LDOHCMNEMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x67699B0", Offset = "0x67685B0", VA = "0x1867699B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6769AC0", Offset = "0x67686C0", VA = "0x186769AC0", Slot = "6")]
	public void EHHLDMLDHNI(POJPECEJPPN GGJNJHCJHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6769BC0", Offset = "0x67687C0", VA = "0x186769BC0", Slot = "7")]
	public void ICMGJFMMHLN(OOHMCNLKMGM KBMPHALHHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6769580", Offset = "0x6768180", VA = "0x186769580", Slot = "4")]
	public void CHCBBHAMLEL(AJPBPBCKEJN JPDKKBHBPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6769BF0", Offset = "0x67687F0", VA = "0x186769BF0")]
	private Vector2 JJBCEKFOCDO(Vector2 NFIODMIOOOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6768470", Offset = "0x6767070", VA = "0x186768470", Slot = "5")]
	public void CAEGABAHDAL(CLAMMCFGNOO KBMPHALHHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6768120", Offset = "0x6766D20", VA = "0x186768120")]
	private void AGFEEJIKHKL(CLAMMCFGNOO HIKJNFPCLJF, KHMDJPEHGBK KBMJOFJNPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6769C50", Offset = "0x6768850", VA = "0x186769C50")]
	private void OFLGCKAEAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x676A060", Offset = "0x6768C60", VA = "0x18676A060")]
	public JKOJGCHGPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6769A30", Offset = "0x6768630", VA = "0x186769A30")]
	[CompilerGenerated]
	internal static (float, float) EHDDGOBGHOD(float CEBMFEAHHKJ)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6769B80", Offset = "0x6768780", VA = "0x186769B80")]
	[CompilerGenerated]
	internal static Vector4 HPOOAEEBCFI(Vector2 DFPHDEDIHFK, Vector2 IADPMFLONGE)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NGCBEGIHFDJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private MaterialPropertyBlock GIJMMCHANNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Color? GHEOAADIGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Color? OFFNGGNLABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Color? BNNJDGKLOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Color? BOGNLDDLOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Color OEADNEGKEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Color BKPKHPEKJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Color CHABIODGIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Texture2D EGMMCIHPDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Texture2D KPGILLIGDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Dictionary<ENGBGEDJDLP, int> JMGMPJKEBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private PJCPHABLHKP[] JOHHDBMOKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private EAOGGLFPFIF[] AHCMOLNDCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4[] KJGPJPAMGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4[] COBFKOKFGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4[] OLLGEMGDJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector4[] BKCHAMMOGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Vector4[] NCOLBDJMALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public Vector4[] NMFOCCKHNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private List<Texture2D> GMAMNOGAEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Vector4[] OLNKAEBEBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private List<Texture2D> JNDNDMLGDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private float[] MLFGPJKEFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private Vector4[] CCEKOEEKIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private float[] ODACNIKJFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public float[] JMJKDEKGEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private List<Texture2D> MABPHLJEDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private float[] DDNJLLMGELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private List<Texture2D> ONGLBPNCBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Vector4[] OIBIHCPGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private float[] EKGNOFDDHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private Vector4[] CHKBKNLOIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float[] FJCACGPLDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Texture2DArray JBNEOJIHHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Texture2DArray AEOMEJLNOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Texture2DArray EEDOBJKMCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public Texture2DArray LKCBGBKOMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool HGOMNFLCGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private int HCMKAFLJHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private Vector2? IGNEFDJLFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private TextureFormat IMKIFCBPBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private Vector2? MFOMFEIPCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private TextureFormat FAGHJAHBAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private Vector2? MMMLAEOMDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private TextureFormat PBJNGPHCJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Vector2? JOKLDHPPBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private TextureFormat CDKOBIKKPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private bool JAMLMCMFMMA;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int POMBONENMJA;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int BEKLPPGFCOA;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int NOHFDIDKCEP;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int KNBPJNNPIEK;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int MEECGOAFMHD;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int OPJFDOBOLEA;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int HMEINADHLAD;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int AHNCBHEBDKG;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int GFDOPKHDECJ;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int PAFAICLGMIN;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int BBPMLEDIOGM;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int ACJDLEEEOLN;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int FKGLFKCJGON;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int HMOJGOMHMND;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int DILFDJEHJJP;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int JCMKFGHINBI;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int IKLKIABKNID;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static int GLHOPIJLFEM;

	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private static int MMONIFJEBHG;

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static int LGNPKNMEEAP;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6780720", Offset = "0x677F320", VA = "0x186780720")]
	private NGCBEGIHFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6780660", Offset = "0x677F260", VA = "0x186780660")]
	public NGCBEGIHFDJ(Color LIFCJEOIDDM, Color GMJMIMHBDGM, Color NKEBJHPEGAN, Color? CNHEHPHHDGE, Color? FJKCGKADNAI, Color? MNDKIAFHHAM, Texture2D AMIFADDGNBB, Texture2D NPJMMFNJEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6780150", Offset = "0x677ED50", VA = "0x186780150")]
	internal int MNPDOGFFCAC(Material HFCCHCOBJKH, PJCPHABLHKP HMOFJCGFIFP, EAOGGLFPFIF JDPJJJHGHPJ, BHNAMMMFFGC OIAOOOECAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6780240", Offset = "0x677EE40", VA = "0x186780240")]
	private int MNPDOGFFCAC(ENGBGEDJDLP DPHIOKCFMFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x677E5E0", Offset = "0x677D1E0", VA = "0x18677E5E0")]
	internal int HNCOEMBKNNN(Material HFCCHCOBJKH, Color CLJELFDEHHE, Color LLNEFDINILF, Color CHECCABIMEA, Color LOAOOLKLPCL, Color BHCFKONNFOC, Texture2D EHFECGMLOMA, Vector4 GNOIMAANLEP, Texture2D ABIDBHPHJFN, Vector4 DHICKIGOHBL, float ADEHCGEKBDB, float FPMCFMCGGOF, Texture2D GHJLKHBNDLD, Vector4 FNLBAGACEBP, float ADBGHBCFLFP, Texture2D PLDEFCEMBJF, Color IPOAGAKBJHA, Vector4 PKMEPAKDHPP, PJCPHABLHKP HMOFJCGFIFP, EAOGGLFPFIF JDPJJJHGHPJ, BHNAMMMFFGC OIAOOOECAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x677DFE0", Offset = "0x677CBE0", VA = "0x18677DFE0")]
	private void ADCHIABLFEP(List<Texture2D> GMAMNOGAEBB, [Out] Texture2DArray DAKNCENEPEA, [Out] Texture2DArray JDHFHMFFKMP, [Out] Texture2DArray PBGPAKPFGCN, [Out] Texture2DArray OIBMLFIFDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x677E450", Offset = "0x677D050", VA = "0x18677E450")]
	public void DKBLNLCCFOB(Shader EHKADOEKOGM, Renderer KKNFDPNGCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x677F2B0", Offset = "0x677DEB0", VA = "0x18677F2B0")]
	private void IHNPKFJENKA(Shader EHKADOEKOGM, Renderer KKNFDPNGCFK, int DAHICKNNODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x677E250", Offset = "0x677CE50", VA = "0x18677E250")]
	private Color CAEDMMNIHKJ(Color DFMLOFOFBLN, PJCPHABLHKP BBCIHDOOABK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6780000", Offset = "0x677EC00", VA = "0x186780000")]
	private Color KINDFLCPNCO(Color HHIFKBALNJM, PJCPHABLHKP BBCIHDOOABK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x677F1B0", Offset = "0x677DDB0", VA = "0x18677F1B0")]
	private bool IBNEOGEKDGI(Texture2D AGHBFAJFPJK, EAOGGLFPFIF BFCBFHPBNPC, [Out] Texture2D FFFBFKKKEGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x677E1A0", Offset = "0x677CDA0", VA = "0x18677E1A0")]
	private void AGNGPEDINFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x677E5A0", Offset = "0x677D1A0", VA = "0x18677E5A0", Slot = "4")]
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
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private DPGGOBMNMNN? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public KAECHKCDNJH CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6777ED0", Offset = "0x6776AD0", VA = "0x186777ED0")]
			get
			{
				return default(KAECHKCDNJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public DPGGOBMNMNN MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x6777F20", Offset = "0x6776B20", VA = "0x186777F20")]
			get
			{
				return default(DPGGOBMNMNN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8431C0", Offset = "0x841DC0", VA = "0x1808431C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x851500", Offset = "0x850100", VA = "0x180851500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6777D10", Offset = "0x6776910", VA = "0x186777D10")]
		public Material[] JHNBKGNIJFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6777B50", Offset = "0x6776750", VA = "0x186777B50")]
		public static void FDNENBFMHEB(AvatarItemMaterial MHAOEEPALCG, Material MBCOMNNFJFG, int BOAHGJOJALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6777E00", Offset = "0x6776A00", VA = "0x186777E00")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[KPAMBFFNOBG]
public struct GDGOBAABJFJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[ReadOnly]
	public JIAECBCDBFM OBMNAEGOONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[ReadOnly]
	public int CLOPHPCHNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public LOBKMOBONGL HHLLGNCEHGI;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6779440", Offset = "0x6778040", VA = "0x186779440", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[KPAMBFFNOBG]
public struct LOBKMOBONGL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector3> IMGIBFMJKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector3> NLAKIACODEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector4> EBNICOCLCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> DHIDHBOGGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Vector2> MEDMABIAEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<Vector2> MIEOLMOMHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<Vector2> KJAOGCIEAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<Color> GFHANHALMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<int> LOHDJLMMHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<int> BMBHLEJIMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private NativeArray<int> BMFMGKAIMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private NativeArray<int> LHGBGFJDFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<int> JCBGHBPFKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<int> KOPGHBMKNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<int> DAMEGLMPCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<BoneWeight> HMBAOFADEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private NativeArray<int> ENFOCCMDNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private bool KLFALJOMPLF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int AGAMJGOCDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x677D770", Offset = "0x677C370", VA = "0x18677D770")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x677D780", Offset = "0x677C380", VA = "0x18677D780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int NABHMHPMAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x677D5F0", Offset = "0x677C1F0", VA = "0x18677D5F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x677D130", Offset = "0x677BD30", VA = "0x18677D130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int CDJJFAHCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x677D790", Offset = "0x677C390", VA = "0x18677D790")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x677CDA0", Offset = "0x677B9A0", VA = "0x18677CDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x677D7F0", Offset = "0x677C3F0", VA = "0x18677D7F0")]
	public LOBKMOBONGL(int IPFIILKFJCO, int DKOEAAGFEDL, int IHJDBGAGKMG, int OMIGHHHAPOG, Allocator BLMBIIGOJPG, int DDBIEIBFIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x677D580", Offset = "0x677C180", VA = "0x18677D580")]
	public void IHEGKBEHJLL(int OPDMGNJCACB, Vector3 BGNEHGMDHMD, Vector3 LGIJFEHDJIO, Vector4 NEAJEANMBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x677CDE0", Offset = "0x677B9E0", VA = "0x18677CDE0")]
	public void DLEFLGOEJOI(int OPDMGNJCACB, BoneWeight FOFINEOPMHL, NativeSlice<byte> AFNAAHCEKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x677D490", Offset = "0x677C090", VA = "0x18677D490")]
	public Color HENAJEFMNII(int OPDMGNJCACB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x677D560", Offset = "0x677C160", VA = "0x18677D560")]
	public void IEOLCHODNIL(int OPDMGNJCACB, Color PIIKINJOJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x677D7A0", Offset = "0x677C3A0", VA = "0x18677D7A0")]
	public void OJPFCPLFMBI(byte PGFBBGLHBMF, int OPDMGNJCACB, Vector2 DMDMOCABFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x677D760", Offset = "0x677C360", VA = "0x18677D760")]
	public void LOIDGJAFDFD(int OPDMGNJCACB, int DDCNOBKIDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x677CDB0", Offset = "0x677B9B0", VA = "0x18677CDB0")]
	public bool BNECDJOCPCJ(int PGFBBGLHBMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x677D600", Offset = "0x677C200", VA = "0x18677D600")]
	public void LGKDIGCPADN(int AGAAAFAEGCB, int MANKJHLJMBO, int JKBHNDINMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x677D4B0", Offset = "0x677C0B0", VA = "0x18677D4B0")]
	public int[] HNFBGCPCJNB(int AGAAAFAEGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x677D6D0", Offset = "0x677C2D0", VA = "0x18677D6D0")]
	private NativeSlice<int> LLMMGFBIBOM(int AGAAAFAEGCB)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x677CF80", Offset = "0x677BB80", VA = "0x18677CF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x677D140", Offset = "0x677BD40", VA = "0x18677D140")]
	public Mesh GNMBBAGPOPA([Optional] string DPMDKEPNEIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[NativeContainer]
[DefaultMember("Item")]
[KPAMBFFNOBG]
public struct JIAECBCDBFM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector3> IMGIBFMJKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector3> NLAKIACODEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector4> EBNICOCLCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector2> DHIDHBOGGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Vector2> MEDMABIAEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector2> MIEOLMOMHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector2> KJAOGCIEAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Color> GFHANHALMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> PDHEDDCPEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> PCNAMDJJHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> HNNNPIHIKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<int> JCIEJPDEHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<bool> NMINCIONGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> FLDKMDEHOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> DOCEOGJCFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<BoneWeight> MLLHNGGJHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<Matrix4x4> LIDFLMANAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<int> KEKAMPGOFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<byte> CMABICPIEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> AGCOCFOBFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private NativeArray<int> PDIACHEEIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<sbyte> BIADHEOPMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<byte> PDEMPIICDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private NativeArray<int> OLGMPBJIKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private bool KLFALJOMPLF;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int ENFOLADMNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int NHHLKBFEJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xFFA810", Offset = "0xFF9410", VA = "0x180FFA810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int DDCMLFLPDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x677B320", Offset = "0x6779F20", VA = "0x18677B320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int BEKNDGJLMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x677ACF0", Offset = "0x67798F0", VA = "0x18677ACF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x677ADE0", Offset = "0x67799E0", VA = "0x18677ADE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int AGAMJGOCDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x677B370", Offset = "0x6779F70", VA = "0x18677B370")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x677B380", Offset = "0x6779F80", VA = "0x18677B380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int IEJJOCNBJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x677AA80", Offset = "0x6779680", VA = "0x18677AA80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x677AD00", Offset = "0x6779900", VA = "0x18677AD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MCCPHDBNPAI DHODOMPICCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x677B390", Offset = "0x6779F90", VA = "0x18677B390")]
		get
		{
			return default(MCCPHDBNPAI);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x677B310", Offset = "0x6779F10", VA = "0x18677B310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte NIADLJOAECN
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x677B350", Offset = "0x6779F50", VA = "0x18677B350")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x677B360", Offset = "0x6779F60", VA = "0x18677B360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LMJALPNAIPM ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x677ADF0", Offset = "0x67799F0", VA = "0x18677ADF0")]
		get
		{
			return default(LMJALPNAIPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x677B3A0", Offset = "0x6779FA0", VA = "0x18677B3A0")]
	public JIAECBCDBFM(IList<Mesh> ALHNEGKLCIP, IList<Matrix4x4> PGCPKEHGGDD, IList<bool> NMINCIONGOF, byte POKIPIOBFBK, IList<byte[]> HMONCEGAKFA, IList<int> IBDMGFEDJBL, IList<bool> IHGHCGCAKFE, IList<int> FLDKMDEHOEO, IList<int> BKANEMKBDCB, IList<int> DEKFHBLHEMJ, Allocator BLMBIIGOJPG, MCCPHDBNPAI JGFOGMPNAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x677AD10", Offset = "0x6779910", VA = "0x18677AD10")]
	public LOBKMOBONGL HAOIEFGOLPE(Allocator BLMBIIGOJPG)
	{
		return default(LOBKMOBONGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x677AA90", Offset = "0x6779690", VA = "0x18677AA90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[KPAMBFFNOBG]
public class KDNOJEBPFAP : EOPPMDLKMKC
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x677CCB0", Offset = "0x677B8B0", VA = "0x18677CCB0")]
	public JIAECBCDBFM AHCKJECMKAI()
	{
		return default(JIAECBCDBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x676A2F0", Offset = "0x6768EF0", VA = "0x18676A2F0")]
	public KDNOJEBPFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct LMJALPNAIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Vector3> IMGIBFMJKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<Vector3> NLAKIACODEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<Vector4> EBNICOCLCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<Vector2> DHIDHBOGGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<Vector2> MEDMABIAEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeSlice<Vector2> MIEOLMOMHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<Vector2> KJAOGCIEAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<Color> GFHANHALMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<int> BKDKHCPEMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<int> JCIEJPDEHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<BoneWeight> MLLHNGGJHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<byte> ANJMDDPIJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public int APCLFENOJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public Matrix4x4 FONOGAAMDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public int DMGDAAPIACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<byte> AFNAAHCEKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public bool GMIEHBNFPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public int BCOGPKNCFFL;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct ENGBGEDJDLP : IEquatable<ENGBGEDJDLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	internal readonly Material AFDBCPGONJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	internal readonly PJCPHABLHKP CDILBFOEDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	internal readonly EAOGGLFPFIF AGKNHHHKNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	internal readonly BHNAMMMFFGC AIJPPOLNOIO;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA1B000", Offset = "0xA19C00", VA = "0x180A1B000")]
	public ENGBGEDJDLP(Material MBCOMNNFJFG, PJCPHABLHKP HMOFJCGFIFP, EAOGGLFPFIF JDPJJJHGHPJ, BHNAMMMFFGC OIAOOOECAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6778170", Offset = "0x6776D70", VA = "0x186778170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA1AD50", Offset = "0xA19950", VA = "0x180A1AD50", Slot = "4")]
	public bool Equals(ENGBGEDJDLP OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6777FE0", Offset = "0x6776BE0", VA = "0x186777FE0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x67780D0", Offset = "0x6776CD0", VA = "0x1867780D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JGCOIDNLEDG
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class AOIAKOFJENH : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public AOIAKOFJENH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA22620", Offset = "0xA21220", VA = "0x180A22620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6777B00", Offset = "0x6776700", VA = "0x186777B00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	public static void AAGIAJPABCD(string EPKGPGILADI, int ICDAEIIIEFB, long HHAKOBIMPKN, long KLHBJNMDHLK, long NHNIJEONBLM, long JKKIKJNLNDF, long EGDHGEMIOHE, long DMEKCLNABOL, long EFHCICJLDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x677A930", Offset = "0x6779530", VA = "0x18677A930")]
	public static GNHKJFLENJL MDBIFDPININ(JobHandle MJIJAMNDLLK, bool MILHHIOALBA, bool PGOKKBJPDHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x677A8C0", Offset = "0x67794C0", VA = "0x18677A8C0")]
	[IteratorStateMachine(typeof(AOIAKOFJENH))]
	private static IEnumerator<OGKGDFEHPGC> IEPJBOKFJIK(JobHandle POAHFHMMEAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class EOAHCLMAIJD : OMKKDGMGOAD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private LPGJBIJPEIO IGICHPBFFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private JDDLAJCAJNC APJFMKPPMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private IRecRoomQualityConfigProvider FOKNPDLLIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private bool KLFALJOMPLF;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x67788C0", Offset = "0x67774C0", VA = "0x1867788C0")]
	[FJJFAIMPJIC(JBEKPLNNIEC.GameOnly)]
	private static void JPDDIPCAKKO(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5ACBA20", Offset = "0x5ACA620", VA = "0x185ACBA20")]
	[UnityEngine.Scripting.Preserve]
	public EOAHCLMAIJD([GOICEJLKLIB(null)] JDDLAJCAJNC GJCIGHPLCBL, [GOICEJLKLIB(null)] LPGJBIJPEIO OPADPIBAOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x67789B0", Offset = "0x67775B0", VA = "0x1867789B0")]
	private void MLMIGHIBJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x67783A0", Offset = "0x6776FA0", VA = "0x1867783A0", Slot = "4")]
	public void CJCKOJMAGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6778400", Offset = "0x6777000", VA = "0x186778400", Slot = "5")]
	public OBOGMAPJNLF<Texture2D> GGNBFAIAIPL(CHECCMHAHDJ BPOBDKCGNFC, [Optional] HODPMKGAFIK ENFOCCMDNKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6778A20", Offset = "0x6777620", VA = "0x186778A20")]
	private uint PDBNHIAABKJ(CHECCMHAHDJ BPOBDKCGNFC, HODPMKGAFIK ENFOCCMDNKP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BIBJCGEPPHH
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBINENPFJDC(Mesh AIKMKIOPGIF, Matrix4x4 BFNNMDHBOEG, byte[] AFNAAHCEKJG, bool JFFBLBEENCM = false, OCPDNKAOFCI.LFAEFIBNIJB FMOIIHAOCMP = (OCPDNKAOFCI.LFAEFIBNIJB)0, int FLDKMDEHOEO = -1, bool NMINCIONGOF = false);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLCEACIPFON(Allocator BLMBIIGOJPG, MCCPHDBNPAI JGFOGMPNAFM, byte POKIPIOBFBK, [Optional] IList<int> BKANEMKBDCB, [Optional] IList<int> GIHIIOAJLFA);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct ODEJKAFNGNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public readonly GameObject NFFIDCOMGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly AvatarItemMaterial MPECIBINFKB;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
	public ODEJKAFNGNC(GameObject NFFIDCOMGHO, AvatarItemMaterial MPECIBINFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x67817D0", Offset = "0x67803D0", VA = "0x1867817D0")]
	public void CDKMFIODDGH(Material MBCOMNNFJFG, int BOAHGJOJALD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class OFFFNJHIAJL : LGLOBCOFOMM<Task<(GameObject, AvatarItemMaterial)>, ODEJKAFNGNC>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct HKBIBPFBLNE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x677A350", Offset = "0x6778F50", VA = "0x18677A350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x677A850", Offset = "0x6779450", VA = "0x18677A850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private OBOGMAPJNLF<GameObject> HBCJPAILCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private OBOGMAPJNLF<AvatarItemMaterial> GAJFEEEOMPI;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6782040", Offset = "0x6780C40", VA = "0x186782040")]
	private OFFFNJHIAJL(Task<(GameObject, AvatarItemMaterial)> HPIAAAJAFJD, OBOGMAPJNLF<GameObject> FIEBMIIKODM, OBOGMAPJNLF<AvatarItemMaterial> AIDNFOEDNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6781C30", Offset = "0x6780830", VA = "0x186781C30")]
	public static OFFFNJHIAJL GADNMLFOLLL(AssetReference AKOIADBFHKB, [Optional] AssetReference KPJELJGGEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6781A60", Offset = "0x6780660", VA = "0x186781A60", Slot = "11")]
	protected override ODEJKAFNGNC CEIMIANEIHK(Task<(GameObject, AvatarItemMaterial)> PCPOPIJAJCI)
	{
		return default(ODEJKAFNGNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x67819E0", Offset = "0x67805E0", VA = "0x1867819E0", Slot = "12")]
	protected override void BHGHIILGJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6781B00", Offset = "0x6780700", VA = "0x186781B00")]
	[AsyncStateMachine(typeof(HKBIBPFBLNE))]
	private static Task<(GameObject, AvatarItemMaterial)> EGOMIACCAOJ(Task<GameObject> HBNGOKACNEI, Task<AvatarItemMaterial> ONGGNOEOCMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class NKDPKLCJFEC : LGLOBCOFOMM<Task<(Material, MaterialMapAsset)>, Material>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class OPBDAIDMDOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public Material mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public MaterialEntry entry;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public OPBDAIDMDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x67820D0", Offset = "0x6780CD0", VA = "0x1867820D0")]
		internal object DFFBOCGGKCL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class PGCKFMCFGIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public string shaderNameToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public OPBDAIDMDOF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public PGCKFMCFGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x67823A0", Offset = "0x6780FA0", VA = "0x1867823A0")]
		internal object PNFNLJOAHGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6782140", Offset = "0x6780D40", VA = "0x186782140")]
		internal object FMKANMDFBPE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OOJANHAADKG<T1, T2> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public AsyncTaskMethodBuilder<(T1, T2)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private T1 <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<T1> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter<T2> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4654C80", Offset = "0x4653880", VA = "0x184654C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4655320", Offset = "0x4653F20", VA = "0x184655320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private OBOGMAPJNLF<Material> CFFEEONOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private OBOGMAPJNLF<MaterialMapAsset> GDJBFIAAMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private bool NECNAOLIFDH;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6781220", Offset = "0x677FE20", VA = "0x186781220")]
	public static NKDPKLCJFEC CPOPNFCDBAP(AssetReference BPOJNEPNMOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6781460", Offset = "0x6780060", VA = "0x186781460")]
	private static OBOGMAPJNLF<MaterialMapAsset> JKKINMJGAMA(AssetReference BPOJNEPNMOH, [Out] bool NECNAOLIFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6781740", Offset = "0x6780340", VA = "0x186781740")]
	private NKDPKLCJFEC(Task<(Material, MaterialMapAsset)> HPIAAAJAFJD, OBOGMAPJNLF<Material> CFFEEONOFIO, OBOGMAPJNLF<MaterialMapAsset> JOJDNACGMLI, bool NECNAOLIFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6781040", Offset = "0x677FC40", VA = "0x186781040", Slot = "11")]
	protected override Material CEIMIANEIHK(Task<(Material, MaterialMapAsset)> PCPOPIJAJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6780C10", Offset = "0x677F810", VA = "0x186780C10")]
	private void AJJIMNBCCIP(Material JPIJFFCOHKA, MaterialMapAsset KIGGFALNMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6780FE0", Offset = "0x677FBE0", VA = "0x186780FE0", Slot = "12")]
	protected override void BHGHIILGJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0E80", Offset = "0x2C9FA80", VA = "0x182CA0E80")]
	[AsyncStateMachine(typeof(OOJANHAADKG<, >))]
	private static Task<(T1, T2)> EGKFHKEBFPB<T1, T2>(Task<T1> GDLBELEEHLP, Task<T2> NGAEFHFOPCG)
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
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6782600", Offset = "0x6781200", VA = "0x186782600")]
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
		private struct MLBDPFPJIMN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public AsyncTaskMethodBuilder<OFIAGAGHOCM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private TaskAwaiter<OFIAGAGHOCM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x677DC30", Offset = "0x677C830", VA = "0x18677DC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x677DF70", Offset = "0x677CB70", VA = "0x18677DF70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private Dictionary<EPAIPDBBJOB, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private Dictionary<EPAIPDBBJOB, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private Dictionary<EPAIPDBBJOB, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private Dictionary<EPAIPDBBJOB, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private readonly Dictionary<EPAIPDBBJOB, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private OFIAGAGHOCM _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6779410", Offset = "0x6778010", VA = "0x186779410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6779290", Offset = "0x6777E90", VA = "0x186779290")]
		public OFIAGAGHOCM PAEDEBIBMDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6779160", Offset = "0x6777D60", VA = "0x186779160")]
		[AsyncStateMachine(typeof(MLBDPFPJIMN))]
		public Task<OFIAGAGHOCM> KDBEEJJCLMC(int ALAJJGGMMKO, int FKKMNKGGIHC, int EMJCPICLAFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x67792E0", Offset = "0x6777EE0", VA = "0x1867792E0")]
		public NoseFaceOption PMBEIGEBMPG(int GIFICBGCBCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6778FE0", Offset = "0x6777BE0", VA = "0x186778FE0")]
		public SelectableFaceOption FDOOEBEPKNA(FaceFeatureType HBFBJIHKKNO, EPAIPDBBJOB GELKFABCEBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6778F60", Offset = "0x6777B60", VA = "0x186778F60")]
		public int EILLBHPMJLK(EPAIPDBBJOB GELKFABCEBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6778D30", Offset = "0x6777930", VA = "0x186778D30")]
		private void EHDEKIEAGMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B00980", Offset = "0x2AFF580", VA = "0x182B00980")]
		private void AKHDFFFBKBN<T>(IDictionary<EPAIPDBBJOB, T> JBCLENIHHPE, IReadOnlyList<T> ADOOBIKKOGO) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6778C80", Offset = "0x6777880", VA = "0x186778C80")]
		public EPAIPDBBJOB DJNAKHLGOGI(FaceFeatureType HBFBJIHKKNO)
		{
			return default(EPAIPDBBJOB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6778B60", Offset = "0x6777760", VA = "0x186778B60")]
		public EPAIPDBBJOB CJFPNFINPJN(FaceFeatureType HBFBJIHKKNO)
		{
			return default(EPAIPDBBJOB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6779380", Offset = "0x6777F80", VA = "0x186779380")]
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
